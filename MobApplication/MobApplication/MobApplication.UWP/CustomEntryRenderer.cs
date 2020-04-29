using MobApplication.UWP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobApplication.Control;
using Xamarin.Forms.Platform.UWP;
using Xamarin.Forms;
using Windows.UI.Xaml;

[assembly: ExportRenderer(typeof(Entry), typeof(CustomEntryRenderer))]
namespace MobApplication.UWP
{
    public class CustomEntryRenderer: EntryRenderer
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
