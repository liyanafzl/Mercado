using Mercado.Models;
using Mercado.ViewModels;
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
	public partial class HomePage : ContentPage
	{
        INavigation navigation;
		public HomePage ()
		{
			InitializeComponent();
           
            BindingContext = new CarouselVM(navigation);
        }
       
	}
}