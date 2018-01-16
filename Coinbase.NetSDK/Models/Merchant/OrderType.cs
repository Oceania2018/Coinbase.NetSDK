using System;
using System.Collections.Generic;
using System.Text;

namespace Coinbase.Models
{
    public enum OrderType
    {
        /// <summary>
        /// regular order
        /// </summary>
        order,

        donation,

        /// <summary>
        /// email invoice
        /// </summary>
        invoice
    }
}
