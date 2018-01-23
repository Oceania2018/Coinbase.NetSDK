using System;
using System.Collections.Generic;
using System.Text;

namespace Coinbase.Models
{
    public class PricePairModel : BalanceModel
    {
        public String Pair { get; set; }

        public CurrencyType Base { get; set; }
    }
}
