/*
 *  JavaSharp, a free Java to C# translator based on ANTLRv4
 *  Copyright (C) 2014-2015  Philip van Oosten
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
package javasharp;

import java.util.List;
import java.util.logging.Level;
import java.util.logging.Logger;
import org.antlr.v4.runtime.BufferedTokenStream;
import org.antlr.v4.runtime.ParserRuleContext;
import org.antlr.v4.runtime.Token;
import org.antlr.v4.runtime.TokenSource;
import org.antlr.v4.runtime.tree.AbstractParseTreeVisitor;
import org.antlr.v4.runtime.tree.TerminalNode;
import org.xml.sax.Attributes;
import org.xml.sax.ContentHandler;
import org.xml.sax.SAXException;
import org.xml.sax.helpers.AttributesImpl;

class XmlEmittingVisitor extends AbstractParseTreeVisitor<Object> implements JavaVisitor<Object> {

    private final BufferedTokenStream bufferedTokenStream;
    private final ContentHandler contentHandler;
    private static final Attributes noAtts = new AttributesImpl();
    private int cursor;

    XmlEmittingVisitor(ContentHandler contentHandler, BufferedTokenStream bufferedTokenStream) {
        this.contentHandler = contentHandler;
        this.bufferedTokenStream = bufferedTokenStream;
        cursor = -1;
    }

    private Object emitXmlElement(String elementName, ParserRuleContext ctx) throws RuntimeException {
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

    @Override
    public Object visitTerminal(TerminalNode node) {
        Token symbol = node.getSymbol();
        int tokenIndex = symbol.getTokenIndex();
        emitComments(tokenIndex);
        TokenSource tokenSource = symbol.getTokenSource();
        emitToken("Symbol", symbol);
        return null;
    }

    @Override
    public Object visitMemberDeclaration(JavaParser.MemberDeclarationContext ctx) {
        return emitXmlElement("MemberDeclaration", ctx);
    }

    @Override
    public Object visitDefaultValue(JavaParser.DefaultValueContext ctx) {
        return emitXmlElement("DefaultValue", ctx);
    }

    @Override
    public Object visitAnnotationTypeElementDeclaration(JavaParser.AnnotationTypeElementDeclarationContext ctx) {
        return emitXmlElement("AnnotationTypeElementDeclaration", ctx);
    }

    @Override
    public Object visitType(JavaParser.TypeContext ctx) {
        return emitXmlElement("Type", ctx);
    }

    @Override
    public Object visitAnnotationTypeBody(JavaParser.AnnotationTypeBodyContext ctx) {
        return emitXmlElement("AnnotationTypeBody", ctx);
    }

    @Override
    public Object visitGenericInterfaceMethodDeclaration(JavaParser.GenericInterfaceMethodDeclarationContext ctx) {
        return emitXmlElement("GenericInterfaceMethodDeclaration", ctx);
    }

    @Override
    public Object visitClassBodyDeclaration(JavaParser.ClassBodyDeclarationContext ctx) {
        return emitXmlElement("ClassBodyDeclaration", ctx);
    }

    @Override
    public Object visitBlock(JavaParser.BlockContext ctx) {
        return emitXmlElement("Block", ctx);
    }

    @Override
    public Object visitEnumBodyDeclarations(JavaParser.EnumBodyDeclarationsContext ctx) {
        return emitXmlElement("EnumBodyDeclarations", ctx);
    }

    @Override
    public Object visitForUpdate(JavaParser.ForUpdateContext ctx) {
        return emitXmlElement("ForUpdate", ctx);
    }

    @Override
    public Object visitEnhancedForControl(JavaParser.EnhancedForControlContext ctx) {
        return emitXmlElement("EnhancedForControl", ctx);
    }

    @Override
    public Object visitAnnotationConstantRest(JavaParser.AnnotationConstantRestContext ctx) {
        return emitXmlElement("AnnotationConstantRest", ctx);
    }

    @Override
    public Object visitExplicitGenericInvocation(JavaParser.ExplicitGenericInvocationContext ctx) {
        return emitXmlElement("ExplicitGenericInvocation", ctx);
    }

    @Override
    public Object visitNonWildcardTypeArgumentsOrDiamond(JavaParser.NonWildcardTypeArgumentsOrDiamondContext ctx) {
        return emitXmlElement("NonWildcardTypeArgumentsOrDiamond", ctx);
    }

    @Override
    public Object visitExpressionList(JavaParser.ExpressionListContext ctx) {
        return emitXmlElement("ExpressionList", ctx);
    }

    @Override
    public Object visitAnnotationTypeElementRest(JavaParser.AnnotationTypeElementRestContext ctx) {
        return emitXmlElement("AnnotationTypeElementRest", ctx);
    }

    @Override
    public Object visitClassOrInterfaceType(JavaParser.ClassOrInterfaceTypeContext ctx) {
        return emitXmlElement("ClassOrInterfaceType", ctx);
    }

    @Override
    public Object visitTypeBound(JavaParser.TypeBoundContext ctx) {
        return emitXmlElement("TypeBound", ctx);
    }

    @Override
    public Object visitVariableDeclaratorId(JavaParser.VariableDeclaratorIdContext ctx) {
        return emitXmlElement("VariableDeclaratorId", ctx);
    }

    @Override
    public Object visitPrimary(JavaParser.PrimaryContext ctx) {
        return emitXmlElement("Primary", ctx);
    }

    @Override
    public Object visitClassCreatorRest(JavaParser.ClassCreatorRestContext ctx) {
        return emitXmlElement("ClassCreatorRest", ctx);
    }

    @Override
    public Object visitInterfaceBodyDeclaration(JavaParser.InterfaceBodyDeclarationContext ctx) {
        return emitXmlElement("InterfaceBodyDeclaration", ctx);
    }

    @Override
    public Object visitTypeArguments(JavaParser.TypeArgumentsContext ctx) {
        return emitXmlElement("TypeArguments", ctx);
    }

    @Override
    public Object visitAnnotationName(JavaParser.AnnotationNameContext ctx) {
        return emitXmlElement("AnnotationName", ctx);
    }

    @Override
    public Object visitFinallyBlock(JavaParser.FinallyBlockContext ctx) {
        return emitXmlElement("FinallyBlock", ctx);
    }

    @Override
    public Object visitTypeParameters(JavaParser.TypeParametersContext ctx) {
        return emitXmlElement("TypeParameters", ctx);
    }

    @Override
    public Object visitLastFormalParameter(JavaParser.LastFormalParameterContext ctx) {
        return emitXmlElement("LastFormalParameter", ctx);
    }

    @Override
    public Object visitConstructorBody(JavaParser.ConstructorBodyContext ctx) {
        return emitXmlElement("ConstructorBody", ctx);
    }

    @Override
    public Object visitLiteral(JavaParser.LiteralContext ctx) {
        return emitXmlElement("Literal", ctx);
    }

    @Override
    public Object visitAnnotationMethodOrConstantRest(JavaParser.AnnotationMethodOrConstantRestContext ctx) {
        return emitXmlElement("AnnotationMethodOrConstantRest", ctx);
    }

    @Override
    public Object visitCatchClause(JavaParser.CatchClauseContext ctx) {
        return emitXmlElement("CatchClause", ctx);
    }

    @Override
    public Object visitVariableDeclarator(JavaParser.VariableDeclaratorContext ctx) {
        return emitXmlElement("VariableDeclarator", ctx);
    }

    @Override
    public Object visitTypeList(JavaParser.TypeListContext ctx) {
        return emitXmlElement("TypeList", ctx);
    }

    @Override
    public Object visitEnumConstants(JavaParser.EnumConstantsContext ctx) {
        return emitXmlElement("EnumConstants", ctx);
    }

    @Override
    public Object visitClassBody(JavaParser.ClassBodyContext ctx) {
        return emitXmlElement("ClassBody", ctx);
    }

    @Override
    public Object visitCreatedName(JavaParser.CreatedNameContext ctx) {
        return emitXmlElement("CreatedName", ctx);
    }

    @Override
    public Object visitEnumDeclaration(JavaParser.EnumDeclarationContext ctx) {
        return emitXmlElement("EnumDeclaration", ctx);
    }

    @Override
    public Object visitFormalParameter(JavaParser.FormalParameterContext ctx) {
        return emitXmlElement("FormalParameter", ctx);
    }

    @Override
    public Object visitParExpression(JavaParser.ParExpressionContext ctx) {
        return emitXmlElement("ParExpression", ctx);
    }

    @Override
    public Object visitAnnotation(JavaParser.AnnotationContext ctx) {
        return emitXmlElement("Annotation", ctx);
    }

    @Override
    public Object visitVariableInitializer(JavaParser.VariableInitializerContext ctx) {
        return emitXmlElement("VariableInitializer", ctx);
    }

    @Override
    public Object visitElementValueArrayInitializer(JavaParser.ElementValueArrayInitializerContext ctx) {
        return emitXmlElement("ElementValueArrayInitializer", ctx);
    }

    @Override
    public Object visitCreator(JavaParser.CreatorContext ctx) {
        return emitXmlElement("Creator", ctx);
    }

    @Override
    public Object visitArrayCreatorRest(JavaParser.ArrayCreatorRestContext ctx) {
        return emitXmlElement("ArrayCreatorRest", ctx);
    }

    @Override
    public Object visitExpression(JavaParser.ExpressionContext ctx) {
        return emitXmlElement("Expression", ctx);
    }

    @Override
    public Object visitConstantExpression(JavaParser.ConstantExpressionContext ctx) {
        return emitXmlElement("ConstantExpression", ctx);
    }

    @Override
    public Object visitQualifiedNameList(JavaParser.QualifiedNameListContext ctx) {
        return emitXmlElement("QualifiedNameList", ctx);
    }

    @Override
    public Object visitConstructorDeclaration(JavaParser.ConstructorDeclarationContext ctx) {
        return emitXmlElement("ConstructorDeclaration", ctx);
    }

    @Override
    public Object visitForControl(JavaParser.ForControlContext ctx) {
        return emitXmlElement("ForControl", ctx);
    }

    @Override
    public Object visitSuperSuffix(JavaParser.SuperSuffixContext ctx) {
        return emitXmlElement("SuperSuffix", ctx);
    }

    @Override
    public Object visitVariableDeclarators(JavaParser.VariableDeclaratorsContext ctx) {
        return emitXmlElement("VariableDeclarators", ctx);
    }

    @Override
    public Object visitCatchType(JavaParser.CatchTypeContext ctx) {
        return emitXmlElement("CatchType", ctx);
    }

    @Override
    public Object visitClassOrInterfaceModifier(JavaParser.ClassOrInterfaceModifierContext ctx) {
        return emitXmlElement("ClassOrInterfaceModifier", ctx);
    }

    @Override
    public Object visitEnumConstantName(JavaParser.EnumConstantNameContext ctx) {
        return emitXmlElement("EnumConstantName", ctx);
    }

    @Override
    public Object visitModifier(JavaParser.ModifierContext ctx) {
        return emitXmlElement("Modifier", ctx);
    }

    @Override
    public Object visitInnerCreator(JavaParser.InnerCreatorContext ctx) {
        return emitXmlElement("InnerCreator", ctx);
    }

    @Override
    public Object visitExplicitGenericInvocationSuffix(JavaParser.ExplicitGenericInvocationSuffixContext ctx) {
        return emitXmlElement("ExplicitGenericInvocationSuffix", ctx);
    }

    @Override
    public Object visitVariableModifier(JavaParser.VariableModifierContext ctx) {
        return emitXmlElement("VariableModifier", ctx);
    }

    @Override
    public Object visitElementValuePair(JavaParser.ElementValuePairContext ctx) {
        return emitXmlElement("ElementValuePair", ctx);
    }

    @Override
    public Object visitArrayInitializer(JavaParser.ArrayInitializerContext ctx) {
        return emitXmlElement("ArrayInitializer", ctx);
    }

    @Override
    public Object visitElementValue(JavaParser.ElementValueContext ctx) {
        return emitXmlElement("ElementValue", ctx);
    }

    @Override
    public Object visitConstDeclaration(JavaParser.ConstDeclarationContext ctx) {
        return emitXmlElement("ConstDeclaration", ctx);
    }

    @Override
    public Object visitResource(JavaParser.ResourceContext ctx) {
        return emitXmlElement("Resource", ctx);
    }

    @Override
    public Object visitQualifiedName(JavaParser.QualifiedNameContext ctx) {
        return emitXmlElement("QualifiedName", ctx);
    }

    @Override
    public Object visitResourceSpecification(JavaParser.ResourceSpecificationContext ctx) {
        return emitXmlElement("ResourceSpecification", ctx);
    }

    @Override
    public Object visitFormalParameterList(JavaParser.FormalParameterListContext ctx) {
        return emitXmlElement("FormalParameterList", ctx);
    }

    @Override
    public Object visitAnnotationTypeDeclaration(JavaParser.AnnotationTypeDeclarationContext ctx) {
        return emitXmlElement("AnnotationTypeDeclaration", ctx);
    }

    @Override
    public Object visitAnnotationMethodRest(JavaParser.AnnotationMethodRestContext ctx) {
        return emitXmlElement("AnnotationMethodRest", ctx);
    }

    @Override
    public Object visitSwitchBlockStatementGroup(JavaParser.SwitchBlockStatementGroupContext ctx) {
        return emitXmlElement("SwitchBlockStatementGroup", ctx);
    }

    @Override
    public Object visitTypeParameter(JavaParser.TypeParameterContext ctx) {
        return emitXmlElement("TypeParameter", ctx);
    }

    @Override
    public Object visitInterfaceBody(JavaParser.InterfaceBodyContext ctx) {
        return emitXmlElement("InterfaceBody", ctx);
    }

    @Override
    public Object visitMethodDeclaration(JavaParser.MethodDeclarationContext ctx) {
        return emitXmlElement("MethodDeclaration", ctx);
    }

    @Override
    public Object visitMethodBody(JavaParser.MethodBodyContext ctx) {
        return emitXmlElement("MethodBody", ctx);
    }

    @Override
    public Object visitTypeArgument(JavaParser.TypeArgumentContext ctx) {
        return emitXmlElement("TypeArgument", ctx);
    }

    @Override
    public Object visitTypeDeclaration(JavaParser.TypeDeclarationContext ctx) {
        return emitXmlElement("TypeDeclaration", ctx);
    }

    @Override
    public Object visitGenericConstructorDeclaration(JavaParser.GenericConstructorDeclarationContext ctx) {
        return emitXmlElement("GenericConstructorDeclaration", ctx);
    }

    @Override
    public Object visitClassDeclaration(JavaParser.ClassDeclarationContext ctx) {
        return emitXmlElement("ClassDeclaration", ctx);
    }

    @Override
    public Object visitEnumConstant(JavaParser.EnumConstantContext ctx) {
        return emitXmlElement("EnumConstant", ctx);
    }

    @Override
    public Object visitStatement(JavaParser.StatementContext ctx) {
        return emitXmlElement("Statement", ctx);
    }

    @Override
    public Object visitImportDeclaration(JavaParser.ImportDeclarationContext ctx) {
        return emitXmlElement("ImportDeclaration", ctx);
    }

    @Override
    public Object visitPrimitiveType(JavaParser.PrimitiveTypeContext ctx) {
        return emitXmlElement("PrimitiveType", ctx);
    }

    @Override
    public Object visitInterfaceDeclaration(JavaParser.InterfaceDeclarationContext ctx) {
        return emitXmlElement("InterfaceDeclaration", ctx);
    }

    @Override
    public Object visitLocalVariableDeclarationStatement(JavaParser.LocalVariableDeclarationStatementContext ctx) {
        return emitXmlElement("LocalVariableDeclarationStatement", ctx);
    }

    @Override
    public Object visitBlockStatement(JavaParser.BlockStatementContext ctx) {
        return emitXmlElement("BlockStatement", ctx);
    }

    @Override
    public Object visitFieldDeclaration(JavaParser.FieldDeclarationContext ctx) {
        return emitXmlElement("FieldDeclaration", ctx);
    }

    @Override
    public Object visitConstantDeclarator(JavaParser.ConstantDeclaratorContext ctx) {
        return emitXmlElement("ConstantDeclarator", ctx);
    }

    @Override
    public Object visitResources(JavaParser.ResourcesContext ctx) {
        return emitXmlElement("Resources", ctx);
    }

    @Override
    public Object visitStatementExpression(JavaParser.StatementExpressionContext ctx) {
        return emitXmlElement("StatementExpression", ctx);
    }

    @Override
    public Object visitInterfaceMethodDeclaration(JavaParser.InterfaceMethodDeclarationContext ctx) {
        return emitXmlElement("InterfaceMethodDeclaration", ctx);
    }

    @Override
    public Object visitPackageDeclaration(JavaParser.PackageDeclarationContext ctx) {
        return emitXmlElement("PackageDeclaration", ctx);
    }

    @Override
    public Object visitElementValuePairs(JavaParser.ElementValuePairsContext ctx) {
        return emitXmlElement("ElementValuePairs", ctx);
    }

    @Override
    public Object visitLocalVariableDeclaration(JavaParser.LocalVariableDeclarationContext ctx) {
        return emitXmlElement("LocalVariableDeclaration", ctx);
    }

    @Override
    public Object visitNonWildcardTypeArguments(JavaParser.NonWildcardTypeArgumentsContext ctx) {
        return emitXmlElement("NonWildcardTypeArguments", ctx);
    }

    @Override
    public Object visitInterfaceMemberDeclaration(JavaParser.InterfaceMemberDeclarationContext ctx) {
        return emitXmlElement("InterfaceMemberDeclaration", ctx);
    }

    @Override
    public Object visitSwitchLabel(JavaParser.SwitchLabelContext ctx) {
        return emitXmlElement("SwitchLabel", ctx);
    }

    @Override
    public Object visitForInit(JavaParser.ForInitContext ctx) {
        return emitXmlElement("ForInit", ctx);
    }

    @Override
    public Object visitFormalParameters(JavaParser.FormalParametersContext ctx) {
        return emitXmlElement("FormalParameters", ctx);
    }

    @Override
    public Object visitArguments(JavaParser.ArgumentsContext ctx) {
        return emitXmlElement("Arguments", ctx);
    }

    @Override
    public Object visitGenericMethodDeclaration(JavaParser.GenericMethodDeclarationContext ctx) {
        return emitXmlElement("GenericMethodDeclaration", ctx);
    }

    @Override
    public Object visitTypeArgumentsOrDiamond(JavaParser.TypeArgumentsOrDiamondContext ctx) {
        return emitXmlElement("TypeArgumentsOrDiamond", ctx);
    }

    @Override
    public Object visitCompilationUnit(JavaParser.CompilationUnitContext ctx) {
        return emitXmlElement("CompilationUnit", ctx);
    }
}
