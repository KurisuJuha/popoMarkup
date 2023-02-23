namespace JuhaKurisu.PopoTools.Markup
{
    public abstract class Style
    {
        public readonly static BoldStyle bold = new BoldStyle();
        public readonly static ItalicStyle italic = new ItalicStyle();

        public MarkupString this[string t]
        {
            get => new MarkupString().AddText(t, this);
        }

        public virtual string ToString(string text)
            => text;

        public static BoldStyle Bold()
            => bold;

        public static ItalicStyle Italic()
            => italic;


        public static MarkupString operator +(Style style, string text)
            => new MarkupString().AddText(text, style);

    }
}