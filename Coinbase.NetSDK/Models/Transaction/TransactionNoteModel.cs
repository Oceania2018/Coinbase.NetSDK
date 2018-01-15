using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coinbase.Models
{
    public class TransactionNoteModel
    {
        public String Title { get; set; }
        
        public String Subtitle { get; set; }

        [DeserializeAs(Name = "payment_method_name")]
        public String PaymentMethodName { get; set; }
    }
}
