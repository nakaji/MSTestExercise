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
            var expected = new List<String>() {"1"};
            Assert.AreSame(expected[0], result[0]);
        }
    }
}
