using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSTestExercise;

namespace MSTestExerciseTest
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void 割り算_8と4で2が返る()
        {
            var result = Calculator.Divide(8, 4);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void 割り算_27と9で3が返る()
        {
            var result = Calculator.Divide(27, 9);

            Assert.AreEqual(3, result);
        }
    }
}
