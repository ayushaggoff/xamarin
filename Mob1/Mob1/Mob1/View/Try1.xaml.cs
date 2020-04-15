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
    public partial class Try1 : ContentPage
    {
        public Try1()
        {
            InitializeComponent();
            //List<string> Item = new List<string> { "Ayush","Aggarwal"};
            BindableLayout.SetItemsSource(g1, new List<string> { "Ayush" } );
            BindableLayout.SetItemsSource(g1, new List<string> { "Ayededed" } );
        }
    }
}