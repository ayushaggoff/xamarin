using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;

namespace WeatherApplication.Control
{
    class AppPreferences
    {
        public static void SetToken(String value)
        {
            Preferences.Set("Token",value);
        }
        public static string GetToken()
        {
            string token = Preferences.Get("Token","");
            return token;
        }
    }
}
