using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace HorseBetTracking
{
    [Serializable]
    public class Bet //: IComparable<Bet>
    {

        private decimal _amount;
        private string _location;

        public Bet()
        {
        }
        // After we have done all test validations
        // We can create constructor to pass all parameters
        public Bet(string location, DateTime date, decimal amount, bool result)
        {
            Location = location;
            BetDate = date;
            Amount = amount;
            BetResult = result;
        }

        public String Location
        {
            get => _location;
            set
            {
                // Version 1
                //_location = value;

                // Version 2
                // Pattern for matching alpha characters
                string pattern = @"[^A-Za-z ]+?";
                Regex reEngine = new Regex(pattern);
                Match match = reEngine.Match(value);
                // Check for match
                // If No mactch => we have non letter space chracter 
                // throw exception
                if (match.Success)
                    throw new Exception("Location may contain only alpha characters or spaces!");
                else
                    _location = value;
            }
        }

        public decimal Amount
        {
            get => _amount;
            set
            {
                // Version 1
                // _amount = value;

                // Version 2
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Amount cannot be negative");
                else
                    _amount = value;
            }
        }

        public DateTime BetDate { get; set; }

        public bool BetResult { get; set; }

        private string ResultToText(bool b)
        {
            return b ? "Win" : "Lost";
        }

        public override string ToString()
        {
            return string.Format("  {0,-20}\t{1,-20}\t{2,-25}\t{3}\n", Location, BetDate.ToShortDateString(), Amount, ResultToText(BetResult));
        }
    }
}
