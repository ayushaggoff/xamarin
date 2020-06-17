using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageA : ContentPage
    {
        private string _tickContract = "tick";
        public ObservableCollection<string> Events { get; set; } = new ObservableCollection<string>();
        public PageA()
        {
            InitializeComponent(); BindingContext = this;
        }
        void HandleSender_Clicked(object sender, System.EventArgs e)
        {
            MessagingCenter.Send(this, _tickContract, DateTime.Now);
        }
        void HandleReceiver_Clicked(object sender, EventArgs args)
        {
            MessagingCenter.Subscribe<MainPage, DateTime>(this, _tickContract, (s, a) => {
                Events.Add($"Received message at {a.ToString()}");
            });
        }
        void HandleClear_Clicked(object sender, EventArgs args)
        {
            Events.Clear();
        }
    }
}