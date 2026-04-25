namespace Banking_Transaction_System
{
    partial class WithdrawalForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.dgvWithdrawalHistory = new System.Windows.Forms.DataGridView();
            this.colAccountNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.txtWithdrawalAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAccountNo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWithdrawalHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(390, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 30);
            this.label4.TabIndex = 19;
            this.label4.Text = "Withdrawal History";
            // 
            // dgvWithdrawalHistory
            // 
            this.dgvWithdrawalHistory.AllowUserToDeleteRows = false;
            this.dgvWithdrawalHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvWithdrawalHistory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvWithdrawalHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWithdrawalHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAccountNo,
            this.colAmount,
            this.colDate,
            this.colTime});
            this.dgvWithdrawalHistory.Location = new System.Drawing.Point(210, 407);
            this.dgvWithdrawalHistory.Name = "dgvWithdrawalHistory";
            this.dgvWithdrawalHistory.ReadOnly = true;
            this.dgvWithdrawalHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWithdrawalHistory.Size = new System.Drawing.Size(569, 150);
            this.dgvWithdrawalHistory.TabIndex = 18;
            this.dgvWithdrawalHistory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWithdrawalHistory_CellContentClick);
            // 
            // colAccountNo
            // 
            this.colAccountNo.HeaderText = "Account No";
            this.colAccountNo.Name = "colAccountNo";
            this.colAccountNo.ReadOnly = true;
            // 
            // colAmount
            // 
            this.colAmount.HeaderText = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.ReadOnly = true;
            // 
            // colDate
            // 
            this.colDate.HeaderText = "Date";
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            // 
            // colTime
            // 
            this.colTime.HeaderText = "Time";
            this.colTime.Name = "colTime";
            this.colTime.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 30);
            this.label3.TabIndex = 17;
            this.label3.Text = "Withdrawal Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 30);
            this.label2.TabIndex = 16;
            this.label2.Text = "Select Account";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(327, 283);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 39);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(627, 283);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 39);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Location = new System.Drawing.Point(451, 283);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(125, 39);
            this.btnWithdraw.TabIndex = 13;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // txtWithdrawalAmount
            // 
            this.txtWithdrawalAmount.Location = new System.Drawing.Point(399, 206);
            this.txtWithdrawalAmount.Name = "txtWithdrawalAmount";
            this.txtWithdrawalAmount.Size = new System.Drawing.Size(251, 35);
            this.txtWithdrawalAmount.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(369, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 40);
            this.label1.TabIndex = 10;
            this.label1.Text = "Withdrawal Screen";
            // 
            // txtAccountNo
            // 
            this.txtAccountNo.Location = new System.Drawing.Point(399, 133);
            this.txtAccountNo.Name = "txtAccountNo";
            this.txtAccountNo.Size = new System.Drawing.Size(251, 35);
            this.txtAccountNo.TabIndex = 20;
            // 
            // WithdrawalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.txtAccountNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvWithdrawalHistory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.txtWithdrawalAmount);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "WithdrawalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WithdrawalForm";
            this.Load += new System.EventHandler(this.WithdrawalForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWithdrawalHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvWithdrawalHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAccountNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.TextBox txtWithdrawalAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAccountNo;
    }
}