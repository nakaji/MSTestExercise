using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSTestExercise;

namespace MSTestExerciseTest
{
    [TestClass]
    public class CounterTest
    {
        [TestMethod]
        public void 初期状態では1が返る()
        {
            var sut = new Counter();

            var actual = sut.Increment();

            Assert.AreEqual(1, actual);
        }

        [TestMethod]
        public void 実行2回目は2が返る()
        {
            var sut = new Counter();

            sut.Increment();
            var actual = sut.Increment();

            Assert.AreEqual(2, actual);
        }
    }
}
