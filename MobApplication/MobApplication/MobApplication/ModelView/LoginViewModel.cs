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
        private string _txt;

        public event PropertyChangedEventHandler PropertyChanged;

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
        //public string Txt
        //{
        //    get
        //    {
        //        return _txt;
        //    }
        //    set
        //    {
        //       _txt=value;
        //        NotifyPropertyChanged("Txt");
        //    }
        //}
        public ICommand OnLogin 
        {
            get;
            set;
        }
        public ICommand CheckEmailFormant
        {
            get;
            set;
        }
        public LoginViewModel()
        {
            OnLogin = new Command(OnButtonClicked);
            //OnLogin = new Command(ChkEmailFormat);
        }
        //public void ChkEmailFormat()
        //{
        //    Regex regex = new Regex(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
        //    bool isValid = regex.IsMatch(Email.Trim());
        //    if (!isValid)
        //    {
        //        Txt = "Please enter the valid email";
        //    }
           

        //}
        public void OnButtonClicked()
        {
            Regex regex = new Regex(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
                bool isValid = regex.IsMatch((""+Email).Trim());
            
            if (string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Password))
            {
                  App.Current.MainPage.DisplayAlert("Error", "Please fill all the fields", "OK");  
            }
            else if (!isValid)
            {
                App.Current.MainPage.DisplayAlert("Error", "please enter the valid email","ok");
            }
            else if (ConstEmail == Email && ConstPassword == Password)
            {
                App.Current.MainPage.DisplayAlert("Login", "Successfully logged in","ok");
            }
            else 
            {
                App.Current.MainPage.DisplayAlert("Error", "Try again", "ok");
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
        //    public virtual void NotifyPropertyChanged(string propertyName="")
        //{

        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //}
    
    }
}
