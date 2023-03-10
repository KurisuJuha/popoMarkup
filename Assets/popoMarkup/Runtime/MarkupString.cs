using System.Linq;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace JuhaKurisu.PopoTools.Markup
{
    public class MarkupString
    {
        public ReadOnlyCollection<(string, List<Style>)> styleTexts => styleTextList.AsReadOnly();
        private List<(string text, List<Style> styles)> styleTextList = new List<(string, List<Style>)>();

        public MarkupString AddText(string text, Style style)
        {
            styleTextList.Add((text, new List<Style>() { style }));
            return this;
        }

        public MarkupString AddStyle(Style style)
        {
            if (styleTextList.Count == 0) return this;

            styleTextList.Last().styles.Add(style);
            return this;
        }

        public override string ToString()
        {
            string ret = "";

            foreach (var styleText in styleTextList)
            {
                string text = styleText.text;
                foreach (var style in styleText.styles)
                    text = style.ToString(text);
                ret += text;
            }

            return ret;
        }

        public static MarkupString operator +(MarkupString a, MarkupString b)
        {
            a.styleTextList.AddRange(b.styleTextList);
            return a;
        }
    }
}