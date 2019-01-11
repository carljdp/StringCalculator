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

        [TestMethod]
        public void Step02_SingleNumber_ResturnsThatNumber()
        {
            var actual1 = Calculator.Add("1");
            var actual2 = Calculator.Add("3");

            Assert.AreEqual(1, actual1);
            Assert.AreEqual(3, actual2);

        }
    }
}
