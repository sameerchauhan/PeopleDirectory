using System;
using System.Collections.Generic;
using DAL;
using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Services;

namespace PeopleServices.Test
{
    [TestClass]
    public class PersonServicesTests
    {
        [TestMethod]
        public void ShouldCallRepository()
        {
            var repo = new Mock<IPeopleRepository>();
            PeopleServiceLocatorFactory.SetRepository(repo.Object);
            repo.Setup(r => r.GetListOfPeople()).Returns(new List<Person>());
            var service = new PersonService();
            
            service.GetListOfPeople();

            repo.Verify(r => r.GetListOfPeople(), Times.AtLeastOnce);
        }
    }
}
