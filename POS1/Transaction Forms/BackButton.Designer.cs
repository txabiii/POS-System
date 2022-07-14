
namespace POS1.Transaction_Forms
{
    partial class BackButton
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


        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackButton));
            this.buttonsBack = new POS1.POS_Controls.Buttons();
            this.panelBackButtonIcon = new System.Windows.Forms.Panel();
            this.pictureBoxBackButtonIcon = new System.Windows.Forms.PictureBox();
            this.panelBackButtonIcon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackButtonIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonsBack
            // 
            this.buttonsBack.BackColor = System.Drawing.Color.White;
            this.buttonsBack.BackgroundColor = System.Drawing.Color.White;
            this.buttonsBack.BorderColor = System.Drawing.Color.Black;
            this.buttonsBack.BorderRadius = 10;
            this.buttonsBack.BorderSize = 3;
            this.buttonsBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonsBack.FlatAppearance.BorderSize = 0;
            this.buttonsBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonsBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonsBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonsBack.Font = new System.Drawing.Font("Roboto Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonsBack.ForeColor = System.Drawing.Color.Black;
            this.buttonsBack.Location = new System.Drawing.Point(0, 0);
            this.buttonsBack.Margin = new System.Windows.Forms.Padding(2);
            this.buttonsBack.Name = "buttonsBack";
            this.buttonsBack.Size = new System.Drawing.Size(117, 43);
            this.buttonsBack.TabIndex = 0;
            this.buttonsBack.Text = "Back";
            this.buttonsBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonsBack.TextColor = System.Drawing.Color.Black;
            this.buttonsBack.UseVisualStyleBackColor = false;
            this.buttonsBack.Click += new System.EventHandler(this.buttonsBack_Click);
            // 
            // panelBackButtonIcon
            // 
            this.panelBackButtonIcon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelBackButtonIcon.BackColor = System.Drawing.Color.White;
            this.panelBackButtonIcon.Controls.Add(this.pictureBoxBackButtonIcon);
            this.panelBackButtonIcon.Location = new System.Drawing.Point(23, 8);
            this.panelBackButtonIcon.Margin = new System.Windows.Forms.Padding(2);
            this.panelBackButtonIcon.Name = "panelBackButtonIcon";
            this.panelBackButtonIcon.Size = new System.Drawing.Size(32, 27);
            this.panelBackButtonIcon.TabIndex = 1;
            // 
            // pictureBoxBackButtonIcon
            // 
            this.pictureBoxBackButtonIcon.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBackButtonIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxBackButtonIcon.BackgroundImage")));
            this.pictureBoxBackButtonIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxBackButtonIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxBackButtonIcon.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxBackButtonIcon.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxBackButtonIcon.Name = "pictureBoxBackButtonIcon";
            this.pictureBoxBackButtonIcon.Size = new System.Drawing.Size(32, 27);
            this.pictureBoxBackButtonIcon.TabIndex = 0;
            this.pictureBoxBackButtonIcon.TabStop = false;
            this.pictureBoxBackButtonIcon.Click += new System.EventHandler(this.pictureBoxBackButtonIcon_Click);
            // 
            // BackButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.panelBackButtonIcon);
            this.Controls.Add(this.buttonsBack);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BackButton";
            this.Size = new System.Drawing.Size(117, 43);
            this.panelBackButtonIcon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackButtonIcon)).EndInit();
            this.ResumeLayout(false);

        }

        private POS_Controls.Buttons buttonsBack;
        public System.Windows.Forms.Panel panelBackButtonIcon;
        public System.Windows.Forms.PictureBox pictureBoxBackButtonIcon;
    }
}
