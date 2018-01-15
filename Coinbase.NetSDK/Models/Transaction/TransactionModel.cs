using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coinbase.Models
{
    public class TransactionModel : ResourceModel
    {
        /// <summary>
        /// Transaction type
        /// </summary>
        public TransactionType Type { get; set; }

        public TransactionStatus Status { get; set; }

        /// <summary>
        /// Amount in bitcoin, bitcoin cash, litecoin or ethereum
        /// </summary>
        public BalanceModel Amount { get; set; }

        [DeserializeAs(Name = "native_amount")]
        public BalanceModel NativeAmount { get; set; }

        /// <summary>
        /// User defined description
        /// </summary>
        public String Description { get; set; }

        [DeserializeAs(Name = "instant_exchange")]
        public Boolean InstantExchange { get; set; }

        /// <summary>
        /// Detailed information about the transaction
        /// </summary>
        public TransactionNoteModel Details { get; set; }

        public NetworkModel Network { get; set; }

        public TransactionPartyModel Buy { get; set; }

        public TransactionPartyModel Sell { get; set; }
    }
}
