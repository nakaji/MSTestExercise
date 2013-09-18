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

        [TestMethod]
        public void 最小値未満の場合False()
        {
            var sut = new Range(1.1d, 9.98d);

            Assert.IsFalse(sut.Contains(1.099999d));
        }

        [TestMethod]
        public void 最小値の場合True()
        {
            var sut = new Range(1.1d, 9.98d);

            Assert.IsTrue(sut.Contains(1.1d));
        }

        [TestMethod]
        public void 最大値の場合True()
        {
            var sut = new Range(1.1d, 9.98d);

            Assert.IsTrue(sut.Contains(9.98d));
        }

        [TestMethod]
        public void 最大値より大きい場合False()
        {
            var sut = new Range(1.1d, 9.98d);

            Assert.IsFalse(sut.Contains(9.980001d));
        }
    }
}
