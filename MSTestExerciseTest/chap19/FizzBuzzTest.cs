using System;
using System.Collections.Generic;
using System.Linq;
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
            var num = 1;
            var result = FizzBuzz.CreateFizzBuzzList(num);

            var expected = new List<String>() { "1" };

            Assert.AreEqual(num, result.Count());
            Assert.AreEqual(expected[0], result[0]);
        }

        [TestMethod]
        public void 引数が2の時()
        {
            var num = 2;
            var result = FizzBuzz.CreateFizzBuzzList(num);

            var expected = new List<String>() { "1", "2" };

            Assert.AreEqual(num, result.Count());
            foreach (var i in Enumerable.Range(0, num))
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }

        [TestMethod]
        public void 引数が3の時()
        {
            var num = 3;
            var result = FizzBuzz.CreateFizzBuzzList(num);

            var expected = new List<String>() { "1", "2", "Fizz" };

            Assert.AreEqual(num, result.Count());
            foreach (var i in Enumerable.Range(0, num))
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }

        [TestMethod]
        public void 引数が5の時()
        {
            var num = 5;
            var result = FizzBuzz.CreateFizzBuzzList(num);

            var expected = new List<String>() { "1", "2", "Fizz", "4", "Buzz" };

            Assert.AreEqual(num, result.Count());
            foreach (var i in Enumerable.Range(0, num))
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }

        [TestMethod]
        public void 引数が15の時()
        {
            var num = 15;
            var result = FizzBuzz.CreateFizzBuzzList(num);

            var expected = new List<String>() { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz" };

            Assert.AreEqual(num, result.Count());
            foreach (var i in Enumerable.Range(0, num))
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }
    }
}
