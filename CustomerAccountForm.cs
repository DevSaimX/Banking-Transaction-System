using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Banking_Transaction_System
{
    public partial class CustomerAccountForm : Form
    {
        string connectionString = @"Data Source=DESKTOP-EPFGREE\SQLEXPRESS;Initial Catalog=BankingTransactionSystem;Integrated Security=True";

        int selectedAccountID = 0;

        public CustomerAccountForm()
        {
            InitializeComponent();
        }

        private void CustomerAccountForm_Load(object sender, EventArgs e)
        {
            cmbAccountType.Items.Add("Savings");
            cmbAccountType.Items.Add("Current");

            cmbStatus.Items.Add("Active");
            cmbStatus.Items.Add("Inactive");

            LoadAccounts();
        }

        private void LoadAccounts()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_GetAllAccounts", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvAccountList.Columns.Clear();
                dgvAccountList.AutoGenerateColumns = true;
                dgvAccountList.DataSource = dt;

                dgvAccountList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvAccountList.ReadOnly = true;
                dgvAccountList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                if (dgvAccountList.Columns.Contains("AccountID"))
                    dgvAccountList.Columns["AccountID"].Visible = false;

                if (dgvAccountList.Columns.Contains("CurrentBalance"))
                    dgvAccountList.Columns["CurrentBalance"].Visible = false;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearFields()
        {
            selectedAccountID = 0;

            txtCustomerID.Clear();
            txtCustomerName.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            txtAccountNo.Clear();
            txtOpeningBalance.Clear();

            cmbAccountType.SelectedIndex = -1;
            cmbStatus.SelectedIndex = -1;
        }

        private void dgvAccountList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvAccountList.Rows[e.RowIndex];

                selectedAccountID = Convert.ToInt32(row.Cells["AccountID"].Value);

                txtCustomerID.Text = row.Cells["CustomerID"].Value.ToString();
                txtCustomerName.Text = row.Cells["CustomerName"].Value.ToString();
                txtPhone.Text = row.Cells["PhoneNumber"].Value.ToString();
                txtAddress.Text = row.Cells["Address"].Value.ToString();
                txtAccountNo.Text = row.Cells["AccountNo"].Value.ToString();
                cmbAccountType.Text = row.Cells["AccountType"].Value.ToString();
                txtOpeningBalance.Text = row.Cells["OpeningBalance"].Value.ToString();
                cmbStatus.Text = row.Cells["Status"].Value.ToString();
            }
        }

        private void btnAddCustomer_Click_1(object sender, EventArgs e)
        {
            if (txtCustomerName.Text == "" || txtPhone.Text == "" || txtAddress.Text == "")
            {
                MessageBox.Show("Please enter customer name, phone number, and address.");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_InsertCustomer", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CustomerName", txtCustomerName.Text);
                cmd.Parameters.AddWithValue("@PhoneNumber", txtPhone.Text);
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);

                con.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Customer added successfully.");
                ClearFields();
                LoadAccounts();
            }
        }

        private void btnCreateAccount_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_CreateAccount", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CustomerID", Convert.ToInt32(txtCustomerID.Text));
                cmd.Parameters.AddWithValue("@AccountNo", txtAccountNo.Text);
                cmd.Parameters.AddWithValue("@AccountType", cmbAccountType.Text);
                cmd.Parameters.AddWithValue("@OpeningBalance", Convert.ToDecimal(txtOpeningBalance.Text));
                cmd.Parameters.AddWithValue("@Status", cmbStatus.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Account created successfully.");
                ClearFields();
                LoadAccounts();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();

        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            if (selectedAccountID == 0)
            {
                MessageBox.Show("Please select a record from the account list.");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                SqlCommand cmdCustomer = new SqlCommand("sp_UpdateCustomer", con);
                cmdCustomer.CommandType = CommandType.StoredProcedure;
                cmdCustomer.Parameters.AddWithValue("@CustomerID", Convert.ToInt32(txtCustomerID.Text));
                cmdCustomer.Parameters.AddWithValue("@CustomerName", txtCustomerName.Text);
                cmdCustomer.Parameters.AddWithValue("@PhoneNumber", txtPhone.Text);
                cmdCustomer.Parameters.AddWithValue("@Address", txtAddress.Text);
                cmdCustomer.ExecuteNonQuery();

                SqlCommand cmdAccount = new SqlCommand("sp_UpdateAccount", con);
                cmdAccount.CommandType = CommandType.StoredProcedure;
                cmdAccount.Parameters.AddWithValue("@AccountID", selectedAccountID);
                cmdAccount.Parameters.AddWithValue("@AccountNo", txtAccountNo.Text);
                cmdAccount.Parameters.AddWithValue("@AccountType", cmbAccountType.Text);
                cmdAccount.Parameters.AddWithValue("@OpeningBalance", Convert.ToDecimal(txtOpeningBalance.Text));
                cmdAccount.Parameters.AddWithValue("@CurrentBalance", Convert.ToDecimal(txtOpeningBalance.Text));
                cmdAccount.Parameters.AddWithValue("@Status", cmbStatus.Text);
                cmdAccount.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Record updated successfully.");
                ClearFields();
                LoadAccounts();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedAccountID == 0)
            {
                MessageBox.Show("Please select a record from the account list.");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_DeleteAccount", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@AccountID", selectedAccountID);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Account deleted successfully.");
                ClearFields();
                LoadAccounts();
            }
        }
    }
}