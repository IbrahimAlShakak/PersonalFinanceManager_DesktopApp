using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalFinanceManager_DesktopApp.Forms
{
    public partial class SettingForm : Form
    {
        public string Currency;
        public SettingForm()
        {
            InitializeComponent();
        }

        private void GetCurrencySymbol()
        {
            if (cbCurrency.Text == null || cbCurrency.Text.ToString().Trim() == "") 
            { 
                Currency = "$"; 
            }
            else
            {
                Currency = cbCurrency.Text.ToString();
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            GetCurrencySymbol();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
