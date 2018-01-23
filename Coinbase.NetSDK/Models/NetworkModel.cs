using System;
using System.Collections.Generic;
using System.Text;

namespace Coinbase.Models
{
    /// <summary>
    /// Information about bitcoin, bitcoin cash, litecoin or ethereum network 
    /// including network transaction hash if transaction was on-blockchain. 
    /// Only available for certain types of transactions
    /// </summary>
    public class NetworkModel
    {
        public String Status { get; set; }

        public String Name { get; set; }

        public String Hash { get; set; }
    }
}
