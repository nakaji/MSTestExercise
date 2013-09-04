using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSTestExercise.chap19;

namespace MSTestExerciseTest.chap19
{
    [TestClass]
    public class MultiLineStringTest
    {
        [TestMethod]
        public void 引数の文字列を改行で連結する()
        {
            var result = MultiLineString.Join("Hello", "World");

            CustomAssert.AreEqual("Hello\nWorld", result);
        }
    }
}
