using MobApplication.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
namespace MobApplication
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage1();
        }

        protected override void OnStart()
        {
            AppCenter.Start("5139bcae-32d9-4bbf-acfa-712c21577886",
                   typeof(Analytics), typeof(Crashes));
            AppCenter.Start("5139bcae-32d9-4bbf-acfa-712c21577886",
                               typeof(Analytics), typeof(Crashes));
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
