using Mercado.Models;
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
	public partial class ListPage : ContentPage
	{
		public ListPage ()
		{
			InitializeComponent ();
            Shop model = new Shop();
            model.shopName = "ABC";
           // List<Shop> l = new List<Shop>();
            
            //ShopList.ItemsSource() = l;
		}
	}
}