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
        //const string Email = "ayush@gmail.com";
        //const string Password = "123";
        public Login()
        {
            InitializeComponent();
            BindingContext = new LoginViewModel();

        }
        //void OnButtonClicked(object sender, EventArgs args)
        //{
        //    var inputEmail = email.Text;
        //    var inputPassword = password.Text;
        //    if (("" + email.Text).Length == 0 || ("" + password.Text).Length == 0)
        //    {
        //        DisplayAlert("Error", "Please fill all the fields ", "ok");
        //    }
        //    else if (inputEmail != Email || inputPassword != Password)
        //    {
        //        DisplayAlert("Error", "Provide the correct input ", "ok");
        //    }
        //    else if (inputEmail == Email && inputPassword == Password)
        //    {
        //        DisplayAlert("Login", "Success", "ok");
        //    }
        //}

        //private void Email_TextChanged(object sender, TextChangedEventArgs e)
        //{
        //    var oldText = "" + e.OldTextValue;
        //    var newText = e.NewTextValue;

        //    if (oldText.Length == 0)
        //    {
        //        if (Char.Parse(newText) < 65 || Char.Parse(newText) > 90 && Char.Parse(newText) < 97 || Char.Parse(newText) > 122)
        //        {
        //            DisplayAlert("Error", "Invalid Format", "ok");
        //        }
        //    }
        //    else if (oldText.Contains("@") && newText == "@")
        //    {
        //        DisplayAlert("Error", "Invalid format", "ok");
        //    }
        //}

        //private void Email_Completed(object sender, EventArgs e)
        //{
        //    var inputEmail = "" + email.Text;
        //    Regex regex = new Regex(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
        //    bool isValid = regex.IsMatch((inputEmail.ToString()).Trim());
        //    if (!isValid)
        //    {
        //        DisplayAlert("Error", "Please enter the valid email", "ok");
        //    }
        //    else
        //    {
        //        password.Focus();
        //    }
        //}
        //private void Password_Completed(object sender, EventArgs e)
        //{
        //    var inputPassword = "" + password.Text;

        //    if (inputPassword.Length == 0)
        //    {
        //        DisplayAlert("Error", "Please provide the password", "ok");
        //    }
        //    else
        //    {
        //        login.Focus();
        //    }
        //}
    }
}
   
