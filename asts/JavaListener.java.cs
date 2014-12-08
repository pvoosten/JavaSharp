// Generated from Java.g4 by ANTLR 4.3
using org.antlr.v4.runtime.misc.NotNull;
using org.antlr.v4.runtime.tree.ParseTreeListener;

namespace javasharp
{ 
/**
 * This interface defines a complete listener for a parse tree produced by
 * {@link JavaParser}.
 */ public  { INTERFACE |
    interface
}

JavaListener {
EXTENDS |extends }
ParseTreeListener {
/**
	 * Enter a parse tree produced by {@link JavaParser#memberDeclaration}.
	 * @param ctx the parse tree
	 */void enterMemberDeclaration(
{
    AT |  @
}

NotNull JavaParser.MemberDeclarationContext ctx);
/**
	 * Exit a parse tree produced by {@link JavaParser#memberDeclaration}.
	 * @param ctx the parse tree
	 */void exitMemberDeclaration(
{
    AT |  @
}

NotNull JavaParser.MemberDeclarationContext ctx);
/**
	 * Enter a parse tree produced by {@link JavaParser#defaultValue}.
	 * @param ctx the parse tree
	 */void enterDefaultValue(
{
    AT |  @
}

NotNull JavaParser.DefaultValueContext ctx);
/**
	 * Exit a parse tree produced by {@link JavaParser#defaultValue}.
	 * @param ctx the parse tree
	 */void exitDefaultValue(
{
    AT |  @
}

NotNull JavaParser.DefaultValueContext ctx);
/**
	 * Enter a parse tree produced by {@link JavaParser#annotationTypeElementDeclaration}.
	 * @param ctx the parse tree
	 */void enterAnnotationTypeElementDeclaration(
{
    AT |  @
}

NotNull JavaParser.AnnotationTypeElementDeclarationContext ctx);
/**
	 * Exit a parse tree produced by {@link JavaParser#annotationTypeElementDeclaration}.
	 * @param ctx the parse tree
	 */void exitAnnotationTypeElementDeclaration(
{
    AT |  @
}

NotNull JavaParser.AnnotationTypeElementDeclarationContext ctx);
/**
	 * Enter a parse tree produced by {@link JavaParser#type}.
	 * @param ctx the parse tree
	 */void enterType(
{
    AT |  @
}

NotNull JavaParser.TypeContext ctx);
/**
	 * Exit a parse tree produced by {@link JavaParser#type}.
	 * @param ctx the parse tree
	 */void exitType(
{
    AT |  @
}

NotNull JavaParser.TypeContext ctx);
/**
	 * Enter a parse tree produced by {@link JavaParser#annotationTypeBody}.
	 * @param ctx the parse tree
	 */void enterAnnotationTypeBody(
{
    AT |  @
}

NotNull JavaParser.AnnotationTypeBodyContext ctx);
/**
	 * Exit a parse tree produced by {@link JavaParser#annotationTypeBody}.
	 * @param ctx the parse tree
	 */void exitAnnotationTypeBody(
{
    AT |  @
}

NotNull JavaParser.AnnotationTypeBodyContext ctx);
/**
	 * Enter a parse tree produced by {@link JavaParser#genericInterfaceMethodDeclaration}.
	 * @param ctx the parse tree
	 */void enterGenericInterfaceMethodDeclaration(
{
    AT |  @
}

NotNull JavaParser.GenericInterfaceMethodDeclarationContext ctx);
/**
	 * Exit a parse tree produced by {@link JavaParser#genericInterfaceMethodDeclaration}.
	 * @param ctx the parse tree
	 */void exitGenericInterfaceMethodDeclaration(
{
    AT |  @
}

NotNull JavaParser.GenericInterfaceMethodDeclarationContext ctx);
/**
	 * Enter a parse tree produced by {@link JavaParser#classBodyDeclaration}.
	 * @param ctx the parse tree
	 */void enterClassBodyDeclaration(
{
    AT |  @
}

NotNull JavaParser.ClassBodyDeclarationContext ctx);
/**
	 * Exit a parse tree produced by {@link JavaParser#classBodyDeclaration}.
	 * @param ctx the parse tree
	 */void exitClassBodyDeclaration(
{
    AT |  @
}

NotNull JavaParser.ClassBodyDeclarationContext ctx);
/**
	 * Enter a parse tree produced by {@link JavaParser#block}.
	 * @param ctx the parse tree
	 */void enterBlock(
{
    AT |  @
}

NotNull JavaParser.BlockContext ctx);
/**
	 * Exit a parse tree produced by {@link JavaParser#block}.
	 * @param ctx the parse tree
	 */void exitBlock(
{
    AT |  @
}

NotNull JavaParser.BlockContext ctx);
/**
	 * Enter a parse tree produced by {@link JavaParser#enumBodyDeclarations}.
	 * @param ctx the parse tree
	 */void enterEnumBodyDeclarations(
{
    AT |  @
}

NotNull JavaParser.EnumBodyDeclarationsContext ctx);
/**
	 * Exit a parse tree produced by {@link JavaParser#enumBodyDeclarations}.
	 * @param ctx the parse tree
	 */void exitEnumBodyDeclarations(
{
    AT |  @
}

NotNull JavaParser.EnumBodyDeclarationsContext ctx);
/**
	 * Enter a parse tree produced by {@link JavaParser#forUpdate}.
	 * @param ctx the parse tree
	 */void enterForUpdate(
{
    AT |  @
}

NotNull JavaParser.ForUpdateContext ctx);
/**
	 * Exit a parse tree produced by {@link JavaParser#forUpdate}.
	 * @param ctx the parse tree
	 */void exitForUpdate(
{
    AT |  @
}

NotNull JavaParser.ForUpdateContext ctx);
/**
	 * Enter a parse tree produced by {@link JavaParser#enhancedForControl}.
	 * @param ctx the parse tree
	 */void enterEnhancedForControl(
{
    AT |  @
}

NotNull JavaParser.EnhancedForControlContext ctx);
/**
	 * Exit a parse tree produced by {@link JavaParser#enhancedForControl}.
	 * @param ctx the parse tree
	 */void exitEnhancedForControl(
{
    AT |  @
}

NotNull JavaParser.EnhancedForControlContext ctx);
/**
	 * Enter a parse tree produced by {@link JavaParser#annotationConstantRest}.
	 * @param ctx the parse tree
	 */void enterAnnotationConstantRest(
{
    AT |  @
}

NotNull JavaParser.AnnotationConstantRestContext ctx);
/**
	 * Exit a parse tree produced by {@link JavaParser#annotationConstantRest}.
	 * @param ctx the parse tree
	 */void exitAnnotationConstantRest(
{
    AT |  @
}

NotNull JavaParser.AnnotationConstantRestContext ctx);
/**
	 * Enter a parse tree produced by {@link JavaParser#explicitGenericInvocation}.
	 * @param ctx the parse tree
	 */void enterExplicitGenericInvocation(
{
    AT |  @
}

NotNull JavaParser.ExplicitGenericInvocationContext ctx);
/**
	 * Exit a parse tree produced by {@link JavaParser#explicitGenericInvocation}.
	 * @param ctx the parse tree
	 */void exitExplicitGenericInvocation(
{
    AT |  @
}

NotNull JavaParser.ExplicitGenericInvocationContext ctx);
/**
	 * Enter a parse tree produced by {@link JavaParser#nonWildcardTypeArgumentsOrDiamond}.
	 * @param ctx the parse tree
	 */void enterNonWildcardTypeArgumentsOrDiamond(
{
    AT |  @
}

NotNull JavaParser.NonWildcardTypeArgumentsOrDiamondContext ctx);
/**
	 * Exit a parse tree produced by {@link JavaParser#nonWildcardTypeArgumentsOrDiamond}.
	 * @param ctx the parse tree
	 */void exitNonWildcardTypeArgumentsOrDiamond(
{
    AT |  @
}

NotNull JavaParser.NonWildcardTypeArgumentsOrDiamondContext ctx);
/**
	 * Enter a parse tree produced by {@link JavaParser#expressionList}.
	 * @param ctx the parse tree
	 */void enterExpressionList(
{
    AT |  @
}

NotNull JavaParser.ExpressionListContext ctx);
/**
	 * Exit a parse tree produced by {@link JavaParser#expressionList}.
	 * @param ctx the parse tree
	 */void exitExpressionList(
{
    AT |  @
}

NotNull JavaParser.ExpressionListContext ctx);
/**
	 * Enter a parse tree produced by {@link JavaParser#annotationTypeElementRest}.
	 * @param ctx the parse tree
	 */void enterAnnotationTypeElementRest(
{
    AT |  @
}

NotNull JavaParser.AnnotationTypeElementRestContext ctx);
/**
	 * Exit a parse tree produced by {@link JavaParser#annotationTypeElementRest}.
	 * @param ctx the parse tree
	 */void exitAnnotationTypeElementRest(
{
    AT |  @
}

NotNull JavaParser.AnnotationTypeElementRestContext ctx);
/**
	 * Enter a parse tree produced by {@link JavaParser#classOrInterfaceType}.
	 * @param ctx the parse tree
	 */void enterClassOrInterfaceType(
{
    AT |  @
}

NotNull JavaParser.ClassOrInterfaceTypeContext ctx);
/**
	 * Exit a parse tree produced by {@link JavaParser#classOrInterfaceType}.
	 * @param ctx the parse tree
	 */void exitClassOrInterfaceType(
{
    AT |  @
}

NotNull JavaParser.ClassOrInterfaceTypeContext ctx);
/**
	 * Enter a parse tree produced by {@link JavaParser#typeBound}.
	 * @param ctx the parse tree
	 */void enterTypeBound(
{
    AT |  @
}

NotNull JavaParser.TypeBoundContext ctx);
/**
	 * Exit a parse tree produced by {@link JavaParser#typeBound}.
	 * @param ctx the parse tree
	 */void exitTypeBound(
{
    AT |  @
}

NotNull JavaParser.TypeBoundContext ctx);
/**
	 * Enter a parse tree produced by {@link JavaParser#variableDeclaratorId}.
	 * @param ctx the parse tree
	 */void enterVariableDeclaratorId(
{
    AT |  @
}

NotNull JavaParser.VariableDeclaratorIdContext ctx);
/**
	 * Exit a parse tree produced by {@link JavaParser#variableDeclaratorId}.
	 * @param ctx the parse tree
	 */void exitVariableDeclaratorId(
{
    AT |  @
}

NotNull JavaParser.VariableDeclaratorIdContext ctx);
/**
	 * Enter a parse tree produced by {@link JavaParser#primary}.
	 * @param ctx the parse tree
	 */void enterPrimary(
{
    AT |  @
}

NotNull JavaParser.PrimaryContext ctx);
/**
	 * Exit a parse tree produced by {@link JavaParser#primary}.
	 * @param ctx the parse tree
	 */void exitPrimary(
{
    AT |  @
}

NotNull JavaParser.PrimaryContext ctx);
/**
	 * Enter a parse tree produced by {@link JavaParser#classCreatorRest}.
	 * @param ctx the parse tree
	 */void enterClassCreatorRest(
{
    AT |  @
}

NotNull JavaParser.ClassCreatorRestContext ctx);
/**
	 * Exit a parse tree produced by {@link JavaParser#classCreatorRest}.
	 * @param ctx the parse tree
	 */void exitClassCreatorRest(
{
    AT |  @
}

NotNull JavaParser.ClassCreatorRestContext ctx);
/**
	 * Enter a parse tree produced by {@link JavaParser#interfaceBodyDeclaration}.
	 * @param ctx the parse tree
	 */void enterInterfaceBodyDeclaration(
{
    AT |  @
}

NotNull JavaParser.InterfaceBodyDeclarationContext ctx);
/**
	 * Exit a parse tree produced by {@link JavaParser#interfaceBodyDeclaration}.
	 * @param ctx the parse tree
	 */void exitInterfaceBodyDeclaration(
{
    AT |  @
}

NotNull JavaParser.InterfaceBodyDeclarationContext ctx);
/**
	 * Enter a parse tree produced by {@link JavaParser#typeArguments}.
	 * @param ctx the parse tree
	 */void enterTypeArguments(
{
    AT |  @
}

NotNull JavaParser.TypeArgumentsContext ctx);
/**
	 * Exit a parse tree produced by {@link JavaParser#typeArguments}.
	 * @param ctx the parse tree
	 */void exitTypeArguments(
{
    AT |  @
}

NotNull JavaParser.TypeArgumentsContext ctx);
/**
	 * Enter a parse tree produced by {@link JavaParser#annotationName}.
	 * @param ctx the parse tree
	 */void enterAnnotationName(
{
    AT |  @
}

NotNull JavaParser.AnnotationNameContext ctx);
/**
	 * Exit a parse tree produced by {@link JavaParser#annotationName}.
	 * @param ctx the parse tree
	 */void exitAnnotationName(
{
    AT |  @
}

NotNull JavaParser.AnnotationNameContext ctx);
/**
	 * Enter a parse tree produced by {@link JavaParser#finallyBlock}.
	 * @param ctx the parse tree
	 */void enterFinallyBlock(
{
    AT |  @
}

NotNull JavaParser.FinallyBlockContext ctx);
/**
	 * Exit a parse tree produced by {@link JavaParser#finallyBlock}.
	 * @param ctx the parse tree
	 */void exitFinallyBlock(
{
    AT |  @
}

NotNull JavaParser.FinallyBlockContext ctx);
/**
	 * Enter a parse tree produced by {@link JavaParser#typeParameters}.
	 * @param ctx the parse tree
	 */void enterTypeParameters(
{
    AT |  @
}

NotNull JavaParser.TypeParametersContext ctx);
/**
	 * Exit a parse tree produced by {@link JavaParser#typeParameters}.
	 * @param ctx the parse tree
	 */void exitTypeParameters(
{
    AT |  @
}

NotNull JavaParser.TypeParametersContext ctx);
/**
	 * Enter a parse tree produced by {@link JavaParser#lastFormalParameter}.
	 * @param ctx the parse tree
	 */void enterLastFormalParameter(
{
    AT |  @
}

NotNull JavaParser.LastFormalParameterContext ctx);
/**
	 * Exit a parse tree produced by {@link JavaParser#lastFormalParameter}.
	 * @param ctx the parse tree
	 */void exitLastFormalParameter(
{
    AT |  @
}

NotNull JavaParser.LastFormalParameterContext ctx);
/**
	 * Enter a parse tree produced by {@link JavaParser#constructorBody}.
	 * @param ctx the parse tree
	 */void enterConstructorBody(
{
    AT |  @
}

NotNull JavaParser.ConstructorBodyContext ctx);
/**
	 * Exit a parse tree produced by {@link JavaParser#constructorBody}.
	 * @param ctx the parse tree
	 */void exitConstructorBody(
{
    AT |  @
}

NotNull JavaParser.ConstructorBodyContext ctx);
/**
	 * Enter a parse tree produced by {@link JavaParser#literal}.
	 * @param ctx the parse tree
	 */void enterLiteral(
{
    AT |  @
}

NotNull JavaParser.LiteralContext ctx);
/**
	 * Exit a parse tree produced by {@link JavaParser#literal}.
	 * @param ctx the parse tree
	 */void exitLiteral(
{
    AT |  @
}

NotNull JavaParser.LiteralContext ctx);
/**
	 * Enter a parse tree produced by {@link JavaParser#annotationMethodOrConstantRest}.
	 * @param ctx the parse tree
	 */void enterAnnotationMethodOrConstantRest(
{
    AT |  @
}

NotNull JavaParser.AnnotationMethodOrConstantRestContext ctx);
/**
	 * Exit a parse tree produced by {@link JavaParser#annotationMethodOrConstantRest}.
	 * @param ctx the parse tree
	 */void exitAnnotationMethodOrConstantRest(
{
    AT |  @
}

NotNull JavaParser.AnnotationMethodOrConstantRestContext ctx);
/**
	 * Enter a parse tree produced by {@link JavaParser#catchClause}.
	 * @param ctx the parse tree
	 */void enterCatchClause(
{
    AT |  @
}

NotNull JavaParser.CatchClauseContext ctx);
/**
	 * Exit a parse tree produced by {@link JavaParser#catchClause}.
	 * @param ctx the parse tree
	 */void exitCatchClause(
{
    AT |  @
}

NotNull JavaParser.CatchClauseContext ctx);
/**
	 * Enter a parse tree produced by {@link JavaParser#variableDeclarator}.
	 * @param ctx the parse tree
	 */void enterVariableDeclarator(
{
    AT |  @
}

NotNull JavaParser.VariableDeclaratorContext ctx);
/**
	 * Exit a parse tree produced by {@link JavaParser#variableDeclarator}.
	 * @param ctx the parse tree
	 */void exitVariableDeclarator(
{
    AT |  @
}

NotNull JavaParser.VariableDeclaratorContext ctx);
/**
	 * Enter a parse tree produced by {@link JavaParser#typeList}.
	 * @param ctx the parse tree
	 */void enterTypeList(
{
    AT |  @
}

NotNull JavaParser.TypeListContext ctx);
/**
	 * Exit a parse tree produced by {@link JavaParser#typeList}.
	 * @param ctx the parse tree
	 */void exitTypeList(
{
    AT |  @
}

NotNull JavaParser.TypeListContext ctx);
/**
	 * Enter a parse tree produced by {@link JavaParser#enumConstants}.
	 * @param ctx the parse tree
	 */void enterEnumConstants(
{
    AT |  @
}

NotNull JavaParser.EnumConstantsContext ctx);
/**
	 * Exit a parse tree produced by {@link JavaParser#enumConstants}.
	 * @param ctx the parse tree
	 */void exitEnumConstants(
{
    AT |  @
}

NotNull JavaParser.EnumConstantsContext ctx);
/**
	 * Enter a parse tree produced by {@link JavaParser#classBody}.
	 * @param ctx the parse tree
	 */void enterClassBody(
{
    AT |  @
}

NotNull JavaParser.ClassBodyContext ctx);
/**
	 * Exit a parse tree produced by {@link JavaParser#classBody}.
	 * @param ctx the parse tree
	 */void exitClassBody(
{
    AT |  @
}

NotNull JavaParser.ClassBodyContext ctx);
/**
	 * Enter a parse tree produced by {@link JavaParser#createdName}.
	 * @param ctx the parse tree
	 */void enterCreatedName(
{
    AT |  @
}

NotNull JavaParser.CreatedNameContext ctx);
/**
	 * Exit a parse tree produced by {@link JavaParser#createdName}.
	 * @param ctx the parse tree
	 */void exitCreatedName(
{
    AT |  @
}

NotNull JavaParser.CreatedNameContext ctx);
/**
	 * Enter a parse tree produced by {@link JavaParser#enumDeclaration}.
	 * @param ctx the parse tree
	 */void enterEnumDeclaration(
{
    AT |  @
}

NotNull JavaParser.EnumDeclarationContext ctx);
/**
	 * Exit a parse tree produced by {@link JavaParser#enumDeclaration}.
	 * @param ctx the parse tree
	 */void exitEnumDeclaration(
{
    AT |  @
}

NotNull JavaParser.EnumDeclarationContext ctx);
/**
	 * Enter a parse tree produced by {@link JavaParser#formalParameter}.
	 * @param ctx the parse tree
	 */void enterFormalParameter(
{
    AT |  @
}

NotNull JavaParser.FormalParameterContext ctx);
/**
	 * Exit a parse tree produced by {@link JavaParser#formalParameter}.
	 * @param ctx the parse tree
	 */void exitFormalParameter(
{
    AT |  @
}

NotNull JavaParser.FormalParameterContext ctx);
/**
	 * Enter a parse tree produced by {@link JavaParser#parExpression}.
	 * @param ctx the parse tree
	 */void enterParExpression(
{
    AT |  @
}

NotNull JavaParser.ParExpressionContext ctx);
/**
	 * Exit a parse tree produced by {@link JavaParser#parExpression}.
	 * @param ctx the parse tree
	 */void exitParExpression(
{
    AT |  @
}

NotNull JavaParser.ParExpressionContext ctx);
/**
	 * Enter a parse tree produced by {@link JavaParser#annotation}.
	 * @param ctx the parse tree
	 */void enterAnnotation(
{
    AT |  @
}

NotNull JavaParser.AnnotationContext ctx);
/**
	 * Exit a parse tree produced by {@link JavaParser#annotation}.
	 * @param ctx the parse tree
	 */void exitAnnotation(
{
    AT |  @
}

NotNull JavaParser.AnnotationContext ctx);
/**
	 * Enter a parse tree produced by {@link JavaParser#variableInitializer}.
	 * @param ctx the parse tree
	 */void enterVariableInitializer(
{
    AT |  @
}

NotNull JavaParser.VariableInitializerContext ctx);
/**
	 * Exit a parse tree produced by {@link JavaParser#variableInitializer}.
	 * @param ctx the parse tree
	 */void exitVariableInitializer(
{
    AT |  @
}

NotNull JavaParser.VariableInitializerContext ctx);
/**
	 * Enter a parse tree produced by {@link JavaParser#elementValueArrayInitializer}.
	 * @param ctx the parse tree
	 */void enterElementValueArrayInitializer(
{
    AT |  @
}

NotNull JavaParser.ElementValueArrayInitializerContext ctx);
/**
	 * Exit a parse tree produced by {@link JavaParser#elementValueArrayInitializer}.
	 * @param ctx the parse tree
	 */void exitElementValueArrayInitializer(
{
    AT |  @
}

NotNull JavaParser.ElementValueArrayInitializerContext ctx);
/**
	 * Enter a parse tree produced by {@link JavaParser#creator}.
	 * @param ctx the parse tree
	 */void enterCreator(
{
    AT |  @
}

NotNull JavaParser.CreatorContext ctx);
/**
	 * Exit a parse tree produced by {@link JavaParser#creator}.
	 * @param ctx the parse tree
	 */void exitCreator(
{
    AT |  @
}

NotNull JavaParser.CreatorContext ctx);
/**
	 * Enter a parse tree produced by {@link JavaParser#arrayCreatorRest}.
	 * @param ctx the parse tree
	 */void enterArrayCreatorRest(
{
    AT |  @
}

NotNull JavaParser.ArrayCreatorRestContext ctx);
/**
	 * Exit a parse tree produced by {@link JavaParser#arrayCreatorRest}.
	 * @param ctx the parse tree
	 */void exitArrayCreatorRest(
{
    AT |  @
}

NotNull JavaParser.ArrayCreatorRestContext ctx);
/**
	 * Enter a parse tree produced by {@link JavaParser#expression}.
	 * @param ctx the parse tree
	 */void enterExpression(
{
    AT |  @
}

NotNull JavaParser.ExpressionContext ctx);
/**
	 * Exit a parse tree produced by {@link JavaParser#expression}.
	 * @param ctx the parse tree
	 */void exitExpression(
{
    AT |  @
}

NotNull JavaParser.ExpressionContext ctx);
/**
	 * Enter a parse tree produced by {@link JavaParser#constantExpression}.
	 * @param ctx the parse tree
	 */void enterConstantExpression(
{
    AT |  @
}

NotNull JavaParser.ConstantExpressionContext ctx);
/**
	 * Exit a parse tree produced by {@link JavaParser#constantExpression}.
	 * @param ctx the parse tree
	 */void exitConstantExpression(
{
    AT |  @
}

NotNull JavaParser.ConstantExpressionContext ctx);
/**
	 * Enter a parse tree produced by {@link JavaParser#qualifiedNameList}.
	 * @param ctx the parse tree
	 */void enterQualifiedNameList(
{
    AT |  @
}

NotNull JavaParser.QualifiedNameListContext ctx);
/**
	 * Exit a parse tree produced by {@link JavaParser#qualifiedNameList}.
	 * @param ctx the parse tree
	 */void exitQualifiedNameList(
{
    AT |  @
}

NotNull JavaParser.QualifiedNameListContext ctx);
/**
	 * Enter a parse tree produced by {@link JavaParser#constructorDeclaration}.
	 * @param ctx the parse tree
	 */void enterConstructorDeclaration(
{
    AT |  @
}

NotNull JavaParser.ConstructorDeclarationContext ctx);
/**
	 * Exit a parse tree produced by {@link JavaParser#constructorDeclaration}.
	 * @param ctx the parse tree
	 */void exitConstructorDeclaration(
{
    AT |  @
}

NotNull JavaParser.ConstructorDeclarationContext ctx);
/**
	 * Enter a parse tree produced by {@link JavaParser#forControl}.
	 * @param ctx the parse tree
	 */void enterForControl(
{
    AT |  @
}

NotNull JavaParser.ForControlContext ctx);
/**
	 * Exit a parse tree produced by {@link JavaParser#forControl}.
	 * @param ctx the parse tree
	 */void exitForControl(
{
    AT |  @
}

NotNull JavaParser.ForControlContext ctx);
/**
	 * Enter a parse tree produced by {@link JavaParser#superSuffix}.
	 * @param ctx the parse tree
	 */void enterSuperSuffix(
{
    AT |  @
}

NotNull JavaParser.SuperSuffixContext ctx);
/**
	 * Exit a parse tree produced by {@link JavaParser#superSuffix}.
	 * @param ctx the parse tree
	 */void exitSuperSuffix(
{
    AT |  @
}

NotNull JavaParser.SuperSuffixContext ctx);
/**
	 * Enter a parse tree produced by {@link JavaParser#variableDeclarators}.
	 * @param ctx the parse tree
	 */void enterVariableDeclarators(
{
    AT |  @
}

NotNull JavaParser.VariableDeclaratorsContext ctx);
/**
	 * Exit a parse tree produced by {@link JavaParser#variableDeclarators}.
	 * @param ctx the parse tree
	 */void exitVariableDeclarators(
{
    AT |  @
}

NotNull JavaParser.VariableDeclaratorsContext ctx);
/**
	 * Enter a parse tree produced by {@link JavaParser#catchType}.
	 * @param ctx the parse tree
	 */void enterCatchType(
{
    AT |  @
}

NotNull JavaParser.CatchTypeContext ctx);
/**
	 * Exit a parse tree produced by {@link JavaParser#catchType}.
	 * @param ctx the parse tree
	 */void exitCatchType(
{
    AT |  @
}

NotNull JavaParser.CatchTypeContext ctx);
/**
	 * Enter a parse tree produced by {@link JavaParser#classOrInterfaceModifier}.
	 * @param ctx the parse tree
	 */void enterClassOrInterfaceModifier(
{
    AT |  @
}

NotNull JavaParser.ClassOrInterfaceModifierContext ctx);
/**
	 * Exit a parse tree produced by {@link JavaParser#classOrInterfaceModifier}.
	 * @param ctx the parse tree
	 */void exitClassOrInterfaceModifier(
{
    AT |  @
}

NotNull JavaParser.ClassOrInterfaceModifierContext ctx);
/**
	 * Enter a parse tree produced by {@link JavaParser#enumConstantName}.
	 * @param ctx the parse tree
	 */void enterEnumConstantName(
{
    AT |  @
}

NotNull JavaParser.EnumConstantNameContext ctx);
/**
	 * Exit a parse tree produced by {@link JavaParser#enumConstantName}.
	 * @param ctx the parse tree
	 */void exitEnumConstantName(
{
    AT |  @
}

NotNull JavaParser.EnumConstantNameContext ctx);
/**
	 * Enter a parse tree produced by {@link JavaParser#modifier}.
	 * @param ctx the parse tree
	 */void enterModifier(
{
    AT |  @
}

NotNull JavaParser.ModifierContext ctx);
/**
	 * Exit a parse tree produced by {@link JavaParser#modifier}.
	 * @param ctx the parse tree
	 */void exitModifier(
{
    AT |  @
}

NotNull JavaParser.ModifierContext ctx);
/**
	 * Enter a parse tree produced by {@link JavaParser#innerCreator}.
	 * @param ctx the parse tree
	 */void enterInnerCreator(
{
    AT |  @
}

NotNull JavaParser.InnerCreatorContext ctx);
/**
	 * Exit a parse tree produced by {@link JavaParser#innerCreator}.
	 * @param ctx the parse tree
	 */void exitInnerCreator(
{
    AT |  @
}

NotNull JavaParser.InnerCreatorContext ctx);
/**
	 * Enter a parse tree produced by {@link JavaParser#explicitGenericInvocationSuffix}.
	 * @param ctx the parse tree
	 */void enterExplicitGenericInvocationSuffix(
{
    AT |  @
}

NotNull JavaParser.ExplicitGenericInvocationSuffixContext ctx);
/**
	 * Exit a parse tree produced by {@link JavaParser#explicitGenericInvocationSuffix}.
	 * @param ctx the parse tree
	 */void exitExplicitGenericInvocationSuffix(
{
    AT |  @
}

NotNull JavaParser.ExplicitGenericInvocationSuffixContext ctx);
/**
	 * Enter a parse tree produced by {@link JavaParser#variableModifier}.
	 * @param ctx the parse tree
	 */void enterVariableModifier(
{
    AT |  @
}

NotNull JavaParser.VariableModifierContext ctx);
/**
	 * Exit a parse tree produced by {@link JavaParser#variableModifier}.
	 * @param ctx the parse tree
	 */void exitVariableModifier(
{
    AT |  @
}

NotNull JavaParser.VariableModifierContext ctx);
/**
	 * Enter a parse tree produced by {@link JavaParser#elementValuePair}.
	 * @param ctx the parse tree
	 */void enterElementValuePair(
{
    AT |  @
}

NotNull JavaParser.ElementValuePairContext ctx);
/**
	 * Exit a parse tree produced by {@link JavaParser#elementValuePair}.
	 * @param ctx the parse tree
	 */void exitElementValuePair(
{
    AT |  @
}

NotNull JavaParser.ElementValuePairContext ctx);
/**
	 * Enter a parse tree produced by {@link JavaParser#arrayInitializer}.
	 * @param ctx the parse tree
	 */void enterArrayInitializer(
{
    AT |  @
}

NotNull JavaParser.ArrayInitializerContext ctx);
/**
	 * Exit a parse tree produced by {@link JavaParser#arrayInitializer}.
	 * @param ctx the parse tree
	 */void exitArrayInitializer(
{
    AT |  @
}

NotNull JavaParser.ArrayInitializerContext ctx);
/**
	 * Enter a parse tree produced by {@link JavaParser#elementValue}.
	 * @param ctx the parse tree
	 */void enterElementValue(
{
    AT |  @
}

NotNull JavaParser.ElementValueContext ctx);
/**
	 * Exit a parse tree produced by {@link JavaParser#elementValue}.
	 * @param ctx the parse tree
	 */void exitElementValue(
{
    AT |  @
}

NotNull JavaParser.ElementValueContext ctx);
/**
	 * Enter a parse tree produced by {@link JavaParser#constDeclaration}.
	 * @param ctx the parse tree
	 */void enterConstDeclaration(
{
    AT |  @
}

NotNull JavaParser.ConstDeclarationContext ctx);
/**
	 * Exit a parse tree produced by {@link JavaParser#constDeclaration}.
	 * @param ctx the parse tree
	 */void exitConstDeclaration(
{
    AT |  @
}

NotNull JavaParser.ConstDeclarationContext ctx);
/**
	 * Enter a parse tree produced by {@link JavaParser#resource}.
	 * @param ctx the parse tree
	 */void enterResource(
{
    AT |  @
}

NotNull JavaParser.ResourceContext ctx);
/**
	 * Exit a parse tree produced by {@link JavaParser#resource}.
	 * @param ctx the parse tree
	 */void exitResource(
{
    AT |  @
}

NotNull JavaParser.ResourceContext ctx);
/**
	 * Enter a parse tree produced by {@link JavaParser#qualifiedName}.
	 * @param ctx the parse tree
	 */void enterQualifiedName(
{
    AT |  @
}

NotNull JavaParser.QualifiedNameContext ctx);
/**
	 * Exit a parse tree produced by {@link JavaParser#qualifiedName}.
	 * @param ctx the parse tree
	 */void exitQualifiedName(
{
    AT |  @
}

NotNull JavaParser.QualifiedNameContext ctx);
/**
	 * Enter a parse tree produced by {@link JavaParser#resourceSpecification}.
	 * @param ctx the parse tree
	 */void enterResourceSpecification(
{
    AT |  @
}

NotNull JavaParser.ResourceSpecificationContext ctx);
/**
	 * Exit a parse tree produced by {@link JavaParser#resourceSpecification}.
	 * @param ctx the parse tree
	 */void exitResourceSpecification(
{
    AT |  @
}

NotNull JavaParser.ResourceSpecificationContext ctx);
/**
	 * Enter a parse tree produced by {@link JavaParser#formalParameterList}.
	 * @param ctx the parse tree
	 */void enterFormalParameterList(
{
    AT |  @
}

NotNull JavaParser.FormalParameterListContext ctx);
/**
	 * Exit a parse tree produced by {@link JavaParser#formalParameterList}.
	 * @param ctx the parse tree
	 */void exitFormalParameterList(
{
    AT |  @
}

NotNull JavaParser.FormalParameterListContext ctx);
/**
	 * Enter a parse tree produced by {@link JavaParser#annotationTypeDeclaration}.
	 * @param ctx the parse tree
	 */void enterAnnotationTypeDeclaration(
{
    AT |  @
}

NotNull JavaParser.AnnotationTypeDeclarationContext ctx);
/**
	 * Exit a parse tree produced by {@link JavaParser#annotationTypeDeclaration}.
	 * @param ctx the parse tree
	 */void exitAnnotationTypeDeclaration(
{
    AT |  @
}

NotNull JavaParser.AnnotationTypeDeclarationContext ctx);
/**
	 * Enter a parse tree produced by {@link JavaParser#compilationUnit}.
	 * @param ctx the parse tree
	 */void enterCompilationUnit(
{
    AT |  @
}

NotNull JavaParser.CompilationUnitContext ctx);
/**
	 * Exit a parse tree produced by {@link JavaParser#compilationUnit}.
	 * @param ctx the parse tree
	 */void exitCompilationUnit(
{
    AT |  @
}

NotNull JavaParser.CompilationUnitContext ctx);
/**
	 * Enter a parse tree produced by {@link JavaParser#annotationMethodRest}.
	 * @param ctx the parse tree
	 */void enterAnnotationMethodRest(
{
    AT |  @
}

NotNull JavaParser.AnnotationMethodRestContext ctx);
/**
	 * Exit a parse tree produced by {@link JavaParser#annotationMethodRest}.
	 * @param ctx the parse tree
	 */void exitAnnotationMethodRest(
{
    AT |  @
}

NotNull JavaParser.AnnotationMethodRestContext ctx);
/**
	 * Enter a parse tree produced by {@link JavaParser#switchBlockStatementGroup}.
	 * @param ctx the parse tree
	 */void enterSwitchBlockStatementGroup(
{
    AT |  @
}

NotNull JavaParser.SwitchBlockStatementGroupContext ctx);
/**
	 * Exit a parse tree produced by {@link JavaParser#switchBlockStatementGroup}.
	 * @param ctx the parse tree
	 */void exitSwitchBlockStatementGroup(
{
    AT |  @
}

NotNull JavaParser.SwitchBlockStatementGroupContext ctx);
/**
	 * Enter a parse tree produced by {@link JavaParser#typeParameter}.
	 * @param ctx the parse tree
	 */void enterTypeParameter(
{
    AT |  @
}

NotNull JavaParser.TypeParameterContext ctx);
/**
	 * Exit a parse tree produced by {@link JavaParser#typeParameter}.
	 * @param ctx the parse tree
	 */void exitTypeParameter(
{
    AT |  @
}

NotNull JavaParser.TypeParameterContext ctx);
/**
	 * Enter a parse tree produced by {@link JavaParser#interfaceBody}.
	 * @param ctx the parse tree
	 */void enterInterfaceBody(
{
    AT |  @
}

NotNull JavaParser.InterfaceBodyContext ctx);
/**
	 * Exit a parse tree produced by {@link JavaParser#interfaceBody}.
	 * @param ctx the parse tree
	 */void exitInterfaceBody(
{
    AT |  @
}

NotNull JavaParser.InterfaceBodyContext ctx);
/**
	 * Enter a parse tree produced by {@link JavaParser#methodDeclaration}.
	 * @param ctx the parse tree
	 */void enterMethodDeclaration(
{
    AT |  @
}

NotNull JavaParser.MethodDeclarationContext ctx);
/**
	 * Exit a parse tree produced by {@link JavaParser#methodDeclaration}.
	 * @param ctx the parse tree
	 */void exitMethodDeclaration(
{
    AT |  @
}

NotNull JavaParser.MethodDeclarationContext ctx);
/**
	 * Enter a parse tree produced by {@link JavaParser#methodBody}.
	 * @param ctx the parse tree
	 */void enterMethodBody(
{
    AT |  @
}

NotNull JavaParser.MethodBodyContext ctx);
/**
	 * Exit a parse tree produced by {@link JavaParser#methodBody}.
	 * @param ctx the parse tree
	 */void exitMethodBody(
{
    AT |  @
}

NotNull JavaParser.MethodBodyContext ctx);
/**
	 * Enter a parse tree produced by {@link JavaParser#typeArgument}.
	 * @param ctx the parse tree
	 */void enterTypeArgument(
{
    AT |  @
}

NotNull JavaParser.TypeArgumentContext ctx);
/**
	 * Exit a parse tree produced by {@link JavaParser#typeArgument}.
	 * @param ctx the parse tree
	 */void exitTypeArgument(
{
    AT |  @
}

NotNull JavaParser.TypeArgumentContext ctx);
/**
	 * Enter a parse tree produced by {@link JavaParser#typeDeclaration}.
	 * @param ctx the parse tree
	 */void enterTypeDeclaration(
{
    AT |  @
}

NotNull JavaParser.TypeDeclarationContext ctx);
/**
	 * Exit a parse tree produced by {@link JavaParser#typeDeclaration}.
	 * @param ctx the parse tree
	 */void exitTypeDeclaration(
{
    AT |  @
}

NotNull JavaParser.TypeDeclarationContext ctx);
/**
	 * Enter a parse tree produced by {@link JavaParser#genericConstructorDeclaration}.
	 * @param ctx the parse tree
	 */void enterGenericConstructorDeclaration(
{
    AT |  @
}

NotNull JavaParser.GenericConstructorDeclarationContext ctx);
/**
	 * Exit a parse tree produced by {@link JavaParser#genericConstructorDeclaration}.
	 * @param ctx the parse tree
	 */void exitGenericConstructorDeclaration(
{
    AT |  @
}

NotNull JavaParser.GenericConstructorDeclarationContext ctx);
/**
	 * Enter a parse tree produced by {@link JavaParser#classDeclaration}.
	 * @param ctx the parse tree
	 */void enterClassDeclaration(
{
    AT |  @
}

NotNull JavaParser.ClassDeclarationContext ctx);
/**
	 * Exit a parse tree produced by {@link JavaParser#classDeclaration}.
	 * @param ctx the parse tree
	 */void exitClassDeclaration(
{
    AT |  @
}

NotNull JavaParser.ClassDeclarationContext ctx);
/**
	 * Enter a parse tree produced by {@link JavaParser#enumConstant}.
	 * @param ctx the parse tree
	 */void enterEnumConstant(
{
    AT |  @
}

NotNull JavaParser.EnumConstantContext ctx);
/**
	 * Exit a parse tree produced by {@link JavaParser#enumConstant}.
	 * @param ctx the parse tree
	 */void exitEnumConstant(
{
    AT |  @
}

NotNull JavaParser.EnumConstantContext ctx);
/**
	 * Enter a parse tree produced by {@link JavaParser#statement}.
	 * @param ctx the parse tree
	 */void enterStatement(
{
    AT |  @
}

NotNull JavaParser.StatementContext ctx);
/**
	 * Exit a parse tree produced by {@link JavaParser#statement}.
	 * @param ctx the parse tree
	 */void exitStatement(
{
    AT |  @
}

NotNull JavaParser.StatementContext ctx);
/**
	 * Enter a parse tree produced by {@link JavaParser#importDeclaration}.
	 * @param ctx the parse tree
	 */void enterImportDeclaration(
{
    AT |  @
}

NotNull JavaParser.ImportDeclarationContext ctx);
/**
	 * Exit a parse tree produced by {@link JavaParser#importDeclaration}.
	 * @param ctx the parse tree
	 */void exitImportDeclaration(
{
    AT |  @
}

NotNull JavaParser.ImportDeclarationContext ctx);
/**
	 * Enter a parse tree produced by {@link JavaParser#primitiveType}.
	 * @param ctx the parse tree
	 */void enterPrimitiveType(
{
    AT |  @
}

NotNull JavaParser.PrimitiveTypeContext ctx);
/**
	 * Exit a parse tree produced by {@link JavaParser#primitiveType}.
	 * @param ctx the parse tree
	 */void exitPrimitiveType(
{
    AT |  @
}

NotNull JavaParser.PrimitiveTypeContext ctx);
/**
	 * Enter a parse tree produced by {@link JavaParser#interfaceDeclaration}.
	 * @param ctx the parse tree
	 */void enterInterfaceDeclaration(
{
    AT |  @
}

NotNull JavaParser.InterfaceDeclarationContext ctx);
/**
	 * Exit a parse tree produced by {@link JavaParser#interfaceDeclaration}.
	 * @param ctx the parse tree
	 */void exitInterfaceDeclaration(
{
    AT |  @
}

NotNull JavaParser.InterfaceDeclarationContext ctx);
/**
	 * Enter a parse tree produced by {@link JavaParser#localVariableDeclarationStatement}.
	 * @param ctx the parse tree
	 */void enterLocalVariableDeclarationStatement(
{
    AT |  @
}

NotNull JavaParser.LocalVariableDeclarationStatementContext ctx);
/**
	 * Exit a parse tree produced by {@link JavaParser#localVariableDeclarationStatement}.
	 * @param ctx the parse tree
	 */void exitLocalVariableDeclarationStatement(
{
    AT |  @
}

NotNull JavaParser.LocalVariableDeclarationStatementContext ctx);
/**
	 * Enter a parse tree produced by {@link JavaParser#blockStatement}.
	 * @param ctx the parse tree
	 */void enterBlockStatement(
{
    AT |  @
}

NotNull JavaParser.BlockStatementContext ctx);
/**
	 * Exit a parse tree produced by {@link JavaParser#blockStatement}.
	 * @param ctx the parse tree
	 */void exitBlockStatement(
{
    AT |  @
}

NotNull JavaParser.BlockStatementContext ctx);
/**
	 * Enter a parse tree produced by {@link JavaParser#fieldDeclaration}.
	 * @param ctx the parse tree
	 */void enterFieldDeclaration(
{
    AT |  @
}

NotNull JavaParser.FieldDeclarationContext ctx);
/**
	 * Exit a parse tree produced by {@link JavaParser#fieldDeclaration}.
	 * @param ctx the parse tree
	 */void exitFieldDeclaration(
{
    AT |  @
}

NotNull JavaParser.FieldDeclarationContext ctx);
/**
	 * Enter a parse tree produced by {@link JavaParser#constantDeclarator}.
	 * @param ctx the parse tree
	 */void enterConstantDeclarator(
{
    AT |  @
}

NotNull JavaParser.ConstantDeclaratorContext ctx);
/**
	 * Exit a parse tree produced by {@link JavaParser#constantDeclarator}.
	 * @param ctx the parse tree
	 */void exitConstantDeclarator(
{
    AT |  @
}

NotNull JavaParser.ConstantDeclaratorContext ctx);
/**
	 * Enter a parse tree produced by {@link JavaParser#resources}.
	 * @param ctx the parse tree
	 */void enterResources(
{
    AT |  @
}

NotNull JavaParser.ResourcesContext ctx);
/**
	 * Exit a parse tree produced by {@link JavaParser#resources}.
	 * @param ctx the parse tree
	 */void exitResources(
{
    AT |  @
}

NotNull JavaParser.ResourcesContext ctx);
/**
	 * Enter a parse tree produced by {@link JavaParser#statementExpression}.
	 * @param ctx the parse tree
	 */void enterStatementExpression(
{
    AT |  @
}

NotNull JavaParser.StatementExpressionContext ctx);
/**
	 * Exit a parse tree produced by {@link JavaParser#statementExpression}.
	 * @param ctx the parse tree
	 */void exitStatementExpression(
{
    AT |  @
}

NotNull JavaParser.StatementExpressionContext ctx);
/**
	 * Enter a parse tree produced by {@link JavaParser#interfaceMethodDeclaration}.
	 * @param ctx the parse tree
	 */void enterInterfaceMethodDeclaration(
{
    AT |  @
}

NotNull JavaParser.InterfaceMethodDeclarationContext ctx);
/**
	 * Exit a parse tree produced by {@link JavaParser#interfaceMethodDeclaration}.
	 * @param ctx the parse tree
	 */void exitInterfaceMethodDeclaration(
{
    AT |  @
}

NotNull JavaParser.InterfaceMethodDeclarationContext ctx);
/**
	 * Enter a parse tree produced by {@link JavaParser#packageDeclaration}.
	 * @param ctx the parse tree
	 */void enterPackageDeclaration(
{
    AT |  @
}

NotNull JavaParser.PackageDeclarationContext ctx);
/**
	 * Exit a parse tree produced by {@link JavaParser#packageDeclaration}.
	 * @param ctx the parse tree
	 */void exitPackageDeclaration(
{
    AT |  @
}

NotNull JavaParser.PackageDeclarationContext ctx);
/**
	 * Enter a parse tree produced by {@link JavaParser#elementValuePairs}.
	 * @param ctx the parse tree
	 */void enterElementValuePairs(
{
    AT |  @
}

NotNull JavaParser.ElementValuePairsContext ctx);
/**
	 * Exit a parse tree produced by {@link JavaParser#elementValuePairs}.
	 * @param ctx the parse tree
	 */void exitElementValuePairs(
{
    AT |  @
}

NotNull JavaParser.ElementValuePairsContext ctx);
/**
	 * Enter a parse tree produced by {@link JavaParser#localVariableDeclaration}.
	 * @param ctx the parse tree
	 */void enterLocalVariableDeclaration(
{
    AT |  @
}

NotNull JavaParser.LocalVariableDeclarationContext ctx);
/**
	 * Exit a parse tree produced by {@link JavaParser#localVariableDeclaration}.
	 * @param ctx the parse tree
	 */void exitLocalVariableDeclaration(
{
    AT |  @
}

NotNull JavaParser.LocalVariableDeclarationContext ctx);
/**
	 * Enter a parse tree produced by {@link JavaParser#nonWildcardTypeArguments}.
	 * @param ctx the parse tree
	 */void enterNonWildcardTypeArguments(
{
    AT |  @
}

NotNull JavaParser.NonWildcardTypeArgumentsContext ctx);
/**
	 * Exit a parse tree produced by {@link JavaParser#nonWildcardTypeArguments}.
	 * @param ctx the parse tree
	 */void exitNonWildcardTypeArguments(
{
    AT |  @
}

NotNull JavaParser.NonWildcardTypeArgumentsContext ctx);
/**
	 * Enter a parse tree produced by {@link JavaParser#interfaceMemberDeclaration}.
	 * @param ctx the parse tree
	 */void enterInterfaceMemberDeclaration(
{
    AT |  @
}

NotNull JavaParser.InterfaceMemberDeclarationContext ctx);
/**
	 * Exit a parse tree produced by {@link JavaParser#interfaceMemberDeclaration}.
	 * @param ctx the parse tree
	 */void exitInterfaceMemberDeclaration(
{
    AT |  @
}

NotNull JavaParser.InterfaceMemberDeclarationContext ctx);
/**
	 * Enter a parse tree produced by {@link JavaParser#switchLabel}.
	 * @param ctx the parse tree
	 */void enterSwitchLabel(
{
    AT |  @
}

NotNull JavaParser.SwitchLabelContext ctx);
/**
	 * Exit a parse tree produced by {@link JavaParser#switchLabel}.
	 * @param ctx the parse tree
	 */void exitSwitchLabel(
{
    AT |  @
}

NotNull JavaParser.SwitchLabelContext ctx);
/**
	 * Enter a parse tree produced by {@link JavaParser#forInit}.
	 * @param ctx the parse tree
	 */void enterForInit(
{
    AT |  @
}

NotNull JavaParser.ForInitContext ctx);
/**
	 * Exit a parse tree produced by {@link JavaParser#forInit}.
	 * @param ctx the parse tree
	 */void exitForInit(
{
    AT |  @
}

NotNull JavaParser.ForInitContext ctx);
/**
	 * Enter a parse tree produced by {@link JavaParser#formalParameters}.
	 * @param ctx the parse tree
	 */void enterFormalParameters(
{
    AT |  @
}

NotNull JavaParser.FormalParametersContext ctx);
/**
	 * Exit a parse tree produced by {@link JavaParser#formalParameters}.
	 * @param ctx the parse tree
	 */void exitFormalParameters(
{
    AT |  @
}

NotNull JavaParser.FormalParametersContext ctx);
/**
	 * Enter a parse tree produced by {@link JavaParser#arguments}.
	 * @param ctx the parse tree
	 */void enterArguments(
{
    AT |  @
}

NotNull JavaParser.ArgumentsContext ctx);
/**
	 * Exit a parse tree produced by {@link JavaParser#arguments}.
	 * @param ctx the parse tree
	 */void exitArguments(
{
    AT |  @
}

NotNull JavaParser.ArgumentsContext ctx);
/**
	 * Enter a parse tree produced by {@link JavaParser#genericMethodDeclaration}.
	 * @param ctx the parse tree
	 */void enterGenericMethodDeclaration(
{
    AT |  @
}

NotNull JavaParser.GenericMethodDeclarationContext ctx);
/**
	 * Exit a parse tree produced by {@link JavaParser#genericMethodDeclaration}.
	 * @param ctx the parse tree
	 */void exitGenericMethodDeclaration(
{
    AT |  @
}

NotNull JavaParser.GenericMethodDeclarationContext ctx);
/**
	 * Enter a parse tree produced by {@link JavaParser#typeArgumentsOrDiamond}.
	 * @param ctx the parse tree
	 */void enterTypeArgumentsOrDiamond(
{
    AT |  @
}

NotNull JavaParser.TypeArgumentsOrDiamondContext ctx);
/**
	 * Exit a parse tree produced by {@link JavaParser#typeArgumentsOrDiamond}.
	 * @param ctx the parse tree
	 */void exitTypeArgumentsOrDiamond(
{
    AT |  @
}

NotNull JavaParser.TypeArgumentsOrDiamondContext ctx); } }
