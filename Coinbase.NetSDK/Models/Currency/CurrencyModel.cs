using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coinbase.Models
{
    public class CurrencyModel
    {
        public String Code { get; set; }

        public String Name { get; set; }

        public String Color { get; set; }

        public int Exponent { get; set; }

        public String Type { get; set; }

        [DeserializeAs(Name = "address_regex")]
        public String AddressRegex { get; set; }
    }
}
