using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSTestExercise;

namespace MSTestExerciseTest
{
    [TestClass]
    public class BackgroundTaskTest
    {
        [TestClass]
        public class オブジェクト生成
        {
            [TestMethod]
            public void コンストラクタでRunnableオブジェクトを引数に持つ()
            {
                var sut = new BackgroundTask(new Runnable());
            }
        }
    }
}
