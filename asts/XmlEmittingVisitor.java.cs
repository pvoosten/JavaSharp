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

    AbstractParseTreeVisitor<Object> {
    IMPLEMENTS |implements
}

JavaVisitor<Object> {
private {
FINAL |final }
BufferedTokenStream bufferedTokenStream;
private {
FINAL |final }
ContentHandler contentHandler;
privatestatic {
FINAL |final }
Attributes noAtts = new AttributesImpl();
privateint cursor;
XmlEmittingVisitor(ContentHandler contentHandler, BufferedTokenStream bufferedTokenStream)
{
    this.contentHandler = contentHandler;
    this.bufferedTokenStream = bufferedTokenStream;
    cursor = -1;
}

private ObjectemitXmlElement(String elementName, ParserRuleContext ctx)
{
    try
    {
        int tokenIndex = ctx.start.getTokenIndex();
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
log(Level.SEVERE,  null , ex); throw 
new RuntimeException(ex); } return  null ;  }
private void emitWhiteSpace(int tokenIndex)
{
    if (tokenIndex > cursor)
    {
        List<Token> hiddenTokens = bufferedTokenStream.getHiddenTokensToLeft(tokenIndex);
        if (hiddenTokens != null)
        {
            emitWhiteSpace(hiddenTokens.get(0));
        }
    }
}

private void emitComments(int tokenIndex)
{
    if (tokenIndex > cursor)
    {
        List<Token> hiddenTokens = bufferedTokenStream.getHiddenTokensToLeft(tokenIndex);
        if (hiddenTokens != null && (hiddenTokens.size() > 0))
        {
            int offset = cursor - hiddenTokens.get(0).getTokenIndex() + 1;
            {
                FOR | for
            }

            (int i = offset;
            i < hiddenTokens.size();
            i++ )
            {
                Token t = hiddenTokens.get(i);
                if (t.getType() == JavaLexer.COMMENT)
                {
                    emitToken("Comment", t);
                }
                else if (t.getType() == JavaLexer.LINE_COMMENT)
                {
                    emitToken("LineComment", t);
                }
                else
                {
                    emitWhiteSpace(t);
                }
            }
        }

        cursor = tokenIndex;
    }
}

private void emitWhiteSpace(Token t)
{
    int tokenIndex = t.getTokenIndex();
    if (tokenIndex > cursor && t.getType() == JavaLexer.WS)
    {
        String ws = t.getText().replaceAll("\r\n", "\n");
        try
        {
            contentHandler.characters(ws.toCharArray(), 0, ws.length());
        }
        catch (SAXException ex)
        {
            Logger.getLogger(XmlEmittingVisitor.class .

getName() ) .
log(Level.SEVERE,  null , ex); }
cursor =  t.getTokenIndex ( ) ;  } }void emitToken(String elementName, Token token)
{
    int tokenIndex = token.getTokenIndex();
    {
        ASSERT | assert
    }

    tokenIndex > cursor;
    String tokenText = token.getText().replaceAll("\r\n", "\n");
    try
    {
        AttributesImpl atts = new AttributesImpl();
        int tokenType = token.getType();
        tokenType = tokenType <= 0 ? 0 : tokenType;
        atts.addAttribute("", "type", "type", "", JavaLexer.tokenTypes[tokenType]);
        contentHandler.startElement("", elementName, elementName, atts);
        contentHandler.characters(tokenText.toCharArray(), 0, tokenText.length());
        contentHandler.endElement("", elementName, elementName);
    }
    catch (SAXException ex)
    {
        Logger.getLogger(XmlEmittingVisitor.class .

getName() ) .
log(Level.SEVERE,  null , ex); throw 
new RuntimeException(ex); }
cursor =  tokenIndex ;  } {AT | @ }Overridepublic ObjectvisitTerminal(TerminalNode node)
{
    Token symbol = node.getSymbol();
    int tokenIndex = symbol.getTokenIndex();
    emitComments(tokenIndex);
    TokenSource tokenSource = symbol.getTokenSource();
    emitToken("Symbol", symbol);
    return null;
} {

AT | @ }Overridepublic ObjectvisitMemberDeclaration(JavaParser.MemberDeclarationContext ctx)
{
    return emitXmlElement("MemberDeclaration", ctx);
} {

AT | @ }Overridepublic ObjectvisitDefaultValue(JavaParser.DefaultValueContext ctx)
{
    return emitXmlElement("DefaultValue", ctx);
} {

AT | @ }Overridepublic ObjectvisitAnnotationTypeElementDeclaration(JavaParser.AnnotationTypeElementDeclarationContext ctx)
{
    return emitXmlElement("AnnotationTypeElementDeclaration", ctx);
} {

AT | @ }Overridepublic ObjectvisitType(JavaParser.TypeContext ctx)
{
    return emitXmlElement("Type", ctx);
} {

AT | @ }Overridepublic ObjectvisitAnnotationTypeBody(JavaParser.AnnotationTypeBodyContext ctx)
{
    return emitXmlElement("AnnotationTypeBody", ctx);
} {

AT | @ }Overridepublic ObjectvisitGenericInterfaceMethodDeclaration(JavaParser.GenericInterfaceMethodDeclarationContext ctx)
{
    return emitXmlElement("GenericInterfaceMethodDeclaration", ctx);
} {

AT | @ }Overridepublic ObjectvisitClassBodyDeclaration(JavaParser.ClassBodyDeclarationContext ctx)
{
    return emitXmlElement("ClassBodyDeclaration", ctx);
} {

AT | @ }Overridepublic ObjectvisitBlock(JavaParser.BlockContext ctx)
{
    return emitXmlElement("Block", ctx);
} {

AT | @ }Overridepublic ObjectvisitEnumBodyDeclarations(JavaParser.EnumBodyDeclarationsContext ctx)
{
    return emitXmlElement("EnumBodyDeclarations", ctx);
} {

AT | @ }Overridepublic ObjectvisitForUpdate(JavaParser.ForUpdateContext ctx)
{
    return emitXmlElement("ForUpdate", ctx);
} {

AT | @ }Overridepublic ObjectvisitEnhancedForControl(JavaParser.EnhancedForControlContext ctx)
{
    return emitXmlElement("EnhancedForControl", ctx);
} {

AT | @ }Overridepublic ObjectvisitAnnotationConstantRest(JavaParser.AnnotationConstantRestContext ctx)
{
    return emitXmlElement("AnnotationConstantRest", ctx);
} {

AT | @ }Overridepublic ObjectvisitExplicitGenericInvocation(JavaParser.ExplicitGenericInvocationContext ctx)
{
    return emitXmlElement("ExplicitGenericInvocation", ctx);
} {

AT | @ }Overridepublic ObjectvisitNonWildcardTypeArgumentsOrDiamond(JavaParser.NonWildcardTypeArgumentsOrDiamondContext ctx)
{
    return emitXmlElement("NonWildcardTypeArgumentsOrDiamond", ctx);
} {

AT | @ }Overridepublic ObjectvisitExpressionList(JavaParser.ExpressionListContext ctx)
{
    return emitXmlElement("ExpressionList", ctx);
} {

AT | @ }Overridepublic ObjectvisitAnnotationTypeElementRest(JavaParser.AnnotationTypeElementRestContext ctx)
{
    return emitXmlElement("AnnotationTypeElementRest", ctx);
} {

AT | @ }Overridepublic ObjectvisitClassOrInterfaceType(JavaParser.ClassOrInterfaceTypeContext ctx)
{
    return emitXmlElement("ClassOrInterfaceType", ctx);
} {

AT | @ }Overridepublic ObjectvisitTypeBound(JavaParser.TypeBoundContext ctx)
{
    return emitXmlElement("TypeBound", ctx);
} {

AT | @ }Overridepublic ObjectvisitVariableDeclaratorId(JavaParser.VariableDeclaratorIdContext ctx)
{
    return emitXmlElement("VariableDeclaratorId", ctx);
} {

AT | @ }Overridepublic ObjectvisitPrimary(JavaParser.PrimaryContext ctx)
{
    return emitXmlElement("Primary", ctx);
} {

AT | @ }Overridepublic ObjectvisitClassCreatorRest(JavaParser.ClassCreatorRestContext ctx)
{
    return emitXmlElement("ClassCreatorRest", ctx);
} {

AT | @ }Overridepublic ObjectvisitInterfaceBodyDeclaration(JavaParser.InterfaceBodyDeclarationContext ctx)
{
    return emitXmlElement("InterfaceBodyDeclaration", ctx);
} {

AT | @ }Overridepublic ObjectvisitTypeArguments(JavaParser.TypeArgumentsContext ctx)
{
    return emitXmlElement("TypeArguments", ctx);
} {

AT | @ }Overridepublic ObjectvisitAnnotationName(JavaParser.AnnotationNameContext ctx)
{
    return emitXmlElement("AnnotationName", ctx);
} {

AT | @ }Overridepublic ObjectvisitFinallyBlock(JavaParser.FinallyBlockContext ctx)
{
    return emitXmlElement("FinallyBlock", ctx);
} {

AT | @ }Overridepublic ObjectvisitTypeParameters(JavaParser.TypeParametersContext ctx)
{
    return emitXmlElement("TypeParameters", ctx);
} {

AT | @ }Overridepublic ObjectvisitLastFormalParameter(JavaParser.LastFormalParameterContext ctx)
{
    return emitXmlElement("LastFormalParameter", ctx);
} {

AT | @ }Overridepublic ObjectvisitConstructorBody(JavaParser.ConstructorBodyContext ctx)
{
    return emitXmlElement("ConstructorBody", ctx);
} {

AT | @ }Overridepublic ObjectvisitLiteral(JavaParser.LiteralContext ctx)
{
    return emitXmlElement("Literal", ctx);
} {

AT | @ }Overridepublic ObjectvisitAnnotationMethodOrConstantRest(JavaParser.AnnotationMethodOrConstantRestContext ctx)
{
    return emitXmlElement("AnnotationMethodOrConstantRest", ctx);
} {

AT | @ }Overridepublic ObjectvisitCatchClause(JavaParser.CatchClauseContext ctx)
{
    return emitXmlElement("CatchClause", ctx);
} {

AT | @ }Overridepublic ObjectvisitVariableDeclarator(JavaParser.VariableDeclaratorContext ctx)
{
    return emitXmlElement("VariableDeclarator", ctx);
} {

AT | @ }Overridepublic ObjectvisitTypeList(JavaParser.TypeListContext ctx)
{
    return emitXmlElement("TypeList", ctx);
} {

AT | @ }Overridepublic ObjectvisitEnumConstants(JavaParser.EnumConstantsContext ctx)
{
    return emitXmlElement("EnumConstants", ctx);
} {

AT | @ }Overridepublic ObjectvisitClassBody(JavaParser.ClassBodyContext ctx)
{
    return emitXmlElement("ClassBody", ctx);
} {

AT | @ }Overridepublic ObjectvisitCreatedName(JavaParser.CreatedNameContext ctx)
{
    return emitXmlElement("CreatedName", ctx);
} {

AT | @ }Overridepublic ObjectvisitEnumDeclaration(JavaParser.EnumDeclarationContext ctx)
{
    return emitXmlElement("EnumDeclaration", ctx);
} {

AT | @ }Overridepublic ObjectvisitFormalParameter(JavaParser.FormalParameterContext ctx)
{
    return emitXmlElement("FormalParameter", ctx);
} {

AT | @ }Overridepublic ObjectvisitParExpression(JavaParser.ParExpressionContext ctx)
{
    return emitXmlElement("ParExpression", ctx);
} {

AT | @ }Overridepublic ObjectvisitAnnotation(JavaParser.AnnotationContext ctx)
{
    return emitXmlElement("Annotation", ctx);
} {

AT | @ }Overridepublic ObjectvisitVariableInitializer(JavaParser.VariableInitializerContext ctx)
{
    return emitXmlElement("VariableInitializer", ctx);
} {

AT | @ }Overridepublic ObjectvisitElementValueArrayInitializer(JavaParser.ElementValueArrayInitializerContext ctx)
{
    return emitXmlElement("ElementValueArrayInitializer", ctx);
} {

AT | @ }Overridepublic ObjectvisitCreator(JavaParser.CreatorContext ctx)
{
    return emitXmlElement("Creator", ctx);
} {

AT | @ }Overridepublic ObjectvisitArrayCreatorRest(JavaParser.ArrayCreatorRestContext ctx)
{
    return emitXmlElement("ArrayCreatorRest", ctx);
} {

AT | @ }Overridepublic ObjectvisitExpression(JavaParser.ExpressionContext ctx)
{
    return emitXmlElement("Expression", ctx);
} {

AT | @ }Overridepublic ObjectvisitConstantExpression(JavaParser.ConstantExpressionContext ctx)
{
    return emitXmlElement("ConstantExpression", ctx);
} {

AT | @ }Overridepublic ObjectvisitQualifiedNameList(JavaParser.QualifiedNameListContext ctx)
{
    return emitXmlElement("QualifiedNameList", ctx);
} {

AT | @ }Overridepublic ObjectvisitConstructorDeclaration(JavaParser.ConstructorDeclarationContext ctx)
{
    return emitXmlElement("ConstructorDeclaration", ctx);
} {

AT | @ }Overridepublic ObjectvisitForControl(JavaParser.ForControlContext ctx)
{
    return emitXmlElement("ForControl", ctx);
} {

AT | @ }Overridepublic ObjectvisitSuperSuffix(JavaParser.SuperSuffixContext ctx)
{
    return emitXmlElement("SuperSuffix", ctx);
} {

AT | @ }Overridepublic ObjectvisitVariableDeclarators(JavaParser.VariableDeclaratorsContext ctx)
{
    return emitXmlElement("VariableDeclarators", ctx);
} {

AT | @ }Overridepublic ObjectvisitCatchType(JavaParser.CatchTypeContext ctx)
{
    return emitXmlElement("CatchType", ctx);
} {

AT | @ }Overridepublic ObjectvisitClassOrInterfaceModifier(JavaParser.ClassOrInterfaceModifierContext ctx)
{
    return emitXmlElement("ClassOrInterfaceModifier", ctx);
} {

AT | @ }Overridepublic ObjectvisitEnumConstantName(JavaParser.EnumConstantNameContext ctx)
{
    return emitXmlElement("EnumConstantName", ctx);
} {

AT | @ }Overridepublic ObjectvisitModifier(JavaParser.ModifierContext ctx)
{
    return emitXmlElement("Modifier", ctx);
} {

AT | @ }Overridepublic ObjectvisitInnerCreator(JavaParser.InnerCreatorContext ctx)
{
    return emitXmlElement("InnerCreator", ctx);
} {

AT | @ }Overridepublic ObjectvisitExplicitGenericInvocationSuffix(JavaParser.ExplicitGenericInvocationSuffixContext ctx)
{
    return emitXmlElement("ExplicitGenericInvocationSuffix", ctx);
} {

AT | @ }Overridepublic ObjectvisitVariableModifier(JavaParser.VariableModifierContext ctx)
{
    return emitXmlElement("VariableModifier", ctx);
} {

AT | @ }Overridepublic ObjectvisitElementValuePair(JavaParser.ElementValuePairContext ctx)
{
    return emitXmlElement("ElementValuePair", ctx);
} {

AT | @ }Overridepublic ObjectvisitArrayInitializer(JavaParser.ArrayInitializerContext ctx)
{
    return emitXmlElement("ArrayInitializer", ctx);
} {

AT | @ }Overridepublic ObjectvisitElementValue(JavaParser.ElementValueContext ctx)
{
    return emitXmlElement("ElementValue", ctx);
} {

AT | @ }Overridepublic ObjectvisitConstDeclaration(JavaParser.ConstDeclarationContext ctx)
{
    return emitXmlElement("ConstDeclaration", ctx);
} {

AT | @ }Overridepublic ObjectvisitResource(JavaParser.ResourceContext ctx)
{
    return emitXmlElement("Resource", ctx);
} {

AT | @ }Overridepublic ObjectvisitQualifiedName(JavaParser.QualifiedNameContext ctx)
{
    return emitXmlElement("QualifiedName", ctx);
} {

AT | @ }Overridepublic ObjectvisitResourceSpecification(JavaParser.ResourceSpecificationContext ctx)
{
    return emitXmlElement("ResourceSpecification", ctx);
} {

AT | @ }Overridepublic ObjectvisitFormalParameterList(JavaParser.FormalParameterListContext ctx)
{
    return emitXmlElement("FormalParameterList", ctx);
} {

AT | @ }Overridepublic ObjectvisitAnnotationTypeDeclaration(JavaParser.AnnotationTypeDeclarationContext ctx)
{
    return emitXmlElement("AnnotationTypeDeclaration", ctx);
} {

AT | @ }Overridepublic ObjectvisitAnnotationMethodRest(JavaParser.AnnotationMethodRestContext ctx)
{
    return emitXmlElement("AnnotationMethodRest", ctx);
} {

AT | @ }Overridepublic ObjectvisitSwitchBlockStatementGroup(JavaParser.SwitchBlockStatementGroupContext ctx)
{
    return emitXmlElement("SwitchBlockStatementGroup", ctx);
} {

AT | @ }Overridepublic ObjectvisitTypeParameter(JavaParser.TypeParameterContext ctx)
{
    return emitXmlElement("TypeParameter", ctx);
} {

AT | @ }Overridepublic ObjectvisitInterfaceBody(JavaParser.InterfaceBodyContext ctx)
{
    return emitXmlElement("InterfaceBody", ctx);
} {

AT | @ }Overridepublic ObjectvisitMethodDeclaration(JavaParser.MethodDeclarationContext ctx)
{
    return emitXmlElement("MethodDeclaration", ctx);
} {

AT | @ }Overridepublic ObjectvisitMethodBody(JavaParser.MethodBodyContext ctx)
{
    return emitXmlElement("MethodBody", ctx);
} {

AT | @ }Overridepublic ObjectvisitTypeArgument(JavaParser.TypeArgumentContext ctx)
{
    return emitXmlElement("TypeArgument", ctx);
} {

AT | @ }Overridepublic ObjectvisitTypeDeclaration(JavaParser.TypeDeclarationContext ctx)
{
    return emitXmlElement("TypeDeclaration", ctx);
} {

AT | @ }Overridepublic ObjectvisitGenericConstructorDeclaration(JavaParser.GenericConstructorDeclarationContext ctx)
{
    return emitXmlElement("GenericConstructorDeclaration", ctx);
} {

AT | @ }Overridepublic ObjectvisitClassDeclaration(JavaParser.ClassDeclarationContext ctx)
{
    return emitXmlElement("ClassDeclaration", ctx);
} {

AT | @ }Overridepublic ObjectvisitEnumConstant(JavaParser.EnumConstantContext ctx)
{
    return emitXmlElement("EnumConstant", ctx);
} {

AT | @ }Overridepublic ObjectvisitStatement(JavaParser.StatementContext ctx)
{
    return emitXmlElement("Statement", ctx);
} {

AT | @ }Overridepublic ObjectvisitImportDeclaration(JavaParser.ImportDeclarationContext ctx)
{
    return emitXmlElement("ImportDeclaration", ctx);
} {

AT | @ }Overridepublic ObjectvisitPrimitiveType(JavaParser.PrimitiveTypeContext ctx)
{
    return emitXmlElement("PrimitiveType", ctx);
} {

AT | @ }Overridepublic ObjectvisitInterfaceDeclaration(JavaParser.InterfaceDeclarationContext ctx)
{
    return emitXmlElement("InterfaceDeclaration", ctx);
} {

AT | @ }Overridepublic ObjectvisitLocalVariableDeclarationStatement(JavaParser.LocalVariableDeclarationStatementContext ctx)
{
    return emitXmlElement("LocalVariableDeclarationStatement", ctx);
} {

AT | @ }Overridepublic ObjectvisitBlockStatement(JavaParser.BlockStatementContext ctx)
{
    return emitXmlElement("BlockStatement", ctx);
} {

AT | @ }Overridepublic ObjectvisitFieldDeclaration(JavaParser.FieldDeclarationContext ctx)
{
    return emitXmlElement("FieldDeclaration", ctx);
} {

AT | @ }Overridepublic ObjectvisitConstantDeclarator(JavaParser.ConstantDeclaratorContext ctx)
{
    return emitXmlElement("ConstantDeclarator", ctx);
} {

AT | @ }Overridepublic ObjectvisitResources(JavaParser.ResourcesContext ctx)
{
    return emitXmlElement("Resources", ctx);
} {

AT | @ }Overridepublic ObjectvisitStatementExpression(JavaParser.StatementExpressionContext ctx)
{
    return emitXmlElement("StatementExpression", ctx);
} {

AT | @ }Overridepublic ObjectvisitInterfaceMethodDeclaration(JavaParser.InterfaceMethodDeclarationContext ctx)
{
    return emitXmlElement("InterfaceMethodDeclaration", ctx);
} {

AT | @ }Overridepublic ObjectvisitPackageDeclaration(JavaParser.PackageDeclarationContext ctx)
{
    return emitXmlElement("PackageDeclaration", ctx);
} {

AT | @ }Overridepublic ObjectvisitElementValuePairs(JavaParser.ElementValuePairsContext ctx)
{
    return emitXmlElement("ElementValuePairs", ctx);
} {

AT | @ }Overridepublic ObjectvisitLocalVariableDeclaration(JavaParser.LocalVariableDeclarationContext ctx)
{
    return emitXmlElement("LocalVariableDeclaration", ctx);
} {

AT | @ }Overridepublic ObjectvisitNonWildcardTypeArguments(JavaParser.NonWildcardTypeArgumentsContext ctx)
{
    return emitXmlElement("NonWildcardTypeArguments", ctx);
} {

AT | @ }Overridepublic ObjectvisitInterfaceMemberDeclaration(JavaParser.InterfaceMemberDeclarationContext ctx)
{
    return emitXmlElement("InterfaceMemberDeclaration", ctx);
} {

AT | @ }Overridepublic ObjectvisitSwitchLabel(JavaParser.SwitchLabelContext ctx)
{
    return emitXmlElement("SwitchLabel", ctx);
} {

AT | @ }Overridepublic ObjectvisitForInit(JavaParser.ForInitContext ctx)
{
    return emitXmlElement("ForInit", ctx);
} {

AT | @ }Overridepublic ObjectvisitFormalParameters(JavaParser.FormalParametersContext ctx)
{
    return emitXmlElement("FormalParameters", ctx);
} {

AT | @ }Overridepublic ObjectvisitArguments(JavaParser.ArgumentsContext ctx)
{
    return emitXmlElement("Arguments", ctx);
} {

AT | @ }Overridepublic ObjectvisitGenericMethodDeclaration(JavaParser.GenericMethodDeclarationContext ctx)
{
    return emitXmlElement("GenericMethodDeclaration", ctx);
} {

AT | @ }Overridepublic ObjectvisitTypeArgumentsOrDiamond(JavaParser.TypeArgumentsOrDiamondContext ctx)
{
    return emitXmlElement("TypeArgumentsOrDiamond", ctx);
} {

AT | @ }Overridepublic ObjectvisitCompilationUnit(JavaParser.CompilationUnitContext ctx)
{
    return emitXmlElement("CompilationUnit", ctx);
} } }
