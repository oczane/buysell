using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyJourney.Controllers;
using MyJourney.Models;

namespace MyJourney.Tests.Repository
{
    [TestClass]
    public class UserRepositoryTest
    {
        MyJourney.Services.UserService.Interface.IRegisterService registerService;

        [TestInitialize]
        public void TestInitialize()
        {
            MyJourney.AppRepository.IRepository<User> repo = new MyJourney.AppRepository.Repository<User>();
            registerService = new MyJourney.Services.UserService.Impl.RegisterService(repo);
        }

        [TestMethod]
        public void SaveUser()
        {
            User model = new User();
            model.Email = "rakesh.gupta@coditas.com";
            model.FirstName = "Rakesh";
            model.LastName = "Gupta";
            model.MobileNumber = "7387070331";
            model.Password = "abcd";
            model.Created = System.DateTime.Now;

            //Act
            var _user = registerService.SaveUser(model);

            //Assert
            Assert.IsNotNull(_user);

        }
    }
}
