using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using EventInfoLibrary;
namespace EventsTest
{
    [TestClass]
    public class EventInfoTest
    {
        [TestMethod]
        public void GetItems_emptyString_returnsNull()
        {
            // Arrange
            var data = "";

            // Act
            var result = GetData.GetItems(data);

            // Assert
            Assert.AreEqual(null, result);

        }

        [TestMethod]
        public void GetItems_randomString_returnsNull()
        {
            // Arrange
            var data = "12345";

            // Act
            var result = GetData.GetItems(data);

            // Assert
            Assert.AreEqual(null, result);

        }

        [TestMethod]
        public void GetItems_jsonString_returnsNull()
        {
            // Arrange
            var data = "{ 'vardenis': 'pavardenis' }";

            // Act
            var result = GetData.GetItems(data);

            // Assert 
            Assert.IsTrue(result is null);

        }

        [TestMethod]
        public void GetItems_jsonString_returnsList()
        {
            // Arrange
            var data = "{'title': 'EONET Events: Water Color','description': 'Related to events that alter the appearance of water: phytoplankton, red tide, algae, sediment, whiting, etc.', 'link': 'https://eonet.sci.gsfc.nasa.gov/api/v2.1/categories/13', 'events': []}";

            // Act
            var result = GetData.GetItems(data);

            // Assert 
            Assert.IsTrue(result is List<Event>);

        }

    }
}