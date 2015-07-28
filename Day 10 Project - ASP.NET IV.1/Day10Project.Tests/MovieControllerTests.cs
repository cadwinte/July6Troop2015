using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Day_10_Project_ASP.NET_IV._1.Models;
using System.Collections.Generic;
using Moq;
using System.Linq;
using Day_10_Project_ASP.NET_IV._1.Controllers;
using System.Web.Mvc;

namespace Day10Project.Tests
{
    [TestClass]
    public class MovieControllerTests
    {
        [TestMethod]
        public void TestIndex()
        {
            //Arrange
            var movies = new List<Movie>
            {
                new Movie { Title = "Star Wars" },
                new Movie { Title = "King Kong" }
            };

            var mockRepo = new Mock<IGenericRepository>();
            mockRepo.Setup(r => r.Query<Movie>()).Returns(movies.AsQueryable());
            var controller = new MoviesController(mockRepo.Object);

            //Act
            var result = (ViewResult)controller.Index();
            var model = (IList<Movie>)result.Model;

            //Assert
            Assert.AreEqual("King Kong", model.First().Title);
        }
    }
}
