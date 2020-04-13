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
            //tried crash analytics
            //var n = 0;
            //int a = n / 0;
            contentview.Content = new View.contactus();
        }
        private void Project_Clicked(object sender, EventArgs e)
        {
            //contentview.Content = new View.ProjectView.Meeting_HubView();
            contentview.Content = new View.ProjectView.NETFacilitiesView();
            TabBtnGrid.IsVisible = false;
            ProjectBtnGrid.IsVisible = true;
        }
        private void AboutUs_Clicked(object sender, EventArgs e)
        {
            contentview.Content = new View.AboutUs();
        }
        private void Home_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new MainPage1();
        }
        private void BIM_Clicked(object sender, EventArgs e)
        {
            contentview.Content = new View.ProjectView.BIMNetworksView();
        }
        private void Display_Clicked(object sender, EventArgs e)
        {
            contentview.Content = new View.ProjectView.DisplayNowView();
        }
        private void Meeting_Clicked(object sender, EventArgs e)
        {
            contentview.Content = new View.ProjectView.Meeting_HubView();
        }
        private void NET_Clicked(object sender, EventArgs e)
        {
            contentview.Content = new View.ProjectView.NETFacilitiesView();
        }
    }
}