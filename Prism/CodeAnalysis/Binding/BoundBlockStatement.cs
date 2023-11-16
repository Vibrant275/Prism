using System.Collections.Immutable;
using Prism.CodeAnalysis.Syntax;

namespace Prism.CodeAnalysis.Binding
{
    internal sealed class BoundBlockStatement : BoundStatement
    {
        public BoundBlockStatement(SyntaxNode syntax, ImmutableArray<BoundStatement> statements)
            : base(syntax)
        {
            Statements = statements;
        }

        public override BoundNodeKind Kind => BoundNodeKind.BlockStatement;
        public ImmutableArray<BoundStatement> Statements { get; }
    }
}
