using CalcLibrary;
using CalcLibrary.services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalcLibrary.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void Calculate_Addition_ReturnsCorrectSum()
        {
            var service = new CalculatorService();
            double result = service.Calculate("2+3");
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        [ExpectedException(typeof(CalculatorException))]
        public void Calculate_DivideByZero_ThrowsCalculatorException()
        {
            var service = new CalculatorService();
            service.Calculate("10÷0");
        }
    }
}