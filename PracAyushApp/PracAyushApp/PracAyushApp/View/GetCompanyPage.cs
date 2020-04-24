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
    public class GetCompanyPage : ContentPage
    {
        ListView _listView = new ListView();
        string _dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "myDB.db3");

        public GetCompanyPage()
        {
            var db = new SQLiteConnection(_dbPath);
            StackLayout stackLayout = new StackLayout();
            _listView = new ListView();
            _listView.ItemsSource = db.Table<Company>().OrderBy(x => x.Name).ToList();
            stackLayout.Children.Add(_listView);
            Content = stackLayout;
        }
    }
}