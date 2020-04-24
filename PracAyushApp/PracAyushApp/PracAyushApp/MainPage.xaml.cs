using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PracAyushApp
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
    }

    
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private const string Url = "https://jsonplaceholder.typicode.com/posts";
        private HttpClient _client = new HttpClient();
        private ObservableCollection<Post> _post;
       
        public MainPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            var content = await _client.GetStringAsync(Url);
            var posts = JsonConvert.DeserializeObject<List<Post>>(content);
            _post = new ObservableCollection<Post>(posts);
            postsListView.ItemsSource = _post;
            base.OnAppearing();
        }

        async void OnAdd(object sender, System.EventArgs e)
        {
            var post = new Post { Title = "Title" + DateTime.Now.Ticks };
            var content = JsonConvert.SerializeObject(post);
         await _client.PostAsync(Url,new StringContent(content));
            _post.Insert(0,post);
        }

       async void OnUpdate(object sender, System.EventArgs e)
        {
            var post = _post[0];
            post.Title = "Ayush Title is Updated";
            var content = JsonConvert.SerializeObject(post);
            await _client.PutAsync(Url+"/"+post.Id, new StringContent(content));
            
        }

        void OnDelete(object sender, System.EventArgs e)
        {
            var post = _post[0];
            _client.DeleteAsync(Url+"/"+post.Id);
            _post.Remove(post);

        }
    }
}
