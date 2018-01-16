using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coinbase.Models
{
    public class BuyingModel : BalanceModel
    {
        [DeserializeAs(Name = "payment_method")]
        public String PaymentMethod { get; set; }

        public Decimal Total { get; set; }

        /// <summary>
        /// Whether or not you would still like to sell if you have to wait for your money to arrive to lock in a price
        /// </summary>
        [DeserializeAs(Name = "agree_btc_amount_varies")]
        public String AgreeBtcAmountVaries { get; set; }

        /// <summary>
        /// If set to false, this sell will not be immediately completed. 
        /// Use the commit call to complete it. 
        /// Default value: true
        /// </summary>
        public Boolean Commit { get; set; }

        /// <summary>
        /// If set to true, response will return an unsave sell for detailed price quote. 
        /// Default value: false
        /// </summary>
        public Boolean Quote { get; set; }
    }
}
