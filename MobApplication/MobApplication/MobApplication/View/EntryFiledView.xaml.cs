using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobApplication.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EntryFiledView : ContentView
    {
        public static BindableProperty TextProperty = BindableProperty.Create(nameof(Text), typeof(string), typeof(EntryFiledView), defaultBindingMode: BindingMode.TwoWay);
        public static BindableProperty PlaceholderProperty = BindableProperty.Create(nameof(Placeholder), typeof(string), typeof(EntryFiledView), defaultBindingMode: BindingMode.TwoWay, propertyChanged: (bindable, oldVal, newval) => {
            var matEntry = (EntryFiledView)bindable;
            matEntry.EntryField.Placeholder = (string)newval;
            matEntry.HiddenLabel.Text = (string)newval;
        });
        public static BindableProperty IsPasswordProperty = BindableProperty.Create(nameof(IsPassword), typeof(bool), typeof(EntryFiledView), defaultValue: false, propertyChanged: (bindable, oldVal, newVal) => {
            var matEntry = (EntryFiledView)bindable;
            matEntry.EntryField.IsPassword = (bool)newVal;
        });
        public static BindableProperty ImgSourceProperty = BindableProperty.Create(nameof(ImgSource), typeof(string), typeof(EntryFiledView), defaultValue: "", propertyChanged: (bindable, oldVal, newVal) =>
        {
            (bindable as EntryFiledView).image.Source = newVal.ToString();
        });
        public EntryFiledView()
        {
            InitializeComponent();

            EntryField.BindingContext = this;
            EntryField.Focused += async (s, a) => {
                Frame.BorderColor = Color.Blue;
                HiddenLabel.IsVisible = true;
                if (string.IsNullOrEmpty(EntryField.Text))
                {
                    //Here we give animation on label position, label fading and box view.  
                
                    EntryField.Placeholder = null;
                }
            };

            EntryField.Unfocused += async (s, a) => {
                Frame.BorderColor = Color.White;
                HiddenLabel.IsVisible = false; 
                if (string.IsNullOrEmpty(EntryField.Text))
                { 
                    EntryField.Placeholder = Placeholder;
                }
               
            };
        }
        public bool IsPassword
        {
            get => (bool)GetValue(IsPasswordProperty);
            set => SetValue(IsPasswordProperty, value);
        }

        public string ImgSource
        {
            get => (string)GetValue(ImgSourceProperty);
            set => SetValue(ImgSourceProperty, value);
        }
        public string Text
        {
            get => (string)GetValue(TextProperty);
            set => SetValue(TextProperty, value);
        }
        public string Placeholder
        {
            get => (string)GetValue(PlaceholderProperty);
            set => SetValue(PlaceholderProperty, value);
        }
    }
}