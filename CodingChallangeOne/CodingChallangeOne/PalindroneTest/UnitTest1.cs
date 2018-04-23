using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingChallange;

namespace PalindroneTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            PEvaluator tester = new PEvaluator();
            string s1 = "Race";
            Assert.AreEqual(false, tester.Palindrome(s1));
        }
        public void TestMethod2()
        {
            PEvaluator tester = new PEvaluator();
            string s1 =  "Racecar";
            Assert.AreEqual(true, tester.Palindrome(s1));
        }
        public void TestMethod3()
        {
            PEvaluator tester = new PEvaluator();
            string s1 = "1e3e1";
            Assert.AreEqual(true, tester.Palindrome(s1));
        }
    }
}
