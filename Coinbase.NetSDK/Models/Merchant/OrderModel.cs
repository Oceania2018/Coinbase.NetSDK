using Newtonsoft.Json.Linq;
using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coinbase.Models
{
    public class OrderModel : ResourceModel
    {
        public String Code { get; set; }

        public OrderStatus Status { get; set; }

        public String Name { get; set; }

        public String Description { get; set; }

        public BalanceModel Amount { get; set; }

        [DeserializeAs(Name = "payout_amount")]
        public BalanceModel PayoutAmount { get; set; }

        [DeserializeAs(Name = "bitcoin_address")]
        public String BitcoinAddress { get; set; }

        [DeserializeAs(Name = "bitcoin_amount")]
        public BalanceModel BitcoinAmount { get; set; }

        [DeserializeAs(Name = "bitcoin_uri")]
        public String BitcoinUri { get; set; }

        [DeserializeAs(Name = "receipt_url")]
        public String ReceiptUrl { get; set; }

        [DeserializeAs(Name = "expires_at")]
        public DateTime ExpiresAt { get; set; }

        [DeserializeAs(Name = "mispaid_at")]
        public DateTime? MispaidAt { get; set; }

        [DeserializeAs(Name = "paid_at")]
        public DateTime? PaidAt { get; set; }

        [DeserializeAs(Name = "refund_address")]
        public String RefundAddress { get; set; }

        public IdResourceModel Transaction { get; set; }

        /// <summary>
        /// Merchant defined metadata
        /// </summary>
        public JObject Metadata { get; set; }
    }
}
