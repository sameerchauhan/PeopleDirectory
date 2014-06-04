using System.Collections.Generic;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using PeopleDirectory.Controllers;
using Services;

namespace PeopleDirectory.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController(null);

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ShouldRetrieveListOfPeople()
        {
            // Arrange
            var list = new List<PersonDto>();
            var service = new Mock<IPersonService>();
            var controller = new HomeController(service.Object);
            service.Setup(s => s.GetListOfPeople()).Returns(list);

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            service.Verify(s => s.GetListOfPeople(), Times.AtLeastOnce);
        }
    }
}
