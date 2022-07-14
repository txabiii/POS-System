namespace POS1.Forms
{
    partial class SalesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesForm));
            this.FilterPanel = new System.Windows.Forms.Panel();
            this.CategoryPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSales = new System.Windows.Forms.TextBox();
            this.SearchBackground = new POS1.POS_Controls.Buttons();
            this.panelSalesRight = new System.Windows.Forms.Panel();
            this.panelBills = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelChange = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelSalesChangeValue = new System.Windows.Forms.Label();
            this.labelSalesChange = new System.Windows.Forms.Label();
            this.panelCash = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.labelSalesCash = new System.Windows.Forms.Label();
            this.labelSalesCashValue = new System.Windows.Forms.Label();
            this.panelTotal = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.labelSalesTotal = new System.Windows.Forms.Label();
            this.labelSalesTotalValue = new System.Windows.Forms.Label();
            this.line = new System.Windows.Forms.Panel();
            this.panelTax = new System.Windows.Forms.Panel();
            this.labelSalesTax = new System.Windows.Forms.Label();
            this.labelSalesTaxValue = new System.Windows.Forms.Label();
            this.panelSubtotal = new System.Windows.Forms.Panel();
            this.labelSalesSubtotal = new System.Windows.Forms.Label();
            this.labelSalesSubtotalValue = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonsSalesPrintBills = new POS1.POS_Controls.Buttons();
            this.buttonsSalesCash = new POS1.POS_Controls.Buttons();
            this.buttonsSalesCard = new POS1.POS_Controls.Buttons();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelSalesBills = new System.Windows.Forms.Label();
            this.buttonsSalesClearAll = new POS1.POS_Controls.Buttons();
            this.labelSalesChangeNumber = new System.Windows.Forms.Label();
            this.labelSalesCashNumber = new System.Windows.Forms.Label();
            this.labelSalesTotalNumber = new System.Windows.Forms.Label();
            this.labelSalesTaxNumber = new System.Windows.Forms.Label();
            this.labelSalesDiscountsNumber = new System.Windows.Forms.Label();
            this.labelSalesSubtotalNumber = new System.Windows.Forms.Label();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.flowLayoutPanelSalesItems = new System.Windows.Forms.FlowLayoutPanel();
            this.FilterPanel.SuspendLayout();
            this.panelSalesRight.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelChange.SuspendLayout();
            this.panelCash.SuspendLayout();
            this.panelTotal.SuspendLayout();
            this.panelTax.SuspendLayout();
            this.panelSubtotal.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.LeftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // FilterPanel
            // 
            this.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.FilterPanel.Controls.Add(this.CategoryPanel);
            this.FilterPanel.Controls.Add(this.buttonSearch);
            this.FilterPanel.Controls.Add(this.textBoxSales);
            this.FilterPanel.Controls.Add(this.SearchBackground);
            this.FilterPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FilterPanel.Location = new System.Drawing.Point(0, 0);
            this.FilterPanel.Margin = new System.Windows.Forms.Padding(2);
            this.FilterPanel.Name = "FilterPanel";
            this.FilterPanel.Size = new System.Drawing.Size(638, 112);
            this.FilterPanel.TabIndex = 0;
            // 
            // CategoryPanel
            // 
            this.CategoryPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CategoryPanel.Location = new System.Drawing.Point(0, 62);
            this.CategoryPanel.Margin = new System.Windows.Forms.Padding(2);
            this.CategoryPanel.Name = "CategoryPanel";
            this.CategoryPanel.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.CategoryPanel.Size = new System.Drawing.Size(638, 50);
            this.CategoryPanel.TabIndex = 0;
            // 
            // buttonSearch
            // 
            this.buttonSearch.AutoSize = true;
            this.buttonSearch.BackColor = System.Drawing.SystemColors.Window;
            this.buttonSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSearch.BackgroundImage")));
            this.buttonSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSearch.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonSearch.FlatAppearance.BorderSize = 0;
            this.buttonSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.ForeColor = System.Drawing.Color.Black;
            this.buttonSearch.Location = new System.Drawing.Point(290, 19);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(23, 20);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxSales
            // 
            this.textBoxSales.BackColor = System.Drawing.Color.White;
            this.textBoxSales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxSales.Location = new System.Drawing.Point(31, 20);
            this.textBoxSales.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSales.Name = "textBoxSales";
            this.textBoxSales.PlaceholderText = "Search item or barcode";
            this.textBoxSales.Size = new System.Drawing.Size(280, 14);
            this.textBoxSales.TabIndex = 1;
            this.textBoxSales.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSales_KeyDown);
            // 
            // SearchBackground
            // 
            this.SearchBackground.AutoSize = true;
            this.SearchBackground.BackColor = System.Drawing.Color.White;
            this.SearchBackground.BackgroundColor = System.Drawing.Color.White;
            this.SearchBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SearchBackground.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.SearchBackground.BorderRadius = 15;
            this.SearchBackground.BorderSize = 0;
            this.SearchBackground.FlatAppearance.BorderSize = 0;
            this.SearchBackground.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.SearchBackground.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBackground.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchBackground.ForeColor = System.Drawing.Color.Black;
            this.SearchBackground.Location = new System.Drawing.Point(20, 15);
            this.SearchBackground.Margin = new System.Windows.Forms.Padding(2);
            this.SearchBackground.Name = "SearchBackground";
            this.SearchBackground.Size = new System.Drawing.Size(300, 26);
            this.SearchBackground.TabIndex = 3;
            this.SearchBackground.TextColor = System.Drawing.Color.Black;
            this.SearchBackground.UseVisualStyleBackColor = false;
            // 
            // panelSalesRight
            // 
            this.panelSalesRight.BackColor = System.Drawing.Color.White;
            this.panelSalesRight.Controls.Add(this.panelBills);
            this.panelSalesRight.Controls.Add(this.panel2);
            this.panelSalesRight.Controls.Add(this.panel3);
            this.panelSalesRight.Controls.Add(this.panel1);
            this.panelSalesRight.Controls.Add(this.labelSalesChangeNumber);
            this.panelSalesRight.Controls.Add(this.labelSalesCashNumber);
            this.panelSalesRight.Controls.Add(this.labelSalesTotalNumber);
            this.panelSalesRight.Controls.Add(this.labelSalesTaxNumber);
            this.panelSalesRight.Controls.Add(this.labelSalesDiscountsNumber);
            this.panelSalesRight.Controls.Add(this.labelSalesSubtotalNumber);
            this.panelSalesRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelSalesRight.Location = new System.Drawing.Point(638, 0);
            this.panelSalesRight.Margin = new System.Windows.Forms.Padding(2);
            this.panelSalesRight.Name = "panelSalesRight";
            this.panelSalesRight.Size = new System.Drawing.Size(414, 630);
            this.panelSalesRight.TabIndex = 0;
            // 
            // panelBills
            // 
            this.panelBills.AutoScroll = true;
            this.panelBills.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBills.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelBills.Location = new System.Drawing.Point(0, 53);
            this.panelBills.Name = "panelBills";
            this.panelBills.Size = new System.Drawing.Size(414, 262);
            this.panelBills.TabIndex = 17;
            this.panelBills.WrapContents = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panelChange);
            this.panel2.Controls.Add(this.panelCash);
            this.panel2.Controls.Add(this.panelTotal);
            this.panel2.Controls.Add(this.line);
            this.panel2.Controls.Add(this.panelTax);
            this.panel2.Controls.Add(this.panelSubtotal);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 315);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.panel2.Size = new System.Drawing.Size(414, 175);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panelChange
            // 
            this.panelChange.Controls.Add(this.label1);
            this.panelChange.Controls.Add(this.label5);
            this.panelChange.Controls.Add(this.labelSalesChangeValue);
            this.panelChange.Controls.Add(this.labelSalesChange);
            this.panelChange.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelChange.Location = new System.Drawing.Point(20, 146);
            this.panelChange.Name = "panelChange";
            this.panelChange.Size = new System.Drawing.Size(374, 32);
            this.panelChange.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(693, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Sales Tax (5%)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(529, 5);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Cash";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSalesChangeValue
            // 
            this.labelSalesChangeValue.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelSalesChangeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSalesChangeValue.Location = new System.Drawing.Point(190, 0);
            this.labelSalesChangeValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSalesChangeValue.Name = "labelSalesChangeValue";
            this.labelSalesChangeValue.Size = new System.Drawing.Size(184, 32);
            this.labelSalesChangeValue.TabIndex = 27;
            this.labelSalesChangeValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSalesChange
            // 
            this.labelSalesChange.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelSalesChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSalesChange.Location = new System.Drawing.Point(0, 0);
            this.labelSalesChange.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSalesChange.Name = "labelSalesChange";
            this.labelSalesChange.Size = new System.Drawing.Size(50, 32);
            this.labelSalesChange.TabIndex = 21;
            this.labelSalesChange.Text = "Change";
            this.labelSalesChange.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelCash
            // 
            this.panelCash.Controls.Add(this.label3);
            this.panelCash.Controls.Add(this.labelSalesCash);
            this.panelCash.Controls.Add(this.labelSalesCashValue);
            this.panelCash.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCash.Location = new System.Drawing.Point(20, 118);
            this.panelCash.Name = "panelCash";
            this.panelCash.Size = new System.Drawing.Size(374, 28);
            this.panelCash.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(479, 5);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Sales Tax (5%)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSalesCash
            // 
            this.labelSalesCash.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelSalesCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSalesCash.Location = new System.Drawing.Point(0, 0);
            this.labelSalesCash.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSalesCash.Name = "labelSalesCash";
            this.labelSalesCash.Size = new System.Drawing.Size(35, 28);
            this.labelSalesCash.TabIndex = 20;
            this.labelSalesCash.Text = "Cash";
            this.labelSalesCash.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSalesCashValue
            // 
            this.labelSalesCashValue.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelSalesCashValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSalesCashValue.Location = new System.Drawing.Point(190, 0);
            this.labelSalesCashValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSalesCashValue.Name = "labelSalesCashValue";
            this.labelSalesCashValue.Size = new System.Drawing.Size(184, 28);
            this.labelSalesCashValue.TabIndex = 26;
            this.labelSalesCashValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelTotal
            // 
            this.panelTotal.Controls.Add(this.label2);
            this.panelTotal.Controls.Add(this.labelSalesTotal);
            this.panelTotal.Controls.Add(this.labelSalesTotalValue);
            this.panelTotal.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTotal.Location = new System.Drawing.Point(20, 57);
            this.panelTotal.Name = "panelTotal";
            this.panelTotal.Size = new System.Drawing.Size(374, 61);
            this.panelTotal.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(497, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Sales Tax (5%)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSalesTotal
            // 
            this.labelSalesTotal.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelSalesTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSalesTotal.Location = new System.Drawing.Point(0, 0);
            this.labelSalesTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSalesTotal.Name = "labelSalesTotal";
            this.labelSalesTotal.Size = new System.Drawing.Size(73, 61);
            this.labelSalesTotal.TabIndex = 19;
            this.labelSalesTotal.Text = "Total";
            this.labelSalesTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSalesTotalValue
            // 
            this.labelSalesTotalValue.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelSalesTotalValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSalesTotalValue.Location = new System.Drawing.Point(190, 0);
            this.labelSalesTotalValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSalesTotalValue.Name = "labelSalesTotalValue";
            this.labelSalesTotalValue.Size = new System.Drawing.Size(184, 61);
            this.labelSalesTotalValue.TabIndex = 25;
            this.labelSalesTotalValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // line
            // 
            this.line.BackColor = System.Drawing.Color.Black;
            this.line.Dock = System.Windows.Forms.DockStyle.Top;
            this.line.Location = new System.Drawing.Point(20, 56);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(374, 1);
            this.line.TabIndex = 30;
            // 
            // panelTax
            // 
            this.panelTax.Controls.Add(this.labelSalesTax);
            this.panelTax.Controls.Add(this.labelSalesTaxValue);
            this.panelTax.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTax.Location = new System.Drawing.Point(20, 28);
            this.panelTax.Name = "panelTax";
            this.panelTax.Size = new System.Drawing.Size(374, 28);
            this.panelTax.TabIndex = 29;
            // 
            // labelSalesTax
            // 
            this.labelSalesTax.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelSalesTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSalesTax.Location = new System.Drawing.Point(0, 0);
            this.labelSalesTax.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSalesTax.Name = "labelSalesTax";
            this.labelSalesTax.Size = new System.Drawing.Size(91, 28);
            this.labelSalesTax.TabIndex = 17;
            this.labelSalesTax.Text = "Sales Tax (5%)";
            this.labelSalesTax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSalesTaxValue
            // 
            this.labelSalesTaxValue.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelSalesTaxValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSalesTaxValue.Location = new System.Drawing.Point(190, 0);
            this.labelSalesTaxValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSalesTaxValue.Name = "labelSalesTaxValue";
            this.labelSalesTaxValue.Size = new System.Drawing.Size(184, 28);
            this.labelSalesTaxValue.TabIndex = 24;
            this.labelSalesTaxValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelSubtotal
            // 
            this.panelSubtotal.Controls.Add(this.labelSalesSubtotal);
            this.panelSubtotal.Controls.Add(this.labelSalesSubtotalValue);
            this.panelSubtotal.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubtotal.Location = new System.Drawing.Point(20, 0);
            this.panelSubtotal.Name = "panelSubtotal";
            this.panelSubtotal.Size = new System.Drawing.Size(374, 28);
            this.panelSubtotal.TabIndex = 28;
            // 
            // labelSalesSubtotal
            // 
            this.labelSalesSubtotal.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelSalesSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSalesSubtotal.Location = new System.Drawing.Point(0, 0);
            this.labelSalesSubtotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSalesSubtotal.Name = "labelSalesSubtotal";
            this.labelSalesSubtotal.Size = new System.Drawing.Size(54, 28);
            this.labelSalesSubtotal.TabIndex = 15;
            this.labelSalesSubtotal.Text = "Subtotal";
            this.labelSalesSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSalesSubtotalValue
            // 
            this.labelSalesSubtotalValue.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelSalesSubtotalValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSalesSubtotalValue.Location = new System.Drawing.Point(190, 0);
            this.labelSalesSubtotalValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSalesSubtotalValue.Name = "labelSalesSubtotalValue";
            this.labelSalesSubtotalValue.Size = new System.Drawing.Size(184, 28);
            this.labelSalesSubtotalValue.TabIndex = 23;
            this.labelSalesSubtotalValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonsSalesPrintBills);
            this.panel3.Controls.Add(this.buttonsSalesCash);
            this.panel3.Controls.Add(this.buttonsSalesCard);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 490);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(414, 140);
            this.panel3.TabIndex = 2;
            // 
            // buttonsSalesPrintBills
            // 
            this.buttonsSalesPrintBills.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonsSalesPrintBills.AutoSize = true;
            this.buttonsSalesPrintBills.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.buttonsSalesPrintBills.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.buttonsSalesPrintBills.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonsSalesPrintBills.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonsSalesPrintBills.BorderRadius = 25;
            this.buttonsSalesPrintBills.BorderSize = 0;
            this.buttonsSalesPrintBills.FlatAppearance.BorderSize = 0;
            this.buttonsSalesPrintBills.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonsSalesPrintBills.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonsSalesPrintBills.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonsSalesPrintBills.ForeColor = System.Drawing.Color.Black;
            this.buttonsSalesPrintBills.Location = new System.Drawing.Point(13, 78);
            this.buttonsSalesPrintBills.Margin = new System.Windows.Forms.Padding(2);
            this.buttonsSalesPrintBills.Name = "buttonsSalesPrintBills";
            this.buttonsSalesPrintBills.Size = new System.Drawing.Size(391, 49);
            this.buttonsSalesPrintBills.TabIndex = 18;
            this.buttonsSalesPrintBills.Text = "Print Bills";
            this.buttonsSalesPrintBills.TextColor = System.Drawing.Color.Black;
            this.buttonsSalesPrintBills.UseVisualStyleBackColor = false;
            this.buttonsSalesPrintBills.Click += new System.EventHandler(this.buttonsSalesPrintBills_Click);
            // 
            // buttonsSalesCash
            // 
            this.buttonsSalesCash.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonsSalesCash.AutoSize = true;
            this.buttonsSalesCash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.buttonsSalesCash.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.buttonsSalesCash.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonsSalesCash.BackgroundImage")));
            this.buttonsSalesCash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonsSalesCash.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonsSalesCash.BorderRadius = 25;
            this.buttonsSalesCash.BorderSize = 0;
            this.buttonsSalesCash.FlatAppearance.BorderSize = 0;
            this.buttonsSalesCash.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonsSalesCash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonsSalesCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonsSalesCash.ForeColor = System.Drawing.Color.Black;
            this.buttonsSalesCash.Location = new System.Drawing.Point(90, 10);
            this.buttonsSalesCash.Margin = new System.Windows.Forms.Padding(2);
            this.buttonsSalesCash.Name = "buttonsSalesCash";
            this.buttonsSalesCash.Size = new System.Drawing.Size(95, 49);
            this.buttonsSalesCash.TabIndex = 16;
            this.buttonsSalesCash.Text = "Cash";
            this.buttonsSalesCash.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonsSalesCash.TextColor = System.Drawing.Color.Black;
            this.buttonsSalesCash.UseVisualStyleBackColor = false;
            this.buttonsSalesCash.Click += new System.EventHandler(this.buttonsSalesCash_Click);
            // 
            // buttonsSalesCard
            // 
            this.buttonsSalesCard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonsSalesCard.AutoSize = true;
            this.buttonsSalesCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.buttonsSalesCard.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.buttonsSalesCard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonsSalesCard.BackgroundImage")));
            this.buttonsSalesCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonsSalesCard.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonsSalesCard.BorderRadius = 25;
            this.buttonsSalesCard.BorderSize = 0;
            this.buttonsSalesCard.FlatAppearance.BorderSize = 0;
            this.buttonsSalesCard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonsSalesCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonsSalesCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonsSalesCard.ForeColor = System.Drawing.Color.Black;
            this.buttonsSalesCard.Location = new System.Drawing.Point(242, 10);
            this.buttonsSalesCard.Margin = new System.Windows.Forms.Padding(2);
            this.buttonsSalesCard.Name = "buttonsSalesCard";
            this.buttonsSalesCard.Size = new System.Drawing.Size(95, 49);
            this.buttonsSalesCard.TabIndex = 17;
            this.buttonsSalesCard.Text = "Card";
            this.buttonsSalesCard.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonsSalesCard.TextColor = System.Drawing.Color.Black;
            this.buttonsSalesCard.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelSalesBills);
            this.panel1.Controls.Add(this.buttonsSalesClearAll);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 53);
            this.panel1.TabIndex = 16;
            // 
            // labelSalesBills
            // 
            this.labelSalesBills.AutoSize = true;
            this.labelSalesBills.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSalesBills.Location = new System.Drawing.Point(9, 10);
            this.labelSalesBills.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSalesBills.Name = "labelSalesBills";
            this.labelSalesBills.Size = new System.Drawing.Size(64, 29);
            this.labelSalesBills.TabIndex = 1;
            this.labelSalesBills.Text = "Bills";
            // 
            // buttonsSalesClearAll
            // 
            this.buttonsSalesClearAll.AutoSize = true;
            this.buttonsSalesClearAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.buttonsSalesClearAll.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.buttonsSalesClearAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonsSalesClearAll.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonsSalesClearAll.BorderRadius = 14;
            this.buttonsSalesClearAll.BorderSize = 0;
            this.buttonsSalesClearAll.FlatAppearance.BorderSize = 0;
            this.buttonsSalesClearAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonsSalesClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonsSalesClearAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonsSalesClearAll.ForeColor = System.Drawing.Color.Black;
            this.buttonsSalesClearAll.Location = new System.Drawing.Point(308, 10);
            this.buttonsSalesClearAll.Margin = new System.Windows.Forms.Padding(2);
            this.buttonsSalesClearAll.Name = "buttonsSalesClearAll";
            this.buttonsSalesClearAll.Size = new System.Drawing.Size(88, 29);
            this.buttonsSalesClearAll.TabIndex = 2;
            this.buttonsSalesClearAll.Text = "Clear All";
            this.buttonsSalesClearAll.TextColor = System.Drawing.Color.Black;
            this.buttonsSalesClearAll.UseVisualStyleBackColor = false;
            this.buttonsSalesClearAll.Click += new System.EventHandler(this.buttonsSalesClearAll_Click_1);
            // 
            // labelSalesChangeNumber
            // 
            this.labelSalesChangeNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSalesChangeNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSalesChangeNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSalesChangeNumber.Location = new System.Drawing.Point(242, 488);
            this.labelSalesChangeNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSalesChangeNumber.Name = "labelSalesChangeNumber";
            this.labelSalesChangeNumber.Size = new System.Drawing.Size(0, 15);
            this.labelSalesChangeNumber.TabIndex = 15;
            // 
            // labelSalesCashNumber
            // 
            this.labelSalesCashNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSalesCashNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSalesCashNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSalesCashNumber.Location = new System.Drawing.Point(242, 472);
            this.labelSalesCashNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSalesCashNumber.Name = "labelSalesCashNumber";
            this.labelSalesCashNumber.Size = new System.Drawing.Size(0, 15);
            this.labelSalesCashNumber.TabIndex = 13;
            // 
            // labelSalesTotalNumber
            // 
            this.labelSalesTotalNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSalesTotalNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSalesTotalNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSalesTotalNumber.Location = new System.Drawing.Point(242, 440);
            this.labelSalesTotalNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSalesTotalNumber.Name = "labelSalesTotalNumber";
            this.labelSalesTotalNumber.Size = new System.Drawing.Size(0, 31);
            this.labelSalesTotalNumber.TabIndex = 11;
            // 
            // labelSalesTaxNumber
            // 
            this.labelSalesTaxNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSalesTaxNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSalesTaxNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSalesTaxNumber.Location = new System.Drawing.Point(242, 394);
            this.labelSalesTaxNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSalesTaxNumber.Name = "labelSalesTaxNumber";
            this.labelSalesTaxNumber.Size = new System.Drawing.Size(0, 15);
            this.labelSalesTaxNumber.TabIndex = 8;
            // 
            // labelSalesDiscountsNumber
            // 
            this.labelSalesDiscountsNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSalesDiscountsNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSalesDiscountsNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSalesDiscountsNumber.Location = new System.Drawing.Point(242, 372);
            this.labelSalesDiscountsNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSalesDiscountsNumber.Name = "labelSalesDiscountsNumber";
            this.labelSalesDiscountsNumber.Size = new System.Drawing.Size(0, 15);
            this.labelSalesDiscountsNumber.TabIndex = 6;
            // 
            // labelSalesSubtotalNumber
            // 
            this.labelSalesSubtotalNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSalesSubtotalNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSalesSubtotalNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSalesSubtotalNumber.Location = new System.Drawing.Point(242, 350);
            this.labelSalesSubtotalNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSalesSubtotalNumber.Name = "labelSalesSubtotalNumber";
            this.labelSalesSubtotalNumber.Size = new System.Drawing.Size(0, 15);
            this.labelSalesSubtotalNumber.TabIndex = 4;
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.SystemColors.Highlight;
            this.LeftPanel.Controls.Add(this.flowLayoutPanelSalesItems);
            this.LeftPanel.Controls.Add(this.FilterPanel);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Margin = new System.Windows.Forms.Padding(2);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(638, 630);
            this.LeftPanel.TabIndex = 0;
            // 
            // flowLayoutPanelSalesItems
            // 
            this.flowLayoutPanelSalesItems.AutoScroll = true;
            this.flowLayoutPanelSalesItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.flowLayoutPanelSalesItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelSalesItems.Location = new System.Drawing.Point(0, 112);
            this.flowLayoutPanelSalesItems.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanelSalesItems.Name = "flowLayoutPanelSalesItems";
            this.flowLayoutPanelSalesItems.Padding = new System.Windows.Forms.Padding(20, 12, 12, 12);
            this.flowLayoutPanelSalesItems.Size = new System.Drawing.Size(638, 518);
            this.flowLayoutPanelSalesItems.TabIndex = 21;
            // 
            // SalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1052, 630);
            this.Controls.Add(this.LeftPanel);
            this.Controls.Add(this.panelSalesRight);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SalesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalesForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SalesForm_Load);
            this.FilterPanel.ResumeLayout(false);
            this.FilterPanel.PerformLayout();
            this.panelSalesRight.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panelChange.ResumeLayout(false);
            this.panelChange.PerformLayout();
            this.panelCash.ResumeLayout(false);
            this.panelCash.PerformLayout();
            this.panelTotal.ResumeLayout(false);
            this.panelTotal.PerformLayout();
            this.panelTax.ResumeLayout(false);
            this.panelSubtotal.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.LeftPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel FilterPanel;
        private System.Windows.Forms.TextBox textBoxSales;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Panel panelSalesRight;
        private System.Windows.Forms.Label labelSalesSubtotalNumber;
        private System.Windows.Forms.Label labelSalesDiscountsNumber;
        private System.Windows.Forms.Label labelSalesTaxNumber;
        private System.Windows.Forms.Label labelSalesTotalNumber;
        private System.Windows.Forms.Label labelSalesCashNumber;
        private System.Windows.Forms.Label labelSalesChangeNumber;
        private POS_Controls.Buttons buttonsSalesCard;
        private POS_Controls.Buttons buttonsSalesCash;
        private System.Windows.Forms.FlowLayoutPanel CategoryPanel;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelSalesItems;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelSalesBills;
        private POS_Controls.Buttons buttonsSalesClearAll;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelSalesChange;
        private System.Windows.Forms.Label labelSalesCash;
        private System.Windows.Forms.Label labelSalesTotal;
        private System.Windows.Forms.Label labelSalesTax;
        private System.Windows.Forms.Label labelSalesSubtotal;
        private System.Windows.Forms.Panel panel3;
        private POS_Controls.Buttons SearchBackground;
        public System.Windows.Forms.FlowLayoutPanel panelBills;
        public System.Windows.Forms.Label labelSalesSubtotalValue;
        public System.Windows.Forms.Label labelSalesChangeValue;
        public System.Windows.Forms.Label labelSalesCashValue;
        public System.Windows.Forms.Label labelSalesTotalValue;
        public System.Windows.Forms.Label labelSalesTaxValue;
        private System.Windows.Forms.Panel panelTax;
        private System.Windows.Forms.Panel panelSubtotal;
        private System.Windows.Forms.Panel panelChange;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelCash;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelTotal;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel line;
        public POS_Controls.Buttons buttonsSalesPrintBills;
    }
}