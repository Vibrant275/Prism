namespace Prism.CodeAnalysis;

public sealed class Evaluator
{
    private readonly ExpressionSyntax _root;

    public Evaluator(ExpressionSyntax root)
    {
        this._root = root;
    }

    public int Evaluate()
    {
        return EvaluateExpression(_root);
    }

    private int EvaluateExpression(ExpressionSyntax node)
    {
        if (node is LiteralExpressionSyntax n)
            return (int)n.NumberToken.Value;

        if (node is BinaryExpressionSyntax b)
        {
            var left = EvaluateExpression(b.Left);
            var right = EvaluateExpression(b.Right);

            if (b.OperatorToken.Kind == SyntaxKind.PlusToken)
                return left + right;
            else if (b.OperatorToken.Kind == SyntaxKind.MinusToken)
                return left - right;
            else if (b.OperatorToken.Kind == SyntaxKind.AsteriskToken)
                return left * right;
            else if (b.OperatorToken.Kind == SyntaxKind.SlashToken)
                return left / right;
            else
                throw new Exception($"Unexpected Binary operator {b.OperatorToken.Kind}");
        }

        if (node is ParenthesizedExpressionSyntax p)
            return EvaluateExpression(p.Expression);

        throw new Exception($"Unexpected node {node.Kind}");
    }
}