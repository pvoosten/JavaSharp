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

# An simple example of how to use JavaSharp

# Import the framework

. $PSScriptRoot\JavaSharp.ps1

# Add knowledge to the equation: load the processors

# Processors can divide the compilation process into different consecutive passes,
# or they can define states that are enabled in defined parts of the AST that is being processed

# The intent of JavaSharp is that to improve (or at least change :-) the output,
# you should tinker with the processors and not with the framework.

. $PSScriptRoot\Processors.ps1

# Boil everything together into a well mixed soup

function Build-CSharpStructure([xml]$javaXml) {
    $cs = @()
    # first pass: strip the unnecessary bloat from the Java AST
    $cs | Process-AstNode $firstPassProcessors $javaXml.CompilationUnit | Transform-ArrayToTree 1
}


# To debug a single java source file translation
# If you downloaded the whole source code, there are Java source files in the script root.
$javaXml = Parse-JavaSource $(Find-JavaFiles $PSScriptRoot)[-2].FullName
$tree = Build-CSharpStructure $javaXml
$tree

# That's it!

