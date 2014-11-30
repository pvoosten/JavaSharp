/*
 * JavaSharp, a free Java to C# translator based on ANTLRv4
 * Copyright (C) 2014  Philip van Oosten
 * 
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU Affero General Public License as
 * published by the Free Software Foundation, either version 3 of the
 * License, or (at your option) any later version.
 * 
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU Affero General Public License for more details.
 * 
 * You should have received a copy of the GNU Affero General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
 * 
 * https://github.com/pvoosten
 */
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
            CSharpSyntaxNode csSyntaxNode = cSharpContext;
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
                        identifiers.Add(SyntaxFactory.IdentifierName(elem.Value));
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

    static class Extensions
    {
        internal static T WithTrivia<T>(this T csNode,  XNode javaNode) where T : CSharpSyntaxNode
        {
            throw new NotImplementedException();
        }
    }
}
