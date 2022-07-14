
namespace POS1.POS_Controls
{
    partial class CategoryButton
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
            this.buttonCategory = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // buttonCategory
            // 
            this.buttonCategory.Appearance = System.Windows.Forms.Appearance.Button;
            this.buttonCategory.AutoSize = true;
            this.buttonCategory.BackColor = System.Drawing.Color.Transparent;
            this.buttonCategory.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonCategory.FlatAppearance.BorderSize = 0;
            this.buttonCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCategory.Font = new System.Drawing.Font("Roboto Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCategory.Location = new System.Drawing.Point(0, 0);
            this.buttonCategory.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.buttonCategory.Name = "buttonCategory";
            this.buttonCategory.Padding = new System.Windows.Forms.Padding(30, 10, 30, 10);
            this.buttonCategory.Size = new System.Drawing.Size(160, 53);
            this.buttonCategory.TabIndex = 0;
            this.buttonCategory.TabStop = true;
            this.buttonCategory.Text = "Category";
            this.buttonCategory.UseVisualStyleBackColor = false;
            this.buttonCategory.CheckedChanged += new System.EventHandler(this.buttonCategory_CheckedChanged);
            this.buttonCategory.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonCategory_Paint);
            // 
            // CategoryButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonCategory);
            this.Name = "CategoryButton";
            this.Size = new System.Drawing.Size(115, 48);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.RadioButton buttonCategory;
    }
}
