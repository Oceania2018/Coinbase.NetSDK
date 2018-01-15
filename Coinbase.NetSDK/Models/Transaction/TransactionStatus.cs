using System;
using System.Collections.Generic;
using System.Text;

namespace Coinbase.Models
{
    /// <summary>
    /// Transactions statuses vary based on the type of the transaction.
    /// https://developers.coinbase.com/api/v2?python#transaction-resource
    /// </summary>
    public enum TransactionStatus
    {
        Pending,
        Completed,
        Failed,
        Expired,
        Canceled,
        Waiting_for_Signature,
        Waiting_for_Clearing
    }
}
