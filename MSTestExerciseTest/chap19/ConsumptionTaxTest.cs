using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSTestExercise;
using MSTestExercise.chap19;

namespace MSTestExerciseTest.chap19
{
    [TestClass]
    public class ConsumptionTaxTest
    {
        public TestContext TestContext { get; set; }
        
        [TestMethod]
        public void オブジェクトの生成()
        {
            var sut = new ConsumptionTax(5);
        }

        [TestMethod]
        [TestCase(5, 100, 105)]
        [TestCase(5, 3000, 3150)]
        [TestCase(10, 50, 55)]
        [TestCase(5, 50, 52)]
        [TestCase(3, 50, 51)]
        public void テスト()
        {
            TestContext.Run((int taxRate, int price, int expected) =>
                            {
                                var sut = new ConsumptionTax(taxRate);

                                sut.Apply(price).Is(expected);
                            });
        }
    }
}
