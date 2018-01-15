using System;
using System.Collections.Generic;
using System.Text;

namespace Coinbase.Models
{
    public class BalanceModel
    {
        public Decimal Amount { get; set; }

        public CurrencyType Currency { get; set; }
    }
}
