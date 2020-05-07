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
    public partial class RandomColorLoader : ContentView
    {
        Random random = new Random();
        public RandomColorLoader()
        {
            InitializeComponent();
            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                 customsg.TextColor =
                     customloader.Color =
                Color.FromRgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
                // True = Repeat again, False = Stop the timer  
                return true;
            });
        }
    }
}