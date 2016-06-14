using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Main;
using System.Linq;

namespace MainTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int a;
            a = 1; 
            string res = Program.Func(a);
            string corr = "один";
            Assert.AreEqual(res,corr);
        }
        [TestMethod]
        public void TestMethod2()
        {
            int a;
            a = 105;
            string res = Program.Func(a);
            var corr = "сто пять";
            Assert.AreEqual(res, corr);
        }
        [TestMethod]
        public void TestMethod3()
        {
            int a;
            a = 1915;
            string res = Program.Func(a);
            var corr = "одна тысяча девятьсот пятнадцать";
            Assert.AreEqual(res, corr);
        }
        [TestMethod]
        public void TestMethod4()
        {
            int a;
            a = 0;
            string res = Program.Func(a);
            var corr = "ноль";
            Assert.AreEqual(res, corr);
        }
    }
}
