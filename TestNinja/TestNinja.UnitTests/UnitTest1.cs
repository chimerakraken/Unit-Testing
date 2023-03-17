using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        // standard for naming test methods 
        // method_scenario_expectedbehaviors
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
        {
            // trip A convention
            // arrange
            var reservation = new Reservation();

            // act
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });

            // assert
            Assert.IsTrue(result);
        }
    }
}
