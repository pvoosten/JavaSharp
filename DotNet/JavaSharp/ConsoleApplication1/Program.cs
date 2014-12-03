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
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var reader = XmlReader.Create(System.IO.File.OpenRead(@"D:\workspace\JavaSharp\JavaSharp\src\main\java\javasharp\Tool.xml"));
            using (MemoryStream stream = new MemoryStream()) {
                XmlWriter writer = XmlWriter.Create(stream);
                new JavaAstReader.JavaAstPreprocessor().PrepareJavaAst(reader, writer);
                XDocument preprocessedJava = XDocument.Load(new MemoryStream(stream.GetBuffer()));
                SyntaxTree tree = SyntaxFactory.ParseSyntaxTree(preprocessedJava.Document.Root.Value);
                var root = tree.GetRoot().NormalizeWhitespace();
                tree = SyntaxFactory.SyntaxTree(root);
                Console.WriteLine(tree.GetText().ToString());
            }
            Console.ReadKey();
        }
    }
}
