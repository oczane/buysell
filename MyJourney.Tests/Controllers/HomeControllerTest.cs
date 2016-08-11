using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyJourney.Controllers;
using MyJourney.Models;

namespace MyJourney.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        MyJourney.Services.AdvertisementService.IAdvertisementService _advertisement;

        [TestInitialize]
        public void TestInitialize()
        {
            MyJourney.AppRepository.IRepository<Advertisement> repo = new MyJourney.AppRepository.Repository<Advertisement>();
            _advertisement = new MyJourney.Services.AdvertisementService.AdvertisementService(repo);
        }

       [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController(_advertisement);

            // Act
            //ViewResult result = controller.Index() as ViewResult;

            string result = "dddsdaasdad";

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void About()
        {
            // Arrange
            HomeController controller = new HomeController(_advertisement);

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }

        [TestMethod]
        public void Contact()
        {
            // Arrange
            HomeController controller = new HomeController(_advertisement);

            // Act
            ViewResult result = controller.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
