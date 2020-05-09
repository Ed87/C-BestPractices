using System;
using BestPractices.Common;
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

        [TestMethod]
        public void TestParameterizedConstructor()
        {
            //Arrange
            var currentActor = new Actor("Ed Tshuma");
            var expected = "Ed Tshuma";

            //Act
            string result = currentActor.JobTitle;

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestNotifyTalent()
        {
            //Arrange
            var expect = "Notifying talent : Ed";

            //Act
            string result = NotificationService.NotifyTalent("Ed");

            //Assert
            Assert.AreEqual(expect, result);
        }

        [TestMethod]
        public void TestBookActor()
        {
            //Arrange
            string details = "Actor will not book if" +
                " they cause trouble";
            var actor = new Actor("Ed Tshuma");

            var expected = "Actor Ed Tshuma is Booked" + details;
           
            //Act
            var result = actor.BookActor();

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
