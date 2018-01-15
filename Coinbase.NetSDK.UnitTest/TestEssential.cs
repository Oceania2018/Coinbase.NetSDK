using Coinbase.Wallet;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coinbase.NetSDK.UnitTest
{
    public abstract class TestEssential
    {
        protected Client client { get; set; }

        public TestEssential()
        {
            client = new Client("", "");
        }
    }
}
