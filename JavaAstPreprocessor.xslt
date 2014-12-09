<?xml version="1.0" encoding="utf-8"?>
<!--
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
-->
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:output method="text" indent="yes"/>

    <xsl:template match="CompilationUnit">
      <xsl:apply-templates select="./TypeDeclaration/preceding-sibling::*" />
      <xsl:text>

namespace </xsl:text>
      <xsl:choose>
        <xsl:when test="./PackageDeclaration">
          <xsl:apply-templates select="PackageDeclaration/QualifiedName/*" />
        </xsl:when>
        <xsl:otherwise>
          <xsl:text>Default</xsl:text>
        </xsl:otherwise>
      </xsl:choose>
      <xsl:text>
{
</xsl:text>
      <xsl:apply-templates select="./TypeDeclaration" />
      <xsl:text>
}
</xsl:text>
      <xsl:apply-templates select="./TypeDeclaration[last()]/following-sibling::*" />
  </xsl:template>

  <!-- toss package declaration -->
  <xsl:template match="PackageDeclaration">
    <xsl:text>
</xsl:text>
  </xsl:template>

  <!-- translate import statements to using statements -->
  <xsl:template match="ImportDeclaration">
    <xsl:text>
using</xsl:text>
    <xsl:apply-templates select="text()|./QualifiedName/*" />
    <xsl:text>;</xsl:text>
  </xsl:template>

  <!-- fix extension and implementation -->
  <xsl:template match="Symbol[@type='EXTENDS']|Symbol[@type='IMPLEMENTS']">
    <xsl:text>:</xsl:text>
  </xsl:template>
  
  <!-- toss EOF marker -->
  <xsl:template match="Symbol[@type='HIDDEN']" />
  
  <!-- Convert the Java final modifier to a [JavaFinal] attribute;
  postpone further replacement to semantic analysis -->
  <xsl:template match="Symbol[@type='FINAL']" />
  <xsl:template match="ClassBodyDeclaration[./Modifier/ClassOrInterfaceModifier/Symbol/@type='FINAL']">
    [JavaSharp.Syntax.JavaFinalModifier]
	<xsl:apply-templates />
  </xsl:template>
  
  <!-- Convert the Java override annotation to an override hint -->
  <xsl:template match="ClassBodyDeclaration[./Modifier/ClassOrInterfaceModifier/Annotation/AnnotationName/QualifiedName/Symbol[@type='Identifier'][text()='Override']]">
    [JavaSharp.Syntax.JavaOverrideAnnotation]
	<xsl:apply-templates />
  </xsl:template>
  <xsl:template match="Annotation[./AnnotationName/QualifiedName/Symbol[@type='Identifier'][text()='Override']]">
  </xsl:template>
  
  <!-- copy line comments, including newline -->
  <xsl:template match="LineComment">
	<xsl:apply-templates select="text()" />
	<xsl:text>
</xsl:text>
  </xsl:template>

  <!-- copy comments -->
  <xsl:template match="Comment">
    <xsl:apply-templates select="text()" />
  </xsl:template>
  
   <!-- toss the throws clause from method declarations -->
  <xsl:template match="MethodDeclaration">
    <xsl:apply-templates select="text()|./*[not(self::Symbol[@type='THROWS'])][not(self::QualifiedNameList)]" />
  </xsl:template>
 
  
  <xsl:template match="text() | @* | node()">
    <xsl:copy>
      <xsl:apply-templates select="@* | node() | text()"/>
    </xsl:copy>
  </xsl:template>

</xsl:stylesheet>
