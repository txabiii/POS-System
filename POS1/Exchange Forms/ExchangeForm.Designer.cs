
namespace POS1.Exchange
{
    partial class ExchangeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExchangeForm));
            this.panelExchangeMenu = new System.Windows.Forms.Panel();
            this.buttonExchangeTransaction = new System.Windows.Forms.Button();
            this.textBoxExchangeSearch = new System.Windows.Forms.TextBox();
            this.ExchangeSearchBackground = new POS1.POS_Controls.Buttons();
            this.panelExchangeLabel = new System.Windows.Forms.Panel();
            this.panelPageNavigation = new System.Windows.Forms.Panel();
            this.pageInput = new System.Windows.Forms.TextBox();
            this.pageDisplay = new POS1.POS_Controls.Buttons();
            this.nextButton = new POS1.POS_Controls.Buttons();
            this.lastButton = new POS1.POS_Controls.Buttons();
            this.previousButton = new POS1.POS_Controls.Buttons();
            this.firstButton = new POS1.POS_Controls.Buttons();
            this.flowLayoutPanelExchangeContents = new System.Windows.Forms.FlowLayoutPanel();
            this.panelExchangeMenu.SuspendLayout();
            this.panelPageNavigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelExchangeMenu
            // 
            this.panelExchangeMenu.Controls.Add(this.buttonExchangeTransaction);
            this.panelExchangeMenu.Controls.Add(this.textBoxExchangeSearch);
            this.panelExchangeMenu.Controls.Add(this.ExchangeSearchBackground);
            this.panelExchangeMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelExchangeMenu.Location = new System.Drawing.Point(0, 0);
            this.panelExchangeMenu.Margin = new System.Windows.Forms.Padding(2);
            this.panelExchangeMenu.Name = "panelExchangeMenu";
            this.panelExchangeMenu.Size = new System.Drawing.Size(1604, 110);
            this.panelExchangeMenu.TabIndex = 13;
            // 
            // buttonExchangeTransaction
            // 
            this.buttonExchangeTransaction.AutoSize = true;
            this.buttonExchangeTransaction.BackColor = System.Drawing.Color.White;
            this.buttonExchangeTransaction.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonExchangeTransaction.BackgroundImage")));
            this.buttonExchangeTransaction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonExchangeTransaction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExchangeTransaction.FlatAppearance.BorderSize = 0;
            this.buttonExchangeTransaction.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonExchangeTransaction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonExchangeTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExchangeTransaction.Location = new System.Drawing.Point(432, 26);
            this.buttonExchangeTransaction.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExchangeTransaction.Name = "buttonExchangeTransaction";
            this.buttonExchangeTransaction.Size = new System.Drawing.Size(34, 30);
            this.buttonExchangeTransaction.TabIndex = 6;
            this.buttonExchangeTransaction.UseVisualStyleBackColor = false;
            // 
            // textBoxExchangeSearch
            // 
            this.textBoxExchangeSearch.BackColor = System.Drawing.Color.White;
            this.textBoxExchangeSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxExchangeSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxExchangeSearch.Location = new System.Drawing.Point(46, 30);
            this.textBoxExchangeSearch.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxExchangeSearch.Name = "textBoxExchangeSearch";
            this.textBoxExchangeSearch.PlaceholderText = "Search Transaction ID";
            this.textBoxExchangeSearch.Size = new System.Drawing.Size(420, 21);
            this.textBoxExchangeSearch.TabIndex = 5;
            // 
            // ExchangeSearchBackground
            // 
            this.ExchangeSearchBackground.AutoSize = true;
            this.ExchangeSearchBackground.BackColor = System.Drawing.Color.White;
            this.ExchangeSearchBackground.BackgroundColor = System.Drawing.Color.White;
            this.ExchangeSearchBackground.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ExchangeSearchBackground.BorderRadius = 15;
            this.ExchangeSearchBackground.BorderSize = 0;
            this.ExchangeSearchBackground.FlatAppearance.BorderSize = 0;
            this.ExchangeSearchBackground.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.ExchangeSearchBackground.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.ExchangeSearchBackground.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExchangeSearchBackground.ForeColor = System.Drawing.Color.White;
            this.ExchangeSearchBackground.Location = new System.Drawing.Point(30, 22);
            this.ExchangeSearchBackground.Margin = new System.Windows.Forms.Padding(2);
            this.ExchangeSearchBackground.Name = "ExchangeSearchBackground";
            this.ExchangeSearchBackground.Size = new System.Drawing.Size(450, 39);
            this.ExchangeSearchBackground.TabIndex = 4;
            this.ExchangeSearchBackground.TextColor = System.Drawing.Color.White;
            this.ExchangeSearchBackground.UseVisualStyleBackColor = false;
            // 
            // panelExchangeLabel
            // 
            this.panelExchangeLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelExchangeLabel.Location = new System.Drawing.Point(0, 110);
            this.panelExchangeLabel.Margin = new System.Windows.Forms.Padding(2);
            this.panelExchangeLabel.Name = "panelExchangeLabel";
            this.panelExchangeLabel.Size = new System.Drawing.Size(1604, 74);
            this.panelExchangeLabel.TabIndex = 15;
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
            this.panelPageNavigation.TabIndex = 16;
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
            // flowLayoutPanelExchangeContents
            // 
            this.flowLayoutPanelExchangeContents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelExchangeContents.Location = new System.Drawing.Point(0, 184);
            this.flowLayoutPanelExchangeContents.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanelExchangeContents.Name = "flowLayoutPanelExchangeContents";
            this.flowLayoutPanelExchangeContents.Size = new System.Drawing.Size(1604, 546);
            this.flowLayoutPanelExchangeContents.TabIndex = 17;
            // 
            // ExchangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1604, 880);
            this.Controls.Add(this.flowLayoutPanelExchangeContents);
            this.Controls.Add(this.panelPageNavigation);
            this.Controls.Add(this.panelExchangeLabel);
            this.Controls.Add(this.panelExchangeMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "ExchangeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exchange";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ExchangeForm_Load);
            this.panelExchangeMenu.ResumeLayout(false);
            this.panelExchangeMenu.PerformLayout();
            this.panelPageNavigation.ResumeLayout(false);
            this.panelPageNavigation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelExchangeMenu;
        private System.Windows.Forms.Button buttonExchangeTransaction;
        private System.Windows.Forms.TextBox textBoxExchangeSearch;
        private POS_Controls.Buttons ExchangeSearchBackground;
        private System.Windows.Forms.Panel panelExchangeLabel;
        private System.Windows.Forms.Panel panelPageNavigation;
        private System.Windows.Forms.TextBox pageInput;
        private POS_Controls.Buttons pageDisplay;
        private POS_Controls.Buttons nextButton;
        private POS_Controls.Buttons lastButton;
        private POS_Controls.Buttons previousButton;
        private POS_Controls.Buttons firstButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelExchangeContents;
    }
}