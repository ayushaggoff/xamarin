using MobApplication.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobApplication.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ActivityLogPage : ContentPage
    {
       
        List<ActivityLog> PList;
        List<ActivityLog> AList;
        public ActivityLogPage()
        {
            InitializeComponent();
            BindingContext =new ActivityLog();
             AList = new List<ActivityLog>
            {
                new ActivityLog{ Name="Ayush Aggarwal",Status="On Hold",Id="FED 89045",Image="p.jpg" },
                new ActivityLog{ Name="Aashish",Status="Not Started",Id="FED 89045" ,Image="p1.jpg"}
            };

            List<ActivityLog> BList = new List<ActivityLog>
            {
                new ActivityLog{ Name="Bilu",Status="On Hold",Id="FED 89045",Image="p5.jpg" },
                new ActivityLog{ Name="Bhupender",Status="Not Started",Id="FED 89045" ,Image="p6.jpg"}
            };


            List<ActivityLog> DList = new List<ActivityLog>
            {
                new ActivityLog{ Name="Deepak",Status="In Progress",Id="FED 89045",Image="p7.jpg" },
                new ActivityLog{ Name="Davinder Singh",Status="On Hold",Id="FED 89045",Image="p8.jpg" },
                new ActivityLog{ Name="Dharam",Status="Not Started",Id="FED 89045",Image="p9.jpg" },
                new ActivityLog{ Name="Devendra",Status="On Hold",Id="FED 89045",Image="p10.jpg" },
                new ActivityLog{ Name="Divyansh",Status="In Progress",Id="FED 89045" ,Image="p11.jpg"}
            };

            List<ActivityLog> GList = new List<ActivityLog>
            {
                new ActivityLog{ Name="Gaurav Yadav",Status="Not Started",Id="FED 89045",Image="p12.jpg" },
                new ActivityLog{ Name="Gautam Kumar",Status="In Progress",Id="FED 89045",Image="p13.jpg" },
                new ActivityLog{ Name="Ghanandra Pratap",Status="On Hold",Id="FED 89045",Image="p14.jpg" },
                new ActivityLog{ Name="Gurpreet Singh",Status="On Hold",Id="FED 89045",Image="p15.jpg" }
            };

            PList = new List<ActivityLog>
            {
                new ActivityLog{ Name="Prabhat",Status="Not Started",Id="FED 89045",Image="p16.jpg" },
                new ActivityLog{ Name="Prashant",Status="In Progress",Id="FED 89045" ,Image="p3.jpg"},
                new ActivityLog{ Name="Prajwal",Status="In Progress",Id="FED 89045" ,Image="p4.jpg"}
            };

            List<ActivityLogGroup> MainActivityList = new List<ActivityLogGroup>
            { 
                new ActivityLogGroup( "A",AList ),
                new ActivityLogGroup( "B",BList ),
                new ActivityLogGroup( "D",DList ),
                new ActivityLogGroup( "G",GList ),
                new ActivityLogGroup("P",PList )
            };

            listView.ItemsSource = MainActivityList;
        }

    }
}