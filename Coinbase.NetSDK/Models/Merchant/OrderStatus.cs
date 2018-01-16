using System;
using System.Collections.Generic;
using System.Text;

namespace Coinbase.Models
{
    public enum OrderStatus
    {
        active,
        paid,
        expired,
        canceled,
        mispaid
    }
}
