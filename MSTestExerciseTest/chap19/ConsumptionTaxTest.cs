using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSTestExercise;
using MSTestExercise.chap19;

namespace MSTestExerciseTest.chap19
{
    [TestClass]
    public class ConsumptionTaxTest
    {
        [TestMethod]
        public void オブジェクトの生成()
        {
            var sut = new ConsumptionTax(5);
        }
    }
}
