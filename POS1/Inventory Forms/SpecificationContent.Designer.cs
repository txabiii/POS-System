
namespace POS1.Inventory_Forms
{
    partial class SpecificationContent
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
            this.ArrangementButton = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Label();
            this.panelSpecificattionName = new System.Windows.Forms.Panel();
            this.SpecificationTextBox = new System.Windows.Forms.TextBox();
            this.panelColor = new System.Windows.Forms.Panel();
            this.comboBoxColor = new System.Windows.Forms.ComboBox();
            this.panelColorDisplay = new System.Windows.Forms.Panel();
            this.panelSpecificattionName.SuspendLayout();
            this.panelColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // ArrangementButton
            // 
            this.ArrangementButton.BackColor = System.Drawing.Color.Transparent;
            this.ArrangementButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ArrangementButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.ArrangementButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ArrangementButton.Location = new System.Drawing.Point(0, 0);
            this.ArrangementButton.Name = "ArrangementButton";
            this.ArrangementButton.Size = new System.Drawing.Size(66, 39);
            this.ArrangementButton.TabIndex = 4;
            this.ArrangementButton.Text = "☰";
            this.ArrangementButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ArrangementButton.Click += new System.EventHandler(this.ArrangementButton_Click);
            this.ArrangementButton.MouseEnter += new System.EventHandler(this.ArrangementButton_MouseEnter);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.Transparent;
            this.DeleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeleteButton.Location = new System.Drawing.Point(280, 0);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(25, 39);
            this.DeleteButton.TabIndex = 6;
            this.DeleteButton.Text = "✕";
            this.DeleteButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // panelSpecificattionName
            // 
            this.panelSpecificattionName.Controls.Add(this.SpecificationTextBox);
            this.panelSpecificattionName.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSpecificattionName.Location = new System.Drawing.Point(66, 0);
            this.panelSpecificattionName.Name = "panelSpecificattionName";
            this.panelSpecificattionName.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.panelSpecificattionName.Size = new System.Drawing.Size(171, 39);
            this.panelSpecificattionName.TabIndex = 8;
            // 
            // SpecificationTextBox
            // 
            this.SpecificationTextBox.BackColor = System.Drawing.Color.White;
            this.SpecificationTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SpecificationTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpecificationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SpecificationTextBox.Location = new System.Drawing.Point(0, 10);
            this.SpecificationTextBox.Multiline = true;
            this.SpecificationTextBox.Name = "SpecificationTextBox";
            this.SpecificationTextBox.PlaceholderText = "Specification";
            this.SpecificationTextBox.Size = new System.Drawing.Size(171, 19);
            this.SpecificationTextBox.TabIndex = 8;
            // 
            // panelColor
            // 
            this.panelColor.Controls.Add(this.comboBoxColor);
            this.panelColor.Controls.Add(this.panelColorDisplay);
            this.panelColor.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelColor.Location = new System.Drawing.Point(237, 0);
            this.panelColor.Name = "panelColor";
            this.panelColor.Padding = new System.Windows.Forms.Padding(0, 7, 0, 7);
            this.panelColor.Size = new System.Drawing.Size(171, 39);
            this.panelColor.TabIndex = 12;
            this.panelColor.Visible = false;
            // 
            // comboBoxColor
            // 
            this.comboBoxColor.BackColor = System.Drawing.Color.White;
            this.comboBoxColor.Dock = System.Windows.Forms.DockStyle.Right;
            this.comboBoxColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxColor.FormattingEnabled = true;
            this.comboBoxColor.Location = new System.Drawing.Point(31, 7);
            this.comboBoxColor.Name = "comboBoxColor";
            this.comboBoxColor.Size = new System.Drawing.Size(140, 25);
            this.comboBoxColor.TabIndex = 1;
            this.comboBoxColor.DropDown += new System.EventHandler(this.comboBoxColor_DropDown);
            this.comboBoxColor.SelectedIndexChanged += new System.EventHandler(this.comboBoxColor_SelectedIndexChanged);
            // 
            // panelColorDisplay
            // 
            this.panelColorDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColorDisplay.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelColorDisplay.Location = new System.Drawing.Point(0, 7);
            this.panelColorDisplay.Name = "panelColorDisplay";
            this.panelColorDisplay.Size = new System.Drawing.Size(25, 25);
            this.panelColorDisplay.TabIndex = 0;
            // 
            // SpecificationContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelColor);
            this.Controls.Add(this.panelSpecificattionName);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.ArrangementButton);
            this.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.Name = "SpecificationContent";
            this.Size = new System.Drawing.Size(305, 39);
            this.panelSpecificattionName.ResumeLayout(false);
            this.panelSpecificattionName.PerformLayout();
            this.panelColor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label ArrangementButton;
        private System.Windows.Forms.Label DeleteButton;
        private System.Windows.Forms.Panel panelSpecificattionName;
        public System.Windows.Forms.TextBox SpecificationTextBox;
        private System.Windows.Forms.Panel panelColor;
        private System.Windows.Forms.ComboBox comboBoxColor;
        private System.Windows.Forms.Panel panelColorDisplay;
    }
}
