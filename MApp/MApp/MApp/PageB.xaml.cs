using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageB : ContentPage
    {
        Data objData = new Data();
        public PageB()
        {
            InitializeComponent();
            MessagingCenter.Subscribe<Data>(this, "Hi", (value) => 
            {

            });
        }
    }
}