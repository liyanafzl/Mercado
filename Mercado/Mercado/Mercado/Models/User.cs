using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mercado.Models
{
    class User
    {
        public int _UserId { get; set; }
        public string _UserName { get; set; }
        public string _Password { get; set; }

        [JsonProperty(PropertyName = "UserId")]
        public int UserId
        {
            get { return _UserId; }
            set { _UserId = value; }
        }

        [JsonProperty(PropertyName = "UserName")]
        public string UserName
        {
            get { return _UserName; }
            set { _UserName = value; }
        }

        [JsonProperty(PropertyName = "Password")]
        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }
    }
}
