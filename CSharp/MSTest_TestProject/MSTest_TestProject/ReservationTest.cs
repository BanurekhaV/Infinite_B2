using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MSTestMainDLL;


namespace MSTest_TestProject
{
    [TestClass]
    public class ReservationTest
    {
      //[TestMethod]
        public void Cancellation_ByAdmin_To_Return_True()
        {
            //Arrange
            var reservation = new Reservation();

            //Act
            var result = reservation.CanbeCancelledBy(new User { IsAdmin = true });

            //Assert
            Assert.IsTrue(result);
        }

      //[TestMethod]
        public void Cancellation_By_MadeBy_To_Return_True()
        {
            var userobj = new User();
            var reservation = new Reservation() { MadeBy = userobj };

            var result = reservation.CanbeCancelledBy(reservation.MadeBy);

            Assert.IsTrue(result);
        }

       //TestMethod]
        public void Cancellation_By_Others_To_Return_False()
        {
            var reservation = new Reservation { MadeBy = new User() };
            var result = reservation.CanbeCancelledBy(new User());

            Assert.IsFalse(result);
        }

        [TestInitialize]
        public void BeforeRunningTestMethod()
        {
            Console.WriteLine("This is Before Test");
        }

        [TestCleanup]
        public void AfterTest()
        {
            Console.WriteLine("This is After Test");
        }

        [TestMethod]
        public void TestMethod1()
        {
            Console.WriteLine("This is Test Method 1");
        }

        [TestMethod]
        public void TestMethod2()
        {
            Console.WriteLine("This is Test Method 2");
        }

        [ClassInitialize]
        //we have to pass an object of TestContext Class which can have additional information about
        //the testing much before the class is instantiated
        public static void BeforeClass(TestContext tc) 
        {
            Console.WriteLine("This is Before Class");
        }

        [ClassCleanup]
        public static void AfterClass()
        {
            Console.WriteLine("This is after Class");
        }
        [AssemblyInitialize]

        public static void BeforeAssembly(TestContext t)
        {
            Console.WriteLine("Before Assembly..");
        }
        [AssemblyCleanup]
        public static void AfterAssembly()
        {
            Console.WriteLine("After Assembly");
        }
    }
}
