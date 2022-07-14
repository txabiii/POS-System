
namespace POS1.Inventory_Forms
{
    partial class InventoryFilter
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
            this.panelInventoryFilter = new System.Windows.Forms.Panel();
            this.comboBoxOrderByDate = new System.Windows.Forms.ComboBox();
            this.labelFilterByDate = new System.Windows.Forms.Label();
            this.labelFilterClear = new System.Windows.Forms.Label();
            this.filterConfirm = new POS1.POS_Controls.Buttons();
            this.comboBoxInventoryFilterOrderByPrice = new System.Windows.Forms.ComboBox();
            this.comboBoxInventoryFilterAlphabeticalOrder = new System.Windows.Forms.ComboBox();
            this.comboBoxInventoryFilterCategory = new System.Windows.Forms.ComboBox();
            this.labelInventoryFilterOrderByPrice = new System.Windows.Forms.Label();
            this.labelInventoryFilterAlphabeticalOrder = new System.Windows.Forms.Label();
            this.labelInventoryFilterCategory = new System.Windows.Forms.Label();
            this.panelInventoryFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelInventoryFilter
            // 
            this.panelInventoryFilter.Controls.Add(this.comboBoxOrderByDate);
            this.panelInventoryFilter.Controls.Add(this.labelFilterByDate);
            this.panelInventoryFilter.Controls.Add(this.labelFilterClear);
            this.panelInventoryFilter.Controls.Add(this.filterConfirm);
            this.panelInventoryFilter.Controls.Add(this.comboBoxInventoryFilterOrderByPrice);
            this.panelInventoryFilter.Controls.Add(this.comboBoxInventoryFilterAlphabeticalOrder);
            this.panelInventoryFilter.Controls.Add(this.comboBoxInventoryFilterCategory);
            this.panelInventoryFilter.Controls.Add(this.labelInventoryFilterOrderByPrice);
            this.panelInventoryFilter.Controls.Add(this.labelInventoryFilterAlphabeticalOrder);
            this.panelInventoryFilter.Controls.Add(this.labelInventoryFilterCategory);
            this.panelInventoryFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInventoryFilter.Location = new System.Drawing.Point(0, 0);
            this.panelInventoryFilter.Margin = new System.Windows.Forms.Padding(2);
            this.panelInventoryFilter.Name = "panelInventoryFilter";
            this.panelInventoryFilter.Size = new System.Drawing.Size(463, 291);
            this.panelInventoryFilter.TabIndex = 0;
            // 
            // comboBoxOrderByDate
            // 
            this.comboBoxOrderByDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxOrderByDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOrderByDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxOrderByDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxOrderByDate.Items.AddRange(new object[] {
            "",
            "Most Recent",
            "Least Recent"});
            this.comboBoxOrderByDate.Location = new System.Drawing.Point(204, 162);
            this.comboBoxOrderByDate.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxOrderByDate.Name = "comboBoxOrderByDate";
            this.comboBoxOrderByDate.Size = new System.Drawing.Size(209, 23);
            this.comboBoxOrderByDate.TabIndex = 13;
            // 
            // labelFilterByDate
            // 
            this.labelFilterByDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelFilterByDate.Location = new System.Drawing.Point(45, 162);
            this.labelFilterByDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFilterByDate.Name = "labelFilterByDate";
            this.labelFilterByDate.Size = new System.Drawing.Size(162, 21);
            this.labelFilterByDate.TabIndex = 12;
            this.labelFilterByDate.Text = "Order by Date Added:\r\n";
            this.labelFilterByDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelFilterClear
            // 
            this.labelFilterClear.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelFilterClear.AutoSize = true;
            this.labelFilterClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelFilterClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFilterClear.ForeColor = System.Drawing.Color.Tomato;
            this.labelFilterClear.Location = new System.Drawing.Point(318, 240);
            this.labelFilterClear.Name = "labelFilterClear";
            this.labelFilterClear.Size = new System.Drawing.Size(40, 18);
            this.labelFilterClear.TabIndex = 11;
            this.labelFilterClear.Text = "clear";
            this.labelFilterClear.Click += new System.EventHandler(this.labelFilterClear_Click);
            // 
            // filterConfirm
            // 
            this.filterConfirm.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.filterConfirm.BackColor = System.Drawing.Color.Gainsboro;
            this.filterConfirm.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.filterConfirm.BorderColor = System.Drawing.Color.Transparent;
            this.filterConfirm.BorderRadius = 15;
            this.filterConfirm.BorderSize = 3;
            this.filterConfirm.FlatAppearance.BorderSize = 0;
            this.filterConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filterConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.filterConfirm.ForeColor = System.Drawing.Color.Black;
            this.filterConfirm.Location = new System.Drawing.Point(157, 231);
            this.filterConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.filterConfirm.Name = "filterConfirm";
            this.filterConfirm.Size = new System.Drawing.Size(150, 35);
            this.filterConfirm.TabIndex = 10;
            this.filterConfirm.Text = "confirm";
            this.filterConfirm.TextColor = System.Drawing.Color.Black;
            this.filterConfirm.UseVisualStyleBackColor = false;
            this.filterConfirm.Click += new System.EventHandler(this.filterConfirm_Click);
            // 
            // comboBoxInventoryFilterOrderByPrice
            // 
            this.comboBoxInventoryFilterOrderByPrice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxInventoryFilterOrderByPrice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxInventoryFilterOrderByPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxInventoryFilterOrderByPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxInventoryFilterOrderByPrice.Items.AddRange(new object[] {
            "",
            "Lowest ",
            "Highest"});
            this.comboBoxInventoryFilterOrderByPrice.Location = new System.Drawing.Point(204, 120);
            this.comboBoxInventoryFilterOrderByPrice.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxInventoryFilterOrderByPrice.Name = "comboBoxInventoryFilterOrderByPrice";
            this.comboBoxInventoryFilterOrderByPrice.Size = new System.Drawing.Size(209, 23);
            this.comboBoxInventoryFilterOrderByPrice.TabIndex = 5;
            // 
            // comboBoxInventoryFilterAlphabeticalOrder
            // 
            this.comboBoxInventoryFilterAlphabeticalOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxInventoryFilterAlphabeticalOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxInventoryFilterAlphabeticalOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxInventoryFilterAlphabeticalOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxInventoryFilterAlphabeticalOrder.Items.AddRange(new object[] {
            "",
            "A to Z",
            "Z to A"});
            this.comboBoxInventoryFilterAlphabeticalOrder.Location = new System.Drawing.Point(204, 78);
            this.comboBoxInventoryFilterAlphabeticalOrder.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxInventoryFilterAlphabeticalOrder.Name = "comboBoxInventoryFilterAlphabeticalOrder";
            this.comboBoxInventoryFilterAlphabeticalOrder.Size = new System.Drawing.Size(209, 23);
            this.comboBoxInventoryFilterAlphabeticalOrder.TabIndex = 4;
            // 
            // comboBoxInventoryFilterCategory
            // 
            this.comboBoxInventoryFilterCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxInventoryFilterCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxInventoryFilterCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxInventoryFilterCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxInventoryFilterCategory.ForeColor = System.Drawing.Color.Black;
            this.comboBoxInventoryFilterCategory.Location = new System.Drawing.Point(204, 36);
            this.comboBoxInventoryFilterCategory.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxInventoryFilterCategory.Name = "comboBoxInventoryFilterCategory";
            this.comboBoxInventoryFilterCategory.Size = new System.Drawing.Size(209, 23);
            this.comboBoxInventoryFilterCategory.TabIndex = 3;
            // 
            // labelInventoryFilterOrderByPrice
            // 
            this.labelInventoryFilterOrderByPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelInventoryFilterOrderByPrice.Location = new System.Drawing.Point(45, 120);
            this.labelInventoryFilterOrderByPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelInventoryFilterOrderByPrice.Name = "labelInventoryFilterOrderByPrice";
            this.labelInventoryFilterOrderByPrice.Size = new System.Drawing.Size(162, 21);
            this.labelInventoryFilterOrderByPrice.TabIndex = 2;
            this.labelInventoryFilterOrderByPrice.Text = "Order by Price:";
            this.labelInventoryFilterOrderByPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelInventoryFilterAlphabeticalOrder
            // 
            this.labelInventoryFilterAlphabeticalOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelInventoryFilterAlphabeticalOrder.Location = new System.Drawing.Point(45, 78);
            this.labelInventoryFilterAlphabeticalOrder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelInventoryFilterAlphabeticalOrder.Name = "labelInventoryFilterAlphabeticalOrder";
            this.labelInventoryFilterAlphabeticalOrder.Size = new System.Drawing.Size(162, 21);
            this.labelInventoryFilterAlphabeticalOrder.TabIndex = 1;
            this.labelInventoryFilterAlphabeticalOrder.Text = "Alphabetical Order:";
            this.labelInventoryFilterAlphabeticalOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelInventoryFilterCategory
            // 
            this.labelInventoryFilterCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelInventoryFilterCategory.Location = new System.Drawing.Point(45, 36);
            this.labelInventoryFilterCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelInventoryFilterCategory.Name = "labelInventoryFilterCategory";
            this.labelInventoryFilterCategory.Size = new System.Drawing.Size(108, 21);
            this.labelInventoryFilterCategory.TabIndex = 0;
            this.labelInventoryFilterCategory.Text = "Category:";
            this.labelInventoryFilterCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // InventoryFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(463, 291);
            this.Controls.Add(this.panelInventoryFilter);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InventoryFilter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Filter";
            this.panelInventoryFilter.ResumeLayout(false);
            this.panelInventoryFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelInventoryFilter;
        private System.Windows.Forms.Label labelInventoryFilterOrderByPrice;
        private System.Windows.Forms.Label labelInventoryFilterAlphabeticalOrder;
        private System.Windows.Forms.Label labelInventoryFilterCategory;
        private System.Windows.Forms.ComboBox comboBoxInventoryFilterOrderByPrice;
        private System.Windows.Forms.ComboBox comboBoxInventoryFilterAlphabeticalOrder;
        private System.Windows.Forms.ComboBox comboBoxInventoryFilterCategory;
        private System.Windows.Forms.Label labelFilterClear;
        public POS_Controls.Buttons filterConfirm;
        private System.Windows.Forms.ComboBox comboBoxOrderByDate;
        private System.Windows.Forms.Label labelFilterByDate;
    }
}