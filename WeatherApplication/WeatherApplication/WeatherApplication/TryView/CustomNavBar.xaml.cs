using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WeatherApplication.TryView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomNavBar : ContentView
    {
        public static readonly BindableProperty LabelTitleTextProperty = BindableProperty.Create("Title_Text",
           typeof(string), typeof(CustomNavBar), "", BindingMode.TwoWay, propertyChanged: LabelTitleTextValueChanged); 
        
        public static readonly BindableProperty LabelTitleTextColorProperty = BindableProperty.Create("Title_TextColor",
           typeof(string), typeof(CustomNavBar), "", BindingMode.TwoWay, propertyChanged: LabelTitleTextColorValueChanged); 
        
        public static readonly BindableProperty LabelTitleBackgroundColorProperty = BindableProperty.Create("Title_BackgroundColor",
           typeof(string), typeof(CustomNavBar), "", BindingMode.TwoWay, propertyChanged: LabelTitleBackgroundColorValueChanged);

        public static readonly BindableProperty BtnLeftImageSourceProperty = BindableProperty.Create("LeftImage_Source",
           typeof(string), typeof(CustomNavBar), "", BindingMode.TwoWay, propertyChanged: BtnLeftImageSourcePropertyValueChanged);

        public static readonly BindableProperty BtnRightImg2SourceProperty = BindableProperty.Create("RightImage2_Source",
            typeof(string), typeof(CustomNavBar), "", BindingMode.TwoWay, propertyChanged: BtnRightImg2SourcePropertyValueChanged);

        public static readonly BindableProperty BtnRightImg1SourceProperty = BindableProperty.Create("RightImage1_Source",
           typeof(string), typeof(CustomNavBar), "", BindingMode.TwoWay, propertyChanged: BtnRightImg1SourcePropertyValueChanged);


        public static readonly BindableProperty GridNavBarBackgroundProperty = BindableProperty.Create("NavBar_Background",
           typeof(string), typeof(CustomNavBar), "", BindingMode.TwoWay, propertyChanged: GridNavBarBackgroundPropertyValueChanged);


        public static readonly BindableProperty CommandLeftImageProperty = BindableProperty.Create(nameof(Command_LeftImage),
            typeof(ICommand),
            typeof(CustomNavBar),
            default(ICommand));

        public static readonly BindableProperty CommandRightImage1Property = BindableProperty.Create(nameof(Command_RightImage1),
            typeof(ICommand),
            typeof(CustomNavBar),
            default(ICommand));

        public static readonly BindableProperty CommandRightImage2Property = BindableProperty.Create(nameof(Command_RightImage2),
            typeof(ICommand),
            typeof(CustomNavBar),
            default(ICommand));


        public static readonly BindableProperty CommandParameterLeftImageProperty = BindableProperty.Create(nameof(CommandParameter_LeftImage),
        typeof(object),
        typeof(CustomNavBar));
        public static readonly BindableProperty CommandParameterRightImage1Property = BindableProperty.Create(nameof(CommandParameter_RightImage1),
        typeof(object),
        typeof(CustomNavBar));
        public static readonly BindableProperty CommandParameterRightImage2Property = BindableProperty.Create(nameof(CommandParameter_RightImage2),
        typeof(object),
        typeof(CustomNavBar));
        public CustomNavBar()
        {
            InitializeComponent();

            Content.BindingContext = this;
        }

        public ICommand Command_LeftImage
        {
            get => (ICommand)GetValue(CommandLeftImageProperty);
            set => SetValue(CommandLeftImageProperty, value);
        }
        public ICommand Command_RightImage1
        {
            get => (ICommand)GetValue(CommandRightImage1Property);
            set => SetValue(CommandRightImage1Property, value);
        }
        public ICommand Command_RightImage2
        {
            get => (ICommand)GetValue(CommandRightImage2Property);
            set => SetValue(CommandRightImage2Property, value);
        }
        public object CommandParameter_LeftImage
        {
            get => GetValue(CommandParameterLeftImageProperty);
            set => SetValue(CommandParameterLeftImageProperty, value);
        }
        public object CommandParameter_RightImage1
        {
            get => GetValue(CommandParameterRightImage1Property);
            set => SetValue(CommandParameterRightImage1Property, value);
        }
        public object CommandParameter_RightImage2
        {
            get => GetValue(CommandParameterRightImage2Property);
            set => SetValue(CommandParameterRightImage2Property, value);
        }
        public string Title_Text
        {
            get { return (string)GetValue(LabelTitleTextProperty); }
            set { SetValue(LabelTitleTextProperty, value); }
        }
        public string Title_TextColor
        {
            get { return (string)GetValue(LabelTitleTextColorProperty); }
            set { SetValue(LabelTitleTextColorProperty, value); }
        }
        public string Title_BackgroundColor
        {
            get { return (string)GetValue(LabelTitleBackgroundColorProperty); }
            set { SetValue(LabelTitleBackgroundColorProperty, value); }
        }
        public string LeftImage_Source
        {
            get { return (string)GetValue(BtnLeftImageSourceProperty); }
            set { SetValue(BtnLeftImageSourceProperty, value); }
        }
        public string RightImage1_Source
        {
            get { return (string)GetValue(BtnRightImg1SourceProperty); }
            set { SetValue(BtnRightImg1SourceProperty, value); }
        }
        public string RightImage2_Source
        {
            get { return (string)GetValue(BtnRightImg2SourceProperty); }
            set { SetValue(BtnRightImg2SourceProperty, value); }
        }
        public string NavBar_Background
        {
            get { return (string)GetValue(GridNavBarBackgroundProperty); }
            set { SetValue(GridNavBarBackgroundProperty, value); }
        }

        public static void LabelTitleTextValueChanged(BindableObject bindable, object oldValue, object newValue)
        {
            (bindable as CustomNavBar).Lbl_Title.Text = Convert.ToString(newValue);
        }
        public static void LabelTitleTextColorValueChanged(BindableObject bindable, object oldValue, object newValue)
        {
            (bindable as CustomNavBar).Lbl_Title.TextColor =(Color)newValue;
        }
        public static void LabelTitleBackgroundColorValueChanged(BindableObject bindable, object oldValue, object newValue)
        {
            (bindable as CustomNavBar).Lbl_Title.BackgroundColor = (Color)newValue;
        }
        public static void BtnLeftImageSourcePropertyValueChanged(BindableObject bindable, object oldValue, object newValue)
        {
            (bindable as CustomNavBar).Btn_LeftImg.Source= Convert.ToString(newValue);
        }
        public static void BtnRightImg1SourcePropertyValueChanged(BindableObject bindable, object oldValue, object newValue)
        {
            (bindable as CustomNavBar).Btn_RightImg1.Source = Convert.ToString(newValue);
        }
        public static void BtnRightImg2SourcePropertyValueChanged(BindableObject bindable, object oldValue, object newValue)
        {
            (bindable as CustomNavBar).Btn_RightImg2.Source = Convert.ToString(newValue);
        }
        public static void GridNavBarBackgroundPropertyValueChanged(BindableObject bindable, object oldValue, object newValue)
        {
            (bindable as CustomNavBar).NavBar.BackgroundColor = (Color)newValue;
        }

    }
}