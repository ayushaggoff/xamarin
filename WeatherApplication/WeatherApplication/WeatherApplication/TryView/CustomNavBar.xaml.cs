using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Markup;
using Xamarin.Forms.Xaml;

namespace WeatherApplication.TryView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomNavBar : ContentView
    {
        public static readonly BindableProperty LabelTitleTextProperty = BindableProperty.Create("Title_Text",
           typeof(string), typeof(CustomNavBar), "", BindingMode.TwoWay, propertyChanged: LabelTitleTextValueChanged);

        public static readonly BindableProperty LabelTitleTextColorProperty = BindableProperty.Create("Title_TextColor",
           typeof(Color), typeof(CustomNavBar),Color.Black, BindingMode.TwoWay, propertyChanged: LabelTitleTextColorValueChanged);

        public static readonly BindableProperty LabelTitleBackgroundColorProperty = BindableProperty.Create("Title_BackgroundColor",
           typeof(Color), typeof(CustomNavBar), Color.Transparent, BindingMode.TwoWay, propertyChanged: LabelTitleBackgroundColorValueChanged);

        public static readonly BindableProperty BtnLeftImageSourceProperty = BindableProperty.Create("LeftImage_Source",
           typeof(string), typeof(CustomNavBar), "", BindingMode.TwoWay, propertyChanged: BtnLeftImageSourcePropertyValueChanged);

        public static readonly BindableProperty BtnRightImg2SourceProperty = BindableProperty.Create("RightImage2_Source",
            typeof(string), typeof(CustomNavBar), "", BindingMode.TwoWay, propertyChanged: BtnRightImg2SourcePropertyValueChanged);

        public static readonly BindableProperty BtnRightImg1SourceProperty = BindableProperty.Create("RightImage1_Source",
           typeof(string), typeof(CustomNavBar), "", BindingMode.TwoWay, propertyChanged: BtnRightImg1SourcePropertyValueChanged);
        //public static BindableProperty CommandProperty = BindableProperty.Create("Command",
        //  typeof(ICommand),
        //  typeof(CustomNavBar), default(ICommand), BindingMode.TwoWay,
        //  propertyChanged: (bindable, oldVal, newval) => {
        //      var b = (bindable as CustomNavBar);
        //      b.Btn_LeftImg.Command = new Command(() =>
        //      {

        //          //if (b.Btn_LeftImg.Command != null)
        //          //{
        //          //    Clicked?.Invoke(this, EventArgs.Empty);
        //          //    if (b.Btn_LeftImg.Command.CanExecute("test"))
        //          //    {
        //          //        b.Btn_LeftImg.Command.Execute("test");

        //          //        return;
        //          //    }
        //          //}

        //      });
        //  });

        //public static BindableProperty CommandLeftImageProperty = BindableProperty.Create("Command",
        //    typeof(ICommand),
        //    typeof(CustomNavBar),BindingMode.TwoWay,
        //    propertyChanged: (bindable, oldVal, newval) => {
        //        var b = (bindable as CustomNavBar);
        //        b.Btn_LeftImg.Command = new Command(() =>
        //        {
        //            if (b.Btn_LeftImg.Command != null)
        //            {
        //                if (b.Btn_LeftImg.Command.CanExecute(""))
        //                    b.Btn_LeftImg.Command.Execute("");
        //            }

        //        });
        //    });
        public static void LeftButtonCommandPropertyChanged(object bindable,object  oldVal,object newval)
        {

        }


        public static BindableProperty TestCommandProperty = BindableProperty.Create("TestCommand",
          typeof(ICommand),
         typeof(CustomNavBar), null,propertyChanged: LeftButtonCommandPropertyChanged);

        public static readonly BindableProperty CommandRightImageOneProperty = BindableProperty.Create("Command_RightImageOne",
            typeof(ICommand),
            typeof(CustomNavBar),
            null);

        public static readonly BindableProperty CommandRightImage2Property = BindableProperty.Create(nameof(Command_RightImage2),
            typeof(ICommand),
            typeof(CustomNavBar),
            default(ICommand));


        public static readonly BindableProperty CommandParameterLeftImageProperty = BindableProperty.Create(nameof(CommandParameter_LeftImage),
        typeof(object),
        typeof(CustomNavBar));
        public static readonly BindableProperty CommandParameterRightImageOneProperty = BindableProperty.Create(nameof(CommandParameter_RightImageOne),
        typeof(object),
        typeof(CustomNavBar));
        public static readonly BindableProperty CommandParameterRightImage2Property = BindableProperty.Create(nameof(CommandParameter_RightImage2),
        typeof(object),
        typeof(CustomNavBar));
        public static event EventHandler Clicked ; 
        public CustomNavBar()
        {
            InitializeComponent();

           // TapGestureRecognizer tap = new TapGestureRecognizer();
           // tap.BindCommand("TestCommand");
            //Btn_LeftImg.GestureRecognizers.Add(new TapGestureRecognizer
            //{
            //    Command = new Command(() =>
            //    {
            //        Clicked?.Invoke(this, EventArgs.Empty);
            //        if (Command != null)
            //        {
            //            if (Command.CanExecute(CommandParameter_LeftImage))
            //                Command.Execute(CommandParameter_LeftImage);
            //        }

            //    })
            //});


            //Btn_RightImg1.GestureRecognizers.Add(new TapGestureRecognizer
            //{
            //    Command = new Command(() =>
            //    {
            //        Clicked?.Invoke(this, EventArgs.Empty);
            //        if (Command != null)
            //        {
            //            if (Command.CanExecute(CommandParameter_RightImageOne))
            //                Command.Execute(CommandParameter_RightImageOne);
            //        }

            //    })
            //});

        }

        //public ICommand Command 
        //{
        //    get => (ICommand)GetValue(CommandProperty);
        //    set => SetValue(CommandProperty, value);
        //}
        //public ICommand Command_LeftImage
        //{
        //    get => (ICommand)GetValue(CommandLeftImageProperty);
        //    set => SetValue(CommandLeftImageProperty, value);
        //}
        public ICommand TestCommand
        {
            get => (ICommand)GetValue(TestCommandProperty);
            set => SetValue(TestCommandProperty, value);
        }
        public ICommand Command_RightImage2
        {
            get => (ICommand)GetValue(CommandRightImage2Property);
            set => SetValue(CommandRightImage2Property, value);
        }
        public Object CommandParameter_LeftImage
        {
            get => GetValue(CommandParameterLeftImageProperty);
            set => SetValue(CommandParameterLeftImageProperty, value);
        }
        public object CommandParameter_RightImageOne
        {
            get => GetValue(CommandParameterRightImageOneProperty);
            set => SetValue(CommandParameterRightImageOneProperty, value);
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
        public Color Title_TextColor
        {
            get { return (Color)GetValue(LabelTitleTextColorProperty); }
            set { SetValue(LabelTitleTextColorProperty, value); }
        }
        public Color Title_BackgroundColor
        {
            get { return (Color)GetValue(LabelTitleBackgroundColorProperty); }
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
        public LayoutOptions Title_HorizontalOption
        {
            get 
            { 
                return (LayoutOptions)GetValue(BtnRightImg2SourceProperty); 
            }
            set { 
                SetValue(BtnRightImg2SourceProperty, value);
                if (value.Alignment.ToString() == "Start")
                {
                    Lbl_LeftTitle.IsVisible = true;
                    Lbl_Title.IsVisible = false;
                }
                else
                {
                    Lbl_LeftTitle.IsVisible = false;
                    Lbl_Title.IsVisible = true;
                }
            }
        }


        public static void LabelTitleTextValueChanged(BindableObject bindable, object oldValue, object newValue)
        {
            (bindable as CustomNavBar).Lbl_Title.Text = Convert.ToString(newValue);
            (bindable as CustomNavBar).Lbl_LeftTitle.Text = Convert.ToString(newValue);
        }
        public static void LabelTitleTextColorValueChanged(BindableObject bindable, object oldValue, object newValue)
        {
            (bindable as CustomNavBar).Lbl_Title.TextColor =(Color)(newValue);
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
      

    }
}