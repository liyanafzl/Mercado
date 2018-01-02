using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mercado.Models
{
   public class Shop
    {
        public int _ShopId { get; set; }
        public string _ShopName { get; set; }
        public double _Latitude { get; set; }
        public double _Longitude { get; set; }
        public int _Rating { get; set; }

        [JsonProperty(PropertyName = "ShopId")]
        public int ShopId
        {
            get { return _ShopId; }
            set { _ShopId = value; }
        }

        [JsonProperty(PropertyName = "ShopName")]
        public string ShopName
        {
            get { return _ShopName; }
            set { _ShopName = value; }
        }

        [JsonProperty(PropertyName = "Latitude")]
        public double Latitude
        {
            get { return _Latitude; }
            set { _Latitude = value; }
        }

        [JsonProperty(PropertyName = "Longitude")]
        public double Longitude
        {
            get { return _Longitude; }
            set { _Longitude = value; }
        }

    }
}
