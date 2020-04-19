using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;

namespace MobApplication.Model
{
    public class Weather: INotifyPropertyChanged
    {
        public string State { get; set; }
        public string WeatherCond { get; set; }
        public string Temprature { get; set; }
        public string ImageUrl { get; set; }
         Color _color;

        public event PropertyChangedEventHandler PropertyChanged;

        public Color bgColor 
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
                OnPropertyChanged("bgColor");
            }
        }


        private void OnPropertyChanged(string status)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(status));
            }
        }
    }
}
