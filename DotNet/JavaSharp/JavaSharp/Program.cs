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
using System.IO;

namespace JavaSharp
{
    class Program
    {


        static void Main(string[] args)
        {
            string javaCsFile, csFile;
            if (args.Length == 1)
            {
                javaCsFile = WithExtension(args[0], ".java.cs");
                csFile = WithExtension(args[0], ".cs");
            }
            else if (args.Length != 2)
            {
                Console.Error.WriteLine("Expected 2 parameters: <java.cs file> <c sharp target file>");
                return;
            }
            else
            {
                javaCsFile = WithExtension(args[0], ".java.cs");
                csFile = WithExtension(args[1], ".cs");
            }

            if (!File.Exists(javaCsFile))
            {
                Console.Error.WriteLine("File " + javaCsFile + " not found");
            }

            try
            {
                string javaCsContent = File.ReadAllText(javaCsFile);
                SyntaxTree tree = SyntaxFactory.ParseSyntaxTree(javaCsContent);
                var root = tree.GetRoot().NormalizeWhitespace();
                ITreeTransformer syntaxProcessor = new SyntaxProcessor();
                root = syntaxProcessor.Transform(root);
                tree = SyntaxFactory.SyntaxTree(root);
                File.WriteAllText(csFile, tree.GetText().ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(javaCsFile + " ==> " + csFile);
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(string.Join("\n", ex.Data.Keys.Cast<object>()
                    .Select(k => "[" + k + "]: " + ex.Data[k])));
            }
        }

        private static string WithExtension(string filename, string extension)
        {
            string directory = Path.GetDirectoryName(filename);
            string withoutExtension = Path.GetFileNameWithoutExtension(filename);
            withoutExtension = Path.ChangeExtension(withoutExtension, null);
            return Path.Combine(directory, Path.ChangeExtension(withoutExtension, extension));
        }
    }
}
