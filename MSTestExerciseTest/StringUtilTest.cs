using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestExercise.Test
{
    [TestClass]
    public class StringUtilTest
    {
        [TestMethod]
        public void aaaを入力するとaaaが取得できる()
        {
            var result = StringUtil.ToSnakeCase("aaa");

            Assert.AreEqual("aaa", result);
        }
    }
}
