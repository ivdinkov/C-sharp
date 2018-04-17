using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HorseBetTracking;
using System.Collections.Generic;

namespace HorseBetTrackingTest
{
    [TestClass]
    public class HorseBetTrackingBetTest
    {
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void LocationInBetObjectShouldThrowExceptionIfdifferentThanAlphaCharacterTest()
        {
            // Arrange
            Bet b = new Bet();

            // Act
            b.Location = "Location 1";// should throw exception if location contains digit
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void AmountNegativeCheckWhenNewBetObjectCreatedTest()
        {
            // Arrange
            Bet b = new Bet();

            // Act
            b.Amount = -10;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddNewBetObjectToListTest()
        {
            // Arrange
            Bets b = new Bets();
            Bet bet = null; // new Bet() to fail

            // Act
            b.AddNewBetToList(bet);
        }

        [TestMethod]
        public void CheckDropDownListCreationTest()
        {
            // List should be sorted and values distinct
            // Arrange
            Bets b = new Bets();
            List<String> expected = new List<string>()
            {
                "Aintree",
                "Ascot",
                "Ayr",
                "Bangor",
                "Chester",
                "Cork",
                "Doncaster",
                "Dundalk",
                "Fairyhouse",
                "Goodwood",
                "Haydock",
                "Kelso",
                "Kilbeggan",
                "Perth",
                "Punchestown",
                "Sandown",
                "Towcester",
                "York"
            };
            // Act
            List<string> actual = b.ExtractLocation();

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CheckSelectedDropDownListNameTest()
        {
            // Arange version 1 checking for negative exception
            //Bets b = new Bets();
            //int send = -31;
            //string actual = b.GetLocationName(send);

            // Arange version 2 cheching for out of range in the list
            //Bets b = new Bets();
            //int send = 50;
            //string actual = b.GetLocationName(send);

            // Vesrion 3
            // Arange
            Bets b = new Bets();
            int send = 3;
            b.GetLocationName(send);
        }

        [TestMethod]
        public void CheckMostPopularLocationTest()
        {
            // Arange
            Bets b = new Bets();
            string expected = "Punchestown";
            string actual = "";
            // Act
            actual = b.GetMostPopularLocation();
            // Assert
            Assert.AreEqual(expected, actual, true);
        }

        [TestMethod]
        public void CheckSortedYearsTest()
        {

            // comment out only with version 1,2 of SortBetsByDate()

            //// List should be sorted and values distinct
            //// Arrange
            //Bets b = new Bets();
            //List<String> expected = new List<string>()
            //{
            //    "23/01/2016",
            //    "04/02/2016",
            //    "12/03/2016",
            //    "25/04/2016",
            //    "08/05/2016",
            //    "23/05/2016",
            //    "14/08/2016",
            //    "13/09/2016",
            //    "18/09/2016",
            //    "05/10/2016",
            //    "03/11/2016",
            //    "09/11/2016",
            //    "12/11/2016",
            //    "15/11/2016",
            //    "17/11/2016",
            //    "30/11/2016",
            //    "02/12/2016",
            //    "22/12/2016",
            //    "22/12/2016",
            //    "22/12/2016",
            //    "20/01/2017",
            //    "03/03/2017",
            //    "11/03/2017",
            //    "11/03/2017",
            //    "01/05/2017",
            //    "12/05/2017",
            //    "22/05/2017",
            //    "21/06/2017",
            //    "23/06/2017",
            //    "23/06/2017",
            //    "05/07/2017",
            //    "02/08/2017",
            //    "07/10/2017",
            //    "11/11/2017",
            //    "02/12/2017"
            //};
            //// Act            
            //// List<string> actual = b.SortBetsByDate();

            //// Assert
            ////CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckHighestWinTest()
        {

            // Arrange
            Bets b = new Bets();
            string expected = "525.74";

            // Act
            string actual = b.GetHighestWin();

            // Assert
            Assert.AreEqual(expected,actual,true);
        }

        [TestMethod]
        public void CheckHighestLostTest()
        {

            // Arrange
            Bets b = new Bets();
            string expected = "50.00";

            // Act
            string actual = b.GetHighestLost();

            // Assert
            Assert.AreEqual(expected, actual, true);
        }

        [TestMethod]
        public void CheckTotalNumberOfWinsTest()
        {            
            // Arrange
            Bets b = new Bets();

            ////version 2 wins
            //string expected = "18";
            ////Act
            //string actual = b.BetsWonOutOfTotal();

            //// version 3 checking for total
            //string expected = "35";
            //// Act
            //string actual = b.BetsWonOutOfTotal();

            // version 3 checking for total
            string expected = "18 wins out of total 35";
            // Act
            string actual = b.BetsWonOutOfTotal();

            // Assert
            Assert.AreEqual(expected,actual,false);
        }

        [TestMethod]
        public void CheckWinsAndLostByYearTest()
        {

            /*
             * To test wins and lost per year we can run separate test 
             * 
             */
            // Arrange
            Bets b = new Bets();
            // version 1 win for 2016
            //string expected = "431.46";

            // version 2 win for 2017
            //string expected = "1196.22";

            // version 3 lost for 2016
            //string expected = "205.00";

            // version 4 lost for 2017
            //string expected = "165.00";

            // version 5 
            string expected = "2016,431.46,205.00#2017,1196.22,165.00#";

            // Act
            string actaul = b.GetReportByYear();

            // Assert
            Assert.AreEqual(expected,actaul,true);
        }
    }
}
