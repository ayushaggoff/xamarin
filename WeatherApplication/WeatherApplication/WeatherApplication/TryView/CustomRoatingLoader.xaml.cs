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
    public partial class CustomRoatingLoader : ContentView
    {
        public CustomRoatingLoader()
        {
            InitializeComponent();
            RotateLoading();
        }
        private async void RotateLoading()
        {

            for (int i = 2; i > 1; i++)
            {
                await L.RotateTo(365, 400, Easing.SinInOut);
                await L.RotateTo(0, 400, Easing.SinInOut);
                await O.RotateTo(365, 400, Easing.SinInOut);
                await O.RotateTo(0, 400, Easing.SinInOut);
                await A.RotateTo(365, 400, Easing.SinInOut);
                await A.RotateTo(0, 400, Easing.SinInOut);
                await D.RotateTo(365, 400, Easing.SinInOut);
                await D.RotateTo(0, 400, Easing.SinInOut);
                await I.RotateTo(365, 400, Easing.SinInOut);
                await I.RotateTo(0, 400, Easing.SinInOut);
                await N.RotateTo(365, 400, Easing.SinInOut);
                await N.RotateTo(0, 400, Easing.SinInOut);
                await G.RotateTo(365, 400, Easing.SinInOut);
                await G.RotateTo(0, 400, Easing.SinInOut);

            }
        }
    }
}