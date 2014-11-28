using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Runtime;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            CompilationUnitSyntax cu = SyntaxFactory.ParseCompilationUnit(@"
using System;
using System.Xml.Ble.Bla;

namespace Foo.Bar.Baz
{
}
", options: new CSharpParseOptions(kind: SourceCodeKind.Regular));


            var translator = new JavaAstReader.JavaSharpTranslator();
            var reader = XmlReader.Create(System.IO.File.OpenRead(@"D:\workspace\JavaSharp\JavaSharp\src\main\java\javasharp\Tool.xml"));
            var xDoc = XDocument.Load(reader, LoadOptions.PreserveWhitespace);
            SyntaxTree syntaxTree = translator.Translate(xDoc);
            Console.WriteLine(syntaxTree.GetText());
            Console.ReadKey();
        }
    }
}
