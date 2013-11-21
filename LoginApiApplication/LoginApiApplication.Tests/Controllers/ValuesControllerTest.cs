using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using LoginApiApplication.Models.UserActions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LoginApiApplication;
using LoginApiApplication.Controllers;

namespace LoginApiApplication.Tests.Controllers
{
    [TestClass]
    public class ValuesControllerTest
    {
        [TestMethod]
        public void Get()
        {
            // Arrange
            //ValuesController controller = new ValuesController();

            // Act
            //IEnumerable<string> result = controller.Get();

            // Assert
            //Assert.IsNotNull(result);
            //Assert.AreEqual(2, result.Count());
            //Assert.AreEqual("value1", result.ElementAt(0));
            //Assert.AreEqual("value2", result.ElementAt(1));
        }

        [TestMethod]
        public void GetById()
        {
            //// Arrange
            //ValuesController controller = new ValuesController();

            //// Act
            //string result = controller.Get(5);

            //// Assert
            //Assert.AreEqual("value", result);
        }

        [TestMethod]
        public void Post()
        {
            //// Arrange
            //ValuesController controller = new ValuesController();

            //// Act
            //controller.Post("value");

            //// Assert
        }

        [TestMethod]
        public void Put()
        {
            //// Arrange
            //ValuesController controller = new ValuesController();

            //// Act
            //controller.Put(5, "value");

            //// Assert
        }

        [TestMethod]
        public void Delete()
        {
            //// Arrange
            //ValuesController controller = new ValuesController();

            //// Act
            //controller.Delete(5);

            //// Assert
        }

        [TestMethod]
        public void AddUser()
        {
            //Models.UserActions.AddUser.AddSimpleUser(new User
            //{
            //    Address = "test",
            //    Email = "test@test.com",
            //    UserId = Guid.NewGuid(),
            //    Company = "test",
            //    DateOfBirth = DateTime.Today,
            //    FirstName = "test",
            //    LastName = "test",
            //    PhoneNumber = 123345,
            //},  new UserAccount
            //{
            //    IsAdmin = true,
            //    IsAuthorized = true,
            //    ConfirmedEmail = true,
            //    Locked = false,
            //    Username = "karan",
            //    Password = "karan",
            //    LastLogin = DateTime.UtcNow,
            //    LoginAttempts = 0,
            //    SignupDate = DateTime.Today,
            //    UserAccountId = Guid.NewGuid()
            //});
        }

        [TestMethod]
        public void GetUser()
        {
            var context = new UserContext();
            IUserCoordinator coordinator = new UserCoordinator(context);
            //coordinator.EditSimpleUser(new User{Email = "test@test.com"});
            //coordinator.ChangePassword("test@test.com", "karan", "karanbatta");
            //coordinator.RetrieveSimpleUser("test@test.com", "karanbatta");
        }
    }
}
