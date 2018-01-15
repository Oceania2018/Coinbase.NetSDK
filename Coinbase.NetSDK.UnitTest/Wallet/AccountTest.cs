using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Coinbase.Wallet;
using System.Linq;

namespace Coinbase.NetSDK.UnitTest.Wallet
{
    [TestClass]
    public class AccountTest : TestEssential
    {
        [TestMethod]
        public void ListAccountsTest()
        {
            var accounts = client.GetAccounts();

            Assert.IsTrue(accounts.Data.ToList().Count > 0);

            var account = client.GetAccount(accounts.Data.First().Id);

            Assert.IsTrue(account.Id == accounts.Data.First().Id);
        }

        [TestMethod]
        public void SetPrimaryAccountTest()
        {
            var accounts = client.GetAccounts().Data.Where(x => x.Type == Models.AccountType.Wallet).ToList();

            int idx = new Random().Next(accounts.Count);

            var primaryAccount = accounts[idx];

            client.SetPrimaryAccount(primaryAccount.Id);

            var primaryAccount2 = client.GetPrimaryAccount();

            Assert.IsTrue(primaryAccount.Id == primaryAccount2.Id);
        }
    }
}
