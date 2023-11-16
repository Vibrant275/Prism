namespace Prism.CodeAnalysis.Syntax;

public enum SyntaxKind
{
    // Numeric literals
    NumberToken,

    // Arithmetic operators
    PlusToken,
    MinusToken,
    MultiplyToken,
    DivideToken,
    AsteriskToken,
    SlashToken,

    // Parentheses
    OpenParenthesisToken,
    CloseParenthesisToken,

    // Assignment
    EqualsToken,

    // Comparison operators
    EqualsEqualsToken,
    BangEqualsToken,
    LessThanToken,
    LessThanOrEqualToken,
    GreaterThanToken,
    GreaterThanOrEqualToken,

    // Keywords
    VarKeyword,
    IfKeyword,
    ElseKeyword,
    WhileKeyword,

    // End of File
    EndOfFileToken,

    // Whitespace
    WhitespaceToken,

    // Other
    BadToken,

    // Expression
    NumberExpression,
    BinaryExpression,
    ParenthesizedExpression,

    // Trivia
    SkippedTextTrivia,
    LineBreakTrivia,
    WhitespaceTrivia,
    SingleLineCommentTrivia,
    MultiLineCommentTrivia,

    // Tokens
    StringToken,
    PlusEqualsToken,
    MinusEqualsToken,
    StarEqualsToken,
    SlashEqualsToken,
    BangToken,
    TildeToken,
    HatToken,
    HatEqualsToken,
    AmpersandToken,
    AmpersandAmpersandToken,
    AmpersandEqualsToken,
    PipeToken,
    PipeEqualsToken,
    PipePipeToken,
    LessToken,
    LessOrEqualsToken,
    GreaterToken,
    GreaterOrEqualsToken,
    OpenBraceToken,
    CloseBraceToken,
    ColonToken,
    CommaToken,
    IdentifierToken,

    // Keywords
    BreakKeyword,
    ContinueKeyword,
    FalseKeyword,
    ForKeyword,
    FunctionKeyword,
    LetKeyword,
    ReturnKeyword,
    ToKeyword,
    TrueKeyword,
    DoKeyword,

    // Nodes
    CompilationUnit,
    FunctionDeclaration,
    GlobalStatement,
    Parameter,
    TypeClause,
    ElseClause,

    // Statements
    BlockStatement,
    VariableDeclaration,
    IfStatement,
    WhileStatement,
    DoWhileStatement,
    ForStatement,
    BreakStatement,
    ContinueStatement,
    ReturnStatement,
    ExpressionStatement,

    // Expressions
    LiteralExpression,
    NameExpression,
    UnaryExpression,
   
    CompoundAssignmentExpression,

    AssignmentExpression,
    CallExpression,
}