using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banking_Transaction_System
{
    public partial class TransferForm : Form
    {
        string connectionString = @"Data Source=DESKTOP-EPFGREE\SQLEXPRESS;Initial Catalog=BankingTransactionSystem;Integrated Security=True";

        public TransferForm()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSenderAccountNo.Clear();
            txtReceiverAccountNo.Clear();
            txtTransferAmount.Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            if (txtSenderAccountNo.Text == "" || txtReceiverAccountNo.Text == "" || txtTransferAmount.Text == "")
            {
                MessageBox.Show("Please enter sender account, receiver account, and amount.");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("sp_TransferFundsByAccountNo", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@SenderAccountNo", txtSenderAccountNo.Text);
                    cmd.Parameters.AddWithValue("@ReceiverAccountNo", txtReceiverAccountNo.Text);
                    cmd.Parameters.AddWithValue("@Amount", Convert.ToDecimal(txtTransferAmount.Text));

                    con.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Amount transferred successfully.");

                    txtSenderAccountNo.Clear();
                    txtReceiverAccountNo.Clear();
                    txtTransferAmount.Clear();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Transfer Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
