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
    public partial class Try : ContentPage
    {
        public Try()
        {
            const string Email = "ayush@gmail.com";
            const string Password = "123";

            AbsoluteLayout layout = new AbsoluteLayout
            {
                BackgroundColor = Color.FromHex("#B3F2DD")
            };
            Button login = new Button
            {
                Text = "Log In",
                BackgroundColor = Color.FromHex("#19D6D2"),
                TextColor = Color.White
            };
            var email = new Entry
            {
                BackgroundColor = Color.White,
                Placeholder = "Username"
            };
            Entry password = new Entry
            {
                IsPassword = true,
                BackgroundColor = Color.White,
                Placeholder = "Password"
            };

            Image userImg = new Image
            {
                Source="user.png"
            };
            Image usernameImg = new Image
            {
                Source = "tie.png",
                BackgroundColor = Color.White
            };
            Image passwordImg = new Image
            {
                Source = "lock1.png",
                BackgroundColor = Color.White
            };
            login.Clicked += (OnButtonClicked);
            email.TextChanged += (Email_TextChanged);
            email.Completed += (Email_Completed);
            password.Completed += (Password_Completed);
            AbsoluteLayout.SetLayoutBounds(userImg, new Rectangle(.5, .15, .8, .3));
            AbsoluteLayout.SetLayoutFlags(userImg, AbsoluteLayoutFlags.All);
            AbsoluteLayout.SetLayoutBounds(usernameImg, new Rectangle(.1, .5, .06, .09));
            AbsoluteLayout.SetLayoutFlags(usernameImg, AbsoluteLayoutFlags.All);
            AbsoluteLayout.SetLayoutBounds(passwordImg, new Rectangle(.1, .62, .06, .09));
            AbsoluteLayout.SetLayoutFlags(passwordImg, AbsoluteLayoutFlags.All);
            AbsoluteLayout.SetLayoutBounds(email, new Rectangle(.59, .5, .74, .09));
            AbsoluteLayout.SetLayoutFlags(email, AbsoluteLayoutFlags.All);
            AbsoluteLayout.SetLayoutBounds(password, new Rectangle(.59, .62, .74, .09));
            AbsoluteLayout.SetLayoutFlags(password, AbsoluteLayoutFlags.All);
            AbsoluteLayout.SetLayoutBounds(login, new Rectangle(.5, .74, .8, .1));
            AbsoluteLayout.SetLayoutFlags(login, AbsoluteLayoutFlags.All);
            layout.Children.Add(userImg);
            layout.Children.Add(usernameImg);
            layout.Children.Add(passwordImg);
            layout.Children.Add(email);
            layout.Children.Add(password);
            layout.Children.Add(login);

            void OnButtonClicked(object sender, EventArgs args)
            {
                var inputEmail = email.Text;
                var inputPassword = password.Text;
                if (("" + email.Text).Length == 0 || ("" + password.Text).Length == 0)
                {
                    DisplayAlert("Error", "Please fill all the fields ", "ok");
                }
                else if (inputEmail != Email || inputPassword != Password)
                {
                    DisplayAlert("Error", "Provide the correct input ", "ok");
                }
                else if (inputEmail == Email && inputPassword == Password)
                {
                    DisplayAlert("Login", "Success", "ok");
                }
            }

            void Email_TextChanged(object sender, TextChangedEventArgs e)
            {
                var oldText = "" + e.OldTextValue;
                var newText = e.NewTextValue;

                if (oldText.Length == 0)
                {
                    if (Char.Parse(newText) < 65 || Char.Parse(newText) > 90 && Char.Parse(newText) < 97 || Char.Parse(newText) > 122)
                    {
                        DisplayAlert("Error", "Invalid Format", "ok");
                    }
                }
                else if (oldText.Contains("@") && newText == "@")
                {
                    DisplayAlert("Error", "Invalid format", "ok");
                }
            }
            void Email_Completed(object sender, EventArgs e)
            {
                var inputEmail = "" + email.Text;
                Regex regex = new Regex(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
                bool isValid = regex.IsMatch((inputEmail.ToString()).Trim());
                if (!isValid)
                {
                    DisplayAlert("Error", "Please enter the valid email", "ok");
                }
                else
                {
                    password.Focus();
                }
            }
            void Password_Completed(object sender, EventArgs e)
            {
                var inputPassword = "" + password.Text;

                if (inputPassword.Length == 0)
                {
                    DisplayAlert("Error", "Please provide the password", "ok");
                }
                else
                {
                    login.Focus();
                }
            }
            Content = layout;

        }
    }
}