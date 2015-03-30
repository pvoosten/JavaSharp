# Production version

# Import the framework
cd $PSScriptRoot
. $PSScriptRoot\JavaSharp.ps1


Write-Host -ForegroundColor Green '#################################################################### '
Write-Host -ForegroundColor Green '#                                                                  # '
Write-Host -ForegroundColor Green '#   FFFFFF                           PPPPP                         # '
Write-Host -ForegroundColor Green '#   F                       t        P    P                        # '
Write-Host -ForegroundColor Green '#   F      ii rrrr   ssss   t        P    P  aaaa   sssss  sssss   # '
Write-Host -ForegroundColor Green '#   F         r   r s      tttt      PPPPP       a s      s        # '
Write-Host -ForegroundColor Green '#   FFFFF  ii r      ssss   t        P       aaaaa  ssss   ssss    # '
Write-Host -ForegroundColor Green '#   F      ii r          s  t        P      a    a      s      s   # '
Write-Host -ForegroundColor Green '#   F      ii r          s  t        P      a    a      s      s   # '
Write-Host -ForegroundColor Green '#   F      ii r     sssss    tt      P       aaaaa sssss  sssss    ##'
Write-Host -ForegroundColor Green '#                                                                   #'
Write-Host -ForegroundColor Green '#####################################################################'


# Add knowledge to the equation: load the processors

# Processors can divide the compilation process into different consecutive passes,
# or they can define states that are enabled in defined parts of the AST that is being processed

# The intent of JavaSharp is that to improve (or at least change :-) the output,
# you should tinker with the processors and not with the framework.

function Process-QualifiedName($qname, $elementName){
    $v = $input | Element $elementName @{qname=([string]::Join('.', ($qname.Symbol | where type -eq 'Identifier' | foreach '#text')));}
    if($qname.Comment){
        $v = $v | Indent
        $qname.Comment | foreach{
            $v = $v | Process-AstNode $firstPassProcessors $_
        }
        $v = $v | Dedent
    }
    $v 
}

$firstPassProcessors = @{
    'CompilationUnit'={
        $commentsBeforeUsings = @()
        $usings = @()
        $namespaceDeclaration = $null # there can be only one per file, a convenient Java restriction
        $typeDeclarations = @()
        $commentsAfterNamespaceDeclaration = @()
    
        $astNode.ChildNodes | foreach{
            if($_.Name -eq 'Comment' -and !$usings -and !$namespaceDeclaration){
                $commentsBeforeUsings += $_
            }elseif($_.Name -eq 'Comment'){
                $commentsAfterNamespaceDeclaration += $_
            }elseif($_.Name -eq 'ImportDeclaration'){
                $usings += $_
            }elseif($_.Name -eq 'TypeDeclaration'){
                $typeDeclarations += $_
            }elseif($_.Name -eq 'PackageDeclaration'){
                $namespaceDeclaration = $_
            }else{
                $input = $input | Element 'SHIT' | Indent | Process-AstNode $firstPassProcessors $_ | Dedent
            }
        }
        $input | Element 'CompilationUnit' @{pass=1} | Indent `
                | Element 'CommentsBeforeUsings' | Indent | Process-AstNode $firstPassProcessors $commentsBeforeUsings | Dedent `
                | Element 'Usings' | Indent | Process-AstNode $firstPassProcessors $usings | Dedent `
                | Process-QualifiedName $namespaceDeclaration.QualifiedName 'Namespace' | Indent `
                    | Process-AstNode $firstPassProcessors $typeDeclarations `
                | Dedent `
                | Element 'CommentsAfterNamespaceDeclaration' | Indent | Process-AstNode $firstPassProcessors $commentsAfterNamespaceDeclaration | Dedent `
            | Dedent
    };
    'Symbol'={
        if($astNode.type -in @('HIDDEN','SEMI','LPAREN','RPAREN','LBRACE','RBRACE')){
            $input
        } else {
            $input | Element 'Symbol' @{type=$astNode.type; text=$astNode.innerText}
        }
    };
    @('Comment','LineComment')={
        if([regex]::IsMatch($astNode.innerText, '^/\*\*+')){
            $match = [regex]::Match($astNode.innerText, "(?<commentStart>/\*\*+)((?<lineStart> *\* *)?(?<line>.*)`r?`n)*(?<line>.*)(?<commentEnd>\*/)", 'Multiline')
            $doctext=@("/// <summary>")
            $doctext += $match.Groups['line'].Captures.Value | foreach{"/// $_"}
            $doctext += "/// </summary>"
            $input | Element 'Comment' @{type='documentation'} | Text ([string]::Join("`r`n", $doctext))
        } elseif([regex]::IsMatch($astNode.innerText, '^/\*')){
            $match = [regex]::Match($astNode.innerText, "(?<commentStart>/\*)((?<lineStart> *\* *)?(?<line>.*)`r?`n)*(?<line>.*)(?<commentEnd>\*/)", 'Multiline')
            $input | Element 'Comment' @{type='multiline'} | Text ([string]::Join("`r`n", ($match.Groups['line'].Captures.Value | foreach {"// $_"})))
        } else {
            $input | Element 'Comment' @{type='line'} | Text $astNode.innerText
        }
    };
    'Type'={
        $input | Process-ChildNodes $firstPassProcessors $astNode
    };
    'Annotation'={
        $input | Text "[$($astNode.AnnotationName.innerText)]"
    };
    'ImportDeclaration'={
        $input | Process-QualifiedName $astNode.QualifiedName 'Using'
    };
    'ClassOrInterfaceType'={
        $input | Process-QualifiedName $astNode 'Type'
    };
} | Flatten-ArrayKeys


# To debug a single java source file translation
# If you downloaded the whole source code, there are Java source files in the script root.
$javaFile = $(Find-JavaFiles $PSScriptRoot)[6].FullName
Write-Host $javaFile -ForegroundColor Yellow
$javaSource = Get-Content -Raw $javaFile
Write-Host "Parsing java source file into an AST..." -ForegroundColor Yellow
$javaXml = Parse-JavaSource $javaFile
Write-Host "Done." -ForegroundColor Green
Write-Host "Processing AST..." -ForegroundColor Yellow
$cs = @() | Process-AstNode $firstPassProcessors $javaXml
Write-Host "Done." -ForegroundColor Green
Write-Host "Transforming array to tree..." -ForegroundColor Yellow
$tree = $cs | Transform-ArrayToTree
Write-Host "First pass done." -BackgroundColor Green

# $tree.CompilationUnit

Write-Host -ForegroundColor Green '########################################################################## '
Write-Host -ForegroundColor Green '#                                                                        # '
Write-Host -ForegroundColor Green '#                                    d     PPPPP                         # '
Write-Host -ForegroundColor Green '#    sss                             d     P    P                        # '
Write-Host -ForegroundColor Green '#   s      eee   ccc  ooo  nnnn   dddd     P    P  aaaa   sssss  sssss   # '
Write-Host -ForegroundColor Green '#   s     e   e c    o   o n   n d   d     PPPPP       a s      s        # '
Write-Host -ForegroundColor Green '#    sss  eeee  c    o   o n   n d   d     P       aaaaa  ssss   ssss    # '
Write-Host -ForegroundColor Green '#       s e     c    o   o n   n d   d     P      a    a      s      s   # '
Write-Host -ForegroundColor Green '#       s e     c    o   o n   n d   d     P      a    a      s      s   # '
Write-Host -ForegroundColor Green '#   ssss   eee   ccc  ooo  n   n  dddd     P       aaaaa sssss  sssss    ##'
Write-Host -ForegroundColor Green '#                                                                         #'
Write-Host -ForegroundColor Green '###########################################################################'

$secondPassProcessors = @{
    'TypeDeclaration'={
        $atts = @{}
        # visibility
        $atts.visibility = 'internal'
        'public','private','protected' | foreach{
            if($_ -in $astNode.ClassOrInterfaceModifier.Symbol.text){
                $atts.visibility = $_
            }
        }
        if($astNode.InterfaceDeclaration){
            $input | Element 'Interface' $atts | Indent | Process-ChildNodes $secondPassProcessors $astNode | Dedent
        }elseif($astNode.ClassDeclaration){
            $atts.name = $astNode.ClassDeclaration.Symbol | where type -eq 'Identifier' | foreach text
            $input | Element 'Class' $atts | Indent | Process-ChildNodes $secondPassProcessors $astNode.ClassDeclaration.ClassBody.ClassBodyDeclaration | Dedent
        }else{
            $input | Element 'FUCKYOU'
        }
    };
    @('TypeParameters','InterfaceBodyDeclaration','Usings')={
        $input | Process-ChildNodes $secondPassProcessors $astNode
    };
    'TypeParameter' = {
        $input | Element 'GenericTypeParameter' @{name=$astNode.Symbol.text}
    };
    'ClassOrInterfaceModifier'={
        $input
    };
    'CompilationUnit'={
        $input | Element 'CompilationUnit' @{pass=2} | Indent | Process-ChildNodes $secondPassProcessors $astNode | Dedent
    };
    'Comment'={
        $input | Element 'Comment' @{type=$astNode.type} | Text $astNode.InnerText
    };
    # experimenteel
    @('Expression','StatementExpression','MethodBody','BlockStatement','Modifier')={
        $input | Process-ChildNodes $secondPassProcessors $astNode
    };
    'Symbol'={
        $input | Text ' ' + $astNode.text + ' '
    };
} | Flatten-ArrayKeys


$cs2 = @() | Process-AstNode $secondPassProcessors $tree
$tree2 = $cs2 | Transform-ArrayToTree
$typeDeclaration = $tree2.CompilationUnit.Namespace.TypeDeclaration



function CSharpSource{
    param($tree)

    $cu = $tree.CompilationUnit
    if($cu.CommentsBeforeUsings){
        $cu.CommentsBeforeUsings.Comment.'#text'
        $comments
        ""
    }
    if($cu.Usings){
        $cu.Usings.Using | foreach { "using $($_.qname); $($_.Comment.'#text')" }
        ""
    }

    "namespace $($cu.Namespace.qname)"
    "{"
    $indent = 1

    $typeDecls = $cu.Namespace.TypeDeclaration
    foreach($typeDecl in $typeDecls){
    ""
        $typeDecl.Comment.'#text'
        $classDecl = $typeDecl.ClassDeclaration
        $classDecl.Field
        
    }



    "}"
    $cu.CommentsAfterNamespaceDeclaration.Comment.'#text'
}
