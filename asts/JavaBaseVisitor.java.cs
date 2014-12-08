// Generated from Java.g4 by ANTLR 4.3
using org.antlr.v4.runtime.misc.NotNull;
using org.antlr.v4.runtime.tree.AbstractParseTreeVisitor;

namespace javasharp
{
    /**
     * This class provides an empty implementation of {@link JavaVisitor},
     * which can be extended to create a visitor which only needs to handle a subset
     * of the available methods.
     *
     * @param <T> The return type of the visit operation. Use {@link Void} for
     * operations with no return type.
     */    public class JavaBaseVisitor<T>
    {
        EXTENDS |extends
    }

    AbstractParseTreeVisitor<T> {
    IMPLEMENTS |implements
}

JavaVisitor<T> { 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {
AT | @ }Overridepublic TvisitMemberDeclaration(
{
    AT |  @
}

NotNull JavaParser.MemberDeclarationContext ctx)
{
    return visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Overridepublic TvisitDefaultValue(
{
    AT |  @
}

NotNull JavaParser.DefaultValueContext ctx)
{
    return visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Overridepublic TvisitAnnotationTypeElementDeclaration(
{
    AT |  @
}

NotNull JavaParser.AnnotationTypeElementDeclarationContext ctx)
{
    return visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Overridepublic TvisitType(
{
    AT |  @
}

NotNull JavaParser.TypeContext ctx)
{
    return visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Overridepublic TvisitAnnotationTypeBody(
{
    AT |  @
}

NotNull JavaParser.AnnotationTypeBodyContext ctx)
{
    return visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Overridepublic TvisitGenericInterfaceMethodDeclaration(
{
    AT |  @
}

NotNull JavaParser.GenericInterfaceMethodDeclarationContext ctx)
{
    return visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Overridepublic TvisitClassBodyDeclaration(
{
    AT |  @
}

NotNull JavaParser.ClassBodyDeclarationContext ctx)
{
    return visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Overridepublic TvisitBlock(
{
    AT |  @
}

NotNull JavaParser.BlockContext ctx)
{
    return visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Overridepublic TvisitEnumBodyDeclarations(
{
    AT |  @
}

NotNull JavaParser.EnumBodyDeclarationsContext ctx)
{
    return visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Overridepublic TvisitForUpdate(
{
    AT |  @
}

NotNull JavaParser.ForUpdateContext ctx)
{
    return visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Overridepublic TvisitEnhancedForControl(
{
    AT |  @
}

NotNull JavaParser.EnhancedForControlContext ctx)
{
    return visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Overridepublic TvisitAnnotationConstantRest(
{
    AT |  @
}

NotNull JavaParser.AnnotationConstantRestContext ctx)
{
    return visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Overridepublic TvisitExplicitGenericInvocation(
{
    AT |  @
}

NotNull JavaParser.ExplicitGenericInvocationContext ctx)
{
    return visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Overridepublic TvisitNonWildcardTypeArgumentsOrDiamond(
{
    AT |  @
}

NotNull JavaParser.NonWildcardTypeArgumentsOrDiamondContext ctx)
{
    return visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Overridepublic TvisitExpressionList(
{
    AT |  @
}

NotNull JavaParser.ExpressionListContext ctx)
{
    return visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Overridepublic TvisitAnnotationTypeElementRest(
{
    AT |  @
}

NotNull JavaParser.AnnotationTypeElementRestContext ctx)
{
    return visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Overridepublic TvisitClassOrInterfaceType(
{
    AT |  @
}

NotNull JavaParser.ClassOrInterfaceTypeContext ctx)
{
    return visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Overridepublic TvisitTypeBound(
{
    AT |  @
}

NotNull JavaParser.TypeBoundContext ctx)
{
    return visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Overridepublic TvisitVariableDeclaratorId(
{
    AT |  @
}

NotNull JavaParser.VariableDeclaratorIdContext ctx)
{
    return visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Overridepublic TvisitPrimary(
{
    AT |  @
}

NotNull JavaParser.PrimaryContext ctx)
{
    return visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Overridepublic TvisitClassCreatorRest(
{
    AT |  @
}

NotNull JavaParser.ClassCreatorRestContext ctx)
{
    return visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Overridepublic TvisitInterfaceBodyDeclaration(
{
    AT |  @
}

NotNull JavaParser.InterfaceBodyDeclarationContext ctx)
{
    return visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Overridepublic TvisitTypeArguments(
{
    AT |  @
}

NotNull JavaParser.TypeArgumentsContext ctx)
{
    return visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Overridepublic TvisitAnnotationName(
{
    AT |  @
}

NotNull JavaParser.AnnotationNameContext ctx)
{
    return visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Overridepublic TvisitFinallyBlock(
{
    AT |  @
}

NotNull JavaParser.FinallyBlockContext ctx)
{
    return visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Overridepublic TvisitTypeParameters(
{
    AT |  @
}

NotNull JavaParser.TypeParametersContext ctx)
{
    return visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Overridepublic TvisitLastFormalParameter(
{
    AT |  @
}

NotNull JavaParser.LastFormalParameterContext ctx)
{
    return visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Overridepublic TvisitConstructorBody(
{
    AT |  @
}

NotNull JavaParser.ConstructorBodyContext ctx)
{
    return visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Overridepublic TvisitLiteral(
{
    AT |  @
}

NotNull JavaParser.LiteralContext ctx)
{
    return visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Overridepublic TvisitAnnotationMethodOrConstantRest(
{
    AT |  @
}

NotNull JavaParser.AnnotationMethodOrConstantRestContext ctx)
{
    return visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Overridepublic TvisitCatchClause(
{
    AT |  @
}

NotNull JavaParser.CatchClauseContext ctx)
{
    return visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Overridepublic TvisitVariableDeclarator(
{
    AT |  @
}

NotNull JavaParser.VariableDeclaratorContext ctx)
{
    return visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Overridepublic TvisitTypeList(
{
    AT |  @
}

NotNull JavaParser.TypeListContext ctx)
{
    return visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Overridepublic TvisitEnumConstants(
{
    AT |  @
}

NotNull JavaParser.EnumConstantsContext ctx)
{
    return visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Overridepublic TvisitClassBody(
{
    AT |  @
}

NotNull JavaParser.ClassBodyContext ctx)
{
    return visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Overridepublic TvisitCreatedName(
{
    AT |  @
}

NotNull JavaParser.CreatedNameContext ctx)
{
    return visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Overridepublic TvisitEnumDeclaration(
{
    AT |  @
}

NotNull JavaParser.EnumDeclarationContext ctx)
{
    return visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Overridepublic TvisitFormalParameter(
{
    AT |  @
}

NotNull JavaParser.FormalParameterContext ctx)
{
    return visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Overridepublic TvisitParExpression(
{
    AT |  @
}

NotNull JavaParser.ParExpressionContext ctx)
{
    return visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Overridepublic TvisitAnnotation(
{
    AT |  @
}

NotNull JavaParser.AnnotationContext ctx)
{
    return visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Overridepublic TvisitVariableInitializer(
{
    AT |  @
}

NotNull JavaParser.VariableInitializerContext ctx)
{
    return visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Overridepublic TvisitElementValueArrayInitializer(
{
    AT |  @
}

NotNull JavaParser.ElementValueArrayInitializerContext ctx)
{
    return visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Overridepublic TvisitCreator(
{
    AT |  @
}

NotNull JavaParser.CreatorContext ctx)
{
    return visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Overridepublic TvisitArrayCreatorRest(
{
    AT |  @
}

NotNull JavaParser.ArrayCreatorRestContext ctx)
{
    return visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Overridepublic TvisitExpression(
{
    AT |  @
}

NotNull JavaParser.ExpressionContext ctx)
{
    return visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Overridepublic TvisitConstantExpression(
{
    AT |  @
}

NotNull JavaParser.ConstantExpressionContext ctx)
{
    return visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Overridepublic TvisitQualifiedNameList(
{
    AT |  @
}

NotNull JavaParser.QualifiedNameListContext ctx)
{
    return visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Overridepublic TvisitConstructorDeclaration(
{
    AT |  @
}

NotNull JavaParser.ConstructorDeclarationContext ctx)
{
    return visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Overridepublic TvisitForControl(
{
    AT |  @
}

NotNull JavaParser.ForControlContext ctx)
{
    return visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Overridepublic TvisitSuperSuffix(
{
    AT |  @
}

NotNull JavaParser.SuperSuffixContext ctx)
{
    return visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Overridepublic TvisitVariableDeclarators(
{
    AT |  @
}

NotNull JavaParser.VariableDeclaratorsContext ctx)
{
    return visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Overridepublic TvisitCatchType(
{
    AT |  @
}

NotNull JavaParser.CatchTypeContext ctx)
{
    return visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Overridepublic TvisitClassOrInterfaceModifier(
{
    AT |  @
}

NotNull JavaParser.ClassOrInterfaceModifierContext ctx)
{
    return visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Overridepublic TvisitEnumConstantName(
{
    AT |  @
}

NotNull JavaParser.EnumConstantNameContext ctx)
{
    return visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Overridepublic TvisitModifier(
{
    AT |  @
}

NotNull JavaParser.ModifierContext ctx)
{
    return visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Overridepublic TvisitInnerCreator(
{
    AT |  @
}

NotNull JavaParser.InnerCreatorContext ctx)
{
    return visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Overridepublic TvisitExplicitGenericInvocationSuffix(
{
    AT |  @
}

NotNull JavaParser.ExplicitGenericInvocationSuffixContext ctx)
{
    return visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Overridepublic TvisitVariableModifier(
{
    AT |  @
}

NotNull JavaParser.VariableModifierContext ctx)
{
    return visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Overridepublic TvisitElementValuePair(
{
    AT |  @
}

NotNull JavaParser.ElementValuePairContext ctx)
{
    return visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Overridepublic TvisitArrayInitializer(
{
    AT |  @
}

NotNull JavaParser.ArrayInitializerContext ctx)
{
    return visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Overridepublic TvisitElementValue(
{
    AT |  @
}

NotNull JavaParser.ElementValueContext ctx)
{
    return visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Overridepublic TvisitConstDeclaration(
{
    AT |  @
}

NotNull JavaParser.ConstDeclarationContext ctx)
{
    return visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Overridepublic TvisitResource(
{
    AT |  @
}

NotNull JavaParser.ResourceContext ctx)
{
    return visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Overridepublic TvisitQualifiedName(
{
    AT |  @
}

NotNull JavaParser.QualifiedNameContext ctx)
{
    return visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Overridepublic TvisitResourceSpecification(
{
    AT |  @
}

NotNull JavaParser.ResourceSpecificationContext ctx)
{
    return visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Overridepublic TvisitFormalParameterList(
{
    AT |  @
}

NotNull JavaParser.FormalParameterListContext ctx)
{
    return visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Overridepublic TvisitAnnotationTypeDeclaration(
{
    AT |  @
}

NotNull JavaParser.AnnotationTypeDeclarationContext ctx)
{
    return visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Overridepublic TvisitCompilationUnit(
{
    AT |  @
}

NotNull JavaParser.CompilationUnitContext ctx)
{
    return visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Overridepublic TvisitAnnotationMethodRest(
{
    AT |  @
}

NotNull JavaParser.AnnotationMethodRestContext ctx)
{
    return visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Overridepublic TvisitSwitchBlockStatementGroup(
{
    AT |  @
}

NotNull JavaParser.SwitchBlockStatementGroupContext ctx)
{
    return visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Overridepublic TvisitTypeParameter(
{
    AT |  @
}

NotNull JavaParser.TypeParameterContext ctx)
{
    return visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Overridepublic TvisitInterfaceBody(
{
    AT |  @
}

NotNull JavaParser.InterfaceBodyContext ctx)
{
    return visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Overridepublic TvisitMethodDeclaration(
{
    AT |  @
}

NotNull JavaParser.MethodDeclarationContext ctx)
{
    return visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Overridepublic TvisitMethodBody(
{
    AT |  @
}

NotNull JavaParser.MethodBodyContext ctx)
{
    return visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Overridepublic TvisitTypeArgument(
{
    AT |  @
}

NotNull JavaParser.TypeArgumentContext ctx)
{
    return visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Overridepublic TvisitTypeDeclaration(
{
    AT |  @
}

NotNull JavaParser.TypeDeclarationContext ctx)
{
    return visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Overridepublic TvisitGenericConstructorDeclaration(
{
    AT |  @
}

NotNull JavaParser.GenericConstructorDeclarationContext ctx)
{
    return visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Overridepublic TvisitClassDeclaration(
{
    AT |  @
}

NotNull JavaParser.ClassDeclarationContext ctx)
{
    return visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Overridepublic TvisitEnumConstant(
{
    AT |  @
}

NotNull JavaParser.EnumConstantContext ctx)
{
    return visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Overridepublic TvisitStatement(
{
    AT |  @
}

NotNull JavaParser.StatementContext ctx)
{
    return visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Overridepublic TvisitImportDeclaration(
{
    AT |  @
}

NotNull JavaParser.ImportDeclarationContext ctx)
{
    return visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Overridepublic TvisitPrimitiveType(
{
    AT |  @
}

NotNull JavaParser.PrimitiveTypeContext ctx)
{
    return visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Overridepublic TvisitInterfaceDeclaration(
{
    AT |  @
}

NotNull JavaParser.InterfaceDeclarationContext ctx)
{
    return visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Overridepublic TvisitLocalVariableDeclarationStatement(
{
    AT |  @
}

NotNull JavaParser.LocalVariableDeclarationStatementContext ctx)
{
    return visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Overridepublic TvisitBlockStatement(
{
    AT |  @
}

NotNull JavaParser.BlockStatementContext ctx)
{
    return visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Overridepublic TvisitFieldDeclaration(
{
    AT |  @
}

NotNull JavaParser.FieldDeclarationContext ctx)
{
    return visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Overridepublic TvisitConstantDeclarator(
{
    AT |  @
}

NotNull JavaParser.ConstantDeclaratorContext ctx)
{
    return visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Overridepublic TvisitResources(
{
    AT |  @
}

NotNull JavaParser.ResourcesContext ctx)
{
    return visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Overridepublic TvisitStatementExpression(
{
    AT |  @
}

NotNull JavaParser.StatementExpressionContext ctx)
{
    return visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Overridepublic TvisitInterfaceMethodDeclaration(
{
    AT |  @
}

NotNull JavaParser.InterfaceMethodDeclarationContext ctx)
{
    return visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Overridepublic TvisitPackageDeclaration(
{
    AT |  @
}

NotNull JavaParser.PackageDeclarationContext ctx)
{
    return visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Overridepublic TvisitElementValuePairs(
{
    AT |  @
}

NotNull JavaParser.ElementValuePairsContext ctx)
{
    return visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Overridepublic TvisitLocalVariableDeclaration(
{
    AT |  @
}

NotNull JavaParser.LocalVariableDeclarationContext ctx)
{
    return visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Overridepublic TvisitNonWildcardTypeArguments(
{
    AT |  @
}

NotNull JavaParser.NonWildcardTypeArgumentsContext ctx)
{
    return visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Overridepublic TvisitInterfaceMemberDeclaration(
{
    AT |  @
}

NotNull JavaParser.InterfaceMemberDeclarationContext ctx)
{
    return visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Overridepublic TvisitSwitchLabel(
{
    AT |  @
}

NotNull JavaParser.SwitchLabelContext ctx)
{
    return visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Overridepublic TvisitForInit(
{
    AT |  @
}

NotNull JavaParser.ForInitContext ctx)
{
    return visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Overridepublic TvisitFormalParameters(
{
    AT |  @
}

NotNull JavaParser.FormalParametersContext ctx)
{
    return visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Overridepublic TvisitArguments(
{
    AT |  @
}

NotNull JavaParser.ArgumentsContext ctx)
{
    return visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Overridepublic TvisitGenericMethodDeclaration(
{
    AT |  @
}

NotNull JavaParser.GenericMethodDeclarationContext ctx)
{
    return visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Overridepublic TvisitTypeArgumentsOrDiamond(
{
    AT |  @
}

NotNull JavaParser.TypeArgumentsOrDiamondContext ctx)
{
    return visitChildren(ctx);
} } }
