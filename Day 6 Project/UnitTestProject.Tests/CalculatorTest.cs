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
                FirstName = "Joaquine",
                LastName = "Hernandez",
                Age = 35,
                DayOfWeek = DayOfWeek.Thursday
            };


            //Act
            decimal result = calc.TaxCalculator(100m, 0.08m);


            //Assert
            Assert.AreEqual(132.00m, result); //First parameter is what you expect, the second is what you actually got
        }
    }
}
