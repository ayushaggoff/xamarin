using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using WeatherApplication.Control;
using WeatherApplication.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using static Android.Arch.Core.Internal.SafeIterableMap;
using Entry = Xamarin.Forms.Entry;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryRenderer))]
namespace WeatherApplication.Droid
{
    public class CustomEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {

                Control.Background = new ColorDrawable(Android.Graphics.Color.Transparent);
            }
        }
    }
}