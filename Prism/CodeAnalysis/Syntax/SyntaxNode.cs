using System.Collections.Generic;

namespace Prism.CodeAnalysis.Syntax
{
    public abstract class SyntaxNode
    {
        public abstract SyntaxKind Kind { get; }

        public abstract IEnumerable<SyntaxNode> GetChildren();
    }
}