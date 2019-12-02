using iMarketPlace.Web.Controllers;
using MarketPlace.ViewModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace MarketPlace.UnitTests
{
    [TestClass]
    public class UserTests
    {
        [TestMethod]
        public void Test_Seller_Registration_Method()
        {
            //Steps (AAA)
            //Arrange
            //Act
            //Assert

            //Moq (Assumption Data) : Moq

            //Arrange (Arrange the Data to be tested)
            var controller = new UserController();
            var person = new Person()
            {
                FirstName = "Irshad",
                LastName = "Ahmed",
                Email = "Irshad@outlook.com",
                Password = "abc123",
                ConfirmPassword = "abc123",
                CityId = 2,
                CountryId = 1,
                IsSeller = true
            };

            //----------
            //Act (Calling the Specific Function)
            var result = controller.Register(person);

            //-----------
            //Assert (Compare Expected Value with Result)
            Assert.IsNotNull(result);

        }
        [TestMethod]
        public void Test_Buyer_Registration_Method()
        {
            //Steps (AAA)
            //Arrange
            //Act
            //Assert

            //Arrange (Arrange the Data to be tested)
            var controller = new UserController();
            var person = new Person()
            {
                FirstName = "Irshad",
                LastName = "Ahmed",
                Email = "Irshad@outlook.com",
                Password = "abc123",
                ConfirmPassword = "abc123",
                CityId = 2,
                CountryId = 1,
                IsSeller = false
            };

            //----------
            //Act (Calling the Specific Function)
            var result = controller.Register(person);

            //-----------
            //Assert (Compare Expected Value with Result)
            Assert.IsNotNull(result);

        }
    }
}
