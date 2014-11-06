/*
JavaSharp, a free Java to C# translator based on ANTLRv4
Copyright (C) 2014  Philip van Oosten

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU Affero General Public License as
published by the Free Software Foundation, either version 3 of the
License, or (at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU Affero General Public License for more details.

You should have received a copy of the GNU Affero General Public License
along with this program.  If not, see <http://www.gnu.org/licenses/>.

https://github.com/pvoosten
*/

package javasharp;

import org.antlr.v4.runtime.tree.ErrorNode;
import org.antlr.v4.runtime.tree.ParseTree;
import org.antlr.v4.runtime.tree.RuleNode;
import org.antlr.v4.runtime.tree.TerminalNode;


public class CSharpCreationVisitor extends JavaBaseVisitor {

    @Override
    public Object visitAnnotation(JavaParser.AnnotationContext ctx) {
        System.out.println(ctx.getText());
        return super.visitAnnotation(ctx);
    }

    @Override
    public Object visitInterfaceMemberDeclaration(JavaParser.InterfaceMemberDeclarationContext ctx) {
        System.out.println(ctx.getText());
        return super.visitInterfaceMemberDeclaration(ctx); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public Object visitInterfaceMethodDeclaration(JavaParser.InterfaceMethodDeclarationContext ctx) {
        System.out.println(ctx.getText());
        return super.visitInterfaceMethodDeclaration(ctx);
    }    
}
