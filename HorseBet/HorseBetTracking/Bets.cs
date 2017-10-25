using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HorseBetTracking
{
    public class Bets
    {
        private static List<Bet> ListBet;
        private static List<String> ListLocation;
        private readonly string USER_PROFILE_PATH;
        private readonly string FILE_NAME;
        private string PATH_NAME;

        

        public Bets()
        {
            ListBet = new List<Bet>();
            ListLocation = new List<string>();
            USER_PROFILE_PATH = GetUserHomeDirectory();
            FILE_NAME = GetFileName();
            PATH_NAME = $@"{USER_PROFILE_PATH}\{FILE_NAME}";
            StartApp();
        }

        // Start Application
        private void StartApp()
        {
            if (IsFirstTime())
            {
                CreateBetsToObjectsAndSavetoList();
                // Create the Bets file and write old bets to it
                if (!WriteBetsFromListToFile())
                {
                    MessageBox.Show("Unable to create bets file");
                }
            }
            else
            {
                // Extract Bets data to list for later use
                if (!ReadBetFileToList())
                {
                    MessageBox.Show("Unable to read bets file");
                }
            }
        }
        
        // Convert list to string to be displayed in reach text box
        public string GetBetObjectsFromListAsString()
        {
            string s = "";
            foreach (Bet item in ListBet)
            {
                s += item + Environment.NewLine;

            }
            return s;
        }
        
        // Desirialize binary file to list of bet objects
        private bool ReadBetFileToList()
        {
            try
            {
                // Open file to read bets records to list
                using (Stream fs = File.Open($@"{PATH_NAME}", FileMode.Open))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    try
                    {
                        ListBet = (List<Bet>)formatter.Deserialize(fs);
                        return true;
                    }
                    catch (SerializationException e)
                    {
                        MessageBox.Show("Failed to serialize. Reason: " + e.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }
       
        // Save new object to list and serialize to file newly created list
        public void SaveNewBet(string location, DateTime betDate, decimal amount, bool outcome, FormMain form)
        {
            // Create new Bet Object
            Bet bet = new Bet(location, betDate, amount, outcome);
            // Add new record to ListBet and rewrite bet file
            try
            {
                AddNewBetToList(bet);
            }
            catch (Exception e)
            {
                MessageBox.Show("Failed to add new bet to list. Reason: " + e.Message);
            }
            // Write the existing bets to the Bets.bin file
            WriteBetsFromListToFile();
            // Refresh rtbMain
            form.UpdateForm();
        }
        
        // Add new bet to list
        public void AddNewBetToList(Bet bet)
        {
            if (bet == null)
            {
                throw new ArgumentNullException();
            }
            else
            {
                ListBet.Add(bet);
            }
        }
       
        // Serialize list objects to binary file
        private bool WriteBetsFromListToFile()
        {
            try
            {
                // Open file to store bets records in user home directory
                using (Stream fs = File.Open($@"{PATH_NAME}", FileMode.OpenOrCreate, FileAccess.ReadWrite))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    try
                    {
                        formatter.Serialize(fs, ListBet);
                        return true;
                    }
                    catch (SerializationException e)
                    {
                        MessageBox.Show("Failed to serialize. Reason: " + e.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }
        
        // Check if Appliaction runs first time
        private bool IsFirstTime()
        {
            return !File.Exists(PATH_NAME);
        }
        
        // Create new binary file name
        private string GetFileName()
        {
            return "Bets.bin";
        }
        
        // Get user home directory
        private string GetUserHomeDirectory()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        }
       
        // Initial write of harcoded bets to list
        public void CreateBetsToObjectsAndSavetoList()
        {
           
            ListBet.Add(new Bet("Aintree", new DateTime(2017, 5, 12), 11.58m, true));
            ListBet.Add(new Bet("Punchestown", new DateTime(2016, 12, 22), 122.52m, true));
            ListBet.Add(new Bet("Sandown", new DateTime(2016, 11, 17), 20.00m, false));
            ListBet.Add(new Bet("Ayr", new DateTime(2016, 11, 03), 25.00m, false));
            ListBet.Add(new Bet("Fairyhouse", new DateTime(2016, 12, 02), 65.75m, true));
            ListBet.Add(new Bet("Ayr", new DateTime(2017, 3, 11), 12.05m, true));
            ListBet.Add(new Bet("Doncaster", new DateTime(2017, 12, 02), 10.00m, false));
            ListBet.Add(new Bet("Towcester", new DateTime(2016, 3, 12), 50.00m, false));
            ListBet.Add(new Bet("Goodwood", new DateTime(2017, 10, 07), 525.74m, true));
            ListBet.Add(new Bet("Kelso", new DateTime(2016, 9, 13), 43.21m, true));
            ListBet.Add(new Bet("Punchestown", new DateTime(2017, 7, 05), 35.00m, false));
            ListBet.Add(new Bet("Ascot", new DateTime(2016, 2, 04), 23.65m, true));
            ListBet.Add(new Bet("Kelso", new DateTime(2017, 8, 02), 30.00m, false));
            ListBet.Add(new Bet("Towcester", new DateTime(2017, 5, 01), 104.33m, true));
            ListBet.Add(new Bet("Ascot", new DateTime(2017, 6, 21), 25.00m, false));
            ListBet.Add(new Bet("Bangor", new DateTime(2016, 12, 22), 30.00m, false));
            ListBet.Add(new Bet("Ayr", new DateTime(2017, 5, 22), 11.50m, true));
            ListBet.Add(new Bet("Ascot", new DateTime(2017, 6, 23), 30.00m, false));
            ListBet.Add(new Bet("Ascot", new DateTime(2017, 6, 23), 374.27m, true));
            ListBet.Add(new Bet("Goodwood", new DateTime(2016, 10, 05), 34.12m, true));
            ListBet.Add(new Bet("Dundalk", new DateTime(2016, 11, 09), 20.00m, false));
            ListBet.Add(new Bet("Haydock", new DateTime(2016, 11, 12), 87.00m, true));
            ListBet.Add(new Bet("Perth", new DateTime(2017, 1, 20), 15.00m, false));
            ListBet.Add(new Bet("York", new DateTime(2017, 11, 11), 101.25m, true));
            ListBet.Add(new Bet("Punchestown", new DateTime(2016, 12, 22), 11.50m, true));
            ListBet.Add(new Bet("Chester", new DateTime(2016, 8, 14), 10.00m, false));
            ListBet.Add(new Bet("Kelso", new DateTime(2016, 9, 18), 10.00m, false));
            ListBet.Add(new Bet("Kilbeggan", new DateTime(2017, 3, 03), 20.00m, false));
            ListBet.Add(new Bet("Fairyhouse", new DateTime(2017, 3, 11), 55.50m, true));
            ListBet.Add(new Bet("Punchestown", new DateTime(2016, 11, 15), 10.00m, false));
            ListBet.Add(new Bet("Towcester", new DateTime(2016, 5, 08), 16.55m, true));
            ListBet.Add(new Bet("Punchestown", new DateTime(2016, 5, 23), 13.71m, true));
            ListBet.Add(new Bet("Cork", new DateTime(2016, 11, 30), 20.00m, false));
            ListBet.Add(new Bet("Punchestown", new DateTime(2016, 4, 25), 13.45m, true));
            ListBet.Add(new Bet("Bangor", new DateTime(2016, 1, 23), 10.00m, false));
        }
       
        // Extract location from old existing bets to be used in a dropdown list
        public List<String> ExtractLocation()
        {
            // Version 1
            //return ListLocation;

            // Version 2
            //var raceLocations = ListBet
            //       .Select(e => e.Location)
            //       .Distinct();
            //return ListLocation;

            // Version 3
            var raceLocations = ListBet
                   .OrderBy(e => e.Location)
                   .Select(e => e.Location)
                   .Distinct();
            foreach (var item in raceLocations)
            {
                ListLocation.Add(item);
            }
            return ListLocation;
        }
        
        // Get name of location by index
        public string GetLocationName(int index)
        {
            // Version 1
            //return null;
            // Version 2
            if (ListLocation[index] == null)
                throw new ArgumentOutOfRangeException("Invalid index");
            return ListLocation[index];
        }
        
        // Most popular location
        public string GetMostPopularLocation()
        {
            // Version 1
            //return null;
            // Version 2
            return ListBet.GroupBy(bets => bets.Location).OrderByDescending(bets => bets.Count()).First().Key;
        }
        
        // Sort by date
        public string SortBetsByDate()
        {
            // Version 1
            // return null;

            // Version 2. For version 2 to work line 52 in MainForm.cs should be commented
            //List<string> sortedDates = new List<string>();
            //var sortedByDate = from bets in ListBet
            //                   orderby bets.BetDate
            //                   select bets.BetDate.ToShortDateString();
            //foreach (var item in sortedByDate)
            //{
            //    sortedDates.Add(item);
            //}
            //return sortedDates;

            // Version 3
            string sortedDates = "";
            var sortedByDate = from bets in ListBet
                               orderby bets.BetDate
                               select bets;
            foreach (var item in sortedByDate)
            {
                sortedDates += item + "\n";
            }
            return sortedDates;
        }

        // Group By Year/Won/Lost
        public string GetReportByYear()
        {

            // Version 1
            //return null;

            // Version 2 wins for 2016
            //var res = ListBet.Where(b => b.BetDate.Year == 2016).Select(x => new { x.Amount, x.BetResult });
            //var f = res.Where(g => g.BetResult == true).Sum(z => z.Amount).ToString();

            // Version 3 wins for 2017
            //var res = ListBet.Where(b => b.BetDate.Year == 2017).Select(x => new { x.Amount, x.BetResult });
            //var f = res.Where(g => g.BetResult == true).Sum(z => z.Amount).ToString();

            // Version 4 lost for 2016
            //var res = ListBet.Where(b => b.BetDate.Year == 2016).Select(x => new { x.Amount, x.BetResult });
            //var f = res.Where(g => g.BetResult == false).Sum(z => z.Amount).ToString();

            // Version 5 lost for 2017
            //var res = ListBet.Where(b => b.BetDate.Year == 2017).Select(x => new { x.Amount, x.BetResult });
            //var f = res.Where(g => g.BetResult == false).Sum(z => z.Amount).ToString();

            // Version 6
            //string s = "";
            //var result = from bets in ListBet
            //             orderby bets.BetDate
            //             let g = new
            //             {
            //                 Year = bets.BetDate.Year
            //             }
            //             group bets by g into z
            //             select new
            //             {
            //                 Year = z.Key.Year,
            //                 Lost = z.Where(v => v.BetResult == false).Sum(v => v.Amount),
            //                 win = z.Where(v => v.BetResult == true).Sum(v => v.Amount)
            //             };
            //var k = result.ToList();

            //foreach (var item in result)
            //{
            //    s += $"{item.Year},{item.win},{item.Lost}#";
            //}
            //return s;

            // Version 7
            string s = "";
            var result = from bets in ListBet
                         orderby bets.BetDate
                         let g = new
                         {
                             Year = bets.BetDate.Year
                         }
                         group bets by g into z
                         select new
                         {
                             Year = z.Key.Year,
                             Lost = z.Where(v => v.BetResult == false).Sum(v => v.Amount),
                             win = z.Where(v => v.BetResult == true).Sum(v => v.Amount)
                         };
            var k = result.ToList();

            foreach (var item in result)
            {
                s += $"   {item.Year}\t{item.win}\t{item.Lost}\n";
            }
            return s;

        }

        // Total win out of total bets
        public string BetsWonOutOfTotal()
        {
            // Vesrion 1
            //return null;

            // Vearion 2 
            // wins
            // return ListBet.Count(b => b.BetResult == true).ToString();

            // Vearion 3 
            // total
            // return ListBet.Count(b => b.Location != "").ToString();

            // Vesrion 4
            string s = "";
            var totalCount = ListBet.Count(b => b.Location != "").ToString();
            var totalWin = ListBet.Count(b => b.BetResult == true).ToString();
            s = $"{totalWin} wins out of total {totalCount}";

            return s;
        }

        // Max Win
        public string GetHighestWin()
        {
            // Version 1
            //return null;

            // Vesrion 2
            string s = "";
            var win = ListBet.Where(t => t.BetResult == true).OrderByDescending(t => t.Amount).FirstOrDefault();
            s = $"{win.Amount.ToString()}";
            return s;
        }

        // Max Lost
        public string GetHighestLost()
        {
            // Version 1
            //return null;

            // Vesrion 2
            string s = "";
            var lost = ListBet.Where(l => l.BetResult == false).OrderByDescending(l => l.Amount).FirstOrDefault();
            s = $"{lost.Amount.ToString()}";
            return s;
        }
    }
}
