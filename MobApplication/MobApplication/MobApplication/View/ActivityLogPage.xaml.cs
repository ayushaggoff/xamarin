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
                new ActivityLog{ Name="Ayush Aggarwal",PrevStatus="On Hold",CurrStatus="In Progress",Id="FED 89045",Image="pp.png" },
                new ActivityLog{ Name="Aashish",PrevStatus="Not Started",CurrStatus="In Progress",Id="FED 89045" ,Image="pp16.png"}
            };

            List<ActivityLog> BList = new List<ActivityLog>
            {
                new ActivityLog{ Name="Bilu",PrevStatus="On Hold",CurrStatus="In Progress",Id="FED 89045",Image="pp5.png" },
                new ActivityLog{ Name="Bhupender",PrevStatus="Not Started",CurrStatus="In Progress",Id="FED 89045" ,Image="pp6.png"}
            };


            List<ActivityLog> DList = new List<ActivityLog>
            {
                new ActivityLog{ Name="Deepak",PrevStatus="In Progress",CurrStatus="Completed",Id="FED 89045",Image="pp7.png "},
                new ActivityLog{ Name="Davinder Singh",PrevStatus="On Hold",CurrStatus="In Progress",Id="FED 89045",Image="pp8.png" },
                new ActivityLog{ Name="Dharam",PrevStatus="Not Started",CurrStatus="In Progress",Id="FED 89045",Image="pp9.png" },
                new ActivityLog{ Name="Devendra",PrevStatus="On Hold",CurrStatus="In Progress",Id="FED 89045",Image="pp10.png" },
                new ActivityLog{ Name="Divyansh",PrevStatus="In Progress",CurrStatus="Completed",Id="FED 89045" ,Image="pp11.png"}
            };

            List<ActivityLog> GList = new List<ActivityLog>
            {
                new ActivityLog{ Name="Gaurav Yadav",PrevStatus="Not Started",CurrStatus="In Progress",Id="FED 89045",Image="pp12.png" },
                new ActivityLog{ Name="Gautam Kumar",PrevStatus="In Progress",CurrStatus="Completed",Id="FED 89045",Image="pp13.png" },
                new ActivityLog{ Name="Ghanandra Pratap",PrevStatus="On Hold",CurrStatus="In Progress",Id="FED 89045",Image="pp14.png" },
                new ActivityLog{ Name="Gurpreet Singh",PrevStatus="On Hold",CurrStatus="In Progress",Id="FED 89045",Image="pp15.png" }
            };

            PList = new List<ActivityLog>
            {
                new ActivityLog{ Name="Prabhat",PrevStatus="Not Started",CurrStatus="In Progress",Id="FED 89045",Image="pp16.png" },
                new ActivityLog{ Name="Prashant",PrevStatus="In Progress",CurrStatus="Completed",Id="FED 89045" ,Image="pp3.png"},
                new ActivityLog{ Name="Prajwal",PrevStatus="In Progress",CurrStatus="Completed",Id="FED 89045" ,Image="pp4.png"}
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