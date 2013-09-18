using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSTestExercise;
using MSTestExercise.chap19;

namespace MSTestExerciseTest.chap19
{
    [TestClass]
    public class RangeTest
    {
        private Range sut;

        [TestInitialize]
        public void SetUp()
        {
            sut = new Range(1.1d, 9.98d); 
        }

        [TestMethod]
        public void オブジェクト生成()
        {
            Assert.AreEqual(1.1d, sut.Min);
            Assert.AreEqual(9.98d, sut.Max);
        }

        [TestMethod]
        public void 最小値未満の場合False()
        {
            Assert.IsFalse(sut.Contains(1.099999d));
        }

        [TestMethod]
        public void 最小値の場合True()
        {
            Assert.IsTrue(sut.Contains(1.1d));
        }

        [TestMethod]
        public void 最大値の場合True()
        {
            Assert.IsTrue(sut.Contains(9.98d));
        }

        [TestMethod]
        public void 最大値より大きい場合False()
        {
            Assert.IsFalse(sut.Contains(9.980001d));
        }

        [TestMethod]
        public void 範囲内はTrue()
        {
            Assert.IsTrue(sut.Contains(5.555d));
        }
    }
}
