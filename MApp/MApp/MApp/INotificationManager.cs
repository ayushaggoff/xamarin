﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MApp
{
    public interface INotificationManager
    {
        event EventHandler NotificationReceived;

        void Initialize();

        int ScheduleNotification(string title, string message);

        void ReceiveNotification(string title, string message);
    }

}
