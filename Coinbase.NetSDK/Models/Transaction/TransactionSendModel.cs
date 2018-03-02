using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Coinbase.Models.Transaction
{
    /// <summary>
    /// https://developers.coinbase.com/api/v2?python#send-money
    /// </summary>
    public class TransactionSendModel
    {
        [Required]
        public TransactionType Type { get; } = TransactionType.send;

        /// <summary>
        /// A bitcoin address, bitcoin cash address, litecoin address, ethereum address, or an email of the recipient
        /// </summary>
        [Required]
        public String To { get; set; }

        [Required]
        public Decimal Amount { get; set; }

        [Required]
        public String Currency { get; set; }

        /// <summary>
        /// Notes to be included in the email that the recipient receives
        /// </summary>
        public String Description { get; set; }

        /// <summary>
        /// Don’t send notification emails for small amounts
        /// </summary>
        public Boolean skip_notifications { get; set; }

        /// <summary>
        /// Transaction fee in BTC/ETH/LTC if you would like to pay it.
        /// </summary>
        public String fee { get; set; }

        /// <summary>
        /// A token to ensure idempotence. [Recommended]
        /// </summary>
        public String Idem { get; set; }

        [DeserializeAs(Name = "to_financial_institution")]
        public Boolean ToFinancialInstitution { get; set; }

        [DeserializeAs(Name = "financial_institution_website")]
        public String FinancialInstitutionWebsite { get; set; }
    }
}
