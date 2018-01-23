using Coinbase.Currecny;
using Coinbase.Wallet;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coinbase.NetSDK.UnitTest.Currency
{
    [TestClass]
    public class CurrencyTest : TestEssential
    {
        [TestMethod]
        public void GetBuyPriceTest()
        {
            var price = client.GetBuyPrice("BTC-USD");

            Assert.IsNotNull(price);
        }

        [TestMethod]
        public void GetSellPriceTest()
        {
            var price = client.GetSellPrice("BTC-USD");

            Assert.IsNotNull(price);
        }

        [TestMethod]
        public void GetSpotPriceTest()
        {
            var price = client.GetSpotPrice("BTC-USD");

            Assert.IsNotNull(price);
        }
    }
}
