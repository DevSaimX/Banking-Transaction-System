using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Banking_Transaction_System
{
    public partial class DepositForm : Form
    {
        string connectionString = @"Data Source=DESKTOP-EPFGREE\SQLEXPRESS;Initial Catalog=BankingTransactionSystem;Integrated Security=True";

        public DepositForm()
        {
            InitializeComponent();
        }

        private void DepositForm_Load(object sender, EventArgs e)
        {
            LoadDepositHistory();
        }

        private void LoadDepositHistory()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_GetDepositHistory", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvDepositHistory.Columns.Clear();
                dgvDepositHistory.AutoGenerateColumns = true;
                dgvDepositHistory.DataSource = dt;

                dgvDepositHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvDepositHistory.ReadOnly = true;
                dgvDepositHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvDepositHistory.RowHeadersVisible = false;
            }
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            if (txtAccountNo.Text == "" || txtDepositAmount.Text == "")
            {
                MessageBox.Show("Please enter account number and amount.");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_DepositMoneyByAccountNo", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@AccountNo", txtAccountNo.Text);
                cmd.Parameters.AddWithValue("@Amount", Convert.ToDecimal(txtDepositAmount.Text));

                con.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Amount deposited successfully.");

                txtAccountNo.Clear();
                txtDepositAmount.Clear();
                LoadDepositHistory();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAccountNo.Clear();
            txtDepositAmount.Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}