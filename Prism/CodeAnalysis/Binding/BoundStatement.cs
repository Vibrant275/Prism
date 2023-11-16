using Prism.CodeAnalysis.Syntax;

namespace Prism.CodeAnalysis.Binding
{
    internal abstract class BoundStatement : BoundNode
    {
        protected BoundStatement(SyntaxNode syntax)
            : base(syntax)
        {
        }
    }
}
