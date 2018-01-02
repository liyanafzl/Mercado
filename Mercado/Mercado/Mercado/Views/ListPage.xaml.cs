using Mercado.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
		public ListPage (ObservableCollection<Shop> l)
		{
			InitializeComponent ();
            ShopList.ItemsSource = l;
           // List<Shop> l = new List<Shop>();
            
            //ShopList.ItemsSource() = l;
		}
	}
}