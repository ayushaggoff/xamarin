using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace MobApplication.Model
{
    public class ActivityLog : INotifyPropertyChanged
    {
        public string Name { get; set; }
        public string Status { get; set; }
        public string Id { get; set; }
        public string Image { get; set; }
        public bool _isCheck;
        public event PropertyChangedEventHandler PropertyChanged;

        public bool IsCheckOnHold
        {
            get
            {
                if (Status == "On Hold")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool IsCheckNotStarted
        {
            get
            {
                if (Status == "Not Started")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool IsCheckInProgress
        {
            get
            {
                if (Status == "In Progress")
                {
                    return true;
                }
                else
                {
                    return false;
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
