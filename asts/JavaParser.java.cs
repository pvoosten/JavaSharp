// Generated from Java.g4 by ANTLR 4.3
using org.antlr.v4.runtime.atn;
using org.antlr.v4.runtime.dfa.DFA;
using org.antlr.v4.runtime;
using org.antlr.v4.runtime.tree;
using java.util.List;

namespace javasharp
{ { AT | @
}

SuppressWarnings(
{
    "all" , 
    "warnings" , 
    "unchecked" , 
    "unused" , 
    "cast"
} )

public class JavaParser
{
    EXTENDS |extends
}

Parser {
static {
RuntimeMetaData.checkVersion ( "4.3" , RuntimeMetaData.VERSION ) ;  } {PROTECTED |protected }
static {
FINAL |final }
DFA[] _decisionToDFA; {
PROTECTED |protected }
static {
FINAL |final }
PredictionContextCache _sharedContextCache = new PredictionContextCache();
public static {
FINAL |final } {
INT |int }
ABSTRACT =  { IntegerLiteral | 1 } , ASSERT =  { IntegerLiteral | 2 } , BOOLEAN =  { IntegerLiteral | 3 } , BREAK =  { IntegerLiteral | 4 } , BYTE =  { IntegerLiteral | 5 } , CASE =  { IntegerLiteral | 6 } , CATCH =  { IntegerLiteral | 7 } , CHAR =  { IntegerLiteral | 8 } , CLASS =  { IntegerLiteral | 9 } , CONST =  { IntegerLiteral | 10 } , CONTINUE =  { IntegerLiteral | 11 } , DEFAULT =  { IntegerLiteral | 12 } , DO =  { IntegerLiteral | 13 } , DOUBLE =  { IntegerLiteral | 14 } , ELSE =  { IntegerLiteral | 15 } , ENUM =  { IntegerLiteral | 16 } , EXTENDS =  { IntegerLiteral | 17 } , FINAL =  { IntegerLiteral | 18 } , FINALLY =  { IntegerLiteral | 19 } , FLOAT =  { IntegerLiteral | 20 } , FOR =  { IntegerLiteral | 21 } , IF =  { IntegerLiteral | 22 } , GOTO =  { IntegerLiteral | 23 } , IMPLEMENTS =  { IntegerLiteral | 24 } , IMPORT =  { IntegerLiteral | 25 } , INSTANCEOF =  { IntegerLiteral | 26 } , INT =  { IntegerLiteral | 27 } , INTERFACE =  { IntegerLiteral | 28 } , LONG =  { IntegerLiteral | 29 } , NATIVE =  { IntegerLiteral | 30 } , NEW =  { IntegerLiteral | 31 } , PACKAGE =  { IntegerLiteral | 32 } , PRIVATE =  { IntegerLiteral | 33 } , PROTECTED =  { IntegerLiteral | 34 } , PUBLIC =  { IntegerLiteral | 35 } , RETURN =  { IntegerLiteral | 36 } , SHORT =  { IntegerLiteral | 37 } , STATIC =  { IntegerLiteral | 38 } , STRICTFP =  { IntegerLiteral | 39 } , SUPER =  { IntegerLiteral | 40 } , SWITCH =  { IntegerLiteral | 41 } , SYNCHRONIZED =  { IntegerLiteral | 42 } , THIS =  { IntegerLiteral | 43 } , THROW =  { IntegerLiteral | 44 } , THROWS =  { IntegerLiteral | 45 } , TRANSIENT =  { IntegerLiteral | 46 } , TRY =  { IntegerLiteral | 47 } , VOID =  { IntegerLiteral | 48 } , VOLATILE =  { IntegerLiteral | 49 } , WHILE =  { IntegerLiteral | 50 } , IntegerLiteral =  { IntegerLiteral | 51 } , FloatingPointLiteral =  { IntegerLiteral | 52 } , BooleanLiteral =  { IntegerLiteral | 53 } , CharacterLiteral =  { IntegerLiteral | 54 } , StringLiteral =  { IntegerLiteral | 55 } , NullLiteral =  { IntegerLiteral | 56 } , LPAREN =  { IntegerLiteral | 57 } , RPAREN =  { IntegerLiteral | 58 } , LBRACE =  { IntegerLiteral | 59 } , RBRACE =  { IntegerLiteral | 60 } , LBRACK =  { IntegerLiteral | 61 } , RBRACK =  { IntegerLiteral | 62 } , SEMI =  { IntegerLiteral | 63 } , COMMA =  { IntegerLiteral | 64 } , DOT =  { IntegerLiteral | 65 } , ASSIGN =  { IntegerLiteral | 66 } , GT =  { IntegerLiteral | 67 } , LT =  { IntegerLiteral | 68 } , BANG =  { IntegerLiteral | 69 } , TILDE =  { IntegerLiteral | 70 } , QUESTION =  { IntegerLiteral | 71 } , COLON =  { IntegerLiteral | 72 } , EQUAL =  { IntegerLiteral | 73 } , LE =  { IntegerLiteral | 74 } , GE =  { IntegerLiteral | 75 } , NOTEQUAL =  { IntegerLiteral | 76 } , AND =  { IntegerLiteral | 77 } , OR =  { IntegerLiteral | 78 } , INC =  { IntegerLiteral | 79 } , DEC =  { IntegerLiteral | 80 } , ADD =  { IntegerLiteral | 81 } , SUB =  { IntegerLiteral | 82 } , MUL =  { IntegerLiteral | 83 } , DIV =  { IntegerLiteral | 84 } , BITAND =  { IntegerLiteral | 85 } , BITOR =  { IntegerLiteral | 86 } , CARET =  { IntegerLiteral | 87 } , MOD =  { IntegerLiteral | 88 } , ADD_ASSIGN =  { IntegerLiteral | 89 } , SUB_ASSIGN =  { IntegerLiteral | 90 } , MUL_ASSIGN =  { IntegerLiteral | 91 } , DIV_ASSIGN =  { IntegerLiteral | 92 } , AND_ASSIGN =  { IntegerLiteral | 93 } , OR_ASSIGN =  { IntegerLiteral | 94 } , XOR_ASSIGN =  { IntegerLiteral | 95 } , MOD_ASSIGN =  { IntegerLiteral | 96 } , LSHIFT_ASSIGN =  { IntegerLiteral | 97 } , RSHIFT_ASSIGN =  { IntegerLiteral | 98 } , URSHIFT_ASSIGN =  { IntegerLiteral | 99 } , Identifier =  { IntegerLiteral | 100 } , AT =  { IntegerLiteral | 101 } , ELLIPSIS =  { IntegerLiteral | 102 } , WS =  { IntegerLiteral | 103 } , COMMENT =  { IntegerLiteral | 104 } , LINE_COMMENT =  { IntegerLiteral | 105 } ; public static {
FINAL |final }
String[] tokenNames =
{
"<INVALID>", "'abstract'", "'assert'", "'boolean'", "'break'", "'byte'", "'case'", "'catch'", "'char'", "'class'", "'const'", "'continue'", "'default'", "'do'", "'double'", "'else'", "'enum'", "'extends'", "'final'", "'finally'", "'float'", "'for'", "'if'", "'goto'", "'implements'", "'import'", "'instanceof'", "'int'", "'interface'", "'long'", "'native'", "'new'", "'package'", "'private'", "'protected'", "'public'", "'return'", "'short'", "'static'", "'strictfp'", "'super'", "'switch'", "'synchronized'", "'this'", "'throw'", "'throws'", "'transient'", "'try'", "'void'", "'volatile'", "'while'", "IntegerLiteral", "FloatingPointLiteral", "BooleanLiteral", "CharacterLiteral", "StringLiteral", "'null'", "'('", "')'", "'{'", "'}'", "'['", "']'", "';'", "','", "'.'", "'='", "'>'", "'<'", "'!'", "'~'", "'?'", "':'", "'=='", "'<='", "'>='", "'!='", "'&&'", "'||'", "'++'", "'--'", "'+'", "'-'", "'*'", "'/'", "'&'", "'|'", "'^'", "'%'", "'+='", "'-='", "'*='", "'/='", "'&='", "'|='", "'^='", "'%='", "'<<='", "'>>='", "'>>>='", "Identifier", "'@'", "'...'", "WS", "COMMENT", "LINE_COMMENT"
}

;
public static {
FINAL |final } {
INT |int }
RULE_compilationUnit =  { IntegerLiteral | 0 } , RULE_packageDeclaration =  { IntegerLiteral | 1 } , RULE_importDeclaration =  { IntegerLiteral | 2 } , RULE_typeDeclaration =  { IntegerLiteral | 3 } , RULE_modifier =  { IntegerLiteral | 4 } , RULE_classOrInterfaceModifier =  { IntegerLiteral | 5 } , RULE_variableModifier =  { IntegerLiteral | 6 } , RULE_classDeclaration =  { IntegerLiteral | 7 } , RULE_typeParameters =  { IntegerLiteral | 8 } , RULE_typeParameter =  { IntegerLiteral | 9 } , RULE_typeBound =  { IntegerLiteral | 10 } , RULE_enumDeclaration =  { IntegerLiteral | 11 } , RULE_enumConstants =  { IntegerLiteral | 12 } , RULE_enumConstant =  { IntegerLiteral | 13 } , RULE_enumBodyDeclarations =  { IntegerLiteral | 14 } , RULE_interfaceDeclaration =  { IntegerLiteral | 15 } , RULE_typeList =  { IntegerLiteral | 16 } , RULE_classBody =  { IntegerLiteral | 17 } , RULE_interfaceBody =  { IntegerLiteral | 18 } , RULE_classBodyDeclaration =  { IntegerLiteral | 19 } , RULE_memberDeclaration =  { IntegerLiteral | 20 } , RULE_methodDeclaration =  { IntegerLiteral | 21 } , RULE_genericMethodDeclaration =  { IntegerLiteral | 22 } , RULE_constructorDeclaration =  { IntegerLiteral | 23 } , RULE_genericConstructorDeclaration =  { IntegerLiteral | 24 } , RULE_fieldDeclaration =  { IntegerLiteral | 25 } , RULE_interfaceBodyDeclaration =  { IntegerLiteral | 26 } , RULE_interfaceMemberDeclaration =  { IntegerLiteral | 27 } , RULE_constDeclaration =  { IntegerLiteral | 28 } , RULE_constantDeclarator =  { IntegerLiteral | 29 } , RULE_interfaceMethodDeclaration =  { IntegerLiteral | 30 } , RULE_genericInterfaceMethodDeclaration =  { IntegerLiteral | 31 } , RULE_variableDeclarators =  { IntegerLiteral | 32 } , RULE_variableDeclarator =  { IntegerLiteral | 33 } , RULE_variableDeclaratorId =  { IntegerLiteral | 34 } , RULE_variableInitializer =  { IntegerLiteral | 35 } , RULE_arrayInitializer =  { IntegerLiteral | 36 } , RULE_enumConstantName =  { IntegerLiteral | 37 } , RULE_type =  { IntegerLiteral | 38 } , RULE_classOrInterfaceType =  { IntegerLiteral | 39 } , RULE_primitiveType =  { IntegerLiteral | 40 } , RULE_typeArguments =  { IntegerLiteral | 41 } , RULE_typeArgument =  { IntegerLiteral | 42 } , RULE_qualifiedNameList =  { IntegerLiteral | 43 } , RULE_formalParameters =  { IntegerLiteral | 44 } , RULE_formalParameterList =  { IntegerLiteral | 45 } , RULE_formalParameter =  { IntegerLiteral | 46 } , RULE_lastFormalParameter =  { IntegerLiteral | 47 } , RULE_methodBody =  { IntegerLiteral | 48 } , RULE_constructorBody =  { IntegerLiteral | 49 } , RULE_qualifiedName =  { IntegerLiteral | 50 } , RULE_literal =  { IntegerLiteral | 51 } , RULE_annotation =  { IntegerLiteral | 52 } , RULE_annotationName =  { IntegerLiteral | 53 } , RULE_elementValuePairs =  { IntegerLiteral | 54 } , RULE_elementValuePair =  { IntegerLiteral | 55 } , RULE_elementValue =  { IntegerLiteral | 56 } , RULE_elementValueArrayInitializer =  { IntegerLiteral | 57 } , RULE_annotationTypeDeclaration =  { IntegerLiteral | 58 } , RULE_annotationTypeBody =  { IntegerLiteral | 59 } , RULE_annotationTypeElementDeclaration =  { IntegerLiteral | 60 } , RULE_annotationTypeElementRest =  { IntegerLiteral | 61 } , RULE_annotationMethodOrConstantRest =  { IntegerLiteral | 62 } , RULE_annotationMethodRest =  { IntegerLiteral | 63 } , RULE_annotationConstantRest =  { IntegerLiteral | 64 } , RULE_defaultValue =  { IntegerLiteral | 65 } , RULE_block =  { IntegerLiteral | 66 } , RULE_blockStatement =  { IntegerLiteral | 67 } , RULE_localVariableDeclarationStatement =  { IntegerLiteral | 68 } , RULE_localVariableDeclaration =  { IntegerLiteral | 69 } , RULE_statement =  { IntegerLiteral | 70 } , RULE_catchClause =  { IntegerLiteral | 71 } , RULE_catchType =  { IntegerLiteral | 72 } , RULE_finallyBlock =  { IntegerLiteral | 73 } , RULE_resourceSpecification =  { IntegerLiteral | 74 } , RULE_resources =  { IntegerLiteral | 75 } , RULE_resource =  { IntegerLiteral | 76 } , RULE_switchBlockStatementGroup =  { IntegerLiteral | 77 } , RULE_switchLabel =  { IntegerLiteral | 78 } , RULE_forControl =  { IntegerLiteral | 79 } , RULE_forInit =  { IntegerLiteral | 80 } , RULE_enhancedForControl =  { IntegerLiteral | 81 } , RULE_forUpdate =  { IntegerLiteral | 82 } , RULE_parExpression =  { IntegerLiteral | 83 } , RULE_expressionList =  { IntegerLiteral | 84 } , RULE_statementExpression =  { IntegerLiteral | 85 } , RULE_constantExpression =  { IntegerLiteral | 86 } , RULE_expression =  { IntegerLiteral | 87 } , RULE_primary =  { IntegerLiteral | 88 } , RULE_creator =  { IntegerLiteral | 89 } , RULE_createdName =  { IntegerLiteral | 90 } , RULE_innerCreator =  { IntegerLiteral | 91 } , RULE_arrayCreatorRest =  { IntegerLiteral | 92 } , RULE_classCreatorRest =  { IntegerLiteral | 93 } , RULE_explicitGenericInvocation =  { IntegerLiteral | 94 } , RULE_nonWildcardTypeArguments =  { IntegerLiteral | 95 } , RULE_typeArgumentsOrDiamond =  { IntegerLiteral | 96 } , RULE_nonWildcardTypeArgumentsOrDiamond =  { IntegerLiteral | 97 } , RULE_superSuffix =  { IntegerLiteral | 98 } , RULE_explicitGenericInvocationSuffix =  { IntegerLiteral | 99 } , RULE_arguments =  { IntegerLiteral | 100 } ; public static {
FINAL |final }
String[] ruleNames =
{
"compilationUnit", "packageDeclaration", "importDeclaration", "typeDeclaration", "modifier", "classOrInterfaceModifier", "variableModifier", "classDeclaration", "typeParameters", "typeParameter", "typeBound", "enumDeclaration", "enumConstants", "enumConstant", "enumBodyDeclarations", "interfaceDeclaration", "typeList", "classBody", "interfaceBody", "classBodyDeclaration", "memberDeclaration", "methodDeclaration", "genericMethodDeclaration", "constructorDeclaration", "genericConstructorDeclaration", "fieldDeclaration", "interfaceBodyDeclaration", "interfaceMemberDeclaration", "constDeclaration", "constantDeclarator", "interfaceMethodDeclaration", "genericInterfaceMethodDeclaration", "variableDeclarators", "variableDeclarator", "variableDeclaratorId", "variableInitializer", "arrayInitializer", "enumConstantName", "type", "classOrInterfaceType", "primitiveType", "typeArguments", "typeArgument", "qualifiedNameList", "formalParameters", "formalParameterList", "formalParameter", "lastFormalParameter", "methodBody", "constructorBody", "qualifiedName", "literal", "annotation", "annotationName", "elementValuePairs", "elementValuePair", "elementValue", "elementValueArrayInitializer", "annotationTypeDeclaration", "annotationTypeBody", "annotationTypeElementDeclaration", "annotationTypeElementRest", "annotationMethodOrConstantRest", "annotationMethodRest", "annotationConstantRest", "defaultValue", "block", "blockStatement", "localVariableDeclarationStatement", "localVariableDeclaration", "statement", "catchClause", "catchType", "finallyBlock", "resourceSpecification", "resources", "resource", "switchBlockStatementGroup", "switchLabel", "forControl", "forInit", "enhancedForControl", "forUpdate", "parExpression", "expressionList", "statementExpression", "constantExpression", "expression", "primary", "creator", "createdName", "innerCreator", "arrayCreatorRest", "classCreatorRest", "explicitGenericInvocation", "nonWildcardTypeArguments", "typeArgumentsOrDiamond", "nonWildcardTypeArgumentsOrDiamond", "superSuffix", "explicitGenericInvocationSuffix", "arguments"
}

; {
AT | @ }Override public StringgetGrammarFileName()
{
    {
        RETURN | return
    }

    "Java.g4";
} {

AT | @ }Override public String[] getTokenNames()
{
    {
        RETURN | return
    }

    tokenNames;
} {

AT | @ }Override public String[] getRuleNames()
{
    {
        RETURN | return
    }

    ruleNames;
} {

AT | @ }Override public StringgetSerializedATN()
{
    {
        RETURN | return
    }

    _serializedATN;
} {

AT | @ }Override public ATNgetATN()
{
    {
        RETURN | return
    }

    _ATN;
}

public JavaParser(TokenStream input)
{
    {
        SUPER | super
    }

    (input);
    _interp = new ParserATNSimulator(
    {
    THIS | this
    }

     , 
    _ATN , 
    _decisionToDFA , 
    _sharedContextCache )
    ;
}

public static class CompilationUnitContext
{
    EXTENDS |extends
}

ParserRuleContext {
public TypeDeclarationContexttypeDeclaration(
{
    INT | int
}

i ) { {RETURN | return }getRuleContext(TypeDeclarationContext.class , 

i ) ;  }public ImportDeclarationContextimportDeclaration(
{
    INT | int
}

i ) { {RETURN | return }getRuleContext(ImportDeclarationContext.class , 

i ) ;  }public List {
LT | < }ImportDeclarationContext {
GT | > }importDeclaration()
{
    {
        RETURN | return
    }

    getRuleContexts(ImportDeclarationContext.class ) ;  }

public TerminalNodeEOF()
{
    {
        RETURN | return
    }

    getToken(JavaParser.EOF, {
        IntegerLiteral | 0
    } )

    ;
}

public PackageDeclarationContextpackageDeclaration()
{
    {
        RETURN | return
    }

    getRuleContext(PackageDeclarationContext.class ,  {

IntegerLiteral | 0 } ) ;  }public List {
LT | < }TypeDeclarationContext {
GT | > }typeDeclaration()
{
    {
        RETURN | return
    }

    getRuleContexts(TypeDeclarationContext.class ) ;  }

public CompilationUnitContext(ParserRuleContext parent, {
    INT | int
}

invokingState ) { {SUPER |super } (
parent , invokingState ) ;  } {AT | @ }Override public {
INT |int }
getRuleIndex()
{
    {
        RETURN | return
    }

    RULE_compilationUnit;
} {

AT | @ }Override public void enterRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterCompilationUnit(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public void exitRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitCompilationUnit(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public {
LT | < }T {
GT | > }Taccept(ParseTreeVisitor
{
    LT | <
} {

QUESTION |? } {
EXTENDS |extends }
T {
GT | > }visitor ) { {IF | if } (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) {RETURN | return } ( (JavaVisitor {
LT | < } {QUESTION |? } {
EXTENDS |extends }
T {
GT | > } )visitor ) .visitCompilationUnit(
{
    THIS | this
} ) ;  {

ELSE | else } {RETURN | return }visitor.visitChildren ( {THIS |this
} ) ;  } }

public {
FINAL |final }
CompilationUnitContextcompilationUnit()
{
    CompilationUnitContext _localctx = new CompilationUnitContext(_ctx, getState());
    enterRule(_localctx, {
        IntegerLiteral | 0
    } , 

    RULE_compilationUnit )
    ;
    {
        INT | int
    }

    _la;
    try
    {
        enterOuterAlt(_localctx, {
            IntegerLiteral | 1
        } )

        ;
        {
            setState(
            {
                IntegerLiteral | 203
            } )

            ;
            {
                SWITCH | switch
                }

                (getInterpreter().adaptivePredict(_input, {
                    IntegerLiteral | 0
                } , 

                _ctx ) )
                {
                    {
                        CASE |  case
                    }

                    {
                        IntegerLiteral | 1
                    }

                    {
                        COLON |  : 
                    }

                    {
                        setState(
                        {
                            IntegerLiteral | 202
                        } )

                        ;
                        packageDeclaration();
                    }

                    {
                        BREAK | break
                    }

                    ;
                }

                setState(
                {
                    IntegerLiteral | 208
                } )

                ;
                _errHandler.sync(
                {
                    THIS | this
                } )

                ;
                _la = _input.LA(
                {
                    IntegerLiteral | 1
                } )

                ;
                {
                    WHILE | while
                }

                (_la
                {
                    EQUAL |= =
                }

                IMPORT )
                {
                    {
                        {
                            setState(
                            {
                                IntegerLiteral | 205
                            } )

                            ;
                            importDeclaration();
                        }
                    }

                    setState(
                    {
                        IntegerLiteral | 210
                    } )

                    ;
                    _errHandler.sync(
                    {
                        THIS | this
                    } )

                    ;
                    _la = _input.LA(
                    {
                        IntegerLiteral | 1
                    } )

                    ;
                }

                setState(
                {
                    IntegerLiteral | 214
                } )

                ;
                _errHandler.sync(
                {
                    THIS | this
                } )

                ;
                _la = _input.LA(
                {
                    IntegerLiteral | 1
                } )

                ;
                {
                    WHILE | while
                }

                ((((_la)
                {
                    BITAND | &
                }

                {
                    TILDE | ~
                }

                {
                    IntegerLiteral | 0x3f
                } )

                {
                    EQUAL |= =
                }

                {
                    IntegerLiteral | 0
                }

                {
                    AND | &&
                }

                ((
                {
                    IntegerLiteral | 1L
                }

                {
                    LT | <
                }

                {
                    LT | <
                }

                _la )
                {
                    BITAND | &
                }

                ((
                {
                    IntegerLiteral | 1L
                }

                {
                    LT | <
                }

                {
                    LT | <
                }

                ABSTRACT )
                {
                    BITOR ||
                }

                (
                {
                    IntegerLiteral | 1L
                }

                {
                    LT | <
                }

                {
                    LT | <
                }

                CLASS )
                {
                    BITOR ||
                }

                (
                {
                    IntegerLiteral | 1L
                }

                {
                    LT | <
                }

                {
                    LT | <
                }

                ENUM )
                {
                    BITOR ||
                }

                (
                {
                    IntegerLiteral | 1L
                }

                {
                    LT | <
                }

                {
                    LT | <
                }

                FINAL )
                {
                    BITOR ||
                }

                (
                {
                    IntegerLiteral | 1L
                }

                {
                    LT | <
                }

                {
                    LT | <
                }

                INTERFACE )
                {
                    BITOR ||
                }

                (
                {
                    IntegerLiteral | 1L
                }

                {
                    LT | <
                }

                {
                    LT | <
                }

                PRIVATE )
                {
                    BITOR ||
                }

                (
                {
                    IntegerLiteral | 1L
                }

                {
                    LT | <
                }

                {
                    LT | <
                }

                PROTECTED )
                {
                    BITOR ||
                }

                (
                {
                    IntegerLiteral | 1L
                }

                {
                    LT | <
                }

                {
                    LT | <
                }

                PUBLIC )
                {
                    BITOR ||
                }

                (
                {
                    IntegerLiteral | 1L
                }

                {
                    LT | <
                }

                {
                    LT | <
                }

                STATIC )
                {
                    BITOR ||
                }

                (
                {
                    IntegerLiteral | 1L
                }

                {
                    LT | <
                }

                {
                    LT | <
                }

                STRICTFP )
                {
                    BITOR ||
                }

                (
                {
                    IntegerLiteral | 1L
                }

                {
                    LT | <
                }

                {
                    LT | <
                }

                SEMI ) ) )
                {
                    NOTEQUAL | !=
                }

                {
                    IntegerLiteral | 0
                } )

                {
                    OR || |
                }

                _la
                {
                    EQUAL |= =
                }

                AT )
                {
                    {
                        {
                            setState(
                            {
                                IntegerLiteral | 211
                            } )

                            ;
                            typeDeclaration();
                        }
                    }

                    setState(
                    {
                        IntegerLiteral | 216
                    } )

                    ;
                    _errHandler.sync(
                    {
                        THIS | this
                    } )

                    ;
                    _la = _input.LA(
                    {
                        IntegerLiteral | 1
                    } )

                    ;
                }

                setState(
                {
                    IntegerLiteral | 217
                } )

                ;
                match(EOF);
            }
        }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(
        {
            THIS | this
        } , 

        re )
        ;
        _errHandler.recover(
        {
            THIS | this
        } , 

        re )
        ;
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        {
            RETURN | return
        }

        _localctx;
    }

public static class PackageDeclarationContext
{
    EXTENDS |extends
}

ParserRuleContext {
public List {
LT | < }AnnotationContext {
GT | > }annotation()
{
    {
        RETURN | return
    }

    getRuleContexts(AnnotationContext.class ) ;  }

public QualifiedNameContextqualifiedName()
{
    {
        RETURN | return
    }

    getRuleContext(QualifiedNameContext.class ,  {

IntegerLiteral | 0 } ) ;  }public AnnotationContextannotation(
{
    INT | int
}

i ) { {RETURN | return }getRuleContext(AnnotationContext.class , 

i ) ;  }public PackageDeclarationContext(ParserRuleContext parent, {
    INT | int
}

invokingState ) { {SUPER |super } (
parent , invokingState ) ;  } {AT | @ }Override public {
INT |int }
getRuleIndex()
{
    {
        RETURN | return
    }

    RULE_packageDeclaration;
} {

AT | @ }Override public void enterRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterPackageDeclaration(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public void exitRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitPackageDeclaration(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public {
LT | < }T {
GT | > }Taccept(ParseTreeVisitor
{
    LT | <
} {

QUESTION |? } {
EXTENDS |extends }
T {
GT | > }visitor ) { {IF | if } (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) {RETURN | return } ( (JavaVisitor {
LT | < } {QUESTION |? } {
EXTENDS |extends }
T {
GT | > } )visitor ) .visitPackageDeclaration(
{
    THIS | this
} ) ;  {

ELSE | else } {RETURN | return }visitor.visitChildren ( {THIS |this
} ) ;  } }

public {
FINAL |final }
PackageDeclarationContextpackageDeclaration()
{
    PackageDeclarationContext _localctx = new PackageDeclarationContext(_ctx, getState());
    enterRule(_localctx, {
        IntegerLiteral | 2
    } , 

    RULE_packageDeclaration )
    ;
    {
        INT | int
    }

    _la;
    try
    {
        enterOuterAlt(_localctx, {
            IntegerLiteral | 1
        } )

        ;
        {
            setState(
            {
                IntegerLiteral | 222
            } )

            ;
            _errHandler.sync(
            {
                THIS | this
            } )

            ;
            _la = _input.LA(
            {
                IntegerLiteral | 1
            } )

            ;
            {
                WHILE | while
            }

            (_la
            {
                EQUAL |= =
            }

            AT )
            {
                {
                    {
                        setState(
                        {
                            IntegerLiteral | 219
                        } )

                        ;
                        annotation();
                    }
                }

                setState(
                {
                    IntegerLiteral | 224
                } )

                ;
                _errHandler.sync(
                {
                    THIS | this
                } )

                ;
                _la = _input.LA(
                {
                    IntegerLiteral | 1
                } )

                ;
            }

            setState(
            {
                IntegerLiteral | 225
            } )

            ;
            match(PACKAGE);
            setState(
            {
                IntegerLiteral | 226
            } )

            ;
            qualifiedName();
            setState(
            {
                IntegerLiteral | 227
            } )

            ;
            match(SEMI);
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(
        {
            THIS | this
        } , 

        re )
        ;
        _errHandler.recover(
        {
            THIS | this
        } , 

        re )
        ;
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        {
            RETURN | return
        }

        _localctx;
    }

public static class ImportDeclarationContext
{
    EXTENDS |extends
}

ParserRuleContext {
public QualifiedNameContextqualifiedName()
{
    {
        RETURN | return
    }

    getRuleContext(QualifiedNameContext.class ,  {

IntegerLiteral | 0 } ) ;  }public ImportDeclarationContext(ParserRuleContext parent, {
    INT | int
}

invokingState ) { {SUPER |super } (
parent , invokingState ) ;  } {AT | @ }Override public {
INT |int }
getRuleIndex()
{
    {
        RETURN | return
    }

    RULE_importDeclaration;
} {

AT | @ }Override public void enterRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterImportDeclaration(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public void exitRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitImportDeclaration(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public {
LT | < }T {
GT | > }Taccept(ParseTreeVisitor
{
    LT | <
} {

QUESTION |? } {
EXTENDS |extends }
T {
GT | > }visitor ) { {IF | if } (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) {RETURN | return } ( (JavaVisitor {
LT | < } {QUESTION |? } {
EXTENDS |extends }
T {
GT | > } )visitor ) .visitImportDeclaration(
{
    THIS | this
} ) ;  {

ELSE | else } {RETURN | return }visitor.visitChildren ( {THIS |this
} ) ;  } }

public {
FINAL |final }
ImportDeclarationContextimportDeclaration()
{
    ImportDeclarationContext _localctx = new ImportDeclarationContext(_ctx, getState());
    enterRule(_localctx, {
        IntegerLiteral | 4
    } , 

    RULE_importDeclaration )
    ;
    {
        INT | int
    }

    _la;
    try
    {
        enterOuterAlt(_localctx, {
            IntegerLiteral | 1
        } )

        ;
        {
            setState(
            {
                IntegerLiteral | 229
            } )

            ;
            match(IMPORT);
            setState(
            {
                IntegerLiteral | 231
            } )

            ;
            _la = _input.LA(
            {
                IntegerLiteral | 1
            } )

            ;
            {
                IF | if
            }

            (_la
            {
                EQUAL |= =
            }

            STATIC )
            {
                {
                    setState(
                    {
                        IntegerLiteral | 230
                    } )

                    ;
                    match(STATIC);
                }
            }

            setState(
            {
                IntegerLiteral | 233
            } )

            ;
            qualifiedName();
            setState(
            {
                IntegerLiteral | 236
            } )

            ;
            _la = _input.LA(
            {
                IntegerLiteral | 1
            } )

            ;
            {
                IF | if
            }

            (_la
            {
                EQUAL |= =
            }

            DOT )
            {
                {
                    setState(
                    {
                        IntegerLiteral | 234
                    } )

                    ;
                    match(DOT);
                    setState(
                    {
                        IntegerLiteral | 235
                    } )

                    ;
                    match(MUL);
                }
            }

            setState(
            {
                IntegerLiteral | 238
            } )

            ;
            match(SEMI);
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(
        {
            THIS | this
        } , 

        re )
        ;
        _errHandler.recover(
        {
            THIS | this
        } , 

        re )
        ;
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        {
            RETURN | return
        }

        _localctx;
    }

public static class TypeDeclarationContext
{
    EXTENDS |extends
}

ParserRuleContext {
public ClassOrInterfaceModifierContextclassOrInterfaceModifier(
{
    INT | int
}

i ) { {RETURN | return }getRuleContext(ClassOrInterfaceModifierContext.class , 

i ) ;  }public EnumDeclarationContextenumDeclaration()
{
    {
        RETURN | return
    }

    getRuleContext(EnumDeclarationContext.class ,  {

IntegerLiteral | 0 } ) ;  }public ClassDeclarationContextclassDeclaration()
{
    {
        RETURN | return
    }

    getRuleContext(ClassDeclarationContext.class ,  {

IntegerLiteral | 0 } ) ;  }public AnnotationTypeDeclarationContextannotationTypeDeclaration()
{
    {
        RETURN | return
    }

    getRuleContext(AnnotationTypeDeclarationContext.class ,  {

IntegerLiteral | 0 } ) ;  }public List {
LT | < }ClassOrInterfaceModifierContext {
GT | > }classOrInterfaceModifier()
{
    {
        RETURN | return
    }

    getRuleContexts(ClassOrInterfaceModifierContext.class ) ;  }

public InterfaceDeclarationContextinterfaceDeclaration()
{
    {
        RETURN | return
    }

    getRuleContext(InterfaceDeclarationContext.class ,  {

IntegerLiteral | 0 } ) ;  }public TypeDeclarationContext(ParserRuleContext parent, {
    INT | int
}

invokingState ) { {SUPER |super } (
parent , invokingState ) ;  } {AT | @ }Override public {
INT |int }
getRuleIndex()
{
    {
        RETURN | return
    }

    RULE_typeDeclaration;
} {

AT | @ }Override public void enterRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterTypeDeclaration(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public void exitRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitTypeDeclaration(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public {
LT | < }T {
GT | > }Taccept(ParseTreeVisitor
{
    LT | <
} {

QUESTION |? } {
EXTENDS |extends }
T {
GT | > }visitor ) { {IF | if } (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) {RETURN | return } ( (JavaVisitor {
LT | < } {QUESTION |? } {
EXTENDS |extends }
T {
GT | > } )visitor ) .visitTypeDeclaration(
{
    THIS | this
} ) ;  {

ELSE | else } {RETURN | return }visitor.visitChildren ( {THIS |this
} ) ;  } }

public {
FINAL |final }
TypeDeclarationContexttypeDeclaration()
{
    TypeDeclarationContext _localctx = new TypeDeclarationContext(_ctx, getState());
    enterRule(_localctx, {
        IntegerLiteral | 6
    } , 

    RULE_typeDeclaration )
    ;
    {
        INT | int
    }

    _la;
    try
    {
        {
            INT | int
        }

        _alt;
        setState(
        {
            IntegerLiteral | 269
        } )

        ;
        {
            SWITCH | switch
            }

            (getInterpreter().adaptivePredict(_input, {
                IntegerLiteral | 10
            } , 

            _ctx ) )
            {
                {
                    CASE |  case
                }

                {
                    IntegerLiteral | 1
                }

                {
                    COLON |  : 
                }

                enterOuterAlt(_localctx, {
                    IntegerLiteral | 1
                } )

                ;
                {
                    setState(
                    {
                        IntegerLiteral | 243
                    } )

                    ;
                    _errHandler.sync(
                    {
                        THIS | this
                    } )

                    ;
                    _la = _input.LA(
                    {
                        IntegerLiteral | 1
                    } )

                    ;
                    {
                        WHILE | while
                    }

                    ((((_la)
                    {
                        BITAND | &
                    }

                    {
                        TILDE | ~
                    }

                    {
                        IntegerLiteral | 0x3f
                    } )

                    {
                        EQUAL |= =
                    }

                    {
                        IntegerLiteral | 0
                    }

                    {
                        AND | &&
                    }

                    ((
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    _la )
                    {
                        BITAND | &
                    }

                    ((
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    ABSTRACT )
                    {
                        BITOR ||
                    }

                    (
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    FINAL )
                    {
                        BITOR ||
                    }

                    (
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    PRIVATE )
                    {
                        BITOR ||
                    }

                    (
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    PROTECTED )
                    {
                        BITOR ||
                    }

                    (
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    PUBLIC )
                    {
                        BITOR ||
                    }

                    (
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    STATIC )
                    {
                        BITOR ||
                    }

                    (
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    STRICTFP ) ) )
                    {
                        NOTEQUAL | !=
                    }

                    {
                        IntegerLiteral | 0
                    } )

                    {
                        OR || |
                    }

                    _la
                    {
                        EQUAL |= =
                    }

                    AT )
                    {
                        {
                            {
                                setState(
                                {
                                    IntegerLiteral | 240
                                } )

                                ;
                                classOrInterfaceModifier();
                            }
                        }

                        setState(
                        {
                            IntegerLiteral | 245
                        } )

                        ;
                        _errHandler.sync(
                        {
                            THIS | this
                        } )

                        ;
                        _la = _input.LA(
                        {
                            IntegerLiteral | 1
                        } )

                        ;
                    }

                    setState(
                    {
                        IntegerLiteral | 246
                    } )

                    ;
                    classDeclaration();
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                {
                    IntegerLiteral | 2
                }

                {
                    COLON |  : 
                }

                enterOuterAlt(_localctx, {
                    IntegerLiteral | 2
                } )

                ;
                {
                    setState(
                    {
                        IntegerLiteral | 250
                    } )

                    ;
                    _errHandler.sync(
                    {
                        THIS | this
                    } )

                    ;
                    _la = _input.LA(
                    {
                        IntegerLiteral | 1
                    } )

                    ;
                    {
                        WHILE | while
                    }

                    ((((_la)
                    {
                        BITAND | &
                    }

                    {
                        TILDE | ~
                    }

                    {
                        IntegerLiteral | 0x3f
                    } )

                    {
                        EQUAL |= =
                    }

                    {
                        IntegerLiteral | 0
                    }

                    {
                        AND | &&
                    }

                    ((
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    _la )
                    {
                        BITAND | &
                    }

                    ((
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    ABSTRACT )
                    {
                        BITOR ||
                    }

                    (
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    FINAL )
                    {
                        BITOR ||
                    }

                    (
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    PRIVATE )
                    {
                        BITOR ||
                    }

                    (
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    PROTECTED )
                    {
                        BITOR ||
                    }

                    (
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    PUBLIC )
                    {
                        BITOR ||
                    }

                    (
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    STATIC )
                    {
                        BITOR ||
                    }

                    (
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    STRICTFP ) ) )
                    {
                        NOTEQUAL | !=
                    }

                    {
                        IntegerLiteral | 0
                    } )

                    {
                        OR || |
                    }

                    _la
                    {
                        EQUAL |= =
                    }

                    AT )
                    {
                        {
                            {
                                setState(
                                {
                                    IntegerLiteral | 247
                                } )

                                ;
                                classOrInterfaceModifier();
                            }
                        }

                        setState(
                        {
                            IntegerLiteral | 252
                        } )

                        ;
                        _errHandler.sync(
                        {
                            THIS | this
                        } )

                        ;
                        _la = _input.LA(
                        {
                            IntegerLiteral | 1
                        } )

                        ;
                    }

                    setState(
                    {
                        IntegerLiteral | 253
                    } )

                    ;
                    enumDeclaration();
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                {
                    IntegerLiteral | 3
                }

                {
                    COLON |  : 
                }

                enterOuterAlt(_localctx, {
                    IntegerLiteral | 3
                } )

                ;
                {
                    setState(
                    {
                        IntegerLiteral | 257
                    } )

                    ;
                    _errHandler.sync(
                    {
                        THIS | this
                    } )

                    ;
                    _la = _input.LA(
                    {
                        IntegerLiteral | 1
                    } )

                    ;
                    {
                        WHILE | while
                    }

                    ((((_la)
                    {
                        BITAND | &
                    }

                    {
                        TILDE | ~
                    }

                    {
                        IntegerLiteral | 0x3f
                    } )

                    {
                        EQUAL |= =
                    }

                    {
                        IntegerLiteral | 0
                    }

                    {
                        AND | &&
                    }

                    ((
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    _la )
                    {
                        BITAND | &
                    }

                    ((
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    ABSTRACT )
                    {
                        BITOR ||
                    }

                    (
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    FINAL )
                    {
                        BITOR ||
                    }

                    (
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    PRIVATE )
                    {
                        BITOR ||
                    }

                    (
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    PROTECTED )
                    {
                        BITOR ||
                    }

                    (
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    PUBLIC )
                    {
                        BITOR ||
                    }

                    (
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    STATIC )
                    {
                        BITOR ||
                    }

                    (
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    STRICTFP ) ) )
                    {
                        NOTEQUAL | !=
                    }

                    {
                        IntegerLiteral | 0
                    } )

                    {
                        OR || |
                    }

                    _la
                    {
                        EQUAL |= =
                    }

                    AT )
                    {
                        {
                            {
                                setState(
                                {
                                    IntegerLiteral | 254
                                } )

                                ;
                                classOrInterfaceModifier();
                            }
                        }

                        setState(
                        {
                            IntegerLiteral | 259
                        } )

                        ;
                        _errHandler.sync(
                        {
                            THIS | this
                        } )

                        ;
                        _la = _input.LA(
                        {
                            IntegerLiteral | 1
                        } )

                        ;
                    }

                    setState(
                    {
                        IntegerLiteral | 260
                    } )

                    ;
                    interfaceDeclaration();
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                {
                    IntegerLiteral | 4
                }

                {
                    COLON |  : 
                }

                enterOuterAlt(_localctx, {
                    IntegerLiteral | 4
                } )

                ;
                {
                    setState(
                    {
                        IntegerLiteral | 264
                    } )

                    ;
                    _errHandler.sync(
                    {
                        THIS | this
                    } )

                    ;
                    _alt = getInterpreter().adaptivePredict(_input, {
                        IntegerLiteral | 9
                    } , 

                    _ctx )
                    ;
                    {
                        WHILE | while
                    }

                    (_alt
                    {
                        NOTEQUAL | !=
                    }

                    {
                        IntegerLiteral | 2
                    }

                    {
                        AND | &&
                    }

                    _alt
                    {
                        NOTEQUAL | !=
                    }

                    org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER )
                    {
                        {
                            IF | if
                        }

                        (_alt
                        {
                            EQUAL |= =
                        }

                        {
                            IntegerLiteral | 1
                        } )

                        {
                            {
                                {
                                    setState(
                                    {
                                        IntegerLiteral | 261
                                    } )

                                    ;
                                    classOrInterfaceModifier();
                                }
                            }
                        }

                        setState(
                        {
                            IntegerLiteral | 266
                        } )

                        ;
                        _errHandler.sync(
                        {
                            THIS | this
                        } )

                        ;
                        _alt = getInterpreter().adaptivePredict(_input, {
                            IntegerLiteral | 9
                        } , 

                        _ctx )
                        ;
                    }

                    setState(
                    {
                        IntegerLiteral | 267
                    } )

                    ;
                    annotationTypeDeclaration();
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                {
                    IntegerLiteral | 5
                }

                {
                    COLON |  : 
                }

                enterOuterAlt(_localctx, {
                    IntegerLiteral | 5
                } )

                ;
                {
                    setState(
                    {
                        IntegerLiteral | 268
                    } )

                    ;
                    match(SEMI);
                }

                {
                    BREAK | break
                }

                ;
            }
        }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(
        {
            THIS | this
        } , 

        re )
        ;
        _errHandler.recover(
        {
            THIS | this
        } , 

        re )
        ;
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        {
            RETURN | return
        }

        _localctx;
    }

public static class ModifierContext
{
    EXTENDS |extends
}

ParserRuleContext {
public ClassOrInterfaceModifierContextclassOrInterfaceModifier()
{
    {
        RETURN | return
    }

    getRuleContext(ClassOrInterfaceModifierContext.class ,  {

IntegerLiteral | 0 } ) ;  }public ModifierContext(ParserRuleContext parent, {
    INT | int
}

invokingState ) { {SUPER |super } (
parent , invokingState ) ;  } {AT | @ }Override public {
INT |int }
getRuleIndex()
{
    {
        RETURN | return
    }

    RULE_modifier;
} {

AT | @ }Override public void enterRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterModifier(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public void exitRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitModifier(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public {
LT | < }T {
GT | > }Taccept(ParseTreeVisitor
{
    LT | <
} {

QUESTION |? } {
EXTENDS |extends }
T {
GT | > }visitor ) { {IF | if } (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) {RETURN | return } ( (JavaVisitor {
LT | < } {QUESTION |? } {
EXTENDS |extends }
T {
GT | > } )visitor ) .visitModifier(
{
    THIS | this
} ) ;  {

ELSE | else } {RETURN | return }visitor.visitChildren ( {THIS |this
} ) ;  } }

public {
FINAL |final }
ModifierContextmodifier()
{
    ModifierContext _localctx = new ModifierContext(_ctx, getState());
    enterRule(_localctx, {
        IntegerLiteral | 8
    } , 

    RULE_modifier )
    ;
    {
        INT | int
    }

    _la;
    try
    {
        setState(
        {
            IntegerLiteral | 273
        } )

        ;
        {
            SWITCH | switch
            }

            (_input.LA(
            {
                IntegerLiteral | 1
            } ) )

            {
                {
                    CASE |  case
                }

                ABSTRACT
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                FINAL
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                PRIVATE
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                PROTECTED
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                PUBLIC
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                STATIC
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                STRICTFP
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                AT
                {
                    COLON |  : 
                }

                enterOuterAlt(_localctx, {
                    IntegerLiteral | 1
                } )

                ;
                {
                    setState(
                    {
                        IntegerLiteral | 271
                    } )

                    ;
                    classOrInterfaceModifier();
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                NATIVE
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                SYNCHRONIZED
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                TRANSIENT
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                VOLATILE
                {
                    COLON |  : 
                }

                enterOuterAlt(_localctx, {
                    IntegerLiteral | 2
                } )

                ;
                {
                    setState(
                    {
                        IntegerLiteral | 272
                    } )

                    ;
                    _la = _input.LA(
                    {
                        IntegerLiteral | 1
                    } )

                    ;
                    {
                        IF | if
                    }

                    (
                    {
                        BANG | !
                    }

                    ((((_la)
                    {
                        BITAND | &
                    }

                    {
                        TILDE | ~
                    }

                    {
                        IntegerLiteral | 0x3f
                    } )

                    {
                        EQUAL |= =
                    }

                    {
                        IntegerLiteral | 0
                    }

                    {
                        AND | &&
                    }

                    ((
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    _la )
                    {
                        BITAND | &
                    }

                    ((
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    NATIVE )
                    {
                        BITOR ||
                    }

                    (
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    SYNCHRONIZED )
                    {
                        BITOR ||
                    }

                    (
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    TRANSIENT )
                    {
                        BITOR ||
                    }

                    (
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    VOLATILE ) ) )
                    {
                        NOTEQUAL | !=
                    }

                    {
                        IntegerLiteral | 0
                    } ) ) )

                    {
                        _errHandler.recoverInline(
                        {
                            THIS | this
                        } )

                        ;
                    }

                    consume();
                }

                {
                    BREAK | break
                }

                ;
                {
                    DEFAULT | default
                }

                {
                    COLON |  : 
                }

                {
                    THROW | throw
                }

                new NoViableAltException(
                {
                THIS | this
                }

                 )
                ;
            }
        }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(
        {
            THIS | this
        } , 

        re )
        ;
        _errHandler.recover(
        {
            THIS | this
        } , 

        re )
        ;
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        {
            RETURN | return
        }

        _localctx;
    }

public static class ClassOrInterfaceModifierContext
{
    EXTENDS |extends
}

ParserRuleContext {
public AnnotationContextannotation()
{
    {
        RETURN | return
    }

    getRuleContext(AnnotationContext.class ,  {

IntegerLiteral | 0 } ) ;  }public ClassOrInterfaceModifierContext(ParserRuleContext parent, {
    INT | int
}

invokingState ) { {SUPER |super } (
parent , invokingState ) ;  } {AT | @ }Override public {
INT |int }
getRuleIndex()
{
    {
        RETURN | return
    }

    RULE_classOrInterfaceModifier;
} {

AT | @ }Override public void enterRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterClassOrInterfaceModifier(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public void exitRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitClassOrInterfaceModifier(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public {
LT | < }T {
GT | > }Taccept(ParseTreeVisitor
{
    LT | <
} {

QUESTION |? } {
EXTENDS |extends }
T {
GT | > }visitor ) { {IF | if } (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) {RETURN | return } ( (JavaVisitor {
LT | < } {QUESTION |? } {
EXTENDS |extends }
T {
GT | > } )visitor ) .visitClassOrInterfaceModifier(
{
    THIS | this
} ) ;  {

ELSE | else } {RETURN | return }visitor.visitChildren ( {THIS |this
} ) ;  } }

public {
FINAL |final }
ClassOrInterfaceModifierContextclassOrInterfaceModifier()
{
    ClassOrInterfaceModifierContext _localctx = new ClassOrInterfaceModifierContext(_ctx, getState());
    enterRule(_localctx, {
        IntegerLiteral | 10
    } , 

    RULE_classOrInterfaceModifier )
    ;
    {
        INT | int
    }

    _la;
    try
    {
        setState(
        {
            IntegerLiteral | 277
        } )

        ;
        {
            SWITCH | switch
            }

            (_input.LA(
            {
                IntegerLiteral | 1
            } ) )

            {
                {
                    CASE |  case
                }

                AT
                {
                    COLON |  : 
                }

                enterOuterAlt(_localctx, {
                    IntegerLiteral | 1
                } )

                ;
                {
                    setState(
                    {
                        IntegerLiteral | 275
                    } )

                    ;
                    annotation();
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                ABSTRACT
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                FINAL
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                PRIVATE
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                PROTECTED
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                PUBLIC
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                STATIC
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                STRICTFP
                {
                    COLON |  : 
                }

                enterOuterAlt(_localctx, {
                    IntegerLiteral | 2
                } )

                ;
                {
                    setState(
                    {
                        IntegerLiteral | 276
                    } )

                    ;
                    _la = _input.LA(
                    {
                        IntegerLiteral | 1
                    } )

                    ;
                    {
                        IF | if
                    }

                    (
                    {
                        BANG | !
                    }

                    ((((_la)
                    {
                        BITAND | &
                    }

                    {
                        TILDE | ~
                    }

                    {
                        IntegerLiteral | 0x3f
                    } )

                    {
                        EQUAL |= =
                    }

                    {
                        IntegerLiteral | 0
                    }

                    {
                        AND | &&
                    }

                    ((
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    _la )
                    {
                        BITAND | &
                    }

                    ((
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    ABSTRACT )
                    {
                        BITOR ||
                    }

                    (
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    FINAL )
                    {
                        BITOR ||
                    }

                    (
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    PRIVATE )
                    {
                        BITOR ||
                    }

                    (
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    PROTECTED )
                    {
                        BITOR ||
                    }

                    (
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    PUBLIC )
                    {
                        BITOR ||
                    }

                    (
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    STATIC )
                    {
                        BITOR ||
                    }

                    (
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    STRICTFP ) ) )
                    {
                        NOTEQUAL | !=
                    }

                    {
                        IntegerLiteral | 0
                    } ) ) )

                    {
                        _errHandler.recoverInline(
                        {
                            THIS | this
                        } )

                        ;
                    }

                    consume();
                }

                {
                    BREAK | break
                }

                ;
                {
                    DEFAULT | default
                }

                {
                    COLON |  : 
                }

                {
                    THROW | throw
                }

                new NoViableAltException(
                {
                THIS | this
                }

                 )
                ;
            }
        }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(
        {
            THIS | this
        } , 

        re )
        ;
        _errHandler.recover(
        {
            THIS | this
        } , 

        re )
        ;
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        {
            RETURN | return
        }

        _localctx;
    }

public static class VariableModifierContext
{
    EXTENDS |extends
}

ParserRuleContext {
public AnnotationContextannotation()
{
    {
        RETURN | return
    }

    getRuleContext(AnnotationContext.class ,  {

IntegerLiteral | 0 } ) ;  }public VariableModifierContext(ParserRuleContext parent, {
    INT | int
}

invokingState ) { {SUPER |super } (
parent , invokingState ) ;  } {AT | @ }Override public {
INT |int }
getRuleIndex()
{
    {
        RETURN | return
    }

    RULE_variableModifier;
} {

AT | @ }Override public void enterRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterVariableModifier(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public void exitRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitVariableModifier(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public {
LT | < }T {
GT | > }Taccept(ParseTreeVisitor
{
    LT | <
} {

QUESTION |? } {
EXTENDS |extends }
T {
GT | > }visitor ) { {IF | if } (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) {RETURN | return } ( (JavaVisitor {
LT | < } {QUESTION |? } {
EXTENDS |extends }
T {
GT | > } )visitor ) .visitVariableModifier(
{
    THIS | this
} ) ;  {

ELSE | else } {RETURN | return }visitor.visitChildren ( {THIS |this
} ) ;  } }

public {
FINAL |final }
VariableModifierContextvariableModifier()
{
    VariableModifierContext _localctx = new VariableModifierContext(_ctx, getState());
    enterRule(_localctx, {
        IntegerLiteral | 12
    } , 

    RULE_variableModifier )
    ;
    try
    {
        setState(
        {
            IntegerLiteral | 281
        } )

        ;
        {
            SWITCH | switch
            }

            (_input.LA(
            {
                IntegerLiteral | 1
            } ) )

            {
                {
                    CASE |  case
                }

                FINAL
                {
                    COLON |  : 
                }

                enterOuterAlt(_localctx, {
                    IntegerLiteral | 1
                } )

                ;
                {
                    setState(
                    {
                        IntegerLiteral | 279
                    } )

                    ;
                    match(FINAL);
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                AT
                {
                    COLON |  : 
                }

                enterOuterAlt(_localctx, {
                    IntegerLiteral | 2
                } )

                ;
                {
                    setState(
                    {
                        IntegerLiteral | 280
                    } )

                    ;
                    annotation();
                }

                {
                    BREAK | break
                }

                ;
                {
                    DEFAULT | default
                }

                {
                    COLON |  : 
                }

                {
                    THROW | throw
                }

                new NoViableAltException(
                {
                THIS | this
                }

                 )
                ;
            }
        }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(
        {
            THIS | this
        } , 

        re )
        ;
        _errHandler.recover(
        {
            THIS | this
        } , 

        re )
        ;
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        {
            RETURN | return
        }

        _localctx;
    }

public static class ClassDeclarationContext
{
    EXTENDS |extends
}

ParserRuleContext {
public TerminalNodeIdentifier()
{
    {
        RETURN | return
    }

    getToken(JavaParser.Identifier, {
        IntegerLiteral | 0
    } )

    ;
}

public ClassBodyContextclassBody()
{
    {
        RETURN | return
    }

    getRuleContext(ClassBodyContext.class ,  {

IntegerLiteral | 0 } ) ;  }public TypeListContexttypeList()
{
    {
        RETURN | return
    }

    getRuleContext(TypeListContext.class ,  {

IntegerLiteral | 0 } ) ;  }public TypeParametersContexttypeParameters()
{
    {
        RETURN | return
    }

    getRuleContext(TypeParametersContext.class ,  {

IntegerLiteral | 0 } ) ;  }public TypeContexttype()
{
    {
        RETURN | return
    }

    getRuleContext(TypeContext.class ,  {

IntegerLiteral | 0 } ) ;  }public ClassDeclarationContext(ParserRuleContext parent, {
    INT | int
}

invokingState ) { {SUPER |super } (
parent , invokingState ) ;  } {AT | @ }Override public {
INT |int }
getRuleIndex()
{
    {
        RETURN | return
    }

    RULE_classDeclaration;
} {

AT | @ }Override public void enterRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterClassDeclaration(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public void exitRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitClassDeclaration(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public {
LT | < }T {
GT | > }Taccept(ParseTreeVisitor
{
    LT | <
} {

QUESTION |? } {
EXTENDS |extends }
T {
GT | > }visitor ) { {IF | if } (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) {RETURN | return } ( (JavaVisitor {
LT | < } {QUESTION |? } {
EXTENDS |extends }
T {
GT | > } )visitor ) .visitClassDeclaration(
{
    THIS | this
} ) ;  {

ELSE | else } {RETURN | return }visitor.visitChildren ( {THIS |this
} ) ;  } }

public {
FINAL |final }
ClassDeclarationContextclassDeclaration()
{
    ClassDeclarationContext _localctx = new ClassDeclarationContext(_ctx, getState());
    enterRule(_localctx, {
        IntegerLiteral | 14
    } , 

    RULE_classDeclaration )
    ;
    {
        INT | int
    }

    _la;
    try
    {
        enterOuterAlt(_localctx, {
            IntegerLiteral | 1
        } )

        ;
        {
            setState(
            {
                IntegerLiteral | 283
            } )

            ;
            match(CLASS);
            setState(
            {
                IntegerLiteral | 284
            } )

            ;
            match(Identifier);
            setState(
            {
                IntegerLiteral | 286
            } )

            ;
            _la = _input.LA(
            {
                IntegerLiteral | 1
            } )

            ;
            {
                IF | if
            }

            (_la
            {
                EQUAL |= =
            }

            LT )
            {
                {
                    setState(
                    {
                        IntegerLiteral | 285
                    } )

                    ;
                    typeParameters();
                }
            }

            setState(
            {
                IntegerLiteral | 290
            } )

            ;
            _la = _input.LA(
            {
                IntegerLiteral | 1
            } )

            ;
            {
                IF | if
            }

            (_la
            {
                EQUAL |= =
            }

            EXTENDS )
            {
                {
                    setState(
                    {
                        IntegerLiteral | 288
                    } )

                    ;
                    match(EXTENDS);
                    setState(
                    {
                        IntegerLiteral | 289
                    } )

                    ;
                    type();
                }
            }

            setState(
            {
                IntegerLiteral | 294
            } )

            ;
            _la = _input.LA(
            {
                IntegerLiteral | 1
            } )

            ;
            {
                IF | if
            }

            (_la
            {
                EQUAL |= =
            }

            IMPLEMENTS )
            {
                {
                    setState(
                    {
                        IntegerLiteral | 292
                    } )

                    ;
                    match(IMPLEMENTS);
                    setState(
                    {
                        IntegerLiteral | 293
                    } )

                    ;
                    typeList();
                }
            }

            setState(
            {
                IntegerLiteral | 296
            } )

            ;
            classBody();
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(
        {
            THIS | this
        } , 

        re )
        ;
        _errHandler.recover(
        {
            THIS | this
        } , 

        re )
        ;
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        {
            RETURN | return
        }

        _localctx;
    }

public static class TypeParametersContext
{
    EXTENDS |extends
}

ParserRuleContext {
public List {
LT | < }TypeParameterContext {
GT | > }typeParameter()
{
    {
        RETURN | return
    }

    getRuleContexts(TypeParameterContext.class ) ;  }

public TypeParameterContexttypeParameter(
{
    INT | int
}

i ) { {RETURN | return }getRuleContext(TypeParameterContext.class , 

i ) ;  }public TypeParametersContext(ParserRuleContext parent, {
    INT | int
}

invokingState ) { {SUPER |super } (
parent , invokingState ) ;  } {AT | @ }Override public {
INT |int }
getRuleIndex()
{
    {
        RETURN | return
    }

    RULE_typeParameters;
} {

AT | @ }Override public void enterRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterTypeParameters(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public void exitRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitTypeParameters(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public {
LT | < }T {
GT | > }Taccept(ParseTreeVisitor
{
    LT | <
} {

QUESTION |? } {
EXTENDS |extends }
T {
GT | > }visitor ) { {IF | if } (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) {RETURN | return } ( (JavaVisitor {
LT | < } {QUESTION |? } {
EXTENDS |extends }
T {
GT | > } )visitor ) .visitTypeParameters(
{
    THIS | this
} ) ;  {

ELSE | else } {RETURN | return }visitor.visitChildren ( {THIS |this
} ) ;  } }

public {
FINAL |final }
TypeParametersContexttypeParameters()
{
    TypeParametersContext _localctx = new TypeParametersContext(_ctx, getState());
    enterRule(_localctx, {
        IntegerLiteral | 16
    } , 

    RULE_typeParameters )
    ;
    {
        INT | int
    }

    _la;
    try
    {
        enterOuterAlt(_localctx, {
            IntegerLiteral | 1
        } )

        ;
        {
            setState(
            {
                IntegerLiteral | 298
            } )

            ;
            match(LT);
            setState(
            {
                IntegerLiteral | 299
            } )

            ;
            typeParameter();
            setState(
            {
                IntegerLiteral | 304
            } )

            ;
            _errHandler.sync(
            {
                THIS | this
            } )

            ;
            _la = _input.LA(
            {
                IntegerLiteral | 1
            } )

            ;
            {
                WHILE | while
            }

            (_la
            {
                EQUAL |= =
            }

            COMMA )
            {
                {
                    {
                        setState(
                        {
                            IntegerLiteral | 300
                        } )

                        ;
                        match(COMMA);
                        setState(
                        {
                            IntegerLiteral | 301
                        } )

                        ;
                        typeParameter();
                    }
                }

                setState(
                {
                    IntegerLiteral | 306
                } )

                ;
                _errHandler.sync(
                {
                    THIS | this
                } )

                ;
                _la = _input.LA(
                {
                    IntegerLiteral | 1
                } )

                ;
            }

            setState(
            {
                IntegerLiteral | 307
            } )

            ;
            match(GT);
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(
        {
            THIS | this
        } , 

        re )
        ;
        _errHandler.recover(
        {
            THIS | this
        } , 

        re )
        ;
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        {
            RETURN | return
        }

        _localctx;
    }

public static class TypeParameterContext
{
    EXTENDS |extends
}

ParserRuleContext {
public TerminalNodeIdentifier()
{
    {
        RETURN | return
    }

    getToken(JavaParser.Identifier, {
        IntegerLiteral | 0
    } )

    ;
}

public TypeBoundContexttypeBound()
{
    {
        RETURN | return
    }

    getRuleContext(TypeBoundContext.class ,  {

IntegerLiteral | 0 } ) ;  }public TypeParameterContext(ParserRuleContext parent, {
    INT | int
}

invokingState ) { {SUPER |super } (
parent , invokingState ) ;  } {AT | @ }Override public {
INT |int }
getRuleIndex()
{
    {
        RETURN | return
    }

    RULE_typeParameter;
} {

AT | @ }Override public void enterRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterTypeParameter(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public void exitRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitTypeParameter(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public {
LT | < }T {
GT | > }Taccept(ParseTreeVisitor
{
    LT | <
} {

QUESTION |? } {
EXTENDS |extends }
T {
GT | > }visitor ) { {IF | if } (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) {RETURN | return } ( (JavaVisitor {
LT | < } {QUESTION |? } {
EXTENDS |extends }
T {
GT | > } )visitor ) .visitTypeParameter(
{
    THIS | this
} ) ;  {

ELSE | else } {RETURN | return }visitor.visitChildren ( {THIS |this
} ) ;  } }

public {
FINAL |final }
TypeParameterContexttypeParameter()
{
    TypeParameterContext _localctx = new TypeParameterContext(_ctx, getState());
    enterRule(_localctx, {
        IntegerLiteral | 18
    } , 

    RULE_typeParameter )
    ;
    {
        INT | int
    }

    _la;
    try
    {
        enterOuterAlt(_localctx, {
            IntegerLiteral | 1
        } )

        ;
        {
            setState(
            {
                IntegerLiteral | 309
            } )

            ;
            match(Identifier);
            setState(
            {
                IntegerLiteral | 312
            } )

            ;
            _la = _input.LA(
            {
                IntegerLiteral | 1
            } )

            ;
            {
                IF | if
            }

            (_la
            {
                EQUAL |= =
            }

            EXTENDS )
            {
                {
                    setState(
                    {
                        IntegerLiteral | 310
                    } )

                    ;
                    match(EXTENDS);
                    setState(
                    {
                        IntegerLiteral | 311
                    } )

                    ;
                    typeBound();
                }
            }
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(
        {
            THIS | this
        } , 

        re )
        ;
        _errHandler.recover(
        {
            THIS | this
        } , 

        re )
        ;
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        {
            RETURN | return
        }

        _localctx;
    }

public static class TypeBoundContext
{
    EXTENDS |extends
}

ParserRuleContext {
public TypeContexttype(
{
    INT | int
}

i ) { {RETURN | return }getRuleContext(TypeContext.class , 

i ) ;  }public List {
LT | < }TypeContext {
GT | > }type()
{
    {
        RETURN | return
    }

    getRuleContexts(TypeContext.class ) ;  }

public TypeBoundContext(ParserRuleContext parent, {
    INT | int
}

invokingState ) { {SUPER |super } (
parent , invokingState ) ;  } {AT | @ }Override public {
INT |int }
getRuleIndex()
{
    {
        RETURN | return
    }

    RULE_typeBound;
} {

AT | @ }Override public void enterRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterTypeBound(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public void exitRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitTypeBound(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public {
LT | < }T {
GT | > }Taccept(ParseTreeVisitor
{
    LT | <
} {

QUESTION |? } {
EXTENDS |extends }
T {
GT | > }visitor ) { {IF | if } (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) {RETURN | return } ( (JavaVisitor {
LT | < } {QUESTION |? } {
EXTENDS |extends }
T {
GT | > } )visitor ) .visitTypeBound(
{
    THIS | this
} ) ;  {

ELSE | else } {RETURN | return }visitor.visitChildren ( {THIS |this
} ) ;  } }

public {
FINAL |final }
TypeBoundContexttypeBound()
{
    TypeBoundContext _localctx = new TypeBoundContext(_ctx, getState());
    enterRule(_localctx, {
        IntegerLiteral | 20
    } , 

    RULE_typeBound )
    ;
    {
        INT | int
    }

    _la;
    try
    {
        enterOuterAlt(_localctx, {
            IntegerLiteral | 1
        } )

        ;
        {
            setState(
            {
                IntegerLiteral | 314
            } )

            ;
            type();
            setState(
            {
                IntegerLiteral | 319
            } )

            ;
            _errHandler.sync(
            {
                THIS | this
            } )

            ;
            _la = _input.LA(
            {
                IntegerLiteral | 1
            } )

            ;
            {
                WHILE | while
            }

            (_la
            {
                EQUAL |= =
            }

            BITAND )
            {
                {
                    {
                        setState(
                        {
                            IntegerLiteral | 315
                        } )

                        ;
                        match(BITAND);
                        setState(
                        {
                            IntegerLiteral | 316
                        } )

                        ;
                        type();
                    }
                }

                setState(
                {
                    IntegerLiteral | 321
                } )

                ;
                _errHandler.sync(
                {
                    THIS | this
                } )

                ;
                _la = _input.LA(
                {
                    IntegerLiteral | 1
                } )

                ;
            }
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(
        {
            THIS | this
        } , 

        re )
        ;
        _errHandler.recover(
        {
            THIS | this
        } , 

        re )
        ;
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        {
            RETURN | return
        }

        _localctx;
    }

public static class EnumDeclarationContext
{
    EXTENDS |extends
}

ParserRuleContext {
public EnumBodyDeclarationsContextenumBodyDeclarations()
{
    {
        RETURN | return
    }

    getRuleContext(EnumBodyDeclarationsContext.class ,  {

IntegerLiteral | 0 } ) ;  }public TerminalNodeIdentifier()
{
    {
        RETURN | return
    }

    getToken(JavaParser.Identifier, {
        IntegerLiteral | 0
    } )

    ;
}

public TypeListContexttypeList()
{
    {
        RETURN | return
    }

    getRuleContext(TypeListContext.class ,  {

IntegerLiteral | 0 } ) ;  }public TerminalNodeENUM()
{
    {
        RETURN | return
    }

    getToken(JavaParser.ENUM, {
        IntegerLiteral | 0
    } )

    ;
}

public EnumConstantsContextenumConstants()
{
    {
        RETURN | return
    }

    getRuleContext(EnumConstantsContext.class ,  {

IntegerLiteral | 0 } ) ;  }public EnumDeclarationContext(ParserRuleContext parent, {
    INT | int
}

invokingState ) { {SUPER |super } (
parent , invokingState ) ;  } {AT | @ }Override public {
INT |int }
getRuleIndex()
{
    {
        RETURN | return
    }

    RULE_enumDeclaration;
} {

AT | @ }Override public void enterRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterEnumDeclaration(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public void exitRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitEnumDeclaration(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public {
LT | < }T {
GT | > }Taccept(ParseTreeVisitor
{
    LT | <
} {

QUESTION |? } {
EXTENDS |extends }
T {
GT | > }visitor ) { {IF | if } (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) {RETURN | return } ( (JavaVisitor {
LT | < } {QUESTION |? } {
EXTENDS |extends }
T {
GT | > } )visitor ) .visitEnumDeclaration(
{
    THIS | this
} ) ;  {

ELSE | else } {RETURN | return }visitor.visitChildren ( {THIS |this
} ) ;  } }

public {
FINAL |final }
EnumDeclarationContextenumDeclaration()
{
    EnumDeclarationContext _localctx = new EnumDeclarationContext(_ctx, getState());
    enterRule(_localctx, {
        IntegerLiteral | 22
    } , 

    RULE_enumDeclaration )
    ;
    {
        INT | int
    }

    _la;
    try
    {
        enterOuterAlt(_localctx, {
            IntegerLiteral | 1
        } )

        ;
        {
            setState(
            {
                IntegerLiteral | 322
            } )

            ;
            match(ENUM);
            setState(
            {
                IntegerLiteral | 323
            } )

            ;
            match(Identifier);
            setState(
            {
                IntegerLiteral | 326
            } )

            ;
            _la = _input.LA(
            {
                IntegerLiteral | 1
            } )

            ;
            {
                IF | if
            }

            (_la
            {
                EQUAL |= =
            }

            IMPLEMENTS )
            {
                {
                    setState(
                    {
                        IntegerLiteral | 324
                    } )

                    ;
                    match(IMPLEMENTS);
                    setState(
                    {
                        IntegerLiteral | 325
                    } )

                    ;
                    typeList();
                }
            }

            setState(
            {
                IntegerLiteral | 328
            } )

            ;
            match(LBRACE);
            setState(
            {
                IntegerLiteral | 330
            } )

            ;
            _la = _input.LA(
            {
                IntegerLiteral | 1
            } )

            ;
            {
                IF | if
            }

            (_la
            {
                EQUAL |= =
            }

            Identifier
            {
                OR || |
            }

            _la
            {
                EQUAL |= =
            }

            AT )
            {
                {
                    setState(
                    {
                        IntegerLiteral | 329
                    } )

                    ;
                    enumConstants();
                }
            }

            setState(
            {
                IntegerLiteral | 333
            } )

            ;
            _la = _input.LA(
            {
                IntegerLiteral | 1
            } )

            ;
            {
                IF | if
            }

            (_la
            {
                EQUAL |= =
            }

            COMMA )
            {
                {
                    setState(
                    {
                        IntegerLiteral | 332
                    } )

                    ;
                    match(COMMA);
                }
            }

            setState(
            {
                IntegerLiteral | 336
            } )

            ;
            _la = _input.LA(
            {
                IntegerLiteral | 1
            } )

            ;
            {
                IF | if
            }

            (_la
            {
                EQUAL |= =
            }

            SEMI )
            {
                {
                    setState(
                    {
                        IntegerLiteral | 335
                    } )

                    ;
                    enumBodyDeclarations();
                }
            }

            setState(
            {
                IntegerLiteral | 338
            } )

            ;
            match(RBRACE);
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(
        {
            THIS | this
        } , 

        re )
        ;
        _errHandler.recover(
        {
            THIS | this
        } , 

        re )
        ;
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        {
            RETURN | return
        }

        _localctx;
    }

public static class EnumConstantsContext
{
    EXTENDS |extends
}

ParserRuleContext {
public List {
LT | < }EnumConstantContext {
GT | > }enumConstant()
{
    {
        RETURN | return
    }

    getRuleContexts(EnumConstantContext.class ) ;  }

public EnumConstantContextenumConstant(
{
    INT | int
}

i ) { {RETURN | return }getRuleContext(EnumConstantContext.class , 

i ) ;  }public EnumConstantsContext(ParserRuleContext parent, {
    INT | int
}

invokingState ) { {SUPER |super } (
parent , invokingState ) ;  } {AT | @ }Override public {
INT |int }
getRuleIndex()
{
    {
        RETURN | return
    }

    RULE_enumConstants;
} {

AT | @ }Override public void enterRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterEnumConstants(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public void exitRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitEnumConstants(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public {
LT | < }T {
GT | > }Taccept(ParseTreeVisitor
{
    LT | <
} {

QUESTION |? } {
EXTENDS |extends }
T {
GT | > }visitor ) { {IF | if } (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) {RETURN | return } ( (JavaVisitor {
LT | < } {QUESTION |? } {
EXTENDS |extends }
T {
GT | > } )visitor ) .visitEnumConstants(
{
    THIS | this
} ) ;  {

ELSE | else } {RETURN | return }visitor.visitChildren ( {THIS |this
} ) ;  } }

public {
FINAL |final }
EnumConstantsContextenumConstants()
{
    EnumConstantsContext _localctx = new EnumConstantsContext(_ctx, getState());
    enterRule(_localctx, {
        IntegerLiteral | 24
    } , 

    RULE_enumConstants )
    ;
    try
    {
        {
            INT | int
        }

        _alt;
        enterOuterAlt(_localctx, {
            IntegerLiteral | 1
        } )

        ;
        {
            setState(
            {
                IntegerLiteral | 340
            } )

            ;
            enumConstant();
            setState(
            {
                IntegerLiteral | 345
            } )

            ;
            _errHandler.sync(
            {
                THIS | this
            } )

            ;
            _alt = getInterpreter().adaptivePredict(_input, {
                IntegerLiteral | 24
            } , 

            _ctx )
            ;
            {
                WHILE | while
            }

            (_alt
            {
                NOTEQUAL | !=
            }

            {
                IntegerLiteral | 2
            }

            {
                AND | &&
            }

            _alt
            {
                NOTEQUAL | !=
            }

            org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER )
            {
                {
                    IF | if
                }

                (_alt
                {
                    EQUAL |= =
                }

                {
                    IntegerLiteral | 1
                } )

                {
                    {
                        {
                            setState(
                            {
                                IntegerLiteral | 341
                            } )

                            ;
                            match(COMMA);
                            setState(
                            {
                                IntegerLiteral | 342
                            } )

                            ;
                            enumConstant();
                        }
                    }
                }

                setState(
                {
                    IntegerLiteral | 347
                } )

                ;
                _errHandler.sync(
                {
                    THIS | this
                } )

                ;
                _alt = getInterpreter().adaptivePredict(_input, {
                    IntegerLiteral | 24
                } , 

                _ctx )
                ;
            }
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(
        {
            THIS | this
        } , 

        re )
        ;
        _errHandler.recover(
        {
            THIS | this
        } , 

        re )
        ;
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        {
            RETURN | return
        }

        _localctx;
    }

public static class EnumConstantContext
{
    EXTENDS |extends
}

ParserRuleContext {
public TerminalNodeIdentifier()
{
    {
        RETURN | return
    }

    getToken(JavaParser.Identifier, {
        IntegerLiteral | 0
    } )

    ;
}

public List {
LT | < }AnnotationContext {
GT | > }annotation()
{
    {
        RETURN | return
    }

    getRuleContexts(AnnotationContext.class ) ;  }

public ClassBodyContextclassBody()
{
    {
        RETURN | return
    }

    getRuleContext(ClassBodyContext.class ,  {

IntegerLiteral | 0 } ) ;  }public AnnotationContextannotation(
{
    INT | int
}

i ) { {RETURN | return }getRuleContext(AnnotationContext.class , 

i ) ;  }public ArgumentsContextarguments()
{
    {
        RETURN | return
    }

    getRuleContext(ArgumentsContext.class ,  {

IntegerLiteral | 0 } ) ;  }public EnumConstantContext(ParserRuleContext parent, {
    INT | int
}

invokingState ) { {SUPER |super } (
parent , invokingState ) ;  } {AT | @ }Override public {
INT |int }
getRuleIndex()
{
    {
        RETURN | return
    }

    RULE_enumConstant;
} {

AT | @ }Override public void enterRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterEnumConstant(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public void exitRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitEnumConstant(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public {
LT | < }T {
GT | > }Taccept(ParseTreeVisitor
{
    LT | <
} {

QUESTION |? } {
EXTENDS |extends }
T {
GT | > }visitor ) { {IF | if } (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) {RETURN | return } ( (JavaVisitor {
LT | < } {QUESTION |? } {
EXTENDS |extends }
T {
GT | > } )visitor ) .visitEnumConstant(
{
    THIS | this
} ) ;  {

ELSE | else } {RETURN | return }visitor.visitChildren ( {THIS |this
} ) ;  } }

public {
FINAL |final }
EnumConstantContextenumConstant()
{
    EnumConstantContext _localctx = new EnumConstantContext(_ctx, getState());
    enterRule(_localctx, {
        IntegerLiteral | 26
    } , 

    RULE_enumConstant )
    ;
    {
        INT | int
    }

    _la;
    try
    {
        enterOuterAlt(_localctx, {
            IntegerLiteral | 1
        } )

        ;
        {
            setState(
            {
                IntegerLiteral | 351
            } )

            ;
            _errHandler.sync(
            {
                THIS | this
            } )

            ;
            _la = _input.LA(
            {
                IntegerLiteral | 1
            } )

            ;
            {
                WHILE | while
            }

            (_la
            {
                EQUAL |= =
            }

            AT )
            {
                {
                    {
                        setState(
                        {
                            IntegerLiteral | 348
                        } )

                        ;
                        annotation();
                    }
                }

                setState(
                {
                    IntegerLiteral | 353
                } )

                ;
                _errHandler.sync(
                {
                    THIS | this
                } )

                ;
                _la = _input.LA(
                {
                    IntegerLiteral | 1
                } )

                ;
            }

            setState(
            {
                IntegerLiteral | 354
            } )

            ;
            match(Identifier);
            setState(
            {
                IntegerLiteral | 356
            } )

            ;
            _la = _input.LA(
            {
                IntegerLiteral | 1
            } )

            ;
            {
                IF | if
            }

            (_la
            {
                EQUAL |= =
            }

            LPAREN )
            {
                {
                    setState(
                    {
                        IntegerLiteral | 355
                    } )

                    ;
                    arguments();
                }
            }

            setState(
            {
                IntegerLiteral | 359
            } )

            ;
            _la = _input.LA(
            {
                IntegerLiteral | 1
            } )

            ;
            {
                IF | if
            }

            (_la
            {
                EQUAL |= =
            }

            LBRACE )
            {
                {
                    setState(
                    {
                        IntegerLiteral | 358
                    } )

                    ;
                    classBody();
                }
            }
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(
        {
            THIS | this
        } , 

        re )
        ;
        _errHandler.recover(
        {
            THIS | this
        } , 

        re )
        ;
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        {
            RETURN | return
        }

        _localctx;
    }

public static class EnumBodyDeclarationsContext
{
    EXTENDS |extends
}

ParserRuleContext {
public List {
LT | < }ClassBodyDeclarationContext {
GT | > }classBodyDeclaration()
{
    {
        RETURN | return
    }

    getRuleContexts(ClassBodyDeclarationContext.class ) ;  }

public ClassBodyDeclarationContextclassBodyDeclaration(
{
    INT | int
}

i ) { {RETURN | return }getRuleContext(ClassBodyDeclarationContext.class , 

i ) ;  }public EnumBodyDeclarationsContext(ParserRuleContext parent, {
    INT | int
}

invokingState ) { {SUPER |super } (
parent , invokingState ) ;  } {AT | @ }Override public {
INT |int }
getRuleIndex()
{
    {
        RETURN | return
    }

    RULE_enumBodyDeclarations;
} {

AT | @ }Override public void enterRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterEnumBodyDeclarations(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public void exitRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitEnumBodyDeclarations(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public {
LT | < }T {
GT | > }Taccept(ParseTreeVisitor
{
    LT | <
} {

QUESTION |? } {
EXTENDS |extends }
T {
GT | > }visitor ) { {IF | if } (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) {RETURN | return } ( (JavaVisitor {
LT | < } {QUESTION |? } {
EXTENDS |extends }
T {
GT | > } )visitor ) .visitEnumBodyDeclarations(
{
    THIS | this
} ) ;  {

ELSE | else } {RETURN | return }visitor.visitChildren ( {THIS |this
} ) ;  } }

public {
FINAL |final }
EnumBodyDeclarationsContextenumBodyDeclarations()
{
    EnumBodyDeclarationsContext _localctx = new EnumBodyDeclarationsContext(_ctx, getState());
    enterRule(_localctx, {
        IntegerLiteral | 28
    } , 

    RULE_enumBodyDeclarations )
    ;
    {
        INT | int
    }

    _la;
    try
    {
        enterOuterAlt(_localctx, {
            IntegerLiteral | 1
        } )

        ;
        {
            setState(
            {
                IntegerLiteral | 361
            } )

            ;
            match(SEMI);
            setState(
            {
                IntegerLiteral | 365
            } )

            ;
            _errHandler.sync(
            {
                THIS | this
            } )

            ;
            _la = _input.LA(
            {
                IntegerLiteral | 1
            } )

            ;
            {
                WHILE | while
            }

            ((((_la)
            {
                BITAND | &
            }

            {
                TILDE | ~
            }

            {
                IntegerLiteral | 0x3f
            } )

            {
                EQUAL |= =
            }

            {
                IntegerLiteral | 0
            }

            {
                AND | &&
            }

            ((
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            _la )
            {
                BITAND | &
            }

            ((
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            ABSTRACT )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            BOOLEAN )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            BYTE )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            CHAR )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            CLASS )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            DOUBLE )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            ENUM )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            FINAL )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            FLOAT )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            INT )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            INTERFACE )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            LONG )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            NATIVE )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            PRIVATE )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            PROTECTED )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            PUBLIC )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            SHORT )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            STATIC )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            STRICTFP )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            SYNCHRONIZED )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            TRANSIENT )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            VOID )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            VOLATILE )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            LBRACE )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            SEMI ) ) )
            {
                NOTEQUAL | !=
            }

            {
                IntegerLiteral | 0
            } )

            {
                OR || |
            }

            ((((_la
            {
                SUB | -
            }

            {
                IntegerLiteral | 68
            } ) )

            {
                BITAND | &
            }

            {
                TILDE | ~
            }

            {
                IntegerLiteral | 0x3f
            } )

            {
                EQUAL |= =
            }

            {
                IntegerLiteral | 0
            }

            {
                AND | &&
            }

            ((
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            (_la
            {
                SUB | -
            }

            {
                IntegerLiteral | 68
            } ) )

            {
                BITAND | &
            }

            ((
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            (LT
            {
                SUB | -
            }

            {
                IntegerLiteral | 68
            } ) )

            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            (Identifier
            {
                SUB | -
            }

            {
                IntegerLiteral | 68
            } ) )

            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            (AT
            {
                SUB | -
            }

            {
                IntegerLiteral | 68
            } ) ) ) )

            {
                NOTEQUAL | !=
            }

            {
                IntegerLiteral | 0
            } ) )

            {
                {
                    {
                        setState(
                        {
                            IntegerLiteral | 362
                        } )

                        ;
                        classBodyDeclaration();
                    }
                }

                setState(
                {
                    IntegerLiteral | 367
                } )

                ;
                _errHandler.sync(
                {
                    THIS | this
                } )

                ;
                _la = _input.LA(
                {
                    IntegerLiteral | 1
                } )

                ;
            }
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(
        {
            THIS | this
        } , 

        re )
        ;
        _errHandler.recover(
        {
            THIS | this
        } , 

        re )
        ;
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        {
            RETURN | return
        }

        _localctx;
    }

public static class InterfaceDeclarationContext
{
    EXTENDS |extends
}

ParserRuleContext {
public TerminalNodeIdentifier()
{
    {
        RETURN | return
    }

    getToken(JavaParser.Identifier, {
        IntegerLiteral | 0
    } )

    ;
}

public InterfaceBodyContextinterfaceBody()
{
    {
        RETURN | return
    }

    getRuleContext(InterfaceBodyContext.class ,  {

IntegerLiteral | 0 } ) ;  }public TypeListContexttypeList()
{
    {
        RETURN | return
    }

    getRuleContext(TypeListContext.class ,  {

IntegerLiteral | 0 } ) ;  }public TypeParametersContexttypeParameters()
{
    {
        RETURN | return
    }

    getRuleContext(TypeParametersContext.class ,  {

IntegerLiteral | 0 } ) ;  }public InterfaceDeclarationContext(ParserRuleContext parent, {
    INT | int
}

invokingState ) { {SUPER |super } (
parent , invokingState ) ;  } {AT | @ }Override public {
INT |int }
getRuleIndex()
{
    {
        RETURN | return
    }

    RULE_interfaceDeclaration;
} {

AT | @ }Override public void enterRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterInterfaceDeclaration(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public void exitRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitInterfaceDeclaration(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public {
LT | < }T {
GT | > }Taccept(ParseTreeVisitor
{
    LT | <
} {

QUESTION |? } {
EXTENDS |extends }
T {
GT | > }visitor ) { {IF | if } (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) {RETURN | return } ( (JavaVisitor {
LT | < } {QUESTION |? } {
EXTENDS |extends }
T {
GT | > } )visitor ) .visitInterfaceDeclaration(
{
    THIS | this
} ) ;  {

ELSE | else } {RETURN | return }visitor.visitChildren ( {THIS |this
} ) ;  } }

public {
FINAL |final }
InterfaceDeclarationContextinterfaceDeclaration()
{
    InterfaceDeclarationContext _localctx = new InterfaceDeclarationContext(_ctx, getState());
    enterRule(_localctx, {
        IntegerLiteral | 30
    } , 

    RULE_interfaceDeclaration )
    ;
    {
        INT | int
    }

    _la;
    try
    {
        enterOuterAlt(_localctx, {
            IntegerLiteral | 1
        } )

        ;
        {
            setState(
            {
                IntegerLiteral | 368
            } )

            ;
            match(INTERFACE);
            setState(
            {
                IntegerLiteral | 369
            } )

            ;
            match(Identifier);
            setState(
            {
                IntegerLiteral | 371
            } )

            ;
            _la = _input.LA(
            {
                IntegerLiteral | 1
            } )

            ;
            {
                IF | if
            }

            (_la
            {
                EQUAL |= =
            }

            LT )
            {
                {
                    setState(
                    {
                        IntegerLiteral | 370
                    } )

                    ;
                    typeParameters();
                }
            }

            setState(
            {
                IntegerLiteral | 375
            } )

            ;
            _la = _input.LA(
            {
                IntegerLiteral | 1
            } )

            ;
            {
                IF | if
            }

            (_la
            {
                EQUAL |= =
            }

            EXTENDS )
            {
                {
                    setState(
                    {
                        IntegerLiteral | 373
                    } )

                    ;
                    match(EXTENDS);
                    setState(
                    {
                        IntegerLiteral | 374
                    } )

                    ;
                    typeList();
                }
            }

            setState(
            {
                IntegerLiteral | 377
            } )

            ;
            interfaceBody();
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(
        {
            THIS | this
        } , 

        re )
        ;
        _errHandler.recover(
        {
            THIS | this
        } , 

        re )
        ;
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        {
            RETURN | return
        }

        _localctx;
    }

public static class TypeListContext
{
    EXTENDS |extends
}

ParserRuleContext {
public TypeContexttype(
{
    INT | int
}

i ) { {RETURN | return }getRuleContext(TypeContext.class , 

i ) ;  }public List {
LT | < }TypeContext {
GT | > }type()
{
    {
        RETURN | return
    }

    getRuleContexts(TypeContext.class ) ;  }

public TypeListContext(ParserRuleContext parent, {
    INT | int
}

invokingState ) { {SUPER |super } (
parent , invokingState ) ;  } {AT | @ }Override public {
INT |int }
getRuleIndex()
{
    {
        RETURN | return
    }

    RULE_typeList;
} {

AT | @ }Override public void enterRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterTypeList(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public void exitRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitTypeList(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public {
LT | < }T {
GT | > }Taccept(ParseTreeVisitor
{
    LT | <
} {

QUESTION |? } {
EXTENDS |extends }
T {
GT | > }visitor ) { {IF | if } (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) {RETURN | return } ( (JavaVisitor {
LT | < } {QUESTION |? } {
EXTENDS |extends }
T {
GT | > } )visitor ) .visitTypeList(
{
    THIS | this
} ) ;  {

ELSE | else } {RETURN | return }visitor.visitChildren ( {THIS |this
} ) ;  } }

public {
FINAL |final }
TypeListContexttypeList()
{
    TypeListContext _localctx = new TypeListContext(_ctx, getState());
    enterRule(_localctx, {
        IntegerLiteral | 32
    } , 

    RULE_typeList )
    ;
    {
        INT | int
    }

    _la;
    try
    {
        enterOuterAlt(_localctx, {
            IntegerLiteral | 1
        } )

        ;
        {
            setState(
            {
                IntegerLiteral | 379
            } )

            ;
            type();
            setState(
            {
                IntegerLiteral | 384
            } )

            ;
            _errHandler.sync(
            {
                THIS | this
            } )

            ;
            _la = _input.LA(
            {
                IntegerLiteral | 1
            } )

            ;
            {
                WHILE | while
            }

            (_la
            {
                EQUAL |= =
            }

            COMMA )
            {
                {
                    {
                        setState(
                        {
                            IntegerLiteral | 380
                        } )

                        ;
                        match(COMMA);
                        setState(
                        {
                            IntegerLiteral | 381
                        } )

                        ;
                        type();
                    }
                }

                setState(
                {
                    IntegerLiteral | 386
                } )

                ;
                _errHandler.sync(
                {
                    THIS | this
                } )

                ;
                _la = _input.LA(
                {
                    IntegerLiteral | 1
                } )

                ;
            }
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(
        {
            THIS | this
        } , 

        re )
        ;
        _errHandler.recover(
        {
            THIS | this
        } , 

        re )
        ;
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        {
            RETURN | return
        }

        _localctx;
    }

public static class ClassBodyContext
{
    EXTENDS |extends
}

ParserRuleContext {
public List {
LT | < }ClassBodyDeclarationContext {
GT | > }classBodyDeclaration()
{
    {
        RETURN | return
    }

    getRuleContexts(ClassBodyDeclarationContext.class ) ;  }

public ClassBodyDeclarationContextclassBodyDeclaration(
{
    INT | int
}

i ) { {RETURN | return }getRuleContext(ClassBodyDeclarationContext.class , 

i ) ;  }public ClassBodyContext(ParserRuleContext parent, {
    INT | int
}

invokingState ) { {SUPER |super } (
parent , invokingState ) ;  } {AT | @ }Override public {
INT |int }
getRuleIndex()
{
    {
        RETURN | return
    }

    RULE_classBody;
} {

AT | @ }Override public void enterRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterClassBody(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public void exitRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitClassBody(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public {
LT | < }T {
GT | > }Taccept(ParseTreeVisitor
{
    LT | <
} {

QUESTION |? } {
EXTENDS |extends }
T {
GT | > }visitor ) { {IF | if } (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) {RETURN | return } ( (JavaVisitor {
LT | < } {QUESTION |? } {
EXTENDS |extends }
T {
GT | > } )visitor ) .visitClassBody(
{
    THIS | this
} ) ;  {

ELSE | else } {RETURN | return }visitor.visitChildren ( {THIS |this
} ) ;  } }

public {
FINAL |final }
ClassBodyContextclassBody()
{
    ClassBodyContext _localctx = new ClassBodyContext(_ctx, getState());
    enterRule(_localctx, {
        IntegerLiteral | 34
    } , 

    RULE_classBody )
    ;
    {
        INT | int
    }

    _la;
    try
    {
        enterOuterAlt(_localctx, {
            IntegerLiteral | 1
        } )

        ;
        {
            setState(
            {
                IntegerLiteral | 387
            } )

            ;
            match(LBRACE);
            setState(
            {
                IntegerLiteral | 391
            } )

            ;
            _errHandler.sync(
            {
                THIS | this
            } )

            ;
            _la = _input.LA(
            {
                IntegerLiteral | 1
            } )

            ;
            {
                WHILE | while
            }

            ((((_la)
            {
                BITAND | &
            }

            {
                TILDE | ~
            }

            {
                IntegerLiteral | 0x3f
            } )

            {
                EQUAL |= =
            }

            {
                IntegerLiteral | 0
            }

            {
                AND | &&
            }

            ((
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            _la )
            {
                BITAND | &
            }

            ((
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            ABSTRACT )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            BOOLEAN )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            BYTE )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            CHAR )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            CLASS )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            DOUBLE )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            ENUM )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            FINAL )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            FLOAT )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            INT )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            INTERFACE )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            LONG )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            NATIVE )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            PRIVATE )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            PROTECTED )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            PUBLIC )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            SHORT )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            STATIC )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            STRICTFP )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            SYNCHRONIZED )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            TRANSIENT )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            VOID )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            VOLATILE )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            LBRACE )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            SEMI ) ) )
            {
                NOTEQUAL | !=
            }

            {
                IntegerLiteral | 0
            } )

            {
                OR || |
            }

            ((((_la
            {
                SUB | -
            }

            {
                IntegerLiteral | 68
            } ) )

            {
                BITAND | &
            }

            {
                TILDE | ~
            }

            {
                IntegerLiteral | 0x3f
            } )

            {
                EQUAL |= =
            }

            {
                IntegerLiteral | 0
            }

            {
                AND | &&
            }

            ((
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            (_la
            {
                SUB | -
            }

            {
                IntegerLiteral | 68
            } ) )

            {
                BITAND | &
            }

            ((
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            (LT
            {
                SUB | -
            }

            {
                IntegerLiteral | 68
            } ) )

            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            (Identifier
            {
                SUB | -
            }

            {
                IntegerLiteral | 68
            } ) )

            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            (AT
            {
                SUB | -
            }

            {
                IntegerLiteral | 68
            } ) ) ) )

            {
                NOTEQUAL | !=
            }

            {
                IntegerLiteral | 0
            } ) )

            {
                {
                    {
                        setState(
                        {
                            IntegerLiteral | 388
                        } )

                        ;
                        classBodyDeclaration();
                    }
                }

                setState(
                {
                    IntegerLiteral | 393
                } )

                ;
                _errHandler.sync(
                {
                    THIS | this
                } )

                ;
                _la = _input.LA(
                {
                    IntegerLiteral | 1
                } )

                ;
            }

            setState(
            {
                IntegerLiteral | 394
            } )

            ;
            match(RBRACE);
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(
        {
            THIS | this
        } , 

        re )
        ;
        _errHandler.recover(
        {
            THIS | this
        } , 

        re )
        ;
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        {
            RETURN | return
        }

        _localctx;
    }

public static class InterfaceBodyContext
{
    EXTENDS |extends
}

ParserRuleContext {
public List {
LT | < }InterfaceBodyDeclarationContext {
GT | > }interfaceBodyDeclaration()
{
    {
        RETURN | return
    }

    getRuleContexts(InterfaceBodyDeclarationContext.class ) ;  }

public InterfaceBodyDeclarationContextinterfaceBodyDeclaration(
{
    INT | int
}

i ) { {RETURN | return }getRuleContext(InterfaceBodyDeclarationContext.class , 

i ) ;  }public InterfaceBodyContext(ParserRuleContext parent, {
    INT | int
}

invokingState ) { {SUPER |super } (
parent , invokingState ) ;  } {AT | @ }Override public {
INT |int }
getRuleIndex()
{
    {
        RETURN | return
    }

    RULE_interfaceBody;
} {

AT | @ }Override public void enterRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterInterfaceBody(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public void exitRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitInterfaceBody(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public {
LT | < }T {
GT | > }Taccept(ParseTreeVisitor
{
    LT | <
} {

QUESTION |? } {
EXTENDS |extends }
T {
GT | > }visitor ) { {IF | if } (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) {RETURN | return } ( (JavaVisitor {
LT | < } {QUESTION |? } {
EXTENDS |extends }
T {
GT | > } )visitor ) .visitInterfaceBody(
{
    THIS | this
} ) ;  {

ELSE | else } {RETURN | return }visitor.visitChildren ( {THIS |this
} ) ;  } }

public {
FINAL |final }
InterfaceBodyContextinterfaceBody()
{
    InterfaceBodyContext _localctx = new InterfaceBodyContext(_ctx, getState());
    enterRule(_localctx, {
        IntegerLiteral | 36
    } , 

    RULE_interfaceBody )
    ;
    {
        INT | int
    }

    _la;
    try
    {
        enterOuterAlt(_localctx, {
            IntegerLiteral | 1
        } )

        ;
        {
            setState(
            {
                IntegerLiteral | 396
            } )

            ;
            match(LBRACE);
            setState(
            {
                IntegerLiteral | 400
            } )

            ;
            _errHandler.sync(
            {
                THIS | this
            } )

            ;
            _la = _input.LA(
            {
                IntegerLiteral | 1
            } )

            ;
            {
                WHILE | while
            }

            ((((_la)
            {
                BITAND | &
            }

            {
                TILDE | ~
            }

            {
                IntegerLiteral | 0x3f
            } )

            {
                EQUAL |= =
            }

            {
                IntegerLiteral | 0
            }

            {
                AND | &&
            }

            ((
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            _la )
            {
                BITAND | &
            }

            ((
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            ABSTRACT )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            BOOLEAN )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            BYTE )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            CHAR )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            CLASS )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            DOUBLE )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            ENUM )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            FINAL )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            FLOAT )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            INT )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            INTERFACE )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            LONG )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            NATIVE )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            PRIVATE )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            PROTECTED )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            PUBLIC )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            SHORT )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            STATIC )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            STRICTFP )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            SYNCHRONIZED )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            TRANSIENT )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            VOID )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            VOLATILE )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            SEMI ) ) )
            {
                NOTEQUAL | !=
            }

            {
                IntegerLiteral | 0
            } )

            {
                OR || |
            }

            ((((_la
            {
                SUB | -
            }

            {
                IntegerLiteral | 68
            } ) )

            {
                BITAND | &
            }

            {
                TILDE | ~
            }

            {
                IntegerLiteral | 0x3f
            } )

            {
                EQUAL |= =
            }

            {
                IntegerLiteral | 0
            }

            {
                AND | &&
            }

            ((
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            (_la
            {
                SUB | -
            }

            {
                IntegerLiteral | 68
            } ) )

            {
                BITAND | &
            }

            ((
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            (LT
            {
                SUB | -
            }

            {
                IntegerLiteral | 68
            } ) )

            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            (Identifier
            {
                SUB | -
            }

            {
                IntegerLiteral | 68
            } ) )

            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            (AT
            {
                SUB | -
            }

            {
                IntegerLiteral | 68
            } ) ) ) )

            {
                NOTEQUAL | !=
            }

            {
                IntegerLiteral | 0
            } ) )

            {
                {
                    {
                        setState(
                        {
                            IntegerLiteral | 397
                        } )

                        ;
                        interfaceBodyDeclaration();
                    }
                }

                setState(
                {
                    IntegerLiteral | 402
                } )

                ;
                _errHandler.sync(
                {
                    THIS | this
                } )

                ;
                _la = _input.LA(
                {
                    IntegerLiteral | 1
                } )

                ;
            }

            setState(
            {
                IntegerLiteral | 403
            } )

            ;
            match(RBRACE);
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(
        {
            THIS | this
        } , 

        re )
        ;
        _errHandler.recover(
        {
            THIS | this
        } , 

        re )
        ;
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        {
            RETURN | return
        }

        _localctx;
    }

public static class ClassBodyDeclarationContext
{
    EXTENDS |extends
}

ParserRuleContext {
public List {
LT | < }ModifierContext {
GT | > }modifier()
{
    {
        RETURN | return
    }

    getRuleContexts(ModifierContext.class ) ;  }

public MemberDeclarationContextmemberDeclaration()
{
    {
        RETURN | return
    }

    getRuleContext(MemberDeclarationContext.class ,  {

IntegerLiteral | 0 } ) ;  }public ModifierContextmodifier(
{
    INT | int
}

i ) { {RETURN | return }getRuleContext(ModifierContext.class , 

i ) ;  }public BlockContextblock()
{
    {
        RETURN | return
    }

    getRuleContext(BlockContext.class ,  {

IntegerLiteral | 0 } ) ;  }public ClassBodyDeclarationContext(ParserRuleContext parent, {
    INT | int
}

invokingState ) { {SUPER |super } (
parent , invokingState ) ;  } {AT | @ }Override public {
INT |int }
getRuleIndex()
{
    {
        RETURN | return
    }

    RULE_classBodyDeclaration;
} {

AT | @ }Override public void enterRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterClassBodyDeclaration(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public void exitRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitClassBodyDeclaration(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public {
LT | < }T {
GT | > }Taccept(ParseTreeVisitor
{
    LT | <
} {

QUESTION |? } {
EXTENDS |extends }
T {
GT | > }visitor ) { {IF | if } (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) {RETURN | return } ( (JavaVisitor {
LT | < } {QUESTION |? } {
EXTENDS |extends }
T {
GT | > } )visitor ) .visitClassBodyDeclaration(
{
    THIS | this
} ) ;  {

ELSE | else } {RETURN | return }visitor.visitChildren ( {THIS |this
} ) ;  } }

public {
FINAL |final }
ClassBodyDeclarationContextclassBodyDeclaration()
{
    ClassBodyDeclarationContext _localctx = new ClassBodyDeclarationContext(_ctx, getState());
    enterRule(_localctx, {
        IntegerLiteral | 38
    } , 

    RULE_classBodyDeclaration )
    ;
    {
        INT | int
    }

    _la;
    try
    {
        {
            INT | int
        }

        _alt;
        setState(
        {
            IntegerLiteral | 417
        } )

        ;
        {
            SWITCH | switch
            }

            (getInterpreter().adaptivePredict(_input, {
                IntegerLiteral | 36
            } , 

            _ctx ) )
            {
                {
                    CASE |  case
                }

                {
                    IntegerLiteral | 1
                }

                {
                    COLON |  : 
                }

                enterOuterAlt(_localctx, {
                    IntegerLiteral | 1
                } )

                ;
                {
                    setState(
                    {
                        IntegerLiteral | 405
                    } )

                    ;
                    match(SEMI);
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                {
                    IntegerLiteral | 2
                }

                {
                    COLON |  : 
                }

                enterOuterAlt(_localctx, {
                    IntegerLiteral | 2
                } )

                ;
                {
                    setState(
                    {
                        IntegerLiteral | 407
                    } )

                    ;
                    _la = _input.LA(
                    {
                        IntegerLiteral | 1
                    } )

                    ;
                    {
                        IF | if
                    }

                    (_la
                    {
                        EQUAL |= =
                    }

                    STATIC )
                    {
                        {
                            setState(
                            {
                                IntegerLiteral | 406
                            } )

                            ;
                            match(STATIC);
                        }
                    }

                    setState(
                    {
                        IntegerLiteral | 409
                    } )

                    ;
                    block();
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                {
                    IntegerLiteral | 3
                }

                {
                    COLON |  : 
                }

                enterOuterAlt(_localctx, {
                    IntegerLiteral | 3
                } )

                ;
                {
                    setState(
                    {
                        IntegerLiteral | 413
                    } )

                    ;
                    _errHandler.sync(
                    {
                        THIS | this
                    } )

                    ;
                    _alt = getInterpreter().adaptivePredict(_input, {
                        IntegerLiteral | 35
                    } , 

                    _ctx )
                    ;
                    {
                        WHILE | while
                    }

                    (_alt
                    {
                        NOTEQUAL | !=
                    }

                    {
                        IntegerLiteral | 2
                    }

                    {
                        AND | &&
                    }

                    _alt
                    {
                        NOTEQUAL | !=
                    }

                    org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER )
                    {
                        {
                            IF | if
                        }

                        (_alt
                        {
                            EQUAL |= =
                        }

                        {
                            IntegerLiteral | 1
                        } )

                        {
                            {
                                {
                                    setState(
                                    {
                                        IntegerLiteral | 410
                                    } )

                                    ;
                                    modifier();
                                }
                            }
                        }

                        setState(
                        {
                            IntegerLiteral | 415
                        } )

                        ;
                        _errHandler.sync(
                        {
                            THIS | this
                        } )

                        ;
                        _alt = getInterpreter().adaptivePredict(_input, {
                            IntegerLiteral | 35
                        } , 

                        _ctx )
                        ;
                    }

                    setState(
                    {
                        IntegerLiteral | 416
                    } )

                    ;
                    memberDeclaration();
                }

                {
                    BREAK | break
                }

                ;
            }
        }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(
        {
            THIS | this
        } , 

        re )
        ;
        _errHandler.recover(
        {
            THIS | this
        } , 

        re )
        ;
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        {
            RETURN | return
        }

        _localctx;
    }

public static class MemberDeclarationContext
{
    EXTENDS |extends
}

ParserRuleContext {
public GenericMethodDeclarationContextgenericMethodDeclaration()
{
    {
        RETURN | return
    }

    getRuleContext(GenericMethodDeclarationContext.class ,  {

IntegerLiteral | 0 } ) ;  }public MethodDeclarationContextmethodDeclaration()
{
    {
        RETURN | return
    }

    getRuleContext(MethodDeclarationContext.class ,  {

IntegerLiteral | 0 } ) ;  }public EnumDeclarationContextenumDeclaration()
{
    {
        RETURN | return
    }

    getRuleContext(EnumDeclarationContext.class ,  {

IntegerLiteral | 0 } ) ;  }public ClassDeclarationContextclassDeclaration()
{
    {
        RETURN | return
    }

    getRuleContext(ClassDeclarationContext.class ,  {

IntegerLiteral | 0 } ) ;  }public AnnotationTypeDeclarationContextannotationTypeDeclaration()
{
    {
        RETURN | return
    }

    getRuleContext(AnnotationTypeDeclarationContext.class ,  {

IntegerLiteral | 0 } ) ;  }public GenericConstructorDeclarationContextgenericConstructorDeclaration()
{
    {
        RETURN | return
    }

    getRuleContext(GenericConstructorDeclarationContext.class ,  {

IntegerLiteral | 0 } ) ;  }public InterfaceDeclarationContextinterfaceDeclaration()
{
    {
        RETURN | return
    }

    getRuleContext(InterfaceDeclarationContext.class ,  {

IntegerLiteral | 0 } ) ;  }public ConstructorDeclarationContextconstructorDeclaration()
{
    {
        RETURN | return
    }

    getRuleContext(ConstructorDeclarationContext.class ,  {

IntegerLiteral | 0 } ) ;  }public FieldDeclarationContextfieldDeclaration()
{
    {
        RETURN | return
    }

    getRuleContext(FieldDeclarationContext.class ,  {

IntegerLiteral | 0 } ) ;  }public MemberDeclarationContext(ParserRuleContext parent, {
    INT | int
}

invokingState ) { {SUPER |super } (
parent , invokingState ) ;  } {AT | @ }Override public {
INT |int }
getRuleIndex()
{
    {
        RETURN | return
    }

    RULE_memberDeclaration;
} {

AT | @ }Override public void enterRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterMemberDeclaration(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public void exitRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitMemberDeclaration(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public {
LT | < }T {
GT | > }Taccept(ParseTreeVisitor
{
    LT | <
} {

QUESTION |? } {
EXTENDS |extends }
T {
GT | > }visitor ) { {IF | if } (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) {RETURN | return } ( (JavaVisitor {
LT | < } {QUESTION |? } {
EXTENDS |extends }
T {
GT | > } )visitor ) .visitMemberDeclaration(
{
    THIS | this
} ) ;  {

ELSE | else } {RETURN | return }visitor.visitChildren ( {THIS |this
} ) ;  } }

public {
FINAL |final }
MemberDeclarationContextmemberDeclaration()
{
    MemberDeclarationContext _localctx = new MemberDeclarationContext(_ctx, getState());
    enterRule(_localctx, {
        IntegerLiteral | 40
    } , 

    RULE_memberDeclaration )
    ;
    try
    {
        setState(
        {
            IntegerLiteral | 428
        } )

        ;
        {
            SWITCH | switch
            }

            (getInterpreter().adaptivePredict(_input, {
                IntegerLiteral | 37
            } , 

            _ctx ) )
            {
                {
                    CASE |  case
                }

                {
                    IntegerLiteral | 1
                }

                {
                    COLON |  : 
                }

                enterOuterAlt(_localctx, {
                    IntegerLiteral | 1
                } )

                ;
                {
                    setState(
                    {
                        IntegerLiteral | 419
                    } )

                    ;
                    methodDeclaration();
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                {
                    IntegerLiteral | 2
                }

                {
                    COLON |  : 
                }

                enterOuterAlt(_localctx, {
                    IntegerLiteral | 2
                } )

                ;
                {
                    setState(
                    {
                        IntegerLiteral | 420
                    } )

                    ;
                    genericMethodDeclaration();
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                {
                    IntegerLiteral | 3
                }

                {
                    COLON |  : 
                }

                enterOuterAlt(_localctx, {
                    IntegerLiteral | 3
                } )

                ;
                {
                    setState(
                    {
                        IntegerLiteral | 421
                    } )

                    ;
                    fieldDeclaration();
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                {
                    IntegerLiteral | 4
                }

                {
                    COLON |  : 
                }

                enterOuterAlt(_localctx, {
                    IntegerLiteral | 4
                } )

                ;
                {
                    setState(
                    {
                        IntegerLiteral | 422
                    } )

                    ;
                    constructorDeclaration();
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                {
                    IntegerLiteral | 5
                }

                {
                    COLON |  : 
                }

                enterOuterAlt(_localctx, {
                    IntegerLiteral | 5
                } )

                ;
                {
                    setState(
                    {
                        IntegerLiteral | 423
                    } )

                    ;
                    genericConstructorDeclaration();
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                {
                    IntegerLiteral | 6
                }

                {
                    COLON |  : 
                }

                enterOuterAlt(_localctx, {
                    IntegerLiteral | 6
                } )

                ;
                {
                    setState(
                    {
                        IntegerLiteral | 424
                    } )

                    ;
                    interfaceDeclaration();
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                {
                    IntegerLiteral | 7
                }

                {
                    COLON |  : 
                }

                enterOuterAlt(_localctx, {
                    IntegerLiteral | 7
                } )

                ;
                {
                    setState(
                    {
                        IntegerLiteral | 425
                    } )

                    ;
                    annotationTypeDeclaration();
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                {
                    IntegerLiteral | 8
                }

                {
                    COLON |  : 
                }

                enterOuterAlt(_localctx, {
                    IntegerLiteral | 8
                } )

                ;
                {
                    setState(
                    {
                        IntegerLiteral | 426
                    } )

                    ;
                    classDeclaration();
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                {
                    IntegerLiteral | 9
                }

                {
                    COLON |  : 
                }

                enterOuterAlt(_localctx, {
                    IntegerLiteral | 9
                } )

                ;
                {
                    setState(
                    {
                        IntegerLiteral | 427
                    } )

                    ;
                    enumDeclaration();
                }

                {
                    BREAK | break
                }

                ;
            }
        }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(
        {
            THIS | this
        } , 

        re )
        ;
        _errHandler.recover(
        {
            THIS | this
        } , 

        re )
        ;
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        {
            RETURN | return
        }

        _localctx;
    }

public static class MethodDeclarationContext
{
    EXTENDS |extends
}

ParserRuleContext {
public TerminalNodeIdentifier()
{
    {
        RETURN | return
    }

    getToken(JavaParser.Identifier, {
        IntegerLiteral | 0
    } )

    ;
}

public MethodBodyContextmethodBody()
{
    {
        RETURN | return
    }

    getRuleContext(MethodBodyContext.class ,  {

IntegerLiteral | 0 } ) ;  }public QualifiedNameListContextqualifiedNameList()
{
    {
        RETURN | return
    }

    getRuleContext(QualifiedNameListContext.class ,  {

IntegerLiteral | 0 } ) ;  }public FormalParametersContextformalParameters()
{
    {
        RETURN | return
    }

    getRuleContext(FormalParametersContext.class ,  {

IntegerLiteral | 0 } ) ;  }public TypeContexttype()
{
    {
        RETURN | return
    }

    getRuleContext(TypeContext.class ,  {

IntegerLiteral | 0 } ) ;  }public MethodDeclarationContext(ParserRuleContext parent, {
    INT | int
}

invokingState ) { {SUPER |super } (
parent , invokingState ) ;  } {AT | @ }Override public {
INT |int }
getRuleIndex()
{
    {
        RETURN | return
    }

    RULE_methodDeclaration;
} {

AT | @ }Override public void enterRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterMethodDeclaration(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public void exitRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitMethodDeclaration(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public {
LT | < }T {
GT | > }Taccept(ParseTreeVisitor
{
    LT | <
} {

QUESTION |? } {
EXTENDS |extends }
T {
GT | > }visitor ) { {IF | if } (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) {RETURN | return } ( (JavaVisitor {
LT | < } {QUESTION |? } {
EXTENDS |extends }
T {
GT | > } )visitor ) .visitMethodDeclaration(
{
    THIS | this
} ) ;  {

ELSE | else } {RETURN | return }visitor.visitChildren ( {THIS |this
} ) ;  } }

public {
FINAL |final }
MethodDeclarationContextmethodDeclaration()
{
    MethodDeclarationContext _localctx = new MethodDeclarationContext(_ctx, getState());
    enterRule(_localctx, {
        IntegerLiteral | 42
    } , 

    RULE_methodDeclaration )
    ;
    {
        INT | int
    }

    _la;
    try
    {
        enterOuterAlt(_localctx, {
            IntegerLiteral | 1
        } )

        ;
        {
            setState(
            {
                IntegerLiteral | 432
            } )

            ;
            {
                SWITCH | switch
                }

                (_input.LA(
                {
                    IntegerLiteral | 1
                } ) )

                {
                    {
                        CASE |  case
                    }

                    BOOLEAN
                    {
                        COLON |  : 
                    }

                    {
                        CASE |  case
                    }

                    BYTE
                    {
                        COLON |  : 
                    }

                    {
                        CASE |  case
                    }

                    CHAR
                    {
                        COLON |  : 
                    }

                    {
                        CASE |  case
                    }

                    DOUBLE
                    {
                        COLON |  : 
                    }

                    {
                        CASE |  case
                    }

                    FLOAT
                    {
                        COLON |  : 
                    }

                    {
                        CASE |  case
                    }

                    INT
                    {
                        COLON |  : 
                    }

                    {
                        CASE |  case
                    }

                    LONG
                    {
                        COLON |  : 
                    }

                    {
                        CASE |  case
                    }

                    SHORT
                    {
                        COLON |  : 
                    }

                    {
                        CASE |  case
                    }

                    Identifier
                    {
                        COLON |  : 
                    }

                    {
                        setState(
                        {
                            IntegerLiteral | 430
                        } )

                        ;
                        type();
                    }

                    {
                        BREAK | break
                    }

                    ;
                    {
                        CASE |  case
                    }

                    VOID
                    {
                        COLON |  : 
                    }

                    {
                        setState(
                        {
                            IntegerLiteral | 431
                        } )

                        ;
                        match(VOID);
                    }

                    {
                        BREAK | break
                    }

                    ;
                    {
                        DEFAULT | default
                    }

                    {
                        COLON |  : 
                    }

                    {
                        THROW | throw
                    }

                    new NoViableAltException(
                    {
                    THIS | this
                    }

                     )
                    ;
                }

                setState(
                {
                    IntegerLiteral | 434
                } )

                ;
                match(Identifier);
                setState(
                {
                    IntegerLiteral | 435
                } )

                ;
                formalParameters();
                setState(
                {
                    IntegerLiteral | 440
                } )

                ;
                _errHandler.sync(
                {
                    THIS | this
                } )

                ;
                _la = _input.LA(
                {
                    IntegerLiteral | 1
                } )

                ;
                {
                    WHILE | while
                }

                (_la
                {
                    EQUAL |= =
                }

                LBRACK )
                {
                    {
                        {
                            setState(
                            {
                                IntegerLiteral | 436
                            } )

                            ;
                            match(LBRACK);
                            setState(
                            {
                                IntegerLiteral | 437
                            } )

                            ;
                            match(RBRACK);
                        }
                    }

                    setState(
                    {
                        IntegerLiteral | 442
                    } )

                    ;
                    _errHandler.sync(
                    {
                        THIS | this
                    } )

                    ;
                    _la = _input.LA(
                    {
                        IntegerLiteral | 1
                    } )

                    ;
                }

                setState(
                {
                    IntegerLiteral | 445
                } )

                ;
                _la = _input.LA(
                {
                    IntegerLiteral | 1
                } )

                ;
                {
                    IF | if
                }

                (_la
                {
                    EQUAL |= =
                }

                THROWS )
                {
                    {
                        setState(
                        {
                            IntegerLiteral | 443
                        } )

                        ;
                        match(THROWS);
                        setState(
                        {
                            IntegerLiteral | 444
                        } )

                        ;
                        qualifiedNameList();
                    }
                }

                setState(
                {
                    IntegerLiteral | 449
                } )

                ;
                {
                    SWITCH | switch
                    }

                    (_input.LA(
                    {
                        IntegerLiteral | 1
                    } ) )

                    {
                        {
                            CASE |  case
                        }

                        LBRACE
                        {
                            COLON |  : 
                        }

                        {
                            setState(
                            {
                                IntegerLiteral | 447
                            } )

                            ;
                            methodBody();
                        }

                        {
                            BREAK | break
                        }

                        ;
                        {
                            CASE |  case
                        }

                        SEMI
                        {
                            COLON |  : 
                        }

                        {
                            setState(
                            {
                                IntegerLiteral | 448
                            } )

                            ;
                            match(SEMI);
                        }

                        {
                            BREAK | break
                        }

                        ;
                        {
                            DEFAULT | default
                        }

                        {
                            COLON |  : 
                        }

                        {
                            THROW | throw
                        }

                        new NoViableAltException(
                        {
                        THIS | this
                        }

                         )
                        ;
                    }
                }
            }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(
        {
            THIS | this
        } , 

        re )
        ;
        _errHandler.recover(
        {
            THIS | this
        } , 

        re )
        ;
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        {
            RETURN | return
        }

        _localctx;
    }

public static class GenericMethodDeclarationContext
{
    EXTENDS |extends
}

ParserRuleContext {
public MethodDeclarationContextmethodDeclaration()
{
    {
        RETURN | return
    }

    getRuleContext(MethodDeclarationContext.class ,  {

IntegerLiteral | 0 } ) ;  }public TypeParametersContexttypeParameters()
{
    {
        RETURN | return
    }

    getRuleContext(TypeParametersContext.class ,  {

IntegerLiteral | 0 } ) ;  }public GenericMethodDeclarationContext(ParserRuleContext parent, {
    INT | int
}

invokingState ) { {SUPER |super } (
parent , invokingState ) ;  } {AT | @ }Override public {
INT |int }
getRuleIndex()
{
    {
        RETURN | return
    }

    RULE_genericMethodDeclaration;
} {

AT | @ }Override public void enterRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterGenericMethodDeclaration(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public void exitRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitGenericMethodDeclaration(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public {
LT | < }T {
GT | > }Taccept(ParseTreeVisitor
{
    LT | <
} {

QUESTION |? } {
EXTENDS |extends }
T {
GT | > }visitor ) { {IF | if } (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) {RETURN | return } ( (JavaVisitor {
LT | < } {QUESTION |? } {
EXTENDS |extends }
T {
GT | > } )visitor ) .visitGenericMethodDeclaration(
{
    THIS | this
} ) ;  {

ELSE | else } {RETURN | return }visitor.visitChildren ( {THIS |this
} ) ;  } }

public {
FINAL |final }
GenericMethodDeclarationContextgenericMethodDeclaration()
{
    GenericMethodDeclarationContext _localctx = new GenericMethodDeclarationContext(_ctx, getState());
    enterRule(_localctx, {
        IntegerLiteral | 44
    } , 

    RULE_genericMethodDeclaration )
    ;
    try
    {
        enterOuterAlt(_localctx, {
            IntegerLiteral | 1
        } )

        ;
        {
            setState(
            {
                IntegerLiteral | 451
            } )

            ;
            typeParameters();
            setState(
            {
                IntegerLiteral | 452
            } )

            ;
            methodDeclaration();
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(
        {
            THIS | this
        } , 

        re )
        ;
        _errHandler.recover(
        {
            THIS | this
        } , 

        re )
        ;
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        {
            RETURN | return
        }

        _localctx;
    }

public static class ConstructorDeclarationContext
{
    EXTENDS |extends
}

ParserRuleContext {
public TerminalNodeIdentifier()
{
    {
        RETURN | return
    }

    getToken(JavaParser.Identifier, {
        IntegerLiteral | 0
    } )

    ;
}

public ConstructorBodyContextconstructorBody()
{
    {
        RETURN | return
    }

    getRuleContext(ConstructorBodyContext.class ,  {

IntegerLiteral | 0 } ) ;  }public QualifiedNameListContextqualifiedNameList()
{
    {
        RETURN | return
    }

    getRuleContext(QualifiedNameListContext.class ,  {

IntegerLiteral | 0 } ) ;  }public FormalParametersContextformalParameters()
{
    {
        RETURN | return
    }

    getRuleContext(FormalParametersContext.class ,  {

IntegerLiteral | 0 } ) ;  }public ConstructorDeclarationContext(ParserRuleContext parent, {
    INT | int
}

invokingState ) { {SUPER |super } (
parent , invokingState ) ;  } {AT | @ }Override public {
INT |int }
getRuleIndex()
{
    {
        RETURN | return
    }

    RULE_constructorDeclaration;
} {

AT | @ }Override public void enterRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterConstructorDeclaration(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public void exitRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitConstructorDeclaration(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public {
LT | < }T {
GT | > }Taccept(ParseTreeVisitor
{
    LT | <
} {

QUESTION |? } {
EXTENDS |extends }
T {
GT | > }visitor ) { {IF | if } (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) {RETURN | return } ( (JavaVisitor {
LT | < } {QUESTION |? } {
EXTENDS |extends }
T {
GT | > } )visitor ) .visitConstructorDeclaration(
{
    THIS | this
} ) ;  {

ELSE | else } {RETURN | return }visitor.visitChildren ( {THIS |this
} ) ;  } }

public {
FINAL |final }
ConstructorDeclarationContextconstructorDeclaration()
{
    ConstructorDeclarationContext _localctx = new ConstructorDeclarationContext(_ctx, getState());
    enterRule(_localctx, {
        IntegerLiteral | 46
    } , 

    RULE_constructorDeclaration )
    ;
    {
        INT | int
    }

    _la;
    try
    {
        enterOuterAlt(_localctx, {
            IntegerLiteral | 1
        } )

        ;
        {
            setState(
            {
                IntegerLiteral | 454
            } )

            ;
            match(Identifier);
            setState(
            {
                IntegerLiteral | 455
            } )

            ;
            formalParameters();
            setState(
            {
                IntegerLiteral | 458
            } )

            ;
            _la = _input.LA(
            {
                IntegerLiteral | 1
            } )

            ;
            {
                IF | if
            }

            (_la
            {
                EQUAL |= =
            }

            THROWS )
            {
                {
                    setState(
                    {
                        IntegerLiteral | 456
                    } )

                    ;
                    match(THROWS);
                    setState(
                    {
                        IntegerLiteral | 457
                    } )

                    ;
                    qualifiedNameList();
                }
            }

            setState(
            {
                IntegerLiteral | 460
            } )

            ;
            constructorBody();
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(
        {
            THIS | this
        } , 

        re )
        ;
        _errHandler.recover(
        {
            THIS | this
        } , 

        re )
        ;
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        {
            RETURN | return
        }

        _localctx;
    }

public static class GenericConstructorDeclarationContext
{
    EXTENDS |extends
}

ParserRuleContext {
public TypeParametersContexttypeParameters()
{
    {
        RETURN | return
    }

    getRuleContext(TypeParametersContext.class ,  {

IntegerLiteral | 0 } ) ;  }public ConstructorDeclarationContextconstructorDeclaration()
{
    {
        RETURN | return
    }

    getRuleContext(ConstructorDeclarationContext.class ,  {

IntegerLiteral | 0 } ) ;  }public GenericConstructorDeclarationContext(ParserRuleContext parent, {
    INT | int
}

invokingState ) { {SUPER |super } (
parent , invokingState ) ;  } {AT | @ }Override public {
INT |int }
getRuleIndex()
{
    {
        RETURN | return
    }

    RULE_genericConstructorDeclaration;
} {

AT | @ }Override public void enterRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterGenericConstructorDeclaration(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public void exitRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitGenericConstructorDeclaration(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public {
LT | < }T {
GT | > }Taccept(ParseTreeVisitor
{
    LT | <
} {

QUESTION |? } {
EXTENDS |extends }
T {
GT | > }visitor ) { {IF | if } (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) {RETURN | return } ( (JavaVisitor {
LT | < } {QUESTION |? } {
EXTENDS |extends }
T {
GT | > } )visitor ) .visitGenericConstructorDeclaration(
{
    THIS | this
} ) ;  {

ELSE | else } {RETURN | return }visitor.visitChildren ( {THIS |this
} ) ;  } }

public {
FINAL |final }
GenericConstructorDeclarationContextgenericConstructorDeclaration()
{
    GenericConstructorDeclarationContext _localctx = new GenericConstructorDeclarationContext(_ctx, getState());
    enterRule(_localctx, {
        IntegerLiteral | 48
    } , 

    RULE_genericConstructorDeclaration )
    ;
    try
    {
        enterOuterAlt(_localctx, {
            IntegerLiteral | 1
        } )

        ;
        {
            setState(
            {
                IntegerLiteral | 462
            } )

            ;
            typeParameters();
            setState(
            {
                IntegerLiteral | 463
            } )

            ;
            constructorDeclaration();
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(
        {
            THIS | this
        } , 

        re )
        ;
        _errHandler.recover(
        {
            THIS | this
        } , 

        re )
        ;
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        {
            RETURN | return
        }

        _localctx;
    }

public static class FieldDeclarationContext
{
    EXTENDS |extends
}

ParserRuleContext {
public VariableDeclaratorsContextvariableDeclarators()
{
    {
        RETURN | return
    }

    getRuleContext(VariableDeclaratorsContext.class ,  {

IntegerLiteral | 0 } ) ;  }public TypeContexttype()
{
    {
        RETURN | return
    }

    getRuleContext(TypeContext.class ,  {

IntegerLiteral | 0 } ) ;  }public FieldDeclarationContext(ParserRuleContext parent, {
    INT | int
}

invokingState ) { {SUPER |super } (
parent , invokingState ) ;  } {AT | @ }Override public {
INT |int }
getRuleIndex()
{
    {
        RETURN | return
    }

    RULE_fieldDeclaration;
} {

AT | @ }Override public void enterRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterFieldDeclaration(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public void exitRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitFieldDeclaration(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public {
LT | < }T {
GT | > }Taccept(ParseTreeVisitor
{
    LT | <
} {

QUESTION |? } {
EXTENDS |extends }
T {
GT | > }visitor ) { {IF | if } (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) {RETURN | return } ( (JavaVisitor {
LT | < } {QUESTION |? } {
EXTENDS |extends }
T {
GT | > } )visitor ) .visitFieldDeclaration(
{
    THIS | this
} ) ;  {

ELSE | else } {RETURN | return }visitor.visitChildren ( {THIS |this
} ) ;  } }

public {
FINAL |final }
FieldDeclarationContextfieldDeclaration()
{
    FieldDeclarationContext _localctx = new FieldDeclarationContext(_ctx, getState());
    enterRule(_localctx, {
        IntegerLiteral | 50
    } , 

    RULE_fieldDeclaration )
    ;
    try
    {
        enterOuterAlt(_localctx, {
            IntegerLiteral | 1
        } )

        ;
        {
            setState(
            {
                IntegerLiteral | 465
            } )

            ;
            type();
            setState(
            {
                IntegerLiteral | 466
            } )

            ;
            variableDeclarators();
            setState(
            {
                IntegerLiteral | 467
            } )

            ;
            match(SEMI);
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(
        {
            THIS | this
        } , 

        re )
        ;
        _errHandler.recover(
        {
            THIS | this
        } , 

        re )
        ;
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        {
            RETURN | return
        }

        _localctx;
    }

public static class InterfaceBodyDeclarationContext
{
    EXTENDS |extends
}

ParserRuleContext {
public List {
LT | < }ModifierContext {
GT | > }modifier()
{
    {
        RETURN | return
    }

    getRuleContexts(ModifierContext.class ) ;  }

public ModifierContextmodifier(
{
    INT | int
}

i ) { {RETURN | return }getRuleContext(ModifierContext.class , 

i ) ;  }public InterfaceMemberDeclarationContextinterfaceMemberDeclaration()
{
    {
        RETURN | return
    }

    getRuleContext(InterfaceMemberDeclarationContext.class ,  {

IntegerLiteral | 0 } ) ;  }public InterfaceBodyDeclarationContext(ParserRuleContext parent, {
    INT | int
}

invokingState ) { {SUPER |super } (
parent , invokingState ) ;  } {AT | @ }Override public {
INT |int }
getRuleIndex()
{
    {
        RETURN | return
    }

    RULE_interfaceBodyDeclaration;
} {

AT | @ }Override public void enterRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterInterfaceBodyDeclaration(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public void exitRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitInterfaceBodyDeclaration(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public {
LT | < }T {
GT | > }Taccept(ParseTreeVisitor
{
    LT | <
} {

QUESTION |? } {
EXTENDS |extends }
T {
GT | > }visitor ) { {IF | if } (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) {RETURN | return } ( (JavaVisitor {
LT | < } {QUESTION |? } {
EXTENDS |extends }
T {
GT | > } )visitor ) .visitInterfaceBodyDeclaration(
{
    THIS | this
} ) ;  {

ELSE | else } {RETURN | return }visitor.visitChildren ( {THIS |this
} ) ;  } }

public {
FINAL |final }
InterfaceBodyDeclarationContextinterfaceBodyDeclaration()
{
    InterfaceBodyDeclarationContext _localctx = new InterfaceBodyDeclarationContext(_ctx, getState());
    enterRule(_localctx, {
        IntegerLiteral | 52
    } , 

    RULE_interfaceBodyDeclaration )
    ;
    try
    {
        {
            INT | int
        }

        _alt;
        setState(
        {
            IntegerLiteral | 477
        } )

        ;
        {
            SWITCH | switch
            }

            (_input.LA(
            {
                IntegerLiteral | 1
            } ) )

            {
                {
                    CASE |  case
                }

                ABSTRACT
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                BOOLEAN
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                BYTE
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                CHAR
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                CLASS
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                DOUBLE
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                ENUM
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                FINAL
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                FLOAT
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                INT
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                INTERFACE
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                LONG
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                NATIVE
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                PRIVATE
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                PROTECTED
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                PUBLIC
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                SHORT
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                STATIC
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                STRICTFP
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                SYNCHRONIZED
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                TRANSIENT
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                VOID
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                VOLATILE
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                LT
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                Identifier
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                AT
                {
                    COLON |  : 
                }

                enterOuterAlt(_localctx, {
                    IntegerLiteral | 1
                } )

                ;
                {
                    setState(
                    {
                        IntegerLiteral | 472
                    } )

                    ;
                    _errHandler.sync(
                    {
                        THIS | this
                    } )

                    ;
                    _alt = getInterpreter().adaptivePredict(_input, {
                        IntegerLiteral | 43
                    } , 

                    _ctx )
                    ;
                    {
                        WHILE | while
                    }

                    (_alt
                    {
                        NOTEQUAL | !=
                    }

                    {
                        IntegerLiteral | 2
                    }

                    {
                        AND | &&
                    }

                    _alt
                    {
                        NOTEQUAL | !=
                    }

                    org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER )
                    {
                        {
                            IF | if
                        }

                        (_alt
                        {
                            EQUAL |= =
                        }

                        {
                            IntegerLiteral | 1
                        } )

                        {
                            {
                                {
                                    setState(
                                    {
                                        IntegerLiteral | 469
                                    } )

                                    ;
                                    modifier();
                                }
                            }
                        }

                        setState(
                        {
                            IntegerLiteral | 474
                        } )

                        ;
                        _errHandler.sync(
                        {
                            THIS | this
                        } )

                        ;
                        _alt = getInterpreter().adaptivePredict(_input, {
                            IntegerLiteral | 43
                        } , 

                        _ctx )
                        ;
                    }

                    setState(
                    {
                        IntegerLiteral | 475
                    } )

                    ;
                    interfaceMemberDeclaration();
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                SEMI
                {
                    COLON |  : 
                }

                enterOuterAlt(_localctx, {
                    IntegerLiteral | 2
                } )

                ;
                {
                    setState(
                    {
                        IntegerLiteral | 476
                    } )

                    ;
                    match(SEMI);
                }

                {
                    BREAK | break
                }

                ;
                {
                    DEFAULT | default
                }

                {
                    COLON |  : 
                }

                {
                    THROW | throw
                }

                new NoViableAltException(
                {
                THIS | this
                }

                 )
                ;
            }
        }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(
        {
            THIS | this
        } , 

        re )
        ;
        _errHandler.recover(
        {
            THIS | this
        } , 

        re )
        ;
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        {
            RETURN | return
        }

        _localctx;
    }

public static class InterfaceMemberDeclarationContext
{
    EXTENDS |extends
}

ParserRuleContext {
public EnumDeclarationContextenumDeclaration()
{
    {
        RETURN | return
    }

    getRuleContext(EnumDeclarationContext.class ,  {

IntegerLiteral | 0 } ) ;  }public ClassDeclarationContextclassDeclaration()
{
    {
        RETURN | return
    }

    getRuleContext(ClassDeclarationContext.class ,  {

IntegerLiteral | 0 } ) ;  }public GenericInterfaceMethodDeclarationContextgenericInterfaceMethodDeclaration()
{
    {
        RETURN | return
    }

    getRuleContext(GenericInterfaceMethodDeclarationContext.class ,  {

IntegerLiteral | 0 } ) ;  }public AnnotationTypeDeclarationContextannotationTypeDeclaration()
{
    {
        RETURN | return
    }

    getRuleContext(AnnotationTypeDeclarationContext.class ,  {

IntegerLiteral | 0 } ) ;  }public InterfaceDeclarationContextinterfaceDeclaration()
{
    {
        RETURN | return
    }

    getRuleContext(InterfaceDeclarationContext.class ,  {

IntegerLiteral | 0 } ) ;  }public ConstDeclarationContextconstDeclaration()
{
    {
        RETURN | return
    }

    getRuleContext(ConstDeclarationContext.class ,  {

IntegerLiteral | 0 } ) ;  }public InterfaceMethodDeclarationContextinterfaceMethodDeclaration()
{
    {
        RETURN | return
    }

    getRuleContext(InterfaceMethodDeclarationContext.class ,  {

IntegerLiteral | 0 } ) ;  }public InterfaceMemberDeclarationContext(ParserRuleContext parent, {
    INT | int
}

invokingState ) { {SUPER |super } (
parent , invokingState ) ;  } {AT | @ }Override public {
INT |int }
getRuleIndex()
{
    {
        RETURN | return
    }

    RULE_interfaceMemberDeclaration;
} {

AT | @ }Override public void enterRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterInterfaceMemberDeclaration(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public void exitRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitInterfaceMemberDeclaration(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public {
LT | < }T {
GT | > }Taccept(ParseTreeVisitor
{
    LT | <
} {

QUESTION |? } {
EXTENDS |extends }
T {
GT | > }visitor ) { {IF | if } (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) {RETURN | return } ( (JavaVisitor {
LT | < } {QUESTION |? } {
EXTENDS |extends }
T {
GT | > } )visitor ) .visitInterfaceMemberDeclaration(
{
    THIS | this
} ) ;  {

ELSE | else } {RETURN | return }visitor.visitChildren ( {THIS |this
} ) ;  } }

public {
FINAL |final }
InterfaceMemberDeclarationContextinterfaceMemberDeclaration()
{
    InterfaceMemberDeclarationContext _localctx = new InterfaceMemberDeclarationContext(_ctx, getState());
    enterRule(_localctx, {
        IntegerLiteral | 54
    } , 

    RULE_interfaceMemberDeclaration )
    ;
    try
    {
        setState(
        {
            IntegerLiteral | 486
        } )

        ;
        {
            SWITCH | switch
            }

            (getInterpreter().adaptivePredict(_input, {
                IntegerLiteral | 45
            } , 

            _ctx ) )
            {
                {
                    CASE |  case
                }

                {
                    IntegerLiteral | 1
                }

                {
                    COLON |  : 
                }

                enterOuterAlt(_localctx, {
                    IntegerLiteral | 1
                } )

                ;
                {
                    setState(
                    {
                        IntegerLiteral | 479
                    } )

                    ;
                    constDeclaration();
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                {
                    IntegerLiteral | 2
                }

                {
                    COLON |  : 
                }

                enterOuterAlt(_localctx, {
                    IntegerLiteral | 2
                } )

                ;
                {
                    setState(
                    {
                        IntegerLiteral | 480
                    } )

                    ;
                    interfaceMethodDeclaration();
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                {
                    IntegerLiteral | 3
                }

                {
                    COLON |  : 
                }

                enterOuterAlt(_localctx, {
                    IntegerLiteral | 3
                } )

                ;
                {
                    setState(
                    {
                        IntegerLiteral | 481
                    } )

                    ;
                    genericInterfaceMethodDeclaration();
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                {
                    IntegerLiteral | 4
                }

                {
                    COLON |  : 
                }

                enterOuterAlt(_localctx, {
                    IntegerLiteral | 4
                } )

                ;
                {
                    setState(
                    {
                        IntegerLiteral | 482
                    } )

                    ;
                    interfaceDeclaration();
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                {
                    IntegerLiteral | 5
                }

                {
                    COLON |  : 
                }

                enterOuterAlt(_localctx, {
                    IntegerLiteral | 5
                } )

                ;
                {
                    setState(
                    {
                        IntegerLiteral | 483
                    } )

                    ;
                    annotationTypeDeclaration();
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                {
                    IntegerLiteral | 6
                }

                {
                    COLON |  : 
                }

                enterOuterAlt(_localctx, {
                    IntegerLiteral | 6
                } )

                ;
                {
                    setState(
                    {
                        IntegerLiteral | 484
                    } )

                    ;
                    classDeclaration();
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                {
                    IntegerLiteral | 7
                }

                {
                    COLON |  : 
                }

                enterOuterAlt(_localctx, {
                    IntegerLiteral | 7
                } )

                ;
                {
                    setState(
                    {
                        IntegerLiteral | 485
                    } )

                    ;
                    enumDeclaration();
                }

                {
                    BREAK | break
                }

                ;
            }
        }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(
        {
            THIS | this
        } , 

        re )
        ;
        _errHandler.recover(
        {
            THIS | this
        } , 

        re )
        ;
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        {
            RETURN | return
        }

        _localctx;
    }

public static class ConstDeclarationContext
{
    EXTENDS |extends
}

ParserRuleContext {
public ConstantDeclaratorContextconstantDeclarator(
{
    INT | int
}

i ) { {RETURN | return }getRuleContext(ConstantDeclaratorContext.class , 

i ) ;  }public List {
LT | < }ConstantDeclaratorContext {
GT | > }constantDeclarator()
{
    {
        RETURN | return
    }

    getRuleContexts(ConstantDeclaratorContext.class ) ;  }

public TypeContexttype()
{
    {
        RETURN | return
    }

    getRuleContext(TypeContext.class ,  {

IntegerLiteral | 0 } ) ;  }public ConstDeclarationContext(ParserRuleContext parent, {
    INT | int
}

invokingState ) { {SUPER |super } (
parent , invokingState ) ;  } {AT | @ }Override public {
INT |int }
getRuleIndex()
{
    {
        RETURN | return
    }

    RULE_constDeclaration;
} {

AT | @ }Override public void enterRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterConstDeclaration(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public void exitRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitConstDeclaration(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public {
LT | < }T {
GT | > }Taccept(ParseTreeVisitor
{
    LT | <
} {

QUESTION |? } {
EXTENDS |extends }
T {
GT | > }visitor ) { {IF | if } (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) {RETURN | return } ( (JavaVisitor {
LT | < } {QUESTION |? } {
EXTENDS |extends }
T {
GT | > } )visitor ) .visitConstDeclaration(
{
    THIS | this
} ) ;  {

ELSE | else } {RETURN | return }visitor.visitChildren ( {THIS |this
} ) ;  } }

public {
FINAL |final }
ConstDeclarationContextconstDeclaration()
{
    ConstDeclarationContext _localctx = new ConstDeclarationContext(_ctx, getState());
    enterRule(_localctx, {
        IntegerLiteral | 56
    } , 

    RULE_constDeclaration )
    ;
    {
        INT | int
    }

    _la;
    try
    {
        enterOuterAlt(_localctx, {
            IntegerLiteral | 1
        } )

        ;
        {
            setState(
            {
                IntegerLiteral | 488
            } )

            ;
            type();
            setState(
            {
                IntegerLiteral | 489
            } )

            ;
            constantDeclarator();
            setState(
            {
                IntegerLiteral | 494
            } )

            ;
            _errHandler.sync(
            {
                THIS | this
            } )

            ;
            _la = _input.LA(
            {
                IntegerLiteral | 1
            } )

            ;
            {
                WHILE | while
            }

            (_la
            {
                EQUAL |= =
            }

            COMMA )
            {
                {
                    {
                        setState(
                        {
                            IntegerLiteral | 490
                        } )

                        ;
                        match(COMMA);
                        setState(
                        {
                            IntegerLiteral | 491
                        } )

                        ;
                        constantDeclarator();
                    }
                }

                setState(
                {
                    IntegerLiteral | 496
                } )

                ;
                _errHandler.sync(
                {
                    THIS | this
                } )

                ;
                _la = _input.LA(
                {
                    IntegerLiteral | 1
                } )

                ;
            }

            setState(
            {
                IntegerLiteral | 497
            } )

            ;
            match(SEMI);
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(
        {
            THIS | this
        } , 

        re )
        ;
        _errHandler.recover(
        {
            THIS | this
        } , 

        re )
        ;
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        {
            RETURN | return
        }

        _localctx;
    }

public static class ConstantDeclaratorContext
{
    EXTENDS |extends
}

ParserRuleContext {
public TerminalNodeIdentifier()
{
    {
        RETURN | return
    }

    getToken(JavaParser.Identifier, {
        IntegerLiteral | 0
    } )

    ;
}

public VariableInitializerContextvariableInitializer()
{
    {
        RETURN | return
    }

    getRuleContext(VariableInitializerContext.class ,  {

IntegerLiteral | 0 } ) ;  }public ConstantDeclaratorContext(ParserRuleContext parent, {
    INT | int
}

invokingState ) { {SUPER |super } (
parent , invokingState ) ;  } {AT | @ }Override public {
INT |int }
getRuleIndex()
{
    {
        RETURN | return
    }

    RULE_constantDeclarator;
} {

AT | @ }Override public void enterRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterConstantDeclarator(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public void exitRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitConstantDeclarator(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public {
LT | < }T {
GT | > }Taccept(ParseTreeVisitor
{
    LT | <
} {

QUESTION |? } {
EXTENDS |extends }
T {
GT | > }visitor ) { {IF | if } (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) {RETURN | return } ( (JavaVisitor {
LT | < } {QUESTION |? } {
EXTENDS |extends }
T {
GT | > } )visitor ) .visitConstantDeclarator(
{
    THIS | this
} ) ;  {

ELSE | else } {RETURN | return }visitor.visitChildren ( {THIS |this
} ) ;  } }

public {
FINAL |final }
ConstantDeclaratorContextconstantDeclarator()
{
    ConstantDeclaratorContext _localctx = new ConstantDeclaratorContext(_ctx, getState());
    enterRule(_localctx, {
        IntegerLiteral | 58
    } , 

    RULE_constantDeclarator )
    ;
    {
        INT | int
    }

    _la;
    try
    {
        enterOuterAlt(_localctx, {
            IntegerLiteral | 1
        } )

        ;
        {
            setState(
            {
                IntegerLiteral | 499
            } )

            ;
            match(Identifier);
            setState(
            {
                IntegerLiteral | 504
            } )

            ;
            _errHandler.sync(
            {
                THIS | this
            } )

            ;
            _la = _input.LA(
            {
                IntegerLiteral | 1
            } )

            ;
            {
                WHILE | while
            }

            (_la
            {
                EQUAL |= =
            }

            LBRACK )
            {
                {
                    {
                        setState(
                        {
                            IntegerLiteral | 500
                        } )

                        ;
                        match(LBRACK);
                        setState(
                        {
                            IntegerLiteral | 501
                        } )

                        ;
                        match(RBRACK);
                    }
                }

                setState(
                {
                    IntegerLiteral | 506
                } )

                ;
                _errHandler.sync(
                {
                    THIS | this
                } )

                ;
                _la = _input.LA(
                {
                    IntegerLiteral | 1
                } )

                ;
            }

            setState(
            {
                IntegerLiteral | 507
            } )

            ;
            match(ASSIGN);
            setState(
            {
                IntegerLiteral | 508
            } )

            ;
            variableInitializer();
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(
        {
            THIS | this
        } , 

        re )
        ;
        _errHandler.recover(
        {
            THIS | this
        } , 

        re )
        ;
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        {
            RETURN | return
        }

        _localctx;
    }

public static class InterfaceMethodDeclarationContext
{
    EXTENDS |extends
}

ParserRuleContext {
public TerminalNodeIdentifier()
{
    {
        RETURN | return
    }

    getToken(JavaParser.Identifier, {
        IntegerLiteral | 0
    } )

    ;
}

public QualifiedNameListContextqualifiedNameList()
{
    {
        RETURN | return
    }

    getRuleContext(QualifiedNameListContext.class ,  {

IntegerLiteral | 0 } ) ;  }public FormalParametersContextformalParameters()
{
    {
        RETURN | return
    }

    getRuleContext(FormalParametersContext.class ,  {

IntegerLiteral | 0 } ) ;  }public TypeContexttype()
{
    {
        RETURN | return
    }

    getRuleContext(TypeContext.class ,  {

IntegerLiteral | 0 } ) ;  }public InterfaceMethodDeclarationContext(ParserRuleContext parent, {
    INT | int
}

invokingState ) { {SUPER |super } (
parent , invokingState ) ;  } {AT | @ }Override public {
INT |int }
getRuleIndex()
{
    {
        RETURN | return
    }

    RULE_interfaceMethodDeclaration;
} {

AT | @ }Override public void enterRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterInterfaceMethodDeclaration(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public void exitRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitInterfaceMethodDeclaration(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public {
LT | < }T {
GT | > }Taccept(ParseTreeVisitor
{
    LT | <
} {

QUESTION |? } {
EXTENDS |extends }
T {
GT | > }visitor ) { {IF | if } (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) {RETURN | return } ( (JavaVisitor {
LT | < } {QUESTION |? } {
EXTENDS |extends }
T {
GT | > } )visitor ) .visitInterfaceMethodDeclaration(
{
    THIS | this
} ) ;  {

ELSE | else } {RETURN | return }visitor.visitChildren ( {THIS |this
} ) ;  } }

public {
FINAL |final }
InterfaceMethodDeclarationContextinterfaceMethodDeclaration()
{
    InterfaceMethodDeclarationContext _localctx = new InterfaceMethodDeclarationContext(_ctx, getState());
    enterRule(_localctx, {
        IntegerLiteral | 60
    } , 

    RULE_interfaceMethodDeclaration )
    ;
    {
        INT | int
    }

    _la;
    try
    {
        enterOuterAlt(_localctx, {
            IntegerLiteral | 1
        } )

        ;
        {
            setState(
            {
                IntegerLiteral | 512
            } )

            ;
            {
                SWITCH | switch
                }

                (_input.LA(
                {
                    IntegerLiteral | 1
                } ) )

                {
                    {
                        CASE |  case
                    }

                    BOOLEAN
                    {
                        COLON |  : 
                    }

                    {
                        CASE |  case
                    }

                    BYTE
                    {
                        COLON |  : 
                    }

                    {
                        CASE |  case
                    }

                    CHAR
                    {
                        COLON |  : 
                    }

                    {
                        CASE |  case
                    }

                    DOUBLE
                    {
                        COLON |  : 
                    }

                    {
                        CASE |  case
                    }

                    FLOAT
                    {
                        COLON |  : 
                    }

                    {
                        CASE |  case
                    }

                    INT
                    {
                        COLON |  : 
                    }

                    {
                        CASE |  case
                    }

                    LONG
                    {
                        COLON |  : 
                    }

                    {
                        CASE |  case
                    }

                    SHORT
                    {
                        COLON |  : 
                    }

                    {
                        CASE |  case
                    }

                    Identifier
                    {
                        COLON |  : 
                    }

                    {
                        setState(
                        {
                            IntegerLiteral | 510
                        } )

                        ;
                        type();
                    }

                    {
                        BREAK | break
                    }

                    ;
                    {
                        CASE |  case
                    }

                    VOID
                    {
                        COLON |  : 
                    }

                    {
                        setState(
                        {
                            IntegerLiteral | 511
                        } )

                        ;
                        match(VOID);
                    }

                    {
                        BREAK | break
                    }

                    ;
                    {
                        DEFAULT | default
                    }

                    {
                        COLON |  : 
                    }

                    {
                        THROW | throw
                    }

                    new NoViableAltException(
                    {
                    THIS | this
                    }

                     )
                    ;
                }

                setState(
                {
                    IntegerLiteral | 514
                } )

                ;
                match(Identifier);
                setState(
                {
                    IntegerLiteral | 515
                } )

                ;
                formalParameters();
                setState(
                {
                    IntegerLiteral | 520
                } )

                ;
                _errHandler.sync(
                {
                    THIS | this
                } )

                ;
                _la = _input.LA(
                {
                    IntegerLiteral | 1
                } )

                ;
                {
                    WHILE | while
                }

                (_la
                {
                    EQUAL |= =
                }

                LBRACK )
                {
                    {
                        {
                            setState(
                            {
                                IntegerLiteral | 516
                            } )

                            ;
                            match(LBRACK);
                            setState(
                            {
                                IntegerLiteral | 517
                            } )

                            ;
                            match(RBRACK);
                        }
                    }

                    setState(
                    {
                        IntegerLiteral | 522
                    } )

                    ;
                    _errHandler.sync(
                    {
                        THIS | this
                    } )

                    ;
                    _la = _input.LA(
                    {
                        IntegerLiteral | 1
                    } )

                    ;
                }

                setState(
                {
                    IntegerLiteral | 525
                } )

                ;
                _la = _input.LA(
                {
                    IntegerLiteral | 1
                } )

                ;
                {
                    IF | if
                }

                (_la
                {
                    EQUAL |= =
                }

                THROWS )
                {
                    {
                        setState(
                        {
                            IntegerLiteral | 523
                        } )

                        ;
                        match(THROWS);
                        setState(
                        {
                            IntegerLiteral | 524
                        } )

                        ;
                        qualifiedNameList();
                    }
                }

                setState(
                {
                    IntegerLiteral | 527
                } )

                ;
                match(SEMI);
            }
        }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(
        {
            THIS | this
        } , 

        re )
        ;
        _errHandler.recover(
        {
            THIS | this
        } , 

        re )
        ;
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        {
            RETURN | return
        }

        _localctx;
    }

public static class GenericInterfaceMethodDeclarationContext
{
    EXTENDS |extends
}

ParserRuleContext {
public TypeParametersContexttypeParameters()
{
    {
        RETURN | return
    }

    getRuleContext(TypeParametersContext.class ,  {

IntegerLiteral | 0 } ) ;  }public InterfaceMethodDeclarationContextinterfaceMethodDeclaration()
{
    {
        RETURN | return
    }

    getRuleContext(InterfaceMethodDeclarationContext.class ,  {

IntegerLiteral | 0 } ) ;  }public GenericInterfaceMethodDeclarationContext(ParserRuleContext parent, {
    INT | int
}

invokingState ) { {SUPER |super } (
parent , invokingState ) ;  } {AT | @ }Override public {
INT |int }
getRuleIndex()
{
    {
        RETURN | return
    }

    RULE_genericInterfaceMethodDeclaration;
} {

AT | @ }Override public void enterRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterGenericInterfaceMethodDeclaration(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public void exitRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitGenericInterfaceMethodDeclaration(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public {
LT | < }T {
GT | > }Taccept(ParseTreeVisitor
{
    LT | <
} {

QUESTION |? } {
EXTENDS |extends }
T {
GT | > }visitor ) { {IF | if } (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) {RETURN | return } ( (JavaVisitor {
LT | < } {QUESTION |? } {
EXTENDS |extends }
T {
GT | > } )visitor ) .visitGenericInterfaceMethodDeclaration(
{
    THIS | this
} ) ;  {

ELSE | else } {RETURN | return }visitor.visitChildren ( {THIS |this
} ) ;  } }

public {
FINAL |final }
GenericInterfaceMethodDeclarationContextgenericInterfaceMethodDeclaration()
{
    GenericInterfaceMethodDeclarationContext _localctx = new GenericInterfaceMethodDeclarationContext(_ctx, getState());
    enterRule(_localctx, {
        IntegerLiteral | 62
    } , 

    RULE_genericInterfaceMethodDeclaration )
    ;
    try
    {
        enterOuterAlt(_localctx, {
            IntegerLiteral | 1
        } )

        ;
        {
            setState(
            {
                IntegerLiteral | 529
            } )

            ;
            typeParameters();
            setState(
            {
                IntegerLiteral | 530
            } )

            ;
            interfaceMethodDeclaration();
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(
        {
            THIS | this
        } , 

        re )
        ;
        _errHandler.recover(
        {
            THIS | this
        } , 

        re )
        ;
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        {
            RETURN | return
        }

        _localctx;
    }

public static class VariableDeclaratorsContext
{
    EXTENDS |extends
}

ParserRuleContext {
public List {
LT | < }VariableDeclaratorContext {
GT | > }variableDeclarator()
{
    {
        RETURN | return
    }

    getRuleContexts(VariableDeclaratorContext.class ) ;  }

public VariableDeclaratorContextvariableDeclarator(
{
    INT | int
}

i ) { {RETURN | return }getRuleContext(VariableDeclaratorContext.class , 

i ) ;  }public VariableDeclaratorsContext(ParserRuleContext parent, {
    INT | int
}

invokingState ) { {SUPER |super } (
parent , invokingState ) ;  } {AT | @ }Override public {
INT |int }
getRuleIndex()
{
    {
        RETURN | return
    }

    RULE_variableDeclarators;
} {

AT | @ }Override public void enterRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterVariableDeclarators(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public void exitRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitVariableDeclarators(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public {
LT | < }T {
GT | > }Taccept(ParseTreeVisitor
{
    LT | <
} {

QUESTION |? } {
EXTENDS |extends }
T {
GT | > }visitor ) { {IF | if } (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) {RETURN | return } ( (JavaVisitor {
LT | < } {QUESTION |? } {
EXTENDS |extends }
T {
GT | > } )visitor ) .visitVariableDeclarators(
{
    THIS | this
} ) ;  {

ELSE | else } {RETURN | return }visitor.visitChildren ( {THIS |this
} ) ;  } }

public {
FINAL |final }
VariableDeclaratorsContextvariableDeclarators()
{
    VariableDeclaratorsContext _localctx = new VariableDeclaratorsContext(_ctx, getState());
    enterRule(_localctx, {
        IntegerLiteral | 64
    } , 

    RULE_variableDeclarators )
    ;
    {
        INT | int
    }

    _la;
    try
    {
        enterOuterAlt(_localctx, {
            IntegerLiteral | 1
        } )

        ;
        {
            setState(
            {
                IntegerLiteral | 532
            } )

            ;
            variableDeclarator();
            setState(
            {
                IntegerLiteral | 537
            } )

            ;
            _errHandler.sync(
            {
                THIS | this
            } )

            ;
            _la = _input.LA(
            {
                IntegerLiteral | 1
            } )

            ;
            {
                WHILE | while
            }

            (_la
            {
                EQUAL |= =
            }

            COMMA )
            {
                {
                    {
                        setState(
                        {
                            IntegerLiteral | 533
                        } )

                        ;
                        match(COMMA);
                        setState(
                        {
                            IntegerLiteral | 534
                        } )

                        ;
                        variableDeclarator();
                    }
                }

                setState(
                {
                    IntegerLiteral | 539
                } )

                ;
                _errHandler.sync(
                {
                    THIS | this
                } )

                ;
                _la = _input.LA(
                {
                    IntegerLiteral | 1
                } )

                ;
            }
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(
        {
            THIS | this
        } , 

        re )
        ;
        _errHandler.recover(
        {
            THIS | this
        } , 

        re )
        ;
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        {
            RETURN | return
        }

        _localctx;
    }

public static class VariableDeclaratorContext
{
    EXTENDS |extends
}

ParserRuleContext {
public VariableInitializerContextvariableInitializer()
{
    {
        RETURN | return
    }

    getRuleContext(VariableInitializerContext.class ,  {

IntegerLiteral | 0 } ) ;  }public VariableDeclaratorIdContextvariableDeclaratorId()
{
    {
        RETURN | return
    }

    getRuleContext(VariableDeclaratorIdContext.class ,  {

IntegerLiteral | 0 } ) ;  }public VariableDeclaratorContext(ParserRuleContext parent, {
    INT | int
}

invokingState ) { {SUPER |super } (
parent , invokingState ) ;  } {AT | @ }Override public {
INT |int }
getRuleIndex()
{
    {
        RETURN | return
    }

    RULE_variableDeclarator;
} {

AT | @ }Override public void enterRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterVariableDeclarator(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public void exitRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitVariableDeclarator(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public {
LT | < }T {
GT | > }Taccept(ParseTreeVisitor
{
    LT | <
} {

QUESTION |? } {
EXTENDS |extends }
T {
GT | > }visitor ) { {IF | if } (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) {RETURN | return } ( (JavaVisitor {
LT | < } {QUESTION |? } {
EXTENDS |extends }
T {
GT | > } )visitor ) .visitVariableDeclarator(
{
    THIS | this
} ) ;  {

ELSE | else } {RETURN | return }visitor.visitChildren ( {THIS |this
} ) ;  } }

public {
FINAL |final }
VariableDeclaratorContextvariableDeclarator()
{
    VariableDeclaratorContext _localctx = new VariableDeclaratorContext(_ctx, getState());
    enterRule(_localctx, {
        IntegerLiteral | 66
    } , 

    RULE_variableDeclarator )
    ;
    {
        INT | int
    }

    _la;
    try
    {
        enterOuterAlt(_localctx, {
            IntegerLiteral | 1
        } )

        ;
        {
            setState(
            {
                IntegerLiteral | 540
            } )

            ;
            variableDeclaratorId();
            setState(
            {
                IntegerLiteral | 543
            } )

            ;
            _la = _input.LA(
            {
                IntegerLiteral | 1
            } )

            ;
            {
                IF | if
            }

            (_la
            {
                EQUAL |= =
            }

            ASSIGN )
            {
                {
                    setState(
                    {
                        IntegerLiteral | 541
                    } )

                    ;
                    match(ASSIGN);
                    setState(
                    {
                        IntegerLiteral | 542
                    } )

                    ;
                    variableInitializer();
                }
            }
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(
        {
            THIS | this
        } , 

        re )
        ;
        _errHandler.recover(
        {
            THIS | this
        } , 

        re )
        ;
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        {
            RETURN | return
        }

        _localctx;
    }

public static class VariableDeclaratorIdContext
{
    EXTENDS |extends
}

ParserRuleContext {
public TerminalNodeIdentifier()
{
    {
        RETURN | return
    }

    getToken(JavaParser.Identifier, {
        IntegerLiteral | 0
    } )

    ;
}

public VariableDeclaratorIdContext(ParserRuleContext parent, {
    INT | int
}

invokingState ) { {SUPER |super } (
parent , invokingState ) ;  } {AT | @ }Override public {
INT |int }
getRuleIndex()
{
    {
        RETURN | return
    }

    RULE_variableDeclaratorId;
} {

AT | @ }Override public void enterRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterVariableDeclaratorId(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public void exitRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitVariableDeclaratorId(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public {
LT | < }T {
GT | > }Taccept(ParseTreeVisitor
{
    LT | <
} {

QUESTION |? } {
EXTENDS |extends }
T {
GT | > }visitor ) { {IF | if } (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) {RETURN | return } ( (JavaVisitor {
LT | < } {QUESTION |? } {
EXTENDS |extends }
T {
GT | > } )visitor ) .visitVariableDeclaratorId(
{
    THIS | this
} ) ;  {

ELSE | else } {RETURN | return }visitor.visitChildren ( {THIS |this
} ) ;  } }

public {
FINAL |final }
VariableDeclaratorIdContextvariableDeclaratorId()
{
    VariableDeclaratorIdContext _localctx = new VariableDeclaratorIdContext(_ctx, getState());
    enterRule(_localctx, {
        IntegerLiteral | 68
    } , 

    RULE_variableDeclaratorId )
    ;
    {
        INT | int
    }

    _la;
    try
    {
        enterOuterAlt(_localctx, {
            IntegerLiteral | 1
        } )

        ;
        {
            setState(
            {
                IntegerLiteral | 545
            } )

            ;
            match(Identifier);
            setState(
            {
                IntegerLiteral | 550
            } )

            ;
            _errHandler.sync(
            {
                THIS | this
            } )

            ;
            _la = _input.LA(
            {
                IntegerLiteral | 1
            } )

            ;
            {
                WHILE | while
            }

            (_la
            {
                EQUAL |= =
            }

            LBRACK )
            {
                {
                    {
                        setState(
                        {
                            IntegerLiteral | 546
                        } )

                        ;
                        match(LBRACK);
                        setState(
                        {
                            IntegerLiteral | 547
                        } )

                        ;
                        match(RBRACK);
                    }
                }

                setState(
                {
                    IntegerLiteral | 552
                } )

                ;
                _errHandler.sync(
                {
                    THIS | this
                } )

                ;
                _la = _input.LA(
                {
                    IntegerLiteral | 1
                } )

                ;
            }
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(
        {
            THIS | this
        } , 

        re )
        ;
        _errHandler.recover(
        {
            THIS | this
        } , 

        re )
        ;
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        {
            RETURN | return
        }

        _localctx;
    }

public static class VariableInitializerContext
{
    EXTENDS |extends
}

ParserRuleContext {
public ArrayInitializerContextarrayInitializer()
{
    {
        RETURN | return
    }

    getRuleContext(ArrayInitializerContext.class ,  {

IntegerLiteral | 0 } ) ;  }public ExpressionContextexpression()
{
    {
        RETURN | return
    }

    getRuleContext(ExpressionContext.class ,  {

IntegerLiteral | 0 } ) ;  }public VariableInitializerContext(ParserRuleContext parent, {
    INT | int
}

invokingState ) { {SUPER |super } (
parent , invokingState ) ;  } {AT | @ }Override public {
INT |int }
getRuleIndex()
{
    {
        RETURN | return
    }

    RULE_variableInitializer;
} {

AT | @ }Override public void enterRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterVariableInitializer(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public void exitRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitVariableInitializer(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public {
LT | < }T {
GT | > }Taccept(ParseTreeVisitor
{
    LT | <
} {

QUESTION |? } {
EXTENDS |extends }
T {
GT | > }visitor ) { {IF | if } (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) {RETURN | return } ( (JavaVisitor {
LT | < } {QUESTION |? } {
EXTENDS |extends }
T {
GT | > } )visitor ) .visitVariableInitializer(
{
    THIS | this
} ) ;  {

ELSE | else } {RETURN | return }visitor.visitChildren ( {THIS |this
} ) ;  } }

public {
FINAL |final }
VariableInitializerContextvariableInitializer()
{
    VariableInitializerContext _localctx = new VariableInitializerContext(_ctx, getState());
    enterRule(_localctx, {
        IntegerLiteral | 70
    } , 

    RULE_variableInitializer )
    ;
    try
    {
        setState(
        {
            IntegerLiteral | 555
        } )

        ;
        {
            SWITCH | switch
            }

            (_input.LA(
            {
                IntegerLiteral | 1
            } ) )

            {
                {
                    CASE |  case
                }

                LBRACE
                {
                    COLON |  : 
                }

                enterOuterAlt(_localctx, {
                    IntegerLiteral | 1
                } )

                ;
                {
                    setState(
                    {
                        IntegerLiteral | 553
                    } )

                    ;
                    arrayInitializer();
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                BOOLEAN
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                BYTE
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                CHAR
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                DOUBLE
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                FLOAT
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                INT
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                LONG
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                NEW
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                SHORT
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                SUPER
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                THIS
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                VOID
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                IntegerLiteral
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                FloatingPointLiteral
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                BooleanLiteral
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                CharacterLiteral
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                StringLiteral
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                NullLiteral
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                LPAREN
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                LT
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                BANG
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                TILDE
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                INC
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                DEC
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                ADD
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                SUB
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                Identifier
                {
                    COLON |  : 
                }

                enterOuterAlt(_localctx, {
                    IntegerLiteral | 2
                } )

                ;
                {
                    setState(
                    {
                        IntegerLiteral | 554
                    } )

                    ;
                    expression(
                    {
                        IntegerLiteral | 0
                    } )

                    ;
                }

                {
                    BREAK | break
                }

                ;
                {
                    DEFAULT | default
                }

                {
                    COLON |  : 
                }

                {
                    THROW | throw
                }

                new NoViableAltException(
                {
                THIS | this
                }

                 )
                ;
            }
        }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(
        {
            THIS | this
        } , 

        re )
        ;
        _errHandler.recover(
        {
            THIS | this
        } , 

        re )
        ;
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        {
            RETURN | return
        }

        _localctx;
    }

public static class ArrayInitializerContext
{
    EXTENDS |extends
}

ParserRuleContext {
public List {
LT | < }VariableInitializerContext {
GT | > }variableInitializer()
{
    {
        RETURN | return
    }

    getRuleContexts(VariableInitializerContext.class ) ;  }

public VariableInitializerContextvariableInitializer(
{
    INT | int
}

i ) { {RETURN | return }getRuleContext(VariableInitializerContext.class , 

i ) ;  }public ArrayInitializerContext(ParserRuleContext parent, {
    INT | int
}

invokingState ) { {SUPER |super } (
parent , invokingState ) ;  } {AT | @ }Override public {
INT |int }
getRuleIndex()
{
    {
        RETURN | return
    }

    RULE_arrayInitializer;
} {

AT | @ }Override public void enterRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterArrayInitializer(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public void exitRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitArrayInitializer(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public {
LT | < }T {
GT | > }Taccept(ParseTreeVisitor
{
    LT | <
} {

QUESTION |? } {
EXTENDS |extends }
T {
GT | > }visitor ) { {IF | if } (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) {RETURN | return } ( (JavaVisitor {
LT | < } {QUESTION |? } {
EXTENDS |extends }
T {
GT | > } )visitor ) .visitArrayInitializer(
{
    THIS | this
} ) ;  {

ELSE | else } {RETURN | return }visitor.visitChildren ( {THIS |this
} ) ;  } }

public {
FINAL |final }
ArrayInitializerContextarrayInitializer()
{
    ArrayInitializerContext _localctx = new ArrayInitializerContext(_ctx, getState());
    enterRule(_localctx, {
        IntegerLiteral | 72
    } , 

    RULE_arrayInitializer )
    ;
    {
        INT | int
    }

    _la;
    try
    {
        {
            INT | int
        }

        _alt;
        enterOuterAlt(_localctx, {
            IntegerLiteral | 1
        } )

        ;
        {
            setState(
            {
                IntegerLiteral | 557
            } )

            ;
            match(LBRACE);
            setState(
            {
                IntegerLiteral | 569
            } )

            ;
            _la = _input.LA(
            {
                IntegerLiteral | 1
            } )

            ;
            {
                IF | if
            }

            ((((_la)
            {
                BITAND | &
            }

            {
                TILDE | ~
            }

            {
                IntegerLiteral | 0x3f
            } )

            {
                EQUAL |= =
            }

            {
                IntegerLiteral | 0
            }

            {
                AND | &&
            }

            ((
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            _la )
            {
                BITAND | &
            }

            ((
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            BOOLEAN )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            BYTE )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            CHAR )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            DOUBLE )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            FLOAT )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            INT )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            LONG )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            NEW )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            SHORT )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            SUPER )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            THIS )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            VOID )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            IntegerLiteral )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            FloatingPointLiteral )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            BooleanLiteral )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            CharacterLiteral )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            StringLiteral )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            NullLiteral )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            LPAREN )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            LBRACE ) ) )
            {
                NOTEQUAL | !=
            }

            {
                IntegerLiteral | 0
            } )

            {
                OR || |
            }

            ((((_la
            {
                SUB | -
            }

            {
                IntegerLiteral | 68
            } ) )

            {
                BITAND | &
            }

            {
                TILDE | ~
            }

            {
                IntegerLiteral | 0x3f
            } )

            {
                EQUAL |= =
            }

            {
                IntegerLiteral | 0
            }

            {
                AND | &&
            }

            ((
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            (_la
            {
                SUB | -
            }

            {
                IntegerLiteral | 68
            } ) )

            {
                BITAND | &
            }

            ((
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            (LT
            {
                SUB | -
            }

            {
                IntegerLiteral | 68
            } ) )

            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            (BANG
            {
                SUB | -
            }

            {
                IntegerLiteral | 68
            } ) )

            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            (TILDE
            {
                SUB | -
            }

            {
                IntegerLiteral | 68
            } ) )

            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            (INC
            {
                SUB | -
            }

            {
                IntegerLiteral | 68
            } ) )

            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            (DEC
            {
                SUB | -
            }

            {
                IntegerLiteral | 68
            } ) )

            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            (ADD
            {
                SUB | -
            }

            {
                IntegerLiteral | 68
            } ) )

            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            (SUB
            {
                SUB | -
            }

            {
                IntegerLiteral | 68
            } ) )

            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            (Identifier
            {
                SUB | -
            }

            {
                IntegerLiteral | 68
            } ) ) ) )

            {
                NOTEQUAL | !=
            }

            {
                IntegerLiteral | 0
            } ) )

            {
                {
                    setState(
                    {
                        IntegerLiteral | 558
                    } )

                    ;
                    variableInitializer();
                    setState(
                    {
                        IntegerLiteral | 563
                    } )

                    ;
                    _errHandler.sync(
                    {
                        THIS | this
                    } )

                    ;
                    _alt = getInterpreter().adaptivePredict(_input, {
                        IntegerLiteral | 55
                    } , 

                    _ctx )
                    ;
                    {
                        WHILE | while
                    }

                    (_alt
                    {
                        NOTEQUAL | !=
                    }

                    {
                        IntegerLiteral | 2
                    }

                    {
                        AND | &&
                    }

                    _alt
                    {
                        NOTEQUAL | !=
                    }

                    org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER )
                    {
                        {
                            IF | if
                        }

                        (_alt
                        {
                            EQUAL |= =
                        }

                        {
                            IntegerLiteral | 1
                        } )

                        {
                            {
                                {
                                    setState(
                                    {
                                        IntegerLiteral | 559
                                    } )

                                    ;
                                    match(COMMA);
                                    setState(
                                    {
                                        IntegerLiteral | 560
                                    } )

                                    ;
                                    variableInitializer();
                                }
                            }
                        }

                        setState(
                        {
                            IntegerLiteral | 565
                        } )

                        ;
                        _errHandler.sync(
                        {
                            THIS | this
                        } )

                        ;
                        _alt = getInterpreter().adaptivePredict(_input, {
                            IntegerLiteral | 55
                        } , 

                        _ctx )
                        ;
                    }

                    setState(
                    {
                        IntegerLiteral | 567
                    } )

                    ;
                    _la = _input.LA(
                    {
                        IntegerLiteral | 1
                    } )

                    ;
                    {
                        IF | if
                    }

                    (_la
                    {
                        EQUAL |= =
                    }

                    COMMA )
                    {
                        {
                            setState(
                            {
                                IntegerLiteral | 566
                            } )

                            ;
                            match(COMMA);
                        }
                    }
                }
            }

            setState(
            {
                IntegerLiteral | 571
            } )

            ;
            match(RBRACE);
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(
        {
            THIS | this
        } , 

        re )
        ;
        _errHandler.recover(
        {
            THIS | this
        } , 

        re )
        ;
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        {
            RETURN | return
        }

        _localctx;
    }

public static class EnumConstantNameContext
{
    EXTENDS |extends
}

ParserRuleContext {
public TerminalNodeIdentifier()
{
    {
        RETURN | return
    }

    getToken(JavaParser.Identifier, {
        IntegerLiteral | 0
    } )

    ;
}

public EnumConstantNameContext(ParserRuleContext parent, {
    INT | int
}

invokingState ) { {SUPER |super } (
parent , invokingState ) ;  } {AT | @ }Override public {
INT |int }
getRuleIndex()
{
    {
        RETURN | return
    }

    RULE_enumConstantName;
} {

AT | @ }Override public void enterRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterEnumConstantName(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public void exitRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitEnumConstantName(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public {
LT | < }T {
GT | > }Taccept(ParseTreeVisitor
{
    LT | <
} {

QUESTION |? } {
EXTENDS |extends }
T {
GT | > }visitor ) { {IF | if } (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) {RETURN | return } ( (JavaVisitor {
LT | < } {QUESTION |? } {
EXTENDS |extends }
T {
GT | > } )visitor ) .visitEnumConstantName(
{
    THIS | this
} ) ;  {

ELSE | else } {RETURN | return }visitor.visitChildren ( {THIS |this
} ) ;  } }

public {
FINAL |final }
EnumConstantNameContextenumConstantName()
{
    EnumConstantNameContext _localctx = new EnumConstantNameContext(_ctx, getState());
    enterRule(_localctx, {
        IntegerLiteral | 74
    } , 

    RULE_enumConstantName )
    ;
    try
    {
        enterOuterAlt(_localctx, {
            IntegerLiteral | 1
        } )

        ;
        {
            setState(
            {
                IntegerLiteral | 573
            } )

            ;
            match(Identifier);
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(
        {
            THIS | this
        } , 

        re )
        ;
        _errHandler.recover(
        {
            THIS | this
        } , 

        re )
        ;
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        {
            RETURN | return
        }

        _localctx;
    }

public static class TypeContext
{
    EXTENDS |extends
}

ParserRuleContext {
public PrimitiveTypeContextprimitiveType()
{
    {
        RETURN | return
    }

    getRuleContext(PrimitiveTypeContext.class ,  {

IntegerLiteral | 0 } ) ;  }public ClassOrInterfaceTypeContextclassOrInterfaceType()
{
    {
        RETURN | return
    }

    getRuleContext(ClassOrInterfaceTypeContext.class ,  {

IntegerLiteral | 0 } ) ;  }public TypeContext(ParserRuleContext parent, {
    INT | int
}

invokingState ) { {SUPER |super } (
parent , invokingState ) ;  } {AT | @ }Override public {
INT |int }
getRuleIndex()
{
    {
        RETURN | return
    }

    RULE_type;
} {

AT | @ }Override public void enterRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterType(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public void exitRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitType(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public {
LT | < }T {
GT | > }Taccept(ParseTreeVisitor
{
    LT | <
} {

QUESTION |? } {
EXTENDS |extends }
T {
GT | > }visitor ) { {IF | if } (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) {RETURN | return } ( (JavaVisitor {
LT | < } {QUESTION |? } {
EXTENDS |extends }
T {
GT | > } )visitor ) .visitType(
{
    THIS | this
} ) ;  {

ELSE | else } {RETURN | return }visitor.visitChildren ( {THIS |this
} ) ;  } }

public {
FINAL |final }
TypeContexttype()
{
    TypeContext _localctx = new TypeContext(_ctx, getState());
    enterRule(_localctx, {
        IntegerLiteral | 76
    } , 

    RULE_type )
    ;
    try
    {
        {
            INT | int
        }

        _alt;
        setState(
        {
            IntegerLiteral | 591
        } )

        ;
        {
            SWITCH | switch
            }

            (_input.LA(
            {
                IntegerLiteral | 1
            } ) )

            {
                {
                    CASE |  case
                }

                Identifier
                {
                    COLON |  : 
                }

                enterOuterAlt(_localctx, {
                    IntegerLiteral | 1
                } )

                ;
                {
                    setState(
                    {
                        IntegerLiteral | 575
                    } )

                    ;
                    classOrInterfaceType();
                    setState(
                    {
                        IntegerLiteral | 580
                    } )

                    ;
                    _errHandler.sync(
                    {
                        THIS | this
                    } )

                    ;
                    _alt = getInterpreter().adaptivePredict(_input, {
                        IntegerLiteral | 58
                    } , 

                    _ctx )
                    ;
                    {
                        WHILE | while
                    }

                    (_alt
                    {
                        NOTEQUAL | !=
                    }

                    {
                        IntegerLiteral | 2
                    }

                    {
                        AND | &&
                    }

                    _alt
                    {
                        NOTEQUAL | !=
                    }

                    org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER )
                    {
                        {
                            IF | if
                        }

                        (_alt
                        {
                            EQUAL |= =
                        }

                        {
                            IntegerLiteral | 1
                        } )

                        {
                            {
                                {
                                    setState(
                                    {
                                        IntegerLiteral | 576
                                    } )

                                    ;
                                    match(LBRACK);
                                    setState(
                                    {
                                        IntegerLiteral | 577
                                    } )

                                    ;
                                    match(RBRACK);
                                }
                            }
                        }

                        setState(
                        {
                            IntegerLiteral | 582
                        } )

                        ;
                        _errHandler.sync(
                        {
                            THIS | this
                        } )

                        ;
                        _alt = getInterpreter().adaptivePredict(_input, {
                            IntegerLiteral | 58
                        } , 

                        _ctx )
                        ;
                    }
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                BOOLEAN
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                BYTE
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                CHAR
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                DOUBLE
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                FLOAT
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                INT
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                LONG
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                SHORT
                {
                    COLON |  : 
                }

                enterOuterAlt(_localctx, {
                    IntegerLiteral | 2
                } )

                ;
                {
                    setState(
                    {
                        IntegerLiteral | 583
                    } )

                    ;
                    primitiveType();
                    setState(
                    {
                        IntegerLiteral | 588
                    } )

                    ;
                    _errHandler.sync(
                    {
                        THIS | this
                    } )

                    ;
                    _alt = getInterpreter().adaptivePredict(_input, {
                        IntegerLiteral | 59
                    } , 

                    _ctx )
                    ;
                    {
                        WHILE | while
                    }

                    (_alt
                    {
                        NOTEQUAL | !=
                    }

                    {
                        IntegerLiteral | 2
                    }

                    {
                        AND | &&
                    }

                    _alt
                    {
                        NOTEQUAL | !=
                    }

                    org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER )
                    {
                        {
                            IF | if
                        }

                        (_alt
                        {
                            EQUAL |= =
                        }

                        {
                            IntegerLiteral | 1
                        } )

                        {
                            {
                                {
                                    setState(
                                    {
                                        IntegerLiteral | 584
                                    } )

                                    ;
                                    match(LBRACK);
                                    setState(
                                    {
                                        IntegerLiteral | 585
                                    } )

                                    ;
                                    match(RBRACK);
                                }
                            }
                        }

                        setState(
                        {
                            IntegerLiteral | 590
                        } )

                        ;
                        _errHandler.sync(
                        {
                            THIS | this
                        } )

                        ;
                        _alt = getInterpreter().adaptivePredict(_input, {
                            IntegerLiteral | 59
                        } , 

                        _ctx )
                        ;
                    }
                }

                {
                    BREAK | break
                }

                ;
                {
                    DEFAULT | default
                }

                {
                    COLON |  : 
                }

                {
                    THROW | throw
                }

                new NoViableAltException(
                {
                THIS | this
                }

                 )
                ;
            }
        }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(
        {
            THIS | this
        } , 

        re )
        ;
        _errHandler.recover(
        {
            THIS | this
        } , 

        re )
        ;
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        {
            RETURN | return
        }

        _localctx;
    }

public static class ClassOrInterfaceTypeContext
{
    EXTENDS |extends
}

ParserRuleContext {
public List {
LT | < }TypeArgumentsContext {
GT | > }typeArguments()
{
    {
        RETURN | return
    }

    getRuleContexts(TypeArgumentsContext.class ) ;  }

public List {
LT | < }TerminalNode {
GT | > }Identifier()
{
    {
        RETURN | return
    }

    getTokens(JavaParser.Identifier);
}

public TerminalNodeIdentifier(
{
    INT | int
}

i ) { {RETURN | return }getToken(JavaParser.Identifier, i); }
public TypeArgumentsContexttypeArguments(
{
    INT | int
}

i ) { {RETURN | return }getRuleContext(TypeArgumentsContext.class , 

i ) ;  }public ClassOrInterfaceTypeContext(ParserRuleContext parent, {
    INT | int
}

invokingState ) { {SUPER |super } (
parent , invokingState ) ;  } {AT | @ }Override public {
INT |int }
getRuleIndex()
{
    {
        RETURN | return
    }

    RULE_classOrInterfaceType;
} {

AT | @ }Override public void enterRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterClassOrInterfaceType(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public void exitRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitClassOrInterfaceType(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public {
LT | < }T {
GT | > }Taccept(ParseTreeVisitor
{
    LT | <
} {

QUESTION |? } {
EXTENDS |extends }
T {
GT | > }visitor ) { {IF | if } (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) {RETURN | return } ( (JavaVisitor {
LT | < } {QUESTION |? } {
EXTENDS |extends }
T {
GT | > } )visitor ) .visitClassOrInterfaceType(
{
    THIS | this
} ) ;  {

ELSE | else } {RETURN | return }visitor.visitChildren ( {THIS |this
} ) ;  } }

public {
FINAL |final }
ClassOrInterfaceTypeContextclassOrInterfaceType()
{
    ClassOrInterfaceTypeContext _localctx = new ClassOrInterfaceTypeContext(_ctx, getState());
    enterRule(_localctx, {
        IntegerLiteral | 78
    } , 

    RULE_classOrInterfaceType )
    ;
    try
    {
        {
            INT | int
        }

        _alt;
        enterOuterAlt(_localctx, {
            IntegerLiteral | 1
        } )

        ;
        {
            setState(
            {
                IntegerLiteral | 593
            } )

            ;
            match(Identifier);
            setState(
            {
                IntegerLiteral | 595
            } )

            ;
            {
                SWITCH | switch
                }

                (getInterpreter().adaptivePredict(_input, {
                    IntegerLiteral | 61
                } , 

                _ctx ) )
                {
                    {
                        CASE |  case
                    }

                    {
                        IntegerLiteral | 1
                    }

                    {
                        COLON |  : 
                    }

                    {
                        setState(
                        {
                            IntegerLiteral | 594
                        } )

                        ;
                        typeArguments();
                    }

                    {
                        BREAK | break
                    }

                    ;
                }

                setState(
                {
                    IntegerLiteral | 604
                } )

                ;
                _errHandler.sync(
                {
                    THIS | this
                } )

                ;
                _alt = getInterpreter().adaptivePredict(_input, {
                    IntegerLiteral | 63
                } , 

                _ctx )
                ;
                {
                    WHILE | while
                }

                (_alt
                {
                    NOTEQUAL | !=
                }

                {
                    IntegerLiteral | 2
                }

                {
                    AND | &&
                }

                _alt
                {
                    NOTEQUAL | !=
                }

                org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER )
                {
                    {
                        IF | if
                    }

                    (_alt
                    {
                        EQUAL |= =
                    }

                    {
                        IntegerLiteral | 1
                    } )

                    {
                        {
                            {
                                setState(
                                {
                                    IntegerLiteral | 597
                                } )

                                ;
                                match(DOT);
                                setState(
                                {
                                    IntegerLiteral | 598
                                } )

                                ;
                                match(Identifier);
                                setState(
                                {
                                    IntegerLiteral | 600
                                } )

                                ;
                                {
                                    SWITCH | switch
                                    }

                                    (getInterpreter().adaptivePredict(_input, {
                                        IntegerLiteral | 62
                                    } , 

                                    _ctx ) )
                                    {
                                        {
                                            CASE |  case
                                        }

                                        {
                                            IntegerLiteral | 1
                                        }

                                        {
                                            COLON |  : 
                                        }

                                        {
                                            setState(
                                            {
                                                IntegerLiteral | 599
                                            } )

                                            ;
                                            typeArguments();
                                        }

                                        {
                                            BREAK | break
                                        }

                                        ;
                                    }
                                }
                            }
                        }

                        setState(
                        {
                            IntegerLiteral | 606
                        } )

                        ;
                        _errHandler.sync(
                        {
                            THIS | this
                        } )

                        ;
                        _alt = getInterpreter().adaptivePredict(_input, {
                            IntegerLiteral | 63
                        } , 

                        _ctx )
                        ;
                    }
                }
            }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(
        {
            THIS | this
        } , 

        re )
        ;
        _errHandler.recover(
        {
            THIS | this
        } , 

        re )
        ;
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        {
            RETURN | return
        }

        _localctx;
    }

public static class PrimitiveTypeContext
{
    EXTENDS |extends
}

ParserRuleContext {
public PrimitiveTypeContext(ParserRuleContext parent, {
    INT | int
}

invokingState ) { {SUPER |super } (
parent , invokingState ) ;  } {AT | @ }Override public {
INT |int }
getRuleIndex()
{
    {
        RETURN | return
    }

    RULE_primitiveType;
} {

AT | @ }Override public void enterRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterPrimitiveType(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public void exitRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitPrimitiveType(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public {
LT | < }T {
GT | > }Taccept(ParseTreeVisitor
{
    LT | <
} {

QUESTION |? } {
EXTENDS |extends }
T {
GT | > }visitor ) { {IF | if } (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) {RETURN | return } ( (JavaVisitor {
LT | < } {QUESTION |? } {
EXTENDS |extends }
T {
GT | > } )visitor ) .visitPrimitiveType(
{
    THIS | this
} ) ;  {

ELSE | else } {RETURN | return }visitor.visitChildren ( {THIS |this
} ) ;  } }

public {
FINAL |final }
PrimitiveTypeContextprimitiveType()
{
    PrimitiveTypeContext _localctx = new PrimitiveTypeContext(_ctx, getState());
    enterRule(_localctx, {
        IntegerLiteral | 80
    } , 

    RULE_primitiveType )
    ;
    {
        INT | int
    }

    _la;
    try
    {
        enterOuterAlt(_localctx, {
            IntegerLiteral | 1
        } )

        ;
        {
            setState(
            {
                IntegerLiteral | 607
            } )

            ;
            _la = _input.LA(
            {
                IntegerLiteral | 1
            } )

            ;
            {
                IF | if
            }

            (
            {
                BANG | !
            }

            ((((_la)
            {
                BITAND | &
            }

            {
                TILDE | ~
            }

            {
                IntegerLiteral | 0x3f
            } )

            {
                EQUAL |= =
            }

            {
                IntegerLiteral | 0
            }

            {
                AND | &&
            }

            ((
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            _la )
            {
                BITAND | &
            }

            ((
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            BOOLEAN )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            BYTE )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            CHAR )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            DOUBLE )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            FLOAT )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            INT )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            LONG )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            SHORT ) ) )
            {
                NOTEQUAL | !=
            }

            {
                IntegerLiteral | 0
            } ) ) )

            {
                _errHandler.recoverInline(
                {
                    THIS | this
                } )

                ;
            }

            consume();
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(
        {
            THIS | this
        } , 

        re )
        ;
        _errHandler.recover(
        {
            THIS | this
        } , 

        re )
        ;
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        {
            RETURN | return
        }

        _localctx;
    }

public static class TypeArgumentsContext
{
    EXTENDS |extends
}

ParserRuleContext {
public List {
LT | < }TypeArgumentContext {
GT | > }typeArgument()
{
    {
        RETURN | return
    }

    getRuleContexts(TypeArgumentContext.class ) ;  }

public TypeArgumentContexttypeArgument(
{
    INT | int
}

i ) { {RETURN | return }getRuleContext(TypeArgumentContext.class , 

i ) ;  }public TypeArgumentsContext(ParserRuleContext parent, {
    INT | int
}

invokingState ) { {SUPER |super } (
parent , invokingState ) ;  } {AT | @ }Override public {
INT |int }
getRuleIndex()
{
    {
        RETURN | return
    }

    RULE_typeArguments;
} {

AT | @ }Override public void enterRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterTypeArguments(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public void exitRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitTypeArguments(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public {
LT | < }T {
GT | > }Taccept(ParseTreeVisitor
{
    LT | <
} {

QUESTION |? } {
EXTENDS |extends }
T {
GT | > }visitor ) { {IF | if } (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) {RETURN | return } ( (JavaVisitor {
LT | < } {QUESTION |? } {
EXTENDS |extends }
T {
GT | > } )visitor ) .visitTypeArguments(
{
    THIS | this
} ) ;  {

ELSE | else } {RETURN | return }visitor.visitChildren ( {THIS |this
} ) ;  } }

public {
FINAL |final }
TypeArgumentsContexttypeArguments()
{
    TypeArgumentsContext _localctx = new TypeArgumentsContext(_ctx, getState());
    enterRule(_localctx, {
        IntegerLiteral | 82
    } , 

    RULE_typeArguments )
    ;
    {
        INT | int
    }

    _la;
    try
    {
        enterOuterAlt(_localctx, {
            IntegerLiteral | 1
        } )

        ;
        {
            setState(
            {
                IntegerLiteral | 609
            } )

            ;
            match(LT);
            setState(
            {
                IntegerLiteral | 610
            } )

            ;
            typeArgument();
            setState(
            {
                IntegerLiteral | 615
            } )

            ;
            _errHandler.sync(
            {
                THIS | this
            } )

            ;
            _la = _input.LA(
            {
                IntegerLiteral | 1
            } )

            ;
            {
                WHILE | while
            }

            (_la
            {
                EQUAL |= =
            }

            COMMA )
            {
                {
                    {
                        setState(
                        {
                            IntegerLiteral | 611
                        } )

                        ;
                        match(COMMA);
                        setState(
                        {
                            IntegerLiteral | 612
                        } )

                        ;
                        typeArgument();
                    }
                }

                setState(
                {
                    IntegerLiteral | 617
                } )

                ;
                _errHandler.sync(
                {
                    THIS | this
                } )

                ;
                _la = _input.LA(
                {
                    IntegerLiteral | 1
                } )

                ;
            }

            setState(
            {
                IntegerLiteral | 618
            } )

            ;
            match(GT);
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(
        {
            THIS | this
        } , 

        re )
        ;
        _errHandler.recover(
        {
            THIS | this
        } , 

        re )
        ;
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        {
            RETURN | return
        }

        _localctx;
    }

public static class TypeArgumentContext
{
    EXTENDS |extends
}

ParserRuleContext {
public TypeContexttype()
{
    {
        RETURN | return
    }

    getRuleContext(TypeContext.class ,  {

IntegerLiteral | 0 } ) ;  }public TypeArgumentContext(ParserRuleContext parent, {
    INT | int
}

invokingState ) { {SUPER |super } (
parent , invokingState ) ;  } {AT | @ }Override public {
INT |int }
getRuleIndex()
{
    {
        RETURN | return
    }

    RULE_typeArgument;
} {

AT | @ }Override public void enterRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterTypeArgument(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public void exitRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitTypeArgument(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public {
LT | < }T {
GT | > }Taccept(ParseTreeVisitor
{
    LT | <
} {

QUESTION |? } {
EXTENDS |extends }
T {
GT | > }visitor ) { {IF | if } (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) {RETURN | return } ( (JavaVisitor {
LT | < } {QUESTION |? } {
EXTENDS |extends }
T {
GT | > } )visitor ) .visitTypeArgument(
{
    THIS | this
} ) ;  {

ELSE | else } {RETURN | return }visitor.visitChildren ( {THIS |this
} ) ;  } }

public {
FINAL |final }
TypeArgumentContexttypeArgument()
{
    TypeArgumentContext _localctx = new TypeArgumentContext(_ctx, getState());
    enterRule(_localctx, {
        IntegerLiteral | 84
    } , 

    RULE_typeArgument )
    ;
    {
        INT | int
    }

    _la;
    try
    {
        setState(
        {
            IntegerLiteral | 626
        } )

        ;
        {
            SWITCH | switch
            }

            (_input.LA(
            {
                IntegerLiteral | 1
            } ) )

            {
                {
                    CASE |  case
                }

                BOOLEAN
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                BYTE
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                CHAR
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                DOUBLE
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                FLOAT
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                INT
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                LONG
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                SHORT
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                Identifier
                {
                    COLON |  : 
                }

                enterOuterAlt(_localctx, {
                    IntegerLiteral | 1
                } )

                ;
                {
                    setState(
                    {
                        IntegerLiteral | 620
                    } )

                    ;
                    type();
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                QUESTION
                {
                    COLON |  : 
                }

                enterOuterAlt(_localctx, {
                    IntegerLiteral | 2
                } )

                ;
                {
                    setState(
                    {
                        IntegerLiteral | 621
                    } )

                    ;
                    match(QUESTION);
                    setState(
                    {
                        IntegerLiteral | 624
                    } )

                    ;
                    _la = _input.LA(
                    {
                        IntegerLiteral | 1
                    } )

                    ;
                    {
                        IF | if
                    }

                    (_la
                    {
                        EQUAL |= =
                    }

                    EXTENDS
                    {
                        OR || |
                    }

                    _la
                    {
                        EQUAL |= =
                    }

                    SUPER )
                    {
                        {
                            setState(
                            {
                                IntegerLiteral | 622
                            } )

                            ;
                            _la = _input.LA(
                            {
                                IntegerLiteral | 1
                            } )

                            ;
                            {
                                IF | if
                            }

                            (
                            {
                                BANG | !
                            }

                            (_la
                            {
                                EQUAL |= =
                            }

                            EXTENDS
                            {
                                OR || |
                            }

                            _la
                            {
                                EQUAL |= =
                            }

                            SUPER ) )
                            {
                                _errHandler.recoverInline(
                                {
                                    THIS | this
                                } )

                                ;
                            }

                            consume();
                            setState(
                            {
                                IntegerLiteral | 623
                            } )

                            ;
                            type();
                        }
                    }
                }

                {
                    BREAK | break
                }

                ;
                {
                    DEFAULT | default
                }

                {
                    COLON |  : 
                }

                {
                    THROW | throw
                }

                new NoViableAltException(
                {
                THIS | this
                }

                 )
                ;
            }
        }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(
        {
            THIS | this
        } , 

        re )
        ;
        _errHandler.recover(
        {
            THIS | this
        } , 

        re )
        ;
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        {
            RETURN | return
        }

        _localctx;
    }

public static class QualifiedNameListContext
{
    EXTENDS |extends
}

ParserRuleContext {
public List {
LT | < }QualifiedNameContext {
GT | > }qualifiedName()
{
    {
        RETURN | return
    }

    getRuleContexts(QualifiedNameContext.class ) ;  }

public QualifiedNameContextqualifiedName(
{
    INT | int
}

i ) { {RETURN | return }getRuleContext(QualifiedNameContext.class , 

i ) ;  }public QualifiedNameListContext(ParserRuleContext parent, {
    INT | int
}

invokingState ) { {SUPER |super } (
parent , invokingState ) ;  } {AT | @ }Override public {
INT |int }
getRuleIndex()
{
    {
        RETURN | return
    }

    RULE_qualifiedNameList;
} {

AT | @ }Override public void enterRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterQualifiedNameList(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public void exitRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitQualifiedNameList(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public {
LT | < }T {
GT | > }Taccept(ParseTreeVisitor
{
    LT | <
} {

QUESTION |? } {
EXTENDS |extends }
T {
GT | > }visitor ) { {IF | if } (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) {RETURN | return } ( (JavaVisitor {
LT | < } {QUESTION |? } {
EXTENDS |extends }
T {
GT | > } )visitor ) .visitQualifiedNameList(
{
    THIS | this
} ) ;  {

ELSE | else } {RETURN | return }visitor.visitChildren ( {THIS |this
} ) ;  } }

public {
FINAL |final }
QualifiedNameListContextqualifiedNameList()
{
    QualifiedNameListContext _localctx = new QualifiedNameListContext(_ctx, getState());
    enterRule(_localctx, {
        IntegerLiteral | 86
    } , 

    RULE_qualifiedNameList )
    ;
    {
        INT | int
    }

    _la;
    try
    {
        enterOuterAlt(_localctx, {
            IntegerLiteral | 1
        } )

        ;
        {
            setState(
            {
                IntegerLiteral | 628
            } )

            ;
            qualifiedName();
            setState(
            {
                IntegerLiteral | 633
            } )

            ;
            _errHandler.sync(
            {
                THIS | this
            } )

            ;
            _la = _input.LA(
            {
                IntegerLiteral | 1
            } )

            ;
            {
                WHILE | while
            }

            (_la
            {
                EQUAL |= =
            }

            COMMA )
            {
                {
                    {
                        setState(
                        {
                            IntegerLiteral | 629
                        } )

                        ;
                        match(COMMA);
                        setState(
                        {
                            IntegerLiteral | 630
                        } )

                        ;
                        qualifiedName();
                    }
                }

                setState(
                {
                    IntegerLiteral | 635
                } )

                ;
                _errHandler.sync(
                {
                    THIS | this
                } )

                ;
                _la = _input.LA(
                {
                    IntegerLiteral | 1
                } )

                ;
            }
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(
        {
            THIS | this
        } , 

        re )
        ;
        _errHandler.recover(
        {
            THIS | this
        } , 

        re )
        ;
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        {
            RETURN | return
        }

        _localctx;
    }

public static class FormalParametersContext
{
    EXTENDS |extends
}

ParserRuleContext {
public FormalParameterListContextformalParameterList()
{
    {
        RETURN | return
    }

    getRuleContext(FormalParameterListContext.class ,  {

IntegerLiteral | 0 } ) ;  }public FormalParametersContext(ParserRuleContext parent, {
    INT | int
}

invokingState ) { {SUPER |super } (
parent , invokingState ) ;  } {AT | @ }Override public {
INT |int }
getRuleIndex()
{
    {
        RETURN | return
    }

    RULE_formalParameters;
} {

AT | @ }Override public void enterRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterFormalParameters(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public void exitRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitFormalParameters(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public {
LT | < }T {
GT | > }Taccept(ParseTreeVisitor
{
    LT | <
} {

QUESTION |? } {
EXTENDS |extends }
T {
GT | > }visitor ) { {IF | if } (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) {RETURN | return } ( (JavaVisitor {
LT | < } {QUESTION |? } {
EXTENDS |extends }
T {
GT | > } )visitor ) .visitFormalParameters(
{
    THIS | this
} ) ;  {

ELSE | else } {RETURN | return }visitor.visitChildren ( {THIS |this
} ) ;  } }

public {
FINAL |final }
FormalParametersContextformalParameters()
{
    FormalParametersContext _localctx = new FormalParametersContext(_ctx, getState());
    enterRule(_localctx, {
        IntegerLiteral | 88
    } , 

    RULE_formalParameters )
    ;
    {
        INT | int
    }

    _la;
    try
    {
        enterOuterAlt(_localctx, {
            IntegerLiteral | 1
        } )

        ;
        {
            setState(
            {
                IntegerLiteral | 636
            } )

            ;
            match(LPAREN);
            setState(
            {
                IntegerLiteral | 638
            } )

            ;
            _la = _input.LA(
            {
                IntegerLiteral | 1
            } )

            ;
            {
                IF | if
            }

            ((((_la)
            {
                BITAND | &
            }

            {
                TILDE | ~
            }

            {
                IntegerLiteral | 0x3f
            } )

            {
                EQUAL |= =
            }

            {
                IntegerLiteral | 0
            }

            {
                AND | &&
            }

            ((
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            _la )
            {
                BITAND | &
            }

            ((
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            BOOLEAN )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            BYTE )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            CHAR )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            DOUBLE )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            FINAL )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            FLOAT )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            INT )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            LONG )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            SHORT ) ) )
            {
                NOTEQUAL | !=
            }

            {
                IntegerLiteral | 0
            } )

            {
                OR || |
            }

            _la
            {
                EQUAL |= =
            }

            Identifier
            {
                OR || |
            }

            _la
            {
                EQUAL |= =
            }

            AT )
            {
                {
                    setState(
                    {
                        IntegerLiteral | 637
                    } )

                    ;
                    formalParameterList();
                }
            }

            setState(
            {
                IntegerLiteral | 640
            } )

            ;
            match(RPAREN);
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(
        {
            THIS | this
        } , 

        re )
        ;
        _errHandler.recover(
        {
            THIS | this
        } , 

        re )
        ;
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        {
            RETURN | return
        }

        _localctx;
    }

public static class FormalParameterListContext
{
    EXTENDS |extends
}

ParserRuleContext {
public List {
LT | < }FormalParameterContext {
GT | > }formalParameter()
{
    {
        RETURN | return
    }

    getRuleContexts(FormalParameterContext.class ) ;  }

public LastFormalParameterContextlastFormalParameter()
{
    {
        RETURN | return
    }

    getRuleContext(LastFormalParameterContext.class ,  {

IntegerLiteral | 0 } ) ;  }public FormalParameterContextformalParameter(
{
    INT | int
}

i ) { {RETURN | return }getRuleContext(FormalParameterContext.class , 

i ) ;  }public FormalParameterListContext(ParserRuleContext parent, {
    INT | int
}

invokingState ) { {SUPER |super } (
parent , invokingState ) ;  } {AT | @ }Override public {
INT |int }
getRuleIndex()
{
    {
        RETURN | return
    }

    RULE_formalParameterList;
} {

AT | @ }Override public void enterRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterFormalParameterList(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public void exitRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitFormalParameterList(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public {
LT | < }T {
GT | > }Taccept(ParseTreeVisitor
{
    LT | <
} {

QUESTION |? } {
EXTENDS |extends }
T {
GT | > }visitor ) { {IF | if } (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) {RETURN | return } ( (JavaVisitor {
LT | < } {QUESTION |? } {
EXTENDS |extends }
T {
GT | > } )visitor ) .visitFormalParameterList(
{
    THIS | this
} ) ;  {

ELSE | else } {RETURN | return }visitor.visitChildren ( {THIS |this
} ) ;  } }

public {
FINAL |final }
FormalParameterListContextformalParameterList()
{
    FormalParameterListContext _localctx = new FormalParameterListContext(_ctx, getState());
    enterRule(_localctx, {
        IntegerLiteral | 90
    } , 

    RULE_formalParameterList )
    ;
    {
        INT | int
    }

    _la;
    try
    {
        {
            INT | int
        }

        _alt;
        setState(
        {
            IntegerLiteral | 655
        } )

        ;
        {
            SWITCH | switch
            }

            (getInterpreter().adaptivePredict(_input, {
                IntegerLiteral | 71
            } , 

            _ctx ) )
            {
                {
                    CASE |  case
                }

                {
                    IntegerLiteral | 1
                }

                {
                    COLON |  : 
                }

                enterOuterAlt(_localctx, {
                    IntegerLiteral | 1
                } )

                ;
                {
                    setState(
                    {
                        IntegerLiteral | 642
                    } )

                    ;
                    formalParameter();
                    setState(
                    {
                        IntegerLiteral | 647
                    } )

                    ;
                    _errHandler.sync(
                    {
                        THIS | this
                    } )

                    ;
                    _alt = getInterpreter().adaptivePredict(_input, {
                        IntegerLiteral | 69
                    } , 

                    _ctx )
                    ;
                    {
                        WHILE | while
                    }

                    (_alt
                    {
                        NOTEQUAL | !=
                    }

                    {
                        IntegerLiteral | 2
                    }

                    {
                        AND | &&
                    }

                    _alt
                    {
                        NOTEQUAL | !=
                    }

                    org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER )
                    {
                        {
                            IF | if
                        }

                        (_alt
                        {
                            EQUAL |= =
                        }

                        {
                            IntegerLiteral | 1
                        } )

                        {
                            {
                                {
                                    setState(
                                    {
                                        IntegerLiteral | 643
                                    } )

                                    ;
                                    match(COMMA);
                                    setState(
                                    {
                                        IntegerLiteral | 644
                                    } )

                                    ;
                                    formalParameter();
                                }
                            }
                        }

                        setState(
                        {
                            IntegerLiteral | 649
                        } )

                        ;
                        _errHandler.sync(
                        {
                            THIS | this
                        } )

                        ;
                        _alt = getInterpreter().adaptivePredict(_input, {
                            IntegerLiteral | 69
                        } , 

                        _ctx )
                        ;
                    }

                    setState(
                    {
                        IntegerLiteral | 652
                    } )

                    ;
                    _la = _input.LA(
                    {
                        IntegerLiteral | 1
                    } )

                    ;
                    {
                        IF | if
                    }

                    (_la
                    {
                        EQUAL |= =
                    }

                    COMMA )
                    {
                        {
                            setState(
                            {
                                IntegerLiteral | 650
                            } )

                            ;
                            match(COMMA);
                            setState(
                            {
                                IntegerLiteral | 651
                            } )

                            ;
                            lastFormalParameter();
                        }
                    }
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                {
                    IntegerLiteral | 2
                }

                {
                    COLON |  : 
                }

                enterOuterAlt(_localctx, {
                    IntegerLiteral | 2
                } )

                ;
                {
                    setState(
                    {
                        IntegerLiteral | 654
                    } )

                    ;
                    lastFormalParameter();
                }

                {
                    BREAK | break
                }

                ;
            }
        }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(
        {
            THIS | this
        } , 

        re )
        ;
        _errHandler.recover(
        {
            THIS | this
        } , 

        re )
        ;
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        {
            RETURN | return
        }

        _localctx;
    }

public static class FormalParameterContext
{
    EXTENDS |extends
}

ParserRuleContext {
public VariableModifierContextvariableModifier(
{
    INT | int
}

i ) { {RETURN | return }getRuleContext(VariableModifierContext.class , 

i ) ;  }public List {
LT | < }VariableModifierContext {
GT | > }variableModifier()
{
    {
        RETURN | return
    }

    getRuleContexts(VariableModifierContext.class ) ;  }

public VariableDeclaratorIdContextvariableDeclaratorId()
{
    {
        RETURN | return
    }

    getRuleContext(VariableDeclaratorIdContext.class ,  {

IntegerLiteral | 0 } ) ;  }public TypeContexttype()
{
    {
        RETURN | return
    }

    getRuleContext(TypeContext.class ,  {

IntegerLiteral | 0 } ) ;  }public FormalParameterContext(ParserRuleContext parent, {
    INT | int
}

invokingState ) { {SUPER |super } (
parent , invokingState ) ;  } {AT | @ }Override public {
INT |int }
getRuleIndex()
{
    {
        RETURN | return
    }

    RULE_formalParameter;
} {

AT | @ }Override public void enterRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterFormalParameter(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public void exitRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitFormalParameter(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public {
LT | < }T {
GT | > }Taccept(ParseTreeVisitor
{
    LT | <
} {

QUESTION |? } {
EXTENDS |extends }
T {
GT | > }visitor ) { {IF | if } (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) {RETURN | return } ( (JavaVisitor {
LT | < } {QUESTION |? } {
EXTENDS |extends }
T {
GT | > } )visitor ) .visitFormalParameter(
{
    THIS | this
} ) ;  {

ELSE | else } {RETURN | return }visitor.visitChildren ( {THIS |this
} ) ;  } }

public {
FINAL |final }
FormalParameterContextformalParameter()
{
    FormalParameterContext _localctx = new FormalParameterContext(_ctx, getState());
    enterRule(_localctx, {
        IntegerLiteral | 92
    } , 

    RULE_formalParameter )
    ;
    {
        INT | int
    }

    _la;
    try
    {
        enterOuterAlt(_localctx, {
            IntegerLiteral | 1
        } )

        ;
        {
            setState(
            {
                IntegerLiteral | 660
            } )

            ;
            _errHandler.sync(
            {
                THIS | this
            } )

            ;
            _la = _input.LA(
            {
                IntegerLiteral | 1
            } )

            ;
            {
                WHILE | while
            }

            (_la
            {
                EQUAL |= =
            }

            FINAL
            {
                OR || |
            }

            _la
            {
                EQUAL |= =
            }

            AT )
            {
                {
                    {
                        setState(
                        {
                            IntegerLiteral | 657
                        } )

                        ;
                        variableModifier();
                    }
                }

                setState(
                {
                    IntegerLiteral | 662
                } )

                ;
                _errHandler.sync(
                {
                    THIS | this
                } )

                ;
                _la = _input.LA(
                {
                    IntegerLiteral | 1
                } )

                ;
            }

            setState(
            {
                IntegerLiteral | 663
            } )

            ;
            type();
            setState(
            {
                IntegerLiteral | 664
            } )

            ;
            variableDeclaratorId();
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(
        {
            THIS | this
        } , 

        re )
        ;
        _errHandler.recover(
        {
            THIS | this
        } , 

        re )
        ;
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        {
            RETURN | return
        }

        _localctx;
    }

public static class LastFormalParameterContext
{
    EXTENDS |extends
}

ParserRuleContext {
public VariableModifierContextvariableModifier(
{
    INT | int
}

i ) { {RETURN | return }getRuleContext(VariableModifierContext.class , 

i ) ;  }public List {
LT | < }VariableModifierContext {
GT | > }variableModifier()
{
    {
        RETURN | return
    }

    getRuleContexts(VariableModifierContext.class ) ;  }

public VariableDeclaratorIdContextvariableDeclaratorId()
{
    {
        RETURN | return
    }

    getRuleContext(VariableDeclaratorIdContext.class ,  {

IntegerLiteral | 0 } ) ;  }public TypeContexttype()
{
    {
        RETURN | return
    }

    getRuleContext(TypeContext.class ,  {

IntegerLiteral | 0 } ) ;  }public LastFormalParameterContext(ParserRuleContext parent, {
    INT | int
}

invokingState ) { {SUPER |super } (
parent , invokingState ) ;  } {AT | @ }Override public {
INT |int }
getRuleIndex()
{
    {
        RETURN | return
    }

    RULE_lastFormalParameter;
} {

AT | @ }Override public void enterRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterLastFormalParameter(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public void exitRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitLastFormalParameter(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public {
LT | < }T {
GT | > }Taccept(ParseTreeVisitor
{
    LT | <
} {

QUESTION |? } {
EXTENDS |extends }
T {
GT | > }visitor ) { {IF | if } (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) {RETURN | return } ( (JavaVisitor {
LT | < } {QUESTION |? } {
EXTENDS |extends }
T {
GT | > } )visitor ) .visitLastFormalParameter(
{
    THIS | this
} ) ;  {

ELSE | else } {RETURN | return }visitor.visitChildren ( {THIS |this
} ) ;  } }

public {
FINAL |final }
LastFormalParameterContextlastFormalParameter()
{
    LastFormalParameterContext _localctx = new LastFormalParameterContext(_ctx, getState());
    enterRule(_localctx, {
        IntegerLiteral | 94
    } , 

    RULE_lastFormalParameter )
    ;
    {
        INT | int
    }

    _la;
    try
    {
        enterOuterAlt(_localctx, {
            IntegerLiteral | 1
        } )

        ;
        {
            setState(
            {
                IntegerLiteral | 669
            } )

            ;
            _errHandler.sync(
            {
                THIS | this
            } )

            ;
            _la = _input.LA(
            {
                IntegerLiteral | 1
            } )

            ;
            {
                WHILE | while
            }

            (_la
            {
                EQUAL |= =
            }

            FINAL
            {
                OR || |
            }

            _la
            {
                EQUAL |= =
            }

            AT )
            {
                {
                    {
                        setState(
                        {
                            IntegerLiteral | 666
                        } )

                        ;
                        variableModifier();
                    }
                }

                setState(
                {
                    IntegerLiteral | 671
                } )

                ;
                _errHandler.sync(
                {
                    THIS | this
                } )

                ;
                _la = _input.LA(
                {
                    IntegerLiteral | 1
                } )

                ;
            }

            setState(
            {
                IntegerLiteral | 672
            } )

            ;
            type();
            setState(
            {
                IntegerLiteral | 673
            } )

            ;
            match(ELLIPSIS);
            setState(
            {
                IntegerLiteral | 674
            } )

            ;
            variableDeclaratorId();
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(
        {
            THIS | this
        } , 

        re )
        ;
        _errHandler.recover(
        {
            THIS | this
        } , 

        re )
        ;
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        {
            RETURN | return
        }

        _localctx;
    }

public static class MethodBodyContext
{
    EXTENDS |extends
}

ParserRuleContext {
public BlockContextblock()
{
    {
        RETURN | return
    }

    getRuleContext(BlockContext.class ,  {

IntegerLiteral | 0 } ) ;  }public MethodBodyContext(ParserRuleContext parent, {
    INT | int
}

invokingState ) { {SUPER |super } (
parent , invokingState ) ;  } {AT | @ }Override public {
INT |int }
getRuleIndex()
{
    {
        RETURN | return
    }

    RULE_methodBody;
} {

AT | @ }Override public void enterRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterMethodBody(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public void exitRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitMethodBody(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public {
LT | < }T {
GT | > }Taccept(ParseTreeVisitor
{
    LT | <
} {

QUESTION |? } {
EXTENDS |extends }
T {
GT | > }visitor ) { {IF | if } (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) {RETURN | return } ( (JavaVisitor {
LT | < } {QUESTION |? } {
EXTENDS |extends }
T {
GT | > } )visitor ) .visitMethodBody(
{
    THIS | this
} ) ;  {

ELSE | else } {RETURN | return }visitor.visitChildren ( {THIS |this
} ) ;  } }

public {
FINAL |final }
MethodBodyContextmethodBody()
{
    MethodBodyContext _localctx = new MethodBodyContext(_ctx, getState());
    enterRule(_localctx, {
        IntegerLiteral | 96
    } , 

    RULE_methodBody )
    ;
    try
    {
        enterOuterAlt(_localctx, {
            IntegerLiteral | 1
        } )

        ;
        {
            setState(
            {
                IntegerLiteral | 676
            } )

            ;
            block();
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(
        {
            THIS | this
        } , 

        re )
        ;
        _errHandler.recover(
        {
            THIS | this
        } , 

        re )
        ;
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        {
            RETURN | return
        }

        _localctx;
    }

public static class ConstructorBodyContext
{
    EXTENDS |extends
}

ParserRuleContext {
public BlockContextblock()
{
    {
        RETURN | return
    }

    getRuleContext(BlockContext.class ,  {

IntegerLiteral | 0 } ) ;  }public ConstructorBodyContext(ParserRuleContext parent, {
    INT | int
}

invokingState ) { {SUPER |super } (
parent , invokingState ) ;  } {AT | @ }Override public {
INT |int }
getRuleIndex()
{
    {
        RETURN | return
    }

    RULE_constructorBody;
} {

AT | @ }Override public void enterRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterConstructorBody(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public void exitRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitConstructorBody(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public {
LT | < }T {
GT | > }Taccept(ParseTreeVisitor
{
    LT | <
} {

QUESTION |? } {
EXTENDS |extends }
T {
GT | > }visitor ) { {IF | if } (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) {RETURN | return } ( (JavaVisitor {
LT | < } {QUESTION |? } {
EXTENDS |extends }
T {
GT | > } )visitor ) .visitConstructorBody(
{
    THIS | this
} ) ;  {

ELSE | else } {RETURN | return }visitor.visitChildren ( {THIS |this
} ) ;  } }

public {
FINAL |final }
ConstructorBodyContextconstructorBody()
{
    ConstructorBodyContext _localctx = new ConstructorBodyContext(_ctx, getState());
    enterRule(_localctx, {
        IntegerLiteral | 98
    } , 

    RULE_constructorBody )
    ;
    try
    {
        enterOuterAlt(_localctx, {
            IntegerLiteral | 1
        } )

        ;
        {
            setState(
            {
                IntegerLiteral | 678
            } )

            ;
            block();
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(
        {
            THIS | this
        } , 

        re )
        ;
        _errHandler.recover(
        {
            THIS | this
        } , 

        re )
        ;
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        {
            RETURN | return
        }

        _localctx;
    }

public static class QualifiedNameContext
{
    EXTENDS |extends
}

ParserRuleContext {
public List {
LT | < }TerminalNode {
GT | > }Identifier()
{
    {
        RETURN | return
    }

    getTokens(JavaParser.Identifier);
}

public TerminalNodeIdentifier(
{
    INT | int
}

i ) { {RETURN | return }getToken(JavaParser.Identifier, i); }
public QualifiedNameContext(ParserRuleContext parent, {
    INT | int
}

invokingState ) { {SUPER |super } (
parent , invokingState ) ;  } {AT | @ }Override public {
INT |int }
getRuleIndex()
{
    {
        RETURN | return
    }

    RULE_qualifiedName;
} {

AT | @ }Override public void enterRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterQualifiedName(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public void exitRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitQualifiedName(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public {
LT | < }T {
GT | > }Taccept(ParseTreeVisitor
{
    LT | <
} {

QUESTION |? } {
EXTENDS |extends }
T {
GT | > }visitor ) { {IF | if } (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) {RETURN | return } ( (JavaVisitor {
LT | < } {QUESTION |? } {
EXTENDS |extends }
T {
GT | > } )visitor ) .visitQualifiedName(
{
    THIS | this
} ) ;  {

ELSE | else } {RETURN | return }visitor.visitChildren ( {THIS |this
} ) ;  } }

public {
FINAL |final }
QualifiedNameContextqualifiedName()
{
    QualifiedNameContext _localctx = new QualifiedNameContext(_ctx, getState());
    enterRule(_localctx, {
        IntegerLiteral | 100
    } , 

    RULE_qualifiedName )
    ;
    try
    {
        {
            INT | int
        }

        _alt;
        enterOuterAlt(_localctx, {
            IntegerLiteral | 1
        } )

        ;
        {
            setState(
            {
                IntegerLiteral | 680
            } )

            ;
            match(Identifier);
            setState(
            {
                IntegerLiteral | 685
            } )

            ;
            _errHandler.sync(
            {
                THIS | this
            } )

            ;
            _alt = getInterpreter().adaptivePredict(_input, {
                IntegerLiteral | 74
            } , 

            _ctx )
            ;
            {
                WHILE | while
            }

            (_alt
            {
                NOTEQUAL | !=
            }

            {
                IntegerLiteral | 2
            }

            {
                AND | &&
            }

            _alt
            {
                NOTEQUAL | !=
            }

            org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER )
            {
                {
                    IF | if
                }

                (_alt
                {
                    EQUAL |= =
                }

                {
                    IntegerLiteral | 1
                } )

                {
                    {
                        {
                            setState(
                            {
                                IntegerLiteral | 681
                            } )

                            ;
                            match(DOT);
                            setState(
                            {
                                IntegerLiteral | 682
                            } )

                            ;
                            match(Identifier);
                        }
                    }
                }

                setState(
                {
                    IntegerLiteral | 687
                } )

                ;
                _errHandler.sync(
                {
                    THIS | this
                } )

                ;
                _alt = getInterpreter().adaptivePredict(_input, {
                    IntegerLiteral | 74
                } , 

                _ctx )
                ;
            }
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(
        {
            THIS | this
        } , 

        re )
        ;
        _errHandler.recover(
        {
            THIS | this
        } , 

        re )
        ;
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        {
            RETURN | return
        }

        _localctx;
    }

public static class LiteralContext
{
    EXTENDS |extends
}

ParserRuleContext {
public TerminalNodeStringLiteral()
{
    {
        RETURN | return
    }

    getToken(JavaParser.StringLiteral, {
        IntegerLiteral | 0
    } )

    ;
}

public TerminalNodeIntegerLiteral()
{
    {
        RETURN | return
    }

    getToken(JavaParser.IntegerLiteral, {
        IntegerLiteral | 0
    } )

    ;
}

public TerminalNodeFloatingPointLiteral()
{
    {
        RETURN | return
    }

    getToken(JavaParser.FloatingPointLiteral, {
        IntegerLiteral | 0
    } )

    ;
}

public TerminalNodeBooleanLiteral()
{
    {
        RETURN | return
    }

    getToken(JavaParser.BooleanLiteral, {
        IntegerLiteral | 0
    } )

    ;
}

public TerminalNodeCharacterLiteral()
{
    {
        RETURN | return
    }

    getToken(JavaParser.CharacterLiteral, {
        IntegerLiteral | 0
    } )

    ;
}

public LiteralContext(ParserRuleContext parent, {
    INT | int
}

invokingState ) { {SUPER |super } (
parent , invokingState ) ;  } {AT | @ }Override public {
INT |int }
getRuleIndex()
{
    {
        RETURN | return
    }

    RULE_literal;
} {

AT | @ }Override public void enterRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterLiteral(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public void exitRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitLiteral(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public {
LT | < }T {
GT | > }Taccept(ParseTreeVisitor
{
    LT | <
} {

QUESTION |? } {
EXTENDS |extends }
T {
GT | > }visitor ) { {IF | if } (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) {RETURN | return } ( (JavaVisitor {
LT | < } {QUESTION |? } {
EXTENDS |extends }
T {
GT | > } )visitor ) .visitLiteral(
{
    THIS | this
} ) ;  {

ELSE | else } {RETURN | return }visitor.visitChildren ( {THIS |this
} ) ;  } }

public {
FINAL |final }
LiteralContextliteral()
{
    LiteralContext _localctx = new LiteralContext(_ctx, getState());
    enterRule(_localctx, {
        IntegerLiteral | 102
    } , 

    RULE_literal )
    ;
    {
        INT | int
    }

    _la;
    try
    {
        enterOuterAlt(_localctx, {
            IntegerLiteral | 1
        } )

        ;
        {
            setState(
            {
                IntegerLiteral | 688
            } )

            ;
            _la = _input.LA(
            {
                IntegerLiteral | 1
            } )

            ;
            {
                IF | if
            }

            (
            {
                BANG | !
            }

            ((((_la)
            {
                BITAND | &
            }

            {
                TILDE | ~
            }

            {
                IntegerLiteral | 0x3f
            } )

            {
                EQUAL |= =
            }

            {
                IntegerLiteral | 0
            }

            {
                AND | &&
            }

            ((
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            _la )
            {
                BITAND | &
            }

            ((
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            IntegerLiteral )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            FloatingPointLiteral )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            BooleanLiteral )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            CharacterLiteral )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            StringLiteral )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            NullLiteral ) ) )
            {
                NOTEQUAL | !=
            }

            {
                IntegerLiteral | 0
            } ) ) )

            {
                _errHandler.recoverInline(
                {
                    THIS | this
                } )

                ;
            }

            consume();
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(
        {
            THIS | this
        } , 

        re )
        ;
        _errHandler.recover(
        {
            THIS | this
        } , 

        re )
        ;
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        {
            RETURN | return
        }

        _localctx;
    }

public static class AnnotationContext
{
    EXTENDS |extends
}

ParserRuleContext {
public ElementValuePairsContextelementValuePairs()
{
    {
        RETURN | return
    }

    getRuleContext(ElementValuePairsContext.class ,  {

IntegerLiteral | 0 } ) ;  }public AnnotationNameContextannotationName()
{
    {
        RETURN | return
    }

    getRuleContext(AnnotationNameContext.class ,  {

IntegerLiteral | 0 } ) ;  }public ElementValueContextelementValue()
{
    {
        RETURN | return
    }

    getRuleContext(ElementValueContext.class ,  {

IntegerLiteral | 0 } ) ;  }public AnnotationContext(ParserRuleContext parent, {
    INT | int
}

invokingState ) { {SUPER |super } (
parent , invokingState ) ;  } {AT | @ }Override public {
INT |int }
getRuleIndex()
{
    {
        RETURN | return
    }

    RULE_annotation;
} {

AT | @ }Override public void enterRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterAnnotation(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public void exitRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitAnnotation(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public {
LT | < }T {
GT | > }Taccept(ParseTreeVisitor
{
    LT | <
} {

QUESTION |? } {
EXTENDS |extends }
T {
GT | > }visitor ) { {IF | if } (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) {RETURN | return } ( (JavaVisitor {
LT | < } {QUESTION |? } {
EXTENDS |extends }
T {
GT | > } )visitor ) .visitAnnotation(
{
    THIS | this
} ) ;  {

ELSE | else } {RETURN | return }visitor.visitChildren ( {THIS |this
} ) ;  } }

public {
FINAL |final }
AnnotationContextannotation()
{
    AnnotationContext _localctx = new AnnotationContext(_ctx, getState());
    enterRule(_localctx, {
        IntegerLiteral | 104
    } , 

    RULE_annotation )
    ;
    {
        INT | int
    }

    _la;
    try
    {
        enterOuterAlt(_localctx, {
            IntegerLiteral | 1
        } )

        ;
        {
            setState(
            {
                IntegerLiteral | 690
            } )

            ;
            match(AT);
            setState(
            {
                IntegerLiteral | 691
            } )

            ;
            annotationName();
            setState(
            {
                IntegerLiteral | 698
            } )

            ;
            _la = _input.LA(
            {
                IntegerLiteral | 1
            } )

            ;
            {
                IF | if
            }

            (_la
            {
                EQUAL |= =
            }

            LPAREN )
            {
                {
                    setState(
                    {
                        IntegerLiteral | 692
                    } )

                    ;
                    match(LPAREN);
                    setState(
                    {
                        IntegerLiteral | 695
                    } )

                    ;
                    {
                        SWITCH | switch
                        }

                        (getInterpreter().adaptivePredict(_input, {
                            IntegerLiteral | 75
                        } , 

                        _ctx ) )
                        {
                            {
                                CASE |  case
                            }

                            {
                                IntegerLiteral | 1
                            }

                            {
                                COLON |  : 
                            }

                            {
                                setState(
                                {
                                    IntegerLiteral | 693
                                } )

                                ;
                                elementValuePairs();
                            }

                            {
                                BREAK | break
                            }

                            ;
                            {
                                CASE |  case
                            }

                            {
                                IntegerLiteral | 2
                            }

                            {
                                COLON |  : 
                            }

                            {
                                setState(
                                {
                                    IntegerLiteral | 694
                                } )

                                ;
                                elementValue();
                            }

                            {
                                BREAK | break
                            }

                            ;
                        }

                        setState(
                        {
                            IntegerLiteral | 697
                        } )

                        ;
                        match(RPAREN);
                    }
                }
            }
        }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(
        {
            THIS | this
        } , 

        re )
        ;
        _errHandler.recover(
        {
            THIS | this
        } , 

        re )
        ;
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        {
            RETURN | return
        }

        _localctx;
    }

public static class AnnotationNameContext
{
    EXTENDS |extends
}

ParserRuleContext {
public QualifiedNameContextqualifiedName()
{
    {
        RETURN | return
    }

    getRuleContext(QualifiedNameContext.class ,  {

IntegerLiteral | 0 } ) ;  }public AnnotationNameContext(ParserRuleContext parent, {
    INT | int
}

invokingState ) { {SUPER |super } (
parent , invokingState ) ;  } {AT | @ }Override public {
INT |int }
getRuleIndex()
{
    {
        RETURN | return
    }

    RULE_annotationName;
} {

AT | @ }Override public void enterRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterAnnotationName(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public void exitRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitAnnotationName(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public {
LT | < }T {
GT | > }Taccept(ParseTreeVisitor
{
    LT | <
} {

QUESTION |? } {
EXTENDS |extends }
T {
GT | > }visitor ) { {IF | if } (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) {RETURN | return } ( (JavaVisitor {
LT | < } {QUESTION |? } {
EXTENDS |extends }
T {
GT | > } )visitor ) .visitAnnotationName(
{
    THIS | this
} ) ;  {

ELSE | else } {RETURN | return }visitor.visitChildren ( {THIS |this
} ) ;  } }

public {
FINAL |final }
AnnotationNameContextannotationName()
{
    AnnotationNameContext _localctx = new AnnotationNameContext(_ctx, getState());
    enterRule(_localctx, {
        IntegerLiteral | 106
    } , 

    RULE_annotationName )
    ;
    try
    {
        enterOuterAlt(_localctx, {
            IntegerLiteral | 1
        } )

        ;
        {
            setState(
            {
                IntegerLiteral | 700
            } )

            ;
            qualifiedName();
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(
        {
            THIS | this
        } , 

        re )
        ;
        _errHandler.recover(
        {
            THIS | this
        } , 

        re )
        ;
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        {
            RETURN | return
        }

        _localctx;
    }

public static class ElementValuePairsContext
{
    EXTENDS |extends
}

ParserRuleContext {
public ElementValuePairContextelementValuePair(
{
    INT | int
}

i ) { {RETURN | return }getRuleContext(ElementValuePairContext.class , 

i ) ;  }public List {
LT | < }ElementValuePairContext {
GT | > }elementValuePair()
{
    {
        RETURN | return
    }

    getRuleContexts(ElementValuePairContext.class ) ;  }

public ElementValuePairsContext(ParserRuleContext parent, {
    INT | int
}

invokingState ) { {SUPER |super } (
parent , invokingState ) ;  } {AT | @ }Override public {
INT |int }
getRuleIndex()
{
    {
        RETURN | return
    }

    RULE_elementValuePairs;
} {

AT | @ }Override public void enterRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterElementValuePairs(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public void exitRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitElementValuePairs(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public {
LT | < }T {
GT | > }Taccept(ParseTreeVisitor
{
    LT | <
} {

QUESTION |? } {
EXTENDS |extends }
T {
GT | > }visitor ) { {IF | if } (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) {RETURN | return } ( (JavaVisitor {
LT | < } {QUESTION |? } {
EXTENDS |extends }
T {
GT | > } )visitor ) .visitElementValuePairs(
{
    THIS | this
} ) ;  {

ELSE | else } {RETURN | return }visitor.visitChildren ( {THIS |this
} ) ;  } }

public {
FINAL |final }
ElementValuePairsContextelementValuePairs()
{
    ElementValuePairsContext _localctx = new ElementValuePairsContext(_ctx, getState());
    enterRule(_localctx, {
        IntegerLiteral | 108
    } , 

    RULE_elementValuePairs )
    ;
    {
        INT | int
    }

    _la;
    try
    {
        enterOuterAlt(_localctx, {
            IntegerLiteral | 1
        } )

        ;
        {
            setState(
            {
                IntegerLiteral | 702
            } )

            ;
            elementValuePair();
            setState(
            {
                IntegerLiteral | 707
            } )

            ;
            _errHandler.sync(
            {
                THIS | this
            } )

            ;
            _la = _input.LA(
            {
                IntegerLiteral | 1
            } )

            ;
            {
                WHILE | while
            }

            (_la
            {
                EQUAL |= =
            }

            COMMA )
            {
                {
                    {
                        setState(
                        {
                            IntegerLiteral | 703
                        } )

                        ;
                        match(COMMA);
                        setState(
                        {
                            IntegerLiteral | 704
                        } )

                        ;
                        elementValuePair();
                    }
                }

                setState(
                {
                    IntegerLiteral | 709
                } )

                ;
                _errHandler.sync(
                {
                    THIS | this
                } )

                ;
                _la = _input.LA(
                {
                    IntegerLiteral | 1
                } )

                ;
            }
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(
        {
            THIS | this
        } , 

        re )
        ;
        _errHandler.recover(
        {
            THIS | this
        } , 

        re )
        ;
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        {
            RETURN | return
        }

        _localctx;
    }

public static class ElementValuePairContext
{
    EXTENDS |extends
}

ParserRuleContext {
public TerminalNodeIdentifier()
{
    {
        RETURN | return
    }

    getToken(JavaParser.Identifier, {
        IntegerLiteral | 0
    } )

    ;
}

public ElementValueContextelementValue()
{
    {
        RETURN | return
    }

    getRuleContext(ElementValueContext.class ,  {

IntegerLiteral | 0 } ) ;  }public ElementValuePairContext(ParserRuleContext parent, {
    INT | int
}

invokingState ) { {SUPER |super } (
parent , invokingState ) ;  } {AT | @ }Override public {
INT |int }
getRuleIndex()
{
    {
        RETURN | return
    }

    RULE_elementValuePair;
} {

AT | @ }Override public void enterRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterElementValuePair(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public void exitRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitElementValuePair(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public {
LT | < }T {
GT | > }Taccept(ParseTreeVisitor
{
    LT | <
} {

QUESTION |? } {
EXTENDS |extends }
T {
GT | > }visitor ) { {IF | if } (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) {RETURN | return } ( (JavaVisitor {
LT | < } {QUESTION |? } {
EXTENDS |extends }
T {
GT | > } )visitor ) .visitElementValuePair(
{
    THIS | this
} ) ;  {

ELSE | else } {RETURN | return }visitor.visitChildren ( {THIS |this
} ) ;  } }

public {
FINAL |final }
ElementValuePairContextelementValuePair()
{
    ElementValuePairContext _localctx = new ElementValuePairContext(_ctx, getState());
    enterRule(_localctx, {
        IntegerLiteral | 110
    } , 

    RULE_elementValuePair )
    ;
    try
    {
        enterOuterAlt(_localctx, {
            IntegerLiteral | 1
        } )

        ;
        {
            setState(
            {
                IntegerLiteral | 710
            } )

            ;
            match(Identifier);
            setState(
            {
                IntegerLiteral | 711
            } )

            ;
            match(ASSIGN);
            setState(
            {
                IntegerLiteral | 712
            } )

            ;
            elementValue();
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(
        {
            THIS | this
        } , 

        re )
        ;
        _errHandler.recover(
        {
            THIS | this
        } , 

        re )
        ;
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        {
            RETURN | return
        }

        _localctx;
    }

public static class ElementValueContext
{
    EXTENDS |extends
}

ParserRuleContext {
public ElementValueArrayInitializerContextelementValueArrayInitializer()
{
    {
        RETURN | return
    }

    getRuleContext(ElementValueArrayInitializerContext.class ,  {

IntegerLiteral | 0 } ) ;  }public AnnotationContextannotation()
{
    {
        RETURN | return
    }

    getRuleContext(AnnotationContext.class ,  {

IntegerLiteral | 0 } ) ;  }public ExpressionContextexpression()
{
    {
        RETURN | return
    }

    getRuleContext(ExpressionContext.class ,  {

IntegerLiteral | 0 } ) ;  }public ElementValueContext(ParserRuleContext parent, {
    INT | int
}

invokingState ) { {SUPER |super } (
parent , invokingState ) ;  } {AT | @ }Override public {
INT |int }
getRuleIndex()
{
    {
        RETURN | return
    }

    RULE_elementValue;
} {

AT | @ }Override public void enterRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterElementValue(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public void exitRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitElementValue(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public {
LT | < }T {
GT | > }Taccept(ParseTreeVisitor
{
    LT | <
} {

QUESTION |? } {
EXTENDS |extends }
T {
GT | > }visitor ) { {IF | if } (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) {RETURN | return } ( (JavaVisitor {
LT | < } {QUESTION |? } {
EXTENDS |extends }
T {
GT | > } )visitor ) .visitElementValue(
{
    THIS | this
} ) ;  {

ELSE | else } {RETURN | return }visitor.visitChildren ( {THIS |this
} ) ;  } }

public {
FINAL |final }
ElementValueContextelementValue()
{
    ElementValueContext _localctx = new ElementValueContext(_ctx, getState());
    enterRule(_localctx, {
        IntegerLiteral | 112
    } , 

    RULE_elementValue )
    ;
    try
    {
        setState(
        {
            IntegerLiteral | 717
        } )

        ;
        {
            SWITCH | switch
            }

            (_input.LA(
            {
                IntegerLiteral | 1
            } ) )

            {
                {
                    CASE |  case
                }

                BOOLEAN
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                BYTE
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                CHAR
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                DOUBLE
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                FLOAT
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                INT
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                LONG
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                NEW
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                SHORT
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                SUPER
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                THIS
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                VOID
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                IntegerLiteral
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                FloatingPointLiteral
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                BooleanLiteral
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                CharacterLiteral
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                StringLiteral
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                NullLiteral
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                LPAREN
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                LT
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                BANG
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                TILDE
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                INC
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                DEC
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                ADD
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                SUB
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                Identifier
                {
                    COLON |  : 
                }

                enterOuterAlt(_localctx, {
                    IntegerLiteral | 1
                } )

                ;
                {
                    setState(
                    {
                        IntegerLiteral | 714
                    } )

                    ;
                    expression(
                    {
                        IntegerLiteral | 0
                    } )

                    ;
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                AT
                {
                    COLON |  : 
                }

                enterOuterAlt(_localctx, {
                    IntegerLiteral | 2
                } )

                ;
                {
                    setState(
                    {
                        IntegerLiteral | 715
                    } )

                    ;
                    annotation();
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                LBRACE
                {
                    COLON |  : 
                }

                enterOuterAlt(_localctx, {
                    IntegerLiteral | 3
                } )

                ;
                {
                    setState(
                    {
                        IntegerLiteral | 716
                    } )

                    ;
                    elementValueArrayInitializer();
                }

                {
                    BREAK | break
                }

                ;
                {
                    DEFAULT | default
                }

                {
                    COLON |  : 
                }

                {
                    THROW | throw
                }

                new NoViableAltException(
                {
                THIS | this
                }

                 )
                ;
            }
        }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(
        {
            THIS | this
        } , 

        re )
        ;
        _errHandler.recover(
        {
            THIS | this
        } , 

        re )
        ;
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        {
            RETURN | return
        }

        _localctx;
    }

public static class ElementValueArrayInitializerContext
{
    EXTENDS |extends
}

ParserRuleContext {
public ElementValueContextelementValue(
{
    INT | int
}

i ) { {RETURN | return }getRuleContext(ElementValueContext.class , 

i ) ;  }public List {
LT | < }ElementValueContext {
GT | > }elementValue()
{
    {
        RETURN | return
    }

    getRuleContexts(ElementValueContext.class ) ;  }

public ElementValueArrayInitializerContext(ParserRuleContext parent, {
    INT | int
}

invokingState ) { {SUPER |super } (
parent , invokingState ) ;  } {AT | @ }Override public {
INT |int }
getRuleIndex()
{
    {
        RETURN | return
    }

    RULE_elementValueArrayInitializer;
} {

AT | @ }Override public void enterRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterElementValueArrayInitializer(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public void exitRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitElementValueArrayInitializer(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public {
LT | < }T {
GT | > }Taccept(ParseTreeVisitor
{
    LT | <
} {

QUESTION |? } {
EXTENDS |extends }
T {
GT | > }visitor ) { {IF | if } (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) {RETURN | return } ( (JavaVisitor {
LT | < } {QUESTION |? } {
EXTENDS |extends }
T {
GT | > } )visitor ) .visitElementValueArrayInitializer(
{
    THIS | this
} ) ;  {

ELSE | else } {RETURN | return }visitor.visitChildren ( {THIS |this
} ) ;  } }

public {
FINAL |final }
ElementValueArrayInitializerContextelementValueArrayInitializer()
{
    ElementValueArrayInitializerContext _localctx = new ElementValueArrayInitializerContext(_ctx, getState());
    enterRule(_localctx, {
        IntegerLiteral | 114
    } , 

    RULE_elementValueArrayInitializer )
    ;
    {
        INT | int
    }

    _la;
    try
    {
        {
            INT | int
        }

        _alt;
        enterOuterAlt(_localctx, {
            IntegerLiteral | 1
        } )

        ;
        {
            setState(
            {
                IntegerLiteral | 719
            } )

            ;
            match(LBRACE);
            setState(
            {
                IntegerLiteral | 728
            } )

            ;
            _la = _input.LA(
            {
                IntegerLiteral | 1
            } )

            ;
            {
                IF | if
            }

            ((((_la)
            {
                BITAND | &
            }

            {
                TILDE | ~
            }

            {
                IntegerLiteral | 0x3f
            } )

            {
                EQUAL |= =
            }

            {
                IntegerLiteral | 0
            }

            {
                AND | &&
            }

            ((
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            _la )
            {
                BITAND | &
            }

            ((
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            BOOLEAN )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            BYTE )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            CHAR )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            DOUBLE )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            FLOAT )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            INT )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            LONG )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            NEW )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            SHORT )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            SUPER )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            THIS )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            VOID )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            IntegerLiteral )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            FloatingPointLiteral )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            BooleanLiteral )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            CharacterLiteral )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            StringLiteral )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            NullLiteral )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            LPAREN )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            LBRACE ) ) )
            {
                NOTEQUAL | !=
            }

            {
                IntegerLiteral | 0
            } )

            {
                OR || |
            }

            ((((_la
            {
                SUB | -
            }

            {
                IntegerLiteral | 68
            } ) )

            {
                BITAND | &
            }

            {
                TILDE | ~
            }

            {
                IntegerLiteral | 0x3f
            } )

            {
                EQUAL |= =
            }

            {
                IntegerLiteral | 0
            }

            {
                AND | &&
            }

            ((
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            (_la
            {
                SUB | -
            }

            {
                IntegerLiteral | 68
            } ) )

            {
                BITAND | &
            }

            ((
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            (LT
            {
                SUB | -
            }

            {
                IntegerLiteral | 68
            } ) )

            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            (BANG
            {
                SUB | -
            }

            {
                IntegerLiteral | 68
            } ) )

            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            (TILDE
            {
                SUB | -
            }

            {
                IntegerLiteral | 68
            } ) )

            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            (INC
            {
                SUB | -
            }

            {
                IntegerLiteral | 68
            } ) )

            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            (DEC
            {
                SUB | -
            }

            {
                IntegerLiteral | 68
            } ) )

            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            (ADD
            {
                SUB | -
            }

            {
                IntegerLiteral | 68
            } ) )

            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            (SUB
            {
                SUB | -
            }

            {
                IntegerLiteral | 68
            } ) )

            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            (Identifier
            {
                SUB | -
            }

            {
                IntegerLiteral | 68
            } ) )

            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            (AT
            {
                SUB | -
            }

            {
                IntegerLiteral | 68
            } ) ) ) )

            {
                NOTEQUAL | !=
            }

            {
                IntegerLiteral | 0
            } ) )

            {
                {
                    setState(
                    {
                        IntegerLiteral | 720
                    } )

                    ;
                    elementValue();
                    setState(
                    {
                        IntegerLiteral | 725
                    } )

                    ;
                    _errHandler.sync(
                    {
                        THIS | this
                    } )

                    ;
                    _alt = getInterpreter().adaptivePredict(_input, {
                        IntegerLiteral | 79
                    } , 

                    _ctx )
                    ;
                    {
                        WHILE | while
                    }

                    (_alt
                    {
                        NOTEQUAL | !=
                    }

                    {
                        IntegerLiteral | 2
                    }

                    {
                        AND | &&
                    }

                    _alt
                    {
                        NOTEQUAL | !=
                    }

                    org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER )
                    {
                        {
                            IF | if
                        }

                        (_alt
                        {
                            EQUAL |= =
                        }

                        {
                            IntegerLiteral | 1
                        } )

                        {
                            {
                                {
                                    setState(
                                    {
                                        IntegerLiteral | 721
                                    } )

                                    ;
                                    match(COMMA);
                                    setState(
                                    {
                                        IntegerLiteral | 722
                                    } )

                                    ;
                                    elementValue();
                                }
                            }
                        }

                        setState(
                        {
                            IntegerLiteral | 727
                        } )

                        ;
                        _errHandler.sync(
                        {
                            THIS | this
                        } )

                        ;
                        _alt = getInterpreter().adaptivePredict(_input, {
                            IntegerLiteral | 79
                        } , 

                        _ctx )
                        ;
                    }
                }
            }

            setState(
            {
                IntegerLiteral | 731
            } )

            ;
            _la = _input.LA(
            {
                IntegerLiteral | 1
            } )

            ;
            {
                IF | if
            }

            (_la
            {
                EQUAL |= =
            }

            COMMA )
            {
                {
                    setState(
                    {
                        IntegerLiteral | 730
                    } )

                    ;
                    match(COMMA);
                }
            }

            setState(
            {
                IntegerLiteral | 733
            } )

            ;
            match(RBRACE);
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(
        {
            THIS | this
        } , 

        re )
        ;
        _errHandler.recover(
        {
            THIS | this
        } , 

        re )
        ;
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        {
            RETURN | return
        }

        _localctx;
    }

public static class AnnotationTypeDeclarationContext
{
    EXTENDS |extends
}

ParserRuleContext {
public TerminalNodeIdentifier()
{
    {
        RETURN | return
    }

    getToken(JavaParser.Identifier, {
        IntegerLiteral | 0
    } )

    ;
}

public AnnotationTypeBodyContextannotationTypeBody()
{
    {
        RETURN | return
    }

    getRuleContext(AnnotationTypeBodyContext.class ,  {

IntegerLiteral | 0 } ) ;  }public AnnotationTypeDeclarationContext(ParserRuleContext parent, {
    INT | int
}

invokingState ) { {SUPER |super } (
parent , invokingState ) ;  } {AT | @ }Override public {
INT |int }
getRuleIndex()
{
    {
        RETURN | return
    }

    RULE_annotationTypeDeclaration;
} {

AT | @ }Override public void enterRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterAnnotationTypeDeclaration(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public void exitRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitAnnotationTypeDeclaration(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public {
LT | < }T {
GT | > }Taccept(ParseTreeVisitor
{
    LT | <
} {

QUESTION |? } {
EXTENDS |extends }
T {
GT | > }visitor ) { {IF | if } (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) {RETURN | return } ( (JavaVisitor {
LT | < } {QUESTION |? } {
EXTENDS |extends }
T {
GT | > } )visitor ) .visitAnnotationTypeDeclaration(
{
    THIS | this
} ) ;  {

ELSE | else } {RETURN | return }visitor.visitChildren ( {THIS |this
} ) ;  } }

public {
FINAL |final }
AnnotationTypeDeclarationContextannotationTypeDeclaration()
{
    AnnotationTypeDeclarationContext _localctx = new AnnotationTypeDeclarationContext(_ctx, getState());
    enterRule(_localctx, {
        IntegerLiteral | 116
    } , 

    RULE_annotationTypeDeclaration )
    ;
    try
    {
        enterOuterAlt(_localctx, {
            IntegerLiteral | 1
        } )

        ;
        {
            setState(
            {
                IntegerLiteral | 735
            } )

            ;
            match(AT);
            setState(
            {
                IntegerLiteral | 736
            } )

            ;
            match(INTERFACE);
            setState(
            {
                IntegerLiteral | 737
            } )

            ;
            match(Identifier);
            setState(
            {
                IntegerLiteral | 738
            } )

            ;
            annotationTypeBody();
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(
        {
            THIS | this
        } , 

        re )
        ;
        _errHandler.recover(
        {
            THIS | this
        } , 

        re )
        ;
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        {
            RETURN | return
        }

        _localctx;
    }

public static class AnnotationTypeBodyContext
{
    EXTENDS |extends
}

ParserRuleContext {
public List {
LT | < }AnnotationTypeElementDeclarationContext {
GT | > }annotationTypeElementDeclaration()
{
    {
        RETURN | return
    }

    getRuleContexts(AnnotationTypeElementDeclarationContext.class ) ;  }

public AnnotationTypeElementDeclarationContextannotationTypeElementDeclaration(
{
    INT | int
}

i ) { {RETURN | return }getRuleContext(AnnotationTypeElementDeclarationContext.class , 

i ) ;  }public AnnotationTypeBodyContext(ParserRuleContext parent, {
    INT | int
}

invokingState ) { {SUPER |super } (
parent , invokingState ) ;  } {AT | @ }Override public {
INT |int }
getRuleIndex()
{
    {
        RETURN | return
    }

    RULE_annotationTypeBody;
} {

AT | @ }Override public void enterRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterAnnotationTypeBody(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public void exitRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitAnnotationTypeBody(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public {
LT | < }T {
GT | > }Taccept(ParseTreeVisitor
{
    LT | <
} {

QUESTION |? } {
EXTENDS |extends }
T {
GT | > }visitor ) { {IF | if } (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) {RETURN | return } ( (JavaVisitor {
LT | < } {QUESTION |? } {
EXTENDS |extends }
T {
GT | > } )visitor ) .visitAnnotationTypeBody(
{
    THIS | this
} ) ;  {

ELSE | else } {RETURN | return }visitor.visitChildren ( {THIS |this
} ) ;  } }

public {
FINAL |final }
AnnotationTypeBodyContextannotationTypeBody()
{
    AnnotationTypeBodyContext _localctx = new AnnotationTypeBodyContext(_ctx, getState());
    enterRule(_localctx, {
        IntegerLiteral | 118
    } , 

    RULE_annotationTypeBody )
    ;
    {
        INT | int
    }

    _la;
    try
    {
        enterOuterAlt(_localctx, {
            IntegerLiteral | 1
        } )

        ;
        {
            setState(
            {
                IntegerLiteral | 740
            } )

            ;
            match(LBRACE);
            setState(
            {
                IntegerLiteral | 744
            } )

            ;
            _errHandler.sync(
            {
                THIS | this
            } )

            ;
            _la = _input.LA(
            {
                IntegerLiteral | 1
            } )

            ;
            {
                WHILE | while
            }

            ((((_la)
            {
                BITAND | &
            }

            {
                TILDE | ~
            }

            {
                IntegerLiteral | 0x3f
            } )

            {
                EQUAL |= =
            }

            {
                IntegerLiteral | 0
            }

            {
                AND | &&
            }

            ((
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            _la )
            {
                BITAND | &
            }

            ((
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            ABSTRACT )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            BOOLEAN )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            BYTE )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            CHAR )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            CLASS )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            DOUBLE )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            ENUM )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            FINAL )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            FLOAT )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            INT )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            INTERFACE )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            LONG )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            NATIVE )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            PRIVATE )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            PROTECTED )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            PUBLIC )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            SHORT )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            STATIC )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            STRICTFP )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            SYNCHRONIZED )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            TRANSIENT )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            VOLATILE )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            SEMI ) ) )
            {
                NOTEQUAL | !=
            }

            {
                IntegerLiteral | 0
            } )

            {
                OR || |
            }

            _la
            {
                EQUAL |= =
            }

            Identifier
            {
                OR || |
            }

            _la
            {
                EQUAL |= =
            }

            AT )
            {
                {
                    {
                        setState(
                        {
                            IntegerLiteral | 741
                        } )

                        ;
                        annotationTypeElementDeclaration();
                    }
                }

                setState(
                {
                    IntegerLiteral | 746
                } )

                ;
                _errHandler.sync(
                {
                    THIS | this
                } )

                ;
                _la = _input.LA(
                {
                    IntegerLiteral | 1
                } )

                ;
            }

            setState(
            {
                IntegerLiteral | 747
            } )

            ;
            match(RBRACE);
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(
        {
            THIS | this
        } , 

        re )
        ;
        _errHandler.recover(
        {
            THIS | this
        } , 

        re )
        ;
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        {
            RETURN | return
        }

        _localctx;
    }

public static class AnnotationTypeElementDeclarationContext
{
    EXTENDS |extends
}

ParserRuleContext {
public List {
LT | < }ModifierContext {
GT | > }modifier()
{
    {
        RETURN | return
    }

    getRuleContexts(ModifierContext.class ) ;  }

public AnnotationTypeElementRestContextannotationTypeElementRest()
{
    {
        RETURN | return
    }

    getRuleContext(AnnotationTypeElementRestContext.class ,  {

IntegerLiteral | 0 } ) ;  }public ModifierContextmodifier(
{
    INT | int
}

i ) { {RETURN | return }getRuleContext(ModifierContext.class , 

i ) ;  }public AnnotationTypeElementDeclarationContext(ParserRuleContext parent, {
    INT | int
}

invokingState ) { {SUPER |super } (
parent , invokingState ) ;  } {AT | @ }Override public {
INT |int }
getRuleIndex()
{
    {
        RETURN | return
    }

    RULE_annotationTypeElementDeclaration;
} {

AT | @ }Override public void enterRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterAnnotationTypeElementDeclaration(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public void exitRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitAnnotationTypeElementDeclaration(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public {
LT | < }T {
GT | > }Taccept(ParseTreeVisitor
{
    LT | <
} {

QUESTION |? } {
EXTENDS |extends }
T {
GT | > }visitor ) { {IF | if } (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) {RETURN | return } ( (JavaVisitor {
LT | < } {QUESTION |? } {
EXTENDS |extends }
T {
GT | > } )visitor ) .visitAnnotationTypeElementDeclaration(
{
    THIS | this
} ) ;  {

ELSE | else } {RETURN | return }visitor.visitChildren ( {THIS |this
} ) ;  } }

public {
FINAL |final }
AnnotationTypeElementDeclarationContextannotationTypeElementDeclaration()
{
    AnnotationTypeElementDeclarationContext _localctx = new AnnotationTypeElementDeclarationContext(_ctx, getState());
    enterRule(_localctx, {
        IntegerLiteral | 120
    } , 

    RULE_annotationTypeElementDeclaration )
    ;
    try
    {
        {
            INT | int
        }

        _alt;
        setState(
        {
            IntegerLiteral | 757
        } )

        ;
        {
            SWITCH | switch
            }

            (_input.LA(
            {
                IntegerLiteral | 1
            } ) )

            {
                {
                    CASE |  case
                }

                ABSTRACT
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                BOOLEAN
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                BYTE
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                CHAR
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                CLASS
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                DOUBLE
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                ENUM
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                FINAL
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                FLOAT
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                INT
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                INTERFACE
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                LONG
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                NATIVE
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                PRIVATE
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                PROTECTED
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                PUBLIC
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                SHORT
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                STATIC
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                STRICTFP
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                SYNCHRONIZED
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                TRANSIENT
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                VOLATILE
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                Identifier
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                AT
                {
                    COLON |  : 
                }

                enterOuterAlt(_localctx, {
                    IntegerLiteral | 1
                } )

                ;
                {
                    setState(
                    {
                        IntegerLiteral | 752
                    } )

                    ;
                    _errHandler.sync(
                    {
                        THIS | this
                    } )

                    ;
                    _alt = getInterpreter().adaptivePredict(_input, {
                        IntegerLiteral | 83
                    } , 

                    _ctx )
                    ;
                    {
                        WHILE | while
                    }

                    (_alt
                    {
                        NOTEQUAL | !=
                    }

                    {
                        IntegerLiteral | 2
                    }

                    {
                        AND | &&
                    }

                    _alt
                    {
                        NOTEQUAL | !=
                    }

                    org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER )
                    {
                        {
                            IF | if
                        }

                        (_alt
                        {
                            EQUAL |= =
                        }

                        {
                            IntegerLiteral | 1
                        } )

                        {
                            {
                                {
                                    setState(
                                    {
                                        IntegerLiteral | 749
                                    } )

                                    ;
                                    modifier();
                                }
                            }
                        }

                        setState(
                        {
                            IntegerLiteral | 754
                        } )

                        ;
                        _errHandler.sync(
                        {
                            THIS | this
                        } )

                        ;
                        _alt = getInterpreter().adaptivePredict(_input, {
                            IntegerLiteral | 83
                        } , 

                        _ctx )
                        ;
                    }

                    setState(
                    {
                        IntegerLiteral | 755
                    } )

                    ;
                    annotationTypeElementRest();
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                SEMI
                {
                    COLON |  : 
                }

                enterOuterAlt(_localctx, {
                    IntegerLiteral | 2
                } )

                ;
                {
                    setState(
                    {
                        IntegerLiteral | 756
                    } )

                    ;
                    match(SEMI);
                }

                {
                    BREAK | break
                }

                ;
                {
                    DEFAULT | default
                }

                {
                    COLON |  : 
                }

                {
                    THROW | throw
                }

                new NoViableAltException(
                {
                THIS | this
                }

                 )
                ;
            }
        }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(
        {
            THIS | this
        } , 

        re )
        ;
        _errHandler.recover(
        {
            THIS | this
        } , 

        re )
        ;
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        {
            RETURN | return
        }

        _localctx;
    }

public static class AnnotationTypeElementRestContext
{
    EXTENDS |extends
}

ParserRuleContext {
public EnumDeclarationContextenumDeclaration()
{
    {
        RETURN | return
    }

    getRuleContext(EnumDeclarationContext.class ,  {

IntegerLiteral | 0 } ) ;  }public ClassDeclarationContextclassDeclaration()
{
    {
        RETURN | return
    }

    getRuleContext(ClassDeclarationContext.class ,  {

IntegerLiteral | 0 } ) ;  }public AnnotationMethodOrConstantRestContextannotationMethodOrConstantRest()
{
    {
        RETURN | return
    }

    getRuleContext(AnnotationMethodOrConstantRestContext.class ,  {

IntegerLiteral | 0 } ) ;  }public AnnotationTypeDeclarationContextannotationTypeDeclaration()
{
    {
        RETURN | return
    }

    getRuleContext(AnnotationTypeDeclarationContext.class ,  {

IntegerLiteral | 0 } ) ;  }public InterfaceDeclarationContextinterfaceDeclaration()
{
    {
        RETURN | return
    }

    getRuleContext(InterfaceDeclarationContext.class ,  {

IntegerLiteral | 0 } ) ;  }public TypeContexttype()
{
    {
        RETURN | return
    }

    getRuleContext(TypeContext.class ,  {

IntegerLiteral | 0 } ) ;  }public AnnotationTypeElementRestContext(ParserRuleContext parent, {
    INT | int
}

invokingState ) { {SUPER |super } (
parent , invokingState ) ;  } {AT | @ }Override public {
INT |int }
getRuleIndex()
{
    {
        RETURN | return
    }

    RULE_annotationTypeElementRest;
} {

AT | @ }Override public void enterRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterAnnotationTypeElementRest(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public void exitRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitAnnotationTypeElementRest(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public {
LT | < }T {
GT | > }Taccept(ParseTreeVisitor
{
    LT | <
} {

QUESTION |? } {
EXTENDS |extends }
T {
GT | > }visitor ) { {IF | if } (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) {RETURN | return } ( (JavaVisitor {
LT | < } {QUESTION |? } {
EXTENDS |extends }
T {
GT | > } )visitor ) .visitAnnotationTypeElementRest(
{
    THIS | this
} ) ;  {

ELSE | else } {RETURN | return }visitor.visitChildren ( {THIS |this
} ) ;  } }

public {
FINAL |final }
AnnotationTypeElementRestContextannotationTypeElementRest()
{
    AnnotationTypeElementRestContext _localctx = new AnnotationTypeElementRestContext(_ctx, getState());
    enterRule(_localctx, {
        IntegerLiteral | 122
    } , 

    RULE_annotationTypeElementRest )
    ;
    try
    {
        setState(
        {
            IntegerLiteral | 779
        } )

        ;
        {
            SWITCH | switch
            }

            (_input.LA(
            {
                IntegerLiteral | 1
            } ) )

            {
                {
                    CASE |  case
                }

                BOOLEAN
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                BYTE
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                CHAR
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                DOUBLE
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                FLOAT
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                INT
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                LONG
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                SHORT
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                Identifier
                {
                    COLON |  : 
                }

                enterOuterAlt(_localctx, {
                    IntegerLiteral | 1
                } )

                ;
                {
                    setState(
                    {
                        IntegerLiteral | 759
                    } )

                    ;
                    type();
                    setState(
                    {
                        IntegerLiteral | 760
                    } )

                    ;
                    annotationMethodOrConstantRest();
                    setState(
                    {
                        IntegerLiteral | 761
                    } )

                    ;
                    match(SEMI);
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                CLASS
                {
                    COLON |  : 
                }

                enterOuterAlt(_localctx, {
                    IntegerLiteral | 2
                } )

                ;
                {
                    setState(
                    {
                        IntegerLiteral | 763
                    } )

                    ;
                    classDeclaration();
                    setState(
                    {
                        IntegerLiteral | 765
                    } )

                    ;
                    {
                        SWITCH | switch
                        }

                        (getInterpreter().adaptivePredict(_input, {
                            IntegerLiteral | 85
                        } , 

                        _ctx ) )
                        {
                            {
                                CASE |  case
                            }

                            {
                                IntegerLiteral | 1
                            }

                            {
                                COLON |  : 
                            }

                            {
                                setState(
                                {
                                    IntegerLiteral | 764
                                } )

                                ;
                                match(SEMI);
                            }

                            {
                                BREAK | break
                            }

                            ;
                        }
                    }

                    {
                        BREAK | break
                    }

                    ;
                    {
                        CASE |  case
                    }

                    INTERFACE
                    {
                        COLON |  : 
                    }

                    enterOuterAlt(_localctx, {
                        IntegerLiteral | 3
                    } )

                    ;
                    {
                        setState(
                        {
                            IntegerLiteral | 767
                        } )

                        ;
                        interfaceDeclaration();
                        setState(
                        {
                            IntegerLiteral | 769
                        } )

                        ;
                        {
                            SWITCH | switch
                            }

                            (getInterpreter().adaptivePredict(_input, {
                                IntegerLiteral | 86
                            } , 

                            _ctx ) )
                            {
                                {
                                    CASE |  case
                                }

                                {
                                    IntegerLiteral | 1
                                }

                                {
                                    COLON |  : 
                                }

                                {
                                    setState(
                                    {
                                        IntegerLiteral | 768
                                    } )

                                    ;
                                    match(SEMI);
                                }

                                {
                                    BREAK | break
                                }

                                ;
                            }
                        }

                        {
                            BREAK | break
                        }

                        ;
                        {
                            CASE |  case
                        }

                        ENUM
                        {
                            COLON |  : 
                        }

                        enterOuterAlt(_localctx, {
                            IntegerLiteral | 4
                        } )

                        ;
                        {
                            setState(
                            {
                                IntegerLiteral | 771
                            } )

                            ;
                            enumDeclaration();
                            setState(
                            {
                                IntegerLiteral | 773
                            } )

                            ;
                            {
                                SWITCH | switch
                                }

                                (getInterpreter().adaptivePredict(_input, {
                                    IntegerLiteral | 87
                                } , 

                                _ctx ) )
                                {
                                    {
                                        CASE |  case
                                    }

                                    {
                                        IntegerLiteral | 1
                                    }

                                    {
                                        COLON |  : 
                                    }

                                    {
                                        setState(
                                        {
                                            IntegerLiteral | 772
                                        } )

                                        ;
                                        match(SEMI);
                                    }

                                    {
                                        BREAK | break
                                    }

                                    ;
                                }
                            }

                            {
                                BREAK | break
                            }

                            ;
                            {
                                CASE |  case
                            }

                            AT
                            {
                                COLON |  : 
                            }

                            enterOuterAlt(_localctx, {
                                IntegerLiteral | 5
                            } )

                            ;
                            {
                                setState(
                                {
                                    IntegerLiteral | 775
                                } )

                                ;
                                annotationTypeDeclaration();
                                setState(
                                {
                                    IntegerLiteral | 777
                                } )

                                ;
                                {
                                    SWITCH | switch
                                    }

                                    (getInterpreter().adaptivePredict(_input, {
                                        IntegerLiteral | 88
                                    } , 

                                    _ctx ) )
                                    {
                                        {
                                            CASE |  case
                                        }

                                        {
                                            IntegerLiteral | 1
                                        }

                                        {
                                            COLON |  : 
                                        }

                                        {
                                            setState(
                                            {
                                                IntegerLiteral | 776
                                            } )

                                            ;
                                            match(SEMI);
                                        }

                                        {
                                            BREAK | break
                                        }

                                        ;
                                    }
                                }

                                {
                                    BREAK | break
                                }

                                ;
                                {
                                    DEFAULT | default
                                }

                                {
                                    COLON |  : 
                                }

                                {
                                    THROW | throw
                                }

                                new NoViableAltException(
                                {
                                THIS | this
                                }

                                 )
                                ;
                            }
                        }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(
        {
            THIS | this
        } , 

        re )
        ;
        _errHandler.recover(
        {
            THIS | this
        } , 

        re )
        ;
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        {
            RETURN | return
        }

        _localctx;
    }

public static class AnnotationMethodOrConstantRestContext
{
    EXTENDS |extends
}

ParserRuleContext {
public AnnotationMethodRestContextannotationMethodRest()
{
    {
        RETURN | return
    }

    getRuleContext(AnnotationMethodRestContext.class ,  {

IntegerLiteral | 0 } ) ;  }public AnnotationConstantRestContextannotationConstantRest()
{
    {
        RETURN | return
    }

    getRuleContext(AnnotationConstantRestContext.class ,  {

IntegerLiteral | 0 } ) ;  }public AnnotationMethodOrConstantRestContext(ParserRuleContext parent, {
    INT | int
}

invokingState ) { {SUPER |super } (
parent , invokingState ) ;  } {AT | @ }Override public {
INT |int }
getRuleIndex()
{
    {
        RETURN | return
    }

    RULE_annotationMethodOrConstantRest;
} {

AT | @ }Override public void enterRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterAnnotationMethodOrConstantRest(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public void exitRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitAnnotationMethodOrConstantRest(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public {
LT | < }T {
GT | > }Taccept(ParseTreeVisitor
{
    LT | <
} {

QUESTION |? } {
EXTENDS |extends }
T {
GT | > }visitor ) { {IF | if } (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) {RETURN | return } ( (JavaVisitor {
LT | < } {QUESTION |? } {
EXTENDS |extends }
T {
GT | > } )visitor ) .visitAnnotationMethodOrConstantRest(
{
    THIS | this
} ) ;  {

ELSE | else } {RETURN | return }visitor.visitChildren ( {THIS |this
} ) ;  } }

public {
FINAL |final }
AnnotationMethodOrConstantRestContextannotationMethodOrConstantRest()
{
    AnnotationMethodOrConstantRestContext _localctx = new AnnotationMethodOrConstantRestContext(_ctx, getState());
    enterRule(_localctx, {
        IntegerLiteral | 124
    } , 

    RULE_annotationMethodOrConstantRest )
    ;
    try
    {
        setState(
        {
            IntegerLiteral | 783
        } )

        ;
        {
            SWITCH | switch
            }

            (getInterpreter().adaptivePredict(_input, {
                IntegerLiteral | 90
            } , 

            _ctx ) )
            {
                {
                    CASE |  case
                }

                {
                    IntegerLiteral | 1
                }

                {
                    COLON |  : 
                }

                enterOuterAlt(_localctx, {
                    IntegerLiteral | 1
                } )

                ;
                {
                    setState(
                    {
                        IntegerLiteral | 781
                    } )

                    ;
                    annotationMethodRest();
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                {
                    IntegerLiteral | 2
                }

                {
                    COLON |  : 
                }

                enterOuterAlt(_localctx, {
                    IntegerLiteral | 2
                } )

                ;
                {
                    setState(
                    {
                        IntegerLiteral | 782
                    } )

                    ;
                    annotationConstantRest();
                }

                {
                    BREAK | break
                }

                ;
            }
        }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(
        {
            THIS | this
        } , 

        re )
        ;
        _errHandler.recover(
        {
            THIS | this
        } , 

        re )
        ;
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        {
            RETURN | return
        }

        _localctx;
    }

public static class AnnotationMethodRestContext
{
    EXTENDS |extends
}

ParserRuleContext {
public TerminalNodeIdentifier()
{
    {
        RETURN | return
    }

    getToken(JavaParser.Identifier, {
        IntegerLiteral | 0
    } )

    ;
}

public DefaultValueContextdefaultValue()
{
    {
        RETURN | return
    }

    getRuleContext(DefaultValueContext.class ,  {

IntegerLiteral | 0 } ) ;  }public AnnotationMethodRestContext(ParserRuleContext parent, {
    INT | int
}

invokingState ) { {SUPER |super } (
parent , invokingState ) ;  } {AT | @ }Override public {
INT |int }
getRuleIndex()
{
    {
        RETURN | return
    }

    RULE_annotationMethodRest;
} {

AT | @ }Override public void enterRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterAnnotationMethodRest(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public void exitRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitAnnotationMethodRest(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public {
LT | < }T {
GT | > }Taccept(ParseTreeVisitor
{
    LT | <
} {

QUESTION |? } {
EXTENDS |extends }
T {
GT | > }visitor ) { {IF | if } (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) {RETURN | return } ( (JavaVisitor {
LT | < } {QUESTION |? } {
EXTENDS |extends }
T {
GT | > } )visitor ) .visitAnnotationMethodRest(
{
    THIS | this
} ) ;  {

ELSE | else } {RETURN | return }visitor.visitChildren ( {THIS |this
} ) ;  } }

public {
FINAL |final }
AnnotationMethodRestContextannotationMethodRest()
{
    AnnotationMethodRestContext _localctx = new AnnotationMethodRestContext(_ctx, getState());
    enterRule(_localctx, {
        IntegerLiteral | 126
    } , 

    RULE_annotationMethodRest )
    ;
    {
        INT | int
    }

    _la;
    try
    {
        enterOuterAlt(_localctx, {
            IntegerLiteral | 1
        } )

        ;
        {
            setState(
            {
                IntegerLiteral | 785
            } )

            ;
            match(Identifier);
            setState(
            {
                IntegerLiteral | 786
            } )

            ;
            match(LPAREN);
            setState(
            {
                IntegerLiteral | 787
            } )

            ;
            match(RPAREN);
            setState(
            {
                IntegerLiteral | 789
            } )

            ;
            _la = _input.LA(
            {
                IntegerLiteral | 1
            } )

            ;
            {
                IF | if
            }

            (_la
            {
                EQUAL |= =
            }

            DEFAULT )
            {
                {
                    setState(
                    {
                        IntegerLiteral | 788
                    } )

                    ;
                    defaultValue();
                }
            }
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(
        {
            THIS | this
        } , 

        re )
        ;
        _errHandler.recover(
        {
            THIS | this
        } , 

        re )
        ;
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        {
            RETURN | return
        }

        _localctx;
    }

public static class AnnotationConstantRestContext
{
    EXTENDS |extends
}

ParserRuleContext {
public VariableDeclaratorsContextvariableDeclarators()
{
    {
        RETURN | return
    }

    getRuleContext(VariableDeclaratorsContext.class ,  {

IntegerLiteral | 0 } ) ;  }public AnnotationConstantRestContext(ParserRuleContext parent, {
    INT | int
}

invokingState ) { {SUPER |super } (
parent , invokingState ) ;  } {AT | @ }Override public {
INT |int }
getRuleIndex()
{
    {
        RETURN | return
    }

    RULE_annotationConstantRest;
} {

AT | @ }Override public void enterRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterAnnotationConstantRest(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public void exitRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitAnnotationConstantRest(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public {
LT | < }T {
GT | > }Taccept(ParseTreeVisitor
{
    LT | <
} {

QUESTION |? } {
EXTENDS |extends }
T {
GT | > }visitor ) { {IF | if } (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) {RETURN | return } ( (JavaVisitor {
LT | < } {QUESTION |? } {
EXTENDS |extends }
T {
GT | > } )visitor ) .visitAnnotationConstantRest(
{
    THIS | this
} ) ;  {

ELSE | else } {RETURN | return }visitor.visitChildren ( {THIS |this
} ) ;  } }

public {
FINAL |final }
AnnotationConstantRestContextannotationConstantRest()
{
    AnnotationConstantRestContext _localctx = new AnnotationConstantRestContext(_ctx, getState());
    enterRule(_localctx, {
        IntegerLiteral | 128
    } , 

    RULE_annotationConstantRest )
    ;
    try
    {
        enterOuterAlt(_localctx, {
            IntegerLiteral | 1
        } )

        ;
        {
            setState(
            {
                IntegerLiteral | 791
            } )

            ;
            variableDeclarators();
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(
        {
            THIS | this
        } , 

        re )
        ;
        _errHandler.recover(
        {
            THIS | this
        } , 

        re )
        ;
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        {
            RETURN | return
        }

        _localctx;
    }

public static class DefaultValueContext
{
    EXTENDS |extends
}

ParserRuleContext {
public ElementValueContextelementValue()
{
    {
        RETURN | return
    }

    getRuleContext(ElementValueContext.class ,  {

IntegerLiteral | 0 } ) ;  }public DefaultValueContext(ParserRuleContext parent, {
    INT | int
}

invokingState ) { {SUPER |super } (
parent , invokingState ) ;  } {AT | @ }Override public {
INT |int }
getRuleIndex()
{
    {
        RETURN | return
    }

    RULE_defaultValue;
} {

AT | @ }Override public void enterRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterDefaultValue(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public void exitRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitDefaultValue(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public {
LT | < }T {
GT | > }Taccept(ParseTreeVisitor
{
    LT | <
} {

QUESTION |? } {
EXTENDS |extends }
T {
GT | > }visitor ) { {IF | if } (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) {RETURN | return } ( (JavaVisitor {
LT | < } {QUESTION |? } {
EXTENDS |extends }
T {
GT | > } )visitor ) .visitDefaultValue(
{
    THIS | this
} ) ;  {

ELSE | else } {RETURN | return }visitor.visitChildren ( {THIS |this
} ) ;  } }

public {
FINAL |final }
DefaultValueContextdefaultValue()
{
    DefaultValueContext _localctx = new DefaultValueContext(_ctx, getState());
    enterRule(_localctx, {
        IntegerLiteral | 130
    } , 

    RULE_defaultValue )
    ;
    try
    {
        enterOuterAlt(_localctx, {
            IntegerLiteral | 1
        } )

        ;
        {
            setState(
            {
                IntegerLiteral | 793
            } )

            ;
            match(DEFAULT);
            setState(
            {
                IntegerLiteral | 794
            } )

            ;
            elementValue();
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(
        {
            THIS | this
        } , 

        re )
        ;
        _errHandler.recover(
        {
            THIS | this
        } , 

        re )
        ;
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        {
            RETURN | return
        }

        _localctx;
    }

public static class BlockContext
{
    EXTENDS |extends
}

ParserRuleContext {
public List {
LT | < }BlockStatementContext {
GT | > }blockStatement()
{
    {
        RETURN | return
    }

    getRuleContexts(BlockStatementContext.class ) ;  }

public BlockStatementContextblockStatement(
{
    INT | int
}

i ) { {RETURN | return }getRuleContext(BlockStatementContext.class , 

i ) ;  }public BlockContext(ParserRuleContext parent, {
    INT | int
}

invokingState ) { {SUPER |super } (
parent , invokingState ) ;  } {AT | @ }Override public {
INT |int }
getRuleIndex()
{
    {
        RETURN | return
    }

    RULE_block;
} {

AT | @ }Override public void enterRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterBlock(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public void exitRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitBlock(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public {
LT | < }T {
GT | > }Taccept(ParseTreeVisitor
{
    LT | <
} {

QUESTION |? } {
EXTENDS |extends }
T {
GT | > }visitor ) { {IF | if } (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) {RETURN | return } ( (JavaVisitor {
LT | < } {QUESTION |? } {
EXTENDS |extends }
T {
GT | > } )visitor ) .visitBlock(
{
    THIS | this
} ) ;  {

ELSE | else } {RETURN | return }visitor.visitChildren ( {THIS |this
} ) ;  } }

public {
FINAL |final }
BlockContextblock()
{
    BlockContext _localctx = new BlockContext(_ctx, getState());
    enterRule(_localctx, {
        IntegerLiteral | 132
    } , 

    RULE_block )
    ;
    {
        INT | int
    }

    _la;
    try
    {
        enterOuterAlt(_localctx, {
            IntegerLiteral | 1
        } )

        ;
        {
            setState(
            {
                IntegerLiteral | 796
            } )

            ;
            match(LBRACE);
            setState(
            {
                IntegerLiteral | 800
            } )

            ;
            _errHandler.sync(
            {
                THIS | this
            } )

            ;
            _la = _input.LA(
            {
                IntegerLiteral | 1
            } )

            ;
            {
                WHILE | while
            }

            ((((_la)
            {
                BITAND | &
            }

            {
                TILDE | ~
            }

            {
                IntegerLiteral | 0x3f
            } )

            {
                EQUAL |= =
            }

            {
                IntegerLiteral | 0
            }

            {
                AND | &&
            }

            ((
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            _la )
            {
                BITAND | &
            }

            ((
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            ABSTRACT )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            ASSERT )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            BOOLEAN )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            BREAK )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            BYTE )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            CHAR )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            CLASS )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            CONTINUE )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            DO )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            DOUBLE )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            ENUM )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            FINAL )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            FLOAT )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            FOR )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            IF )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            INT )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            INTERFACE )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            LONG )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            NEW )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            PRIVATE )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            PROTECTED )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            PUBLIC )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            RETURN )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            SHORT )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            STATIC )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            STRICTFP )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            SUPER )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            SWITCH )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            SYNCHRONIZED )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            THIS )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            THROW )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            TRY )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            VOID )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            WHILE )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            IntegerLiteral )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            FloatingPointLiteral )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            BooleanLiteral )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            CharacterLiteral )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            StringLiteral )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            NullLiteral )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            LPAREN )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            LBRACE )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            SEMI ) ) )
            {
                NOTEQUAL | !=
            }

            {
                IntegerLiteral | 0
            } )

            {
                OR || |
            }

            ((((_la
            {
                SUB | -
            }

            {
                IntegerLiteral | 68
            } ) )

            {
                BITAND | &
            }

            {
                TILDE | ~
            }

            {
                IntegerLiteral | 0x3f
            } )

            {
                EQUAL |= =
            }

            {
                IntegerLiteral | 0
            }

            {
                AND | &&
            }

            ((
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            (_la
            {
                SUB | -
            }

            {
                IntegerLiteral | 68
            } ) )

            {
                BITAND | &
            }

            ((
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            (LT
            {
                SUB | -
            }

            {
                IntegerLiteral | 68
            } ) )

            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            (BANG
            {
                SUB | -
            }

            {
                IntegerLiteral | 68
            } ) )

            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            (TILDE
            {
                SUB | -
            }

            {
                IntegerLiteral | 68
            } ) )

            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            (INC
            {
                SUB | -
            }

            {
                IntegerLiteral | 68
            } ) )

            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            (DEC
            {
                SUB | -
            }

            {
                IntegerLiteral | 68
            } ) )

            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            (ADD
            {
                SUB | -
            }

            {
                IntegerLiteral | 68
            } ) )

            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            (SUB
            {
                SUB | -
            }

            {
                IntegerLiteral | 68
            } ) )

            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            (Identifier
            {
                SUB | -
            }

            {
                IntegerLiteral | 68
            } ) )

            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            (AT
            {
                SUB | -
            }

            {
                IntegerLiteral | 68
            } ) ) ) )

            {
                NOTEQUAL | !=
            }

            {
                IntegerLiteral | 0
            } ) )

            {
                {
                    {
                        setState(
                        {
                            IntegerLiteral | 797
                        } )

                        ;
                        blockStatement();
                    }
                }

                setState(
                {
                    IntegerLiteral | 802
                } )

                ;
                _errHandler.sync(
                {
                    THIS | this
                } )

                ;
                _la = _input.LA(
                {
                    IntegerLiteral | 1
                } )

                ;
            }

            setState(
            {
                IntegerLiteral | 803
            } )

            ;
            match(RBRACE);
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(
        {
            THIS | this
        } , 

        re )
        ;
        _errHandler.recover(
        {
            THIS | this
        } , 

        re )
        ;
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        {
            RETURN | return
        }

        _localctx;
    }

public static class BlockStatementContext
{
    EXTENDS |extends
}

ParserRuleContext {
public TypeDeclarationContexttypeDeclaration()
{
    {
        RETURN | return
    }

    getRuleContext(TypeDeclarationContext.class ,  {

IntegerLiteral | 0 } ) ;  }public StatementContextstatement()
{
    {
        RETURN | return
    }

    getRuleContext(StatementContext.class ,  {

IntegerLiteral | 0 } ) ;  }public LocalVariableDeclarationStatementContextlocalVariableDeclarationStatement()
{
    {
        RETURN | return
    }

    getRuleContext(LocalVariableDeclarationStatementContext.class ,  {

IntegerLiteral | 0 } ) ;  }public BlockStatementContext(ParserRuleContext parent, {
    INT | int
}

invokingState ) { {SUPER |super } (
parent , invokingState ) ;  } {AT | @ }Override public {
INT |int }
getRuleIndex()
{
    {
        RETURN | return
    }

    RULE_blockStatement;
} {

AT | @ }Override public void enterRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterBlockStatement(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public void exitRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitBlockStatement(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public {
LT | < }T {
GT | > }Taccept(ParseTreeVisitor
{
    LT | <
} {

QUESTION |? } {
EXTENDS |extends }
T {
GT | > }visitor ) { {IF | if } (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) {RETURN | return } ( (JavaVisitor {
LT | < } {QUESTION |? } {
EXTENDS |extends }
T {
GT | > } )visitor ) .visitBlockStatement(
{
    THIS | this
} ) ;  {

ELSE | else } {RETURN | return }visitor.visitChildren ( {THIS |this
} ) ;  } }

public {
FINAL |final }
BlockStatementContextblockStatement()
{
    BlockStatementContext _localctx = new BlockStatementContext(_ctx, getState());
    enterRule(_localctx, {
        IntegerLiteral | 134
    } , 

    RULE_blockStatement )
    ;
    try
    {
        setState(
        {
            IntegerLiteral | 808
        } )

        ;
        {
            SWITCH | switch
            }

            (getInterpreter().adaptivePredict(_input, {
                IntegerLiteral | 93
            } , 

            _ctx ) )
            {
                {
                    CASE |  case
                }

                {
                    IntegerLiteral | 1
                }

                {
                    COLON |  : 
                }

                enterOuterAlt(_localctx, {
                    IntegerLiteral | 1
                } )

                ;
                {
                    setState(
                    {
                        IntegerLiteral | 805
                    } )

                    ;
                    localVariableDeclarationStatement();
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                {
                    IntegerLiteral | 2
                }

                {
                    COLON |  : 
                }

                enterOuterAlt(_localctx, {
                    IntegerLiteral | 2
                } )

                ;
                {
                    setState(
                    {
                        IntegerLiteral | 806
                    } )

                    ;
                    statement();
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                {
                    IntegerLiteral | 3
                }

                {
                    COLON |  : 
                }

                enterOuterAlt(_localctx, {
                    IntegerLiteral | 3
                } )

                ;
                {
                    setState(
                    {
                        IntegerLiteral | 807
                    } )

                    ;
                    typeDeclaration();
                }

                {
                    BREAK | break
                }

                ;
            }
        }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(
        {
            THIS | this
        } , 

        re )
        ;
        _errHandler.recover(
        {
            THIS | this
        } , 

        re )
        ;
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        {
            RETURN | return
        }

        _localctx;
    }

public static class LocalVariableDeclarationStatementContext
{
    EXTENDS |extends
}

ParserRuleContext {
public LocalVariableDeclarationContextlocalVariableDeclaration()
{
    {
        RETURN | return
    }

    getRuleContext(LocalVariableDeclarationContext.class ,  {

IntegerLiteral | 0 } ) ;  }public LocalVariableDeclarationStatementContext(ParserRuleContext parent, {
    INT | int
}

invokingState ) { {SUPER |super } (
parent , invokingState ) ;  } {AT | @ }Override public {
INT |int }
getRuleIndex()
{
    {
        RETURN | return
    }

    RULE_localVariableDeclarationStatement;
} {

AT | @ }Override public void enterRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterLocalVariableDeclarationStatement(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public void exitRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitLocalVariableDeclarationStatement(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public {
LT | < }T {
GT | > }Taccept(ParseTreeVisitor
{
    LT | <
} {

QUESTION |? } {
EXTENDS |extends }
T {
GT | > }visitor ) { {IF | if } (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) {RETURN | return } ( (JavaVisitor {
LT | < } {QUESTION |? } {
EXTENDS |extends }
T {
GT | > } )visitor ) .visitLocalVariableDeclarationStatement(
{
    THIS | this
} ) ;  {

ELSE | else } {RETURN | return }visitor.visitChildren ( {THIS |this
} ) ;  } }

public {
FINAL |final }
LocalVariableDeclarationStatementContextlocalVariableDeclarationStatement()
{
    LocalVariableDeclarationStatementContext _localctx = new LocalVariableDeclarationStatementContext(_ctx, getState());
    enterRule(_localctx, {
        IntegerLiteral | 136
    } , 

    RULE_localVariableDeclarationStatement )
    ;
    try
    {
        enterOuterAlt(_localctx, {
            IntegerLiteral | 1
        } )

        ;
        {
            setState(
            {
                IntegerLiteral | 810
            } )

            ;
            localVariableDeclaration();
            setState(
            {
                IntegerLiteral | 811
            } )

            ;
            match(SEMI);
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(
        {
            THIS | this
        } , 

        re )
        ;
        _errHandler.recover(
        {
            THIS | this
        } , 

        re )
        ;
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        {
            RETURN | return
        }

        _localctx;
    }

public static class LocalVariableDeclarationContext
{
    EXTENDS |extends
}

ParserRuleContext {
public VariableModifierContextvariableModifier(
{
    INT | int
}

i ) { {RETURN | return }getRuleContext(VariableModifierContext.class , 

i ) ;  }public List {
LT | < }VariableModifierContext {
GT | > }variableModifier()
{
    {
        RETURN | return
    }

    getRuleContexts(VariableModifierContext.class ) ;  }

public VariableDeclaratorsContextvariableDeclarators()
{
    {
        RETURN | return
    }

    getRuleContext(VariableDeclaratorsContext.class ,  {

IntegerLiteral | 0 } ) ;  }public TypeContexttype()
{
    {
        RETURN | return
    }

    getRuleContext(TypeContext.class ,  {

IntegerLiteral | 0 } ) ;  }public LocalVariableDeclarationContext(ParserRuleContext parent, {
    INT | int
}

invokingState ) { {SUPER |super } (
parent , invokingState ) ;  } {AT | @ }Override public {
INT |int }
getRuleIndex()
{
    {
        RETURN | return
    }

    RULE_localVariableDeclaration;
} {

AT | @ }Override public void enterRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterLocalVariableDeclaration(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public void exitRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitLocalVariableDeclaration(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public {
LT | < }T {
GT | > }Taccept(ParseTreeVisitor
{
    LT | <
} {

QUESTION |? } {
EXTENDS |extends }
T {
GT | > }visitor ) { {IF | if } (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) {RETURN | return } ( (JavaVisitor {
LT | < } {QUESTION |? } {
EXTENDS |extends }
T {
GT | > } )visitor ) .visitLocalVariableDeclaration(
{
    THIS | this
} ) ;  {

ELSE | else } {RETURN | return }visitor.visitChildren ( {THIS |this
} ) ;  } }

public {
FINAL |final }
LocalVariableDeclarationContextlocalVariableDeclaration()
{
    LocalVariableDeclarationContext _localctx = new LocalVariableDeclarationContext(_ctx, getState());
    enterRule(_localctx, {
        IntegerLiteral | 138
    } , 

    RULE_localVariableDeclaration )
    ;
    {
        INT | int
    }

    _la;
    try
    {
        enterOuterAlt(_localctx, {
            IntegerLiteral | 1
        } )

        ;
        {
            setState(
            {
                IntegerLiteral | 816
            } )

            ;
            _errHandler.sync(
            {
                THIS | this
            } )

            ;
            _la = _input.LA(
            {
                IntegerLiteral | 1
            } )

            ;
            {
                WHILE | while
            }

            (_la
            {
                EQUAL |= =
            }

            FINAL
            {
                OR || |
            }

            _la
            {
                EQUAL |= =
            }

            AT )
            {
                {
                    {
                        setState(
                        {
                            IntegerLiteral | 813
                        } )

                        ;
                        variableModifier();
                    }
                }

                setState(
                {
                    IntegerLiteral | 818
                } )

                ;
                _errHandler.sync(
                {
                    THIS | this
                } )

                ;
                _la = _input.LA(
                {
                    IntegerLiteral | 1
                } )

                ;
            }

            setState(
            {
                IntegerLiteral | 819
            } )

            ;
            type();
            setState(
            {
                IntegerLiteral | 820
            } )

            ;
            variableDeclarators();
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(
        {
            THIS | this
        } , 

        re )
        ;
        _errHandler.recover(
        {
            THIS | this
        } , 

        re )
        ;
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        {
            RETURN | return
        }

        _localctx;
    }

public static class StatementContext
{
    EXTENDS |extends
}

ParserRuleContext {
public ExpressionContextexpression(
{
    INT | int
}

i ) { {RETURN | return }getRuleContext(ExpressionContext.class , 

i ) ;  }public StatementExpressionContextstatementExpression()
{
    {
        RETURN | return
    }

    getRuleContext(StatementExpressionContext.class ,  {

IntegerLiteral | 0 } ) ;  }public StatementContextstatement(
{
    INT | int
}

i ) { {RETURN | return }getRuleContext(StatementContext.class , 

i ) ;  }public List {
LT | < }SwitchLabelContext {
GT | > }switchLabel()
{
    {
        RETURN | return
    }

    getRuleContexts(SwitchLabelContext.class ) ;  }

public List {
LT | < }SwitchBlockStatementGroupContext {
GT | > }switchBlockStatementGroup()
{
    {
        RETURN | return
    }

    getRuleContexts(SwitchBlockStatementGroupContext.class ) ;  }

public ParExpressionContextparExpression()
{
    {
        RETURN | return
    }

    getRuleContext(ParExpressionContext.class ,  {

IntegerLiteral | 0 } ) ;  }public List {
LT | < }CatchClauseContext {
GT | > }catchClause()
{
    {
        RETURN | return
    }

    getRuleContexts(CatchClauseContext.class ) ;  }

public CatchClauseContextcatchClause(
{
    INT | int
}

i ) { {RETURN | return }getRuleContext(CatchClauseContext.class , 

i ) ;  }public TerminalNodeIdentifier()
{
    {
        RETURN | return
    }

    getToken(JavaParser.Identifier, {
        IntegerLiteral | 0
    } )

    ;
}

public FinallyBlockContextfinallyBlock()
{
    {
        RETURN | return
    }

    getRuleContext(FinallyBlockContext.class ,  {

IntegerLiteral | 0 } ) ;  }public SwitchBlockStatementGroupContextswitchBlockStatementGroup(
{
    INT | int
}

i ) { {RETURN | return }getRuleContext(SwitchBlockStatementGroupContext.class , 

i ) ;  }public ForControlContextforControl()
{
    {
        RETURN | return
    }

    getRuleContext(ForControlContext.class ,  {

IntegerLiteral | 0 } ) ;  }public TerminalNodeASSERT()
{
    {
        RETURN | return
    }

    getToken(JavaParser.ASSERT, {
        IntegerLiteral | 0
    } )

    ;
}

public ResourceSpecificationContextresourceSpecification()
{
    {
        RETURN | return
    }

    getRuleContext(ResourceSpecificationContext.class ,  {

IntegerLiteral | 0 } ) ;  }public List {
LT | < }StatementContext {
GT | > }statement()
{
    {
        RETURN | return
    }

    getRuleContexts(StatementContext.class ) ;  }

public BlockContextblock()
{
    {
        RETURN | return
    }

    getRuleContext(BlockContext.class ,  {

IntegerLiteral | 0 } ) ;  }public List {
LT | < }ExpressionContext {
GT | > }expression()
{
    {
        RETURN | return
    }

    getRuleContexts(ExpressionContext.class ) ;  }

public SwitchLabelContextswitchLabel(
{
    INT | int
}

i ) { {RETURN | return }getRuleContext(SwitchLabelContext.class , 

i ) ;  }public StatementContext(ParserRuleContext parent, {
    INT | int
}

invokingState ) { {SUPER |super } (
parent , invokingState ) ;  } {AT | @ }Override public {
INT |int }
getRuleIndex()
{
    {
        RETURN | return
    }

    RULE_statement;
} {

AT | @ }Override public void enterRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterStatement(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public void exitRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitStatement(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public {
LT | < }T {
GT | > }Taccept(ParseTreeVisitor
{
    LT | <
} {

QUESTION |? } {
EXTENDS |extends }
T {
GT | > }visitor ) { {IF | if } (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) {RETURN | return } ( (JavaVisitor {
LT | < } {QUESTION |? } {
EXTENDS |extends }
T {
GT | > } )visitor ) .visitStatement(
{
    THIS | this
} ) ;  {

ELSE | else } {RETURN | return }visitor.visitChildren ( {THIS |this
} ) ;  } }

public {
FINAL |final }
StatementContextstatement()
{
    StatementContext _localctx = new StatementContext(_ctx, getState());
    enterRule(_localctx, {
        IntegerLiteral | 140
    } , 

    RULE_statement )
    ;
    {
        INT | int
    }

    _la;
    try
    {
        {
            INT | int
        }

        _alt;
        setState(
        {
            IntegerLiteral | 926
        } )

        ;
        {
            SWITCH | switch
            }

            (getInterpreter().adaptivePredict(_input, {
                IntegerLiteral | 107
            } , 

            _ctx ) )
            {
                {
                    CASE |  case
                }

                {
                    IntegerLiteral | 1
                }

                {
                    COLON |  : 
                }

                enterOuterAlt(_localctx, {
                    IntegerLiteral | 1
                } )

                ;
                {
                    setState(
                    {
                        IntegerLiteral | 822
                    } )

                    ;
                    block();
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                {
                    IntegerLiteral | 2
                }

                {
                    COLON |  : 
                }

                enterOuterAlt(_localctx, {
                    IntegerLiteral | 2
                } )

                ;
                {
                    setState(
                    {
                        IntegerLiteral | 823
                    } )

                    ;
                    match(ASSERT);
                    setState(
                    {
                        IntegerLiteral | 824
                    } )

                    ;
                    expression(
                    {
                        IntegerLiteral | 0
                    } )

                    ;
                    setState(
                    {
                        IntegerLiteral | 827
                    } )

                    ;
                    _la = _input.LA(
                    {
                        IntegerLiteral | 1
                    } )

                    ;
                    {
                        IF | if
                    }

                    (_la
                    {
                        EQUAL |= =
                    }

                    COLON )
                    {
                        {
                            setState(
                            {
                                IntegerLiteral | 825
                            } )

                            ;
                            match(COLON);
                            setState(
                            {
                                IntegerLiteral | 826
                            } )

                            ;
                            expression(
                            {
                                IntegerLiteral | 0
                            } )

                            ;
                        }
                    }

                    setState(
                    {
                        IntegerLiteral | 829
                    } )

                    ;
                    match(SEMI);
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                {
                    IntegerLiteral | 3
                }

                {
                    COLON |  : 
                }

                enterOuterAlt(_localctx, {
                    IntegerLiteral | 3
                } )

                ;
                {
                    setState(
                    {
                        IntegerLiteral | 831
                    } )

                    ;
                    match(IF);
                    setState(
                    {
                        IntegerLiteral | 832
                    } )

                    ;
                    parExpression();
                    setState(
                    {
                        IntegerLiteral | 833
                    } )

                    ;
                    statement();
                    setState(
                    {
                        IntegerLiteral | 836
                    } )

                    ;
                    {
                        SWITCH | switch
                        }

                        (getInterpreter().adaptivePredict(_input, {
                            IntegerLiteral | 96
                        } , 

                        _ctx ) )
                        {
                            {
                                CASE |  case
                            }

                            {
                                IntegerLiteral | 1
                            }

                            {
                                COLON |  : 
                            }

                            {
                                setState(
                                {
                                    IntegerLiteral | 834
                                } )

                                ;
                                match(ELSE);
                                setState(
                                {
                                    IntegerLiteral | 835
                                } )

                                ;
                                statement();
                            }

                            {
                                BREAK | break
                            }

                            ;
                        }
                    }

                    {
                        BREAK | break
                    }

                    ;
                    {
                        CASE |  case
                    }

                    {
                        IntegerLiteral | 4
                    }

                    {
                        COLON |  : 
                    }

                    enterOuterAlt(_localctx, {
                        IntegerLiteral | 4
                    } )

                    ;
                    {
                        setState(
                        {
                            IntegerLiteral | 838
                        } )

                        ;
                        match(FOR);
                        setState(
                        {
                            IntegerLiteral | 839
                        } )

                        ;
                        match(LPAREN);
                        setState(
                        {
                            IntegerLiteral | 840
                        } )

                        ;
                        forControl();
                        setState(
                        {
                            IntegerLiteral | 841
                        } )

                        ;
                        match(RPAREN);
                        setState(
                        {
                            IntegerLiteral | 842
                        } )

                        ;
                        statement();
                    }

                    {
                        BREAK | break
                    }

                    ;
                    {
                        CASE |  case
                    }

                    {
                        IntegerLiteral | 5
                    }

                    {
                        COLON |  : 
                    }

                    enterOuterAlt(_localctx, {
                        IntegerLiteral | 5
                    } )

                    ;
                    {
                        setState(
                        {
                            IntegerLiteral | 844
                        } )

                        ;
                        match(WHILE);
                        setState(
                        {
                            IntegerLiteral | 845
                        } )

                        ;
                        parExpression();
                        setState(
                        {
                            IntegerLiteral | 846
                        } )

                        ;
                        statement();
                    }

                    {
                        BREAK | break
                    }

                    ;
                    {
                        CASE |  case
                    }

                    {
                        IntegerLiteral | 6
                    }

                    {
                        COLON |  : 
                    }

                    enterOuterAlt(_localctx, {
                        IntegerLiteral | 6
                    } )

                    ;
                    {
                        setState(
                        {
                            IntegerLiteral | 848
                        } )

                        ;
                        match(DO);
                        setState(
                        {
                            IntegerLiteral | 849
                        } )

                        ;
                        statement();
                        setState(
                        {
                            IntegerLiteral | 850
                        } )

                        ;
                        match(WHILE);
                        setState(
                        {
                            IntegerLiteral | 851
                        } )

                        ;
                        parExpression();
                        setState(
                        {
                            IntegerLiteral | 852
                        } )

                        ;
                        match(SEMI);
                    }

                    {
                        BREAK | break
                    }

                    ;
                    {
                        CASE |  case
                    }

                    {
                        IntegerLiteral | 7
                    }

                    {
                        COLON |  : 
                    }

                    enterOuterAlt(_localctx, {
                        IntegerLiteral | 7
                    } )

                    ;
                    {
                        setState(
                        {
                            IntegerLiteral | 854
                        } )

                        ;
                        match(TRY);
                        setState(
                        {
                            IntegerLiteral | 855
                        } )

                        ;
                        block();
                        setState(
                        {
                            IntegerLiteral | 865
                        } )

                        ;
                        {
                            SWITCH | switch
                            }

                            (_input.LA(
                            {
                                IntegerLiteral | 1
                            } ) )

                            {
                                {
                                    CASE |  case
                                }

                                CATCH
                                {
                                    COLON |  : 
                                }

                                {
                                    setState(
                                    {
                                        IntegerLiteral | 857
                                    } )

                                    ;
                                    _errHandler.sync(
                                    {
                                        THIS | this
                                    } )

                                    ;
                                    _la = _input.LA(
                                    {
                                        IntegerLiteral | 1
                                    } )

                                    ;
                                    {
                                        DO | do
                                    }

                                    {
                                        {
                                            {
                                                setState(
                                                {
                                                    IntegerLiteral | 856
                                                } )

                                                ;
                                                catchClause();
                                            }
                                        }

                                        setState(
                                        {
                                            IntegerLiteral | 859
                                        } )

                                        ;
                                        _errHandler.sync(
                                        {
                                            THIS | this
                                        } )

                                        ;
                                        _la = _input.LA(
                                        {
                                            IntegerLiteral | 1
                                        } )

                                        ;
                                    }

                                    {
                                        WHILE | while
                                    }

                                    (_la
                                    {
                                        EQUAL |= =
                                    }

                                    CATCH )
                                    ;
                                    setState(
                                    {
                                        IntegerLiteral | 862
                                    } )

                                    ;
                                    _la = _input.LA(
                                    {
                                        IntegerLiteral | 1
                                    } )

                                    ;
                                    {
                                        IF | if
                                    }

                                    (_la
                                    {
                                        EQUAL |= =
                                    }

                                    FINALLY )
                                    {
                                        {
                                            setState(
                                            {
                                                IntegerLiteral | 861
                                            } )

                                            ;
                                            finallyBlock();
                                        }
                                    }
                                }

                                {
                                    BREAK | break
                                }

                                ;
                                {
                                    CASE |  case
                                }

                                FINALLY
                                {
                                    COLON |  : 
                                }

                                {
                                    setState(
                                    {
                                        IntegerLiteral | 864
                                    } )

                                    ;
                                    finallyBlock();
                                }

                                {
                                    BREAK | break
                                }

                                ;
                                {
                                    DEFAULT | default
                                }

                                {
                                    COLON |  : 
                                }

                                {
                                    THROW | throw
                                }

                                new NoViableAltException(
                                {
                                THIS | this
                                }

                                 )
                                ;
                            }
                        }

                        {
                            BREAK | break
                        }

                        ;
                        {
                            CASE |  case
                        }

                        {
                            IntegerLiteral | 8
                        }

                        {
                            COLON |  : 
                        }

                        enterOuterAlt(_localctx, {
                            IntegerLiteral | 8
                        } )

                        ;
                        {
                            setState(
                            {
                                IntegerLiteral | 867
                            } )

                            ;
                            match(TRY);
                            setState(
                            {
                                IntegerLiteral | 868
                            } )

                            ;
                            resourceSpecification();
                            setState(
                            {
                                IntegerLiteral | 869
                            } )

                            ;
                            block();
                            setState(
                            {
                                IntegerLiteral | 873
                            } )

                            ;
                            _errHandler.sync(
                            {
                                THIS | this
                            } )

                            ;
                            _la = _input.LA(
                            {
                                IntegerLiteral | 1
                            } )

                            ;
                            {
                                WHILE | while
                            }

                            (_la
                            {
                                EQUAL |= =
                            }

                            CATCH )
                            {
                                {
                                    {
                                        setState(
                                        {
                                            IntegerLiteral | 870
                                        } )

                                        ;
                                        catchClause();
                                    }
                                }

                                setState(
                                {
                                    IntegerLiteral | 875
                                } )

                                ;
                                _errHandler.sync(
                                {
                                    THIS | this
                                } )

                                ;
                                _la = _input.LA(
                                {
                                    IntegerLiteral | 1
                                } )

                                ;
                            }

                            setState(
                            {
                                IntegerLiteral | 877
                            } )

                            ;
                            _la = _input.LA(
                            {
                                IntegerLiteral | 1
                            } )

                            ;
                            {
                                IF | if
                            }

                            (_la
                            {
                                EQUAL |= =
                            }

                            FINALLY )
                            {
                                {
                                    setState(
                                    {
                                        IntegerLiteral | 876
                                    } )

                                    ;
                                    finallyBlock();
                                }
                            }
                        }

                        {
                            BREAK | break
                        }

                        ;
                        {
                            CASE |  case
                        }

                        {
                            IntegerLiteral | 9
                        }

                        {
                            COLON |  : 
                        }

                        enterOuterAlt(_localctx, {
                            IntegerLiteral | 9
                        } )

                        ;
                        {
                            setState(
                            {
                                IntegerLiteral | 879
                            } )

                            ;
                            match(SWITCH);
                            setState(
                            {
                                IntegerLiteral | 880
                            } )

                            ;
                            parExpression();
                            setState(
                            {
                                IntegerLiteral | 881
                            } )

                            ;
                            match(LBRACE);
                            setState(
                            {
                                IntegerLiteral | 885
                            } )

                            ;
                            _errHandler.sync(
                            {
                                THIS | this
                            } )

                            ;
                            _alt = getInterpreter().adaptivePredict(_input, {
                                IntegerLiteral | 102
                            } , 

                            _ctx )
                            ;
                            {
                                WHILE | while
                            }

                            (_alt
                            {
                                NOTEQUAL | !=
                            }

                            {
                                IntegerLiteral | 2
                            }

                            {
                                AND | &&
                            }

                            _alt
                            {
                                NOTEQUAL | !=
                            }

                            org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER )
                            {
                                {
                                    IF | if
                                }

                                (_alt
                                {
                                    EQUAL |= =
                                }

                                {
                                    IntegerLiteral | 1
                                } )

                                {
                                    {
                                        {
                                            setState(
                                            {
                                                IntegerLiteral | 882
                                            } )

                                            ;
                                            switchBlockStatementGroup();
                                        }
                                    }
                                }

                                setState(
                                {
                                    IntegerLiteral | 887
                                } )

                                ;
                                _errHandler.sync(
                                {
                                    THIS | this
                                } )

                                ;
                                _alt = getInterpreter().adaptivePredict(_input, {
                                    IntegerLiteral | 102
                                } , 

                                _ctx )
                                ;
                            }

                            setState(
                            {
                                IntegerLiteral | 891
                            } )

                            ;
                            _errHandler.sync(
                            {
                                THIS | this
                            } )

                            ;
                            _la = _input.LA(
                            {
                                IntegerLiteral | 1
                            } )

                            ;
                            {
                                WHILE | while
                            }

                            (_la
                            {
                                EQUAL |= =
                            }

                            CASE
                            {
                                OR || |
                            }

                            _la
                            {
                                EQUAL |= =
                            }

                            DEFAULT )
                            {
                                {
                                    {
                                        setState(
                                        {
                                            IntegerLiteral | 888
                                        } )

                                        ;
                                        switchLabel();
                                    }
                                }

                                setState(
                                {
                                    IntegerLiteral | 893
                                } )

                                ;
                                _errHandler.sync(
                                {
                                    THIS | this
                                } )

                                ;
                                _la = _input.LA(
                                {
                                    IntegerLiteral | 1
                                } )

                                ;
                            }

                            setState(
                            {
                                IntegerLiteral | 894
                            } )

                            ;
                            match(RBRACE);
                        }

                        {
                            BREAK | break
                        }

                        ;
                        {
                            CASE |  case
                        }

                        {
                            IntegerLiteral | 10
                        }

                        {
                            COLON |  : 
                        }

                        enterOuterAlt(_localctx, {
                            IntegerLiteral | 10
                        } )

                        ;
                        {
                            setState(
                            {
                                IntegerLiteral | 896
                            } )

                            ;
                            match(SYNCHRONIZED);
                            setState(
                            {
                                IntegerLiteral | 897
                            } )

                            ;
                            parExpression();
                            setState(
                            {
                                IntegerLiteral | 898
                            } )

                            ;
                            block();
                        }

                        {
                            BREAK | break
                        }

                        ;
                        {
                            CASE |  case
                        }

                        {
                            IntegerLiteral | 11
                        }

                        {
                            COLON |  : 
                        }

                        enterOuterAlt(_localctx, {
                            IntegerLiteral | 11
                        } )

                        ;
                        {
                            setState(
                            {
                                IntegerLiteral | 900
                            } )

                            ;
                            match(RETURN);
                            setState(
                            {
                                IntegerLiteral | 902
                            } )

                            ;
                            _la = _input.LA(
                            {
                                IntegerLiteral | 1
                            } )

                            ;
                            {
                                IF | if
                            }

                            ((((_la)
                            {
                                BITAND | &
                            }

                            {
                                TILDE | ~
                            }

                            {
                                IntegerLiteral | 0x3f
                            } )

                            {
                                EQUAL |= =
                            }

                            {
                                IntegerLiteral | 0
                            }

                            {
                                AND | &&
                            }

                            ((
                            {
                                IntegerLiteral | 1L
                            }

                            {
                                LT | <
                            }

                            {
                                LT | <
                            }

                            _la )
                            {
                                BITAND | &
                            }

                            ((
                            {
                                IntegerLiteral | 1L
                            }

                            {
                                LT | <
                            }

                            {
                                LT | <
                            }

                            BOOLEAN )
                            {
                                BITOR ||
                            }

                            (
                            {
                                IntegerLiteral | 1L
                            }

                            {
                                LT | <
                            }

                            {
                                LT | <
                            }

                            BYTE )
                            {
                                BITOR ||
                            }

                            (
                            {
                                IntegerLiteral | 1L
                            }

                            {
                                LT | <
                            }

                            {
                                LT | <
                            }

                            CHAR )
                            {
                                BITOR ||
                            }

                            (
                            {
                                IntegerLiteral | 1L
                            }

                            {
                                LT | <
                            }

                            {
                                LT | <
                            }

                            DOUBLE )
                            {
                                BITOR ||
                            }

                            (
                            {
                                IntegerLiteral | 1L
                            }

                            {
                                LT | <
                            }

                            {
                                LT | <
                            }

                            FLOAT )
                            {
                                BITOR ||
                            }

                            (
                            {
                                IntegerLiteral | 1L
                            }

                            {
                                LT | <
                            }

                            {
                                LT | <
                            }

                            INT )
                            {
                                BITOR ||
                            }

                            (
                            {
                                IntegerLiteral | 1L
                            }

                            {
                                LT | <
                            }

                            {
                                LT | <
                            }

                            LONG )
                            {
                                BITOR ||
                            }

                            (
                            {
                                IntegerLiteral | 1L
                            }

                            {
                                LT | <
                            }

                            {
                                LT | <
                            }

                            NEW )
                            {
                                BITOR ||
                            }

                            (
                            {
                                IntegerLiteral | 1L
                            }

                            {
                                LT | <
                            }

                            {
                                LT | <
                            }

                            SHORT )
                            {
                                BITOR ||
                            }

                            (
                            {
                                IntegerLiteral | 1L
                            }

                            {
                                LT | <
                            }

                            {
                                LT | <
                            }

                            SUPER )
                            {
                                BITOR ||
                            }

                            (
                            {
                                IntegerLiteral | 1L
                            }

                            {
                                LT | <
                            }

                            {
                                LT | <
                            }

                            THIS )
                            {
                                BITOR ||
                            }

                            (
                            {
                                IntegerLiteral | 1L
                            }

                            {
                                LT | <
                            }

                            {
                                LT | <
                            }

                            VOID )
                            {
                                BITOR ||
                            }

                            (
                            {
                                IntegerLiteral | 1L
                            }

                            {
                                LT | <
                            }

                            {
                                LT | <
                            }

                            IntegerLiteral )
                            {
                                BITOR ||
                            }

                            (
                            {
                                IntegerLiteral | 1L
                            }

                            {
                                LT | <
                            }

                            {
                                LT | <
                            }

                            FloatingPointLiteral )
                            {
                                BITOR ||
                            }

                            (
                            {
                                IntegerLiteral | 1L
                            }

                            {
                                LT | <
                            }

                            {
                                LT | <
                            }

                            BooleanLiteral )
                            {
                                BITOR ||
                            }

                            (
                            {
                                IntegerLiteral | 1L
                            }

                            {
                                LT | <
                            }

                            {
                                LT | <
                            }

                            CharacterLiteral )
                            {
                                BITOR ||
                            }

                            (
                            {
                                IntegerLiteral | 1L
                            }

                            {
                                LT | <
                            }

                            {
                                LT | <
                            }

                            StringLiteral )
                            {
                                BITOR ||
                            }

                            (
                            {
                                IntegerLiteral | 1L
                            }

                            {
                                LT | <
                            }

                            {
                                LT | <
                            }

                            NullLiteral )
                            {
                                BITOR ||
                            }

                            (
                            {
                                IntegerLiteral | 1L
                            }

                            {
                                LT | <
                            }

                            {
                                LT | <
                            }

                            LPAREN ) ) )
                            {
                                NOTEQUAL | !=
                            }

                            {
                                IntegerLiteral | 0
                            } )

                            {
                                OR || |
                            }

                            ((((_la
                            {
                                SUB | -
                            }

                            {
                                IntegerLiteral | 68
                            } ) )

                            {
                                BITAND | &
                            }

                            {
                                TILDE | ~
                            }

                            {
                                IntegerLiteral | 0x3f
                            } )

                            {
                                EQUAL |= =
                            }

                            {
                                IntegerLiteral | 0
                            }

                            {
                                AND | &&
                            }

                            ((
                            {
                                IntegerLiteral | 1L
                            }

                            {
                                LT | <
                            }

                            {
                                LT | <
                            }

                            (_la
                            {
                                SUB | -
                            }

                            {
                                IntegerLiteral | 68
                            } ) )

                            {
                                BITAND | &
                            }

                            ((
                            {
                                IntegerLiteral | 1L
                            }

                            {
                                LT | <
                            }

                            {
                                LT | <
                            }

                            (LT
                            {
                                SUB | -
                            }

                            {
                                IntegerLiteral | 68
                            } ) )

                            {
                                BITOR ||
                            }

                            (
                            {
                                IntegerLiteral | 1L
                            }

                            {
                                LT | <
                            }

                            {
                                LT | <
                            }

                            (BANG
                            {
                                SUB | -
                            }

                            {
                                IntegerLiteral | 68
                            } ) )

                            {
                                BITOR ||
                            }

                            (
                            {
                                IntegerLiteral | 1L
                            }

                            {
                                LT | <
                            }

                            {
                                LT | <
                            }

                            (TILDE
                            {
                                SUB | -
                            }

                            {
                                IntegerLiteral | 68
                            } ) )

                            {
                                BITOR ||
                            }

                            (
                            {
                                IntegerLiteral | 1L
                            }

                            {
                                LT | <
                            }

                            {
                                LT | <
                            }

                            (INC
                            {
                                SUB | -
                            }

                            {
                                IntegerLiteral | 68
                            } ) )

                            {
                                BITOR ||
                            }

                            (
                            {
                                IntegerLiteral | 1L
                            }

                            {
                                LT | <
                            }

                            {
                                LT | <
                            }

                            (DEC
                            {
                                SUB | -
                            }

                            {
                                IntegerLiteral | 68
                            } ) )

                            {
                                BITOR ||
                            }

                            (
                            {
                                IntegerLiteral | 1L
                            }

                            {
                                LT | <
                            }

                            {
                                LT | <
                            }

                            (ADD
                            {
                                SUB | -
                            }

                            {
                                IntegerLiteral | 68
                            } ) )

                            {
                                BITOR ||
                            }

                            (
                            {
                                IntegerLiteral | 1L
                            }

                            {
                                LT | <
                            }

                            {
                                LT | <
                            }

                            (SUB
                            {
                                SUB | -
                            }

                            {
                                IntegerLiteral | 68
                            } ) )

                            {
                                BITOR ||
                            }

                            (
                            {
                                IntegerLiteral | 1L
                            }

                            {
                                LT | <
                            }

                            {
                                LT | <
                            }

                            (Identifier
                            {
                                SUB | -
                            }

                            {
                                IntegerLiteral | 68
                            } ) ) ) )

                            {
                                NOTEQUAL | !=
                            }

                            {
                                IntegerLiteral | 0
                            } ) )

                            {
                                {
                                    setState(
                                    {
                                        IntegerLiteral | 901
                                    } )

                                    ;
                                    expression(
                                    {
                                        IntegerLiteral | 0
                                    } )

                                    ;
                                }
                            }

                            setState(
                            {
                                IntegerLiteral | 904
                            } )

                            ;
                            match(SEMI);
                        }

                        {
                            BREAK | break
                        }

                        ;
                        {
                            CASE |  case
                        }

                        {
                            IntegerLiteral | 12
                        }

                        {
                            COLON |  : 
                        }

                        enterOuterAlt(_localctx, {
                            IntegerLiteral | 12
                        } )

                        ;
                        {
                            setState(
                            {
                                IntegerLiteral | 905
                            } )

                            ;
                            match(THROW);
                            setState(
                            {
                                IntegerLiteral | 906
                            } )

                            ;
                            expression(
                            {
                                IntegerLiteral | 0
                            } )

                            ;
                            setState(
                            {
                                IntegerLiteral | 907
                            } )

                            ;
                            match(SEMI);
                        }

                        {
                            BREAK | break
                        }

                        ;
                        {
                            CASE |  case
                        }

                        {
                            IntegerLiteral | 13
                        }

                        {
                            COLON |  : 
                        }

                        enterOuterAlt(_localctx, {
                            IntegerLiteral | 13
                        } )

                        ;
                        {
                            setState(
                            {
                                IntegerLiteral | 909
                            } )

                            ;
                            match(BREAK);
                            setState(
                            {
                                IntegerLiteral | 911
                            } )

                            ;
                            _la = _input.LA(
                            {
                                IntegerLiteral | 1
                            } )

                            ;
                            {
                                IF | if
                            }

                            (_la
                            {
                                EQUAL |= =
                            }

                            Identifier )
                            {
                                {
                                    setState(
                                    {
                                        IntegerLiteral | 910
                                    } )

                                    ;
                                    match(Identifier);
                                }
                            }

                            setState(
                            {
                                IntegerLiteral | 913
                            } )

                            ;
                            match(SEMI);
                        }

                        {
                            BREAK | break
                        }

                        ;
                        {
                            CASE |  case
                        }

                        {
                            IntegerLiteral | 14
                        }

                        {
                            COLON |  : 
                        }

                        enterOuterAlt(_localctx, {
                            IntegerLiteral | 14
                        } )

                        ;
                        {
                            setState(
                            {
                                IntegerLiteral | 914
                            } )

                            ;
                            match(CONTINUE);
                            setState(
                            {
                                IntegerLiteral | 916
                            } )

                            ;
                            _la = _input.LA(
                            {
                                IntegerLiteral | 1
                            } )

                            ;
                            {
                                IF | if
                            }

                            (_la
                            {
                                EQUAL |= =
                            }

                            Identifier )
                            {
                                {
                                    setState(
                                    {
                                        IntegerLiteral | 915
                                    } )

                                    ;
                                    match(Identifier);
                                }
                            }

                            setState(
                            {
                                IntegerLiteral | 918
                            } )

                            ;
                            match(SEMI);
                        }

                        {
                            BREAK | break
                        }

                        ;
                        {
                            CASE |  case
                        }

                        {
                            IntegerLiteral | 15
                        }

                        {
                            COLON |  : 
                        }

                        enterOuterAlt(_localctx, {
                            IntegerLiteral | 15
                        } )

                        ;
                        {
                            setState(
                            {
                                IntegerLiteral | 919
                            } )

                            ;
                            match(SEMI);
                        }

                        {
                            BREAK | break
                        }

                        ;
                        {
                            CASE |  case
                        }

                        {
                            IntegerLiteral | 16
                        }

                        {
                            COLON |  : 
                        }

                        enterOuterAlt(_localctx, {
                            IntegerLiteral | 16
                        } )

                        ;
                        {
                            setState(
                            {
                                IntegerLiteral | 920
                            } )

                            ;
                            statementExpression();
                            setState(
                            {
                                IntegerLiteral | 921
                            } )

                            ;
                            match(SEMI);
                        }

                        {
                            BREAK | break
                        }

                        ;
                        {
                            CASE |  case
                        }

                        {
                            IntegerLiteral | 17
                        }

                        {
                            COLON |  : 
                        }

                        enterOuterAlt(_localctx, {
                            IntegerLiteral | 17
                        } )

                        ;
                        {
                            setState(
                            {
                                IntegerLiteral | 923
                            } )

                            ;
                            match(Identifier);
                            setState(
                            {
                                IntegerLiteral | 924
                            } )

                            ;
                            match(COLON);
                            setState(
                            {
                                IntegerLiteral | 925
                            } )

                            ;
                            statement();
                        }

                        {
                            BREAK | break
                        }

                        ;
                    }
                }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(
        {
            THIS | this
        } , 

        re )
        ;
        _errHandler.recover(
        {
            THIS | this
        } , 

        re )
        ;
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        {
            RETURN | return
        }

        _localctx;
    }

public static class CatchClauseContext
{
    EXTENDS |extends
}

ParserRuleContext {
public CatchTypeContextcatchType()
{
    {
        RETURN | return
    }

    getRuleContext(CatchTypeContext.class ,  {

IntegerLiteral | 0 } ) ;  }public TerminalNodeIdentifier()
{
    {
        RETURN | return
    }

    getToken(JavaParser.Identifier, {
        IntegerLiteral | 0
    } )

    ;
}

public VariableModifierContextvariableModifier(
{
    INT | int
}

i ) { {RETURN | return }getRuleContext(VariableModifierContext.class , 

i ) ;  }public List {
LT | < }VariableModifierContext {
GT | > }variableModifier()
{
    {
        RETURN | return
    }

    getRuleContexts(VariableModifierContext.class ) ;  }

public BlockContextblock()
{
    {
        RETURN | return
    }

    getRuleContext(BlockContext.class ,  {

IntegerLiteral | 0 } ) ;  }public CatchClauseContext(ParserRuleContext parent, {
    INT | int
}

invokingState ) { {SUPER |super } (
parent , invokingState ) ;  } {AT | @ }Override public {
INT |int }
getRuleIndex()
{
    {
        RETURN | return
    }

    RULE_catchClause;
} {

AT | @ }Override public void enterRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterCatchClause(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public void exitRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitCatchClause(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public {
LT | < }T {
GT | > }Taccept(ParseTreeVisitor
{
    LT | <
} {

QUESTION |? } {
EXTENDS |extends }
T {
GT | > }visitor ) { {IF | if } (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) {RETURN | return } ( (JavaVisitor {
LT | < } {QUESTION |? } {
EXTENDS |extends }
T {
GT | > } )visitor ) .visitCatchClause(
{
    THIS | this
} ) ;  {

ELSE | else } {RETURN | return }visitor.visitChildren ( {THIS |this
} ) ;  } }

public {
FINAL |final }
CatchClauseContextcatchClause()
{
    CatchClauseContext _localctx = new CatchClauseContext(_ctx, getState());
    enterRule(_localctx, {
        IntegerLiteral | 142
    } , 

    RULE_catchClause )
    ;
    {
        INT | int
    }

    _la;
    try
    {
        enterOuterAlt(_localctx, {
            IntegerLiteral | 1
        } )

        ;
        {
            setState(
            {
                IntegerLiteral | 928
            } )

            ;
            match(CATCH);
            setState(
            {
                IntegerLiteral | 929
            } )

            ;
            match(LPAREN);
            setState(
            {
                IntegerLiteral | 933
            } )

            ;
            _errHandler.sync(
            {
                THIS | this
            } )

            ;
            _la = _input.LA(
            {
                IntegerLiteral | 1
            } )

            ;
            {
                WHILE | while
            }

            (_la
            {
                EQUAL |= =
            }

            FINAL
            {
                OR || |
            }

            _la
            {
                EQUAL |= =
            }

            AT )
            {
                {
                    {
                        setState(
                        {
                            IntegerLiteral | 930
                        } )

                        ;
                        variableModifier();
                    }
                }

                setState(
                {
                    IntegerLiteral | 935
                } )

                ;
                _errHandler.sync(
                {
                    THIS | this
                } )

                ;
                _la = _input.LA(
                {
                    IntegerLiteral | 1
                } )

                ;
            }

            setState(
            {
                IntegerLiteral | 936
            } )

            ;
            catchType();
            setState(
            {
                IntegerLiteral | 937
            } )

            ;
            match(Identifier);
            setState(
            {
                IntegerLiteral | 938
            } )

            ;
            match(RPAREN);
            setState(
            {
                IntegerLiteral | 939
            } )

            ;
            block();
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(
        {
            THIS | this
        } , 

        re )
        ;
        _errHandler.recover(
        {
            THIS | this
        } , 

        re )
        ;
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        {
            RETURN | return
        }

        _localctx;
    }

public static class CatchTypeContext
{
    EXTENDS |extends
}

ParserRuleContext {
public List {
LT | < }QualifiedNameContext {
GT | > }qualifiedName()
{
    {
        RETURN | return
    }

    getRuleContexts(QualifiedNameContext.class ) ;  }

public QualifiedNameContextqualifiedName(
{
    INT | int
}

i ) { {RETURN | return }getRuleContext(QualifiedNameContext.class , 

i ) ;  }public CatchTypeContext(ParserRuleContext parent, {
    INT | int
}

invokingState ) { {SUPER |super } (
parent , invokingState ) ;  } {AT | @ }Override public {
INT |int }
getRuleIndex()
{
    {
        RETURN | return
    }

    RULE_catchType;
} {

AT | @ }Override public void enterRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterCatchType(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public void exitRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitCatchType(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public {
LT | < }T {
GT | > }Taccept(ParseTreeVisitor
{
    LT | <
} {

QUESTION |? } {
EXTENDS |extends }
T {
GT | > }visitor ) { {IF | if } (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) {RETURN | return } ( (JavaVisitor {
LT | < } {QUESTION |? } {
EXTENDS |extends }
T {
GT | > } )visitor ) .visitCatchType(
{
    THIS | this
} ) ;  {

ELSE | else } {RETURN | return }visitor.visitChildren ( {THIS |this
} ) ;  } }

public {
FINAL |final }
CatchTypeContextcatchType()
{
    CatchTypeContext _localctx = new CatchTypeContext(_ctx, getState());
    enterRule(_localctx, {
        IntegerLiteral | 144
    } , 

    RULE_catchType )
    ;
    {
        INT | int
    }

    _la;
    try
    {
        enterOuterAlt(_localctx, {
            IntegerLiteral | 1
        } )

        ;
        {
            setState(
            {
                IntegerLiteral | 941
            } )

            ;
            qualifiedName();
            setState(
            {
                IntegerLiteral | 946
            } )

            ;
            _errHandler.sync(
            {
                THIS | this
            } )

            ;
            _la = _input.LA(
            {
                IntegerLiteral | 1
            } )

            ;
            {
                WHILE | while
            }

            (_la
            {
                EQUAL |= =
            }

            BITOR )
            {
                {
                    {
                        setState(
                        {
                            IntegerLiteral | 942
                        } )

                        ;
                        match(BITOR);
                        setState(
                        {
                            IntegerLiteral | 943
                        } )

                        ;
                        qualifiedName();
                    }
                }

                setState(
                {
                    IntegerLiteral | 948
                } )

                ;
                _errHandler.sync(
                {
                    THIS | this
                } )

                ;
                _la = _input.LA(
                {
                    IntegerLiteral | 1
                } )

                ;
            }
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(
        {
            THIS | this
        } , 

        re )
        ;
        _errHandler.recover(
        {
            THIS | this
        } , 

        re )
        ;
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        {
            RETURN | return
        }

        _localctx;
    }

public static class FinallyBlockContext
{
    EXTENDS |extends
}

ParserRuleContext {
public BlockContextblock()
{
    {
        RETURN | return
    }

    getRuleContext(BlockContext.class ,  {

IntegerLiteral | 0 } ) ;  }public FinallyBlockContext(ParserRuleContext parent, {
    INT | int
}

invokingState ) { {SUPER |super } (
parent , invokingState ) ;  } {AT | @ }Override public {
INT |int }
getRuleIndex()
{
    {
        RETURN | return
    }

    RULE_finallyBlock;
} {

AT | @ }Override public void enterRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterFinallyBlock(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public void exitRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitFinallyBlock(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public {
LT | < }T {
GT | > }Taccept(ParseTreeVisitor
{
    LT | <
} {

QUESTION |? } {
EXTENDS |extends }
T {
GT | > }visitor ) { {IF | if } (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) {RETURN | return } ( (JavaVisitor {
LT | < } {QUESTION |? } {
EXTENDS |extends }
T {
GT | > } )visitor ) .visitFinallyBlock(
{
    THIS | this
} ) ;  {

ELSE | else } {RETURN | return }visitor.visitChildren ( {THIS |this
} ) ;  } }

public {
FINAL |final }
FinallyBlockContextfinallyBlock()
{
    FinallyBlockContext _localctx = new FinallyBlockContext(_ctx, getState());
    enterRule(_localctx, {
        IntegerLiteral | 146
    } , 

    RULE_finallyBlock )
    ;
    try
    {
        enterOuterAlt(_localctx, {
            IntegerLiteral | 1
        } )

        ;
        {
            setState(
            {
                IntegerLiteral | 949
            } )

            ;
            match(FINALLY);
            setState(
            {
                IntegerLiteral | 950
            } )

            ;
            block();
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(
        {
            THIS | this
        } , 

        re )
        ;
        _errHandler.recover(
        {
            THIS | this
        } , 

        re )
        ;
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        {
            RETURN | return
        }

        _localctx;
    }

public static class ResourceSpecificationContext
{
    EXTENDS |extends
}

ParserRuleContext {
public ResourcesContextresources()
{
    {
        RETURN | return
    }

    getRuleContext(ResourcesContext.class ,  {

IntegerLiteral | 0 } ) ;  }public ResourceSpecificationContext(ParserRuleContext parent, {
    INT | int
}

invokingState ) { {SUPER |super } (
parent , invokingState ) ;  } {AT | @ }Override public {
INT |int }
getRuleIndex()
{
    {
        RETURN | return
    }

    RULE_resourceSpecification;
} {

AT | @ }Override public void enterRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterResourceSpecification(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public void exitRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitResourceSpecification(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public {
LT | < }T {
GT | > }Taccept(ParseTreeVisitor
{
    LT | <
} {

QUESTION |? } {
EXTENDS |extends }
T {
GT | > }visitor ) { {IF | if } (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) {RETURN | return } ( (JavaVisitor {
LT | < } {QUESTION |? } {
EXTENDS |extends }
T {
GT | > } )visitor ) .visitResourceSpecification(
{
    THIS | this
} ) ;  {

ELSE | else } {RETURN | return }visitor.visitChildren ( {THIS |this
} ) ;  } }

public {
FINAL |final }
ResourceSpecificationContextresourceSpecification()
{
    ResourceSpecificationContext _localctx = new ResourceSpecificationContext(_ctx, getState());
    enterRule(_localctx, {
        IntegerLiteral | 148
    } , 

    RULE_resourceSpecification )
    ;
    {
        INT | int
    }

    _la;
    try
    {
        enterOuterAlt(_localctx, {
            IntegerLiteral | 1
        } )

        ;
        {
            setState(
            {
                IntegerLiteral | 952
            } )

            ;
            match(LPAREN);
            setState(
            {
                IntegerLiteral | 953
            } )

            ;
            resources();
            setState(
            {
                IntegerLiteral | 955
            } )

            ;
            _la = _input.LA(
            {
                IntegerLiteral | 1
            } )

            ;
            {
                IF | if
            }

            (_la
            {
                EQUAL |= =
            }

            SEMI )
            {
                {
                    setState(
                    {
                        IntegerLiteral | 954
                    } )

                    ;
                    match(SEMI);
                }
            }

            setState(
            {
                IntegerLiteral | 957
            } )

            ;
            match(RPAREN);
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(
        {
            THIS | this
        } , 

        re )
        ;
        _errHandler.recover(
        {
            THIS | this
        } , 

        re )
        ;
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        {
            RETURN | return
        }

        _localctx;
    }

public static class ResourcesContext
{
    EXTENDS |extends
}

ParserRuleContext {
public ResourceContextresource(
{
    INT | int
}

i ) { {RETURN | return }getRuleContext(ResourceContext.class , 

i ) ;  }public List {
LT | < }ResourceContext {
GT | > }resource()
{
    {
        RETURN | return
    }

    getRuleContexts(ResourceContext.class ) ;  }

public ResourcesContext(ParserRuleContext parent, {
    INT | int
}

invokingState ) { {SUPER |super } (
parent , invokingState ) ;  } {AT | @ }Override public {
INT |int }
getRuleIndex()
{
    {
        RETURN | return
    }

    RULE_resources;
} {

AT | @ }Override public void enterRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterResources(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public void exitRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitResources(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public {
LT | < }T {
GT | > }Taccept(ParseTreeVisitor
{
    LT | <
} {

QUESTION |? } {
EXTENDS |extends }
T {
GT | > }visitor ) { {IF | if } (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) {RETURN | return } ( (JavaVisitor {
LT | < } {QUESTION |? } {
EXTENDS |extends }
T {
GT | > } )visitor ) .visitResources(
{
    THIS | this
} ) ;  {

ELSE | else } {RETURN | return }visitor.visitChildren ( {THIS |this
} ) ;  } }

public {
FINAL |final }
ResourcesContextresources()
{
    ResourcesContext _localctx = new ResourcesContext(_ctx, getState());
    enterRule(_localctx, {
        IntegerLiteral | 150
    } , 

    RULE_resources )
    ;
    try
    {
        {
            INT | int
        }

        _alt;
        enterOuterAlt(_localctx, {
            IntegerLiteral | 1
        } )

        ;
        {
            setState(
            {
                IntegerLiteral | 959
            } )

            ;
            resource();
            setState(
            {
                IntegerLiteral | 964
            } )

            ;
            _errHandler.sync(
            {
                THIS | this
            } )

            ;
            _alt = getInterpreter().adaptivePredict(_input, {
                IntegerLiteral | 111
            } , 

            _ctx )
            ;
            {
                WHILE | while
            }

            (_alt
            {
                NOTEQUAL | !=
            }

            {
                IntegerLiteral | 2
            }

            {
                AND | &&
            }

            _alt
            {
                NOTEQUAL | !=
            }

            org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER )
            {
                {
                    IF | if
                }

                (_alt
                {
                    EQUAL |= =
                }

                {
                    IntegerLiteral | 1
                } )

                {
                    {
                        {
                            setState(
                            {
                                IntegerLiteral | 960
                            } )

                            ;
                            match(SEMI);
                            setState(
                            {
                                IntegerLiteral | 961
                            } )

                            ;
                            resource();
                        }
                    }
                }

                setState(
                {
                    IntegerLiteral | 966
                } )

                ;
                _errHandler.sync(
                {
                    THIS | this
                } )

                ;
                _alt = getInterpreter().adaptivePredict(_input, {
                    IntegerLiteral | 111
                } , 

                _ctx )
                ;
            }
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(
        {
            THIS | this
        } , 

        re )
        ;
        _errHandler.recover(
        {
            THIS | this
        } , 

        re )
        ;
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        {
            RETURN | return
        }

        _localctx;
    }

public static class ResourceContext
{
    EXTENDS |extends
}

ParserRuleContext {
public VariableModifierContextvariableModifier(
{
    INT | int
}

i ) { {RETURN | return }getRuleContext(VariableModifierContext.class , 

i ) ;  }public List {
LT | < }VariableModifierContext {
GT | > }variableModifier()
{
    {
        RETURN | return
    }

    getRuleContexts(VariableModifierContext.class ) ;  }

public ClassOrInterfaceTypeContextclassOrInterfaceType()
{
    {
        RETURN | return
    }

    getRuleContext(ClassOrInterfaceTypeContext.class ,  {

IntegerLiteral | 0 } ) ;  }public VariableDeclaratorIdContextvariableDeclaratorId()
{
    {
        RETURN | return
    }

    getRuleContext(VariableDeclaratorIdContext.class ,  {

IntegerLiteral | 0 } ) ;  }public ExpressionContextexpression()
{
    {
        RETURN | return
    }

    getRuleContext(ExpressionContext.class ,  {

IntegerLiteral | 0 } ) ;  }public ResourceContext(ParserRuleContext parent, {
    INT | int
}

invokingState ) { {SUPER |super } (
parent , invokingState ) ;  } {AT | @ }Override public {
INT |int }
getRuleIndex()
{
    {
        RETURN | return
    }

    RULE_resource;
} {

AT | @ }Override public void enterRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterResource(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public void exitRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitResource(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public {
LT | < }T {
GT | > }Taccept(ParseTreeVisitor
{
    LT | <
} {

QUESTION |? } {
EXTENDS |extends }
T {
GT | > }visitor ) { {IF | if } (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) {RETURN | return } ( (JavaVisitor {
LT | < } {QUESTION |? } {
EXTENDS |extends }
T {
GT | > } )visitor ) .visitResource(
{
    THIS | this
} ) ;  {

ELSE | else } {RETURN | return }visitor.visitChildren ( {THIS |this
} ) ;  } }

public {
FINAL |final }
ResourceContextresource()
{
    ResourceContext _localctx = new ResourceContext(_ctx, getState());
    enterRule(_localctx, {
        IntegerLiteral | 152
    } , 

    RULE_resource )
    ;
    {
        INT | int
    }

    _la;
    try
    {
        enterOuterAlt(_localctx, {
            IntegerLiteral | 1
        } )

        ;
        {
            setState(
            {
                IntegerLiteral | 970
            } )

            ;
            _errHandler.sync(
            {
                THIS | this
            } )

            ;
            _la = _input.LA(
            {
                IntegerLiteral | 1
            } )

            ;
            {
                WHILE | while
            }

            (_la
            {
                EQUAL |= =
            }

            FINAL
            {
                OR || |
            }

            _la
            {
                EQUAL |= =
            }

            AT )
            {
                {
                    {
                        setState(
                        {
                            IntegerLiteral | 967
                        } )

                        ;
                        variableModifier();
                    }
                }

                setState(
                {
                    IntegerLiteral | 972
                } )

                ;
                _errHandler.sync(
                {
                    THIS | this
                } )

                ;
                _la = _input.LA(
                {
                    IntegerLiteral | 1
                } )

                ;
            }

            setState(
            {
                IntegerLiteral | 973
            } )

            ;
            classOrInterfaceType();
            setState(
            {
                IntegerLiteral | 974
            } )

            ;
            variableDeclaratorId();
            setState(
            {
                IntegerLiteral | 975
            } )

            ;
            match(ASSIGN);
            setState(
            {
                IntegerLiteral | 976
            } )

            ;
            expression(
            {
                IntegerLiteral | 0
            } )

            ;
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(
        {
            THIS | this
        } , 

        re )
        ;
        _errHandler.recover(
        {
            THIS | this
        } , 

        re )
        ;
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        {
            RETURN | return
        }

        _localctx;
    }

public static class SwitchBlockStatementGroupContext
{
    EXTENDS |extends
}

ParserRuleContext {
public List {
LT | < }BlockStatementContext {
GT | > }blockStatement()
{
    {
        RETURN | return
    }

    getRuleContexts(BlockStatementContext.class ) ;  }

public List {
LT | < }SwitchLabelContext {
GT | > }switchLabel()
{
    {
        RETURN | return
    }

    getRuleContexts(SwitchLabelContext.class ) ;  }

public BlockStatementContextblockStatement(
{
    INT | int
}

i ) { {RETURN | return }getRuleContext(BlockStatementContext.class , 

i ) ;  }public SwitchLabelContextswitchLabel(
{
    INT | int
}

i ) { {RETURN | return }getRuleContext(SwitchLabelContext.class , 

i ) ;  }public SwitchBlockStatementGroupContext(ParserRuleContext parent, {
    INT | int
}

invokingState ) { {SUPER |super } (
parent , invokingState ) ;  } {AT | @ }Override public {
INT |int }
getRuleIndex()
{
    {
        RETURN | return
    }

    RULE_switchBlockStatementGroup;
} {

AT | @ }Override public void enterRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterSwitchBlockStatementGroup(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public void exitRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitSwitchBlockStatementGroup(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public {
LT | < }T {
GT | > }Taccept(ParseTreeVisitor
{
    LT | <
} {

QUESTION |? } {
EXTENDS |extends }
T {
GT | > }visitor ) { {IF | if } (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) {RETURN | return } ( (JavaVisitor {
LT | < } {QUESTION |? } {
EXTENDS |extends }
T {
GT | > } )visitor ) .visitSwitchBlockStatementGroup(
{
    THIS | this
} ) ;  {

ELSE | else } {RETURN | return }visitor.visitChildren ( {THIS |this
} ) ;  } }

public {
FINAL |final }
SwitchBlockStatementGroupContextswitchBlockStatementGroup()
{
    SwitchBlockStatementGroupContext _localctx = new SwitchBlockStatementGroupContext(_ctx, getState());
    enterRule(_localctx, {
        IntegerLiteral | 154
    } , 

    RULE_switchBlockStatementGroup )
    ;
    {
        INT | int
    }

    _la;
    try
    {
        enterOuterAlt(_localctx, {
            IntegerLiteral | 1
        } )

        ;
        {
            setState(
            {
                IntegerLiteral | 979
            } )

            ;
            _errHandler.sync(
            {
                THIS | this
            } )

            ;
            _la = _input.LA(
            {
                IntegerLiteral | 1
            } )

            ;
            {
                DO | do
            }

            {
                {
                    {
                        setState(
                        {
                            IntegerLiteral | 978
                        } )

                        ;
                        switchLabel();
                    }
                }

                setState(
                {
                    IntegerLiteral | 981
                } )

                ;
                _errHandler.sync(
                {
                    THIS | this
                } )

                ;
                _la = _input.LA(
                {
                    IntegerLiteral | 1
                } )

                ;
            }

            {
                WHILE | while
            }

            (_la
            {
                EQUAL |= =
            }

            CASE
            {
                OR || |
            }

            _la
            {
                EQUAL |= =
            }

            DEFAULT )
            ;
            setState(
            {
                IntegerLiteral | 984
            } )

            ;
            _errHandler.sync(
            {
                THIS | this
            } )

            ;
            _la = _input.LA(
            {
                IntegerLiteral | 1
            } )

            ;
            {
                DO | do
            }

            {
                {
                    {
                        setState(
                        {
                            IntegerLiteral | 983
                        } )

                        ;
                        blockStatement();
                    }
                }

                setState(
                {
                    IntegerLiteral | 986
                } )

                ;
                _errHandler.sync(
                {
                    THIS | this
                } )

                ;
                _la = _input.LA(
                {
                    IntegerLiteral | 1
                } )

                ;
            }

            {
                WHILE | while
            }

            ((((_la)
            {
                BITAND | &
            }

            {
                TILDE | ~
            }

            {
                IntegerLiteral | 0x3f
            } )

            {
                EQUAL |= =
            }

            {
                IntegerLiteral | 0
            }

            {
                AND | &&
            }

            ((
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            _la )
            {
                BITAND | &
            }

            ((
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            ABSTRACT )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            ASSERT )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            BOOLEAN )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            BREAK )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            BYTE )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            CHAR )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            CLASS )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            CONTINUE )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            DO )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            DOUBLE )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            ENUM )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            FINAL )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            FLOAT )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            FOR )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            IF )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            INT )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            INTERFACE )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            LONG )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            NEW )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            PRIVATE )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            PROTECTED )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            PUBLIC )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            RETURN )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            SHORT )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            STATIC )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            STRICTFP )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            SUPER )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            SWITCH )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            SYNCHRONIZED )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            THIS )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            THROW )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            TRY )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            VOID )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            WHILE )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            IntegerLiteral )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            FloatingPointLiteral )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            BooleanLiteral )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            CharacterLiteral )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            StringLiteral )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            NullLiteral )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            LPAREN )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            LBRACE )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            SEMI ) ) )
            {
                NOTEQUAL | !=
            }

            {
                IntegerLiteral | 0
            } )

            {
                OR || |
            }

            ((((_la
            {
                SUB | -
            }

            {
                IntegerLiteral | 68
            } ) )

            {
                BITAND | &
            }

            {
                TILDE | ~
            }

            {
                IntegerLiteral | 0x3f
            } )

            {
                EQUAL |= =
            }

            {
                IntegerLiteral | 0
            }

            {
                AND | &&
            }

            ((
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            (_la
            {
                SUB | -
            }

            {
                IntegerLiteral | 68
            } ) )

            {
                BITAND | &
            }

            ((
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            (LT
            {
                SUB | -
            }

            {
                IntegerLiteral | 68
            } ) )

            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            (BANG
            {
                SUB | -
            }

            {
                IntegerLiteral | 68
            } ) )

            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            (TILDE
            {
                SUB | -
            }

            {
                IntegerLiteral | 68
            } ) )

            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            (INC
            {
                SUB | -
            }

            {
                IntegerLiteral | 68
            } ) )

            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            (DEC
            {
                SUB | -
            }

            {
                IntegerLiteral | 68
            } ) )

            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            (ADD
            {
                SUB | -
            }

            {
                IntegerLiteral | 68
            } ) )

            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            (SUB
            {
                SUB | -
            }

            {
                IntegerLiteral | 68
            } ) )

            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            (Identifier
            {
                SUB | -
            }

            {
                IntegerLiteral | 68
            } ) )

            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            (AT
            {
                SUB | -
            }

            {
                IntegerLiteral | 68
            } ) ) ) )

            {
                NOTEQUAL | !=
            }

            {
                IntegerLiteral | 0
            } ) )

            ;
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(
        {
            THIS | this
        } , 

        re )
        ;
        _errHandler.recover(
        {
            THIS | this
        } , 

        re )
        ;
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        {
            RETURN | return
        }

        _localctx;
    }

public static class SwitchLabelContext
{
    EXTENDS |extends
}

ParserRuleContext {
public ConstantExpressionContextconstantExpression()
{
    {
        RETURN | return
    }

    getRuleContext(ConstantExpressionContext.class ,  {

IntegerLiteral | 0 } ) ;  }public EnumConstantNameContextenumConstantName()
{
    {
        RETURN | return
    }

    getRuleContext(EnumConstantNameContext.class ,  {

IntegerLiteral | 0 } ) ;  }public SwitchLabelContext(ParserRuleContext parent, {
    INT | int
}

invokingState ) { {SUPER |super } (
parent , invokingState ) ;  } {AT | @ }Override public {
INT |int }
getRuleIndex()
{
    {
        RETURN | return
    }

    RULE_switchLabel;
} {

AT | @ }Override public void enterRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterSwitchLabel(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public void exitRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitSwitchLabel(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public {
LT | < }T {
GT | > }Taccept(ParseTreeVisitor
{
    LT | <
} {

QUESTION |? } {
EXTENDS |extends }
T {
GT | > }visitor ) { {IF | if } (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) {RETURN | return } ( (JavaVisitor {
LT | < } {QUESTION |? } {
EXTENDS |extends }
T {
GT | > } )visitor ) .visitSwitchLabel(
{
    THIS | this
} ) ;  {

ELSE | else } {RETURN | return }visitor.visitChildren ( {THIS |this
} ) ;  } }

public {
FINAL |final }
SwitchLabelContextswitchLabel()
{
    SwitchLabelContext _localctx = new SwitchLabelContext(_ctx, getState());
    enterRule(_localctx, {
        IntegerLiteral | 156
    } , 

    RULE_switchLabel )
    ;
    try
    {
        setState(
        {
            IntegerLiteral | 998
        } )

        ;
        {
            SWITCH | switch
            }

            (getInterpreter().adaptivePredict(_input, {
                IntegerLiteral | 115
            } , 

            _ctx ) )
            {
                {
                    CASE |  case
                }

                {
                    IntegerLiteral | 1
                }

                {
                    COLON |  : 
                }

                enterOuterAlt(_localctx, {
                    IntegerLiteral | 1
                } )

                ;
                {
                    setState(
                    {
                        IntegerLiteral | 988
                    } )

                    ;
                    match(CASE);
                    setState(
                    {
                        IntegerLiteral | 989
                    } )

                    ;
                    constantExpression();
                    setState(
                    {
                        IntegerLiteral | 990
                    } )

                    ;
                    match(COLON);
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                {
                    IntegerLiteral | 2
                }

                {
                    COLON |  : 
                }

                enterOuterAlt(_localctx, {
                    IntegerLiteral | 2
                } )

                ;
                {
                    setState(
                    {
                        IntegerLiteral | 992
                    } )

                    ;
                    match(CASE);
                    setState(
                    {
                        IntegerLiteral | 993
                    } )

                    ;
                    enumConstantName();
                    setState(
                    {
                        IntegerLiteral | 994
                    } )

                    ;
                    match(COLON);
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                {
                    IntegerLiteral | 3
                }

                {
                    COLON |  : 
                }

                enterOuterAlt(_localctx, {
                    IntegerLiteral | 3
                } )

                ;
                {
                    setState(
                    {
                        IntegerLiteral | 996
                    } )

                    ;
                    match(DEFAULT);
                    setState(
                    {
                        IntegerLiteral | 997
                    } )

                    ;
                    match(COLON);
                }

                {
                    BREAK | break
                }

                ;
            }
        }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(
        {
            THIS | this
        } , 

        re )
        ;
        _errHandler.recover(
        {
            THIS | this
        } , 

        re )
        ;
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        {
            RETURN | return
        }

        _localctx;
    }

public static class ForControlContext
{
    EXTENDS |extends
}

ParserRuleContext {
public ForUpdateContextforUpdate()
{
    {
        RETURN | return
    }

    getRuleContext(ForUpdateContext.class ,  {

IntegerLiteral | 0 } ) ;  }public ForInitContextforInit()
{
    {
        RETURN | return
    }

    getRuleContext(ForInitContext.class ,  {

IntegerLiteral | 0 } ) ;  }public EnhancedForControlContextenhancedForControl()
{
    {
        RETURN | return
    }

    getRuleContext(EnhancedForControlContext.class ,  {

IntegerLiteral | 0 } ) ;  }public ExpressionContextexpression()
{
    {
        RETURN | return
    }

    getRuleContext(ExpressionContext.class ,  {

IntegerLiteral | 0 } ) ;  }public ForControlContext(ParserRuleContext parent, {
    INT | int
}

invokingState ) { {SUPER |super } (
parent , invokingState ) ;  } {AT | @ }Override public {
INT |int }
getRuleIndex()
{
    {
        RETURN | return
    }

    RULE_forControl;
} {

AT | @ }Override public void enterRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterForControl(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public void exitRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitForControl(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public {
LT | < }T {
GT | > }Taccept(ParseTreeVisitor
{
    LT | <
} {

QUESTION |? } {
EXTENDS |extends }
T {
GT | > }visitor ) { {IF | if } (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) {RETURN | return } ( (JavaVisitor {
LT | < } {QUESTION |? } {
EXTENDS |extends }
T {
GT | > } )visitor ) .visitForControl(
{
    THIS | this
} ) ;  {

ELSE | else } {RETURN | return }visitor.visitChildren ( {THIS |this
} ) ;  } }

public {
FINAL |final }
ForControlContextforControl()
{
    ForControlContext _localctx = new ForControlContext(_ctx, getState());
    enterRule(_localctx, {
        IntegerLiteral | 158
    } , 

    RULE_forControl )
    ;
    {
        INT | int
    }

    _la;
    try
    {
        setState(
        {
            IntegerLiteral | 1012
        } )

        ;
        {
            SWITCH | switch
            }

            (getInterpreter().adaptivePredict(_input, {
                IntegerLiteral | 119
            } , 

            _ctx ) )
            {
                {
                    CASE |  case
                }

                {
                    IntegerLiteral | 1
                }

                {
                    COLON |  : 
                }

                enterOuterAlt(_localctx, {
                    IntegerLiteral | 1
                } )

                ;
                {
                    setState(
                    {
                        IntegerLiteral | 1000
                    } )

                    ;
                    enhancedForControl();
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                {
                    IntegerLiteral | 2
                }

                {
                    COLON |  : 
                }

                enterOuterAlt(_localctx, {
                    IntegerLiteral | 2
                } )

                ;
                {
                    setState(
                    {
                        IntegerLiteral | 1002
                    } )

                    ;
                    _la = _input.LA(
                    {
                        IntegerLiteral | 1
                    } )

                    ;
                    {
                        IF | if
                    }

                    ((((_la)
                    {
                        BITAND | &
                    }

                    {
                        TILDE | ~
                    }

                    {
                        IntegerLiteral | 0x3f
                    } )

                    {
                        EQUAL |= =
                    }

                    {
                        IntegerLiteral | 0
                    }

                    {
                        AND | &&
                    }

                    ((
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    _la )
                    {
                        BITAND | &
                    }

                    ((
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    BOOLEAN )
                    {
                        BITOR ||
                    }

                    (
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    BYTE )
                    {
                        BITOR ||
                    }

                    (
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    CHAR )
                    {
                        BITOR ||
                    }

                    (
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    DOUBLE )
                    {
                        BITOR ||
                    }

                    (
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    FINAL )
                    {
                        BITOR ||
                    }

                    (
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    FLOAT )
                    {
                        BITOR ||
                    }

                    (
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    INT )
                    {
                        BITOR ||
                    }

                    (
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    LONG )
                    {
                        BITOR ||
                    }

                    (
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    NEW )
                    {
                        BITOR ||
                    }

                    (
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    SHORT )
                    {
                        BITOR ||
                    }

                    (
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    SUPER )
                    {
                        BITOR ||
                    }

                    (
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    THIS )
                    {
                        BITOR ||
                    }

                    (
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    VOID )
                    {
                        BITOR ||
                    }

                    (
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    IntegerLiteral )
                    {
                        BITOR ||
                    }

                    (
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    FloatingPointLiteral )
                    {
                        BITOR ||
                    }

                    (
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    BooleanLiteral )
                    {
                        BITOR ||
                    }

                    (
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    CharacterLiteral )
                    {
                        BITOR ||
                    }

                    (
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    StringLiteral )
                    {
                        BITOR ||
                    }

                    (
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    NullLiteral )
                    {
                        BITOR ||
                    }

                    (
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    LPAREN ) ) )
                    {
                        NOTEQUAL | !=
                    }

                    {
                        IntegerLiteral | 0
                    } )

                    {
                        OR || |
                    }

                    ((((_la
                    {
                        SUB | -
                    }

                    {
                        IntegerLiteral | 68
                    } ) )

                    {
                        BITAND | &
                    }

                    {
                        TILDE | ~
                    }

                    {
                        IntegerLiteral | 0x3f
                    } )

                    {
                        EQUAL |= =
                    }

                    {
                        IntegerLiteral | 0
                    }

                    {
                        AND | &&
                    }

                    ((
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    (_la
                    {
                        SUB | -
                    }

                    {
                        IntegerLiteral | 68
                    } ) )

                    {
                        BITAND | &
                    }

                    ((
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    (LT
                    {
                        SUB | -
                    }

                    {
                        IntegerLiteral | 68
                    } ) )

                    {
                        BITOR ||
                    }

                    (
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    (BANG
                    {
                        SUB | -
                    }

                    {
                        IntegerLiteral | 68
                    } ) )

                    {
                        BITOR ||
                    }

                    (
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    (TILDE
                    {
                        SUB | -
                    }

                    {
                        IntegerLiteral | 68
                    } ) )

                    {
                        BITOR ||
                    }

                    (
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    (INC
                    {
                        SUB | -
                    }

                    {
                        IntegerLiteral | 68
                    } ) )

                    {
                        BITOR ||
                    }

                    (
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    (DEC
                    {
                        SUB | -
                    }

                    {
                        IntegerLiteral | 68
                    } ) )

                    {
                        BITOR ||
                    }

                    (
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    (ADD
                    {
                        SUB | -
                    }

                    {
                        IntegerLiteral | 68
                    } ) )

                    {
                        BITOR ||
                    }

                    (
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    (SUB
                    {
                        SUB | -
                    }

                    {
                        IntegerLiteral | 68
                    } ) )

                    {
                        BITOR ||
                    }

                    (
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    (Identifier
                    {
                        SUB | -
                    }

                    {
                        IntegerLiteral | 68
                    } ) )

                    {
                        BITOR ||
                    }

                    (
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    (AT
                    {
                        SUB | -
                    }

                    {
                        IntegerLiteral | 68
                    } ) ) ) )

                    {
                        NOTEQUAL | !=
                    }

                    {
                        IntegerLiteral | 0
                    } ) )

                    {
                        {
                            setState(
                            {
                                IntegerLiteral | 1001
                            } )

                            ;
                            forInit();
                        }
                    }

                    setState(
                    {
                        IntegerLiteral | 1004
                    } )

                    ;
                    match(SEMI);
                    setState(
                    {
                        IntegerLiteral | 1006
                    } )

                    ;
                    _la = _input.LA(
                    {
                        IntegerLiteral | 1
                    } )

                    ;
                    {
                        IF | if
                    }

                    ((((_la)
                    {
                        BITAND | &
                    }

                    {
                        TILDE | ~
                    }

                    {
                        IntegerLiteral | 0x3f
                    } )

                    {
                        EQUAL |= =
                    }

                    {
                        IntegerLiteral | 0
                    }

                    {
                        AND | &&
                    }

                    ((
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    _la )
                    {
                        BITAND | &
                    }

                    ((
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    BOOLEAN )
                    {
                        BITOR ||
                    }

                    (
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    BYTE )
                    {
                        BITOR ||
                    }

                    (
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    CHAR )
                    {
                        BITOR ||
                    }

                    (
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    DOUBLE )
                    {
                        BITOR ||
                    }

                    (
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    FLOAT )
                    {
                        BITOR ||
                    }

                    (
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    INT )
                    {
                        BITOR ||
                    }

                    (
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    LONG )
                    {
                        BITOR ||
                    }

                    (
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    NEW )
                    {
                        BITOR ||
                    }

                    (
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    SHORT )
                    {
                        BITOR ||
                    }

                    (
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    SUPER )
                    {
                        BITOR ||
                    }

                    (
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    THIS )
                    {
                        BITOR ||
                    }

                    (
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    VOID )
                    {
                        BITOR ||
                    }

                    (
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    IntegerLiteral )
                    {
                        BITOR ||
                    }

                    (
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    FloatingPointLiteral )
                    {
                        BITOR ||
                    }

                    (
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    BooleanLiteral )
                    {
                        BITOR ||
                    }

                    (
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    CharacterLiteral )
                    {
                        BITOR ||
                    }

                    (
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    StringLiteral )
                    {
                        BITOR ||
                    }

                    (
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    NullLiteral )
                    {
                        BITOR ||
                    }

                    (
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    LPAREN ) ) )
                    {
                        NOTEQUAL | !=
                    }

                    {
                        IntegerLiteral | 0
                    } )

                    {
                        OR || |
                    }

                    ((((_la
                    {
                        SUB | -
                    }

                    {
                        IntegerLiteral | 68
                    } ) )

                    {
                        BITAND | &
                    }

                    {
                        TILDE | ~
                    }

                    {
                        IntegerLiteral | 0x3f
                    } )

                    {
                        EQUAL |= =
                    }

                    {
                        IntegerLiteral | 0
                    }

                    {
                        AND | &&
                    }

                    ((
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    (_la
                    {
                        SUB | -
                    }

                    {
                        IntegerLiteral | 68
                    } ) )

                    {
                        BITAND | &
                    }

                    ((
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    (LT
                    {
                        SUB | -
                    }

                    {
                        IntegerLiteral | 68
                    } ) )

                    {
                        BITOR ||
                    }

                    (
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    (BANG
                    {
                        SUB | -
                    }

                    {
                        IntegerLiteral | 68
                    } ) )

                    {
                        BITOR ||
                    }

                    (
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    (TILDE
                    {
                        SUB | -
                    }

                    {
                        IntegerLiteral | 68
                    } ) )

                    {
                        BITOR ||
                    }

                    (
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    (INC
                    {
                        SUB | -
                    }

                    {
                        IntegerLiteral | 68
                    } ) )

                    {
                        BITOR ||
                    }

                    (
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    (DEC
                    {
                        SUB | -
                    }

                    {
                        IntegerLiteral | 68
                    } ) )

                    {
                        BITOR ||
                    }

                    (
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    (ADD
                    {
                        SUB | -
                    }

                    {
                        IntegerLiteral | 68
                    } ) )

                    {
                        BITOR ||
                    }

                    (
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    (SUB
                    {
                        SUB | -
                    }

                    {
                        IntegerLiteral | 68
                    } ) )

                    {
                        BITOR ||
                    }

                    (
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    (Identifier
                    {
                        SUB | -
                    }

                    {
                        IntegerLiteral | 68
                    } ) ) ) )

                    {
                        NOTEQUAL | !=
                    }

                    {
                        IntegerLiteral | 0
                    } ) )

                    {
                        {
                            setState(
                            {
                                IntegerLiteral | 1005
                            } )

                            ;
                            expression(
                            {
                                IntegerLiteral | 0
                            } )

                            ;
                        }
                    }

                    setState(
                    {
                        IntegerLiteral | 1008
                    } )

                    ;
                    match(SEMI);
                    setState(
                    {
                        IntegerLiteral | 1010
                    } )

                    ;
                    _la = _input.LA(
                    {
                        IntegerLiteral | 1
                    } )

                    ;
                    {
                        IF | if
                    }

                    ((((_la)
                    {
                        BITAND | &
                    }

                    {
                        TILDE | ~
                    }

                    {
                        IntegerLiteral | 0x3f
                    } )

                    {
                        EQUAL |= =
                    }

                    {
                        IntegerLiteral | 0
                    }

                    {
                        AND | &&
                    }

                    ((
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    _la )
                    {
                        BITAND | &
                    }

                    ((
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    BOOLEAN )
                    {
                        BITOR ||
                    }

                    (
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    BYTE )
                    {
                        BITOR ||
                    }

                    (
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    CHAR )
                    {
                        BITOR ||
                    }

                    (
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    DOUBLE )
                    {
                        BITOR ||
                    }

                    (
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    FLOAT )
                    {
                        BITOR ||
                    }

                    (
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    INT )
                    {
                        BITOR ||
                    }

                    (
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    LONG )
                    {
                        BITOR ||
                    }

                    (
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    NEW )
                    {
                        BITOR ||
                    }

                    (
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    SHORT )
                    {
                        BITOR ||
                    }

                    (
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    SUPER )
                    {
                        BITOR ||
                    }

                    (
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    THIS )
                    {
                        BITOR ||
                    }

                    (
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    VOID )
                    {
                        BITOR ||
                    }

                    (
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    IntegerLiteral )
                    {
                        BITOR ||
                    }

                    (
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    FloatingPointLiteral )
                    {
                        BITOR ||
                    }

                    (
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    BooleanLiteral )
                    {
                        BITOR ||
                    }

                    (
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    CharacterLiteral )
                    {
                        BITOR ||
                    }

                    (
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    StringLiteral )
                    {
                        BITOR ||
                    }

                    (
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    NullLiteral )
                    {
                        BITOR ||
                    }

                    (
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    LPAREN ) ) )
                    {
                        NOTEQUAL | !=
                    }

                    {
                        IntegerLiteral | 0
                    } )

                    {
                        OR || |
                    }

                    ((((_la
                    {
                        SUB | -
                    }

                    {
                        IntegerLiteral | 68
                    } ) )

                    {
                        BITAND | &
                    }

                    {
                        TILDE | ~
                    }

                    {
                        IntegerLiteral | 0x3f
                    } )

                    {
                        EQUAL |= =
                    }

                    {
                        IntegerLiteral | 0
                    }

                    {
                        AND | &&
                    }

                    ((
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    (_la
                    {
                        SUB | -
                    }

                    {
                        IntegerLiteral | 68
                    } ) )

                    {
                        BITAND | &
                    }

                    ((
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    (LT
                    {
                        SUB | -
                    }

                    {
                        IntegerLiteral | 68
                    } ) )

                    {
                        BITOR ||
                    }

                    (
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    (BANG
                    {
                        SUB | -
                    }

                    {
                        IntegerLiteral | 68
                    } ) )

                    {
                        BITOR ||
                    }

                    (
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    (TILDE
                    {
                        SUB | -
                    }

                    {
                        IntegerLiteral | 68
                    } ) )

                    {
                        BITOR ||
                    }

                    (
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    (INC
                    {
                        SUB | -
                    }

                    {
                        IntegerLiteral | 68
                    } ) )

                    {
                        BITOR ||
                    }

                    (
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    (DEC
                    {
                        SUB | -
                    }

                    {
                        IntegerLiteral | 68
                    } ) )

                    {
                        BITOR ||
                    }

                    (
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    (ADD
                    {
                        SUB | -
                    }

                    {
                        IntegerLiteral | 68
                    } ) )

                    {
                        BITOR ||
                    }

                    (
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    (SUB
                    {
                        SUB | -
                    }

                    {
                        IntegerLiteral | 68
                    } ) )

                    {
                        BITOR ||
                    }

                    (
                    {
                        IntegerLiteral | 1L
                    }

                    {
                        LT | <
                    }

                    {
                        LT | <
                    }

                    (Identifier
                    {
                        SUB | -
                    }

                    {
                        IntegerLiteral | 68
                    } ) ) ) )

                    {
                        NOTEQUAL | !=
                    }

                    {
                        IntegerLiteral | 0
                    } ) )

                    {
                        {
                            setState(
                            {
                                IntegerLiteral | 1009
                            } )

                            ;
                            forUpdate();
                        }
                    }
                }

                {
                    BREAK | break
                }

                ;
            }
        }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(
        {
            THIS | this
        } , 

        re )
        ;
        _errHandler.recover(
        {
            THIS | this
        } , 

        re )
        ;
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        {
            RETURN | return
        }

        _localctx;
    }

public static class ForInitContext
{
    EXTENDS |extends
}

ParserRuleContext {
public LocalVariableDeclarationContextlocalVariableDeclaration()
{
    {
        RETURN | return
    }

    getRuleContext(LocalVariableDeclarationContext.class ,  {

IntegerLiteral | 0 } ) ;  }public ExpressionListContextexpressionList()
{
    {
        RETURN | return
    }

    getRuleContext(ExpressionListContext.class ,  {

IntegerLiteral | 0 } ) ;  }public ForInitContext(ParserRuleContext parent, {
    INT | int
}

invokingState ) { {SUPER |super } (
parent , invokingState ) ;  } {AT | @ }Override public {
INT |int }
getRuleIndex()
{
    {
        RETURN | return
    }

    RULE_forInit;
} {

AT | @ }Override public void enterRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterForInit(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public void exitRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitForInit(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public {
LT | < }T {
GT | > }Taccept(ParseTreeVisitor
{
    LT | <
} {

QUESTION |? } {
EXTENDS |extends }
T {
GT | > }visitor ) { {IF | if } (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) {RETURN | return } ( (JavaVisitor {
LT | < } {QUESTION |? } {
EXTENDS |extends }
T {
GT | > } )visitor ) .visitForInit(
{
    THIS | this
} ) ;  {

ELSE | else } {RETURN | return }visitor.visitChildren ( {THIS |this
} ) ;  } }

public {
FINAL |final }
ForInitContextforInit()
{
    ForInitContext _localctx = new ForInitContext(_ctx, getState());
    enterRule(_localctx, {
        IntegerLiteral | 160
    } , 

    RULE_forInit )
    ;
    try
    {
        setState(
        {
            IntegerLiteral | 1016
        } )

        ;
        {
            SWITCH | switch
            }

            (getInterpreter().adaptivePredict(_input, {
                IntegerLiteral | 120
            } , 

            _ctx ) )
            {
                {
                    CASE |  case
                }

                {
                    IntegerLiteral | 1
                }

                {
                    COLON |  : 
                }

                enterOuterAlt(_localctx, {
                    IntegerLiteral | 1
                } )

                ;
                {
                    setState(
                    {
                        IntegerLiteral | 1014
                    } )

                    ;
                    localVariableDeclaration();
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                {
                    IntegerLiteral | 2
                }

                {
                    COLON |  : 
                }

                enterOuterAlt(_localctx, {
                    IntegerLiteral | 2
                } )

                ;
                {
                    setState(
                    {
                        IntegerLiteral | 1015
                    } )

                    ;
                    expressionList();
                }

                {
                    BREAK | break
                }

                ;
            }
        }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(
        {
            THIS | this
        } , 

        re )
        ;
        _errHandler.recover(
        {
            THIS | this
        } , 

        re )
        ;
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        {
            RETURN | return
        }

        _localctx;
    }

public static class EnhancedForControlContext
{
    EXTENDS |extends
}

ParserRuleContext {
public VariableModifierContextvariableModifier(
{
    INT | int
}

i ) { {RETURN | return }getRuleContext(VariableModifierContext.class , 

i ) ;  }public List {
LT | < }VariableModifierContext {
GT | > }variableModifier()
{
    {
        RETURN | return
    }

    getRuleContexts(VariableModifierContext.class ) ;  }

public VariableDeclaratorIdContextvariableDeclaratorId()
{
    {
        RETURN | return
    }

    getRuleContext(VariableDeclaratorIdContext.class ,  {

IntegerLiteral | 0 } ) ;  }public TypeContexttype()
{
    {
        RETURN | return
    }

    getRuleContext(TypeContext.class ,  {

IntegerLiteral | 0 } ) ;  }public ExpressionContextexpression()
{
    {
        RETURN | return
    }

    getRuleContext(ExpressionContext.class ,  {

IntegerLiteral | 0 } ) ;  }public EnhancedForControlContext(ParserRuleContext parent, {
    INT | int
}

invokingState ) { {SUPER |super } (
parent , invokingState ) ;  } {AT | @ }Override public {
INT |int }
getRuleIndex()
{
    {
        RETURN | return
    }

    RULE_enhancedForControl;
} {

AT | @ }Override public void enterRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterEnhancedForControl(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public void exitRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitEnhancedForControl(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public {
LT | < }T {
GT | > }Taccept(ParseTreeVisitor
{
    LT | <
} {

QUESTION |? } {
EXTENDS |extends }
T {
GT | > }visitor ) { {IF | if } (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) {RETURN | return } ( (JavaVisitor {
LT | < } {QUESTION |? } {
EXTENDS |extends }
T {
GT | > } )visitor ) .visitEnhancedForControl(
{
    THIS | this
} ) ;  {

ELSE | else } {RETURN | return }visitor.visitChildren ( {THIS |this
} ) ;  } }

public {
FINAL |final }
EnhancedForControlContextenhancedForControl()
{
    EnhancedForControlContext _localctx = new EnhancedForControlContext(_ctx, getState());
    enterRule(_localctx, {
        IntegerLiteral | 162
    } , 

    RULE_enhancedForControl )
    ;
    {
        INT | int
    }

    _la;
    try
    {
        enterOuterAlt(_localctx, {
            IntegerLiteral | 1
        } )

        ;
        {
            setState(
            {
                IntegerLiteral | 1021
            } )

            ;
            _errHandler.sync(
            {
                THIS | this
            } )

            ;
            _la = _input.LA(
            {
                IntegerLiteral | 1
            } )

            ;
            {
                WHILE | while
            }

            (_la
            {
                EQUAL |= =
            }

            FINAL
            {
                OR || |
            }

            _la
            {
                EQUAL |= =
            }

            AT )
            {
                {
                    {
                        setState(
                        {
                            IntegerLiteral | 1018
                        } )

                        ;
                        variableModifier();
                    }
                }

                setState(
                {
                    IntegerLiteral | 1023
                } )

                ;
                _errHandler.sync(
                {
                    THIS | this
                } )

                ;
                _la = _input.LA(
                {
                    IntegerLiteral | 1
                } )

                ;
            }

            setState(
            {
                IntegerLiteral | 1024
            } )

            ;
            type();
            setState(
            {
                IntegerLiteral | 1025
            } )

            ;
            variableDeclaratorId();
            setState(
            {
                IntegerLiteral | 1026
            } )

            ;
            match(COLON);
            setState(
            {
                IntegerLiteral | 1027
            } )

            ;
            expression(
            {
                IntegerLiteral | 0
            } )

            ;
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(
        {
            THIS | this
        } , 

        re )
        ;
        _errHandler.recover(
        {
            THIS | this
        } , 

        re )
        ;
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        {
            RETURN | return
        }

        _localctx;
    }

public static class ForUpdateContext
{
    EXTENDS |extends
}

ParserRuleContext {
public ExpressionListContextexpressionList()
{
    {
        RETURN | return
    }

    getRuleContext(ExpressionListContext.class ,  {

IntegerLiteral | 0 } ) ;  }public ForUpdateContext(ParserRuleContext parent, {
    INT | int
}

invokingState ) { {SUPER |super } (
parent , invokingState ) ;  } {AT | @ }Override public {
INT |int }
getRuleIndex()
{
    {
        RETURN | return
    }

    RULE_forUpdate;
} {

AT | @ }Override public void enterRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterForUpdate(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public void exitRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitForUpdate(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public {
LT | < }T {
GT | > }Taccept(ParseTreeVisitor
{
    LT | <
} {

QUESTION |? } {
EXTENDS |extends }
T {
GT | > }visitor ) { {IF | if } (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) {RETURN | return } ( (JavaVisitor {
LT | < } {QUESTION |? } {
EXTENDS |extends }
T {
GT | > } )visitor ) .visitForUpdate(
{
    THIS | this
} ) ;  {

ELSE | else } {RETURN | return }visitor.visitChildren ( {THIS |this
} ) ;  } }

public {
FINAL |final }
ForUpdateContextforUpdate()
{
    ForUpdateContext _localctx = new ForUpdateContext(_ctx, getState());
    enterRule(_localctx, {
        IntegerLiteral | 164
    } , 

    RULE_forUpdate )
    ;
    try
    {
        enterOuterAlt(_localctx, {
            IntegerLiteral | 1
        } )

        ;
        {
            setState(
            {
                IntegerLiteral | 1029
            } )

            ;
            expressionList();
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(
        {
            THIS | this
        } , 

        re )
        ;
        _errHandler.recover(
        {
            THIS | this
        } , 

        re )
        ;
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        {
            RETURN | return
        }

        _localctx;
    }

public static class ParExpressionContext
{
    EXTENDS |extends
}

ParserRuleContext {
public ExpressionContextexpression()
{
    {
        RETURN | return
    }

    getRuleContext(ExpressionContext.class ,  {

IntegerLiteral | 0 } ) ;  }public ParExpressionContext(ParserRuleContext parent, {
    INT | int
}

invokingState ) { {SUPER |super } (
parent , invokingState ) ;  } {AT | @ }Override public {
INT |int }
getRuleIndex()
{
    {
        RETURN | return
    }

    RULE_parExpression;
} {

AT | @ }Override public void enterRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterParExpression(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public void exitRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitParExpression(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public {
LT | < }T {
GT | > }Taccept(ParseTreeVisitor
{
    LT | <
} {

QUESTION |? } {
EXTENDS |extends }
T {
GT | > }visitor ) { {IF | if } (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) {RETURN | return } ( (JavaVisitor {
LT | < } {QUESTION |? } {
EXTENDS |extends }
T {
GT | > } )visitor ) .visitParExpression(
{
    THIS | this
} ) ;  {

ELSE | else } {RETURN | return }visitor.visitChildren ( {THIS |this
} ) ;  } }

public {
FINAL |final }
ParExpressionContextparExpression()
{
    ParExpressionContext _localctx = new ParExpressionContext(_ctx, getState());
    enterRule(_localctx, {
        IntegerLiteral | 166
    } , 

    RULE_parExpression )
    ;
    try
    {
        enterOuterAlt(_localctx, {
            IntegerLiteral | 1
        } )

        ;
        {
            setState(
            {
                IntegerLiteral | 1031
            } )

            ;
            match(LPAREN);
            setState(
            {
                IntegerLiteral | 1032
            } )

            ;
            expression(
            {
                IntegerLiteral | 0
            } )

            ;
            setState(
            {
                IntegerLiteral | 1033
            } )

            ;
            match(RPAREN);
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(
        {
            THIS | this
        } , 

        re )
        ;
        _errHandler.recover(
        {
            THIS | this
        } , 

        re )
        ;
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        {
            RETURN | return
        }

        _localctx;
    }

public static class ExpressionListContext
{
    EXTENDS |extends
}

ParserRuleContext {
public ExpressionContextexpression(
{
    INT | int
}

i ) { {RETURN | return }getRuleContext(ExpressionContext.class , 

i ) ;  }public List {
LT | < }ExpressionContext {
GT | > }expression()
{
    {
        RETURN | return
    }

    getRuleContexts(ExpressionContext.class ) ;  }

public ExpressionListContext(ParserRuleContext parent, {
    INT | int
}

invokingState ) { {SUPER |super } (
parent , invokingState ) ;  } {AT | @ }Override public {
INT |int }
getRuleIndex()
{
    {
        RETURN | return
    }

    RULE_expressionList;
} {

AT | @ }Override public void enterRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterExpressionList(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public void exitRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitExpressionList(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public {
LT | < }T {
GT | > }Taccept(ParseTreeVisitor
{
    LT | <
} {

QUESTION |? } {
EXTENDS |extends }
T {
GT | > }visitor ) { {IF | if } (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) {RETURN | return } ( (JavaVisitor {
LT | < } {QUESTION |? } {
EXTENDS |extends }
T {
GT | > } )visitor ) .visitExpressionList(
{
    THIS | this
} ) ;  {

ELSE | else } {RETURN | return }visitor.visitChildren ( {THIS |this
} ) ;  } }

public {
FINAL |final }
ExpressionListContextexpressionList()
{
    ExpressionListContext _localctx = new ExpressionListContext(_ctx, getState());
    enterRule(_localctx, {
        IntegerLiteral | 168
    } , 

    RULE_expressionList )
    ;
    {
        INT | int
    }

    _la;
    try
    {
        enterOuterAlt(_localctx, {
            IntegerLiteral | 1
        } )

        ;
        {
            setState(
            {
                IntegerLiteral | 1035
            } )

            ;
            expression(
            {
                IntegerLiteral | 0
            } )

            ;
            setState(
            {
                IntegerLiteral | 1040
            } )

            ;
            _errHandler.sync(
            {
                THIS | this
            } )

            ;
            _la = _input.LA(
            {
                IntegerLiteral | 1
            } )

            ;
            {
                WHILE | while
            }

            (_la
            {
                EQUAL |= =
            }

            COMMA )
            {
                {
                    {
                        setState(
                        {
                            IntegerLiteral | 1036
                        } )

                        ;
                        match(COMMA);
                        setState(
                        {
                            IntegerLiteral | 1037
                        } )

                        ;
                        expression(
                        {
                            IntegerLiteral | 0
                        } )

                        ;
                    }
                }

                setState(
                {
                    IntegerLiteral | 1042
                } )

                ;
                _errHandler.sync(
                {
                    THIS | this
                } )

                ;
                _la = _input.LA(
                {
                    IntegerLiteral | 1
                } )

                ;
            }
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(
        {
            THIS | this
        } , 

        re )
        ;
        _errHandler.recover(
        {
            THIS | this
        } , 

        re )
        ;
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        {
            RETURN | return
        }

        _localctx;
    }

public static class StatementExpressionContext
{
    EXTENDS |extends
}

ParserRuleContext {
public ExpressionContextexpression()
{
    {
        RETURN | return
    }

    getRuleContext(ExpressionContext.class ,  {

IntegerLiteral | 0 } ) ;  }public StatementExpressionContext(ParserRuleContext parent, {
    INT | int
}

invokingState ) { {SUPER |super } (
parent , invokingState ) ;  } {AT | @ }Override public {
INT |int }
getRuleIndex()
{
    {
        RETURN | return
    }

    RULE_statementExpression;
} {

AT | @ }Override public void enterRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterStatementExpression(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public void exitRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitStatementExpression(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public {
LT | < }T {
GT | > }Taccept(ParseTreeVisitor
{
    LT | <
} {

QUESTION |? } {
EXTENDS |extends }
T {
GT | > }visitor ) { {IF | if } (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) {RETURN | return } ( (JavaVisitor {
LT | < } {QUESTION |? } {
EXTENDS |extends }
T {
GT | > } )visitor ) .visitStatementExpression(
{
    THIS | this
} ) ;  {

ELSE | else } {RETURN | return }visitor.visitChildren ( {THIS |this
} ) ;  } }

public {
FINAL |final }
StatementExpressionContextstatementExpression()
{
    StatementExpressionContext _localctx = new StatementExpressionContext(_ctx, getState());
    enterRule(_localctx, {
        IntegerLiteral | 170
    } , 

    RULE_statementExpression )
    ;
    try
    {
        enterOuterAlt(_localctx, {
            IntegerLiteral | 1
        } )

        ;
        {
            setState(
            {
                IntegerLiteral | 1043
            } )

            ;
            expression(
            {
                IntegerLiteral | 0
            } )

            ;
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(
        {
            THIS | this
        } , 

        re )
        ;
        _errHandler.recover(
        {
            THIS | this
        } , 

        re )
        ;
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        {
            RETURN | return
        }

        _localctx;
    }

public static class ConstantExpressionContext
{
    EXTENDS |extends
}

ParserRuleContext {
public ExpressionContextexpression()
{
    {
        RETURN | return
    }

    getRuleContext(ExpressionContext.class ,  {

IntegerLiteral | 0 } ) ;  }public ConstantExpressionContext(ParserRuleContext parent, {
    INT | int
}

invokingState ) { {SUPER |super } (
parent , invokingState ) ;  } {AT | @ }Override public {
INT |int }
getRuleIndex()
{
    {
        RETURN | return
    }

    RULE_constantExpression;
} {

AT | @ }Override public void enterRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterConstantExpression(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public void exitRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitConstantExpression(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public {
LT | < }T {
GT | > }Taccept(ParseTreeVisitor
{
    LT | <
} {

QUESTION |? } {
EXTENDS |extends }
T {
GT | > }visitor ) { {IF | if } (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) {RETURN | return } ( (JavaVisitor {
LT | < } {QUESTION |? } {
EXTENDS |extends }
T {
GT | > } )visitor ) .visitConstantExpression(
{
    THIS | this
} ) ;  {

ELSE | else } {RETURN | return }visitor.visitChildren ( {THIS |this
} ) ;  } }

public {
FINAL |final }
ConstantExpressionContextconstantExpression()
{
    ConstantExpressionContext _localctx = new ConstantExpressionContext(_ctx, getState());
    enterRule(_localctx, {
        IntegerLiteral | 172
    } , 

    RULE_constantExpression )
    ;
    try
    {
        enterOuterAlt(_localctx, {
            IntegerLiteral | 1
        } )

        ;
        {
            setState(
            {
                IntegerLiteral | 1045
            } )

            ;
            expression(
            {
                IntegerLiteral | 0
            } )

            ;
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(
        {
            THIS | this
        } , 

        re )
        ;
        _errHandler.recover(
        {
            THIS | this
        } , 

        re )
        ;
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        {
            RETURN | return
        }

        _localctx;
    }

public static class ExpressionContext
{
    EXTENDS |extends
}

ParserRuleContext {
public TerminalNodeIdentifier()
{
    {
        RETURN | return
    }

    getToken(JavaParser.Identifier, {
        IntegerLiteral | 0
    } )

    ;
}

public NonWildcardTypeArgumentsContextnonWildcardTypeArguments()
{
    {
        RETURN | return
    }

    getRuleContext(NonWildcardTypeArgumentsContext.class ,  {

IntegerLiteral | 0 } ) ;  }public ExplicitGenericInvocationContextexplicitGenericInvocation()
{
    {
        RETURN | return
    }

    getRuleContext(ExplicitGenericInvocationContext.class ,  {

IntegerLiteral | 0 } ) ;  }public ExpressionListContextexpressionList()
{
    {
        RETURN | return
    }

    getRuleContext(ExpressionListContext.class ,  {

IntegerLiteral | 0 } ) ;  }public InnerCreatorContextinnerCreator()
{
    {
        RETURN | return
    }

    getRuleContext(InnerCreatorContext.class ,  {

IntegerLiteral | 0 } ) ;  }public SuperSuffixContextsuperSuffix()
{
    {
        RETURN | return
    }

    getRuleContext(SuperSuffixContext.class ,  {

IntegerLiteral | 0 } ) ;  }public ExpressionContextexpression(
{
    INT | int
}

i ) { {RETURN | return }getRuleContext(ExpressionContext.class , 

i ) ;  }public PrimaryContextprimary()
{
    {
        RETURN | return
    }

    getRuleContext(PrimaryContext.class ,  {

IntegerLiteral | 0 } ) ;  }public TypeContexttype()
{
    {
        RETURN | return
    }

    getRuleContext(TypeContext.class ,  {

IntegerLiteral | 0 } ) ;  }public List {
LT | < }ExpressionContext {
GT | > }expression()
{
    {
        RETURN | return
    }

    getRuleContexts(ExpressionContext.class ) ;  }

public CreatorContextcreator()
{
    {
        RETURN | return
    }

    getRuleContext(CreatorContext.class ,  {

IntegerLiteral | 0 } ) ;  }public ExpressionContext(ParserRuleContext parent, {
    INT | int
}

invokingState ) { {SUPER |super } (
parent , invokingState ) ;  } {AT | @ }Override public {
INT |int }
getRuleIndex()
{
    {
        RETURN | return
    }

    RULE_expression;
} {

AT | @ }Override public void enterRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterExpression(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public void exitRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitExpression(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public {
LT | < }T {
GT | > }Taccept(ParseTreeVisitor
{
    LT | <
} {

QUESTION |? } {
EXTENDS |extends }
T {
GT | > }visitor ) { {IF | if } (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) {RETURN | return } ( (JavaVisitor {
LT | < } {QUESTION |? } {
EXTENDS |extends }
T {
GT | > } )visitor ) .visitExpression(
{
    THIS | this
} ) ;  {

ELSE | else } {RETURN | return }visitor.visitChildren ( {THIS |this
} ) ;  } }

public {
FINAL |final }
ExpressionContextexpression()
{
    {
        RETURN | return
    }

    expression(
    {
        IntegerLiteral | 0
    } )

    ;
}

private ExpressionContextexpression(
{
    INT | int
}

_p ) {ParserRuleContext _parentctx = _ctx; {
INT |int }
_parentState =  getState();
ExpressionContext _localctx = new ExpressionContext(_ctx, _parentState);
ExpressionContext _prevctx = _localctx; {
INT |int }
_startState =  { IntegerLiteral | 174 } ; enterRecursionRule(_localctx, {
    IntegerLiteral | 174
} , 

RULE_expression , _p ) ;  {INT |int }
_la ;  try  { {INT |int }
_alt ; enterOuterAlt(_localctx, {
    IntegerLiteral | 1
} ) ;  {

setState(
{
    IntegerLiteral | 1060
} ) ;  {

SWITCH | switch } (getInterpreter() .
adaptivePredict(_input, {
    IntegerLiteral | 123
} , 

_ctx ) ) { {CASE | case } {IntegerLiteral | 1 } {COLON | :  } {setState(
{
    IntegerLiteral | 1048
} ) ; 

match(LPAREN);
setState(
{
    IntegerLiteral | 1049
} ) ; 

type();
setState(
{
    IntegerLiteral | 1050
} ) ; 

match(RPAREN);
setState(
{
    IntegerLiteral | 1051
} ) ; 

expression(
{
    IntegerLiteral | 17
} ) ;  } {

BREAK | break } ;  {CASE | case } {IntegerLiteral | 2 } {COLON | :  } {setState(
{
    IntegerLiteral | 1053
} ) ; 

_la =  _input.LA ( {IntegerLiteral | 1 } ) ;  {IF | if } ( {BANG | ! } ( ( ( ( (_la {
SUB | - } {IntegerLiteral | 79 } ) ) {BITAND | & } {TILDE |~
 } {
IntegerLiteral | 0x3f } ) {EQUAL |=  =  } {IntegerLiteral | 0 } {AND | && } ( ( {IntegerLiteral | 1L } {LT | < } {LT | < } (_la {
SUB | - } {IntegerLiteral | 79 } ) ) {BITAND | & } ( ( {IntegerLiteral | 1L } {LT | < } {LT | < } (INC {
SUB | - } {IntegerLiteral | 79 } ) ) {BITOR || } ( {IntegerLiteral | 1L } {LT | < } {LT | < } (DEC {
SUB | - } {IntegerLiteral | 79 } ) ) {BITOR || } ( {IntegerLiteral | 1L } {LT | < } {LT | < } (ADD {
SUB | - } {IntegerLiteral | 79 } ) ) {BITOR || } ( {IntegerLiteral | 1L } {LT | < } {LT | < } (SUB {
SUB | - } {IntegerLiteral | 79 } ) ) ) ) {NOTEQUAL | != } {IntegerLiteral | 0 } ) ) ) {_errHandler.recoverInline ( {THIS |this
} ) ;  }

consume();
setState(
{
    IntegerLiteral | 1054
} ) ; 

expression(
{
    IntegerLiteral | 15
} ) ;  } {

BREAK | break } ;  {CASE | case } {IntegerLiteral | 3 } {COLON | :  } {setState(
{
    IntegerLiteral | 1055
} ) ; 

_la =  _input.LA ( {IntegerLiteral | 1 } ) ;  {IF | if } ( {BANG | ! } (_la {
EQUAL |=  =  }BANG {
OR || | }_la {
EQUAL |=  =  }TILDE ) ) {_errHandler.recoverInline ( {THIS |this
} ) ;  }

consume();
setState(
{
    IntegerLiteral | 1056
} ) ; 

expression(
{
    IntegerLiteral | 14
} ) ;  } {

BREAK | break } ;  {CASE | case } {IntegerLiteral | 4 } {COLON | :  } {setState(
{
    IntegerLiteral | 1057
} ) ; 

primary(); } {
BREAK | break } ;  {CASE | case } {IntegerLiteral | 5 } {COLON | :  } {setState(
{
    IntegerLiteral | 1058
} ) ; 

match(NEW);
setState(
{
    IntegerLiteral | 1059
} ) ; 

creator(); } {
BREAK | break } ;  }_ctx.stop =  _input.LT ( {SUB | - } {IntegerLiteral | 1 } ) ; setState(
{
    IntegerLiteral | 1147
} ) ; 

_errHandler.sync ( {THIS |this
} ) ; 

_alt =  getInterpreter() .
adaptivePredict(_input, {
    IntegerLiteral | 128
} , 

_ctx ) ;  {WHILE | while } (_alt {
NOTEQUAL | != } {IntegerLiteral | 2 } {AND | && }_alt {
NOTEQUAL | != }org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER ) { {IF | if } (_alt {
EQUAL |=  =  } {IntegerLiteral | 1 } ) { {IF | if } (_parseListeners {
NOTEQUAL | != } null )triggerExitRuleEvent();
_prevctx =  _localctx ;  {setState(
{
    IntegerLiteral | 1145
} ) ;  {

SWITCH | switch } (getInterpreter() .
adaptivePredict(_input, {
    IntegerLiteral | 127
} , 

_ctx ) ) { {CASE | case } {IntegerLiteral | 1 } {COLON | :  } {_localctx =  new ExpressionContext(_parentctx, _parentState);
pushNewRecursionContext(_localctx, _startState, RULE_expression);
setState(
{
    IntegerLiteral | 1062
} ) ;  {

IF | if } ( {BANG | ! } (precpred(_ctx, {
    IntegerLiteral | 13
} ) ) ) {

THROW | throw }new FailedPredicateException(
{
    THIS | this
} ,  "precpred(_ctx, 13)" ) ; 

setState(
{
    IntegerLiteral | 1063
} ) ; 

_la =  _input.LA ( {IntegerLiteral | 1 } ) ;  {IF | if } ( {BANG | ! } ( ( ( ( (_la {
SUB | - } {IntegerLiteral | 83 } ) ) {BITAND | & } {TILDE |~
 } {
IntegerLiteral | 0x3f } ) {EQUAL |=  =  } {IntegerLiteral | 0 } {AND | && } ( ( {IntegerLiteral | 1L } {LT | < } {LT | < } (_la {
SUB | - } {IntegerLiteral | 83 } ) ) {BITAND | & } ( ( {IntegerLiteral | 1L } {LT | < } {LT | < } (MUL {
SUB | - } {IntegerLiteral | 83 } ) ) {BITOR || } ( {IntegerLiteral | 1L } {LT | < } {LT | < } (DIV {
SUB | - } {IntegerLiteral | 83 } ) ) {BITOR || } ( {IntegerLiteral | 1L } {LT | < } {LT | < } (MOD {
SUB | - } {IntegerLiteral | 83 } ) ) ) ) {NOTEQUAL | != } {IntegerLiteral | 0 } ) ) ) {_errHandler.recoverInline ( {THIS |this
} ) ;  }

consume();
setState(
{
    IntegerLiteral | 1064
} ) ; 

expression(
{
    IntegerLiteral | 14
} ) ;  } {

BREAK | break } ;  {CASE | case } {IntegerLiteral | 2 } {COLON | :  } {_localctx =  new ExpressionContext(_parentctx, _parentState);
pushNewRecursionContext(_localctx, _startState, RULE_expression);
setState(
{
    IntegerLiteral | 1065
} ) ;  {

IF | if } ( {BANG | ! } (precpred(_ctx, {
    IntegerLiteral | 12
} ) ) ) {

THROW | throw }new FailedPredicateException(
{
    THIS | this
} ,  "precpred(_ctx, 12)" ) ; 

setState(
{
    IntegerLiteral | 1066
} ) ; 

_la =  _input.LA ( {IntegerLiteral | 1 } ) ;  {IF | if } ( {BANG | ! } (_la {
EQUAL |=  =  }ADD {
OR || | }_la {
EQUAL |=  =  }SUB ) ) {_errHandler.recoverInline ( {THIS |this
} ) ;  }

consume();
setState(
{
    IntegerLiteral | 1067
} ) ; 

expression(
{
    IntegerLiteral | 13
} ) ;  } {

BREAK | break } ;  {CASE | case } {IntegerLiteral | 3 } {COLON | :  } {_localctx =  new ExpressionContext(_parentctx, _parentState);
pushNewRecursionContext(_localctx, _startState, RULE_expression);
setState(
{
    IntegerLiteral | 1068
} ) ;  {

IF | if } ( {BANG | ! } (precpred(_ctx, {
    IntegerLiteral | 11
} ) ) ) {

THROW | throw }new FailedPredicateException(
{
    THIS | this
} ,  "precpred(_ctx, 11)" ) ; 

setState(
{
    IntegerLiteral | 1076
} ) ;  {

SWITCH | switch } (getInterpreter() .
adaptivePredict(_input, {
    IntegerLiteral | 124
} , 

_ctx ) ) { {CASE | case } {IntegerLiteral | 1 } {COLON | :  } {setState(
{
    IntegerLiteral | 1069
} ) ; 

match(LT);
setState(
{
    IntegerLiteral | 1070
} ) ; 

match(LT); } {
BREAK | break } ;  {CASE | case } {IntegerLiteral | 2 } {COLON | :  } {setState(
{
    IntegerLiteral | 1071
} ) ; 

match(GT);
setState(
{
    IntegerLiteral | 1072
} ) ; 

match(GT);
setState(
{
    IntegerLiteral | 1073
} ) ; 

match(GT); } {
BREAK | break } ;  {CASE | case } {IntegerLiteral | 3 } {COLON | :  } {setState(
{
    IntegerLiteral | 1074
} ) ; 

match(GT);
setState(
{
    IntegerLiteral | 1075
} ) ; 

match(GT); } {
BREAK | break } ;  }setState(
{
    IntegerLiteral | 1078
} ) ; 

expression(
{
    IntegerLiteral | 12
} ) ;  } {

BREAK | break } ;  {CASE | case } {IntegerLiteral | 4 } {COLON | :  } {_localctx =  new ExpressionContext(_parentctx, _parentState);
pushNewRecursionContext(_localctx, _startState, RULE_expression);
setState(
{
    IntegerLiteral | 1079
} ) ;  {

IF | if } ( {BANG | ! } (precpred(_ctx, {
    IntegerLiteral | 10
} ) ) ) {

THROW | throw }new FailedPredicateException(
{
    THIS | this
} ,  "precpred(_ctx, 10)" ) ; 

setState(
{
    IntegerLiteral | 1080
} ) ; 

_la =  _input.LA ( {IntegerLiteral | 1 } ) ;  {IF | if } ( {BANG | ! } ( ( ( ( (_la {
SUB | - } {IntegerLiteral | 67 } ) ) {BITAND | & } {TILDE |~
 } {
IntegerLiteral | 0x3f } ) {EQUAL |=  =  } {IntegerLiteral | 0 } {AND | && } ( ( {IntegerLiteral | 1L } {LT | < } {LT | < } (_la {
SUB | - } {IntegerLiteral | 67 } ) ) {BITAND | & } ( ( {IntegerLiteral | 1L } {LT | < } {LT | < } (GT {
SUB | - } {IntegerLiteral | 67 } ) ) {BITOR || } ( {IntegerLiteral | 1L } {LT | < } {LT | < } (LT {
SUB | - } {IntegerLiteral | 67 } ) ) {BITOR || } ( {IntegerLiteral | 1L } {LT | < } {LT | < } (LE {
SUB | - } {IntegerLiteral | 67 } ) ) {BITOR || } ( {IntegerLiteral | 1L } {LT | < } {LT | < } (GE {
SUB | - } {IntegerLiteral | 67 } ) ) ) ) {NOTEQUAL | != } {IntegerLiteral | 0 } ) ) ) {_errHandler.recoverInline ( {THIS |this
} ) ;  }

consume();
setState(
{
    IntegerLiteral | 1081
} ) ; 

expression(
{
    IntegerLiteral | 11
} ) ;  } {

BREAK | break } ;  {CASE | case } {IntegerLiteral | 5 } {COLON | :  } {_localctx =  new ExpressionContext(_parentctx, _parentState);
pushNewRecursionContext(_localctx, _startState, RULE_expression);
setState(
{
    IntegerLiteral | 1082
} ) ;  {

IF | if } ( {BANG | ! } (precpred(_ctx, {
    IntegerLiteral | 8
} ) ) ) {

THROW | throw }new FailedPredicateException(
{
    THIS | this
} ,  "precpred(_ctx, 8)" ) ; 

setState(
{
    IntegerLiteral | 1083
} ) ; 

_la =  _input.LA ( {IntegerLiteral | 1 } ) ;  {IF | if } ( {BANG | ! } (_la {
EQUAL |=  =  }EQUAL {
OR || | }_la {
EQUAL |=  =  }NOTEQUAL ) ) {_errHandler.recoverInline ( {THIS |this
} ) ;  }

consume();
setState(
{
    IntegerLiteral | 1084
} ) ; 

expression(
{
    IntegerLiteral | 9
} ) ;  } {

BREAK | break } ;  {CASE | case } {IntegerLiteral | 6 } {COLON | :  } {_localctx =  new ExpressionContext(_parentctx, _parentState);
pushNewRecursionContext(_localctx, _startState, RULE_expression);
setState(
{
    IntegerLiteral | 1085
} ) ;  {

IF | if } ( {BANG | ! } (precpred(_ctx, {
    IntegerLiteral | 7
} ) ) ) {

THROW | throw }new FailedPredicateException(
{
    THIS | this
} ,  "precpred(_ctx, 7)" ) ; 

setState(
{
    IntegerLiteral | 1086
} ) ; 

match(BITAND);
setState(
{
    IntegerLiteral | 1087
} ) ; 

expression(
{
    IntegerLiteral | 8
} ) ;  } {

BREAK | break } ;  {CASE | case } {IntegerLiteral | 7 } {COLON | :  } {_localctx =  new ExpressionContext(_parentctx, _parentState);
pushNewRecursionContext(_localctx, _startState, RULE_expression);
setState(
{
    IntegerLiteral | 1088
} ) ;  {

IF | if } ( {BANG | ! } (precpred(_ctx, {
    IntegerLiteral | 6
} ) ) ) {

THROW | throw }new FailedPredicateException(
{
    THIS | this
} ,  "precpred(_ctx, 6)" ) ; 

setState(
{
    IntegerLiteral | 1089
} ) ; 

match(CARET);
setState(
{
    IntegerLiteral | 1090
} ) ; 

expression(
{
    IntegerLiteral | 7
} ) ;  } {

BREAK | break } ;  {CASE | case } {IntegerLiteral | 8 } {COLON | :  } {_localctx =  new ExpressionContext(_parentctx, _parentState);
pushNewRecursionContext(_localctx, _startState, RULE_expression);
setState(
{
    IntegerLiteral | 1091
} ) ;  {

IF | if } ( {BANG | ! } (precpred(_ctx, {
    IntegerLiteral | 5
} ) ) ) {

THROW | throw }new FailedPredicateException(
{
    THIS | this
} ,  "precpred(_ctx, 5)" ) ; 

setState(
{
    IntegerLiteral | 1092
} ) ; 

match(BITOR);
setState(
{
    IntegerLiteral | 1093
} ) ; 

expression(
{
    IntegerLiteral | 6
} ) ;  } {

BREAK | break } ;  {CASE | case } {IntegerLiteral | 9 } {COLON | :  } {_localctx =  new ExpressionContext(_parentctx, _parentState);
pushNewRecursionContext(_localctx, _startState, RULE_expression);
setState(
{
    IntegerLiteral | 1094
} ) ;  {

IF | if } ( {BANG | ! } (precpred(_ctx, {
    IntegerLiteral | 4
} ) ) ) {

THROW | throw }new FailedPredicateException(
{
    THIS | this
} ,  "precpred(_ctx, 4)" ) ; 

setState(
{
    IntegerLiteral | 1095
} ) ; 

match(AND);
setState(
{
    IntegerLiteral | 1096
} ) ; 

expression(
{
    IntegerLiteral | 5
} ) ;  } {

BREAK | break } ;  {CASE | case } {IntegerLiteral | 10 } {COLON | :  } {_localctx =  new ExpressionContext(_parentctx, _parentState);
pushNewRecursionContext(_localctx, _startState, RULE_expression);
setState(
{
    IntegerLiteral | 1097
} ) ;  {

IF | if } ( {BANG | ! } (precpred(_ctx, {
    IntegerLiteral | 3
} ) ) ) {

THROW | throw }new FailedPredicateException(
{
    THIS | this
} ,  "precpred(_ctx, 3)" ) ; 

setState(
{
    IntegerLiteral | 1098
} ) ; 

match(OR);
setState(
{
    IntegerLiteral | 1099
} ) ; 

expression(
{
    IntegerLiteral | 4
} ) ;  } {

BREAK | break } ;  {CASE | case } {IntegerLiteral | 11 } {COLON | :  } {_localctx =  new ExpressionContext(_parentctx, _parentState);
pushNewRecursionContext(_localctx, _startState, RULE_expression);
setState(
{
    IntegerLiteral | 1100
} ) ;  {

IF | if } ( {BANG | ! } (precpred(_ctx, {
    IntegerLiteral | 2
} ) ) ) {

THROW | throw }new FailedPredicateException(
{
    THIS | this
} ,  "precpred(_ctx, 2)" ) ; 

setState(
{
    IntegerLiteral | 1101
} ) ; 

match(QUESTION);
setState(
{
    IntegerLiteral | 1102
} ) ; 

expression(
{
    IntegerLiteral | 0
} ) ; 

setState(
{
    IntegerLiteral | 1103
} ) ; 

match(COLON);
setState(
{
    IntegerLiteral | 1104
} ) ; 

expression(
{
    IntegerLiteral | 3
} ) ;  } {

BREAK | break } ;  {CASE | case } {IntegerLiteral | 12 } {COLON | :  } {_localctx =  new ExpressionContext(_parentctx, _parentState);
pushNewRecursionContext(_localctx, _startState, RULE_expression);
setState(
{
    IntegerLiteral | 1106
} ) ;  {

IF | if } ( {BANG | ! } (precpred(_ctx, {
    IntegerLiteral | 1
} ) ) ) {

THROW | throw }new FailedPredicateException(
{
    THIS | this
} ,  "precpred(_ctx, 1)" ) ; 

setState(
{
    IntegerLiteral | 1107
} ) ; 

_la =  _input.LA ( {IntegerLiteral | 1 } ) ;  {IF | if } ( {BANG | ! } ( ( ( ( (_la {
SUB | - } {IntegerLiteral | 66 } ) ) {BITAND | & } {TILDE |~
 } {
IntegerLiteral | 0x3f } ) {EQUAL |=  =  } {IntegerLiteral | 0 } {AND | && } ( ( {IntegerLiteral | 1L } {LT | < } {LT | < } (_la {
SUB | - } {IntegerLiteral | 66 } ) ) {BITAND | & } ( ( {IntegerLiteral | 1L } {LT | < } {LT | < } (ASSIGN {
SUB | - } {IntegerLiteral | 66 } ) ) {BITOR || } ( {IntegerLiteral | 1L } {LT | < } {LT | < } (ADD_ASSIGN {
SUB | - } {IntegerLiteral | 66 } ) ) {BITOR || } ( {IntegerLiteral | 1L } {LT | < } {LT | < } (SUB_ASSIGN {
SUB | - } {IntegerLiteral | 66 } ) ) {BITOR || } ( {IntegerLiteral | 1L } {LT | < } {LT | < } (MUL_ASSIGN {
SUB | - } {IntegerLiteral | 66 } ) ) {BITOR || } ( {IntegerLiteral | 1L } {LT | < } {LT | < } (DIV_ASSIGN {
SUB | - } {IntegerLiteral | 66 } ) ) {BITOR || } ( {IntegerLiteral | 1L } {LT | < } {LT | < } (AND_ASSIGN {
SUB | - } {IntegerLiteral | 66 } ) ) {BITOR || } ( {IntegerLiteral | 1L } {LT | < } {LT | < } (OR_ASSIGN {
SUB | - } {IntegerLiteral | 66 } ) ) {BITOR || } ( {IntegerLiteral | 1L } {LT | < } {LT | < } (XOR_ASSIGN {
SUB | - } {IntegerLiteral | 66 } ) ) {BITOR || } ( {IntegerLiteral | 1L } {LT | < } {LT | < } (MOD_ASSIGN {
SUB | - } {IntegerLiteral | 66 } ) ) {BITOR || } ( {IntegerLiteral | 1L } {LT | < } {LT | < } (LSHIFT_ASSIGN {
SUB | - } {IntegerLiteral | 66 } ) ) {BITOR || } ( {IntegerLiteral | 1L } {LT | < } {LT | < } (RSHIFT_ASSIGN {
SUB | - } {IntegerLiteral | 66 } ) ) {BITOR || } ( {IntegerLiteral | 1L } {LT | < } {LT | < } (URSHIFT_ASSIGN {
SUB | - } {IntegerLiteral | 66 } ) ) ) ) {NOTEQUAL | != } {IntegerLiteral | 0 } ) ) ) {_errHandler.recoverInline ( {THIS |this
} ) ;  }

consume();
setState(
{
    IntegerLiteral | 1108
} ) ; 

expression(
{
    IntegerLiteral | 1
} ) ;  } {

BREAK | break } ;  {CASE | case } {IntegerLiteral | 13 } {COLON | :  } {_localctx =  new ExpressionContext(_parentctx, _parentState);
pushNewRecursionContext(_localctx, _startState, RULE_expression);
setState(
{
    IntegerLiteral | 1109
} ) ;  {

IF | if } ( {BANG | ! } (precpred(_ctx, {
    IntegerLiteral | 25
} ) ) ) {

THROW | throw }new FailedPredicateException(
{
    THIS | this
} ,  "precpred(_ctx, 25)" ) ; 

setState(
{
    IntegerLiteral | 1110
} ) ; 

match(DOT);
setState(
{
    IntegerLiteral | 1111
} ) ; 

match(Identifier); } {
BREAK | break } ;  {CASE | case } {IntegerLiteral | 14 } {COLON | :  } {_localctx =  new ExpressionContext(_parentctx, _parentState);
pushNewRecursionContext(_localctx, _startState, RULE_expression);
setState(
{
    IntegerLiteral | 1112
} ) ;  {

IF | if } ( {BANG | ! } (precpred(_ctx, {
    IntegerLiteral | 24
} ) ) ) {

THROW | throw }new FailedPredicateException(
{
    THIS | this
} ,  "precpred(_ctx, 24)" ) ; 

setState(
{
    IntegerLiteral | 1113
} ) ; 

match(DOT);
setState(
{
    IntegerLiteral | 1114
} ) ; 

match(THIS); } {
BREAK | break } ;  {CASE | case } {IntegerLiteral | 15 } {COLON | :  } {_localctx =  new ExpressionContext(_parentctx, _parentState);
pushNewRecursionContext(_localctx, _startState, RULE_expression);
setState(
{
    IntegerLiteral | 1115
} ) ;  {

IF | if } ( {BANG | ! } (precpred(_ctx, {
    IntegerLiteral | 23
} ) ) ) {

THROW | throw }new FailedPredicateException(
{
    THIS | this
} ,  "precpred(_ctx, 23)" ) ; 

setState(
{
    IntegerLiteral | 1116
} ) ; 

match(DOT);
setState(
{
    IntegerLiteral | 1117
} ) ; 

match(NEW);
setState(
{
    IntegerLiteral | 1119
} ) ; 

_la =  _input.LA ( {IntegerLiteral | 1 } ) ;  {IF | if } (_la {
EQUAL |=  =  }LT ) { {setState(
{
    IntegerLiteral | 1118
} ) ; 

nonWildcardTypeArguments(); } }
setState(
{
    IntegerLiteral | 1121
} ) ; 

innerCreator(); } {
BREAK | break } ;  {CASE | case } {IntegerLiteral | 16 } {COLON | :  } {_localctx =  new ExpressionContext(_parentctx, _parentState);
pushNewRecursionContext(_localctx, _startState, RULE_expression);
setState(
{
    IntegerLiteral | 1122
} ) ;  {

IF | if } ( {BANG | ! } (precpred(_ctx, {
    IntegerLiteral | 22
} ) ) ) {

THROW | throw }new FailedPredicateException(
{
    THIS | this
} ,  "precpred(_ctx, 22)" ) ; 

setState(
{
    IntegerLiteral | 1123
} ) ; 

match(DOT);
setState(
{
    IntegerLiteral | 1124
} ) ; 

match(SUPER);
setState(
{
    IntegerLiteral | 1125
} ) ; 

superSuffix(); } {
BREAK | break } ;  {CASE | case } {IntegerLiteral | 17 } {COLON | :  } {_localctx =  new ExpressionContext(_parentctx, _parentState);
pushNewRecursionContext(_localctx, _startState, RULE_expression);
setState(
{
    IntegerLiteral | 1126
} ) ;  {

IF | if } ( {BANG | ! } (precpred(_ctx, {
    IntegerLiteral | 21
} ) ) ) {

THROW | throw }new FailedPredicateException(
{
    THIS | this
} ,  "precpred(_ctx, 21)" ) ; 

setState(
{
    IntegerLiteral | 1127
} ) ; 

match(DOT);
setState(
{
    IntegerLiteral | 1128
} ) ; 

explicitGenericInvocation(); } {
BREAK | break } ;  {CASE | case } {IntegerLiteral | 18 } {COLON | :  } {_localctx =  new ExpressionContext(_parentctx, _parentState);
pushNewRecursionContext(_localctx, _startState, RULE_expression);
setState(
{
    IntegerLiteral | 1129
} ) ;  {

IF | if } ( {BANG | ! } (precpred(_ctx, {
    IntegerLiteral | 20
} ) ) ) {

THROW | throw }new FailedPredicateException(
{
    THIS | this
} ,  "precpred(_ctx, 20)" ) ; 

setState(
{
    IntegerLiteral | 1130
} ) ; 

match(LBRACK);
setState(
{
    IntegerLiteral | 1131
} ) ; 

expression(
{
    IntegerLiteral | 0
} ) ; 

setState(
{
    IntegerLiteral | 1132
} ) ; 

match(RBRACK); } {
BREAK | break } ;  {CASE | case } {IntegerLiteral | 19 } {COLON | :  } {_localctx =  new ExpressionContext(_parentctx, _parentState);
pushNewRecursionContext(_localctx, _startState, RULE_expression);
setState(
{
    IntegerLiteral | 1134
} ) ;  {

IF | if } ( {BANG | ! } (precpred(_ctx, {
    IntegerLiteral | 19
} ) ) ) {

THROW | throw }new FailedPredicateException(
{
    THIS | this
} ,  "precpred(_ctx, 19)" ) ; 

setState(
{
    IntegerLiteral | 1135
} ) ; 

match(LPAREN);
setState(
{
    IntegerLiteral | 1137
} ) ; 

_la =  _input.LA ( {IntegerLiteral | 1 } ) ;  {IF | if } ( ( ( (_la ) {BITAND | & } {TILDE |~
 } {
IntegerLiteral | 0x3f } ) {EQUAL |=  =  } {IntegerLiteral | 0 } {AND | && } ( ( {IntegerLiteral | 1L } {LT | < } {LT | < }_la ) {BITAND | & } ( ( {IntegerLiteral | 1L } {LT | < } {LT | < }BOOLEAN ) {BITOR || } ( {IntegerLiteral | 1L } {LT | < } {LT | < }BYTE ) {BITOR || } ( {IntegerLiteral | 1L } {LT | < } {LT | < }CHAR ) {BITOR || } ( {IntegerLiteral | 1L } {LT | < } {LT | < }DOUBLE ) {BITOR || } ( {IntegerLiteral | 1L } {LT | < } {LT | < }FLOAT ) {BITOR || } ( {IntegerLiteral | 1L } {LT | < } {LT | < }INT ) {BITOR || } ( {IntegerLiteral | 1L } {LT | < } {LT | < }LONG ) {BITOR || } ( {IntegerLiteral | 1L } {LT | < } {LT | < }NEW ) {BITOR || } ( {IntegerLiteral | 1L } {LT | < } {LT | < }SHORT ) {BITOR || } ( {IntegerLiteral | 1L } {LT | < } {LT | < }SUPER ) {BITOR || } ( {IntegerLiteral | 1L } {LT | < } {LT | < }THIS ) {BITOR || } ( {IntegerLiteral | 1L } {LT | < } {LT | < }VOID ) {BITOR || } ( {IntegerLiteral | 1L } {LT | < } {LT | < }IntegerLiteral ) {BITOR || } ( {IntegerLiteral | 1L } {LT | < } {LT | < }FloatingPointLiteral ) {BITOR || } ( {IntegerLiteral | 1L } {LT | < } {LT | < }BooleanLiteral ) {BITOR || } ( {IntegerLiteral | 1L } {LT | < } {LT | < }CharacterLiteral ) {BITOR || } ( {IntegerLiteral | 1L } {LT | < } {LT | < }StringLiteral ) {BITOR || } ( {IntegerLiteral | 1L } {LT | < } {LT | < }NullLiteral ) {BITOR || } ( {IntegerLiteral | 1L } {LT | < } {LT | < }LPAREN ) ) ) {NOTEQUAL | != } {IntegerLiteral | 0 } ) {OR || | } ( ( ( (_la {
SUB | - } {IntegerLiteral | 68 } ) ) {BITAND | & } {TILDE |~
 } {
IntegerLiteral | 0x3f } ) {EQUAL |=  =  } {IntegerLiteral | 0 } {AND | && } ( ( {IntegerLiteral | 1L } {LT | < } {LT | < } (_la {
SUB | - } {IntegerLiteral | 68 } ) ) {BITAND | & } ( ( {IntegerLiteral | 1L } {LT | < } {LT | < } (LT {
SUB | - } {IntegerLiteral | 68 } ) ) {BITOR || } ( {IntegerLiteral | 1L } {LT | < } {LT | < } (BANG {
SUB | - } {IntegerLiteral | 68 } ) ) {BITOR || } ( {IntegerLiteral | 1L } {LT | < } {LT | < } (TILDE {
SUB | - } {IntegerLiteral | 68 } ) ) {BITOR || } ( {IntegerLiteral | 1L } {LT | < } {LT | < } (INC {
SUB | - } {IntegerLiteral | 68 } ) ) {BITOR || } ( {IntegerLiteral | 1L } {LT | < } {LT | < } (DEC {
SUB | - } {IntegerLiteral | 68 } ) ) {BITOR || } ( {IntegerLiteral | 1L } {LT | < } {LT | < } (ADD {
SUB | - } {IntegerLiteral | 68 } ) ) {BITOR || } ( {IntegerLiteral | 1L } {LT | < } {LT | < } (SUB {
SUB | - } {IntegerLiteral | 68 } ) ) {BITOR || } ( {IntegerLiteral | 1L } {LT | < } {LT | < } (Identifier {
SUB | - } {IntegerLiteral | 68 } ) ) ) ) {NOTEQUAL | != } {IntegerLiteral | 0 } ) ) { {setState(
{
    IntegerLiteral | 1136
} ) ; 

expressionList(); } }
setState(
{
    IntegerLiteral | 1139
} ) ; 

match(RPAREN); } {
BREAK | break } ;  {CASE | case } {IntegerLiteral | 20 } {COLON | :  } {_localctx =  new ExpressionContext(_parentctx, _parentState);
pushNewRecursionContext(_localctx, _startState, RULE_expression);
setState(
{
    IntegerLiteral | 1140
} ) ;  {

IF | if } ( {BANG | ! } (precpred(_ctx, {
    IntegerLiteral | 16
} ) ) ) {

THROW | throw }new FailedPredicateException(
{
    THIS | this
} ,  "precpred(_ctx, 16)" ) ; 

setState(
{
    IntegerLiteral | 1141
} ) ; 

_la =  _input.LA ( {IntegerLiteral | 1 } ) ;  {IF | if } ( {BANG | ! } (_la {
EQUAL |=  =  }INC {
OR || | }_la {
EQUAL |=  =  }DEC ) ) {_errHandler.recoverInline ( {THIS |this
} ) ;  }

consume(); } {
BREAK | break } ;  {CASE | case } {IntegerLiteral | 21 } {COLON | :  } {_localctx =  new ExpressionContext(_parentctx, _parentState);
pushNewRecursionContext(_localctx, _startState, RULE_expression);
setState(
{
    IntegerLiteral | 1142
} ) ;  {

IF | if } ( {BANG | ! } (precpred(_ctx, {
    IntegerLiteral | 9
} ) ) ) {

THROW | throw }new FailedPredicateException(
{
    THIS | this
} ,  "precpred(_ctx, 9)" ) ; 

setState(
{
    IntegerLiteral | 1143
} ) ; 

match(INSTANCEOF);
setState(
{
    IntegerLiteral | 1144
} ) ; 

type(); } {
BREAK | break } ;  } } }setState(
{
    IntegerLiteral | 1149
} ) ; 

_errHandler.sync ( {THIS |this
} ) ; 

_alt =  getInterpreter() .
adaptivePredict(_input, {
    IntegerLiteral | 128
} , 

_ctx ) ;  } } } catch  (RecognitionException re ) {
_localctx.exception =  re ; _errHandler.reportError ( {THIS |this
} , 

re ) ; _errHandler.recover ( {THIS |this
} , 

re ) ;  } {FINALLY | finally } {unrollRecursionContexts(_parentctx); } {
RETURN | return }_localctx ;  }public static class PrimaryContext
{
    EXTENDS |extends
}

ParserRuleContext {
public TerminalNodeIdentifier()
{
    {
        RETURN | return
    }

    getToken(JavaParser.Identifier, {
        IntegerLiteral | 0
    } )

    ;
}

public NonWildcardTypeArgumentsContextnonWildcardTypeArguments()
{
    {
        RETURN | return
    }

    getRuleContext(NonWildcardTypeArgumentsContext.class ,  {

IntegerLiteral | 0 } ) ;  }public ExplicitGenericInvocationSuffixContextexplicitGenericInvocationSuffix()
{
    {
        RETURN | return
    }

    getRuleContext(ExplicitGenericInvocationSuffixContext.class ,  {

IntegerLiteral | 0 } ) ;  }public LiteralContextliteral()
{
    {
        RETURN | return
    }

    getRuleContext(LiteralContext.class ,  {

IntegerLiteral | 0 } ) ;  }public TypeContexttype()
{
    {
        RETURN | return
    }

    getRuleContext(TypeContext.class ,  {

IntegerLiteral | 0 } ) ;  }public ArgumentsContextarguments()
{
    {
        RETURN | return
    }

    getRuleContext(ArgumentsContext.class ,  {

IntegerLiteral | 0 } ) ;  }public ExpressionContextexpression()
{
    {
        RETURN | return
    }

    getRuleContext(ExpressionContext.class ,  {

IntegerLiteral | 0 } ) ;  }public PrimaryContext(ParserRuleContext parent, {
    INT | int
}

invokingState ) { {SUPER |super } (
parent , invokingState ) ;  } {AT | @ }Override public {
INT |int }
getRuleIndex()
{
    {
        RETURN | return
    }

    RULE_primary;
} {

AT | @ }Override public void enterRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterPrimary(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public void exitRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitPrimary(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public {
LT | < }T {
GT | > }Taccept(ParseTreeVisitor
{
    LT | <
} {

QUESTION |? } {
EXTENDS |extends }
T {
GT | > }visitor ) { {IF | if } (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) {RETURN | return } ( (JavaVisitor {
LT | < } {QUESTION |? } {
EXTENDS |extends }
T {
GT | > } )visitor ) .visitPrimary(
{
    THIS | this
} ) ;  {

ELSE | else } {RETURN | return }visitor.visitChildren ( {THIS |this
} ) ;  } }

public {
FINAL |final }
PrimaryContextprimary()
{
    PrimaryContext _localctx = new PrimaryContext(_ctx, getState());
    enterRule(_localctx, {
        IntegerLiteral | 176
    } , 

    RULE_primary )
    ;
    try
    {
        setState(
        {
            IntegerLiteral | 1171
        } )

        ;
        {
            SWITCH | switch
            }

            (getInterpreter().adaptivePredict(_input, {
                IntegerLiteral | 130
            } , 

            _ctx ) )
            {
                {
                    CASE |  case
                }

                {
                    IntegerLiteral | 1
                }

                {
                    COLON |  : 
                }

                enterOuterAlt(_localctx, {
                    IntegerLiteral | 1
                } )

                ;
                {
                    setState(
                    {
                        IntegerLiteral | 1150
                    } )

                    ;
                    match(LPAREN);
                    setState(
                    {
                        IntegerLiteral | 1151
                    } )

                    ;
                    expression(
                    {
                        IntegerLiteral | 0
                    } )

                    ;
                    setState(
                    {
                        IntegerLiteral | 1152
                    } )

                    ;
                    match(RPAREN);
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                {
                    IntegerLiteral | 2
                }

                {
                    COLON |  : 
                }

                enterOuterAlt(_localctx, {
                    IntegerLiteral | 2
                } )

                ;
                {
                    setState(
                    {
                        IntegerLiteral | 1154
                    } )

                    ;
                    match(THIS);
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                {
                    IntegerLiteral | 3
                }

                {
                    COLON |  : 
                }

                enterOuterAlt(_localctx, {
                    IntegerLiteral | 3
                } )

                ;
                {
                    setState(
                    {
                        IntegerLiteral | 1155
                    } )

                    ;
                    match(SUPER);
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                {
                    IntegerLiteral | 4
                }

                {
                    COLON |  : 
                }

                enterOuterAlt(_localctx, {
                    IntegerLiteral | 4
                } )

                ;
                {
                    setState(
                    {
                        IntegerLiteral | 1156
                    } )

                    ;
                    literal();
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                {
                    IntegerLiteral | 5
                }

                {
                    COLON |  : 
                }

                enterOuterAlt(_localctx, {
                    IntegerLiteral | 5
                } )

                ;
                {
                    setState(
                    {
                        IntegerLiteral | 1157
                    } )

                    ;
                    match(Identifier);
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                {
                    IntegerLiteral | 6
                }

                {
                    COLON |  : 
                }

                enterOuterAlt(_localctx, {
                    IntegerLiteral | 6
                } )

                ;
                {
                    setState(
                    {
                        IntegerLiteral | 1158
                    } )

                    ;
                    type();
                    setState(
                    {
                        IntegerLiteral | 1159
                    } )

                    ;
                    match(DOT);
                    setState(
                    {
                        IntegerLiteral | 1160
                    } )

                    ;
                    match(CLASS);
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                {
                    IntegerLiteral | 7
                }

                {
                    COLON |  : 
                }

                enterOuterAlt(_localctx, {
                    IntegerLiteral | 7
                } )

                ;
                {
                    setState(
                    {
                        IntegerLiteral | 1162
                    } )

                    ;
                    match(VOID);
                    setState(
                    {
                        IntegerLiteral | 1163
                    } )

                    ;
                    match(DOT);
                    setState(
                    {
                        IntegerLiteral | 1164
                    } )

                    ;
                    match(CLASS);
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                {
                    IntegerLiteral | 8
                }

                {
                    COLON |  : 
                }

                enterOuterAlt(_localctx, {
                    IntegerLiteral | 8
                } )

                ;
                {
                    setState(
                    {
                        IntegerLiteral | 1165
                    } )

                    ;
                    nonWildcardTypeArguments();
                    setState(
                    {
                        IntegerLiteral | 1169
                    } )

                    ;
                    {
                        SWITCH | switch
                        }

                        (_input.LA(
                        {
                            IntegerLiteral | 1
                        } ) )

                        {
                            {
                                CASE |  case
                            }

                            SUPER
                            {
                                COLON |  : 
                            }

                            {
                                CASE |  case
                            }

                            Identifier
                            {
                                COLON |  : 
                            }

                            {
                                setState(
                                {
                                    IntegerLiteral | 1166
                                } )

                                ;
                                explicitGenericInvocationSuffix();
                            }

                            {
                                BREAK | break
                            }

                            ;
                            {
                                CASE |  case
                            }

                            THIS
                            {
                                COLON |  : 
                            }

                            {
                                setState(
                                {
                                    IntegerLiteral | 1167
                                } )

                                ;
                                match(THIS);
                                setState(
                                {
                                    IntegerLiteral | 1168
                                } )

                                ;
                                arguments();
                            }

                            {
                                BREAK | break
                            }

                            ;
                            {
                                DEFAULT | default
                            }

                            {
                                COLON |  : 
                            }

                            {
                                THROW | throw
                            }

                            new NoViableAltException(
                            {
                            THIS | this
                            }

                             )
                            ;
                        }
                    }

                    {
                        BREAK | break
                    }

                    ;
                }
            }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(
        {
            THIS | this
        } , 

        re )
        ;
        _errHandler.recover(
        {
            THIS | this
        } , 

        re )
        ;
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        {
            RETURN | return
        }

        _localctx;
    }

public static class CreatorContext
{
    EXTENDS |extends
}

ParserRuleContext {
public ArrayCreatorRestContextarrayCreatorRest()
{
    {
        RETURN | return
    }

    getRuleContext(ArrayCreatorRestContext.class ,  {

IntegerLiteral | 0 } ) ;  }public NonWildcardTypeArgumentsContextnonWildcardTypeArguments()
{
    {
        RETURN | return
    }

    getRuleContext(NonWildcardTypeArgumentsContext.class ,  {

IntegerLiteral | 0 } ) ;  }public ClassCreatorRestContextclassCreatorRest()
{
    {
        RETURN | return
    }

    getRuleContext(ClassCreatorRestContext.class ,  {

IntegerLiteral | 0 } ) ;  }public CreatedNameContextcreatedName()
{
    {
        RETURN | return
    }

    getRuleContext(CreatedNameContext.class ,  {

IntegerLiteral | 0 } ) ;  }public CreatorContext(ParserRuleContext parent, {
    INT | int
}

invokingState ) { {SUPER |super } (
parent , invokingState ) ;  } {AT | @ }Override public {
INT |int }
getRuleIndex()
{
    {
        RETURN | return
    }

    RULE_creator;
} {

AT | @ }Override public void enterRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterCreator(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public void exitRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitCreator(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public {
LT | < }T {
GT | > }Taccept(ParseTreeVisitor
{
    LT | <
} {

QUESTION |? } {
EXTENDS |extends }
T {
GT | > }visitor ) { {IF | if } (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) {RETURN | return } ( (JavaVisitor {
LT | < } {QUESTION |? } {
EXTENDS |extends }
T {
GT | > } )visitor ) .visitCreator(
{
    THIS | this
} ) ;  {

ELSE | else } {RETURN | return }visitor.visitChildren ( {THIS |this
} ) ;  } }

public {
FINAL |final }
CreatorContextcreator()
{
    CreatorContext _localctx = new CreatorContext(_ctx, getState());
    enterRule(_localctx, {
        IntegerLiteral | 178
    } , 

    RULE_creator )
    ;
    try
    {
        setState(
        {
            IntegerLiteral | 1182
        } )

        ;
        {
            SWITCH | switch
            }

            (_input.LA(
            {
                IntegerLiteral | 1
            } ) )

            {
                {
                    CASE |  case
                }

                LT
                {
                    COLON |  : 
                }

                enterOuterAlt(_localctx, {
                    IntegerLiteral | 1
                } )

                ;
                {
                    setState(
                    {
                        IntegerLiteral | 1173
                    } )

                    ;
                    nonWildcardTypeArguments();
                    setState(
                    {
                        IntegerLiteral | 1174
                    } )

                    ;
                    createdName();
                    setState(
                    {
                        IntegerLiteral | 1175
                    } )

                    ;
                    classCreatorRest();
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                BOOLEAN
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                BYTE
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                CHAR
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                DOUBLE
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                FLOAT
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                INT
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                LONG
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                SHORT
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                Identifier
                {
                    COLON |  : 
                }

                enterOuterAlt(_localctx, {
                    IntegerLiteral | 2
                } )

                ;
                {
                    setState(
                    {
                        IntegerLiteral | 1177
                    } )

                    ;
                    createdName();
                    setState(
                    {
                        IntegerLiteral | 1180
                    } )

                    ;
                    {
                        SWITCH | switch
                        }

                        (_input.LA(
                        {
                            IntegerLiteral | 1
                        } ) )

                        {
                            {
                                CASE |  case
                            }

                            LBRACK
                            {
                                COLON |  : 
                            }

                            {
                                setState(
                                {
                                    IntegerLiteral | 1178
                                } )

                                ;
                                arrayCreatorRest();
                            }

                            {
                                BREAK | break
                            }

                            ;
                            {
                                CASE |  case
                            }

                            LPAREN
                            {
                                COLON |  : 
                            }

                            {
                                setState(
                                {
                                    IntegerLiteral | 1179
                                } )

                                ;
                                classCreatorRest();
                            }

                            {
                                BREAK | break
                            }

                            ;
                            {
                                DEFAULT | default
                            }

                            {
                                COLON |  : 
                            }

                            {
                                THROW | throw
                            }

                            new NoViableAltException(
                            {
                            THIS | this
                            }

                             )
                            ;
                        }
                    }

                    {
                        BREAK | break
                    }

                    ;
                    {
                        DEFAULT | default
                    }

                    {
                        COLON |  : 
                    }

                    {
                        THROW | throw
                    }

                    new NoViableAltException(
                    {
                    THIS | this
                    }

                     )
                    ;
                }
            }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(
        {
            THIS | this
        } , 

        re )
        ;
        _errHandler.recover(
        {
            THIS | this
        } , 

        re )
        ;
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        {
            RETURN | return
        }

        _localctx;
    }

public static class CreatedNameContext
{
    EXTENDS |extends
}

ParserRuleContext {
public List {
LT | < }TerminalNode {
GT | > }Identifier()
{
    {
        RETURN | return
    }

    getTokens(JavaParser.Identifier);
}

public TerminalNodeIdentifier(
{
    INT | int
}

i ) { {RETURN | return }getToken(JavaParser.Identifier, i); }
public List {
LT | < }TypeArgumentsOrDiamondContext {
GT | > }typeArgumentsOrDiamond()
{
    {
        RETURN | return
    }

    getRuleContexts(TypeArgumentsOrDiamondContext.class ) ;  }

public PrimitiveTypeContextprimitiveType()
{
    {
        RETURN | return
    }

    getRuleContext(PrimitiveTypeContext.class ,  {

IntegerLiteral | 0 } ) ;  }public TypeArgumentsOrDiamondContexttypeArgumentsOrDiamond(
{
    INT | int
}

i ) { {RETURN | return }getRuleContext(TypeArgumentsOrDiamondContext.class , 

i ) ;  }public CreatedNameContext(ParserRuleContext parent, {
    INT | int
}

invokingState ) { {SUPER |super } (
parent , invokingState ) ;  } {AT | @ }Override public {
INT |int }
getRuleIndex()
{
    {
        RETURN | return
    }

    RULE_createdName;
} {

AT | @ }Override public void enterRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterCreatedName(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public void exitRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitCreatedName(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public {
LT | < }T {
GT | > }Taccept(ParseTreeVisitor
{
    LT | <
} {

QUESTION |? } {
EXTENDS |extends }
T {
GT | > }visitor ) { {IF | if } (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) {RETURN | return } ( (JavaVisitor {
LT | < } {QUESTION |? } {
EXTENDS |extends }
T {
GT | > } )visitor ) .visitCreatedName(
{
    THIS | this
} ) ;  {

ELSE | else } {RETURN | return }visitor.visitChildren ( {THIS |this
} ) ;  } }

public {
FINAL |final }
CreatedNameContextcreatedName()
{
    CreatedNameContext _localctx = new CreatedNameContext(_ctx, getState());
    enterRule(_localctx, {
        IntegerLiteral | 180
    } , 

    RULE_createdName )
    ;
    {
        INT | int
    }

    _la;
    try
    {
        setState(
        {
            IntegerLiteral | 1199
        } )

        ;
        {
            SWITCH | switch
            }

            (_input.LA(
            {
                IntegerLiteral | 1
            } ) )

            {
                {
                    CASE |  case
                }

                Identifier
                {
                    COLON |  : 
                }

                enterOuterAlt(_localctx, {
                    IntegerLiteral | 1
                } )

                ;
                {
                    setState(
                    {
                        IntegerLiteral | 1184
                    } )

                    ;
                    match(Identifier);
                    setState(
                    {
                        IntegerLiteral | 1186
                    } )

                    ;
                    _la = _input.LA(
                    {
                        IntegerLiteral | 1
                    } )

                    ;
                    {
                        IF | if
                    }

                    (_la
                    {
                        EQUAL |= =
                    }

                    LT )
                    {
                        {
                            setState(
                            {
                                IntegerLiteral | 1185
                            } )

                            ;
                            typeArgumentsOrDiamond();
                        }
                    }

                    setState(
                    {
                        IntegerLiteral | 1195
                    } )

                    ;
                    _errHandler.sync(
                    {
                        THIS | this
                    } )

                    ;
                    _la = _input.LA(
                    {
                        IntegerLiteral | 1
                    } )

                    ;
                    {
                        WHILE | while
                    }

                    (_la
                    {
                        EQUAL |= =
                    }

                    DOT )
                    {
                        {
                            {
                                setState(
                                {
                                    IntegerLiteral | 1188
                                } )

                                ;
                                match(DOT);
                                setState(
                                {
                                    IntegerLiteral | 1189
                                } )

                                ;
                                match(Identifier);
                                setState(
                                {
                                    IntegerLiteral | 1191
                                } )

                                ;
                                _la = _input.LA(
                                {
                                    IntegerLiteral | 1
                                } )

                                ;
                                {
                                    IF | if
                                }

                                (_la
                                {
                                    EQUAL |= =
                                }

                                LT )
                                {
                                    {
                                        setState(
                                        {
                                            IntegerLiteral | 1190
                                        } )

                                        ;
                                        typeArgumentsOrDiamond();
                                    }
                                }
                            }
                        }

                        setState(
                        {
                            IntegerLiteral | 1197
                        } )

                        ;
                        _errHandler.sync(
                        {
                            THIS | this
                        } )

                        ;
                        _la = _input.LA(
                        {
                            IntegerLiteral | 1
                        } )

                        ;
                    }
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                BOOLEAN
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                BYTE
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                CHAR
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                DOUBLE
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                FLOAT
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                INT
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                LONG
                {
                    COLON |  : 
                }

                {
                    CASE |  case
                }

                SHORT
                {
                    COLON |  : 
                }

                enterOuterAlt(_localctx, {
                    IntegerLiteral | 2
                } )

                ;
                {
                    setState(
                    {
                        IntegerLiteral | 1198
                    } )

                    ;
                    primitiveType();
                }

                {
                    BREAK | break
                }

                ;
                {
                    DEFAULT | default
                }

                {
                    COLON |  : 
                }

                {
                    THROW | throw
                }

                new NoViableAltException(
                {
                THIS | this
                }

                 )
                ;
            }
        }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(
        {
            THIS | this
        } , 

        re )
        ;
        _errHandler.recover(
        {
            THIS | this
        } , 

        re )
        ;
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        {
            RETURN | return
        }

        _localctx;
    }

public static class InnerCreatorContext
{
    EXTENDS |extends
}

ParserRuleContext {
public TerminalNodeIdentifier()
{
    {
        RETURN | return
    }

    getToken(JavaParser.Identifier, {
        IntegerLiteral | 0
    } )

    ;
}

public ClassCreatorRestContextclassCreatorRest()
{
    {
        RETURN | return
    }

    getRuleContext(ClassCreatorRestContext.class ,  {

IntegerLiteral | 0 } ) ;  }public NonWildcardTypeArgumentsOrDiamondContextnonWildcardTypeArgumentsOrDiamond()
{
    {
        RETURN | return
    }

    getRuleContext(NonWildcardTypeArgumentsOrDiamondContext.class ,  {

IntegerLiteral | 0 } ) ;  }public InnerCreatorContext(ParserRuleContext parent, {
    INT | int
}

invokingState ) { {SUPER |super } (
parent , invokingState ) ;  } {AT | @ }Override public {
INT |int }
getRuleIndex()
{
    {
        RETURN | return
    }

    RULE_innerCreator;
} {

AT | @ }Override public void enterRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterInnerCreator(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public void exitRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitInnerCreator(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public {
LT | < }T {
GT | > }Taccept(ParseTreeVisitor
{
    LT | <
} {

QUESTION |? } {
EXTENDS |extends }
T {
GT | > }visitor ) { {IF | if } (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) {RETURN | return } ( (JavaVisitor {
LT | < } {QUESTION |? } {
EXTENDS |extends }
T {
GT | > } )visitor ) .visitInnerCreator(
{
    THIS | this
} ) ;  {

ELSE | else } {RETURN | return }visitor.visitChildren ( {THIS |this
} ) ;  } }

public {
FINAL |final }
InnerCreatorContextinnerCreator()
{
    InnerCreatorContext _localctx = new InnerCreatorContext(_ctx, getState());
    enterRule(_localctx, {
        IntegerLiteral | 182
    } , 

    RULE_innerCreator )
    ;
    {
        INT | int
    }

    _la;
    try
    {
        enterOuterAlt(_localctx, {
            IntegerLiteral | 1
        } )

        ;
        {
            setState(
            {
                IntegerLiteral | 1201
            } )

            ;
            match(Identifier);
            setState(
            {
                IntegerLiteral | 1203
            } )

            ;
            _la = _input.LA(
            {
                IntegerLiteral | 1
            } )

            ;
            {
                IF | if
            }

            (_la
            {
                EQUAL |= =
            }

            LT )
            {
                {
                    setState(
                    {
                        IntegerLiteral | 1202
                    } )

                    ;
                    nonWildcardTypeArgumentsOrDiamond();
                }
            }

            setState(
            {
                IntegerLiteral | 1205
            } )

            ;
            classCreatorRest();
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(
        {
            THIS | this
        } , 

        re )
        ;
        _errHandler.recover(
        {
            THIS | this
        } , 

        re )
        ;
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        {
            RETURN | return
        }

        _localctx;
    }

public static class ArrayCreatorRestContext
{
    EXTENDS |extends
}

ParserRuleContext {
public ArrayInitializerContextarrayInitializer()
{
    {
        RETURN | return
    }

    getRuleContext(ArrayInitializerContext.class ,  {

IntegerLiteral | 0 } ) ;  }public ExpressionContextexpression(
{
    INT | int
}

i ) { {RETURN | return }getRuleContext(ExpressionContext.class , 

i ) ;  }public List {
LT | < }ExpressionContext {
GT | > }expression()
{
    {
        RETURN | return
    }

    getRuleContexts(ExpressionContext.class ) ;  }

public ArrayCreatorRestContext(ParserRuleContext parent, {
    INT | int
}

invokingState ) { {SUPER |super } (
parent , invokingState ) ;  } {AT | @ }Override public {
INT |int }
getRuleIndex()
{
    {
        RETURN | return
    }

    RULE_arrayCreatorRest;
} {

AT | @ }Override public void enterRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterArrayCreatorRest(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public void exitRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitArrayCreatorRest(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public {
LT | < }T {
GT | > }Taccept(ParseTreeVisitor
{
    LT | <
} {

QUESTION |? } {
EXTENDS |extends }
T {
GT | > }visitor ) { {IF | if } (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) {RETURN | return } ( (JavaVisitor {
LT | < } {QUESTION |? } {
EXTENDS |extends }
T {
GT | > } )visitor ) .visitArrayCreatorRest(
{
    THIS | this
} ) ;  {

ELSE | else } {RETURN | return }visitor.visitChildren ( {THIS |this
} ) ;  } }

public {
FINAL |final }
ArrayCreatorRestContextarrayCreatorRest()
{
    ArrayCreatorRestContext _localctx = new ArrayCreatorRestContext(_ctx, getState());
    enterRule(_localctx, {
        IntegerLiteral | 184
    } , 

    RULE_arrayCreatorRest )
    ;
    {
        INT | int
    }

    _la;
    try
    {
        {
            INT | int
        }

        _alt;
        enterOuterAlt(_localctx, {
            IntegerLiteral | 1
        } )

        ;
        {
            setState(
            {
                IntegerLiteral | 1207
            } )

            ;
            match(LBRACK);
            setState(
            {
                IntegerLiteral | 1235
            } )

            ;
            {
                SWITCH | switch
                }

                (_input.LA(
                {
                    IntegerLiteral | 1
                } ) )

                {
                    {
                        CASE |  case
                    }

                    RBRACK
                    {
                        COLON |  : 
                    }

                    {
                        setState(
                        {
                            IntegerLiteral | 1208
                        } )

                        ;
                        match(RBRACK);
                        setState(
                        {
                            IntegerLiteral | 1213
                        } )

                        ;
                        _errHandler.sync(
                        {
                            THIS | this
                        } )

                        ;
                        _la = _input.LA(
                        {
                            IntegerLiteral | 1
                        } )

                        ;
                        {
                            WHILE | while
                        }

                        (_la
                        {
                            EQUAL |= =
                        }

                        LBRACK )
                        {
                            {
                                {
                                    setState(
                                    {
                                        IntegerLiteral | 1209
                                    } )

                                    ;
                                    match(LBRACK);
                                    setState(
                                    {
                                        IntegerLiteral | 1210
                                    } )

                                    ;
                                    match(RBRACK);
                                }
                            }

                            setState(
                            {
                                IntegerLiteral | 1215
                            } )

                            ;
                            _errHandler.sync(
                            {
                                THIS | this
                            } )

                            ;
                            _la = _input.LA(
                            {
                                IntegerLiteral | 1
                            } )

                            ;
                        }

                        setState(
                        {
                            IntegerLiteral | 1216
                        } )

                        ;
                        arrayInitializer();
                    }

                    {
                        BREAK | break
                    }

                    ;
                    {
                        CASE |  case
                    }

                    BOOLEAN
                    {
                        COLON |  : 
                    }

                    {
                        CASE |  case
                    }

                    BYTE
                    {
                        COLON |  : 
                    }

                    {
                        CASE |  case
                    }

                    CHAR
                    {
                        COLON |  : 
                    }

                    {
                        CASE |  case
                    }

                    DOUBLE
                    {
                        COLON |  : 
                    }

                    {
                        CASE |  case
                    }

                    FLOAT
                    {
                        COLON |  : 
                    }

                    {
                        CASE |  case
                    }

                    INT
                    {
                        COLON |  : 
                    }

                    {
                        CASE |  case
                    }

                    LONG
                    {
                        COLON |  : 
                    }

                    {
                        CASE |  case
                    }

                    NEW
                    {
                        COLON |  : 
                    }

                    {
                        CASE |  case
                    }

                    SHORT
                    {
                        COLON |  : 
                    }

                    {
                        CASE |  case
                    }

                    SUPER
                    {
                        COLON |  : 
                    }

                    {
                        CASE |  case
                    }

                    THIS
                    {
                        COLON |  : 
                    }

                    {
                        CASE |  case
                    }

                    VOID
                    {
                        COLON |  : 
                    }

                    {
                        CASE |  case
                    }

                    IntegerLiteral
                    {
                        COLON |  : 
                    }

                    {
                        CASE |  case
                    }

                    FloatingPointLiteral
                    {
                        COLON |  : 
                    }

                    {
                        CASE |  case
                    }

                    BooleanLiteral
                    {
                        COLON |  : 
                    }

                    {
                        CASE |  case
                    }

                    CharacterLiteral
                    {
                        COLON |  : 
                    }

                    {
                        CASE |  case
                    }

                    StringLiteral
                    {
                        COLON |  : 
                    }

                    {
                        CASE |  case
                    }

                    NullLiteral
                    {
                        COLON |  : 
                    }

                    {
                        CASE |  case
                    }

                    LPAREN
                    {
                        COLON |  : 
                    }

                    {
                        CASE |  case
                    }

                    LT
                    {
                        COLON |  : 
                    }

                    {
                        CASE |  case
                    }

                    BANG
                    {
                        COLON |  : 
                    }

                    {
                        CASE |  case
                    }

                    TILDE
                    {
                        COLON |  : 
                    }

                    {
                        CASE |  case
                    }

                    INC
                    {
                        COLON |  : 
                    }

                    {
                        CASE |  case
                    }

                    DEC
                    {
                        COLON |  : 
                    }

                    {
                        CASE |  case
                    }

                    ADD
                    {
                        COLON |  : 
                    }

                    {
                        CASE |  case
                    }

                    SUB
                    {
                        COLON |  : 
                    }

                    {
                        CASE |  case
                    }

                    Identifier
                    {
                        COLON |  : 
                    }

                    {
                        setState(
                        {
                            IntegerLiteral | 1217
                        } )

                        ;
                        expression(
                        {
                            IntegerLiteral | 0
                        } )

                        ;
                        setState(
                        {
                            IntegerLiteral | 1218
                        } )

                        ;
                        match(RBRACK);
                        setState(
                        {
                            IntegerLiteral | 1225
                        } )

                        ;
                        _errHandler.sync(
                        {
                            THIS | this
                        } )

                        ;
                        _alt = getInterpreter().adaptivePredict(_input, {
                            IntegerLiteral | 139
                        } , 

                        _ctx )
                        ;
                        {
                            WHILE | while
                        }

                        (_alt
                        {
                            NOTEQUAL | !=
                        }

                        {
                            IntegerLiteral | 2
                        }

                        {
                            AND | &&
                        }

                        _alt
                        {
                            NOTEQUAL | !=
                        }

                        org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER )
                        {
                            {
                                IF | if
                            }

                            (_alt
                            {
                                EQUAL |= =
                            }

                            {
                                IntegerLiteral | 1
                            } )

                            {
                                {
                                    {
                                        setState(
                                        {
                                            IntegerLiteral | 1219
                                        } )

                                        ;
                                        match(LBRACK);
                                        setState(
                                        {
                                            IntegerLiteral | 1220
                                        } )

                                        ;
                                        expression(
                                        {
                                            IntegerLiteral | 0
                                        } )

                                        ;
                                        setState(
                                        {
                                            IntegerLiteral | 1221
                                        } )

                                        ;
                                        match(RBRACK);
                                    }
                                }
                            }

                            setState(
                            {
                                IntegerLiteral | 1227
                            } )

                            ;
                            _errHandler.sync(
                            {
                                THIS | this
                            } )

                            ;
                            _alt = getInterpreter().adaptivePredict(_input, {
                                IntegerLiteral | 139
                            } , 

                            _ctx )
                            ;
                        }

                        setState(
                        {
                            IntegerLiteral | 1232
                        } )

                        ;
                        _errHandler.sync(
                        {
                            THIS | this
                        } )

                        ;
                        _alt = getInterpreter().adaptivePredict(_input, {
                            IntegerLiteral | 140
                        } , 

                        _ctx )
                        ;
                        {
                            WHILE | while
                        }

                        (_alt
                        {
                            NOTEQUAL | !=
                        }

                        {
                            IntegerLiteral | 2
                        }

                        {
                            AND | &&
                        }

                        _alt
                        {
                            NOTEQUAL | !=
                        }

                        org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER )
                        {
                            {
                                IF | if
                            }

                            (_alt
                            {
                                EQUAL |= =
                            }

                            {
                                IntegerLiteral | 1
                            } )

                            {
                                {
                                    {
                                        setState(
                                        {
                                            IntegerLiteral | 1228
                                        } )

                                        ;
                                        match(LBRACK);
                                        setState(
                                        {
                                            IntegerLiteral | 1229
                                        } )

                                        ;
                                        match(RBRACK);
                                    }
                                }
                            }

                            setState(
                            {
                                IntegerLiteral | 1234
                            } )

                            ;
                            _errHandler.sync(
                            {
                                THIS | this
                            } )

                            ;
                            _alt = getInterpreter().adaptivePredict(_input, {
                                IntegerLiteral | 140
                            } , 

                            _ctx )
                            ;
                        }
                    }

                    {
                        BREAK | break
                    }

                    ;
                    {
                        DEFAULT | default
                    }

                    {
                        COLON |  : 
                    }

                    {
                        THROW | throw
                    }

                    new NoViableAltException(
                    {
                    THIS | this
                    }

                     )
                    ;
                }
            }
        }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(
        {
            THIS | this
        } , 

        re )
        ;
        _errHandler.recover(
        {
            THIS | this
        } , 

        re )
        ;
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        {
            RETURN | return
        }

        _localctx;
    }

public static class ClassCreatorRestContext
{
    EXTENDS |extends
}

ParserRuleContext {
public ClassBodyContextclassBody()
{
    {
        RETURN | return
    }

    getRuleContext(ClassBodyContext.class ,  {

IntegerLiteral | 0 } ) ;  }public ArgumentsContextarguments()
{
    {
        RETURN | return
    }

    getRuleContext(ArgumentsContext.class ,  {

IntegerLiteral | 0 } ) ;  }public ClassCreatorRestContext(ParserRuleContext parent, {
    INT | int
}

invokingState ) { {SUPER |super } (
parent , invokingState ) ;  } {AT | @ }Override public {
INT |int }
getRuleIndex()
{
    {
        RETURN | return
    }

    RULE_classCreatorRest;
} {

AT | @ }Override public void enterRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterClassCreatorRest(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public void exitRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitClassCreatorRest(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public {
LT | < }T {
GT | > }Taccept(ParseTreeVisitor
{
    LT | <
} {

QUESTION |? } {
EXTENDS |extends }
T {
GT | > }visitor ) { {IF | if } (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) {RETURN | return } ( (JavaVisitor {
LT | < } {QUESTION |? } {
EXTENDS |extends }
T {
GT | > } )visitor ) .visitClassCreatorRest(
{
    THIS | this
} ) ;  {

ELSE | else } {RETURN | return }visitor.visitChildren ( {THIS |this
} ) ;  } }

public {
FINAL |final }
ClassCreatorRestContextclassCreatorRest()
{
    ClassCreatorRestContext _localctx = new ClassCreatorRestContext(_ctx, getState());
    enterRule(_localctx, {
        IntegerLiteral | 186
    } , 

    RULE_classCreatorRest )
    ;
    try
    {
        enterOuterAlt(_localctx, {
            IntegerLiteral | 1
        } )

        ;
        {
            setState(
            {
                IntegerLiteral | 1237
            } )

            ;
            arguments();
            setState(
            {
                IntegerLiteral | 1239
            } )

            ;
            {
                SWITCH | switch
                }

                (getInterpreter().adaptivePredict(_input, {
                    IntegerLiteral | 142
                } , 

                _ctx ) )
                {
                    {
                        CASE |  case
                    }

                    {
                        IntegerLiteral | 1
                    }

                    {
                        COLON |  : 
                    }

                    {
                        setState(
                        {
                            IntegerLiteral | 1238
                        } )

                        ;
                        classBody();
                    }

                    {
                        BREAK | break
                    }

                    ;
                }
            }
        }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(
        {
            THIS | this
        } , 

        re )
        ;
        _errHandler.recover(
        {
            THIS | this
        } , 

        re )
        ;
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        {
            RETURN | return
        }

        _localctx;
    }

public static class ExplicitGenericInvocationContext
{
    EXTENDS |extends
}

ParserRuleContext {
public NonWildcardTypeArgumentsContextnonWildcardTypeArguments()
{
    {
        RETURN | return
    }

    getRuleContext(NonWildcardTypeArgumentsContext.class ,  {

IntegerLiteral | 0 } ) ;  }public ExplicitGenericInvocationSuffixContextexplicitGenericInvocationSuffix()
{
    {
        RETURN | return
    }

    getRuleContext(ExplicitGenericInvocationSuffixContext.class ,  {

IntegerLiteral | 0 } ) ;  }public ExplicitGenericInvocationContext(ParserRuleContext parent, {
    INT | int
}

invokingState ) { {SUPER |super } (
parent , invokingState ) ;  } {AT | @ }Override public {
INT |int }
getRuleIndex()
{
    {
        RETURN | return
    }

    RULE_explicitGenericInvocation;
} {

AT | @ }Override public void enterRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterExplicitGenericInvocation(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public void exitRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitExplicitGenericInvocation(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public {
LT | < }T {
GT | > }Taccept(ParseTreeVisitor
{
    LT | <
} {

QUESTION |? } {
EXTENDS |extends }
T {
GT | > }visitor ) { {IF | if } (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) {RETURN | return } ( (JavaVisitor {
LT | < } {QUESTION |? } {
EXTENDS |extends }
T {
GT | > } )visitor ) .visitExplicitGenericInvocation(
{
    THIS | this
} ) ;  {

ELSE | else } {RETURN | return }visitor.visitChildren ( {THIS |this
} ) ;  } }

public {
FINAL |final }
ExplicitGenericInvocationContextexplicitGenericInvocation()
{
    ExplicitGenericInvocationContext _localctx = new ExplicitGenericInvocationContext(_ctx, getState());
    enterRule(_localctx, {
        IntegerLiteral | 188
    } , 

    RULE_explicitGenericInvocation )
    ;
    try
    {
        enterOuterAlt(_localctx, {
            IntegerLiteral | 1
        } )

        ;
        {
            setState(
            {
                IntegerLiteral | 1241
            } )

            ;
            nonWildcardTypeArguments();
            setState(
            {
                IntegerLiteral | 1242
            } )

            ;
            explicitGenericInvocationSuffix();
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(
        {
            THIS | this
        } , 

        re )
        ;
        _errHandler.recover(
        {
            THIS | this
        } , 

        re )
        ;
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        {
            RETURN | return
        }

        _localctx;
    }

public static class NonWildcardTypeArgumentsContext
{
    EXTENDS |extends
}

ParserRuleContext {
public TypeListContexttypeList()
{
    {
        RETURN | return
    }

    getRuleContext(TypeListContext.class ,  {

IntegerLiteral | 0 } ) ;  }public NonWildcardTypeArgumentsContext(ParserRuleContext parent, {
    INT | int
}

invokingState ) { {SUPER |super } (
parent , invokingState ) ;  } {AT | @ }Override public {
INT |int }
getRuleIndex()
{
    {
        RETURN | return
    }

    RULE_nonWildcardTypeArguments;
} {

AT | @ }Override public void enterRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterNonWildcardTypeArguments(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public void exitRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitNonWildcardTypeArguments(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public {
LT | < }T {
GT | > }Taccept(ParseTreeVisitor
{
    LT | <
} {

QUESTION |? } {
EXTENDS |extends }
T {
GT | > }visitor ) { {IF | if } (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) {RETURN | return } ( (JavaVisitor {
LT | < } {QUESTION |? } {
EXTENDS |extends }
T {
GT | > } )visitor ) .visitNonWildcardTypeArguments(
{
    THIS | this
} ) ;  {

ELSE | else } {RETURN | return }visitor.visitChildren ( {THIS |this
} ) ;  } }

public {
FINAL |final }
NonWildcardTypeArgumentsContextnonWildcardTypeArguments()
{
    NonWildcardTypeArgumentsContext _localctx = new NonWildcardTypeArgumentsContext(_ctx, getState());
    enterRule(_localctx, {
        IntegerLiteral | 190
    } , 

    RULE_nonWildcardTypeArguments )
    ;
    try
    {
        enterOuterAlt(_localctx, {
            IntegerLiteral | 1
        } )

        ;
        {
            setState(
            {
                IntegerLiteral | 1244
            } )

            ;
            match(LT);
            setState(
            {
                IntegerLiteral | 1245
            } )

            ;
            typeList();
            setState(
            {
                IntegerLiteral | 1246
            } )

            ;
            match(GT);
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(
        {
            THIS | this
        } , 

        re )
        ;
        _errHandler.recover(
        {
            THIS | this
        } , 

        re )
        ;
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        {
            RETURN | return
        }

        _localctx;
    }

public static class TypeArgumentsOrDiamondContext
{
    EXTENDS |extends
}

ParserRuleContext {
public TypeArgumentsContexttypeArguments()
{
    {
        RETURN | return
    }

    getRuleContext(TypeArgumentsContext.class ,  {

IntegerLiteral | 0 } ) ;  }public TypeArgumentsOrDiamondContext(ParserRuleContext parent, {
    INT | int
}

invokingState ) { {SUPER |super } (
parent , invokingState ) ;  } {AT | @ }Override public {
INT |int }
getRuleIndex()
{
    {
        RETURN | return
    }

    RULE_typeArgumentsOrDiamond;
} {

AT | @ }Override public void enterRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterTypeArgumentsOrDiamond(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public void exitRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitTypeArgumentsOrDiamond(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public {
LT | < }T {
GT | > }Taccept(ParseTreeVisitor
{
    LT | <
} {

QUESTION |? } {
EXTENDS |extends }
T {
GT | > }visitor ) { {IF | if } (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) {RETURN | return } ( (JavaVisitor {
LT | < } {QUESTION |? } {
EXTENDS |extends }
T {
GT | > } )visitor ) .visitTypeArgumentsOrDiamond(
{
    THIS | this
} ) ;  {

ELSE | else } {RETURN | return }visitor.visitChildren ( {THIS |this
} ) ;  } }

public {
FINAL |final }
TypeArgumentsOrDiamondContexttypeArgumentsOrDiamond()
{
    TypeArgumentsOrDiamondContext _localctx = new TypeArgumentsOrDiamondContext(_ctx, getState());
    enterRule(_localctx, {
        IntegerLiteral | 192
    } , 

    RULE_typeArgumentsOrDiamond )
    ;
    try
    {
        setState(
        {
            IntegerLiteral | 1251
        } )

        ;
        {
            SWITCH | switch
            }

            (getInterpreter().adaptivePredict(_input, {
                IntegerLiteral | 143
            } , 

            _ctx ) )
            {
                {
                    CASE |  case
                }

                {
                    IntegerLiteral | 1
                }

                {
                    COLON |  : 
                }

                enterOuterAlt(_localctx, {
                    IntegerLiteral | 1
                } )

                ;
                {
                    setState(
                    {
                        IntegerLiteral | 1248
                    } )

                    ;
                    match(LT);
                    setState(
                    {
                        IntegerLiteral | 1249
                    } )

                    ;
                    match(GT);
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                {
                    IntegerLiteral | 2
                }

                {
                    COLON |  : 
                }

                enterOuterAlt(_localctx, {
                    IntegerLiteral | 2
                } )

                ;
                {
                    setState(
                    {
                        IntegerLiteral | 1250
                    } )

                    ;
                    typeArguments();
                }

                {
                    BREAK | break
                }

                ;
            }
        }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(
        {
            THIS | this
        } , 

        re )
        ;
        _errHandler.recover(
        {
            THIS | this
        } , 

        re )
        ;
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        {
            RETURN | return
        }

        _localctx;
    }

public static class NonWildcardTypeArgumentsOrDiamondContext
{
    EXTENDS |extends
}

ParserRuleContext {
public NonWildcardTypeArgumentsContextnonWildcardTypeArguments()
{
    {
        RETURN | return
    }

    getRuleContext(NonWildcardTypeArgumentsContext.class ,  {

IntegerLiteral | 0 } ) ;  }public NonWildcardTypeArgumentsOrDiamondContext(ParserRuleContext parent, {
    INT | int
}

invokingState ) { {SUPER |super } (
parent , invokingState ) ;  } {AT | @ }Override public {
INT |int }
getRuleIndex()
{
    {
        RETURN | return
    }

    RULE_nonWildcardTypeArgumentsOrDiamond;
} {

AT | @ }Override public void enterRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterNonWildcardTypeArgumentsOrDiamond(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public void exitRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitNonWildcardTypeArgumentsOrDiamond(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public {
LT | < }T {
GT | > }Taccept(ParseTreeVisitor
{
    LT | <
} {

QUESTION |? } {
EXTENDS |extends }
T {
GT | > }visitor ) { {IF | if } (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) {RETURN | return } ( (JavaVisitor {
LT | < } {QUESTION |? } {
EXTENDS |extends }
T {
GT | > } )visitor ) .visitNonWildcardTypeArgumentsOrDiamond(
{
    THIS | this
} ) ;  {

ELSE | else } {RETURN | return }visitor.visitChildren ( {THIS |this
} ) ;  } }

public {
FINAL |final }
NonWildcardTypeArgumentsOrDiamondContextnonWildcardTypeArgumentsOrDiamond()
{
    NonWildcardTypeArgumentsOrDiamondContext _localctx = new NonWildcardTypeArgumentsOrDiamondContext(_ctx, getState());
    enterRule(_localctx, {
        IntegerLiteral | 194
    } , 

    RULE_nonWildcardTypeArgumentsOrDiamond )
    ;
    try
    {
        setState(
        {
            IntegerLiteral | 1256
        } )

        ;
        {
            SWITCH | switch
            }

            (getInterpreter().adaptivePredict(_input, {
                IntegerLiteral | 144
            } , 

            _ctx ) )
            {
                {
                    CASE |  case
                }

                {
                    IntegerLiteral | 1
                }

                {
                    COLON |  : 
                }

                enterOuterAlt(_localctx, {
                    IntegerLiteral | 1
                } )

                ;
                {
                    setState(
                    {
                        IntegerLiteral | 1253
                    } )

                    ;
                    match(LT);
                    setState(
                    {
                        IntegerLiteral | 1254
                    } )

                    ;
                    match(GT);
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                {
                    IntegerLiteral | 2
                }

                {
                    COLON |  : 
                }

                enterOuterAlt(_localctx, {
                    IntegerLiteral | 2
                } )

                ;
                {
                    setState(
                    {
                        IntegerLiteral | 1255
                    } )

                    ;
                    nonWildcardTypeArguments();
                }

                {
                    BREAK | break
                }

                ;
            }
        }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(
        {
            THIS | this
        } , 

        re )
        ;
        _errHandler.recover(
        {
            THIS | this
        } , 

        re )
        ;
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        {
            RETURN | return
        }

        _localctx;
    }

public static class SuperSuffixContext
{
    EXTENDS |extends
}

ParserRuleContext {
public TerminalNodeIdentifier()
{
    {
        RETURN | return
    }

    getToken(JavaParser.Identifier, {
        IntegerLiteral | 0
    } )

    ;
}

public ArgumentsContextarguments()
{
    {
        RETURN | return
    }

    getRuleContext(ArgumentsContext.class ,  {

IntegerLiteral | 0 } ) ;  }public SuperSuffixContext(ParserRuleContext parent, {
    INT | int
}

invokingState ) { {SUPER |super } (
parent , invokingState ) ;  } {AT | @ }Override public {
INT |int }
getRuleIndex()
{
    {
        RETURN | return
    }

    RULE_superSuffix;
} {

AT | @ }Override public void enterRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterSuperSuffix(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public void exitRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitSuperSuffix(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public {
LT | < }T {
GT | > }Taccept(ParseTreeVisitor
{
    LT | <
} {

QUESTION |? } {
EXTENDS |extends }
T {
GT | > }visitor ) { {IF | if } (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) {RETURN | return } ( (JavaVisitor {
LT | < } {QUESTION |? } {
EXTENDS |extends }
T {
GT | > } )visitor ) .visitSuperSuffix(
{
    THIS | this
} ) ;  {

ELSE | else } {RETURN | return }visitor.visitChildren ( {THIS |this
} ) ;  } }

public {
FINAL |final }
SuperSuffixContextsuperSuffix()
{
    SuperSuffixContext _localctx = new SuperSuffixContext(_ctx, getState());
    enterRule(_localctx, {
        IntegerLiteral | 196
    } , 

    RULE_superSuffix )
    ;
    try
    {
        setState(
        {
            IntegerLiteral | 1264
        } )

        ;
        {
            SWITCH | switch
            }

            (_input.LA(
            {
                IntegerLiteral | 1
            } ) )

            {
                {
                    CASE |  case
                }

                LPAREN
                {
                    COLON |  : 
                }

                enterOuterAlt(_localctx, {
                    IntegerLiteral | 1
                } )

                ;
                {
                    setState(
                    {
                        IntegerLiteral | 1258
                    } )

                    ;
                    arguments();
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                DOT
                {
                    COLON |  : 
                }

                enterOuterAlt(_localctx, {
                    IntegerLiteral | 2
                } )

                ;
                {
                    setState(
                    {
                        IntegerLiteral | 1259
                    } )

                    ;
                    match(DOT);
                    setState(
                    {
                        IntegerLiteral | 1260
                    } )

                    ;
                    match(Identifier);
                    setState(
                    {
                        IntegerLiteral | 1262
                    } )

                    ;
                    {
                        SWITCH | switch
                        }

                        (getInterpreter().adaptivePredict(_input, {
                            IntegerLiteral | 145
                        } , 

                        _ctx ) )
                        {
                            {
                                CASE |  case
                            }

                            {
                                IntegerLiteral | 1
                            }

                            {
                                COLON |  : 
                            }

                            {
                                setState(
                                {
                                    IntegerLiteral | 1261
                                } )

                                ;
                                arguments();
                            }

                            {
                                BREAK | break
                            }

                            ;
                        }
                    }

                    {
                        BREAK | break
                    }

                    ;
                    {
                        DEFAULT | default
                    }

                    {
                        COLON |  : 
                    }

                    {
                        THROW | throw
                    }

                    new NoViableAltException(
                    {
                    THIS | this
                    }

                     )
                    ;
                }
            }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(
        {
            THIS | this
        } , 

        re )
        ;
        _errHandler.recover(
        {
            THIS | this
        } , 

        re )
        ;
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        {
            RETURN | return
        }

        _localctx;
    }

public static class ExplicitGenericInvocationSuffixContext
{
    EXTENDS |extends
}

ParserRuleContext {
public TerminalNodeIdentifier()
{
    {
        RETURN | return
    }

    getToken(JavaParser.Identifier, {
        IntegerLiteral | 0
    } )

    ;
}

public SuperSuffixContextsuperSuffix()
{
    {
        RETURN | return
    }

    getRuleContext(SuperSuffixContext.class ,  {

IntegerLiteral | 0 } ) ;  }public ArgumentsContextarguments()
{
    {
        RETURN | return
    }

    getRuleContext(ArgumentsContext.class ,  {

IntegerLiteral | 0 } ) ;  }public ExplicitGenericInvocationSuffixContext(ParserRuleContext parent, {
    INT | int
}

invokingState ) { {SUPER |super } (
parent , invokingState ) ;  } {AT | @ }Override public {
INT |int }
getRuleIndex()
{
    {
        RETURN | return
    }

    RULE_explicitGenericInvocationSuffix;
} {

AT | @ }Override public void enterRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterExplicitGenericInvocationSuffix(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public void exitRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitExplicitGenericInvocationSuffix(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public {
LT | < }T {
GT | > }Taccept(ParseTreeVisitor
{
    LT | <
} {

QUESTION |? } {
EXTENDS |extends }
T {
GT | > }visitor ) { {IF | if } (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) {RETURN | return } ( (JavaVisitor {
LT | < } {QUESTION |? } {
EXTENDS |extends }
T {
GT | > } )visitor ) .visitExplicitGenericInvocationSuffix(
{
    THIS | this
} ) ;  {

ELSE | else } {RETURN | return }visitor.visitChildren ( {THIS |this
} ) ;  } }

public {
FINAL |final }
ExplicitGenericInvocationSuffixContextexplicitGenericInvocationSuffix()
{
    ExplicitGenericInvocationSuffixContext _localctx = new ExplicitGenericInvocationSuffixContext(_ctx, getState());
    enterRule(_localctx, {
        IntegerLiteral | 198
    } , 

    RULE_explicitGenericInvocationSuffix )
    ;
    try
    {
        setState(
        {
            IntegerLiteral | 1270
        } )

        ;
        {
            SWITCH | switch
            }

            (_input.LA(
            {
                IntegerLiteral | 1
            } ) )

            {
                {
                    CASE |  case
                }

                SUPER
                {
                    COLON |  : 
                }

                enterOuterAlt(_localctx, {
                    IntegerLiteral | 1
                } )

                ;
                {
                    setState(
                    {
                        IntegerLiteral | 1266
                    } )

                    ;
                    match(SUPER);
                    setState(
                    {
                        IntegerLiteral | 1267
                    } )

                    ;
                    superSuffix();
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                Identifier
                {
                    COLON |  : 
                }

                enterOuterAlt(_localctx, {
                    IntegerLiteral | 2
                } )

                ;
                {
                    setState(
                    {
                        IntegerLiteral | 1268
                    } )

                    ;
                    match(Identifier);
                    setState(
                    {
                        IntegerLiteral | 1269
                    } )

                    ;
                    arguments();
                }

                {
                    BREAK | break
                }

                ;
                {
                    DEFAULT | default
                }

                {
                    COLON |  : 
                }

                {
                    THROW | throw
                }

                new NoViableAltException(
                {
                THIS | this
                }

                 )
                ;
            }
        }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(
        {
            THIS | this
        } , 

        re )
        ;
        _errHandler.recover(
        {
            THIS | this
        } , 

        re )
        ;
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        {
            RETURN | return
        }

        _localctx;
    }

public static class ArgumentsContext
{
    EXTENDS |extends
}

ParserRuleContext {
public ExpressionListContextexpressionList()
{
    {
        RETURN | return
    }

    getRuleContext(ExpressionListContext.class ,  {

IntegerLiteral | 0 } ) ;  }public ArgumentsContext(ParserRuleContext parent, {
    INT | int
}

invokingState ) { {SUPER |super } (
parent , invokingState ) ;  } {AT | @ }Override public {
INT |int }
getRuleIndex()
{
    {
        RETURN | return
    }

    RULE_arguments;
} {

AT | @ }Override public void enterRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterArguments(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public void exitRule(ParseTreeListener listener)
{
    {
        IF | if
    }

    (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitArguments(
    {
        THIS | this
    } )

    ;
} {

AT | @ }Override public {
LT | < }T {
GT | > }Taccept(ParseTreeVisitor
{
    LT | <
} {

QUESTION |? } {
EXTENDS |extends }
T {
GT | > }visitor ) { {IF | if } (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) {RETURN | return } ( (JavaVisitor {
LT | < } {QUESTION |? } {
EXTENDS |extends }
T {
GT | > } )visitor ) .visitArguments(
{
    THIS | this
} ) ;  {

ELSE | else } {RETURN | return }visitor.visitChildren ( {THIS |this
} ) ;  } }

public {
FINAL |final }
ArgumentsContextarguments()
{
    ArgumentsContext _localctx = new ArgumentsContext(_ctx, getState());
    enterRule(_localctx, {
        IntegerLiteral | 200
    } , 

    RULE_arguments )
    ;
    {
        INT | int
    }

    _la;
    try
    {
        enterOuterAlt(_localctx, {
            IntegerLiteral | 1
        } )

        ;
        {
            setState(
            {
                IntegerLiteral | 1272
            } )

            ;
            match(LPAREN);
            setState(
            {
                IntegerLiteral | 1274
            } )

            ;
            _la = _input.LA(
            {
                IntegerLiteral | 1
            } )

            ;
            {
                IF | if
            }

            ((((_la)
            {
                BITAND | &
            }

            {
                TILDE | ~
            }

            {
                IntegerLiteral | 0x3f
            } )

            {
                EQUAL |= =
            }

            {
                IntegerLiteral | 0
            }

            {
                AND | &&
            }

            ((
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            _la )
            {
                BITAND | &
            }

            ((
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            BOOLEAN )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            BYTE )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            CHAR )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            DOUBLE )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            FLOAT )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            INT )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            LONG )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            NEW )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            SHORT )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            SUPER )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            THIS )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            VOID )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            IntegerLiteral )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            FloatingPointLiteral )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            BooleanLiteral )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            CharacterLiteral )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            StringLiteral )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            NullLiteral )
            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            LPAREN ) ) )
            {
                NOTEQUAL | !=
            }

            {
                IntegerLiteral | 0
            } )

            {
                OR || |
            }

            ((((_la
            {
                SUB | -
            }

            {
                IntegerLiteral | 68
            } ) )

            {
                BITAND | &
            }

            {
                TILDE | ~
            }

            {
                IntegerLiteral | 0x3f
            } )

            {
                EQUAL |= =
            }

            {
                IntegerLiteral | 0
            }

            {
                AND | &&
            }

            ((
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            (_la
            {
                SUB | -
            }

            {
                IntegerLiteral | 68
            } ) )

            {
                BITAND | &
            }

            ((
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            (LT
            {
                SUB | -
            }

            {
                IntegerLiteral | 68
            } ) )

            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            (BANG
            {
                SUB | -
            }

            {
                IntegerLiteral | 68
            } ) )

            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            (TILDE
            {
                SUB | -
            }

            {
                IntegerLiteral | 68
            } ) )

            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            (INC
            {
                SUB | -
            }

            {
                IntegerLiteral | 68
            } ) )

            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            (DEC
            {
                SUB | -
            }

            {
                IntegerLiteral | 68
            } ) )

            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            (ADD
            {
                SUB | -
            }

            {
                IntegerLiteral | 68
            } ) )

            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            (SUB
            {
                SUB | -
            }

            {
                IntegerLiteral | 68
            } ) )

            {
                BITOR ||
            }

            (
            {
                IntegerLiteral | 1L
            }

            {
                LT | <
            }

            {
                LT | <
            }

            (Identifier
            {
                SUB | -
            }

            {
                IntegerLiteral | 68
            } ) ) ) )

            {
                NOTEQUAL | !=
            }

            {
                IntegerLiteral | 0
            } ) )

            {
                {
                    setState(
                    {
                        IntegerLiteral | 1273
                    } )

                    ;
                    expressionList();
                }
            }

            setState(
            {
                IntegerLiteral | 1276
            } )

            ;
            match(RPAREN);
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(
        {
            THIS | this
        } , 

        re )
        ;
        _errHandler.recover(
        {
            THIS | this
        } , 

        re )
        ;
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        {
            RETURN | return
        }

        _localctx;
    }

public {
BOOLEAN |boolean }
sempred(RuleContext _localctx, {
    INT | int
}

ruleIndex ,  {INT |int }
predIndex ) { {SWITCH | switch } (ruleIndex ) { {CASE | case } {IntegerLiteral | 87 } {COLON | :  } {RETURN | return }expression_sempred( (ExpressionContext)_localctx , predIndex ) ;  } {RETURN | return } {BooleanLiteral | true } ;  }private {
BOOLEAN |boolean }
expression_sempred(ExpressionContext _localctx, {
    INT | int
}

predIndex ) { {SWITCH | switch } (predIndex ) { {CASE | case } {IntegerLiteral | 0 } {COLON | :  } {RETURN | return }precpred(_ctx, {
    IntegerLiteral | 13
} ) ;  {

CASE | case } {IntegerLiteral | 1 } {COLON | :  } {RETURN | return }precpred(_ctx, {
    IntegerLiteral | 12
} ) ;  {

CASE | case } {IntegerLiteral | 2 } {COLON | :  } {RETURN | return }precpred(_ctx, {
    IntegerLiteral | 11
} ) ;  {

CASE | case } {IntegerLiteral | 3 } {COLON | :  } {RETURN | return }precpred(_ctx, {
    IntegerLiteral | 10
} ) ;  {

CASE | case } {IntegerLiteral | 4 } {COLON | :  } {RETURN | return }precpred(_ctx, {
    IntegerLiteral | 8
} ) ;  {

CASE | case } {IntegerLiteral | 5 } {COLON | :  } {RETURN | return }precpred(_ctx, {
    IntegerLiteral | 7
} ) ;  {

CASE | case } {IntegerLiteral | 6 } {COLON | :  } {RETURN | return }precpred(_ctx, {
    IntegerLiteral | 6
} ) ;  {

CASE | case } {IntegerLiteral | 7 } {COLON | :  } {RETURN | return }precpred(_ctx, {
    IntegerLiteral | 5
} ) ;  {

CASE | case } {IntegerLiteral | 8 } {COLON | :  } {RETURN | return }precpred(_ctx, {
    IntegerLiteral | 4
} ) ;  {

CASE | case } {IntegerLiteral | 9 } {COLON | :  } {RETURN | return }precpred(_ctx, {
    IntegerLiteral | 3
} ) ;  {

CASE | case } {IntegerLiteral | 10 } {COLON | :  } {RETURN | return }precpred(_ctx, {
    IntegerLiteral | 2
} ) ;  {

CASE | case } {IntegerLiteral | 11 } {COLON | :  } {RETURN | return }precpred(_ctx, {
    IntegerLiteral | 1
} ) ;  {

CASE | case } {IntegerLiteral | 12 } {COLON | :  } {RETURN | return }precpred(_ctx, {
    IntegerLiteral | 25
} ) ;  {

CASE | case } {IntegerLiteral | 13 } {COLON | :  } {RETURN | return }precpred(_ctx, {
    IntegerLiteral | 24
} ) ;  {

CASE | case } {IntegerLiteral | 14 } {COLON | :  } {RETURN | return }precpred(_ctx, {
    IntegerLiteral | 23
} ) ;  {

CASE | case } {IntegerLiteral | 15 } {COLON | :  } {RETURN | return }precpred(_ctx, {
    IntegerLiteral | 22
} ) ;  {

CASE | case } {IntegerLiteral | 16 } {COLON | :  } {RETURN | return }precpred(_ctx, {
    IntegerLiteral | 21
} ) ;  {

CASE | case } {IntegerLiteral | 17 } {COLON | :  } {RETURN | return }precpred(_ctx, {
    IntegerLiteral | 20
} ) ;  {

CASE | case } {IntegerLiteral | 18 } {COLON | :  } {RETURN | return }precpred(_ctx, {
    IntegerLiteral | 19
} ) ;  {

CASE | case } {IntegerLiteral | 19 } {COLON | :  } {RETURN | return }precpred(_ctx, {
    IntegerLiteral | 16
} ) ;  {

CASE | case } {IntegerLiteral | 20 } {COLON | :  } {RETURN | return }precpred(_ctx, {
    IntegerLiteral | 9
} ) ;  } {

RETURN | return } {BooleanLiteral | true } ;  }public static {
FINAL |final }
String _serializedATN = "\3\u0430\ud6d1\u8206\uad2d\u4417\uaef1\u8d80\uaadd\3k\u0501\4\2\t\2\4"
 {
ADD | + } "\3\t\3\4\4\t\4\4\5\t\5\4\6\t\6\4\7\t\7\4\b\t\b\4\t\t\t\4\n\t\n\4\13\t" {ADD | + } "\13\4\f\t\f\4\r\t\r\4\16\t\16\4\17\t\17\4\20\t\20\4\21\t\21\4\22\t\22" {ADD | + } "\4\23\t\23\4\24\t\24\4\25\t\25\4\26\t\26\4\27\t\27\4\30\t\30\4\31\t\31" {ADD | + } "\4\32\t\32\4\33\t\33\4\34\t\34\4\35\t\35\4\36\t\36\4\37\t\37\4 \t \4!" {ADD | + } "\t!\4\"\t\"\4#\t#\4$\t$\4%\t%\4&\t&\4\'\t\'\4(\t(\4)\t)\4*\t*\4+\t+\4" {ADD | + } ",\t,\4-\t-\4.\t.\4/\t/\4\60\t\60\4\61\t\61\4\62\t\62\4\63\t\63\4\64\t" {ADD | + } "\64\4\65\t\65\4\66\t\66\4\67\t\67\48\t8\49\t9\4:\t:\4;\t;\4<\t<\4=\t=" {ADD | + } "\4>\t>\4?\t?\4@\t@\4A\tA\4B\tB\4C\tC\4D\tD\4E\tE\4F\tF\4G\tG\4H\tH\4I" {ADD | + } "\tI\4J\tJ\4K\tK\4L\tL\4M\tM\4N\tN\4O\tO\4P\tP\4Q\tQ\4R\tR\4S\tS\4T\tT" {ADD | + } "\4U\tU\4V\tV\4W\tW\4X\tX\4Y\tY\4Z\tZ\4[\t[\4\\\t\\\4]\t]\4^\t^\4_\t_\4" {ADD | + } "`\t`\4a\ta\4b\tb\4c\tc\4d\td\4e\te\4f\tf\3\2\5\2\u00ce\n\2\3\2\7\2\u00d1" {ADD | + } "\n\2\f\2\16\2\u00d4\13\2\3\2\7\2\u00d7\n\2\f\2\16\2\u00da\13\2\3\2\3\2" {ADD | + } "\3\3\7\3\u00df\n\3\f\3\16\3\u00e2\13\3\3\3\3\3\3\3\3\3\3\4\3\4\5\4\u00ea" {ADD | + } "\n\4\3\4\3\4\3\4\5\4\u00ef\n\4\3\4\3\4\3\5\7\5\u00f4\n\5\f\5\16\5\u00f7" {ADD | + } "\13\5\3\5\3\5\7\5\u00fb\n\5\f\5\16\5\u00fe\13\5\3\5\3\5\7\5\u0102\n\5" {ADD | + } "\f\5\16\5\u0105\13\5\3\5\3\5\7\5\u0109\n\5\f\5\16\5\u010c\13\5\3\5\3\5" {ADD | + } "\5\5\u0110\n\5\3\6\3\6\5\6\u0114\n\6\3\7\3\7\5\7\u0118\n\7\3\b\3\b\5\b" {ADD | + } "\u011c\n\b\3\t\3\t\3\t\5\t\u0121\n\t\3\t\3\t\5\t\u0125\n\t\3\t\3\t\5\t" {ADD | + } "\u0129\n\t\3\t\3\t\3\n\3\n\3\n\3\n\7\n\u0131\n\n\f\n\16\n\u0134\13\n\3" {ADD | + } "\n\3\n\3\13\3\13\3\13\5\13\u013b\n\13\3\f\3\f\3\f\7\f\u0140\n\f\f\f\16" {ADD | + } "\f\u0143\13\f\3\r\3\r\3\r\3\r\5\r\u0149\n\r\3\r\3\r\5\r\u014d\n\r\3\r" {ADD | + } "\5\r\u0150\n\r\3\r\5\r\u0153\n\r\3\r\3\r\3\16\3\16\3\16\7\16\u015a\n\16" {ADD | + } "\f\16\16\16\u015d\13\16\3\17\7\17\u0160\n\17\f\17\16\17\u0163\13\17\3" {ADD | + } "\17\3\17\5\17\u0167\n\17\3\17\5\17\u016a\n\17\3\20\3\20\7\20\u016e\n\20" {ADD | + } "\f\20\16\20\u0171\13\20\3\21\3\21\3\21\5\21\u0176\n\21\3\21\3\21\5\21" {ADD | + } "\u017a\n\21\3\21\3\21\3\22\3\22\3\22\7\22\u0181\n\22\f\22\16\22\u0184" {ADD | + } "\13\22\3\23\3\23\7\23\u0188\n\23\f\23\16\23\u018b\13\23\3\23\3\23\3\24" {ADD | + } "\3\24\7\24\u0191\n\24\f\24\16\24\u0194\13\24\3\24\3\24\3\25\3\25\5\25" {ADD | + } "\u019a\n\25\3\25\3\25\7\25\u019e\n\25\f\25\16\25\u01a1\13\25\3\25\5\25" {ADD | + } "\u01a4\n\25\3\26\3\26\3\26\3\26\3\26\3\26\3\26\3\26\3\26\5\26\u01af\n" {ADD | + } "\26\3\27\3\27\5\27\u01b3\n\27\3\27\3\27\3\27\3\27\7\27\u01b9\n\27\f\27" {ADD | + } "\16\27\u01bc\13\27\3\27\3\27\5\27\u01c0\n\27\3\27\3\27\5\27\u01c4\n\27" {ADD | + } "\3\30\3\30\3\30\3\31\3\31\3\31\3\31\5\31\u01cd\n\31\3\31\3\31\3\32\3\32" {ADD | + } "\3\32\3\33\3\33\3\33\3\33\3\34\7\34\u01d9\n\34\f\34\16\34\u01dc\13\34" {ADD | + } "\3\34\3\34\5\34\u01e0\n\34\3\35\3\35\3\35\3\35\3\35\3\35\3\35\5\35\u01e9" {ADD | + } "\n\35\3\36\3\36\3\36\3\36\7\36\u01ef\n\36\f\36\16\36\u01f2\13\36\3\36" {ADD | + } "\3\36\3\37\3\37\3\37\7\37\u01f9\n\37\f\37\16\37\u01fc\13\37\3\37\3\37" {ADD | + } "\3\37\3 \3 \5 \u0203\n \3 \3 \3 \3 \7 \u0209\n \f \16 \u020c\13 \3 \3" {ADD | + } " \5 \u0210\n \3 \3 \3!\3!\3!\3\"\3\"\3\"\7\"\u021a\n\"\f\"\16\"\u021d" {ADD | + } "\13\"\3#\3#\3#\5#\u0222\n#\3$\3$\3$\7$\u0227\n$\f$\16$\u022a\13$\3%\3" {ADD | + } "%\5%\u022e\n%\3&\3&\3&\3&\7&\u0234\n&\f&\16&\u0237\13&\3&\5&\u023a\n&" {ADD | + } "\5&\u023c\n&\3&\3&\3\'\3\'\3(\3(\3(\7(\u0245\n(\f(\16(\u0248\13(\3(\3" {ADD | + } "(\3(\7(\u024d\n(\f(\16(\u0250\13(\5(\u0252\n(\3)\3)\5)\u0256\n)\3)\3)" {ADD | + } "\3)\5)\u025b\n)\7)\u025d\n)\f)\16)\u0260\13)\3*\3*\3+\3+\3+\3+\7+\u0268" {ADD | + } "\n+\f+\16+\u026b\13+\3+\3+\3,\3,\3,\3,\5,\u0273\n,\5,\u0275\n,\3-\3-\3" {ADD | + } "-\7-\u027a\n-\f-\16-\u027d\13-\3.\3.\5.\u0281\n.\3.\3.\3/\3/\3/\7/\u0288" {ADD | + } "\n/\f/\16/\u028b\13/\3/\3/\5/\u028f\n/\3/\5/\u0292\n/\3\60\7\60\u0295" {ADD | + } "\n\60\f\60\16\60\u0298\13\60\3\60\3\60\3\60\3\61\7\61\u029e\n\61\f\61" {ADD | + } "\16\61\u02a1\13\61\3\61\3\61\3\61\3\61\3\62\3\62\3\63\3\63\3\64\3\64\3" {ADD | + } "\64\7\64\u02ae\n\64\f\64\16\64\u02b1\13\64\3\65\3\65\3\66\3\66\3\66\3" {ADD | + } "\66\3\66\5\66\u02ba\n\66\3\66\5\66\u02bd\n\66\3\67\3\67\38\38\38\78\u02c4" {ADD | + } "\n8\f8\168\u02c7\138\39\39\39\39\3:\3:\3:\5:\u02d0\n:\3;\3;\3;\3;\7;\u02d6" {ADD | + } "\n;\f;\16;\u02d9\13;\5;\u02db\n;\3;\5;\u02de\n;\3;\3;\3<\3<\3<\3<\3<\3" {ADD | + } "=\3=\7=\u02e9\n=\f=\16=\u02ec\13=\3=\3=\3>\7>\u02f1\n>\f>\16>\u02f4\13" {ADD | + } ">\3>\3>\5>\u02f8\n>\3?\3?\3?\3?\3?\3?\5?\u0300\n?\3?\3?\5?\u0304\n?\3" {ADD | + } "?\3?\5?\u0308\n?\3?\3?\5?\u030c\n?\5?\u030e\n?\3@\3@\5@\u0312\n@\3A\3" {ADD | + } "A\3A\3A\5A\u0318\nA\3B\3B\3C\3C\3C\3D\3D\7D\u0321\nD\fD\16D\u0324\13D" {ADD | + } "\3D\3D\3E\3E\3E\5E\u032b\nE\3F\3F\3F\3G\7G\u0331\nG\fG\16G\u0334\13G\3" {ADD | + } "G\3G\3G\3H\3H\3H\3H\3H\5H\u033e\nH\3H\3H\3H\3H\3H\3H\3H\5H\u0347\nH\3" {ADD | + } "H\3H\3H\3H\3H\3H\3H\3H\3H\3H\3H\3H\3H\3H\3H\3H\3H\3H\3H\6H\u035c\nH\r" {ADD | + } "H\16H\u035d\3H\5H\u0361\nH\3H\5H\u0364\nH\3H\3H\3H\3H\7H\u036a\nH\fH\16" {ADD | + } "H\u036d\13H\3H\5H\u0370\nH\3H\3H\3H\3H\7H\u0376\nH\fH\16H\u0379\13H\3" {ADD | + } "H\7H\u037c\nH\fH\16H\u037f\13H\3H\3H\3H\3H\3H\3H\3H\3H\5H\u0389\nH\3H" {ADD | + } "\3H\3H\3H\3H\3H\3H\5H\u0392\nH\3H\3H\3H\5H\u0397\nH\3H\3H\3H\3H\3H\3H" {ADD | + } "\3H\3H\5H\u03a1\nH\3I\3I\3I\7I\u03a6\nI\fI\16I\u03a9\13I\3I\3I\3I\3I\3" {ADD | + } "I\3J\3J\3J\7J\u03b3\nJ\fJ\16J\u03b6\13J\3K\3K\3K\3L\3L\3L\5L\u03be\nL" {ADD | + } "\3L\3L\3M\3M\3M\7M\u03c5\nM\fM\16M\u03c8\13M\3N\7N\u03cb\nN\fN\16N\u03ce" {ADD | + } "\13N\3N\3N\3N\3N\3N\3O\6O\u03d6\nO\rO\16O\u03d7\3O\6O\u03db\nO\rO\16O" {ADD | + } "\u03dc\3P\3P\3P\3P\3P\3P\3P\3P\3P\3P\5P\u03e9\nP\3Q\3Q\5Q\u03ed\nQ\3Q" {ADD | + } "\3Q\5Q\u03f1\nQ\3Q\3Q\5Q\u03f5\nQ\5Q\u03f7\nQ\3R\3R\5R\u03fb\nR\3S\7S" {ADD | + } "\u03fe\nS\fS\16S\u0401\13S\3S\3S\3S\3S\3S\3T\3T\3U\3U\3U\3U\3V\3V\3V\7" {ADD | + } "V\u0411\nV\fV\16V\u0414\13V\3W\3W\3X\3X\3Y\3Y\3Y\3Y\3Y\3Y\3Y\3Y\3Y\3Y" {ADD | + } "\3Y\3Y\3Y\5Y\u0427\nY\3Y\3Y\3Y\3Y\3Y\3Y\3Y\3Y\3Y\3Y\3Y\3Y\3Y\3Y\5Y\u0437" {ADD | + } "\nY\3Y\3Y\3Y\3Y\3Y\3Y\3Y\3Y\3Y\3Y\3Y\3Y\3Y\3Y\3Y\3Y\3Y\3Y\3Y\3Y\3Y\3Y" {ADD | + } "\3Y\3Y\3Y\3Y\3Y\3Y\3Y\3Y\3Y\3Y\3Y\3Y\3Y\3Y\3Y\3Y\3Y\3Y\3Y\5Y\u0462\nY" {ADD | + } "\3Y\3Y\3Y\3Y\3Y\3Y\3Y\3Y\3Y\3Y\3Y\3Y\3Y\3Y\3Y\3Y\5Y\u0474\nY\3Y\3Y\3Y" {ADD | + } "\3Y\3Y\3Y\7Y\u047c\nY\fY\16Y\u047f\13Y\3Z\3Z\3Z\3Z\3Z\3Z\3Z\3Z\3Z\3Z\3" {ADD | + } "Z\3Z\3Z\3Z\3Z\3Z\3Z\3Z\3Z\5Z\u0494\nZ\5Z\u0496\nZ\3[\3[\3[\3[\3[\3[\3" {ADD | + } "[\5[\u049f\n[\5[\u04a1\n[\3\\\3\\\5\\\u04a5\n\\\3\\\3\\\3\\\5\\\u04aa" {ADD | + } "\n\\\7\\\u04ac\n\\\f\\\16\\\u04af\13\\\3\\\5\\\u04b2\n\\\3]\3]\5]\u04b6" {ADD | + } "\n]\3]\3]\3^\3^\3^\3^\7^\u04be\n^\f^\16^\u04c1\13^\3^\3^\3^\3^\3^\3^\3" {ADD | + } "^\7^\u04ca\n^\f^\16^\u04cd\13^\3^\3^\7^\u04d1\n^\f^\16^\u04d4\13^\5^\u04d6" {ADD | + } "\n^\3_\3_\5_\u04da\n_\3`\3`\3`\3a\3a\3a\3a\3b\3b\3b\5b\u04e6\nb\3c\3c" {ADD | + } "\3c\5c\u04eb\nc\3d\3d\3d\3d\5d\u04f1\nd\5d\u04f3\nd\3e\3e\3e\3e\5e\u04f9" {ADD | + } "\ne\3f\3f\5f\u04fd\nf\3f\3f\3f\2\3\u00b0g\2\4\6\b\n\f\16\20\22\24\26\30" {ADD | + } "\32\34\36 \"$&(*,.\60\62\64\668:<>@BDFHJLNPRTVXZ\\^`bdfhjlnprtvxz|~\u0080" {ADD | + } "\u0082\u0084\u0086\u0088\u008a\u008c\u008e\u0090\u0092\u0094\u0096\u0098" {ADD | + } "\u009a\u009c\u009e\u00a0\u00a2\u00a4\u00a6\u00a8\u00aa\u00ac\u00ae\u00b0" {ADD | + } "\u00b2\u00b4\u00b6\u00b8\u00ba\u00bc\u00be\u00c0\u00c2\u00c4\u00c6\u00c8" {ADD | + } "\u00ca\2\17\6\2  ,,\60\60\63\63\6\2\3\3\24\24#%()\n\2\5\5\7\7\n\n\20\20" {ADD | + } "\26\26\35\35\37\37\'\'\4\2\23\23**\3\2\65:\3\2QT\3\2GH\4\2UVZZ\3\2ST\4" {ADD | + } "\2EFLM\4\2KKNN\4\2DD[e\3\2QR\u0573\2\u00cd\3\2\2\2\4\u00e0\3\2\2\2\6\u00e7" {ADD | + } "\3\2\2\2\b\u010f\3\2\2\2\n\u0113\3\2\2\2\f\u0117\3\2\2\2\16\u011b\3\2" {ADD | + } "\2\2\20\u011d\3\2\2\2\22\u012c\3\2\2\2\24\u0137\3\2\2\2\26\u013c\3\2\2" {ADD | + } "\2\30\u0144\3\2\2\2\32\u0156\3\2\2\2\34\u0161\3\2\2\2\36\u016b\3\2\2\2" {ADD | + } " \u0172\3\2\2\2\"\u017d\3\2\2\2$\u0185\3\2\2\2&\u018e\3\2\2\2(\u01a3\3" {ADD | + } "\2\2\2*\u01ae\3\2\2\2,\u01b2\3\2\2\2.\u01c5\3\2\2\2\60\u01c8\3\2\2\2\62" {ADD | + } "\u01d0\3\2\2\2\64\u01d3\3\2\2\2\66\u01df\3\2\2\28\u01e8\3\2\2\2:\u01ea" {ADD | + } "\3\2\2\2<\u01f5\3\2\2\2>\u0202\3\2\2\2@\u0213\3\2\2\2B\u0216\3\2\2\2D" {ADD | + } "\u021e\3\2\2\2F\u0223\3\2\2\2H\u022d\3\2\2\2J\u022f\3\2\2\2L\u023f\3\2" {ADD | + } "\2\2N\u0251\3\2\2\2P\u0253\3\2\2\2R\u0261\3\2\2\2T\u0263\3\2\2\2V\u0274" {ADD | + } "\3\2\2\2X\u0276\3\2\2\2Z\u027e\3\2\2\2\\\u0291\3\2\2\2^\u0296\3\2\2\2" {ADD | + } "`\u029f\3\2\2\2b\u02a6\3\2\2\2d\u02a8\3\2\2\2f\u02aa\3\2\2\2h\u02b2\3" {ADD | + } "\2\2\2j\u02b4\3\2\2\2l\u02be\3\2\2\2n\u02c0\3\2\2\2p\u02c8\3\2\2\2r\u02cf" {ADD | + } "\3\2\2\2t\u02d1\3\2\2\2v\u02e1\3\2\2\2x\u02e6\3\2\2\2z\u02f7\3\2\2\2|" {ADD | + } "\u030d\3\2\2\2~\u0311\3\2\2\2\u0080\u0313\3\2\2\2\u0082\u0319\3\2\2\2" {ADD | + } "\u0084\u031b\3\2\2\2\u0086\u031e\3\2\2\2\u0088\u032a\3\2\2\2\u008a\u032c" {ADD | + } "\3\2\2\2\u008c\u0332\3\2\2\2\u008e\u03a0\3\2\2\2\u0090\u03a2\3\2\2\2\u0092" {ADD | + } "\u03af\3\2\2\2\u0094\u03b7\3\2\2\2\u0096\u03ba\3\2\2\2\u0098\u03c1\3\2" {ADD | + } "\2\2\u009a\u03cc\3\2\2\2\u009c\u03d5\3\2\2\2\u009e\u03e8\3\2\2\2\u00a0" {ADD | + } "\u03f6\3\2\2\2\u00a2\u03fa\3\2\2\2\u00a4\u03ff\3\2\2\2\u00a6\u0407\3\2" {ADD | + } "\2\2\u00a8\u0409\3\2\2\2\u00aa\u040d\3\2\2\2\u00ac\u0415\3\2\2\2\u00ae" {ADD | + } "\u0417\3\2\2\2\u00b0\u0426\3\2\2\2\u00b2\u0495\3\2\2\2\u00b4\u04a0\3\2" {ADD | + } "\2\2\u00b6\u04b1\3\2\2\2\u00b8\u04b3\3\2\2\2\u00ba\u04b9\3\2\2\2\u00bc" {ADD | + } "\u04d7\3\2\2\2\u00be\u04db\3\2\2\2\u00c0\u04de\3\2\2\2\u00c2\u04e5\3\2" {ADD | + } "\2\2\u00c4\u04ea\3\2\2\2\u00c6\u04f2\3\2\2\2\u00c8\u04f8\3\2\2\2\u00ca" {ADD | + } "\u04fa\3\2\2\2\u00cc\u00ce\5\4\3\2\u00cd\u00cc\3\2\2\2\u00cd\u00ce\3\2" {ADD | + } "\2\2\u00ce\u00d2\3\2\2\2\u00cf\u00d1\5\6\4\2\u00d0\u00cf\3\2\2\2\u00d1" {ADD | + } "\u00d4\3\2\2\2\u00d2\u00d0\3\2\2\2\u00d2\u00d3\3\2\2\2\u00d3\u00d8\3\2" {ADD | + } "\2\2\u00d4\u00d2\3\2\2\2\u00d5\u00d7\5\b\5\2\u00d6\u00d5\3\2\2\2\u00d7" {ADD | + } "\u00da\3\2\2\2\u00d8\u00d6\3\2\2\2\u00d8\u00d9\3\2\2\2\u00d9\u00db\3\2" {ADD | + } "\2\2\u00da\u00d8\3\2\2\2\u00db\u00dc\7\2\2\3\u00dc\3\3\2\2\2\u00dd\u00df" {ADD | + } "\5j\66\2\u00de\u00dd\3\2\2\2\u00df\u00e2\3\2\2\2\u00e0\u00de\3\2\2\2\u00e0" {ADD | + } "\u00e1\3\2\2\2\u00e1\u00e3\3\2\2\2\u00e2\u00e0\3\2\2\2\u00e3\u00e4\7\"" {ADD | + } "\2\2\u00e4\u00e5\5f\64\2\u00e5\u00e6\7A\2\2\u00e6\5\3\2\2\2\u00e7\u00e9" {ADD | + } "\7\33\2\2\u00e8\u00ea\7(\2\2\u00e9\u00e8\3\2\2\2\u00e9\u00ea\3\2\2\2\u00ea" {ADD | + } "\u00eb\3\2\2\2\u00eb\u00ee\5f\64\2\u00ec\u00ed\7C\2\2\u00ed\u00ef\7U\2" {ADD | + } "\2\u00ee\u00ec\3\2\2\2\u00ee\u00ef\3\2\2\2\u00ef\u00f0\3\2\2\2\u00f0\u00f1" {ADD | + } "\7A\2\2\u00f1\7\3\2\2\2\u00f2\u00f4\5\f\7\2\u00f3\u00f2\3\2\2\2\u00f4" {ADD | + } "\u00f7\3\2\2\2\u00f5\u00f3\3\2\2\2\u00f5\u00f6\3\2\2\2\u00f6\u00f8\3\2" {ADD | + } "\2\2\u00f7\u00f5\3\2\2\2\u00f8\u0110\5\20\t\2\u00f9\u00fb\5\f\7\2\u00fa" {ADD | + } "\u00f9\3\2\2\2\u00fb\u00fe\3\2\2\2\u00fc\u00fa\3\2\2\2\u00fc\u00fd\3\2" {ADD | + } "\2\2\u00fd\u00ff\3\2\2\2\u00fe\u00fc\3\2\2\2\u00ff\u0110\5\30\r\2\u0100" {ADD | + } "\u0102\5\f\7\2\u0101\u0100\3\2\2\2\u0102\u0105\3\2\2\2\u0103\u0101\3\2" {ADD | + } "\2\2\u0103\u0104\3\2\2\2\u0104\u0106\3\2\2\2\u0105\u0103\3\2\2\2\u0106" {ADD | + } "\u0110\5 \21\2\u0107\u0109\5\f\7\2\u0108\u0107\3\2\2\2\u0109\u010c\3\2" {ADD | + } "\2\2\u010a\u0108\3\2\2\2\u010a\u010b\3\2\2\2\u010b\u010d\3\2\2\2\u010c" {ADD | + } "\u010a\3\2\2\2\u010d\u0110\5v<\2\u010e\u0110\7A\2\2\u010f\u00f5\3\2\2" {ADD | + } "\2\u010f\u00fc\3\2\2\2\u010f\u0103\3\2\2\2\u010f\u010a\3\2\2\2\u010f\u010e" {ADD | + } "\3\2\2\2\u0110\t\3\2\2\2\u0111\u0114\5\f\7\2\u0112\u0114\t\2\2\2\u0113" {ADD | + } "\u0111\3\2\2\2\u0113\u0112\3\2\2\2\u0114\13\3\2\2\2\u0115\u0118\5j\66" {ADD | + } "\2\u0116\u0118\t\3\2\2\u0117\u0115\3\2\2\2\u0117\u0116\3\2\2\2\u0118\r" {ADD | + } "\3\2\2\2\u0119\u011c\7\24\2\2\u011a\u011c\5j\66\2\u011b\u0119\3\2\2\2" {ADD | + } "\u011b\u011a\3\2\2\2\u011c\17\3\2\2\2\u011d\u011e\7\13\2\2\u011e\u0120" {ADD | + } "\7f\2\2\u011f\u0121\5\22\n\2\u0120\u011f\3\2\2\2\u0120\u0121\3\2\2\2\u0121" {ADD | + } "\u0124\3\2\2\2\u0122\u0123\7\23\2\2\u0123\u0125\5N(\2\u0124\u0122\3\2" {ADD | + } "\2\2\u0124\u0125\3\2\2\2\u0125\u0128\3\2\2\2\u0126\u0127\7\32\2\2\u0127" {ADD | + } "\u0129\5\"\22\2\u0128\u0126\3\2\2\2\u0128\u0129\3\2\2\2\u0129\u012a\3" {ADD | + } "\2\2\2\u012a\u012b\5$\23\2\u012b\21\3\2\2\2\u012c\u012d\7F\2\2\u012d\u0132" {ADD | + } "\5\24\13\2\u012e\u012f\7B\2\2\u012f\u0131\5\24\13\2\u0130\u012e\3\2\2" {ADD | + } "\2\u0131\u0134\3\2\2\2\u0132\u0130\3\2\2\2\u0132\u0133\3\2\2\2\u0133\u0135" {ADD | + } "\3\2\2\2\u0134\u0132\3\2\2\2\u0135\u0136\7E\2\2\u0136\23\3\2\2\2\u0137" {ADD | + } "\u013a\7f\2\2\u0138\u0139\7\23\2\2\u0139\u013b\5\26\f\2\u013a\u0138\3" {ADD | + } "\2\2\2\u013a\u013b\3\2\2\2\u013b\25\3\2\2\2\u013c\u0141\5N(\2\u013d\u013e" {ADD | + } "\7W\2\2\u013e\u0140\5N(\2\u013f\u013d\3\2\2\2\u0140\u0143\3\2\2\2\u0141" {ADD | + } "\u013f\3\2\2\2\u0141\u0142\3\2\2\2\u0142\27\3\2\2\2\u0143\u0141\3\2\2" {ADD | + } "\2\u0144\u0145\7\22\2\2\u0145\u0148\7f\2\2\u0146\u0147\7\32\2\2\u0147" {ADD | + } "\u0149\5\"\22\2\u0148\u0146\3\2\2\2\u0148\u0149\3\2\2\2\u0149\u014a\3" {ADD | + } "\2\2\2\u014a\u014c\7=\2\2\u014b\u014d\5\32\16\2\u014c\u014b\3\2\2\2\u014c" {ADD | + } "\u014d\3\2\2\2\u014d\u014f\3\2\2\2\u014e\u0150\7B\2\2\u014f\u014e\3\2" {ADD | + } "\2\2\u014f\u0150\3\2\2\2\u0150\u0152\3\2\2\2\u0151\u0153\5\36\20\2\u0152" {ADD | + } "\u0151\3\2\2\2\u0152\u0153\3\2\2\2\u0153\u0154\3\2\2\2\u0154\u0155\7>" {ADD | + } "\2\2\u0155\31\3\2\2\2\u0156\u015b\5\34\17\2\u0157\u0158\7B\2\2\u0158\u015a" {ADD | + } "\5\34\17\2\u0159\u0157\3\2\2\2\u015a\u015d\3\2\2\2\u015b\u0159\3\2\2\2" {ADD | + } "\u015b\u015c\3\2\2\2\u015c\33\3\2\2\2\u015d\u015b\3\2\2\2\u015e\u0160" {ADD | + } "\5j\66\2\u015f\u015e\3\2\2\2\u0160\u0163\3\2\2\2\u0161\u015f\3\2\2\2\u0161" {ADD | + } "\u0162\3\2\2\2\u0162\u0164\3\2\2\2\u0163\u0161\3\2\2\2\u0164\u0166\7f" {ADD | + } "\2\2\u0165\u0167\5\u00caf\2\u0166\u0165\3\2\2\2\u0166\u0167\3\2\2\2\u0167" {ADD | + } "\u0169\3\2\2\2\u0168\u016a\5$\23\2\u0169\u0168\3\2\2\2\u0169\u016a\3\2" {ADD | + } "\2\2\u016a\35\3\2\2\2\u016b\u016f\7A\2\2\u016c\u016e\5(\25\2\u016d\u016c" {ADD | + } "\3\2\2\2\u016e\u0171\3\2\2\2\u016f\u016d\3\2\2\2\u016f\u0170\3\2\2\2\u0170" {ADD | + } "\37\3\2\2\2\u0171\u016f\3\2\2\2\u0172\u0173\7\36\2\2\u0173\u0175\7f\2" {ADD | + } "\2\u0174\u0176\5\22\n\2\u0175\u0174\3\2\2\2\u0175\u0176\3\2\2\2\u0176" {ADD | + } "\u0179\3\2\2\2\u0177\u0178\7\23\2\2\u0178\u017a\5\"\22\2\u0179\u0177\3" {ADD | + } "\2\2\2\u0179\u017a\3\2\2\2\u017a\u017b\3\2\2\2\u017b\u017c\5&\24\2\u017c" {ADD | + } "!\3\2\2\2\u017d\u0182\5N(\2\u017e\u017f\7B\2\2\u017f\u0181\5N(\2\u0180" {ADD | + } "\u017e\3\2\2\2\u0181\u0184\3\2\2\2\u0182\u0180\3\2\2\2\u0182\u0183\3\2" {ADD | + } "\2\2\u0183#\3\2\2\2\u0184\u0182\3\2\2\2\u0185\u0189\7=\2\2\u0186\u0188" {ADD | + } "\5(\25\2\u0187\u0186\3\2\2\2\u0188\u018b\3\2\2\2\u0189\u0187\3\2\2\2\u0189" {ADD | + } "\u018a\3\2\2\2\u018a\u018c\3\2\2\2\u018b\u0189\3\2\2\2\u018c\u018d\7>" {ADD | + } "\2\2\u018d%\3\2\2\2\u018e\u0192\7=\2\2\u018f\u0191\5\66\34\2\u0190\u018f" {ADD | + } "\3\2\2\2\u0191\u0194\3\2\2\2\u0192\u0190\3\2\2\2\u0192\u0193\3\2\2\2\u0193" {ADD | + } "\u0195\3\2\2\2\u0194\u0192\3\2\2\2\u0195\u0196\7>\2\2\u0196\'\3\2\2\2" {ADD | + } "\u0197\u01a4\7A\2\2\u0198\u019a\7(\2\2\u0199\u0198\3\2\2\2\u0199\u019a" {ADD | + } "\3\2\2\2\u019a\u019b\3\2\2\2\u019b\u01a4\5\u0086D\2\u019c\u019e\5\n\6" {ADD | + } "\2\u019d\u019c\3\2\2\2\u019e\u01a1\3\2\2\2\u019f\u019d\3\2\2\2\u019f\u01a0" {ADD | + } "\3\2\2\2\u01a0\u01a2\3\2\2\2\u01a1\u019f\3\2\2\2\u01a2\u01a4\5*\26\2\u01a3" {ADD | + } "\u0197\3\2\2\2\u01a3\u0199\3\2\2\2\u01a3\u019f\3\2\2\2\u01a4)\3\2\2\2" {ADD | + } "\u01a5\u01af\5,\27\2\u01a6\u01af\5.\30\2\u01a7\u01af\5\64\33\2\u01a8\u01af" {ADD | + } "\5\60\31\2\u01a9\u01af\5\62\32\2\u01aa\u01af\5 \21\2\u01ab\u01af\5v<\2" {ADD | + } "\u01ac\u01af\5\20\t\2\u01ad\u01af\5\30\r\2\u01ae\u01a5\3\2\2\2\u01ae\u01a6" {ADD | + } "\3\2\2\2\u01ae\u01a7\3\2\2\2\u01ae\u01a8\3\2\2\2\u01ae\u01a9\3\2\2\2\u01ae" {ADD | + } "\u01aa\3\2\2\2\u01ae\u01ab\3\2\2\2\u01ae\u01ac\3\2\2\2\u01ae\u01ad\3\2" {ADD | + } "\2\2\u01af+\3\2\2\2\u01b0\u01b3\5N(\2\u01b1\u01b3\7\62\2\2\u01b2\u01b0" {ADD | + } "\3\2\2\2\u01b2\u01b1\3\2\2\2\u01b3\u01b4\3\2\2\2\u01b4\u01b5\7f\2\2\u01b5" {ADD | + } "\u01ba\5Z.\2\u01b6\u01b7\7?\2\2\u01b7\u01b9\7@\2\2\u01b8\u01b6\3\2\2\2" {ADD | + } "\u01b9\u01bc\3\2\2\2\u01ba\u01b8\3\2\2\2\u01ba\u01bb\3\2\2\2\u01bb\u01bf" {ADD | + } "\3\2\2\2\u01bc\u01ba\3\2\2\2\u01bd\u01be\7/\2\2\u01be\u01c0\5X-\2\u01bf" {ADD | + } "\u01bd\3\2\2\2\u01bf\u01c0\3\2\2\2\u01c0\u01c3\3\2\2\2\u01c1\u01c4\5b" {ADD | + } "\62\2\u01c2\u01c4\7A\2\2\u01c3\u01c1\3\2\2\2\u01c3\u01c2\3\2\2\2\u01c4" {ADD | + } "-\3\2\2\2\u01c5\u01c6\5\22\n\2\u01c6\u01c7\5,\27\2\u01c7/\3\2\2\2\u01c8" {ADD | + } "\u01c9\7f\2\2\u01c9\u01cc\5Z.\2\u01ca\u01cb\7/\2\2\u01cb\u01cd\5X-\2\u01cc" {ADD | + } "\u01ca\3\2\2\2\u01cc\u01cd\3\2\2\2\u01cd\u01ce\3\2\2\2\u01ce\u01cf\5d" {ADD | + } "\63\2\u01cf\61\3\2\2\2\u01d0\u01d1\5\22\n\2\u01d1\u01d2\5\60\31\2\u01d2" {ADD | + } "\63\3\2\2\2\u01d3\u01d4\5N(\2\u01d4\u01d5\5B\"\2\u01d5\u01d6\7A\2\2\u01d6" {ADD | + } "\65\3\2\2\2\u01d7\u01d9\5\n\6\2\u01d8\u01d7\3\2\2\2\u01d9\u01dc\3\2\2" {ADD | + } "\2\u01da\u01d8\3\2\2\2\u01da\u01db\3\2\2\2\u01db\u01dd\3\2\2\2\u01dc\u01da" {ADD | + } "\3\2\2\2\u01dd\u01e0\58\35\2\u01de\u01e0\7A\2\2\u01df\u01da\3\2\2\2\u01df" {ADD | + } "\u01de\3\2\2\2\u01e0\67\3\2\2\2\u01e1\u01e9\5:\36\2\u01e2\u01e9\5> \2" {ADD | + } "\u01e3\u01e9\5@!\2\u01e4\u01e9\5 \21\2\u01e5\u01e9\5v<\2\u01e6\u01e9\5" {ADD | + } "\20\t\2\u01e7\u01e9\5\30\r\2\u01e8\u01e1\3\2\2\2\u01e8\u01e2\3\2\2\2\u01e8" {ADD | + } "\u01e3\3\2\2\2\u01e8\u01e4\3\2\2\2\u01e8\u01e5\3\2\2\2\u01e8\u01e6\3\2" {ADD | + } "\2\2\u01e8\u01e7\3\2\2\2\u01e99\3\2\2\2\u01ea\u01eb\5N(\2\u01eb\u01f0" {ADD | + } "\5<\37\2\u01ec\u01ed\7B\2\2\u01ed\u01ef\5<\37\2\u01ee\u01ec\3\2\2\2\u01ef" {ADD | + } "\u01f2\3\2\2\2\u01f0\u01ee\3\2\2\2\u01f0\u01f1\3\2\2\2\u01f1\u01f3\3\2" {ADD | + } "\2\2\u01f2\u01f0\3\2\2\2\u01f3\u01f4\7A\2\2\u01f4;\3\2\2\2\u01f5\u01fa" {ADD | + } "\7f\2\2\u01f6\u01f7\7?\2\2\u01f7\u01f9\7@\2\2\u01f8\u01f6\3\2\2\2\u01f9" {ADD | + } "\u01fc\3\2\2\2\u01fa\u01f8\3\2\2\2\u01fa\u01fb\3\2\2\2\u01fb\u01fd\3\2" {ADD | + } "\2\2\u01fc\u01fa\3\2\2\2\u01fd\u01fe\7D\2\2\u01fe\u01ff\5H%\2\u01ff=\3" {ADD | + } "\2\2\2\u0200\u0203\5N(\2\u0201\u0203\7\62\2\2\u0202\u0200\3\2\2\2\u0202" {ADD | + } "\u0201\3\2\2\2\u0203\u0204\3\2\2\2\u0204\u0205\7f\2\2\u0205\u020a\5Z." {ADD | + } "\2\u0206\u0207\7?\2\2\u0207\u0209\7@\2\2\u0208\u0206\3\2\2\2\u0209\u020c" {ADD | + } "\3\2\2\2\u020a\u0208\3\2\2\2\u020a\u020b\3\2\2\2\u020b\u020f\3\2\2\2\u020c" {ADD | + } "\u020a\3\2\2\2\u020d\u020e\7/\2\2\u020e\u0210\5X-\2\u020f\u020d\3\2\2" {ADD | + } "\2\u020f\u0210\3\2\2\2\u0210\u0211\3\2\2\2\u0211\u0212\7A\2\2\u0212?\3" {ADD | + } "\2\2\2\u0213\u0214\5\22\n\2\u0214\u0215\5> \2\u0215A\3\2\2\2\u0216\u021b" {ADD | + } "\5D#\2\u0217\u0218\7B\2\2\u0218\u021a\5D#\2\u0219\u0217\3\2\2\2\u021a" {ADD | + } "\u021d\3\2\2\2\u021b\u0219\3\2\2\2\u021b\u021c\3\2\2\2\u021cC\3\2\2\2" {ADD | + } "\u021d\u021b\3\2\2\2\u021e\u0221\5F$\2\u021f\u0220\7D\2\2\u0220\u0222" {ADD | + } "\5H%\2\u0221\u021f\3\2\2\2\u0221\u0222\3\2\2\2\u0222E\3\2\2\2\u0223\u0228" {ADD | + } "\7f\2\2\u0224\u0225\7?\2\2\u0225\u0227\7@\2\2\u0226\u0224\3\2\2\2\u0227" {ADD | + } "\u022a\3\2\2\2\u0228\u0226\3\2\2\2\u0228\u0229\3\2\2\2\u0229G\3\2\2\2" {ADD | + } "\u022a\u0228\3\2\2\2\u022b\u022e\5J&\2\u022c\u022e\5\u00b0Y\2\u022d\u022b" {ADD | + } "\3\2\2\2\u022d\u022c\3\2\2\2\u022eI\3\2\2\2\u022f\u023b\7=\2\2\u0230\u0235" {ADD | + } "\5H%\2\u0231\u0232\7B\2\2\u0232\u0234\5H%\2\u0233\u0231\3\2\2\2\u0234" {ADD | + } "\u0237\3\2\2\2\u0235\u0233\3\2\2\2\u0235\u0236\3\2\2\2\u0236\u0239\3\2" {ADD | + } "\2\2\u0237\u0235\3\2\2\2\u0238\u023a\7B\2\2\u0239\u0238\3\2\2\2\u0239" {ADD | + } "\u023a\3\2\2\2\u023a\u023c\3\2\2\2\u023b\u0230\3\2\2\2\u023b\u023c\3\2" {ADD | + } "\2\2\u023c\u023d\3\2\2\2\u023d\u023e\7>\2\2\u023eK\3\2\2\2\u023f\u0240" {ADD | + } "\7f\2\2\u0240M\3\2\2\2\u0241\u0246\5P)\2\u0242\u0243\7?\2\2\u0243\u0245" {ADD | + } "\7@\2\2\u0244\u0242\3\2\2\2\u0245\u0248\3\2\2\2\u0246\u0244\3\2\2\2\u0246" {ADD | + } "\u0247\3\2\2\2\u0247\u0252\3\2\2\2\u0248\u0246\3\2\2\2\u0249\u024e\5R" {ADD | + } "*\2\u024a\u024b\7?\2\2\u024b\u024d\7@\2\2\u024c\u024a\3\2\2\2\u024d\u0250" {ADD | + } "\3\2\2\2\u024e\u024c\3\2\2\2\u024e\u024f\3\2\2\2\u024f\u0252\3\2\2\2\u0250" {ADD | + } "\u024e\3\2\2\2\u0251\u0241\3\2\2\2\u0251\u0249\3\2\2\2\u0252O\3\2\2\2" {ADD | + } "\u0253\u0255\7f\2\2\u0254\u0256\5T+\2\u0255\u0254\3\2\2\2\u0255\u0256" {ADD | + } "\3\2\2\2\u0256\u025e\3\2\2\2\u0257\u0258\7C\2\2\u0258\u025a\7f\2\2\u0259" {ADD | + } "\u025b\5T+\2\u025a\u0259\3\2\2\2\u025a\u025b\3\2\2\2\u025b\u025d\3\2\2" {ADD | + } "\2\u025c\u0257\3\2\2\2\u025d\u0260\3\2\2\2\u025e\u025c\3\2\2\2\u025e\u025f" {ADD | + } "\3\2\2\2\u025fQ\3\2\2\2\u0260\u025e\3\2\2\2\u0261\u0262\t\4\2\2\u0262" {ADD | + } "S\3\2\2\2\u0263\u0264\7F\2\2\u0264\u0269\5V,\2\u0265\u0266\7B\2\2\u0266" {ADD | + } "\u0268\5V,\2\u0267\u0265\3\2\2\2\u0268\u026b\3\2\2\2\u0269\u0267\3\2\2" {ADD | + } "\2\u0269\u026a\3\2\2\2\u026a\u026c\3\2\2\2\u026b\u0269\3\2\2\2\u026c\u026d" {ADD | + } "\7E\2\2\u026dU\3\2\2\2\u026e\u0275\5N(\2\u026f\u0272\7I\2\2\u0270\u0271" {ADD | + } "\t\5\2\2\u0271\u0273\5N(\2\u0272\u0270\3\2\2\2\u0272\u0273\3\2\2\2\u0273" {ADD | + } "\u0275\3\2\2\2\u0274\u026e\3\2\2\2\u0274\u026f\3\2\2\2\u0275W\3\2\2\2" {ADD | + } "\u0276\u027b\5f\64\2\u0277\u0278\7B\2\2\u0278\u027a\5f\64\2\u0279\u0277" {ADD | + } "\3\2\2\2\u027a\u027d\3\2\2\2\u027b\u0279\3\2\2\2\u027b\u027c\3\2\2\2\u027c" {ADD | + } "Y\3\2\2\2\u027d\u027b\3\2\2\2\u027e\u0280\7;\2\2\u027f\u0281\5\\/\2\u0280" {ADD | + } "\u027f\3\2\2\2\u0280\u0281\3\2\2\2\u0281\u0282\3\2\2\2\u0282\u0283\7<" {ADD | + } "\2\2\u0283[\3\2\2\2\u0284\u0289\5^\60\2\u0285\u0286\7B\2\2\u0286\u0288" {ADD | + } "\5^\60\2\u0287\u0285\3\2\2\2\u0288\u028b\3\2\2\2\u0289\u0287\3\2\2\2\u0289" {ADD | + } "\u028a\3\2\2\2\u028a\u028e\3\2\2\2\u028b\u0289\3\2\2\2\u028c\u028d\7B" {ADD | + } "\2\2\u028d\u028f\5`\61\2\u028e\u028c\3\2\2\2\u028e\u028f\3\2\2\2\u028f" {ADD | + } "\u0292\3\2\2\2\u0290\u0292\5`\61\2\u0291\u0284\3\2\2\2\u0291\u0290\3\2" {ADD | + } "\2\2\u0292]\3\2\2\2\u0293\u0295\5\16\b\2\u0294\u0293\3\2\2\2\u0295\u0298" {ADD | + } "\3\2\2\2\u0296\u0294\3\2\2\2\u0296\u0297\3\2\2\2\u0297\u0299\3\2\2\2\u0298" {ADD | + } "\u0296\3\2\2\2\u0299\u029a\5N(\2\u029a\u029b\5F$\2\u029b_\3\2\2\2\u029c" {ADD | + } "\u029e\5\16\b\2\u029d\u029c\3\2\2\2\u029e\u02a1\3\2\2\2\u029f\u029d\3" {ADD | + } "\2\2\2\u029f\u02a0\3\2\2\2\u02a0\u02a2\3\2\2\2\u02a1\u029f\3\2\2\2\u02a2" {ADD | + } "\u02a3\5N(\2\u02a3\u02a4\7h\2\2\u02a4\u02a5\5F$\2\u02a5a\3\2\2\2\u02a6" {ADD | + } "\u02a7\5\u0086D\2\u02a7c\3\2\2\2\u02a8\u02a9\5\u0086D\2\u02a9e\3\2\2\2" {ADD | + } "\u02aa\u02af\7f\2\2\u02ab\u02ac\7C\2\2\u02ac\u02ae\7f\2\2\u02ad\u02ab" {ADD | + } "\3\2\2\2\u02ae\u02b1\3\2\2\2\u02af\u02ad\3\2\2\2\u02af\u02b0\3\2\2\2\u02b0" {ADD | + } "g\3\2\2\2\u02b1\u02af\3\2\2\2\u02b2\u02b3\t\6\2\2\u02b3i\3\2\2\2\u02b4" {ADD | + } "\u02b5\7g\2\2\u02b5\u02bc\5l\67\2\u02b6\u02b9\7;\2\2\u02b7\u02ba\5n8\2" {ADD | + } "\u02b8\u02ba\5r:\2\u02b9\u02b7\3\2\2\2\u02b9\u02b8\3\2\2\2\u02b9\u02ba" {ADD | + } "\3\2\2\2\u02ba\u02bb\3\2\2\2\u02bb\u02bd\7<\2\2\u02bc\u02b6\3\2\2\2\u02bc" {ADD | + } "\u02bd\3\2\2\2\u02bdk\3\2\2\2\u02be\u02bf\5f\64\2\u02bfm\3\2\2\2\u02c0" {ADD | + } "\u02c5\5p9\2\u02c1\u02c2\7B\2\2\u02c2\u02c4\5p9\2\u02c3\u02c1\3\2\2\2" {ADD | + } "\u02c4\u02c7\3\2\2\2\u02c5\u02c3\3\2\2\2\u02c5\u02c6\3\2\2\2\u02c6o\3" {ADD | + } "\2\2\2\u02c7\u02c5\3\2\2\2\u02c8\u02c9\7f\2\2\u02c9\u02ca\7D\2\2\u02ca" {ADD | + } "\u02cb\5r:\2\u02cbq\3\2\2\2\u02cc\u02d0\5\u00b0Y\2\u02cd\u02d0\5j\66\2" {ADD | + } "\u02ce\u02d0\5t;\2\u02cf\u02cc\3\2\2\2\u02cf\u02cd\3\2\2\2\u02cf\u02ce" {ADD | + } "\3\2\2\2\u02d0s\3\2\2\2\u02d1\u02da\7=\2\2\u02d2\u02d7\5r:\2\u02d3\u02d4" {ADD | + } "\7B\2\2\u02d4\u02d6\5r:\2\u02d5\u02d3\3\2\2\2\u02d6\u02d9\3\2\2\2\u02d7" {ADD | + } "\u02d5\3\2\2\2\u02d7\u02d8\3\2\2\2\u02d8\u02db\3\2\2\2\u02d9\u02d7\3\2" {ADD | + } "\2\2\u02da\u02d2\3\2\2\2\u02da\u02db\3\2\2\2\u02db\u02dd\3\2\2\2\u02dc" {ADD | + } "\u02de\7B\2\2\u02dd\u02dc\3\2\2\2\u02dd\u02de\3\2\2\2\u02de\u02df\3\2" {ADD | + } "\2\2\u02df\u02e0\7>\2\2\u02e0u\3\2\2\2\u02e1\u02e2\7g\2\2\u02e2\u02e3" {ADD | + } "\7\36\2\2\u02e3\u02e4\7f\2\2\u02e4\u02e5\5x=\2\u02e5w\3\2\2\2\u02e6\u02ea" {ADD | + } "\7=\2\2\u02e7\u02e9\5z>\2\u02e8\u02e7\3\2\2\2\u02e9\u02ec\3\2\2\2\u02ea" {ADD | + } "\u02e8\3\2\2\2\u02ea\u02eb\3\2\2\2\u02eb\u02ed\3\2\2\2\u02ec\u02ea\3\2" {ADD | + } "\2\2\u02ed\u02ee\7>\2\2\u02eey\3\2\2\2\u02ef\u02f1\5\n\6\2\u02f0\u02ef" {ADD | + } "\3\2\2\2\u02f1\u02f4\3\2\2\2\u02f2\u02f0\3\2\2\2\u02f2\u02f3\3\2\2\2\u02f3" {ADD | + } "\u02f5\3\2\2\2\u02f4\u02f2\3\2\2\2\u02f5\u02f8\5|?\2\u02f6\u02f8\7A\2" {ADD | + } "\2\u02f7\u02f2\3\2\2\2\u02f7\u02f6\3\2\2\2\u02f8{\3\2\2\2\u02f9\u02fa" {ADD | + } "\5N(\2\u02fa\u02fb\5~@\2\u02fb\u02fc\7A\2\2\u02fc\u030e\3\2\2\2\u02fd" {ADD | + } "\u02ff\5\20\t\2\u02fe\u0300\7A\2\2\u02ff\u02fe\3\2\2\2\u02ff\u0300\3\2" {ADD | + } "\2\2\u0300\u030e\3\2\2\2\u0301\u0303\5 \21\2\u0302\u0304\7A\2\2\u0303" {ADD | + } "\u0302\3\2\2\2\u0303\u0304\3\2\2\2\u0304\u030e\3\2\2\2\u0305\u0307\5\30" {ADD | + } "\r\2\u0306\u0308\7A\2\2\u0307\u0306\3\2\2\2\u0307\u0308\3\2\2\2\u0308" {ADD | + } "\u030e\3\2\2\2\u0309\u030b\5v<\2\u030a\u030c\7A\2\2\u030b\u030a\3\2\2" {ADD | + } "\2\u030b\u030c\3\2\2\2\u030c\u030e\3\2\2\2\u030d\u02f9\3\2\2\2\u030d\u02fd" {ADD | + } "\3\2\2\2\u030d\u0301\3\2\2\2\u030d\u0305\3\2\2\2\u030d\u0309\3\2\2\2\u030e" {ADD | + } "}\3\2\2\2\u030f\u0312\5\u0080A\2\u0310\u0312\5\u0082B\2\u0311\u030f\3" {ADD | + } "\2\2\2\u0311\u0310\3\2\2\2\u0312\177\3\2\2\2\u0313\u0314\7f\2\2\u0314" {ADD | + } "\u0315\7;\2\2\u0315\u0317\7<\2\2\u0316\u0318\5\u0084C\2\u0317\u0316\3" {ADD | + } "\2\2\2\u0317\u0318\3\2\2\2\u0318\u0081\3\2\2\2\u0319\u031a\5B\"\2\u031a" {ADD | + } "\u0083\3\2\2\2\u031b\u031c\7\16\2\2\u031c\u031d\5r:\2\u031d\u0085\3\2" {ADD | + } "\2\2\u031e\u0322\7=\2\2\u031f\u0321\5\u0088E\2\u0320\u031f\3\2\2\2\u0321" {ADD | + } "\u0324\3\2\2\2\u0322\u0320\3\2\2\2\u0322\u0323\3\2\2\2\u0323\u0325\3\2" {ADD | + } "\2\2\u0324\u0322\3\2\2\2\u0325\u0326\7>\2\2\u0326\u0087\3\2\2\2\u0327" {ADD | + } "\u032b\5\u008aF\2\u0328\u032b\5\u008eH\2\u0329\u032b\5\b\5\2\u032a\u0327" {ADD | + } "\3\2\2\2\u032a\u0328\3\2\2\2\u032a\u0329\3\2\2\2\u032b\u0089\3\2\2\2\u032c" {ADD | + } "\u032d\5\u008cG\2\u032d\u032e\7A\2\2\u032e\u008b\3\2\2\2\u032f\u0331\5" {ADD | + } "\16\b\2\u0330\u032f\3\2\2\2\u0331\u0334\3\2\2\2\u0332\u0330\3\2\2\2\u0332" {ADD | + } "\u0333\3\2\2\2\u0333\u0335\3\2\2\2\u0334\u0332\3\2\2\2\u0335\u0336\5N" {ADD | + } "(\2\u0336\u0337\5B\"\2\u0337\u008d\3\2\2\2\u0338\u03a1\5\u0086D\2\u0339" {ADD | + } "\u033a\7\4\2\2\u033a\u033d\5\u00b0Y\2\u033b\u033c\7J\2\2\u033c\u033e\5" {ADD | + } "\u00b0Y\2\u033d\u033b\3\2\2\2\u033d\u033e\3\2\2\2\u033e\u033f\3\2\2\2" {ADD | + } "\u033f\u0340\7A\2\2\u0340\u03a1\3\2\2\2\u0341\u0342\7\30\2\2\u0342\u0343" {ADD | + } "\5\u00a8U\2\u0343\u0346\5\u008eH\2\u0344\u0345\7\21\2\2\u0345\u0347\5" {ADD | + } "\u008eH\2\u0346\u0344\3\2\2\2\u0346\u0347\3\2\2\2\u0347\u03a1\3\2\2\2" {ADD | + } "\u0348\u0349\7\27\2\2\u0349\u034a\7;\2\2\u034a\u034b\5\u00a0Q\2\u034b" {ADD | + } "\u034c\7<\2\2\u034c\u034d\5\u008eH\2\u034d\u03a1\3\2\2\2\u034e\u034f\7" {ADD | + } "\64\2\2\u034f\u0350\5\u00a8U\2\u0350\u0351\5\u008eH\2\u0351\u03a1\3\2" {ADD | + } "\2\2\u0352\u0353\7\17\2\2\u0353\u0354\5\u008eH\2\u0354\u0355\7\64\2\2" {ADD | + } "\u0355\u0356\5\u00a8U\2\u0356\u0357\7A\2\2\u0357\u03a1\3\2\2\2\u0358\u0359" {ADD | + } "\7\61\2\2\u0359\u0363\5\u0086D\2\u035a\u035c\5\u0090I\2\u035b\u035a\3" {ADD | + } "\2\2\2\u035c\u035d\3\2\2\2\u035d\u035b\3\2\2\2\u035d\u035e\3\2\2\2\u035e" {ADD | + } "\u0360\3\2\2\2\u035f\u0361\5\u0094K\2\u0360\u035f\3\2\2\2\u0360\u0361" {ADD | + } "\3\2\2\2\u0361\u0364\3\2\2\2\u0362\u0364\5\u0094K\2\u0363\u035b\3\2\2" {ADD | + } "\2\u0363\u0362\3\2\2\2\u0364\u03a1\3\2\2\2\u0365\u0366\7\61\2\2\u0366" {ADD | + } "\u0367\5\u0096L\2\u0367\u036b\5\u0086D\2\u0368\u036a\5\u0090I\2\u0369" {ADD | + } "\u0368\3\2\2\2\u036a\u036d\3\2\2\2\u036b\u0369\3\2\2\2\u036b\u036c\3\2" {ADD | + } "\2\2\u036c\u036f\3\2\2\2\u036d\u036b\3\2\2\2\u036e\u0370\5\u0094K\2\u036f" {ADD | + } "\u036e\3\2\2\2\u036f\u0370\3\2\2\2\u0370\u03a1\3\2\2\2\u0371\u0372\7+" {ADD | + } "\2\2\u0372\u0373\5\u00a8U\2\u0373\u0377\7=\2\2\u0374\u0376\5\u009cO\2" {ADD | + } "\u0375\u0374\3\2\2\2\u0376\u0379\3\2\2\2\u0377\u0375\3\2\2\2\u0377\u0378" {ADD | + } "\3\2\2\2\u0378\u037d\3\2\2\2\u0379\u0377\3\2\2\2\u037a\u037c\5\u009eP" {ADD | + } "\2\u037b\u037a\3\2\2\2\u037c\u037f\3\2\2\2\u037d\u037b\3\2\2\2\u037d\u037e" {ADD | + } "\3\2\2\2\u037e\u0380\3\2\2\2\u037f\u037d\3\2\2\2\u0380\u0381\7>\2\2\u0381" {ADD | + } "\u03a1\3\2\2\2\u0382\u0383\7,\2\2\u0383\u0384\5\u00a8U\2\u0384\u0385\5" {ADD | + } "\u0086D\2\u0385\u03a1\3\2\2\2\u0386\u0388\7&\2\2\u0387\u0389\5\u00b0Y" {ADD | + } "\2\u0388\u0387\3\2\2\2\u0388\u0389\3\2\2\2\u0389\u038a\3\2\2\2\u038a\u03a1" {ADD | + } "\7A\2\2\u038b\u038c\7.\2\2\u038c\u038d\5\u00b0Y\2\u038d\u038e\7A\2\2\u038e" {ADD | + } "\u03a1\3\2\2\2\u038f\u0391\7\6\2\2\u0390\u0392\7f\2\2\u0391\u0390\3\2" {ADD | + } "\2\2\u0391\u0392\3\2\2\2\u0392\u0393\3\2\2\2\u0393\u03a1\7A\2\2\u0394" {ADD | + } "\u0396\7\r\2\2\u0395\u0397\7f\2\2\u0396\u0395\3\2\2\2\u0396\u0397\3\2" {ADD | + } "\2\2\u0397\u0398\3\2\2\2\u0398\u03a1\7A\2\2\u0399\u03a1\7A\2\2\u039a\u039b" {ADD | + } "\5\u00acW\2\u039b\u039c\7A\2\2\u039c\u03a1\3\2\2\2\u039d\u039e\7f\2\2" {ADD | + } "\u039e\u039f\7J\2\2\u039f\u03a1\5\u008eH\2\u03a0\u0338\3\2\2\2\u03a0\u0339" {ADD | + } "\3\2\2\2\u03a0\u0341\3\2\2\2\u03a0\u0348\3\2\2\2\u03a0\u034e\3\2\2\2\u03a0" {ADD | + } "\u0352\3\2\2\2\u03a0\u0358\3\2\2\2\u03a0\u0365\3\2\2\2\u03a0\u0371\3\2" {ADD | + } "\2\2\u03a0\u0382\3\2\2\2\u03a0\u0386\3\2\2\2\u03a0\u038b\3\2\2\2\u03a0" {ADD | + } "\u038f\3\2\2\2\u03a0\u0394\3\2\2\2\u03a0\u0399\3\2\2\2\u03a0\u039a\3\2" {ADD | + } "\2\2\u03a0\u039d\3\2\2\2\u03a1\u008f\3\2\2\2\u03a2\u03a3\7\t\2\2\u03a3" {ADD | + } "\u03a7\7;\2\2\u03a4\u03a6\5\16\b\2\u03a5\u03a4\3\2\2\2\u03a6\u03a9\3\2" {ADD | + } "\2\2\u03a7\u03a5\3\2\2\2\u03a7\u03a8\3\2\2\2\u03a8\u03aa\3\2\2\2\u03a9" {ADD | + } "\u03a7\3\2\2\2\u03aa\u03ab\5\u0092J\2\u03ab\u03ac\7f\2\2\u03ac\u03ad\7" {ADD | + } "<\2\2\u03ad\u03ae\5\u0086D\2\u03ae\u0091\3\2\2\2\u03af\u03b4\5f\64\2\u03b0" {ADD | + } "\u03b1\7X\2\2\u03b1\u03b3\5f\64\2\u03b2\u03b0\3\2\2\2\u03b3\u03b6\3\2" {ADD | + } "\2\2\u03b4\u03b2\3\2\2\2\u03b4\u03b5\3\2\2\2\u03b5\u0093\3\2\2\2\u03b6" {ADD | + } "\u03b4\3\2\2\2\u03b7\u03b8\7\25\2\2\u03b8\u03b9\5\u0086D\2\u03b9\u0095" {ADD | + } "\3\2\2\2\u03ba\u03bb\7;\2\2\u03bb\u03bd\5\u0098M\2\u03bc\u03be\7A\2\2" {ADD | + } "\u03bd\u03bc\3\2\2\2\u03bd\u03be\3\2\2\2\u03be\u03bf\3\2\2\2\u03bf\u03c0" {ADD | + } "\7<\2\2\u03c0\u0097\3\2\2\2\u03c1\u03c6\5\u009aN\2\u03c2\u03c3\7A\2\2" {ADD | + } "\u03c3\u03c5\5\u009aN\2\u03c4\u03c2\3\2\2\2\u03c5\u03c8\3\2\2\2\u03c6" {ADD | + } "\u03c4\3\2\2\2\u03c6\u03c7\3\2\2\2\u03c7\u0099\3\2\2\2\u03c8\u03c6\3\2" {ADD | + } "\2\2\u03c9\u03cb\5\16\b\2\u03ca\u03c9\3\2\2\2\u03cb\u03ce\3\2\2\2\u03cc" {ADD | + } "\u03ca\3\2\2\2\u03cc\u03cd\3\2\2\2\u03cd\u03cf\3\2\2\2\u03ce\u03cc\3\2" {ADD | + } "\2\2\u03cf\u03d0\5P)\2\u03d0\u03d1\5F$\2\u03d1\u03d2\7D\2\2\u03d2\u03d3" {ADD | + } "\5\u00b0Y\2\u03d3\u009b\3\2\2\2\u03d4\u03d6\5\u009eP\2\u03d5\u03d4\3\2" {ADD | + } "\2\2\u03d6\u03d7\3\2\2\2\u03d7\u03d5\3\2\2\2\u03d7\u03d8\3\2\2\2\u03d8" {ADD | + } "\u03da\3\2\2\2\u03d9\u03db\5\u0088E\2\u03da\u03d9\3\2\2\2\u03db\u03dc" {ADD | + } "\3\2\2\2\u03dc\u03da\3\2\2\2\u03dc\u03dd\3\2\2\2\u03dd\u009d\3\2\2\2\u03de" {ADD | + } "\u03df\7\b\2\2\u03df\u03e0\5\u00aeX\2\u03e0\u03e1\7J\2\2\u03e1\u03e9\3" {ADD | + } "\2\2\2\u03e2\u03e3\7\b\2\2\u03e3\u03e4\5L\'\2\u03e4\u03e5\7J\2\2\u03e5" {ADD | + } "\u03e9\3\2\2\2\u03e6\u03e7\7\16\2\2\u03e7\u03e9\7J\2\2\u03e8\u03de\3\2" {ADD | + } "\2\2\u03e8\u03e2\3\2\2\2\u03e8\u03e6\3\2\2\2\u03e9\u009f\3\2\2\2\u03ea" {ADD | + } "\u03f7\5\u00a4S\2\u03eb\u03ed\5\u00a2R\2\u03ec\u03eb\3\2\2\2\u03ec\u03ed" {ADD | + } "\3\2\2\2\u03ed\u03ee\3\2\2\2\u03ee\u03f0\7A\2\2\u03ef\u03f1\5\u00b0Y\2" {ADD | + } "\u03f0\u03ef\3\2\2\2\u03f0\u03f1\3\2\2\2\u03f1\u03f2\3\2\2\2\u03f2\u03f4" {ADD | + } "\7A\2\2\u03f3\u03f5\5\u00a6T\2\u03f4\u03f3\3\2\2\2\u03f4\u03f5\3\2\2\2" {ADD | + } "\u03f5\u03f7\3\2\2\2\u03f6\u03ea\3\2\2\2\u03f6\u03ec\3\2\2\2\u03f7\u00a1" {ADD | + } "\3\2\2\2\u03f8\u03fb\5\u008cG\2\u03f9\u03fb\5\u00aaV\2\u03fa\u03f8\3\2" {ADD | + } "\2\2\u03fa\u03f9\3\2\2\2\u03fb\u00a3\3\2\2\2\u03fc\u03fe\5\16\b\2\u03fd" {ADD | + } "\u03fc\3\2\2\2\u03fe\u0401\3\2\2\2\u03ff\u03fd\3\2\2\2\u03ff\u0400\3\2" {ADD | + } "\2\2\u0400\u0402\3\2\2\2\u0401\u03ff\3\2\2\2\u0402\u0403\5N(\2\u0403\u0404" {ADD | + } "\5F$\2\u0404\u0405\7J\2\2\u0405\u0406\5\u00b0Y\2\u0406\u00a5\3\2\2\2\u0407" {ADD | + } "\u0408\5\u00aaV\2\u0408\u00a7\3\2\2\2\u0409\u040a\7;\2\2\u040a\u040b\5" {ADD | + } "\u00b0Y\2\u040b\u040c\7<\2\2\u040c\u00a9\3\2\2\2\u040d\u0412\5\u00b0Y" {ADD | + } "\2\u040e\u040f\7B\2\2\u040f\u0411\5\u00b0Y\2\u0410\u040e\3\2\2\2\u0411" {ADD | + } "\u0414\3\2\2\2\u0412\u0410\3\2\2\2\u0412\u0413\3\2\2\2\u0413\u00ab\3\2" {ADD | + } "\2\2\u0414\u0412\3\2\2\2\u0415\u0416\5\u00b0Y\2\u0416\u00ad\3\2\2\2\u0417" {ADD | + } "\u0418\5\u00b0Y\2\u0418\u00af\3\2\2\2\u0419\u041a\bY\1\2\u041a\u041b\7" {ADD | + } ";\2\2\u041b\u041c\5N(\2\u041c\u041d\7<\2\2\u041d\u041e\5\u00b0Y\23\u041e" {ADD | + } "\u0427\3\2\2\2\u041f\u0420\t\7\2\2\u0420\u0427\5\u00b0Y\21\u0421\u0422" {ADD | + } "\t\b\2\2\u0422\u0427\5\u00b0Y\20\u0423\u0427\5\u00b2Z\2\u0424\u0425\7" {ADD | + } "!\2\2\u0425\u0427\5\u00b4[\2\u0426\u0419\3\2\2\2\u0426\u041f\3\2\2\2\u0426" {ADD | + } "\u0421\3\2\2\2\u0426\u0423\3\2\2\2\u0426\u0424\3\2\2\2\u0427\u047d\3\2" {ADD | + } "\2\2\u0428\u0429\f\17\2\2\u0429\u042a\t\t\2\2\u042a\u047c\5\u00b0Y\20" {ADD | + } "\u042b\u042c\f\16\2\2\u042c\u042d\t\n\2\2\u042d\u047c\5\u00b0Y\17\u042e" {ADD | + } "\u0436\f\r\2\2\u042f\u0430\7F\2\2\u0430\u0437\7F\2\2\u0431\u0432\7E\2" {ADD | + } "\2\u0432\u0433\7E\2\2\u0433\u0437\7E\2\2\u0434\u0435\7E\2\2\u0435\u0437" {ADD | + } "\7E\2\2\u0436\u042f\3\2\2\2\u0436\u0431\3\2\2\2\u0436\u0434\3\2\2\2\u0437" {ADD | + } "\u0438\3\2\2\2\u0438\u047c\5\u00b0Y\16\u0439\u043a\f\f\2\2\u043a\u043b" {ADD | + } "\t\13\2\2\u043b\u047c\5\u00b0Y\r\u043c\u043d\f\n\2\2\u043d\u043e\t\f\2" {ADD | + } "\2\u043e\u047c\5\u00b0Y\13\u043f\u0440\f\t\2\2\u0440\u0441\7W\2\2\u0441" {ADD | + } "\u047c\5\u00b0Y\n\u0442\u0443\f\b\2\2\u0443\u0444\7Y\2\2\u0444\u047c\5" {ADD | + } "\u00b0Y\t\u0445\u0446\f\7\2\2\u0446\u0447\7X\2\2\u0447\u047c\5\u00b0Y" {ADD | + } "\b\u0448\u0449\f\6\2\2\u0449\u044a\7O\2\2\u044a\u047c\5\u00b0Y\7\u044b" {ADD | + } "\u044c\f\5\2\2\u044c\u044d\7P\2\2\u044d\u047c\5\u00b0Y\6\u044e\u044f\f" {ADD | + } "\4\2\2\u044f\u0450\7I\2\2\u0450\u0451\5\u00b0Y\2\u0451\u0452\7J\2\2\u0452" {ADD | + } "\u0453\5\u00b0Y\5\u0453\u047c\3\2\2\2\u0454\u0455\f\3\2\2\u0455\u0456" {ADD | + } "\t\r\2\2\u0456\u047c\5\u00b0Y\3\u0457\u0458\f\33\2\2\u0458\u0459\7C\2" {ADD | + } "\2\u0459\u047c\7f\2\2\u045a\u045b\f\32\2\2\u045b\u045c\7C\2\2\u045c\u047c" {ADD | + } "\7-\2\2\u045d\u045e\f\31\2\2\u045e\u045f\7C\2\2\u045f\u0461\7!\2\2\u0460" {ADD | + } "\u0462\5\u00c0a\2\u0461\u0460\3\2\2\2\u0461\u0462\3\2\2\2\u0462\u0463" {ADD | + } "\3\2\2\2\u0463\u047c\5\u00b8]\2\u0464\u0465\f\30\2\2\u0465\u0466\7C\2" {ADD | + } "\2\u0466\u0467\7*\2\2\u0467\u047c\5\u00c6d\2\u0468\u0469\f\27\2\2\u0469" {ADD | + } "\u046a\7C\2\2\u046a\u047c\5\u00be`\2\u046b\u046c\f\26\2\2\u046c\u046d" {ADD | + } "\7?\2\2\u046d\u046e\5\u00b0Y\2\u046e\u046f\7@\2\2\u046f\u047c\3\2\2\2" {ADD | + } "\u0470\u0471\f\25\2\2\u0471\u0473\7;\2\2\u0472\u0474\5\u00aaV\2\u0473" {ADD | + } "\u0472\3\2\2\2\u0473\u0474\3\2\2\2\u0474\u0475\3\2\2\2\u0475\u047c\7<" {ADD | + } "\2\2\u0476\u0477\f\22\2\2\u0477\u047c\t\16\2\2\u0478\u0479\f\13\2\2\u0479" {ADD | + } "\u047a\7\34\2\2\u047a\u047c\5N(\2\u047b\u0428\3\2\2\2\u047b\u042b\3\2" {ADD | + } "\2\2\u047b\u042e\3\2\2\2\u047b\u0439\3\2\2\2\u047b\u043c\3\2\2\2\u047b" {ADD | + } "\u043f\3\2\2\2\u047b\u0442\3\2\2\2\u047b\u0445\3\2\2\2\u047b\u0448\3\2" {ADD | + } "\2\2\u047b\u044b\3\2\2\2\u047b\u044e\3\2\2\2\u047b\u0454\3\2\2\2\u047b" {ADD | + } "\u0457\3\2\2\2\u047b\u045a\3\2\2\2\u047b\u045d\3\2\2\2\u047b\u0464\3\2" {ADD | + } "\2\2\u047b\u0468\3\2\2\2\u047b\u046b\3\2\2\2\u047b\u0470\3\2\2\2\u047b" {ADD | + } "\u0476\3\2\2\2\u047b\u0478\3\2\2\2\u047c\u047f\3\2\2\2\u047d\u047b\3\2" {ADD | + } "\2\2\u047d\u047e\3\2\2\2\u047e\u00b1\3\2\2\2\u047f\u047d\3\2\2\2\u0480" {ADD | + } "\u0481\7;\2\2\u0481\u0482\5\u00b0Y\2\u0482\u0483\7<\2\2\u0483\u0496\3" {ADD | + } "\2\2\2\u0484\u0496\7-\2\2\u0485\u0496\7*\2\2\u0486\u0496\5h\65\2\u0487" {ADD | + } "\u0496\7f\2\2\u0488\u0489\5N(\2\u0489\u048a\7C\2\2\u048a\u048b\7\13\2" {ADD | + } "\2\u048b\u0496\3\2\2\2\u048c\u048d\7\62\2\2\u048d\u048e\7C\2\2\u048e\u0496" {ADD | + } "\7\13\2\2\u048f\u0493\5\u00c0a\2\u0490\u0494\5\u00c8e\2\u0491\u0492\7" {ADD | + } "-\2\2\u0492\u0494\5\u00caf\2\u0493\u0490\3\2\2\2\u0493\u0491\3\2\2\2\u0494" {ADD | + } "\u0496\3\2\2\2\u0495\u0480\3\2\2\2\u0495\u0484\3\2\2\2\u0495\u0485\3\2" {ADD | + } "\2\2\u0495\u0486\3\2\2\2\u0495\u0487\3\2\2\2\u0495\u0488\3\2\2\2\u0495" {ADD | + } "\u048c\3\2\2\2\u0495\u048f\3\2\2\2\u0496\u00b3\3\2\2\2\u0497\u0498\5\u00c0" {ADD | + } "a\2\u0498\u0499\5\u00b6\\\2\u0499\u049a\5\u00bc_\2\u049a\u04a1\3\2\2\2" {ADD | + } "\u049b\u049e\5\u00b6\\\2\u049c\u049f\5\u00ba^\2\u049d\u049f\5\u00bc_\2" {ADD | + } "\u049e\u049c\3\2\2\2\u049e\u049d\3\2\2\2\u049f\u04a1\3\2\2\2\u04a0\u0497" {ADD | + } "\3\2\2\2\u04a0\u049b\3\2\2\2\u04a1\u00b5\3\2\2\2\u04a2\u04a4\7f\2\2\u04a3" {ADD | + } "\u04a5\5\u00c2b\2\u04a4\u04a3\3\2\2\2\u04a4\u04a5\3\2\2\2\u04a5\u04ad" {ADD | + } "\3\2\2\2\u04a6\u04a7\7C\2\2\u04a7\u04a9\7f\2\2\u04a8\u04aa\5\u00c2b\2" {ADD | + } "\u04a9\u04a8\3\2\2\2\u04a9\u04aa\3\2\2\2\u04aa\u04ac\3\2\2\2\u04ab\u04a6" {ADD | + } "\3\2\2\2\u04ac\u04af\3\2\2\2\u04ad\u04ab\3\2\2\2\u04ad\u04ae\3\2\2\2\u04ae" {ADD | + } "\u04b2\3\2\2\2\u04af\u04ad\3\2\2\2\u04b0\u04b2\5R*\2\u04b1\u04a2\3\2\2" {ADD | + } "\2\u04b1\u04b0\3\2\2\2\u04b2\u00b7\3\2\2\2\u04b3\u04b5\7f\2\2\u04b4\u04b6" {ADD | + } "\5\u00c4c\2\u04b5\u04b4\3\2\2\2\u04b5\u04b6\3\2\2\2\u04b6\u04b7\3\2\2" {ADD | + } "\2\u04b7\u04b8\5\u00bc_\2\u04b8\u00b9\3\2\2\2\u04b9\u04d5\7?\2\2\u04ba" {ADD | + } "\u04bf\7@\2\2\u04bb\u04bc\7?\2\2\u04bc\u04be\7@\2\2\u04bd\u04bb\3\2\2" {ADD | + } "\2\u04be\u04c1\3\2\2\2\u04bf\u04bd\3\2\2\2\u04bf\u04c0\3\2\2\2\u04c0\u04c2" {ADD | + } "\3\2\2\2\u04c1\u04bf\3\2\2\2\u04c2\u04d6\5J&\2\u04c3\u04c4\5\u00b0Y\2" {ADD | + } "\u04c4\u04cb\7@\2\2\u04c5\u04c6\7?\2\2\u04c6\u04c7\5\u00b0Y\2\u04c7\u04c8" {ADD | + } "\7@\2\2\u04c8\u04ca\3\2\2\2\u04c9\u04c5\3\2\2\2\u04ca\u04cd\3\2\2\2\u04cb" {ADD | + } "\u04c9\3\2\2\2\u04cb\u04cc\3\2\2\2\u04cc\u04d2\3\2\2\2\u04cd\u04cb\3\2" {ADD | + } "\2\2\u04ce\u04cf\7?\2\2\u04cf\u04d1\7@\2\2\u04d0\u04ce\3\2\2\2\u04d1\u04d4" {ADD | + } "\3\2\2\2\u04d2\u04d0\3\2\2\2\u04d2\u04d3\3\2\2\2\u04d3\u04d6\3\2\2\2\u04d4" {ADD | + } "\u04d2\3\2\2\2\u04d5\u04ba\3\2\2\2\u04d5\u04c3\3\2\2\2\u04d6\u00bb\3\2" {ADD | + } "\2\2\u04d7\u04d9\5\u00caf\2\u04d8\u04da\5$\23\2\u04d9\u04d8\3\2\2\2\u04d9" {ADD | + } "\u04da\3\2\2\2\u04da\u00bd\3\2\2\2\u04db\u04dc\5\u00c0a\2\u04dc\u04dd" {ADD | + } "\5\u00c8e\2\u04dd\u00bf\3\2\2\2\u04de\u04df\7F\2\2\u04df\u04e0\5\"\22" {ADD | + } "\2\u04e0\u04e1\7E\2\2\u04e1\u00c1\3\2\2\2\u04e2\u04e3\7F\2\2\u04e3\u04e6" {ADD | + } "\7E\2\2\u04e4\u04e6\5T+\2\u04e5\u04e2\3\2\2\2\u04e5\u04e4\3\2\2\2\u04e6" {ADD | + } "\u00c3\3\2\2\2\u04e7\u04e8\7F\2\2\u04e8\u04eb\7E\2\2\u04e9\u04eb\5\u00c0" {ADD | + } "a\2\u04ea\u04e7\3\2\2\2\u04ea\u04e9\3\2\2\2\u04eb\u00c5\3\2\2\2\u04ec" {ADD | + } "\u04f3\5\u00caf\2\u04ed\u04ee\7C\2\2\u04ee\u04f0\7f\2\2\u04ef\u04f1\5" {ADD | + } "\u00caf\2\u04f0\u04ef\3\2\2\2\u04f0\u04f1\3\2\2\2\u04f1\u04f3\3\2\2\2" {ADD | + } "\u04f2\u04ec\3\2\2\2\u04f2\u04ed\3\2\2\2\u04f3\u00c7\3\2\2\2\u04f4\u04f5" {ADD | + } "\7*\2\2\u04f5\u04f9\5\u00c6d\2\u04f6\u04f7\7f\2\2\u04f7\u04f9\5\u00ca" {ADD | + } "f\2\u04f8\u04f4\3\2\2\2\u04f8\u04f6\3\2\2\2\u04f9\u00c9\3\2\2\2\u04fa" {ADD | + } "\u04fc\7;\2\2\u04fb\u04fd\5\u00aaV\2\u04fc\u04fb\3\2\2\2\u04fc\u04fd\3" {ADD | + } "\2\2\2\u04fd\u04fe\3\2\2\2\u04fe\u04ff\7<\2\2\u04ff\u00cb\3\2\2\2\u0097" {ADD | + } "\u00cd\u00d2\u00d8\u00e0\u00e9\u00ee\u00f5\u00fc\u0103\u010a\u010f\u0113" {ADD | + } "\u0117\u011b\u0120\u0124\u0128\u0132\u013a\u0141\u0148\u014c\u014f\u0152" {ADD | + } "\u015b\u0161\u0166\u0169\u016f\u0175\u0179\u0182\u0189\u0192\u0199\u019f" {ADD | + } "\u01a3\u01ae\u01b2\u01ba\u01bf\u01c3\u01cc\u01da\u01df\u01e8\u01f0\u01fa" {ADD | + } "\u0202\u020a\u020f\u021b\u0221\u0228\u022d\u0235\u0239\u023b\u0246\u024e" {ADD | + } "\u0251\u0255\u025a\u025e\u0269\u0272\u0274\u027b\u0280\u0289\u028e\u0291" {ADD | + } "\u0296\u029f\u02af\u02b9\u02bc\u02c5\u02cf\u02d7\u02da\u02dd\u02ea\u02f2" {ADD | + } "\u02f7\u02ff\u0303\u0307\u030b\u030d\u0311\u0317\u0322\u032a\u0332\u033d" {ADD | + } "\u0346\u035d\u0360\u0363\u036b\u036f\u0377\u037d\u0388\u0391\u0396\u03a0" {ADD | + } "\u03a7\u03b4\u03bd\u03c6\u03cc\u03d7\u03dc\u03e8\u03ec\u03f0\u03f4\u03f6" {ADD | + } "\u03fa\u03ff\u0412\u0426\u0436\u0461\u0473\u047b\u047d\u0493\u0495\u049e" {ADD | + } "\u04a0\u04a4\u04a9\u04ad\u04b1\u04b5\u04bf\u04cb\u04d2\u04d5\u04d9\u04e5" {ADD | + } "\u04ea\u04f0\u04f2\u04f8\u04fc" ; public static {
FINAL |final }
ATN _ATN = new ATNDeserializer().deserialize(_serializedATN.toCharArray());
static {
_decisionToDFA =  new DFA[_ATN.getNumberOfDecisions()] ;  {FOR | for } ( {INT |int }
i =  { IntegerLiteral | 0 } ; i {
LT | < }_ATN.getNumberOfDecisions ( ) ; i {
INC | ++ } ) {_decisionToDFA[i] =  new DFA(_ATN.getDecisionState (i) , 
i ) ;  } } } }