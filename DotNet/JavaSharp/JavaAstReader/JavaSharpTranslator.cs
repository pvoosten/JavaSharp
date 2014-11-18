using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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
                TranslateCompilationUnit(root, cu);
            }
            return CSharpSyntaxTree.Create(cu);
        }

        private void TranslateCompilationUnit(XElement javaElement, CompilationUnitSyntax cSharpContext)
        {
            foreach (XElement element in javaCompilationUnit.Descendants())
            {
                // TODO: package declaration becomes name space, which is hierarchical in C#, but there can be only one per compilation unit,
                // because that is a Java constraint.
                switch(element.Name.LocalName){
                    case "PackageDeclaration":
                        cSharpContext.AddMembers(SyntaxFactory.NamespaceDeclaration(SyntaxFactory.QualifiedName());
                        break;
                    case "ImportDeclaration":
                        break;
                    case "TypeDeclaration":
                        break;
                    default:
                        throw new InvalidJavaSyntaxException(element);
                        break;
                }
            }
        }
    }

    [Serializable]
    public class InvalidJavaSyntaxException : Exception
    {
        public InvalidJavaSyntaxException() { }
        public InvalidJavaSyntaxException(XElement child) : this(string.Format("Unexpected {0} child element of {1} element", child.Name.LocalName, child.Parent.Name.LocalName)) { }
        public InvalidJavaSyntaxException(string message) : base(message) { }
        public InvalidJavaSyntaxException(string message, Exception inner) : base(message, inner) { }
        protected InvalidJavaSyntaxException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }
}
