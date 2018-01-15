using Coinbase.Wallet;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coinbase.NetSDK.UnitTest.Wallet
{
    [TestClass]
    public class AddressTest : TestEssential
    {
        [TestMethod]
        public void GetAddressTest()
        {
            var accountId = client.GetAccounts().Data.First(x => x.Type == Models.AccountType.Wallet).Id;

            var addresses = client.GetAddresses(accountId);

            Assert.IsTrue(addresses.Data.Count() > 0);

            string addressId = addresses.Data.First().Id;

            var address = client.GetAddress(accountId, addressId);

            Assert.IsTrue(address.Id == addressId);
        }

        [TestMethod]
        public void CreateAddressTest()
        {
            var account = client.GetPrimaryAccount();
            var address = client.CreateAddress(account.Id);

            Assert.IsNotNull(address.Id);
        }
    }
}
