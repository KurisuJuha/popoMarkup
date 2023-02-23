namespace JuhaKurisu.PopoTools.Markup
{
    public class ColorStyle : Style
    {
        public readonly MarkupColor color;

        public ColorStyle(MarkupColor color)
        {
            this.color = color;
        }

        public override string ToString(string text)
        {
            return $"<color=#{color.ToColorCode()}>{text}</color>";
        }
    }
}