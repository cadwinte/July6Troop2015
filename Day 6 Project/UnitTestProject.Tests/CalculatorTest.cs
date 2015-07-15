using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTests;

namespace UnitTestProject.Tests
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void TestAddNumbers()
        {
            //Arrange
            Calculator calc = new Calculator()
            {
                FirstName = "Koaquine",
                LastName = "Hernandez",
                Age = 35,
                Day = DateTime.Now
            };


            //Act
            decimal result = calc.TaxCalculator(100m, 0.08m);


            //Assert
            Assert.AreEqual(108.00m, result); //First parameter is what you expect, the second is what you actually got
        }
    }
}
