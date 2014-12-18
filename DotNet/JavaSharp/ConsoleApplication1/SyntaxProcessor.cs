using System;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

namespace JavaSharp
{
    internal class SyntaxProcessor : ITreeTransformer
    {
        public SyntaxNode Transform(SyntaxNode originalNode)
        {
            return originalNode.NormalizeWhitespace("    ");
        }
    }
}