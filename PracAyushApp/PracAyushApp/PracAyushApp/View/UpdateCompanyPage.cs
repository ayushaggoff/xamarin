using PracAyushApp.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace PracAyushApp.View
{
    public class UpdateCompanyPage : ContentPage
    {
        private Entry _nameEntry;
        private Entry _addressEntry;
        private Button _updateButton;
        string _dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "myDB.db3");

        public UpdateCompanyPage()
        {
            StackLayout stackLayout = new StackLayout();
            _nameEntry = new Entry();
            _nameEntry.Keyboard = Keyboard.Text;
            _nameEntry.Placeholder = "Company Name";
            stackLayout.Children.Add(_nameEntry);
            _addressEntry = new Entry();
            _addressEntry.Keyboard = Keyboard.Text;
            _addressEntry.Placeholder = "Address";
            stackLayout.Children.Add(_addressEntry);
            _updateButton = new Button();
            _updateButton.Text = "Update";
            _updateButton.Clicked += _updateButton_Clicked;
            stackLayout.Children.Add(_updateButton);
            Content = stackLayout;
        }
        private async void _updateButton_Clicked(object sender, EventArgs e)
        {
            var db = new SQLiteConnection(_dbPath);
            db.CreateTable<Models.Company>();

            var maxPk = db.Table<Models.Company>().OrderByDescending(c => c.Id).FirstOrDefault();
            Models.Company company = new Models.Company()
            {
                Id = (maxPk == null ? 1 : maxPk.Id + 1),
                Name = _nameEntry.Text,
                Address = _addressEntry.Text
            };
            db.Insert(company);
            await DisplayAlert("", company.Name + "save", "ok");
            await Navigation.PopAsync();
        }

    }
}