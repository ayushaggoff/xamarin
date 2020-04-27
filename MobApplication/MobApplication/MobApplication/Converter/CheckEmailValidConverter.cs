using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
using Xamarin.Forms;

namespace MobApplication.Converter
{
    public class CheckEmailValidConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                var email = value.ToString();
                Regex regex = new Regex(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
                bool isValid = regex.IsMatch(("" + email).Trim());
                if (!isValid)
                {
                    return Color.Red;
                }
                else 
                {
                    return Color.White;
                }

            }
            else
            {
                return Color.White;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                return Color.White;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
                        
                return Color.White;
            
        }
    }
}
