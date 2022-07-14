
namespace POS1.POS_Controls
{
    partial class SizeOption
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
            this.buttonSize = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // buttonSize
            // 
            this.buttonSize.Appearance = System.Windows.Forms.Appearance.Button;
            this.buttonSize.AutoSize = true;
            this.buttonSize.BackColor = System.Drawing.SystemColors.Window;
            this.buttonSize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSize.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonSize.FlatAppearance.BorderSize = 2;
            this.buttonSize.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSize.Font = new System.Drawing.Font("Roboto Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSize.Location = new System.Drawing.Point(0, 0);
            this.buttonSize.Name = "buttonSize";
            this.buttonSize.Padding = new System.Windows.Forms.Padding(0, 7, 0, 7);
            this.buttonSize.Size = new System.Drawing.Size(74, 54);
            this.buttonSize.TabIndex = 8;
            this.buttonSize.Text = "Size";
            this.buttonSize.UseVisualStyleBackColor = false;
            // 
            // SizeOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.buttonSize);
            this.Name = "SizeOption";
            this.Size = new System.Drawing.Size(77, 57);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.RadioButton buttonSize;
    }
}
