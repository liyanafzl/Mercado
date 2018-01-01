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
        public ObservableCollection<string> images { get; set; }
        public string im { get; set; }
            
        public CarouselVM()
        {
            images = new ObservableCollection<string>
            {   "logo.jpg",
               "icon.png"
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
