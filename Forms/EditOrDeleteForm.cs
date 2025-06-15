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
    public partial class EditOrDeleteForm : Form
    {
        public string UserAction { get; private set; } = "None";

        private int _TransactionID;
        private float _Amount;

        public Transaction EditedTransaction = new Transaction();

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
        private void EditTransaction()
        {
            EditedTransaction.Id = _TransactionID;
            EditedTransaction.Date = dateTimePicker.Value;
            EditedTransaction.Category = cbCategoryTransaction.Text.ToString();
            EditedTransaction.Amount = _Amount;
            EditedTransaction.Description = tbDescriptionTransaction.Text;
        }

        public EditOrDeleteForm(int TransactionID)
        {
            InitializeComponent();
            _TransactionID = TransactionID;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!isValidInput()) return;
            else
            {
                UserAction = "Edit";
                EditTransaction();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            UserAction = "Delete";
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
