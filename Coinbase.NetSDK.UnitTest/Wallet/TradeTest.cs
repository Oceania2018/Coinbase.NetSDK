using Coinbase.Currecny;
using Coinbase.Models;
using Coinbase.Wallet;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coinbase.NetSDK.UnitTest.Wallet
{
    [TestClass]
    public class TradeTest : TestEssential
    {
        [TestMethod]
        public void GetBuysTest()
        {
            var account = client.GetPrimaryAccount();
            var buys = client.GetBuys(account.Id);

            Assert.IsTrue(buys.Data.Count() > 0);

            var buy = client.GetBuy(account.Id, buys.Data.First().Id);

            Assert.IsNotNull(buy);
        }

        [TestMethod]
        public void BuyTest()
        {
            var account = client.GetPrimaryAccount();
            var payment = client.GetPaymentMethods().Data.First(x => x.InstantSell);
            var buyPrice = client.GetBuyPrice("BTC-USD");

            if (buyPrice.Amount > 10000) return;

            client.Buy(account.Id, new BuyingModel
            {
                Amount = 0.005M,
                Currency = "BTC",
                PaymentMethod = payment.Id,
                Commit = false
            });
        }

        [TestMethod]
        public void GetSellsTest()
        {
            var account = client.GetPrimaryAccount();
            var sells = client.GetSells(account.Id);

            Assert.IsTrue(sells.Data.Count() > 0);

            var sell = client.GetSell(account.Id, sells.Data.First().Id);

            Assert.IsNotNull(sell);
        }

        [TestMethod]
        public void SellTest()
        {
            var account = client.GetPrimaryAccount();
            var payment = client.GetPaymentMethods().Data.First(x => x.InstantSell);
            var sellPrice = client.GetSellPrice("BTC-USD");

            if (sellPrice.Amount < 20000) return;

            var sell = client.Sell(account.Id, new SellingModel
            {
                Amount = 0.005M,
                Currency = "BTC",
                PaymentMethod = payment.Id,
                Commit = false
            });
        }
    }
}
