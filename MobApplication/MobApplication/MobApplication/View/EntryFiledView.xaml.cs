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
        public static BindableProperty LabelTextProperty = BindableProperty.Create("LabelText",
            typeof(string), typeof(EntryFiledView),"",BindingMode.TwoWay,propertyChanged: LabelTextValueChanged);

        public static BindableProperty EntryTextProperty = BindableProperty.Create("LabelText",
            typeof(string), typeof(EntryFiledView), "", BindingMode.TwoWay, propertyChanged: EntryTextValueChanged);
        public EntryFiledView()
        {
            InitializeComponent();
        }
        public string LabelText
        {
            get { return (string)GetValue(LabelTextProperty); }
            set { SetValue(LabelTextProperty, value); }
        } 
        public string EntryText
        {
            get { return (string)GetValue(LabelTextProperty); }
            set { SetValue(LabelTextProperty, value); }
        }
        public static void LabelTextValueChanged(BindableObject bindable, object oldValue, object newValue)
        {
            (bindable as EntryFiledView).lblTitle.Text = Convert.ToString(newValue);
        }
        public static void EntryTextValueChanged(BindableObject bindable, object oldValue, object newValue)
        {
            (bindable as EntryFiledView).enttext.Text = Convert.ToString(newValue);
        }
        

    }
}