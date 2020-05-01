using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApplication.ModelView;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WeatherApplication.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        ObservableCollection<WeatherModelView> list;
        public HomePage()
        {
            InitializeComponent();
           list = new ObservableCollection<WeatherModelView>
            {
                new WeatherModelView { State = "Sydney", WeatherCondition = "Sunny", MinTemp = "20\u2103",MaxTemp = "12\u2103" ,Day="Thrusday" ,Date="11"},
                new WeatherModelView { State = "Bangalore", WeatherCondition = "Sunny", MinTemp = "28\u2103" ,MaxTemp = "15\u2103" ,Day="Friday",Date="12"},
                new WeatherModelView { State = "London", WeatherCondition = "Windy", MinTemp = "34\u2103",MaxTemp = "21\u2103" ,Day="Saturday",Date="13"},
                new WeatherModelView { State = "New York", WeatherCondition = "Sunny", MinTemp = "29\u2103",MaxTemp = "14\u2103" ,Day="Sunday",Date="14"},
                new WeatherModelView { State = "London", WeatherCondition = "Sunny", MinTemp = "24\u2103",MaxTemp = "12\u2103" ,Day="Monday",Date="15"},
                new WeatherModelView { State = "New York", WeatherCondition = "Cloudy", MinTemp = "19\u2103" ,MaxTemp = "13\u2103" ,Day="Tuesday",Date="16"},
                new WeatherModelView { State = "London", WeatherCondition = "Sunny", MinTemp = "23\u2103" ,MaxTemp = "16\u2103" ,Day="Wednesday",Date="17"}
               };
            Lbl_CurrentState.Text = list[0].State;
            Lbl_CurrentWeatherCondition.Text = list[0].WeatherCondition;
            int pos = list[0].MinTemp.IndexOf("\u2103");
            string minTemp = list[0].MinTemp.Remove(pos);
            string maxTemp = list[0].MaxTemp.Remove(pos);
            int averageTemp = (int.Parse(maxTemp) + int.Parse(minTemp)) / 2;
            Lbl_CurrentAverageTemp.Text = averageTemp.ToString();
            Lbl_CurrentDay.Text = list[0].Day;
            Lbl_CurrentMinTemp.Text = list[0].MinTemp;
            Lbl_CurrentMaxTemp.Text = list[0].MaxTemp;
            abcList.ItemsSource = list;
            listView.ItemsSource= list;
        }
        private void CollectionList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var previous = e.PreviousSelection;
            var current = e.CurrentSelection;
            if (e.CurrentSelection.Count != 0)
            {
                var data = e.CurrentSelection[0] as WeatherModelView;
                int pos = data.MinTemp.IndexOf("\u2103");
                string minTemp = data.MinTemp.Remove(pos);
                string maxTemp = data.MaxTemp.Remove(pos);

                int averageTemp = (int.Parse(maxTemp) + int.Parse(minTemp)) / 2;
                Lbl_CurrentState.Text = data.State;
                Lbl_CurrentWeatherCondition.Text = data.WeatherCondition;
                Lbl_CurrentAverageTemp.Text = averageTemp.ToString();
                Lbl_CurrentDay.Text = data.Day;
                Lbl_CurrentMinTemp.Text = data.MinTemp;
                Lbl_CurrentMaxTemp.Text = data.MaxTemp;
                //state.Date = "Now";
                //list.Append(state);
            }
        }
    }
}