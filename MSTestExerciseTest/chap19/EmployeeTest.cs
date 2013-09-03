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

        [TestClass]
        public class テキストファイルに2件データが存在する場合
        {
            [TestMethod]
            public void Employeeが2件格納されたリストを返す()
            {
                var result = Employee.Load(@"chap19\Data\twoEmployeeFile.txt");

                Assert.AreEqual(2, result.Count());

                Assert.AreEqual(new Employee("Ichiro", "Tanaka", "ichiro@example.com"), result[0]);
                Assert.AreEqual(new Employee("Jiro", "Suzuki", "jiro@example.com"), result[1]);
            }
        }
    }
}
