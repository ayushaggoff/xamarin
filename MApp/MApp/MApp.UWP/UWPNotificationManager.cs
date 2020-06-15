using Microsoft.Toolkit.Uwp.Notifications;
//using NotificationsExtensions.Toasts;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Notifications;
using Microsoft.QueryStringDotNET; // QueryString.NET
using System.Xml.Linq;

[assembly: Xamarin.Forms.Dependency(typeof(MApp.UWP.UWPNotificationManager))]
namespace MApp.UWP
{
    public class UWPNotificationManager : INotificationManager
    {
        string title = "Ayush  sent you a picture";
        string content = "Check this out, Happy Canyon in Utah!";
        string image = "https://picsum.photos/360/202?image=883";
        string logo = "ms-appdata:///local/Andrew.jpg";


        int messageId = -1;
        public event EventHandler NotificationReceived;

        public void Initialize()
        {
        }

        public void ReceiveNotification(string title, string message)
        {
            throw new NotImplementedException();
        }

        public int ScheduleNotification(string title, string message)
        {
            #region cdcwcwc
            ToastContent tc = new ToastContent()
            {
                Visual = new ToastVisual()
                {
                    BindingGeneric = new ToastBindingGeneric()
                    {
                        Children =
                        {
                            new AdaptiveText()
                            {
                                Text = title
                            },
                            new AdaptiveText()
                            {
                                Text = content
                            },
                            new AdaptiveImage()
                            {
                                 Source = image
                            }
                        },
                        AppLogoOverride = new ToastGenericAppLogo()
                        {
                            Source = logo,
                            HintCrop = ToastGenericAppLogoCrop.Circle
                        }
                    }
                }
            };


            //ToastActionsCustom actions = new ToastActionsCustom()
            //{
            //    Inputs =
            //    {
            //        new ToastTextBox("tbReply")
            //        {
            //            PlaceholderContent = "Type a response"
            //        }
            //    },
            //    Buttons =
            //    {
            //        new ToastButton("Reply", new QueryString()
            //        {
            //            { "action", "reply" },
            //            { "conversationId", messageId.ToString() }

            //        }.ToString())
            //        {
            //            ActivationType = ToastActivationType.Background,
            //            ImageUri = "Assets/Reply.png",

            //            // Reference the text box's ID in order to
            //            // place this button next to the text box
            //            TextBoxId = "tbReply"
            //        },

            //        new ToastButton("Like", new QueryString()
            //        {
            //            { "action", "like" },
            //            { "conversationId", messageId.ToString() }

            //        }.ToString())
            //        {
            //            ActivationType = ToastActivationType.Background
            //        },

            //        new ToastButton("View", new QueryString()
            //        {
            //            { "action", "viewImage" },
            //            { "imageUrl", image }

            //        }.ToString())
            //    }
            //};


            //ToastContent toastContent = new ToastContent()
            //{
            //    Visual = visual,
            //    Launch = new QueryString()
            //    {
            //        { "action", "viewConversation" },
            //        { "conversationId", messageId.ToString() }

            //    }.ToString()

            //};

            //          And create the toast notification
            // var toast = new ToastNotification(toastContent.GetXml());

            //ToastNotificationManager.CreateToastNotifier().Show(toast);


            var text = tc.GetContent();
            var xml = tc.GetXml();
            var toast = new ToastNotification(xml);
            ToastNotificationManager.CreateToastNotifier().Show(toast);




            #endregion




            //var xmdock = CreateToast();
            //var toast = new ToastNotification(xmdock);
            //var notifi = Windows.UI.Notifications.ToastNotificationManager.CreateToastNotifier();
            //notifi.Show(toast);



            return messageId;
        }


        public static Windows.Data.Xml.Dom.XmlDocument CreateToast()
        {
            var xDoc = new XDocument(
               new XElement("toast",
               new XElement("visual",
               new XElement("binding", new XAttribute("template", "ToastGeneric"),
               new XElement("text", "C# Corner"),
               new XElement("text", "Do you got MVP award?")
            )
            ),// actions    
            new XElement("actions",
            new XElement("action", new XAttribute("activationType", "background"),
            new XAttribute("content", "Yes"), new XAttribute("arguments", "yes")),
            new XElement("action", new XAttribute("activationType", "background"),
            new XAttribute("content", "No"), new XAttribute("arguments", "no"))
            )
            )
            );

            var xmlDoc = new Windows.Data.Xml.Dom.XmlDocument();
            xmlDoc.LoadXml(xDoc.ToString());
            return xmlDoc;
        }

    } 

}
