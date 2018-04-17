namespace HorseBetTracking
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddNewBet = new System.Windows.Forms.Button();
            this.grbYearReport = new System.Windows.Forms.GroupBox();
            this.lblTotalLostPerYear = new System.Windows.Forms.Label();
            this.lblTotalWinPerYear = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.rtbByYear = new System.Windows.Forms.RichTextBox();
            this.grbAll = new System.Windows.Forms.GroupBox();
            this.lblOutcome = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.rtbMain = new System.Windows.Forms.RichTextBox();
            this.grbMostPopular = new System.Windows.Forms.GroupBox();
            this.lblMostPopularLocation = new System.Windows.Forms.Label();
            this.grbSuccess = new System.Windows.Forms.GroupBox();
            this.lblTotalBets = new System.Windows.Forms.Label();
            this.btnSortAllByYear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblHighestLost = new System.Windows.Forms.Label();
            this.lblHighestWin = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grbYearReport.SuspendLayout();
            this.grbAll.SuspendLayout();
            this.grbMostPopular.SuspendLayout();
            this.grbSuccess.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(513, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hot Tipster";
            // 
            // btnAddNewBet
            // 
            this.btnAddNewBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewBet.Location = new System.Drawing.Point(706, 571);
            this.btnAddNewBet.Name = "btnAddNewBet";
            this.btnAddNewBet.Size = new System.Drawing.Size(405, 36);
            this.btnAddNewBet.TabIndex = 2;
            this.btnAddNewBet.Text = "Add New Bet";
            this.btnAddNewBet.UseVisualStyleBackColor = true;
            this.btnAddNewBet.Click += new System.EventHandler(this.btnAddNewBet_Click);
            // 
            // grbYearReport
            // 
            this.grbYearReport.Controls.Add(this.lblTotalLostPerYear);
            this.grbYearReport.Controls.Add(this.lblTotalWinPerYear);
            this.grbYearReport.Controls.Add(this.lblYear);
            this.grbYearReport.Controls.Add(this.rtbByYear);
            this.grbYearReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbYearReport.Location = new System.Drawing.Point(706, 77);
            this.grbYearReport.Name = "grbYearReport";
            this.grbYearReport.Size = new System.Drawing.Size(405, 162);
            this.grbYearReport.TabIndex = 6;
            this.grbYearReport.TabStop = false;
            this.grbYearReport.Text = "Yearly report";
            // 
            // lblTotalLostPerYear
            // 
            this.lblTotalLostPerYear.AutoSize = true;
            this.lblTotalLostPerYear.Location = new System.Drawing.Point(223, 43);
            this.lblTotalLostPerYear.Name = "lblTotalLostPerYear";
            this.lblTotalLostPerYear.Size = new System.Drawing.Size(40, 20);
            this.lblTotalLostPerYear.TabIndex = 3;
            this.lblTotalLostPerYear.Text = "Lost";
            // 
            // lblTotalWinPerYear
            // 
            this.lblTotalWinPerYear.AutoSize = true;
            this.lblTotalWinPerYear.Location = new System.Drawing.Point(124, 42);
            this.lblTotalWinPerYear.Name = "lblTotalWinPerYear";
            this.lblTotalWinPerYear.Size = new System.Drawing.Size(36, 20);
            this.lblTotalWinPerYear.TabIndex = 2;
            this.lblTotalWinPerYear.Text = "Win";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(31, 43);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(43, 20);
            this.lblYear.TabIndex = 1;
            this.lblYear.Text = "Year";
            // 
            // rtbByYear
            // 
            this.rtbByYear.Location = new System.Drawing.Point(17, 66);
            this.rtbByYear.Name = "rtbByYear";
            this.rtbByYear.ReadOnly = true;
            this.rtbByYear.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbByYear.Size = new System.Drawing.Size(362, 70);
            this.rtbByYear.TabIndex = 0;
            this.rtbByYear.Text = "";
            // 
            // grbAll
            // 
            this.grbAll.Controls.Add(this.lblOutcome);
            this.grbAll.Controls.Add(this.lblAmount);
            this.grbAll.Controls.Add(this.lblDate);
            this.grbAll.Controls.Add(this.lblLocation);
            this.grbAll.Controls.Add(this.rtbMain);
            this.grbAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbAll.Location = new System.Drawing.Point(52, 77);
            this.grbAll.Name = "grbAll";
            this.grbAll.Size = new System.Drawing.Size(582, 473);
            this.grbAll.TabIndex = 7;
            this.grbAll.TabStop = false;
            this.grbAll.Text = "All Bets";
            // 
            // lblOutcome
            // 
            this.lblOutcome.AutoSize = true;
            this.lblOutcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutcome.Location = new System.Drawing.Point(414, 39);
            this.lblOutcome.Name = "lblOutcome";
            this.lblOutcome.Size = new System.Drawing.Size(74, 20);
            this.lblOutcome.TabIndex = 4;
            this.lblOutcome.Text = "Outcome";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(286, 41);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(65, 20);
            this.lblAmount.TabIndex = 3;
            this.lblAmount.Text = "Amount";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(173, 42);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(44, 20);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(39, 42);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(70, 20);
            this.lblLocation.TabIndex = 1;
            this.lblLocation.Text = "Location";
            // 
            // rtbMain
            // 
            this.rtbMain.Location = new System.Drawing.Point(17, 66);
            this.rtbMain.Name = "rtbMain";
            this.rtbMain.ReadOnly = true;
            this.rtbMain.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbMain.Size = new System.Drawing.Size(546, 387);
            this.rtbMain.TabIndex = 0;
            this.rtbMain.Text = "";
            // 
            // grbMostPopular
            // 
            this.grbMostPopular.Controls.Add(this.lblMostPopularLocation);
            this.grbMostPopular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbMostPopular.Location = new System.Drawing.Point(706, 355);
            this.grbMostPopular.Name = "grbMostPopular";
            this.grbMostPopular.Size = new System.Drawing.Size(405, 109);
            this.grbMostPopular.TabIndex = 7;
            this.grbMostPopular.TabStop = false;
            this.grbMostPopular.Text = "Most popular location";
            // 
            // lblMostPopularLocation
            // 
            this.lblMostPopularLocation.AutoSize = true;
            this.lblMostPopularLocation.Location = new System.Drawing.Point(13, 39);
            this.lblMostPopularLocation.Name = "lblMostPopularLocation";
            this.lblMostPopularLocation.Size = new System.Drawing.Size(0, 20);
            this.lblMostPopularLocation.TabIndex = 0;
            // 
            // grbSuccess
            // 
            this.grbSuccess.Controls.Add(this.lblTotalBets);
            this.grbSuccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSuccess.Location = new System.Drawing.Point(706, 470);
            this.grbSuccess.Name = "grbSuccess";
            this.grbSuccess.Size = new System.Drawing.Size(405, 80);
            this.grbSuccess.TabIndex = 8;
            this.grbSuccess.TabStop = false;
            this.grbSuccess.Text = "Bets Won of Total";
            // 
            // lblTotalBets
            // 
            this.lblTotalBets.AutoSize = true;
            this.lblTotalBets.Location = new System.Drawing.Point(11, 40);
            this.lblTotalBets.Name = "lblTotalBets";
            this.lblTotalBets.Size = new System.Drawing.Size(75, 20);
            this.lblTotalBets.TabIndex = 3;
            this.lblTotalBets.Text = "total bets";
            // 
            // btnSortAllByYear
            // 
            this.btnSortAllByYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortAllByYear.Location = new System.Drawing.Point(52, 571);
            this.btnSortAllByYear.Name = "btnSortAllByYear";
            this.btnSortAllByYear.Size = new System.Drawing.Size(117, 36);
            this.btnSortAllByYear.TabIndex = 9;
            this.btnSortAllByYear.Text = "Sort By Year";
            this.btnSortAllByYear.UseVisualStyleBackColor = true;
            this.btnSortAllByYear.Click += new System.EventHandler(this.btnSortAllByYear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblHighestLost);
            this.groupBox1.Controls.Add(this.lblHighestWin);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(706, 245);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 104);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Highest Win/Lost";
            // 
            // lblHighestLost
            // 
            this.lblHighestLost.AutoSize = true;
            this.lblHighestLost.Location = new System.Drawing.Point(223, 68);
            this.lblHighestLost.Name = "lblHighestLost";
            this.lblHighestLost.Size = new System.Drawing.Size(0, 20);
            this.lblHighestLost.TabIndex = 5;
            // 
            // lblHighestWin
            // 
            this.lblHighestWin.AutoSize = true;
            this.lblHighestWin.Location = new System.Drawing.Point(19, 68);
            this.lblHighestWin.Name = "lblHighestWin";
            this.lblHighestWin.Size = new System.Drawing.Size(0, 20);
            this.lblHighestWin.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(223, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Max Lost";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Max Win";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 633);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSortAllByYear);
            this.Controls.Add(this.grbSuccess);
            this.Controls.Add(this.grbMostPopular);
            this.Controls.Add(this.grbAll);
            this.Controls.Add(this.grbYearReport);
            this.Controls.Add(this.btnAddNewBet);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "Hot Tipster Bet Shop";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.grbYearReport.ResumeLayout(false);
            this.grbYearReport.PerformLayout();
            this.grbAll.ResumeLayout(false);
            this.grbAll.PerformLayout();
            this.grbMostPopular.ResumeLayout(false);
            this.grbMostPopular.PerformLayout();
            this.grbSuccess.ResumeLayout(false);
            this.grbSuccess.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddNewBet;
        private System.Windows.Forms.GroupBox grbYearReport;
        private System.Windows.Forms.Label lblTotalLostPerYear;
        private System.Windows.Forms.Label lblTotalWinPerYear;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.RichTextBox rtbByYear;
        private System.Windows.Forms.GroupBox grbAll;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.RichTextBox rtbMain;
        private System.Windows.Forms.Label lblOutcome;
        private System.Windows.Forms.GroupBox grbMostPopular;
        private System.Windows.Forms.GroupBox grbSuccess;
        private System.Windows.Forms.Label lblMostPopularLocation;
        private System.Windows.Forms.Button btnSortAllByYear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblHighestLost;
        private System.Windows.Forms.Label lblHighestWin;
        private System.Windows.Forms.Label lblTotalBets;
    }
}

