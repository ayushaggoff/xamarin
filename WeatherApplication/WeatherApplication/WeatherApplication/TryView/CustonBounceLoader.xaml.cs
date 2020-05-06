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
    public partial class CustonBounceLoader : ContentView
    {
        public CustonBounceLoader()
        {
            Random random = new Random();

            InitializeComponent();
            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                Ball.TextColor = Ball1.TextColor = Ball2.TextColor =
                     Ball3.TextColor = Ball4.TextColor =
                Color.FromRgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
                // True = Repeat again, False = Stop the timer  
                return true;
            });
            Bounce();
            Bounce1();
            Bounce2();
            Bounce3();
            Bounce4();
        }
        private async void Bounce()
        {

            for (int i = 2; i > 1; i++)
            {
                await Ball.TranslateTo(0, -100, 800, Easing.SinIn);
                await Ball.TranslateTo(0, 0, 800, Easing.SinInOut);
            }
        }
        private async void Bounce1()
        {
            for (int i = 2; i > 1; i++)
            {
                await Ball1.TranslateTo(0, -150, 1000, Easing.SinIn);
                await Ball1.TranslateTo(0, 0, 1000, Easing.SinInOut);
            }
        }
        private async void Bounce2()
        {
            for (int i = 2; i > 1; i++)
            {
                await Ball2.TranslateTo(0, -100, 700, Easing.SinIn);
                await Ball2.TranslateTo(0, 0, 700, Easing.SinInOut);
            }
        }
        private async void Bounce3()
        {
            for (int i = 2; i > 1; i++)
            {
                await Ball3.TranslateTo(0, -200, 780, Easing.SinIn);
                await Ball3.TranslateTo(0, 0, 780, Easing.SinInOut);
            }
        }
        private async void Bounce4()
        {
            for (int i = 2; i > 1; i++)
            {
                await Ball4.TranslateTo(0, -190, 800, Easing.SinIn);
                await Ball4.TranslateTo(0, 0, 800, Easing.SinInOut);
            }
        }
    }
}