using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using College;


namespace CollegeTest
{
    [TestClass]
    public class PersonTest
    {
        [TestMethod]
        public void Test_IsPpsnExist()
        {
            // Arrange
            string ppsn = "1000008AB";
            bool expected = false; // expected = true => should fail because no test objects are created with this ppsn

            // Actual
            bool actual = College.College.IsPpsnExistInList(ppsn);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Test_GenerateId()
        {
            // check if method is going to throw exception when invalid status is passed
            // valid range (x >=1 || x<=3)
            // failing the test => works as not throwing exception 
            // Arange
            int status = 2;
            College.College.GenerateID(status);
        }

        [TestMethod]
        public void Test_ValidateMenuChoice()
        {
            // Menu should accept only digit 1 to 10
            // Arrange
            int choice = 0;
            bool expected = true;
            bool actual;

            // Actual
            actual = College.College.Range(choice, 1, 10);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_IsDeciaml()
        {
            // Arrange
            // shoud fail if 1000k
            string salary = "1000.00";
            bool expected = true;
            bool actual;

            // Actual
            actual = College.College.IsDecimal(salary, out decimal z);

            // Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
