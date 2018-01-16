using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coinbase.Models
{
    public class SellModel : ResourceModel
    {
        public SellStatus Status { get; set; }

        public IdResourceModel PaymentMethod { get; set; }

        public IdResourceModel Transaction { get; set; }

        public BalanceModel Amount { get; set; }

        public BalanceModel Total { get; set; }

        public BalanceModel Subtotal { get; set; }

        public BalanceModel Fee { get; set; }

        public Boolean Committed { get; set; }

        public bool Instant { get; set; }

        [DeserializeAs(Name = "payout_at")]
        public DateTime PayoutAt { get; set; }
    }
}
