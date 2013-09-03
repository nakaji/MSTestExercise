using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSTestExercise;
using MSTestExercise.chap19;
using System.Linq;

namespace MSTestExerciseTest.chap19
{
    [TestClass]
    public class EmployeeTest
    {
        [TestMethod]
        public void Employeeオブジェクトの生成()
        {
            var sut = new Employee("FirstName", "LastName", "Email");

            Assert.AreEqual("FirstName", sut.FirstName);
            Assert.AreEqual("LastName", sut.LastName);
            Assert.AreEqual("Email", sut.Email);
        }

        [TestClass]
        public class テキストファイルが存在しない場合
        {
            [TestMethod]
            [ExpectedException(typeof(FileNotFoundException))]
            public void FileNotFoundExceptionが発生する()
            {
                Employee.Load("notExistsFile.txt");
            }
        }

        [TestClass]
        public class テキストファイルが空の場合
        {
            [TestMethod]
            public void 空のリストを返す()
            {
                var result  = Employee.Load(@"chap19\Data\emptyFile.txt");

                Assert.AreEqual(0,result.Count());
            }
        }
    }
}
