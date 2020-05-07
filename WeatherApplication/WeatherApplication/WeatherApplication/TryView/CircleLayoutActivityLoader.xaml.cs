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
    public partial class CircleLayoutActivityLoader : ContentPage
    {
        public CircleLayoutActivityLoader()
        {
            InitializeComponent();
            RotateLoading();
        }
        private async void RotateLoading()
        {
            for (int i = 2; i > 1; i++)
            {
                Circle1.BackgroundColor = Circle2.BackgroundColor = Circle3.BackgroundColor = Color.Blue;
                await CircleLayout.RotateTo(365, 200, Easing.Linear);
                await CircleLayout.ScaleTo(2, 266, Easing.Linear);
                Circle1.BackgroundColor = Circle2.BackgroundColor = Circle3.BackgroundColor = Color.LightBlue;
                await CircleLayout.ScaleTo(1, 1, Easing.Linear);
                await CircleLayout.RotateTo(-365, 200, Easing.Linear);
            }
        }
    }
}