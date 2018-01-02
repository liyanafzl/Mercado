using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Mercado.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyMasterPage : MasterDetailPage
    {
        public MyMasterPage()
        {
            InitializeComponent();
            List<string> l = new List<string>();
            l.Add("");
            NavList.ItemsSource = l;

        }

        public async void OnShopTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ShopDetail());
        }
        public async void OnAboutTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AboutPage());
        }
    }     
}