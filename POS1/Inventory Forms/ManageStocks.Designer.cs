
namespace POS1.Inventory_Forms
{
    partial class ManageStocks
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
            this.ManageStocksHeader = new System.Windows.Forms.Panel();
            this.panelRemarks = new System.Windows.Forms.Panel();
            this.textBoxRemarks = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.labelRemarks = new System.Windows.Forms.Label();
            this.buttonsClear = new POS1.POS_Controls.Buttons();
            this.labelItemName = new System.Windows.Forms.Label();
            this.ManageStocksContentPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttons2 = new POS1.POS_Controls.Buttons();
            this.buttonStocksConfirm = new POS1.POS_Controls.Buttons();
            this.ManageStocksConfirmPanel = new System.Windows.Forms.Panel();
            this.ManageStocksHeader.SuspendLayout();
            this.panelRemarks.SuspendLayout();
            this.panel2.SuspendLayout();
            this.ManageStocksContentPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.ManageStocksConfirmPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ManageStocksHeader
            // 
            this.ManageStocksHeader.Controls.Add(this.panelRemarks);
            this.ManageStocksHeader.Controls.Add(this.buttonsClear);
            this.ManageStocksHeader.Controls.Add(this.labelItemName);
            this.ManageStocksHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.ManageStocksHeader.Location = new System.Drawing.Point(20, 20);
            this.ManageStocksHeader.Name = "ManageStocksHeader";
            this.ManageStocksHeader.Size = new System.Drawing.Size(388, 146);
            this.ManageStocksHeader.TabIndex = 0;
            // 
            // panelRemarks
            // 
            this.panelRemarks.BackColor = System.Drawing.Color.White;
            this.panelRemarks.Controls.Add(this.textBoxRemarks);
            this.panelRemarks.Controls.Add(this.panel2);
            this.panelRemarks.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelRemarks.Location = new System.Drawing.Point(0, 49);
            this.panelRemarks.Name = "panelRemarks";
            this.panelRemarks.Padding = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.panelRemarks.Size = new System.Drawing.Size(388, 97);
            this.panelRemarks.TabIndex = 23;
            this.panelRemarks.Visible = false;
            // 
            // textBoxRemarks
            // 
            this.textBoxRemarks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxRemarks.Location = new System.Drawing.Point(10, 20);
            this.textBoxRemarks.Multiline = true;
            this.textBoxRemarks.Name = "textBoxRemarks";
            this.textBoxRemarks.PlaceholderText = "e.g. Product is returned due to defect";
            this.textBoxRemarks.Size = new System.Drawing.Size(368, 67);
            this.textBoxRemarks.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelQuantity);
            this.panel2.Controls.Add(this.labelRemarks);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(10, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(368, 20);
            this.panel2.TabIndex = 0;
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelQuantity.ForeColor = System.Drawing.Color.Red;
            this.labelQuantity.Location = new System.Drawing.Point(303, 0);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(65, 17);
            this.labelQuantity.TabIndex = 2;
            this.labelQuantity.Text = "-3 stocks";
            // 
            // labelRemarks
            // 
            this.labelRemarks.AutoSize = true;
            this.labelRemarks.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRemarks.Location = new System.Drawing.Point(0, 0);
            this.labelRemarks.Name = "labelRemarks";
            this.labelRemarks.Size = new System.Drawing.Size(72, 17);
            this.labelRemarks.TabIndex = 1;
            this.labelRemarks.Text = "Remarks: ";
            // 
            // buttonsClear
            // 
            this.buttonsClear.BackColor = System.Drawing.Color.Tomato;
            this.buttonsClear.BackgroundColor = System.Drawing.Color.Tomato;
            this.buttonsClear.BorderColor = System.Drawing.Color.Transparent;
            this.buttonsClear.BorderRadius = 13;
            this.buttonsClear.BorderSize = 3;
            this.buttonsClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonsClear.FlatAppearance.BorderSize = 0;
            this.buttonsClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonsClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonsClear.ForeColor = System.Drawing.Color.White;
            this.buttonsClear.Location = new System.Drawing.Point(313, 0);
            this.buttonsClear.Margin = new System.Windows.Forms.Padding(2);
            this.buttonsClear.Name = "buttonsClear";
            this.buttonsClear.Size = new System.Drawing.Size(75, 26);
            this.buttonsClear.TabIndex = 3;
            this.buttonsClear.Text = "clear all";
            this.buttonsClear.TextColor = System.Drawing.Color.White;
            this.buttonsClear.UseVisualStyleBackColor = false;
            this.buttonsClear.Click += new System.EventHandler(this.buttons1_Click);
            // 
            // labelItemName
            // 
            this.labelItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelItemName.Location = new System.Drawing.Point(0, 0);
            this.labelItemName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelItemName.Name = "labelItemName";
            this.labelItemName.Size = new System.Drawing.Size(222, 43);
            this.labelItemName.TabIndex = 1;
            this.labelItemName.Text = "Item Name";
            // 
            // ManageStocksContentPanel
            // 
            this.ManageStocksContentPanel.AutoScroll = true;
            this.ManageStocksContentPanel.AutoSize = true;
            this.ManageStocksContentPanel.Controls.Add(this.panel3);
            this.ManageStocksContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ManageStocksContentPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ManageStocksContentPanel.Location = new System.Drawing.Point(20, 166);
            this.ManageStocksContentPanel.Name = "ManageStocksContentPanel";
            this.ManageStocksContentPanel.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.ManageStocksContentPanel.Size = new System.Drawing.Size(388, 222);
            this.ManageStocksContentPanel.TabIndex = 2;
            this.ManageStocksContentPanel.WrapContents = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttons2);
            this.panel3.Location = new System.Drawing.Point(18, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(350, 50);
            this.panel3.TabIndex = 23;
            // 
            // buttons2
            // 
            this.buttons2.BackColor = System.Drawing.Color.Gainsboro;
            this.buttons2.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.buttons2.BorderColor = System.Drawing.Color.Transparent;
            this.buttons2.BorderRadius = 18;
            this.buttons2.BorderSize = 3;
            this.buttons2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttons2.FlatAppearance.BorderSize = 0;
            this.buttons2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttons2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttons2.ForeColor = System.Drawing.Color.Black;
            this.buttons2.Location = new System.Drawing.Point(157, 7);
            this.buttons2.Margin = new System.Windows.Forms.Padding(2);
            this.buttons2.Name = "buttons2";
            this.buttons2.Size = new System.Drawing.Size(36, 36);
            this.buttons2.TabIndex = 3;
            this.buttons2.Text = " +";
            this.buttons2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttons2.TextColor = System.Drawing.Color.Black;
            this.buttons2.UseVisualStyleBackColor = false;
            this.buttons2.Click += new System.EventHandler(this.buttons2_Click);
            // 
            // buttonStocksConfirm
            // 
            this.buttonStocksConfirm.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonStocksConfirm.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.buttonStocksConfirm.BorderColor = System.Drawing.Color.Transparent;
            this.buttonStocksConfirm.BorderRadius = 15;
            this.buttonStocksConfirm.BorderSize = 3;
            this.buttonStocksConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStocksConfirm.FlatAppearance.BorderSize = 0;
            this.buttonStocksConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStocksConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonStocksConfirm.ForeColor = System.Drawing.Color.Black;
            this.buttonStocksConfirm.Location = new System.Drawing.Point(124, 28);
            this.buttonStocksConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStocksConfirm.Name = "buttonStocksConfirm";
            this.buttonStocksConfirm.Size = new System.Drawing.Size(150, 35);
            this.buttonStocksConfirm.TabIndex = 2;
            this.buttonStocksConfirm.Text = "confirm";
            this.buttonStocksConfirm.TextColor = System.Drawing.Color.Black;
            this.buttonStocksConfirm.UseVisualStyleBackColor = false;
            this.buttonStocksConfirm.Click += new System.EventHandler(this.buttonStocksConfirm_Click);
            // 
            // ManageStocksConfirmPanel
            // 
            this.ManageStocksConfirmPanel.Controls.Add(this.buttonStocksConfirm);
            this.ManageStocksConfirmPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ManageStocksConfirmPanel.Location = new System.Drawing.Point(20, 388);
            this.ManageStocksConfirmPanel.Name = "ManageStocksConfirmPanel";
            this.ManageStocksConfirmPanel.Size = new System.Drawing.Size(388, 65);
            this.ManageStocksConfirmPanel.TabIndex = 1;
            // 
            // ManageStocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(428, 473);
            this.Controls.Add(this.ManageStocksContentPanel);
            this.Controls.Add(this.ManageStocksConfirmPanel);
            this.Controls.Add(this.ManageStocksHeader);
            this.MaximumSize = new System.Drawing.Size(444, 1000);
            this.MinimumSize = new System.Drawing.Size(444, 350);
            this.Name = "ManageStocks";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "ManageStocks";
            this.Load += new System.EventHandler(this.ManageStocks_Load);
            this.ManageStocksHeader.ResumeLayout(false);
            this.panelRemarks.ResumeLayout(false);
            this.panelRemarks.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ManageStocksContentPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ManageStocksConfirmPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ManageStocksHeader;
        private System.Windows.Forms.FlowLayoutPanel ManageStocksContentPanel;
        public POS_Controls.Buttons buttonsClear;
        public POS_Controls.Buttons filterConfirm;
        private System.Windows.Forms.Label labelItemName;
        private System.Windows.Forms.Panel panel3;
        public POS_Controls.Buttons buttons2;
        private System.Windows.Forms.Panel panelRemarks;
        private System.Windows.Forms.TextBox textBoxRemarks;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelRemarks;
        public POS_Controls.Buttons buttonStocksConfirm;
        private System.Windows.Forms.Panel ManageStocksConfirmPanel;
    }
}