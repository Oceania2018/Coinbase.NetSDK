using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coinbase.Models
{
    public class AddressModel : ResourceModel
    {
        public String Name { get; set; }

        public String Address { get; set; }

        [DeserializeAs(Name = "callback_url")]
        public String CallbackUrl { get; set; }

        public String Network { get; set; }
    }
}
