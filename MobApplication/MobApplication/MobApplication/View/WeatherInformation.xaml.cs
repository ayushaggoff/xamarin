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
        Weather prevCellInfo;
        ViewCell lastCell;
        ObservableCollection<Weather> list = new ObservableCollection<Weather>
            {
            new Weather{ State="Berlin", WeatherCond="Snowing",Temprature="0\u2103" ,ImageUrl="https://img.icons8.com/offices/40/000000/snow.png"},
            new Weather { State="Bangalore", WeatherCond="Thunderstorms",Temprature="23\u2103",ImageUrl="https://img.icons8.com/offices/40/000000/storm.png" },
            new Weather { State="London", WeatherCond="Rainy",Temprature="5\u2103" ,ImageUrl="https://img.icons8.com/offices/40/000000/downpour.png"},
            new Weather { State="New York", WeatherCond="Cloudy",Temprature="18\u2103" ,ImageUrl="https://img.icons8.com/offices/40/000000/clouds.png"},
              new Weather { State="London", WeatherCond="Rainy",Temprature="5\u2103" ,ImageUrl="https://img.icons8.com/offices/40/000000/downpour.png"},
            new Weather { State="New York", WeatherCond="Cloudy",Temprature="18\u2103" ,ImageUrl="https://img.icons8.com/offices/40/000000/clouds.png"},
              new Weather { State="London", WeatherCond="Rainy",Temprature="5\u2103" ,ImageUrl="https://img.icons8.com/offices/40/000000/downpour.png"},
            new Weather { State="New York", WeatherCond="Cloudy",Temprature="18\u2103" ,ImageUrl="https://img.icons8.com/offices/40/000000/clouds.png"},
              new Weather { State="London1", WeatherCond="Rainy",Temprature="5\u2103" ,ImageUrl="https://img.icons8.com/offices/40/000000/downpour.png"},
            new Weather { State="New York2", WeatherCond="Cloudy",Temprature="18\u2103" ,ImageUrl="https://img.icons8.com/offices/40/000000/clouds.png"},
              new Weather { State="London3", WeatherCond="Rainy",Temprature="5\u2103" ,ImageUrl="https://img.icons8.com/offices/40/000000/downpour.png"},
                new Weather { State="London4", WeatherCond="Rainy",Temprature="5\u2103" ,ImageUrl="https://img.icons8.com/offices/40/000000/downpour.png"},
                  new Weather { State="London5", WeatherCond="Rainy",Temprature="5\u2103" ,ImageUrl="https://img.icons8.com/offices/40/000000/downpour.png"},
                    new Weather { State="London6", WeatherCond="Rainy",Temprature="5\u2103" ,ImageUrl="https://img.icons8.com/offices/40/000000/downpour.png"},
            new Weather { State="New York7", WeatherCond="Cloudy",Temprature="18\u2103" ,ImageUrl="https://img.icons8.com/offices/40/000000/clouds.png"},
              new Weather { State="London8", WeatherCond="Rainy",Temprature="5\u2103" ,ImageUrl="https://img.icons8.com/offices/40/000000/downpour.png"},
            new Weather { State="New York9", WeatherCond="Cloudy",Temprature="18\u2103" ,ImageUrl="https://img.icons8.com/offices/40/000000/clouds.png"},
              new Weather { State="London8", WeatherCond="Rainy",Temprature="5\u2103" ,ImageUrl="https://img.icons8.com/offices/40/000000/downpour.png"},
            new Weather { State="New York1", WeatherCond="Cloudy",Temprature="18\u2103" ,ImageUrl="https://img.icons8.com/offices/40/000000/clouds.png"},
              new Weather { State="London11", WeatherCond="Rainy",Temprature="5\u2103" ,ImageUrl="https://img.icons8.com/offices/40/000000/downpour.png"},
            new Weather { State="New York12", WeatherCond="Cloudy",Temprature="18\u2103" ,ImageUrl="https://img.icons8.com/offices/40/000000/clouds.png"},
              new Weather { State="London13", WeatherCond="Rainy",Temprature="5\u2103" ,ImageUrl="https://img.icons8.com/offices/40/000000/downpour.png"},
            new Weather { State="New York14", WeatherCond="Cloudy",Temprature="18\u2103" ,ImageUrl="https://img.icons8.com/offices/40/000000/clouds.png"},
              new Weather { State="London", WeatherCond="Rainy",Temprature="5\u2103" ,ImageUrl="https://img.icons8.com/offices/40/000000/downpour.png"},
            new Weather { State="New York", WeatherCond="Cloudy",Temprature="18\u2103" ,ImageUrl="https://img.icons8.com/offices/40/000000/clouds.png"},
              new Weather { State="London", WeatherCond="Rainy",Temprature="5\u2103" ,ImageUrl="https://img.icons8.com/offices/40/000000/downpour.png"},
                new Weather { State="London", WeatherCond="Rainy",Temprature="5\u2103" ,ImageUrl="https://img.icons8.com/offices/40/000000/downpour.png"},

            new Weather { State="New York", WeatherCond="Cloudy",Temprature="18\u2103" ,ImageUrl="https://img.icons8.com/offices/40/000000/clouds.png"},
            new Weather { State="New York", WeatherCond="Cloudy",Temprature="18\u2103" ,ImageUrl="https://img.icons8.com/offices/40/000000/clouds.png"},

            new Weather { State="New York", WeatherCond="Cloudy",Temprature="18\u2103" ,ImageUrl="https://img.icons8.com/offices/40/000000/clouds.png"},
            new Weather { State="New York", WeatherCond="Cloudy",Temprature="18\u2103" ,ImageUrl="https://img.icons8.com/offices/40/000000/clouds.png"},
            new Weather { State="New York", WeatherCond="Cloudy",Temprature="18\u2103" ,ImageUrl="https://img.icons8.com/offices/40/000000/clouds.png"},
            new Weather { State="Sydney", WeatherCond="Sunny",Temprature="6\u2103" ,ImageUrl="https://img.icons8.com/offices/40/000000/sun.png"}
            };
        public WeatherInformation()
        {
            InitializeComponent();

            BindingContext = new Weather();
            listView.ItemsSource = list;
            prevCellInfo = list[0];//
            // BindableLayout.SetItemsSource(g1, list);
        }

        private void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            
            var se = (ListView)sender;
            prevCellInfo.BgColor = Color.Transparent;
            int count = 0;
            prevCellInfo.BgColor = Color.Transparent;
            var data = e.SelectedItem as Weather;

            data.BgColor = Color.Red;
            prevCellInfo = data;
            //var state = e.SelectedItemIndex;
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

        private void listView_ItemSelected_1(object sender, SelectedItemChangedEventArgs e)
        {

        }

        private void listView_ItemAppearing(object sender, ItemVisibilityEventArgs e)
        {

        }
    }
}