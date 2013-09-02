﻿using System;
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

        [TestMethod]
        public void 引数が3の時()
        {
            var result = FizzBuzz.CreateFizzBuzzList(3);

            var expected = new List<String>() { "1", "2", "Fizz" };

            Assert.AreEqual(expected[0], result[0]);
            Assert.AreEqual(expected[1], result[1]);
            Assert.AreEqual(expected[2], result[2]);
        }

        [TestMethod]
        public void 引数が5の時()
        {
            var result = FizzBuzz.CreateFizzBuzzList(5);

            var expected = new List<String>() { "1", "2", "Fizz", "4", "Buzz" };

            Assert.AreEqual(expected[0], result[0]);
            Assert.AreEqual(expected[1], result[1]);
            Assert.AreEqual(expected[2], result[2]);
            Assert.AreEqual(expected[3], result[3]);
            Assert.AreEqual(expected[4], result[4]);
        }
    }
}
