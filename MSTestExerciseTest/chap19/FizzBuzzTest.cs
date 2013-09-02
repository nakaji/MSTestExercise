using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSTestExercise.chap19;

namespace MSTestExerciseTest.chap19
{
    [TestClass]
    public class FizzBuzzTest
    {
        [TestMethod]
        public void 引数が1の時()
        {
            var result = FizzBuzz.CreateFizzBuzzList(1);

            var expected = new List<String>() { "1" };

            Assert.AreEqual(expected[0], result[0]);
        }

        [TestMethod]
        public void 引数が2の時()
        {
            var result = FizzBuzz.CreateFizzBuzzList(2);

            var expected = new List<String>() { "1", "2" };

            Assert.AreEqual(expected[0], result[0]);
            Assert.AreEqual(expected[1], result[1]);
        }
    }
}
