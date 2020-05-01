using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApplication.UWP;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;

[assembly: ExportRenderer(typeof(Entry), typeof(CustomEntryRenderer))]
namespace WeatherApplication.UWP
{
    public class CustomEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)

            {
                Control.BorderThickness = new Windows.UI.Xaml.Thickness(0);
                //Control.Padding = new Windows.UI.Xaml.Thickness(0);
                Control.BorderBrush.Opacity = 0;
            }
        }
    }
}
