using Prism.CodeAnalysis.Symbols;
using Prism.CodeAnalysis.Syntax;

namespace Prism.CodeAnalysis.Binding
{
    internal sealed class BoundVariableDeclaration : BoundStatement
    {
        public BoundVariableDeclaration(SyntaxNode syntax, VariableSymbol variable, BoundExpression initializer)
            : base(syntax)
        {
            Variable = variable;
            Initializer = initializer;
        }

        public override BoundNodeKind Kind => BoundNodeKind.VariableDeclaration;
        public VariableSymbol Variable { get; }
        public BoundExpression Initializer { get; }
    }
}
