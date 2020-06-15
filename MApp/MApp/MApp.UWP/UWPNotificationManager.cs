using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Notifications;




namespace MApp.UWP
{
    public class UWPNotificationManager : INotificationManager
    {
        public event EventHandler NotificationReceived;
        int messageId = -1;
        public void Initialize()
        {
            throw new NotImplementedException();
        }

        public void ReceiveNotification(string title, string message)
        {
            throw new NotImplementedException();
        }

        public int ScheduleNotification(string title, string message)
        {
                 messageId++;
                string TOAST = $@"<toast>
                  <visual>
                    <binding template='ToastGeneric'>
                      <text>{title}</text>
                      <text>{message}</text>
                    </binding>
                  </visual>
                  <audio src =""ms-winsoundevent:Notification.Mail"" loop=""true""/>
                </toast>";

                Windows.Data.Xml.Dom.XmlDocument xml = new Windows.Data.Xml.Dom.XmlDocument();
                xml.LoadXml(TOAST);

                ScheduledToastNotification toast = new ScheduledToastNotification(xml, DateTime.Now + TimeSpan.FromSeconds(3));
                toast.Id = "IdTostone" + messageId.ToString();
                toast.Tag = "NotificationOne";
                toast.Group = nameof(UWPNotificationManager);
                ToastNotificationManager.CreateToastNotifier().AddToSchedule(toast);

                return messageId;
            }
            
    }

}
