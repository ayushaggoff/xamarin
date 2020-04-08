using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TryApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PracMasterDetail : MasterDetailPage
    {
        public PracMasterDetail()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Page1());
            IsPresented = false;
        }
        private void Button_Clicked2(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new PracTabbedPage());
            IsPresented = false;
        }
        private void Button_Clicked3(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new PracCarouselPage());
            IsPresented = false;
        }
    }
}