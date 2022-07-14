
namespace POS1.Inventory_Forms
{
    partial class InventoryCreateCategory
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
            this.buttonsInventoryCreateCategory = new POS1.POS_Controls.Buttons();
            this.labelInventoryCreateCategory = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonsInventoryCreateCategory
            // 
            this.buttonsInventoryCreateCategory.BackColor = System.Drawing.Color.White;
            this.buttonsInventoryCreateCategory.BackgroundColor = System.Drawing.Color.White;
            this.buttonsInventoryCreateCategory.BorderColor = System.Drawing.Color.Black;
            this.buttonsInventoryCreateCategory.BorderRadius = 20;
            this.buttonsInventoryCreateCategory.BorderSize = 4;
            this.buttonsInventoryCreateCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonsInventoryCreateCategory.FlatAppearance.BorderSize = 0;
            this.buttonsInventoryCreateCategory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonsInventoryCreateCategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonsInventoryCreateCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonsInventoryCreateCategory.ForeColor = System.Drawing.Color.White;
            this.buttonsInventoryCreateCategory.Location = new System.Drawing.Point(1, 0);
            this.buttonsInventoryCreateCategory.Name = "buttonsInventoryCreateCategory";
            this.buttonsInventoryCreateCategory.Size = new System.Drawing.Size(98, 107);
            this.buttonsInventoryCreateCategory.TabIndex = 0;
            this.buttonsInventoryCreateCategory.TextColor = System.Drawing.Color.White;
            this.buttonsInventoryCreateCategory.UseVisualStyleBackColor = false;
            this.buttonsInventoryCreateCategory.Click += new System.EventHandler(this.buttonsInventoryCreateCategory_Click);
            // 
            // labelInventoryCreateCategory
            // 
            this.labelInventoryCreateCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelInventoryCreateCategory.BackColor = System.Drawing.Color.White;
            this.labelInventoryCreateCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelInventoryCreateCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelInventoryCreateCategory.Location = new System.Drawing.Point(9, 35);
            this.labelInventoryCreateCategory.Name = "labelInventoryCreateCategory";
            this.labelInventoryCreateCategory.Size = new System.Drawing.Size(82, 45);
            this.labelInventoryCreateCategory.TabIndex = 1;
            this.labelInventoryCreateCategory.Text = "Men";
            this.labelInventoryCreateCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelInventoryCreateCategory.Click += new System.EventHandler(this.labelInventoryCreateCategory_Click);
            // 
            // InventoryCreateCategory
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.labelInventoryCreateCategory);
            this.Controls.Add(this.buttonsInventoryCreateCategory);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "InventoryCreateCategory";
            this.Size = new System.Drawing.Size(99, 107);
            this.ResumeLayout(false);

        }

        #endregion

        private POS_Controls.Buttons buttonsInventoryCreateCategory;
        private System.Windows.Forms.Label labelInventoryCreateCategory;
    }
}
