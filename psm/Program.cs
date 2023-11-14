using System;

namespace psm
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("> ");
                var line = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(line))
                    return;

                Console.WriteLine(line == "1 + 2 * 3" ? "7" : "InVaidExpression");
            }
        }
    }

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
        WhitespaceToken
    }
    

    class SyntaxToken
    {
        public SyntaxToken(SyntaxKind kind, int position, string text, object value)
        {
            Kind = kind;
            Position = position;
            Text = text;
        }

        public SyntaxKind Kind { get; }
        public int Position { get; }
        public string Text { get; }
    }

    class Lexer
    {
        private readonly string _text;
        private int _position;

        public Lexer(string text)
        {
            _text = text;
        }

        private Char Current
        {
            get
            {
                if (_position >= _text.Length)
                {
                    return '\0';
                }

                return _text[_position];
            }
        }

        private void Next()
        {
            _position++;
        }

        public SyntaxToken NewToken()
        {
            if (char.IsDigit(Current))
            {
                var start = _position;

                while (char.IsDigit(Current))
                    Next();

                var length = _position - start;
                var text = _text.Substring(start, length);
                int.TryParse(text, out var value);
                return new SyntaxToken(SyntaxKind.NumberToken, start, text, value);
            }

            if (char.IsWhiteSpace(Current))
            {
                var start = _position;

                while (char.IsDigit(Current))
                    Next();

                var length = _position - start;
                var text = _text.Substring(start, length);
                int.TryParse(text, out var value);
                return new SyntaxToken(SyntaxKind.WhitespaceToken, start, text, value);
            }

            if (Current == '+')
                return new SyntaxToken(SyntaxKind.PlusToken, _position++, "+", null);
            else  if (Current == '-')
                return new SyntaxToken(SyntaxKind.MinusToken, _position++, "-", null);
            else  if (Current == '*')
                return new SyntaxToken(SyntaxKind.AsteriskToken, _position++, "*", null);
            else  if (Current == '/')
                return new SyntaxToken(SyntaxKind.SlashToken, _position++, "/", null);
            else  if (Current == '(')
                return new SyntaxToken(SyntaxKind.OpenParenthesisToken, _position++, "(", null);
            else  if (Current == ')')
                return new SyntaxToken(SyntaxKind.CloseParenthesisToken, _position++, ")", null);
        
        }
    }
}

