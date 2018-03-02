using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Coinbase.Models.Transaction
{
    public class TransactionTransferModel
    {
        [Required]
        public TransactionType Type { get; } = TransactionType.transfer;

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
        public String Currency { get; set; }

        /// <summary>
        /// Notes to be included in the email that the recipient receives
        /// </summary>
        public String Description { get; set; }
    }
}
