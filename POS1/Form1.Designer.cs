
namespace POS1
{
    partial class Dashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonsTransactions = new POS1.POS_Controls.Buttons();
            this.pictureBoxBenchLogo = new System.Windows.Forms.PictureBox();
            this.buttonsExchange = new POS1.POS_Controls.Buttons();
            this.buttonsRefund = new POS1.POS_Controls.Buttons();
            this.buttonsInventory = new POS1.POS_Controls.Buttons();
            this.buttonsSales = new POS1.POS_Controls.Buttons();
            this.labelTimeDate = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelRightSide = new System.Windows.Forms.Panel();
            this.panelDashboardRight = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBenchLogo)).BeginInit();
            this.panelRightSide.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.AutoSize = true;
            this.panelMenu.BackColor = System.Drawing.Color.White;
            this.panelMenu.Controls.Add(this.buttonsTransactions);
            this.panelMenu.Controls.Add(this.pictureBoxBenchLogo);
            this.panelMenu.Controls.Add(this.buttonsExchange);
            this.panelMenu.Controls.Add(this.buttonsRefund);
            this.panelMenu.Controls.Add(this.buttonsInventory);
            this.panelMenu.Controls.Add(this.buttonsSales);
            this.panelMenu.Controls.Add(this.labelTimeDate);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.panelMenu.Size = new System.Drawing.Size(98, 587);
            this.panelMenu.TabIndex = 0;
            // 
            // buttonsTransactions
            // 
            this.buttonsTransactions.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonsTransactions.AutoSize = true;
            this.buttonsTransactions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.buttonsTransactions.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.buttonsTransactions.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonsTransactions.BackgroundImage")));
            this.buttonsTransactions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonsTransactions.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonsTransactions.BorderRadius = 30;
            this.buttonsTransactions.BorderSize = 0;
            this.buttonsTransactions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonsTransactions.FlatAppearance.BorderSize = 0;
            this.buttonsTransactions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonsTransactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonsTransactions.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonsTransactions.ForeColor = System.Drawing.Color.Black;
            this.buttonsTransactions.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonsTransactions.Location = new System.Drawing.Point(12, 189);
            this.buttonsTransactions.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.buttonsTransactions.Name = "buttonsTransactions";
            this.buttonsTransactions.Size = new System.Drawing.Size(73, 67);
            this.buttonsTransactions.TabIndex = 2;
            this.buttonsTransactions.Text = "Transaction";
            this.buttonsTransactions.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonsTransactions.TextColor = System.Drawing.Color.Black;
            this.buttonsTransactions.UseVisualStyleBackColor = false;
            this.buttonsTransactions.Click += new System.EventHandler(this.buttonsTransactions_Click);
            // 
            // pictureBoxBenchLogo
            // 
            this.pictureBoxBenchLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxBenchLogo.Image = global::POS1.Properties.Resources.BENCH_logo;
            this.pictureBoxBenchLogo.Location = new System.Drawing.Point(12, 0);
            this.pictureBoxBenchLogo.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.pictureBoxBenchLogo.Name = "pictureBoxBenchLogo";
            this.pictureBoxBenchLogo.Size = new System.Drawing.Size(74, 59);
            this.pictureBoxBenchLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBenchLogo.TabIndex = 6;
            this.pictureBoxBenchLogo.TabStop = false;
            // 
            // buttonsExchange
            // 
            this.buttonsExchange.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonsExchange.AutoSize = true;
            this.buttonsExchange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.buttonsExchange.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.buttonsExchange.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonsExchange.BackgroundImage")));
            this.buttonsExchange.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonsExchange.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonsExchange.BorderRadius = 30;
            this.buttonsExchange.BorderSize = 0;
            this.buttonsExchange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonsExchange.FlatAppearance.BorderSize = 0;
            this.buttonsExchange.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonsExchange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonsExchange.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonsExchange.ForeColor = System.Drawing.Color.Black;
            this.buttonsExchange.Location = new System.Drawing.Point(12, 414);
            this.buttonsExchange.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.buttonsExchange.Name = "buttonsExchange";
            this.buttonsExchange.Size = new System.Drawing.Size(73, 67);
            this.buttonsExchange.TabIndex = 5;
            this.buttonsExchange.Text = "Exchange";
            this.buttonsExchange.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonsExchange.TextColor = System.Drawing.Color.Black;
            this.buttonsExchange.UseVisualStyleBackColor = false;
            this.buttonsExchange.Click += new System.EventHandler(this.buttonsExchange_Click);
            // 
            // buttonsRefund
            // 
            this.buttonsRefund.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonsRefund.AutoSize = true;
            this.buttonsRefund.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.buttonsRefund.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.buttonsRefund.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonsRefund.BackgroundImage")));
            this.buttonsRefund.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonsRefund.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonsRefund.BorderRadius = 30;
            this.buttonsRefund.BorderSize = 0;
            this.buttonsRefund.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonsRefund.FlatAppearance.BorderSize = 0;
            this.buttonsRefund.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonsRefund.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonsRefund.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonsRefund.ForeColor = System.Drawing.Color.Black;
            this.buttonsRefund.Location = new System.Drawing.Point(12, 339);
            this.buttonsRefund.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.buttonsRefund.Name = "buttonsRefund";
            this.buttonsRefund.Size = new System.Drawing.Size(73, 67);
            this.buttonsRefund.TabIndex = 4;
            this.buttonsRefund.Text = "Refund";
            this.buttonsRefund.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonsRefund.TextColor = System.Drawing.Color.Black;
            this.buttonsRefund.UseVisualStyleBackColor = false;
            this.buttonsRefund.Click += new System.EventHandler(this.buttonsRefund_Click);
            // 
            // buttonsInventory
            // 
            this.buttonsInventory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonsInventory.AutoSize = true;
            this.buttonsInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.buttonsInventory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.buttonsInventory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonsInventory.BackgroundImage")));
            this.buttonsInventory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonsInventory.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonsInventory.BorderRadius = 30;
            this.buttonsInventory.BorderSize = 0;
            this.buttonsInventory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonsInventory.FlatAppearance.BorderSize = 0;
            this.buttonsInventory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonsInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonsInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonsInventory.ForeColor = System.Drawing.Color.Black;
            this.buttonsInventory.Location = new System.Drawing.Point(12, 264);
            this.buttonsInventory.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.buttonsInventory.Name = "buttonsInventory";
            this.buttonsInventory.Size = new System.Drawing.Size(73, 67);
            this.buttonsInventory.TabIndex = 3;
            this.buttonsInventory.Text = "Inventory";
            this.buttonsInventory.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonsInventory.TextColor = System.Drawing.Color.Black;
            this.buttonsInventory.UseVisualStyleBackColor = false;
            this.buttonsInventory.Click += new System.EventHandler(this.buttonsInventory_Click);
            // 
            // buttonsSales
            // 
            this.buttonsSales.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonsSales.AutoSize = true;
            this.buttonsSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.buttonsSales.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.buttonsSales.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonsSales.BackgroundImage")));
            this.buttonsSales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonsSales.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonsSales.BorderRadius = 30;
            this.buttonsSales.BorderSize = 0;
            this.buttonsSales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonsSales.FlatAppearance.BorderSize = 0;
            this.buttonsSales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonsSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonsSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonsSales.ForeColor = System.Drawing.Color.Black;
            this.buttonsSales.Location = new System.Drawing.Point(12, 114);
            this.buttonsSales.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.buttonsSales.Name = "buttonsSales";
            this.buttonsSales.Size = new System.Drawing.Size(73, 67);
            this.buttonsSales.TabIndex = 1;
            this.buttonsSales.Text = "Sales";
            this.buttonsSales.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonsSales.TextColor = System.Drawing.Color.Black;
            this.buttonsSales.UseVisualStyleBackColor = false;
            this.buttonsSales.Click += new System.EventHandler(this.buttonsSales_Click);
            // 
            // labelTimeDate
            // 
            this.labelTimeDate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelTimeDate.Location = new System.Drawing.Point(12, 530);
            this.labelTimeDate.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelTimeDate.Name = "labelTimeDate";
            this.labelTimeDate.Size = new System.Drawing.Size(74, 57);
            this.labelTimeDate.TabIndex = 0;
            this.labelTimeDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelRightSide
            // 
            this.panelRightSide.Controls.Add(this.panelDashboardRight);
            this.panelRightSide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRightSide.Location = new System.Drawing.Point(98, 0);
            this.panelRightSide.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.panelRightSide.Name = "panelRightSide";
            this.panelRightSide.Size = new System.Drawing.Size(954, 587);
            this.panelRightSide.TabIndex = 1;
            // 
            // panelDashboardRight
            // 
            this.panelDashboardRight.AutoSize = true;
            this.panelDashboardRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelDashboardRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDashboardRight.Location = new System.Drawing.Point(0, 0);
            this.panelDashboardRight.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.panelDashboardRight.Name = "panelDashboardRight";
            this.panelDashboardRight.Size = new System.Drawing.Size(954, 587);
            this.panelDashboardRight.TabIndex = 0;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1052, 587);
            this.Controls.Add(this.panelRightSide);
            this.Controls.Add(this.panelMenu);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BENCH/";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBenchLogo)).EndInit();
            this.panelRightSide.ResumeLayout(false);
            this.panelRightSide.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label labelTimeDate;
        private System.Windows.Forms.Timer timer1;
        private POS_Controls.Buttons buttonsSales;
        private POS_Controls.Buttons buttonsExchange;
        private POS_Controls.Buttons buttonsRefund;
        private POS_Controls.Buttons buttonsInventory;
        private POS_Controls.Buttons buttonsTransactions;
        private System.Windows.Forms.PictureBox pictureBoxBenchLogo;
        private System.Windows.Forms.Panel panelRightSide;
        private System.Windows.Forms.Panel panelDashboardRight;
    }
}

