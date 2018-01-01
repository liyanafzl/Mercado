using Mercado.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace Mercado.ViewModels
{
    class CarouselVM : INotifyPropertyChanged
    {
        public ObservableCollection<Coupon> images { get; set; }
        
        public CarouselVM()
        {
            images = new ObservableCollection<Coupon>
            {   new Coupon
            {
                oneimage = "logo",
            },
            new Coupon
            {
               oneimage = "icon"
            }
            };
            

        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
