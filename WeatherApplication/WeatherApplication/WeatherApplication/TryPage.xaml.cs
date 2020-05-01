using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WeatherApplication
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TryPage : ContentPage
    {
        public TryPage()
        {
            InitializeComponent();
            
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            string fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), Ent_FileName.Text);
            bool doesExist = File.Exists(fileName);
            if (doesExist)
            {
            btn.IsVisible = false;
                DisplayAlert("", "File Exist in Local Storage ", "ok");
                Lbl_ShowFiledata.IsVisible = true;
                Lbl_ShowFiledata.Text = File.ReadAllText(fileName);
                btnEdit.IsVisible = true;
            }
            else
            {
                DisplayAlert("", "File Does not Exist ", "ok");
            }
        }
            private void Button_Edit(object sender, EventArgs e)
            {
            btnEdit.IsVisible = false;
            Lbl_ShowFiledata.IsVisible = false;
            Ent_ShowFiledata.IsVisible = true;
            Ent_ShowFiledata.Text = Lbl_ShowFiledata.Text;
            btnSave.IsVisible = true;
        }

        private void btnSave_Clicked(object sender, EventArgs e)
        {
            string fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), Ent_FileName.Text);
            File.WriteAllText(fileName, Ent_ShowFiledata.Text);
            btnSave.IsVisible = false;
            DisplayAlert("File Handling","File Edited","ok");
        }
    }
}