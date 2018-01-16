using Coinbase.Models;
using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coinbase.Models
{
    public class LocationModel
    {
        public String Line1 { get; set; }

        public String Line2 { get; set; }

        public String City { get; set; }

        public String State { get; set; }

        [DeserializeAs(Name = "postal_code")]
        public String PostalCode { get; set; }

        public CountryModel Country { get; set; }
    }
}
