
namespace POS1.Sales_Forms
{
    partial class SalesBills
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesBills));
            this.panelSalesBillsDetails = new System.Windows.Forms.Panel();
            this.textBoxBillsQuantity = new System.Windows.Forms.TextBox();
            this.labelBillsPrice = new System.Windows.Forms.Label();
            this.buttonsBillsPlus = new POS1.POS_Controls.Buttons();
            this.buttonsBillsMinus = new POS1.POS_Controls.Buttons();
            this.labelBillsClothesColor = new System.Windows.Forms.Label();
            this.labelBillsClothesSize = new System.Windows.Forms.Label();
            this.labelBillsClothesCode = new System.Windows.Forms.Label();
            this.labelBillsClothesTitle = new System.Windows.Forms.Label();
            this.panelSalesBillsClothesIcon = new System.Windows.Forms.Panel();
            this.pictureBoxBillsIcon = new System.Windows.Forms.PictureBox();
            this.panelSalesBillsDetails.SuspendLayout();
            this.panelSalesBillsClothesIcon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBillsIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSalesBillsDetails
            // 
            this.panelSalesBillsDetails.AutoSize = true;
            this.panelSalesBillsDetails.Controls.Add(this.textBoxBillsQuantity);
            this.panelSalesBillsDetails.Controls.Add(this.labelBillsPrice);
            this.panelSalesBillsDetails.Controls.Add(this.buttonsBillsPlus);
            this.panelSalesBillsDetails.Controls.Add(this.buttonsBillsMinus);
            this.panelSalesBillsDetails.Controls.Add(this.labelBillsClothesColor);
            this.panelSalesBillsDetails.Controls.Add(this.labelBillsClothesSize);
            this.panelSalesBillsDetails.Controls.Add(this.labelBillsClothesCode);
            this.panelSalesBillsDetails.Controls.Add(this.labelBillsClothesTitle);
            this.panelSalesBillsDetails.Location = new System.Drawing.Point(127, 11);
            this.panelSalesBillsDetails.Margin = new System.Windows.Forms.Padding(2);
            this.panelSalesBillsDetails.Name = "panelSalesBillsDetails";
            this.panelSalesBillsDetails.Size = new System.Drawing.Size(250, 85);
            this.panelSalesBillsDetails.TabIndex = 1;
            // 
            // textBoxBillsQuantity
            // 
            this.textBoxBillsQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxBillsQuantity.BackColor = System.Drawing.Color.White;
            this.textBoxBillsQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBillsQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxBillsQuantity.Location = new System.Drawing.Point(160, 45);
            this.textBoxBillsQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxBillsQuantity.Multiline = true;
            this.textBoxBillsQuantity.Name = "textBoxBillsQuantity";
            this.textBoxBillsQuantity.Size = new System.Drawing.Size(55, 26);
            this.textBoxBillsQuantity.TabIndex = 17;
            this.textBoxBillsQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxBillsQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBillsQuantity_KeyPress);
            this.textBoxBillsQuantity.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxBillsQuantity_KeyUp);
            // 
            // labelBillsPrice
            // 
            this.labelBillsPrice.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelBillsPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelBillsPrice.ForeColor = System.Drawing.Color.Tomato;
            this.labelBillsPrice.Location = new System.Drawing.Point(128, 2);
            this.labelBillsPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBillsPrice.MaximumSize = new System.Drawing.Size(116, 0);
            this.labelBillsPrice.MinimumSize = new System.Drawing.Size(0, 30);
            this.labelBillsPrice.Name = "labelBillsPrice";
            this.labelBillsPrice.Size = new System.Drawing.Size(116, 30);
            this.labelBillsPrice.TabIndex = 7;
            this.labelBillsPrice.Text = "0";
            this.labelBillsPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonsBillsPlus
            // 
            this.buttonsBillsPlus.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonsBillsPlus.AutoSize = true;
            this.buttonsBillsPlus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.buttonsBillsPlus.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.buttonsBillsPlus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonsBillsPlus.BackgroundImage")));
            this.buttonsBillsPlus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonsBillsPlus.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonsBillsPlus.BorderRadius = 10;
            this.buttonsBillsPlus.BorderSize = 0;
            this.buttonsBillsPlus.FlatAppearance.BorderSize = 0;
            this.buttonsBillsPlus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonsBillsPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonsBillsPlus.ForeColor = System.Drawing.Color.Black;
            this.buttonsBillsPlus.Location = new System.Drawing.Point(219, 47);
            this.buttonsBillsPlus.Margin = new System.Windows.Forms.Padding(2);
            this.buttonsBillsPlus.Name = "buttonsBillsPlus";
            this.buttonsBillsPlus.Size = new System.Drawing.Size(28, 24);
            this.buttonsBillsPlus.TabIndex = 5;
            this.buttonsBillsPlus.TextColor = System.Drawing.Color.Black;
            this.buttonsBillsPlus.UseVisualStyleBackColor = false;
            this.buttonsBillsPlus.Click += new System.EventHandler(this.buttonsBillsPlus_Click);
            // 
            // buttonsBillsMinus
            // 
            this.buttonsBillsMinus.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonsBillsMinus.AutoSize = true;
            this.buttonsBillsMinus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.buttonsBillsMinus.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.buttonsBillsMinus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonsBillsMinus.BackgroundImage")));
            this.buttonsBillsMinus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonsBillsMinus.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonsBillsMinus.BorderRadius = 10;
            this.buttonsBillsMinus.BorderSize = 0;
            this.buttonsBillsMinus.FlatAppearance.BorderSize = 0;
            this.buttonsBillsMinus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonsBillsMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonsBillsMinus.ForeColor = System.Drawing.Color.Black;
            this.buttonsBillsMinus.Location = new System.Drawing.Point(128, 47);
            this.buttonsBillsMinus.Margin = new System.Windows.Forms.Padding(2);
            this.buttonsBillsMinus.Name = "buttonsBillsMinus";
            this.buttonsBillsMinus.Size = new System.Drawing.Size(28, 24);
            this.buttonsBillsMinus.TabIndex = 4;
            this.buttonsBillsMinus.TextColor = System.Drawing.Color.Black;
            this.buttonsBillsMinus.UseVisualStyleBackColor = false;
            this.buttonsBillsMinus.Click += new System.EventHandler(this.buttonsBillsMinus_Click);
            // 
            // labelBillsClothesColor
            // 
            this.labelBillsClothesColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelBillsClothesColor.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelBillsClothesColor.Location = new System.Drawing.Point(4, 65);
            this.labelBillsClothesColor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBillsClothesColor.Name = "labelBillsClothesColor";
            this.labelBillsClothesColor.Size = new System.Drawing.Size(128, 12);
            this.labelBillsClothesColor.TabIndex = 3;
            this.labelBillsClothesColor.Text = "Insert Text";
            // 
            // labelBillsClothesSize
            // 
            this.labelBillsClothesSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelBillsClothesSize.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelBillsClothesSize.Location = new System.Drawing.Point(4, 51);
            this.labelBillsClothesSize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBillsClothesSize.Name = "labelBillsClothesSize";
            this.labelBillsClothesSize.Size = new System.Drawing.Size(128, 12);
            this.labelBillsClothesSize.TabIndex = 2;
            this.labelBillsClothesSize.Text = "Insert Text";
            // 
            // labelBillsClothesCode
            // 
            this.labelBillsClothesCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelBillsClothesCode.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelBillsClothesCode.Location = new System.Drawing.Point(4, 37);
            this.labelBillsClothesCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBillsClothesCode.Name = "labelBillsClothesCode";
            this.labelBillsClothesCode.Size = new System.Drawing.Size(128, 12);
            this.labelBillsClothesCode.TabIndex = 1;
            this.labelBillsClothesCode.Text = "Insert Text";
            // 
            // labelBillsClothesTitle
            // 
            this.labelBillsClothesTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelBillsClothesTitle.Location = new System.Drawing.Point(4, 2);
            this.labelBillsClothesTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBillsClothesTitle.Name = "labelBillsClothesTitle";
            this.labelBillsClothesTitle.Size = new System.Drawing.Size(128, 17);
            this.labelBillsClothesTitle.TabIndex = 0;
            this.labelBillsClothesTitle.Text = "Insert Text";
            // 
            // panelSalesBillsClothesIcon
            // 
            this.panelSalesBillsClothesIcon.AutoSize = true;
            this.panelSalesBillsClothesIcon.Controls.Add(this.pictureBoxBillsIcon);
            this.panelSalesBillsClothesIcon.Location = new System.Drawing.Point(15, 14);
            this.panelSalesBillsClothesIcon.Margin = new System.Windows.Forms.Padding(2);
            this.panelSalesBillsClothesIcon.Name = "panelSalesBillsClothesIcon";
            this.panelSalesBillsClothesIcon.Size = new System.Drawing.Size(112, 83);
            this.panelSalesBillsClothesIcon.TabIndex = 2;
            // 
            // pictureBoxBillsIcon
            // 
            this.pictureBoxBillsIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxBillsIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxBillsIcon.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxBillsIcon.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxBillsIcon.Name = "pictureBoxBillsIcon";
            this.pictureBoxBillsIcon.Size = new System.Drawing.Size(112, 83);
            this.pictureBoxBillsIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBillsIcon.TabIndex = 0;
            this.pictureBoxBillsIcon.TabStop = false;
            // 
            // SalesBills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelSalesBillsClothesIcon);
            this.Controls.Add(this.panelSalesBillsDetails);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SalesBills";
            this.Padding = new System.Windows.Forms.Padding(13, 11, 13, 11);
            this.Size = new System.Drawing.Size(400, 112);
            this.panelSalesBillsDetails.ResumeLayout(false);
            this.panelSalesBillsDetails.PerformLayout();
            this.panelSalesBillsClothesIcon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBillsIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelBillsClothesTitle;
        private System.Windows.Forms.Label labelBillsClothesCode;
        private System.Windows.Forms.Label labelBillsClothesColor;
        private System.Windows.Forms.Label labelBillsClothesSize;
        private System.Windows.Forms.Panel panelSalesBillsClothesIcon;
        public System.Windows.Forms.PictureBox pictureBoxBillsIcon;
        public System.Windows.Forms.Label labelBillsPrice;
        public POS_Controls.Buttons buttonsBillsMinus;
        public POS_Controls.Buttons buttonsBillsPlus;
        public System.Windows.Forms.Panel panelSalesBillsDetails;
        public System.Windows.Forms.TextBox textBoxBillsQuantity;
    }
}
