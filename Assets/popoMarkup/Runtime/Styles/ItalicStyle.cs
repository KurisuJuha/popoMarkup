namespace JuhaKurisu.PopoTools.Markup
{
    public class ItalicStyle : Style
    {
        public override string ToString(string text)
        {
            return $"<i>{text}</i>";
        }
    }
}