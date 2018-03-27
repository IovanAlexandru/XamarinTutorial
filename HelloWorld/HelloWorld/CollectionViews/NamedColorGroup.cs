using System.Collections.Generic;

namespace HelloWorld.CollectionViews
{
    public class NamedColorGroup : List<NamedColor>
    {
        public NamedColorGroup(string title, List<NamedColor> colors)
        {
            this.Title = title;
            this.AddRange(colors);
        }

        public string Title { get; set; }
    }
}
