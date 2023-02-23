namespace JuhaKurisu.PopoTools.Markup
{
    public class BoldStyle : Style
    {
        public override string ToString(string text)
        {
            return $"<b>{text}</b>";
        }
    }
}