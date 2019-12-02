using iMarketPlace.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.UnitTests
{
    [TestClass]
    public class LocationServiceTests
    {
        [TestMethod]
        public void Test_Get_Cities_By_Country_Method()
        {
            //Arrange
            var locationService = new LocationService();
            int countryId = 1;

            //Act
            var cities = locationService.GetCitiesByCountryId(countryId);

            //Assert
            Assert.IsNotNull(cities);
            Assert.AreEqual(true, cities.Count > 0);
        }
    }
}
