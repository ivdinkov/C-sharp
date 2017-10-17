using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StreamAdapters
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpenWrite_Click(object sender, EventArgs e)
        {
            using (Stream fs = File.Open(@"C:\AdvProg\FileAdapters.bin", FileMode.OpenOrCreate))
            {
                using (BinaryWriter binWriter = new BinaryWriter(fs))
                {
                    try
                    {
                        btnOpenWrite.Enabled = false;
                        decimal salesTotal = 129.99M;
                        bool flag = false;
                        string customerName = "Mr. Jones";
                        // Write out this primitive data to a stream
                        binWriter.Write(salesTotal);
                        binWriter.Write(flag);
                        binWriter.Write(customerName);
                        MessageBox.Show("Binary file created and written to successfully");
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            using (Stream fs = File.Open(@"C:\AdvProg\FileAdapters.bin",
                                         FileMode.Open))
            using (BinaryReader binReader = new BinaryReader(fs))
            {
                try
                {
                    /*
                    The Write() method is overloaded to take many different primitive types
                    and write them to a binary stream.  The Read's are handled via
                    dedicated ReadXXXX() types of methods.  There must be agreement, therefore,
                    between writers and readers as to the "format" of data being exchanged.
                    */
                    decimal salesTotal = binReader.ReadDecimal();
                    bool flag = binReader.ReadBoolean();
                    string customerName = binReader.ReadString();

                    rtbOutput.Text = $"Sales total is: {salesTotal}" + Environment.NewLine
                                     + $"Flag is set to: {flag}" + Environment.NewLine
                                     + $"Customer name is: {customerName}" + Environment.NewLine;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnOpenWriteRead_Click(object sender, EventArgs e)
        {
            using (Stream fs = File.Open(@"C:\AdvProg\FileAdapters.bin", FileMode.OpenOrCreate))
            using (BinaryWriter binWriter = new BinaryWriter(fs))
            using (BinaryReader binReader = new BinaryReader(fs))
            {
                try
                {
                    btnOpenWrite.Enabled = false;
                    decimal salesTotal = 129.99M;
                    bool flag = false;
                    string customerName = "Mr. Jones";
                    binWriter.Write(salesTotal);
                    binWriter.Write(flag);
                    binWriter.Write(customerName);
                    MessageBox.Show("Binary file created and written to successfully");
                    /*
                    We need to Flush the stream here to ensure that buffered bytes
                    are written out **BEFORE** we re-position the stream using
                    Seek() or the Position property.
                    */
                    binWriter.Flush();

                    // Re-wind the stream position to the beginning of the stream
                    fs.Seek(0, SeekOrigin.Begin);
                    rtbOutput.Clear();
                    rtbOutput.AppendText("Now reading data back...");
                    decimal salesTotalRead = binReader.ReadDecimal();
                    bool flagRead = binReader.ReadBoolean();
                    string customerNameRead = binReader.ReadString();

                    rtbOutput.AppendText($"Sales total is: {salesTotalRead}" + Environment.NewLine
                                         + $"Flag is set to: {flagRead}" + Environment.NewLine
                                         + $"Customer name is: {customerNameRead}" + Environment.NewLine);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnSalesTxn_Click(object sender, EventArgs e)
        {
            using (Stream fs = File.Open(@"C:\AdvProg\SalesTxn.bin", FileMode.OpenOrCreate))
            using (BinaryWriter binWriter = new BinaryWriter(fs))
            using (BinaryReader binReader = new BinaryReader(fs))
            {
                try
                {
                    SalesTxn salesTxn = new SalesTxn();
                    salesTxn.CustomerName = "Mrs Stephens";
                    salesTxn.CouponCode = "DEAL123";
                    salesTxn.OrderTotal = 123.50M;
                    salesTxn.IsExpressDelivery = true;

                    binWriter.Write(salesTxn.CustomerName);
                    binWriter.Write(salesTxn.CouponCode);
                    binWriter.Write(salesTxn.OrderTotal);
                    binWriter.Write(salesTxn.IsExpressDelivery);
                    MessageBox.Show("Sales Txn File created");
                    binWriter.Flush();

                    // Re-wind the stream position to the beginning of the stream
                    fs.Seek(0, SeekOrigin.Begin);
                    rtbOutput.Clear();
                    rtbOutput.AppendText("Now reading data back...");
                    SalesTxn salesTxn2 = new SalesTxn();
                    salesTxn2.CustomerName = binReader.ReadString();
                    salesTxn2.CouponCode = binReader.ReadString();
                    salesTxn2.OrderTotal = binReader.ReadDecimal();
                    salesTxn2.IsExpressDelivery = binReader.ReadBoolean();

                    rtbOutput.AppendText($"Customer name is: {salesTxn2.CustomerName}" + Environment.NewLine
                                         + $"Coupon code is: {salesTxn2.CouponCode}" + Environment.NewLine
                                         + $"Sales total is: {salesTxn2.OrderTotal}" + Environment.NewLine
                                         + $"Express delivery is set to: {salesTxn2.IsExpressDelivery}" + Environment.NewLine);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
