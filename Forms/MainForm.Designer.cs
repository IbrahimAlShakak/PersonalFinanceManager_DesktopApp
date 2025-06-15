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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.gbDashboard = new System.Windows.Forms.GroupBox();
            this.lblIncome = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbFinancialGoals = new System.Windows.Forms.GroupBox();
            this.lblProgressBar = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.gbTransactions = new System.Windows.Forms.GroupBox();
            this.cbMax = new System.Windows.Forms.ComboBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.cbMin = new System.Windows.Forms.ComboBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.listView = new System.Windows.Forms.ListView();
            this.chDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnViewReport = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
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
            // lblIncome
            // 
            this.lblIncome.AutoSize = true;
            this.lblIncome.Location = new System.Drawing.Point(258, 76);
            this.lblIncome.Name = "lblIncome";
            this.lblIncome.Size = new System.Drawing.Size(61, 25);
            this.lblIncome.TabIndex = 3;
            this.lblIncome.Text = "$0.00";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Income:";
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
            // gbFinancialGoals
            // 
            this.gbFinancialGoals.Controls.Add(this.lblProgressBar);
            this.gbFinancialGoals.Controls.Add(this.progressBar);
            this.gbFinancialGoals.Location = new System.Drawing.Point(391, 12);
            this.gbFinancialGoals.Name = "gbFinancialGoals";
            this.gbFinancialGoals.Size = new System.Drawing.Size(510, 117);
            this.gbFinancialGoals.TabIndex = 4;
            this.gbFinancialGoals.TabStop = false;
            this.gbFinancialGoals.Text = "Financial Goals";
            // 
            // lblProgressBar
            // 
            this.lblProgressBar.Location = new System.Drawing.Point(15, 76);
            this.lblProgressBar.Name = "lblProgressBar";
            this.lblProgressBar.Size = new System.Drawing.Size(489, 23);
            this.lblProgressBar.TabIndex = 1;
            this.lblProgressBar.Text = "$0 / $0.00";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(20, 42);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(484, 23);
            this.progressBar.TabIndex = 0;
            // 
            // gbTransactions
            // 
            this.gbTransactions.Controls.Add(this.cbMax);
            this.gbTransactions.Controls.Add(this.cbCategory);
            this.gbTransactions.Controls.Add(this.cbMin);
            this.gbTransactions.Controls.Add(this.btnFilter);
            this.gbTransactions.Controls.Add(this.label3);
            this.gbTransactions.Controls.Add(this.listView);
            this.gbTransactions.Location = new System.Drawing.Point(12, 135);
            this.gbTransactions.Name = "gbTransactions";
            this.gbTransactions.Size = new System.Drawing.Size(766, 457);
            this.gbTransactions.TabIndex = 5;
            this.gbTransactions.TabStop = false;
            this.gbTransactions.Text = "Transactions";
            // 
            // cbMax
            // 
            this.cbMax.FormattingEnabled = true;
            this.cbMax.Items.AddRange(new object[] {
            "-50",
            "-100",
            "-250",
            "-500",
            "-1000",
            "None",
            "0",
            "50",
            "100",
            "250",
            "500",
            "1000"});
            this.cbMax.Location = new System.Drawing.Point(413, 39);
            this.cbMax.Name = "cbMax";
            this.cbMax.Size = new System.Drawing.Size(104, 32);
            this.cbMax.TabIndex = 7;
            this.cbMax.Text = "Max";
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Items.AddRange(new object[] {
            "All",
            "Salary",
            "Freelance",
            "Groceries",
            "Transport",
            "Dining",
            "Utilities",
            "Entertainment",
            "Health",
            "Shopping",
            "Rent"});
            this.cbCategory.Location = new System.Drawing.Point(202, 39);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(205, 32);
            this.cbCategory.TabIndex = 5;
            this.cbCategory.Text = "Category";
            // 
            // cbMin
            // 
            this.cbMin.FormattingEnabled = true;
            this.cbMin.Items.AddRange(new object[] {
            "-50",
            "-100",
            "-250",
            "-500",
            "-1000",
            "None",
            "0",
            "50",
            "100",
            "250",
            "500",
            "1000"});
            this.cbMin.Location = new System.Drawing.Point(523, 39);
            this.cbMin.Name = "cbMin";
            this.cbMin.Size = new System.Drawing.Size(104, 32);
            this.cbMin.TabIndex = 4;
            this.cbMin.Text = "Min";
            // 
            // btnFilter
            // 
            this.btnFilter.AutoSize = true;
            this.btnFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.Location = new System.Drawing.Point(633, 28);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(127, 36);
            this.btnFilter.TabIndex = 2;
            this.btnFilter.Text = "Filter....";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
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
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chDate,
            this.chCategory,
            this.chDescription,
            this.chAmount});
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(0, 81);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(760, 370);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // chDate
            // 
            this.chDate.Text = "Date";
            this.chDate.Width = 80;
            // 
            // chCategory
            // 
            this.chCategory.Text = "Category";
            this.chCategory.Width = 80;
            // 
            // chDescription
            // 
            this.chDescription.Text = "Description";
            this.chDescription.Width = 150;
            // 
            // chAmount
            // 
            this.chAmount.Text = "Amount";
            this.chAmount.Width = 100;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(784, 135);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(140, 38);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add....";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(784, 194);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(140, 38);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Edit....";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(784, 253);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(140, 38);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnViewReport
            // 
            this.btnViewReport.Location = new System.Drawing.Point(784, 312);
            this.btnViewReport.Name = "btnViewReport";
            this.btnViewReport.Size = new System.Drawing.Size(140, 38);
            this.btnViewReport.TabIndex = 9;
            this.btnViewReport.Text = "View Report";
            this.btnViewReport.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(784, 434);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(140, 38);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnSetting
            // 
            this.btnSetting.Location = new System.Drawing.Point(784, 373);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lblProgressBar;
        private System.Windows.Forms.GroupBox gbTransactions;
        private System.Windows.Forms.ListView listView;
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
        private System.Windows.Forms.ComboBox cbMax;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.ComboBox cbMin;
        private System.Windows.Forms.Button btnSetting;
    }
}

