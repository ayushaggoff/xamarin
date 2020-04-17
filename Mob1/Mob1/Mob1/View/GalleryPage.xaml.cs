using Mob1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Mob1.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GalleryPage : ContentPage
    {
        public string CustColor { get; set; }
        public GalleryPage()
        {
            InitializeComponent();
            
           // collectionList.SelectionChanged += CollectionList_SelectionChanged;
            var imageList = new List<Gallery>
            { 
            new Gallery{ Title="Ayush" ,ImageUrl="https://images.pexels.com/photos/1227520/pexels-photo-1227520.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500"},
            new Gallery{ Title="Aggarwal" ,ImageUrl="https://images.pexels.com/photos/207353/pexels-photo-207353.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500"}, 
            new Gallery{ Title="aaaaa" ,ImageUrl="https://images.pexels.com/photos/364096/pexels-photo-364096.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500"},
            new Gallery{ Title="sdsddsds" ,ImageUrl="https://images.pexels.com/photos/924633/pexels-photo-924633.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500"}, 
            new Gallery{ Title="frfgr" ,ImageUrl="https://images.pexels.com/photos/276092/pexels-photo-276092.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500"},
            new Gallery{ Title="edef" ,ImageUrl="https://images.pexels.com/photos/1590549/pexels-photo-1590549.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500"},
            new Gallery{ Title="eded" ,ImageUrl="https://images.pexels.com/photos/459335/pexels-photo-459335.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500"},
            new Gallery{ Title="fefwefe" ,ImageUrl="https://images.pexels.com/photos/544268/pexels-photo-544268.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500"},
            new Gallery{ Title="fefewdwd" ,ImageUrl="https://images.pexels.com/photos/1866690/pexels-photo-1866690.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500"}
            };
            CustColor = "White";
            collectionList.ItemsSource = imageList;
        }
        void OnCheckBoxCheckedChanged(object sender, CheckedChangedEventArgs e)
        {

        }
        private void CollectionList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var previous = e.CurrentSelection;
            var current = e.CurrentSelection;
            CustColor = "Green";
            
            if ((current.Count) > 0)
            {
                Btn_Save.Text = "Save";
            }
            else
            {
                Btn_Save.Text = "None";
            }
            string msg = "Selected Image \n";
            for (int i = 0; i < previous.Count; i++)
            {
                var image = previous[i] as Gallery;
               msg= msg +"\n"+$"{image.Title }"; 
            }
               DisplayAlert("", msg,"ok");
        }

        

    }
}