using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mercado.Models
{
    public class Coupons
    {
        public int _CouponId { get; set; }
        public int _InventoryId { get; set; }
        public int _UserId { get; set; } 
        public bool _Validity { get; set; }

        
        [JsonProperty(PropertyName = "CouponId")]
        public int CouponId
        {
            get { return _CouponId; }
            set { _CouponId = value; }
        }

        [JsonProperty(PropertyName = "InventoryId")]
        public int InventoryId
        {
            get { return _InventoryId; }
            set { _InventoryId = value; }
        }
        [JsonProperty(PropertyName = "UserId")]
        public int UserId
        {
            get { return _UserId; }
            set { _UserId = value; }
        }

        [JsonProperty(PropertyName = "Validity")]
        public bool Validity
        {
            get { return _Validity; }
            set { _Validity = value; }
        }

    }
}


