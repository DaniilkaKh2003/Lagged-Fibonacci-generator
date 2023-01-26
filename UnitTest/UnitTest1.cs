using Lagged_Fibonacci_generator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Collections;
using System.Data.Entity;
using System.Windows.Forms;

namespace UnitTest
{ 
    [TestClass]
    public class UnitTest1
    {
        private string Hash(string password)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(password));
                var sb = new StringBuilder(hash.Length * 2);
                foreach (byte b in hash) { sb.Append(b.ToString("x2")); }
                return sb.ToString();
            }
        }
        [TestMethod]
        public void TestRegistration()
        {
            string nickname = "dani_23";
            bool expected = true;
            Registration test = new Registration();
            bool actual = test.CheckUser(nickname);
            Assert.AreNotEqual(expected, actual);
        }
        [TestMethod]
        public void TestRegistrationNOT()
        {
            string nickname = "daniil";
            bool expected = false;
            Registration test = new Registration();
            bool actual = test.CheckUser(nickname);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestAuthorization()
        {
            string nickname = "dani_23"; 
            string password = Hash("password"); 
            Boolean expected = true;
            Authorization test = new Authorization();
            Boolean actual = test.CheckUserNP(nickname, password);
            Assert.AreNotEqual(expected, actual);
        }
        [TestMethod]
        public void TestAuthorizationNOT()
        {
            string nickname = "daniil";
            string password = Hash("password");
            Boolean expected = false;
            Authorization test = new Authorization();
            Boolean actual = test.CheckUserNP(nickname, password);
            Assert.AreEqual(expected, actual);
        }
    }
}
