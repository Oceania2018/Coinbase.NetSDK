using RestSharp.Serializers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Coinbase.Models.Transaction
{
    /// <summary>
    /// Requests money from an email address.
    /// https://developers.coinbase.com/api/v2?python#request-money
    /// </summary>
    public class TransactionRequestModel
    {
        [Required]
        public TransactionType Type { get; } = TransactionType.request;

        /// <summary>
        /// An email of the recipient
        /// </summary>
        [Required]
        public String To { get; set; }

        /// <summary>
        /// Amount to be requested
        /// </summary>
        [Required]
        public Decimal Amount { get; set; }

        [Required]
        public CurrencyType Currency { get; set; }

        /// <summary>
        /// Notes to be included in the email that the recipient receives
        /// </summary>
        public String Description { get; set; }
    }
}
