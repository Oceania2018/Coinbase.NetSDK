using Coinbase.Wallet;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coinbase.NetSDK.UnitTest.Wallet
{
    [TestClass]
    public class PaymentTest :TestEssential
    {
        [TestMethod]
        public void GetPaymentMethodsTest()
        {
            var methods = client.GetPaymentMethods();

            Assert.IsTrue(methods.Data.Count() > 0);

            var method = client.GetPaymentMethod(methods.Data.First().Id);

            Assert.IsTrue(method.Id == methods.Data.First().Id);
        }

    }
}
