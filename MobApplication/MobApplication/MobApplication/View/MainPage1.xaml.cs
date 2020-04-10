using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace MobApplication.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage1 : MasterDetailPage
    {
        public MainPage1()
        {
            InitializeComponent();
            contentview.Content = new View.AboutUs();
        }

        private void Login_Clicked(object sender, EventArgs e)
        {
            //tried crash analytics
            //var n = 0;
            //int a = n / 0;
            App.Current.MainPage = new Login();
        }

        private void ContactUs_Clicked(object sender, EventArgs e)
        {
            contentview.Content = new View.contactus();
        }

        private void AboutUs_Clicked(object sender, EventArgs e)
        {
            contentview.Content = new View.AboutUs();

        }
    }
}