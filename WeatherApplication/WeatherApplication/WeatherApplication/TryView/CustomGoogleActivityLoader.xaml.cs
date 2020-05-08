using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WeatherApplication.TryView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomGoogleActivityLoader : ContentView
    {
        public CustomGoogleActivityLoader()
        {
            InitializeComponent();
            Bounce();

        }
        private async void Bounce()
        {

            for (int i = 2; i > 1; i++)
            {
                await Circle_Green.TranslateTo(0, -20, 250, Easing.SinOut);
                await Circle_Yellow.TranslateTo(0, -20, 250, Easing.SinOut);
                await Circle_Red.TranslateTo(0, -20, 250, Easing.SinOut);
                await Circle_Blue.TranslateTo(0, -20, 250, Easing.SinOut);
                await Circle_Blue.TranslateTo(0, 0, 250, Easing.SinOut);
                await Circle_Red.TranslateTo(0, 0, 250, Easing.SinOut);
                await Circle_Yellow.TranslateTo(0, 0, 250, Easing.SinOut);
                await Circle_Green.TranslateTo(0, 0, 250, Easing.SinOut);
            }

        }
    }
}