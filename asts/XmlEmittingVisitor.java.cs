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
class XmlEmittingVisitor : AbstractParseTreeVisitor<Object> : JavaVisitor<Object> {

    
    [JavaSharp.Syntax.JavaFinalModifier]
	private  BufferedTokenStream bufferedTokenStream;
    
    [JavaSharp.Syntax.JavaFinalModifier]
	private  ContentHandler contentHandler;
    
    [JavaSharp.Syntax.JavaFinalModifier]
	private static  Attributes noAtts = new AttributesImpl();
    private int cursor;

    XmlEmittingVisitor(ContentHandler contentHandler, BufferedTokenStream bufferedTokenStream) {
        this.contentHandler = contentHandler;
        this.bufferedTokenStream = bufferedTokenStream;
        cursor = -1;
    }

    private Object emitXmlElement(String elementName, ParserRuleContext ctx)   {
        try {
            int tokenIndex = ctx.start.getTokenIndex();
            emitWhiteSpace(tokenIndex);
            contentHandler.startElement("", elementName, elementName, noAtts);
            emitComments(tokenIndex);
            visitChildren(ctx);
            contentHandler.endElement("", elementName, elementName);
        } catch (SAXException ex) {
            Logger.getLogger(XmlEmittingVisitor.class.getName()).log(Level.SEVERE, null, ex);
            throw new RuntimeException(ex);
        }
        return null;
    }

    private void emitWhiteSpace(int tokenIndex) {
        if (tokenIndex > cursor) {
            List<Token> hiddenTokens = bufferedTokenStream.getHiddenTokensToLeft(tokenIndex);
            if (hiddenTokens != null) {
                emitWhiteSpace(hiddenTokens.get(0));
            }
        }
    }

    private void emitComments(int tokenIndex) {
        if (tokenIndex > cursor) {
            List<Token> hiddenTokens = bufferedTokenStream.getHiddenTokensToLeft(tokenIndex);
            if (hiddenTokens != null && (hiddenTokens.size() > 0)) {
                int offset = cursor - hiddenTokens.get(0).getTokenIndex() + 1;
                for (int i = offset; i < hiddenTokens.size(); i++) {
                    Token t = hiddenTokens.get(i);
                    if (t.getType() == JavaLexer.COMMENT) {
                        emitToken("Comment", t);
                    } else if (t.getType() == JavaLexer.LINE_COMMENT) {
                        emitToken("LineComment", t);
                    } else {
                        emitWhiteSpace(t);
                    }
                }
            }
            cursor = tokenIndex;
        }
    }

    private void emitWhiteSpace(Token t) {
        int tokenIndex = t.getTokenIndex();
        if (tokenIndex > cursor && t.getType() == JavaLexer.WS) {
            String ws = t.getText().replaceAll("\r\n", "\n");
            try {
                contentHandler.characters(ws.toCharArray(), 0, ws.length());
            } catch (SAXException ex) {
                Logger.getLogger(XmlEmittingVisitor.class
                        .getName()).log(Level.SEVERE, null, ex);
            }
            cursor = t.getTokenIndex();
        }
    }

    void emitToken(String elementName, Token token) {
        int tokenIndex = token.getTokenIndex();
        assert tokenIndex > cursor;
        String tokenText = token.getText().replaceAll("\r\n", "\n");
        try {
            AttributesImpl atts = new AttributesImpl();
            int tokenType = token.getType();
            tokenType = tokenType <= 0 ? 0 : tokenType;
            atts.addAttribute("", "type", "type", "", JavaLexer.tokenTypes[tokenType]);
            contentHandler.startElement("", elementName, elementName, atts);
            contentHandler.characters(tokenText.toCharArray(), 0, tokenText.length());
            contentHandler.endElement("", elementName, elementName);
        } catch (SAXException ex) {
            Logger.getLogger(XmlEmittingVisitor.class
                    .getName()).log(Level.SEVERE, null, ex);
            throw new RuntimeException(ex);
        }
        cursor = tokenIndex;
    }

    
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	
    public Object visitTerminal(TerminalNode node) {
        Token symbol = node.getSymbol();
        int tokenIndex = symbol.getTokenIndex();
        emitComments(tokenIndex);
        TokenSource tokenSource = symbol.getTokenSource();
        emitToken("Symbol", symbol);
        return null;
    }

    
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	
    public Object visitMemberDeclaration(JavaParser.MemberDeclarationContext ctx) {
        return emitXmlElement("MemberDeclaration", ctx);
    }

    
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	
    public Object visitDefaultValue(JavaParser.DefaultValueContext ctx) {
        return emitXmlElement("DefaultValue", ctx);
    }

    
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	
    public Object visitAnnotationTypeElementDeclaration(JavaParser.AnnotationTypeElementDeclarationContext ctx) {
        return emitXmlElement("AnnotationTypeElementDeclaration", ctx);
    }

    
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	
    public Object visitType(JavaParser.TypeContext ctx) {
        return emitXmlElement("Type", ctx);
    }

    
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	
    public Object visitAnnotationTypeBody(JavaParser.AnnotationTypeBodyContext ctx) {
        return emitXmlElement("AnnotationTypeBody", ctx);
    }

    
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	
    public Object visitGenericInterfaceMethodDeclaration(JavaParser.GenericInterfaceMethodDeclarationContext ctx) {
        return emitXmlElement("GenericInterfaceMethodDeclaration", ctx);
    }

    
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	
    public Object visitClassBodyDeclaration(JavaParser.ClassBodyDeclarationContext ctx) {
        return emitXmlElement("ClassBodyDeclaration", ctx);
    }

    
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	
    public Object visitBlock(JavaParser.BlockContext ctx) {
        return emitXmlElement("Block", ctx);
    }

    
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	
    public Object visitEnumBodyDeclarations(JavaParser.EnumBodyDeclarationsContext ctx) {
        return emitXmlElement("EnumBodyDeclarations", ctx);
    }

    
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	
    public Object visitForUpdate(JavaParser.ForUpdateContext ctx) {
        return emitXmlElement("ForUpdate", ctx);
    }

    
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	
    public Object visitEnhancedForControl(JavaParser.EnhancedForControlContext ctx) {
        return emitXmlElement("EnhancedForControl", ctx);
    }

    
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	
    public Object visitAnnotationConstantRest(JavaParser.AnnotationConstantRestContext ctx) {
        return emitXmlElement("AnnotationConstantRest", ctx);
    }

    
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	
    public Object visitExplicitGenericInvocation(JavaParser.ExplicitGenericInvocationContext ctx) {
        return emitXmlElement("ExplicitGenericInvocation", ctx);
    }

    
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	
    public Object visitNonWildcardTypeArgumentsOrDiamond(JavaParser.NonWildcardTypeArgumentsOrDiamondContext ctx) {
        return emitXmlElement("NonWildcardTypeArgumentsOrDiamond", ctx);
    }

    
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	
    public Object visitExpressionList(JavaParser.ExpressionListContext ctx) {
        return emitXmlElement("ExpressionList", ctx);
    }

    
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	
    public Object visitAnnotationTypeElementRest(JavaParser.AnnotationTypeElementRestContext ctx) {
        return emitXmlElement("AnnotationTypeElementRest", ctx);
    }

    
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	
    public Object visitClassOrInterfaceType(JavaParser.ClassOrInterfaceTypeContext ctx) {
        return emitXmlElement("ClassOrInterfaceType", ctx);
    }

    
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	
    public Object visitTypeBound(JavaParser.TypeBoundContext ctx) {
        return emitXmlElement("TypeBound", ctx);
    }

    
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	
    public Object visitVariableDeclaratorId(JavaParser.VariableDeclaratorIdContext ctx) {
        return emitXmlElement("VariableDeclaratorId", ctx);
    }

    
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	
    public Object visitPrimary(JavaParser.PrimaryContext ctx) {
        return emitXmlElement("Primary", ctx);
    }

    
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	
    public Object visitClassCreatorRest(JavaParser.ClassCreatorRestContext ctx) {
        return emitXmlElement("ClassCreatorRest", ctx);
    }

    
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	
    public Object visitInterfaceBodyDeclaration(JavaParser.InterfaceBodyDeclarationContext ctx) {
        return emitXmlElement("InterfaceBodyDeclaration", ctx);
    }

    
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	
    public Object visitTypeArguments(JavaParser.TypeArgumentsContext ctx) {
        return emitXmlElement("TypeArguments", ctx);
    }

    
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	
    public Object visitAnnotationName(JavaParser.AnnotationNameContext ctx) {
        return emitXmlElement("AnnotationName", ctx);
    }

    
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	
    public Object visitFinallyBlock(JavaParser.FinallyBlockContext ctx) {
        return emitXmlElement("FinallyBlock", ctx);
    }

    
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	
    public Object visitTypeParameters(JavaParser.TypeParametersContext ctx) {
        return emitXmlElement("TypeParameters", ctx);
    }

    
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	
    public Object visitLastFormalParameter(JavaParser.LastFormalParameterContext ctx) {
        return emitXmlElement("LastFormalParameter", ctx);
    }

    
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	
    public Object visitConstructorBody(JavaParser.ConstructorBodyContext ctx) {
        return emitXmlElement("ConstructorBody", ctx);
    }

    
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	
    public Object visitLiteral(JavaParser.LiteralContext ctx) {
        return emitXmlElement("Literal", ctx);
    }

    
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	
    public Object visitAnnotationMethodOrConstantRest(JavaParser.AnnotationMethodOrConstantRestContext ctx) {
        return emitXmlElement("AnnotationMethodOrConstantRest", ctx);
    }

    
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	
    public Object visitCatchClause(JavaParser.CatchClauseContext ctx) {
        return emitXmlElement("CatchClause", ctx);
    }

    
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	
    public Object visitVariableDeclarator(JavaParser.VariableDeclaratorContext ctx) {
        return emitXmlElement("VariableDeclarator", ctx);
    }

    
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	
    public Object visitTypeList(JavaParser.TypeListContext ctx) {
        return emitXmlElement("TypeList", ctx);
    }

    
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	
    public Object visitEnumConstants(JavaParser.EnumConstantsContext ctx) {
        return emitXmlElement("EnumConstants", ctx);
    }

    
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	
    public Object visitClassBody(JavaParser.ClassBodyContext ctx) {
        return emitXmlElement("ClassBody", ctx);
    }

    
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	
    public Object visitCreatedName(JavaParser.CreatedNameContext ctx) {
        return emitXmlElement("CreatedName", ctx);
    }

    
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	
    public Object visitEnumDeclaration(JavaParser.EnumDeclarationContext ctx) {
        return emitXmlElement("EnumDeclaration", ctx);
    }

    
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	
    public Object visitFormalParameter(JavaParser.FormalParameterContext ctx) {
        return emitXmlElement("FormalParameter", ctx);
    }

    
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	
    public Object visitParExpression(JavaParser.ParExpressionContext ctx) {
        return emitXmlElement("ParExpression", ctx);
    }

    
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	
    public Object visitAnnotation(JavaParser.AnnotationContext ctx) {
        return emitXmlElement("Annotation", ctx);
    }

    
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	
    public Object visitVariableInitializer(JavaParser.VariableInitializerContext ctx) {
        return emitXmlElement("VariableInitializer", ctx);
    }

    
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	
    public Object visitElementValueArrayInitializer(JavaParser.ElementValueArrayInitializerContext ctx) {
        return emitXmlElement("ElementValueArrayInitializer", ctx);
    }

    
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	
    public Object visitCreator(JavaParser.CreatorContext ctx) {
        return emitXmlElement("Creator", ctx);
    }

    
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	
    public Object visitArrayCreatorRest(JavaParser.ArrayCreatorRestContext ctx) {
        return emitXmlElement("ArrayCreatorRest", ctx);
    }

    
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	
    public Object visitExpression(JavaParser.ExpressionContext ctx) {
        return emitXmlElement("Expression", ctx);
    }

    
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	
    public Object visitConstantExpression(JavaParser.ConstantExpressionContext ctx) {
        return emitXmlElement("ConstantExpression", ctx);
    }

    
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	
    public Object visitQualifiedNameList(JavaParser.QualifiedNameListContext ctx) {
        return emitXmlElement("QualifiedNameList", ctx);
    }

    
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	
    public Object visitConstructorDeclaration(JavaParser.ConstructorDeclarationContext ctx) {
        return emitXmlElement("ConstructorDeclaration", ctx);
    }

    
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	
    public Object visitForControl(JavaParser.ForControlContext ctx) {
        return emitXmlElement("ForControl", ctx);
    }

    
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	
    public Object visitSuperSuffix(JavaParser.SuperSuffixContext ctx) {
        return emitXmlElement("SuperSuffix", ctx);
    }

    
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	
    public Object visitVariableDeclarators(JavaParser.VariableDeclaratorsContext ctx) {
        return emitXmlElement("VariableDeclarators", ctx);
    }

    
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	
    public Object visitCatchType(JavaParser.CatchTypeContext ctx) {
        return emitXmlElement("CatchType", ctx);
    }

    
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	
    public Object visitClassOrInterfaceModifier(JavaParser.ClassOrInterfaceModifierContext ctx) {
        return emitXmlElement("ClassOrInterfaceModifier", ctx);
    }

    
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	
    public Object visitEnumConstantName(JavaParser.EnumConstantNameContext ctx) {
        return emitXmlElement("EnumConstantName", ctx);
    }

    
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	
    public Object visitModifier(JavaParser.ModifierContext ctx) {
        return emitXmlElement("Modifier", ctx);
    }

    
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	
    public Object visitInnerCreator(JavaParser.InnerCreatorContext ctx) {
        return emitXmlElement("InnerCreator", ctx);
    }

    
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	
    public Object visitExplicitGenericInvocationSuffix(JavaParser.ExplicitGenericInvocationSuffixContext ctx) {
        return emitXmlElement("ExplicitGenericInvocationSuffix", ctx);
    }

    
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	
    public Object visitVariableModifier(JavaParser.VariableModifierContext ctx) {
        return emitXmlElement("VariableModifier", ctx);
    }

    
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	
    public Object visitElementValuePair(JavaParser.ElementValuePairContext ctx) {
        return emitXmlElement("ElementValuePair", ctx);
    }

    
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	
    public Object visitArrayInitializer(JavaParser.ArrayInitializerContext ctx) {
        return emitXmlElement("ArrayInitializer", ctx);
    }

    
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	
    public Object visitElementValue(JavaParser.ElementValueContext ctx) {
        return emitXmlElement("ElementValue", ctx);
    }

    
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	
    public Object visitConstDeclaration(JavaParser.ConstDeclarationContext ctx) {
        return emitXmlElement("ConstDeclaration", ctx);
    }

    
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	
    public Object visitResource(JavaParser.ResourceContext ctx) {
        return emitXmlElement("Resource", ctx);
    }

    
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	
    public Object visitQualifiedName(JavaParser.QualifiedNameContext ctx) {
        return emitXmlElement("QualifiedName", ctx);
    }

    
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	
    public Object visitResourceSpecification(JavaParser.ResourceSpecificationContext ctx) {
        return emitXmlElement("ResourceSpecification", ctx);
    }

    
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	
    public Object visitFormalParameterList(JavaParser.FormalParameterListContext ctx) {
        return emitXmlElement("FormalParameterList", ctx);
    }

    
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	
    public Object visitAnnotationTypeDeclaration(JavaParser.AnnotationTypeDeclarationContext ctx) {
        return emitXmlElement("AnnotationTypeDeclaration", ctx);
    }

    
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	
    public Object visitAnnotationMethodRest(JavaParser.AnnotationMethodRestContext ctx) {
        return emitXmlElement("AnnotationMethodRest", ctx);
    }

    
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	
    public Object visitSwitchBlockStatementGroup(JavaParser.SwitchBlockStatementGroupContext ctx) {
        return emitXmlElement("SwitchBlockStatementGroup", ctx);
    }

    
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	
    public Object visitTypeParameter(JavaParser.TypeParameterContext ctx) {
        return emitXmlElement("TypeParameter", ctx);
    }

    
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	
    public Object visitInterfaceBody(JavaParser.InterfaceBodyContext ctx) {
        return emitXmlElement("InterfaceBody", ctx);
    }

    
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	
    public Object visitMethodDeclaration(JavaParser.MethodDeclarationContext ctx) {
        return emitXmlElement("MethodDeclaration", ctx);
    }

    
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	
    public Object visitMethodBody(JavaParser.MethodBodyContext ctx) {
        return emitXmlElement("MethodBody", ctx);
    }

    
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	
    public Object visitTypeArgument(JavaParser.TypeArgumentContext ctx) {
        return emitXmlElement("TypeArgument", ctx);
    }

    
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	
    public Object visitTypeDeclaration(JavaParser.TypeDeclarationContext ctx) {
        return emitXmlElement("TypeDeclaration", ctx);
    }

    
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	
    public Object visitGenericConstructorDeclaration(JavaParser.GenericConstructorDeclarationContext ctx) {
        return emitXmlElement("GenericConstructorDeclaration", ctx);
    }

    
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	
    public Object visitClassDeclaration(JavaParser.ClassDeclarationContext ctx) {
        return emitXmlElement("ClassDeclaration", ctx);
    }

    
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	
    public Object visitEnumConstant(JavaParser.EnumConstantContext ctx) {
        return emitXmlElement("EnumConstant", ctx);
    }

    
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	
    public Object visitStatement(JavaParser.StatementContext ctx) {
        return emitXmlElement("Statement", ctx);
    }

    
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	
    public Object visitImportDeclaration(JavaParser.ImportDeclarationContext ctx) {
        return emitXmlElement("ImportDeclaration", ctx);
    }

    
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	
    public Object visitPrimitiveType(JavaParser.PrimitiveTypeContext ctx) {
        return emitXmlElement("PrimitiveType", ctx);
    }

    
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	
    public Object visitInterfaceDeclaration(JavaParser.InterfaceDeclarationContext ctx) {
        return emitXmlElement("InterfaceDeclaration", ctx);
    }

    
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	
    public Object visitLocalVariableDeclarationStatement(JavaParser.LocalVariableDeclarationStatementContext ctx) {
        return emitXmlElement("LocalVariableDeclarationStatement", ctx);
    }

    
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	
    public Object visitBlockStatement(JavaParser.BlockStatementContext ctx) {
        return emitXmlElement("BlockStatement", ctx);
    }

    
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	
    public Object visitFieldDeclaration(JavaParser.FieldDeclarationContext ctx) {
        return emitXmlElement("FieldDeclaration", ctx);
    }

    
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	
    public Object visitConstantDeclarator(JavaParser.ConstantDeclaratorContext ctx) {
        return emitXmlElement("ConstantDeclarator", ctx);
    }

    
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	
    public Object visitResources(JavaParser.ResourcesContext ctx) {
        return emitXmlElement("Resources", ctx);
    }

    
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	
    public Object visitStatementExpression(JavaParser.StatementExpressionContext ctx) {
        return emitXmlElement("StatementExpression", ctx);
    }

    
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	
    public Object visitInterfaceMethodDeclaration(JavaParser.InterfaceMethodDeclarationContext ctx) {
        return emitXmlElement("InterfaceMethodDeclaration", ctx);
    }

    
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	
    public Object visitPackageDeclaration(JavaParser.PackageDeclarationContext ctx) {
        return emitXmlElement("PackageDeclaration", ctx);
    }

    
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	
    public Object visitElementValuePairs(JavaParser.ElementValuePairsContext ctx) {
        return emitXmlElement("ElementValuePairs", ctx);
    }

    
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	
    public Object visitLocalVariableDeclaration(JavaParser.LocalVariableDeclarationContext ctx) {
        return emitXmlElement("LocalVariableDeclaration", ctx);
    }

    
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	
    public Object visitNonWildcardTypeArguments(JavaParser.NonWildcardTypeArgumentsContext ctx) {
        return emitXmlElement("NonWildcardTypeArguments", ctx);
    }

    
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	
    public Object visitInterfaceMemberDeclaration(JavaParser.InterfaceMemberDeclarationContext ctx) {
        return emitXmlElement("InterfaceMemberDeclaration", ctx);
    }

    
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	
    public Object visitSwitchLabel(JavaParser.SwitchLabelContext ctx) {
        return emitXmlElement("SwitchLabel", ctx);
    }

    
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	
    public Object visitForInit(JavaParser.ForInitContext ctx) {
        return emitXmlElement("ForInit", ctx);
    }

    
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	
    public Object visitFormalParameters(JavaParser.FormalParametersContext ctx) {
        return emitXmlElement("FormalParameters", ctx);
    }

    
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	
    public Object visitArguments(JavaParser.ArgumentsContext ctx) {
        return emitXmlElement("Arguments", ctx);
    }

    
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	
    public Object visitGenericMethodDeclaration(JavaParser.GenericMethodDeclarationContext ctx) {
        return emitXmlElement("GenericMethodDeclaration", ctx);
    }

    
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	
    public Object visitTypeArgumentsOrDiamond(JavaParser.TypeArgumentsOrDiamondContext ctx) {
        return emitXmlElement("TypeArgumentsOrDiamond", ctx);
    }

    
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	
    public Object visitCompilationUnit(JavaParser.CompilationUnitContext ctx) {
        return emitXmlElement("CompilationUnit", ctx);
    }
}
}
