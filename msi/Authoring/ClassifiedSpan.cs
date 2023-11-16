using Prism.CodeAnalysis.Text;

namespace Prism.CodeAnalysis.Authoring
{
    public sealed class ClassifiedSpan
    {
        public ClassifiedSpan(TextSpan span, Classification classification)
        {
            Span = span;
            Classification = classification;
        }

        public TextSpan Span { get; }
        public Classification Classification { get; }
    }
}
