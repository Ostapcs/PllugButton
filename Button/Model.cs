using System;
using System.Collections.Generic;
using System.Reflection;
using Xamarin.Forms;

namespace Button
{
    public class Model
    {
        public List<string> colours { get; set; }
        public int cornRadiusValue { get; set; }
        public int fontSizeValue { get; set; }
        public int borderWidthValue { get; set; }
        public int colouSelectedIndex { get; set; }
        public string backgroundcolour { get; set; }
        public string textcolour { get; set; }
        public string bordercolour { get; set; }

        public Model()
        {
            fontSizeValue = 50;

            backgroundcolour = "Black";
            textcolour = "White";
            bordercolour = "Yellow";

            ColorTypeConverter converter = new ColorTypeConverter();
            colours = new List<string>();

            foreach (var field in typeof(Xamarin.Forms.Color).GetFields(BindingFlags.Static | BindingFlags.Public))
            {
                if (field != null && !String.IsNullOrEmpty(field.Name))
                    colours.Add(field.Name);
            }
        }
    }
}
