using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coinbase.Models
{
    /// <summary>
    /// Buy resource represents a purchase of bitcoin, bitcoin cash, litecoin or ethereum using a payment method (either a bank or a fiat account). 
    /// Each committed buy also has an associated transaction.
    /// https://developers.coinbase.com/api/v2?python#buy-resource
    /// </summary>
    public class BuyModel : ResourceModel
    {
        public BuyStatus Status { get; set; }

        /// <summary>
        /// Associated payment method (e.g. a bank, fiat account)
        /// </summary>
        public IdResourceModel PaymentMethod { get; set; }

        /// <summary>
        /// Associated transaction (e.g. a bank, fiat account)
        /// </summary>
        public IdResourceModel Transaction { get; set; }

        /// <summary>
        /// Amount in bitcoin, bitcoin cash, litecoin or ethereum
        /// </summary>
        public BalanceModel Amount { get; set; }

        /// <summary>
        /// Fiat amount with fees
        /// </summary>
        public BalanceModel Total { get; set; }

        /// <summary>
        /// Fiat amount without fees
        /// </summary>
        public BalanceModel Subtotal { get; set; }

        /// <summary>
        /// Fee associated to this buy
        /// </summary>
        public BalanceModel Fee { get; set; }

        /// <summary>
        /// Has this buy been committed?
        /// </summary>
        public Boolean Committed { get; set; }

        /// <summary>
        /// Was this buy executed instantly?
        /// </summary>
        public bool Instant { get; set; }

        /// <summary>
        /// When a buy isn’t executed instantly, it will receive a payout date for the time it will be executed
        /// </summary>
        [DeserializeAs(Name = "payout_at")]
        public DateTime PayoutAt { get; set; }
    }
}
