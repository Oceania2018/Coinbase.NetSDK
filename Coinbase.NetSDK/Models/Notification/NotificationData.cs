using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coinbase.Models
{
    public class NotificationData : ResourceModel
    {
        public String Address { get; set; }

        public String Name { get; set; }

        public BalanceModel Amount { get; set; }

        [DeserializeAs(Name = "bitcoin_address")]
        public String BitcoinAddress { get; set; }

        public IdResourceModel Transaction { get; set; }
    }
}
