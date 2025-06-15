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
using PersonalFinanceManager_DesktopApp.Forms;

namespace PersonalFinanceManager_DesktopApp
{
    public partial class MainForm : Form
    {
        List<Transaction> Transactions = new List<Transaction>();
        private string _Currency = "$";

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
                ListViewItem item = new ListViewItem(transaction.Id.ToString());
                item.SubItems.Add(transaction.Date.ToString("dd/MM/yyyy"));
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

            lblBalance.Text = $"{_Currency}{balance:0.00}";
            lblIncome.Text = $"{_Currency}{income:0.00}";
        }
        private void UpdateFinancialGolas()
        {
            int FinancialGoal = 100000;
            float income = GetIncome();
            float expenses = GetExpenses();
            float balance = income - expenses;

            progressBar.Maximum = FinancialGoal;
            progressBar.Value = (int)balance;

            lblProgressBar.Text = $"{_Currency}{balance} / {_Currency}{FinancialGoal}";

        }
        private void GetFilteredTransaction()
        {
            var filteredTransactions = Transactions.Where(t =>
            (cbCategory.SelectedItem == null || cbCategory.SelectedItem.ToString() == "All" || t.Category == cbCategory.SelectedItem.ToString()) &&
            (cbMin.SelectedItem == null || cbMin.SelectedItem.ToString() == "None" || t.Amount >= float.Parse(cbMin.SelectedItem.ToString())) &&
            (cbMax.SelectedItem == null || cbMax.SelectedItem.ToString() == "None" || t.Amount <= float.Parse(cbMax.SelectedItem.ToString()))).ToList();


            listView.Items.Clear();

            foreach (var transaction in filteredTransactions)
            {
                ListViewItem item = new ListViewItem(transaction.Id.ToString());
                item.SubItems.Add(transaction.Date.ToString("dd/MM/yyyy"));
                item.SubItems.Add(transaction.Category);
                item.SubItems.Add(transaction.Description);
                item.SubItems.Add(transaction.Amount.ToString());
                listView.Items.Add(item);
            }

        }
        private void AddNewTransaction()
        {
            int lastId = Transactions.Any() ? Transactions.Max(t => t.Id) : 0;
            AddTransactionForm addTransactionForm = new AddTransactionForm(lastId+1);
            if (addTransactionForm.ShowDialog() == DialogResult.OK)
            {
                Transaction NewTransaction = addTransactionForm.NewTransaction;
                Transactions.Add(NewTransaction);
                SaveTransactions();
                LoadTransactions();
                UpdateDashboard();
                UpdateFinancialGolas();
            }
        }
        private void GetCurrencyChange()
        {
            SettingForm settingForm = new SettingForm();
            if (settingForm.ShowDialog() == DialogResult.OK)
            {
                _Currency = settingForm.Currency;
                UpdateDashboard();
                UpdateFinancialGolas();
            }

        }

        public MainForm()
        {
            InitializeComponent();
            LoadTransactions();
            UpdateDashboard();
            UpdateFinancialGolas();
        }
        private void btnFilter_Click(object sender, EventArgs e)
        {
            GetFilteredTransaction();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddNewTransaction();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            GetCurrencyChange();
        }
    }
}
