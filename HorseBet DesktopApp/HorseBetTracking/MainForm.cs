using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HorseBetTracking
{
    public partial class FormMain : Form
    {
        private static Bets b;

        public FormMain()
        {
            InitializeComponent();
            b = new Bets();
        }

        private void btnAddNewBet_Click(object sender, EventArgs e)
        {
            new SaveBet(b,this).Show();
        }

        public void FormMain_Load(object sender, EventArgs e)
        {
            // Load all fields with values
            rtbMain.Text = b.GetBetObjectsFromListAsString();
            lblMostPopularLocation.Text = b.GetMostPopularLocation();
            rtbByYear.Text = b.GetReportByYear();
            lblHighestLost.Text = b.GetHighestLost();
            lblHighestWin.Text = b.GetHighestWin();
            lblTotalBets.Text = b.BetsWonOutOfTotal();
            
        }
        /* Bellow method runs all the queries to populate the MainForm
         * All fields are populated by calls to Bets class
         * the method bellow is called from SaveNewBet 
         * when new bet is saved to list.
         * This way newly created Bet object immediatelly is displayed on the form
         */
        public void UpdateForm()
        {
            // Update form
            rtbMain.Text = b.GetBetObjectsFromListAsString();
            lblMostPopularLocation.Text = b.GetMostPopularLocation();
            rtbByYear.Text = b.GetReportByYear();
            lblHighestLost.Text = b.GetHighestLost();
            lblHighestWin.Text = b.GetHighestWin();
            lblTotalBets.Text = b.BetsWonOutOfTotal();
        }

        /*
         * Bellow method sorts all bets by year
         */
        private void btnSortAllByYear_Click(object sender, EventArgs e)
        {
            rtbMain.Clear();
            rtbMain.Text = b.SortBetsByDate();
        }

    }
}
