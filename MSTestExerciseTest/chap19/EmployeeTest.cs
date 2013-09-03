using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSTestExercise;
using MSTestExercise.chap19;

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
    }
}
