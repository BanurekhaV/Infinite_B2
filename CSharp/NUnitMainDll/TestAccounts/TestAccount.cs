using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnitMainDll;

namespace TestAccounts
{
    [TestFixture]
    public class TestAccount
    {
        //Arrange globally
        Account acc;

        [SetUp]
        public void TestSetup()
        {
            acc = new Account("A1234");
        }

        [Test]
        public void TestDeposit_Method()
        {
              //ask
            acc.Deposit(500);

            //Assert
            Assert.AreEqual(1000, acc.checkBalance()); 
        }

        //[Test]
        public void TestWithdrawal_Method()
        {
            acc.Withdraw(2000);
        }

        [Test]

        public void TestWithdrawalException()
        {
            Assert.Throws<Exception>(TestWithdrawal_Method);
        }

        [Test]
        public void JustCheckingBalance()
        {
            Assert.AreNotEqual(1500, acc.checkBalance());
        }
    }
}
