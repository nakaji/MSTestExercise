﻿using System;
using System.Threading;
using System.Threading.Tasks;
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
                var sut = new BackgroundTask(new Runnable(new Task(() => { })));
            }
        }

        [TestMethod, Timeout(1000)]
        public void Invokeメソッドで処理を実行する()
        {
            int count = 0;
            var sut = new BackgroundTask(new Runnable(new Task(() =>
                                                               {
                                                                   Thread.Sleep(500);
                                                                   count++;
                                                               })));

            var task = sut.Invoke();

            Assert.AreEqual(0, count);
            task.ContinueWith(x => Assert.AreEqual(1, count));
           
        }
    }

    [TestClass]
    public class RunnableTest
    {
        [TestMethod]
        public void Runメソッドで処理を実行する()
        {
            int count = 0;
            var sut = new Runnable(new Task(() => { count++; }));

            sut.Run.Start();
            sut.Run.Wait();

            Assert.AreEqual(1, count);
        }

    }
}