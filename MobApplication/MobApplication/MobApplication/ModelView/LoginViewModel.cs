using System;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows.Input;
using Xamarin.Forms;

namespace MobApplication.ModelView
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        const string ConstEmail = "ayush@gmail.com";
        const string ConstPassword = "123";
        private string _email;
        private string _password;

        public event PropertyChangedEventHandler PropertyChanged;
        public event EventHandler EmailCompleted;
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
               _email=value;
            }
        }
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                 _password = value;
            }
        }
        public ICommand OnLogin 
        {
            get;
            set;
        }

        public LoginViewModel()
        {
            OnLogin = new Command(OnButtonClicked);
            EmailCompleted?.Invoke("Please fill all the fields", null);
        }

        public void OnButtonClicked()
        {
            Regex regex = new Regex(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
            bool isValid = regex.IsMatch(("" + Email).Trim());

            if (string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Password))
            {
               // EmailCompleted?.Invoke("Please fill all the fields", null);
                // App.Current.MainPage.DisplayAlert("Error", "Please fill all the fields", "OK");  
            }
            else if (!isValid)
            {
                App.Current.MainPage.DisplayAlert("Error", "please enter the valid email", "ok");
            }
            else if (ConstEmail == Email && ConstPassword == Password)
            {
                App.Current.MainPage.DisplayAlert("Login", "Successfully logged in", "ok");
            }
            else
            {
                App.Current.MainPage.DisplayAlert("Error", "Try again", "ok");
            }

        }
    }
}
