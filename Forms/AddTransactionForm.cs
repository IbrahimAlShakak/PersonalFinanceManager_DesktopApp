using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PersonalFinanceManager_DesktopApp.Models;

namespace PersonalFinanceManager_DesktopApp.Forms
{
    public partial class AddTransactionForm : Form
    {
        private int _NewTransactionID;
        private float _Amount;

        public Transaction NewTransaction = new Transaction();

        private bool isValidInput()
        {
            if (string.IsNullOrWhiteSpace(tbAmountTransaction.Text) ||
                string.IsNullOrWhiteSpace(tbDescriptionTransaction.Text) ||
                cbCategoryTransaction.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!float.TryParse(tbAmountTransaction.Text, System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out float amount))

            {
                MessageBox.Show("Amount must be a valid number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            _Amount = amount;

            return true;
        }
        private void SetNewTransaction()
        {
                NewTransaction.Id = _NewTransactionID;
                NewTransaction.Date = dateTimePicker.Value;
                NewTransaction.Category = cbCategoryTransaction.Text.ToString();
                NewTransaction.Amount = _Amount;
                NewTransaction.Description = tbDescriptionTransaction.Text;
        }
        public AddTransactionForm(int NewTransactionID)
        {
            InitializeComponent();
            _NewTransactionID = NewTransactionID;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!isValidInput()) return;
            else
            {
                SetNewTransaction();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
