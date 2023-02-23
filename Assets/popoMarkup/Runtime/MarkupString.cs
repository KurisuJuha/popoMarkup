using System.Linq;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace JuhaKurisu.PopoTools.Markup
{
    public class MarkupString
    {
        public ReadOnlyCollection<(string, List<Style>)> styleTexts => styleTextList.AsReadOnly();
        private List<(string text, List<Style> styles)> styleTextList = new List<(string, List<Style>)>();

    }
}