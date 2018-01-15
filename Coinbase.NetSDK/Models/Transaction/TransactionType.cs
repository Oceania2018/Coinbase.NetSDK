using System;
using System.Collections.Generic;
using System.Text;

namespace Coinbase.Models
{
    /// <summary>
    /// Transaction resource represents an event on the account.
    /// https://developers.coinbase.com/api/v2?python#transactions
    /// </summary>
    public enum TransactionType
    {
        send,
        request,
        transfer,
        buy,
        sell,
        fiat_deposit,
        fiat_withdrawal,
        exchange_deposit,
        exchange_withdrawal,
        vault_withdrawal
    }
}
