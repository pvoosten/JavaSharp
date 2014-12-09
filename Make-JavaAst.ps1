
cd D:\workspace\JavaSharp

Function Make-JavaAst([String]$JavaSourceFile, [String]$TargetXmlFile){
    java -classpath "D:\workspace\JavaSharp\JavaSharp\target\JavaSharp-0.1.jar;D:\workspace\JavaSharp\lib\antlr-4.3-complete.jar" javasharp.Tool $JavaSourceFile $TargetXmlFile
}

Function ToCsharpSyntax($xmlFile, $javaCsFile) {
    $xslt = New-Object System.Xml.Xsl.XslCompiledTransform;
    $xslt.Load("$(pwd)\JavaAstPreprocessor.xslt");
    $xslt.Transform($xmlFile, $javaCsFile);
}

$foo = ls D:\workspace\JavaSharp\JavaSharp\src\main\java\javasharp\*.java

foreach($j in $foo){
    if(!(Test-Path -Path .\asts)){
        mkdir .\asts
    }
    $javaFile = $j.FullName
    $xmlFile = "$(pwd)\asts\$($j.Name).xml"
    $csFile = "$(pwd)\asts\$($j.Name).cs"
    echo "$javaFile ==> $csFile"
    Make-JavaAst $javaFile $xmlFile
    ToCsharpSyntax $xmlFile $csFile
}
