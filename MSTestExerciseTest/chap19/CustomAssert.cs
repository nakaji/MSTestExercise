using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestExerciseTest.chap19
{
    public static class CustomAssert
    {
        public static void AreEqual(string expected, string actual)
        {
            var exp = expected.Split('\n');
            var act = actual.Split('\n');

            if (exp.Count() != act.Count())
            {
                throw new AssertFailedException(string.Format("CustomAssert.AreEqualに失敗しました。要素の個数が<{0}>必要ですが、<{1}>しかありません", exp.Count(), act.Count()));
            }

            for (var i = 0; i < exp.Length; i++)
            {
                if (!act[i].Equals(exp[i]))
                {
                    throw new AssertFailedException(string.Format("CustomAssert.AreEqualに失敗しました。{0}番目の要素の個数が異なります。期待値：{1}　実績値：{2}", i+1, exp[i], act[i]));
                }
            }

        }
    }

    [TestClass]
    public class CustomAssertTest
    {
        [TestMethod]
        public void 正常()
        {
            CustomAssert.AreEqual("!", "!");
        }

        [TestMethod]
        public void 予想より少ない()
        {
            try
            {
                CustomAssert.AreEqual("A\nB\nC", "A\nB");
            }
            catch (AssertFailedException ex)
            {
                Assert.AreEqual("CustomAssert.AreEqualに失敗しました。要素の個数が<3>必要ですが、<2>しかありません", ex.Message);
            }
        }

        [TestMethod]
        public void 二番目の要素が異なる場合()
        {
            try
            {
                CustomAssert.AreEqual("A\nB\nC", "A\nb\nC");
            }
            catch (AssertFailedException ex)
            {
                Assert.AreEqual("CustomAssert.AreEqualに失敗しました。2番目の要素の個数が異なります。期待値：B　実績値：b", ex.Message);
            }
        }
    }
}
