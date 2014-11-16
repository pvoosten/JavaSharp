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
package javasharp;

import java.io.File;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.xml.transform.Result;
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
        Tool tool = new Tool();
        String javaInputFile = "D:\\workspace\\JavaSharp\\JavaSharp\\src\\main\\java\\javasharp\\Tool.java";
        String xmlOutputFile = "D:\\workspace\\JavaSharp\\JavaSharp\\src\\main\\java\\javasharp\\Tool.xml";
        tool.convertJavaToXmlSyntaxTree(javaInputFile, xmlOutputFile);
    }
}

