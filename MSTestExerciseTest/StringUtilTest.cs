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

        [TestMethod]
        public void bbbを入力するとbbbが取得できる()
        {
            var result = StringUtil.ToSnakeCase("bbb");

            Assert.AreEqual("bbb", result);
        }
    }
}
