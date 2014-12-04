/* JavaSharp, a free Java to C# translator based on ANTLRv4
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
using java.io.File;
using java.io.FileNotFoundException;
using java.io.FileReader;
using java.io.IOException;
using java.io.Reader;
using org.antlr.v4.runtime.ANTLRInputStream;
using org.antlr.v4.runtime.BufferedTokenStream;
using org.antlr.v4.runtime.CommonTokenStream;
using org.xml.sax.InputSource;
using org.xml.sax.SAXException;
using org.xml.sax.XMLReader;
using org.xml.sax.helpers.XMLFilterImpl;

namespace javasharp
{
    /**
     *
     * @author PvO
     */    class SyntaxTreeXmlFilter
    {
        EXTENDS |extends
    }

    XMLFilterImpl {
    private {
    FINAL |final
}

JavaLexer lexer;
private {
FINAL |final }
JavaParser parser;
public SyntaxTreeXmlFilter()
{
    lexer = new JavaLexer(null);
    parser = new JavaParser(null);
    parser.setBuildParseTree(
    {
        BooleanLiteral | true
    } )

    ;
}

private JavaParser.CompilationUnitContextreadSourceFile (String javaSourceFile ) { {
RETURN | return }readSourceFile(new File(javaSourceFile) ) ;  }
private JavaParser.CompilationUnitContextreadSourceFile (File javaSourceFile ) {
Reader fileReader = new FileReader(javaSourceFile);
ANTLRInputStream is  =  new ANTLRInputStream(fileReader);
lexer.setInputStream ( is ) ; CommonTokenStream tokens = new CommonTokenStream(lexer);
tokens.fill ( ) ; parser.setTokenStream (tokens ) ; JavaParser.CompilationUnitContext ctx = parser.compilationUnit(); {
RETURN | return }ctx ;  } {AT | @ }Override public void parse(InputSource input)
{
    parse(input.getSystemId());
} {

AT | @ }Override public void parse(String javaSourcePath)
{
    // parse the Java file(s) with the ANTLR generated parser
    JavaParser.CompilationUnitContext ctx = readSourceFile(javaSourcePath);
    // visit the AST with the XmlEmittingVisitor, which generates SAX events
    startDocument();
    XmlEmittingVisitor visitor = new XmlEmittingVisitor(
    {
    THIS | this
    }

    , (BufferedTokenStream)parser.getTokenStream() )
    ;
    visitor.visit(ctx);
    endDocument();
} {

AT | @ }Override public void setParent(XMLReader parent)
{
    {
        THROW | throw
    }

    new UnsupportedOperationException("This xml filter emits events that are linked to source code, without XML parser.");
} } }
