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

            var reader = XmlReader.Create(System.IO.File.OpenRead(@"D:\workspace\JavaSharp\JavaSharp\src\main\java\javasharp\Tool.xml"));
            XmlWriter writer = XmlWriter.Create(Console.Out);
            new JavaAstReader.JavaAstPreprocessor().PrepareJavaAst(reader, writer);


            //            CompilationUnitSyntax cu = SyntaxFactory.ParseCompilationUnit(@"
            //using System;
            //using System.Xml.Ble.Bla;

            //namespace Foo.Bar.Baz
            //{
            //}
            //", options: new CSharpParseOptions(kind: SourceCodeKind.Regular));

            //            var translator = new JavaAstReader.JavaSharpTranslator();
            //            var xDoc = XDocument.Load(reader, LoadOptions.PreserveWhitespace);
            //            SyntaxTree syntaxTree = translator.Translate(xDoc);
            //            Console.WriteLine(syntaxTree.GetText());

            Console.ReadKey();
        }
    }
}
