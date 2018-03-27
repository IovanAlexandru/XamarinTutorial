using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Xamarin.Forms;

namespace HelloWorld.CollectionViews
{
    public class NamedColor
    {
        private NamedColor()
        {
        }

        public string Name { get; private set; }
        public string FriendlyName { get; private set; }
        public Color Color { get; private set; }
        public string RgbDisplay { get; private set; }

        static NamedColor()
        {
            List<NamedColor> all = new List<NamedColor>();
            StringBuilder stringBuilder = new StringBuilder();
            foreach (FieldInfo fieldInfo in typeof(NamedColor).GetRuntimeFields())
            {
                if (fieldInfo.IsPublic &&
                    fieldInfo.IsStatic &&
                    fieldInfo.FieldType == typeof(Color))
                {
                    string name = fieldInfo.Name;
                    stringBuilder.Clear();
                    int index = 0;
                    foreach (char ch in name)
                    {
                        if (index != 0 && Char.IsUpper(ch))
                        {
                            stringBuilder.Append(' ');
                        }

                        stringBuilder.Append(ch);
                        index++;
                    }

                    Color color = (Color)fieldInfo.GetValue(null);
                    NamedColor namedColor = new NamedColor()
                    {
                        Name = name,
                        FriendlyName = stringBuilder.ToString(),
                        Color = color,
                        RgbDisplay = string.Format("{0:X2}-{1:X2}-{2:X2}",
                                            (int)(255 * color.R),
                                            (int)(255 * color.G),
                                            (int)(255 * color.B))
                    };

                    all.Add(namedColor);
                }
            }

            all.TrimExcess();
            All = all.ToList();
            for (var i = 0; i < 10; i++)
            {
                ((List<NamedColor>) All).AddRange(all);
            }
        }

        public static IList<NamedColor> All { private set; get; }

        public static readonly Color AliceBlue = Color.FromRgb(240, 248, 255);
        public static readonly Color AntiqueWhite = Color.FromRgb(250, 235, 215);
        public static readonly Color Aqua = Color.FromRgb(0, 255, 255);
        public static readonly Color WhiteSmoke = Color.FromRgb(245, 245, 245);
        public static readonly Color Yellow = Color.FromRgb(255, 255, 0);
        public static readonly Color YellowGreen = Color.FromRgb(154, 205, 50);
    }
}
