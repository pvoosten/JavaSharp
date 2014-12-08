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
     */    public class JavaBaseVisitor
    {
        LT | <    }

    T {
    GT | >} {

EXTENDS |extends }
AbstractParseTreeVisitor {
LT | < }T {
GT | > } {IMPLEMENTS |implements }
JavaVisitor {
LT | < }T {
GT | > } { 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {AT | @ }Override public TvisitMemberDeclaration(
{
    AT |  @
}

NotNull JavaParser.MemberDeclarationContext ctx)
{
    {
        RETURN | return
    }

    visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Override public TvisitDefaultValue(
{
    AT |  @
}

NotNull JavaParser.DefaultValueContext ctx)
{
    {
        RETURN | return
    }

    visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Override public TvisitAnnotationTypeElementDeclaration(
{
    AT |  @
}

NotNull JavaParser.AnnotationTypeElementDeclarationContext ctx)
{
    {
        RETURN | return
    }

    visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Override public TvisitType(
{
    AT |  @
}

NotNull JavaParser.TypeContext ctx)
{
    {
        RETURN | return
    }

    visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Override public TvisitAnnotationTypeBody(
{
    AT |  @
}

NotNull JavaParser.AnnotationTypeBodyContext ctx)
{
    {
        RETURN | return
    }

    visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Override public TvisitGenericInterfaceMethodDeclaration(
{
    AT |  @
}

NotNull JavaParser.GenericInterfaceMethodDeclarationContext ctx)
{
    {
        RETURN | return
    }

    visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Override public TvisitClassBodyDeclaration(
{
    AT |  @
}

NotNull JavaParser.ClassBodyDeclarationContext ctx)
{
    {
        RETURN | return
    }

    visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Override public TvisitBlock(
{
    AT |  @
}

NotNull JavaParser.BlockContext ctx)
{
    {
        RETURN | return
    }

    visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Override public TvisitEnumBodyDeclarations(
{
    AT |  @
}

NotNull JavaParser.EnumBodyDeclarationsContext ctx)
{
    {
        RETURN | return
    }

    visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Override public TvisitForUpdate(
{
    AT |  @
}

NotNull JavaParser.ForUpdateContext ctx)
{
    {
        RETURN | return
    }

    visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Override public TvisitEnhancedForControl(
{
    AT |  @
}

NotNull JavaParser.EnhancedForControlContext ctx)
{
    {
        RETURN | return
    }

    visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Override public TvisitAnnotationConstantRest(
{
    AT |  @
}

NotNull JavaParser.AnnotationConstantRestContext ctx)
{
    {
        RETURN | return
    }

    visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Override public TvisitExplicitGenericInvocation(
{
    AT |  @
}

NotNull JavaParser.ExplicitGenericInvocationContext ctx)
{
    {
        RETURN | return
    }

    visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Override public TvisitNonWildcardTypeArgumentsOrDiamond(
{
    AT |  @
}

NotNull JavaParser.NonWildcardTypeArgumentsOrDiamondContext ctx)
{
    {
        RETURN | return
    }

    visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Override public TvisitExpressionList(
{
    AT |  @
}

NotNull JavaParser.ExpressionListContext ctx)
{
    {
        RETURN | return
    }

    visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Override public TvisitAnnotationTypeElementRest(
{
    AT |  @
}

NotNull JavaParser.AnnotationTypeElementRestContext ctx)
{
    {
        RETURN | return
    }

    visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Override public TvisitClassOrInterfaceType(
{
    AT |  @
}

NotNull JavaParser.ClassOrInterfaceTypeContext ctx)
{
    {
        RETURN | return
    }

    visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Override public TvisitTypeBound(
{
    AT |  @
}

NotNull JavaParser.TypeBoundContext ctx)
{
    {
        RETURN | return
    }

    visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Override public TvisitVariableDeclaratorId(
{
    AT |  @
}

NotNull JavaParser.VariableDeclaratorIdContext ctx)
{
    {
        RETURN | return
    }

    visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Override public TvisitPrimary(
{
    AT |  @
}

NotNull JavaParser.PrimaryContext ctx)
{
    {
        RETURN | return
    }

    visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Override public TvisitClassCreatorRest(
{
    AT |  @
}

NotNull JavaParser.ClassCreatorRestContext ctx)
{
    {
        RETURN | return
    }

    visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Override public TvisitInterfaceBodyDeclaration(
{
    AT |  @
}

NotNull JavaParser.InterfaceBodyDeclarationContext ctx)
{
    {
        RETURN | return
    }

    visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Override public TvisitTypeArguments(
{
    AT |  @
}

NotNull JavaParser.TypeArgumentsContext ctx)
{
    {
        RETURN | return
    }

    visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Override public TvisitAnnotationName(
{
    AT |  @
}

NotNull JavaParser.AnnotationNameContext ctx)
{
    {
        RETURN | return
    }

    visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Override public TvisitFinallyBlock(
{
    AT |  @
}

NotNull JavaParser.FinallyBlockContext ctx)
{
    {
        RETURN | return
    }

    visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Override public TvisitTypeParameters(
{
    AT |  @
}

NotNull JavaParser.TypeParametersContext ctx)
{
    {
        RETURN | return
    }

    visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Override public TvisitLastFormalParameter(
{
    AT |  @
}

NotNull JavaParser.LastFormalParameterContext ctx)
{
    {
        RETURN | return
    }

    visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Override public TvisitConstructorBody(
{
    AT |  @
}

NotNull JavaParser.ConstructorBodyContext ctx)
{
    {
        RETURN | return
    }

    visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Override public TvisitLiteral(
{
    AT |  @
}

NotNull JavaParser.LiteralContext ctx)
{
    {
        RETURN | return
    }

    visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Override public TvisitAnnotationMethodOrConstantRest(
{
    AT |  @
}

NotNull JavaParser.AnnotationMethodOrConstantRestContext ctx)
{
    {
        RETURN | return
    }

    visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Override public TvisitCatchClause(
{
    AT |  @
}

NotNull JavaParser.CatchClauseContext ctx)
{
    {
        RETURN | return
    }

    visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Override public TvisitVariableDeclarator(
{
    AT |  @
}

NotNull JavaParser.VariableDeclaratorContext ctx)
{
    {
        RETURN | return
    }

    visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Override public TvisitTypeList(
{
    AT |  @
}

NotNull JavaParser.TypeListContext ctx)
{
    {
        RETURN | return
    }

    visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Override public TvisitEnumConstants(
{
    AT |  @
}

NotNull JavaParser.EnumConstantsContext ctx)
{
    {
        RETURN | return
    }

    visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Override public TvisitClassBody(
{
    AT |  @
}

NotNull JavaParser.ClassBodyContext ctx)
{
    {
        RETURN | return
    }

    visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Override public TvisitCreatedName(
{
    AT |  @
}

NotNull JavaParser.CreatedNameContext ctx)
{
    {
        RETURN | return
    }

    visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Override public TvisitEnumDeclaration(
{
    AT |  @
}

NotNull JavaParser.EnumDeclarationContext ctx)
{
    {
        RETURN | return
    }

    visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Override public TvisitFormalParameter(
{
    AT |  @
}

NotNull JavaParser.FormalParameterContext ctx)
{
    {
        RETURN | return
    }

    visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Override public TvisitParExpression(
{
    AT |  @
}

NotNull JavaParser.ParExpressionContext ctx)
{
    {
        RETURN | return
    }

    visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Override public TvisitAnnotation(
{
    AT |  @
}

NotNull JavaParser.AnnotationContext ctx)
{
    {
        RETURN | return
    }

    visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Override public TvisitVariableInitializer(
{
    AT |  @
}

NotNull JavaParser.VariableInitializerContext ctx)
{
    {
        RETURN | return
    }

    visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Override public TvisitElementValueArrayInitializer(
{
    AT |  @
}

NotNull JavaParser.ElementValueArrayInitializerContext ctx)
{
    {
        RETURN | return
    }

    visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Override public TvisitCreator(
{
    AT |  @
}

NotNull JavaParser.CreatorContext ctx)
{
    {
        RETURN | return
    }

    visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Override public TvisitArrayCreatorRest(
{
    AT |  @
}

NotNull JavaParser.ArrayCreatorRestContext ctx)
{
    {
        RETURN | return
    }

    visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Override public TvisitExpression(
{
    AT |  @
}

NotNull JavaParser.ExpressionContext ctx)
{
    {
        RETURN | return
    }

    visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Override public TvisitConstantExpression(
{
    AT |  @
}

NotNull JavaParser.ConstantExpressionContext ctx)
{
    {
        RETURN | return
    }

    visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Override public TvisitQualifiedNameList(
{
    AT |  @
}

NotNull JavaParser.QualifiedNameListContext ctx)
{
    {
        RETURN | return
    }

    visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Override public TvisitConstructorDeclaration(
{
    AT |  @
}

NotNull JavaParser.ConstructorDeclarationContext ctx)
{
    {
        RETURN | return
    }

    visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Override public TvisitForControl(
{
    AT |  @
}

NotNull JavaParser.ForControlContext ctx)
{
    {
        RETURN | return
    }

    visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Override public TvisitSuperSuffix(
{
    AT |  @
}

NotNull JavaParser.SuperSuffixContext ctx)
{
    {
        RETURN | return
    }

    visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Override public TvisitVariableDeclarators(
{
    AT |  @
}

NotNull JavaParser.VariableDeclaratorsContext ctx)
{
    {
        RETURN | return
    }

    visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Override public TvisitCatchType(
{
    AT |  @
}

NotNull JavaParser.CatchTypeContext ctx)
{
    {
        RETURN | return
    }

    visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Override public TvisitClassOrInterfaceModifier(
{
    AT |  @
}

NotNull JavaParser.ClassOrInterfaceModifierContext ctx)
{
    {
        RETURN | return
    }

    visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Override public TvisitEnumConstantName(
{
    AT |  @
}

NotNull JavaParser.EnumConstantNameContext ctx)
{
    {
        RETURN | return
    }

    visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Override public TvisitModifier(
{
    AT |  @
}

NotNull JavaParser.ModifierContext ctx)
{
    {
        RETURN | return
    }

    visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Override public TvisitInnerCreator(
{
    AT |  @
}

NotNull JavaParser.InnerCreatorContext ctx)
{
    {
        RETURN | return
    }

    visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Override public TvisitExplicitGenericInvocationSuffix(
{
    AT |  @
}

NotNull JavaParser.ExplicitGenericInvocationSuffixContext ctx)
{
    {
        RETURN | return
    }

    visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Override public TvisitVariableModifier(
{
    AT |  @
}

NotNull JavaParser.VariableModifierContext ctx)
{
    {
        RETURN | return
    }

    visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Override public TvisitElementValuePair(
{
    AT |  @
}

NotNull JavaParser.ElementValuePairContext ctx)
{
    {
        RETURN | return
    }

    visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Override public TvisitArrayInitializer(
{
    AT |  @
}

NotNull JavaParser.ArrayInitializerContext ctx)
{
    {
        RETURN | return
    }

    visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Override public TvisitElementValue(
{
    AT |  @
}

NotNull JavaParser.ElementValueContext ctx)
{
    {
        RETURN | return
    }

    visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Override public TvisitConstDeclaration(
{
    AT |  @
}

NotNull JavaParser.ConstDeclarationContext ctx)
{
    {
        RETURN | return
    }

    visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Override public TvisitResource(
{
    AT |  @
}

NotNull JavaParser.ResourceContext ctx)
{
    {
        RETURN | return
    }

    visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Override public TvisitQualifiedName(
{
    AT |  @
}

NotNull JavaParser.QualifiedNameContext ctx)
{
    {
        RETURN | return
    }

    visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Override public TvisitResourceSpecification(
{
    AT |  @
}

NotNull JavaParser.ResourceSpecificationContext ctx)
{
    {
        RETURN | return
    }

    visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Override public TvisitFormalParameterList(
{
    AT |  @
}

NotNull JavaParser.FormalParameterListContext ctx)
{
    {
        RETURN | return
    }

    visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Override public TvisitAnnotationTypeDeclaration(
{
    AT |  @
}

NotNull JavaParser.AnnotationTypeDeclarationContext ctx)
{
    {
        RETURN | return
    }

    visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Override public TvisitCompilationUnit(
{
    AT |  @
}

NotNull JavaParser.CompilationUnitContext ctx)
{
    {
        RETURN | return
    }

    visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Override public TvisitAnnotationMethodRest(
{
    AT |  @
}

NotNull JavaParser.AnnotationMethodRestContext ctx)
{
    {
        RETURN | return
    }

    visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Override public TvisitSwitchBlockStatementGroup(
{
    AT |  @
}

NotNull JavaParser.SwitchBlockStatementGroupContext ctx)
{
    {
        RETURN | return
    }

    visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Override public TvisitTypeParameter(
{
    AT |  @
}

NotNull JavaParser.TypeParameterContext ctx)
{
    {
        RETURN | return
    }

    visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Override public TvisitInterfaceBody(
{
    AT |  @
}

NotNull JavaParser.InterfaceBodyContext ctx)
{
    {
        RETURN | return
    }

    visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Override public TvisitMethodDeclaration(
{
    AT |  @
}

NotNull JavaParser.MethodDeclarationContext ctx)
{
    {
        RETURN | return
    }

    visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Override public TvisitMethodBody(
{
    AT |  @
}

NotNull JavaParser.MethodBodyContext ctx)
{
    {
        RETURN | return
    }

    visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Override public TvisitTypeArgument(
{
    AT |  @
}

NotNull JavaParser.TypeArgumentContext ctx)
{
    {
        RETURN | return
    }

    visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Override public TvisitTypeDeclaration(
{
    AT |  @
}

NotNull JavaParser.TypeDeclarationContext ctx)
{
    {
        RETURN | return
    }

    visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Override public TvisitGenericConstructorDeclaration(
{
    AT |  @
}

NotNull JavaParser.GenericConstructorDeclarationContext ctx)
{
    {
        RETURN | return
    }

    visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Override public TvisitClassDeclaration(
{
    AT |  @
}

NotNull JavaParser.ClassDeclarationContext ctx)
{
    {
        RETURN | return
    }

    visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Override public TvisitEnumConstant(
{
    AT |  @
}

NotNull JavaParser.EnumConstantContext ctx)
{
    {
        RETURN | return
    }

    visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Override public TvisitStatement(
{
    AT |  @
}

NotNull JavaParser.StatementContext ctx)
{
    {
        RETURN | return
    }

    visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Override public TvisitImportDeclaration(
{
    AT |  @
}

NotNull JavaParser.ImportDeclarationContext ctx)
{
    {
        RETURN | return
    }

    visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Override public TvisitPrimitiveType(
{
    AT |  @
}

NotNull JavaParser.PrimitiveTypeContext ctx)
{
    {
        RETURN | return
    }

    visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Override public TvisitInterfaceDeclaration(
{
    AT |  @
}

NotNull JavaParser.InterfaceDeclarationContext ctx)
{
    {
        RETURN | return
    }

    visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Override public TvisitLocalVariableDeclarationStatement(
{
    AT |  @
}

NotNull JavaParser.LocalVariableDeclarationStatementContext ctx)
{
    {
        RETURN | return
    }

    visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Override public TvisitBlockStatement(
{
    AT |  @
}

NotNull JavaParser.BlockStatementContext ctx)
{
    {
        RETURN | return
    }

    visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Override public TvisitFieldDeclaration(
{
    AT |  @
}

NotNull JavaParser.FieldDeclarationContext ctx)
{
    {
        RETURN | return
    }

    visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Override public TvisitConstantDeclarator(
{
    AT |  @
}

NotNull JavaParser.ConstantDeclaratorContext ctx)
{
    {
        RETURN | return
    }

    visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Override public TvisitResources(
{
    AT |  @
}

NotNull JavaParser.ResourcesContext ctx)
{
    {
        RETURN | return
    }

    visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Override public TvisitStatementExpression(
{
    AT |  @
}

NotNull JavaParser.StatementExpressionContext ctx)
{
    {
        RETURN | return
    }

    visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Override public TvisitInterfaceMethodDeclaration(
{
    AT |  @
}

NotNull JavaParser.InterfaceMethodDeclarationContext ctx)
{
    {
        RETURN | return
    }

    visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Override public TvisitPackageDeclaration(
{
    AT |  @
}

NotNull JavaParser.PackageDeclarationContext ctx)
{
    {
        RETURN | return
    }

    visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Override public TvisitElementValuePairs(
{
    AT |  @
}

NotNull JavaParser.ElementValuePairsContext ctx)
{
    {
        RETURN | return
    }

    visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Override public TvisitLocalVariableDeclaration(
{
    AT |  @
}

NotNull JavaParser.LocalVariableDeclarationContext ctx)
{
    {
        RETURN | return
    }

    visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Override public TvisitNonWildcardTypeArguments(
{
    AT |  @
}

NotNull JavaParser.NonWildcardTypeArgumentsContext ctx)
{
    {
        RETURN | return
    }

    visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Override public TvisitInterfaceMemberDeclaration(
{
    AT |  @
}

NotNull JavaParser.InterfaceMemberDeclarationContext ctx)
{
    {
        RETURN | return
    }

    visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Override public TvisitSwitchLabel(
{
    AT |  @
}

NotNull JavaParser.SwitchLabelContext ctx)
{
    {
        RETURN | return
    }

    visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Override public TvisitForInit(
{
    AT |  @
}

NotNull JavaParser.ForInitContext ctx)
{
    {
        RETURN | return
    }

    visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Override public TvisitFormalParameters(
{
    AT |  @
}

NotNull JavaParser.FormalParametersContext ctx)
{
    {
        RETURN | return
    }

    visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Override public TvisitArguments(
{
    AT |  @
}

NotNull JavaParser.ArgumentsContext ctx)
{
    {
        RETURN | return
    }

    visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Override public TvisitGenericMethodDeclaration(
{
    AT |  @
}

NotNull JavaParser.GenericMethodDeclarationContext ctx)
{
    {
        RETURN | return
    }

    visitChildren(ctx);
} 
/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */ {

AT | @ }Override public TvisitTypeArgumentsOrDiamond(
{
    AT |  @
}

NotNull JavaParser.TypeArgumentsOrDiamondContext ctx)
{
    {
        RETURN | return
    }

    visitChildren(ctx);
} } }
