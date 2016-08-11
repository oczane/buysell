using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyJourney.Controllers;
using MyJourney.Models;
using Moq;

namespace MyJourney.Tests.Repository
{
    [TestClass]
    public class UserRepositoryTest
    {
        MyJourney.AppRepository.IRepository<User> _repository;
        MyJourney.Services.UserService.Interface.IRegisterService _service;

        [TestInitialize]
        public void TestInitialize()
        {
            _repository = new MyJourney.AppRepository.Repository<User>();
        }

        [TestMethod]
        public void Save_New_User_Test()
        {
            User model = new User();
            model.Email = "grakesh18@gmail.com";
            model.FirstName = "Rakesh";
            model.LastName = "Gupta";
            model.MobileNumber = "7387070331";
            model.Password = "abcd"; //to-do: encryption check 
            model.Created = System.DateTime.Now;

            //Act
            var _user = _repository.InsertReturnEntity(model);

            //Assert
            Assert.IsNotNull(_user);

        }

        [TestMethod]
        public void Mock_Save_New_User_Test()
        {
            // Arrange
            User user = new User()
            {
                Email = "grakesh18@gmail.com",
                FirstName = "Rakesh",
                LastName = "Gupta",
                MobileNumber = "7387070331",
                Password = "abcd",
                Created = System.DateTime.Now
            };

            var repo = new Mock<MyJourney.AppRepository.IRepository<User>>();

            // Setup
            repo.Setup(x => x.InsertReturnEntity(user)).Returns(user);

            _service = new MyJourney.Services.UserService.Impl.RegisterService(repo.Object);

            // Assert
            Assert.IsNotNull(user);

            // Verify
            //repo.Verify(x => x.InsertReturnEntity(user), Times.Exactly(1));
        }
    }
}
