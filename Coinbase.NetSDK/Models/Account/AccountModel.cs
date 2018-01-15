using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coinbase.Models
{
    public class AccountModel : ResourceModel
    {
        public String Name { get; set; }

        public Boolean Primary { get; set; }

        public AccountType Type { get; set; }

        public CurrencyModel Currency { get; set; }

        public BalanceModel Balance { get; set; }
    }
}
