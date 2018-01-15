using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coinbase.Models
{
    public class TransactionPartyModel
    {
        public String Id { get; set; }

        public String Resource { get; set; }

        [DeserializeAs(Name = "resource_path")]
        public String ResourcePath { get; set; }
    }
}
