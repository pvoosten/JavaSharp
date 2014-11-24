using Microsoft.CodeAnalysis;
using System;
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
            var translator = new JavaAstReader.JavaSharpTranslator();
            var reader = XmlReader.Create(System.IO.File.OpenRead(@"D:\workspace\JavaSharp\JavaSharp\src\main\java\javasharp\Tool.xml"));
            var xDoc = XDocument.Load(reader, LoadOptions.PreserveWhitespace);
            SyntaxTree syntaxTree = translator.Translate(xDoc);
            Console.WriteLine(syntaxTree.GetText());
            Console.ReadKey();
        }
    }
}
