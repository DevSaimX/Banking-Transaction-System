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
    public partial class WithdrawalForm : Form
    {
        string connectionString = @"Data Source=DESKTOP-EPFGREE\SQLEXPRESS;Initial Catalog=BankingTransactionSystem;Integrated Security=True";
        string userRole;
        public WithdrawalForm(string role)
        {
            InitializeComponent();
            userRole = role;
        }


        private void WithdrawalForm_Load(object sender, EventArgs e)
        {
            LoadWithdrawalHistory();
        }



        private void LoadWithdrawalHistory()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_GetWithdrawalHistory", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvWithdrawalHistory.Columns.Clear();
                dgvWithdrawalHistory.AutoGenerateColumns = true;
                dgvWithdrawalHistory.DataSource = dt;

                dgvWithdrawalHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvWithdrawalHistory.ReadOnly = true;
                dgvWithdrawalHistory.RowHeadersVisible = false;
            }
        }
        private void cmbAccount_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

     

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            if (txtAccountNo.Text == "" || txtWithdrawalAmount.Text == "")
            {
                MessageBox.Show("Please enter account number and amount.");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_WithdrawMoneyByAccountNo", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@AccountNo", txtAccountNo.Text);
                cmd.Parameters.AddWithValue("@Amount", Convert.ToDecimal(txtWithdrawalAmount.Text));

                con.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Amount withdrawn successfully.");

                txtAccountNo.Clear();
                txtWithdrawalAmount.Clear();
                LoadWithdrawalHistory();
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAccountNo.Clear();
            txtWithdrawalAmount.Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void dgvWithdrawalHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
