namespace Prism.CodeAnalysis.Syntax
{
    public abstract class ExpressionSyntax : SyntaxNode
    {
        private protected ExpressionSyntax(SyntaxTree syntaxTree)
            : base(syntaxTree)
        {
        }
    }
}