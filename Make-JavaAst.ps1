Function Make-JavaAst([String]$JavaSourceFile, [String]$TargetXmlFile){
    java -classpath "D:\workspace\JavaSharp\JavaSharp\target\JavaSharp-0.1.jar;D:\workspace\JavaSharp\lib\antlr-4.3-complete.jar" javasharp.Tool $JavaSourceFile $TargetXmlFile
}

Function Translate-ToCSharp($JavaAstFile, $CsharpFile) {
    .\DotNet\JavaSharp\ConsoleApplication1\bin\Debug\ConsoleApplication1.exe $JavaAstFile $CsharpFile
}

$foo = ls D:\workspace\JavaSharp\JavaSharp\src\main\java\javasharp\*.java

foreach($j in $foo){
    $javaFile = $j.FullName
    $xmlFile = ".\asts\$($j.Name).xml"
    $csFile = ".\asts\$($j.Name).cs"
    Make-JavaAst $javaFile $xmlFile
    Translate-ToCSharp $xmlFile $csFile
}