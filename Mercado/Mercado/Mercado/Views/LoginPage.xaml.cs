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
	public partial class LoginPage : ContentPage
	{
		public LoginPage ()
		{
			InitializeComponent ();
		}
        
       //public async void OnShopTapped(object s, EventArgs e)
       // {
            
       //     await Navigation.PushAsync(new SignUpPage());  
       // }
       public async void CreateClicked(object s, EventArgs e)
        {
             await Navigation.PushAsync(new SignUpPage());
        }
        public async void LoginOnClicked(object s, EventArgs e)
        {
            string str_user, str_pass;
             str_user = user.Text;
             str_pass = password.Text;
            if(str_user.StartsWith("MERC"))
            {
                await Navigation.PushAsync(new MyMasterPage());
                 
            }
            else
            {
                await Navigation.PushAsync(new MyMasterPage());
            }


        }



    }
}