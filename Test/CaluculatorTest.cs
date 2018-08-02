using Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    /// <summary>
    /// CaluculatorTest 的摘要描述
    /// </summary>
    [TestClass]
    public class CaluculatorTest
    {
        public CaluculatorTest()
        {
            this.calculator = new Calculator();
        }

        private ICalculator calculator { get; }

        [TestMethod]
        public void TestAdd()
        {
            int actual;
            int expect = 2;

            actual = calculator.Add(1, 1);

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void TestMinus()
        {
            int actual;
            int expect = 0;

            actual = calculator.Minus(1, 1);

            Assert.AreEqual(expect, actual);
        }
    }
}