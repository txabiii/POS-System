
namespace POS1.POS_Controls
{
    partial class ColorOption
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
            this.ColorButton = new POS1.POS_Controls.Buttons();
            this.SuspendLayout();
            // 
            // ColorButton
            // 
            this.ColorButton.AutoSize = true;
            this.ColorButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ColorButton.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.ColorButton.BorderColor = System.Drawing.Color.Black;
            this.ColorButton.BorderRadius = 17;
            this.ColorButton.BorderSize = 2;
            this.ColorButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ColorButton.FlatAppearance.BorderSize = 0;
            this.ColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ColorButton.ForeColor = System.Drawing.Color.Black;
            this.ColorButton.Location = new System.Drawing.Point(2, 2);
            this.ColorButton.Margin = new System.Windows.Forms.Padding(2);
            this.ColorButton.Name = "ColorButton";
            this.ColorButton.Size = new System.Drawing.Size(35, 35);
            this.ColorButton.TabIndex = 14;
            this.ColorButton.TextColor = System.Drawing.Color.Black;
            this.ColorButton.UseVisualStyleBackColor = false;
            // 
            // ColorOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ColorButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ColorOption";
            this.Size = new System.Drawing.Size(38, 40);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Buttons ColorButton;
    }
}
