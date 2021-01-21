using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using EventInfoLibrary;


namespace EventsTest
{
    [TestClass]
    public class EventInfoTest
    {
        [TestMethod]
        public void getItems_emptyString_returnsError()
        {
            // Arrange
            var data = "0";

            // Act
            var result = GetData.GetItems(data);

            // Assert
            Assert.AreEqual(null, result);

        }
    }
}