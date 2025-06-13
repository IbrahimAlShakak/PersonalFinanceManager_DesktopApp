using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using PersonalFinanceManager_DesktopApp.Models;
using System.Text.Json;

namespace PersonalFinanceManager_DesktopApp
{
    public partial class MainForm : Form
    {
        List<Transaction> Transactions = new List<Transaction>();

        private void GetTransactions()
        {
            string jsonFromFile = File.ReadAllText("transactions_sample.json");

            Transactions = JsonSerializer.Deserialize<List<Transaction>>(jsonFromFile);
        }
        private void SaveTransactions()
        {
            string dataToJson = JsonSerializer.Serialize(Transactions, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            File.WriteAllText("transactions_sample.json", dataToJson);
        }

        private void LoadTransactions()
        {
            GetTransactions();
            listView.Items.Clear();

            foreach (var transaction in Transactions)
            {
                ListViewItem item = new ListViewItem(transaction.Date.ToString("dd/MM/yyyy"));
                item.SubItems.Add(transaction.Category);
                item.SubItems.Add(transaction.Description);
                item.SubItems.Add(transaction.Amount.ToString());
                listView.Items.Add(item);
            }

        }

        private float GetIncome()
        {
            if (Transactions.Count < 1) return 0f;

            float income = 0f;
            foreach (var transaction in Transactions)
            {
                income += transaction.Amount > 0 ? transaction.Amount : 0;
            }

            return income;
        }
        private float GetExpenses()
        {
            if (Transactions.Count < 1) return 0f;

            float Expenses = 0f;
            foreach (var transaction in Transactions)
            {
                Expenses += transaction.Amount < 0 ? Math.Abs(transaction.Amount) : 0;
            }

            return Expenses;
        }
        private void UpdateDashboard()
        {
            float income = GetIncome();
            float expenses = GetExpenses();
            float balance = income - expenses;

            lblBalance.Text = $"${balance:0.00}";
            lblIncome.Text = $"${income:0.00}";
        }

        private void UpdateFinancialGolas()
        {
            int FinancialGoal = 100000;
            float income = GetIncome();

            progressBar.Maximum = FinancialGoal;
            progressBar.Value = (int) income;

            lblProgressBar.Text = $"${income} / ${FinancialGoal}";

        }
        public MainForm()
        {
            InitializeComponent();
            LoadTransactions();
            UpdateDashboard();
            UpdateFinancialGolas();
        }

    }
}
