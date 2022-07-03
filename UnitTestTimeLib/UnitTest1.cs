using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TimeLib;

namespace UnitTestTimeLib
{
    [TestClass]
    public class UnitTestTime
    {
        [TestMethod]
        public void TestMethodStartTimeIsTrue()
        {
            //Arrange
            TimeSpan test = TimeSpan.FromHours(10);
            bool expected = true;
            //Act
            bool actual = TimeLib.Calculate.ValidateTime(test);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
