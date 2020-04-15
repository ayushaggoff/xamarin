using MobApplication.View;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MobApplication.ModelView
{
    class HomePageViewModel
    {
        public ICommand Btn_Clicked
        {
            get;
            set;
        }

        //public HomePageViewModel()
        //{
        //    Btn_Clicked = new Command(OnButtonClicked);
        //}
        //public void OnButtonClicked()
        //{
        //    Login objlogin = new Login();
        //    var btn = (Button)sender;
        //    switch (btn.CommandParameter)
        //    {
        //        case "Home":
        //            App.Current.MainPage = new HomePage();
        //            break;
        //        case "About Us":
        //            contentview.Content = new View.AboutUs();
        //            break;
        //        case "Project":
        //            contentview.Content = new View.ProjectView.NETFacilitiesView();
        //            TabBtnGrid.IsVisible = false;
        //            ProjectBtnGrid.IsVisible = true;
        //            break;
        //        case "BIM Network":
        //            contentview.Content = new View.ProjectView.BIMNetworksView();
        //            break;
        //        case "Display Now":
        //            contentview.Content = new View.ProjectView.DisplayNowView();
        //            break;
        //        case "Meeting Hub":
        //            contentview.Content = new View.ProjectView.Meeting_HubView();
        //            break;
        //        case "Contact Us":
        //            contentview.Content = new View.contactus();
        //            break;
        //        case "Login":
        //            contentview.Content = objlogin.Content;
        //            //  App.Current.MainPage = new Login();
        //            break;
        //    }

        //}
    }
}