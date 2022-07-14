
namespace POS1.Refund_Forms
{
    partial class RefundForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RefundForm));
            this.panelRefundMenu = new System.Windows.Forms.Panel();
            this.buttonRefundTransaction = new System.Windows.Forms.Button();
            this.textBoxRefundSearch = new System.Windows.Forms.TextBox();
            this.RefundSearchBackground = new POS1.POS_Controls.Buttons();
            this.panelPageNavigation = new System.Windows.Forms.Panel();
            this.pageInput = new System.Windows.Forms.TextBox();
            this.pageDisplay = new POS1.POS_Controls.Buttons();
            this.nextButton = new POS1.POS_Controls.Buttons();
            this.lastButton = new POS1.POS_Controls.Buttons();
            this.previousButton = new POS1.POS_Controls.Buttons();
            this.firstButton = new POS1.POS_Controls.Buttons();
            this.panelRefundLabel = new System.Windows.Forms.Panel();
            this.flowLayoutPanelRefundContents = new System.Windows.Forms.FlowLayoutPanel();
            this.panelRefundMenu.SuspendLayout();
            this.panelPageNavigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelRefundMenu
            // 
            this.panelRefundMenu.Controls.Add(this.buttonRefundTransaction);
            this.panelRefundMenu.Controls.Add(this.textBoxRefundSearch);
            this.panelRefundMenu.Controls.Add(this.RefundSearchBackground);
            this.panelRefundMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRefundMenu.Location = new System.Drawing.Point(0, 0);
            this.panelRefundMenu.Margin = new System.Windows.Forms.Padding(2);
            this.panelRefundMenu.Name = "panelRefundMenu";
            this.panelRefundMenu.Size = new System.Drawing.Size(1604, 110);
            this.panelRefundMenu.TabIndex = 12;
            // 
            // buttonRefundTransaction
            // 
            this.buttonRefundTransaction.AutoSize = true;
            this.buttonRefundTransaction.BackColor = System.Drawing.Color.White;
            this.buttonRefundTransaction.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRefundTransaction.BackgroundImage")));
            this.buttonRefundTransaction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRefundTransaction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRefundTransaction.FlatAppearance.BorderSize = 0;
            this.buttonRefundTransaction.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonRefundTransaction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonRefundTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefundTransaction.Location = new System.Drawing.Point(432, 26);
            this.buttonRefundTransaction.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRefundTransaction.Name = "buttonRefundTransaction";
            this.buttonRefundTransaction.Size = new System.Drawing.Size(34, 30);
            this.buttonRefundTransaction.TabIndex = 6;
            this.buttonRefundTransaction.UseVisualStyleBackColor = false;
            // 
            // textBoxRefundSearch
            // 
            this.textBoxRefundSearch.BackColor = System.Drawing.Color.White;
            this.textBoxRefundSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRefundSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxRefundSearch.Location = new System.Drawing.Point(46, 30);
            this.textBoxRefundSearch.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxRefundSearch.Name = "textBoxRefundSearch";
            this.textBoxRefundSearch.PlaceholderText = "Search Transaction ID";
            this.textBoxRefundSearch.Size = new System.Drawing.Size(420, 21);
            this.textBoxRefundSearch.TabIndex = 5;
            // 
            // RefundSearchBackground
            // 
            this.RefundSearchBackground.AutoSize = true;
            this.RefundSearchBackground.BackColor = System.Drawing.Color.White;
            this.RefundSearchBackground.BackgroundColor = System.Drawing.Color.White;
            this.RefundSearchBackground.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.RefundSearchBackground.BorderRadius = 15;
            this.RefundSearchBackground.BorderSize = 0;
            this.RefundSearchBackground.FlatAppearance.BorderSize = 0;
            this.RefundSearchBackground.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.RefundSearchBackground.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.RefundSearchBackground.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefundSearchBackground.ForeColor = System.Drawing.Color.White;
            this.RefundSearchBackground.Location = new System.Drawing.Point(30, 22);
            this.RefundSearchBackground.Margin = new System.Windows.Forms.Padding(2);
            this.RefundSearchBackground.Name = "RefundSearchBackground";
            this.RefundSearchBackground.Size = new System.Drawing.Size(450, 39);
            this.RefundSearchBackground.TabIndex = 4;
            this.RefundSearchBackground.TextColor = System.Drawing.Color.White;
            this.RefundSearchBackground.UseVisualStyleBackColor = false;
            // 
            // panelPageNavigation
            // 
            this.panelPageNavigation.Controls.Add(this.pageInput);
            this.panelPageNavigation.Controls.Add(this.pageDisplay);
            this.panelPageNavigation.Controls.Add(this.nextButton);
            this.panelPageNavigation.Controls.Add(this.lastButton);
            this.panelPageNavigation.Controls.Add(this.previousButton);
            this.panelPageNavigation.Controls.Add(this.firstButton);
            this.panelPageNavigation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPageNavigation.Location = new System.Drawing.Point(0, 730);
            this.panelPageNavigation.Margin = new System.Windows.Forms.Padding(4);
            this.panelPageNavigation.Name = "panelPageNavigation";
            this.panelPageNavigation.Padding = new System.Windows.Forms.Padding(600, 38, 600, 38);
            this.panelPageNavigation.Size = new System.Drawing.Size(1604, 150);
            this.panelPageNavigation.TabIndex = 13;
            // 
            // pageInput
            // 
            this.pageInput.BackColor = System.Drawing.Color.White;
            this.pageInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pageInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pageInput.Location = new System.Drawing.Point(760, 68);
            this.pageInput.Margin = new System.Windows.Forms.Padding(4);
            this.pageInput.Name = "pageInput";
            this.pageInput.Size = new System.Drawing.Size(90, 21);
            this.pageInput.TabIndex = 5;
            this.pageInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pageDisplay
            // 
            this.pageDisplay.BackColor = System.Drawing.Color.White;
            this.pageDisplay.BackgroundColor = System.Drawing.Color.White;
            this.pageDisplay.BorderColor = System.Drawing.Color.Transparent;
            this.pageDisplay.BorderRadius = 10;
            this.pageDisplay.BorderSize = 0;
            this.pageDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pageDisplay.FlatAppearance.BorderSize = 0;
            this.pageDisplay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.pageDisplay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.pageDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pageDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pageDisplay.ForeColor = System.Drawing.Color.DimGray;
            this.pageDisplay.Location = new System.Drawing.Point(744, 38);
            this.pageDisplay.Margin = new System.Windows.Forms.Padding(12, 4, 12, 4);
            this.pageDisplay.Name = "pageDisplay";
            this.pageDisplay.Size = new System.Drawing.Size(116, 74);
            this.pageDisplay.TabIndex = 4;
            this.pageDisplay.TextColor = System.Drawing.Color.DimGray;
            this.pageDisplay.UseVisualStyleBackColor = false;
            // 
            // nextButton
            // 
            this.nextButton.BackColor = System.Drawing.Color.White;
            this.nextButton.BackgroundColor = System.Drawing.Color.White;
            this.nextButton.BorderColor = System.Drawing.Color.Transparent;
            this.nextButton.BorderRadius = 10;
            this.nextButton.BorderSize = 0;
            this.nextButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.nextButton.FlatAppearance.BorderSize = 0;
            this.nextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nextButton.ForeColor = System.Drawing.Color.DimGray;
            this.nextButton.Location = new System.Drawing.Point(860, 38);
            this.nextButton.Margin = new System.Windows.Forms.Padding(12, 4, 12, 4);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(72, 74);
            this.nextButton.TabIndex = 3;
            this.nextButton.Text = "→";
            this.nextButton.TextColor = System.Drawing.Color.DimGray;
            this.nextButton.UseVisualStyleBackColor = false;
            // 
            // lastButton
            // 
            this.lastButton.BackColor = System.Drawing.Color.White;
            this.lastButton.BackgroundColor = System.Drawing.Color.White;
            this.lastButton.BorderColor = System.Drawing.Color.Transparent;
            this.lastButton.BorderRadius = 10;
            this.lastButton.BorderSize = 0;
            this.lastButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.lastButton.FlatAppearance.BorderSize = 0;
            this.lastButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lastButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lastButton.ForeColor = System.Drawing.Color.DimGray;
            this.lastButton.Location = new System.Drawing.Point(932, 38);
            this.lastButton.Margin = new System.Windows.Forms.Padding(12, 4, 12, 4);
            this.lastButton.Name = "lastButton";
            this.lastButton.Size = new System.Drawing.Size(72, 74);
            this.lastButton.TabIndex = 2;
            this.lastButton.Text = "⇥";
            this.lastButton.TextColor = System.Drawing.Color.DimGray;
            this.lastButton.UseVisualStyleBackColor = false;
            // 
            // previousButton
            // 
            this.previousButton.BackColor = System.Drawing.Color.White;
            this.previousButton.BackgroundColor = System.Drawing.Color.White;
            this.previousButton.BorderColor = System.Drawing.Color.Transparent;
            this.previousButton.BorderRadius = 10;
            this.previousButton.BorderSize = 0;
            this.previousButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.previousButton.FlatAppearance.BorderSize = 0;
            this.previousButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.previousButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.previousButton.ForeColor = System.Drawing.Color.DimGray;
            this.previousButton.Location = new System.Drawing.Point(672, 38);
            this.previousButton.Margin = new System.Windows.Forms.Padding(12, 4, 12, 4);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(72, 74);
            this.previousButton.TabIndex = 1;
            this.previousButton.Text = "←";
            this.previousButton.TextColor = System.Drawing.Color.DimGray;
            this.previousButton.UseVisualStyleBackColor = false;
            // 
            // firstButton
            // 
            this.firstButton.BackColor = System.Drawing.Color.White;
            this.firstButton.BackgroundColor = System.Drawing.Color.White;
            this.firstButton.BorderColor = System.Drawing.Color.Transparent;
            this.firstButton.BorderRadius = 10;
            this.firstButton.BorderSize = 0;
            this.firstButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.firstButton.FlatAppearance.BorderSize = 0;
            this.firstButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.firstButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstButton.ForeColor = System.Drawing.Color.DimGray;
            this.firstButton.Location = new System.Drawing.Point(600, 38);
            this.firstButton.Margin = new System.Windows.Forms.Padding(12, 4, 12, 4);
            this.firstButton.Name = "firstButton";
            this.firstButton.Size = new System.Drawing.Size(72, 74);
            this.firstButton.TabIndex = 0;
            this.firstButton.Text = "⇤";
            this.firstButton.TextColor = System.Drawing.Color.DimGray;
            this.firstButton.UseVisualStyleBackColor = false;
            // 
            // panelRefundLabel
            // 
            this.panelRefundLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRefundLabel.Location = new System.Drawing.Point(0, 110);
            this.panelRefundLabel.Margin = new System.Windows.Forms.Padding(2);
            this.panelRefundLabel.Name = "panelRefundLabel";
            this.panelRefundLabel.Size = new System.Drawing.Size(1604, 74);
            this.panelRefundLabel.TabIndex = 14;
            // 
            // flowLayoutPanelRefundContents
            // 
            this.flowLayoutPanelRefundContents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelRefundContents.Location = new System.Drawing.Point(0, 184);
            this.flowLayoutPanelRefundContents.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanelRefundContents.Name = "flowLayoutPanelRefundContents";
            this.flowLayoutPanelRefundContents.Size = new System.Drawing.Size(1604, 546);
            this.flowLayoutPanelRefundContents.TabIndex = 15;
            // 
            // RefundForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1604, 880);
            this.Controls.Add(this.flowLayoutPanelRefundContents);
            this.Controls.Add(this.panelRefundLabel);
            this.Controls.Add(this.panelPageNavigation);
            this.Controls.Add(this.panelRefundMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "RefundForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Refund";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RefundForm_Load);
            this.panelRefundMenu.ResumeLayout(false);
            this.panelRefundMenu.PerformLayout();
            this.panelPageNavigation.ResumeLayout(false);
            this.panelPageNavigation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelRefundMenu;
        private System.Windows.Forms.Button buttonRefundTransaction;
        private System.Windows.Forms.TextBox textBoxRefundSearch;
        private POS_Controls.Buttons RefundSearchBackground;
        private System.Windows.Forms.Panel panelPageNavigation;
        private System.Windows.Forms.TextBox pageInput;
        private POS_Controls.Buttons pageDisplay;
        private POS_Controls.Buttons nextButton;
        private POS_Controls.Buttons lastButton;
        private POS_Controls.Buttons previousButton;
        private POS_Controls.Buttons firstButton;
        private System.Windows.Forms.Panel panelRefundLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelRefundContents;
    }
}