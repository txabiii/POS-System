
namespace POS1.Transaction_Forms
{
    partial class Filter
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
            this.filterConfirm = new POS1.POS_Controls.Buttons();
            this.labelTransactionFilterType = new System.Windows.Forms.Label();
            this.comboBoxTransactionType = new System.Windows.Forms.ComboBox();
            this.labelTransactionFilterStartDate = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.labelTransactionFilterEndDate = new System.Windows.Forms.Label();
            this.filterByDateCheckBox = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panelFilterLeft = new System.Windows.Forms.Panel();
            this.labelFilterClear = new System.Windows.Forms.Label();
            this.panelConfirm = new System.Windows.Forms.Panel();
            this.labelTransactionItemId = new System.Windows.Forms.Label();
            this.textBoxItemIdFilter = new System.Windows.Forms.TextBox();
            this.panelItemIdFilter = new System.Windows.Forms.Panel();
            this.panelFilterLeft.SuspendLayout();
            this.panelConfirm.SuspendLayout();
            this.panelItemIdFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // filterConfirm
            // 
            this.filterConfirm.BackColor = System.Drawing.Color.Gainsboro;
            this.filterConfirm.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.filterConfirm.BorderColor = System.Drawing.Color.Transparent;
            this.filterConfirm.BorderRadius = 15;
            this.filterConfirm.BorderSize = 3;
            this.filterConfirm.FlatAppearance.BorderSize = 0;
            this.filterConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filterConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.filterConfirm.ForeColor = System.Drawing.Color.Black;
            this.filterConfirm.Location = new System.Drawing.Point(149, 27);
            this.filterConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.filterConfirm.Name = "filterConfirm";
            this.filterConfirm.Size = new System.Drawing.Size(150, 35);
            this.filterConfirm.TabIndex = 1;
            this.filterConfirm.Text = "confirm";
            this.filterConfirm.TextColor = System.Drawing.Color.Black;
            this.filterConfirm.UseVisualStyleBackColor = false;
            this.filterConfirm.Click += new System.EventHandler(this.buttons1_Click);
            // 
            // labelTransactionFilterType
            // 
            this.labelTransactionFilterType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTransactionFilterType.Location = new System.Drawing.Point(45, 135);
            this.labelTransactionFilterType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTransactionFilterType.Name = "labelTransactionFilterType";
            this.labelTransactionFilterType.Size = new System.Drawing.Size(94, 38);
            this.labelTransactionFilterType.TabIndex = 1;
            this.labelTransactionFilterType.Text = "Transaction Type:";
            // 
            // comboBoxTransactionType
            // 
            this.comboBoxTransactionType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxTransactionType.FormattingEnabled = true;
            this.comboBoxTransactionType.Items.AddRange(new object[] {
            "all",
            "sale",
            "refund",
            "exchange ",
            "supply"});
            this.comboBoxTransactionType.Location = new System.Drawing.Point(171, 135);
            this.comboBoxTransactionType.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxTransactionType.Name = "comboBoxTransactionType";
            this.comboBoxTransactionType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxTransactionType.Size = new System.Drawing.Size(102, 23);
            this.comboBoxTransactionType.TabIndex = 4;
            this.comboBoxTransactionType.Text = "all";
            // 
            // labelTransactionFilterStartDate
            // 
            this.labelTransactionFilterStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTransactionFilterStartDate.Location = new System.Drawing.Point(45, 36);
            this.labelTransactionFilterStartDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTransactionFilterStartDate.Name = "labelTransactionFilterStartDate";
            this.labelTransactionFilterStartDate.Size = new System.Drawing.Size(122, 22);
            this.labelTransactionFilterStartDate.TabIndex = 0;
            this.labelTransactionFilterStartDate.Text = "Start Date:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker2.Location = new System.Drawing.Point(171, 63);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(223, 21);
            this.dateTimePicker2.TabIndex = 6;
            // 
            // labelTransactionFilterEndDate
            // 
            this.labelTransactionFilterEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTransactionFilterEndDate.Location = new System.Drawing.Point(45, 63);
            this.labelTransactionFilterEndDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTransactionFilterEndDate.Name = "labelTransactionFilterEndDate";
            this.labelTransactionFilterEndDate.Size = new System.Drawing.Size(105, 22);
            this.labelTransactionFilterEndDate.TabIndex = 2;
            this.labelTransactionFilterEndDate.Text = "End Date:";
            // 
            // filterByDateCheckBox
            // 
            this.filterByDateCheckBox.AutoSize = true;
            this.filterByDateCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.filterByDateCheckBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.filterByDateCheckBox.Location = new System.Drawing.Point(171, 90);
            this.filterByDateCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.filterByDateCheckBox.Name = "filterByDateCheckBox";
            this.filterByDateCheckBox.Size = new System.Drawing.Size(123, 19);
            this.filterByDateCheckBox.TabIndex = 7;
            this.filterByDateCheckBox.Text = "Don\'t filter by date";
            this.filterByDateCheckBox.UseVisualStyleBackColor = true;
            this.filterByDateCheckBox.CheckStateChanged += new System.EventHandler(this.checkBox1_CheckStateChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Location = new System.Drawing.Point(171, 31);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(223, 21);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // panelFilterLeft
            // 
            this.panelFilterLeft.Controls.Add(this.dateTimePicker1);
            this.panelFilterLeft.Controls.Add(this.filterByDateCheckBox);
            this.panelFilterLeft.Controls.Add(this.labelTransactionFilterEndDate);
            this.panelFilterLeft.Controls.Add(this.dateTimePicker2);
            this.panelFilterLeft.Controls.Add(this.labelTransactionFilterStartDate);
            this.panelFilterLeft.Controls.Add(this.comboBoxTransactionType);
            this.panelFilterLeft.Controls.Add(this.labelTransactionFilterType);
            this.panelFilterLeft.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilterLeft.Location = new System.Drawing.Point(0, 0);
            this.panelFilterLeft.Margin = new System.Windows.Forms.Padding(2);
            this.panelFilterLeft.Name = "panelFilterLeft";
            this.panelFilterLeft.Size = new System.Drawing.Size(438, 181);
            this.panelFilterLeft.TabIndex = 5;
            // 
            // labelFilterClear
            // 
            this.labelFilterClear.AutoSize = true;
            this.labelFilterClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelFilterClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFilterClear.ForeColor = System.Drawing.Color.Tomato;
            this.labelFilterClear.Location = new System.Drawing.Point(309, 36);
            this.labelFilterClear.Name = "labelFilterClear";
            this.labelFilterClear.Size = new System.Drawing.Size(40, 18);
            this.labelFilterClear.TabIndex = 9;
            this.labelFilterClear.Text = "clear";
            this.labelFilterClear.Click += new System.EventHandler(this.labelFilterClear_Click);
            // 
            // panelConfirm
            // 
            this.panelConfirm.Controls.Add(this.labelFilterClear);
            this.panelConfirm.Controls.Add(this.filterConfirm);
            this.panelConfirm.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelConfirm.Location = new System.Drawing.Point(0, 256);
            this.panelConfirm.Name = "panelConfirm";
            this.panelConfirm.Size = new System.Drawing.Size(438, 85);
            this.panelConfirm.TabIndex = 11;
            // 
            // labelTransactionItemId
            // 
            this.labelTransactionItemId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTransactionItemId.Location = new System.Drawing.Point(45, 19);
            this.labelTransactionItemId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTransactionItemId.Name = "labelTransactionItemId";
            this.labelTransactionItemId.Size = new System.Drawing.Size(94, 21);
            this.labelTransactionItemId.TabIndex = 3;
            this.labelTransactionItemId.Text = "Item Id:";
            // 
            // textBoxItemIdFilter
            // 
            this.textBoxItemIdFilter.Location = new System.Drawing.Point(171, 21);
            this.textBoxItemIdFilter.Name = "textBoxItemIdFilter";
            this.textBoxItemIdFilter.Size = new System.Drawing.Size(102, 23);
            this.textBoxItemIdFilter.TabIndex = 8;
            this.textBoxItemIdFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxItemIdFilter_KeyPress);
            // 
            // panelItemIdFilter
            // 
            this.panelItemIdFilter.Controls.Add(this.textBoxItemIdFilter);
            this.panelItemIdFilter.Controls.Add(this.labelTransactionItemId);
            this.panelItemIdFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelItemIdFilter.Location = new System.Drawing.Point(0, 181);
            this.panelItemIdFilter.Name = "panelItemIdFilter";
            this.panelItemIdFilter.Size = new System.Drawing.Size(438, 75);
            this.panelItemIdFilter.TabIndex = 10;
            this.panelItemIdFilter.Visible = false;
            // 
            // Filter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(438, 341);
            this.Controls.Add(this.panelConfirm);
            this.Controls.Add(this.panelItemIdFilter);
            this.Controls.Add(this.panelFilterLeft);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Filter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filter";
            this.panelFilterLeft.ResumeLayout(false);
            this.panelFilterLeft.PerformLayout();
            this.panelConfirm.ResumeLayout(false);
            this.panelConfirm.PerformLayout();
            this.panelItemIdFilter.ResumeLayout(false);
            this.panelItemIdFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public POS_Controls.Buttons filterConfirm;
        private System.Windows.Forms.Label labelTransactionFilterType;
        public System.Windows.Forms.ComboBox comboBoxTransactionType;
        private System.Windows.Forms.Label labelTransactionFilterStartDate;
        public System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label labelTransactionFilterEndDate;
        private System.Windows.Forms.CheckBox filterByDateCheckBox;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelFilterClear;
        private System.Windows.Forms.Label labelTransactionItemId;
        private System.Windows.Forms.TextBox textBoxItemIdFilter;
        public System.Windows.Forms.Panel panelItemIdFilter;
        public System.Windows.Forms.Panel panelConfirm;
        public System.Windows.Forms.Panel panelFilterLeft;
    }
}