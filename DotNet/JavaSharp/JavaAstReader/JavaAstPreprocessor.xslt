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
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
  <xsl:output method="xml" indent="yes"/>

  <xsl:template match="@* | node()">
    <xsl:copy>
      <xsl:apply-templates select="@* | node()"/>
    </xsl:copy>
  </xsl:template>

  <xsl:template match="LineComment|Comment">
    <xsl:value-of select="text()"/>
  </xsl:template>

  <xsl:template match="ImportDeclaration">
    <Using>
      <xsl:apply-templates select="./QualifiedName" />
    </Using>
  </xsl:template>

  <xsl:template match="PackageDeclaration">
    <Namespace>
    <xsl:comment>pkg must be turned into name space</xsl:comment>
    <xsl:apply-templates/>
    </Namespace>
  </xsl:template>

  <xsl:template match="Symbol">
    <xsl:text>{</xsl:text>
    <xsl:value-of select="@type"/>
    <xsl:text>|</xsl:text>
    <xsl:value-of select="text()"/>
    <xsl:text>}</xsl:text>
  </xsl:template>

  <xsl:template match="Symbol[@type='DOT']|Symbol[@type='SEMI']|Symbol[@type='RPAREN']|Symbol[@type='LPAREN']|Symbol[@type='RBRACE']|Symbol[@type='LBRACE']|Symbol[@type='COMMA']|Symbol[@type='ASSIGN']|Symbol[@type='Identifier']">
    <xsl:value-of select="text()"/>
  </xsl:template>

</xsl:stylesheet>
