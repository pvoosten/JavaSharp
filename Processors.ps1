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

# This is the knowledge.
# Elaboration on the knowledge is ongoing research.

$firstPassProcessors = @{
    'Symbol'={
        $input | Element $astNode.type | Text $(if($astNode.type -in 'SEMI','LBRACE','RBRACE'){"$($astNode.innerText)`r`n" }else{ $astNode.innerText })
    };
    @('Comment','LineComment')={
        $input | Text $astNode.innerText
    };
    'Annotation'={
        $input | Text "[$($astNode.AnnotationName.innerText)]"
    };
    @('FormalParameters','FormalParameterList',
        'ClassOrInterfaceModifier', 'Modifier',
        'MethodBody', 'Block', 'MemberDeclaration','MethodDeclaration',
        'Expression', 'Literal','VariableDeclarator',
        'Primary')={
        $input | Process-ChildNodes $firstPassProcessors $astNode
    };
}
$firstPassProcessors = Flatten-ArrayKeys $firstPassProcessors
