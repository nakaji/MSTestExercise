using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSTestExercise;

namespace MSTestExerciseTest
{
    [TestClass]
    public class ItemStockTest
    {
        [TestClass]
        public class オブジェクト生成
        {
            private ItemStock sut;
            private Item item;

            [TestInitialize]
            public void SetUp()
            {
                sut = new ItemStock();
            }

            [TestMethod]
            public void 生成直後は0()
            {
                Assert.AreEqual(0, sut.GetNum(item));
            }
        }
    }
}
