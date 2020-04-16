using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobApplication.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobApplication.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WeatherInformation : ContentPage
    {
        ViewCell lastCell;
        ObservableCollection<Weather> list = new ObservableCollection<Weather>();
        public WeatherInformation()
        {
            InitializeComponent();
          
             list = new ObservableCollection<Weather>
            {
            new Weather{ State="Berlin", WeatherCond="Snowing",Temprature="0\u2103" ,ImageUrl="https://img.icons8.com/offices/40/000000/snow.png"},
            new Weather { State="Bangalore", WeatherCond="Thunderstorms",Temprature="23\u2103",ImageUrl="https://img.icons8.com/offices/40/000000/storm.png" },
            new Weather { State="London", WeatherCond="Rainy",Temprature="5\u2103" ,ImageUrl="https://img.icons8.com/offices/40/000000/downpour.png"},
            new Weather { State="New York", WeatherCond="Cloudy",Temprature="18\u2103" ,ImageUrl="https://img.icons8.com/offices/40/000000/clouds.png"},
            new Weather { State="Sydney", WeatherCond="Sunny",Temprature="6\u2103" ,ImageUrl="https://img.icons8.com/offices/40/000000/sun.png"}
            };
            listView.ItemsSource = list;
            // BindableLayout.SetItemsSource(g1, list);
        }
        
        private void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            
            var state = e.SelectedItemIndex;
            //     list.RemoveAt(state);
           
        }

        private void listView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
        //    DisplayAlert("", "tab", "ok");
        }

        private void ViewCell_Tapped(object sender, EventArgs e)
        {
          
            if (lastCell != null)
                lastCell.View.BackgroundColor = Color.Transparent;
            var viewCell = (ViewCell)sender;
            if (viewCell.View != null)
            {
                viewCell.View.BackgroundColor = Color.Purple;
                lastCell = viewCell;
            }
        }
    }
}