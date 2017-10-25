using System;
using System.Windows.Forms;
using System.Configuration;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace HorseBetTracking
{
    public partial class SaveBet : Form
    {
        private readonly string cutNPasteIllegalCharactersPattern;
        private readonly string keyPressValidCharsPattern;
        private FormMain formMain;
        private Bets b;

        public SaveBet(Bets b1, FormMain formMain)
        {
            InitializeComponent();
            this.b = b1;
            this.formMain = formMain;
            cutNPasteIllegalCharactersPattern = ConfigurationManager.AppSettings["CutNPasteIllegalCharactersPattern"];
            keyPressValidCharsPattern = ConfigurationManager.AppSettings["KeyPressValidCharsPattern"];
        }

        private void btnSaveNewBet_Click(object sender, EventArgs e)
        {
            string location = "";
            string err = "";
            DateTime betDate;
            decimal amount = 0.00m;
            decimal decOutput;
            bool outcome = false;
            bool error = false;

            // Get location
            if (cmbLocation.SelectedIndex == -1)
            {
                err += "Please select location" + Environment.NewLine;
                error = true;
            }
            else
            {
                // get the name of the location matching this index
                location = b.GetLocationName(cmbLocation.SelectedIndex);
            }

            // Get date
            betDate = dtpNewBet.Value.Date;

            // Get amount 
            if (decimal.TryParse(txtAmount.Text, out decOutput))
            {
                amount = decOutput;
                if (amount == 0.00M)
                {
                    error = true;
                    err += "Please enter amount" + Environment.NewLine;
                }
            }
            else
            {
                err += "Invalid amount" + Environment.NewLine;
                error = true;
            }

            // Get outcome
            if (cmbOutcome.SelectedIndex == -1)
            {
                err += "Please select outcome" + Environment.NewLine;
                error = true;
            }
            else
            {
                outcome = cmbOutcome.SelectedIndex == 0 ? true : false;
            }

            // Save new bet
            if (!error)
            {
                b.SaveNewBet(location, betDate, amount, outcome, formMain);

                this.Close();
            }
            else
            {
                MessageBox.Show(err, "ERROR");
            }

        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {

            Regex regExEngine = new Regex(cutNPasteIllegalCharactersPattern);

            if (regExEngine.IsMatch(txtAmount.Text))
            {
                MessageBox.Show("Illegal character(s) entered. Please try again");
                txtAmount.Text = "";
            }
            else
            {
                /*
                 * To avoid misstyping I used the following code 
                 * After the input is filtered it is cleaned and converted 
                 * to decimal format with two digits after deciaml point
                 */
                string temp = txtAmount.Text;
                // remove .
                temp = temp.Replace(".", "");
                temp = string.Format("{0:0.00}", decimal.Parse(temp) / 100);
                txtAmount.Text = temp;

            }
            txtAmount.SelectionStart = txtAmount.Text.Length;
        }
        /*
         * On Every KeyPress argument is checked against regex
         * only digit, decimal point and backspace are alowed in the format of decimal point
         */
        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!IsValidKey(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private bool IsValidKey(string key)
        {
            Regex regEngine = new Regex(keyPressValidCharsPattern);

            return regEngine.IsMatch(key);
        }
        /*
         * By using dropdown box I presume that all known locations are allready in the list 
         * When SaveBet form is loaded location dropbox is populated by query 
         * extracting all distinct locations from ListBet<string> file in Bets class 
         */
        private void SaveBet_Load(object sender, EventArgs e)
        {
            List<String> location = b.ExtractLocation();

            foreach (var item in location)
            {
                cmbLocation.Items.Add(item);
            }
        }

        private void txtAmount_MouseClick(object sender, MouseEventArgs e)
        {
            txtAmount.SelectionStart = txtAmount.Text.Length;
        }
    }
}
