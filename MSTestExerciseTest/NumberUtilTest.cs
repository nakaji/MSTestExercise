using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSTestExercise;

namespace MSTestExerciseTest
{
    [TestClass]
    public class NumberUtilTest
    {
        [TestMethod]
        public void 引数が2の時はtrue()
        {
            Assert.IsTrue(NumberUtil.IsEven(2));
        }
    }
}
