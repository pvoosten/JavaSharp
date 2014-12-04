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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Xsl;

namespace JavaAstReader
{
    /// <summary>
    /// Transforms the Java AST into a form that is more easy to turn into a CSharp AST.
    /// </summary>
    public class JavaAstPreprocessor
    {

        private XslCompiledTransform xslt;

        public JavaAstPreprocessor()
        {
            string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
            path = System.IO.Path.GetDirectoryName(path);
            path = System.IO.Path.Combine(path, "JavaAstPreprocessor.xslt");
            xslt = new XslCompiledTransform();
            xslt.Load(path);
        }

        public void PrepareJavaAst(string inputUri, string resultsFile)
        {
            xslt.Transform(inputUri, resultsFile);
        }

        public void PrepareJavaAst(XmlReader xmlReader, XmlWriter xmlWriter)
        {
            XsltArgumentList args = new XsltArgumentList();    
            xslt.Transform(xmlReader, xmlWriter);
        }
    }
}
