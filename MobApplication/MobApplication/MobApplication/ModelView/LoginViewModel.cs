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
        private bool _isFocus;

        public event PropertyChangedEventHandler PropertyChanged;
        public event EventHandler EmailCompleted;
        public event EventHandler Show;
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
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
        }
        public void EmailCheck(Entry sender)
        {
            Regex regex = new Regex(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
            bool isValid = regex.IsMatch(("" + Email).Trim());
            if (!isValid)
            {
                Show?.Invoke("please enter the valid email", null);
            }
            else 
            {
                sender.Focus();
            }
        }
        public void PasswordCheck(object sender)
        {
            if (string.IsNullOrEmpty(Password))
            {
                Show?.Invoke("Please enter the Password", null);
            }
            else
            {
                ((Button)sender).Focus();
            }
        }
        public void OnButtonClicked()
        {
            Regex regex = new Regex(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
            bool isValid = regex.IsMatch(("" + Email).Trim());

            if (string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Password))
            {
                Show?.Invoke("Please fill all the fields", null);
            }
            else if (!isValid)
            {
                Show?.Invoke("Please enter the valid email", null);
            }
            else if (ConstEmail == Email && ConstPassword == Password)
            {
                Show?.Invoke("Successfully logged in", null);
            }
            else
            {
                Show?.Invoke("Try again", null);
            }
        }
    }
}