using MobApplication.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobApplication
{
    public partial class App : Application
    {
        public App()
        {

            InitializeComponent();

            MainPage = new WeatherPage();
        //    MainPage = new NavigationPage(new DetailPage())
        //    {
        //        BarBackgroundColor = Color.White,
        //    };
        }


        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
