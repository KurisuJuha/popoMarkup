namespace JuhaKurisu.PopoTools.Markup
{
    public abstract class Style
    {
        public MarkupString this[string t]
        {
            get => new MarkupString().AddText(t, this);
        }

        public virtual string ToString(string text)
            => text;

    }
}