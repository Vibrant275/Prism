using Prism.CodeAnalysis.Binding;

internal abstract class BoundBinaryExpression : BoundExpression
{
    public BoundBinaryExpression(BoundExpression left, BoundBinaryOperatorKind operatorKind, BoundExpression right)
    {
        Left = left;
        OperatorKind = operatorKind;
        Right = right;
    }

    public BoundBinaryOperatorKind OperatorKind { get; }
    public BoundExpression Left { get; }
    public BoundExpression Right { get; }
    public override BoundNodeKind Kind => BoundNodeKind.UnaryExpression;
    public override Type Type => Left.Type;
}