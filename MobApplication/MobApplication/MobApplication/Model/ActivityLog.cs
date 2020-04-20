using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;

namespace MobApplication.Model
{
    public class ActivityLog : INotifyPropertyChanged
    {
        public string Name { get; set; }
        public string PrevStatus { get; set; }
        public string CurrStatus { get; set; }

        public string Id { get; set; }
        public string Image { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;

        public Color PrevStatusColor
        {
            get
            {
                if (PrevStatus == "On Hold")
                {
                    return Color.Orange;
                }
                else if (PrevStatus == "Not Started")
                {
                    return Color.Red;
                }
                else if (PrevStatus == "In Progress")
                {
                    return Color.Red;
                }
                else
                {
                    return Color.Red;
                }
            }
        }
        public Color CurrStatusColor
        {
            get
            {
                if (CurrStatus == "On Hold")
                {
                    return Color.Orange;
                }
                else if (CurrStatus == "Not Started")
                {
                    return Color.Red;
                }
                else if (CurrStatus == "In Progress")
                {
                    return Color.Blue;
                }
                else
                {
                    return Color.LightGreen;
                }
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
