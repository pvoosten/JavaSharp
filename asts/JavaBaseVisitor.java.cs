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
 */
public class JavaBaseVisitor<T> : AbstractParseTreeVisitor<T> : JavaVisitor<T> {
	
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */
	 public T visitMemberDeclaration(@NotNull JavaParser.MemberDeclarationContext ctx) { return visitChildren(ctx); }

	
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */
	 public T visitDefaultValue(@NotNull JavaParser.DefaultValueContext ctx) { return visitChildren(ctx); }

	
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */
	 public T visitAnnotationTypeElementDeclaration(@NotNull JavaParser.AnnotationTypeElementDeclarationContext ctx) { return visitChildren(ctx); }

	
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */
	 public T visitType(@NotNull JavaParser.TypeContext ctx) { return visitChildren(ctx); }

	
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */
	 public T visitAnnotationTypeBody(@NotNull JavaParser.AnnotationTypeBodyContext ctx) { return visitChildren(ctx); }

	
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */
	 public T visitGenericInterfaceMethodDeclaration(@NotNull JavaParser.GenericInterfaceMethodDeclarationContext ctx) { return visitChildren(ctx); }

	
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */
	 public T visitClassBodyDeclaration(@NotNull JavaParser.ClassBodyDeclarationContext ctx) { return visitChildren(ctx); }

	
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */
	 public T visitBlock(@NotNull JavaParser.BlockContext ctx) { return visitChildren(ctx); }

	
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */
	 public T visitEnumBodyDeclarations(@NotNull JavaParser.EnumBodyDeclarationsContext ctx) { return visitChildren(ctx); }

	
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */
	 public T visitForUpdate(@NotNull JavaParser.ForUpdateContext ctx) { return visitChildren(ctx); }

	
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */
	 public T visitEnhancedForControl(@NotNull JavaParser.EnhancedForControlContext ctx) { return visitChildren(ctx); }

	
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */
	 public T visitAnnotationConstantRest(@NotNull JavaParser.AnnotationConstantRestContext ctx) { return visitChildren(ctx); }

	
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */
	 public T visitExplicitGenericInvocation(@NotNull JavaParser.ExplicitGenericInvocationContext ctx) { return visitChildren(ctx); }

	
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */
	 public T visitNonWildcardTypeArgumentsOrDiamond(@NotNull JavaParser.NonWildcardTypeArgumentsOrDiamondContext ctx) { return visitChildren(ctx); }

	
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */
	 public T visitExpressionList(@NotNull JavaParser.ExpressionListContext ctx) { return visitChildren(ctx); }

	
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */
	 public T visitAnnotationTypeElementRest(@NotNull JavaParser.AnnotationTypeElementRestContext ctx) { return visitChildren(ctx); }

	
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */
	 public T visitClassOrInterfaceType(@NotNull JavaParser.ClassOrInterfaceTypeContext ctx) { return visitChildren(ctx); }

	
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */
	 public T visitTypeBound(@NotNull JavaParser.TypeBoundContext ctx) { return visitChildren(ctx); }

	
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */
	 public T visitVariableDeclaratorId(@NotNull JavaParser.VariableDeclaratorIdContext ctx) { return visitChildren(ctx); }

	
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */
	 public T visitPrimary(@NotNull JavaParser.PrimaryContext ctx) { return visitChildren(ctx); }

	
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */
	 public T visitClassCreatorRest(@NotNull JavaParser.ClassCreatorRestContext ctx) { return visitChildren(ctx); }

	
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */
	 public T visitInterfaceBodyDeclaration(@NotNull JavaParser.InterfaceBodyDeclarationContext ctx) { return visitChildren(ctx); }

	
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */
	 public T visitTypeArguments(@NotNull JavaParser.TypeArgumentsContext ctx) { return visitChildren(ctx); }

	
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */
	 public T visitAnnotationName(@NotNull JavaParser.AnnotationNameContext ctx) { return visitChildren(ctx); }

	
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */
	 public T visitFinallyBlock(@NotNull JavaParser.FinallyBlockContext ctx) { return visitChildren(ctx); }

	
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */
	 public T visitTypeParameters(@NotNull JavaParser.TypeParametersContext ctx) { return visitChildren(ctx); }

	
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */
	 public T visitLastFormalParameter(@NotNull JavaParser.LastFormalParameterContext ctx) { return visitChildren(ctx); }

	
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */
	 public T visitConstructorBody(@NotNull JavaParser.ConstructorBodyContext ctx) { return visitChildren(ctx); }

	
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */
	 public T visitLiteral(@NotNull JavaParser.LiteralContext ctx) { return visitChildren(ctx); }

	
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */
	 public T visitAnnotationMethodOrConstantRest(@NotNull JavaParser.AnnotationMethodOrConstantRestContext ctx) { return visitChildren(ctx); }

	
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */
	 public T visitCatchClause(@NotNull JavaParser.CatchClauseContext ctx) { return visitChildren(ctx); }

	
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */
	 public T visitVariableDeclarator(@NotNull JavaParser.VariableDeclaratorContext ctx) { return visitChildren(ctx); }

	
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */
	 public T visitTypeList(@NotNull JavaParser.TypeListContext ctx) { return visitChildren(ctx); }

	
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */
	 public T visitEnumConstants(@NotNull JavaParser.EnumConstantsContext ctx) { return visitChildren(ctx); }

	
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */
	 public T visitClassBody(@NotNull JavaParser.ClassBodyContext ctx) { return visitChildren(ctx); }

	
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */
	 public T visitCreatedName(@NotNull JavaParser.CreatedNameContext ctx) { return visitChildren(ctx); }

	
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */
	 public T visitEnumDeclaration(@NotNull JavaParser.EnumDeclarationContext ctx) { return visitChildren(ctx); }

	
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */
	 public T visitFormalParameter(@NotNull JavaParser.FormalParameterContext ctx) { return visitChildren(ctx); }

	
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */
	 public T visitParExpression(@NotNull JavaParser.ParExpressionContext ctx) { return visitChildren(ctx); }

	
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */
	 public T visitAnnotation(@NotNull JavaParser.AnnotationContext ctx) { return visitChildren(ctx); }

	
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */
	 public T visitVariableInitializer(@NotNull JavaParser.VariableInitializerContext ctx) { return visitChildren(ctx); }

	
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */
	 public T visitElementValueArrayInitializer(@NotNull JavaParser.ElementValueArrayInitializerContext ctx) { return visitChildren(ctx); }

	
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */
	 public T visitCreator(@NotNull JavaParser.CreatorContext ctx) { return visitChildren(ctx); }

	
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */
	 public T visitArrayCreatorRest(@NotNull JavaParser.ArrayCreatorRestContext ctx) { return visitChildren(ctx); }

	
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */
	 public T visitExpression(@NotNull JavaParser.ExpressionContext ctx) { return visitChildren(ctx); }

	
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */
	 public T visitConstantExpression(@NotNull JavaParser.ConstantExpressionContext ctx) { return visitChildren(ctx); }

	
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */
	 public T visitQualifiedNameList(@NotNull JavaParser.QualifiedNameListContext ctx) { return visitChildren(ctx); }

	
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */
	 public T visitConstructorDeclaration(@NotNull JavaParser.ConstructorDeclarationContext ctx) { return visitChildren(ctx); }

	
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */
	 public T visitForControl(@NotNull JavaParser.ForControlContext ctx) { return visitChildren(ctx); }

	
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */
	 public T visitSuperSuffix(@NotNull JavaParser.SuperSuffixContext ctx) { return visitChildren(ctx); }

	
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */
	 public T visitVariableDeclarators(@NotNull JavaParser.VariableDeclaratorsContext ctx) { return visitChildren(ctx); }

	
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */
	 public T visitCatchType(@NotNull JavaParser.CatchTypeContext ctx) { return visitChildren(ctx); }

	
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */
	 public T visitClassOrInterfaceModifier(@NotNull JavaParser.ClassOrInterfaceModifierContext ctx) { return visitChildren(ctx); }

	
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */
	 public T visitEnumConstantName(@NotNull JavaParser.EnumConstantNameContext ctx) { return visitChildren(ctx); }

	
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */
	 public T visitModifier(@NotNull JavaParser.ModifierContext ctx) { return visitChildren(ctx); }

	
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */
	 public T visitInnerCreator(@NotNull JavaParser.InnerCreatorContext ctx) { return visitChildren(ctx); }

	
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */
	 public T visitExplicitGenericInvocationSuffix(@NotNull JavaParser.ExplicitGenericInvocationSuffixContext ctx) { return visitChildren(ctx); }

	
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */
	 public T visitVariableModifier(@NotNull JavaParser.VariableModifierContext ctx) { return visitChildren(ctx); }

	
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */
	 public T visitElementValuePair(@NotNull JavaParser.ElementValuePairContext ctx) { return visitChildren(ctx); }

	
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */
	 public T visitArrayInitializer(@NotNull JavaParser.ArrayInitializerContext ctx) { return visitChildren(ctx); }

	
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */
	 public T visitElementValue(@NotNull JavaParser.ElementValueContext ctx) { return visitChildren(ctx); }

	
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */
	 public T visitConstDeclaration(@NotNull JavaParser.ConstDeclarationContext ctx) { return visitChildren(ctx); }

	
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */
	 public T visitResource(@NotNull JavaParser.ResourceContext ctx) { return visitChildren(ctx); }

	
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */
	 public T visitQualifiedName(@NotNull JavaParser.QualifiedNameContext ctx) { return visitChildren(ctx); }

	
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */
	 public T visitResourceSpecification(@NotNull JavaParser.ResourceSpecificationContext ctx) { return visitChildren(ctx); }

	
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */
	 public T visitFormalParameterList(@NotNull JavaParser.FormalParameterListContext ctx) { return visitChildren(ctx); }

	
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */
	 public T visitAnnotationTypeDeclaration(@NotNull JavaParser.AnnotationTypeDeclarationContext ctx) { return visitChildren(ctx); }

	
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */
	 public T visitCompilationUnit(@NotNull JavaParser.CompilationUnitContext ctx) { return visitChildren(ctx); }

	
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */
	 public T visitAnnotationMethodRest(@NotNull JavaParser.AnnotationMethodRestContext ctx) { return visitChildren(ctx); }

	
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */
	 public T visitSwitchBlockStatementGroup(@NotNull JavaParser.SwitchBlockStatementGroupContext ctx) { return visitChildren(ctx); }

	
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */
	 public T visitTypeParameter(@NotNull JavaParser.TypeParameterContext ctx) { return visitChildren(ctx); }

	
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */
	 public T visitInterfaceBody(@NotNull JavaParser.InterfaceBodyContext ctx) { return visitChildren(ctx); }

	
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */
	 public T visitMethodDeclaration(@NotNull JavaParser.MethodDeclarationContext ctx) { return visitChildren(ctx); }

	
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */
	 public T visitMethodBody(@NotNull JavaParser.MethodBodyContext ctx) { return visitChildren(ctx); }

	
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */
	 public T visitTypeArgument(@NotNull JavaParser.TypeArgumentContext ctx) { return visitChildren(ctx); }

	
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */
	 public T visitTypeDeclaration(@NotNull JavaParser.TypeDeclarationContext ctx) { return visitChildren(ctx); }

	
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */
	 public T visitGenericConstructorDeclaration(@NotNull JavaParser.GenericConstructorDeclarationContext ctx) { return visitChildren(ctx); }

	
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */
	 public T visitClassDeclaration(@NotNull JavaParser.ClassDeclarationContext ctx) { return visitChildren(ctx); }

	
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */
	 public T visitEnumConstant(@NotNull JavaParser.EnumConstantContext ctx) { return visitChildren(ctx); }

	
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */
	 public T visitStatement(@NotNull JavaParser.StatementContext ctx) { return visitChildren(ctx); }

	
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */
	 public T visitImportDeclaration(@NotNull JavaParser.ImportDeclarationContext ctx) { return visitChildren(ctx); }

	
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */
	 public T visitPrimitiveType(@NotNull JavaParser.PrimitiveTypeContext ctx) { return visitChildren(ctx); }

	
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */
	 public T visitInterfaceDeclaration(@NotNull JavaParser.InterfaceDeclarationContext ctx) { return visitChildren(ctx); }

	
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */
	 public T visitLocalVariableDeclarationStatement(@NotNull JavaParser.LocalVariableDeclarationStatementContext ctx) { return visitChildren(ctx); }

	
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */
	 public T visitBlockStatement(@NotNull JavaParser.BlockStatementContext ctx) { return visitChildren(ctx); }

	
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */
	 public T visitFieldDeclaration(@NotNull JavaParser.FieldDeclarationContext ctx) { return visitChildren(ctx); }

	
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */
	 public T visitConstantDeclarator(@NotNull JavaParser.ConstantDeclaratorContext ctx) { return visitChildren(ctx); }

	
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */
	 public T visitResources(@NotNull JavaParser.ResourcesContext ctx) { return visitChildren(ctx); }

	
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */
	 public T visitStatementExpression(@NotNull JavaParser.StatementExpressionContext ctx) { return visitChildren(ctx); }

	
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */
	 public T visitInterfaceMethodDeclaration(@NotNull JavaParser.InterfaceMethodDeclarationContext ctx) { return visitChildren(ctx); }

	
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */
	 public T visitPackageDeclaration(@NotNull JavaParser.PackageDeclarationContext ctx) { return visitChildren(ctx); }

	
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */
	 public T visitElementValuePairs(@NotNull JavaParser.ElementValuePairsContext ctx) { return visitChildren(ctx); }

	
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */
	 public T visitLocalVariableDeclaration(@NotNull JavaParser.LocalVariableDeclarationContext ctx) { return visitChildren(ctx); }

	
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */
	 public T visitNonWildcardTypeArguments(@NotNull JavaParser.NonWildcardTypeArgumentsContext ctx) { return visitChildren(ctx); }

	
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */
	 public T visitInterfaceMemberDeclaration(@NotNull JavaParser.InterfaceMemberDeclarationContext ctx) { return visitChildren(ctx); }

	
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */
	 public T visitSwitchLabel(@NotNull JavaParser.SwitchLabelContext ctx) { return visitChildren(ctx); }

	
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */
	 public T visitForInit(@NotNull JavaParser.ForInitContext ctx) { return visitChildren(ctx); }

	
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */
	 public T visitFormalParameters(@NotNull JavaParser.FormalParametersContext ctx) { return visitChildren(ctx); }

	
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */
	 public T visitArguments(@NotNull JavaParser.ArgumentsContext ctx) { return visitChildren(ctx); }

	
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */
	 public T visitGenericMethodDeclaration(@NotNull JavaParser.GenericMethodDeclarationContext ctx) { return visitChildren(ctx); }

	
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	/**
	 * {@inheritDoc}
	 *
	 * <p>The default implementation returns the result of calling
	 * {@link #visitChildren} on {@code ctx}.</p>
	 */
	 public T visitTypeArgumentsOrDiamond(@NotNull JavaParser.TypeArgumentsOrDiamondContext ctx) { return visitChildren(ctx); }
}
}
