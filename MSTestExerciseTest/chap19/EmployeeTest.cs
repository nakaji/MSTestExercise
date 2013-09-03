using System;
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
    }
}
