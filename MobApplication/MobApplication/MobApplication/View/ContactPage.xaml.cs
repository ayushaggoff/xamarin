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
    public partial class ContactPage : ContentPage
    {
        ObservableCollection<Contact> ContactList = new ObservableCollection<Contact>
        { 
        new Contact{ Name="Ayush Aggarwal",Number="9736826298" },
        new Contact{ Name="Shyam Singh",Number="9682629800" },
        new Contact{ Name="Raghav Aggarwal",Number="9736806208" },
        new Contact{ Name="Aashish Jain",Number="8736826288" },
        new Contact{ Name="Prabhat Kumar",Number="7736824248" },
        new Contact{ Name="John Bh",Number="9436824292" },
        new Contact{ Name="Kartik Ag",Number="7363226228" },
        new Contact{ Name="Probal Mukherjee",Number="7336826211" },
        new Contact{ Name="Bharat Kumar",Number="8736823201" },
        new Contact{ Name="Ravi Singh",Number="9734126298" },
        new Contact{ Name="Praveen Aggarwal",Number="8736426231" },
        new Contact{ Name="Shivam kumar",Number="9936823298" },new Contact{ Name="Praveen Aggaral",Number="8736426231" },
        new Contact{ Name="Shivam kumar",Number="9936823298" },new Contact{ Name="Praveen Aggarwal",Number="8736426231" },
        new Contact{ Name="Shivam kumar",Number="9936823298" },new Contact{ Name="Praveen Aggarwal",Number="8736426231" },
        new Contact{ Name="Shivam kumar",Number="9936823298" },new Contact{ Name="Praveen Aggarwal",Number="8736426231" },
        new Contact{ Name="Shivam kumar",Number="9936823298" },new Contact{ Name="Praveen Aggarwal",Number="8736426231" },
        new Contact{ Name="Shivam kumar",Number="9936823298" },new Contact{ Name="Praveen Aggarwal",Number="8736426231" },
        new Contact{ Name="Shivam kumar",Number="9936823298" }
        };
        public ContactPage()
        {
            InitializeComponent();
            ContactListView.ItemsSource = ContactList;
        }

        private void DeleteItem_Clicked(object sender, EventArgs e)
        {
            var contact = (sender as MenuItem).CommandParameter as Contact;
            ContactList.Remove(contact);
        }
    }
}