using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Project
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.Detail = new Page1();
            
        }

        private void Btnsch_OnClicked(object sender, EventArgs e)
        {
           this.Detail = new Page2();
            IsPresented = false;
        }

        private void Btnhome_OnClicked(object sender, EventArgs e)
        {
            this.Detail = new Page1();
            IsPresented = false;
        }

        private void Btnsec_OnClicked(object sender, EventArgs e)
        {
            this.Detail = new Page3();
            IsPresented = false;

        }

        private void TapGestureRecognizer_OnTapped(object sender, EventArgs e)
        {
            this.Detail = new Page4();
            IsPresented = false;
        }

        private void TapGestureRecognizer_OnTapped1(object sender, EventArgs e)
        {
            this.Detail = new Page5();
            IsPresented = false;
        }

        private void TapGestureRecognizer_OnTapped2(object sender, EventArgs e)
        {
            this.Detail= new Page6();
            IsPresented = false;
        }
    }
}
