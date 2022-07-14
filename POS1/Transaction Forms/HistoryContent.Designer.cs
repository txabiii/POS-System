
namespace POS1.Transaction_Forms
{
    partial class HistoryContent
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

        public string getHistoryContentTransactionID()
        {
            return labelHistoryContentTransactionID.Text;
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonsHistoryContentBackground = new POS1.POS_Controls.Buttons();
            this.pictureBoxHistoryContentImage = new System.Windows.Forms.PictureBox();
            this.labelHistoryContentTime = new System.Windows.Forms.Label();
            this.labelHistoryContentDate = new System.Windows.Forms.Label();
            this.labelHistoryContentTotal = new System.Windows.Forms.Label();
            this.labelHistoryContentType = new System.Windows.Forms.Label();
            this.labelHistoryContentTransactionID = new System.Windows.Forms.Label();
            this.historyContentTable = new System.Windows.Forms.TableLayoutPanel();
            this.viewTransactionDetails = new POS1.POS_Controls.Buttons();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHistoryContentImage)).BeginInit();
            this.historyContentTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonsHistoryContentBackground
            // 
            this.buttonsHistoryContentBackground.BackColor = System.Drawing.Color.White;
            this.buttonsHistoryContentBackground.BackgroundColor = System.Drawing.Color.White;
            this.buttonsHistoryContentBackground.BorderColor = System.Drawing.Color.White;
            this.buttonsHistoryContentBackground.BorderRadius = 30;
            this.buttonsHistoryContentBackground.BorderSize = 0;
            this.buttonsHistoryContentBackground.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonsHistoryContentBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonsHistoryContentBackground.FlatAppearance.BorderSize = 0;
            this.buttonsHistoryContentBackground.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonsHistoryContentBackground.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonsHistoryContentBackground.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonsHistoryContentBackground.ForeColor = System.Drawing.Color.White;
            this.buttonsHistoryContentBackground.Location = new System.Drawing.Point(20, 0);
            this.buttonsHistoryContentBackground.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.buttonsHistoryContentBackground.Name = "buttonsHistoryContentBackground";
            this.buttonsHistoryContentBackground.Size = new System.Drawing.Size(1160, 79);
            this.buttonsHistoryContentBackground.TabIndex = 0;
            this.buttonsHistoryContentBackground.Text = "`";
            this.buttonsHistoryContentBackground.TextColor = System.Drawing.Color.White;
            this.buttonsHistoryContentBackground.UseVisualStyleBackColor = false;
            // 
            // pictureBoxHistoryContentImage
            // 
            this.pictureBoxHistoryContentImage.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBoxHistoryContentImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxHistoryContentImage.Location = new System.Drawing.Point(1, 1);
            this.pictureBoxHistoryContentImage.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.pictureBoxHistoryContentImage.Name = "pictureBoxHistoryContentImage";
            this.pictureBoxHistoryContentImage.Size = new System.Drawing.Size(108, 77);
            this.pictureBoxHistoryContentImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHistoryContentImage.TabIndex = 0;
            this.pictureBoxHistoryContentImage.TabStop = false;
            // 
            // labelHistoryContentTime
            // 
            this.labelHistoryContentTime.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelHistoryContentTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelHistoryContentTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelHistoryContentTime.Location = new System.Drawing.Point(859, 0);
            this.labelHistoryContentTime.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelHistoryContentTime.Name = "labelHistoryContentTime";
            this.labelHistoryContentTime.Size = new System.Drawing.Size(189, 79);
            this.labelHistoryContentTime.TabIndex = 4;
            this.labelHistoryContentTime.Text = "11:11 AM";
            this.labelHistoryContentTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelHistoryContentDate
            // 
            this.labelHistoryContentDate.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelHistoryContentDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelHistoryContentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelHistoryContentDate.Location = new System.Drawing.Point(672, 0);
            this.labelHistoryContentDate.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelHistoryContentDate.Name = "labelHistoryContentDate";
            this.labelHistoryContentDate.Size = new System.Drawing.Size(185, 79);
            this.labelHistoryContentDate.TabIndex = 3;
            this.labelHistoryContentDate.Text = "Nov 06, 2021";
            this.labelHistoryContentDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelHistoryContentTotal
            // 
            this.labelHistoryContentTotal.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelHistoryContentTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelHistoryContentTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelHistoryContentTotal.Location = new System.Drawing.Point(485, 0);
            this.labelHistoryContentTotal.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelHistoryContentTotal.Name = "labelHistoryContentTotal";
            this.labelHistoryContentTotal.Size = new System.Drawing.Size(185, 79);
            this.labelHistoryContentTotal.TabIndex = 2;
            this.labelHistoryContentTotal.Text = "1,999.75";
            this.labelHistoryContentTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelHistoryContentType
            // 
            this.labelHistoryContentType.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelHistoryContentType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelHistoryContentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelHistoryContentType.Location = new System.Drawing.Point(298, 0);
            this.labelHistoryContentType.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelHistoryContentType.Name = "labelHistoryContentType";
            this.labelHistoryContentType.Size = new System.Drawing.Size(185, 79);
            this.labelHistoryContentType.TabIndex = 1;
            this.labelHistoryContentType.Text = "Sale";
            this.labelHistoryContentType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelHistoryContentTransactionID
            // 
            this.labelHistoryContentTransactionID.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelHistoryContentTransactionID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelHistoryContentTransactionID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelHistoryContentTransactionID.Location = new System.Drawing.Point(111, 0);
            this.labelHistoryContentTransactionID.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelHistoryContentTransactionID.Name = "labelHistoryContentTransactionID";
            this.labelHistoryContentTransactionID.Size = new System.Drawing.Size(185, 79);
            this.labelHistoryContentTransactionID.TabIndex = 0;
            this.labelHistoryContentTransactionID.Text = "BNCH12345";
            this.labelHistoryContentTransactionID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // historyContentTable
            // 
            this.historyContentTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.historyContentTable.BackColor = System.Drawing.Color.White;
            this.historyContentTable.ColumnCount = 6;
            this.historyContentTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.52632F));
            this.historyContentTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.89474F));
            this.historyContentTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.89474F));
            this.historyContentTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.89474F));
            this.historyContentTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.89474F));
            this.historyContentTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.89474F));
            this.historyContentTable.Controls.Add(this.labelHistoryContentTime, 5, 0);
            this.historyContentTable.Controls.Add(this.pictureBoxHistoryContentImage, 0, 0);
            this.historyContentTable.Controls.Add(this.labelHistoryContentDate, 4, 0);
            this.historyContentTable.Controls.Add(this.labelHistoryContentTransactionID, 1, 0);
            this.historyContentTable.Controls.Add(this.labelHistoryContentTotal, 3, 0);
            this.historyContentTable.Controls.Add(this.labelHistoryContentType, 2, 0);
            this.historyContentTable.Cursor = System.Windows.Forms.Cursors.Default;
            this.historyContentTable.Location = new System.Drawing.Point(103, 0);
            this.historyContentTable.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.historyContentTable.Name = "historyContentTable";
            this.historyContentTable.RowCount = 1;
            this.historyContentTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.historyContentTable.Size = new System.Drawing.Size(1049, 79);
            this.historyContentTable.TabIndex = 5;
            // 
            // viewTransactionDetails
            // 
            this.viewTransactionDetails.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.viewTransactionDetails.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.viewTransactionDetails.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.viewTransactionDetails.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.viewTransactionDetails.BorderRadius = 9;
            this.viewTransactionDetails.BorderSize = 0;
            this.viewTransactionDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewTransactionDetails.FlatAppearance.BorderSize = 0;
            this.viewTransactionDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewTransactionDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.viewTransactionDetails.ForeColor = System.Drawing.Color.DimGray;
            this.viewTransactionDetails.Location = new System.Drawing.Point(41, 17);
            this.viewTransactionDetails.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.viewTransactionDetails.Name = "viewTransactionDetails";
            this.viewTransactionDetails.Size = new System.Drawing.Size(47, 40);
            this.viewTransactionDetails.TabIndex = 7;
            this.viewTransactionDetails.Text = "View";
            this.viewTransactionDetails.TextColor = System.Drawing.Color.DimGray;
            this.viewTransactionDetails.UseVisualStyleBackColor = false;
            this.viewTransactionDetails.Click += new System.EventHandler(this.viewTransactionDetails_Click);
            // 
            // HistoryContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.viewTransactionDetails);
            this.Controls.Add(this.historyContentTable);
            this.Controls.Add(this.buttonsHistoryContentBackground);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "HistoryContent";
            this.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.Size = new System.Drawing.Size(1180, 79);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHistoryContentImage)).EndInit();
            this.historyContentTable.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private POS_Controls.Buttons buttonsHistoryContentBackground;
        private System.Windows.Forms.PictureBox pictureBoxHistoryContentImage;
        private System.Windows.Forms.Label labelHistoryContentTransactionID;
        private System.Windows.Forms.Label labelHistoryContentTime;
        private System.Windows.Forms.Label labelHistoryContentDate;
        private System.Windows.Forms.Label labelHistoryContentTotal;
        private System.Windows.Forms.Label labelHistoryContentType;
        public System.Windows.Forms.TableLayoutPanel historyContentTable;
        public POS_Controls.Buttons viewTransactionDetails;
    }
}
