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
using java.io. /* a comment withing a qualified name*/File;
using java.util.logging.Level;
using /* Before a qualified name */ java.util.logging.Logger;
using javax.xml.transform.Result;
using javax.xml.transform.Source;
using javax.xml.transform.Transformer;
using javax.xml.transform.TransformerException;
using javax.xml.transform.TransformerFactory;
using javax.xml.transform.sax.SAXSource;
using javax.xml.transform.stream.StreamResult;
using org.xml.sax.InputSource;

namespace javasharp
{
    /**
     *
     * @author PvO
     */    public class Tool
    {
        private void convertJavaToXmlSyntaxTree(String javaSourceFile, String xmlOutputFile)
        {
            try
            {
                Transformer transformer = TransformerFactory.newInstance().newTransformer();
                SyntaxTreeXmlFilter xmlEmitter = new SyntaxTreeXmlFilter();
                Source source = new SAXSource(xmlEmitter, new InputSource(javaSourceFile));
                Result result = new StreamResult(new File(xmlOutputFile));
                transformer.transform(source, result);
            }
            catch (TransformerException ex)
            {
                Logger.getLogger(Tool.class         .

        getName() ) .
        log(Level.SEVERE,  null , ex);
    }
}

public static void main(String[] args)
{
    {
        IF | if
    }

    (args.length
    {
        EQUAL |= =
    }

    {
        IntegerLiteral | 2
    } )

    {
        Tool tool = new Tool();
        String javaInputFile = args[
        {
            IntegerLiteral | 0
        } ]

        ;
        String xmlOutputFile = args[
        {
            IntegerLiteral | 1
        } ]

        ;
        tool.convertJavaToXmlSyntaxTree(javaInputFile, xmlOutputFile);
    }

    {
        ELSE |
         else
    }

    {
        System.err.println("2 arguments required: <java input file> <xml output file>");
        System.exit(
        {
            IntegerLiteral | 1
        } )

        ;
    }
} } }
// Comment at the end of the file
/* Just to verify that it is included in the xml version of the AST */
