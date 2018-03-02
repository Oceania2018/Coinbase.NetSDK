using Coinbase.Models;
using Coinbase.Models.Transaction;
using Coinbase.Wallet;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coinbase.NetSDK.UnitTest.Wallet
{
    [TestClass]
    public class TransactionTest : TestEssential
    {
        [TestMethod]
        public void GetTransactionsTest()
        {
            var accountId = client.GetAccounts().Data.First(x => x.Type == Models.AccountType.Wallet).Id;

            var transactions = client.GetTransactions(accountId);

            Assert.IsTrue(transactions.Data.Count() > 0);

            string transactionId = transactions.Data.First().Id;

            var transaction = client.GetTransaction(accountId, transactionId);

            Assert.IsTrue(transaction.Id == transactionId);
        }

        [TestMethod]
        public void SendMoneyTest()
        {
            var account = client.GetPrimaryAccount();

            var transaction = client.SendMoney(account.Id, new TransactionSendModel {
                To = "1rundZJCMJhUiWQNFS5uT3BvisBuLxkAp",
                Amount = 0.0001M,
                Currency = "BTC"
            });
        }

        [TestMethod]
        public void RequestMoneyTest()
        {
            var account = client.GetPrimaryAccount();

            var transaction = client.RequestMoney(account.Id, new TransactionRequestModel
            {
                To = "xxxxxxxx@gmail.com",
                Amount = 0.0001M,
                Currency = "BTC"
            });
        }

        [TestMethod]
        public void TransferMoneyTest()
        {
            var account = client.GetPrimaryAccount();

            var transaction = client.RequestMoney(account.Id, new TransactionRequestModel
            {
                To = "1rundZJCMJhUiWQNFS5uT3BvisBuLxkAp",
                Amount = 0.0001M
            });
        }
    }
}
