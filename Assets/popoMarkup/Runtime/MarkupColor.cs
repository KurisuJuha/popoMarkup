namespace JuhaKurisu.PopoTools.Markup
{
    public class MarkupColor
    {
        public readonly byte r;
        public readonly byte g;
        public readonly byte b;
        public readonly byte a;

        public MarkupColor(byte r, byte g, byte b, byte a)
        {
            this.r = r;
            this.g = g;
            this.b = b;
            this.a = a;
        }

        public static MarkupColor Rgb(byte r = 0, byte g = 0, byte b = 0)
            => new MarkupColor(r, g, b, 255);
    }
}