using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSTestExercise;
using MSTestExercise.chap19;

namespace MSTestExerciseTest.chap19
{
    [TestClass]
    public class RangeTest
    {
        [TestMethod]
        public void オブジェクト生成()
        {
            var range = new Range(1.1d, 9.98d);

            Assert.AreEqual(1.1d, range.Min);
            Assert.AreEqual(9.98d, range.Max);
        }
    }
}
