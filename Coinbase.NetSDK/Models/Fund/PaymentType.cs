using System;
using System.Collections.Generic;
using System.Text;

namespace Coinbase.Models
{
    public enum PaymentType
    {
        /// <summary>
        /// Regular US bank account
        /// </summary>
        ach_bank_account,

        /// <summary>
        /// European SEPA bank account
        /// </summary>
        sepa_bank_account,

        /// <summary>
        /// iDeal bank account (Europe)
        /// </summary>
        ideal_bank_account,

        /// <summary>
        /// Fiat nominated Coinbase account
        /// </summary>
        fiat_account,

        /// <summary>
        /// Bank wire (US only)
        /// </summary>
        bank_wire,

        /// <summary>
        /// Credit card (can’t be used for buying/selling)
        /// </summary>
        credit_card,

        /// <summary>
        /// Secure3D verified payment card
        /// </summary>
        secure3d_card,

        /// <summary>
        /// Canadian EFT bank account
        /// </summary>
        eft_bank_account,

        /// <summary>
        /// - Interac Online for Canadian bank accounts
        /// </summary>
        interac
    }
}
