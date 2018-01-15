using Coinbase.Wallet;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coinbase.NetSDK.UnitTest.Wallet
{
    [TestClass]
    public class UserTest : TestEssential
    {
        [TestMethod]
        public void GetCurrenUser()
        {
            var user = client.GetCurrentUser();

            Assert.IsNotNull(user.Id);

            var user1 = client.GetUser(user.Id);

            Assert.IsTrue(user.Id == user1.Id);
        }
    }
}
