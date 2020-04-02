using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MobApp.ModelView
{
    public class LoginViewModel
    {
        const string ConstEmail = "ayush@gmail.com";
        const string ConstPassword = "1234";
        private string _email;
        private string _password;
        private string _txt;
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                value = _email;
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
                value = _password;
            }
        }
        public string Txt
        {
            get
            {
                return _txt;
            }
            set
            {
                value = _txt;
            }
        }
        public ICommand OnLogin;
       public LoginViewModel()
        {
            OnLogin = new Command(OnButtonClicked);
        }
        void OnButtonClicked()
        {
            var inputEmail = Email;
            var inputPassword = Password;
            if (("" + Email).Length == 0 || ("" + Password).Length == 0)
            {
                Txt = "ayush";
            }
            //else if (Email != ConstEmail || Password != ConstPassword)
            //{
            //    DisplayAlert("Error", "Provide the correct input ", "ok");
            //}
            //else if (Email == ConstEmail && Password == ConstPassword)
            //{
            //    DisplayAlert("Login", "Success", "ok");
            //}

        }
    }
}
