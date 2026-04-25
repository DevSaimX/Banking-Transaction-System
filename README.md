# 🏦 Banking Transaction System

![C#](https://img.shields.io/badge/Language-C%23-blue)
![.NET](https://img.shields.io/badge/.NET-Windows%20Forms-purple)
![SQL Server](https://img.shields.io/badge/Database-SQL%20Server-red)
![Status](https://img.shields.io/badge/Status-Completed-success)
![License](https://img.shields.io/badge/License-Educational-lightgrey)

A desktop-based Banking Application developed using **C# Windows Forms** and **SQL Server** that performs essential banking operations like account management, transactions, and history tracking.

---

## 📌 Features

- 🔐 User Authentication (Login System)
- 👤 Customer Management
- 💳 Account Creation & Management
- 💰 Deposit Money
- 💸 Withdraw Money
- 🔁 Fund Transfer
- 📊 Transaction History with Filtering

---

## 🧑‍💻 User Roles

### 👨‍💼 Admin
- Manage Customers & Accounts
- Perform Deposit / Withdrawal / Transfer
- View all transactions

### 👤 User
- Deposit / Withdraw Money
- Transfer Funds
- View own transaction history

---

## 🛠️ Technologies Used

| Technology | Description |
|----------|-------------|
| C# (.NET) | Windows Forms Application |
| SQL Server | Database Management |
| ADO.NET | Database Connectivity |
| SSMS 19 | Database Design |

---

## 🗄️ Database Structure

### Tables:
- `Users`
- `Customers`
- `Accounts`
- `Transactions`

### Concepts Used:
- Primary Keys & Foreign Keys
- Constraints (NOT NULL, CHECK)
- Stored Procedures for all operations
- Basic Transaction Handling

---

## ⚙️ Stored Procedures

- `sp_LoginUser`
- `sp_InsertCustomer`
- `sp_CreateAccount`
- `sp_UpdateCustomer`
- `sp_UpdateAccount`
- `sp_DeleteAccount`
- `sp_DepositMoneyByAccountNo`
- `sp_WithdrawMoneyByAccountNo`
- `sp_TransferFundsByAccountNo`
- `sp_GetTransactionHistory`
- `sp_FilterTransactionsByAccountNo`

---

## 🖥️ Application Screens

### 🔐 Login Screen
![Login Screen](screenshots/login.png)

### 📊 Dashboard
![Dashboard](screenshots/dashboard.png)

### 👤 Customer / Account Management
![Customer Management](screenshots/customer.png)

### 💰 Deposit Screen
![Deposit](screenshots/deposit.png)

### 💸 Withdrawal Screen
![Withdrawal](screenshots/withdrawal.png)

### 🔁 Fund Transfer Screen
![Transfer](screenshots/transfer.png)

### 📜 Transaction History
![Transaction History](screenshots/history.png)

---

## 📁 Project Structure

```
Banking Transaction System/
│
├── Forms/
│   ├── LoginForm.cs
│   ├── DashboardForm.cs
│   ├── CustomerAccountForm.cs
│   ├── DepositForm.cs
│   ├── WithdrawalForm.cs
│   ├── TransferForm.cs
│   └── TransactionHistoryForm.cs
│
├── Database/
│   ├── Tables.sql
│   ├── StoredProcedures.sql
│
└── Program.cs
```

---

## 🚀 How to Run

1. Clone repository:
   ```bash
   git clone https://github.com/your-username/banking-system.git
   ```

2. Open in **Visual Studio 2022**

3. Setup database in SQL Server:
   - Run SQL scripts
   - Create stored procedures

4. Update connection string:

```csharp
Data Source=YOUR_SERVER;
Initial Catalog=BankingTransactionSystem;
Integrated Security=True;
```

5. Run the project ▶️

---

## ⚠️ Notes

- Account operations use **stored procedures only**
- Manual account number entry is used for simplicity
- Error handling implemented using SQL + C#

---

## 🙌 Credit & Attribution

If you use or reference this project, please consider mentioning the author on LinkedIn:

👉 **Saim Iftikhar**

Your support helps showcase the work and allows for reposting and appreciation. 🚀

---

## 👨‍🎓 Author

**Name:** SAIM IFTIKHAR  
**ARID:** 2023-ARID-3894  
**Section:** BSAI-6C  

---

## 📜 License

This project is developed for **educational purposes only**.

---

## ⭐ If you like this project

Give it a ⭐ on GitHub!
