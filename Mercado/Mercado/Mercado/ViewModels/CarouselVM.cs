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

namespace Mercado.ViewModels
{
    class CarouselVM : INotifyPropertyChanged
    {
        public ObservableCollection<Coupon> images { get; set; }
        public INavigation Navigation;
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
        public CarouselVM()
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

        }
        public ICommand TakePhoto => (new Command(async () => await displayCommand()));
        private async Task displayCommand()
        {
            var photo = await Plugin.Media.CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions() { });

            if (photo != null)
            {
                PhotoImage = photo.Path;

                OnPropertyChanged("PhotoImage");
                
              //  Models.ImageResult res = await VisionAPIService.MakeAnalysisRequest(photo.Path);

               
               

            }
            else { }

        }

        public event PropertyChangedEventHandler PropertyChanged;
        



        public void OnPropertyChanged([CallerMemberName]string name = "") =>

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));


    }

}
