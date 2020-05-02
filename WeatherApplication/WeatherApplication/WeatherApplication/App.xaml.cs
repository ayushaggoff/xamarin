using System;
using WeatherApplication.Control;
using WeatherApplication.View;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WeatherApplication
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new TryPage());
            //if (!String.IsNullOrEmpty(AppPreferences.GetToken()))
            //{
            //    MainPage = new NavigationPage(new HomePage());
            //}
            //else
            //{
            //    MainPage = new NavigationPage(new Login());
            //}

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
