namespace JuhaKurisu.PopoTools.Markup
{
    public abstract class Style
    {
        public readonly static BoldStyle bold = new BoldStyle();
        public MarkupString this[string t]
        {
            get => new MarkupString().AddText(t, this);
        }

        public virtual string ToString(string text)
            => text;

        public static BoldStyle Bold()
            => bold;

    }
}