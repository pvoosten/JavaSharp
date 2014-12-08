/*
 *  JavaSharp, a free Java to C# translator based on ANTLRv4
 *  Copyright (C) 2014  Philip van Oosten
 * 
 *  This program is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU Affero General Public License as
 *  published by the Free Software Foundation, either version 3 of the
 *  License, or (at your option) any later version.
 * 
 *  This program is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU Affero General Public License for more details.
 * 
 *  You should have received a copy of the GNU Affero General Public License
 *  along with this program.  If not, see <http://www.gnu.org/licenses/>.
 * 
 *  https://github.com/pvoosten
 */
using java.util.List;
using java.util.logging.Level;
using java.util.logging.Logger;
using org.antlr.v4.runtime.BufferedTokenStream;
using org.antlr.v4.runtime.ParserRuleContext;
using org.antlr.v4.runtime.Token;
using org.antlr.v4.runtime.TokenSource;
using org.antlr.v4.runtime.tree.AbstractParseTreeVisitor;
using org.antlr.v4.runtime.tree.TerminalNode;
using org.xml.sax.Attributes;
using org.xml.sax.ContentHandler;
using org.xml.sax.SAXException;
using org.xml.sax.helpers.AttributesImpl;

namespace javasharp
{
    class XmlEmittingVisitor
    {
        EXTENDS |extends
    }

    AbstractParseTreeVisitor {
    LT | <}

Object {
GT | > } {IMPLEMENTS |implements }
JavaVisitor {
LT | < }Object {
GT | > } {private {
FINAL |final }
BufferedTokenStream bufferedTokenStream;
private {
FINAL |final }
ContentHandler contentHandler;
private static {
FINAL |final }
Attributes noAtts = new AttributesImpl();
private {
INT |int }
cursor ; XmlEmittingVisitor(ContentHandler contentHandler, BufferedTokenStream bufferedTokenStream)
{
    {
        THIS | this
    } .

    contentHandler = contentHandler;
    {
        THIS | this
    } .

    bufferedTokenStream = bufferedTokenStream;
    cursor =
    {
        SUB | -
    }

    {
        IntegerLiteral | 1
    }

    ;
}

private ObjectemitXmlElement(String elementName, ParserRuleContext ctx)
{
    try
    {
        {
            INT | int
        }

        tokenIndex = ctx.start.getTokenIndex();
        emitWhiteSpace(tokenIndex);
        contentHandler.startElement("", elementName, elementName, noAtts);
        emitComments(tokenIndex);
        visitChildren(ctx);
        contentHandler.endElement("", elementName, elementName);
    }
    catch (SAXException ex)
    {
        Logger.getLogger(XmlEmittingVisitor.class .

getName() ) .
log(Level.SEVERE,  null , ex); {
THROW | throw }new RuntimeException(ex); } {
RETURN | return } null ;  }private void emitWhiteSpace(
{
    INT | int
}

tokenIndex ) { {IF | if } (tokenIndex {
GT | > }cursor ) {List {
LT | < }Token {
GT | > }hiddenTokens =  bufferedTokenStream.getHiddenTokensToLeft (tokenIndex ) ;  {IF | if } (hiddenTokens {
NOTEQUAL | != } null ) {emitWhiteSpace(hiddenTokens.get ({
    IntegerLiteral | 0
} ) ) ;  } } }

private void emitComments(
{
    INT | int
}

tokenIndex ) { {IF | if } (tokenIndex {
GT | > }cursor ) {List {
LT | < }Token {
GT | > }hiddenTokens =  bufferedTokenStream.getHiddenTokensToLeft (tokenIndex ) ;  {IF | if } (hiddenTokens {
NOTEQUAL | != } null  {AND | && } (hiddenTokens.size ( ) {GT | > } {IntegerLiteral | 0 } ) ) { {INT |int }
offset =  cursor {
SUB | - }hiddenTokens.get ( {IntegerLiteral | 0 } ) .getTokenIndex()
{
    ADD | +
} {

IntegerLiteral | 1 } ;  {FOR | for } ( {INT |int }
i =  offset ; i {
LT | < }hiddenTokens.size ( ) ; i {
INC | ++ } ) {Token t = hiddenTokens.get(i); {
IF | if } (t.getType ( ) {EQUAL |=  =  }JavaLexer.COMMENT ) {emitToken( "Comment", t); } {
ELSE | else } {IF | if } (t.getType ( ) {EQUAL |=  =  }JavaLexer.LINE_COMMENT ) {emitToken( "LineComment", t); } {
ELSE | else } {emitWhiteSpace(t); } } }
cursor =  tokenIndex ;  } }private void emitWhiteSpace(Token t)
{
    {
        INT | int
    }

    tokenIndex = t.getTokenIndex();
    {
        IF | if
    }

    (tokenIndex
    {
        GT | >
    }

    cursor
    {
        AND | &&
    }

    t.getType()
    {
        EQUAL |= =
    }

    JavaLexer.WS )
    {
        String ws = t.getText().replaceAll("\r\n", "\n");
        try
        {
            contentHandler.characters(ws.toCharArray(), {
                IntegerLiteral | 0
            } , 

            ws.length() )
            ;
        }
        catch (SAXException ex)
        {
            Logger.getLogger(XmlEmittingVisitor.class .

getName() ) .
log(Level.SEVERE,  null , ex); }
cursor =  t.getTokenIndex ( ) ;  } }void emitToken(String elementName, Token token)
{
    {
        INT | int
    }

    tokenIndex = token.getTokenIndex();
    {
        ASSERT | assert
    }

    tokenIndex
    {
        GT | >
    }

    cursor;
    String tokenText = token.getText().replaceAll("\r\n", "\n");
    try
    {
        AttributesImpl atts = new AttributesImpl();
        {
            INT | int
        }

        tokenType = token.getType();
        tokenType = tokenType
        {
            LE | <=
        }

        {
            IntegerLiteral | 0
        }

        {
            QUESTION | ?
        }

        {
            IntegerLiteral | 0
        }

        {
            COLON |  : 
        }

        tokenType;
        atts.addAttribute("", "type", "type", "", JavaLexer.tokenTypes[tokenType]);
        contentHandler.startElement("", elementName, elementName, atts);
        contentHandler.characters(tokenText.toCharArray(), {
            IntegerLiteral | 0
        } , 

        tokenText.length() )
        ;
        contentHandler.endElement("", elementName, elementName);
    }
    catch (SAXException ex)
    {
        Logger.getLogger(XmlEmittingVisitor.class .

getName() ) .
log(Level.SEVERE,  null , ex); {
THROW | throw }new RuntimeException(ex); }
cursor =  tokenIndex ;  } {AT | @ }Override public ObjectvisitTerminal(TerminalNode node)
{
    Token symbol = node.getSymbol();
    {
        INT | int
    }

    tokenIndex = symbol.getTokenIndex();
    emitComments(tokenIndex);
    TokenSource tokenSource = symbol.getTokenSource();
    emitToken("Symbol", symbol);
    {
        RETURN | return
    }

    null;
} {

AT | @ }Override public ObjectvisitMemberDeclaration(JavaParser.MemberDeclarationContext ctx)
{
    {
        RETURN | return
    }

    emitXmlElement("MemberDeclaration", ctx);
} {

AT | @ }Override public ObjectvisitDefaultValue(JavaParser.DefaultValueContext ctx)
{
    {
        RETURN | return
    }

    emitXmlElement("DefaultValue", ctx);
} {

AT | @ }Override public ObjectvisitAnnotationTypeElementDeclaration(JavaParser.AnnotationTypeElementDeclarationContext ctx)
{
    {
        RETURN | return
    }

    emitXmlElement("AnnotationTypeElementDeclaration", ctx);
} {

AT | @ }Override public ObjectvisitType(JavaParser.TypeContext ctx)
{
    {
        RETURN | return
    }

    emitXmlElement("Type", ctx);
} {

AT | @ }Override public ObjectvisitAnnotationTypeBody(JavaParser.AnnotationTypeBodyContext ctx)
{
    {
        RETURN | return
    }

    emitXmlElement("AnnotationTypeBody", ctx);
} {

AT | @ }Override public ObjectvisitGenericInterfaceMethodDeclaration(JavaParser.GenericInterfaceMethodDeclarationContext ctx)
{
    {
        RETURN | return
    }

    emitXmlElement("GenericInterfaceMethodDeclaration", ctx);
} {

AT | @ }Override public ObjectvisitClassBodyDeclaration(JavaParser.ClassBodyDeclarationContext ctx)
{
    {
        RETURN | return
    }

    emitXmlElement("ClassBodyDeclaration", ctx);
} {

AT | @ }Override public ObjectvisitBlock(JavaParser.BlockContext ctx)
{
    {
        RETURN | return
    }

    emitXmlElement("Block", ctx);
} {

AT | @ }Override public ObjectvisitEnumBodyDeclarations(JavaParser.EnumBodyDeclarationsContext ctx)
{
    {
        RETURN | return
    }

    emitXmlElement("EnumBodyDeclarations", ctx);
} {

AT | @ }Override public ObjectvisitForUpdate(JavaParser.ForUpdateContext ctx)
{
    {
        RETURN | return
    }

    emitXmlElement("ForUpdate", ctx);
} {

AT | @ }Override public ObjectvisitEnhancedForControl(JavaParser.EnhancedForControlContext ctx)
{
    {
        RETURN | return
    }

    emitXmlElement("EnhancedForControl", ctx);
} {

AT | @ }Override public ObjectvisitAnnotationConstantRest(JavaParser.AnnotationConstantRestContext ctx)
{
    {
        RETURN | return
    }

    emitXmlElement("AnnotationConstantRest", ctx);
} {

AT | @ }Override public ObjectvisitExplicitGenericInvocation(JavaParser.ExplicitGenericInvocationContext ctx)
{
    {
        RETURN | return
    }

    emitXmlElement("ExplicitGenericInvocation", ctx);
} {

AT | @ }Override public ObjectvisitNonWildcardTypeArgumentsOrDiamond(JavaParser.NonWildcardTypeArgumentsOrDiamondContext ctx)
{
    {
        RETURN | return
    }

    emitXmlElement("NonWildcardTypeArgumentsOrDiamond", ctx);
} {

AT | @ }Override public ObjectvisitExpressionList(JavaParser.ExpressionListContext ctx)
{
    {
        RETURN | return
    }

    emitXmlElement("ExpressionList", ctx);
} {

AT | @ }Override public ObjectvisitAnnotationTypeElementRest(JavaParser.AnnotationTypeElementRestContext ctx)
{
    {
        RETURN | return
    }

    emitXmlElement("AnnotationTypeElementRest", ctx);
} {

AT | @ }Override public ObjectvisitClassOrInterfaceType(JavaParser.ClassOrInterfaceTypeContext ctx)
{
    {
        RETURN | return
    }

    emitXmlElement("ClassOrInterfaceType", ctx);
} {

AT | @ }Override public ObjectvisitTypeBound(JavaParser.TypeBoundContext ctx)
{
    {
        RETURN | return
    }

    emitXmlElement("TypeBound", ctx);
} {

AT | @ }Override public ObjectvisitVariableDeclaratorId(JavaParser.VariableDeclaratorIdContext ctx)
{
    {
        RETURN | return
    }

    emitXmlElement("VariableDeclaratorId", ctx);
} {

AT | @ }Override public ObjectvisitPrimary(JavaParser.PrimaryContext ctx)
{
    {
        RETURN | return
    }

    emitXmlElement("Primary", ctx);
} {

AT | @ }Override public ObjectvisitClassCreatorRest(JavaParser.ClassCreatorRestContext ctx)
{
    {
        RETURN | return
    }

    emitXmlElement("ClassCreatorRest", ctx);
} {

AT | @ }Override public ObjectvisitInterfaceBodyDeclaration(JavaParser.InterfaceBodyDeclarationContext ctx)
{
    {
        RETURN | return
    }

    emitXmlElement("InterfaceBodyDeclaration", ctx);
} {

AT | @ }Override public ObjectvisitTypeArguments(JavaParser.TypeArgumentsContext ctx)
{
    {
        RETURN | return
    }

    emitXmlElement("TypeArguments", ctx);
} {

AT | @ }Override public ObjectvisitAnnotationName(JavaParser.AnnotationNameContext ctx)
{
    {
        RETURN | return
    }

    emitXmlElement("AnnotationName", ctx);
} {

AT | @ }Override public ObjectvisitFinallyBlock(JavaParser.FinallyBlockContext ctx)
{
    {
        RETURN | return
    }

    emitXmlElement("FinallyBlock", ctx);
} {

AT | @ }Override public ObjectvisitTypeParameters(JavaParser.TypeParametersContext ctx)
{
    {
        RETURN | return
    }

    emitXmlElement("TypeParameters", ctx);
} {

AT | @ }Override public ObjectvisitLastFormalParameter(JavaParser.LastFormalParameterContext ctx)
{
    {
        RETURN | return
    }

    emitXmlElement("LastFormalParameter", ctx);
} {

AT | @ }Override public ObjectvisitConstructorBody(JavaParser.ConstructorBodyContext ctx)
{
    {
        RETURN | return
    }

    emitXmlElement("ConstructorBody", ctx);
} {

AT | @ }Override public ObjectvisitLiteral(JavaParser.LiteralContext ctx)
{
    {
        RETURN | return
    }

    emitXmlElement("Literal", ctx);
} {

AT | @ }Override public ObjectvisitAnnotationMethodOrConstantRest(JavaParser.AnnotationMethodOrConstantRestContext ctx)
{
    {
        RETURN | return
    }

    emitXmlElement("AnnotationMethodOrConstantRest", ctx);
} {

AT | @ }Override public ObjectvisitCatchClause(JavaParser.CatchClauseContext ctx)
{
    {
        RETURN | return
    }

    emitXmlElement("CatchClause", ctx);
} {

AT | @ }Override public ObjectvisitVariableDeclarator(JavaParser.VariableDeclaratorContext ctx)
{
    {
        RETURN | return
    }

    emitXmlElement("VariableDeclarator", ctx);
} {

AT | @ }Override public ObjectvisitTypeList(JavaParser.TypeListContext ctx)
{
    {
        RETURN | return
    }

    emitXmlElement("TypeList", ctx);
} {

AT | @ }Override public ObjectvisitEnumConstants(JavaParser.EnumConstantsContext ctx)
{
    {
        RETURN | return
    }

    emitXmlElement("EnumConstants", ctx);
} {

AT | @ }Override public ObjectvisitClassBody(JavaParser.ClassBodyContext ctx)
{
    {
        RETURN | return
    }

    emitXmlElement("ClassBody", ctx);
} {

AT | @ }Override public ObjectvisitCreatedName(JavaParser.CreatedNameContext ctx)
{
    {
        RETURN | return
    }

    emitXmlElement("CreatedName", ctx);
} {

AT | @ }Override public ObjectvisitEnumDeclaration(JavaParser.EnumDeclarationContext ctx)
{
    {
        RETURN | return
    }

    emitXmlElement("EnumDeclaration", ctx);
} {

AT | @ }Override public ObjectvisitFormalParameter(JavaParser.FormalParameterContext ctx)
{
    {
        RETURN | return
    }

    emitXmlElement("FormalParameter", ctx);
} {

AT | @ }Override public ObjectvisitParExpression(JavaParser.ParExpressionContext ctx)
{
    {
        RETURN | return
    }

    emitXmlElement("ParExpression", ctx);
} {

AT | @ }Override public ObjectvisitAnnotation(JavaParser.AnnotationContext ctx)
{
    {
        RETURN | return
    }

    emitXmlElement("Annotation", ctx);
} {

AT | @ }Override public ObjectvisitVariableInitializer(JavaParser.VariableInitializerContext ctx)
{
    {
        RETURN | return
    }

    emitXmlElement("VariableInitializer", ctx);
} {

AT | @ }Override public ObjectvisitElementValueArrayInitializer(JavaParser.ElementValueArrayInitializerContext ctx)
{
    {
        RETURN | return
    }

    emitXmlElement("ElementValueArrayInitializer", ctx);
} {

AT | @ }Override public ObjectvisitCreator(JavaParser.CreatorContext ctx)
{
    {
        RETURN | return
    }

    emitXmlElement("Creator", ctx);
} {

AT | @ }Override public ObjectvisitArrayCreatorRest(JavaParser.ArrayCreatorRestContext ctx)
{
    {
        RETURN | return
    }

    emitXmlElement("ArrayCreatorRest", ctx);
} {

AT | @ }Override public ObjectvisitExpression(JavaParser.ExpressionContext ctx)
{
    {
        RETURN | return
    }

    emitXmlElement("Expression", ctx);
} {

AT | @ }Override public ObjectvisitConstantExpression(JavaParser.ConstantExpressionContext ctx)
{
    {
        RETURN | return
    }

    emitXmlElement("ConstantExpression", ctx);
} {

AT | @ }Override public ObjectvisitQualifiedNameList(JavaParser.QualifiedNameListContext ctx)
{
    {
        RETURN | return
    }

    emitXmlElement("QualifiedNameList", ctx);
} {

AT | @ }Override public ObjectvisitConstructorDeclaration(JavaParser.ConstructorDeclarationContext ctx)
{
    {
        RETURN | return
    }

    emitXmlElement("ConstructorDeclaration", ctx);
} {

AT | @ }Override public ObjectvisitForControl(JavaParser.ForControlContext ctx)
{
    {
        RETURN | return
    }

    emitXmlElement("ForControl", ctx);
} {

AT | @ }Override public ObjectvisitSuperSuffix(JavaParser.SuperSuffixContext ctx)
{
    {
        RETURN | return
    }

    emitXmlElement("SuperSuffix", ctx);
} {

AT | @ }Override public ObjectvisitVariableDeclarators(JavaParser.VariableDeclaratorsContext ctx)
{
    {
        RETURN | return
    }

    emitXmlElement("VariableDeclarators", ctx);
} {

AT | @ }Override public ObjectvisitCatchType(JavaParser.CatchTypeContext ctx)
{
    {
        RETURN | return
    }

    emitXmlElement("CatchType", ctx);
} {

AT | @ }Override public ObjectvisitClassOrInterfaceModifier(JavaParser.ClassOrInterfaceModifierContext ctx)
{
    {
        RETURN | return
    }

    emitXmlElement("ClassOrInterfaceModifier", ctx);
} {

AT | @ }Override public ObjectvisitEnumConstantName(JavaParser.EnumConstantNameContext ctx)
{
    {
        RETURN | return
    }

    emitXmlElement("EnumConstantName", ctx);
} {

AT | @ }Override public ObjectvisitModifier(JavaParser.ModifierContext ctx)
{
    {
        RETURN | return
    }

    emitXmlElement("Modifier", ctx);
} {

AT | @ }Override public ObjectvisitInnerCreator(JavaParser.InnerCreatorContext ctx)
{
    {
        RETURN | return
    }

    emitXmlElement("InnerCreator", ctx);
} {

AT | @ }Override public ObjectvisitExplicitGenericInvocationSuffix(JavaParser.ExplicitGenericInvocationSuffixContext ctx)
{
    {
        RETURN | return
    }

    emitXmlElement("ExplicitGenericInvocationSuffix", ctx);
} {

AT | @ }Override public ObjectvisitVariableModifier(JavaParser.VariableModifierContext ctx)
{
    {
        RETURN | return
    }

    emitXmlElement("VariableModifier", ctx);
} {

AT | @ }Override public ObjectvisitElementValuePair(JavaParser.ElementValuePairContext ctx)
{
    {
        RETURN | return
    }

    emitXmlElement("ElementValuePair", ctx);
} {

AT | @ }Override public ObjectvisitArrayInitializer(JavaParser.ArrayInitializerContext ctx)
{
    {
        RETURN | return
    }

    emitXmlElement("ArrayInitializer", ctx);
} {

AT | @ }Override public ObjectvisitElementValue(JavaParser.ElementValueContext ctx)
{
    {
        RETURN | return
    }

    emitXmlElement("ElementValue", ctx);
} {

AT | @ }Override public ObjectvisitConstDeclaration(JavaParser.ConstDeclarationContext ctx)
{
    {
        RETURN | return
    }

    emitXmlElement("ConstDeclaration", ctx);
} {

AT | @ }Override public ObjectvisitResource(JavaParser.ResourceContext ctx)
{
    {
        RETURN | return
    }

    emitXmlElement("Resource", ctx);
} {

AT | @ }Override public ObjectvisitQualifiedName(JavaParser.QualifiedNameContext ctx)
{
    {
        RETURN | return
    }

    emitXmlElement("QualifiedName", ctx);
} {

AT | @ }Override public ObjectvisitResourceSpecification(JavaParser.ResourceSpecificationContext ctx)
{
    {
        RETURN | return
    }

    emitXmlElement("ResourceSpecification", ctx);
} {

AT | @ }Override public ObjectvisitFormalParameterList(JavaParser.FormalParameterListContext ctx)
{
    {
        RETURN | return
    }

    emitXmlElement("FormalParameterList", ctx);
} {

AT | @ }Override public ObjectvisitAnnotationTypeDeclaration(JavaParser.AnnotationTypeDeclarationContext ctx)
{
    {
        RETURN | return
    }

    emitXmlElement("AnnotationTypeDeclaration", ctx);
} {

AT | @ }Override public ObjectvisitAnnotationMethodRest(JavaParser.AnnotationMethodRestContext ctx)
{
    {
        RETURN | return
    }

    emitXmlElement("AnnotationMethodRest", ctx);
} {

AT | @ }Override public ObjectvisitSwitchBlockStatementGroup(JavaParser.SwitchBlockStatementGroupContext ctx)
{
    {
        RETURN | return
    }

    emitXmlElement("SwitchBlockStatementGroup", ctx);
} {

AT | @ }Override public ObjectvisitTypeParameter(JavaParser.TypeParameterContext ctx)
{
    {
        RETURN | return
    }

    emitXmlElement("TypeParameter", ctx);
} {

AT | @ }Override public ObjectvisitInterfaceBody(JavaParser.InterfaceBodyContext ctx)
{
    {
        RETURN | return
    }

    emitXmlElement("InterfaceBody", ctx);
} {

AT | @ }Override public ObjectvisitMethodDeclaration(JavaParser.MethodDeclarationContext ctx)
{
    {
        RETURN | return
    }

    emitXmlElement("MethodDeclaration", ctx);
} {

AT | @ }Override public ObjectvisitMethodBody(JavaParser.MethodBodyContext ctx)
{
    {
        RETURN | return
    }

    emitXmlElement("MethodBody", ctx);
} {

AT | @ }Override public ObjectvisitTypeArgument(JavaParser.TypeArgumentContext ctx)
{
    {
        RETURN | return
    }

    emitXmlElement("TypeArgument", ctx);
} {

AT | @ }Override public ObjectvisitTypeDeclaration(JavaParser.TypeDeclarationContext ctx)
{
    {
        RETURN | return
    }

    emitXmlElement("TypeDeclaration", ctx);
} {

AT | @ }Override public ObjectvisitGenericConstructorDeclaration(JavaParser.GenericConstructorDeclarationContext ctx)
{
    {
        RETURN | return
    }

    emitXmlElement("GenericConstructorDeclaration", ctx);
} {

AT | @ }Override public ObjectvisitClassDeclaration(JavaParser.ClassDeclarationContext ctx)
{
    {
        RETURN | return
    }

    emitXmlElement("ClassDeclaration", ctx);
} {

AT | @ }Override public ObjectvisitEnumConstant(JavaParser.EnumConstantContext ctx)
{
    {
        RETURN | return
    }

    emitXmlElement("EnumConstant", ctx);
} {

AT | @ }Override public ObjectvisitStatement(JavaParser.StatementContext ctx)
{
    {
        RETURN | return
    }

    emitXmlElement("Statement", ctx);
} {

AT | @ }Override public ObjectvisitImportDeclaration(JavaParser.ImportDeclarationContext ctx)
{
    {
        RETURN | return
    }

    emitXmlElement("ImportDeclaration", ctx);
} {

AT | @ }Override public ObjectvisitPrimitiveType(JavaParser.PrimitiveTypeContext ctx)
{
    {
        RETURN | return
    }

    emitXmlElement("PrimitiveType", ctx);
} {

AT | @ }Override public ObjectvisitInterfaceDeclaration(JavaParser.InterfaceDeclarationContext ctx)
{
    {
        RETURN | return
    }

    emitXmlElement("InterfaceDeclaration", ctx);
} {

AT | @ }Override public ObjectvisitLocalVariableDeclarationStatement(JavaParser.LocalVariableDeclarationStatementContext ctx)
{
    {
        RETURN | return
    }

    emitXmlElement("LocalVariableDeclarationStatement", ctx);
} {

AT | @ }Override public ObjectvisitBlockStatement(JavaParser.BlockStatementContext ctx)
{
    {
        RETURN | return
    }

    emitXmlElement("BlockStatement", ctx);
} {

AT | @ }Override public ObjectvisitFieldDeclaration(JavaParser.FieldDeclarationContext ctx)
{
    {
        RETURN | return
    }

    emitXmlElement("FieldDeclaration", ctx);
} {

AT | @ }Override public ObjectvisitConstantDeclarator(JavaParser.ConstantDeclaratorContext ctx)
{
    {
        RETURN | return
    }

    emitXmlElement("ConstantDeclarator", ctx);
} {

AT | @ }Override public ObjectvisitResources(JavaParser.ResourcesContext ctx)
{
    {
        RETURN | return
    }

    emitXmlElement("Resources", ctx);
} {

AT | @ }Override public ObjectvisitStatementExpression(JavaParser.StatementExpressionContext ctx)
{
    {
        RETURN | return
    }

    emitXmlElement("StatementExpression", ctx);
} {

AT | @ }Override public ObjectvisitInterfaceMethodDeclaration(JavaParser.InterfaceMethodDeclarationContext ctx)
{
    {
        RETURN | return
    }

    emitXmlElement("InterfaceMethodDeclaration", ctx);
} {

AT | @ }Override public ObjectvisitPackageDeclaration(JavaParser.PackageDeclarationContext ctx)
{
    {
        RETURN | return
    }

    emitXmlElement("PackageDeclaration", ctx);
} {

AT | @ }Override public ObjectvisitElementValuePairs(JavaParser.ElementValuePairsContext ctx)
{
    {
        RETURN | return
    }

    emitXmlElement("ElementValuePairs", ctx);
} {

AT | @ }Override public ObjectvisitLocalVariableDeclaration(JavaParser.LocalVariableDeclarationContext ctx)
{
    {
        RETURN | return
    }

    emitXmlElement("LocalVariableDeclaration", ctx);
} {

AT | @ }Override public ObjectvisitNonWildcardTypeArguments(JavaParser.NonWildcardTypeArgumentsContext ctx)
{
    {
        RETURN | return
    }

    emitXmlElement("NonWildcardTypeArguments", ctx);
} {

AT | @ }Override public ObjectvisitInterfaceMemberDeclaration(JavaParser.InterfaceMemberDeclarationContext ctx)
{
    {
        RETURN | return
    }

    emitXmlElement("InterfaceMemberDeclaration", ctx);
} {

AT | @ }Override public ObjectvisitSwitchLabel(JavaParser.SwitchLabelContext ctx)
{
    {
        RETURN | return
    }

    emitXmlElement("SwitchLabel", ctx);
} {

AT | @ }Override public ObjectvisitForInit(JavaParser.ForInitContext ctx)
{
    {
        RETURN | return
    }

    emitXmlElement("ForInit", ctx);
} {

AT | @ }Override public ObjectvisitFormalParameters(JavaParser.FormalParametersContext ctx)
{
    {
        RETURN | return
    }

    emitXmlElement("FormalParameters", ctx);
} {

AT | @ }Override public ObjectvisitArguments(JavaParser.ArgumentsContext ctx)
{
    {
        RETURN | return
    }

    emitXmlElement("Arguments", ctx);
} {

AT | @ }Override public ObjectvisitGenericMethodDeclaration(JavaParser.GenericMethodDeclarationContext ctx)
{
    {
        RETURN | return
    }

    emitXmlElement("GenericMethodDeclaration", ctx);
} {

AT | @ }Override public ObjectvisitTypeArgumentsOrDiamond(JavaParser.TypeArgumentsOrDiamondContext ctx)
{
    {
        RETURN | return
    }

    emitXmlElement("TypeArgumentsOrDiamond", ctx);
} {

AT | @ }Override public ObjectvisitCompilationUnit(JavaParser.CompilationUnitContext ctx)
{
    {
        RETURN | return
    }

    emitXmlElement("CompilationUnit", ctx);
} } }
