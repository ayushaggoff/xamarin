using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TryApp
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
    }

  
    public partial class PracRestFullService : ContentPage
    {
        private const string Url = "https://jsonplaceholder.typicode.com/posts";
        private HttpClient _client=new HttpClient();
        private ObservableCollection<Post> _post;
        public PracRestFullService()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
           var content=await _client.GetStringAsync(Url);
          var posts=JsonConvert.DeserializeObject<List<Post>>(content);
            _post = new ObservableCollection<Post>(posts);
            postsListView.ItemsSource = _post;
            base.OnAppearing();
        }

        void OnAdd(object sender, System.EventArgs e)
        {
        }

        void OnUpdate(object sender, System.EventArgs e)
        {
        }

        void OnDelete(object sender, System.EventArgs e)
        {
        }
    }
}