using System;
using System.Collections.Generic;
using System.Text;

namespace Coinbase.Models
{
    public class BalanceModel
    {
        public Decimal Amount { get; set; }

        /// <summary>
        /// Currency Symbol
        /// </summary>
        public String Currency { get; set; }
    }
}
