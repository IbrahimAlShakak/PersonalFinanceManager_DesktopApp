namespace PersonalFinanceManager_DesktopApp
{
    partial class MainForm
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
            this.gbDashboard = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblIncome = new System.Windows.Forms.Label();
            this.gbFinancialGoals = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblProgressBar = new System.Windows.Forms.Label();
            this.gbTransactions = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.chDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnViewReport = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnSetting = new System.Windows.Forms.Button();
            this.gbDashboard.SuspendLayout();
            this.gbFinancialGoals.SuspendLayout();
            this.gbTransactions.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDashboard
            // 
            this.gbDashboard.Controls.Add(this.lblIncome);
            this.gbDashboard.Controls.Add(this.lblBalance);
            this.gbDashboard.Controls.Add(this.label2);
            this.gbDashboard.Controls.Add(this.label1);
            this.gbDashboard.Location = new System.Drawing.Point(12, 12);
            this.gbDashboard.Name = "gbDashboard";
            this.gbDashboard.Size = new System.Drawing.Size(373, 117);
            this.gbDashboard.TabIndex = 0;
            this.gbDashboard.TabStop = false;
            this.gbDashboard.Text = "Dashboard";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Balance:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Income:";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(258, 40);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(61, 25);
            this.lblBalance.TabIndex = 2;
            this.lblBalance.Text = "$0.00";
            // 
            // lblIncome
            // 
            this.lblIncome.AutoSize = true;
            this.lblIncome.Location = new System.Drawing.Point(258, 76);
            this.lblIncome.Name = "lblIncome";
            this.lblIncome.Size = new System.Drawing.Size(61, 25);
            this.lblIncome.TabIndex = 3;
            this.lblIncome.Text = "$0.00";
            // 
            // gbFinancialGoals
            // 
            this.gbFinancialGoals.Controls.Add(this.lblProgressBar);
            this.gbFinancialGoals.Controls.Add(this.progressBar1);
            this.gbFinancialGoals.Location = new System.Drawing.Point(391, 12);
            this.gbFinancialGoals.Name = "gbFinancialGoals";
            this.gbFinancialGoals.Size = new System.Drawing.Size(510, 117);
            this.gbFinancialGoals.TabIndex = 4;
            this.gbFinancialGoals.TabStop = false;
            this.gbFinancialGoals.Text = "Financial Goals";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(20, 42);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(484, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // lblProgressBar
            // 
            this.lblProgressBar.Location = new System.Drawing.Point(355, 76);
            this.lblProgressBar.Name = "lblProgressBar";
            this.lblProgressBar.Size = new System.Drawing.Size(149, 23);
            this.lblProgressBar.TabIndex = 1;
            this.lblProgressBar.Text = "$0 / $0.00";
            // 
            // gbTransactions
            // 
            this.gbTransactions.Controls.Add(this.comboBox1);
            this.gbTransactions.Controls.Add(this.cbCategory);
            this.gbTransactions.Controls.Add(this.comboBox2);
            this.gbTransactions.Controls.Add(this.btnFilter);
            this.gbTransactions.Controls.Add(this.label3);
            this.gbTransactions.Controls.Add(this.listView1);
            this.gbTransactions.Location = new System.Drawing.Point(12, 135);
            this.gbTransactions.Name = "gbTransactions";
            this.gbTransactions.Size = new System.Drawing.Size(743, 457);
            this.gbTransactions.TabIndex = 5;
            this.gbTransactions.TabStop = false;
            this.gbTransactions.Text = "Transactions";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chDate,
            this.chCategory,
            this.chDescription,
            this.chAmount});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 81);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(737, 370);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // chDate
            // 
            this.chDate.Text = "Date";
            this.chDate.Width = 150;
            // 
            // chCategory
            // 
            this.chCategory.Text = "Category";
            this.chCategory.Width = 200;
            // 
            // chDescription
            // 
            this.chDescription.Text = "Description";
            this.chDescription.Width = 200;
            // 
            // chAmount
            // 
            this.chAmount.Text = "Amount";
            this.chAmount.Width = 200;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Transactions History";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(761, 145);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(140, 38);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add....";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(761, 204);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(140, 38);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Edit....";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(761, 263);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(140, 38);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnViewReport
            // 
            this.btnViewReport.Location = new System.Drawing.Point(761, 322);
            this.btnViewReport.Name = "btnViewReport";
            this.btnViewReport.Size = new System.Drawing.Size(140, 38);
            this.btnViewReport.TabIndex = 9;
            this.btnViewReport.Text = "View Report";
            this.btnViewReport.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(761, 444);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(140, 38);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnFilter
            // 
            this.btnFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.Location = new System.Drawing.Point(633, 39);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(104, 33);
            this.btnFilter.TabIndex = 2;
            this.btnFilter.Text = "Filter....";
            this.btnFilter.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(523, 39);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(104, 32);
            this.comboBox2.TabIndex = 4;
            this.comboBox2.Text = "Min";
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(202, 39);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(205, 32);
            this.cbCategory.TabIndex = 5;
            this.cbCategory.Text = "Category";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(413, 39);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(104, 32);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.Text = "Max";
            // 
            // btnSetting
            // 
            this.btnSetting.Location = new System.Drawing.Point(761, 383);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(140, 38);
            this.btnSetting.TabIndex = 11;
            this.btnSetting.Text = "Settings";
            this.btnSetting.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 604);
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnViewReport);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gbTransactions);
            this.Controls.Add(this.gbFinancialGoals);
            this.Controls.Add(this.gbDashboard);
            this.Name = "MainForm";
            this.Text = "Personal Finance";
            this.gbDashboard.ResumeLayout(false);
            this.gbDashboard.PerformLayout();
            this.gbFinancialGoals.ResumeLayout(false);
            this.gbTransactions.ResumeLayout(false);
            this.gbTransactions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDashboard;
        private System.Windows.Forms.Label lblIncome;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbFinancialGoals;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblProgressBar;
        private System.Windows.Forms.GroupBox gbTransactions;
        private System.Windows.Forms.ListView listView1;
        public System.Windows.Forms.ColumnHeader chDate;
        public System.Windows.Forms.ColumnHeader chCategory;
        private System.Windows.Forms.ColumnHeader chDescription;
        public System.Windows.Forms.ColumnHeader chAmount;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnViewReport;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button btnSetting;
    }
}

