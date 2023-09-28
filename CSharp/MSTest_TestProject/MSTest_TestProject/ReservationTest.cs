using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MSTestMainDLL;

namespace MSTest_TestProject
{
    [TestClass]
    public class ReservationTest
    {
        [TestMethod]
        public void Cancellation_ByAdmin_To_Return_True()
        {
            //Arrange
            var reservation = new Reservation();

            //Act
            var result = reservation.CanbeCancelledBy(new User { IsAdmin = true });

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Cancellation_By_MadeBy_To_Return_True()
        {
            var userobj = new User();
            var reservation = new Reservation() { MadeBy = userobj };

            var result = reservation.CanbeCancelledBy(reservation.MadeBy);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Cancellation_By_Others_To_Return_False()
        {
            var reservation = new Reservation { MadeBy = new User() };
            var result = reservation.CanbeCancelledBy(new User());

            Assert.IsFalse(result);
        }
    }
}
