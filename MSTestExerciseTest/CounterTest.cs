using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSTestExercise;

namespace MSTestExerciseTest
{
    [TestClass]
    public class CounterTest
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

        [TestMethod]
        public void 実行2回目は2が返る()
        {
            _sut.Increment();
            var actual = _sut.Increment();

            Assert.AreEqual(2, actual);
        }
        [TestMethod]
        public void 実行51回目は51が返る()
        {
            Enumerable.Range(1, 50).ToList().ForEach(x => _sut.Increment());
            
            var actual = _sut.Increment();

            Assert.AreEqual(51, actual);
        }
    }
}
