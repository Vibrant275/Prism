using Prism.CodeAnalysis.Syntax;

namespace Prism.CodeAnalysis.Binding
{
    internal sealed class BoundExpressionStatement : BoundStatement
    {
        public BoundExpressionStatement(SyntaxNode syntax, BoundExpression expression)
            : base(syntax)
        {
            Expression = expression;
        }

        public override BoundNodeKind Kind => BoundNodeKind.ExpressionStatement;
        public BoundExpression Expression { get; }
    }
}
