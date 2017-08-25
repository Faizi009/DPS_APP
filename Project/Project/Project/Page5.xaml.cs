using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Project
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page5 : ContentPage
    {
        public Page5()
        {
            InitializeComponent();
        }

        private void Btnreg_OnClicked(object sender, EventArgs e)
        {
            Models.front fon = new Models.front
            {
                Name = entuser.Text,
                Address = pass.Text,
                Session = sess.Text,
                Mail = Emno.Text,
            };

            HttpClient httpClient = new HttpClient();
            var jason = JsonConvert.SerializeObject(fon);
            HttpContent httpContent = new StringContent(jason);
            httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            httpClient.PostAsync("http://dpsa.azurewebsites.net/api/alumni1", httpContent);

        }
    }
}