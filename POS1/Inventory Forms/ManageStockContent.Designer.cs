
namespace POS1.Inventory_Forms
{
    partial class ManageStockContent
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelUnderline = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelSize = new System.Windows.Forms.Panel();
            this.labelSize = new System.Windows.Forms.Label();
            this.comboBoxSize = new System.Windows.Forms.ComboBox();
            this.MinusButton = new POS1.POS_Controls.Buttons();
            this.panelStock = new System.Windows.Forms.Panel();
            this.textBoxStock = new System.Windows.Forms.TextBox();
            this.AddButton = new POS1.POS_Controls.Buttons();
            this.panelColor = new System.Windows.Forms.Panel();
            this.labelColor = new System.Windows.Forms.Label();
            this.comboBoxColor = new System.Windows.Forms.ComboBox();
            this.panelMain.SuspendLayout();
            this.panelSize.SuspendLayout();
            this.panelStock.SuspendLayout();
            this.panelColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUnderline
            // 
            this.panelUnderline.BackColor = System.Drawing.Color.Gainsboro;
            this.panelUnderline.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelUnderline.Location = new System.Drawing.Point(0, 48);
            this.panelUnderline.Name = "panelUnderline";
            this.panelUnderline.Size = new System.Drawing.Size(350, 2);
            this.panelUnderline.TabIndex = 18;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Controls.Add(this.panelSize);
            this.panelMain.Controls.Add(this.MinusButton);
            this.panelMain.Controls.Add(this.panelStock);
            this.panelMain.Controls.Add(this.AddButton);
            this.panelMain.Controls.Add(this.panelColor);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(9);
            this.panelMain.Size = new System.Drawing.Size(350, 48);
            this.panelMain.TabIndex = 21;
            // 
            // panelSize
            // 
            this.panelSize.Controls.Add(this.labelSize);
            this.panelSize.Controls.Add(this.comboBoxSize);
            this.panelSize.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSize.Location = new System.Drawing.Point(96, 9);
            this.panelSize.Name = "panelSize";
            this.panelSize.Size = new System.Drawing.Size(87, 30);
            this.panelSize.TabIndex = 17;
            // 
            // labelSize
            // 
            this.labelSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSize.Location = new System.Drawing.Point(0, 26);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(87, 4);
            this.labelSize.TabIndex = 3;
            this.labelSize.Text = "Size";
            this.labelSize.Visible = false;
            // 
            // comboBoxSize
            // 
            this.comboBoxSize.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBoxSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxSize.FormattingEnabled = true;
            this.comboBoxSize.Location = new System.Drawing.Point(0, 0);
            this.comboBoxSize.Name = "comboBoxSize";
            this.comboBoxSize.Size = new System.Drawing.Size(87, 26);
            this.comboBoxSize.TabIndex = 0;
            this.comboBoxSize.DropDown += new System.EventHandler(this.comboBoxSize_DropDown);
            this.comboBoxSize.SelectedIndexChanged += new System.EventHandler(this.comboBoxSize_SelectedIndexChanged);
            // 
            // MinusButton
            // 
            this.MinusButton.BackColor = System.Drawing.Color.White;
            this.MinusButton.BackgroundColor = System.Drawing.Color.White;
            this.MinusButton.BorderColor = System.Drawing.Color.Black;
            this.MinusButton.BorderRadius = 10;
            this.MinusButton.BorderSize = 2;
            this.MinusButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinusButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.MinusButton.FlatAppearance.BorderSize = 0;
            this.MinusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinusButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MinusButton.ForeColor = System.Drawing.Color.Black;
            this.MinusButton.Location = new System.Drawing.Point(211, 9);
            this.MinusButton.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.MinusButton.Name = "MinusButton";
            this.MinusButton.Size = new System.Drawing.Size(30, 30);
            this.MinusButton.TabIndex = 16;
            this.MinusButton.Text = " -";
            this.MinusButton.TextColor = System.Drawing.Color.Black;
            this.MinusButton.UseVisualStyleBackColor = false;
            this.MinusButton.Click += new System.EventHandler(this.MinusButton_Click);
            // 
            // panelStock
            // 
            this.panelStock.Controls.Add(this.textBoxStock);
            this.panelStock.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelStock.Location = new System.Drawing.Point(241, 9);
            this.panelStock.Name = "panelStock";
            this.panelStock.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.panelStock.Size = new System.Drawing.Size(70, 30);
            this.panelStock.TabIndex = 15;
            // 
            // textBoxStock
            // 
            this.textBoxStock.BackColor = System.Drawing.Color.White;
            this.textBoxStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxStock.Location = new System.Drawing.Point(0, 6);
            this.textBoxStock.Name = "textBoxStock";
            this.textBoxStock.PlaceholderText = "Stock";
            this.textBoxStock.Size = new System.Drawing.Size(70, 17);
            this.textBoxStock.TabIndex = 8;
            this.textBoxStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStock_KeyPress);
            this.textBoxStock.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxStock_KeyUp);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.White;
            this.AddButton.BackgroundColor = System.Drawing.Color.White;
            this.AddButton.BorderColor = System.Drawing.Color.Black;
            this.AddButton.BorderRadius = 10;
            this.AddButton.BorderSize = 2;
            this.AddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddButton.ForeColor = System.Drawing.Color.Black;
            this.AddButton.Location = new System.Drawing.Point(311, 9);
            this.AddButton.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(30, 30);
            this.AddButton.TabIndex = 14;
            this.AddButton.Text = " +";
            this.AddButton.TextColor = System.Drawing.Color.Black;
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // panelColor
            // 
            this.panelColor.Controls.Add(this.labelColor);
            this.panelColor.Controls.Add(this.comboBoxColor);
            this.panelColor.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelColor.Location = new System.Drawing.Point(9, 9);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(87, 30);
            this.panelColor.TabIndex = 12;
            // 
            // labelColor
            // 
            this.labelColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelColor.Location = new System.Drawing.Point(0, 26);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(87, 4);
            this.labelColor.TabIndex = 2;
            this.labelColor.Text = "Color";
            this.labelColor.Visible = false;
            // 
            // comboBoxColor
            // 
            this.comboBoxColor.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBoxColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxColor.FormattingEnabled = true;
            this.comboBoxColor.Location = new System.Drawing.Point(0, 0);
            this.comboBoxColor.Name = "comboBoxColor";
            this.comboBoxColor.Size = new System.Drawing.Size(87, 26);
            this.comboBoxColor.TabIndex = 0;
            this.comboBoxColor.DropDown += new System.EventHandler(this.comboBoxColor_DropDown);
            this.comboBoxColor.SelectedIndexChanged += new System.EventHandler(this.comboBoxColor_SelectedIndexChanged);
            // 
            // ManageStockContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelUnderline);
            this.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.Name = "ManageStockContent";
            this.Size = new System.Drawing.Size(350, 50);
            this.panelMain.ResumeLayout(false);
            this.panelSize.ResumeLayout(false);
            this.panelStock.ResumeLayout(false);
            this.panelStock.PerformLayout();
            this.panelColor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUnderline;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelSize;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.ComboBox comboBoxSize;
        private POS_Controls.Buttons MinusButton;
        private System.Windows.Forms.Panel panelStock;
        private System.Windows.Forms.TextBox textBoxStock;
        private POS_Controls.Buttons AddButton;
        private System.Windows.Forms.Panel panelColor;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.ComboBox comboBoxColor;
    }
}
