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

        [TestMethod]
        public void Aaaを入力するとaaaが取得できる()
        {
            var result = StringUtil.ToSnakeCase("Aaa");

            Assert.AreEqual("aaa", result);
        }

        [TestMethod]
        public void HelloWorldを入力するとhello_worldが取得できる()
        {
            var result = StringUtil.ToSnakeCase("HelloWorld");

            Assert.AreEqual("hello_world", result);
        }
        
        [TestMethod]
        public void practiceMsTestを入力するとpractice_ms_testが取得できる()
        {
            var result = StringUtil.ToSnakeCase("practiceMsTest");

            Assert.AreEqual("practice_ms_test", result);
        }
    }
}
