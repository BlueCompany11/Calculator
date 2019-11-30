using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExceptionalCalculator;

namespace UTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAdd()
        {
            var calc = new Calculator();
            calc.Add(10);
            Assert.AreEqual(calc.Value, 10);

            calc = new Calculator();
            calc.Add(20);
            Assert.AreNotEqual(calc.Value, 10);
        }
    }
}
