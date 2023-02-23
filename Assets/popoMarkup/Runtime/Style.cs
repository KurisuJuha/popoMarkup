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

        public static ColorStyle Color(UnityEngine.Color color)
            => new ColorStyle(MarkupColor.FromUnityColor(color));

        public static ColorStyle Color(UnityEngine.Color32 color)
            => new ColorStyle(MarkupColor.FromUnityColor32(color));

        public static ColorStyle Color(System.Drawing.Color color)
            => new ColorStyle(MarkupColor.FromSystemColor(color));

        public static ColorStyle Color(byte r = 255, byte g = 255, byte b = 255, byte a = 255)
            => new ColorStyle(new MarkupColor(r, g, b, a));

        public static BoldStyle Bold()
            => bold;

        public static ItalicStyle Italic()
            => italic;


        public static MarkupString operator +(Style style, string text)
            => new MarkupString().AddText(text, style);

        public static MarkupString operator +(string text, Style style)
            => new MarkupString().AddText(text, style);

        public static MarkupString operator +(MarkupString text, Style style)
            => text.AddStyle(style);

        public static MarkupString operator +(Style style, MarkupString text)
            => text.AddStyle(style);
    }
}