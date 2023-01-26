using Lagged_Fibonacci_generator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net;

namespace NUnit
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestLogin()
        {
            string nickname = "Engineer"; // проверка на зарег. пользователя с таким логином
            bool expected = true;
            Registration test = new Registration();
            bool actual = test.CheckUser(nickname);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestAkk()
        {
            string nickname = "admin"; // свой логин
            string password = "12345"; // свой пароль
            Boolean expected = true;
            Authorization test = new Authorization();
            Boolean actual = test.check(nickname, password);
            Assert.AreNotEqual(expected, actual);
        }
        [TestMethod]
        public void TestNoAkk()
        {
            string nickname = "vsdv45"; // не свой логин и не свой пароль
            string password = "3435t";
            Boolean expected = false;
            Authorization test = new Authorization();
            Boolean actual = test.check(nickname, password);
            Assert.AreEqual(expected, actual);
        }
    }
}
