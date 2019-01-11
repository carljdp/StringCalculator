using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringCalculator;

namespace StringCalculator.Tests
{
    [TestClass]
    public class StringCalculatorTestSteps
    {
        [TestMethod]
        public void Step01_Add_TakesAString_ReturnsANumber()
        {
            var actual = Calculator.Add("");

            Assert.AreEqual(0, actual);

        }
    }
}
