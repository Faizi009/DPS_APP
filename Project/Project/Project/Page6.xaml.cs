using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Project
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page6 : ContentPage
    {
        public Page6()
        {
            InitializeComponent();
            GetmovieeAsync();
        }

        private async void GetmovieeAsync()
        {
            HttpClient httpClient = new HttpClient();
            var show = await httpClient.GetStringAsync("http://dpsa.azurewebsites.net/api/alumni1");
            var data = JsonConvert.DeserializeObject<List<Models.front>>(show);
            Project.ItemsSource = data;
            // return moviee;
        }
    }
}