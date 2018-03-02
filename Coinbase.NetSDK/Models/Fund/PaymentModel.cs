using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coinbase.Models
{
    /// <summary>
    /// Payment method resource represents the different kinds of payment methods that can be used when buying and selling bitcoin, bitcoin cash, litecoin or ethereum.
    /// https://developers.coinbase.com/api/v2#payment-method-resource
    /// </summary>
    public class PaymentModel : ResourceModel
    {
        /// <summary>
        /// Payment method type
        /// </summary>
        public PaymentType Type { get; set; }

        /// <summary>
        /// Payment method type
        /// </summary>
        public String Name { get; set; }

        /// <summary>
        /// Payment method’s native currency
        /// </summary>
        public String Currency { get; set; }

        /// <summary>
        /// Is primary buying method?
        /// </summary>
        [DeserializeAs(Name = "primary_buy")]
        public Boolean PrimaryBuy { get; set; }

        /// <summary>
        /// Is primary selling method?
        /// </summary>
        [DeserializeAs(Name = "primary_sell")]
        public Boolean PrimarySell { get; set; }

        /// <summary>
        /// Is buying allowed with this method?
        /// </summary>
        [DeserializeAs(Name = "allow_buy")]
        public Boolean AllowBuy { get; set; }

        /// <summary>
        /// Is selling allowed with this method?
        /// </summary>
        [DeserializeAs(Name = "allow_sell")]
        public Boolean AllowSell { get; set; }

        /// <summary>
        /// Does this method allow for instant buys?
        /// </summary>
        [DeserializeAs(Name = "instant_buy")]
        public Boolean InstantBuy { get; set; }

        /// <summary>
        /// Does this method allow for instant sells?
        /// </summary>
        [DeserializeAs(Name = "instant_sell")]
        public Boolean InstantSell { get; set; }
    }
}
