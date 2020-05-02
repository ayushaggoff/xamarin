using MobApplication.ModelView;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobApplication.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WeatherPage : ContentPage
    {
        public WeatherPage()
        {
            InitializeComponent();
            ObservableCollection<WeatherPage_ModelView> list = new ObservableCollection<WeatherPage_ModelView>
            {
                new WeatherPage_ModelView { State = "Sydney", WeatherCondition = "Sun", MinTemp = "20\u2103",MaxTemp = "12\u2103" ,Day="Thrusday"},
                new WeatherPage_ModelView { State = "Bangalore", WeatherCondition = "Sun", MinTemp = "28\u2103" ,MaxTemp = "15\u2103" ,Day="Friday"},
                new WeatherPage_ModelView { State = "London", WeatherCondition = "Rainy", MinTemp = "34\u2103",MaxTemp = "21\u2103" ,Day="Saturday"},
                new WeatherPage_ModelView { State = "New York", WeatherCondition = "Cloudy", MinTemp = "29\u2103",MaxTemp = "14\u2103" ,Day="Sunday"},
                new WeatherPage_ModelView { State = "London", WeatherCondition = "Rainy", MinTemp = "24\u2103",MaxTemp = "12\u2103" ,Day="Monday"},
                new WeatherPage_ModelView { State = "New York", WeatherCondition = "Cloudy", MinTemp = "19\u2103" ,MaxTemp = "13\u2103" ,Day="Tuesday"},
                new WeatherPage_ModelView { State = "London", WeatherCondition = "Rainy", MinTemp = "23\u2103" ,MaxTemp = "16\u2103" ,Day="Wednesday"}
               };
            
            
        }
    }
}