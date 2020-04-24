using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PracAyushApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            this.Title = "Select Option";
            StackLayout stackLayout = new StackLayout();
            Button addButton = new Button();
            addButton.Text = "Add Company";
            addButton.Clicked += AddButton_Clicked;
            stackLayout.Children.Add(addButton);
            Button getButton = new Button();
            getButton.Text = "Get Company List";
            getButton.Clicked += GetButton_Clicked;
            stackLayout.Children.Add(getButton);

            Button updateButton = new Button();
            updateButton.Text = "Update Company Detail";
            updateButton.Clicked += UpdateButton_Clicked;
            stackLayout.Children.Add(updateButton);
            Button deleteButton = new Button();
            deleteButton.Text = "Delete Company";
            deleteButton.Clicked += DeleteButton_Clicked;
            stackLayout.Children.Add(deleteButton);
            Content = stackLayout;
        }

        private async void AddButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddCompanyPage());
        }
        private async void GetButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GetCompanyPage());
        }
        private async void UpdateButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new UpdateCompanyPage());
        }
        private async void DeleteButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddCompanyPage());
        }
    }
}