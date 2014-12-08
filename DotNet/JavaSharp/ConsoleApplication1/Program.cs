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

        private const int ERROR_CONTEXT_LINES = 2;

        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.Error.WriteLine("Expected 2 parameters: <java ast xml file> <c sharp target file>");
                return;
            }

            string javaAstFile = args[0];
            string csFile = args[1];

            var reader = XmlReader.Create(System.IO.File.OpenRead(javaAstFile));
            using (MemoryStream stream = new MemoryStream())
            { 
                try
                {
                    XmlWriter writer = XmlWriter.Create(stream);
                    new JavaAstReader.JavaAstPreprocessor().PrepareJavaAst(reader, writer);
                    var newStream = new MemoryStream(stream.GetBuffer());
                    newStream.SetLength(stream.Length);
                    XDocument preprocessedJava = XDocument.Load(newStream);
                    SyntaxTree tree = SyntaxFactory.ParseSyntaxTree(preprocessedJava.Document.Root.Value);
                    var root = tree.GetRoot().NormalizeWhitespace();
                    tree = SyntaxFactory.SyntaxTree(root);
                    File.WriteAllText(csFile, tree.GetText().ToString());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(javaAstFile + " ==> " + csFile);
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.StackTrace);
                    Console.WriteLine(string.Join("\n", ex.Data.Keys.Cast<object>()
                        .Select(k => "[" + k + "]: " + ex.Data[k])));
                    XmlException xmlEx = ex as XmlException;
                    if (xmlEx != null)
                    {
                        var lines = File.ReadAllLines(javaAstFile);
                        int startLine = Math.Max(0, xmlEx.LineNumber - ERROR_CONTEXT_LINES);
                        int endLine = Math.Min(lines.Length - 1, xmlEx.LineNumber + ERROR_CONTEXT_LINES);
                        for (int i = startLine; i <= endLine; i++)
                        {
                            Console.WriteLine("" + i + "\t" + lines[i]);
                        }
                    }
                }
            }
        }
    }
}
