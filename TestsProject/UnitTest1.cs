using System;
using BestPractices.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestsProject
{
    [TestClass]
    public class ActorTest
    {
        [TestMethod]
        public void TestGetOccupation()
        {
            //Arrange
            var currentActor = new Actor();
            var expected = "Actor";

            //Act
            string result = currentActor.GetOccupation();

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
