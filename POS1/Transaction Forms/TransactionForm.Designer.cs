
namespace POS1.Transaction
{
    partial class TransactionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionForm));
            this.TransactionSearchBackground = new POS1.POS_Controls.Buttons();
            this.textBoxTransactionSearch = new System.Windows.Forms.TextBox();
            this.panelTransactionMenu = new System.Windows.Forms.Panel();
            this.panelFilterButtonIcon = new System.Windows.Forms.Panel();
            this.filterDot = new POS1.POS_Controls.Buttons();
            this.pictureBoxFilterButtonIcon = new System.Windows.Forms.PictureBox();
            this.buttonsTransactionFilter = new POS1.POS_Controls.Buttons();
            this.OptionPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.itemMovementBottomBorder = new System.Windows.Forms.Panel();
            this.itemMovementButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.historyBottomBorder = new System.Windows.Forms.Panel();
            this.historyButton = new System.Windows.Forms.Button();
            this.buttonSearchTransaction = new System.Windows.Forms.Button();
            this.panelHistoryControls = new System.Windows.Forms.Panel();
            this.panelPageNavigation = new System.Windows.Forms.Panel();
            this.pageInput = new System.Windows.Forms.TextBox();
            this.pageDisplay = new POS1.POS_Controls.Buttons();
            this.nextButton = new POS1.POS_Controls.Buttons();
            this.lastButton = new POS1.POS_Controls.Buttons();
            this.previousButton = new POS1.POS_Controls.Buttons();
            this.firstButton = new POS1.POS_Controls.Buttons();
            this.panelTransactionHistoryLabel = new System.Windows.Forms.Panel();
            this.flowLayoutPanelTransactionContents = new System.Windows.Forms.FlowLayoutPanel();
            this.panelTransactionMenu.SuspendLayout();
            this.panelFilterButtonIcon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFilterButtonIcon)).BeginInit();
            this.OptionPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelHistoryControls.SuspendLayout();
            this.panelPageNavigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // TransactionSearchBackground
            // 
            this.TransactionSearchBackground.AutoSize = true;
            this.TransactionSearchBackground.BackColor = System.Drawing.Color.White;
            this.TransactionSearchBackground.BackgroundColor = System.Drawing.Color.White;
            this.TransactionSearchBackground.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.TransactionSearchBackground.BorderRadius = 15;
            this.TransactionSearchBackground.BorderSize = 0;
            this.TransactionSearchBackground.FlatAppearance.BorderSize = 0;
            this.TransactionSearchBackground.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.TransactionSearchBackground.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.TransactionSearchBackground.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TransactionSearchBackground.ForeColor = System.Drawing.Color.White;
            this.TransactionSearchBackground.Location = new System.Drawing.Point(20, 15);
            this.TransactionSearchBackground.Margin = new System.Windows.Forms.Padding(1);
            this.TransactionSearchBackground.Name = "TransactionSearchBackground";
            this.TransactionSearchBackground.Size = new System.Drawing.Size(300, 26);
            this.TransactionSearchBackground.TabIndex = 0;
            this.TransactionSearchBackground.TextColor = System.Drawing.Color.White;
            this.TransactionSearchBackground.UseVisualStyleBackColor = false;
            // 
            // textBoxTransactionSearch
            // 
            this.textBoxTransactionSearch.BackColor = System.Drawing.Color.White;
            this.textBoxTransactionSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTransactionSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxTransactionSearch.Location = new System.Drawing.Point(31, 20);
            this.textBoxTransactionSearch.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxTransactionSearch.Name = "textBoxTransactionSearch";
            this.textBoxTransactionSearch.PlaceholderText = "Search Transaction ID";
            this.textBoxTransactionSearch.Size = new System.Drawing.Size(280, 14);
            this.textBoxTransactionSearch.TabIndex = 1;
            this.textBoxTransactionSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxTransactionSearch_KeyDown);
            this.textBoxTransactionSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pageInput_KeyPress);
            // 
            // panelTransactionMenu
            // 
            this.panelTransactionMenu.Controls.Add(this.panelFilterButtonIcon);
            this.panelTransactionMenu.Controls.Add(this.buttonsTransactionFilter);
            this.panelTransactionMenu.Controls.Add(this.OptionPanel);
            this.panelTransactionMenu.Controls.Add(this.buttonSearchTransaction);
            this.panelTransactionMenu.Controls.Add(this.textBoxTransactionSearch);
            this.panelTransactionMenu.Controls.Add(this.TransactionSearchBackground);
            this.panelTransactionMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTransactionMenu.Location = new System.Drawing.Point(0, 0);
            this.panelTransactionMenu.Margin = new System.Windows.Forms.Padding(1);
            this.panelTransactionMenu.Name = "panelTransactionMenu";
            this.panelTransactionMenu.Size = new System.Drawing.Size(1069, 73);
            this.panelTransactionMenu.TabIndex = 6;
            // 
            // panelFilterButtonIcon
            // 
            this.panelFilterButtonIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFilterButtonIcon.BackColor = System.Drawing.Color.White;
            this.panelFilterButtonIcon.Controls.Add(this.filterDot);
            this.panelFilterButtonIcon.Controls.Add(this.pictureBoxFilterButtonIcon);
            this.panelFilterButtonIcon.Location = new System.Drawing.Point(939, 21);
            this.panelFilterButtonIcon.Margin = new System.Windows.Forms.Padding(2);
            this.panelFilterButtonIcon.Name = "panelFilterButtonIcon";
            this.panelFilterButtonIcon.Size = new System.Drawing.Size(45, 22);
            this.panelFilterButtonIcon.TabIndex = 14;
            // 
            // filterDot
            // 
            this.filterDot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.filterDot.BackColor = System.Drawing.Color.Red;
            this.filterDot.BackgroundColor = System.Drawing.Color.Red;
            this.filterDot.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.filterDot.BorderRadius = 5;
            this.filterDot.BorderSize = 0;
            this.filterDot.FlatAppearance.BorderSize = 0;
            this.filterDot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filterDot.ForeColor = System.Drawing.Color.White;
            this.filterDot.Location = new System.Drawing.Point(0, 5);
            this.filterDot.Name = "filterDot";
            this.filterDot.Size = new System.Drawing.Size(10, 10);
            this.filterDot.TabIndex = 12;
            this.filterDot.TextColor = System.Drawing.Color.White;
            this.filterDot.UseVisualStyleBackColor = false;
            this.filterDot.Visible = false;
            // 
            // pictureBoxFilterButtonIcon
            // 
            this.pictureBoxFilterButtonIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxFilterButtonIcon.BackgroundImage")));
            this.pictureBoxFilterButtonIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxFilterButtonIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxFilterButtonIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxFilterButtonIcon.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxFilterButtonIcon.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxFilterButtonIcon.Name = "pictureBoxFilterButtonIcon";
            this.pictureBoxFilterButtonIcon.Size = new System.Drawing.Size(45, 22);
            this.pictureBoxFilterButtonIcon.TabIndex = 0;
            this.pictureBoxFilterButtonIcon.TabStop = false;
            this.pictureBoxFilterButtonIcon.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // buttonsTransactionFilter
            // 
            this.buttonsTransactionFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonsTransactionFilter.BackColor = System.Drawing.Color.White;
            this.buttonsTransactionFilter.BackgroundColor = System.Drawing.Color.White;
            this.buttonsTransactionFilter.BorderColor = System.Drawing.Color.Black;
            this.buttonsTransactionFilter.BorderRadius = 10;
            this.buttonsTransactionFilter.BorderSize = 3;
            this.buttonsTransactionFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonsTransactionFilter.FlatAppearance.BorderSize = 0;
            this.buttonsTransactionFilter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonsTransactionFilter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonsTransactionFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonsTransactionFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonsTransactionFilter.ForeColor = System.Drawing.Color.Black;
            this.buttonsTransactionFilter.Location = new System.Drawing.Point(929, 15);
            this.buttonsTransactionFilter.Margin = new System.Windows.Forms.Padding(2);
            this.buttonsTransactionFilter.Name = "buttonsTransactionFilter";
            this.buttonsTransactionFilter.Size = new System.Drawing.Size(105, 32);
            this.buttonsTransactionFilter.TabIndex = 13;
            this.buttonsTransactionFilter.Text = "Filter";
            this.buttonsTransactionFilter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonsTransactionFilter.TextColor = System.Drawing.Color.Black;
            this.buttonsTransactionFilter.UseVisualStyleBackColor = false;
            this.buttonsTransactionFilter.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // OptionPanel
            // 
            this.OptionPanel.Controls.Add(this.panel2);
            this.OptionPanel.Controls.Add(this.panel1);
            this.OptionPanel.Location = new System.Drawing.Point(345, 9);
            this.OptionPanel.Name = "OptionPanel";
            this.OptionPanel.Size = new System.Drawing.Size(260, 31);
            this.OptionPanel.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.itemMovementBottomBorder);
            this.panel2.Controls.Add(this.itemMovementButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(103, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(157, 31);
            this.panel2.TabIndex = 1;
            // 
            // itemMovementBottomBorder
            // 
            this.itemMovementBottomBorder.BackColor = System.Drawing.Color.Silver;
            this.itemMovementBottomBorder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.itemMovementBottomBorder.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.itemMovementBottomBorder.Location = new System.Drawing.Point(0, 30);
            this.itemMovementBottomBorder.Name = "itemMovementBottomBorder";
            this.itemMovementBottomBorder.Size = new System.Drawing.Size(157, 1);
            this.itemMovementBottomBorder.TabIndex = 7;
            // 
            // itemMovementButton
            // 
            this.itemMovementButton.AutoSize = true;
            this.itemMovementButton.BackColor = System.Drawing.Color.Transparent;
            this.itemMovementButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.itemMovementButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.itemMovementButton.FlatAppearance.BorderSize = 0;
            this.itemMovementButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.itemMovementButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.itemMovementButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemMovementButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.itemMovementButton.Location = new System.Drawing.Point(0, 0);
            this.itemMovementButton.Margin = new System.Windows.Forms.Padding(1);
            this.itemMovementButton.Name = "itemMovementButton";
            this.itemMovementButton.Size = new System.Drawing.Size(157, 27);
            this.itemMovementButton.TabIndex = 6;
            this.itemMovementButton.Text = "Item Movement";
            this.itemMovementButton.UseVisualStyleBackColor = false;
            this.itemMovementButton.Click += new System.EventHandler(this.itemMovementButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.historyBottomBorder);
            this.panel1.Controls.Add(this.historyButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(103, 31);
            this.panel1.TabIndex = 0;
            // 
            // historyBottomBorder
            // 
            this.historyBottomBorder.BackColor = System.Drawing.Color.Red;
            this.historyBottomBorder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.historyBottomBorder.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.historyBottomBorder.Location = new System.Drawing.Point(0, 24);
            this.historyBottomBorder.Name = "historyBottomBorder";
            this.historyBottomBorder.Size = new System.Drawing.Size(103, 7);
            this.historyBottomBorder.TabIndex = 6;
            // 
            // historyButton
            // 
            this.historyButton.AutoSize = true;
            this.historyButton.BackColor = System.Drawing.Color.Transparent;
            this.historyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.historyButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.historyButton.FlatAppearance.BorderSize = 0;
            this.historyButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.historyButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.historyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.historyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.historyButton.Location = new System.Drawing.Point(0, 0);
            this.historyButton.Margin = new System.Windows.Forms.Padding(1);
            this.historyButton.Name = "historyButton";
            this.historyButton.Size = new System.Drawing.Size(103, 27);
            this.historyButton.TabIndex = 5;
            this.historyButton.Text = "History";
            this.historyButton.UseVisualStyleBackColor = false;
            this.historyButton.Click += new System.EventHandler(this.historyButton_Click);
            // 
            // buttonSearchTransaction
            // 
            this.buttonSearchTransaction.AutoSize = true;
            this.buttonSearchTransaction.BackColor = System.Drawing.Color.White;
            this.buttonSearchTransaction.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSearchTransaction.BackgroundImage")));
            this.buttonSearchTransaction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSearchTransaction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSearchTransaction.FlatAppearance.BorderSize = 0;
            this.buttonSearchTransaction.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonSearchTransaction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonSearchTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearchTransaction.Location = new System.Drawing.Point(290, 19);
            this.buttonSearchTransaction.Margin = new System.Windows.Forms.Padding(1);
            this.buttonSearchTransaction.Name = "buttonSearchTransaction";
            this.buttonSearchTransaction.Size = new System.Drawing.Size(23, 20);
            this.buttonSearchTransaction.TabIndex = 3;
            this.buttonSearchTransaction.UseVisualStyleBackColor = false;
            // 
            // panelHistoryControls
            // 
            this.panelHistoryControls.Controls.Add(this.panelPageNavigation);
            this.panelHistoryControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelHistoryControls.Location = new System.Drawing.Point(0, 487);
            this.panelHistoryControls.Margin = new System.Windows.Forms.Padding(1);
            this.panelHistoryControls.Name = "panelHistoryControls";
            this.panelHistoryControls.Size = new System.Drawing.Size(1069, 100);
            this.panelHistoryControls.TabIndex = 8;
            // 
            // panelPageNavigation
            // 
            this.panelPageNavigation.Controls.Add(this.pageInput);
            this.panelPageNavigation.Controls.Add(this.pageDisplay);
            this.panelPageNavigation.Controls.Add(this.nextButton);
            this.panelPageNavigation.Controls.Add(this.lastButton);
            this.panelPageNavigation.Controls.Add(this.previousButton);
            this.panelPageNavigation.Controls.Add(this.firstButton);
            this.panelPageNavigation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPageNavigation.Location = new System.Drawing.Point(0, 0);
            this.panelPageNavigation.Name = "panelPageNavigation";
            this.panelPageNavigation.Padding = new System.Windows.Forms.Padding(400, 25, 400, 25);
            this.panelPageNavigation.Size = new System.Drawing.Size(1069, 100);
            this.panelPageNavigation.TabIndex = 5;
            // 
            // pageInput
            // 
            this.pageInput.BackColor = System.Drawing.Color.White;
            this.pageInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pageInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pageInput.Location = new System.Drawing.Point(507, 45);
            this.pageInput.Name = "pageInput";
            this.pageInput.Size = new System.Drawing.Size(60, 14);
            this.pageInput.TabIndex = 5;
            this.pageInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pageInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pageInput_KeyDown);
            this.pageInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pageInput_KeyPress);
            this.pageInput.MouseLeave += new System.EventHandler(this.pageInput_MouseLeave);
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
            this.pageDisplay.Location = new System.Drawing.Point(496, 25);
            this.pageDisplay.Margin = new System.Windows.Forms.Padding(8, 3, 8, 3);
            this.pageDisplay.Name = "pageDisplay";
            this.pageDisplay.Size = new System.Drawing.Size(77, 50);
            this.pageDisplay.TabIndex = 4;
            this.pageDisplay.TextColor = System.Drawing.Color.DimGray;
            this.pageDisplay.UseVisualStyleBackColor = false;
            this.pageDisplay.Paint += new System.Windows.Forms.PaintEventHandler(this.pageDisplay_Paint);
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
            this.nextButton.Location = new System.Drawing.Point(573, 25);
            this.nextButton.Margin = new System.Windows.Forms.Padding(8, 3, 8, 3);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(48, 50);
            this.nextButton.TabIndex = 3;
            this.nextButton.Text = "→";
            this.nextButton.TextColor = System.Drawing.Color.DimGray;
            this.nextButton.UseVisualStyleBackColor = false;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
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
            this.lastButton.Location = new System.Drawing.Point(621, 25);
            this.lastButton.Margin = new System.Windows.Forms.Padding(8, 3, 8, 3);
            this.lastButton.Name = "lastButton";
            this.lastButton.Size = new System.Drawing.Size(48, 50);
            this.lastButton.TabIndex = 2;
            this.lastButton.Text = "⇥";
            this.lastButton.TextColor = System.Drawing.Color.DimGray;
            this.lastButton.UseVisualStyleBackColor = false;
            this.lastButton.Click += new System.EventHandler(this.lastButton_Click);
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
            this.previousButton.Location = new System.Drawing.Point(448, 25);
            this.previousButton.Margin = new System.Windows.Forms.Padding(8, 3, 8, 3);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(48, 50);
            this.previousButton.TabIndex = 1;
            this.previousButton.Text = "←";
            this.previousButton.TextColor = System.Drawing.Color.DimGray;
            this.previousButton.UseVisualStyleBackColor = false;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
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
            this.firstButton.Location = new System.Drawing.Point(400, 25);
            this.firstButton.Margin = new System.Windows.Forms.Padding(8, 3, 8, 3);
            this.firstButton.Name = "firstButton";
            this.firstButton.Size = new System.Drawing.Size(48, 50);
            this.firstButton.TabIndex = 0;
            this.firstButton.Text = "⇤";
            this.firstButton.TextColor = System.Drawing.Color.DimGray;
            this.firstButton.UseVisualStyleBackColor = false;
            this.firstButton.Click += new System.EventHandler(this.firstButton_Click);
            // 
            // panelTransactionHistoryLabel
            // 
            this.panelTransactionHistoryLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTransactionHistoryLabel.Location = new System.Drawing.Point(0, 73);
            this.panelTransactionHistoryLabel.Margin = new System.Windows.Forms.Padding(1);
            this.panelTransactionHistoryLabel.Name = "panelTransactionHistoryLabel";
            this.panelTransactionHistoryLabel.Size = new System.Drawing.Size(1069, 49);
            this.panelTransactionHistoryLabel.TabIndex = 10;
            // 
            // flowLayoutPanelTransactionContents
            // 
            this.flowLayoutPanelTransactionContents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelTransactionContents.Location = new System.Drawing.Point(0, 122);
            this.flowLayoutPanelTransactionContents.Margin = new System.Windows.Forms.Padding(1);
            this.flowLayoutPanelTransactionContents.Name = "flowLayoutPanelTransactionContents";
            this.flowLayoutPanelTransactionContents.Size = new System.Drawing.Size(1069, 365);
            this.flowLayoutPanelTransactionContents.TabIndex = 11;
            // 
            // TransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1069, 587);
            this.Controls.Add(this.flowLayoutPanelTransactionContents);
            this.Controls.Add(this.panelTransactionHistoryLabel);
            this.Controls.Add(this.panelHistoryControls);
            this.Controls.Add(this.panelTransactionMenu);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "TransactionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transaction Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TransactionForm_Load);
            this.panelTransactionMenu.ResumeLayout(false);
            this.panelTransactionMenu.PerformLayout();
            this.panelFilterButtonIcon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFilterButtonIcon)).EndInit();
            this.OptionPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelHistoryControls.ResumeLayout(false);
            this.panelPageNavigation.ResumeLayout(false);
            this.panelPageNavigation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private POS_Controls.Buttons TransactionSearchBackground;
        private System.Windows.Forms.TextBox textBoxTransactionSearch;
        private System.Windows.Forms.Panel panelTransactionMenu;
        private System.Windows.Forms.Button buttonSearchTransaction;
        private System.Windows.Forms.Panel panelHistoryControls;
        private System.Windows.Forms.Panel panelTransactionHistoryLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelTransactionContents;
        private System.Windows.Forms.Panel OptionPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel itemMovementBottomBorder;
        private System.Windows.Forms.Button itemMovementButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel historyBottomBorder;
        private System.Windows.Forms.Button historyButton;
        private POS_Controls.Buttons pageDisplay;
        private POS_Controls.Buttons nextButton;
        private POS_Controls.Buttons lastButton;
        private POS_Controls.Buttons previousButton;
        private POS_Controls.Buttons firstButton;
        private System.Windows.Forms.TextBox pageInput;
        private System.Windows.Forms.Panel panelFilterButtonIcon;
        public System.Windows.Forms.PictureBox pictureBoxFilterButtonIcon;
        public POS_Controls.Buttons buttonsTransactionFilter;
        public POS_Controls.Buttons filterDot;
        private System.Windows.Forms.Panel panelPageNavigation;
    }
}