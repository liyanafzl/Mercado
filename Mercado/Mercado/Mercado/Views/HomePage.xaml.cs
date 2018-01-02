using Mercado.Models;
using Mercado.Services;
using Mercado.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Mercado.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomePage : ContentPage, INotifyPropertyChanged
	{
        public ObservableCollection<Coupon> images { get; set; }
        public ObservableCollection<Phone> PhoneImage { get; set; }
        private string photoImage;
        public string PhotoImage
        {


            get { return photoImage; }
            set
            {
                photoImage = value;
                OnPropertyChanged();

            }
        }
        private string _text { get; set; }
        public string text
        {


            get { return _text; }
            set
            {
                _text = value;
                OnPropertyChanged();

            }
        }
        public HomePage()
        {
            InitializeComponent();
            images = new ObservableCollection<Coupon>
            {   new Coupon
            {
                oneimage = "dress",
            },
            new Coupon
            {
               oneimage = "dress2"
            },
            new Coupon
            {
               oneimage = "dress3"
            }
        };
            OnPropertyChanged("text");
            PhoneImage = new ObservableCollection<Phone>
            {   new Phone
            {
                phone = "apple",
            },
            new Phone
            {
               phone = "phone1"
            },
            new Phone
            {
               phone = "iphone"
            }

        };
            cview.ItemsSource = images;
            cviews.ItemsSource = PhoneImage;
        }

        public async void SCommand(object s, EventArgs e)
        {

            ObservableCollection<Shop> l = new ObservableCollection<Shop>();
            var user = new UserService();
            text = SearchTab.Text;
            l = await user.SearchShop(text);
            await Navigation.PushAsync(new ListPage(l));
        }
        public async void ViewButton(object s, EventArgs e)
        {
            ObservableCollection<Shop> l = new ObservableCollection<Shop>();
            var user = new UserService();
            l = await user.GetShopList();
            await Navigation.PushAsync(new ListPage(l));
        }
        
        
       
	}
}