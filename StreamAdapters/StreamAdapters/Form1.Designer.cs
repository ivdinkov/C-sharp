namespace StreamAdapters
{
    partial class Form1
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
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.btnOpenWrite = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnOpenWriteRead = new System.Windows.Forms.Button();
            this.btnSalesTxn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbOutput
            // 
            this.rtbOutput.Location = new System.Drawing.Point(1, 3);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(281, 158);
            this.rtbOutput.TabIndex = 0;
            this.rtbOutput.Text = "";
            // 
            // btnOpenWrite
            // 
            this.btnOpenWrite.Location = new System.Drawing.Point(47, 195);
            this.btnOpenWrite.Name = "btnOpenWrite";
            this.btnOpenWrite.Size = new System.Drawing.Size(75, 23);
            this.btnOpenWrite.TabIndex = 1;
            this.btnOpenWrite.Text = "Open/Write";
            this.btnOpenWrite.UseVisualStyleBackColor = true;
            this.btnOpenWrite.Click += new System.EventHandler(this.btnOpenWrite_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(163, 195);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 23);
            this.btnRead.TabIndex = 2;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnOpenWriteRead
            // 
            this.btnOpenWriteRead.Location = new System.Drawing.Point(47, 227);
            this.btnOpenWriteRead.Name = "btnOpenWriteRead";
            this.btnOpenWriteRead.Size = new System.Drawing.Size(104, 23);
            this.btnOpenWriteRead.TabIndex = 3;
            this.btnOpenWriteRead.Text = "Open/Write/Read";
            this.btnOpenWriteRead.UseVisualStyleBackColor = true;
            this.btnOpenWriteRead.Click += new System.EventHandler(this.btnOpenWriteRead_Click);
            // 
            // btnSalesTxn
            // 
            this.btnSalesTxn.Location = new System.Drawing.Point(163, 227);
            this.btnSalesTxn.Name = "btnSalesTxn";
            this.btnSalesTxn.Size = new System.Drawing.Size(75, 23);
            this.btnSalesTxn.TabIndex = 4;
            this.btnSalesTxn.Text = "Sales Txn";
            this.btnSalesTxn.UseVisualStyleBackColor = true;
            this.btnSalesTxn.Click += new System.EventHandler(this.btnSalesTxn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnSalesTxn);
            this.Controls.Add(this.btnOpenWriteRead);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnOpenWrite);
            this.Controls.Add(this.rtbOutput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.Button btnOpenWrite;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnOpenWriteRead;
        private System.Windows.Forms.Button btnSalesTxn;
    }
}

