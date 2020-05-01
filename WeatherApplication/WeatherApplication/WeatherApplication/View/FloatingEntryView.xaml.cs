using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WeatherApplication.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FloatingEntryView : ContentView
    {

        public static BindableProperty TextProperty = BindableProperty.Create(nameof(Text), typeof(string), typeof(FloatingEntryView), defaultBindingMode: BindingMode.TwoWay, defaultValue: "", propertyChanged: (bindable, oldVal, newval) => {
            var matEntry = (FloatingEntryView)bindable;
            matEntry.EntryField.Text = (string)newval;
        });
        //public static BindableProperty TextColorProperty = BindableProperty.Create(nameof(Text), typeof(Color), typeof(FloatingEntryView), defaultBindingMode: BindingMode.TwoWay, defaultValue: "", propertyChanged: (bindable, oldVal, newval) => {
        //    var matEntry = (FloatingEntryView)bindable;
        //    matEntry.EntryField.TextColor = (Color)newval;
        //});
        public static BindableProperty PlaceholderProperty = BindableProperty.Create(nameof(Placeholder), typeof(string), typeof(FloatingEntryView), defaultBindingMode: BindingMode.TwoWay, propertyChanged: (bindable, oldVal, newval) => {
            var matEntry = (FloatingEntryView)bindable;
            matEntry.EntryField.Placeholder = (string)newval;
            matEntry.HiddenLabel.Text = (string)newval;
        });
        public static BindableProperty IsPasswordProperty = BindableProperty.Create(nameof(IsPassword), typeof(bool), typeof(FloatingEntryView), defaultValue: false, propertyChanged: (bindable, oldVal, newVal) => {
            var matEntry = (FloatingEntryView)bindable;
            matEntry.EntryField.IsPassword = (bool)newVal;
        });
        public static BindableProperty ImgSourceProperty = BindableProperty.Create(nameof(ImgSource), typeof(string), typeof(FloatingEntryView), defaultValue: "", propertyChanged: (bindable, oldVal, newVal) =>
        {
            (bindable as FloatingEntryView).image.Source = newVal.ToString();
        });

        public FloatingEntryView()
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