using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Xamarin.Forms;

namespace MobApplication
{
    class EmailValidationTriggerAction : TriggerAction<Entry>
    {
        protected override void Invoke(Entry entry)
        {
            var email = entry.Text;
            Regex regex = new Regex(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
            bool isValid = regex.IsMatch(("" + email).Trim());
            if (!isValid)
            {
                entry.BackgroundColor = Color.Tomato;
                App.Current.MainPage.DisplayAlert("Error", "please enter the valid email", "ok");
            }
            else
            {
                entry.BackgroundColor = Color.LightGreen;
            }
        }
    }
}
