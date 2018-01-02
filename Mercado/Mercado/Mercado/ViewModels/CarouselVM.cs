using Mercado.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;
using Mercado.Views;
using System.Windows.Input;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.Net.Http;
using System.IO;
using Mercado.Services;

namespace Mercado.ViewModels
{
    class CarouselVM : INotifyPropertyChanged
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
        INavigation _navigation;
        public CarouselVM(INavigation navigation)
        {
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
                phone = "dress",
            },
            new Phone
            {
               phone = "dress2"
            },
            new Phone
            {
               phone = "dress3"
            }
            
        };
            _navigation = navigation;

        }
        public ICommand  SCommand => (new Command(async () => await displayCommand()));
        private async Task displayCommand()
        {
            
            ObservableCollection<Shop> l = new ObservableCollection<Shop>();
            var user = new UserService();
           l =  await  user.SearchShop(text);
            await _navigation.PushAsync(new ListPage(l));

        }
        //{
        //public ICommand TakePhoto => (new Command(async () => await displayCommand()));
        //private async Task displayCommand()
        //{
        //    var photo = await Plugin.Media.CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions() { });

        //    if (photo != null)
        //    {
        //        PhotoImage = photo.Path;

        //        OnPropertyChanged("PhotoImage");
        //        //byte[] bytes = PhotoImage;
        //        //ByteArrayContent stream = new ByteArrayContent(bytes);
        //        //MultipartFormDataContent content = new MultipartFormDataContent();
        //        //stream.Headers.Add(“Content-Type”, fileproperties.mimetype);
        //        //string res = AiService.




        //    }
        //    else { }

        //}

        public event PropertyChangedEventHandler PropertyChanged;
       
        public void OnPropertyChanged([CallerMemberName]string name = "") =>

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));


    }

}
