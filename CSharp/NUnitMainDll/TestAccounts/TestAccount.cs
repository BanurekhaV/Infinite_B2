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
        EmployeeDetails edetails;
        List<EmployeeDetails> elist;

        [SetUp]
        public void TestSetup()
        {
            acc = new Account("A1234");
            edetails = new EmployeeDetails();
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

        [Test]
        public void TestAddmethod()
        {
            int result = acc.Add(15, 65);
            Assert.That(result, Is.EqualTo(80));
        }

        //testcases for testing various situations/conditions
        [Test]
        [TestCase(15,35,50)]
        [TestCase(10,45,55)]
        [TestCase(20,50,60)]
        public void TestAddMethodWithTestCases(int num1,int num2, int expected)
        {
            int result = acc.Add(num1, num2);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void CheckLogin()
        {
            string L1 = acc.Login("Banu", "1234");
            string L2 = acc.Login("", "admin1234");
            string L3 = acc.Login("Admin", "Admin123");
            Assert.AreEqual("Incorrect Userid or Password", L1);
            Assert.AreEqual("UserId or password cannot be Empty", L2);
            Assert.AreEqual("Welcome Admin", L3);
        }

        [Test]
        public void validateEmployeeDetails()
        {
            elist=edetails.AllEmployees();
            foreach(var e in elist)
            {
                Assert.IsNotNull(e.ID);
                Assert.IsNotNull(e.Name);
                Assert.IsNotNull(e.Salary);
            }
        }

        [Test]
        [Ignore("Ignoringthis")]
        public void TestgetEmployeeById()
        {
            EmployeeDetails e = edetails.GetEmployeeById(21);
            Assert.IsNotNull(e);        
                
        }
    }
}
