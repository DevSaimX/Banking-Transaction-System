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
    public partial class TransactionHistoryForm : Form
    {
        string connectionString = @"Data Source=DESKTOP-EPFGREE\SQLEXPRESS;Initial Catalog=BankingTransactionSystem;Integrated Security=True";

        public TransactionHistoryForm()
        {
            InitializeComponent();
        }

        private void TransactionHistoryForm_Load(object sender, EventArgs e)
        {
            LoadTransactionHistory();
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtAccountNo.Text == "")
            {
                MessageBox.Show("Please enter account number to filter.");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_FilterTransactionsByAccountNo", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@AccountNo", txtAccountNo.Text);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvTransactionHistory.Columns.Clear();
                dgvTransactionHistory.AutoGenerateColumns = true;
                dgvTransactionHistory.DataSource = dt;

                dgvTransactionHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvTransactionHistory.ReadOnly = true;
                dgvTransactionHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvTransactionHistory.RowHeadersVisible = false;
            }

        }

        private void LoadTransactionHistory()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_GetTransactionHistory", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvTransactionHistory.Columns.Clear();
                dgvTransactionHistory.AutoGenerateColumns = true;
                dgvTransactionHistory.DataSource = dt;

                dgvTransactionHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvTransactionHistory.ReadOnly = true;
                dgvTransactionHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvTransactionHistory.RowHeadersVisible = false;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtAccountNo.Clear();
            LoadTransactionHistory();
        }
    }
}
