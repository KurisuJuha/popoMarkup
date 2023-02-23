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

        public static MarkupColor Rgba(byte r = 0, byte g = 0, byte b = 0, byte a = 255)
            => new MarkupColor(r, g, b, a);

        public static MarkupColor FromUnityColor(UnityEngine.Color color)
            => new MarkupColor((byte)(color.r * 255), (byte)(color.g * 255), (byte)(color.b * 255), (byte)(color.a * 255));

        public static MarkupColor FromUnityColor32(UnityEngine.Color32 color)
            => new MarkupColor(color.r, color.g, color.b, color.a);

        public static MarkupColor FromSystemColor(System.Drawing.Color color)
            => new MarkupColor(color.R, color.G, color.B, color.A);
    }
}