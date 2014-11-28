using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using System.Xml.Linq;
using System;
using System.Linq;

namespace JavaAstReader
{

    /// <summary>
    /// Translates Java ASTs to C# ASTs.
    /// </summary>
    public class JavaSharpTranslator
    {
        public JavaSharpTranslator()
        {

        }


        public SyntaxTree Translate(XDocument javaSyntaxTreeDocument)
        {
            XElement root = javaSyntaxTreeDocument.Root;
            var cu = SyntaxFactory.CompilationUnit();
            if (root.Name == "CompilationUnit")
            {
                cu = TranslateCompilationUnit(root, cu);
            }
            return CSharpSyntaxTree.Create(cu);
        }

        private CompilationUnitSyntax TranslateCompilationUnit(XElement javaElement, CompilationUnitSyntax cSharpContext)
        {
            CSharpSyntaxNode csSyntaxNode = TranslateDefaults(javaElement, cSharpContext);
            javaElement.Element("PackageDeclaration");

            SyntaxList<UsingDirectiveSyntax> usings = new SyntaxList<UsingDirectiveSyntax>();
            foreach (XNode node in javaElement.Nodes())
            {
                // Java package declaration becomes C# name space, which is hierarchical
                // C# allows multiple name spaces per compilation unit, but that will not occur in translations from Java

                // Java import statements come after the package declaration, in C# the using statements are declared before the name space.
                if (node.NodeType == System.Xml.XmlNodeType.Element)
                {
                    var element = node as XElement;
                    switch (element.Name.LocalName)
                    {
                        case "PackageDeclaration":
                            var namespaceDeclaration = TranslatePackageDeclaration(element);
                            cSharpContext = cSharpContext.AddMembers(namespaceDeclaration);
                            csSyntaxNode = namespaceDeclaration;
                            break;
                        case "ImportDeclaration":
                            usings = usings.Add(TranslateImportDeclaration(element));
                            break;
                        case "TypeDeclaration":
                            break;
                        case "Symbol":
                            break;
                        case "Comment":
                            break;
                        case "LineComment":
                            break;
                        default:
                            throw new InvalidJavaSyntaxException(element);
                    }
                }
            }
            cSharpContext = cSharpContext.WithUsings(usings);
            return cSharpContext;
        }

        private UsingDirectiveSyntax TranslateImportDeclaration(XElement element)
        {
            NameSyntax nameSpaceName = SyntaxFactory.IdentifierName("Nop");
            foreach (XNode node in element.Nodes())
            {
                if (node.NodeType == System.Xml.XmlNodeType.Element)
                {
                    XElement elem = node as XElement;
                    if (elem.Name.LocalName == "QualifiedName")
                    {
                        nameSpaceName = TranslateQualifiedName(elem);
                    }
                }
            }
            return SyntaxFactory.UsingDirective(nameSpaceName);
        }

        private T TranslateDefaults<T>(XNode javaContext, T csharpContext) where T : CSharpSyntaxNode
        {
            int triviaCount = -1;
            SyntaxTriviaList trivias = new SyntaxTriviaList();
            XNode currentNode = javaContext;
            while (triviaCount < trivias.Count)
            {
                triviaCount = trivias.Count;
                if (javaContext.NodeType == System.Xml.XmlNodeType.Element)
                {
                    XElement javaElement = javaContext as XElement;
                    if (javaElement.Name.LocalName == "Comment")
                    {
                        trivias.Add(SyntaxFactory.SyntaxTrivia(SyntaxKind.MultiLineCommentTrivia, javaElement.Value));
                    }
                    else if (javaElement.Name.LocalName == "LineComment")
                    {
                        trivias.Add(SyntaxFactory.SyntaxTrivia(SyntaxKind.SingleLineCommentTrivia, javaElement.Value));
                    }
                }
                else if (javaContext.NodeType == System.Xml.XmlNodeType.SignificantWhitespace || javaContext.NodeType == System.Xml.XmlNodeType.Whitespace)
                {
                    trivias.Add(SyntaxFactory.SyntaxTrivia(SyntaxKind.WhitespaceTrivia, javaContext.ToString()));
                }
                currentNode = currentNode.NextNode;
            }
            T newNode = csharpContext;
            if (trivias.Count > 0)
            {
                newNode = newNode.WithTrailingTrivia(trivias);
            }
            return newNode;
        }

        private NamespaceDeclarationSyntax TranslatePackageDeclaration(XElement element)
        {
            var nameSpaceSyntax = SyntaxFactory.NamespaceDeclaration(SyntaxFactory.IdentifierName("DefaultNameSpace"));
            foreach (XNode node in element.Nodes())
            {
                if (node.NodeType == System.Xml.XmlNodeType.Element)
                {
                    XElement elem = node as XElement;
                    if (elem.Name.LocalName == "QualifiedName")
                    {
                        nameSpaceSyntax = SyntaxFactory.NamespaceDeclaration(TranslateQualifiedName(elem));
                    }
                }
            }
            return nameSpaceSyntax;
        }

        NameSyntax TranslateQualifiedName(XElement element)
        {
            List<IdentifierNameSyntax> identifiers = new List<IdentifierNameSyntax>();
            foreach (XNode node in element.Nodes())
            {
                if (node.NodeType == System.Xml.XmlNodeType.Element)
                {
                    XElement elem = node as XElement;
                    if (elem.Name.LocalName == "Symbol" && elem.FirstAttribute.Value == "Identifier")
                    {
                        var identifier = SyntaxFactory.IdentifierName(elem.Value);
                        identifier = TranslateDefaults(elem, identifier);
                        identifiers.Add(identifier);
                    }
                }
            }
            NameSyntax qualifiedName;
            if (identifiers.Count >= 2)
            {
                qualifiedName = SyntaxFactory.QualifiedName(identifiers[0], identifiers[1]);
                for (int i = 2; i <identifiers.Count; i++)
                {
                    qualifiedName = SyntaxFactory.QualifiedName(qualifiedName, identifiers[i]);
                }
            }
            else if (identifiers.Count == 1)
            {
                qualifiedName = identifiers[0];
            }
            else
            {
                return SyntaxFactory.ParseName("Default");
            }
            return qualifiedName;

        }
    }
}
