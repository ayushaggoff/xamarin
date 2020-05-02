using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace WeatherApplication.ModelView
{
   public class WeatherModelView:INotifyPropertyChanged

    {
        private string _state;
        private string _imgSource;
        private string _day;
        private string _date;
        private string _weatherCondition;
        private string _minTemp;
        private string _maxTemp;
        public string State
        {
            get
            {
                return _state;
            }
            set
            {
                _state = value;
            }
        }
        public string ImgSource
        {
            get
            {
                return _imgSource;
            }
            set
            {
                _imgSource = value;
            }
        }
        public string Date
        {
            get
            {
                return _date;
            }
            set
            {
                _date = value;
            }
        }
        public string Day
        {
            get
            {
                return _day;
            }
            set
            {
                _day = value;
            }
        }
        public string WeatherCondition
        {
            get
            {
                return _weatherCondition;

            }
            set
            {
                _weatherCondition = value;

                if (_weatherCondition == "Sunny")
                {
                    ImgSource = "sun50.png";
                    OnPropertyChanged(ImgSource); 
                }
                else if (_weatherCondition == "Windy")
                {
                    ImgSource = "windy50.png";
                    OnPropertyChanged(ImgSource);

                }
                else if (_weatherCondition == "Cloudy")
                {
                    ImgSource = "cloudy.png";
                    OnPropertyChanged(ImgSource);

                }
                else
                {
                    ImgSource = "";
                    OnPropertyChanged(ImgSource);

                }
                _weatherCondition = value;
            }
        }
        public string MinTemp
        {
            get
            {
                return _minTemp;
            }
            set
            {
                _minTemp = value;
            }
        }
        public string MaxTemp
        {
            get
            {
                return _maxTemp;
            }
            set
            {
                _maxTemp = value;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string status)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(status));
            }
        }
    }
}
