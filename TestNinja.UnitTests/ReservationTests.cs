
using NUnit.Framework;
using System;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class ReservationTests
    {
        [Test]
        public void CanBeCancelledBy_UserIsAdmin_True()
        {
            //Arrange
            var reservationObj = new Reservation();
            //Act
            var result = reservationObj.CanBeCancelledBy(new User() { IsAdmin = true });
            //Assert
            Assert.IsTrue(result);
            Assert.That(result, Is.True);
            Assert.That(result == true);
        }
        [Test]
        public void CanBeCancelBy_UserIsAdmin_False()
        {
            //arrange
            var reqesut = new Reservation();
            //act
            var result = reqesut.CanBeCancelledBy(new User() { IsAdmin = false});
            //assert
            Assert.IsFalse(result);
        }
    }
}
