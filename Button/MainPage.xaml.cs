using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Themes;

namespace Button
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();


        }

        void Switch(object sender,ToggledEventArgs e)
        {
            var Resorses = new Xamarin.Forms.Themes.DarkThemeResources();

            if (Resources?.GetType() == typeof(DarkThemeResources))
            {
                Resources = new LightThemeResources();
                return;
            }
            Resources = new DarkThemeResources();
        }


    }
}
