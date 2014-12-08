// Generated from Java.g4 by ANTLR 4.3
using org.antlr.v4.runtime.misc.NotNull;
using org.antlr.v4.runtime.tree.ParseTreeVisitor;

namespace javasharp
{ 
/**
 * This interface defines a complete generic visitor for a parse tree produced
 * by {@link JavaParser}.
 *
 * @param <T> The return type of the visit operation. Use {@link Void} for
 * operations with no return type.
 */ public  { INTERFACE |
    interface
}

JavaVisitor<T> {
EXTENDS |extends }
ParseTreeVisitor<T> {
/**
	 * Visit a parse tree produced by {@link JavaParser#memberDeclaration}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */T visitMemberDeclaration(
{
    AT |  @
}

NotNull JavaParser.MemberDeclarationContext ctx);
/**
	 * Visit a parse tree produced by {@link JavaParser#defaultValue}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */T visitDefaultValue(
{
    AT |  @
}

NotNull JavaParser.DefaultValueContext ctx);
/**
	 * Visit a parse tree produced by {@link JavaParser#annotationTypeElementDeclaration}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */T visitAnnotationTypeElementDeclaration(
{
    AT |  @
}

NotNull JavaParser.AnnotationTypeElementDeclarationContext ctx);
/**
	 * Visit a parse tree produced by {@link JavaParser#type}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */T visitType(
{
    AT |  @
}

NotNull JavaParser.TypeContext ctx);
/**
	 * Visit a parse tree produced by {@link JavaParser#annotationTypeBody}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */T visitAnnotationTypeBody(
{
    AT |  @
}

NotNull JavaParser.AnnotationTypeBodyContext ctx);
/**
	 * Visit a parse tree produced by {@link JavaParser#genericInterfaceMethodDeclaration}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */T visitGenericInterfaceMethodDeclaration(
{
    AT |  @
}

NotNull JavaParser.GenericInterfaceMethodDeclarationContext ctx);
/**
	 * Visit a parse tree produced by {@link JavaParser#classBodyDeclaration}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */T visitClassBodyDeclaration(
{
    AT |  @
}

NotNull JavaParser.ClassBodyDeclarationContext ctx);
/**
	 * Visit a parse tree produced by {@link JavaParser#block}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */T visitBlock(
{
    AT |  @
}

NotNull JavaParser.BlockContext ctx);
/**
	 * Visit a parse tree produced by {@link JavaParser#enumBodyDeclarations}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */T visitEnumBodyDeclarations(
{
    AT |  @
}

NotNull JavaParser.EnumBodyDeclarationsContext ctx);
/**
	 * Visit a parse tree produced by {@link JavaParser#forUpdate}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */T visitForUpdate(
{
    AT |  @
}

NotNull JavaParser.ForUpdateContext ctx);
/**
	 * Visit a parse tree produced by {@link JavaParser#enhancedForControl}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */T visitEnhancedForControl(
{
    AT |  @
}

NotNull JavaParser.EnhancedForControlContext ctx);
/**
	 * Visit a parse tree produced by {@link JavaParser#annotationConstantRest}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */T visitAnnotationConstantRest(
{
    AT |  @
}

NotNull JavaParser.AnnotationConstantRestContext ctx);
/**
	 * Visit a parse tree produced by {@link JavaParser#explicitGenericInvocation}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */T visitExplicitGenericInvocation(
{
    AT |  @
}

NotNull JavaParser.ExplicitGenericInvocationContext ctx);
/**
	 * Visit a parse tree produced by {@link JavaParser#nonWildcardTypeArgumentsOrDiamond}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */T visitNonWildcardTypeArgumentsOrDiamond(
{
    AT |  @
}

NotNull JavaParser.NonWildcardTypeArgumentsOrDiamondContext ctx);
/**
	 * Visit a parse tree produced by {@link JavaParser#expressionList}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */T visitExpressionList(
{
    AT |  @
}

NotNull JavaParser.ExpressionListContext ctx);
/**
	 * Visit a parse tree produced by {@link JavaParser#annotationTypeElementRest}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */T visitAnnotationTypeElementRest(
{
    AT |  @
}

NotNull JavaParser.AnnotationTypeElementRestContext ctx);
/**
	 * Visit a parse tree produced by {@link JavaParser#classOrInterfaceType}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */T visitClassOrInterfaceType(
{
    AT |  @
}

NotNull JavaParser.ClassOrInterfaceTypeContext ctx);
/**
	 * Visit a parse tree produced by {@link JavaParser#typeBound}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */T visitTypeBound(
{
    AT |  @
}

NotNull JavaParser.TypeBoundContext ctx);
/**
	 * Visit a parse tree produced by {@link JavaParser#variableDeclaratorId}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */T visitVariableDeclaratorId(
{
    AT |  @
}

NotNull JavaParser.VariableDeclaratorIdContext ctx);
/**
	 * Visit a parse tree produced by {@link JavaParser#primary}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */T visitPrimary(
{
    AT |  @
}

NotNull JavaParser.PrimaryContext ctx);
/**
	 * Visit a parse tree produced by {@link JavaParser#classCreatorRest}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */T visitClassCreatorRest(
{
    AT |  @
}

NotNull JavaParser.ClassCreatorRestContext ctx);
/**
	 * Visit a parse tree produced by {@link JavaParser#interfaceBodyDeclaration}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */T visitInterfaceBodyDeclaration(
{
    AT |  @
}

NotNull JavaParser.InterfaceBodyDeclarationContext ctx);
/**
	 * Visit a parse tree produced by {@link JavaParser#typeArguments}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */T visitTypeArguments(
{
    AT |  @
}

NotNull JavaParser.TypeArgumentsContext ctx);
/**
	 * Visit a parse tree produced by {@link JavaParser#annotationName}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */T visitAnnotationName(
{
    AT |  @
}

NotNull JavaParser.AnnotationNameContext ctx);
/**
	 * Visit a parse tree produced by {@link JavaParser#finallyBlock}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */T visitFinallyBlock(
{
    AT |  @
}

NotNull JavaParser.FinallyBlockContext ctx);
/**
	 * Visit a parse tree produced by {@link JavaParser#typeParameters}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */T visitTypeParameters(
{
    AT |  @
}

NotNull JavaParser.TypeParametersContext ctx);
/**
	 * Visit a parse tree produced by {@link JavaParser#lastFormalParameter}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */T visitLastFormalParameter(
{
    AT |  @
}

NotNull JavaParser.LastFormalParameterContext ctx);
/**
	 * Visit a parse tree produced by {@link JavaParser#constructorBody}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */T visitConstructorBody(
{
    AT |  @
}

NotNull JavaParser.ConstructorBodyContext ctx);
/**
	 * Visit a parse tree produced by {@link JavaParser#literal}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */T visitLiteral(
{
    AT |  @
}

NotNull JavaParser.LiteralContext ctx);
/**
	 * Visit a parse tree produced by {@link JavaParser#annotationMethodOrConstantRest}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */T visitAnnotationMethodOrConstantRest(
{
    AT |  @
}

NotNull JavaParser.AnnotationMethodOrConstantRestContext ctx);
/**
	 * Visit a parse tree produced by {@link JavaParser#catchClause}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */T visitCatchClause(
{
    AT |  @
}

NotNull JavaParser.CatchClauseContext ctx);
/**
	 * Visit a parse tree produced by {@link JavaParser#variableDeclarator}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */T visitVariableDeclarator(
{
    AT |  @
}

NotNull JavaParser.VariableDeclaratorContext ctx);
/**
	 * Visit a parse tree produced by {@link JavaParser#typeList}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */T visitTypeList(
{
    AT |  @
}

NotNull JavaParser.TypeListContext ctx);
/**
	 * Visit a parse tree produced by {@link JavaParser#enumConstants}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */T visitEnumConstants(
{
    AT |  @
}

NotNull JavaParser.EnumConstantsContext ctx);
/**
	 * Visit a parse tree produced by {@link JavaParser#classBody}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */T visitClassBody(
{
    AT |  @
}

NotNull JavaParser.ClassBodyContext ctx);
/**
	 * Visit a parse tree produced by {@link JavaParser#createdName}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */T visitCreatedName(
{
    AT |  @
}

NotNull JavaParser.CreatedNameContext ctx);
/**
	 * Visit a parse tree produced by {@link JavaParser#enumDeclaration}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */T visitEnumDeclaration(
{
    AT |  @
}

NotNull JavaParser.EnumDeclarationContext ctx);
/**
	 * Visit a parse tree produced by {@link JavaParser#formalParameter}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */T visitFormalParameter(
{
    AT |  @
}

NotNull JavaParser.FormalParameterContext ctx);
/**
	 * Visit a parse tree produced by {@link JavaParser#parExpression}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */T visitParExpression(
{
    AT |  @
}

NotNull JavaParser.ParExpressionContext ctx);
/**
	 * Visit a parse tree produced by {@link JavaParser#annotation}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */T visitAnnotation(
{
    AT |  @
}

NotNull JavaParser.AnnotationContext ctx);
/**
	 * Visit a parse tree produced by {@link JavaParser#variableInitializer}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */T visitVariableInitializer(
{
    AT |  @
}

NotNull JavaParser.VariableInitializerContext ctx);
/**
	 * Visit a parse tree produced by {@link JavaParser#elementValueArrayInitializer}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */T visitElementValueArrayInitializer(
{
    AT |  @
}

NotNull JavaParser.ElementValueArrayInitializerContext ctx);
/**
	 * Visit a parse tree produced by {@link JavaParser#creator}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */T visitCreator(
{
    AT |  @
}

NotNull JavaParser.CreatorContext ctx);
/**
	 * Visit a parse tree produced by {@link JavaParser#arrayCreatorRest}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */T visitArrayCreatorRest(
{
    AT |  @
}

NotNull JavaParser.ArrayCreatorRestContext ctx);
/**
	 * Visit a parse tree produced by {@link JavaParser#expression}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */T visitExpression(
{
    AT |  @
}

NotNull JavaParser.ExpressionContext ctx);
/**
	 * Visit a parse tree produced by {@link JavaParser#constantExpression}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */T visitConstantExpression(
{
    AT |  @
}

NotNull JavaParser.ConstantExpressionContext ctx);
/**
	 * Visit a parse tree produced by {@link JavaParser#qualifiedNameList}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */T visitQualifiedNameList(
{
    AT |  @
}

NotNull JavaParser.QualifiedNameListContext ctx);
/**
	 * Visit a parse tree produced by {@link JavaParser#constructorDeclaration}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */T visitConstructorDeclaration(
{
    AT |  @
}

NotNull JavaParser.ConstructorDeclarationContext ctx);
/**
	 * Visit a parse tree produced by {@link JavaParser#forControl}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */T visitForControl(
{
    AT |  @
}

NotNull JavaParser.ForControlContext ctx);
/**
	 * Visit a parse tree produced by {@link JavaParser#superSuffix}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */T visitSuperSuffix(
{
    AT |  @
}

NotNull JavaParser.SuperSuffixContext ctx);
/**
	 * Visit a parse tree produced by {@link JavaParser#variableDeclarators}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */T visitVariableDeclarators(
{
    AT |  @
}

NotNull JavaParser.VariableDeclaratorsContext ctx);
/**
	 * Visit a parse tree produced by {@link JavaParser#catchType}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */T visitCatchType(
{
    AT |  @
}

NotNull JavaParser.CatchTypeContext ctx);
/**
	 * Visit a parse tree produced by {@link JavaParser#classOrInterfaceModifier}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */T visitClassOrInterfaceModifier(
{
    AT |  @
}

NotNull JavaParser.ClassOrInterfaceModifierContext ctx);
/**
	 * Visit a parse tree produced by {@link JavaParser#enumConstantName}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */T visitEnumConstantName(
{
    AT |  @
}

NotNull JavaParser.EnumConstantNameContext ctx);
/**
	 * Visit a parse tree produced by {@link JavaParser#modifier}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */T visitModifier(
{
    AT |  @
}

NotNull JavaParser.ModifierContext ctx);
/**
	 * Visit a parse tree produced by {@link JavaParser#innerCreator}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */T visitInnerCreator(
{
    AT |  @
}

NotNull JavaParser.InnerCreatorContext ctx);
/**
	 * Visit a parse tree produced by {@link JavaParser#explicitGenericInvocationSuffix}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */T visitExplicitGenericInvocationSuffix(
{
    AT |  @
}

NotNull JavaParser.ExplicitGenericInvocationSuffixContext ctx);
/**
	 * Visit a parse tree produced by {@link JavaParser#variableModifier}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */T visitVariableModifier(
{
    AT |  @
}

NotNull JavaParser.VariableModifierContext ctx);
/**
	 * Visit a parse tree produced by {@link JavaParser#elementValuePair}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */T visitElementValuePair(
{
    AT |  @
}

NotNull JavaParser.ElementValuePairContext ctx);
/**
	 * Visit a parse tree produced by {@link JavaParser#arrayInitializer}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */T visitArrayInitializer(
{
    AT |  @
}

NotNull JavaParser.ArrayInitializerContext ctx);
/**
	 * Visit a parse tree produced by {@link JavaParser#elementValue}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */T visitElementValue(
{
    AT |  @
}

NotNull JavaParser.ElementValueContext ctx);
/**
	 * Visit a parse tree produced by {@link JavaParser#constDeclaration}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */T visitConstDeclaration(
{
    AT |  @
}

NotNull JavaParser.ConstDeclarationContext ctx);
/**
	 * Visit a parse tree produced by {@link JavaParser#resource}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */T visitResource(
{
    AT |  @
}

NotNull JavaParser.ResourceContext ctx);
/**
	 * Visit a parse tree produced by {@link JavaParser#qualifiedName}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */T visitQualifiedName(
{
    AT |  @
}

NotNull JavaParser.QualifiedNameContext ctx);
/**
	 * Visit a parse tree produced by {@link JavaParser#resourceSpecification}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */T visitResourceSpecification(
{
    AT |  @
}

NotNull JavaParser.ResourceSpecificationContext ctx);
/**
	 * Visit a parse tree produced by {@link JavaParser#formalParameterList}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */T visitFormalParameterList(
{
    AT |  @
}

NotNull JavaParser.FormalParameterListContext ctx);
/**
	 * Visit a parse tree produced by {@link JavaParser#annotationTypeDeclaration}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */T visitAnnotationTypeDeclaration(
{
    AT |  @
}

NotNull JavaParser.AnnotationTypeDeclarationContext ctx);
/**
	 * Visit a parse tree produced by {@link JavaParser#compilationUnit}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */T visitCompilationUnit(
{
    AT |  @
}

NotNull JavaParser.CompilationUnitContext ctx);
/**
	 * Visit a parse tree produced by {@link JavaParser#annotationMethodRest}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */T visitAnnotationMethodRest(
{
    AT |  @
}

NotNull JavaParser.AnnotationMethodRestContext ctx);
/**
	 * Visit a parse tree produced by {@link JavaParser#switchBlockStatementGroup}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */T visitSwitchBlockStatementGroup(
{
    AT |  @
}

NotNull JavaParser.SwitchBlockStatementGroupContext ctx);
/**
	 * Visit a parse tree produced by {@link JavaParser#typeParameter}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */T visitTypeParameter(
{
    AT |  @
}

NotNull JavaParser.TypeParameterContext ctx);
/**
	 * Visit a parse tree produced by {@link JavaParser#interfaceBody}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */T visitInterfaceBody(
{
    AT |  @
}

NotNull JavaParser.InterfaceBodyContext ctx);
/**
	 * Visit a parse tree produced by {@link JavaParser#methodDeclaration}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */T visitMethodDeclaration(
{
    AT |  @
}

NotNull JavaParser.MethodDeclarationContext ctx);
/**
	 * Visit a parse tree produced by {@link JavaParser#methodBody}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */T visitMethodBody(
{
    AT |  @
}

NotNull JavaParser.MethodBodyContext ctx);
/**
	 * Visit a parse tree produced by {@link JavaParser#typeArgument}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */T visitTypeArgument(
{
    AT |  @
}

NotNull JavaParser.TypeArgumentContext ctx);
/**
	 * Visit a parse tree produced by {@link JavaParser#typeDeclaration}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */T visitTypeDeclaration(
{
    AT |  @
}

NotNull JavaParser.TypeDeclarationContext ctx);
/**
	 * Visit a parse tree produced by {@link JavaParser#genericConstructorDeclaration}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */T visitGenericConstructorDeclaration(
{
    AT |  @
}

NotNull JavaParser.GenericConstructorDeclarationContext ctx);
/**
	 * Visit a parse tree produced by {@link JavaParser#classDeclaration}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */T visitClassDeclaration(
{
    AT |  @
}

NotNull JavaParser.ClassDeclarationContext ctx);
/**
	 * Visit a parse tree produced by {@link JavaParser#enumConstant}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */T visitEnumConstant(
{
    AT |  @
}

NotNull JavaParser.EnumConstantContext ctx);
/**
	 * Visit a parse tree produced by {@link JavaParser#statement}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */T visitStatement(
{
    AT |  @
}

NotNull JavaParser.StatementContext ctx);
/**
	 * Visit a parse tree produced by {@link JavaParser#importDeclaration}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */T visitImportDeclaration(
{
    AT |  @
}

NotNull JavaParser.ImportDeclarationContext ctx);
/**
	 * Visit a parse tree produced by {@link JavaParser#primitiveType}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */T visitPrimitiveType(
{
    AT |  @
}

NotNull JavaParser.PrimitiveTypeContext ctx);
/**
	 * Visit a parse tree produced by {@link JavaParser#interfaceDeclaration}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */T visitInterfaceDeclaration(
{
    AT |  @
}

NotNull JavaParser.InterfaceDeclarationContext ctx);
/**
	 * Visit a parse tree produced by {@link JavaParser#localVariableDeclarationStatement}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */T visitLocalVariableDeclarationStatement(
{
    AT |  @
}

NotNull JavaParser.LocalVariableDeclarationStatementContext ctx);
/**
	 * Visit a parse tree produced by {@link JavaParser#blockStatement}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */T visitBlockStatement(
{
    AT |  @
}

NotNull JavaParser.BlockStatementContext ctx);
/**
	 * Visit a parse tree produced by {@link JavaParser#fieldDeclaration}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */T visitFieldDeclaration(
{
    AT |  @
}

NotNull JavaParser.FieldDeclarationContext ctx);
/**
	 * Visit a parse tree produced by {@link JavaParser#constantDeclarator}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */T visitConstantDeclarator(
{
    AT |  @
}

NotNull JavaParser.ConstantDeclaratorContext ctx);
/**
	 * Visit a parse tree produced by {@link JavaParser#resources}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */T visitResources(
{
    AT |  @
}

NotNull JavaParser.ResourcesContext ctx);
/**
	 * Visit a parse tree produced by {@link JavaParser#statementExpression}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */T visitStatementExpression(
{
    AT |  @
}

NotNull JavaParser.StatementExpressionContext ctx);
/**
	 * Visit a parse tree produced by {@link JavaParser#interfaceMethodDeclaration}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */T visitInterfaceMethodDeclaration(
{
    AT |  @
}

NotNull JavaParser.InterfaceMethodDeclarationContext ctx);
/**
	 * Visit a parse tree produced by {@link JavaParser#packageDeclaration}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */T visitPackageDeclaration(
{
    AT |  @
}

NotNull JavaParser.PackageDeclarationContext ctx);
/**
	 * Visit a parse tree produced by {@link JavaParser#elementValuePairs}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */T visitElementValuePairs(
{
    AT |  @
}

NotNull JavaParser.ElementValuePairsContext ctx);
/**
	 * Visit a parse tree produced by {@link JavaParser#localVariableDeclaration}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */T visitLocalVariableDeclaration(
{
    AT |  @
}

NotNull JavaParser.LocalVariableDeclarationContext ctx);
/**
	 * Visit a parse tree produced by {@link JavaParser#nonWildcardTypeArguments}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */T visitNonWildcardTypeArguments(
{
    AT |  @
}

NotNull JavaParser.NonWildcardTypeArgumentsContext ctx);
/**
	 * Visit a parse tree produced by {@link JavaParser#interfaceMemberDeclaration}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */T visitInterfaceMemberDeclaration(
{
    AT |  @
}

NotNull JavaParser.InterfaceMemberDeclarationContext ctx);
/**
	 * Visit a parse tree produced by {@link JavaParser#switchLabel}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */T visitSwitchLabel(
{
    AT |  @
}

NotNull JavaParser.SwitchLabelContext ctx);
/**
	 * Visit a parse tree produced by {@link JavaParser#forInit}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */T visitForInit(
{
    AT |  @
}

NotNull JavaParser.ForInitContext ctx);
/**
	 * Visit a parse tree produced by {@link JavaParser#formalParameters}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */T visitFormalParameters(
{
    AT |  @
}

NotNull JavaParser.FormalParametersContext ctx);
/**
	 * Visit a parse tree produced by {@link JavaParser#arguments}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */T visitArguments(
{
    AT |  @
}

NotNull JavaParser.ArgumentsContext ctx);
/**
	 * Visit a parse tree produced by {@link JavaParser#genericMethodDeclaration}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */T visitGenericMethodDeclaration(
{
    AT |  @
}

NotNull JavaParser.GenericMethodDeclarationContext ctx);
/**
	 * Visit a parse tree produced by {@link JavaParser#typeArgumentsOrDiamond}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */T visitTypeArgumentsOrDiamond(
{
    AT |  @
}

NotNull JavaParser.TypeArgumentsOrDiamondContext ctx); } }
