/*
 * JavaSharp, a free Java to C# translator based on ANTLRv4
 * Copyright (C) 2014-2015  Philip van Oosten
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
package javasharp;

import java.io./* a comment withing a qualified name*/File;
import java.util.logging.Level/* after a qualified name */;
import /* Before a qualified name */ java.util.logging.Logger;
import javax.xml.transform.Result; // added white space within qualified name on purpose
import javax.xml.transform.Source;
import javax.xml.transform.Transformer;
import javax.xml.transform.TransformerException;
import javax.xml.transform.TransformerFactory;
import javax.xml.transform.sax.SAXSource;
import javax.xml.transform.stream.StreamResult;
import org.xml.sax.InputSource;

/**
 *
 * @author PvO
 */
public class Tool {

    private void convertJavaToXmlSyntaxTree(String javaSourceFile, String xmlOutputFile) {
        try {
            Transformer transformer = TransformerFactory.newInstance().newTransformer();
            SyntaxTreeXmlFilter xmlEmitter = new SyntaxTreeXmlFilter();
            Source source = new SAXSource(xmlEmitter, new InputSource(javaSourceFile));
            Result result = new StreamResult(new File(xmlOutputFile));
            transformer.transform(source, result);
        } catch (TransformerException ex) {
            Logger.getLogger(Tool.class.getName()).log(Level.SEVERE, null, ex);
        }
    }

    public static void main(String[] args) throws Exception {
        if (args.length == 2) {
            Tool tool = new Tool();
            String javaInputFile = args[0];
            String xmlOutputFile = args[1];
            tool.convertJavaToXmlSyntaxTree(javaInputFile, xmlOutputFile);
        } else {
            System.err.println("2 arguments required: <java input file> <xml output file>");
            System.exit(1);
        }
    }
}

// Comment at the end of the file
/* Just to verify that it is included in the xml version of the AST */
