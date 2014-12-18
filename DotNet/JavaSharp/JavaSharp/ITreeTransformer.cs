using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaSharp
{
    interface ITreeTransformer
    {
        /// <summary>
        /// Transforms the syntax tree to an other syntax tree.
        /// </summary>
        /// <param name="originalNode">The original root node of the syntax tree</param>
        /// <returns>The root node of a transformed tree</returns>
        SyntaxNode Transform(SyntaxNode originalNode);
    }
}
