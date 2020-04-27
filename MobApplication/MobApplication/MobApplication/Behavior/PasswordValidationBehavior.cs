using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MobApplication.Behavior
{
   public class PasswordValidationBehavior:Behavior<Entry>
    {
        protected override void OnAttachedTo(Entry entry)
        {
            entry.TextChanged += OnEntryTextChanged;
            base.OnAttachedTo(entry);
        }

        protected override void OnDetachingFrom(Entry entry)
        {
            entry.TextChanged -= OnEntryTextChanged;
            base.OnDetachingFrom(entry);
        }
        void OnEntryTextChanged(object sender, TextChangedEventArgs args)
        {

            var password = ((Entry)sender).Text;
            if (password.Length < 4)
            {
                ((Entry)sender).BackgroundColor = Color.Red;
            }
            else if (password.Length >3&& password.Length <7)
            {
                ((Entry)sender).BackgroundColor = Color.LightGreen;
            }
            else
            {
                ((Entry)sender).BackgroundColor = Color.Yellow;
            }
        }
    }
}
