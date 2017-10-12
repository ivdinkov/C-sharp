using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindrome;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void IsPalindromeNullCheckerTest()
        {
            PalindromeChecker p = new PalindromeChecker();
            p.IsPallindrome(null);
        }

        [TestMethod]
        public void IsPalindromeCheckerTest()
        {
            // Arrange
            PalindromeChecker p = new PalindromeChecker();
            string send = "karak";
            bool expected = true;
            // Act
            bool actual = p.IsPallindrome(send);
            // Assert
            Assert.AreEqual(expected,actual);
        }

    }
}
