using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banking_Transaction_System
{
    public partial class DashboardForm : Form
    {
        string userRole;
        public DashboardForm(string role)
        {
            InitializeComponent();
            userRole = role;

            if (userRole == "User")
            {
                btnCustomerAccount.Visible = false;
            }

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCustomerAccount_Click(object sender, EventArgs e)
        {
            CustomerAccountForm form = new CustomerAccountForm();
            form.Show();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            DepositForm form = new DepositForm();
            form.Show();
        }

        private void btnWithdrawal_Click(object sender, EventArgs e)
        {
            WithdrawalForm form = new WithdrawalForm(userRole);
            form.Show();
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            TransferForm form = new TransferForm();
            form.Show();
        }

        private void btnTransactionHistory_Click(object sender, EventArgs e)
        {
            TransactionHistoryForm form = new TransactionHistoryForm();
            form.Show();

        }
    }
}
