using MobApplication.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace MobApplication.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage1 : MasterDetailPage
    {
        public MainPage1()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            CVIndustries.ItemsSource = new List<Industry>()
            {
                new Industry{ ImageUrl="https://successive.tech/wp-content/uploads/2020/01/media_Thumbnails.png",Detail="The effective use of data based tools can power up marketing teams and amplify brand presence amongst your audience. "},
     new Industry { ImageUrl = "https://successive.tech/wp-content/uploads/2020/01/ecommerce_Thumbnails.png", Detail="Seamless omnichannel presence for your retail brand to augment customer loyalty and boost e-commerce toplines." },
     new Industry { ImageUrl = "https://successive.tech/wp-content/uploads/2020/01/Legal_Thumbnails.png", Detail="We enable an unbeatable combination of technology and legal acumen." },
     new Industry { ImageUrl = "https://successive.tech/wp-content/uploads/2020/01/agri_Thumbnails.png", Detail="We specialize in innovative tech-oriented business models that will drive massive ROI in the agriculture space." },
     new Industry { ImageUrl = "https://successive.tech/wp-content/uploads/2020/01/Fintech_Thumbnails.png", Detail="Disruptive software-driven services need our innovative customer-centric solutions." },
     new Industry { ImageUrl = "https://successive.tech/wp-content/uploads/2020/01/Logistics_Thumbnails.png", Detail="Transformation in transportation – infinite possibilities enabled at Successive." }
            };
        }
        private void Btn_Clicked(object sender, EventArgs e)
        {
            Login objlogin = new Login();
            var btn = (Button)sender;
            switch (btn.CommandParameter)
            {
                case "Home":
                    App.Current.MainPage = new MainPage1();
                    break;
                case "About Us":
                    contentview.Content = new View.AboutUs();
                    break;
                case "Project":
                    contentview.Content = new View.ProjectView.NETFacilitiesView();
                    TabBtnGrid.IsVisible = false;
                    ProjectBtnGrid.IsVisible = true;
                    break;
                case "BIM Network":
                    contentview.Content = new View.ProjectView.BIMNetworksView();
                    break;
                case "Display Now":
                    contentview.Content = new View.ProjectView.DisplayNowView();
                    break;
                case "Meeting Hub":
                    contentview.Content = new View.ProjectView.Meeting_HubView();
                    break;
                case "Contact Us":
                    contentview.Content = new View.contactus();
                    break;
                case "Careers":
                    contentview.Content = new View.CareersView();
                    break;
                case "Login":
                    contentview.Content = objlogin.Content;
                    //  App.Current.MainPage = new Login();
                    break;
            }
        }
    }
}