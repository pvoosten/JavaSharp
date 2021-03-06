# JavaSharp, a free Java to C# translator based on ANTLRv4
# Copyright (C) 2014-2015  Philip van Oosten
# 
# This program is free software: you can redistribute it and/or modify
# it under the terms of the GNU Affero General Public License as
# published by the Free Software Foundation, either version 3 of the
# License, or (at your option) any later version.
# 
# This program is distributed in the hope that it will be useful,
# but WITHOUT ANY WARRANTY; without even the implied warranty of
# MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
# GNU Affero General Public License for more details.
# 
# You should have received a copy of the GNU Affero General Public License
# along with this program.  If not, see <http://www.gnu.org/licenses/>.
# 
# https://github.com/pvoosten

# This is the framework

function Find-JavaFiles{
    param([string]$Path)
    Get-ChildItem -Path $Path -Recurse | where {$_.Name.EndsWith('.java')} | select FullName
}

function Parse-JavaSource{
    param([string]$InputObject)
    $JavaFile = $InputObject
    $tempFile = [System.IO.Path]::GetTempFileName()
    java -classpath "$PSScriptRoot\JavaSharp\target\JavaSharp-0.1.jar;$PSScriptRoot\lib\antlr-4.3-complete.jar" javasharp.Tool $JavaFile $tempFile
    [xml]$content = Get-Content -Raw $tempFile
    Remove-Item $tempFile -ErrorAction SilentlyContinue
    $content
}

function Text{
    param($txt)
    $input + """$txt"
}

function Escape-Xml{
    param([string]$text)
    $text.Replace('&', '&amp;').Replace('"', '&quot;').Replace('<', '&lt;').Replace('>','&gt;')
}

function Element{
    param(
    [string]
    $name,
    [hashtable]
    $attributes=$null)
    $attlist = if($attributes){[string]::Join("", ($attributes.GetEnumerator() | foreach{" $($_.Name)=""$(Escape-Xml $_.Value)"""}))}
    $input + "<$name$attlist"
}

function Indent{
    $input + $true
}

function Dedent{
    $input + $false
}

function Process-ChildNodes($processors, $astNode){
    for($i=0; $i -lt $astNode.ChildNodes.Count; $i++){
        $childNode = $astNode.ChildNodes[$i]
        if($childNode.NodeType -eq 'Element'){
            $input = $input | Process-AstNode $processors $childNode
        }
    }
    $input
}

function Process-AstNode($processors, $astNode) {
    if($astNode -is [array]){
        foreach($item in $astNode){
            $input = $input | Process-AstNode $processors $item
        }
        $input
    }elseif($astNode.NodeType -eq 'Document'){
        Process-AstNode $processors $astNode.DocumentElement
    }elseif($astNode.NodeType -ne 'Element'){
        "No element: $($astNode.NodeType)"
    }elseif($processors.ContainsKey($astNode.Name)){
        $input | &$processors[$astNode.Name] $astNode
    }else{
        $atts = $null
        if($astNode.HasAttributes){
            $atts = @{}
            $astNode.Attributes.GetEnumerator() | foreach {$atts[$_.Name]= $_.Value}
        }
        if($astNode.ChildNodes -ne $null){
            $input | Element $astNode.Name $atts | Indent | Process-ChildNodes $processors $astNode | Dedent
        }else{
            $input | Element $astNode.Name $atts
        }
    }
}

function Transform-ArrayToTree{
    $i=0
    trap{"index $i"}
    if($input.MoveNext()){
        $i++
        $root = $input.Current.Clone()
        if($root[0] -ne '<'){return "Root node is not an element"}
    }
    if($input.MoveNext()){
        $i++
        $rootIndent = $input.Current
        if(!$rootIndent){return "No indent after root element"}
    }

    if($i -ne 2){return}

    [xml]$tree = "$root />"
    $cursor = $tree.DocumentElement
    $indent = 1
    Write-Host -BackgroundColor Green $tree

    while($input.MoveNext()){
        $i++
        $item = $input.Current
        if($item -is [bool]){
            $indent += if($item){1}else{-1}
        }else{
            if($item.StartsWith('"')){
                $cursor.InnerText += $item.Substring(1)
            }elseif($item.StartsWith('<')){
                $parent = $null
                if($indent -eq 0){
                    $parent = $cursor.ParentNode
                }elseif($indent -eq 1){
                    $parent = $cursor
                    $indent = 0 # indent only one step, not in a loop
                }elseif($indent -le -1){
                    $parent = $cursor.ParentNode.ParentNode
                    $indent++ # One dedent ongoing, multiple consecutive dedents are possible
                }
                if($parent -eq $null){
                    Write-Host -BackgroundColor Red "index $i; item $item; cursor $cursor; parent null"
                    break
                }
                $parent.InnerXml += "<$($item.Substring(1)) />"
                $cursor = $parent.LastChild
            }
        }
    }
    $tree
}

function Flatten-ArrayKeys{
    $flattened = @{}
    foreach($kv in $input.GetEnumerator()){
        if($kv.Key -is [string]){
            $flattened[$kv.Key] = $kv.Value
        }else{
            $kv.Key | foreach {
                $flattened[$_] = $kv.Value
            }
        }
    }
    $flattened
}

