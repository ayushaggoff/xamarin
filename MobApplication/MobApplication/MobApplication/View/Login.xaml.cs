using MobApplication.ModelView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobApplication.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        LoginViewModel model = new LoginViewModel();
        //const string Email = "ayush@gmail.com";
        //const string Password = "123";
        //string check;
        public Login()
        {
            InitializeComponent();
         
            model.Show += Model_Show;
            BindingContext = model;
           
        }
        private void Model_Show(object sender, EventArgs e)
        {
            var ob = (string)sender;
            App.Current.MainPage.DisplayAlert("Error", ob, "ok");
        }
        private void Email_Completed(object sender, EventArgs e)
        { 
          // model.EmailCheck(password);  
        }

        private void Password_Completed(object sender, EventArgs e)
        {
          //  model.PasswordCheck(login);
        }

        private void email_Focused(object sender, FocusEventArgs e)
        {
            //CustField.EntryText = email.Text;
            //ImgUsername.IsVisible = false;
            //email.IsVisible = false;
            //CustField.LabelText = email.Placeholder.ToString();
            //CustField.BackgroundColor = Color.White;
            //CustField.IsVisible = true;
        }

        private void password_Focused(object sender, FocusEventArgs e)
        {
            //CustFieldPassword.EntryText = password.Text;
            //ImgPassword.IsVisible = false;
            //password.IsVisible = false;
            //CustFieldPassword.LabelText = password.Placeholder.ToString();
            //CustFieldPassword.BackgroundColor = Color.White;
          //CustFieldPassword.IsVisible = true;
        }

        private void CustFieldPassword_Unfocused(object sender, FocusEventArgs e)
        {
            //CustFieldPassword.IsVisible = false;
            //password.IsVisible = true;
        }
    }
}
   
