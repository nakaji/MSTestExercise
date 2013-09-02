using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSTestExercise;

namespace MSTestExerciseTest
{
    [TestClass]
    public class CounterTest
    {
        [TestClass]
        private class 初期状態
        {
            private Counter _sut;

            [TestInitialize]
            public void SetUp()
            {
                _sut = new Counter();
            }

            [TestMethod]
            public void 初期状態では1が返る()
            {
                var actual = _sut.Increment();

                Assert.AreEqual(1, actual);
            }
        }

        [TestClass]
        private class 実行2回目
        {
            private Counter _sut;

            [TestInitialize]
            public void SetUp()
            {
                _sut = new Counter();
                _sut.Increment();
            }
            
            [TestMethod]
            public void 実行2回目は2が返る()
            {
                var actual = _sut.Increment();

                Assert.AreEqual(2, actual);
            }
        }

        [TestClass]
        private class 実行51回目
        {
            private Counter _sut;

            [TestInitialize]
            public void SetUp()
            {
                _sut = new Counter();
                Enumerable.Range(1, 50).ToList().ForEach(x => _sut.Increment());
            }

            [TestMethod]
            public void 実行51回目は51が返る()
            {

                var actual = _sut.Increment();

                Assert.AreEqual(51, actual);
            }
        }
    }
}
