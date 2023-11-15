namespace psm.CodeAnalysis;

enum SyntaxKind
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
    ParenthesizedExpression
}