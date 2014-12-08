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
publicstatic {
FINAL |final }
int ABSTRACT = 1, ASSERT = 2, BOOLEAN = 3, BREAK = 4, BYTE = 5, CASE = 6, CATCH = 7, CHAR = 8, CLASS = 9, CONST = 10, CONTINUE = 11, DEFAULT = 12, DO = 13, DOUBLE = 14, ELSE = 15, ENUM = 16, EXTENDS = 17, FINAL = 18, FINALLY = 19, FLOAT = 20, FOR = 21, IF = 22, GOTO = 23, IMPLEMENTS = 24, IMPORT = 25, INSTANCEOF = 26, INT = 27, INTERFACE = 28, LONG = 29, NATIVE = 30, NEW = 31, PACKAGE = 32, PRIVATE = 33, PROTECTED = 34, PUBLIC = 35, RETURN = 36, SHORT = 37, STATIC = 38, STRICTFP = 39, SUPER = 40, SWITCH = 41, SYNCHRONIZED = 42, THIS = 43, THROW = 44, THROWS = 45, TRANSIENT = 46, TRY = 47, VOID = 48, VOLATILE = 49, WHILE = 50, IntegerLiteral = 51, FloatingPointLiteral = 52, BooleanLiteral = 53, CharacterLiteral = 54, StringLiteral = 55, NullLiteral = 56, LPAREN = 57, RPAREN = 58, LBRACE = 59, RBRACE = 60, LBRACK = 61, RBRACK = 62, SEMI = 63, COMMA = 64, DOT = 65, ASSIGN = 66, GT = 67, LT = 68, BANG = 69, TILDE = 70, QUESTION = 71, COLON = 72, EQUAL = 73, LE = 74, GE = 75, NOTEQUAL = 76, AND = 77, OR = 78, INC = 79, DEC = 80, ADD = 81, SUB = 82, MUL = 83, DIV = 84, BITAND = 85, BITOR = 86, CARET = 87, MOD = 88, ADD_ASSIGN = 89, SUB_ASSIGN = 90, MUL_ASSIGN = 91, DIV_ASSIGN = 92, AND_ASSIGN = 93, OR_ASSIGN = 94, XOR_ASSIGN = 95, MOD_ASSIGN = 96, LSHIFT_ASSIGN = 97, RSHIFT_ASSIGN = 98, URSHIFT_ASSIGN = 99, Identifier = 100, AT = 101, ELLIPSIS = 102, WS = 103, COMMENT = 104, LINE_COMMENT = 105;
publicstatic {
FINAL |final }
String[] tokenNames =
{
"<INVALID>", "'abstract'", "'assert'", "'boolean'", "'break'", "'byte'", "'case'", "'catch'", "'char'", "'class'", "'const'", "'continue'", "'default'", "'do'", "'double'", "'else'", "'enum'", "'extends'", "'final'", "'finally'", "'float'", "'for'", "'if'", "'goto'", "'implements'", "'import'", "'instanceof'", "'int'", "'interface'", "'long'", "'native'", "'new'", "'package'", "'private'", "'protected'", "'public'", "'return'", "'short'", "'static'", "'strictfp'", "'super'", "'switch'", "'synchronized'", "'this'", "'throw'", "'throws'", "'transient'", "'try'", "'void'", "'volatile'", "'while'", "IntegerLiteral", "FloatingPointLiteral", "BooleanLiteral", "CharacterLiteral", "StringLiteral", "'null'", "'('", "')'", "'{'", "'}'", "'['", "']'", "';'", "','", "'.'", "'='", "'>'", "'<'", "'!'", "'~'", "'?'", "':'", "'=='", "'<='", "'>='", "'!='", "'&&'", "'||'", "'++'", "'--'", "'+'", "'-'", "'*'", "'/'", "'&'", "'|'", "'^'", "'%'", "'+='", "'-='", "'*='", "'/='", "'&='", "'|='", "'^='", "'%='", "'<<='", "'>>='", "'>>>='", "Identifier", "'@'", "'...'", "WS", "COMMENT", "LINE_COMMENT"
}

;
publicstatic {
FINAL |final }
int RULE_compilationUnit = 0, RULE_packageDeclaration = 1, RULE_importDeclaration = 2, RULE_typeDeclaration = 3, RULE_modifier = 4, RULE_classOrInterfaceModifier = 5, RULE_variableModifier = 6, RULE_classDeclaration = 7, RULE_typeParameters = 8, RULE_typeParameter = 9, RULE_typeBound = 10, RULE_enumDeclaration = 11, RULE_enumConstants = 12, RULE_enumConstant = 13, RULE_enumBodyDeclarations = 14, RULE_interfaceDeclaration = 15, RULE_typeList = 16, RULE_classBody = 17, RULE_interfaceBody = 18, RULE_classBodyDeclaration = 19, RULE_memberDeclaration = 20, RULE_methodDeclaration = 21, RULE_genericMethodDeclaration = 22, RULE_constructorDeclaration = 23, RULE_genericConstructorDeclaration = 24, RULE_fieldDeclaration = 25, RULE_interfaceBodyDeclaration = 26, RULE_interfaceMemberDeclaration = 27, RULE_constDeclaration = 28, RULE_constantDeclarator = 29, RULE_interfaceMethodDeclaration = 30, RULE_genericInterfaceMethodDeclaration = 31, RULE_variableDeclarators = 32, RULE_variableDeclarator = 33, RULE_variableDeclaratorId = 34, RULE_variableInitializer = 35, RULE_arrayInitializer = 36, RULE_enumConstantName = 37, RULE_type = 38, RULE_classOrInterfaceType = 39, RULE_primitiveType = 40, RULE_typeArguments = 41, RULE_typeArgument = 42, RULE_qualifiedNameList = 43, RULE_formalParameters = 44, RULE_formalParameterList = 45, RULE_formalParameter = 46, RULE_lastFormalParameter = 47, RULE_methodBody = 48, RULE_constructorBody = 49, RULE_qualifiedName = 50, RULE_literal = 51, RULE_annotation = 52, RULE_annotationName = 53, RULE_elementValuePairs = 54, RULE_elementValuePair = 55, RULE_elementValue = 56, RULE_elementValueArrayInitializer = 57, RULE_annotationTypeDeclaration = 58, RULE_annotationTypeBody = 59, RULE_annotationTypeElementDeclaration = 60, RULE_annotationTypeElementRest = 61, RULE_annotationMethodOrConstantRest = 62, RULE_annotationMethodRest = 63, RULE_annotationConstantRest = 64, RULE_defaultValue = 65, RULE_block = 66, RULE_blockStatement = 67, RULE_localVariableDeclarationStatement = 68, RULE_localVariableDeclaration = 69, RULE_statement = 70, RULE_catchClause = 71, RULE_catchType = 72, RULE_finallyBlock = 73, RULE_resourceSpecification = 74, RULE_resources = 75, RULE_resource = 76, RULE_switchBlockStatementGroup = 77, RULE_switchLabel = 78, RULE_forControl = 79, RULE_forInit = 80, RULE_enhancedForControl = 81, RULE_forUpdate = 82, RULE_parExpression = 83, RULE_expressionList = 84, RULE_statementExpression = 85, RULE_constantExpression = 86, RULE_expression = 87, RULE_primary = 88, RULE_creator = 89, RULE_createdName = 90, RULE_innerCreator = 91, RULE_arrayCreatorRest = 92, RULE_classCreatorRest = 93, RULE_explicitGenericInvocation = 94, RULE_nonWildcardTypeArguments = 95, RULE_typeArgumentsOrDiamond = 96, RULE_nonWildcardTypeArgumentsOrDiamond = 97, RULE_superSuffix = 98, RULE_explicitGenericInvocationSuffix = 99, RULE_arguments = 100;
publicstatic {
FINAL |final }
String[] ruleNames =
{
"compilationUnit", "packageDeclaration", "importDeclaration", "typeDeclaration", "modifier", "classOrInterfaceModifier", "variableModifier", "classDeclaration", "typeParameters", "typeParameter", "typeBound", "enumDeclaration", "enumConstants", "enumConstant", "enumBodyDeclarations", "interfaceDeclaration", "typeList", "classBody", "interfaceBody", "classBodyDeclaration", "memberDeclaration", "methodDeclaration", "genericMethodDeclaration", "constructorDeclaration", "genericConstructorDeclaration", "fieldDeclaration", "interfaceBodyDeclaration", "interfaceMemberDeclaration", "constDeclaration", "constantDeclarator", "interfaceMethodDeclaration", "genericInterfaceMethodDeclaration", "variableDeclarators", "variableDeclarator", "variableDeclaratorId", "variableInitializer", "arrayInitializer", "enumConstantName", "type", "classOrInterfaceType", "primitiveType", "typeArguments", "typeArgument", "qualifiedNameList", "formalParameters", "formalParameterList", "formalParameter", "lastFormalParameter", "methodBody", "constructorBody", "qualifiedName", "literal", "annotation", "annotationName", "elementValuePairs", "elementValuePair", "elementValue", "elementValueArrayInitializer", "annotationTypeDeclaration", "annotationTypeBody", "annotationTypeElementDeclaration", "annotationTypeElementRest", "annotationMethodOrConstantRest", "annotationMethodRest", "annotationConstantRest", "defaultValue", "block", "blockStatement", "localVariableDeclarationStatement", "localVariableDeclaration", "statement", "catchClause", "catchType", "finallyBlock", "resourceSpecification", "resources", "resource", "switchBlockStatementGroup", "switchLabel", "forControl", "forInit", "enhancedForControl", "forUpdate", "parExpression", "expressionList", "statementExpression", "constantExpression", "expression", "primary", "creator", "createdName", "innerCreator", "arrayCreatorRest", "classCreatorRest", "explicitGenericInvocation", "nonWildcardTypeArguments", "typeArgumentsOrDiamond", "nonWildcardTypeArgumentsOrDiamond", "superSuffix", "explicitGenericInvocationSuffix", "arguments"
}

; {
AT | @ }Overridepublic StringgetGrammarFileName()
{
    return "Java.g4";
} {

AT | @ }Overridepublic String[] getTokenNames()
{
    return tokenNames;
} {

AT | @ }Overridepublic String[] getRuleNames()
{
    return ruleNames;
} {

AT | @ }Overridepublic StringgetSerializedATN()
{
    return _serializedATN;
} {

AT | @ }Overridepublic ATNgetATN()
{
    return _ATN;
}

publicJavaParser(TokenStream input)
{
    {
        SUPER | super
    }

    (input);
    _interp = new ParserATNSimulator(this, _ATN, _decisionToDFA, _sharedContextCache);
}

publicstatic class CompilationUnitContext
{
    EXTENDS |extends
}

ParserRuleContext {
public TypeDeclarationContexttypeDeclaration(int i)
{
    return getRuleContext(TypeDeclarationContext.class , 

i ) ;  }public ImportDeclarationContextimportDeclaration(int i)
{
    return getRuleContext(ImportDeclarationContext.class , 

i ) ;  }public List<ImportDeclarationContext> importDeclaration()
{
    return getRuleContexts(ImportDeclarationContext.class ) ;  }

public TerminalNodeEOF()
{
    return getToken(JavaParser.EOF, 0);
}

public PackageDeclarationContextpackageDeclaration()
{
    return getRuleContext(PackageDeclarationContext.class ,  0 ) ;  }

public List<TypeDeclarationContext> typeDeclaration()
{
    return getRuleContexts(TypeDeclarationContext.class ) ;  }

publicCompilationUnitContext(ParserRuleContext parent, int invokingState)
{
    {
        SUPER | super
    }

    (parent, invokingState);
} {

AT | @ }OverridepublicintgetRuleIndex()
{
    return RULE_compilationUnit;
} {

AT | @ }Overridepublic void enterRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterCompilationUnit(this);
} {

AT | @ }Overridepublic void exitRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitCompilationUnit(this);
} {

AT | @ }Overridepublic<T> Taccept(ParseTreeVisitor<?
{
    EXTENDS | extends
}

T >visitor ) { if  (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) return  ( (JavaVisitor<?
 {
EXTENDS |extends }
T > )visitor ) .visitCompilationUnit(this); else  return 
visitor.visitChildren (this )
    ;
} }
public {
FINAL |final }
CompilationUnitContextcompilationUnit()
{
    CompilationUnitContext _localctx = new CompilationUnitContext(_ctx, getState());
    enterRule(_localctx, 0, RULE_compilationUnit);
    int _la;
    try
    {
        enterOuterAlt(_localctx, 1);
        {
            setState(203);
            {
                SWITCH | switch
                }

                (getInterpreter().adaptivePredict(_input, 0, _ctx))
                {
                    {
                        CASE |  case
                    }

                    1 : 
                    {
                        setState(202);
                        packageDeclaration();
                    }

                    {
                        BREAK | break
                    }

                    ;
                }

                setState(208);
                _errHandler.sync(this);
                _la = _input.LA(1);
                {
                    WHILE | while
                }

                (_la == IMPORT)
                {
                    {
                        {
                            setState(205);
                            importDeclaration();
                        }
                    }

                    setState(210);
                    _errHandler.sync(this);
                    _la = _input.LA(1);
                }

                setState(214);
                _errHandler.sync(this);
                _la = _input.LA(1);
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

                0x3f ) 
                == 0 && ((1L << _la)
                {
                    BITAND | &
                }

                ((1L << ABSTRACT)
                {
                    BITOR ||
                }

                (1L << CLASS)
                {
                    BITOR ||
                }

                (1L << ENUM)
                {
                    BITOR ||
                }

                (1L << FINAL)
                {
                    BITOR ||
                }

                (1L << INTERFACE)
                {
                    BITOR ||
                }

                (1L << PRIVATE)
                {
                    BITOR ||
                }

                (1L << PROTECTED)
                {
                    BITOR ||
                }

                (1L << PUBLIC)
                {
                    BITOR ||
                }

                (1L << STATIC)
                {
                    BITOR ||
                }

                (1L << STRICTFP)
                {
                    BITOR ||
                }

                (1L << SEMI) ) ) 
                != 0 )
                {
                    OR || |
                }

                _la == AT )
                {
                    {
                        {
                            setState(211);
                            typeDeclaration();
                        }
                    }

                    setState(216);
                    _errHandler.sync(this);
                    _la = _input.LA(1);
                }

                setState(217);
                match(EOF);
            }
        }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(this, re);
        _errHandler.recover(this, re);
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        return _localctx;
    }

    publicstatic class PackageDeclarationContext
{
    EXTENDS |extends
}

ParserRuleContext {
public List<AnnotationContext> annotation()
{
    return getRuleContexts(AnnotationContext.class ) ;  }

public QualifiedNameContextqualifiedName()
{
    return getRuleContext(QualifiedNameContext.class ,  0 ) ;  }

public AnnotationContextannotation(int i)
{
    return getRuleContext(AnnotationContext.class , 

i ) ;  }publicPackageDeclarationContext(ParserRuleContext parent, int invokingState)
{
    {
        SUPER | super
    }

    (parent, invokingState);
} {

AT | @ }OverridepublicintgetRuleIndex()
{
    return RULE_packageDeclaration;
} {

AT | @ }Overridepublic void enterRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterPackageDeclaration(this);
} {

AT | @ }Overridepublic void exitRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitPackageDeclaration(this);
} {

AT | @ }Overridepublic<T> Taccept(ParseTreeVisitor<?
{
    EXTENDS | extends
}

T >visitor ) { if  (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) return  ( (JavaVisitor<?
 {
EXTENDS |extends }
T > )visitor ) .visitPackageDeclaration(this); else  return 
visitor.visitChildren (this )
    ;
} }
public {
FINAL |final }
PackageDeclarationContextpackageDeclaration()
{
    PackageDeclarationContext _localctx = new PackageDeclarationContext(_ctx, getState());
    enterRule(_localctx, 2, RULE_packageDeclaration);
    int _la;
    try
    {
        enterOuterAlt(_localctx, 1);
        {
            setState(222);
            _errHandler.sync(this);
            _la = _input.LA(1);
            {
                WHILE | while
            }

            (_la == AT)
            {
                {
                    {
                        setState(219);
                        annotation();
                    }
                }

                setState(224);
                _errHandler.sync(this);
                _la = _input.LA(1);
            }

            setState(225);
            match(PACKAGE);
            setState(226);
            qualifiedName();
            setState(227);
            match(SEMI);
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(this, re);
        _errHandler.recover(this, re);
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        return _localctx;
    }

    publicstatic class ImportDeclarationContext
{
    EXTENDS |extends
}

ParserRuleContext {
public QualifiedNameContextqualifiedName()
{
    return getRuleContext(QualifiedNameContext.class ,  0 ) ;  }

publicImportDeclarationContext(ParserRuleContext parent, int invokingState)
{
    {
        SUPER | super
    }

    (parent, invokingState);
} {

AT | @ }OverridepublicintgetRuleIndex()
{
    return RULE_importDeclaration;
} {

AT | @ }Overridepublic void enterRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterImportDeclaration(this);
} {

AT | @ }Overridepublic void exitRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitImportDeclaration(this);
} {

AT | @ }Overridepublic<T> Taccept(ParseTreeVisitor<?
{
    EXTENDS | extends
}

T >visitor ) { if  (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) return  ( (JavaVisitor<?
 {
EXTENDS |extends }
T > )visitor ) .visitImportDeclaration(this); else  return 
visitor.visitChildren (this )
    ;
} }
public {
FINAL |final }
ImportDeclarationContextimportDeclaration()
{
    ImportDeclarationContext _localctx = new ImportDeclarationContext(_ctx, getState());
    enterRule(_localctx, 4, RULE_importDeclaration);
    int _la;
    try
    {
        enterOuterAlt(_localctx, 1);
        {
            setState(229);
            match(IMPORT);
            setState(231);
            _la = _input.LA(1);
            if (_la == STATIC)
            {
                {
                    setState(230);
                    match(STATIC);
                }
            }

            setState(233);
            qualifiedName();
            setState(236);
            _la = _input.LA(1);
            if (_la == DOT)
            {
                {
                    setState(234);
                    match(DOT);
                    setState(235);
                    match(MUL);
                }
            }

            setState(238);
            match(SEMI);
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(this, re);
        _errHandler.recover(this, re);
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        return _localctx;
    }

    publicstatic class TypeDeclarationContext
{
    EXTENDS |extends
}

ParserRuleContext {
public ClassOrInterfaceModifierContextclassOrInterfaceModifier(int i)
{
    return getRuleContext(ClassOrInterfaceModifierContext.class , 

i ) ;  }public EnumDeclarationContextenumDeclaration()
{
    return getRuleContext(EnumDeclarationContext.class ,  0 ) ;  }

public ClassDeclarationContextclassDeclaration()
{
    return getRuleContext(ClassDeclarationContext.class ,  0 ) ;  }

public AnnotationTypeDeclarationContextannotationTypeDeclaration()
{
    return getRuleContext(AnnotationTypeDeclarationContext.class ,  0 ) ;  }

public List<ClassOrInterfaceModifierContext> classOrInterfaceModifier()
{
    return getRuleContexts(ClassOrInterfaceModifierContext.class ) ;  }

public InterfaceDeclarationContextinterfaceDeclaration()
{
    return getRuleContext(InterfaceDeclarationContext.class ,  0 ) ;  }

publicTypeDeclarationContext(ParserRuleContext parent, int invokingState)
{
    {
        SUPER | super
    }

    (parent, invokingState);
} {

AT | @ }OverridepublicintgetRuleIndex()
{
    return RULE_typeDeclaration;
} {

AT | @ }Overridepublic void enterRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterTypeDeclaration(this);
} {

AT | @ }Overridepublic void exitRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitTypeDeclaration(this);
} {

AT | @ }Overridepublic<T> Taccept(ParseTreeVisitor<?
{
    EXTENDS | extends
}

T >visitor ) { if  (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) return  ( (JavaVisitor<?
 {
EXTENDS |extends }
T > )visitor ) .visitTypeDeclaration(this); else  return 
visitor.visitChildren (this )
    ;
} }
public {
FINAL |final }
TypeDeclarationContexttypeDeclaration()
{
    TypeDeclarationContext _localctx = new TypeDeclarationContext(_ctx, getState());
    enterRule(_localctx, 6, RULE_typeDeclaration);
    int _la;
    try
    {
        int _alt;
        setState(269);
        {
            SWITCH | switch
            }

            (getInterpreter().adaptivePredict(_input, 10, _ctx))
            {
                {
                    CASE |  case
                }

                1 : 
                enterOuterAlt(_localctx, 1);
                {
                    setState(243);
                    _errHandler.sync(this);
                    _la = _input.LA(1);
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

                    0x3f ) 
                    == 0 && ((1L << _la)
                    {
                        BITAND | &
                    }

                    ((1L << ABSTRACT)
                    {
                        BITOR ||
                    }

                    (1L << FINAL)
                    {
                        BITOR ||
                    }

                    (1L << PRIVATE)
                    {
                        BITOR ||
                    }

                    (1L << PROTECTED)
                    {
                        BITOR ||
                    }

                    (1L << PUBLIC)
                    {
                        BITOR ||
                    }

                    (1L << STATIC)
                    {
                        BITOR ||
                    }

                    (1L << STRICTFP) ) ) 
                    != 0 )
                    {
                        OR || |
                    }

                    _la == AT )
                    {
                        {
                            {
                                setState(240);
                                classOrInterfaceModifier();
                            }
                        }

                        setState(245);
                        _errHandler.sync(this);
                        _la = _input.LA(1);
                    }

                    setState(246);
                    classDeclaration();
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                2 : 
                enterOuterAlt(_localctx, 2);
                {
                    setState(250);
                    _errHandler.sync(this);
                    _la = _input.LA(1);
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

                    0x3f ) 
                    == 0 && ((1L << _la)
                    {
                        BITAND | &
                    }

                    ((1L << ABSTRACT)
                    {
                        BITOR ||
                    }

                    (1L << FINAL)
                    {
                        BITOR ||
                    }

                    (1L << PRIVATE)
                    {
                        BITOR ||
                    }

                    (1L << PROTECTED)
                    {
                        BITOR ||
                    }

                    (1L << PUBLIC)
                    {
                        BITOR ||
                    }

                    (1L << STATIC)
                    {
                        BITOR ||
                    }

                    (1L << STRICTFP) ) ) 
                    != 0 )
                    {
                        OR || |
                    }

                    _la == AT )
                    {
                        {
                            {
                                setState(247);
                                classOrInterfaceModifier();
                            }
                        }

                        setState(252);
                        _errHandler.sync(this);
                        _la = _input.LA(1);
                    }

                    setState(253);
                    enumDeclaration();
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                3 : 
                enterOuterAlt(_localctx, 3);
                {
                    setState(257);
                    _errHandler.sync(this);
                    _la = _input.LA(1);
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

                    0x3f ) 
                    == 0 && ((1L << _la)
                    {
                        BITAND | &
                    }

                    ((1L << ABSTRACT)
                    {
                        BITOR ||
                    }

                    (1L << FINAL)
                    {
                        BITOR ||
                    }

                    (1L << PRIVATE)
                    {
                        BITOR ||
                    }

                    (1L << PROTECTED)
                    {
                        BITOR ||
                    }

                    (1L << PUBLIC)
                    {
                        BITOR ||
                    }

                    (1L << STATIC)
                    {
                        BITOR ||
                    }

                    (1L << STRICTFP) ) ) 
                    != 0 )
                    {
                        OR || |
                    }

                    _la == AT )
                    {
                        {
                            {
                                setState(254);
                                classOrInterfaceModifier();
                            }
                        }

                        setState(259);
                        _errHandler.sync(this);
                        _la = _input.LA(1);
                    }

                    setState(260);
                    interfaceDeclaration();
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                4 : 
                enterOuterAlt(_localctx, 4);
                {
                    setState(264);
                    _errHandler.sync(this);
                    _alt = getInterpreter().adaptivePredict(_input, 9, _ctx);
                    {
                        WHILE | while
                    }

                    (_alt != 2 && _alt != org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER)
                    {
                        if (_alt == 1)
                        {
                            {
                                {
                                    setState(261);
                                    classOrInterfaceModifier();
                                }
                            }
                        }

                        setState(266);
                        _errHandler.sync(this);
                        _alt = getInterpreter().adaptivePredict(_input, 9, _ctx);
                    }

                    setState(267);
                    annotationTypeDeclaration();
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                5 : 
                enterOuterAlt(_localctx, 5);
                {
                    setState(268);
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
        _errHandler.reportError(this, re);
        _errHandler.recover(this, re);
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        return _localctx;
    }

    publicstatic class ModifierContext
{
    EXTENDS |extends
}

ParserRuleContext {
public ClassOrInterfaceModifierContextclassOrInterfaceModifier()
{
    return getRuleContext(ClassOrInterfaceModifierContext.class ,  0 ) ;  }

publicModifierContext(ParserRuleContext parent, int invokingState)
{
    {
        SUPER | super
    }

    (parent, invokingState);
} {

AT | @ }OverridepublicintgetRuleIndex()
{
    return RULE_modifier;
} {

AT | @ }Overridepublic void enterRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterModifier(this);
} {

AT | @ }Overridepublic void exitRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitModifier(this);
} {

AT | @ }Overridepublic<T> Taccept(ParseTreeVisitor<?
{
    EXTENDS | extends
}

T >visitor ) { if  (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) return  ( (JavaVisitor<?
 {
EXTENDS |extends }
T > )visitor ) .visitModifier(this); else  return 
visitor.visitChildren (this )
    ;
} }
public {
FINAL |final }
ModifierContextmodifier()
{
    ModifierContext _localctx = new ModifierContext(_ctx, getState());
    enterRule(_localctx, 8, RULE_modifier);
    int _la;
    try
    {
        setState(273);
        {
            SWITCH | switch
            }

            (_input.LA(1))
            {
                {
                    CASE |  case
                }

                ABSTRACT:
                {
                    CASE |  case
                }

                FINAL:
                {
                    CASE |  case
                }

                PRIVATE:
                {
                    CASE |  case
                }

                PROTECTED:
                {
                    CASE |  case
                }

                PUBLIC:
                {
                    CASE |  case
                }

                STATIC:
                {
                    CASE |  case
                }

                STRICTFP:
                {
                    CASE |  case
                }

                AT:
                    enterOuterAlt(_localctx, 1);
                {
                    setState(271);
                    classOrInterfaceModifier();
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                NATIVE:
                {
                    CASE |  case
                }

                SYNCHRONIZED:
                {
                    CASE |  case
                }

                TRANSIENT:
                {
                    CASE |  case
                }

                VOLATILE:
                    enterOuterAlt(_localctx, 2);
                {
                    setState(272);
                    _la = _input.LA(1);
                    if (
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

                    0x3f ) 
                    == 0 && ((1L << _la)
                    {
                        BITAND | &
                    }

                    ((1L << NATIVE)
                    {
                        BITOR ||
                    }

                    (1L << SYNCHRONIZED)
                    {
                        BITOR ||
                    }

                    (1L << TRANSIENT)
                    {
                        BITOR ||
                    }

                    (1L << VOLATILE) ) ) 
                    != 0 ) ) )
                    {
                        _errHandler.recoverInline(this);
                    }

                    consume();
                }

                {
                    BREAK | break
                }

                ;
                {
                    DEFAULT | default
                } : 

                throw new NoViableAltException(this);
            }
        }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(this, re);
        _errHandler.recover(this, re);
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        return _localctx;
    }

    publicstatic class ClassOrInterfaceModifierContext
{
    EXTENDS |extends
}

ParserRuleContext {
public AnnotationContextannotation()
{
    return getRuleContext(AnnotationContext.class ,  0 ) ;  }

publicClassOrInterfaceModifierContext(ParserRuleContext parent, int invokingState)
{
    {
        SUPER | super
    }

    (parent, invokingState);
} {

AT | @ }OverridepublicintgetRuleIndex()
{
    return RULE_classOrInterfaceModifier;
} {

AT | @ }Overridepublic void enterRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterClassOrInterfaceModifier(this);
} {

AT | @ }Overridepublic void exitRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitClassOrInterfaceModifier(this);
} {

AT | @ }Overridepublic<T> Taccept(ParseTreeVisitor<?
{
    EXTENDS | extends
}

T >visitor ) { if  (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) return  ( (JavaVisitor<?
 {
EXTENDS |extends }
T > )visitor ) .visitClassOrInterfaceModifier(this); else  return 
visitor.visitChildren (this )
    ;
} }
public {
FINAL |final }
ClassOrInterfaceModifierContextclassOrInterfaceModifier()
{
    ClassOrInterfaceModifierContext _localctx = new ClassOrInterfaceModifierContext(_ctx, getState());
    enterRule(_localctx, 10, RULE_classOrInterfaceModifier);
    int _la;
    try
    {
        setState(277);
        {
            SWITCH | switch
            }

            (_input.LA(1))
            {
                {
                    CASE |  case
                }

                AT:
                    enterOuterAlt(_localctx, 1);
                {
                    setState(275);
                    annotation();
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                ABSTRACT:
                {
                    CASE |  case
                }

                FINAL:
                {
                    CASE |  case
                }

                PRIVATE:
                {
                    CASE |  case
                }

                PROTECTED:
                {
                    CASE |  case
                }

                PUBLIC:
                {
                    CASE |  case
                }

                STATIC:
                {
                    CASE |  case
                }

                STRICTFP:
                    enterOuterAlt(_localctx, 2);
                {
                    setState(276);
                    _la = _input.LA(1);
                    if (
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

                    0x3f ) 
                    == 0 && ((1L << _la)
                    {
                        BITAND | &
                    }

                    ((1L << ABSTRACT)
                    {
                        BITOR ||
                    }

                    (1L << FINAL)
                    {
                        BITOR ||
                    }

                    (1L << PRIVATE)
                    {
                        BITOR ||
                    }

                    (1L << PROTECTED)
                    {
                        BITOR ||
                    }

                    (1L << PUBLIC)
                    {
                        BITOR ||
                    }

                    (1L << STATIC)
                    {
                        BITOR ||
                    }

                    (1L << STRICTFP) ) ) 
                    != 0 ) ) )
                    {
                        _errHandler.recoverInline(this);
                    }

                    consume();
                }

                {
                    BREAK | break
                }

                ;
                {
                    DEFAULT | default
                } : 

                throw new NoViableAltException(this);
            }
        }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(this, re);
        _errHandler.recover(this, re);
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        return _localctx;
    }

    publicstatic class VariableModifierContext
{
    EXTENDS |extends
}

ParserRuleContext {
public AnnotationContextannotation()
{
    return getRuleContext(AnnotationContext.class ,  0 ) ;  }

publicVariableModifierContext(ParserRuleContext parent, int invokingState)
{
    {
        SUPER | super
    }

    (parent, invokingState);
} {

AT | @ }OverridepublicintgetRuleIndex()
{
    return RULE_variableModifier;
} {

AT | @ }Overridepublic void enterRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterVariableModifier(this);
} {

AT | @ }Overridepublic void exitRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitVariableModifier(this);
} {

AT | @ }Overridepublic<T> Taccept(ParseTreeVisitor<?
{
    EXTENDS | extends
}

T >visitor ) { if  (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) return  ( (JavaVisitor<?
 {
EXTENDS |extends }
T > )visitor ) .visitVariableModifier(this); else  return 
visitor.visitChildren (this )
    ;
} }
public {
FINAL |final }
VariableModifierContextvariableModifier()
{
    VariableModifierContext _localctx = new VariableModifierContext(_ctx, getState());
    enterRule(_localctx, 12, RULE_variableModifier);
    try
    {
        setState(281);
        {
            SWITCH | switch
            }

            (_input.LA(1))
            {
                {
                    CASE |  case
                }

                FINAL:
                    enterOuterAlt(_localctx, 1);
                {
                    setState(279);
                    match(FINAL);
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                AT:
                    enterOuterAlt(_localctx, 2);
                {
                    setState(280);
                    annotation();
                }

                {
                    BREAK | break
                }

                ;
                {
                    DEFAULT | default
                } : 

                throw new NoViableAltException(this);
            }
        }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(this, re);
        _errHandler.recover(this, re);
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        return _localctx;
    }

    publicstatic class ClassDeclarationContext
{
    EXTENDS |extends
}

ParserRuleContext {
public TerminalNodeIdentifier()
{
    return getToken(JavaParser.Identifier, 0);
}

public ClassBodyContextclassBody()
{
    return getRuleContext(ClassBodyContext.class ,  0 ) ;  }

public TypeListContexttypeList()
{
    return getRuleContext(TypeListContext.class ,  0 ) ;  }

public TypeParametersContexttypeParameters()
{
    return getRuleContext(TypeParametersContext.class ,  0 ) ;  }

public TypeContexttype()
{
    return getRuleContext(TypeContext.class ,  0 ) ;  }

publicClassDeclarationContext(ParserRuleContext parent, int invokingState)
{
    {
        SUPER | super
    }

    (parent, invokingState);
} {

AT | @ }OverridepublicintgetRuleIndex()
{
    return RULE_classDeclaration;
} {

AT | @ }Overridepublic void enterRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterClassDeclaration(this);
} {

AT | @ }Overridepublic void exitRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitClassDeclaration(this);
} {

AT | @ }Overridepublic<T> Taccept(ParseTreeVisitor<?
{
    EXTENDS | extends
}

T >visitor ) { if  (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) return  ( (JavaVisitor<?
 {
EXTENDS |extends }
T > )visitor ) .visitClassDeclaration(this); else  return 
visitor.visitChildren (this )
    ;
} }
public {
FINAL |final }
ClassDeclarationContextclassDeclaration()
{
    ClassDeclarationContext _localctx = new ClassDeclarationContext(_ctx, getState());
    enterRule(_localctx, 14, RULE_classDeclaration);
    int _la;
    try
    {
        enterOuterAlt(_localctx, 1);
        {
            setState(283);
            match(CLASS);
            setState(284);
            match(Identifier);
            setState(286);
            _la = _input.LA(1);
            if (_la == LT)
            {
                {
                    setState(285);
                    typeParameters();
                }
            }

            setState(290);
            _la = _input.LA(1);
            if (_la == EXTENDS)
            {
                {
                    setState(288);
                    match(EXTENDS);
                    setState(289);
                    type();
                }
            }

            setState(294);
            _la = _input.LA(1);
            if (_la == IMPLEMENTS)
            {
                {
                    setState(292);
                    match(IMPLEMENTS);
                    setState(293);
                    typeList();
                }
            }

            setState(296);
            classBody();
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(this, re);
        _errHandler.recover(this, re);
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        return _localctx;
    }

    publicstatic class TypeParametersContext
{
    EXTENDS |extends
}

ParserRuleContext {
public List<TypeParameterContext> typeParameter()
{
    return getRuleContexts(TypeParameterContext.class ) ;  }

public TypeParameterContexttypeParameter(int i)
{
    return getRuleContext(TypeParameterContext.class , 

i ) ;  }publicTypeParametersContext(ParserRuleContext parent, int invokingState)
{
    {
        SUPER | super
    }

    (parent, invokingState);
} {

AT | @ }OverridepublicintgetRuleIndex()
{
    return RULE_typeParameters;
} {

AT | @ }Overridepublic void enterRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterTypeParameters(this);
} {

AT | @ }Overridepublic void exitRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitTypeParameters(this);
} {

AT | @ }Overridepublic<T> Taccept(ParseTreeVisitor<?
{
    EXTENDS | extends
}

T >visitor ) { if  (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) return  ( (JavaVisitor<?
 {
EXTENDS |extends }
T > )visitor ) .visitTypeParameters(this); else  return 
visitor.visitChildren (this )
    ;
} }
public {
FINAL |final }
TypeParametersContexttypeParameters()
{
    TypeParametersContext _localctx = new TypeParametersContext(_ctx, getState());
    enterRule(_localctx, 16, RULE_typeParameters);
    int _la;
    try
    {
        enterOuterAlt(_localctx, 1);
        {
            setState(298);
            match(LT);
            setState(299);
            typeParameter();
            setState(304);
            _errHandler.sync(this);
            _la = _input.LA(1);
            {
                WHILE | while
            }

            (_la == COMMA)
            {
                {
                    {
                        setState(300);
                        match(COMMA);
                        setState(301);
                        typeParameter();
                    }
                }

                setState(306);
                _errHandler.sync(this);
                _la = _input.LA(1);
            }

            setState(307);
            match(GT);
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(this, re);
        _errHandler.recover(this, re);
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        return _localctx;
    }

    publicstatic class TypeParameterContext
{
    EXTENDS |extends
}

ParserRuleContext {
public TerminalNodeIdentifier()
{
    return getToken(JavaParser.Identifier, 0);
}

public TypeBoundContexttypeBound()
{
    return getRuleContext(TypeBoundContext.class ,  0 ) ;  }

publicTypeParameterContext(ParserRuleContext parent, int invokingState)
{
    {
        SUPER | super
    }

    (parent, invokingState);
} {

AT | @ }OverridepublicintgetRuleIndex()
{
    return RULE_typeParameter;
} {

AT | @ }Overridepublic void enterRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterTypeParameter(this);
} {

AT | @ }Overridepublic void exitRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitTypeParameter(this);
} {

AT | @ }Overridepublic<T> Taccept(ParseTreeVisitor<?
{
    EXTENDS | extends
}

T >visitor ) { if  (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) return  ( (JavaVisitor<?
 {
EXTENDS |extends }
T > )visitor ) .visitTypeParameter(this); else  return 
visitor.visitChildren (this )
    ;
} }
public {
FINAL |final }
TypeParameterContexttypeParameter()
{
    TypeParameterContext _localctx = new TypeParameterContext(_ctx, getState());
    enterRule(_localctx, 18, RULE_typeParameter);
    int _la;
    try
    {
        enterOuterAlt(_localctx, 1);
        {
            setState(309);
            match(Identifier);
            setState(312);
            _la = _input.LA(1);
            if (_la == EXTENDS)
            {
                {
                    setState(310);
                    match(EXTENDS);
                    setState(311);
                    typeBound();
                }
            }
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(this, re);
        _errHandler.recover(this, re);
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        return _localctx;
    }

    publicstatic class TypeBoundContext
{
    EXTENDS |extends
}

ParserRuleContext {
public TypeContexttype(int i)
{
    return getRuleContext(TypeContext.class , 

i ) ;  }public List<TypeContext> type()
{
    return getRuleContexts(TypeContext.class ) ;  }

publicTypeBoundContext(ParserRuleContext parent, int invokingState)
{
    {
        SUPER | super
    }

    (parent, invokingState);
} {

AT | @ }OverridepublicintgetRuleIndex()
{
    return RULE_typeBound;
} {

AT | @ }Overridepublic void enterRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterTypeBound(this);
} {

AT | @ }Overridepublic void exitRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitTypeBound(this);
} {

AT | @ }Overridepublic<T> Taccept(ParseTreeVisitor<?
{
    EXTENDS | extends
}

T >visitor ) { if  (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) return  ( (JavaVisitor<?
 {
EXTENDS |extends }
T > )visitor ) .visitTypeBound(this); else  return 
visitor.visitChildren (this )
    ;
} }
public {
FINAL |final }
TypeBoundContexttypeBound()
{
    TypeBoundContext _localctx = new TypeBoundContext(_ctx, getState());
    enterRule(_localctx, 20, RULE_typeBound);
    int _la;
    try
    {
        enterOuterAlt(_localctx, 1);
        {
            setState(314);
            type();
            setState(319);
            _errHandler.sync(this);
            _la = _input.LA(1);
            {
                WHILE | while
            }

            (_la == BITAND)
            {
                {
                    {
                        setState(315);
                        match(BITAND);
                        setState(316);
                        type();
                    }
                }

                setState(321);
                _errHandler.sync(this);
                _la = _input.LA(1);
            }
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(this, re);
        _errHandler.recover(this, re);
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        return _localctx;
    }

    publicstatic class EnumDeclarationContext
{
    EXTENDS |extends
}

ParserRuleContext {
public EnumBodyDeclarationsContextenumBodyDeclarations()
{
    return getRuleContext(EnumBodyDeclarationsContext.class ,  0 ) ;  }

public TerminalNodeIdentifier()
{
    return getToken(JavaParser.Identifier, 0);
}

public TypeListContexttypeList()
{
    return getRuleContext(TypeListContext.class ,  0 ) ;  }

public TerminalNodeENUM()
{
    return getToken(JavaParser.ENUM, 0);
}

public EnumConstantsContextenumConstants()
{
    return getRuleContext(EnumConstantsContext.class ,  0 ) ;  }

publicEnumDeclarationContext(ParserRuleContext parent, int invokingState)
{
    {
        SUPER | super
    }

    (parent, invokingState);
} {

AT | @ }OverridepublicintgetRuleIndex()
{
    return RULE_enumDeclaration;
} {

AT | @ }Overridepublic void enterRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterEnumDeclaration(this);
} {

AT | @ }Overridepublic void exitRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitEnumDeclaration(this);
} {

AT | @ }Overridepublic<T> Taccept(ParseTreeVisitor<?
{
    EXTENDS | extends
}

T >visitor ) { if  (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) return  ( (JavaVisitor<?
 {
EXTENDS |extends }
T > )visitor ) .visitEnumDeclaration(this); else  return 
visitor.visitChildren (this )
    ;
} }
public {
FINAL |final }
EnumDeclarationContextenumDeclaration()
{
    EnumDeclarationContext _localctx = new EnumDeclarationContext(_ctx, getState());
    enterRule(_localctx, 22, RULE_enumDeclaration);
    int _la;
    try
    {
        enterOuterAlt(_localctx, 1);
        {
            setState(322);
            match(ENUM);
            setState(323);
            match(Identifier);
            setState(326);
            _la = _input.LA(1);
            if (_la == IMPLEMENTS)
            {
                {
                    setState(324);
                    match(IMPLEMENTS);
                    setState(325);
                    typeList();
                }
            }

            setState(328);
            match(LBRACE);
            setState(330);
            _la = _input.LA(1);
            if (_la == Identifier
            {
                OR || |
            }

            _la == AT )
            {
                {
                    setState(329);
                    enumConstants();
                }
            }

            setState(333);
            _la = _input.LA(1);
            if (_la == COMMA)
            {
                {
                    setState(332);
                    match(COMMA);
                }
            }

            setState(336);
            _la = _input.LA(1);
            if (_la == SEMI)
            {
                {
                    setState(335);
                    enumBodyDeclarations();
                }
            }

            setState(338);
            match(RBRACE);
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(this, re);
        _errHandler.recover(this, re);
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        return _localctx;
    }

    publicstatic class EnumConstantsContext
{
    EXTENDS |extends
}

ParserRuleContext {
public List<EnumConstantContext> enumConstant()
{
    return getRuleContexts(EnumConstantContext.class ) ;  }

public EnumConstantContextenumConstant(int i)
{
    return getRuleContext(EnumConstantContext.class , 

i ) ;  }publicEnumConstantsContext(ParserRuleContext parent, int invokingState)
{
    {
        SUPER | super
    }

    (parent, invokingState);
} {

AT | @ }OverridepublicintgetRuleIndex()
{
    return RULE_enumConstants;
} {

AT | @ }Overridepublic void enterRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterEnumConstants(this);
} {

AT | @ }Overridepublic void exitRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitEnumConstants(this);
} {

AT | @ }Overridepublic<T> Taccept(ParseTreeVisitor<?
{
    EXTENDS | extends
}

T >visitor ) { if  (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) return  ( (JavaVisitor<?
 {
EXTENDS |extends }
T > )visitor ) .visitEnumConstants(this); else  return 
visitor.visitChildren (this )
    ;
} }
public {
FINAL |final }
EnumConstantsContextenumConstants()
{
    EnumConstantsContext _localctx = new EnumConstantsContext(_ctx, getState());
    enterRule(_localctx, 24, RULE_enumConstants);
    try
    {
        int _alt;
        enterOuterAlt(_localctx, 1);
        {
            setState(340);
            enumConstant();
            setState(345);
            _errHandler.sync(this);
            _alt = getInterpreter().adaptivePredict(_input, 24, _ctx);
            {
                WHILE | while
            }

            (_alt != 2 && _alt != org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER)
            {
                if (_alt == 1)
                {
                    {
                        {
                            setState(341);
                            match(COMMA);
                            setState(342);
                            enumConstant();
                        }
                    }
                }

                setState(347);
                _errHandler.sync(this);
                _alt = getInterpreter().adaptivePredict(_input, 24, _ctx);
            }
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(this, re);
        _errHandler.recover(this, re);
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        return _localctx;
    }

    publicstatic class EnumConstantContext
{
    EXTENDS |extends
}

ParserRuleContext {
public TerminalNodeIdentifier()
{
    return getToken(JavaParser.Identifier, 0);
}

public List<AnnotationContext> annotation()
{
    return getRuleContexts(AnnotationContext.class ) ;  }

public ClassBodyContextclassBody()
{
    return getRuleContext(ClassBodyContext.class ,  0 ) ;  }

public AnnotationContextannotation(int i)
{
    return getRuleContext(AnnotationContext.class , 

i ) ;  }public ArgumentsContextarguments()
{
    return getRuleContext(ArgumentsContext.class ,  0 ) ;  }

publicEnumConstantContext(ParserRuleContext parent, int invokingState)
{
    {
        SUPER | super
    }

    (parent, invokingState);
} {

AT | @ }OverridepublicintgetRuleIndex()
{
    return RULE_enumConstant;
} {

AT | @ }Overridepublic void enterRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterEnumConstant(this);
} {

AT | @ }Overridepublic void exitRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitEnumConstant(this);
} {

AT | @ }Overridepublic<T> Taccept(ParseTreeVisitor<?
{
    EXTENDS | extends
}

T >visitor ) { if  (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) return  ( (JavaVisitor<?
 {
EXTENDS |extends }
T > )visitor ) .visitEnumConstant(this); else  return 
visitor.visitChildren (this )
    ;
} }
public {
FINAL |final }
EnumConstantContextenumConstant()
{
    EnumConstantContext _localctx = new EnumConstantContext(_ctx, getState());
    enterRule(_localctx, 26, RULE_enumConstant);
    int _la;
    try
    {
        enterOuterAlt(_localctx, 1);
        {
            setState(351);
            _errHandler.sync(this);
            _la = _input.LA(1);
            {
                WHILE | while
            }

            (_la == AT)
            {
                {
                    {
                        setState(348);
                        annotation();
                    }
                }

                setState(353);
                _errHandler.sync(this);
                _la = _input.LA(1);
            }

            setState(354);
            match(Identifier);
            setState(356);
            _la = _input.LA(1);
            if (_la == LPAREN)
            {
                {
                    setState(355);
                    arguments();
                }
            }

            setState(359);
            _la = _input.LA(1);
            if (_la == LBRACE)
            {
                {
                    setState(358);
                    classBody();
                }
            }
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(this, re);
        _errHandler.recover(this, re);
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        return _localctx;
    }

    publicstatic class EnumBodyDeclarationsContext
{
    EXTENDS |extends
}

ParserRuleContext {
public List<ClassBodyDeclarationContext> classBodyDeclaration()
{
    return getRuleContexts(ClassBodyDeclarationContext.class ) ;  }

public ClassBodyDeclarationContextclassBodyDeclaration(int i)
{
    return getRuleContext(ClassBodyDeclarationContext.class , 

i ) ;  }publicEnumBodyDeclarationsContext(ParserRuleContext parent, int invokingState)
{
    {
        SUPER | super
    }

    (parent, invokingState);
} {

AT | @ }OverridepublicintgetRuleIndex()
{
    return RULE_enumBodyDeclarations;
} {

AT | @ }Overridepublic void enterRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterEnumBodyDeclarations(this);
} {

AT | @ }Overridepublic void exitRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitEnumBodyDeclarations(this);
} {

AT | @ }Overridepublic<T> Taccept(ParseTreeVisitor<?
{
    EXTENDS | extends
}

T >visitor ) { if  (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) return  ( (JavaVisitor<?
 {
EXTENDS |extends }
T > )visitor ) .visitEnumBodyDeclarations(this); else  return 
visitor.visitChildren (this )
    ;
} }
public {
FINAL |final }
EnumBodyDeclarationsContextenumBodyDeclarations()
{
    EnumBodyDeclarationsContext _localctx = new EnumBodyDeclarationsContext(_ctx, getState());
    enterRule(_localctx, 28, RULE_enumBodyDeclarations);
    int _la;
    try
    {
        enterOuterAlt(_localctx, 1);
        {
            setState(361);
            match(SEMI);
            setState(365);
            _errHandler.sync(this);
            _la = _input.LA(1);
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

            0x3f ) 
            == 0 && ((1L << _la)
            {
                BITAND | &
            }

            ((1L << ABSTRACT)
            {
                BITOR ||
            }

            (1L << BOOLEAN)
            {
                BITOR ||
            }

            (1L << BYTE)
            {
                BITOR ||
            }

            (1L << CHAR)
            {
                BITOR ||
            }

            (1L << CLASS)
            {
                BITOR ||
            }

            (1L << DOUBLE)
            {
                BITOR ||
            }

            (1L << ENUM)
            {
                BITOR ||
            }

            (1L << FINAL)
            {
                BITOR ||
            }

            (1L << FLOAT)
            {
                BITOR ||
            }

            (1L << INT)
            {
                BITOR ||
            }

            (1L << INTERFACE)
            {
                BITOR ||
            }

            (1L << LONG)
            {
                BITOR ||
            }

            (1L << NATIVE)
            {
                BITOR ||
            }

            (1L << PRIVATE)
            {
                BITOR ||
            }

            (1L << PROTECTED)
            {
                BITOR ||
            }

            (1L << PUBLIC)
            {
                BITOR ||
            }

            (1L << SHORT)
            {
                BITOR ||
            }

            (1L << STATIC)
            {
                BITOR ||
            }

            (1L << STRICTFP)
            {
                BITOR ||
            }

            (1L << SYNCHRONIZED)
            {
                BITOR ||
            }

            (1L << TRANSIENT)
            {
                BITOR ||
            }

            (1L << VOID)
            {
                BITOR ||
            }

            (1L << VOLATILE)
            {
                BITOR ||
            }

            (1L << LBRACE)
            {
                BITOR ||
            }

            (1L << SEMI) ) ) 
            != 0 )
            {
                OR || |
            }

            ((((_la - 68))
            {
                BITAND | &
            }

            {
                TILDE | ~
            }

            0x3f ) 
            == 0 && ((1L << (_la - 68))
            {
                BITAND | &
            }

            ((1L << (LT - 68))
            {
                BITOR ||
            }

            (1L << (Identifier - 68))
            {
                BITOR ||
            }

            (1L << (AT - 68)) ) ) 
            != 0 ) )
            {
                {
                    {
                        setState(362);
                        classBodyDeclaration();
                    }
                }

                setState(367);
                _errHandler.sync(this);
                _la = _input.LA(1);
            }
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(this, re);
        _errHandler.recover(this, re);
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        return _localctx;
    }

    publicstatic class InterfaceDeclarationContext
{
    EXTENDS |extends
}

ParserRuleContext {
public TerminalNodeIdentifier()
{
    return getToken(JavaParser.Identifier, 0);
}

public InterfaceBodyContextinterfaceBody()
{
    return getRuleContext(InterfaceBodyContext.class ,  0 ) ;  }

public TypeListContexttypeList()
{
    return getRuleContext(TypeListContext.class ,  0 ) ;  }

public TypeParametersContexttypeParameters()
{
    return getRuleContext(TypeParametersContext.class ,  0 ) ;  }

publicInterfaceDeclarationContext(ParserRuleContext parent, int invokingState)
{
    {
        SUPER | super
    }

    (parent, invokingState);
} {

AT | @ }OverridepublicintgetRuleIndex()
{
    return RULE_interfaceDeclaration;
} {

AT | @ }Overridepublic void enterRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterInterfaceDeclaration(this);
} {

AT | @ }Overridepublic void exitRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitInterfaceDeclaration(this);
} {

AT | @ }Overridepublic<T> Taccept(ParseTreeVisitor<?
{
    EXTENDS | extends
}

T >visitor ) { if  (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) return  ( (JavaVisitor<?
 {
EXTENDS |extends }
T > )visitor ) .visitInterfaceDeclaration(this); else  return 
visitor.visitChildren (this )
    ;
} }
public {
FINAL |final }
InterfaceDeclarationContextinterfaceDeclaration()
{
    InterfaceDeclarationContext _localctx = new InterfaceDeclarationContext(_ctx, getState());
    enterRule(_localctx, 30, RULE_interfaceDeclaration);
    int _la;
    try
    {
        enterOuterAlt(_localctx, 1);
        {
            setState(368);
            match(INTERFACE);
            setState(369);
            match(Identifier);
            setState(371);
            _la = _input.LA(1);
            if (_la == LT)
            {
                {
                    setState(370);
                    typeParameters();
                }
            }

            setState(375);
            _la = _input.LA(1);
            if (_la == EXTENDS)
            {
                {
                    setState(373);
                    match(EXTENDS);
                    setState(374);
                    typeList();
                }
            }

            setState(377);
            interfaceBody();
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(this, re);
        _errHandler.recover(this, re);
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        return _localctx;
    }

    publicstatic class TypeListContext
{
    EXTENDS |extends
}

ParserRuleContext {
public TypeContexttype(int i)
{
    return getRuleContext(TypeContext.class , 

i ) ;  }public List<TypeContext> type()
{
    return getRuleContexts(TypeContext.class ) ;  }

publicTypeListContext(ParserRuleContext parent, int invokingState)
{
    {
        SUPER | super
    }

    (parent, invokingState);
} {

AT | @ }OverridepublicintgetRuleIndex()
{
    return RULE_typeList;
} {

AT | @ }Overridepublic void enterRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterTypeList(this);
} {

AT | @ }Overridepublic void exitRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitTypeList(this);
} {

AT | @ }Overridepublic<T> Taccept(ParseTreeVisitor<?
{
    EXTENDS | extends
}

T >visitor ) { if  (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) return  ( (JavaVisitor<?
 {
EXTENDS |extends }
T > )visitor ) .visitTypeList(this); else  return 
visitor.visitChildren (this )
    ;
} }
public {
FINAL |final }
TypeListContexttypeList()
{
    TypeListContext _localctx = new TypeListContext(_ctx, getState());
    enterRule(_localctx, 32, RULE_typeList);
    int _la;
    try
    {
        enterOuterAlt(_localctx, 1);
        {
            setState(379);
            type();
            setState(384);
            _errHandler.sync(this);
            _la = _input.LA(1);
            {
                WHILE | while
            }

            (_la == COMMA)
            {
                {
                    {
                        setState(380);
                        match(COMMA);
                        setState(381);
                        type();
                    }
                }

                setState(386);
                _errHandler.sync(this);
                _la = _input.LA(1);
            }
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(this, re);
        _errHandler.recover(this, re);
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        return _localctx;
    }

    publicstatic class ClassBodyContext
{
    EXTENDS |extends
}

ParserRuleContext {
public List<ClassBodyDeclarationContext> classBodyDeclaration()
{
    return getRuleContexts(ClassBodyDeclarationContext.class ) ;  }

public ClassBodyDeclarationContextclassBodyDeclaration(int i)
{
    return getRuleContext(ClassBodyDeclarationContext.class , 

i ) ;  }publicClassBodyContext(ParserRuleContext parent, int invokingState)
{
    {
        SUPER | super
    }

    (parent, invokingState);
} {

AT | @ }OverridepublicintgetRuleIndex()
{
    return RULE_classBody;
} {

AT | @ }Overridepublic void enterRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterClassBody(this);
} {

AT | @ }Overridepublic void exitRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitClassBody(this);
} {

AT | @ }Overridepublic<T> Taccept(ParseTreeVisitor<?
{
    EXTENDS | extends
}

T >visitor ) { if  (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) return  ( (JavaVisitor<?
 {
EXTENDS |extends }
T > )visitor ) .visitClassBody(this); else  return 
visitor.visitChildren (this )
    ;
} }
public {
FINAL |final }
ClassBodyContextclassBody()
{
    ClassBodyContext _localctx = new ClassBodyContext(_ctx, getState());
    enterRule(_localctx, 34, RULE_classBody);
    int _la;
    try
    {
        enterOuterAlt(_localctx, 1);
        {
            setState(387);
            match(LBRACE);
            setState(391);
            _errHandler.sync(this);
            _la = _input.LA(1);
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

            0x3f ) 
            == 0 && ((1L << _la)
            {
                BITAND | &
            }

            ((1L << ABSTRACT)
            {
                BITOR ||
            }

            (1L << BOOLEAN)
            {
                BITOR ||
            }

            (1L << BYTE)
            {
                BITOR ||
            }

            (1L << CHAR)
            {
                BITOR ||
            }

            (1L << CLASS)
            {
                BITOR ||
            }

            (1L << DOUBLE)
            {
                BITOR ||
            }

            (1L << ENUM)
            {
                BITOR ||
            }

            (1L << FINAL)
            {
                BITOR ||
            }

            (1L << FLOAT)
            {
                BITOR ||
            }

            (1L << INT)
            {
                BITOR ||
            }

            (1L << INTERFACE)
            {
                BITOR ||
            }

            (1L << LONG)
            {
                BITOR ||
            }

            (1L << NATIVE)
            {
                BITOR ||
            }

            (1L << PRIVATE)
            {
                BITOR ||
            }

            (1L << PROTECTED)
            {
                BITOR ||
            }

            (1L << PUBLIC)
            {
                BITOR ||
            }

            (1L << SHORT)
            {
                BITOR ||
            }

            (1L << STATIC)
            {
                BITOR ||
            }

            (1L << STRICTFP)
            {
                BITOR ||
            }

            (1L << SYNCHRONIZED)
            {
                BITOR ||
            }

            (1L << TRANSIENT)
            {
                BITOR ||
            }

            (1L << VOID)
            {
                BITOR ||
            }

            (1L << VOLATILE)
            {
                BITOR ||
            }

            (1L << LBRACE)
            {
                BITOR ||
            }

            (1L << SEMI) ) ) 
            != 0 )
            {
                OR || |
            }

            ((((_la - 68))
            {
                BITAND | &
            }

            {
                TILDE | ~
            }

            0x3f ) 
            == 0 && ((1L << (_la - 68))
            {
                BITAND | &
            }

            ((1L << (LT - 68))
            {
                BITOR ||
            }

            (1L << (Identifier - 68))
            {
                BITOR ||
            }

            (1L << (AT - 68)) ) ) 
            != 0 ) )
            {
                {
                    {
                        setState(388);
                        classBodyDeclaration();
                    }
                }

                setState(393);
                _errHandler.sync(this);
                _la = _input.LA(1);
            }

            setState(394);
            match(RBRACE);
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(this, re);
        _errHandler.recover(this, re);
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        return _localctx;
    }

    publicstatic class InterfaceBodyContext
{
    EXTENDS |extends
}

ParserRuleContext {
public List<InterfaceBodyDeclarationContext> interfaceBodyDeclaration()
{
    return getRuleContexts(InterfaceBodyDeclarationContext.class ) ;  }

public InterfaceBodyDeclarationContextinterfaceBodyDeclaration(int i)
{
    return getRuleContext(InterfaceBodyDeclarationContext.class , 

i ) ;  }publicInterfaceBodyContext(ParserRuleContext parent, int invokingState)
{
    {
        SUPER | super
    }

    (parent, invokingState);
} {

AT | @ }OverridepublicintgetRuleIndex()
{
    return RULE_interfaceBody;
} {

AT | @ }Overridepublic void enterRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterInterfaceBody(this);
} {

AT | @ }Overridepublic void exitRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitInterfaceBody(this);
} {

AT | @ }Overridepublic<T> Taccept(ParseTreeVisitor<?
{
    EXTENDS | extends
}

T >visitor ) { if  (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) return  ( (JavaVisitor<?
 {
EXTENDS |extends }
T > )visitor ) .visitInterfaceBody(this); else  return 
visitor.visitChildren (this )
    ;
} }
public {
FINAL |final }
InterfaceBodyContextinterfaceBody()
{
    InterfaceBodyContext _localctx = new InterfaceBodyContext(_ctx, getState());
    enterRule(_localctx, 36, RULE_interfaceBody);
    int _la;
    try
    {
        enterOuterAlt(_localctx, 1);
        {
            setState(396);
            match(LBRACE);
            setState(400);
            _errHandler.sync(this);
            _la = _input.LA(1);
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

            0x3f ) 
            == 0 && ((1L << _la)
            {
                BITAND | &
            }

            ((1L << ABSTRACT)
            {
                BITOR ||
            }

            (1L << BOOLEAN)
            {
                BITOR ||
            }

            (1L << BYTE)
            {
                BITOR ||
            }

            (1L << CHAR)
            {
                BITOR ||
            }

            (1L << CLASS)
            {
                BITOR ||
            }

            (1L << DOUBLE)
            {
                BITOR ||
            }

            (1L << ENUM)
            {
                BITOR ||
            }

            (1L << FINAL)
            {
                BITOR ||
            }

            (1L << FLOAT)
            {
                BITOR ||
            }

            (1L << INT)
            {
                BITOR ||
            }

            (1L << INTERFACE)
            {
                BITOR ||
            }

            (1L << LONG)
            {
                BITOR ||
            }

            (1L << NATIVE)
            {
                BITOR ||
            }

            (1L << PRIVATE)
            {
                BITOR ||
            }

            (1L << PROTECTED)
            {
                BITOR ||
            }

            (1L << PUBLIC)
            {
                BITOR ||
            }

            (1L << SHORT)
            {
                BITOR ||
            }

            (1L << STATIC)
            {
                BITOR ||
            }

            (1L << STRICTFP)
            {
                BITOR ||
            }

            (1L << SYNCHRONIZED)
            {
                BITOR ||
            }

            (1L << TRANSIENT)
            {
                BITOR ||
            }

            (1L << VOID)
            {
                BITOR ||
            }

            (1L << VOLATILE)
            {
                BITOR ||
            }

            (1L << SEMI) ) ) 
            != 0 )
            {
                OR || |
            }

            ((((_la - 68))
            {
                BITAND | &
            }

            {
                TILDE | ~
            }

            0x3f ) 
            == 0 && ((1L << (_la - 68))
            {
                BITAND | &
            }

            ((1L << (LT - 68))
            {
                BITOR ||
            }

            (1L << (Identifier - 68))
            {
                BITOR ||
            }

            (1L << (AT - 68)) ) ) 
            != 0 ) )
            {
                {
                    {
                        setState(397);
                        interfaceBodyDeclaration();
                    }
                }

                setState(402);
                _errHandler.sync(this);
                _la = _input.LA(1);
            }

            setState(403);
            match(RBRACE);
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(this, re);
        _errHandler.recover(this, re);
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        return _localctx;
    }

    publicstatic class ClassBodyDeclarationContext
{
    EXTENDS |extends
}

ParserRuleContext {
public List<ModifierContext> modifier()
{
    return getRuleContexts(ModifierContext.class ) ;  }

public MemberDeclarationContextmemberDeclaration()
{
    return getRuleContext(MemberDeclarationContext.class ,  0 ) ;  }

public ModifierContextmodifier(int i)
{
    return getRuleContext(ModifierContext.class , 

i ) ;  }public BlockContextblock()
{
    return getRuleContext(BlockContext.class ,  0 ) ;  }

publicClassBodyDeclarationContext(ParserRuleContext parent, int invokingState)
{
    {
        SUPER | super
    }

    (parent, invokingState);
} {

AT | @ }OverridepublicintgetRuleIndex()
{
    return RULE_classBodyDeclaration;
} {

AT | @ }Overridepublic void enterRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterClassBodyDeclaration(this);
} {

AT | @ }Overridepublic void exitRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitClassBodyDeclaration(this);
} {

AT | @ }Overridepublic<T> Taccept(ParseTreeVisitor<?
{
    EXTENDS | extends
}

T >visitor ) { if  (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) return  ( (JavaVisitor<?
 {
EXTENDS |extends }
T > )visitor ) .visitClassBodyDeclaration(this); else  return 
visitor.visitChildren (this )
    ;
} }
public {
FINAL |final }
ClassBodyDeclarationContextclassBodyDeclaration()
{
    ClassBodyDeclarationContext _localctx = new ClassBodyDeclarationContext(_ctx, getState());
    enterRule(_localctx, 38, RULE_classBodyDeclaration);
    int _la;
    try
    {
        int _alt;
        setState(417);
        {
            SWITCH | switch
            }

            (getInterpreter().adaptivePredict(_input, 36, _ctx))
            {
                {
                    CASE |  case
                }

                1 : 
                enterOuterAlt(_localctx, 1);
                {
                    setState(405);
                    match(SEMI);
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                2 : 
                enterOuterAlt(_localctx, 2);
                {
                    setState(407);
                    _la = _input.LA(1);
                    if (_la == STATIC)
                    {
                        {
                            setState(406);
                            match(STATIC);
                        }
                    }

                    setState(409);
                    block();
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                3 : 
                enterOuterAlt(_localctx, 3);
                {
                    setState(413);
                    _errHandler.sync(this);
                    _alt = getInterpreter().adaptivePredict(_input, 35, _ctx);
                    {
                        WHILE | while
                    }

                    (_alt != 2 && _alt != org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER)
                    {
                        if (_alt == 1)
                        {
                            {
                                {
                                    setState(410);
                                    modifier();
                                }
                            }
                        }

                        setState(415);
                        _errHandler.sync(this);
                        _alt = getInterpreter().adaptivePredict(_input, 35, _ctx);
                    }

                    setState(416);
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
        _errHandler.reportError(this, re);
        _errHandler.recover(this, re);
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        return _localctx;
    }

    publicstatic class MemberDeclarationContext
{
    EXTENDS |extends
}

ParserRuleContext {
public GenericMethodDeclarationContextgenericMethodDeclaration()
{
    return getRuleContext(GenericMethodDeclarationContext.class ,  0 ) ;  }

public MethodDeclarationContextmethodDeclaration()
{
    return getRuleContext(MethodDeclarationContext.class ,  0 ) ;  }

public EnumDeclarationContextenumDeclaration()
{
    return getRuleContext(EnumDeclarationContext.class ,  0 ) ;  }

public ClassDeclarationContextclassDeclaration()
{
    return getRuleContext(ClassDeclarationContext.class ,  0 ) ;  }

public AnnotationTypeDeclarationContextannotationTypeDeclaration()
{
    return getRuleContext(AnnotationTypeDeclarationContext.class ,  0 ) ;  }

public GenericConstructorDeclarationContextgenericConstructorDeclaration()
{
    return getRuleContext(GenericConstructorDeclarationContext.class ,  0 ) ;  }

public InterfaceDeclarationContextinterfaceDeclaration()
{
    return getRuleContext(InterfaceDeclarationContext.class ,  0 ) ;  }

public ConstructorDeclarationContextconstructorDeclaration()
{
    return getRuleContext(ConstructorDeclarationContext.class ,  0 ) ;  }

public FieldDeclarationContextfieldDeclaration()
{
    return getRuleContext(FieldDeclarationContext.class ,  0 ) ;  }

publicMemberDeclarationContext(ParserRuleContext parent, int invokingState)
{
    {
        SUPER | super
    }

    (parent, invokingState);
} {

AT | @ }OverridepublicintgetRuleIndex()
{
    return RULE_memberDeclaration;
} {

AT | @ }Overridepublic void enterRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterMemberDeclaration(this);
} {

AT | @ }Overridepublic void exitRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitMemberDeclaration(this);
} {

AT | @ }Overridepublic<T> Taccept(ParseTreeVisitor<?
{
    EXTENDS | extends
}

T >visitor ) { if  (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) return  ( (JavaVisitor<?
 {
EXTENDS |extends }
T > )visitor ) .visitMemberDeclaration(this); else  return 
visitor.visitChildren (this )
    ;
} }
public {
FINAL |final }
MemberDeclarationContextmemberDeclaration()
{
    MemberDeclarationContext _localctx = new MemberDeclarationContext(_ctx, getState());
    enterRule(_localctx, 40, RULE_memberDeclaration);
    try
    {
        setState(428);
        {
            SWITCH | switch
            }

            (getInterpreter().adaptivePredict(_input, 37, _ctx))
            {
                {
                    CASE |  case
                }

                1 : 
                enterOuterAlt(_localctx, 1);
                {
                    setState(419);
                    methodDeclaration();
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                2 : 
                enterOuterAlt(_localctx, 2);
                {
                    setState(420);
                    genericMethodDeclaration();
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                3 : 
                enterOuterAlt(_localctx, 3);
                {
                    setState(421);
                    fieldDeclaration();
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                4 : 
                enterOuterAlt(_localctx, 4);
                {
                    setState(422);
                    constructorDeclaration();
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                5 : 
                enterOuterAlt(_localctx, 5);
                {
                    setState(423);
                    genericConstructorDeclaration();
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                6 : 
                enterOuterAlt(_localctx, 6);
                {
                    setState(424);
                    interfaceDeclaration();
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                7 : 
                enterOuterAlt(_localctx, 7);
                {
                    setState(425);
                    annotationTypeDeclaration();
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                8 : 
                enterOuterAlt(_localctx, 8);
                {
                    setState(426);
                    classDeclaration();
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                9 : 
                enterOuterAlt(_localctx, 9);
                {
                    setState(427);
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
        _errHandler.reportError(this, re);
        _errHandler.recover(this, re);
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        return _localctx;
    }

    publicstatic class MethodDeclarationContext
{
    EXTENDS |extends
}

ParserRuleContext {
public TerminalNodeIdentifier()
{
    return getToken(JavaParser.Identifier, 0);
}

public MethodBodyContextmethodBody()
{
    return getRuleContext(MethodBodyContext.class ,  0 ) ;  }

public QualifiedNameListContextqualifiedNameList()
{
    return getRuleContext(QualifiedNameListContext.class ,  0 ) ;  }

public FormalParametersContextformalParameters()
{
    return getRuleContext(FormalParametersContext.class ,  0 ) ;  }

public TypeContexttype()
{
    return getRuleContext(TypeContext.class ,  0 ) ;  }

publicMethodDeclarationContext(ParserRuleContext parent, int invokingState)
{
    {
        SUPER | super
    }

    (parent, invokingState);
} {

AT | @ }OverridepublicintgetRuleIndex()
{
    return RULE_methodDeclaration;
} {

AT | @ }Overridepublic void enterRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterMethodDeclaration(this);
} {

AT | @ }Overridepublic void exitRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitMethodDeclaration(this);
} {

AT | @ }Overridepublic<T> Taccept(ParseTreeVisitor<?
{
    EXTENDS | extends
}

T >visitor ) { if  (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) return  ( (JavaVisitor<?
 {
EXTENDS |extends }
T > )visitor ) .visitMethodDeclaration(this); else  return 
visitor.visitChildren (this )
    ;
} }
public {
FINAL |final }
MethodDeclarationContextmethodDeclaration()
{
    MethodDeclarationContext _localctx = new MethodDeclarationContext(_ctx, getState());
    enterRule(_localctx, 42, RULE_methodDeclaration);
    int _la;
    try
    {
        enterOuterAlt(_localctx, 1);
        {
            setState(432);
            {
                SWITCH | switch
                }

                (_input.LA(1))
                {
                    {
                        CASE |  case
                    }

                    BOOLEAN:
                    {
                        CASE |  case
                    }

                    BYTE:
                    {
                        CASE |  case
                    }

                    CHAR:
                    {
                        CASE |  case
                    }

                    DOUBLE:
                    {
                        CASE |  case
                    }

                    FLOAT:
                    {
                        CASE |  case
                    }

                    INT:
                    {
                        CASE |  case
                    }

                    LONG:
                    {
                        CASE |  case
                    }

                    SHORT:
                    {
                        CASE |  case
                    }

                    Identifier:
                    {
                        setState(430);
                        type();
                    }

                    {
                        BREAK | break
                    }

                    ;
                    {
                        CASE |  case
                    }

                    VOID:
                    {
                        setState(431);
                        match(VOID);
                    }

                    {
                        BREAK | break
                    }

                    ;
                    {
                        DEFAULT | default
                    } : 

                    throw new NoViableAltException(this);
                }

                setState(434);
                match(Identifier);
                setState(435);
                formalParameters();
                setState(440);
                _errHandler.sync(this);
                _la = _input.LA(1);
                {
                    WHILE | while
                }

                (_la == LBRACK)
                {
                    {
                        {
                            setState(436);
                            match(LBRACK);
                            setState(437);
                            match(RBRACK);
                        }
                    }

                    setState(442);
                    _errHandler.sync(this);
                    _la = _input.LA(1);
                }

                setState(445);
                _la = _input.LA(1);
                if (_la == THROWS)
                {
                    {
                        setState(443);
                        match(THROWS);
                        setState(444);
                        qualifiedNameList();
                    }
                }

                setState(449);
                {
                    SWITCH | switch
                    }

                    (_input.LA(1))
                    {
                        {
                            CASE |  case
                        }

                        LBRACE:
                        {
                            setState(447);
                            methodBody();
                        }

                        {
                            BREAK | break
                        }

                        ;
                        {
                            CASE |  case
                        }

                        SEMI:
                        {
                            setState(448);
                            match(SEMI);
                        }

                        {
                            BREAK | break
                        }

                        ;
                        {
                            DEFAULT | default
                        } : 

                        throw new NoViableAltException(this);
                    }
                }
            }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(this, re);
        _errHandler.recover(this, re);
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        return _localctx;
    }

    publicstatic class GenericMethodDeclarationContext
{
    EXTENDS |extends
}

ParserRuleContext {
public MethodDeclarationContextmethodDeclaration()
{
    return getRuleContext(MethodDeclarationContext.class ,  0 ) ;  }

public TypeParametersContexttypeParameters()
{
    return getRuleContext(TypeParametersContext.class ,  0 ) ;  }

publicGenericMethodDeclarationContext(ParserRuleContext parent, int invokingState)
{
    {
        SUPER | super
    }

    (parent, invokingState);
} {

AT | @ }OverridepublicintgetRuleIndex()
{
    return RULE_genericMethodDeclaration;
} {

AT | @ }Overridepublic void enterRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterGenericMethodDeclaration(this);
} {

AT | @ }Overridepublic void exitRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitGenericMethodDeclaration(this);
} {

AT | @ }Overridepublic<T> Taccept(ParseTreeVisitor<?
{
    EXTENDS | extends
}

T >visitor ) { if  (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) return  ( (JavaVisitor<?
 {
EXTENDS |extends }
T > )visitor ) .visitGenericMethodDeclaration(this); else  return 
visitor.visitChildren (this )
    ;
} }
public {
FINAL |final }
GenericMethodDeclarationContextgenericMethodDeclaration()
{
    GenericMethodDeclarationContext _localctx = new GenericMethodDeclarationContext(_ctx, getState());
    enterRule(_localctx, 44, RULE_genericMethodDeclaration);
    try
    {
        enterOuterAlt(_localctx, 1);
        {
            setState(451);
            typeParameters();
            setState(452);
            methodDeclaration();
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(this, re);
        _errHandler.recover(this, re);
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        return _localctx;
    }

    publicstatic class ConstructorDeclarationContext
{
    EXTENDS |extends
}

ParserRuleContext {
public TerminalNodeIdentifier()
{
    return getToken(JavaParser.Identifier, 0);
}

public ConstructorBodyContextconstructorBody()
{
    return getRuleContext(ConstructorBodyContext.class ,  0 ) ;  }

public QualifiedNameListContextqualifiedNameList()
{
    return getRuleContext(QualifiedNameListContext.class ,  0 ) ;  }

public FormalParametersContextformalParameters()
{
    return getRuleContext(FormalParametersContext.class ,  0 ) ;  }

publicConstructorDeclarationContext(ParserRuleContext parent, int invokingState)
{
    {
        SUPER | super
    }

    (parent, invokingState);
} {

AT | @ }OverridepublicintgetRuleIndex()
{
    return RULE_constructorDeclaration;
} {

AT | @ }Overridepublic void enterRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterConstructorDeclaration(this);
} {

AT | @ }Overridepublic void exitRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitConstructorDeclaration(this);
} {

AT | @ }Overridepublic<T> Taccept(ParseTreeVisitor<?
{
    EXTENDS | extends
}

T >visitor ) { if  (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) return  ( (JavaVisitor<?
 {
EXTENDS |extends }
T > )visitor ) .visitConstructorDeclaration(this); else  return 
visitor.visitChildren (this )
    ;
} }
public {
FINAL |final }
ConstructorDeclarationContextconstructorDeclaration()
{
    ConstructorDeclarationContext _localctx = new ConstructorDeclarationContext(_ctx, getState());
    enterRule(_localctx, 46, RULE_constructorDeclaration);
    int _la;
    try
    {
        enterOuterAlt(_localctx, 1);
        {
            setState(454);
            match(Identifier);
            setState(455);
            formalParameters();
            setState(458);
            _la = _input.LA(1);
            if (_la == THROWS)
            {
                {
                    setState(456);
                    match(THROWS);
                    setState(457);
                    qualifiedNameList();
                }
            }

            setState(460);
            constructorBody();
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(this, re);
        _errHandler.recover(this, re);
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        return _localctx;
    }

    publicstatic class GenericConstructorDeclarationContext
{
    EXTENDS |extends
}

ParserRuleContext {
public TypeParametersContexttypeParameters()
{
    return getRuleContext(TypeParametersContext.class ,  0 ) ;  }

public ConstructorDeclarationContextconstructorDeclaration()
{
    return getRuleContext(ConstructorDeclarationContext.class ,  0 ) ;  }

publicGenericConstructorDeclarationContext(ParserRuleContext parent, int invokingState)
{
    {
        SUPER | super
    }

    (parent, invokingState);
} {

AT | @ }OverridepublicintgetRuleIndex()
{
    return RULE_genericConstructorDeclaration;
} {

AT | @ }Overridepublic void enterRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterGenericConstructorDeclaration(this);
} {

AT | @ }Overridepublic void exitRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitGenericConstructorDeclaration(this);
} {

AT | @ }Overridepublic<T> Taccept(ParseTreeVisitor<?
{
    EXTENDS | extends
}

T >visitor ) { if  (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) return  ( (JavaVisitor<?
 {
EXTENDS |extends }
T > )visitor ) .visitGenericConstructorDeclaration(this); else  return 
visitor.visitChildren (this )
    ;
} }
public {
FINAL |final }
GenericConstructorDeclarationContextgenericConstructorDeclaration()
{
    GenericConstructorDeclarationContext _localctx = new GenericConstructorDeclarationContext(_ctx, getState());
    enterRule(_localctx, 48, RULE_genericConstructorDeclaration);
    try
    {
        enterOuterAlt(_localctx, 1);
        {
            setState(462);
            typeParameters();
            setState(463);
            constructorDeclaration();
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(this, re);
        _errHandler.recover(this, re);
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        return _localctx;
    }

    publicstatic class FieldDeclarationContext
{
    EXTENDS |extends
}

ParserRuleContext {
public VariableDeclaratorsContextvariableDeclarators()
{
    return getRuleContext(VariableDeclaratorsContext.class ,  0 ) ;  }

public TypeContexttype()
{
    return getRuleContext(TypeContext.class ,  0 ) ;  }

publicFieldDeclarationContext(ParserRuleContext parent, int invokingState)
{
    {
        SUPER | super
    }

    (parent, invokingState);
} {

AT | @ }OverridepublicintgetRuleIndex()
{
    return RULE_fieldDeclaration;
} {

AT | @ }Overridepublic void enterRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterFieldDeclaration(this);
} {

AT | @ }Overridepublic void exitRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitFieldDeclaration(this);
} {

AT | @ }Overridepublic<T> Taccept(ParseTreeVisitor<?
{
    EXTENDS | extends
}

T >visitor ) { if  (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) return  ( (JavaVisitor<?
 {
EXTENDS |extends }
T > )visitor ) .visitFieldDeclaration(this); else  return 
visitor.visitChildren (this )
    ;
} }
public {
FINAL |final }
FieldDeclarationContextfieldDeclaration()
{
    FieldDeclarationContext _localctx = new FieldDeclarationContext(_ctx, getState());
    enterRule(_localctx, 50, RULE_fieldDeclaration);
    try
    {
        enterOuterAlt(_localctx, 1);
        {
            setState(465);
            type();
            setState(466);
            variableDeclarators();
            setState(467);
            match(SEMI);
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(this, re);
        _errHandler.recover(this, re);
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        return _localctx;
    }

    publicstatic class InterfaceBodyDeclarationContext
{
    EXTENDS |extends
}

ParserRuleContext {
public List<ModifierContext> modifier()
{
    return getRuleContexts(ModifierContext.class ) ;  }

public ModifierContextmodifier(int i)
{
    return getRuleContext(ModifierContext.class , 

i ) ;  }public InterfaceMemberDeclarationContextinterfaceMemberDeclaration()
{
    return getRuleContext(InterfaceMemberDeclarationContext.class ,  0 ) ;  }

publicInterfaceBodyDeclarationContext(ParserRuleContext parent, int invokingState)
{
    {
        SUPER | super
    }

    (parent, invokingState);
} {

AT | @ }OverridepublicintgetRuleIndex()
{
    return RULE_interfaceBodyDeclaration;
} {

AT | @ }Overridepublic void enterRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterInterfaceBodyDeclaration(this);
} {

AT | @ }Overridepublic void exitRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitInterfaceBodyDeclaration(this);
} {

AT | @ }Overridepublic<T> Taccept(ParseTreeVisitor<?
{
    EXTENDS | extends
}

T >visitor ) { if  (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) return  ( (JavaVisitor<?
 {
EXTENDS |extends }
T > )visitor ) .visitInterfaceBodyDeclaration(this); else  return 
visitor.visitChildren (this )
    ;
} }
public {
FINAL |final }
InterfaceBodyDeclarationContextinterfaceBodyDeclaration()
{
    InterfaceBodyDeclarationContext _localctx = new InterfaceBodyDeclarationContext(_ctx, getState());
    enterRule(_localctx, 52, RULE_interfaceBodyDeclaration);
    try
    {
        int _alt;
        setState(477);
        {
            SWITCH | switch
            }

            (_input.LA(1))
            {
                {
                    CASE |  case
                }

                ABSTRACT:
                {
                    CASE |  case
                }

                BOOLEAN:
                {
                    CASE |  case
                }

                BYTE:
                {
                    CASE |  case
                }

                CHAR:
                {
                    CASE |  case
                }

                CLASS:
                {
                    CASE |  case
                }

                DOUBLE:
                {
                    CASE |  case
                }

                ENUM:
                {
                    CASE |  case
                }

                FINAL:
                {
                    CASE |  case
                }

                FLOAT:
                {
                    CASE |  case
                }

                INT:
                {
                    CASE |  case
                }

                INTERFACE:
                {
                    CASE |  case
                }

                LONG:
                {
                    CASE |  case
                }

                NATIVE:
                {
                    CASE |  case
                }

                PRIVATE:
                {
                    CASE |  case
                }

                PROTECTED:
                {
                    CASE |  case
                }

                PUBLIC:
                {
                    CASE |  case
                }

                SHORT:
                {
                    CASE |  case
                }

                STATIC:
                {
                    CASE |  case
                }

                STRICTFP:
                {
                    CASE |  case
                }

                SYNCHRONIZED:
                {
                    CASE |  case
                }

                TRANSIENT:
                {
                    CASE |  case
                }

                VOID:
                {
                    CASE |  case
                }

                VOLATILE:
                {
                    CASE |  case
                }

                LT:
                {
                    CASE |  case
                }

                Identifier:
                {
                    CASE |  case
                }

                AT:
                    enterOuterAlt(_localctx, 1);
                {
                    setState(472);
                    _errHandler.sync(this);
                    _alt = getInterpreter().adaptivePredict(_input, 43, _ctx);
                    {
                        WHILE | while
                    }

                    (_alt != 2 && _alt != org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER)
                    {
                        if (_alt == 1)
                        {
                            {
                                {
                                    setState(469);
                                    modifier();
                                }
                            }
                        }

                        setState(474);
                        _errHandler.sync(this);
                        _alt = getInterpreter().adaptivePredict(_input, 43, _ctx);
                    }

                    setState(475);
                    interfaceMemberDeclaration();
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                SEMI:
                    enterOuterAlt(_localctx, 2);
                {
                    setState(476);
                    match(SEMI);
                }

                {
                    BREAK | break
                }

                ;
                {
                    DEFAULT | default
                } : 

                throw new NoViableAltException(this);
            }
        }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(this, re);
        _errHandler.recover(this, re);
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        return _localctx;
    }

    publicstatic class InterfaceMemberDeclarationContext
{
    EXTENDS |extends
}

ParserRuleContext {
public EnumDeclarationContextenumDeclaration()
{
    return getRuleContext(EnumDeclarationContext.class ,  0 ) ;  }

public ClassDeclarationContextclassDeclaration()
{
    return getRuleContext(ClassDeclarationContext.class ,  0 ) ;  }

public GenericInterfaceMethodDeclarationContextgenericInterfaceMethodDeclaration()
{
    return getRuleContext(GenericInterfaceMethodDeclarationContext.class ,  0 ) ;  }

public AnnotationTypeDeclarationContextannotationTypeDeclaration()
{
    return getRuleContext(AnnotationTypeDeclarationContext.class ,  0 ) ;  }

public InterfaceDeclarationContextinterfaceDeclaration()
{
    return getRuleContext(InterfaceDeclarationContext.class ,  0 ) ;  }

public ConstDeclarationContextconstDeclaration()
{
    return getRuleContext(ConstDeclarationContext.class ,  0 ) ;  }

public InterfaceMethodDeclarationContextinterfaceMethodDeclaration()
{
    return getRuleContext(InterfaceMethodDeclarationContext.class ,  0 ) ;  }

publicInterfaceMemberDeclarationContext(ParserRuleContext parent, int invokingState)
{
    {
        SUPER | super
    }

    (parent, invokingState);
} {

AT | @ }OverridepublicintgetRuleIndex()
{
    return RULE_interfaceMemberDeclaration;
} {

AT | @ }Overridepublic void enterRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterInterfaceMemberDeclaration(this);
} {

AT | @ }Overridepublic void exitRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitInterfaceMemberDeclaration(this);
} {

AT | @ }Overridepublic<T> Taccept(ParseTreeVisitor<?
{
    EXTENDS | extends
}

T >visitor ) { if  (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) return  ( (JavaVisitor<?
 {
EXTENDS |extends }
T > )visitor ) .visitInterfaceMemberDeclaration(this); else  return 
visitor.visitChildren (this )
    ;
} }
public {
FINAL |final }
InterfaceMemberDeclarationContextinterfaceMemberDeclaration()
{
    InterfaceMemberDeclarationContext _localctx = new InterfaceMemberDeclarationContext(_ctx, getState());
    enterRule(_localctx, 54, RULE_interfaceMemberDeclaration);
    try
    {
        setState(486);
        {
            SWITCH | switch
            }

            (getInterpreter().adaptivePredict(_input, 45, _ctx))
            {
                {
                    CASE |  case
                }

                1 : 
                enterOuterAlt(_localctx, 1);
                {
                    setState(479);
                    constDeclaration();
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                2 : 
                enterOuterAlt(_localctx, 2);
                {
                    setState(480);
                    interfaceMethodDeclaration();
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                3 : 
                enterOuterAlt(_localctx, 3);
                {
                    setState(481);
                    genericInterfaceMethodDeclaration();
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                4 : 
                enterOuterAlt(_localctx, 4);
                {
                    setState(482);
                    interfaceDeclaration();
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                5 : 
                enterOuterAlt(_localctx, 5);
                {
                    setState(483);
                    annotationTypeDeclaration();
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                6 : 
                enterOuterAlt(_localctx, 6);
                {
                    setState(484);
                    classDeclaration();
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                7 : 
                enterOuterAlt(_localctx, 7);
                {
                    setState(485);
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
        _errHandler.reportError(this, re);
        _errHandler.recover(this, re);
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        return _localctx;
    }

    publicstatic class ConstDeclarationContext
{
    EXTENDS |extends
}

ParserRuleContext {
public ConstantDeclaratorContextconstantDeclarator(int i)
{
    return getRuleContext(ConstantDeclaratorContext.class , 

i ) ;  }public List<ConstantDeclaratorContext> constantDeclarator()
{
    return getRuleContexts(ConstantDeclaratorContext.class ) ;  }

public TypeContexttype()
{
    return getRuleContext(TypeContext.class ,  0 ) ;  }

publicConstDeclarationContext(ParserRuleContext parent, int invokingState)
{
    {
        SUPER | super
    }

    (parent, invokingState);
} {

AT | @ }OverridepublicintgetRuleIndex()
{
    return RULE_constDeclaration;
} {

AT | @ }Overridepublic void enterRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterConstDeclaration(this);
} {

AT | @ }Overridepublic void exitRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitConstDeclaration(this);
} {

AT | @ }Overridepublic<T> Taccept(ParseTreeVisitor<?
{
    EXTENDS | extends
}

T >visitor ) { if  (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) return  ( (JavaVisitor<?
 {
EXTENDS |extends }
T > )visitor ) .visitConstDeclaration(this); else  return 
visitor.visitChildren (this )
    ;
} }
public {
FINAL |final }
ConstDeclarationContextconstDeclaration()
{
    ConstDeclarationContext _localctx = new ConstDeclarationContext(_ctx, getState());
    enterRule(_localctx, 56, RULE_constDeclaration);
    int _la;
    try
    {
        enterOuterAlt(_localctx, 1);
        {
            setState(488);
            type();
            setState(489);
            constantDeclarator();
            setState(494);
            _errHandler.sync(this);
            _la = _input.LA(1);
            {
                WHILE | while
            }

            (_la == COMMA)
            {
                {
                    {
                        setState(490);
                        match(COMMA);
                        setState(491);
                        constantDeclarator();
                    }
                }

                setState(496);
                _errHandler.sync(this);
                _la = _input.LA(1);
            }

            setState(497);
            match(SEMI);
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(this, re);
        _errHandler.recover(this, re);
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        return _localctx;
    }

    publicstatic class ConstantDeclaratorContext
{
    EXTENDS |extends
}

ParserRuleContext {
public TerminalNodeIdentifier()
{
    return getToken(JavaParser.Identifier, 0);
}

public VariableInitializerContextvariableInitializer()
{
    return getRuleContext(VariableInitializerContext.class ,  0 ) ;  }

publicConstantDeclaratorContext(ParserRuleContext parent, int invokingState)
{
    {
        SUPER | super
    }

    (parent, invokingState);
} {

AT | @ }OverridepublicintgetRuleIndex()
{
    return RULE_constantDeclarator;
} {

AT | @ }Overridepublic void enterRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterConstantDeclarator(this);
} {

AT | @ }Overridepublic void exitRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitConstantDeclarator(this);
} {

AT | @ }Overridepublic<T> Taccept(ParseTreeVisitor<?
{
    EXTENDS | extends
}

T >visitor ) { if  (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) return  ( (JavaVisitor<?
 {
EXTENDS |extends }
T > )visitor ) .visitConstantDeclarator(this); else  return 
visitor.visitChildren (this )
    ;
} }
public {
FINAL |final }
ConstantDeclaratorContextconstantDeclarator()
{
    ConstantDeclaratorContext _localctx = new ConstantDeclaratorContext(_ctx, getState());
    enterRule(_localctx, 58, RULE_constantDeclarator);
    int _la;
    try
    {
        enterOuterAlt(_localctx, 1);
        {
            setState(499);
            match(Identifier);
            setState(504);
            _errHandler.sync(this);
            _la = _input.LA(1);
            {
                WHILE | while
            }

            (_la == LBRACK)
            {
                {
                    {
                        setState(500);
                        match(LBRACK);
                        setState(501);
                        match(RBRACK);
                    }
                }

                setState(506);
                _errHandler.sync(this);
                _la = _input.LA(1);
            }

            setState(507);
            match(ASSIGN);
            setState(508);
            variableInitializer();
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(this, re);
        _errHandler.recover(this, re);
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        return _localctx;
    }

    publicstatic class InterfaceMethodDeclarationContext
{
    EXTENDS |extends
}

ParserRuleContext {
public TerminalNodeIdentifier()
{
    return getToken(JavaParser.Identifier, 0);
}

public QualifiedNameListContextqualifiedNameList()
{
    return getRuleContext(QualifiedNameListContext.class ,  0 ) ;  }

public FormalParametersContextformalParameters()
{
    return getRuleContext(FormalParametersContext.class ,  0 ) ;  }

public TypeContexttype()
{
    return getRuleContext(TypeContext.class ,  0 ) ;  }

publicInterfaceMethodDeclarationContext(ParserRuleContext parent, int invokingState)
{
    {
        SUPER | super
    }

    (parent, invokingState);
} {

AT | @ }OverridepublicintgetRuleIndex()
{
    return RULE_interfaceMethodDeclaration;
} {

AT | @ }Overridepublic void enterRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterInterfaceMethodDeclaration(this);
} {

AT | @ }Overridepublic void exitRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitInterfaceMethodDeclaration(this);
} {

AT | @ }Overridepublic<T> Taccept(ParseTreeVisitor<?
{
    EXTENDS | extends
}

T >visitor ) { if  (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) return  ( (JavaVisitor<?
 {
EXTENDS |extends }
T > )visitor ) .visitInterfaceMethodDeclaration(this); else  return 
visitor.visitChildren (this )
    ;
} }
public {
FINAL |final }
InterfaceMethodDeclarationContextinterfaceMethodDeclaration()
{
    InterfaceMethodDeclarationContext _localctx = new InterfaceMethodDeclarationContext(_ctx, getState());
    enterRule(_localctx, 60, RULE_interfaceMethodDeclaration);
    int _la;
    try
    {
        enterOuterAlt(_localctx, 1);
        {
            setState(512);
            {
                SWITCH | switch
                }

                (_input.LA(1))
                {
                    {
                        CASE |  case
                    }

                    BOOLEAN:
                    {
                        CASE |  case
                    }

                    BYTE:
                    {
                        CASE |  case
                    }

                    CHAR:
                    {
                        CASE |  case
                    }

                    DOUBLE:
                    {
                        CASE |  case
                    }

                    FLOAT:
                    {
                        CASE |  case
                    }

                    INT:
                    {
                        CASE |  case
                    }

                    LONG:
                    {
                        CASE |  case
                    }

                    SHORT:
                    {
                        CASE |  case
                    }

                    Identifier:
                    {
                        setState(510);
                        type();
                    }

                    {
                        BREAK | break
                    }

                    ;
                    {
                        CASE |  case
                    }

                    VOID:
                    {
                        setState(511);
                        match(VOID);
                    }

                    {
                        BREAK | break
                    }

                    ;
                    {
                        DEFAULT | default
                    } : 

                    throw new NoViableAltException(this);
                }

                setState(514);
                match(Identifier);
                setState(515);
                formalParameters();
                setState(520);
                _errHandler.sync(this);
                _la = _input.LA(1);
                {
                    WHILE | while
                }

                (_la == LBRACK)
                {
                    {
                        {
                            setState(516);
                            match(LBRACK);
                            setState(517);
                            match(RBRACK);
                        }
                    }

                    setState(522);
                    _errHandler.sync(this);
                    _la = _input.LA(1);
                }

                setState(525);
                _la = _input.LA(1);
                if (_la == THROWS)
                {
                    {
                        setState(523);
                        match(THROWS);
                        setState(524);
                        qualifiedNameList();
                    }
                }

                setState(527);
                match(SEMI);
            }
        }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(this, re);
        _errHandler.recover(this, re);
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        return _localctx;
    }

    publicstatic class GenericInterfaceMethodDeclarationContext
{
    EXTENDS |extends
}

ParserRuleContext {
public TypeParametersContexttypeParameters()
{
    return getRuleContext(TypeParametersContext.class ,  0 ) ;  }

public InterfaceMethodDeclarationContextinterfaceMethodDeclaration()
{
    return getRuleContext(InterfaceMethodDeclarationContext.class ,  0 ) ;  }

publicGenericInterfaceMethodDeclarationContext(ParserRuleContext parent, int invokingState)
{
    {
        SUPER | super
    }

    (parent, invokingState);
} {

AT | @ }OverridepublicintgetRuleIndex()
{
    return RULE_genericInterfaceMethodDeclaration;
} {

AT | @ }Overridepublic void enterRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterGenericInterfaceMethodDeclaration(this);
} {

AT | @ }Overridepublic void exitRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitGenericInterfaceMethodDeclaration(this);
} {

AT | @ }Overridepublic<T> Taccept(ParseTreeVisitor<?
{
    EXTENDS | extends
}

T >visitor ) { if  (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) return  ( (JavaVisitor<?
 {
EXTENDS |extends }
T > )visitor ) .visitGenericInterfaceMethodDeclaration(this); else  return 
visitor.visitChildren (this )
    ;
} }
public {
FINAL |final }
GenericInterfaceMethodDeclarationContextgenericInterfaceMethodDeclaration()
{
    GenericInterfaceMethodDeclarationContext _localctx = new GenericInterfaceMethodDeclarationContext(_ctx, getState());
    enterRule(_localctx, 62, RULE_genericInterfaceMethodDeclaration);
    try
    {
        enterOuterAlt(_localctx, 1);
        {
            setState(529);
            typeParameters();
            setState(530);
            interfaceMethodDeclaration();
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(this, re);
        _errHandler.recover(this, re);
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        return _localctx;
    }

    publicstatic class VariableDeclaratorsContext
{
    EXTENDS |extends
}

ParserRuleContext {
public List<VariableDeclaratorContext> variableDeclarator()
{
    return getRuleContexts(VariableDeclaratorContext.class ) ;  }

public VariableDeclaratorContextvariableDeclarator(int i)
{
    return getRuleContext(VariableDeclaratorContext.class , 

i ) ;  }publicVariableDeclaratorsContext(ParserRuleContext parent, int invokingState)
{
    {
        SUPER | super
    }

    (parent, invokingState);
} {

AT | @ }OverridepublicintgetRuleIndex()
{
    return RULE_variableDeclarators;
} {

AT | @ }Overridepublic void enterRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterVariableDeclarators(this);
} {

AT | @ }Overridepublic void exitRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitVariableDeclarators(this);
} {

AT | @ }Overridepublic<T> Taccept(ParseTreeVisitor<?
{
    EXTENDS | extends
}

T >visitor ) { if  (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) return  ( (JavaVisitor<?
 {
EXTENDS |extends }
T > )visitor ) .visitVariableDeclarators(this); else  return 
visitor.visitChildren (this )
    ;
} }
public {
FINAL |final }
VariableDeclaratorsContextvariableDeclarators()
{
    VariableDeclaratorsContext _localctx = new VariableDeclaratorsContext(_ctx, getState());
    enterRule(_localctx, 64, RULE_variableDeclarators);
    int _la;
    try
    {
        enterOuterAlt(_localctx, 1);
        {
            setState(532);
            variableDeclarator();
            setState(537);
            _errHandler.sync(this);
            _la = _input.LA(1);
            {
                WHILE | while
            }

            (_la == COMMA)
            {
                {
                    {
                        setState(533);
                        match(COMMA);
                        setState(534);
                        variableDeclarator();
                    }
                }

                setState(539);
                _errHandler.sync(this);
                _la = _input.LA(1);
            }
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(this, re);
        _errHandler.recover(this, re);
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        return _localctx;
    }

    publicstatic class VariableDeclaratorContext
{
    EXTENDS |extends
}

ParserRuleContext {
public VariableInitializerContextvariableInitializer()
{
    return getRuleContext(VariableInitializerContext.class ,  0 ) ;  }

public VariableDeclaratorIdContextvariableDeclaratorId()
{
    return getRuleContext(VariableDeclaratorIdContext.class ,  0 ) ;  }

publicVariableDeclaratorContext(ParserRuleContext parent, int invokingState)
{
    {
        SUPER | super
    }

    (parent, invokingState);
} {

AT | @ }OverridepublicintgetRuleIndex()
{
    return RULE_variableDeclarator;
} {

AT | @ }Overridepublic void enterRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterVariableDeclarator(this);
} {

AT | @ }Overridepublic void exitRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitVariableDeclarator(this);
} {

AT | @ }Overridepublic<T> Taccept(ParseTreeVisitor<?
{
    EXTENDS | extends
}

T >visitor ) { if  (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) return  ( (JavaVisitor<?
 {
EXTENDS |extends }
T > )visitor ) .visitVariableDeclarator(this); else  return 
visitor.visitChildren (this )
    ;
} }
public {
FINAL |final }
VariableDeclaratorContextvariableDeclarator()
{
    VariableDeclaratorContext _localctx = new VariableDeclaratorContext(_ctx, getState());
    enterRule(_localctx, 66, RULE_variableDeclarator);
    int _la;
    try
    {
        enterOuterAlt(_localctx, 1);
        {
            setState(540);
            variableDeclaratorId();
            setState(543);
            _la = _input.LA(1);
            if (_la == ASSIGN)
            {
                {
                    setState(541);
                    match(ASSIGN);
                    setState(542);
                    variableInitializer();
                }
            }
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(this, re);
        _errHandler.recover(this, re);
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        return _localctx;
    }

    publicstatic class VariableDeclaratorIdContext
{
    EXTENDS |extends
}

ParserRuleContext {
public TerminalNodeIdentifier()
{
    return getToken(JavaParser.Identifier, 0);
}

publicVariableDeclaratorIdContext(ParserRuleContext parent, int invokingState)
{
    {
        SUPER | super
    }

    (parent, invokingState);
} {

AT | @ }OverridepublicintgetRuleIndex()
{
    return RULE_variableDeclaratorId;
} {

AT | @ }Overridepublic void enterRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterVariableDeclaratorId(this);
} {

AT | @ }Overridepublic void exitRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitVariableDeclaratorId(this);
} {

AT | @ }Overridepublic<T> Taccept(ParseTreeVisitor<?
{
    EXTENDS | extends
}

T >visitor ) { if  (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) return  ( (JavaVisitor<?
 {
EXTENDS |extends }
T > )visitor ) .visitVariableDeclaratorId(this); else  return 
visitor.visitChildren (this )
    ;
} }
public {
FINAL |final }
VariableDeclaratorIdContextvariableDeclaratorId()
{
    VariableDeclaratorIdContext _localctx = new VariableDeclaratorIdContext(_ctx, getState());
    enterRule(_localctx, 68, RULE_variableDeclaratorId);
    int _la;
    try
    {
        enterOuterAlt(_localctx, 1);
        {
            setState(545);
            match(Identifier);
            setState(550);
            _errHandler.sync(this);
            _la = _input.LA(1);
            {
                WHILE | while
            }

            (_la == LBRACK)
            {
                {
                    {
                        setState(546);
                        match(LBRACK);
                        setState(547);
                        match(RBRACK);
                    }
                }

                setState(552);
                _errHandler.sync(this);
                _la = _input.LA(1);
            }
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(this, re);
        _errHandler.recover(this, re);
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        return _localctx;
    }

    publicstatic class VariableInitializerContext
{
    EXTENDS |extends
}

ParserRuleContext {
public ArrayInitializerContextarrayInitializer()
{
    return getRuleContext(ArrayInitializerContext.class ,  0 ) ;  }

public ExpressionContextexpression()
{
    return getRuleContext(ExpressionContext.class ,  0 ) ;  }

publicVariableInitializerContext(ParserRuleContext parent, int invokingState)
{
    {
        SUPER | super
    }

    (parent, invokingState);
} {

AT | @ }OverridepublicintgetRuleIndex()
{
    return RULE_variableInitializer;
} {

AT | @ }Overridepublic void enterRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterVariableInitializer(this);
} {

AT | @ }Overridepublic void exitRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitVariableInitializer(this);
} {

AT | @ }Overridepublic<T> Taccept(ParseTreeVisitor<?
{
    EXTENDS | extends
}

T >visitor ) { if  (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) return  ( (JavaVisitor<?
 {
EXTENDS |extends }
T > )visitor ) .visitVariableInitializer(this); else  return 
visitor.visitChildren (this )
    ;
} }
public {
FINAL |final }
VariableInitializerContextvariableInitializer()
{
    VariableInitializerContext _localctx = new VariableInitializerContext(_ctx, getState());
    enterRule(_localctx, 70, RULE_variableInitializer);
    try
    {
        setState(555);
        {
            SWITCH | switch
            }

            (_input.LA(1))
            {
                {
                    CASE |  case
                }

                LBRACE:
                    enterOuterAlt(_localctx, 1);
                {
                    setState(553);
                    arrayInitializer();
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                BOOLEAN:
                {
                    CASE |  case
                }

                BYTE:
                {
                    CASE |  case
                }

                CHAR:
                {
                    CASE |  case
                }

                DOUBLE:
                {
                    CASE |  case
                }

                FLOAT:
                {
                    CASE |  case
                }

                INT:
                {
                    CASE |  case
                }

                LONG:
                {
                    CASE |  case
                }

                NEW:
                {
                    CASE |  case
                }

                SHORT:
                {
                    CASE |  case
                }

                SUPER:
                {
                    CASE |  case
                }

                THIS:
                {
                    CASE |  case
                }

                VOID:
                {
                    CASE |  case
                }

                IntegerLiteral:
                {
                    CASE |  case
                }

                FloatingPointLiteral:
                {
                    CASE |  case
                }

                BooleanLiteral:
                {
                    CASE |  case
                }

                CharacterLiteral:
                {
                    CASE |  case
                }

                StringLiteral:
                {
                    CASE |  case
                }

                NullLiteral:
                {
                    CASE |  case
                }

                LPAREN:
                {
                    CASE |  case
                }

                LT:
                {
                    CASE |  case
                }

                BANG:
                {
                    CASE |  case
                }

                TILDE:
                {
                    CASE |  case
                }

                INC:
                {
                    CASE |  case
                }

                DEC:
                {
                    CASE |  case
                }

                ADD:
                {
                    CASE |  case
                }

                SUB:
                {
                    CASE |  case
                }

                Identifier:
                    enterOuterAlt(_localctx, 2);
                {
                    setState(554);
                    expression(0);
                }

                {
                    BREAK | break
                }

                ;
                {
                    DEFAULT | default
                } : 

                throw new NoViableAltException(this);
            }
        }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(this, re);
        _errHandler.recover(this, re);
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        return _localctx;
    }

    publicstatic class ArrayInitializerContext
{
    EXTENDS |extends
}

ParserRuleContext {
public List<VariableInitializerContext> variableInitializer()
{
    return getRuleContexts(VariableInitializerContext.class ) ;  }

public VariableInitializerContextvariableInitializer(int i)
{
    return getRuleContext(VariableInitializerContext.class , 

i ) ;  }publicArrayInitializerContext(ParserRuleContext parent, int invokingState)
{
    {
        SUPER | super
    }

    (parent, invokingState);
} {

AT | @ }OverridepublicintgetRuleIndex()
{
    return RULE_arrayInitializer;
} {

AT | @ }Overridepublic void enterRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterArrayInitializer(this);
} {

AT | @ }Overridepublic void exitRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitArrayInitializer(this);
} {

AT | @ }Overridepublic<T> Taccept(ParseTreeVisitor<?
{
    EXTENDS | extends
}

T >visitor ) { if  (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) return  ( (JavaVisitor<?
 {
EXTENDS |extends }
T > )visitor ) .visitArrayInitializer(this); else  return 
visitor.visitChildren (this )
    ;
} }
public {
FINAL |final }
ArrayInitializerContextarrayInitializer()
{
    ArrayInitializerContext _localctx = new ArrayInitializerContext(_ctx, getState());
    enterRule(_localctx, 72, RULE_arrayInitializer);
    int _la;
    try
    {
        int _alt;
        enterOuterAlt(_localctx, 1);
        {
            setState(557);
            match(LBRACE);
            setState(569);
            _la = _input.LA(1);
            if ((((_la)
            {
                BITAND | &
            }

            {
                TILDE | ~
            }

            0x3f ) 
            == 0 && ((1L << _la)
            {
                BITAND | &
            }

            ((1L << BOOLEAN)
            {
                BITOR ||
            }

            (1L << BYTE)
            {
                BITOR ||
            }

            (1L << CHAR)
            {
                BITOR ||
            }

            (1L << DOUBLE)
            {
                BITOR ||
            }

            (1L << FLOAT)
            {
                BITOR ||
            }

            (1L << INT)
            {
                BITOR ||
            }

            (1L << LONG)
            {
                BITOR ||
            }

            (1L << NEW)
            {
                BITOR ||
            }

            (1L << SHORT)
            {
                BITOR ||
            }

            (1L << SUPER)
            {
                BITOR ||
            }

            (1L << THIS)
            {
                BITOR ||
            }

            (1L << VOID)
            {
                BITOR ||
            }

            (1L << IntegerLiteral)
            {
                BITOR ||
            }

            (1L << FloatingPointLiteral)
            {
                BITOR ||
            }

            (1L << BooleanLiteral)
            {
                BITOR ||
            }

            (1L << CharacterLiteral)
            {
                BITOR ||
            }

            (1L << StringLiteral)
            {
                BITOR ||
            }

            (1L << NullLiteral)
            {
                BITOR ||
            }

            (1L << LPAREN)
            {
                BITOR ||
            }

            (1L << LBRACE) ) ) 
            != 0 )
            {
                OR || |
            }

            ((((_la - 68))
            {
                BITAND | &
            }

            {
                TILDE | ~
            }

            0x3f ) 
            == 0 && ((1L << (_la - 68))
            {
                BITAND | &
            }

            ((1L << (LT - 68))
            {
                BITOR ||
            }

            (1L << (BANG - 68))
            {
                BITOR ||
            }

            (1L << (TILDE - 68))
            {
                BITOR ||
            }

            (1L << (INC - 68))
            {
                BITOR ||
            }

            (1L << (DEC - 68))
            {
                BITOR ||
            }

            (1L << (ADD - 68))
            {
                BITOR ||
            }

            (1L << (SUB - 68))
            {
                BITOR ||
            }

            (1L << (Identifier - 68)) ) ) 
            != 0 ) )
            {
                {
                    setState(558);
                    variableInitializer();
                    setState(563);
                    _errHandler.sync(this);
                    _alt = getInterpreter().adaptivePredict(_input, 55, _ctx);
                    {
                        WHILE | while
                    }

                    (_alt != 2 && _alt != org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER)
                    {
                        if (_alt == 1)
                        {
                            {
                                {
                                    setState(559);
                                    match(COMMA);
                                    setState(560);
                                    variableInitializer();
                                }
                            }
                        }

                        setState(565);
                        _errHandler.sync(this);
                        _alt = getInterpreter().adaptivePredict(_input, 55, _ctx);
                    }

                    setState(567);
                    _la = _input.LA(1);
                    if (_la == COMMA)
                    {
                        {
                            setState(566);
                            match(COMMA);
                        }
                    }
                }
            }

            setState(571);
            match(RBRACE);
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(this, re);
        _errHandler.recover(this, re);
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        return _localctx;
    }

    publicstatic class EnumConstantNameContext
{
    EXTENDS |extends
}

ParserRuleContext {
public TerminalNodeIdentifier()
{
    return getToken(JavaParser.Identifier, 0);
}

publicEnumConstantNameContext(ParserRuleContext parent, int invokingState)
{
    {
        SUPER | super
    }

    (parent, invokingState);
} {

AT | @ }OverridepublicintgetRuleIndex()
{
    return RULE_enumConstantName;
} {

AT | @ }Overridepublic void enterRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterEnumConstantName(this);
} {

AT | @ }Overridepublic void exitRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitEnumConstantName(this);
} {

AT | @ }Overridepublic<T> Taccept(ParseTreeVisitor<?
{
    EXTENDS | extends
}

T >visitor ) { if  (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) return  ( (JavaVisitor<?
 {
EXTENDS |extends }
T > )visitor ) .visitEnumConstantName(this); else  return 
visitor.visitChildren (this )
    ;
} }
public {
FINAL |final }
EnumConstantNameContextenumConstantName()
{
    EnumConstantNameContext _localctx = new EnumConstantNameContext(_ctx, getState());
    enterRule(_localctx, 74, RULE_enumConstantName);
    try
    {
        enterOuterAlt(_localctx, 1);
        {
            setState(573);
            match(Identifier);
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(this, re);
        _errHandler.recover(this, re);
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        return _localctx;
    }

    publicstatic class TypeContext
{
    EXTENDS |extends
}

ParserRuleContext {
public PrimitiveTypeContextprimitiveType()
{
    return getRuleContext(PrimitiveTypeContext.class ,  0 ) ;  }

public ClassOrInterfaceTypeContextclassOrInterfaceType()
{
    return getRuleContext(ClassOrInterfaceTypeContext.class ,  0 ) ;  }

publicTypeContext(ParserRuleContext parent, int invokingState)
{
    {
        SUPER | super
    }

    (parent, invokingState);
} {

AT | @ }OverridepublicintgetRuleIndex()
{
    return RULE_type;
} {

AT | @ }Overridepublic void enterRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterType(this);
} {

AT | @ }Overridepublic void exitRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitType(this);
} {

AT | @ }Overridepublic<T> Taccept(ParseTreeVisitor<?
{
    EXTENDS | extends
}

T >visitor ) { if  (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) return  ( (JavaVisitor<?
 {
EXTENDS |extends }
T > )visitor ) .visitType(this); else  return 
visitor.visitChildren (this )
    ;
} }
public {
FINAL |final }
TypeContexttype()
{
    TypeContext _localctx = new TypeContext(_ctx, getState());
    enterRule(_localctx, 76, RULE_type);
    try
    {
        int _alt;
        setState(591);
        {
            SWITCH | switch
            }

            (_input.LA(1))
            {
                {
                    CASE |  case
                }

                Identifier:
                    enterOuterAlt(_localctx, 1);
                {
                    setState(575);
                    classOrInterfaceType();
                    setState(580);
                    _errHandler.sync(this);
                    _alt = getInterpreter().adaptivePredict(_input, 58, _ctx);
                    {
                        WHILE | while
                    }

                    (_alt != 2 && _alt != org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER)
                    {
                        if (_alt == 1)
                        {
                            {
                                {
                                    setState(576);
                                    match(LBRACK);
                                    setState(577);
                                    match(RBRACK);
                                }
                            }
                        }

                        setState(582);
                        _errHandler.sync(this);
                        _alt = getInterpreter().adaptivePredict(_input, 58, _ctx);
                    }
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                BOOLEAN:
                {
                    CASE |  case
                }

                BYTE:
                {
                    CASE |  case
                }

                CHAR:
                {
                    CASE |  case
                }

                DOUBLE:
                {
                    CASE |  case
                }

                FLOAT:
                {
                    CASE |  case
                }

                INT:
                {
                    CASE |  case
                }

                LONG:
                {
                    CASE |  case
                }

                SHORT:
                    enterOuterAlt(_localctx, 2);
                {
                    setState(583);
                    primitiveType();
                    setState(588);
                    _errHandler.sync(this);
                    _alt = getInterpreter().adaptivePredict(_input, 59, _ctx);
                    {
                        WHILE | while
                    }

                    (_alt != 2 && _alt != org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER)
                    {
                        if (_alt == 1)
                        {
                            {
                                {
                                    setState(584);
                                    match(LBRACK);
                                    setState(585);
                                    match(RBRACK);
                                }
                            }
                        }

                        setState(590);
                        _errHandler.sync(this);
                        _alt = getInterpreter().adaptivePredict(_input, 59, _ctx);
                    }
                }

                {
                    BREAK | break
                }

                ;
                {
                    DEFAULT | default
                } : 

                throw new NoViableAltException(this);
            }
        }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(this, re);
        _errHandler.recover(this, re);
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        return _localctx;
    }

    publicstatic class ClassOrInterfaceTypeContext
{
    EXTENDS |extends
}

ParserRuleContext {
public List<TypeArgumentsContext> typeArguments()
{
    return getRuleContexts(TypeArgumentsContext.class ) ;  }

public List<TerminalNode> Identifier()
{
    return getTokens(JavaParser.Identifier);
}

public TerminalNodeIdentifier(int i)
{
    return getToken(JavaParser.Identifier, i);
}

public TypeArgumentsContexttypeArguments(int i)
{
    return getRuleContext(TypeArgumentsContext.class , 

i ) ;  }publicClassOrInterfaceTypeContext(ParserRuleContext parent, int invokingState)
{
    {
        SUPER | super
    }

    (parent, invokingState);
} {

AT | @ }OverridepublicintgetRuleIndex()
{
    return RULE_classOrInterfaceType;
} {

AT | @ }Overridepublic void enterRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterClassOrInterfaceType(this);
} {

AT | @ }Overridepublic void exitRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitClassOrInterfaceType(this);
} {

AT | @ }Overridepublic<T> Taccept(ParseTreeVisitor<?
{
    EXTENDS | extends
}

T >visitor ) { if  (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) return  ( (JavaVisitor<?
 {
EXTENDS |extends }
T > )visitor ) .visitClassOrInterfaceType(this); else  return 
visitor.visitChildren (this )
    ;
} }
public {
FINAL |final }
ClassOrInterfaceTypeContextclassOrInterfaceType()
{
    ClassOrInterfaceTypeContext _localctx = new ClassOrInterfaceTypeContext(_ctx, getState());
    enterRule(_localctx, 78, RULE_classOrInterfaceType);
    try
    {
        int _alt;
        enterOuterAlt(_localctx, 1);
        {
            setState(593);
            match(Identifier);
            setState(595);
            {
                SWITCH | switch
                }

                (getInterpreter().adaptivePredict(_input, 61, _ctx))
                {
                    {
                        CASE |  case
                    }

                    1 : 
                    {
                        setState(594);
                        typeArguments();
                    }

                    {
                        BREAK | break
                    }

                    ;
                }

                setState(604);
                _errHandler.sync(this);
                _alt = getInterpreter().adaptivePredict(_input, 63, _ctx);
                {
                    WHILE | while
                }

                (_alt != 2 && _alt != org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER)
                {
                    if (_alt == 1)
                    {
                        {
                            {
                                setState(597);
                                match(DOT);
                                setState(598);
                                match(Identifier);
                                setState(600);
                                {
                                    SWITCH | switch
                                    }

                                    (getInterpreter().adaptivePredict(_input, 62, _ctx))
                                    {
                                        {
                                            CASE |  case
                                        }

                                        1 : 
                                        {
                                            setState(599);
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

                        setState(606);
                        _errHandler.sync(this);
                        _alt = getInterpreter().adaptivePredict(_input, 63, _ctx);
                    }
                }
            }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(this, re);
        _errHandler.recover(this, re);
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        return _localctx;
    }

    publicstatic class PrimitiveTypeContext
{
    EXTENDS |extends
}

ParserRuleContext {
publicPrimitiveTypeContext(ParserRuleContext parent, int invokingState)
{
    {
        SUPER | super
    }

    (parent, invokingState);
} {

AT | @ }OverridepublicintgetRuleIndex()
{
    return RULE_primitiveType;
} {

AT | @ }Overridepublic void enterRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterPrimitiveType(this);
} {

AT | @ }Overridepublic void exitRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitPrimitiveType(this);
} {

AT | @ }Overridepublic<T> Taccept(ParseTreeVisitor<?
{
    EXTENDS | extends
}

T >visitor ) { if  (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) return  ( (JavaVisitor<?
 {
EXTENDS |extends }
T > )visitor ) .visitPrimitiveType(this); else  return 
visitor.visitChildren (this )
    ;
} }
public {
FINAL |final }
PrimitiveTypeContextprimitiveType()
{
    PrimitiveTypeContext _localctx = new PrimitiveTypeContext(_ctx, getState());
    enterRule(_localctx, 80, RULE_primitiveType);
    int _la;
    try
    {
        enterOuterAlt(_localctx, 1);
        {
            setState(607);
            _la = _input.LA(1);
            if (
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

            0x3f ) 
            == 0 && ((1L << _la)
            {
                BITAND | &
            }

            ((1L << BOOLEAN)
            {
                BITOR ||
            }

            (1L << BYTE)
            {
                BITOR ||
            }

            (1L << CHAR)
            {
                BITOR ||
            }

            (1L << DOUBLE)
            {
                BITOR ||
            }

            (1L << FLOAT)
            {
                BITOR ||
            }

            (1L << INT)
            {
                BITOR ||
            }

            (1L << LONG)
            {
                BITOR ||
            }

            (1L << SHORT) ) ) 
            != 0 ) ) )
            {
                _errHandler.recoverInline(this);
            }

            consume();
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(this, re);
        _errHandler.recover(this, re);
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        return _localctx;
    }

    publicstatic class TypeArgumentsContext
{
    EXTENDS |extends
}

ParserRuleContext {
public List<TypeArgumentContext> typeArgument()
{
    return getRuleContexts(TypeArgumentContext.class ) ;  }

public TypeArgumentContexttypeArgument(int i)
{
    return getRuleContext(TypeArgumentContext.class , 

i ) ;  }publicTypeArgumentsContext(ParserRuleContext parent, int invokingState)
{
    {
        SUPER | super
    }

    (parent, invokingState);
} {

AT | @ }OverridepublicintgetRuleIndex()
{
    return RULE_typeArguments;
} {

AT | @ }Overridepublic void enterRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterTypeArguments(this);
} {

AT | @ }Overridepublic void exitRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitTypeArguments(this);
} {

AT | @ }Overridepublic<T> Taccept(ParseTreeVisitor<?
{
    EXTENDS | extends
}

T >visitor ) { if  (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) return  ( (JavaVisitor<?
 {
EXTENDS |extends }
T > )visitor ) .visitTypeArguments(this); else  return 
visitor.visitChildren (this )
    ;
} }
public {
FINAL |final }
TypeArgumentsContexttypeArguments()
{
    TypeArgumentsContext _localctx = new TypeArgumentsContext(_ctx, getState());
    enterRule(_localctx, 82, RULE_typeArguments);
    int _la;
    try
    {
        enterOuterAlt(_localctx, 1);
        {
            setState(609);
            match(LT);
            setState(610);
            typeArgument();
            setState(615);
            _errHandler.sync(this);
            _la = _input.LA(1);
            {
                WHILE | while
            }

            (_la == COMMA)
            {
                {
                    {
                        setState(611);
                        match(COMMA);
                        setState(612);
                        typeArgument();
                    }
                }

                setState(617);
                _errHandler.sync(this);
                _la = _input.LA(1);
            }

            setState(618);
            match(GT);
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(this, re);
        _errHandler.recover(this, re);
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        return _localctx;
    }

    publicstatic class TypeArgumentContext
{
    EXTENDS |extends
}

ParserRuleContext {
public TypeContexttype()
{
    return getRuleContext(TypeContext.class ,  0 ) ;  }

publicTypeArgumentContext(ParserRuleContext parent, int invokingState)
{
    {
        SUPER | super
    }

    (parent, invokingState);
} {

AT | @ }OverridepublicintgetRuleIndex()
{
    return RULE_typeArgument;
} {

AT | @ }Overridepublic void enterRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterTypeArgument(this);
} {

AT | @ }Overridepublic void exitRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitTypeArgument(this);
} {

AT | @ }Overridepublic<T> Taccept(ParseTreeVisitor<?
{
    EXTENDS | extends
}

T >visitor ) { if  (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) return  ( (JavaVisitor<?
 {
EXTENDS |extends }
T > )visitor ) .visitTypeArgument(this); else  return 
visitor.visitChildren (this )
    ;
} }
public {
FINAL |final }
TypeArgumentContexttypeArgument()
{
    TypeArgumentContext _localctx = new TypeArgumentContext(_ctx, getState());
    enterRule(_localctx, 84, RULE_typeArgument);
    int _la;
    try
    {
        setState(626);
        {
            SWITCH | switch
            }

            (_input.LA(1))
            {
                {
                    CASE |  case
                }

                BOOLEAN:
                {
                    CASE |  case
                }

                BYTE:
                {
                    CASE |  case
                }

                CHAR:
                {
                    CASE |  case
                }

                DOUBLE:
                {
                    CASE |  case
                }

                FLOAT:
                {
                    CASE |  case
                }

                INT:
                {
                    CASE |  case
                }

                LONG:
                {
                    CASE |  case
                }

                SHORT:
                {
                    CASE |  case
                }

                Identifier:
                    enterOuterAlt(_localctx, 1);
                {
                    setState(620);
                    type();
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                QUESTION:
                    enterOuterAlt(_localctx, 2);
                {
                    setState(621);
                    match(QUESTION);
                    setState(624);
                    _la = _input.LA(1);
                    if (_la == EXTENDS
                    {
                        OR || |
                    }

                    _la == SUPER )
                    {
                        {
                            setState(622);
                            _la = _input.LA(1);
                            if (
                            {
                                BANG | !
                            }

                            (_la == EXTENDS
                            {
                                OR || |
                            }

                            _la == SUPER ) )
                            {
                                _errHandler.recoverInline(this);
                            }

                            consume();
                            setState(623);
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
                } : 

                throw new NoViableAltException(this);
            }
        }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(this, re);
        _errHandler.recover(this, re);
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        return _localctx;
    }

    publicstatic class QualifiedNameListContext
{
    EXTENDS |extends
}

ParserRuleContext {
public List<QualifiedNameContext> qualifiedName()
{
    return getRuleContexts(QualifiedNameContext.class ) ;  }

public QualifiedNameContextqualifiedName(int i)
{
    return getRuleContext(QualifiedNameContext.class , 

i ) ;  }publicQualifiedNameListContext(ParserRuleContext parent, int invokingState)
{
    {
        SUPER | super
    }

    (parent, invokingState);
} {

AT | @ }OverridepublicintgetRuleIndex()
{
    return RULE_qualifiedNameList;
} {

AT | @ }Overridepublic void enterRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterQualifiedNameList(this);
} {

AT | @ }Overridepublic void exitRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitQualifiedNameList(this);
} {

AT | @ }Overridepublic<T> Taccept(ParseTreeVisitor<?
{
    EXTENDS | extends
}

T >visitor ) { if  (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) return  ( (JavaVisitor<?
 {
EXTENDS |extends }
T > )visitor ) .visitQualifiedNameList(this); else  return 
visitor.visitChildren (this )
    ;
} }
public {
FINAL |final }
QualifiedNameListContextqualifiedNameList()
{
    QualifiedNameListContext _localctx = new QualifiedNameListContext(_ctx, getState());
    enterRule(_localctx, 86, RULE_qualifiedNameList);
    int _la;
    try
    {
        enterOuterAlt(_localctx, 1);
        {
            setState(628);
            qualifiedName();
            setState(633);
            _errHandler.sync(this);
            _la = _input.LA(1);
            {
                WHILE | while
            }

            (_la == COMMA)
            {
                {
                    {
                        setState(629);
                        match(COMMA);
                        setState(630);
                        qualifiedName();
                    }
                }

                setState(635);
                _errHandler.sync(this);
                _la = _input.LA(1);
            }
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(this, re);
        _errHandler.recover(this, re);
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        return _localctx;
    }

    publicstatic class FormalParametersContext
{
    EXTENDS |extends
}

ParserRuleContext {
public FormalParameterListContextformalParameterList()
{
    return getRuleContext(FormalParameterListContext.class ,  0 ) ;  }

publicFormalParametersContext(ParserRuleContext parent, int invokingState)
{
    {
        SUPER | super
    }

    (parent, invokingState);
} {

AT | @ }OverridepublicintgetRuleIndex()
{
    return RULE_formalParameters;
} {

AT | @ }Overridepublic void enterRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterFormalParameters(this);
} {

AT | @ }Overridepublic void exitRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitFormalParameters(this);
} {

AT | @ }Overridepublic<T> Taccept(ParseTreeVisitor<?
{
    EXTENDS | extends
}

T >visitor ) { if  (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) return  ( (JavaVisitor<?
 {
EXTENDS |extends }
T > )visitor ) .visitFormalParameters(this); else  return 
visitor.visitChildren (this )
    ;
} }
public {
FINAL |final }
FormalParametersContextformalParameters()
{
    FormalParametersContext _localctx = new FormalParametersContext(_ctx, getState());
    enterRule(_localctx, 88, RULE_formalParameters);
    int _la;
    try
    {
        enterOuterAlt(_localctx, 1);
        {
            setState(636);
            match(LPAREN);
            setState(638);
            _la = _input.LA(1);
            if ((((_la)
            {
                BITAND | &
            }

            {
                TILDE | ~
            }

            0x3f ) 
            == 0 && ((1L << _la)
            {
                BITAND | &
            }

            ((1L << BOOLEAN)
            {
                BITOR ||
            }

            (1L << BYTE)
            {
                BITOR ||
            }

            (1L << CHAR)
            {
                BITOR ||
            }

            (1L << DOUBLE)
            {
                BITOR ||
            }

            (1L << FINAL)
            {
                BITOR ||
            }

            (1L << FLOAT)
            {
                BITOR ||
            }

            (1L << INT)
            {
                BITOR ||
            }

            (1L << LONG)
            {
                BITOR ||
            }

            (1L << SHORT) ) ) 
            != 0 )
            {
                OR || |
            }

            _la == Identifier
            {
                OR || |
            }

            _la == AT )
            {
                {
                    setState(637);
                    formalParameterList();
                }
            }

            setState(640);
            match(RPAREN);
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(this, re);
        _errHandler.recover(this, re);
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        return _localctx;
    }

    publicstatic class FormalParameterListContext
{
    EXTENDS |extends
}

ParserRuleContext {
public List<FormalParameterContext> formalParameter()
{
    return getRuleContexts(FormalParameterContext.class ) ;  }

public LastFormalParameterContextlastFormalParameter()
{
    return getRuleContext(LastFormalParameterContext.class ,  0 ) ;  }

public FormalParameterContextformalParameter(int i)
{
    return getRuleContext(FormalParameterContext.class , 

i ) ;  }publicFormalParameterListContext(ParserRuleContext parent, int invokingState)
{
    {
        SUPER | super
    }

    (parent, invokingState);
} {

AT | @ }OverridepublicintgetRuleIndex()
{
    return RULE_formalParameterList;
} {

AT | @ }Overridepublic void enterRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterFormalParameterList(this);
} {

AT | @ }Overridepublic void exitRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitFormalParameterList(this);
} {

AT | @ }Overridepublic<T> Taccept(ParseTreeVisitor<?
{
    EXTENDS | extends
}

T >visitor ) { if  (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) return  ( (JavaVisitor<?
 {
EXTENDS |extends }
T > )visitor ) .visitFormalParameterList(this); else  return 
visitor.visitChildren (this )
    ;
} }
public {
FINAL |final }
FormalParameterListContextformalParameterList()
{
    FormalParameterListContext _localctx = new FormalParameterListContext(_ctx, getState());
    enterRule(_localctx, 90, RULE_formalParameterList);
    int _la;
    try
    {
        int _alt;
        setState(655);
        {
            SWITCH | switch
            }

            (getInterpreter().adaptivePredict(_input, 71, _ctx))
            {
                {
                    CASE |  case
                }

                1 : 
                enterOuterAlt(_localctx, 1);
                {
                    setState(642);
                    formalParameter();
                    setState(647);
                    _errHandler.sync(this);
                    _alt = getInterpreter().adaptivePredict(_input, 69, _ctx);
                    {
                        WHILE | while
                    }

                    (_alt != 2 && _alt != org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER)
                    {
                        if (_alt == 1)
                        {
                            {
                                {
                                    setState(643);
                                    match(COMMA);
                                    setState(644);
                                    formalParameter();
                                }
                            }
                        }

                        setState(649);
                        _errHandler.sync(this);
                        _alt = getInterpreter().adaptivePredict(_input, 69, _ctx);
                    }

                    setState(652);
                    _la = _input.LA(1);
                    if (_la == COMMA)
                    {
                        {
                            setState(650);
                            match(COMMA);
                            setState(651);
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

                2 : 
                enterOuterAlt(_localctx, 2);
                {
                    setState(654);
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
        _errHandler.reportError(this, re);
        _errHandler.recover(this, re);
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        return _localctx;
    }

    publicstatic class FormalParameterContext
{
    EXTENDS |extends
}

ParserRuleContext {
public VariableModifierContextvariableModifier(int i)
{
    return getRuleContext(VariableModifierContext.class , 

i ) ;  }public List<VariableModifierContext> variableModifier()
{
    return getRuleContexts(VariableModifierContext.class ) ;  }

public VariableDeclaratorIdContextvariableDeclaratorId()
{
    return getRuleContext(VariableDeclaratorIdContext.class ,  0 ) ;  }

public TypeContexttype()
{
    return getRuleContext(TypeContext.class ,  0 ) ;  }

publicFormalParameterContext(ParserRuleContext parent, int invokingState)
{
    {
        SUPER | super
    }

    (parent, invokingState);
} {

AT | @ }OverridepublicintgetRuleIndex()
{
    return RULE_formalParameter;
} {

AT | @ }Overridepublic void enterRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterFormalParameter(this);
} {

AT | @ }Overridepublic void exitRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitFormalParameter(this);
} {

AT | @ }Overridepublic<T> Taccept(ParseTreeVisitor<?
{
    EXTENDS | extends
}

T >visitor ) { if  (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) return  ( (JavaVisitor<?
 {
EXTENDS |extends }
T > )visitor ) .visitFormalParameter(this); else  return 
visitor.visitChildren (this )
    ;
} }
public {
FINAL |final }
FormalParameterContextformalParameter()
{
    FormalParameterContext _localctx = new FormalParameterContext(_ctx, getState());
    enterRule(_localctx, 92, RULE_formalParameter);
    int _la;
    try
    {
        enterOuterAlt(_localctx, 1);
        {
            setState(660);
            _errHandler.sync(this);
            _la = _input.LA(1);
            {
                WHILE | while
            }

            (_la == FINAL
            {
                OR || |
            }

            _la == AT )
            {
                {
                    {
                        setState(657);
                        variableModifier();
                    }
                }

                setState(662);
                _errHandler.sync(this);
                _la = _input.LA(1);
            }

            setState(663);
            type();
            setState(664);
            variableDeclaratorId();
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(this, re);
        _errHandler.recover(this, re);
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        return _localctx;
    }

    publicstatic class LastFormalParameterContext
{
    EXTENDS |extends
}

ParserRuleContext {
public VariableModifierContextvariableModifier(int i)
{
    return getRuleContext(VariableModifierContext.class , 

i ) ;  }public List<VariableModifierContext> variableModifier()
{
    return getRuleContexts(VariableModifierContext.class ) ;  }

public VariableDeclaratorIdContextvariableDeclaratorId()
{
    return getRuleContext(VariableDeclaratorIdContext.class ,  0 ) ;  }

public TypeContexttype()
{
    return getRuleContext(TypeContext.class ,  0 ) ;  }

publicLastFormalParameterContext(ParserRuleContext parent, int invokingState)
{
    {
        SUPER | super
    }

    (parent, invokingState);
} {

AT | @ }OverridepublicintgetRuleIndex()
{
    return RULE_lastFormalParameter;
} {

AT | @ }Overridepublic void enterRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterLastFormalParameter(this);
} {

AT | @ }Overridepublic void exitRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitLastFormalParameter(this);
} {

AT | @ }Overridepublic<T> Taccept(ParseTreeVisitor<?
{
    EXTENDS | extends
}

T >visitor ) { if  (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) return  ( (JavaVisitor<?
 {
EXTENDS |extends }
T > )visitor ) .visitLastFormalParameter(this); else  return 
visitor.visitChildren (this )
    ;
} }
public {
FINAL |final }
LastFormalParameterContextlastFormalParameter()
{
    LastFormalParameterContext _localctx = new LastFormalParameterContext(_ctx, getState());
    enterRule(_localctx, 94, RULE_lastFormalParameter);
    int _la;
    try
    {
        enterOuterAlt(_localctx, 1);
        {
            setState(669);
            _errHandler.sync(this);
            _la = _input.LA(1);
            {
                WHILE | while
            }

            (_la == FINAL
            {
                OR || |
            }

            _la == AT )
            {
                {
                    {
                        setState(666);
                        variableModifier();
                    }
                }

                setState(671);
                _errHandler.sync(this);
                _la = _input.LA(1);
            }

            setState(672);
            type();
            setState(673);
            match(ELLIPSIS);
            setState(674);
            variableDeclaratorId();
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(this, re);
        _errHandler.recover(this, re);
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        return _localctx;
    }

    publicstatic class MethodBodyContext
{
    EXTENDS |extends
}

ParserRuleContext {
public BlockContextblock()
{
    return getRuleContext(BlockContext.class ,  0 ) ;  }

publicMethodBodyContext(ParserRuleContext parent, int invokingState)
{
    {
        SUPER | super
    }

    (parent, invokingState);
} {

AT | @ }OverridepublicintgetRuleIndex()
{
    return RULE_methodBody;
} {

AT | @ }Overridepublic void enterRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterMethodBody(this);
} {

AT | @ }Overridepublic void exitRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitMethodBody(this);
} {

AT | @ }Overridepublic<T> Taccept(ParseTreeVisitor<?
{
    EXTENDS | extends
}

T >visitor ) { if  (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) return  ( (JavaVisitor<?
 {
EXTENDS |extends }
T > )visitor ) .visitMethodBody(this); else  return 
visitor.visitChildren (this )
    ;
} }
public {
FINAL |final }
MethodBodyContextmethodBody()
{
    MethodBodyContext _localctx = new MethodBodyContext(_ctx, getState());
    enterRule(_localctx, 96, RULE_methodBody);
    try
    {
        enterOuterAlt(_localctx, 1);
        {
            setState(676);
            block();
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(this, re);
        _errHandler.recover(this, re);
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        return _localctx;
    }

    publicstatic class ConstructorBodyContext
{
    EXTENDS |extends
}

ParserRuleContext {
public BlockContextblock()
{
    return getRuleContext(BlockContext.class ,  0 ) ;  }

publicConstructorBodyContext(ParserRuleContext parent, int invokingState)
{
    {
        SUPER | super
    }

    (parent, invokingState);
} {

AT | @ }OverridepublicintgetRuleIndex()
{
    return RULE_constructorBody;
} {

AT | @ }Overridepublic void enterRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterConstructorBody(this);
} {

AT | @ }Overridepublic void exitRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitConstructorBody(this);
} {

AT | @ }Overridepublic<T> Taccept(ParseTreeVisitor<?
{
    EXTENDS | extends
}

T >visitor ) { if  (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) return  ( (JavaVisitor<?
 {
EXTENDS |extends }
T > )visitor ) .visitConstructorBody(this); else  return 
visitor.visitChildren (this )
    ;
} }
public {
FINAL |final }
ConstructorBodyContextconstructorBody()
{
    ConstructorBodyContext _localctx = new ConstructorBodyContext(_ctx, getState());
    enterRule(_localctx, 98, RULE_constructorBody);
    try
    {
        enterOuterAlt(_localctx, 1);
        {
            setState(678);
            block();
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(this, re);
        _errHandler.recover(this, re);
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        return _localctx;
    }

    publicstatic class QualifiedNameContext
{
    EXTENDS |extends
}

ParserRuleContext {
public List<TerminalNode> Identifier()
{
    return getTokens(JavaParser.Identifier);
}

public TerminalNodeIdentifier(int i)
{
    return getToken(JavaParser.Identifier, i);
}

publicQualifiedNameContext(ParserRuleContext parent, int invokingState)
{
    {
        SUPER | super
    }

    (parent, invokingState);
} {

AT | @ }OverridepublicintgetRuleIndex()
{
    return RULE_qualifiedName;
} {

AT | @ }Overridepublic void enterRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterQualifiedName(this);
} {

AT | @ }Overridepublic void exitRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitQualifiedName(this);
} {

AT | @ }Overridepublic<T> Taccept(ParseTreeVisitor<?
{
    EXTENDS | extends
}

T >visitor ) { if  (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) return  ( (JavaVisitor<?
 {
EXTENDS |extends }
T > )visitor ) .visitQualifiedName(this); else  return 
visitor.visitChildren (this )
    ;
} }
public {
FINAL |final }
QualifiedNameContextqualifiedName()
{
    QualifiedNameContext _localctx = new QualifiedNameContext(_ctx, getState());
    enterRule(_localctx, 100, RULE_qualifiedName);
    try
    {
        int _alt;
        enterOuterAlt(_localctx, 1);
        {
            setState(680);
            match(Identifier);
            setState(685);
            _errHandler.sync(this);
            _alt = getInterpreter().adaptivePredict(_input, 74, _ctx);
            {
                WHILE | while
            }

            (_alt != 2 && _alt != org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER)
            {
                if (_alt == 1)
                {
                    {
                        {
                            setState(681);
                            match(DOT);
                            setState(682);
                            match(Identifier);
                        }
                    }
                }

                setState(687);
                _errHandler.sync(this);
                _alt = getInterpreter().adaptivePredict(_input, 74, _ctx);
            }
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(this, re);
        _errHandler.recover(this, re);
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        return _localctx;
    }

    publicstatic class LiteralContext
{
    EXTENDS |extends
}

ParserRuleContext {
public TerminalNodeStringLiteral()
{
    return getToken(JavaParser.StringLiteral, 0);
}

public TerminalNodeIntegerLiteral()
{
    return getToken(JavaParser.IntegerLiteral, 0);
}

public TerminalNodeFloatingPointLiteral()
{
    return getToken(JavaParser.FloatingPointLiteral, 0);
}

public TerminalNodeBooleanLiteral()
{
    return getToken(JavaParser.BooleanLiteral, 0);
}

public TerminalNodeCharacterLiteral()
{
    return getToken(JavaParser.CharacterLiteral, 0);
}

publicLiteralContext(ParserRuleContext parent, int invokingState)
{
    {
        SUPER | super
    }

    (parent, invokingState);
} {

AT | @ }OverridepublicintgetRuleIndex()
{
    return RULE_literal;
} {

AT | @ }Overridepublic void enterRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterLiteral(this);
} {

AT | @ }Overridepublic void exitRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitLiteral(this);
} {

AT | @ }Overridepublic<T> Taccept(ParseTreeVisitor<?
{
    EXTENDS | extends
}

T >visitor ) { if  (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) return  ( (JavaVisitor<?
 {
EXTENDS |extends }
T > )visitor ) .visitLiteral(this); else  return 
visitor.visitChildren (this )
    ;
} }
public {
FINAL |final }
LiteralContextliteral()
{
    LiteralContext _localctx = new LiteralContext(_ctx, getState());
    enterRule(_localctx, 102, RULE_literal);
    int _la;
    try
    {
        enterOuterAlt(_localctx, 1);
        {
            setState(688);
            _la = _input.LA(1);
            if (
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

            0x3f ) 
            == 0 && ((1L << _la)
            {
                BITAND | &
            }

            ((1L << IntegerLiteral)
            {
                BITOR ||
            }

            (1L << FloatingPointLiteral)
            {
                BITOR ||
            }

            (1L << BooleanLiteral)
            {
                BITOR ||
            }

            (1L << CharacterLiteral)
            {
                BITOR ||
            }

            (1L << StringLiteral)
            {
                BITOR ||
            }

            (1L << NullLiteral) ) ) 
            != 0 ) ) )
            {
                _errHandler.recoverInline(this);
            }

            consume();
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(this, re);
        _errHandler.recover(this, re);
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        return _localctx;
    }

    publicstatic class AnnotationContext
{
    EXTENDS |extends
}

ParserRuleContext {
public ElementValuePairsContextelementValuePairs()
{
    return getRuleContext(ElementValuePairsContext.class ,  0 ) ;  }

public AnnotationNameContextannotationName()
{
    return getRuleContext(AnnotationNameContext.class ,  0 ) ;  }

public ElementValueContextelementValue()
{
    return getRuleContext(ElementValueContext.class ,  0 ) ;  }

publicAnnotationContext(ParserRuleContext parent, int invokingState)
{
    {
        SUPER | super
    }

    (parent, invokingState);
} {

AT | @ }OverridepublicintgetRuleIndex()
{
    return RULE_annotation;
} {

AT | @ }Overridepublic void enterRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterAnnotation(this);
} {

AT | @ }Overridepublic void exitRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitAnnotation(this);
} {

AT | @ }Overridepublic<T> Taccept(ParseTreeVisitor<?
{
    EXTENDS | extends
}

T >visitor ) { if  (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) return  ( (JavaVisitor<?
 {
EXTENDS |extends }
T > )visitor ) .visitAnnotation(this); else  return 
visitor.visitChildren (this )
    ;
} }
public {
FINAL |final }
AnnotationContextannotation()
{
    AnnotationContext _localctx = new AnnotationContext(_ctx, getState());
    enterRule(_localctx, 104, RULE_annotation);
    int _la;
    try
    {
        enterOuterAlt(_localctx, 1);
        {
            setState(690);
            match(AT);
            setState(691);
            annotationName();
            setState(698);
            _la = _input.LA(1);
            if (_la == LPAREN)
            {
                {
                    setState(692);
                    match(LPAREN);
                    setState(695);
                    {
                        SWITCH | switch
                        }

                        (getInterpreter().adaptivePredict(_input, 75, _ctx))
                        {
                            {
                                CASE |  case
                            }

                            1 : 
                            {
                                setState(693);
                                elementValuePairs();
                            }

                            {
                                BREAK | break
                            }

                            ;
                            {
                                CASE |  case
                            }

                            2 : 
                            {
                                setState(694);
                                elementValue();
                            }

                            {
                                BREAK | break
                            }

                            ;
                        }

                        setState(697);
                        match(RPAREN);
                    }
                }
            }
        }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(this, re);
        _errHandler.recover(this, re);
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        return _localctx;
    }

    publicstatic class AnnotationNameContext
{
    EXTENDS |extends
}

ParserRuleContext {
public QualifiedNameContextqualifiedName()
{
    return getRuleContext(QualifiedNameContext.class ,  0 ) ;  }

publicAnnotationNameContext(ParserRuleContext parent, int invokingState)
{
    {
        SUPER | super
    }

    (parent, invokingState);
} {

AT | @ }OverridepublicintgetRuleIndex()
{
    return RULE_annotationName;
} {

AT | @ }Overridepublic void enterRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterAnnotationName(this);
} {

AT | @ }Overridepublic void exitRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitAnnotationName(this);
} {

AT | @ }Overridepublic<T> Taccept(ParseTreeVisitor<?
{
    EXTENDS | extends
}

T >visitor ) { if  (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) return  ( (JavaVisitor<?
 {
EXTENDS |extends }
T > )visitor ) .visitAnnotationName(this); else  return 
visitor.visitChildren (this )
    ;
} }
public {
FINAL |final }
AnnotationNameContextannotationName()
{
    AnnotationNameContext _localctx = new AnnotationNameContext(_ctx, getState());
    enterRule(_localctx, 106, RULE_annotationName);
    try
    {
        enterOuterAlt(_localctx, 1);
        {
            setState(700);
            qualifiedName();
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(this, re);
        _errHandler.recover(this, re);
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        return _localctx;
    }

    publicstatic class ElementValuePairsContext
{
    EXTENDS |extends
}

ParserRuleContext {
public ElementValuePairContextelementValuePair(int i)
{
    return getRuleContext(ElementValuePairContext.class , 

i ) ;  }public List<ElementValuePairContext> elementValuePair()
{
    return getRuleContexts(ElementValuePairContext.class ) ;  }

publicElementValuePairsContext(ParserRuleContext parent, int invokingState)
{
    {
        SUPER | super
    }

    (parent, invokingState);
} {

AT | @ }OverridepublicintgetRuleIndex()
{
    return RULE_elementValuePairs;
} {

AT | @ }Overridepublic void enterRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterElementValuePairs(this);
} {

AT | @ }Overridepublic void exitRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitElementValuePairs(this);
} {

AT | @ }Overridepublic<T> Taccept(ParseTreeVisitor<?
{
    EXTENDS | extends
}

T >visitor ) { if  (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) return  ( (JavaVisitor<?
 {
EXTENDS |extends }
T > )visitor ) .visitElementValuePairs(this); else  return 
visitor.visitChildren (this )
    ;
} }
public {
FINAL |final }
ElementValuePairsContextelementValuePairs()
{
    ElementValuePairsContext _localctx = new ElementValuePairsContext(_ctx, getState());
    enterRule(_localctx, 108, RULE_elementValuePairs);
    int _la;
    try
    {
        enterOuterAlt(_localctx, 1);
        {
            setState(702);
            elementValuePair();
            setState(707);
            _errHandler.sync(this);
            _la = _input.LA(1);
            {
                WHILE | while
            }

            (_la == COMMA)
            {
                {
                    {
                        setState(703);
                        match(COMMA);
                        setState(704);
                        elementValuePair();
                    }
                }

                setState(709);
                _errHandler.sync(this);
                _la = _input.LA(1);
            }
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(this, re);
        _errHandler.recover(this, re);
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        return _localctx;
    }

    publicstatic class ElementValuePairContext
{
    EXTENDS |extends
}

ParserRuleContext {
public TerminalNodeIdentifier()
{
    return getToken(JavaParser.Identifier, 0);
}

public ElementValueContextelementValue()
{
    return getRuleContext(ElementValueContext.class ,  0 ) ;  }

publicElementValuePairContext(ParserRuleContext parent, int invokingState)
{
    {
        SUPER | super
    }

    (parent, invokingState);
} {

AT | @ }OverridepublicintgetRuleIndex()
{
    return RULE_elementValuePair;
} {

AT | @ }Overridepublic void enterRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterElementValuePair(this);
} {

AT | @ }Overridepublic void exitRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitElementValuePair(this);
} {

AT | @ }Overridepublic<T> Taccept(ParseTreeVisitor<?
{
    EXTENDS | extends
}

T >visitor ) { if  (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) return  ( (JavaVisitor<?
 {
EXTENDS |extends }
T > )visitor ) .visitElementValuePair(this); else  return 
visitor.visitChildren (this )
    ;
} }
public {
FINAL |final }
ElementValuePairContextelementValuePair()
{
    ElementValuePairContext _localctx = new ElementValuePairContext(_ctx, getState());
    enterRule(_localctx, 110, RULE_elementValuePair);
    try
    {
        enterOuterAlt(_localctx, 1);
        {
            setState(710);
            match(Identifier);
            setState(711);
            match(ASSIGN);
            setState(712);
            elementValue();
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(this, re);
        _errHandler.recover(this, re);
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        return _localctx;
    }

    publicstatic class ElementValueContext
{
    EXTENDS |extends
}

ParserRuleContext {
public ElementValueArrayInitializerContextelementValueArrayInitializer()
{
    return getRuleContext(ElementValueArrayInitializerContext.class ,  0 ) ;  }

public AnnotationContextannotation()
{
    return getRuleContext(AnnotationContext.class ,  0 ) ;  }

public ExpressionContextexpression()
{
    return getRuleContext(ExpressionContext.class ,  0 ) ;  }

publicElementValueContext(ParserRuleContext parent, int invokingState)
{
    {
        SUPER | super
    }

    (parent, invokingState);
} {

AT | @ }OverridepublicintgetRuleIndex()
{
    return RULE_elementValue;
} {

AT | @ }Overridepublic void enterRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterElementValue(this);
} {

AT | @ }Overridepublic void exitRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitElementValue(this);
} {

AT | @ }Overridepublic<T> Taccept(ParseTreeVisitor<?
{
    EXTENDS | extends
}

T >visitor ) { if  (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) return  ( (JavaVisitor<?
 {
EXTENDS |extends }
T > )visitor ) .visitElementValue(this); else  return 
visitor.visitChildren (this )
    ;
} }
public {
FINAL |final }
ElementValueContextelementValue()
{
    ElementValueContext _localctx = new ElementValueContext(_ctx, getState());
    enterRule(_localctx, 112, RULE_elementValue);
    try
    {
        setState(717);
        {
            SWITCH | switch
            }

            (_input.LA(1))
            {
                {
                    CASE |  case
                }

                BOOLEAN:
                {
                    CASE |  case
                }

                BYTE:
                {
                    CASE |  case
                }

                CHAR:
                {
                    CASE |  case
                }

                DOUBLE:
                {
                    CASE |  case
                }

                FLOAT:
                {
                    CASE |  case
                }

                INT:
                {
                    CASE |  case
                }

                LONG:
                {
                    CASE |  case
                }

                NEW:
                {
                    CASE |  case
                }

                SHORT:
                {
                    CASE |  case
                }

                SUPER:
                {
                    CASE |  case
                }

                THIS:
                {
                    CASE |  case
                }

                VOID:
                {
                    CASE |  case
                }

                IntegerLiteral:
                {
                    CASE |  case
                }

                FloatingPointLiteral:
                {
                    CASE |  case
                }

                BooleanLiteral:
                {
                    CASE |  case
                }

                CharacterLiteral:
                {
                    CASE |  case
                }

                StringLiteral:
                {
                    CASE |  case
                }

                NullLiteral:
                {
                    CASE |  case
                }

                LPAREN:
                {
                    CASE |  case
                }

                LT:
                {
                    CASE |  case
                }

                BANG:
                {
                    CASE |  case
                }

                TILDE:
                {
                    CASE |  case
                }

                INC:
                {
                    CASE |  case
                }

                DEC:
                {
                    CASE |  case
                }

                ADD:
                {
                    CASE |  case
                }

                SUB:
                {
                    CASE |  case
                }

                Identifier:
                    enterOuterAlt(_localctx, 1);
                {
                    setState(714);
                    expression(0);
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                AT:
                    enterOuterAlt(_localctx, 2);
                {
                    setState(715);
                    annotation();
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                LBRACE:
                    enterOuterAlt(_localctx, 3);
                {
                    setState(716);
                    elementValueArrayInitializer();
                }

                {
                    BREAK | break
                }

                ;
                {
                    DEFAULT | default
                } : 

                throw new NoViableAltException(this);
            }
        }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(this, re);
        _errHandler.recover(this, re);
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        return _localctx;
    }

    publicstatic class ElementValueArrayInitializerContext
{
    EXTENDS |extends
}

ParserRuleContext {
public ElementValueContextelementValue(int i)
{
    return getRuleContext(ElementValueContext.class , 

i ) ;  }public List<ElementValueContext> elementValue()
{
    return getRuleContexts(ElementValueContext.class ) ;  }

publicElementValueArrayInitializerContext(ParserRuleContext parent, int invokingState)
{
    {
        SUPER | super
    }

    (parent, invokingState);
} {

AT | @ }OverridepublicintgetRuleIndex()
{
    return RULE_elementValueArrayInitializer;
} {

AT | @ }Overridepublic void enterRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterElementValueArrayInitializer(this);
} {

AT | @ }Overridepublic void exitRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitElementValueArrayInitializer(this);
} {

AT | @ }Overridepublic<T> Taccept(ParseTreeVisitor<?
{
    EXTENDS | extends
}

T >visitor ) { if  (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) return  ( (JavaVisitor<?
 {
EXTENDS |extends }
T > )visitor ) .visitElementValueArrayInitializer(this); else  return 
visitor.visitChildren (this )
    ;
} }
public {
FINAL |final }
ElementValueArrayInitializerContextelementValueArrayInitializer()
{
    ElementValueArrayInitializerContext _localctx = new ElementValueArrayInitializerContext(_ctx, getState());
    enterRule(_localctx, 114, RULE_elementValueArrayInitializer);
    int _la;
    try
    {
        int _alt;
        enterOuterAlt(_localctx, 1);
        {
            setState(719);
            match(LBRACE);
            setState(728);
            _la = _input.LA(1);
            if ((((_la)
            {
                BITAND | &
            }

            {
                TILDE | ~
            }

            0x3f ) 
            == 0 && ((1L << _la)
            {
                BITAND | &
            }

            ((1L << BOOLEAN)
            {
                BITOR ||
            }

            (1L << BYTE)
            {
                BITOR ||
            }

            (1L << CHAR)
            {
                BITOR ||
            }

            (1L << DOUBLE)
            {
                BITOR ||
            }

            (1L << FLOAT)
            {
                BITOR ||
            }

            (1L << INT)
            {
                BITOR ||
            }

            (1L << LONG)
            {
                BITOR ||
            }

            (1L << NEW)
            {
                BITOR ||
            }

            (1L << SHORT)
            {
                BITOR ||
            }

            (1L << SUPER)
            {
                BITOR ||
            }

            (1L << THIS)
            {
                BITOR ||
            }

            (1L << VOID)
            {
                BITOR ||
            }

            (1L << IntegerLiteral)
            {
                BITOR ||
            }

            (1L << FloatingPointLiteral)
            {
                BITOR ||
            }

            (1L << BooleanLiteral)
            {
                BITOR ||
            }

            (1L << CharacterLiteral)
            {
                BITOR ||
            }

            (1L << StringLiteral)
            {
                BITOR ||
            }

            (1L << NullLiteral)
            {
                BITOR ||
            }

            (1L << LPAREN)
            {
                BITOR ||
            }

            (1L << LBRACE) ) ) 
            != 0 )
            {
                OR || |
            }

            ((((_la - 68))
            {
                BITAND | &
            }

            {
                TILDE | ~
            }

            0x3f ) 
            == 0 && ((1L << (_la - 68))
            {
                BITAND | &
            }

            ((1L << (LT - 68))
            {
                BITOR ||
            }

            (1L << (BANG - 68))
            {
                BITOR ||
            }

            (1L << (TILDE - 68))
            {
                BITOR ||
            }

            (1L << (INC - 68))
            {
                BITOR ||
            }

            (1L << (DEC - 68))
            {
                BITOR ||
            }

            (1L << (ADD - 68))
            {
                BITOR ||
            }

            (1L << (SUB - 68))
            {
                BITOR ||
            }

            (1L << (Identifier - 68))
            {
                BITOR ||
            }

            (1L << (AT - 68)) ) ) 
            != 0 ) )
            {
                {
                    setState(720);
                    elementValue();
                    setState(725);
                    _errHandler.sync(this);
                    _alt = getInterpreter().adaptivePredict(_input, 79, _ctx);
                    {
                        WHILE | while
                    }

                    (_alt != 2 && _alt != org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER)
                    {
                        if (_alt == 1)
                        {
                            {
                                {
                                    setState(721);
                                    match(COMMA);
                                    setState(722);
                                    elementValue();
                                }
                            }
                        }

                        setState(727);
                        _errHandler.sync(this);
                        _alt = getInterpreter().adaptivePredict(_input, 79, _ctx);
                    }
                }
            }

            setState(731);
            _la = _input.LA(1);
            if (_la == COMMA)
            {
                {
                    setState(730);
                    match(COMMA);
                }
            }

            setState(733);
            match(RBRACE);
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(this, re);
        _errHandler.recover(this, re);
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        return _localctx;
    }

    publicstatic class AnnotationTypeDeclarationContext
{
    EXTENDS |extends
}

ParserRuleContext {
public TerminalNodeIdentifier()
{
    return getToken(JavaParser.Identifier, 0);
}

public AnnotationTypeBodyContextannotationTypeBody()
{
    return getRuleContext(AnnotationTypeBodyContext.class ,  0 ) ;  }

publicAnnotationTypeDeclarationContext(ParserRuleContext parent, int invokingState)
{
    {
        SUPER | super
    }

    (parent, invokingState);
} {

AT | @ }OverridepublicintgetRuleIndex()
{
    return RULE_annotationTypeDeclaration;
} {

AT | @ }Overridepublic void enterRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterAnnotationTypeDeclaration(this);
} {

AT | @ }Overridepublic void exitRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitAnnotationTypeDeclaration(this);
} {

AT | @ }Overridepublic<T> Taccept(ParseTreeVisitor<?
{
    EXTENDS | extends
}

T >visitor ) { if  (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) return  ( (JavaVisitor<?
 {
EXTENDS |extends }
T > )visitor ) .visitAnnotationTypeDeclaration(this); else  return 
visitor.visitChildren (this )
    ;
} }
public {
FINAL |final }
AnnotationTypeDeclarationContextannotationTypeDeclaration()
{
    AnnotationTypeDeclarationContext _localctx = new AnnotationTypeDeclarationContext(_ctx, getState());
    enterRule(_localctx, 116, RULE_annotationTypeDeclaration);
    try
    {
        enterOuterAlt(_localctx, 1);
        {
            setState(735);
            match(AT);
            setState(736);
            match(INTERFACE);
            setState(737);
            match(Identifier);
            setState(738);
            annotationTypeBody();
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(this, re);
        _errHandler.recover(this, re);
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        return _localctx;
    }

    publicstatic class AnnotationTypeBodyContext
{
    EXTENDS |extends
}

ParserRuleContext {
public List<AnnotationTypeElementDeclarationContext> annotationTypeElementDeclaration()
{
    return getRuleContexts(AnnotationTypeElementDeclarationContext.class ) ;  }

public AnnotationTypeElementDeclarationContextannotationTypeElementDeclaration(int i)
{
    return getRuleContext(AnnotationTypeElementDeclarationContext.class , 

i ) ;  }publicAnnotationTypeBodyContext(ParserRuleContext parent, int invokingState)
{
    {
        SUPER | super
    }

    (parent, invokingState);
} {

AT | @ }OverridepublicintgetRuleIndex()
{
    return RULE_annotationTypeBody;
} {

AT | @ }Overridepublic void enterRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterAnnotationTypeBody(this);
} {

AT | @ }Overridepublic void exitRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitAnnotationTypeBody(this);
} {

AT | @ }Overridepublic<T> Taccept(ParseTreeVisitor<?
{
    EXTENDS | extends
}

T >visitor ) { if  (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) return  ( (JavaVisitor<?
 {
EXTENDS |extends }
T > )visitor ) .visitAnnotationTypeBody(this); else  return 
visitor.visitChildren (this )
    ;
} }
public {
FINAL |final }
AnnotationTypeBodyContextannotationTypeBody()
{
    AnnotationTypeBodyContext _localctx = new AnnotationTypeBodyContext(_ctx, getState());
    enterRule(_localctx, 118, RULE_annotationTypeBody);
    int _la;
    try
    {
        enterOuterAlt(_localctx, 1);
        {
            setState(740);
            match(LBRACE);
            setState(744);
            _errHandler.sync(this);
            _la = _input.LA(1);
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

            0x3f ) 
            == 0 && ((1L << _la)
            {
                BITAND | &
            }

            ((1L << ABSTRACT)
            {
                BITOR ||
            }

            (1L << BOOLEAN)
            {
                BITOR ||
            }

            (1L << BYTE)
            {
                BITOR ||
            }

            (1L << CHAR)
            {
                BITOR ||
            }

            (1L << CLASS)
            {
                BITOR ||
            }

            (1L << DOUBLE)
            {
                BITOR ||
            }

            (1L << ENUM)
            {
                BITOR ||
            }

            (1L << FINAL)
            {
                BITOR ||
            }

            (1L << FLOAT)
            {
                BITOR ||
            }

            (1L << INT)
            {
                BITOR ||
            }

            (1L << INTERFACE)
            {
                BITOR ||
            }

            (1L << LONG)
            {
                BITOR ||
            }

            (1L << NATIVE)
            {
                BITOR ||
            }

            (1L << PRIVATE)
            {
                BITOR ||
            }

            (1L << PROTECTED)
            {
                BITOR ||
            }

            (1L << PUBLIC)
            {
                BITOR ||
            }

            (1L << SHORT)
            {
                BITOR ||
            }

            (1L << STATIC)
            {
                BITOR ||
            }

            (1L << STRICTFP)
            {
                BITOR ||
            }

            (1L << SYNCHRONIZED)
            {
                BITOR ||
            }

            (1L << TRANSIENT)
            {
                BITOR ||
            }

            (1L << VOLATILE)
            {
                BITOR ||
            }

            (1L << SEMI) ) ) 
            != 0 )
            {
                OR || |
            }

            _la == Identifier
            {
                OR || |
            }

            _la == AT )
            {
                {
                    {
                        setState(741);
                        annotationTypeElementDeclaration();
                    }
                }

                setState(746);
                _errHandler.sync(this);
                _la = _input.LA(1);
            }

            setState(747);
            match(RBRACE);
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(this, re);
        _errHandler.recover(this, re);
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        return _localctx;
    }

    publicstatic class AnnotationTypeElementDeclarationContext
{
    EXTENDS |extends
}

ParserRuleContext {
public List<ModifierContext> modifier()
{
    return getRuleContexts(ModifierContext.class ) ;  }

public AnnotationTypeElementRestContextannotationTypeElementRest()
{
    return getRuleContext(AnnotationTypeElementRestContext.class ,  0 ) ;  }

public ModifierContextmodifier(int i)
{
    return getRuleContext(ModifierContext.class , 

i ) ;  }publicAnnotationTypeElementDeclarationContext(ParserRuleContext parent, int invokingState)
{
    {
        SUPER | super
    }

    (parent, invokingState);
} {

AT | @ }OverridepublicintgetRuleIndex()
{
    return RULE_annotationTypeElementDeclaration;
} {

AT | @ }Overridepublic void enterRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterAnnotationTypeElementDeclaration(this);
} {

AT | @ }Overridepublic void exitRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitAnnotationTypeElementDeclaration(this);
} {

AT | @ }Overridepublic<T> Taccept(ParseTreeVisitor<?
{
    EXTENDS | extends
}

T >visitor ) { if  (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) return  ( (JavaVisitor<?
 {
EXTENDS |extends }
T > )visitor ) .visitAnnotationTypeElementDeclaration(this); else  return 
visitor.visitChildren (this )
    ;
} }
public {
FINAL |final }
AnnotationTypeElementDeclarationContextannotationTypeElementDeclaration()
{
    AnnotationTypeElementDeclarationContext _localctx = new AnnotationTypeElementDeclarationContext(_ctx, getState());
    enterRule(_localctx, 120, RULE_annotationTypeElementDeclaration);
    try
    {
        int _alt;
        setState(757);
        {
            SWITCH | switch
            }

            (_input.LA(1))
            {
                {
                    CASE |  case
                }

                ABSTRACT:
                {
                    CASE |  case
                }

                BOOLEAN:
                {
                    CASE |  case
                }

                BYTE:
                {
                    CASE |  case
                }

                CHAR:
                {
                    CASE |  case
                }

                CLASS:
                {
                    CASE |  case
                }

                DOUBLE:
                {
                    CASE |  case
                }

                ENUM:
                {
                    CASE |  case
                }

                FINAL:
                {
                    CASE |  case
                }

                FLOAT:
                {
                    CASE |  case
                }

                INT:
                {
                    CASE |  case
                }

                INTERFACE:
                {
                    CASE |  case
                }

                LONG:
                {
                    CASE |  case
                }

                NATIVE:
                {
                    CASE |  case
                }

                PRIVATE:
                {
                    CASE |  case
                }

                PROTECTED:
                {
                    CASE |  case
                }

                PUBLIC:
                {
                    CASE |  case
                }

                SHORT:
                {
                    CASE |  case
                }

                STATIC:
                {
                    CASE |  case
                }

                STRICTFP:
                {
                    CASE |  case
                }

                SYNCHRONIZED:
                {
                    CASE |  case
                }

                TRANSIENT:
                {
                    CASE |  case
                }

                VOLATILE:
                {
                    CASE |  case
                }

                Identifier:
                {
                    CASE |  case
                }

                AT:
                    enterOuterAlt(_localctx, 1);
                {
                    setState(752);
                    _errHandler.sync(this);
                    _alt = getInterpreter().adaptivePredict(_input, 83, _ctx);
                    {
                        WHILE | while
                    }

                    (_alt != 2 && _alt != org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER)
                    {
                        if (_alt == 1)
                        {
                            {
                                {
                                    setState(749);
                                    modifier();
                                }
                            }
                        }

                        setState(754);
                        _errHandler.sync(this);
                        _alt = getInterpreter().adaptivePredict(_input, 83, _ctx);
                    }

                    setState(755);
                    annotationTypeElementRest();
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                SEMI:
                    enterOuterAlt(_localctx, 2);
                {
                    setState(756);
                    match(SEMI);
                }

                {
                    BREAK | break
                }

                ;
                {
                    DEFAULT | default
                } : 

                throw new NoViableAltException(this);
            }
        }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(this, re);
        _errHandler.recover(this, re);
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        return _localctx;
    }

    publicstatic class AnnotationTypeElementRestContext
{
    EXTENDS |extends
}

ParserRuleContext {
public EnumDeclarationContextenumDeclaration()
{
    return getRuleContext(EnumDeclarationContext.class ,  0 ) ;  }

public ClassDeclarationContextclassDeclaration()
{
    return getRuleContext(ClassDeclarationContext.class ,  0 ) ;  }

public AnnotationMethodOrConstantRestContextannotationMethodOrConstantRest()
{
    return getRuleContext(AnnotationMethodOrConstantRestContext.class ,  0 ) ;  }

public AnnotationTypeDeclarationContextannotationTypeDeclaration()
{
    return getRuleContext(AnnotationTypeDeclarationContext.class ,  0 ) ;  }

public InterfaceDeclarationContextinterfaceDeclaration()
{
    return getRuleContext(InterfaceDeclarationContext.class ,  0 ) ;  }

public TypeContexttype()
{
    return getRuleContext(TypeContext.class ,  0 ) ;  }

publicAnnotationTypeElementRestContext(ParserRuleContext parent, int invokingState)
{
    {
        SUPER | super
    }

    (parent, invokingState);
} {

AT | @ }OverridepublicintgetRuleIndex()
{
    return RULE_annotationTypeElementRest;
} {

AT | @ }Overridepublic void enterRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterAnnotationTypeElementRest(this);
} {

AT | @ }Overridepublic void exitRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitAnnotationTypeElementRest(this);
} {

AT | @ }Overridepublic<T> Taccept(ParseTreeVisitor<?
{
    EXTENDS | extends
}

T >visitor ) { if  (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) return  ( (JavaVisitor<?
 {
EXTENDS |extends }
T > )visitor ) .visitAnnotationTypeElementRest(this); else  return 
visitor.visitChildren (this )
    ;
} }
public {
FINAL |final }
AnnotationTypeElementRestContextannotationTypeElementRest()
{
    AnnotationTypeElementRestContext _localctx = new AnnotationTypeElementRestContext(_ctx, getState());
    enterRule(_localctx, 122, RULE_annotationTypeElementRest);
    try
    {
        setState(779);
        {
            SWITCH | switch
            }

            (_input.LA(1))
            {
                {
                    CASE |  case
                }

                BOOLEAN:
                {
                    CASE |  case
                }

                BYTE:
                {
                    CASE |  case
                }

                CHAR:
                {
                    CASE |  case
                }

                DOUBLE:
                {
                    CASE |  case
                }

                FLOAT:
                {
                    CASE |  case
                }

                INT:
                {
                    CASE |  case
                }

                LONG:
                {
                    CASE |  case
                }

                SHORT:
                {
                    CASE |  case
                }

                Identifier:
                    enterOuterAlt(_localctx, 1);
                {
                    setState(759);
                    type();
                    setState(760);
                    annotationMethodOrConstantRest();
                    setState(761);
                    match(SEMI);
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                CLASS:
                    enterOuterAlt(_localctx, 2);
                {
                    setState(763);
                    classDeclaration();
                    setState(765);
                    {
                        SWITCH | switch
                        }

                        (getInterpreter().adaptivePredict(_input, 85, _ctx))
                        {
                            {
                                CASE |  case
                            }

                            1 : 
                            {
                                setState(764);
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

                    INTERFACE:
                        enterOuterAlt(_localctx, 3);
                    {
                        setState(767);
                        interfaceDeclaration();
                        setState(769);
                        {
                            SWITCH | switch
                            }

                            (getInterpreter().adaptivePredict(_input, 86, _ctx))
                            {
                                {
                                    CASE |  case
                                }

                                1 : 
                                {
                                    setState(768);
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

                        ENUM:
                            enterOuterAlt(_localctx, 4);
                        {
                            setState(771);
                            enumDeclaration();
                            setState(773);
                            {
                                SWITCH | switch
                                }

                                (getInterpreter().adaptivePredict(_input, 87, _ctx))
                                {
                                    {
                                        CASE |  case
                                    }

                                    1 : 
                                    {
                                        setState(772);
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

                            AT:
                                enterOuterAlt(_localctx, 5);
                            {
                                setState(775);
                                annotationTypeDeclaration();
                                setState(777);
                                {
                                    SWITCH | switch
                                    }

                                    (getInterpreter().adaptivePredict(_input, 88, _ctx))
                                    {
                                        {
                                            CASE |  case
                                        }

                                        1 : 
                                        {
                                            setState(776);
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
                                } : 

                                throw new NoViableAltException(this);
                            }
                        }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(this, re);
        _errHandler.recover(this, re);
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        return _localctx;
    }

    publicstatic class AnnotationMethodOrConstantRestContext
{
    EXTENDS |extends
}

ParserRuleContext {
public AnnotationMethodRestContextannotationMethodRest()
{
    return getRuleContext(AnnotationMethodRestContext.class ,  0 ) ;  }

public AnnotationConstantRestContextannotationConstantRest()
{
    return getRuleContext(AnnotationConstantRestContext.class ,  0 ) ;  }

publicAnnotationMethodOrConstantRestContext(ParserRuleContext parent, int invokingState)
{
    {
        SUPER | super
    }

    (parent, invokingState);
} {

AT | @ }OverridepublicintgetRuleIndex()
{
    return RULE_annotationMethodOrConstantRest;
} {

AT | @ }Overridepublic void enterRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterAnnotationMethodOrConstantRest(this);
} {

AT | @ }Overridepublic void exitRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitAnnotationMethodOrConstantRest(this);
} {

AT | @ }Overridepublic<T> Taccept(ParseTreeVisitor<?
{
    EXTENDS | extends
}

T >visitor ) { if  (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) return  ( (JavaVisitor<?
 {
EXTENDS |extends }
T > )visitor ) .visitAnnotationMethodOrConstantRest(this); else  return 
visitor.visitChildren (this )
    ;
} }
public {
FINAL |final }
AnnotationMethodOrConstantRestContextannotationMethodOrConstantRest()
{
    AnnotationMethodOrConstantRestContext _localctx = new AnnotationMethodOrConstantRestContext(_ctx, getState());
    enterRule(_localctx, 124, RULE_annotationMethodOrConstantRest);
    try
    {
        setState(783);
        {
            SWITCH | switch
            }

            (getInterpreter().adaptivePredict(_input, 90, _ctx))
            {
                {
                    CASE |  case
                }

                1 : 
                enterOuterAlt(_localctx, 1);
                {
                    setState(781);
                    annotationMethodRest();
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                2 : 
                enterOuterAlt(_localctx, 2);
                {
                    setState(782);
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
        _errHandler.reportError(this, re);
        _errHandler.recover(this, re);
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        return _localctx;
    }

    publicstatic class AnnotationMethodRestContext
{
    EXTENDS |extends
}

ParserRuleContext {
public TerminalNodeIdentifier()
{
    return getToken(JavaParser.Identifier, 0);
}

public DefaultValueContextdefaultValue()
{
    return getRuleContext(DefaultValueContext.class ,  0 ) ;  }

publicAnnotationMethodRestContext(ParserRuleContext parent, int invokingState)
{
    {
        SUPER | super
    }

    (parent, invokingState);
} {

AT | @ }OverridepublicintgetRuleIndex()
{
    return RULE_annotationMethodRest;
} {

AT | @ }Overridepublic void enterRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterAnnotationMethodRest(this);
} {

AT | @ }Overridepublic void exitRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitAnnotationMethodRest(this);
} {

AT | @ }Overridepublic<T> Taccept(ParseTreeVisitor<?
{
    EXTENDS | extends
}

T >visitor ) { if  (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) return  ( (JavaVisitor<?
 {
EXTENDS |extends }
T > )visitor ) .visitAnnotationMethodRest(this); else  return 
visitor.visitChildren (this )
    ;
} }
public {
FINAL |final }
AnnotationMethodRestContextannotationMethodRest()
{
    AnnotationMethodRestContext _localctx = new AnnotationMethodRestContext(_ctx, getState());
    enterRule(_localctx, 126, RULE_annotationMethodRest);
    int _la;
    try
    {
        enterOuterAlt(_localctx, 1);
        {
            setState(785);
            match(Identifier);
            setState(786);
            match(LPAREN);
            setState(787);
            match(RPAREN);
            setState(789);
            _la = _input.LA(1);
            if (_la == DEFAULT)
            {
                {
                    setState(788);
                    defaultValue();
                }
            }
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(this, re);
        _errHandler.recover(this, re);
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        return _localctx;
    }

    publicstatic class AnnotationConstantRestContext
{
    EXTENDS |extends
}

ParserRuleContext {
public VariableDeclaratorsContextvariableDeclarators()
{
    return getRuleContext(VariableDeclaratorsContext.class ,  0 ) ;  }

publicAnnotationConstantRestContext(ParserRuleContext parent, int invokingState)
{
    {
        SUPER | super
    }

    (parent, invokingState);
} {

AT | @ }OverridepublicintgetRuleIndex()
{
    return RULE_annotationConstantRest;
} {

AT | @ }Overridepublic void enterRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterAnnotationConstantRest(this);
} {

AT | @ }Overridepublic void exitRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitAnnotationConstantRest(this);
} {

AT | @ }Overridepublic<T> Taccept(ParseTreeVisitor<?
{
    EXTENDS | extends
}

T >visitor ) { if  (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) return  ( (JavaVisitor<?
 {
EXTENDS |extends }
T > )visitor ) .visitAnnotationConstantRest(this); else  return 
visitor.visitChildren (this )
    ;
} }
public {
FINAL |final }
AnnotationConstantRestContextannotationConstantRest()
{
    AnnotationConstantRestContext _localctx = new AnnotationConstantRestContext(_ctx, getState());
    enterRule(_localctx, 128, RULE_annotationConstantRest);
    try
    {
        enterOuterAlt(_localctx, 1);
        {
            setState(791);
            variableDeclarators();
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(this, re);
        _errHandler.recover(this, re);
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        return _localctx;
    }

    publicstatic class DefaultValueContext
{
    EXTENDS |extends
}

ParserRuleContext {
public ElementValueContextelementValue()
{
    return getRuleContext(ElementValueContext.class ,  0 ) ;  }

publicDefaultValueContext(ParserRuleContext parent, int invokingState)
{
    {
        SUPER | super
    }

    (parent, invokingState);
} {

AT | @ }OverridepublicintgetRuleIndex()
{
    return RULE_defaultValue;
} {

AT | @ }Overridepublic void enterRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterDefaultValue(this);
} {

AT | @ }Overridepublic void exitRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitDefaultValue(this);
} {

AT | @ }Overridepublic<T> Taccept(ParseTreeVisitor<?
{
    EXTENDS | extends
}

T >visitor ) { if  (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) return  ( (JavaVisitor<?
 {
EXTENDS |extends }
T > )visitor ) .visitDefaultValue(this); else  return 
visitor.visitChildren (this )
    ;
} }
public {
FINAL |final }
DefaultValueContextdefaultValue()
{
    DefaultValueContext _localctx = new DefaultValueContext(_ctx, getState());
    enterRule(_localctx, 130, RULE_defaultValue);
    try
    {
        enterOuterAlt(_localctx, 1);
        {
            setState(793);
            match(DEFAULT);
            setState(794);
            elementValue();
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(this, re);
        _errHandler.recover(this, re);
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        return _localctx;
    }

    publicstatic class BlockContext
{
    EXTENDS |extends
}

ParserRuleContext {
public List<BlockStatementContext> blockStatement()
{
    return getRuleContexts(BlockStatementContext.class ) ;  }

public BlockStatementContextblockStatement(int i)
{
    return getRuleContext(BlockStatementContext.class , 

i ) ;  }publicBlockContext(ParserRuleContext parent, int invokingState)
{
    {
        SUPER | super
    }

    (parent, invokingState);
} {

AT | @ }OverridepublicintgetRuleIndex()
{
    return RULE_block;
} {

AT | @ }Overridepublic void enterRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterBlock(this);
} {

AT | @ }Overridepublic void exitRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitBlock(this);
} {

AT | @ }Overridepublic<T> Taccept(ParseTreeVisitor<?
{
    EXTENDS | extends
}

T >visitor ) { if  (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) return  ( (JavaVisitor<?
 {
EXTENDS |extends }
T > )visitor ) .visitBlock(this); else  return 
visitor.visitChildren (this )
    ;
} }
public {
FINAL |final }
BlockContextblock()
{
    BlockContext _localctx = new BlockContext(_ctx, getState());
    enterRule(_localctx, 132, RULE_block);
    int _la;
    try
    {
        enterOuterAlt(_localctx, 1);
        {
            setState(796);
            match(LBRACE);
            setState(800);
            _errHandler.sync(this);
            _la = _input.LA(1);
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

            0x3f ) 
            == 0 && ((1L << _la)
            {
                BITAND | &
            }

            ((1L << ABSTRACT)
            {
                BITOR ||
            }

            (1L << ASSERT)
            {
                BITOR ||
            }

            (1L << BOOLEAN)
            {
                BITOR ||
            }

            (1L << BREAK)
            {
                BITOR ||
            }

            (1L << BYTE)
            {
                BITOR ||
            }

            (1L << CHAR)
            {
                BITOR ||
            }

            (1L << CLASS)
            {
                BITOR ||
            }

            (1L << CONTINUE)
            {
                BITOR ||
            }

            (1L << DO)
            {
                BITOR ||
            }

            (1L << DOUBLE)
            {
                BITOR ||
            }

            (1L << ENUM)
            {
                BITOR ||
            }

            (1L << FINAL)
            {
                BITOR ||
            }

            (1L << FLOAT)
            {
                BITOR ||
            }

            (1L << FOR)
            {
                BITOR ||
            }

            (1L << IF)
            {
                BITOR ||
            }

            (1L << INT)
            {
                BITOR ||
            }

            (1L << INTERFACE)
            {
                BITOR ||
            }

            (1L << LONG)
            {
                BITOR ||
            }

            (1L << NEW)
            {
                BITOR ||
            }

            (1L << PRIVATE)
            {
                BITOR ||
            }

            (1L << PROTECTED)
            {
                BITOR ||
            }

            (1L << PUBLIC)
            {
                BITOR ||
            }

            (1L << RETURN)
            {
                BITOR ||
            }

            (1L << SHORT)
            {
                BITOR ||
            }

            (1L << STATIC)
            {
                BITOR ||
            }

            (1L << STRICTFP)
            {
                BITOR ||
            }

            (1L << SUPER)
            {
                BITOR ||
            }

            (1L << SWITCH)
            {
                BITOR ||
            }

            (1L << SYNCHRONIZED)
            {
                BITOR ||
            }

            (1L << THIS)
            {
                BITOR ||
            }

            (1L << THROW)
            {
                BITOR ||
            }

            (1L << TRY)
            {
                BITOR ||
            }

            (1L << VOID)
            {
                BITOR ||
            }

            (1L << WHILE)
            {
                BITOR ||
            }

            (1L << IntegerLiteral)
            {
                BITOR ||
            }

            (1L << FloatingPointLiteral)
            {
                BITOR ||
            }

            (1L << BooleanLiteral)
            {
                BITOR ||
            }

            (1L << CharacterLiteral)
            {
                BITOR ||
            }

            (1L << StringLiteral)
            {
                BITOR ||
            }

            (1L << NullLiteral)
            {
                BITOR ||
            }

            (1L << LPAREN)
            {
                BITOR ||
            }

            (1L << LBRACE)
            {
                BITOR ||
            }

            (1L << SEMI) ) ) 
            != 0 )
            {
                OR || |
            }

            ((((_la - 68))
            {
                BITAND | &
            }

            {
                TILDE | ~
            }

            0x3f ) 
            == 0 && ((1L << (_la - 68))
            {
                BITAND | &
            }

            ((1L << (LT - 68))
            {
                BITOR ||
            }

            (1L << (BANG - 68))
            {
                BITOR ||
            }

            (1L << (TILDE - 68))
            {
                BITOR ||
            }

            (1L << (INC - 68))
            {
                BITOR ||
            }

            (1L << (DEC - 68))
            {
                BITOR ||
            }

            (1L << (ADD - 68))
            {
                BITOR ||
            }

            (1L << (SUB - 68))
            {
                BITOR ||
            }

            (1L << (Identifier - 68))
            {
                BITOR ||
            }

            (1L << (AT - 68)) ) ) 
            != 0 ) )
            {
                {
                    {
                        setState(797);
                        blockStatement();
                    }
                }

                setState(802);
                _errHandler.sync(this);
                _la = _input.LA(1);
            }

            setState(803);
            match(RBRACE);
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(this, re);
        _errHandler.recover(this, re);
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        return _localctx;
    }

    publicstatic class BlockStatementContext
{
    EXTENDS |extends
}

ParserRuleContext {
public TypeDeclarationContexttypeDeclaration()
{
    return getRuleContext(TypeDeclarationContext.class ,  0 ) ;  }

public StatementContextstatement()
{
    return getRuleContext(StatementContext.class ,  0 ) ;  }

public LocalVariableDeclarationStatementContextlocalVariableDeclarationStatement()
{
    return getRuleContext(LocalVariableDeclarationStatementContext.class ,  0 ) ;  }

publicBlockStatementContext(ParserRuleContext parent, int invokingState)
{
    {
        SUPER | super
    }

    (parent, invokingState);
} {

AT | @ }OverridepublicintgetRuleIndex()
{
    return RULE_blockStatement;
} {

AT | @ }Overridepublic void enterRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterBlockStatement(this);
} {

AT | @ }Overridepublic void exitRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitBlockStatement(this);
} {

AT | @ }Overridepublic<T> Taccept(ParseTreeVisitor<?
{
    EXTENDS | extends
}

T >visitor ) { if  (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) return  ( (JavaVisitor<?
 {
EXTENDS |extends }
T > )visitor ) .visitBlockStatement(this); else  return 
visitor.visitChildren (this )
    ;
} }
public {
FINAL |final }
BlockStatementContextblockStatement()
{
    BlockStatementContext _localctx = new BlockStatementContext(_ctx, getState());
    enterRule(_localctx, 134, RULE_blockStatement);
    try
    {
        setState(808);
        {
            SWITCH | switch
            }

            (getInterpreter().adaptivePredict(_input, 93, _ctx))
            {
                {
                    CASE |  case
                }

                1 : 
                enterOuterAlt(_localctx, 1);
                {
                    setState(805);
                    localVariableDeclarationStatement();
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                2 : 
                enterOuterAlt(_localctx, 2);
                {
                    setState(806);
                    statement();
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                3 : 
                enterOuterAlt(_localctx, 3);
                {
                    setState(807);
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
        _errHandler.reportError(this, re);
        _errHandler.recover(this, re);
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        return _localctx;
    }

    publicstatic class LocalVariableDeclarationStatementContext
{
    EXTENDS |extends
}

ParserRuleContext {
public LocalVariableDeclarationContextlocalVariableDeclaration()
{
    return getRuleContext(LocalVariableDeclarationContext.class ,  0 ) ;  }

publicLocalVariableDeclarationStatementContext(ParserRuleContext parent, int invokingState)
{
    {
        SUPER | super
    }

    (parent, invokingState);
} {

AT | @ }OverridepublicintgetRuleIndex()
{
    return RULE_localVariableDeclarationStatement;
} {

AT | @ }Overridepublic void enterRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterLocalVariableDeclarationStatement(this);
} {

AT | @ }Overridepublic void exitRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitLocalVariableDeclarationStatement(this);
} {

AT | @ }Overridepublic<T> Taccept(ParseTreeVisitor<?
{
    EXTENDS | extends
}

T >visitor ) { if  (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) return  ( (JavaVisitor<?
 {
EXTENDS |extends }
T > )visitor ) .visitLocalVariableDeclarationStatement(this); else  return 
visitor.visitChildren (this )
    ;
} }
public {
FINAL |final }
LocalVariableDeclarationStatementContextlocalVariableDeclarationStatement()
{
    LocalVariableDeclarationStatementContext _localctx = new LocalVariableDeclarationStatementContext(_ctx, getState());
    enterRule(_localctx, 136, RULE_localVariableDeclarationStatement);
    try
    {
        enterOuterAlt(_localctx, 1);
        {
            setState(810);
            localVariableDeclaration();
            setState(811);
            match(SEMI);
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(this, re);
        _errHandler.recover(this, re);
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        return _localctx;
    }

    publicstatic class LocalVariableDeclarationContext
{
    EXTENDS |extends
}

ParserRuleContext {
public VariableModifierContextvariableModifier(int i)
{
    return getRuleContext(VariableModifierContext.class , 

i ) ;  }public List<VariableModifierContext> variableModifier()
{
    return getRuleContexts(VariableModifierContext.class ) ;  }

public VariableDeclaratorsContextvariableDeclarators()
{
    return getRuleContext(VariableDeclaratorsContext.class ,  0 ) ;  }

public TypeContexttype()
{
    return getRuleContext(TypeContext.class ,  0 ) ;  }

publicLocalVariableDeclarationContext(ParserRuleContext parent, int invokingState)
{
    {
        SUPER | super
    }

    (parent, invokingState);
} {

AT | @ }OverridepublicintgetRuleIndex()
{
    return RULE_localVariableDeclaration;
} {

AT | @ }Overridepublic void enterRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterLocalVariableDeclaration(this);
} {

AT | @ }Overridepublic void exitRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitLocalVariableDeclaration(this);
} {

AT | @ }Overridepublic<T> Taccept(ParseTreeVisitor<?
{
    EXTENDS | extends
}

T >visitor ) { if  (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) return  ( (JavaVisitor<?
 {
EXTENDS |extends }
T > )visitor ) .visitLocalVariableDeclaration(this); else  return 
visitor.visitChildren (this )
    ;
} }
public {
FINAL |final }
LocalVariableDeclarationContextlocalVariableDeclaration()
{
    LocalVariableDeclarationContext _localctx = new LocalVariableDeclarationContext(_ctx, getState());
    enterRule(_localctx, 138, RULE_localVariableDeclaration);
    int _la;
    try
    {
        enterOuterAlt(_localctx, 1);
        {
            setState(816);
            _errHandler.sync(this);
            _la = _input.LA(1);
            {
                WHILE | while
            }

            (_la == FINAL
            {
                OR || |
            }

            _la == AT )
            {
                {
                    {
                        setState(813);
                        variableModifier();
                    }
                }

                setState(818);
                _errHandler.sync(this);
                _la = _input.LA(1);
            }

            setState(819);
            type();
            setState(820);
            variableDeclarators();
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(this, re);
        _errHandler.recover(this, re);
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        return _localctx;
    }

    publicstatic class StatementContext
{
    EXTENDS |extends
}

ParserRuleContext {
public ExpressionContextexpression(int i)
{
    return getRuleContext(ExpressionContext.class , 

i ) ;  }public StatementExpressionContextstatementExpression()
{
    return getRuleContext(StatementExpressionContext.class ,  0 ) ;  }

public StatementContextstatement(int i)
{
    return getRuleContext(StatementContext.class , 

i ) ;  }public List<SwitchLabelContext> switchLabel()
{
    return getRuleContexts(SwitchLabelContext.class ) ;  }

public List<SwitchBlockStatementGroupContext> switchBlockStatementGroup()
{
    return getRuleContexts(SwitchBlockStatementGroupContext.class ) ;  }

public ParExpressionContextparExpression()
{
    return getRuleContext(ParExpressionContext.class ,  0 ) ;  }

public List<CatchClauseContext> catchClause()
{
    return getRuleContexts(CatchClauseContext.class ) ;  }

public CatchClauseContextcatchClause(int i)
{
    return getRuleContext(CatchClauseContext.class , 

i ) ;  }public TerminalNodeIdentifier()
{
    return getToken(JavaParser.Identifier, 0);
}

public FinallyBlockContextfinallyBlock()
{
    return getRuleContext(FinallyBlockContext.class ,  0 ) ;  }

public SwitchBlockStatementGroupContextswitchBlockStatementGroup(int i)
{
    return getRuleContext(SwitchBlockStatementGroupContext.class , 

i ) ;  }public ForControlContextforControl()
{
    return getRuleContext(ForControlContext.class ,  0 ) ;  }

public TerminalNodeASSERT()
{
    return getToken(JavaParser.ASSERT, 0);
}

public ResourceSpecificationContextresourceSpecification()
{
    return getRuleContext(ResourceSpecificationContext.class ,  0 ) ;  }

public List<StatementContext> statement()
{
    return getRuleContexts(StatementContext.class ) ;  }

public BlockContextblock()
{
    return getRuleContext(BlockContext.class ,  0 ) ;  }

public List<ExpressionContext> expression()
{
    return getRuleContexts(ExpressionContext.class ) ;  }

public SwitchLabelContextswitchLabel(int i)
{
    return getRuleContext(SwitchLabelContext.class , 

i ) ;  }publicStatementContext(ParserRuleContext parent, int invokingState)
{
    {
        SUPER | super
    }

    (parent, invokingState);
} {

AT | @ }OverridepublicintgetRuleIndex()
{
    return RULE_statement;
} {

AT | @ }Overridepublic void enterRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterStatement(this);
} {

AT | @ }Overridepublic void exitRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitStatement(this);
} {

AT | @ }Overridepublic<T> Taccept(ParseTreeVisitor<?
{
    EXTENDS | extends
}

T >visitor ) { if  (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) return  ( (JavaVisitor<?
 {
EXTENDS |extends }
T > )visitor ) .visitStatement(this); else  return 
visitor.visitChildren (this )
    ;
} }
public {
FINAL |final }
StatementContextstatement()
{
    StatementContext _localctx = new StatementContext(_ctx, getState());
    enterRule(_localctx, 140, RULE_statement);
    int _la;
    try
    {
        int _alt;
        setState(926);
        {
            SWITCH | switch
            }

            (getInterpreter().adaptivePredict(_input, 107, _ctx))
            {
                {
                    CASE |  case
                }

                1 : 
                enterOuterAlt(_localctx, 1);
                {
                    setState(822);
                    block();
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                2 : 
                enterOuterAlt(_localctx, 2);
                {
                    setState(823);
                    match(ASSERT);
                    setState(824);
                    expression(0);
                    setState(827);
                    _la = _input.LA(1);
                    if (_la == COLON)
                    {
                        {
                            setState(825);
                            match(COLON);
                            setState(826);
                            expression(0);
                        }
                    }

                    setState(829);
                    match(SEMI);
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                3 : 
                enterOuterAlt(_localctx, 3);
                {
                    setState(831);
                    match(IF);
                    setState(832);
                    parExpression();
                    setState(833);
                    statement();
                    setState(836);
                    {
                        SWITCH | switch
                        }

                        (getInterpreter().adaptivePredict(_input, 96, _ctx))
                        {
                            {
                                CASE |  case
                            }

                            1 : 
                            {
                                setState(834);
                                match(ELSE);
                                setState(835);
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

                    4 : 
                    enterOuterAlt(_localctx, 4);
                    {
                        setState(838);
                        match(FOR);
                        setState(839);
                        match(LPAREN);
                        setState(840);
                        forControl();
                        setState(841);
                        match(RPAREN);
                        setState(842);
                        statement();
                    }

                    {
                        BREAK | break
                    }

                    ;
                    {
                        CASE |  case
                    }

                    5 : 
                    enterOuterAlt(_localctx, 5);
                    {
                        setState(844);
                        match(WHILE);
                        setState(845);
                        parExpression();
                        setState(846);
                        statement();
                    }

                    {
                        BREAK | break
                    }

                    ;
                    {
                        CASE |  case
                    }

                    6 : 
                    enterOuterAlt(_localctx, 6);
                    {
                        setState(848);
                        match(DO);
                        setState(849);
                        statement();
                        setState(850);
                        match(WHILE);
                        setState(851);
                        parExpression();
                        setState(852);
                        match(SEMI);
                    }

                    {
                        BREAK | break
                    }

                    ;
                    {
                        CASE |  case
                    }

                    7 : 
                    enterOuterAlt(_localctx, 7);
                    {
                        setState(854);
                        match(TRY);
                        setState(855);
                        block();
                        setState(865);
                        {
                            SWITCH | switch
                            }

                            (_input.LA(1))
                            {
                                {
                                    CASE |  case
                                }

                                CATCH:
                                {
                                    setState(857);
                                    _errHandler.sync(this);
                                    _la = _input.LA(1);
                                    {
                                        DO | do
                                    }

                                    {
                                        {
                                            {
                                                setState(856);
                                                catchClause();
                                            }
                                        }

                                        setState(859);
                                        _errHandler.sync(this);
                                        _la = _input.LA(1);
                                    }

                                    {
                                        WHILE | while
                                    }

                                    (_la == CATCH);
                                    setState(862);
                                    _la = _input.LA(1);
                                    if (_la == FINALLY)
                                    {
                                        {
                                            setState(861);
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

                                FINALLY:
                                {
                                    setState(864);
                                    finallyBlock();
                                }

                                {
                                    BREAK | break
                                }

                                ;
                                {
                                    DEFAULT | default
                                } : 

                                throw new NoViableAltException(this);
                            }
                        }

                        {
                            BREAK | break
                        }

                        ;
                        {
                            CASE |  case
                        }

                        8 : 
                        enterOuterAlt(_localctx, 8);
                        {
                            setState(867);
                            match(TRY);
                            setState(868);
                            resourceSpecification();
                            setState(869);
                            block();
                            setState(873);
                            _errHandler.sync(this);
                            _la = _input.LA(1);
                            {
                                WHILE | while
                            }

                            (_la == CATCH)
                            {
                                {
                                    {
                                        setState(870);
                                        catchClause();
                                    }
                                }

                                setState(875);
                                _errHandler.sync(this);
                                _la = _input.LA(1);
                            }

                            setState(877);
                            _la = _input.LA(1);
                            if (_la == FINALLY)
                            {
                                {
                                    setState(876);
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

                        9 : 
                        enterOuterAlt(_localctx, 9);
                        {
                            setState(879);
                            match(SWITCH);
                            setState(880);
                            parExpression();
                            setState(881);
                            match(LBRACE);
                            setState(885);
                            _errHandler.sync(this);
                            _alt = getInterpreter().adaptivePredict(_input, 102, _ctx);
                            {
                                WHILE | while
                            }

                            (_alt != 2 && _alt != org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER)
                            {
                                if (_alt == 1)
                                {
                                    {
                                        {
                                            setState(882);
                                            switchBlockStatementGroup();
                                        }
                                    }
                                }

                                setState(887);
                                _errHandler.sync(this);
                                _alt = getInterpreter().adaptivePredict(_input, 102, _ctx);
                            }

                            setState(891);
                            _errHandler.sync(this);
                            _la = _input.LA(1);
                            {
                                WHILE | while
                            }

                            (_la == CASE
                            {
                                OR || |
                            }

                            _la == DEFAULT )
                            {
                                {
                                    {
                                        setState(888);
                                        switchLabel();
                                    }
                                }

                                setState(893);
                                _errHandler.sync(this);
                                _la = _input.LA(1);
                            }

                            setState(894);
                            match(RBRACE);
                        }

                        {
                            BREAK | break
                        }

                        ;
                        {
                            CASE |  case
                        }

                        10 : 
                        enterOuterAlt(_localctx, 10);
                        {
                            setState(896);
                            match(SYNCHRONIZED);
                            setState(897);
                            parExpression();
                            setState(898);
                            block();
                        }

                        {
                            BREAK | break
                        }

                        ;
                        {
                            CASE |  case
                        }

                        11 : 
                        enterOuterAlt(_localctx, 11);
                        {
                            setState(900);
                            match(RETURN);
                            setState(902);
                            _la = _input.LA(1);
                            if ((((_la)
                            {
                                BITAND | &
                            }

                            {
                                TILDE | ~
                            }

                            0x3f ) 
                            == 0 && ((1L << _la)
                            {
                                BITAND | &
                            }

                            ((1L << BOOLEAN)
                            {
                                BITOR ||
                            }

                            (1L << BYTE)
                            {
                                BITOR ||
                            }

                            (1L << CHAR)
                            {
                                BITOR ||
                            }

                            (1L << DOUBLE)
                            {
                                BITOR ||
                            }

                            (1L << FLOAT)
                            {
                                BITOR ||
                            }

                            (1L << INT)
                            {
                                BITOR ||
                            }

                            (1L << LONG)
                            {
                                BITOR ||
                            }

                            (1L << NEW)
                            {
                                BITOR ||
                            }

                            (1L << SHORT)
                            {
                                BITOR ||
                            }

                            (1L << SUPER)
                            {
                                BITOR ||
                            }

                            (1L << THIS)
                            {
                                BITOR ||
                            }

                            (1L << VOID)
                            {
                                BITOR ||
                            }

                            (1L << IntegerLiteral)
                            {
                                BITOR ||
                            }

                            (1L << FloatingPointLiteral)
                            {
                                BITOR ||
                            }

                            (1L << BooleanLiteral)
                            {
                                BITOR ||
                            }

                            (1L << CharacterLiteral)
                            {
                                BITOR ||
                            }

                            (1L << StringLiteral)
                            {
                                BITOR ||
                            }

                            (1L << NullLiteral)
                            {
                                BITOR ||
                            }

                            (1L << LPAREN) ) ) 
                            != 0 )
                            {
                                OR || |
                            }

                            ((((_la - 68))
                            {
                                BITAND | &
                            }

                            {
                                TILDE | ~
                            }

                            0x3f ) 
                            == 0 && ((1L << (_la - 68))
                            {
                                BITAND | &
                            }

                            ((1L << (LT - 68))
                            {
                                BITOR ||
                            }

                            (1L << (BANG - 68))
                            {
                                BITOR ||
                            }

                            (1L << (TILDE - 68))
                            {
                                BITOR ||
                            }

                            (1L << (INC - 68))
                            {
                                BITOR ||
                            }

                            (1L << (DEC - 68))
                            {
                                BITOR ||
                            }

                            (1L << (ADD - 68))
                            {
                                BITOR ||
                            }

                            (1L << (SUB - 68))
                            {
                                BITOR ||
                            }

                            (1L << (Identifier - 68)) ) ) 
                            != 0 ) )
                            {
                                {
                                    setState(901);
                                    expression(0);
                                }
                            }

                            setState(904);
                            match(SEMI);
                        }

                        {
                            BREAK | break
                        }

                        ;
                        {
                            CASE |  case
                        }

                        12 : 
                        enterOuterAlt(_localctx, 12);
                        {
                            setState(905);
                            match(THROW);
                            setState(906);
                            expression(0);
                            setState(907);
                            match(SEMI);
                        }

                        {
                            BREAK | break
                        }

                        ;
                        {
                            CASE |  case
                        }

                        13 : 
                        enterOuterAlt(_localctx, 13);
                        {
                            setState(909);
                            match(BREAK);
                            setState(911);
                            _la = _input.LA(1);
                            if (_la == Identifier)
                            {
                                {
                                    setState(910);
                                    match(Identifier);
                                }
                            }

                            setState(913);
                            match(SEMI);
                        }

                        {
                            BREAK | break
                        }

                        ;
                        {
                            CASE |  case
                        }

                        14 : 
                        enterOuterAlt(_localctx, 14);
                        {
                            setState(914);
                            match(CONTINUE);
                            setState(916);
                            _la = _input.LA(1);
                            if (_la == Identifier)
                            {
                                {
                                    setState(915);
                                    match(Identifier);
                                }
                            }

                            setState(918);
                            match(SEMI);
                        }

                        {
                            BREAK | break
                        }

                        ;
                        {
                            CASE |  case
                        }

                        15 : 
                        enterOuterAlt(_localctx, 15);
                        {
                            setState(919);
                            match(SEMI);
                        }

                        {
                            BREAK | break
                        }

                        ;
                        {
                            CASE |  case
                        }

                        16 : 
                        enterOuterAlt(_localctx, 16);
                        {
                            setState(920);
                            statementExpression();
                            setState(921);
                            match(SEMI);
                        }

                        {
                            BREAK | break
                        }

                        ;
                        {
                            CASE |  case
                        }

                        17 : 
                        enterOuterAlt(_localctx, 17);
                        {
                            setState(923);
                            match(Identifier);
                            setState(924);
                            match(COLON);
                            setState(925);
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
        _errHandler.reportError(this, re);
        _errHandler.recover(this, re);
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        return _localctx;
    }

    publicstatic class CatchClauseContext
{
    EXTENDS |extends
}

ParserRuleContext {
public CatchTypeContextcatchType()
{
    return getRuleContext(CatchTypeContext.class ,  0 ) ;  }

public TerminalNodeIdentifier()
{
    return getToken(JavaParser.Identifier, 0);
}

public VariableModifierContextvariableModifier(int i)
{
    return getRuleContext(VariableModifierContext.class , 

i ) ;  }public List<VariableModifierContext> variableModifier()
{
    return getRuleContexts(VariableModifierContext.class ) ;  }

public BlockContextblock()
{
    return getRuleContext(BlockContext.class ,  0 ) ;  }

publicCatchClauseContext(ParserRuleContext parent, int invokingState)
{
    {
        SUPER | super
    }

    (parent, invokingState);
} {

AT | @ }OverridepublicintgetRuleIndex()
{
    return RULE_catchClause;
} {

AT | @ }Overridepublic void enterRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterCatchClause(this);
} {

AT | @ }Overridepublic void exitRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitCatchClause(this);
} {

AT | @ }Overridepublic<T> Taccept(ParseTreeVisitor<?
{
    EXTENDS | extends
}

T >visitor ) { if  (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) return  ( (JavaVisitor<?
 {
EXTENDS |extends }
T > )visitor ) .visitCatchClause(this); else  return 
visitor.visitChildren (this )
    ;
} }
public {
FINAL |final }
CatchClauseContextcatchClause()
{
    CatchClauseContext _localctx = new CatchClauseContext(_ctx, getState());
    enterRule(_localctx, 142, RULE_catchClause);
    int _la;
    try
    {
        enterOuterAlt(_localctx, 1);
        {
            setState(928);
            match(CATCH);
            setState(929);
            match(LPAREN);
            setState(933);
            _errHandler.sync(this);
            _la = _input.LA(1);
            {
                WHILE | while
            }

            (_la == FINAL
            {
                OR || |
            }

            _la == AT )
            {
                {
                    {
                        setState(930);
                        variableModifier();
                    }
                }

                setState(935);
                _errHandler.sync(this);
                _la = _input.LA(1);
            }

            setState(936);
            catchType();
            setState(937);
            match(Identifier);
            setState(938);
            match(RPAREN);
            setState(939);
            block();
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(this, re);
        _errHandler.recover(this, re);
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        return _localctx;
    }

    publicstatic class CatchTypeContext
{
    EXTENDS |extends
}

ParserRuleContext {
public List<QualifiedNameContext> qualifiedName()
{
    return getRuleContexts(QualifiedNameContext.class ) ;  }

public QualifiedNameContextqualifiedName(int i)
{
    return getRuleContext(QualifiedNameContext.class , 

i ) ;  }publicCatchTypeContext(ParserRuleContext parent, int invokingState)
{
    {
        SUPER | super
    }

    (parent, invokingState);
} {

AT | @ }OverridepublicintgetRuleIndex()
{
    return RULE_catchType;
} {

AT | @ }Overridepublic void enterRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterCatchType(this);
} {

AT | @ }Overridepublic void exitRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitCatchType(this);
} {

AT | @ }Overridepublic<T> Taccept(ParseTreeVisitor<?
{
    EXTENDS | extends
}

T >visitor ) { if  (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) return  ( (JavaVisitor<?
 {
EXTENDS |extends }
T > )visitor ) .visitCatchType(this); else  return 
visitor.visitChildren (this )
    ;
} }
public {
FINAL |final }
CatchTypeContextcatchType()
{
    CatchTypeContext _localctx = new CatchTypeContext(_ctx, getState());
    enterRule(_localctx, 144, RULE_catchType);
    int _la;
    try
    {
        enterOuterAlt(_localctx, 1);
        {
            setState(941);
            qualifiedName();
            setState(946);
            _errHandler.sync(this);
            _la = _input.LA(1);
            {
                WHILE | while
            }

            (_la == BITOR)
            {
                {
                    {
                        setState(942);
                        match(BITOR);
                        setState(943);
                        qualifiedName();
                    }
                }

                setState(948);
                _errHandler.sync(this);
                _la = _input.LA(1);
            }
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(this, re);
        _errHandler.recover(this, re);
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        return _localctx;
    }

    publicstatic class FinallyBlockContext
{
    EXTENDS |extends
}

ParserRuleContext {
public BlockContextblock()
{
    return getRuleContext(BlockContext.class ,  0 ) ;  }

publicFinallyBlockContext(ParserRuleContext parent, int invokingState)
{
    {
        SUPER | super
    }

    (parent, invokingState);
} {

AT | @ }OverridepublicintgetRuleIndex()
{
    return RULE_finallyBlock;
} {

AT | @ }Overridepublic void enterRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterFinallyBlock(this);
} {

AT | @ }Overridepublic void exitRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitFinallyBlock(this);
} {

AT | @ }Overridepublic<T> Taccept(ParseTreeVisitor<?
{
    EXTENDS | extends
}

T >visitor ) { if  (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) return  ( (JavaVisitor<?
 {
EXTENDS |extends }
T > )visitor ) .visitFinallyBlock(this); else  return 
visitor.visitChildren (this )
    ;
} }
public {
FINAL |final }
FinallyBlockContextfinallyBlock()
{
    FinallyBlockContext _localctx = new FinallyBlockContext(_ctx, getState());
    enterRule(_localctx, 146, RULE_finallyBlock);
    try
    {
        enterOuterAlt(_localctx, 1);
        {
            setState(949);
            match(FINALLY);
            setState(950);
            block();
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(this, re);
        _errHandler.recover(this, re);
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        return _localctx;
    }

    publicstatic class ResourceSpecificationContext
{
    EXTENDS |extends
}

ParserRuleContext {
public ResourcesContextresources()
{
    return getRuleContext(ResourcesContext.class ,  0 ) ;  }

publicResourceSpecificationContext(ParserRuleContext parent, int invokingState)
{
    {
        SUPER | super
    }

    (parent, invokingState);
} {

AT | @ }OverridepublicintgetRuleIndex()
{
    return RULE_resourceSpecification;
} {

AT | @ }Overridepublic void enterRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterResourceSpecification(this);
} {

AT | @ }Overridepublic void exitRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitResourceSpecification(this);
} {

AT | @ }Overridepublic<T> Taccept(ParseTreeVisitor<?
{
    EXTENDS | extends
}

T >visitor ) { if  (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) return  ( (JavaVisitor<?
 {
EXTENDS |extends }
T > )visitor ) .visitResourceSpecification(this); else  return 
visitor.visitChildren (this )
    ;
} }
public {
FINAL |final }
ResourceSpecificationContextresourceSpecification()
{
    ResourceSpecificationContext _localctx = new ResourceSpecificationContext(_ctx, getState());
    enterRule(_localctx, 148, RULE_resourceSpecification);
    int _la;
    try
    {
        enterOuterAlt(_localctx, 1);
        {
            setState(952);
            match(LPAREN);
            setState(953);
            resources();
            setState(955);
            _la = _input.LA(1);
            if (_la == SEMI)
            {
                {
                    setState(954);
                    match(SEMI);
                }
            }

            setState(957);
            match(RPAREN);
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(this, re);
        _errHandler.recover(this, re);
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        return _localctx;
    }

    publicstatic class ResourcesContext
{
    EXTENDS |extends
}

ParserRuleContext {
public ResourceContextresource(int i)
{
    return getRuleContext(ResourceContext.class , 

i ) ;  }public List<ResourceContext> resource()
{
    return getRuleContexts(ResourceContext.class ) ;  }

publicResourcesContext(ParserRuleContext parent, int invokingState)
{
    {
        SUPER | super
    }

    (parent, invokingState);
} {

AT | @ }OverridepublicintgetRuleIndex()
{
    return RULE_resources;
} {

AT | @ }Overridepublic void enterRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterResources(this);
} {

AT | @ }Overridepublic void exitRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitResources(this);
} {

AT | @ }Overridepublic<T> Taccept(ParseTreeVisitor<?
{
    EXTENDS | extends
}

T >visitor ) { if  (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) return  ( (JavaVisitor<?
 {
EXTENDS |extends }
T > )visitor ) .visitResources(this); else  return 
visitor.visitChildren (this )
    ;
} }
public {
FINAL |final }
ResourcesContextresources()
{
    ResourcesContext _localctx = new ResourcesContext(_ctx, getState());
    enterRule(_localctx, 150, RULE_resources);
    try
    {
        int _alt;
        enterOuterAlt(_localctx, 1);
        {
            setState(959);
            resource();
            setState(964);
            _errHandler.sync(this);
            _alt = getInterpreter().adaptivePredict(_input, 111, _ctx);
            {
                WHILE | while
            }

            (_alt != 2 && _alt != org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER)
            {
                if (_alt == 1)
                {
                    {
                        {
                            setState(960);
                            match(SEMI);
                            setState(961);
                            resource();
                        }
                    }
                }

                setState(966);
                _errHandler.sync(this);
                _alt = getInterpreter().adaptivePredict(_input, 111, _ctx);
            }
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(this, re);
        _errHandler.recover(this, re);
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        return _localctx;
    }

    publicstatic class ResourceContext
{
    EXTENDS |extends
}

ParserRuleContext {
public VariableModifierContextvariableModifier(int i)
{
    return getRuleContext(VariableModifierContext.class , 

i ) ;  }public List<VariableModifierContext> variableModifier()
{
    return getRuleContexts(VariableModifierContext.class ) ;  }

public ClassOrInterfaceTypeContextclassOrInterfaceType()
{
    return getRuleContext(ClassOrInterfaceTypeContext.class ,  0 ) ;  }

public VariableDeclaratorIdContextvariableDeclaratorId()
{
    return getRuleContext(VariableDeclaratorIdContext.class ,  0 ) ;  }

public ExpressionContextexpression()
{
    return getRuleContext(ExpressionContext.class ,  0 ) ;  }

publicResourceContext(ParserRuleContext parent, int invokingState)
{
    {
        SUPER | super
    }

    (parent, invokingState);
} {

AT | @ }OverridepublicintgetRuleIndex()
{
    return RULE_resource;
} {

AT | @ }Overridepublic void enterRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterResource(this);
} {

AT | @ }Overridepublic void exitRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitResource(this);
} {

AT | @ }Overridepublic<T> Taccept(ParseTreeVisitor<?
{
    EXTENDS | extends
}

T >visitor ) { if  (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) return  ( (JavaVisitor<?
 {
EXTENDS |extends }
T > )visitor ) .visitResource(this); else  return 
visitor.visitChildren (this )
    ;
} }
public {
FINAL |final }
ResourceContextresource()
{
    ResourceContext _localctx = new ResourceContext(_ctx, getState());
    enterRule(_localctx, 152, RULE_resource);
    int _la;
    try
    {
        enterOuterAlt(_localctx, 1);
        {
            setState(970);
            _errHandler.sync(this);
            _la = _input.LA(1);
            {
                WHILE | while
            }

            (_la == FINAL
            {
                OR || |
            }

            _la == AT )
            {
                {
                    {
                        setState(967);
                        variableModifier();
                    }
                }

                setState(972);
                _errHandler.sync(this);
                _la = _input.LA(1);
            }

            setState(973);
            classOrInterfaceType();
            setState(974);
            variableDeclaratorId();
            setState(975);
            match(ASSIGN);
            setState(976);
            expression(0);
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(this, re);
        _errHandler.recover(this, re);
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        return _localctx;
    }

    publicstatic class SwitchBlockStatementGroupContext
{
    EXTENDS |extends
}

ParserRuleContext {
public List<BlockStatementContext> blockStatement()
{
    return getRuleContexts(BlockStatementContext.class ) ;  }

public List<SwitchLabelContext> switchLabel()
{
    return getRuleContexts(SwitchLabelContext.class ) ;  }

public BlockStatementContextblockStatement(int i)
{
    return getRuleContext(BlockStatementContext.class , 

i ) ;  }public SwitchLabelContextswitchLabel(int i)
{
    return getRuleContext(SwitchLabelContext.class , 

i ) ;  }publicSwitchBlockStatementGroupContext(ParserRuleContext parent, int invokingState)
{
    {
        SUPER | super
    }

    (parent, invokingState);
} {

AT | @ }OverridepublicintgetRuleIndex()
{
    return RULE_switchBlockStatementGroup;
} {

AT | @ }Overridepublic void enterRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterSwitchBlockStatementGroup(this);
} {

AT | @ }Overridepublic void exitRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitSwitchBlockStatementGroup(this);
} {

AT | @ }Overridepublic<T> Taccept(ParseTreeVisitor<?
{
    EXTENDS | extends
}

T >visitor ) { if  (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) return  ( (JavaVisitor<?
 {
EXTENDS |extends }
T > )visitor ) .visitSwitchBlockStatementGroup(this); else  return 
visitor.visitChildren (this )
    ;
} }
public {
FINAL |final }
SwitchBlockStatementGroupContextswitchBlockStatementGroup()
{
    SwitchBlockStatementGroupContext _localctx = new SwitchBlockStatementGroupContext(_ctx, getState());
    enterRule(_localctx, 154, RULE_switchBlockStatementGroup);
    int _la;
    try
    {
        enterOuterAlt(_localctx, 1);
        {
            setState(979);
            _errHandler.sync(this);
            _la = _input.LA(1);
            {
                DO | do
            }

            {
                {
                    {
                        setState(978);
                        switchLabel();
                    }
                }

                setState(981);
                _errHandler.sync(this);
                _la = _input.LA(1);
            }

            {
                WHILE | while
            }

            (_la == CASE
            {
                OR || |
            }

            _la == DEFAULT )
            ;
            setState(984);
            _errHandler.sync(this);
            _la = _input.LA(1);
            {
                DO | do
            }

            {
                {
                    {
                        setState(983);
                        blockStatement();
                    }
                }

                setState(986);
                _errHandler.sync(this);
                _la = _input.LA(1);
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

            0x3f ) 
            == 0 && ((1L << _la)
            {
                BITAND | &
            }

            ((1L << ABSTRACT)
            {
                BITOR ||
            }

            (1L << ASSERT)
            {
                BITOR ||
            }

            (1L << BOOLEAN)
            {
                BITOR ||
            }

            (1L << BREAK)
            {
                BITOR ||
            }

            (1L << BYTE)
            {
                BITOR ||
            }

            (1L << CHAR)
            {
                BITOR ||
            }

            (1L << CLASS)
            {
                BITOR ||
            }

            (1L << CONTINUE)
            {
                BITOR ||
            }

            (1L << DO)
            {
                BITOR ||
            }

            (1L << DOUBLE)
            {
                BITOR ||
            }

            (1L << ENUM)
            {
                BITOR ||
            }

            (1L << FINAL)
            {
                BITOR ||
            }

            (1L << FLOAT)
            {
                BITOR ||
            }

            (1L << FOR)
            {
                BITOR ||
            }

            (1L << IF)
            {
                BITOR ||
            }

            (1L << INT)
            {
                BITOR ||
            }

            (1L << INTERFACE)
            {
                BITOR ||
            }

            (1L << LONG)
            {
                BITOR ||
            }

            (1L << NEW)
            {
                BITOR ||
            }

            (1L << PRIVATE)
            {
                BITOR ||
            }

            (1L << PROTECTED)
            {
                BITOR ||
            }

            (1L << PUBLIC)
            {
                BITOR ||
            }

            (1L << RETURN)
            {
                BITOR ||
            }

            (1L << SHORT)
            {
                BITOR ||
            }

            (1L << STATIC)
            {
                BITOR ||
            }

            (1L << STRICTFP)
            {
                BITOR ||
            }

            (1L << SUPER)
            {
                BITOR ||
            }

            (1L << SWITCH)
            {
                BITOR ||
            }

            (1L << SYNCHRONIZED)
            {
                BITOR ||
            }

            (1L << THIS)
            {
                BITOR ||
            }

            (1L << THROW)
            {
                BITOR ||
            }

            (1L << TRY)
            {
                BITOR ||
            }

            (1L << VOID)
            {
                BITOR ||
            }

            (1L << WHILE)
            {
                BITOR ||
            }

            (1L << IntegerLiteral)
            {
                BITOR ||
            }

            (1L << FloatingPointLiteral)
            {
                BITOR ||
            }

            (1L << BooleanLiteral)
            {
                BITOR ||
            }

            (1L << CharacterLiteral)
            {
                BITOR ||
            }

            (1L << StringLiteral)
            {
                BITOR ||
            }

            (1L << NullLiteral)
            {
                BITOR ||
            }

            (1L << LPAREN)
            {
                BITOR ||
            }

            (1L << LBRACE)
            {
                BITOR ||
            }

            (1L << SEMI) ) ) 
            != 0 )
            {
                OR || |
            }

            ((((_la - 68))
            {
                BITAND | &
            }

            {
                TILDE | ~
            }

            0x3f ) 
            == 0 && ((1L << (_la - 68))
            {
                BITAND | &
            }

            ((1L << (LT - 68))
            {
                BITOR ||
            }

            (1L << (BANG - 68))
            {
                BITOR ||
            }

            (1L << (TILDE - 68))
            {
                BITOR ||
            }

            (1L << (INC - 68))
            {
                BITOR ||
            }

            (1L << (DEC - 68))
            {
                BITOR ||
            }

            (1L << (ADD - 68))
            {
                BITOR ||
            }

            (1L << (SUB - 68))
            {
                BITOR ||
            }

            (1L << (Identifier - 68))
            {
                BITOR ||
            }

            (1L << (AT - 68)) ) ) 
            != 0 ) )
            ;
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(this, re);
        _errHandler.recover(this, re);
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        return _localctx;
    }

    publicstatic class SwitchLabelContext
{
    EXTENDS |extends
}

ParserRuleContext {
public ConstantExpressionContextconstantExpression()
{
    return getRuleContext(ConstantExpressionContext.class ,  0 ) ;  }

public EnumConstantNameContextenumConstantName()
{
    return getRuleContext(EnumConstantNameContext.class ,  0 ) ;  }

publicSwitchLabelContext(ParserRuleContext parent, int invokingState)
{
    {
        SUPER | super
    }

    (parent, invokingState);
} {

AT | @ }OverridepublicintgetRuleIndex()
{
    return RULE_switchLabel;
} {

AT | @ }Overridepublic void enterRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterSwitchLabel(this);
} {

AT | @ }Overridepublic void exitRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitSwitchLabel(this);
} {

AT | @ }Overridepublic<T> Taccept(ParseTreeVisitor<?
{
    EXTENDS | extends
}

T >visitor ) { if  (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) return  ( (JavaVisitor<?
 {
EXTENDS |extends }
T > )visitor ) .visitSwitchLabel(this); else  return 
visitor.visitChildren (this )
    ;
} }
public {
FINAL |final }
SwitchLabelContextswitchLabel()
{
    SwitchLabelContext _localctx = new SwitchLabelContext(_ctx, getState());
    enterRule(_localctx, 156, RULE_switchLabel);
    try
    {
        setState(998);
        {
            SWITCH | switch
            }

            (getInterpreter().adaptivePredict(_input, 115, _ctx))
            {
                {
                    CASE |  case
                }

                1 : 
                enterOuterAlt(_localctx, 1);
                {
                    setState(988);
                    match(CASE);
                    setState(989);
                    constantExpression();
                    setState(990);
                    match(COLON);
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                2 : 
                enterOuterAlt(_localctx, 2);
                {
                    setState(992);
                    match(CASE);
                    setState(993);
                    enumConstantName();
                    setState(994);
                    match(COLON);
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                3 : 
                enterOuterAlt(_localctx, 3);
                {
                    setState(996);
                    match(DEFAULT);
                    setState(997);
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
        _errHandler.reportError(this, re);
        _errHandler.recover(this, re);
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        return _localctx;
    }

    publicstatic class ForControlContext
{
    EXTENDS |extends
}

ParserRuleContext {
public ForUpdateContextforUpdate()
{
    return getRuleContext(ForUpdateContext.class ,  0 ) ;  }

public ForInitContextforInit()
{
    return getRuleContext(ForInitContext.class ,  0 ) ;  }

public EnhancedForControlContextenhancedForControl()
{
    return getRuleContext(EnhancedForControlContext.class ,  0 ) ;  }

public ExpressionContextexpression()
{
    return getRuleContext(ExpressionContext.class ,  0 ) ;  }

publicForControlContext(ParserRuleContext parent, int invokingState)
{
    {
        SUPER | super
    }

    (parent, invokingState);
} {

AT | @ }OverridepublicintgetRuleIndex()
{
    return RULE_forControl;
} {

AT | @ }Overridepublic void enterRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterForControl(this);
} {

AT | @ }Overridepublic void exitRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitForControl(this);
} {

AT | @ }Overridepublic<T> Taccept(ParseTreeVisitor<?
{
    EXTENDS | extends
}

T >visitor ) { if  (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) return  ( (JavaVisitor<?
 {
EXTENDS |extends }
T > )visitor ) .visitForControl(this); else  return 
visitor.visitChildren (this )
    ;
} }
public {
FINAL |final }
ForControlContextforControl()
{
    ForControlContext _localctx = new ForControlContext(_ctx, getState());
    enterRule(_localctx, 158, RULE_forControl);
    int _la;
    try
    {
        setState(1012);
        {
            SWITCH | switch
            }

            (getInterpreter().adaptivePredict(_input, 119, _ctx))
            {
                {
                    CASE |  case
                }

                1 : 
                enterOuterAlt(_localctx, 1);
                {
                    setState(1000);
                    enhancedForControl();
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                2 : 
                enterOuterAlt(_localctx, 2);
                {
                    setState(1002);
                    _la = _input.LA(1);
                    if ((((_la)
                    {
                        BITAND | &
                    }

                    {
                        TILDE | ~
                    }

                    0x3f ) 
                    == 0 && ((1L << _la)
                    {
                        BITAND | &
                    }

                    ((1L << BOOLEAN)
                    {
                        BITOR ||
                    }

                    (1L << BYTE)
                    {
                        BITOR ||
                    }

                    (1L << CHAR)
                    {
                        BITOR ||
                    }

                    (1L << DOUBLE)
                    {
                        BITOR ||
                    }

                    (1L << FINAL)
                    {
                        BITOR ||
                    }

                    (1L << FLOAT)
                    {
                        BITOR ||
                    }

                    (1L << INT)
                    {
                        BITOR ||
                    }

                    (1L << LONG)
                    {
                        BITOR ||
                    }

                    (1L << NEW)
                    {
                        BITOR ||
                    }

                    (1L << SHORT)
                    {
                        BITOR ||
                    }

                    (1L << SUPER)
                    {
                        BITOR ||
                    }

                    (1L << THIS)
                    {
                        BITOR ||
                    }

                    (1L << VOID)
                    {
                        BITOR ||
                    }

                    (1L << IntegerLiteral)
                    {
                        BITOR ||
                    }

                    (1L << FloatingPointLiteral)
                    {
                        BITOR ||
                    }

                    (1L << BooleanLiteral)
                    {
                        BITOR ||
                    }

                    (1L << CharacterLiteral)
                    {
                        BITOR ||
                    }

                    (1L << StringLiteral)
                    {
                        BITOR ||
                    }

                    (1L << NullLiteral)
                    {
                        BITOR ||
                    }

                    (1L << LPAREN) ) ) 
                    != 0 )
                    {
                        OR || |
                    }

                    ((((_la - 68))
                    {
                        BITAND | &
                    }

                    {
                        TILDE | ~
                    }

                    0x3f ) 
                    == 0 && ((1L << (_la - 68))
                    {
                        BITAND | &
                    }

                    ((1L << (LT - 68))
                    {
                        BITOR ||
                    }

                    (1L << (BANG - 68))
                    {
                        BITOR ||
                    }

                    (1L << (TILDE - 68))
                    {
                        BITOR ||
                    }

                    (1L << (INC - 68))
                    {
                        BITOR ||
                    }

                    (1L << (DEC - 68))
                    {
                        BITOR ||
                    }

                    (1L << (ADD - 68))
                    {
                        BITOR ||
                    }

                    (1L << (SUB - 68))
                    {
                        BITOR ||
                    }

                    (1L << (Identifier - 68))
                    {
                        BITOR ||
                    }

                    (1L << (AT - 68)) ) ) 
                    != 0 ) )
                    {
                        {
                            setState(1001);
                            forInit();
                        }
                    }

                    setState(1004);
                    match(SEMI);
                    setState(1006);
                    _la = _input.LA(1);
                    if ((((_la)
                    {
                        BITAND | &
                    }

                    {
                        TILDE | ~
                    }

                    0x3f ) 
                    == 0 && ((1L << _la)
                    {
                        BITAND | &
                    }

                    ((1L << BOOLEAN)
                    {
                        BITOR ||
                    }

                    (1L << BYTE)
                    {
                        BITOR ||
                    }

                    (1L << CHAR)
                    {
                        BITOR ||
                    }

                    (1L << DOUBLE)
                    {
                        BITOR ||
                    }

                    (1L << FLOAT)
                    {
                        BITOR ||
                    }

                    (1L << INT)
                    {
                        BITOR ||
                    }

                    (1L << LONG)
                    {
                        BITOR ||
                    }

                    (1L << NEW)
                    {
                        BITOR ||
                    }

                    (1L << SHORT)
                    {
                        BITOR ||
                    }

                    (1L << SUPER)
                    {
                        BITOR ||
                    }

                    (1L << THIS)
                    {
                        BITOR ||
                    }

                    (1L << VOID)
                    {
                        BITOR ||
                    }

                    (1L << IntegerLiteral)
                    {
                        BITOR ||
                    }

                    (1L << FloatingPointLiteral)
                    {
                        BITOR ||
                    }

                    (1L << BooleanLiteral)
                    {
                        BITOR ||
                    }

                    (1L << CharacterLiteral)
                    {
                        BITOR ||
                    }

                    (1L << StringLiteral)
                    {
                        BITOR ||
                    }

                    (1L << NullLiteral)
                    {
                        BITOR ||
                    }

                    (1L << LPAREN) ) ) 
                    != 0 )
                    {
                        OR || |
                    }

                    ((((_la - 68))
                    {
                        BITAND | &
                    }

                    {
                        TILDE | ~
                    }

                    0x3f ) 
                    == 0 && ((1L << (_la - 68))
                    {
                        BITAND | &
                    }

                    ((1L << (LT - 68))
                    {
                        BITOR ||
                    }

                    (1L << (BANG - 68))
                    {
                        BITOR ||
                    }

                    (1L << (TILDE - 68))
                    {
                        BITOR ||
                    }

                    (1L << (INC - 68))
                    {
                        BITOR ||
                    }

                    (1L << (DEC - 68))
                    {
                        BITOR ||
                    }

                    (1L << (ADD - 68))
                    {
                        BITOR ||
                    }

                    (1L << (SUB - 68))
                    {
                        BITOR ||
                    }

                    (1L << (Identifier - 68)) ) ) 
                    != 0 ) )
                    {
                        {
                            setState(1005);
                            expression(0);
                        }
                    }

                    setState(1008);
                    match(SEMI);
                    setState(1010);
                    _la = _input.LA(1);
                    if ((((_la)
                    {
                        BITAND | &
                    }

                    {
                        TILDE | ~
                    }

                    0x3f ) 
                    == 0 && ((1L << _la)
                    {
                        BITAND | &
                    }

                    ((1L << BOOLEAN)
                    {
                        BITOR ||
                    }

                    (1L << BYTE)
                    {
                        BITOR ||
                    }

                    (1L << CHAR)
                    {
                        BITOR ||
                    }

                    (1L << DOUBLE)
                    {
                        BITOR ||
                    }

                    (1L << FLOAT)
                    {
                        BITOR ||
                    }

                    (1L << INT)
                    {
                        BITOR ||
                    }

                    (1L << LONG)
                    {
                        BITOR ||
                    }

                    (1L << NEW)
                    {
                        BITOR ||
                    }

                    (1L << SHORT)
                    {
                        BITOR ||
                    }

                    (1L << SUPER)
                    {
                        BITOR ||
                    }

                    (1L << THIS)
                    {
                        BITOR ||
                    }

                    (1L << VOID)
                    {
                        BITOR ||
                    }

                    (1L << IntegerLiteral)
                    {
                        BITOR ||
                    }

                    (1L << FloatingPointLiteral)
                    {
                        BITOR ||
                    }

                    (1L << BooleanLiteral)
                    {
                        BITOR ||
                    }

                    (1L << CharacterLiteral)
                    {
                        BITOR ||
                    }

                    (1L << StringLiteral)
                    {
                        BITOR ||
                    }

                    (1L << NullLiteral)
                    {
                        BITOR ||
                    }

                    (1L << LPAREN) ) ) 
                    != 0 )
                    {
                        OR || |
                    }

                    ((((_la - 68))
                    {
                        BITAND | &
                    }

                    {
                        TILDE | ~
                    }

                    0x3f ) 
                    == 0 && ((1L << (_la - 68))
                    {
                        BITAND | &
                    }

                    ((1L << (LT - 68))
                    {
                        BITOR ||
                    }

                    (1L << (BANG - 68))
                    {
                        BITOR ||
                    }

                    (1L << (TILDE - 68))
                    {
                        BITOR ||
                    }

                    (1L << (INC - 68))
                    {
                        BITOR ||
                    }

                    (1L << (DEC - 68))
                    {
                        BITOR ||
                    }

                    (1L << (ADD - 68))
                    {
                        BITOR ||
                    }

                    (1L << (SUB - 68))
                    {
                        BITOR ||
                    }

                    (1L << (Identifier - 68)) ) ) 
                    != 0 ) )
                    {
                        {
                            setState(1009);
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
        _errHandler.reportError(this, re);
        _errHandler.recover(this, re);
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        return _localctx;
    }

    publicstatic class ForInitContext
{
    EXTENDS |extends
}

ParserRuleContext {
public LocalVariableDeclarationContextlocalVariableDeclaration()
{
    return getRuleContext(LocalVariableDeclarationContext.class ,  0 ) ;  }

public ExpressionListContextexpressionList()
{
    return getRuleContext(ExpressionListContext.class ,  0 ) ;  }

publicForInitContext(ParserRuleContext parent, int invokingState)
{
    {
        SUPER | super
    }

    (parent, invokingState);
} {

AT | @ }OverridepublicintgetRuleIndex()
{
    return RULE_forInit;
} {

AT | @ }Overridepublic void enterRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterForInit(this);
} {

AT | @ }Overridepublic void exitRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitForInit(this);
} {

AT | @ }Overridepublic<T> Taccept(ParseTreeVisitor<?
{
    EXTENDS | extends
}

T >visitor ) { if  (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) return  ( (JavaVisitor<?
 {
EXTENDS |extends }
T > )visitor ) .visitForInit(this); else  return 
visitor.visitChildren (this )
    ;
} }
public {
FINAL |final }
ForInitContextforInit()
{
    ForInitContext _localctx = new ForInitContext(_ctx, getState());
    enterRule(_localctx, 160, RULE_forInit);
    try
    {
        setState(1016);
        {
            SWITCH | switch
            }

            (getInterpreter().adaptivePredict(_input, 120, _ctx))
            {
                {
                    CASE |  case
                }

                1 : 
                enterOuterAlt(_localctx, 1);
                {
                    setState(1014);
                    localVariableDeclaration();
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                2 : 
                enterOuterAlt(_localctx, 2);
                {
                    setState(1015);
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
        _errHandler.reportError(this, re);
        _errHandler.recover(this, re);
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        return _localctx;
    }

    publicstatic class EnhancedForControlContext
{
    EXTENDS |extends
}

ParserRuleContext {
public VariableModifierContextvariableModifier(int i)
{
    return getRuleContext(VariableModifierContext.class , 

i ) ;  }public List<VariableModifierContext> variableModifier()
{
    return getRuleContexts(VariableModifierContext.class ) ;  }

public VariableDeclaratorIdContextvariableDeclaratorId()
{
    return getRuleContext(VariableDeclaratorIdContext.class ,  0 ) ;  }

public TypeContexttype()
{
    return getRuleContext(TypeContext.class ,  0 ) ;  }

public ExpressionContextexpression()
{
    return getRuleContext(ExpressionContext.class ,  0 ) ;  }

publicEnhancedForControlContext(ParserRuleContext parent, int invokingState)
{
    {
        SUPER | super
    }

    (parent, invokingState);
} {

AT | @ }OverridepublicintgetRuleIndex()
{
    return RULE_enhancedForControl;
} {

AT | @ }Overridepublic void enterRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterEnhancedForControl(this);
} {

AT | @ }Overridepublic void exitRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitEnhancedForControl(this);
} {

AT | @ }Overridepublic<T> Taccept(ParseTreeVisitor<?
{
    EXTENDS | extends
}

T >visitor ) { if  (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) return  ( (JavaVisitor<?
 {
EXTENDS |extends }
T > )visitor ) .visitEnhancedForControl(this); else  return 
visitor.visitChildren (this )
    ;
} }
public {
FINAL |final }
EnhancedForControlContextenhancedForControl()
{
    EnhancedForControlContext _localctx = new EnhancedForControlContext(_ctx, getState());
    enterRule(_localctx, 162, RULE_enhancedForControl);
    int _la;
    try
    {
        enterOuterAlt(_localctx, 1);
        {
            setState(1021);
            _errHandler.sync(this);
            _la = _input.LA(1);
            {
                WHILE | while
            }

            (_la == FINAL
            {
                OR || |
            }

            _la == AT )
            {
                {
                    {
                        setState(1018);
                        variableModifier();
                    }
                }

                setState(1023);
                _errHandler.sync(this);
                _la = _input.LA(1);
            }

            setState(1024);
            type();
            setState(1025);
            variableDeclaratorId();
            setState(1026);
            match(COLON);
            setState(1027);
            expression(0);
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(this, re);
        _errHandler.recover(this, re);
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        return _localctx;
    }

    publicstatic class ForUpdateContext
{
    EXTENDS |extends
}

ParserRuleContext {
public ExpressionListContextexpressionList()
{
    return getRuleContext(ExpressionListContext.class ,  0 ) ;  }

publicForUpdateContext(ParserRuleContext parent, int invokingState)
{
    {
        SUPER | super
    }

    (parent, invokingState);
} {

AT | @ }OverridepublicintgetRuleIndex()
{
    return RULE_forUpdate;
} {

AT | @ }Overridepublic void enterRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterForUpdate(this);
} {

AT | @ }Overridepublic void exitRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitForUpdate(this);
} {

AT | @ }Overridepublic<T> Taccept(ParseTreeVisitor<?
{
    EXTENDS | extends
}

T >visitor ) { if  (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) return  ( (JavaVisitor<?
 {
EXTENDS |extends }
T > )visitor ) .visitForUpdate(this); else  return 
visitor.visitChildren (this )
    ;
} }
public {
FINAL |final }
ForUpdateContextforUpdate()
{
    ForUpdateContext _localctx = new ForUpdateContext(_ctx, getState());
    enterRule(_localctx, 164, RULE_forUpdate);
    try
    {
        enterOuterAlt(_localctx, 1);
        {
            setState(1029);
            expressionList();
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(this, re);
        _errHandler.recover(this, re);
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        return _localctx;
    }

    publicstatic class ParExpressionContext
{
    EXTENDS |extends
}

ParserRuleContext {
public ExpressionContextexpression()
{
    return getRuleContext(ExpressionContext.class ,  0 ) ;  }

publicParExpressionContext(ParserRuleContext parent, int invokingState)
{
    {
        SUPER | super
    }

    (parent, invokingState);
} {

AT | @ }OverridepublicintgetRuleIndex()
{
    return RULE_parExpression;
} {

AT | @ }Overridepublic void enterRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterParExpression(this);
} {

AT | @ }Overridepublic void exitRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitParExpression(this);
} {

AT | @ }Overridepublic<T> Taccept(ParseTreeVisitor<?
{
    EXTENDS | extends
}

T >visitor ) { if  (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) return  ( (JavaVisitor<?
 {
EXTENDS |extends }
T > )visitor ) .visitParExpression(this); else  return 
visitor.visitChildren (this )
    ;
} }
public {
FINAL |final }
ParExpressionContextparExpression()
{
    ParExpressionContext _localctx = new ParExpressionContext(_ctx, getState());
    enterRule(_localctx, 166, RULE_parExpression);
    try
    {
        enterOuterAlt(_localctx, 1);
        {
            setState(1031);
            match(LPAREN);
            setState(1032);
            expression(0);
            setState(1033);
            match(RPAREN);
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(this, re);
        _errHandler.recover(this, re);
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        return _localctx;
    }

    publicstatic class ExpressionListContext
{
    EXTENDS |extends
}

ParserRuleContext {
public ExpressionContextexpression(int i)
{
    return getRuleContext(ExpressionContext.class , 

i ) ;  }public List<ExpressionContext> expression()
{
    return getRuleContexts(ExpressionContext.class ) ;  }

publicExpressionListContext(ParserRuleContext parent, int invokingState)
{
    {
        SUPER | super
    }

    (parent, invokingState);
} {

AT | @ }OverridepublicintgetRuleIndex()
{
    return RULE_expressionList;
} {

AT | @ }Overridepublic void enterRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterExpressionList(this);
} {

AT | @ }Overridepublic void exitRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitExpressionList(this);
} {

AT | @ }Overridepublic<T> Taccept(ParseTreeVisitor<?
{
    EXTENDS | extends
}

T >visitor ) { if  (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) return  ( (JavaVisitor<?
 {
EXTENDS |extends }
T > )visitor ) .visitExpressionList(this); else  return 
visitor.visitChildren (this )
    ;
} }
public {
FINAL |final }
ExpressionListContextexpressionList()
{
    ExpressionListContext _localctx = new ExpressionListContext(_ctx, getState());
    enterRule(_localctx, 168, RULE_expressionList);
    int _la;
    try
    {
        enterOuterAlt(_localctx, 1);
        {
            setState(1035);
            expression(0);
            setState(1040);
            _errHandler.sync(this);
            _la = _input.LA(1);
            {
                WHILE | while
            }

            (_la == COMMA)
            {
                {
                    {
                        setState(1036);
                        match(COMMA);
                        setState(1037);
                        expression(0);
                    }
                }

                setState(1042);
                _errHandler.sync(this);
                _la = _input.LA(1);
            }
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(this, re);
        _errHandler.recover(this, re);
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        return _localctx;
    }

    publicstatic class StatementExpressionContext
{
    EXTENDS |extends
}

ParserRuleContext {
public ExpressionContextexpression()
{
    return getRuleContext(ExpressionContext.class ,  0 ) ;  }

publicStatementExpressionContext(ParserRuleContext parent, int invokingState)
{
    {
        SUPER | super
    }

    (parent, invokingState);
} {

AT | @ }OverridepublicintgetRuleIndex()
{
    return RULE_statementExpression;
} {

AT | @ }Overridepublic void enterRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterStatementExpression(this);
} {

AT | @ }Overridepublic void exitRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitStatementExpression(this);
} {

AT | @ }Overridepublic<T> Taccept(ParseTreeVisitor<?
{
    EXTENDS | extends
}

T >visitor ) { if  (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) return  ( (JavaVisitor<?
 {
EXTENDS |extends }
T > )visitor ) .visitStatementExpression(this); else  return 
visitor.visitChildren (this )
    ;
} }
public {
FINAL |final }
StatementExpressionContextstatementExpression()
{
    StatementExpressionContext _localctx = new StatementExpressionContext(_ctx, getState());
    enterRule(_localctx, 170, RULE_statementExpression);
    try
    {
        enterOuterAlt(_localctx, 1);
        {
            setState(1043);
            expression(0);
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(this, re);
        _errHandler.recover(this, re);
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        return _localctx;
    }

    publicstatic class ConstantExpressionContext
{
    EXTENDS |extends
}

ParserRuleContext {
public ExpressionContextexpression()
{
    return getRuleContext(ExpressionContext.class ,  0 ) ;  }

publicConstantExpressionContext(ParserRuleContext parent, int invokingState)
{
    {
        SUPER | super
    }

    (parent, invokingState);
} {

AT | @ }OverridepublicintgetRuleIndex()
{
    return RULE_constantExpression;
} {

AT | @ }Overridepublic void enterRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterConstantExpression(this);
} {

AT | @ }Overridepublic void exitRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitConstantExpression(this);
} {

AT | @ }Overridepublic<T> Taccept(ParseTreeVisitor<?
{
    EXTENDS | extends
}

T >visitor ) { if  (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) return  ( (JavaVisitor<?
 {
EXTENDS |extends }
T > )visitor ) .visitConstantExpression(this); else  return 
visitor.visitChildren (this )
    ;
} }
public {
FINAL |final }
ConstantExpressionContextconstantExpression()
{
    ConstantExpressionContext _localctx = new ConstantExpressionContext(_ctx, getState());
    enterRule(_localctx, 172, RULE_constantExpression);
    try
    {
        enterOuterAlt(_localctx, 1);
        {
            setState(1045);
            expression(0);
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(this, re);
        _errHandler.recover(this, re);
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        return _localctx;
    }

    publicstatic class ExpressionContext
{
    EXTENDS |extends
}

ParserRuleContext {
public TerminalNodeIdentifier()
{
    return getToken(JavaParser.Identifier, 0);
}

public NonWildcardTypeArgumentsContextnonWildcardTypeArguments()
{
    return getRuleContext(NonWildcardTypeArgumentsContext.class ,  0 ) ;  }

public ExplicitGenericInvocationContextexplicitGenericInvocation()
{
    return getRuleContext(ExplicitGenericInvocationContext.class ,  0 ) ;  }

public ExpressionListContextexpressionList()
{
    return getRuleContext(ExpressionListContext.class ,  0 ) ;  }

public InnerCreatorContextinnerCreator()
{
    return getRuleContext(InnerCreatorContext.class ,  0 ) ;  }

public SuperSuffixContextsuperSuffix()
{
    return getRuleContext(SuperSuffixContext.class ,  0 ) ;  }

public ExpressionContextexpression(int i)
{
    return getRuleContext(ExpressionContext.class , 

i ) ;  }public PrimaryContextprimary()
{
    return getRuleContext(PrimaryContext.class ,  0 ) ;  }

public TypeContexttype()
{
    return getRuleContext(TypeContext.class ,  0 ) ;  }

public List<ExpressionContext> expression()
{
    return getRuleContexts(ExpressionContext.class ) ;  }

public CreatorContextcreator()
{
    return getRuleContext(CreatorContext.class ,  0 ) ;  }

publicExpressionContext(ParserRuleContext parent, int invokingState)
{
    {
        SUPER | super
    }

    (parent, invokingState);
} {

AT | @ }OverridepublicintgetRuleIndex()
{
    return RULE_expression;
} {

AT | @ }Overridepublic void enterRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterExpression(this);
} {

AT | @ }Overridepublic void exitRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitExpression(this);
} {

AT | @ }Overridepublic<T> Taccept(ParseTreeVisitor<?
{
    EXTENDS | extends
}

T >visitor ) { if  (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) return  ( (JavaVisitor<?
 {
EXTENDS |extends }
T > )visitor ) .visitExpression(this); else  return 
visitor.visitChildren (this )
    ;
} }
public {
FINAL |final }
ExpressionContextexpression()
{
    return expression(0);
}

private ExpressionContextexpression(int _p)
{
    ParserRuleContext _parentctx = _ctx;
    int _parentState = getState();
    ExpressionContext _localctx = new ExpressionContext(_ctx, _parentState);
    ExpressionContext _prevctx = _localctx;
    int _startState = 174;
    enterRecursionRule(_localctx, 174, RULE_expression, _p);
    int _la;
    try
    {
        int _alt;
        enterOuterAlt(_localctx, 1);
        {
            setState(1060);
            {
                SWITCH | switch
                }

                (getInterpreter().adaptivePredict(_input, 123, _ctx))
                {
                    {
                        CASE |  case
                    }

                    1 : 
                    {
                        setState(1048);
                        match(LPAREN);
                        setState(1049);
                        type();
                        setState(1050);
                        match(RPAREN);
                        setState(1051);
                        expression(17);
                    }

                    {
                        BREAK | break
                    }

                    ;
                    {
                        CASE |  case
                    }

                    2 : 
                    {
                        setState(1053);
                        _la = _input.LA(1);
                        if (
                        {
                            BANG | !
                        }

                        (((((_la - 79))
                        {
                            BITAND | &
                        }

                        {
                            TILDE | ~
                        }

                        0x3f ) 
                        == 0 && ((1L << (_la - 79))
                        {
                            BITAND | &
                        }

                        ((1L << (INC - 79))
                        {
                            BITOR ||
                        }

                        (1L << (DEC - 79))
                        {
                            BITOR ||
                        }

                        (1L << (ADD - 79))
                        {
                            BITOR ||
                        }

                        (1L << (SUB - 79)) ) ) 
                        != 0 ) ) )
                        {
                            _errHandler.recoverInline(this);
                        }

                        consume();
                        setState(1054);
                        expression(15);
                    }

                    {
                        BREAK | break
                    }

                    ;
                    {
                        CASE |  case
                    }

                    3 : 
                    {
                        setState(1055);
                        _la = _input.LA(1);
                        if (
                        {
                            BANG | !
                        }

                        (_la == BANG
                        {
                            OR || |
                        }

                        _la == TILDE ) )
                        {
                            _errHandler.recoverInline(this);
                        }

                        consume();
                        setState(1056);
                        expression(14);
                    }

                    {
                        BREAK | break
                    }

                    ;
                    {
                        CASE |  case
                    }

                    4 : 
                    {
                        setState(1057);
                        primary();
                    }

                    {
                        BREAK | break
                    }

                    ;
                    {
                        CASE |  case
                    }

                    5 : 
                    {
                        setState(1058);
                        match(NEW);
                        setState(1059);
                        creator();
                    }

                    {
                        BREAK | break
                    }

                    ;
                }

                _ctx.stop = _input.LT(-1);
                setState(1147);
                _errHandler.sync(this);
                _alt = getInterpreter().adaptivePredict(_input, 128, _ctx);
                {
                    WHILE | while
                }

                (_alt != 2 && _alt != org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER)
                {
                    if (_alt == 1)
                    {
                        if (_parseListeners != null)
                            triggerExitRuleEvent();
                        _prevctx = _localctx;
                        {
                            setState(1145);
                            {
                                SWITCH | switch
                                }

                                (getInterpreter().adaptivePredict(_input, 127, _ctx))
                                {
                                    {
                                        CASE |  case
                                    }

                                    1 : 
                                    {
                                        _localctx = new ExpressionContext(_parentctx, _parentState);
                                        pushNewRecursionContext(_localctx, _startState, RULE_expression);
                                        setState(1062);
                                        if (
                                        {
                                            BANG | !
                                        }

                                        (precpred(_ctx, 13)) )
                                        throw new FailedPredicateException(this, "precpred(_ctx, 13)");
                                        setState(1063);
                                        _la = _input.LA(1);
                                        if (
                                        {
                                            BANG | !
                                        }

                                        (((((_la - 83))
                                        {
                                            BITAND | &
                                        }

                                        {
                                            TILDE | ~
                                        }

                                        0x3f ) 
                                        == 0 && ((1L << (_la - 83))
                                        {
                                            BITAND | &
                                        }

                                        ((1L << (MUL - 83))
                                        {
                                            BITOR ||
                                        }

                                        (1L << (DIV - 83))
                                        {
                                            BITOR ||
                                        }

                                        (1L << (MOD - 83)) ) ) 
                                        != 0 ) ) )
                                        {
                                            _errHandler.recoverInline(this);
                                        }

                                        consume();
                                        setState(1064);
                                        expression(14);
                                    }

                                    {
                                        BREAK | break
                                    }

                                    ;
                                    {
                                        CASE |  case
                                    }

                                    2 : 
                                    {
                                        _localctx = new ExpressionContext(_parentctx, _parentState);
                                        pushNewRecursionContext(_localctx, _startState, RULE_expression);
                                        setState(1065);
                                        if (
                                        {
                                            BANG | !
                                        }

                                        (precpred(_ctx, 12)) )
                                        throw new FailedPredicateException(this, "precpred(_ctx, 12)");
                                        setState(1066);
                                        _la = _input.LA(1);
                                        if (
                                        {
                                            BANG | !
                                        }

                                        (_la == ADD
                                        {
                                            OR || |
                                        }

                                        _la == SUB ) )
                                        {
                                            _errHandler.recoverInline(this);
                                        }

                                        consume();
                                        setState(1067);
                                        expression(13);
                                    }

                                    {
                                        BREAK | break
                                    }

                                    ;
                                    {
                                        CASE |  case
                                    }

                                    3 : 
                                    {
                                        _localctx = new ExpressionContext(_parentctx, _parentState);
                                        pushNewRecursionContext(_localctx, _startState, RULE_expression);
                                        setState(1068);
                                        if (
                                        {
                                            BANG | !
                                        }

                                        (precpred(_ctx, 11)) )
                                        throw new FailedPredicateException(this, "precpred(_ctx, 11)");
                                        setState(1076);
                                        {
                                            SWITCH | switch
                                            }

                                            (getInterpreter().adaptivePredict(_input, 124, _ctx))
                                            {
                                                {
                                                    CASE |  case
                                                }

                                                1 : 
                                                {
                                                    setState(1069);
                                                    match(LT);
                                                    setState(1070);
                                                    match(LT);
                                                }

                                                {
                                                    BREAK | break
                                                }

                                                ;
                                                {
                                                    CASE |  case
                                                }

                                                2 : 
                                                {
                                                    setState(1071);
                                                    match(GT);
                                                    setState(1072);
                                                    match(GT);
                                                    setState(1073);
                                                    match(GT);
                                                }

                                                {
                                                    BREAK | break
                                                }

                                                ;
                                                {
                                                    CASE |  case
                                                }

                                                3 : 
                                                {
                                                    setState(1074);
                                                    match(GT);
                                                    setState(1075);
                                                    match(GT);
                                                }

                                                {
                                                    BREAK | break
                                                }

                                                ;
                                            }

                                            setState(1078);
                                            expression(12);
                                        }

                                        {
                                            BREAK | break
                                        }

                                        ;
                                        {
                                            CASE |  case
                                        }

                                        4 : 
                                        {
                                            _localctx = new ExpressionContext(_parentctx, _parentState);
                                            pushNewRecursionContext(_localctx, _startState, RULE_expression);
                                            setState(1079);
                                            if (
                                            {
                                                BANG | !
                                            }

                                            (precpred(_ctx, 10)) )
                                            throw new FailedPredicateException(this, "precpred(_ctx, 10)");
                                            setState(1080);
                                            _la = _input.LA(1);
                                            if (
                                            {
                                                BANG | !
                                            }

                                            (((((_la - 67))
                                            {
                                                BITAND | &
                                            }

                                            {
                                                TILDE | ~
                                            }

                                            0x3f ) 
                                            == 0 && ((1L << (_la - 67))
                                            {
                                                BITAND | &
                                            }

                                            ((1L << (GT - 67))
                                            {
                                                BITOR ||
                                            }

                                            (1L << (LT - 67))
                                            {
                                                BITOR ||
                                            }

                                            (1L << (LE - 67))
                                            {
                                                BITOR ||
                                            }

                                            (1L << (GE - 67)) ) ) 
                                            != 0 ) ) )
                                            {
                                                _errHandler.recoverInline(this);
                                            }

                                            consume();
                                            setState(1081);
                                            expression(11);
                                        }

                                        {
                                            BREAK | break
                                        }

                                        ;
                                        {
                                            CASE |  case
                                        }

                                        5 : 
                                        {
                                            _localctx = new ExpressionContext(_parentctx, _parentState);
                                            pushNewRecursionContext(_localctx, _startState, RULE_expression);
                                            setState(1082);
                                            if (
                                            {
                                                BANG | !
                                            }

                                            (precpred(_ctx, 8)) )
                                            throw new FailedPredicateException(this, "precpred(_ctx, 8)");
                                            setState(1083);
                                            _la = _input.LA(1);
                                            if (
                                            {
                                                BANG | !
                                            }

                                            (_la == EQUAL
                                            {
                                                OR || |
                                            }

                                            _la == NOTEQUAL ) )
                                            {
                                                _errHandler.recoverInline(this);
                                            }

                                            consume();
                                            setState(1084);
                                            expression(9);
                                        }

                                        {
                                            BREAK | break
                                        }

                                        ;
                                        {
                                            CASE |  case
                                        }

                                        6 : 
                                        {
                                            _localctx = new ExpressionContext(_parentctx, _parentState);
                                            pushNewRecursionContext(_localctx, _startState, RULE_expression);
                                            setState(1085);
                                            if (
                                            {
                                                BANG | !
                                            }

                                            (precpred(_ctx, 7)) )
                                            throw new FailedPredicateException(this, "precpred(_ctx, 7)");
                                            setState(1086);
                                            match(BITAND);
                                            setState(1087);
                                            expression(8);
                                        }

                                        {
                                            BREAK | break
                                        }

                                        ;
                                        {
                                            CASE |  case
                                        }

                                        7 : 
                                        {
                                            _localctx = new ExpressionContext(_parentctx, _parentState);
                                            pushNewRecursionContext(_localctx, _startState, RULE_expression);
                                            setState(1088);
                                            if (
                                            {
                                                BANG | !
                                            }

                                            (precpred(_ctx, 6)) )
                                            throw new FailedPredicateException(this, "precpred(_ctx, 6)");
                                            setState(1089);
                                            match(CARET);
                                            setState(1090);
                                            expression(7);
                                        }

                                        {
                                            BREAK | break
                                        }

                                        ;
                                        {
                                            CASE |  case
                                        }

                                        8 : 
                                        {
                                            _localctx = new ExpressionContext(_parentctx, _parentState);
                                            pushNewRecursionContext(_localctx, _startState, RULE_expression);
                                            setState(1091);
                                            if (
                                            {
                                                BANG | !
                                            }

                                            (precpred(_ctx, 5)) )
                                            throw new FailedPredicateException(this, "precpred(_ctx, 5)");
                                            setState(1092);
                                            match(BITOR);
                                            setState(1093);
                                            expression(6);
                                        }

                                        {
                                            BREAK | break
                                        }

                                        ;
                                        {
                                            CASE |  case
                                        }

                                        9 : 
                                        {
                                            _localctx = new ExpressionContext(_parentctx, _parentState);
                                            pushNewRecursionContext(_localctx, _startState, RULE_expression);
                                            setState(1094);
                                            if (
                                            {
                                                BANG | !
                                            }

                                            (precpred(_ctx, 4)) )
                                            throw new FailedPredicateException(this, "precpred(_ctx, 4)");
                                            setState(1095);
                                            match(AND);
                                            setState(1096);
                                            expression(5);
                                        }

                                        {
                                            BREAK | break
                                        }

                                        ;
                                        {
                                            CASE |  case
                                        }

                                        10 : 
                                        {
                                            _localctx = new ExpressionContext(_parentctx, _parentState);
                                            pushNewRecursionContext(_localctx, _startState, RULE_expression);
                                            setState(1097);
                                            if (
                                            {
                                                BANG | !
                                            }

                                            (precpred(_ctx, 3)) )
                                            throw new FailedPredicateException(this, "precpred(_ctx, 3)");
                                            setState(1098);
                                            match(OR);
                                            setState(1099);
                                            expression(4);
                                        }

                                        {
                                            BREAK | break
                                        }

                                        ;
                                        {
                                            CASE |  case
                                        }

                                        11 : 
                                        {
                                            _localctx = new ExpressionContext(_parentctx, _parentState);
                                            pushNewRecursionContext(_localctx, _startState, RULE_expression);
                                            setState(1100);
                                            if (
                                            {
                                                BANG | !
                                            }

                                            (precpred(_ctx, 2)) )
                                            throw new FailedPredicateException(this, "precpred(_ctx, 2)");
                                            setState(1101);
                                            match(QUESTION);
                                            setState(1102);
                                            expression(0);
                                            setState(1103);
                                            match(COLON);
                                            setState(1104);
                                            expression(3);
                                        }

                                        {
                                            BREAK | break
                                        }

                                        ;
                                        {
                                            CASE |  case
                                        }

                                        12 : 
                                        {
                                            _localctx = new ExpressionContext(_parentctx, _parentState);
                                            pushNewRecursionContext(_localctx, _startState, RULE_expression);
                                            setState(1106);
                                            if (
                                            {
                                                BANG | !
                                            }

                                            (precpred(_ctx, 1)) )
                                            throw new FailedPredicateException(this, "precpred(_ctx, 1)");
                                            setState(1107);
                                            _la = _input.LA(1);
                                            if (
                                            {
                                                BANG | !
                                            }

                                            (((((_la - 66))
                                            {
                                                BITAND | &
                                            }

                                            {
                                                TILDE | ~
                                            }

                                            0x3f ) 
                                            == 0 && ((1L << (_la - 66))
                                            {
                                                BITAND | &
                                            }

                                            ((1L << (ASSIGN - 66))
                                            {
                                                BITOR ||
                                            }

                                            (1L << (ADD_ASSIGN - 66))
                                            {
                                                BITOR ||
                                            }

                                            (1L << (SUB_ASSIGN - 66))
                                            {
                                                BITOR ||
                                            }

                                            (1L << (MUL_ASSIGN - 66))
                                            {
                                                BITOR ||
                                            }

                                            (1L << (DIV_ASSIGN - 66))
                                            {
                                                BITOR ||
                                            }

                                            (1L << (AND_ASSIGN - 66))
                                            {
                                                BITOR ||
                                            }

                                            (1L << (OR_ASSIGN - 66))
                                            {
                                                BITOR ||
                                            }

                                            (1L << (XOR_ASSIGN - 66))
                                            {
                                                BITOR ||
                                            }

                                            (1L << (MOD_ASSIGN - 66))
                                            {
                                                BITOR ||
                                            }

                                            (1L << (LSHIFT_ASSIGN - 66))
                                            {
                                                BITOR ||
                                            }

                                            (1L << (RSHIFT_ASSIGN - 66))
                                            {
                                                BITOR ||
                                            }

                                            (1L << (URSHIFT_ASSIGN - 66)) ) ) 
                                            != 0 ) ) )
                                            {
                                                _errHandler.recoverInline(this);
                                            }

                                            consume();
                                            setState(1108);
                                            expression(1);
                                        }

                                        {
                                            BREAK | break
                                        }

                                        ;
                                        {
                                            CASE |  case
                                        }

                                        13 : 
                                        {
                                            _localctx = new ExpressionContext(_parentctx, _parentState);
                                            pushNewRecursionContext(_localctx, _startState, RULE_expression);
                                            setState(1109);
                                            if (
                                            {
                                                BANG | !
                                            }

                                            (precpred(_ctx, 25)) )
                                            throw new FailedPredicateException(this, "precpred(_ctx, 25)");
                                            setState(1110);
                                            match(DOT);
                                            setState(1111);
                                            match(Identifier);
                                        }

                                        {
                                            BREAK | break
                                        }

                                        ;
                                        {
                                            CASE |  case
                                        }

                                        14 : 
                                        {
                                            _localctx = new ExpressionContext(_parentctx, _parentState);
                                            pushNewRecursionContext(_localctx, _startState, RULE_expression);
                                            setState(1112);
                                            if (
                                            {
                                                BANG | !
                                            }

                                            (precpred(_ctx, 24)) )
                                            throw new FailedPredicateException(this, "precpred(_ctx, 24)");
                                            setState(1113);
                                            match(DOT);
                                            setState(1114);
                                            match(THIS);
                                        }

                                        {
                                            BREAK | break
                                        }

                                        ;
                                        {
                                            CASE |  case
                                        }

                                        15 : 
                                        {
                                            _localctx = new ExpressionContext(_parentctx, _parentState);
                                            pushNewRecursionContext(_localctx, _startState, RULE_expression);
                                            setState(1115);
                                            if (
                                            {
                                                BANG | !
                                            }

                                            (precpred(_ctx, 23)) )
                                            throw new FailedPredicateException(this, "precpred(_ctx, 23)");
                                            setState(1116);
                                            match(DOT);
                                            setState(1117);
                                            match(NEW);
                                            setState(1119);
                                            _la = _input.LA(1);
                                            if (_la == LT)
                                            {
                                                {
                                                    setState(1118);
                                                    nonWildcardTypeArguments();
                                                }
                                            }

                                            setState(1121);
                                            innerCreator();
                                        }

                                        {
                                            BREAK | break
                                        }

                                        ;
                                        {
                                            CASE |  case
                                        }

                                        16 : 
                                        {
                                            _localctx = new ExpressionContext(_parentctx, _parentState);
                                            pushNewRecursionContext(_localctx, _startState, RULE_expression);
                                            setState(1122);
                                            if (
                                            {
                                                BANG | !
                                            }

                                            (precpred(_ctx, 22)) )
                                            throw new FailedPredicateException(this, "precpred(_ctx, 22)");
                                            setState(1123);
                                            match(DOT);
                                            setState(1124);
                                            match(SUPER);
                                            setState(1125);
                                            superSuffix();
                                        }

                                        {
                                            BREAK | break
                                        }

                                        ;
                                        {
                                            CASE |  case
                                        }

                                        17 : 
                                        {
                                            _localctx = new ExpressionContext(_parentctx, _parentState);
                                            pushNewRecursionContext(_localctx, _startState, RULE_expression);
                                            setState(1126);
                                            if (
                                            {
                                                BANG | !
                                            }

                                            (precpred(_ctx, 21)) )
                                            throw new FailedPredicateException(this, "precpred(_ctx, 21)");
                                            setState(1127);
                                            match(DOT);
                                            setState(1128);
                                            explicitGenericInvocation();
                                        }

                                        {
                                            BREAK | break
                                        }

                                        ;
                                        {
                                            CASE |  case
                                        }

                                        18 : 
                                        {
                                            _localctx = new ExpressionContext(_parentctx, _parentState);
                                            pushNewRecursionContext(_localctx, _startState, RULE_expression);
                                            setState(1129);
                                            if (
                                            {
                                                BANG | !
                                            }

                                            (precpred(_ctx, 20)) )
                                            throw new FailedPredicateException(this, "precpred(_ctx, 20)");
                                            setState(1130);
                                            match(LBRACK);
                                            setState(1131);
                                            expression(0);
                                            setState(1132);
                                            match(RBRACK);
                                        }

                                        {
                                            BREAK | break
                                        }

                                        ;
                                        {
                                            CASE |  case
                                        }

                                        19 : 
                                        {
                                            _localctx = new ExpressionContext(_parentctx, _parentState);
                                            pushNewRecursionContext(_localctx, _startState, RULE_expression);
                                            setState(1134);
                                            if (
                                            {
                                                BANG | !
                                            }

                                            (precpred(_ctx, 19)) )
                                            throw new FailedPredicateException(this, "precpred(_ctx, 19)");
                                            setState(1135);
                                            match(LPAREN);
                                            setState(1137);
                                            _la = _input.LA(1);
                                            if ((((_la)
                                            {
                                                BITAND | &
                                            }

                                            {
                                                TILDE | ~
                                            }

                                            0x3f ) 
                                            == 0 && ((1L << _la)
                                            {
                                                BITAND | &
                                            }

                                            ((1L << BOOLEAN)
                                            {
                                                BITOR ||
                                            }

                                            (1L << BYTE)
                                            {
                                                BITOR ||
                                            }

                                            (1L << CHAR)
                                            {
                                                BITOR ||
                                            }

                                            (1L << DOUBLE)
                                            {
                                                BITOR ||
                                            }

                                            (1L << FLOAT)
                                            {
                                                BITOR ||
                                            }

                                            (1L << INT)
                                            {
                                                BITOR ||
                                            }

                                            (1L << LONG)
                                            {
                                                BITOR ||
                                            }

                                            (1L << NEW)
                                            {
                                                BITOR ||
                                            }

                                            (1L << SHORT)
                                            {
                                                BITOR ||
                                            }

                                            (1L << SUPER)
                                            {
                                                BITOR ||
                                            }

                                            (1L << THIS)
                                            {
                                                BITOR ||
                                            }

                                            (1L << VOID)
                                            {
                                                BITOR ||
                                            }

                                            (1L << IntegerLiteral)
                                            {
                                                BITOR ||
                                            }

                                            (1L << FloatingPointLiteral)
                                            {
                                                BITOR ||
                                            }

                                            (1L << BooleanLiteral)
                                            {
                                                BITOR ||
                                            }

                                            (1L << CharacterLiteral)
                                            {
                                                BITOR ||
                                            }

                                            (1L << StringLiteral)
                                            {
                                                BITOR ||
                                            }

                                            (1L << NullLiteral)
                                            {
                                                BITOR ||
                                            }

                                            (1L << LPAREN) ) ) 
                                            != 0 )
                                            {
                                                OR || |
                                            }

                                            ((((_la - 68))
                                            {
                                                BITAND | &
                                            }

                                            {
                                                TILDE | ~
                                            }

                                            0x3f ) 
                                            == 0 && ((1L << (_la - 68))
                                            {
                                                BITAND | &
                                            }

                                            ((1L << (LT - 68))
                                            {
                                                BITOR ||
                                            }

                                            (1L << (BANG - 68))
                                            {
                                                BITOR ||
                                            }

                                            (1L << (TILDE - 68))
                                            {
                                                BITOR ||
                                            }

                                            (1L << (INC - 68))
                                            {
                                                BITOR ||
                                            }

                                            (1L << (DEC - 68))
                                            {
                                                BITOR ||
                                            }

                                            (1L << (ADD - 68))
                                            {
                                                BITOR ||
                                            }

                                            (1L << (SUB - 68))
                                            {
                                                BITOR ||
                                            }

                                            (1L << (Identifier - 68)) ) ) 
                                            != 0 ) )
                                            {
                                                {
                                                    setState(1136);
                                                    expressionList();
                                                }
                                            }

                                            setState(1139);
                                            match(RPAREN);
                                        }

                                        {
                                            BREAK | break
                                        }

                                        ;
                                        {
                                            CASE |  case
                                        }

                                        20 : 
                                        {
                                            _localctx = new ExpressionContext(_parentctx, _parentState);
                                            pushNewRecursionContext(_localctx, _startState, RULE_expression);
                                            setState(1140);
                                            if (
                                            {
                                                BANG | !
                                            }

                                            (precpred(_ctx, 16)) )
                                            throw new FailedPredicateException(this, "precpred(_ctx, 16)");
                                            setState(1141);
                                            _la = _input.LA(1);
                                            if (
                                            {
                                                BANG | !
                                            }

                                            (_la == INC
                                            {
                                                OR || |
                                            }

                                            _la == DEC ) )
                                            {
                                                _errHandler.recoverInline(this);
                                            }

                                            consume();
                                        }

                                        {
                                            BREAK | break
                                        }

                                        ;
                                        {
                                            CASE |  case
                                        }

                                        21 : 
                                        {
                                            _localctx = new ExpressionContext(_parentctx, _parentState);
                                            pushNewRecursionContext(_localctx, _startState, RULE_expression);
                                            setState(1142);
                                            if (
                                            {
                                                BANG | !
                                            }

                                            (precpred(_ctx, 9)) )
                                            throw new FailedPredicateException(this, "precpred(_ctx, 9)");
                                            setState(1143);
                                            match(INSTANCEOF);
                                            setState(1144);
                                            type();
                                        }

                                        {
                                            BREAK | break
                                        }

                                        ;
                                    }
                                }
                            }

                            setState(1149);
                            _errHandler.sync(this);
                            _alt = getInterpreter().adaptivePredict(_input, 128, _ctx);
                        }
                    }
                }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(this, re);
        _errHandler.recover(this, re);
    }

    {
        FINALLY |
        finally
        }

        {
            unrollRecursionContexts(_parentctx);
        }

        return _localctx;
    }

    publicstatic class PrimaryContext
{
    EXTENDS |extends
}

ParserRuleContext {
public TerminalNodeIdentifier()
{
    return getToken(JavaParser.Identifier, 0);
}

public NonWildcardTypeArgumentsContextnonWildcardTypeArguments()
{
    return getRuleContext(NonWildcardTypeArgumentsContext.class ,  0 ) ;  }

public ExplicitGenericInvocationSuffixContextexplicitGenericInvocationSuffix()
{
    return getRuleContext(ExplicitGenericInvocationSuffixContext.class ,  0 ) ;  }

public LiteralContextliteral()
{
    return getRuleContext(LiteralContext.class ,  0 ) ;  }

public TypeContexttype()
{
    return getRuleContext(TypeContext.class ,  0 ) ;  }

public ArgumentsContextarguments()
{
    return getRuleContext(ArgumentsContext.class ,  0 ) ;  }

public ExpressionContextexpression()
{
    return getRuleContext(ExpressionContext.class ,  0 ) ;  }

publicPrimaryContext(ParserRuleContext parent, int invokingState)
{
    {
        SUPER | super
    }

    (parent, invokingState);
} {

AT | @ }OverridepublicintgetRuleIndex()
{
    return RULE_primary;
} {

AT | @ }Overridepublic void enterRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterPrimary(this);
} {

AT | @ }Overridepublic void exitRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitPrimary(this);
} {

AT | @ }Overridepublic<T> Taccept(ParseTreeVisitor<?
{
    EXTENDS | extends
}

T >visitor ) { if  (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) return  ( (JavaVisitor<?
 {
EXTENDS |extends }
T > )visitor ) .visitPrimary(this); else  return 
visitor.visitChildren (this )
    ;
} }
public {
FINAL |final }
PrimaryContextprimary()
{
    PrimaryContext _localctx = new PrimaryContext(_ctx, getState());
    enterRule(_localctx, 176, RULE_primary);
    try
    {
        setState(1171);
        {
            SWITCH | switch
            }

            (getInterpreter().adaptivePredict(_input, 130, _ctx))
            {
                {
                    CASE |  case
                }

                1 : 
                enterOuterAlt(_localctx, 1);
                {
                    setState(1150);
                    match(LPAREN);
                    setState(1151);
                    expression(0);
                    setState(1152);
                    match(RPAREN);
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                2 : 
                enterOuterAlt(_localctx, 2);
                {
                    setState(1154);
                    match(THIS);
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                3 : 
                enterOuterAlt(_localctx, 3);
                {
                    setState(1155);
                    match(SUPER);
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                4 : 
                enterOuterAlt(_localctx, 4);
                {
                    setState(1156);
                    literal();
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                5 : 
                enterOuterAlt(_localctx, 5);
                {
                    setState(1157);
                    match(Identifier);
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                6 : 
                enterOuterAlt(_localctx, 6);
                {
                    setState(1158);
                    type();
                    setState(1159);
                    match(DOT);
                    setState(1160);
                    match(CLASS);
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                7 : 
                enterOuterAlt(_localctx, 7);
                {
                    setState(1162);
                    match(VOID);
                    setState(1163);
                    match(DOT);
                    setState(1164);
                    match(CLASS);
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                8 : 
                enterOuterAlt(_localctx, 8);
                {
                    setState(1165);
                    nonWildcardTypeArguments();
                    setState(1169);
                    {
                        SWITCH | switch
                        }

                        (_input.LA(1))
                        {
                            {
                                CASE |  case
                            }

                            SUPER:
                            {
                                CASE |  case
                            }

                            Identifier:
                            {
                                setState(1166);
                                explicitGenericInvocationSuffix();
                            }

                            {
                                BREAK | break
                            }

                            ;
                            {
                                CASE |  case
                            }

                            THIS:
                            {
                                setState(1167);
                                match(THIS);
                                setState(1168);
                                arguments();
                            }

                            {
                                BREAK | break
                            }

                            ;
                            {
                                DEFAULT | default
                            } : 

                            throw new NoViableAltException(this);
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
        _errHandler.reportError(this, re);
        _errHandler.recover(this, re);
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        return _localctx;
    }

    publicstatic class CreatorContext
{
    EXTENDS |extends
}

ParserRuleContext {
public ArrayCreatorRestContextarrayCreatorRest()
{
    return getRuleContext(ArrayCreatorRestContext.class ,  0 ) ;  }

public NonWildcardTypeArgumentsContextnonWildcardTypeArguments()
{
    return getRuleContext(NonWildcardTypeArgumentsContext.class ,  0 ) ;  }

public ClassCreatorRestContextclassCreatorRest()
{
    return getRuleContext(ClassCreatorRestContext.class ,  0 ) ;  }

public CreatedNameContextcreatedName()
{
    return getRuleContext(CreatedNameContext.class ,  0 ) ;  }

publicCreatorContext(ParserRuleContext parent, int invokingState)
{
    {
        SUPER | super
    }

    (parent, invokingState);
} {

AT | @ }OverridepublicintgetRuleIndex()
{
    return RULE_creator;
} {

AT | @ }Overridepublic void enterRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterCreator(this);
} {

AT | @ }Overridepublic void exitRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitCreator(this);
} {

AT | @ }Overridepublic<T> Taccept(ParseTreeVisitor<?
{
    EXTENDS | extends
}

T >visitor ) { if  (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) return  ( (JavaVisitor<?
 {
EXTENDS |extends }
T > )visitor ) .visitCreator(this); else  return 
visitor.visitChildren (this )
    ;
} }
public {
FINAL |final }
CreatorContextcreator()
{
    CreatorContext _localctx = new CreatorContext(_ctx, getState());
    enterRule(_localctx, 178, RULE_creator);
    try
    {
        setState(1182);
        {
            SWITCH | switch
            }

            (_input.LA(1))
            {
                {
                    CASE |  case
                }

                LT:
                    enterOuterAlt(_localctx, 1);
                {
                    setState(1173);
                    nonWildcardTypeArguments();
                    setState(1174);
                    createdName();
                    setState(1175);
                    classCreatorRest();
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                BOOLEAN:
                {
                    CASE |  case
                }

                BYTE:
                {
                    CASE |  case
                }

                CHAR:
                {
                    CASE |  case
                }

                DOUBLE:
                {
                    CASE |  case
                }

                FLOAT:
                {
                    CASE |  case
                }

                INT:
                {
                    CASE |  case
                }

                LONG:
                {
                    CASE |  case
                }

                SHORT:
                {
                    CASE |  case
                }

                Identifier:
                    enterOuterAlt(_localctx, 2);
                {
                    setState(1177);
                    createdName();
                    setState(1180);
                    {
                        SWITCH | switch
                        }

                        (_input.LA(1))
                        {
                            {
                                CASE |  case
                            }

                            LBRACK:
                            {
                                setState(1178);
                                arrayCreatorRest();
                            }

                            {
                                BREAK | break
                            }

                            ;
                            {
                                CASE |  case
                            }

                            LPAREN:
                            {
                                setState(1179);
                                classCreatorRest();
                            }

                            {
                                BREAK | break
                            }

                            ;
                            {
                                DEFAULT | default
                            } : 

                            throw new NoViableAltException(this);
                        }
                    }

                    {
                        BREAK | break
                    }

                    ;
                    {
                        DEFAULT | default
                    } : 

                    throw new NoViableAltException(this);
                }
            }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(this, re);
        _errHandler.recover(this, re);
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        return _localctx;
    }

    publicstatic class CreatedNameContext
{
    EXTENDS |extends
}

ParserRuleContext {
public List<TerminalNode> Identifier()
{
    return getTokens(JavaParser.Identifier);
}

public TerminalNodeIdentifier(int i)
{
    return getToken(JavaParser.Identifier, i);
}

public List<TypeArgumentsOrDiamondContext> typeArgumentsOrDiamond()
{
    return getRuleContexts(TypeArgumentsOrDiamondContext.class ) ;  }

public PrimitiveTypeContextprimitiveType()
{
    return getRuleContext(PrimitiveTypeContext.class ,  0 ) ;  }

public TypeArgumentsOrDiamondContexttypeArgumentsOrDiamond(int i)
{
    return getRuleContext(TypeArgumentsOrDiamondContext.class , 

i ) ;  }publicCreatedNameContext(ParserRuleContext parent, int invokingState)
{
    {
        SUPER | super
    }

    (parent, invokingState);
} {

AT | @ }OverridepublicintgetRuleIndex()
{
    return RULE_createdName;
} {

AT | @ }Overridepublic void enterRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterCreatedName(this);
} {

AT | @ }Overridepublic void exitRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitCreatedName(this);
} {

AT | @ }Overridepublic<T> Taccept(ParseTreeVisitor<?
{
    EXTENDS | extends
}

T >visitor ) { if  (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) return  ( (JavaVisitor<?
 {
EXTENDS |extends }
T > )visitor ) .visitCreatedName(this); else  return 
visitor.visitChildren (this )
    ;
} }
public {
FINAL |final }
CreatedNameContextcreatedName()
{
    CreatedNameContext _localctx = new CreatedNameContext(_ctx, getState());
    enterRule(_localctx, 180, RULE_createdName);
    int _la;
    try
    {
        setState(1199);
        {
            SWITCH | switch
            }

            (_input.LA(1))
            {
                {
                    CASE |  case
                }

                Identifier:
                    enterOuterAlt(_localctx, 1);
                {
                    setState(1184);
                    match(Identifier);
                    setState(1186);
                    _la = _input.LA(1);
                    if (_la == LT)
                    {
                        {
                            setState(1185);
                            typeArgumentsOrDiamond();
                        }
                    }

                    setState(1195);
                    _errHandler.sync(this);
                    _la = _input.LA(1);
                    {
                        WHILE | while
                    }

                    (_la == DOT)
                    {
                        {
                            {
                                setState(1188);
                                match(DOT);
                                setState(1189);
                                match(Identifier);
                                setState(1191);
                                _la = _input.LA(1);
                                if (_la == LT)
                                {
                                    {
                                        setState(1190);
                                        typeArgumentsOrDiamond();
                                    }
                                }
                            }
                        }

                        setState(1197);
                        _errHandler.sync(this);
                        _la = _input.LA(1);
                    }
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                BOOLEAN:
                {
                    CASE |  case
                }

                BYTE:
                {
                    CASE |  case
                }

                CHAR:
                {
                    CASE |  case
                }

                DOUBLE:
                {
                    CASE |  case
                }

                FLOAT:
                {
                    CASE |  case
                }

                INT:
                {
                    CASE |  case
                }

                LONG:
                {
                    CASE |  case
                }

                SHORT:
                    enterOuterAlt(_localctx, 2);
                {
                    setState(1198);
                    primitiveType();
                }

                {
                    BREAK | break
                }

                ;
                {
                    DEFAULT | default
                } : 

                throw new NoViableAltException(this);
            }
        }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(this, re);
        _errHandler.recover(this, re);
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        return _localctx;
    }

    publicstatic class InnerCreatorContext
{
    EXTENDS |extends
}

ParserRuleContext {
public TerminalNodeIdentifier()
{
    return getToken(JavaParser.Identifier, 0);
}

public ClassCreatorRestContextclassCreatorRest()
{
    return getRuleContext(ClassCreatorRestContext.class ,  0 ) ;  }

public NonWildcardTypeArgumentsOrDiamondContextnonWildcardTypeArgumentsOrDiamond()
{
    return getRuleContext(NonWildcardTypeArgumentsOrDiamondContext.class ,  0 ) ;  }

publicInnerCreatorContext(ParserRuleContext parent, int invokingState)
{
    {
        SUPER | super
    }

    (parent, invokingState);
} {

AT | @ }OverridepublicintgetRuleIndex()
{
    return RULE_innerCreator;
} {

AT | @ }Overridepublic void enterRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterInnerCreator(this);
} {

AT | @ }Overridepublic void exitRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitInnerCreator(this);
} {

AT | @ }Overridepublic<T> Taccept(ParseTreeVisitor<?
{
    EXTENDS | extends
}

T >visitor ) { if  (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) return  ( (JavaVisitor<?
 {
EXTENDS |extends }
T > )visitor ) .visitInnerCreator(this); else  return 
visitor.visitChildren (this )
    ;
} }
public {
FINAL |final }
InnerCreatorContextinnerCreator()
{
    InnerCreatorContext _localctx = new InnerCreatorContext(_ctx, getState());
    enterRule(_localctx, 182, RULE_innerCreator);
    int _la;
    try
    {
        enterOuterAlt(_localctx, 1);
        {
            setState(1201);
            match(Identifier);
            setState(1203);
            _la = _input.LA(1);
            if (_la == LT)
            {
                {
                    setState(1202);
                    nonWildcardTypeArgumentsOrDiamond();
                }
            }

            setState(1205);
            classCreatorRest();
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(this, re);
        _errHandler.recover(this, re);
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        return _localctx;
    }

    publicstatic class ArrayCreatorRestContext
{
    EXTENDS |extends
}

ParserRuleContext {
public ArrayInitializerContextarrayInitializer()
{
    return getRuleContext(ArrayInitializerContext.class ,  0 ) ;  }

public ExpressionContextexpression(int i)
{
    return getRuleContext(ExpressionContext.class , 

i ) ;  }public List<ExpressionContext> expression()
{
    return getRuleContexts(ExpressionContext.class ) ;  }

publicArrayCreatorRestContext(ParserRuleContext parent, int invokingState)
{
    {
        SUPER | super
    }

    (parent, invokingState);
} {

AT | @ }OverridepublicintgetRuleIndex()
{
    return RULE_arrayCreatorRest;
} {

AT | @ }Overridepublic void enterRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterArrayCreatorRest(this);
} {

AT | @ }Overridepublic void exitRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitArrayCreatorRest(this);
} {

AT | @ }Overridepublic<T> Taccept(ParseTreeVisitor<?
{
    EXTENDS | extends
}

T >visitor ) { if  (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) return  ( (JavaVisitor<?
 {
EXTENDS |extends }
T > )visitor ) .visitArrayCreatorRest(this); else  return 
visitor.visitChildren (this )
    ;
} }
public {
FINAL |final }
ArrayCreatorRestContextarrayCreatorRest()
{
    ArrayCreatorRestContext _localctx = new ArrayCreatorRestContext(_ctx, getState());
    enterRule(_localctx, 184, RULE_arrayCreatorRest);
    int _la;
    try
    {
        int _alt;
        enterOuterAlt(_localctx, 1);
        {
            setState(1207);
            match(LBRACK);
            setState(1235);
            {
                SWITCH | switch
                }

                (_input.LA(1))
                {
                    {
                        CASE |  case
                    }

                    RBRACK:
                    {
                        setState(1208);
                        match(RBRACK);
                        setState(1213);
                        _errHandler.sync(this);
                        _la = _input.LA(1);
                        {
                            WHILE | while
                        }

                        (_la == LBRACK)
                        {
                            {
                                {
                                    setState(1209);
                                    match(LBRACK);
                                    setState(1210);
                                    match(RBRACK);
                                }
                            }

                            setState(1215);
                            _errHandler.sync(this);
                            _la = _input.LA(1);
                        }

                        setState(1216);
                        arrayInitializer();
                    }

                    {
                        BREAK | break
                    }

                    ;
                    {
                        CASE |  case
                    }

                    BOOLEAN:
                    {
                        CASE |  case
                    }

                    BYTE:
                    {
                        CASE |  case
                    }

                    CHAR:
                    {
                        CASE |  case
                    }

                    DOUBLE:
                    {
                        CASE |  case
                    }

                    FLOAT:
                    {
                        CASE |  case
                    }

                    INT:
                    {
                        CASE |  case
                    }

                    LONG:
                    {
                        CASE |  case
                    }

                    NEW:
                    {
                        CASE |  case
                    }

                    SHORT:
                    {
                        CASE |  case
                    }

                    SUPER:
                    {
                        CASE |  case
                    }

                    THIS:
                    {
                        CASE |  case
                    }

                    VOID:
                    {
                        CASE |  case
                    }

                    IntegerLiteral:
                    {
                        CASE |  case
                    }

                    FloatingPointLiteral:
                    {
                        CASE |  case
                    }

                    BooleanLiteral:
                    {
                        CASE |  case
                    }

                    CharacterLiteral:
                    {
                        CASE |  case
                    }

                    StringLiteral:
                    {
                        CASE |  case
                    }

                    NullLiteral:
                    {
                        CASE |  case
                    }

                    LPAREN:
                    {
                        CASE |  case
                    }

                    LT:
                    {
                        CASE |  case
                    }

                    BANG:
                    {
                        CASE |  case
                    }

                    TILDE:
                    {
                        CASE |  case
                    }

                    INC:
                    {
                        CASE |  case
                    }

                    DEC:
                    {
                        CASE |  case
                    }

                    ADD:
                    {
                        CASE |  case
                    }

                    SUB:
                    {
                        CASE |  case
                    }

                    Identifier:
                    {
                        setState(1217);
                        expression(0);
                        setState(1218);
                        match(RBRACK);
                        setState(1225);
                        _errHandler.sync(this);
                        _alt = getInterpreter().adaptivePredict(_input, 139, _ctx);
                        {
                            WHILE | while
                        }

                        (_alt != 2 && _alt != org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER)
                        {
                            if (_alt == 1)
                            {
                                {
                                    {
                                        setState(1219);
                                        match(LBRACK);
                                        setState(1220);
                                        expression(0);
                                        setState(1221);
                                        match(RBRACK);
                                    }
                                }
                            }

                            setState(1227);
                            _errHandler.sync(this);
                            _alt = getInterpreter().adaptivePredict(_input, 139, _ctx);
                        }

                        setState(1232);
                        _errHandler.sync(this);
                        _alt = getInterpreter().adaptivePredict(_input, 140, _ctx);
                        {
                            WHILE | while
                        }

                        (_alt != 2 && _alt != org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER)
                        {
                            if (_alt == 1)
                            {
                                {
                                    {
                                        setState(1228);
                                        match(LBRACK);
                                        setState(1229);
                                        match(RBRACK);
                                    }
                                }
                            }

                            setState(1234);
                            _errHandler.sync(this);
                            _alt = getInterpreter().adaptivePredict(_input, 140, _ctx);
                        }
                    }

                    {
                        BREAK | break
                    }

                    ;
                    {
                        DEFAULT | default
                    } : 

                    throw new NoViableAltException(this);
                }
            }
        }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(this, re);
        _errHandler.recover(this, re);
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        return _localctx;
    }

    publicstatic class ClassCreatorRestContext
{
    EXTENDS |extends
}

ParserRuleContext {
public ClassBodyContextclassBody()
{
    return getRuleContext(ClassBodyContext.class ,  0 ) ;  }

public ArgumentsContextarguments()
{
    return getRuleContext(ArgumentsContext.class ,  0 ) ;  }

publicClassCreatorRestContext(ParserRuleContext parent, int invokingState)
{
    {
        SUPER | super
    }

    (parent, invokingState);
} {

AT | @ }OverridepublicintgetRuleIndex()
{
    return RULE_classCreatorRest;
} {

AT | @ }Overridepublic void enterRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterClassCreatorRest(this);
} {

AT | @ }Overridepublic void exitRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitClassCreatorRest(this);
} {

AT | @ }Overridepublic<T> Taccept(ParseTreeVisitor<?
{
    EXTENDS | extends
}

T >visitor ) { if  (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) return  ( (JavaVisitor<?
 {
EXTENDS |extends }
T > )visitor ) .visitClassCreatorRest(this); else  return 
visitor.visitChildren (this )
    ;
} }
public {
FINAL |final }
ClassCreatorRestContextclassCreatorRest()
{
    ClassCreatorRestContext _localctx = new ClassCreatorRestContext(_ctx, getState());
    enterRule(_localctx, 186, RULE_classCreatorRest);
    try
    {
        enterOuterAlt(_localctx, 1);
        {
            setState(1237);
            arguments();
            setState(1239);
            {
                SWITCH | switch
                }

                (getInterpreter().adaptivePredict(_input, 142, _ctx))
                {
                    {
                        CASE |  case
                    }

                    1 : 
                    {
                        setState(1238);
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
        _errHandler.reportError(this, re);
        _errHandler.recover(this, re);
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        return _localctx;
    }

    publicstatic class ExplicitGenericInvocationContext
{
    EXTENDS |extends
}

ParserRuleContext {
public NonWildcardTypeArgumentsContextnonWildcardTypeArguments()
{
    return getRuleContext(NonWildcardTypeArgumentsContext.class ,  0 ) ;  }

public ExplicitGenericInvocationSuffixContextexplicitGenericInvocationSuffix()
{
    return getRuleContext(ExplicitGenericInvocationSuffixContext.class ,  0 ) ;  }

publicExplicitGenericInvocationContext(ParserRuleContext parent, int invokingState)
{
    {
        SUPER | super
    }

    (parent, invokingState);
} {

AT | @ }OverridepublicintgetRuleIndex()
{
    return RULE_explicitGenericInvocation;
} {

AT | @ }Overridepublic void enterRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterExplicitGenericInvocation(this);
} {

AT | @ }Overridepublic void exitRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitExplicitGenericInvocation(this);
} {

AT | @ }Overridepublic<T> Taccept(ParseTreeVisitor<?
{
    EXTENDS | extends
}

T >visitor ) { if  (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) return  ( (JavaVisitor<?
 {
EXTENDS |extends }
T > )visitor ) .visitExplicitGenericInvocation(this); else  return 
visitor.visitChildren (this )
    ;
} }
public {
FINAL |final }
ExplicitGenericInvocationContextexplicitGenericInvocation()
{
    ExplicitGenericInvocationContext _localctx = new ExplicitGenericInvocationContext(_ctx, getState());
    enterRule(_localctx, 188, RULE_explicitGenericInvocation);
    try
    {
        enterOuterAlt(_localctx, 1);
        {
            setState(1241);
            nonWildcardTypeArguments();
            setState(1242);
            explicitGenericInvocationSuffix();
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(this, re);
        _errHandler.recover(this, re);
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        return _localctx;
    }

    publicstatic class NonWildcardTypeArgumentsContext
{
    EXTENDS |extends
}

ParserRuleContext {
public TypeListContexttypeList()
{
    return getRuleContext(TypeListContext.class ,  0 ) ;  }

publicNonWildcardTypeArgumentsContext(ParserRuleContext parent, int invokingState)
{
    {
        SUPER | super
    }

    (parent, invokingState);
} {

AT | @ }OverridepublicintgetRuleIndex()
{
    return RULE_nonWildcardTypeArguments;
} {

AT | @ }Overridepublic void enterRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterNonWildcardTypeArguments(this);
} {

AT | @ }Overridepublic void exitRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitNonWildcardTypeArguments(this);
} {

AT | @ }Overridepublic<T> Taccept(ParseTreeVisitor<?
{
    EXTENDS | extends
}

T >visitor ) { if  (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) return  ( (JavaVisitor<?
 {
EXTENDS |extends }
T > )visitor ) .visitNonWildcardTypeArguments(this); else  return 
visitor.visitChildren (this )
    ;
} }
public {
FINAL |final }
NonWildcardTypeArgumentsContextnonWildcardTypeArguments()
{
    NonWildcardTypeArgumentsContext _localctx = new NonWildcardTypeArgumentsContext(_ctx, getState());
    enterRule(_localctx, 190, RULE_nonWildcardTypeArguments);
    try
    {
        enterOuterAlt(_localctx, 1);
        {
            setState(1244);
            match(LT);
            setState(1245);
            typeList();
            setState(1246);
            match(GT);
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(this, re);
        _errHandler.recover(this, re);
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        return _localctx;
    }

    publicstatic class TypeArgumentsOrDiamondContext
{
    EXTENDS |extends
}

ParserRuleContext {
public TypeArgumentsContexttypeArguments()
{
    return getRuleContext(TypeArgumentsContext.class ,  0 ) ;  }

publicTypeArgumentsOrDiamondContext(ParserRuleContext parent, int invokingState)
{
    {
        SUPER | super
    }

    (parent, invokingState);
} {

AT | @ }OverridepublicintgetRuleIndex()
{
    return RULE_typeArgumentsOrDiamond;
} {

AT | @ }Overridepublic void enterRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterTypeArgumentsOrDiamond(this);
} {

AT | @ }Overridepublic void exitRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitTypeArgumentsOrDiamond(this);
} {

AT | @ }Overridepublic<T> Taccept(ParseTreeVisitor<?
{
    EXTENDS | extends
}

T >visitor ) { if  (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) return  ( (JavaVisitor<?
 {
EXTENDS |extends }
T > )visitor ) .visitTypeArgumentsOrDiamond(this); else  return 
visitor.visitChildren (this )
    ;
} }
public {
FINAL |final }
TypeArgumentsOrDiamondContexttypeArgumentsOrDiamond()
{
    TypeArgumentsOrDiamondContext _localctx = new TypeArgumentsOrDiamondContext(_ctx, getState());
    enterRule(_localctx, 192, RULE_typeArgumentsOrDiamond);
    try
    {
        setState(1251);
        {
            SWITCH | switch
            }

            (getInterpreter().adaptivePredict(_input, 143, _ctx))
            {
                {
                    CASE |  case
                }

                1 : 
                enterOuterAlt(_localctx, 1);
                {
                    setState(1248);
                    match(LT);
                    setState(1249);
                    match(GT);
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                2 : 
                enterOuterAlt(_localctx, 2);
                {
                    setState(1250);
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
        _errHandler.reportError(this, re);
        _errHandler.recover(this, re);
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        return _localctx;
    }

    publicstatic class NonWildcardTypeArgumentsOrDiamondContext
{
    EXTENDS |extends
}

ParserRuleContext {
public NonWildcardTypeArgumentsContextnonWildcardTypeArguments()
{
    return getRuleContext(NonWildcardTypeArgumentsContext.class ,  0 ) ;  }

publicNonWildcardTypeArgumentsOrDiamondContext(ParserRuleContext parent, int invokingState)
{
    {
        SUPER | super
    }

    (parent, invokingState);
} {

AT | @ }OverridepublicintgetRuleIndex()
{
    return RULE_nonWildcardTypeArgumentsOrDiamond;
} {

AT | @ }Overridepublic void enterRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterNonWildcardTypeArgumentsOrDiamond(this);
} {

AT | @ }Overridepublic void exitRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitNonWildcardTypeArgumentsOrDiamond(this);
} {

AT | @ }Overridepublic<T> Taccept(ParseTreeVisitor<?
{
    EXTENDS | extends
}

T >visitor ) { if  (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) return  ( (JavaVisitor<?
 {
EXTENDS |extends }
T > )visitor ) .visitNonWildcardTypeArgumentsOrDiamond(this); else  return 
visitor.visitChildren (this )
    ;
} }
public {
FINAL |final }
NonWildcardTypeArgumentsOrDiamondContextnonWildcardTypeArgumentsOrDiamond()
{
    NonWildcardTypeArgumentsOrDiamondContext _localctx = new NonWildcardTypeArgumentsOrDiamondContext(_ctx, getState());
    enterRule(_localctx, 194, RULE_nonWildcardTypeArgumentsOrDiamond);
    try
    {
        setState(1256);
        {
            SWITCH | switch
            }

            (getInterpreter().adaptivePredict(_input, 144, _ctx))
            {
                {
                    CASE |  case
                }

                1 : 
                enterOuterAlt(_localctx, 1);
                {
                    setState(1253);
                    match(LT);
                    setState(1254);
                    match(GT);
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                2 : 
                enterOuterAlt(_localctx, 2);
                {
                    setState(1255);
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
        _errHandler.reportError(this, re);
        _errHandler.recover(this, re);
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        return _localctx;
    }

    publicstatic class SuperSuffixContext
{
    EXTENDS |extends
}

ParserRuleContext {
public TerminalNodeIdentifier()
{
    return getToken(JavaParser.Identifier, 0);
}

public ArgumentsContextarguments()
{
    return getRuleContext(ArgumentsContext.class ,  0 ) ;  }

publicSuperSuffixContext(ParserRuleContext parent, int invokingState)
{
    {
        SUPER | super
    }

    (parent, invokingState);
} {

AT | @ }OverridepublicintgetRuleIndex()
{
    return RULE_superSuffix;
} {

AT | @ }Overridepublic void enterRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterSuperSuffix(this);
} {

AT | @ }Overridepublic void exitRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitSuperSuffix(this);
} {

AT | @ }Overridepublic<T> Taccept(ParseTreeVisitor<?
{
    EXTENDS | extends
}

T >visitor ) { if  (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) return  ( (JavaVisitor<?
 {
EXTENDS |extends }
T > )visitor ) .visitSuperSuffix(this); else  return 
visitor.visitChildren (this )
    ;
} }
public {
FINAL |final }
SuperSuffixContextsuperSuffix()
{
    SuperSuffixContext _localctx = new SuperSuffixContext(_ctx, getState());
    enterRule(_localctx, 196, RULE_superSuffix);
    try
    {
        setState(1264);
        {
            SWITCH | switch
            }

            (_input.LA(1))
            {
                {
                    CASE |  case
                }

                LPAREN:
                    enterOuterAlt(_localctx, 1);
                {
                    setState(1258);
                    arguments();
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                DOT:
                    enterOuterAlt(_localctx, 2);
                {
                    setState(1259);
                    match(DOT);
                    setState(1260);
                    match(Identifier);
                    setState(1262);
                    {
                        SWITCH | switch
                        }

                        (getInterpreter().adaptivePredict(_input, 145, _ctx))
                        {
                            {
                                CASE |  case
                            }

                            1 : 
                            {
                                setState(1261);
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
                    } : 

                    throw new NoViableAltException(this);
                }
            }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(this, re);
        _errHandler.recover(this, re);
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        return _localctx;
    }

    publicstatic class ExplicitGenericInvocationSuffixContext
{
    EXTENDS |extends
}

ParserRuleContext {
public TerminalNodeIdentifier()
{
    return getToken(JavaParser.Identifier, 0);
}

public SuperSuffixContextsuperSuffix()
{
    return getRuleContext(SuperSuffixContext.class ,  0 ) ;  }

public ArgumentsContextarguments()
{
    return getRuleContext(ArgumentsContext.class ,  0 ) ;  }

publicExplicitGenericInvocationSuffixContext(ParserRuleContext parent, int invokingState)
{
    {
        SUPER | super
    }

    (parent, invokingState);
} {

AT | @ }OverridepublicintgetRuleIndex()
{
    return RULE_explicitGenericInvocationSuffix;
} {

AT | @ }Overridepublic void enterRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterExplicitGenericInvocationSuffix(this);
} {

AT | @ }Overridepublic void exitRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitExplicitGenericInvocationSuffix(this);
} {

AT | @ }Overridepublic<T> Taccept(ParseTreeVisitor<?
{
    EXTENDS | extends
}

T >visitor ) { if  (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) return  ( (JavaVisitor<?
 {
EXTENDS |extends }
T > )visitor ) .visitExplicitGenericInvocationSuffix(this); else  return 
visitor.visitChildren (this )
    ;
} }
public {
FINAL |final }
ExplicitGenericInvocationSuffixContextexplicitGenericInvocationSuffix()
{
    ExplicitGenericInvocationSuffixContext _localctx = new ExplicitGenericInvocationSuffixContext(_ctx, getState());
    enterRule(_localctx, 198, RULE_explicitGenericInvocationSuffix);
    try
    {
        setState(1270);
        {
            SWITCH | switch
            }

            (_input.LA(1))
            {
                {
                    CASE |  case
                }

                SUPER:
                    enterOuterAlt(_localctx, 1);
                {
                    setState(1266);
                    match(SUPER);
                    setState(1267);
                    superSuffix();
                }

                {
                    BREAK | break
                }

                ;
                {
                    CASE |  case
                }

                Identifier:
                    enterOuterAlt(_localctx, 2);
                {
                    setState(1268);
                    match(Identifier);
                    setState(1269);
                    arguments();
                }

                {
                    BREAK | break
                }

                ;
                {
                    DEFAULT | default
                } : 

                throw new NoViableAltException(this);
            }
        }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(this, re);
        _errHandler.recover(this, re);
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        return _localctx;
    }

    publicstatic class ArgumentsContext
{
    EXTENDS |extends
}

ParserRuleContext {
public ExpressionListContextexpressionList()
{
    return getRuleContext(ExpressionListContext.class ,  0 ) ;  }

publicArgumentsContext(ParserRuleContext parent, int invokingState)
{
    {
        SUPER | super
    }

    (parent, invokingState);
} {

AT | @ }OverridepublicintgetRuleIndex()
{
    return RULE_arguments;
} {

AT | @ }Overridepublic void enterRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).enterArguments(this);
} {

AT | @ }Overridepublic void exitRule(ParseTreeListener listener)
{
    if (listener
    {
        INSTANCEOF | instanceof
    }

    JavaListener )
    ((JavaListener)listener).exitArguments(this);
} {

AT | @ }Overridepublic<T> Taccept(ParseTreeVisitor<?
{
    EXTENDS | extends
}

T >visitor ) { if  (visitor {
INSTANCEOF |instanceof }
JavaVisitor ) return  ( (JavaVisitor<?
 {
EXTENDS |extends }
T > )visitor ) .visitArguments(this); else  return 
visitor.visitChildren (this )
    ;
} }
public {
FINAL |final }
ArgumentsContextarguments()
{
    ArgumentsContext _localctx = new ArgumentsContext(_ctx, getState());
    enterRule(_localctx, 200, RULE_arguments);
    int _la;
    try
    {
        enterOuterAlt(_localctx, 1);
        {
            setState(1272);
            match(LPAREN);
            setState(1274);
            _la = _input.LA(1);
            if ((((_la)
            {
                BITAND | &
            }

            {
                TILDE | ~
            }

            0x3f ) 
            == 0 && ((1L << _la)
            {
                BITAND | &
            }

            ((1L << BOOLEAN)
            {
                BITOR ||
            }

            (1L << BYTE)
            {
                BITOR ||
            }

            (1L << CHAR)
            {
                BITOR ||
            }

            (1L << DOUBLE)
            {
                BITOR ||
            }

            (1L << FLOAT)
            {
                BITOR ||
            }

            (1L << INT)
            {
                BITOR ||
            }

            (1L << LONG)
            {
                BITOR ||
            }

            (1L << NEW)
            {
                BITOR ||
            }

            (1L << SHORT)
            {
                BITOR ||
            }

            (1L << SUPER)
            {
                BITOR ||
            }

            (1L << THIS)
            {
                BITOR ||
            }

            (1L << VOID)
            {
                BITOR ||
            }

            (1L << IntegerLiteral)
            {
                BITOR ||
            }

            (1L << FloatingPointLiteral)
            {
                BITOR ||
            }

            (1L << BooleanLiteral)
            {
                BITOR ||
            }

            (1L << CharacterLiteral)
            {
                BITOR ||
            }

            (1L << StringLiteral)
            {
                BITOR ||
            }

            (1L << NullLiteral)
            {
                BITOR ||
            }

            (1L << LPAREN) ) ) 
            != 0 )
            {
                OR || |
            }

            ((((_la - 68))
            {
                BITAND | &
            }

            {
                TILDE | ~
            }

            0x3f ) 
            == 0 && ((1L << (_la - 68))
            {
                BITAND | &
            }

            ((1L << (LT - 68))
            {
                BITOR ||
            }

            (1L << (BANG - 68))
            {
                BITOR ||
            }

            (1L << (TILDE - 68))
            {
                BITOR ||
            }

            (1L << (INC - 68))
            {
                BITOR ||
            }

            (1L << (DEC - 68))
            {
                BITOR ||
            }

            (1L << (ADD - 68))
            {
                BITOR ||
            }

            (1L << (SUB - 68))
            {
                BITOR ||
            }

            (1L << (Identifier - 68)) ) ) 
            != 0 ) )
            {
                {
                    setState(1273);
                    expressionList();
                }
            }

            setState(1276);
            match(RPAREN);
        }
    }
    catch (RecognitionException re)
    {
        _localctx.exception = re;
        _errHandler.reportError(this, re);
        _errHandler.recover(this, re);
    }

    {
        FINALLY |
        finally
        }

        {
            exitRule();
        }

        return _localctx;
    }

public {
BOOLEAN |boolean }
sempred(RuleContext _localctx, int ruleIndex, int predIndex)
{
    {
        SWITCH | switch
        }

        (ruleIndex)
        {
            {
                CASE |  case
            }

            87 : 
            return expression_sempred((ExpressionContext)_localctx, predIndex);
        }

        return
        {
            BooleanLiteral | true
        }

        ;
    }

private {
BOOLEAN |boolean }
expression_sempred(ExpressionContext _localctx, int predIndex)
{
    {
        SWITCH | switch
        }

        (predIndex)
        {
            {
                CASE |  case
            }

            0 : 
            return precpred(_ctx, 13);
            {
                CASE |  case
            }

            1 : 
            return precpred(_ctx, 12);
            {
                CASE |  case
            }

            2 : 
            return precpred(_ctx, 11);
            {
                CASE |  case
            }

            3 : 
            return precpred(_ctx, 10);
            {
                CASE |  case
            }

            4 : 
            return precpred(_ctx, 8);
            {
                CASE |  case
            }

            5 : 
            return precpred(_ctx, 7);
            {
                CASE |  case
            }

            6 : 
            return precpred(_ctx, 6);
            {
                CASE |  case
            }

            7 : 
            return precpred(_ctx, 5);
            {
                CASE |  case
            }

            8 : 
            return precpred(_ctx, 4);
            {
                CASE |  case
            }

            9 : 
            return precpred(_ctx, 3);
            {
                CASE |  case
            }

            10 : 
            return precpred(_ctx, 2);
            {
                CASE |  case
            }

            11 : 
            return precpred(_ctx, 1);
            {
                CASE |  case
            }

            12 : 
            return precpred(_ctx, 25);
            {
                CASE |  case
            }

            13 : 
            return precpred(_ctx, 24);
            {
                CASE |  case
            }

            14 : 
            return precpred(_ctx, 23);
            {
                CASE |  case
            }

            15 : 
            return precpred(_ctx, 22);
            {
                CASE |  case
            }

            16 : 
            return precpred(_ctx, 21);
            {
                CASE |  case
            }

            17 : 
            return precpred(_ctx, 20);
            {
                CASE |  case
            }

            18 : 
            return precpred(_ctx, 19);
            {
                CASE |  case
            }

            19 : 
            return precpred(_ctx, 16);
            {
                CASE |  case
            }

            20 : 
            return precpred(_ctx, 9);
        }

        return
        {
            BooleanLiteral | true
        }

        ;
    }

    publicstatic
    {
        FINAL | final
    }

    String _serializedATN = "\3\u0430\ud6d1\u8206\uad2d\u4417\uaef1\u8d80\uaadd\3k\u0501\4\2\t\2\4" + "\3\t\3\4\4\t\4\4\5\t\5\4\6\t\6\4\7\t\7\4\b\t\b\4\t\t\t\4\n\t\n\4\13\t" + "\13\4\f\t\f\4\r\t\r\4\16\t\16\4\17\t\17\4\20\t\20\4\21\t\21\4\22\t\22" + "\4\23\t\23\4\24\t\24\4\25\t\25\4\26\t\26\4\27\t\27\4\30\t\30\4\31\t\31" + "\4\32\t\32\4\33\t\33\4\34\t\34\4\35\t\35\4\36\t\36\4\37\t\37\4 \t \4!" + "\t!\4\"\t\"\4#\t#\4$\t$\4%\t%\4&\t&\4\'\t\'\4(\t(\4)\t)\4*\t*\4+\t+\4" + ",\t,\4-\t-\4.\t.\4/\t/\4\60\t\60\4\61\t\61\4\62\t\62\4\63\t\63\4\64\t" + "\64\4\65\t\65\4\66\t\66\4\67\t\67\48\t8\49\t9\4:\t:\4;\t;\4<\t<\4=\t=" + "\4>\t>\4?\t?\4@\t@\4A\tA\4B\tB\4C\tC\4D\tD\4E\tE\4F\tF\4G\tG\4H\tH\4I" + "\tI\4J\tJ\4K\tK\4L\tL\4M\tM\4N\tN\4O\tO\4P\tP\4Q\tQ\4R\tR\4S\tS\4T\tT" + "\4U\tU\4V\tV\4W\tW\4X\tX\4Y\tY\4Z\tZ\4[\t[\4\\\t\\\4]\t]\4^\t^\4_\t_\4" + "`\t`\4a\ta\4b\tb\4c\tc\4d\td\4e\te\4f\tf\3\2\5\2\u00ce\n\2\3\2\7\2\u00d1" + "\n\2\f\2\16\2\u00d4\13\2\3\2\7\2\u00d7\n\2\f\2\16\2\u00da\13\2\3\2\3\2" + "\3\3\7\3\u00df\n\3\f\3\16\3\u00e2\13\3\3\3\3\3\3\3\3\3\3\4\3\4\5\4\u00ea" + "\n\4\3\4\3\4\3\4\5\4\u00ef\n\4\3\4\3\4\3\5\7\5\u00f4\n\5\f\5\16\5\u00f7" + "\13\5\3\5\3\5\7\5\u00fb\n\5\f\5\16\5\u00fe\13\5\3\5\3\5\7\5\u0102\n\5" + "\f\5\16\5\u0105\13\5\3\5\3\5\7\5\u0109\n\5\f\5\16\5\u010c\13\5\3\5\3\5" + "\5\5\u0110\n\5\3\6\3\6\5\6\u0114\n\6\3\7\3\7\5\7\u0118\n\7\3\b\3\b\5\b" + "\u011c\n\b\3\t\3\t\3\t\5\t\u0121\n\t\3\t\3\t\5\t\u0125\n\t\3\t\3\t\5\t" + "\u0129\n\t\3\t\3\t\3\n\3\n\3\n\3\n\7\n\u0131\n\n\f\n\16\n\u0134\13\n\3" + "\n\3\n\3\13\3\13\3\13\5\13\u013b\n\13\3\f\3\f\3\f\7\f\u0140\n\f\f\f\16" + "\f\u0143\13\f\3\r\3\r\3\r\3\r\5\r\u0149\n\r\3\r\3\r\5\r\u014d\n\r\3\r" + "\5\r\u0150\n\r\3\r\5\r\u0153\n\r\3\r\3\r\3\16\3\16\3\16\7\16\u015a\n\16" + "\f\16\16\16\u015d\13\16\3\17\7\17\u0160\n\17\f\17\16\17\u0163\13\17\3" + "\17\3\17\5\17\u0167\n\17\3\17\5\17\u016a\n\17\3\20\3\20\7\20\u016e\n\20" + "\f\20\16\20\u0171\13\20\3\21\3\21\3\21\5\21\u0176\n\21\3\21\3\21\5\21" + "\u017a\n\21\3\21\3\21\3\22\3\22\3\22\7\22\u0181\n\22\f\22\16\22\u0184" + "\13\22\3\23\3\23\7\23\u0188\n\23\f\23\16\23\u018b\13\23\3\23\3\23\3\24" + "\3\24\7\24\u0191\n\24\f\24\16\24\u0194\13\24\3\24\3\24\3\25\3\25\5\25" + "\u019a\n\25\3\25\3\25\7\25\u019e\n\25\f\25\16\25\u01a1\13\25\3\25\5\25" + "\u01a4\n\25\3\26\3\26\3\26\3\26\3\26\3\26\3\26\3\26\3\26\5\26\u01af\n" + "\26\3\27\3\27\5\27\u01b3\n\27\3\27\3\27\3\27\3\27\7\27\u01b9\n\27\f\27" + "\16\27\u01bc\13\27\3\27\3\27\5\27\u01c0\n\27\3\27\3\27\5\27\u01c4\n\27" + "\3\30\3\30\3\30\3\31\3\31\3\31\3\31\5\31\u01cd\n\31\3\31\3\31\3\32\3\32" + "\3\32\3\33\3\33\3\33\3\33\3\34\7\34\u01d9\n\34\f\34\16\34\u01dc\13\34" + "\3\34\3\34\5\34\u01e0\n\34\3\35\3\35\3\35\3\35\3\35\3\35\3\35\5\35\u01e9" + "\n\35\3\36\3\36\3\36\3\36\7\36\u01ef\n\36\f\36\16\36\u01f2\13\36\3\36" + "\3\36\3\37\3\37\3\37\7\37\u01f9\n\37\f\37\16\37\u01fc\13\37\3\37\3\37" + "\3\37\3 \3 \5 \u0203\n \3 \3 \3 \3 \7 \u0209\n \f \16 \u020c\13 \3 \3" + " \5 \u0210\n \3 \3 \3!\3!\3!\3\"\3\"\3\"\7\"\u021a\n\"\f\"\16\"\u021d" + "\13\"\3#\3#\3#\5#\u0222\n#\3$\3$\3$\7$\u0227\n$\f$\16$\u022a\13$\3%\3" + "%\5%\u022e\n%\3&\3&\3&\3&\7&\u0234\n&\f&\16&\u0237\13&\3&\5&\u023a\n&" + "\5&\u023c\n&\3&\3&\3\'\3\'\3(\3(\3(\7(\u0245\n(\f(\16(\u0248\13(\3(\3" + "(\3(\7(\u024d\n(\f(\16(\u0250\13(\5(\u0252\n(\3)\3)\5)\u0256\n)\3)\3)" + "\3)\5)\u025b\n)\7)\u025d\n)\f)\16)\u0260\13)\3*\3*\3+\3+\3+\3+\7+\u0268" + "\n+\f+\16+\u026b\13+\3+\3+\3,\3,\3,\3,\5,\u0273\n,\5,\u0275\n,\3-\3-\3" + "-\7-\u027a\n-\f-\16-\u027d\13-\3.\3.\5.\u0281\n.\3.\3.\3/\3/\3/\7/\u0288" + "\n/\f/\16/\u028b\13/\3/\3/\5/\u028f\n/\3/\5/\u0292\n/\3\60\7\60\u0295" + "\n\60\f\60\16\60\u0298\13\60\3\60\3\60\3\60\3\61\7\61\u029e\n\61\f\61" + "\16\61\u02a1\13\61\3\61\3\61\3\61\3\61\3\62\3\62\3\63\3\63\3\64\3\64\3" + "\64\7\64\u02ae\n\64\f\64\16\64\u02b1\13\64\3\65\3\65\3\66\3\66\3\66\3" + "\66\3\66\5\66\u02ba\n\66\3\66\5\66\u02bd\n\66\3\67\3\67\38\38\38\78\u02c4" + "\n8\f8\168\u02c7\138\39\39\39\39\3:\3:\3:\5:\u02d0\n:\3;\3;\3;\3;\7;\u02d6" + "\n;\f;\16;\u02d9\13;\5;\u02db\n;\3;\5;\u02de\n;\3;\3;\3<\3<\3<\3<\3<\3" + "=\3=\7=\u02e9\n=\f=\16=\u02ec\13=\3=\3=\3>\7>\u02f1\n>\f>\16>\u02f4\13" + ">\3>\3>\5>\u02f8\n>\3?\3?\3?\3?\3?\3?\5?\u0300\n?\3?\3?\5?\u0304\n?\3" + "?\3?\5?\u0308\n?\3?\3?\5?\u030c\n?\5?\u030e\n?\3@\3@\5@\u0312\n@\3A\3" + "A\3A\3A\5A\u0318\nA\3B\3B\3C\3C\3C\3D\3D\7D\u0321\nD\fD\16D\u0324\13D" + "\3D\3D\3E\3E\3E\5E\u032b\nE\3F\3F\3F\3G\7G\u0331\nG\fG\16G\u0334\13G\3" + "G\3G\3G\3H\3H\3H\3H\3H\5H\u033e\nH\3H\3H\3H\3H\3H\3H\3H\5H\u0347\nH\3" + "H\3H\3H\3H\3H\3H\3H\3H\3H\3H\3H\3H\3H\3H\3H\3H\3H\3H\3H\6H\u035c\nH\r" + "H\16H\u035d\3H\5H\u0361\nH\3H\5H\u0364\nH\3H\3H\3H\3H\7H\u036a\nH\fH\16" + "H\u036d\13H\3H\5H\u0370\nH\3H\3H\3H\3H\7H\u0376\nH\fH\16H\u0379\13H\3" + "H\7H\u037c\nH\fH\16H\u037f\13H\3H\3H\3H\3H\3H\3H\3H\3H\5H\u0389\nH\3H" + "\3H\3H\3H\3H\3H\3H\5H\u0392\nH\3H\3H\3H\5H\u0397\nH\3H\3H\3H\3H\3H\3H" + "\3H\3H\5H\u03a1\nH\3I\3I\3I\7I\u03a6\nI\fI\16I\u03a9\13I\3I\3I\3I\3I\3" + "I\3J\3J\3J\7J\u03b3\nJ\fJ\16J\u03b6\13J\3K\3K\3K\3L\3L\3L\5L\u03be\nL" + "\3L\3L\3M\3M\3M\7M\u03c5\nM\fM\16M\u03c8\13M\3N\7N\u03cb\nN\fN\16N\u03ce" + "\13N\3N\3N\3N\3N\3N\3O\6O\u03d6\nO\rO\16O\u03d7\3O\6O\u03db\nO\rO\16O" + "\u03dc\3P\3P\3P\3P\3P\3P\3P\3P\3P\3P\5P\u03e9\nP\3Q\3Q\5Q\u03ed\nQ\3Q" + "\3Q\5Q\u03f1\nQ\3Q\3Q\5Q\u03f5\nQ\5Q\u03f7\nQ\3R\3R\5R\u03fb\nR\3S\7S" + "\u03fe\nS\fS\16S\u0401\13S\3S\3S\3S\3S\3S\3T\3T\3U\3U\3U\3U\3V\3V\3V\7" + "V\u0411\nV\fV\16V\u0414\13V\3W\3W\3X\3X\3Y\3Y\3Y\3Y\3Y\3Y\3Y\3Y\3Y\3Y" + "\3Y\3Y\3Y\5Y\u0427\nY\3Y\3Y\3Y\3Y\3Y\3Y\3Y\3Y\3Y\3Y\3Y\3Y\3Y\3Y\5Y\u0437" + "\nY\3Y\3Y\3Y\3Y\3Y\3Y\3Y\3Y\3Y\3Y\3Y\3Y\3Y\3Y\3Y\3Y\3Y\3Y\3Y\3Y\3Y\3Y" + "\3Y\3Y\3Y\3Y\3Y\3Y\3Y\3Y\3Y\3Y\3Y\3Y\3Y\3Y\3Y\3Y\3Y\3Y\3Y\5Y\u0462\nY" + "\3Y\3Y\3Y\3Y\3Y\3Y\3Y\3Y\3Y\3Y\3Y\3Y\3Y\3Y\3Y\3Y\5Y\u0474\nY\3Y\3Y\3Y" + "\3Y\3Y\3Y\7Y\u047c\nY\fY\16Y\u047f\13Y\3Z\3Z\3Z\3Z\3Z\3Z\3Z\3Z\3Z\3Z\3" + "Z\3Z\3Z\3Z\3Z\3Z\3Z\3Z\3Z\5Z\u0494\nZ\5Z\u0496\nZ\3[\3[\3[\3[\3[\3[\3" + "[\5[\u049f\n[\5[\u04a1\n[\3\\\3\\\5\\\u04a5\n\\\3\\\3\\\3\\\5\\\u04aa" + "\n\\\7\\\u04ac\n\\\f\\\16\\\u04af\13\\\3\\\5\\\u04b2\n\\\3]\3]\5]\u04b6" + "\n]\3]\3]\3^\3^\3^\3^\7^\u04be\n^\f^\16^\u04c1\13^\3^\3^\3^\3^\3^\3^\3" + "^\7^\u04ca\n^\f^\16^\u04cd\13^\3^\3^\7^\u04d1\n^\f^\16^\u04d4\13^\5^\u04d6" + "\n^\3_\3_\5_\u04da\n_\3`\3`\3`\3a\3a\3a\3a\3b\3b\3b\5b\u04e6\nb\3c\3c" + "\3c\5c\u04eb\nc\3d\3d\3d\3d\5d\u04f1\nd\5d\u04f3\nd\3e\3e\3e\3e\5e\u04f9" + "\ne\3f\3f\5f\u04fd\nf\3f\3f\3f\2\3\u00b0g\2\4\6\b\n\f\16\20\22\24\26\30" + "\32\34\36 \"$&(*,.\60\62\64\668:<>@BDFHJLNPRTVXZ\\^`bdfhjlnprtvxz|~\u0080" + "\u0082\u0084\u0086\u0088\u008a\u008c\u008e\u0090\u0092\u0094\u0096\u0098" + "\u009a\u009c\u009e\u00a0\u00a2\u00a4\u00a6\u00a8\u00aa\u00ac\u00ae\u00b0" + "\u00b2\u00b4\u00b6\u00b8\u00ba\u00bc\u00be\u00c0\u00c2\u00c4\u00c6\u00c8" + "\u00ca\2\17\6\2  ,,\60\60\63\63\6\2\3\3\24\24#%()\n\2\5\5\7\7\n\n\20\20" + "\26\26\35\35\37\37\'\'\4\2\23\23**\3\2\65:\3\2QT\3\2GH\4\2UVZZ\3\2ST\4" + "\2EFLM\4\2KKNN\4\2DD[e\3\2QR\u0573\2\u00cd\3\2\2\2\4\u00e0\3\2\2\2\6\u00e7" + "\3\2\2\2\b\u010f\3\2\2\2\n\u0113\3\2\2\2\f\u0117\3\2\2\2\16\u011b\3\2" + "\2\2\20\u011d\3\2\2\2\22\u012c\3\2\2\2\24\u0137\3\2\2\2\26\u013c\3\2\2" + "\2\30\u0144\3\2\2\2\32\u0156\3\2\2\2\34\u0161\3\2\2\2\36\u016b\3\2\2\2" + " \u0172\3\2\2\2\"\u017d\3\2\2\2$\u0185\3\2\2\2&\u018e\3\2\2\2(\u01a3\3" + "\2\2\2*\u01ae\3\2\2\2,\u01b2\3\2\2\2.\u01c5\3\2\2\2\60\u01c8\3\2\2\2\62" + "\u01d0\3\2\2\2\64\u01d3\3\2\2\2\66\u01df\3\2\2\28\u01e8\3\2\2\2:\u01ea" + "\3\2\2\2<\u01f5\3\2\2\2>\u0202\3\2\2\2@\u0213\3\2\2\2B\u0216\3\2\2\2D" + "\u021e\3\2\2\2F\u0223\3\2\2\2H\u022d\3\2\2\2J\u022f\3\2\2\2L\u023f\3\2" + "\2\2N\u0251\3\2\2\2P\u0253\3\2\2\2R\u0261\3\2\2\2T\u0263\3\2\2\2V\u0274" + "\3\2\2\2X\u0276\3\2\2\2Z\u027e\3\2\2\2\\\u0291\3\2\2\2^\u0296\3\2\2\2" + "`\u029f\3\2\2\2b\u02a6\3\2\2\2d\u02a8\3\2\2\2f\u02aa\3\2\2\2h\u02b2\3" + "\2\2\2j\u02b4\3\2\2\2l\u02be\3\2\2\2n\u02c0\3\2\2\2p\u02c8\3\2\2\2r\u02cf" + "\3\2\2\2t\u02d1\3\2\2\2v\u02e1\3\2\2\2x\u02e6\3\2\2\2z\u02f7\3\2\2\2|" + "\u030d\3\2\2\2~\u0311\3\2\2\2\u0080\u0313\3\2\2\2\u0082\u0319\3\2\2\2" + "\u0084\u031b\3\2\2\2\u0086\u031e\3\2\2\2\u0088\u032a\3\2\2\2\u008a\u032c" + "\3\2\2\2\u008c\u0332\3\2\2\2\u008e\u03a0\3\2\2\2\u0090\u03a2\3\2\2\2\u0092" + "\u03af\3\2\2\2\u0094\u03b7\3\2\2\2\u0096\u03ba\3\2\2\2\u0098\u03c1\3\2" + "\2\2\u009a\u03cc\3\2\2\2\u009c\u03d5\3\2\2\2\u009e\u03e8\3\2\2\2\u00a0" + "\u03f6\3\2\2\2\u00a2\u03fa\3\2\2\2\u00a4\u03ff\3\2\2\2\u00a6\u0407\3\2" + "\2\2\u00a8\u0409\3\2\2\2\u00aa\u040d\3\2\2\2\u00ac\u0415\3\2\2\2\u00ae" + "\u0417\3\2\2\2\u00b0\u0426\3\2\2\2\u00b2\u0495\3\2\2\2\u00b4\u04a0\3\2" + "\2\2\u00b6\u04b1\3\2\2\2\u00b8\u04b3\3\2\2\2\u00ba\u04b9\3\2\2\2\u00bc" + "\u04d7\3\2\2\2\u00be\u04db\3\2\2\2\u00c0\u04de\3\2\2\2\u00c2\u04e5\3\2" + "\2\2\u00c4\u04ea\3\2\2\2\u00c6\u04f2\3\2\2\2\u00c8\u04f8\3\2\2\2\u00ca" + "\u04fa\3\2\2\2\u00cc\u00ce\5\4\3\2\u00cd\u00cc\3\2\2\2\u00cd\u00ce\3\2" + "\2\2\u00ce\u00d2\3\2\2\2\u00cf\u00d1\5\6\4\2\u00d0\u00cf\3\2\2\2\u00d1" + "\u00d4\3\2\2\2\u00d2\u00d0\3\2\2\2\u00d2\u00d3\3\2\2\2\u00d3\u00d8\3\2" + "\2\2\u00d4\u00d2\3\2\2\2\u00d5\u00d7\5\b\5\2\u00d6\u00d5\3\2\2\2\u00d7" + "\u00da\3\2\2\2\u00d8\u00d6\3\2\2\2\u00d8\u00d9\3\2\2\2\u00d9\u00db\3\2" + "\2\2\u00da\u00d8\3\2\2\2\u00db\u00dc\7\2\2\3\u00dc\3\3\2\2\2\u00dd\u00df" + "\5j\66\2\u00de\u00dd\3\2\2\2\u00df\u00e2\3\2\2\2\u00e0\u00de\3\2\2\2\u00e0" + "\u00e1\3\2\2\2\u00e1\u00e3\3\2\2\2\u00e2\u00e0\3\2\2\2\u00e3\u00e4\7\"" + "\2\2\u00e4\u00e5\5f\64\2\u00e5\u00e6\7A\2\2\u00e6\5\3\2\2\2\u00e7\u00e9" + "\7\33\2\2\u00e8\u00ea\7(\2\2\u00e9\u00e8\3\2\2\2\u00e9\u00ea\3\2\2\2\u00ea" + "\u00eb\3\2\2\2\u00eb\u00ee\5f\64\2\u00ec\u00ed\7C\2\2\u00ed\u00ef\7U\2" + "\2\u00ee\u00ec\3\2\2\2\u00ee\u00ef\3\2\2\2\u00ef\u00f0\3\2\2\2\u00f0\u00f1" + "\7A\2\2\u00f1\7\3\2\2\2\u00f2\u00f4\5\f\7\2\u00f3\u00f2\3\2\2\2\u00f4" + "\u00f7\3\2\2\2\u00f5\u00f3\3\2\2\2\u00f5\u00f6\3\2\2\2\u00f6\u00f8\3\2" + "\2\2\u00f7\u00f5\3\2\2\2\u00f8\u0110\5\20\t\2\u00f9\u00fb\5\f\7\2\u00fa" + "\u00f9\3\2\2\2\u00fb\u00fe\3\2\2\2\u00fc\u00fa\3\2\2\2\u00fc\u00fd\3\2" + "\2\2\u00fd\u00ff\3\2\2\2\u00fe\u00fc\3\2\2\2\u00ff\u0110\5\30\r\2\u0100" + "\u0102\5\f\7\2\u0101\u0100\3\2\2\2\u0102\u0105\3\2\2\2\u0103\u0101\3\2" + "\2\2\u0103\u0104\3\2\2\2\u0104\u0106\3\2\2\2\u0105\u0103\3\2\2\2\u0106" + "\u0110\5 \21\2\u0107\u0109\5\f\7\2\u0108\u0107\3\2\2\2\u0109\u010c\3\2" + "\2\2\u010a\u0108\3\2\2\2\u010a\u010b\3\2\2\2\u010b\u010d\3\2\2\2\u010c" + "\u010a\3\2\2\2\u010d\u0110\5v<\2\u010e\u0110\7A\2\2\u010f\u00f5\3\2\2" + "\2\u010f\u00fc\3\2\2\2\u010f\u0103\3\2\2\2\u010f\u010a\3\2\2\2\u010f\u010e" + "\3\2\2\2\u0110\t\3\2\2\2\u0111\u0114\5\f\7\2\u0112\u0114\t\2\2\2\u0113" + "\u0111\3\2\2\2\u0113\u0112\3\2\2\2\u0114\13\3\2\2\2\u0115\u0118\5j\66" + "\2\u0116\u0118\t\3\2\2\u0117\u0115\3\2\2\2\u0117\u0116\3\2\2\2\u0118\r" + "\3\2\2\2\u0119\u011c\7\24\2\2\u011a\u011c\5j\66\2\u011b\u0119\3\2\2\2" + "\u011b\u011a\3\2\2\2\u011c\17\3\2\2\2\u011d\u011e\7\13\2\2\u011e\u0120" + "\7f\2\2\u011f\u0121\5\22\n\2\u0120\u011f\3\2\2\2\u0120\u0121\3\2\2\2\u0121" + "\u0124\3\2\2\2\u0122\u0123\7\23\2\2\u0123\u0125\5N(\2\u0124\u0122\3\2" + "\2\2\u0124\u0125\3\2\2\2\u0125\u0128\3\2\2\2\u0126\u0127\7\32\2\2\u0127" + "\u0129\5\"\22\2\u0128\u0126\3\2\2\2\u0128\u0129\3\2\2\2\u0129\u012a\3" + "\2\2\2\u012a\u012b\5$\23\2\u012b\21\3\2\2\2\u012c\u012d\7F\2\2\u012d\u0132" + "\5\24\13\2\u012e\u012f\7B\2\2\u012f\u0131\5\24\13\2\u0130\u012e\3\2\2" + "\2\u0131\u0134\3\2\2\2\u0132\u0130\3\2\2\2\u0132\u0133\3\2\2\2\u0133\u0135" + "\3\2\2\2\u0134\u0132\3\2\2\2\u0135\u0136\7E\2\2\u0136\23\3\2\2\2\u0137" + "\u013a\7f\2\2\u0138\u0139\7\23\2\2\u0139\u013b\5\26\f\2\u013a\u0138\3" + "\2\2\2\u013a\u013b\3\2\2\2\u013b\25\3\2\2\2\u013c\u0141\5N(\2\u013d\u013e" + "\7W\2\2\u013e\u0140\5N(\2\u013f\u013d\3\2\2\2\u0140\u0143\3\2\2\2\u0141" + "\u013f\3\2\2\2\u0141\u0142\3\2\2\2\u0142\27\3\2\2\2\u0143\u0141\3\2\2" + "\2\u0144\u0145\7\22\2\2\u0145\u0148\7f\2\2\u0146\u0147\7\32\2\2\u0147" + "\u0149\5\"\22\2\u0148\u0146\3\2\2\2\u0148\u0149\3\2\2\2\u0149\u014a\3" + "\2\2\2\u014a\u014c\7=\2\2\u014b\u014d\5\32\16\2\u014c\u014b\3\2\2\2\u014c" + "\u014d\3\2\2\2\u014d\u014f\3\2\2\2\u014e\u0150\7B\2\2\u014f\u014e\3\2" + "\2\2\u014f\u0150\3\2\2\2\u0150\u0152\3\2\2\2\u0151\u0153\5\36\20\2\u0152" + "\u0151\3\2\2\2\u0152\u0153\3\2\2\2\u0153\u0154\3\2\2\2\u0154\u0155\7>" + "\2\2\u0155\31\3\2\2\2\u0156\u015b\5\34\17\2\u0157\u0158\7B\2\2\u0158\u015a" + "\5\34\17\2\u0159\u0157\3\2\2\2\u015a\u015d\3\2\2\2\u015b\u0159\3\2\2\2" + "\u015b\u015c\3\2\2\2\u015c\33\3\2\2\2\u015d\u015b\3\2\2\2\u015e\u0160" + "\5j\66\2\u015f\u015e\3\2\2\2\u0160\u0163\3\2\2\2\u0161\u015f\3\2\2\2\u0161" + "\u0162\3\2\2\2\u0162\u0164\3\2\2\2\u0163\u0161\3\2\2\2\u0164\u0166\7f" + "\2\2\u0165\u0167\5\u00caf\2\u0166\u0165\3\2\2\2\u0166\u0167\3\2\2\2\u0167" + "\u0169\3\2\2\2\u0168\u016a\5$\23\2\u0169\u0168\3\2\2\2\u0169\u016a\3\2" + "\2\2\u016a\35\3\2\2\2\u016b\u016f\7A\2\2\u016c\u016e\5(\25\2\u016d\u016c" + "\3\2\2\2\u016e\u0171\3\2\2\2\u016f\u016d\3\2\2\2\u016f\u0170\3\2\2\2\u0170" + "\37\3\2\2\2\u0171\u016f\3\2\2\2\u0172\u0173\7\36\2\2\u0173\u0175\7f\2" + "\2\u0174\u0176\5\22\n\2\u0175\u0174\3\2\2\2\u0175\u0176\3\2\2\2\u0176" + "\u0179\3\2\2\2\u0177\u0178\7\23\2\2\u0178\u017a\5\"\22\2\u0179\u0177\3" + "\2\2\2\u0179\u017a\3\2\2\2\u017a\u017b\3\2\2\2\u017b\u017c\5&\24\2\u017c" + "!\3\2\2\2\u017d\u0182\5N(\2\u017e\u017f\7B\2\2\u017f\u0181\5N(\2\u0180" + "\u017e\3\2\2\2\u0181\u0184\3\2\2\2\u0182\u0180\3\2\2\2\u0182\u0183\3\2" + "\2\2\u0183#\3\2\2\2\u0184\u0182\3\2\2\2\u0185\u0189\7=\2\2\u0186\u0188" + "\5(\25\2\u0187\u0186\3\2\2\2\u0188\u018b\3\2\2\2\u0189\u0187\3\2\2\2\u0189" + "\u018a\3\2\2\2\u018a\u018c\3\2\2\2\u018b\u0189\3\2\2\2\u018c\u018d\7>" + "\2\2\u018d%\3\2\2\2\u018e\u0192\7=\2\2\u018f\u0191\5\66\34\2\u0190\u018f" + "\3\2\2\2\u0191\u0194\3\2\2\2\u0192\u0190\3\2\2\2\u0192\u0193\3\2\2\2\u0193" + "\u0195\3\2\2\2\u0194\u0192\3\2\2\2\u0195\u0196\7>\2\2\u0196\'\3\2\2\2" + "\u0197\u01a4\7A\2\2\u0198\u019a\7(\2\2\u0199\u0198\3\2\2\2\u0199\u019a" + "\3\2\2\2\u019a\u019b\3\2\2\2\u019b\u01a4\5\u0086D\2\u019c\u019e\5\n\6" + "\2\u019d\u019c\3\2\2\2\u019e\u01a1\3\2\2\2\u019f\u019d\3\2\2\2\u019f\u01a0" + "\3\2\2\2\u01a0\u01a2\3\2\2\2\u01a1\u019f\3\2\2\2\u01a2\u01a4\5*\26\2\u01a3" + "\u0197\3\2\2\2\u01a3\u0199\3\2\2\2\u01a3\u019f\3\2\2\2\u01a4)\3\2\2\2" + "\u01a5\u01af\5,\27\2\u01a6\u01af\5.\30\2\u01a7\u01af\5\64\33\2\u01a8\u01af" + "\5\60\31\2\u01a9\u01af\5\62\32\2\u01aa\u01af\5 \21\2\u01ab\u01af\5v<\2" + "\u01ac\u01af\5\20\t\2\u01ad\u01af\5\30\r\2\u01ae\u01a5\3\2\2\2\u01ae\u01a6" + "\3\2\2\2\u01ae\u01a7\3\2\2\2\u01ae\u01a8\3\2\2\2\u01ae\u01a9\3\2\2\2\u01ae" + "\u01aa\3\2\2\2\u01ae\u01ab\3\2\2\2\u01ae\u01ac\3\2\2\2\u01ae\u01ad\3\2" + "\2\2\u01af+\3\2\2\2\u01b0\u01b3\5N(\2\u01b1\u01b3\7\62\2\2\u01b2\u01b0" + "\3\2\2\2\u01b2\u01b1\3\2\2\2\u01b3\u01b4\3\2\2\2\u01b4\u01b5\7f\2\2\u01b5" + "\u01ba\5Z.\2\u01b6\u01b7\7?\2\2\u01b7\u01b9\7@\2\2\u01b8\u01b6\3\2\2\2" + "\u01b9\u01bc\3\2\2\2\u01ba\u01b8\3\2\2\2\u01ba\u01bb\3\2\2\2\u01bb\u01bf" + "\3\2\2\2\u01bc\u01ba\3\2\2\2\u01bd\u01be\7/\2\2\u01be\u01c0\5X-\2\u01bf" + "\u01bd\3\2\2\2\u01bf\u01c0\3\2\2\2\u01c0\u01c3\3\2\2\2\u01c1\u01c4\5b" + "\62\2\u01c2\u01c4\7A\2\2\u01c3\u01c1\3\2\2\2\u01c3\u01c2\3\2\2\2\u01c4" + "-\3\2\2\2\u01c5\u01c6\5\22\n\2\u01c6\u01c7\5,\27\2\u01c7/\3\2\2\2\u01c8" + "\u01c9\7f\2\2\u01c9\u01cc\5Z.\2\u01ca\u01cb\7/\2\2\u01cb\u01cd\5X-\2\u01cc" + "\u01ca\3\2\2\2\u01cc\u01cd\3\2\2\2\u01cd\u01ce\3\2\2\2\u01ce\u01cf\5d" + "\63\2\u01cf\61\3\2\2\2\u01d0\u01d1\5\22\n\2\u01d1\u01d2\5\60\31\2\u01d2" + "\63\3\2\2\2\u01d3\u01d4\5N(\2\u01d4\u01d5\5B\"\2\u01d5\u01d6\7A\2\2\u01d6" + "\65\3\2\2\2\u01d7\u01d9\5\n\6\2\u01d8\u01d7\3\2\2\2\u01d9\u01dc\3\2\2" + "\2\u01da\u01d8\3\2\2\2\u01da\u01db\3\2\2\2\u01db\u01dd\3\2\2\2\u01dc\u01da" + "\3\2\2\2\u01dd\u01e0\58\35\2\u01de\u01e0\7A\2\2\u01df\u01da\3\2\2\2\u01df" + "\u01de\3\2\2\2\u01e0\67\3\2\2\2\u01e1\u01e9\5:\36\2\u01e2\u01e9\5> \2" + "\u01e3\u01e9\5@!\2\u01e4\u01e9\5 \21\2\u01e5\u01e9\5v<\2\u01e6\u01e9\5" + "\20\t\2\u01e7\u01e9\5\30\r\2\u01e8\u01e1\3\2\2\2\u01e8\u01e2\3\2\2\2\u01e8" + "\u01e3\3\2\2\2\u01e8\u01e4\3\2\2\2\u01e8\u01e5\3\2\2\2\u01e8\u01e6\3\2" + "\2\2\u01e8\u01e7\3\2\2\2\u01e99\3\2\2\2\u01ea\u01eb\5N(\2\u01eb\u01f0" + "\5<\37\2\u01ec\u01ed\7B\2\2\u01ed\u01ef\5<\37\2\u01ee\u01ec\3\2\2\2\u01ef" + "\u01f2\3\2\2\2\u01f0\u01ee\3\2\2\2\u01f0\u01f1\3\2\2\2\u01f1\u01f3\3\2" + "\2\2\u01f2\u01f0\3\2\2\2\u01f3\u01f4\7A\2\2\u01f4;\3\2\2\2\u01f5\u01fa" + "\7f\2\2\u01f6\u01f7\7?\2\2\u01f7\u01f9\7@\2\2\u01f8\u01f6\3\2\2\2\u01f9" + "\u01fc\3\2\2\2\u01fa\u01f8\3\2\2\2\u01fa\u01fb\3\2\2\2\u01fb\u01fd\3\2" + "\2\2\u01fc\u01fa\3\2\2\2\u01fd\u01fe\7D\2\2\u01fe\u01ff\5H%\2\u01ff=\3" + "\2\2\2\u0200\u0203\5N(\2\u0201\u0203\7\62\2\2\u0202\u0200\3\2\2\2\u0202" + "\u0201\3\2\2\2\u0203\u0204\3\2\2\2\u0204\u0205\7f\2\2\u0205\u020a\5Z." + "\2\u0206\u0207\7?\2\2\u0207\u0209\7@\2\2\u0208\u0206\3\2\2\2\u0209\u020c" + "\3\2\2\2\u020a\u0208\3\2\2\2\u020a\u020b\3\2\2\2\u020b\u020f\3\2\2\2\u020c" + "\u020a\3\2\2\2\u020d\u020e\7/\2\2\u020e\u0210\5X-\2\u020f\u020d\3\2\2" + "\2\u020f\u0210\3\2\2\2\u0210\u0211\3\2\2\2\u0211\u0212\7A\2\2\u0212?\3" + "\2\2\2\u0213\u0214\5\22\n\2\u0214\u0215\5> \2\u0215A\3\2\2\2\u0216\u021b" + "\5D#\2\u0217\u0218\7B\2\2\u0218\u021a\5D#\2\u0219\u0217\3\2\2\2\u021a" + "\u021d\3\2\2\2\u021b\u0219\3\2\2\2\u021b\u021c\3\2\2\2\u021cC\3\2\2\2" + "\u021d\u021b\3\2\2\2\u021e\u0221\5F$\2\u021f\u0220\7D\2\2\u0220\u0222" + "\5H%\2\u0221\u021f\3\2\2\2\u0221\u0222\3\2\2\2\u0222E\3\2\2\2\u0223\u0228" + "\7f\2\2\u0224\u0225\7?\2\2\u0225\u0227\7@\2\2\u0226\u0224\3\2\2\2\u0227" + "\u022a\3\2\2\2\u0228\u0226\3\2\2\2\u0228\u0229\3\2\2\2\u0229G\3\2\2\2" + "\u022a\u0228\3\2\2\2\u022b\u022e\5J&\2\u022c\u022e\5\u00b0Y\2\u022d\u022b" + "\3\2\2\2\u022d\u022c\3\2\2\2\u022eI\3\2\2\2\u022f\u023b\7=\2\2\u0230\u0235" + "\5H%\2\u0231\u0232\7B\2\2\u0232\u0234\5H%\2\u0233\u0231\3\2\2\2\u0234" + "\u0237\3\2\2\2\u0235\u0233\3\2\2\2\u0235\u0236\3\2\2\2\u0236\u0239\3\2" + "\2\2\u0237\u0235\3\2\2\2\u0238\u023a\7B\2\2\u0239\u0238\3\2\2\2\u0239" + "\u023a\3\2\2\2\u023a\u023c\3\2\2\2\u023b\u0230\3\2\2\2\u023b\u023c\3\2" + "\2\2\u023c\u023d\3\2\2\2\u023d\u023e\7>\2\2\u023eK\3\2\2\2\u023f\u0240" + "\7f\2\2\u0240M\3\2\2\2\u0241\u0246\5P)\2\u0242\u0243\7?\2\2\u0243\u0245" + "\7@\2\2\u0244\u0242\3\2\2\2\u0245\u0248\3\2\2\2\u0246\u0244\3\2\2\2\u0246" + "\u0247\3\2\2\2\u0247\u0252\3\2\2\2\u0248\u0246\3\2\2\2\u0249\u024e\5R" + "*\2\u024a\u024b\7?\2\2\u024b\u024d\7@\2\2\u024c\u024a\3\2\2\2\u024d\u0250" + "\3\2\2\2\u024e\u024c\3\2\2\2\u024e\u024f\3\2\2\2\u024f\u0252\3\2\2\2\u0250" + "\u024e\3\2\2\2\u0251\u0241\3\2\2\2\u0251\u0249\3\2\2\2\u0252O\3\2\2\2" + "\u0253\u0255\7f\2\2\u0254\u0256\5T+\2\u0255\u0254\3\2\2\2\u0255\u0256" + "\3\2\2\2\u0256\u025e\3\2\2\2\u0257\u0258\7C\2\2\u0258\u025a\7f\2\2\u0259" + "\u025b\5T+\2\u025a\u0259\3\2\2\2\u025a\u025b\3\2\2\2\u025b\u025d\3\2\2" + "\2\u025c\u0257\3\2\2\2\u025d\u0260\3\2\2\2\u025e\u025c\3\2\2\2\u025e\u025f" + "\3\2\2\2\u025fQ\3\2\2\2\u0260\u025e\3\2\2\2\u0261\u0262\t\4\2\2\u0262" + "S\3\2\2\2\u0263\u0264\7F\2\2\u0264\u0269\5V,\2\u0265\u0266\7B\2\2\u0266" + "\u0268\5V,\2\u0267\u0265\3\2\2\2\u0268\u026b\3\2\2\2\u0269\u0267\3\2\2" + "\2\u0269\u026a\3\2\2\2\u026a\u026c\3\2\2\2\u026b\u0269\3\2\2\2\u026c\u026d" + "\7E\2\2\u026dU\3\2\2\2\u026e\u0275\5N(\2\u026f\u0272\7I\2\2\u0270\u0271" + "\t\5\2\2\u0271\u0273\5N(\2\u0272\u0270\3\2\2\2\u0272\u0273\3\2\2\2\u0273" + "\u0275\3\2\2\2\u0274\u026e\3\2\2\2\u0274\u026f\3\2\2\2\u0275W\3\2\2\2" + "\u0276\u027b\5f\64\2\u0277\u0278\7B\2\2\u0278\u027a\5f\64\2\u0279\u0277" + "\3\2\2\2\u027a\u027d\3\2\2\2\u027b\u0279\3\2\2\2\u027b\u027c\3\2\2\2\u027c" + "Y\3\2\2\2\u027d\u027b\3\2\2\2\u027e\u0280\7;\2\2\u027f\u0281\5\\/\2\u0280" + "\u027f\3\2\2\2\u0280\u0281\3\2\2\2\u0281\u0282\3\2\2\2\u0282\u0283\7<" + "\2\2\u0283[\3\2\2\2\u0284\u0289\5^\60\2\u0285\u0286\7B\2\2\u0286\u0288" + "\5^\60\2\u0287\u0285\3\2\2\2\u0288\u028b\3\2\2\2\u0289\u0287\3\2\2\2\u0289" + "\u028a\3\2\2\2\u028a\u028e\3\2\2\2\u028b\u0289\3\2\2\2\u028c\u028d\7B" + "\2\2\u028d\u028f\5`\61\2\u028e\u028c\3\2\2\2\u028e\u028f\3\2\2\2\u028f" + "\u0292\3\2\2\2\u0290\u0292\5`\61\2\u0291\u0284\3\2\2\2\u0291\u0290\3\2" + "\2\2\u0292]\3\2\2\2\u0293\u0295\5\16\b\2\u0294\u0293\3\2\2\2\u0295\u0298" + "\3\2\2\2\u0296\u0294\3\2\2\2\u0296\u0297\3\2\2\2\u0297\u0299\3\2\2\2\u0298" + "\u0296\3\2\2\2\u0299\u029a\5N(\2\u029a\u029b\5F$\2\u029b_\3\2\2\2\u029c" + "\u029e\5\16\b\2\u029d\u029c\3\2\2\2\u029e\u02a1\3\2\2\2\u029f\u029d\3" + "\2\2\2\u029f\u02a0\3\2\2\2\u02a0\u02a2\3\2\2\2\u02a1\u029f\3\2\2\2\u02a2" + "\u02a3\5N(\2\u02a3\u02a4\7h\2\2\u02a4\u02a5\5F$\2\u02a5a\3\2\2\2\u02a6" + "\u02a7\5\u0086D\2\u02a7c\3\2\2\2\u02a8\u02a9\5\u0086D\2\u02a9e\3\2\2\2" + "\u02aa\u02af\7f\2\2\u02ab\u02ac\7C\2\2\u02ac\u02ae\7f\2\2\u02ad\u02ab" + "\3\2\2\2\u02ae\u02b1\3\2\2\2\u02af\u02ad\3\2\2\2\u02af\u02b0\3\2\2\2\u02b0" + "g\3\2\2\2\u02b1\u02af\3\2\2\2\u02b2\u02b3\t\6\2\2\u02b3i\3\2\2\2\u02b4" + "\u02b5\7g\2\2\u02b5\u02bc\5l\67\2\u02b6\u02b9\7;\2\2\u02b7\u02ba\5n8\2" + "\u02b8\u02ba\5r:\2\u02b9\u02b7\3\2\2\2\u02b9\u02b8\3\2\2\2\u02b9\u02ba" + "\3\2\2\2\u02ba\u02bb\3\2\2\2\u02bb\u02bd\7<\2\2\u02bc\u02b6\3\2\2\2\u02bc" + "\u02bd\3\2\2\2\u02bdk\3\2\2\2\u02be\u02bf\5f\64\2\u02bfm\3\2\2\2\u02c0" + "\u02c5\5p9\2\u02c1\u02c2\7B\2\2\u02c2\u02c4\5p9\2\u02c3\u02c1\3\2\2\2" + "\u02c4\u02c7\3\2\2\2\u02c5\u02c3\3\2\2\2\u02c5\u02c6\3\2\2\2\u02c6o\3" + "\2\2\2\u02c7\u02c5\3\2\2\2\u02c8\u02c9\7f\2\2\u02c9\u02ca\7D\2\2\u02ca" + "\u02cb\5r:\2\u02cbq\3\2\2\2\u02cc\u02d0\5\u00b0Y\2\u02cd\u02d0\5j\66\2" + "\u02ce\u02d0\5t;\2\u02cf\u02cc\3\2\2\2\u02cf\u02cd\3\2\2\2\u02cf\u02ce" + "\3\2\2\2\u02d0s\3\2\2\2\u02d1\u02da\7=\2\2\u02d2\u02d7\5r:\2\u02d3\u02d4" + "\7B\2\2\u02d4\u02d6\5r:\2\u02d5\u02d3\3\2\2\2\u02d6\u02d9\3\2\2\2\u02d7" + "\u02d5\3\2\2\2\u02d7\u02d8\3\2\2\2\u02d8\u02db\3\2\2\2\u02d9\u02d7\3\2" + "\2\2\u02da\u02d2\3\2\2\2\u02da\u02db\3\2\2\2\u02db\u02dd\3\2\2\2\u02dc" + "\u02de\7B\2\2\u02dd\u02dc\3\2\2\2\u02dd\u02de\3\2\2\2\u02de\u02df\3\2" + "\2\2\u02df\u02e0\7>\2\2\u02e0u\3\2\2\2\u02e1\u02e2\7g\2\2\u02e2\u02e3" + "\7\36\2\2\u02e3\u02e4\7f\2\2\u02e4\u02e5\5x=\2\u02e5w\3\2\2\2\u02e6\u02ea" + "\7=\2\2\u02e7\u02e9\5z>\2\u02e8\u02e7\3\2\2\2\u02e9\u02ec\3\2\2\2\u02ea" + "\u02e8\3\2\2\2\u02ea\u02eb\3\2\2\2\u02eb\u02ed\3\2\2\2\u02ec\u02ea\3\2" + "\2\2\u02ed\u02ee\7>\2\2\u02eey\3\2\2\2\u02ef\u02f1\5\n\6\2\u02f0\u02ef" + "\3\2\2\2\u02f1\u02f4\3\2\2\2\u02f2\u02f0\3\2\2\2\u02f2\u02f3\3\2\2\2\u02f3" + "\u02f5\3\2\2\2\u02f4\u02f2\3\2\2\2\u02f5\u02f8\5|?\2\u02f6\u02f8\7A\2" + "\2\u02f7\u02f2\3\2\2\2\u02f7\u02f6\3\2\2\2\u02f8{\3\2\2\2\u02f9\u02fa" + "\5N(\2\u02fa\u02fb\5~@\2\u02fb\u02fc\7A\2\2\u02fc\u030e\3\2\2\2\u02fd" + "\u02ff\5\20\t\2\u02fe\u0300\7A\2\2\u02ff\u02fe\3\2\2\2\u02ff\u0300\3\2" + "\2\2\u0300\u030e\3\2\2\2\u0301\u0303\5 \21\2\u0302\u0304\7A\2\2\u0303" + "\u0302\3\2\2\2\u0303\u0304\3\2\2\2\u0304\u030e\3\2\2\2\u0305\u0307\5\30" + "\r\2\u0306\u0308\7A\2\2\u0307\u0306\3\2\2\2\u0307\u0308\3\2\2\2\u0308" + "\u030e\3\2\2\2\u0309\u030b\5v<\2\u030a\u030c\7A\2\2\u030b\u030a\3\2\2" + "\2\u030b\u030c\3\2\2\2\u030c\u030e\3\2\2\2\u030d\u02f9\3\2\2\2\u030d\u02fd" + "\3\2\2\2\u030d\u0301\3\2\2\2\u030d\u0305\3\2\2\2\u030d\u0309\3\2\2\2\u030e" + "}\3\2\2\2\u030f\u0312\5\u0080A\2\u0310\u0312\5\u0082B\2\u0311\u030f\3" + "\2\2\2\u0311\u0310\3\2\2\2\u0312\177\3\2\2\2\u0313\u0314\7f\2\2\u0314" + "\u0315\7;\2\2\u0315\u0317\7<\2\2\u0316\u0318\5\u0084C\2\u0317\u0316\3" + "\2\2\2\u0317\u0318\3\2\2\2\u0318\u0081\3\2\2\2\u0319\u031a\5B\"\2\u031a" + "\u0083\3\2\2\2\u031b\u031c\7\16\2\2\u031c\u031d\5r:\2\u031d\u0085\3\2" + "\2\2\u031e\u0322\7=\2\2\u031f\u0321\5\u0088E\2\u0320\u031f\3\2\2\2\u0321" + "\u0324\3\2\2\2\u0322\u0320\3\2\2\2\u0322\u0323\3\2\2\2\u0323\u0325\3\2" + "\2\2\u0324\u0322\3\2\2\2\u0325\u0326\7>\2\2\u0326\u0087\3\2\2\2\u0327" + "\u032b\5\u008aF\2\u0328\u032b\5\u008eH\2\u0329\u032b\5\b\5\2\u032a\u0327" + "\3\2\2\2\u032a\u0328\3\2\2\2\u032a\u0329\3\2\2\2\u032b\u0089\3\2\2\2\u032c" + "\u032d\5\u008cG\2\u032d\u032e\7A\2\2\u032e\u008b\3\2\2\2\u032f\u0331\5" + "\16\b\2\u0330\u032f\3\2\2\2\u0331\u0334\3\2\2\2\u0332\u0330\3\2\2\2\u0332" + "\u0333\3\2\2\2\u0333\u0335\3\2\2\2\u0334\u0332\3\2\2\2\u0335\u0336\5N" + "(\2\u0336\u0337\5B\"\2\u0337\u008d\3\2\2\2\u0338\u03a1\5\u0086D\2\u0339" + "\u033a\7\4\2\2\u033a\u033d\5\u00b0Y\2\u033b\u033c\7J\2\2\u033c\u033e\5" + "\u00b0Y\2\u033d\u033b\3\2\2\2\u033d\u033e\3\2\2\2\u033e\u033f\3\2\2\2" + "\u033f\u0340\7A\2\2\u0340\u03a1\3\2\2\2\u0341\u0342\7\30\2\2\u0342\u0343" + "\5\u00a8U\2\u0343\u0346\5\u008eH\2\u0344\u0345\7\21\2\2\u0345\u0347\5" + "\u008eH\2\u0346\u0344\3\2\2\2\u0346\u0347\3\2\2\2\u0347\u03a1\3\2\2\2" + "\u0348\u0349\7\27\2\2\u0349\u034a\7;\2\2\u034a\u034b\5\u00a0Q\2\u034b" + "\u034c\7<\2\2\u034c\u034d\5\u008eH\2\u034d\u03a1\3\2\2\2\u034e\u034f\7" + "\64\2\2\u034f\u0350\5\u00a8U\2\u0350\u0351\5\u008eH\2\u0351\u03a1\3\2" + "\2\2\u0352\u0353\7\17\2\2\u0353\u0354\5\u008eH\2\u0354\u0355\7\64\2\2" + "\u0355\u0356\5\u00a8U\2\u0356\u0357\7A\2\2\u0357\u03a1\3\2\2\2\u0358\u0359" + "\7\61\2\2\u0359\u0363\5\u0086D\2\u035a\u035c\5\u0090I\2\u035b\u035a\3" + "\2\2\2\u035c\u035d\3\2\2\2\u035d\u035b\3\2\2\2\u035d\u035e\3\2\2\2\u035e" + "\u0360\3\2\2\2\u035f\u0361\5\u0094K\2\u0360\u035f\3\2\2\2\u0360\u0361" + "\3\2\2\2\u0361\u0364\3\2\2\2\u0362\u0364\5\u0094K\2\u0363\u035b\3\2\2" + "\2\u0363\u0362\3\2\2\2\u0364\u03a1\3\2\2\2\u0365\u0366\7\61\2\2\u0366" + "\u0367\5\u0096L\2\u0367\u036b\5\u0086D\2\u0368\u036a\5\u0090I\2\u0369" + "\u0368\3\2\2\2\u036a\u036d\3\2\2\2\u036b\u0369\3\2\2\2\u036b\u036c\3\2" + "\2\2\u036c\u036f\3\2\2\2\u036d\u036b\3\2\2\2\u036e\u0370\5\u0094K\2\u036f" + "\u036e\3\2\2\2\u036f\u0370\3\2\2\2\u0370\u03a1\3\2\2\2\u0371\u0372\7+" + "\2\2\u0372\u0373\5\u00a8U\2\u0373\u0377\7=\2\2\u0374\u0376\5\u009cO\2" + "\u0375\u0374\3\2\2\2\u0376\u0379\3\2\2\2\u0377\u0375\3\2\2\2\u0377\u0378" + "\3\2\2\2\u0378\u037d\3\2\2\2\u0379\u0377\3\2\2\2\u037a\u037c\5\u009eP" + "\2\u037b\u037a\3\2\2\2\u037c\u037f\3\2\2\2\u037d\u037b\3\2\2\2\u037d\u037e" + "\3\2\2\2\u037e\u0380\3\2\2\2\u037f\u037d\3\2\2\2\u0380\u0381\7>\2\2\u0381" + "\u03a1\3\2\2\2\u0382\u0383\7,\2\2\u0383\u0384\5\u00a8U\2\u0384\u0385\5" + "\u0086D\2\u0385\u03a1\3\2\2\2\u0386\u0388\7&\2\2\u0387\u0389\5\u00b0Y" + "\2\u0388\u0387\3\2\2\2\u0388\u0389\3\2\2\2\u0389\u038a\3\2\2\2\u038a\u03a1" + "\7A\2\2\u038b\u038c\7.\2\2\u038c\u038d\5\u00b0Y\2\u038d\u038e\7A\2\2\u038e" + "\u03a1\3\2\2\2\u038f\u0391\7\6\2\2\u0390\u0392\7f\2\2\u0391\u0390\3\2" + "\2\2\u0391\u0392\3\2\2\2\u0392\u0393\3\2\2\2\u0393\u03a1\7A\2\2\u0394" + "\u0396\7\r\2\2\u0395\u0397\7f\2\2\u0396\u0395\3\2\2\2\u0396\u0397\3\2" + "\2\2\u0397\u0398\3\2\2\2\u0398\u03a1\7A\2\2\u0399\u03a1\7A\2\2\u039a\u039b" + "\5\u00acW\2\u039b\u039c\7A\2\2\u039c\u03a1\3\2\2\2\u039d\u039e\7f\2\2" + "\u039e\u039f\7J\2\2\u039f\u03a1\5\u008eH\2\u03a0\u0338\3\2\2\2\u03a0\u0339" + "\3\2\2\2\u03a0\u0341\3\2\2\2\u03a0\u0348\3\2\2\2\u03a0\u034e\3\2\2\2\u03a0" + "\u0352\3\2\2\2\u03a0\u0358\3\2\2\2\u03a0\u0365\3\2\2\2\u03a0\u0371\3\2" + "\2\2\u03a0\u0382\3\2\2\2\u03a0\u0386\3\2\2\2\u03a0\u038b\3\2\2\2\u03a0" + "\u038f\3\2\2\2\u03a0\u0394\3\2\2\2\u03a0\u0399\3\2\2\2\u03a0\u039a\3\2" + "\2\2\u03a0\u039d\3\2\2\2\u03a1\u008f\3\2\2\2\u03a2\u03a3\7\t\2\2\u03a3" + "\u03a7\7;\2\2\u03a4\u03a6\5\16\b\2\u03a5\u03a4\3\2\2\2\u03a6\u03a9\3\2" + "\2\2\u03a7\u03a5\3\2\2\2\u03a7\u03a8\3\2\2\2\u03a8\u03aa\3\2\2\2\u03a9" + "\u03a7\3\2\2\2\u03aa\u03ab\5\u0092J\2\u03ab\u03ac\7f\2\2\u03ac\u03ad\7" + "<\2\2\u03ad\u03ae\5\u0086D\2\u03ae\u0091\3\2\2\2\u03af\u03b4\5f\64\2\u03b0" + "\u03b1\7X\2\2\u03b1\u03b3\5f\64\2\u03b2\u03b0\3\2\2\2\u03b3\u03b6\3\2" + "\2\2\u03b4\u03b2\3\2\2\2\u03b4\u03b5\3\2\2\2\u03b5\u0093\3\2\2\2\u03b6" + "\u03b4\3\2\2\2\u03b7\u03b8\7\25\2\2\u03b8\u03b9\5\u0086D\2\u03b9\u0095" + "\3\2\2\2\u03ba\u03bb\7;\2\2\u03bb\u03bd\5\u0098M\2\u03bc\u03be\7A\2\2" + "\u03bd\u03bc\3\2\2\2\u03bd\u03be\3\2\2\2\u03be\u03bf\3\2\2\2\u03bf\u03c0" + "\7<\2\2\u03c0\u0097\3\2\2\2\u03c1\u03c6\5\u009aN\2\u03c2\u03c3\7A\2\2" + "\u03c3\u03c5\5\u009aN\2\u03c4\u03c2\3\2\2\2\u03c5\u03c8\3\2\2\2\u03c6" + "\u03c4\3\2\2\2\u03c6\u03c7\3\2\2\2\u03c7\u0099\3\2\2\2\u03c8\u03c6\3\2" + "\2\2\u03c9\u03cb\5\16\b\2\u03ca\u03c9\3\2\2\2\u03cb\u03ce\3\2\2\2\u03cc" + "\u03ca\3\2\2\2\u03cc\u03cd\3\2\2\2\u03cd\u03cf\3\2\2\2\u03ce\u03cc\3\2" + "\2\2\u03cf\u03d0\5P)\2\u03d0\u03d1\5F$\2\u03d1\u03d2\7D\2\2\u03d2\u03d3" + "\5\u00b0Y\2\u03d3\u009b\3\2\2\2\u03d4\u03d6\5\u009eP\2\u03d5\u03d4\3\2" + "\2\2\u03d6\u03d7\3\2\2\2\u03d7\u03d5\3\2\2\2\u03d7\u03d8\3\2\2\2\u03d8" + "\u03da\3\2\2\2\u03d9\u03db\5\u0088E\2\u03da\u03d9\3\2\2\2\u03db\u03dc" + "\3\2\2\2\u03dc\u03da\3\2\2\2\u03dc\u03dd\3\2\2\2\u03dd\u009d\3\2\2\2\u03de" + "\u03df\7\b\2\2\u03df\u03e0\5\u00aeX\2\u03e0\u03e1\7J\2\2\u03e1\u03e9\3" + "\2\2\2\u03e2\u03e3\7\b\2\2\u03e3\u03e4\5L\'\2\u03e4\u03e5\7J\2\2\u03e5" + "\u03e9\3\2\2\2\u03e6\u03e7\7\16\2\2\u03e7\u03e9\7J\2\2\u03e8\u03de\3\2" + "\2\2\u03e8\u03e2\3\2\2\2\u03e8\u03e6\3\2\2\2\u03e9\u009f\3\2\2\2\u03ea" + "\u03f7\5\u00a4S\2\u03eb\u03ed\5\u00a2R\2\u03ec\u03eb\3\2\2\2\u03ec\u03ed" + "\3\2\2\2\u03ed\u03ee\3\2\2\2\u03ee\u03f0\7A\2\2\u03ef\u03f1\5\u00b0Y\2" + "\u03f0\u03ef\3\2\2\2\u03f0\u03f1\3\2\2\2\u03f1\u03f2\3\2\2\2\u03f2\u03f4" + "\7A\2\2\u03f3\u03f5\5\u00a6T\2\u03f4\u03f3\3\2\2\2\u03f4\u03f5\3\2\2\2" + "\u03f5\u03f7\3\2\2\2\u03f6\u03ea\3\2\2\2\u03f6\u03ec\3\2\2\2\u03f7\u00a1" + "\3\2\2\2\u03f8\u03fb\5\u008cG\2\u03f9\u03fb\5\u00aaV\2\u03fa\u03f8\3\2" + "\2\2\u03fa\u03f9\3\2\2\2\u03fb\u00a3\3\2\2\2\u03fc\u03fe\5\16\b\2\u03fd" + "\u03fc\3\2\2\2\u03fe\u0401\3\2\2\2\u03ff\u03fd\3\2\2\2\u03ff\u0400\3\2" + "\2\2\u0400\u0402\3\2\2\2\u0401\u03ff\3\2\2\2\u0402\u0403\5N(\2\u0403\u0404" + "\5F$\2\u0404\u0405\7J\2\2\u0405\u0406\5\u00b0Y\2\u0406\u00a5\3\2\2\2\u0407" + "\u0408\5\u00aaV\2\u0408\u00a7\3\2\2\2\u0409\u040a\7;\2\2\u040a\u040b\5" + "\u00b0Y\2\u040b\u040c\7<\2\2\u040c\u00a9\3\2\2\2\u040d\u0412\5\u00b0Y" + "\2\u040e\u040f\7B\2\2\u040f\u0411\5\u00b0Y\2\u0410\u040e\3\2\2\2\u0411" + "\u0414\3\2\2\2\u0412\u0410\3\2\2\2\u0412\u0413\3\2\2\2\u0413\u00ab\3\2" + "\2\2\u0414\u0412\3\2\2\2\u0415\u0416\5\u00b0Y\2\u0416\u00ad\3\2\2\2\u0417" + "\u0418\5\u00b0Y\2\u0418\u00af\3\2\2\2\u0419\u041a\bY\1\2\u041a\u041b\7" + ";\2\2\u041b\u041c\5N(\2\u041c\u041d\7<\2\2\u041d\u041e\5\u00b0Y\23\u041e" + "\u0427\3\2\2\2\u041f\u0420\t\7\2\2\u0420\u0427\5\u00b0Y\21\u0421\u0422" + "\t\b\2\2\u0422\u0427\5\u00b0Y\20\u0423\u0427\5\u00b2Z\2\u0424\u0425\7" + "!\2\2\u0425\u0427\5\u00b4[\2\u0426\u0419\3\2\2\2\u0426\u041f\3\2\2\2\u0426" + "\u0421\3\2\2\2\u0426\u0423\3\2\2\2\u0426\u0424\3\2\2\2\u0427\u047d\3\2" + "\2\2\u0428\u0429\f\17\2\2\u0429\u042a\t\t\2\2\u042a\u047c\5\u00b0Y\20" + "\u042b\u042c\f\16\2\2\u042c\u042d\t\n\2\2\u042d\u047c\5\u00b0Y\17\u042e" + "\u0436\f\r\2\2\u042f\u0430\7F\2\2\u0430\u0437\7F\2\2\u0431\u0432\7E\2" + "\2\u0432\u0433\7E\2\2\u0433\u0437\7E\2\2\u0434\u0435\7E\2\2\u0435\u0437" + "\7E\2\2\u0436\u042f\3\2\2\2\u0436\u0431\3\2\2\2\u0436\u0434\3\2\2\2\u0437" + "\u0438\3\2\2\2\u0438\u047c\5\u00b0Y\16\u0439\u043a\f\f\2\2\u043a\u043b" + "\t\13\2\2\u043b\u047c\5\u00b0Y\r\u043c\u043d\f\n\2\2\u043d\u043e\t\f\2" + "\2\u043e\u047c\5\u00b0Y\13\u043f\u0440\f\t\2\2\u0440\u0441\7W\2\2\u0441" + "\u047c\5\u00b0Y\n\u0442\u0443\f\b\2\2\u0443\u0444\7Y\2\2\u0444\u047c\5" + "\u00b0Y\t\u0445\u0446\f\7\2\2\u0446\u0447\7X\2\2\u0447\u047c\5\u00b0Y" + "\b\u0448\u0449\f\6\2\2\u0449\u044a\7O\2\2\u044a\u047c\5\u00b0Y\7\u044b" + "\u044c\f\5\2\2\u044c\u044d\7P\2\2\u044d\u047c\5\u00b0Y\6\u044e\u044f\f" + "\4\2\2\u044f\u0450\7I\2\2\u0450\u0451\5\u00b0Y\2\u0451\u0452\7J\2\2\u0452" + "\u0453\5\u00b0Y\5\u0453\u047c\3\2\2\2\u0454\u0455\f\3\2\2\u0455\u0456" + "\t\r\2\2\u0456\u047c\5\u00b0Y\3\u0457\u0458\f\33\2\2\u0458\u0459\7C\2" + "\2\u0459\u047c\7f\2\2\u045a\u045b\f\32\2\2\u045b\u045c\7C\2\2\u045c\u047c" + "\7-\2\2\u045d\u045e\f\31\2\2\u045e\u045f\7C\2\2\u045f\u0461\7!\2\2\u0460" + "\u0462\5\u00c0a\2\u0461\u0460\3\2\2\2\u0461\u0462\3\2\2\2\u0462\u0463" + "\3\2\2\2\u0463\u047c\5\u00b8]\2\u0464\u0465\f\30\2\2\u0465\u0466\7C\2" + "\2\u0466\u0467\7*\2\2\u0467\u047c\5\u00c6d\2\u0468\u0469\f\27\2\2\u0469" + "\u046a\7C\2\2\u046a\u047c\5\u00be`\2\u046b\u046c\f\26\2\2\u046c\u046d" + "\7?\2\2\u046d\u046e\5\u00b0Y\2\u046e\u046f\7@\2\2\u046f\u047c\3\2\2\2" + "\u0470\u0471\f\25\2\2\u0471\u0473\7;\2\2\u0472\u0474\5\u00aaV\2\u0473" + "\u0472\3\2\2\2\u0473\u0474\3\2\2\2\u0474\u0475\3\2\2\2\u0475\u047c\7<" + "\2\2\u0476\u0477\f\22\2\2\u0477\u047c\t\16\2\2\u0478\u0479\f\13\2\2\u0479" + "\u047a\7\34\2\2\u047a\u047c\5N(\2\u047b\u0428\3\2\2\2\u047b\u042b\3\2" + "\2\2\u047b\u042e\3\2\2\2\u047b\u0439\3\2\2\2\u047b\u043c\3\2\2\2\u047b" + "\u043f\3\2\2\2\u047b\u0442\3\2\2\2\u047b\u0445\3\2\2\2\u047b\u0448\3\2" + "\2\2\u047b\u044b\3\2\2\2\u047b\u044e\3\2\2\2\u047b\u0454\3\2\2\2\u047b" + "\u0457\3\2\2\2\u047b\u045a\3\2\2\2\u047b\u045d\3\2\2\2\u047b\u0464\3\2" + "\2\2\u047b\u0468\3\2\2\2\u047b\u046b\3\2\2\2\u047b\u0470\3\2\2\2\u047b" + "\u0476\3\2\2\2\u047b\u0478\3\2\2\2\u047c\u047f\3\2\2\2\u047d\u047b\3\2" + "\2\2\u047d\u047e\3\2\2\2\u047e\u00b1\3\2\2\2\u047f\u047d\3\2\2\2\u0480" + "\u0481\7;\2\2\u0481\u0482\5\u00b0Y\2\u0482\u0483\7<\2\2\u0483\u0496\3" + "\2\2\2\u0484\u0496\7-\2\2\u0485\u0496\7*\2\2\u0486\u0496\5h\65\2\u0487" + "\u0496\7f\2\2\u0488\u0489\5N(\2\u0489\u048a\7C\2\2\u048a\u048b\7\13\2" + "\2\u048b\u0496\3\2\2\2\u048c\u048d\7\62\2\2\u048d\u048e\7C\2\2\u048e\u0496" + "\7\13\2\2\u048f\u0493\5\u00c0a\2\u0490\u0494\5\u00c8e\2\u0491\u0492\7" + "-\2\2\u0492\u0494\5\u00caf\2\u0493\u0490\3\2\2\2\u0493\u0491\3\2\2\2\u0494" + "\u0496\3\2\2\2\u0495\u0480\3\2\2\2\u0495\u0484\3\2\2\2\u0495\u0485\3\2" + "\2\2\u0495\u0486\3\2\2\2\u0495\u0487\3\2\2\2\u0495\u0488\3\2\2\2\u0495" + "\u048c\3\2\2\2\u0495\u048f\3\2\2\2\u0496\u00b3\3\2\2\2\u0497\u0498\5\u00c0" + "a\2\u0498\u0499\5\u00b6\\\2\u0499\u049a\5\u00bc_\2\u049a\u04a1\3\2\2\2" + "\u049b\u049e\5\u00b6\\\2\u049c\u049f\5\u00ba^\2\u049d\u049f\5\u00bc_\2" + "\u049e\u049c\3\2\2\2\u049e\u049d\3\2\2\2\u049f\u04a1\3\2\2\2\u04a0\u0497" + "\3\2\2\2\u04a0\u049b\3\2\2\2\u04a1\u00b5\3\2\2\2\u04a2\u04a4\7f\2\2\u04a3" + "\u04a5\5\u00c2b\2\u04a4\u04a3\3\2\2\2\u04a4\u04a5\3\2\2\2\u04a5\u04ad" + "\3\2\2\2\u04a6\u04a7\7C\2\2\u04a7\u04a9\7f\2\2\u04a8\u04aa\5\u00c2b\2" + "\u04a9\u04a8\3\2\2\2\u04a9\u04aa\3\2\2\2\u04aa\u04ac\3\2\2\2\u04ab\u04a6" + "\3\2\2\2\u04ac\u04af\3\2\2\2\u04ad\u04ab\3\2\2\2\u04ad\u04ae\3\2\2\2\u04ae" + "\u04b2\3\2\2\2\u04af\u04ad\3\2\2\2\u04b0\u04b2\5R*\2\u04b1\u04a2\3\2\2" + "\2\u04b1\u04b0\3\2\2\2\u04b2\u00b7\3\2\2\2\u04b3\u04b5\7f\2\2\u04b4\u04b6" + "\5\u00c4c\2\u04b5\u04b4\3\2\2\2\u04b5\u04b6\3\2\2\2\u04b6\u04b7\3\2\2" + "\2\u04b7\u04b8\5\u00bc_\2\u04b8\u00b9\3\2\2\2\u04b9\u04d5\7?\2\2\u04ba" + "\u04bf\7@\2\2\u04bb\u04bc\7?\2\2\u04bc\u04be\7@\2\2\u04bd\u04bb\3\2\2" + "\2\u04be\u04c1\3\2\2\2\u04bf\u04bd\3\2\2\2\u04bf\u04c0\3\2\2\2\u04c0\u04c2" + "\3\2\2\2\u04c1\u04bf\3\2\2\2\u04c2\u04d6\5J&\2\u04c3\u04c4\5\u00b0Y\2" + "\u04c4\u04cb\7@\2\2\u04c5\u04c6\7?\2\2\u04c6\u04c7\5\u00b0Y\2\u04c7\u04c8" + "\7@\2\2\u04c8\u04ca\3\2\2\2\u04c9\u04c5\3\2\2\2\u04ca\u04cd\3\2\2\2\u04cb" + "\u04c9\3\2\2\2\u04cb\u04cc\3\2\2\2\u04cc\u04d2\3\2\2\2\u04cd\u04cb\3\2" + "\2\2\u04ce\u04cf\7?\2\2\u04cf\u04d1\7@\2\2\u04d0\u04ce\3\2\2\2\u04d1\u04d4" + "\3\2\2\2\u04d2\u04d0\3\2\2\2\u04d2\u04d3\3\2\2\2\u04d3\u04d6\3\2\2\2\u04d4" + "\u04d2\3\2\2\2\u04d5\u04ba\3\2\2\2\u04d5\u04c3\3\2\2\2\u04d6\u00bb\3\2" + "\2\2\u04d7\u04d9\5\u00caf\2\u04d8\u04da\5$\23\2\u04d9\u04d8\3\2\2\2\u04d9" + "\u04da\3\2\2\2\u04da\u00bd\3\2\2\2\u04db\u04dc\5\u00c0a\2\u04dc\u04dd" + "\5\u00c8e\2\u04dd\u00bf\3\2\2\2\u04de\u04df\7F\2\2\u04df\u04e0\5\"\22" + "\2\u04e0\u04e1\7E\2\2\u04e1\u00c1\3\2\2\2\u04e2\u04e3\7F\2\2\u04e3\u04e6" + "\7E\2\2\u04e4\u04e6\5T+\2\u04e5\u04e2\3\2\2\2\u04e5\u04e4\3\2\2\2\u04e6" + "\u00c3\3\2\2\2\u04e7\u04e8\7F\2\2\u04e8\u04eb\7E\2\2\u04e9\u04eb\5\u00c0" + "a\2\u04ea\u04e7\3\2\2\2\u04ea\u04e9\3\2\2\2\u04eb\u00c5\3\2\2\2\u04ec" + "\u04f3\5\u00caf\2\u04ed\u04ee\7C\2\2\u04ee\u04f0\7f\2\2\u04ef\u04f1\5" + "\u00caf\2\u04f0\u04ef\3\2\2\2\u04f0\u04f1\3\2\2\2\u04f1\u04f3\3\2\2\2" + "\u04f2\u04ec\3\2\2\2\u04f2\u04ed\3\2\2\2\u04f3\u00c7\3\2\2\2\u04f4\u04f5" + "\7*\2\2\u04f5\u04f9\5\u00c6d\2\u04f6\u04f7\7f\2\2\u04f7\u04f9\5\u00ca" + "f\2\u04f8\u04f4\3\2\2\2\u04f8\u04f6\3\2\2\2\u04f9\u00c9\3\2\2\2\u04fa" + "\u04fc\7;\2\2\u04fb\u04fd\5\u00aaV\2\u04fc\u04fb\3\2\2\2\u04fc\u04fd\3" + "\2\2\2\u04fd\u04fe\3\2\2\2\u04fe\u04ff\7<\2\2\u04ff\u00cb\3\2\2\2\u0097" + "\u00cd\u00d2\u00d8\u00e0\u00e9\u00ee\u00f5\u00fc\u0103\u010a\u010f\u0113" + "\u0117\u011b\u0120\u0124\u0128\u0132\u013a\u0141\u0148\u014c\u014f\u0152" + "\u015b\u0161\u0166\u0169\u016f\u0175\u0179\u0182\u0189\u0192\u0199\u019f" + "\u01a3\u01ae\u01b2\u01ba\u01bf\u01c3\u01cc\u01da\u01df\u01e8\u01f0\u01fa" + "\u0202\u020a\u020f\u021b\u0221\u0228\u022d\u0235\u0239\u023b\u0246\u024e" + "\u0251\u0255\u025a\u025e\u0269\u0272\u0274\u027b\u0280\u0289\u028e\u0291" + "\u0296\u029f\u02af\u02b9\u02bc\u02c5\u02cf\u02d7\u02da\u02dd\u02ea\u02f2" + "\u02f7\u02ff\u0303\u0307\u030b\u030d\u0311\u0317\u0322\u032a\u0332\u033d" + "\u0346\u035d\u0360\u0363\u036b\u036f\u0377\u037d\u0388\u0391\u0396\u03a0" + "\u03a7\u03b4\u03bd\u03c6\u03cc\u03d7\u03dc\u03e8\u03ec\u03f0\u03f4\u03f6" + "\u03fa\u03ff\u0412\u0426\u0436\u0461\u0473\u047b\u047d\u0493\u0495\u049e" + "\u04a0\u04a4\u04a9\u04ad\u04b1\u04b5\u04bf\u04cb\u04d2\u04d5\u04d9\u04e5" + "\u04ea\u04f0\u04f2\u04f8\u04fc";
    publicstatic
    {
        FINAL | final
    }

    ATN _ATN = new ATNDeserializer().deserialize(_serializedATN.toCharArray());
    static
    {
        _decisionToDFA = new DFA[_ATN.getNumberOfDecisions()];
        {
            FOR | for
        }

        (int i = 0;
        i < _ATN.getNumberOfDecisions();
        i++ )
        {
            _decisionToDFA[i] = new DFA(_ATN.getDecisionState(i), i);
        }
    }
} }
