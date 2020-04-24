﻿using PracAyushApp.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace PracAyushApp.View
{
    public class AddCompanyPage : ContentPage
    {
        private Entry _nameEntry;
        private Entry _addressEntry;
        private Button _saveButton;
        string _dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal),"myDB.db3");
        public AddCompanyPage()
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
            _saveButton = new Button();
            _saveButton.Text = "Add";
            _saveButton.Clicked += _saveButton_Clicked;
            stackLayout.Children.Add(_saveButton);
            Content = stackLayout;

        }

        private async void _saveButton_Clicked(object sender, EventArgs e)
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
            await DisplayAlert("",company.Name +"save","ok");
            await Navigation.PopAsync();
        }
    }
}