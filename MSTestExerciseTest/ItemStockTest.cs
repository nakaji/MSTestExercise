using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSTestExercise;

namespace MSTestExerciseTest
{
    [TestClass]
    public class ItemStockTest
    {
        [TestClass]
        public class 初期状態
        {
            private ItemStock sut;
            private Item item;

            [TestInitialize]
            public void SetUp()
            {
                sut = new ItemStock();
            }

            [TestMethod]
            public void 初期状態では0()
            {
                Assert.AreEqual(0, sut.GetNum(item));
            }

            [TestMethod]
            public void 初期状態でItemを追加すると1()
            {
                sut.Add(item);

                Assert.AreEqual(1, sut.GetNum(item));
            }
        }

        [TestClass]
        public class Itemが1つ追加された状態
        {
            private ItemStock sut;
            private Item item;

            [TestInitialize]
            public void SetUp()
            {
                sut = new ItemStock();
                sut.Add(item);
            }

            [TestMethod]
            public void Itemが1つ追加された状態では1()
            {
                Assert.AreEqual(1, sut.GetNum(item));
            }

            [TestMethod]
            public void Itemが1つ追加された状態で同じItemを追加すると2()
            {
                sut.Add(item);
                Assert.AreEqual(2, sut.GetNum(item));
            }
        }
    }
}
