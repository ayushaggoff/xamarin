using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApplication.ModelView;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WeatherApplication.View
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

        public void SetValue(string key, string value)
        {
            var data = new LoginViewModel();
            var content = JsonConvert.SerializeObject(data);
            Preferences.Set(content, value);
        }
        public void GetValue(string key, string value)
        {
            var content = JsonConvert.DeserializeObject<List<LoginViewModel>>(key);
          ;
        }

        private void Model_Show(object sender, EventArgs e)
        {
            var ob = (string)sender;
            App.Current.MainPage.DisplayAlert("Error", ob, "ok");
            if (ob == "Successfully logged in")
            {
                Navigation.PushAsync(new HomePage());
            }

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