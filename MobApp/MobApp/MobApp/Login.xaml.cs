using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        const string UserName ="ayush@gmail.com";
        const string Password ="123";
        public Login()
        {
            InitializeComponent();
        }
        void OnButtonClicked(object sender, EventArgs args)
        {
            var inputUsername = username.Text;
            var inputPassword = password.Text;
            if (inputUsername != UserName||inputPassword!=Password)
            {
                DisplayAlert("Error","Provide the correct input ","ok");
            }
            else if (inputUsername == UserName && inputPassword == Password)
            {
                DisplayAlert("Login", "Success", "ok");
            }
        }

        private void Username_TextChanged(object sender, TextChangedEventArgs e)
        {
            var oldText =""+e.OldTextValue;
            var newText = e.NewTextValue;
           
            if (oldText.Length==0)
            {
                if (Char.Parse(newText) < 65 || Char.Parse(newText) > 90&& Char.Parse(newText)<97 || Char.Parse(newText) >122)
                {
                    DisplayAlert("Error", "Invalid Format", "ok");
                }
            }
            else if (oldText.Contains("@") && newText == "@")
            {
                DisplayAlert("Error", "Invalid format", "ok");
            }
        }

        private void Username_Completed(object sender, EventArgs e)
        {
            var inputUsername = ""+username.Text;
            Regex regex = new Regex(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
            bool isValid = regex.IsMatch((inputUsername.ToString()).Trim());
            if (!isValid)
            {
                DisplayAlert("Error", "Invalid Username", "ok");
            }
            else 
            {
                password.Focus();           
            }
        }
        private void Password_Completed(object sender, EventArgs e)
        {
            var inputPassword = "" + password.Text;
        
            if (inputPassword.Length==0)
            {
                DisplayAlert("Error", "Invalid Password", "ok");
            }
            else
            {
                login.Focus();
            }
        }
    }
}