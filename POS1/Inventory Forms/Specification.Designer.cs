
namespace POS1.Inventory_Forms
{
    partial class Specification
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
            this.SpecificationConfirm = new System.Windows.Forms.Panel();
            this.buttonStocksConfirm = new POS1.POS_Controls.Buttons();
            this.SpecificationHeader = new System.Windows.Forms.Panel();
            this.buttonsReset = new POS1.POS_Controls.Buttons();
            this.labelSpecificationTitle = new System.Windows.Forms.Label();
            this.SpecificationContentPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.AddPanel = new System.Windows.Forms.Panel();
            this.TopBorderContainer = new System.Windows.Forms.Panel();
            this.buttonsAddSpecification = new POS1.POS_Controls.Buttons();
            this.SpecificationConfirm.SuspendLayout();
            this.SpecificationHeader.SuspendLayout();
            this.SpecificationContentPanel.SuspendLayout();
            this.AddPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SpecificationConfirm
            // 
            this.SpecificationConfirm.Controls.Add(this.buttonStocksConfirm);
            this.SpecificationConfirm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SpecificationConfirm.Location = new System.Drawing.Point(0, 385);
            this.SpecificationConfirm.Name = "SpecificationConfirm";
            this.SpecificationConfirm.Size = new System.Drawing.Size(330, 68);
            this.SpecificationConfirm.TabIndex = 2;
            // 
            // buttonStocksConfirm
            // 
            this.buttonStocksConfirm.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonStocksConfirm.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.buttonStocksConfirm.BorderColor = System.Drawing.Color.Transparent;
            this.buttonStocksConfirm.BorderRadius = 15;
            this.buttonStocksConfirm.BorderSize = 3;
            this.buttonStocksConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStocksConfirm.FlatAppearance.BorderSize = 0;
            this.buttonStocksConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStocksConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonStocksConfirm.ForeColor = System.Drawing.Color.Black;
            this.buttonStocksConfirm.Location = new System.Drawing.Point(90, 28);
            this.buttonStocksConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStocksConfirm.Name = "buttonStocksConfirm";
            this.buttonStocksConfirm.Size = new System.Drawing.Size(150, 35);
            this.buttonStocksConfirm.TabIndex = 2;
            this.buttonStocksConfirm.Text = "confirm";
            this.buttonStocksConfirm.TextColor = System.Drawing.Color.Black;
            this.buttonStocksConfirm.UseVisualStyleBackColor = false;
            this.buttonStocksConfirm.Click += new System.EventHandler(this.buttonStocksConfirm_Click);
            // 
            // SpecificationHeader
            // 
            this.SpecificationHeader.Controls.Add(this.buttonsReset);
            this.SpecificationHeader.Controls.Add(this.labelSpecificationTitle);
            this.SpecificationHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.SpecificationHeader.Location = new System.Drawing.Point(0, 20);
            this.SpecificationHeader.Name = "SpecificationHeader";
            this.SpecificationHeader.Size = new System.Drawing.Size(330, 45);
            this.SpecificationHeader.TabIndex = 3;
            // 
            // buttonsReset
            // 
            this.buttonsReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonsReset.BackColor = System.Drawing.Color.Tomato;
            this.buttonsReset.BackgroundColor = System.Drawing.Color.Tomato;
            this.buttonsReset.BorderColor = System.Drawing.Color.Transparent;
            this.buttonsReset.BorderRadius = 13;
            this.buttonsReset.BorderSize = 3;
            this.buttonsReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonsReset.FlatAppearance.BorderSize = 0;
            this.buttonsReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonsReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonsReset.ForeColor = System.Drawing.Color.White;
            this.buttonsReset.Location = new System.Drawing.Point(233, 0);
            this.buttonsReset.Margin = new System.Windows.Forms.Padding(2);
            this.buttonsReset.Name = "buttonsReset";
            this.buttonsReset.Size = new System.Drawing.Size(75, 26);
            this.buttonsReset.TabIndex = 25;
            this.buttonsReset.Text = "reset";
            this.buttonsReset.TextColor = System.Drawing.Color.White;
            this.buttonsReset.UseVisualStyleBackColor = false;
            this.buttonsReset.Click += new System.EventHandler(this.buttonsReset_Click);
            // 
            // labelSpecificationTitle
            // 
            this.labelSpecificationTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSpecificationTitle.Location = new System.Drawing.Point(20, 2);
            this.labelSpecificationTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSpecificationTitle.Name = "labelSpecificationTitle";
            this.labelSpecificationTitle.Size = new System.Drawing.Size(250, 43);
            this.labelSpecificationTitle.TabIndex = 2;
            this.labelSpecificationTitle.Text = "Specification";
            // 
            // SpecificationContentPanel
            // 
            this.SpecificationContentPanel.AutoScroll = true;
            this.SpecificationContentPanel.Controls.Add(this.AddPanel);
            this.SpecificationContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpecificationContentPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.SpecificationContentPanel.Location = new System.Drawing.Point(0, 65);
            this.SpecificationContentPanel.Name = "SpecificationContentPanel";
            this.SpecificationContentPanel.Size = new System.Drawing.Size(330, 320);
            this.SpecificationContentPanel.TabIndex = 4;
            this.SpecificationContentPanel.WrapContents = false;
            // 
            // AddPanel
            // 
            this.AddPanel.Controls.Add(this.TopBorderContainer);
            this.AddPanel.Controls.Add(this.buttonsAddSpecification);
            this.AddPanel.Location = new System.Drawing.Point(3, 3);
            this.AddPanel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.AddPanel.Name = "AddPanel";
            this.AddPanel.Size = new System.Drawing.Size(305, 39);
            this.AddPanel.TabIndex = 5;
            this.AddPanel.Click += new System.EventHandler(this.AddPanel_Click);
            // 
            // TopBorderContainer
            // 
            this.TopBorderContainer.BackColor = System.Drawing.Color.White;
            this.TopBorderContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBorderContainer.Location = new System.Drawing.Point(0, 0);
            this.TopBorderContainer.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.TopBorderContainer.Name = "TopBorderContainer";
            this.TopBorderContainer.Size = new System.Drawing.Size(305, 1);
            this.TopBorderContainer.TabIndex = 4;
            // 
            // buttonsAddSpecification
            // 
            this.buttonsAddSpecification.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonsAddSpecification.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.buttonsAddSpecification.BorderColor = System.Drawing.Color.Transparent;
            this.buttonsAddSpecification.BorderRadius = 15;
            this.buttonsAddSpecification.BorderSize = 3;
            this.buttonsAddSpecification.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonsAddSpecification.FlatAppearance.BorderSize = 0;
            this.buttonsAddSpecification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonsAddSpecification.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonsAddSpecification.ForeColor = System.Drawing.Color.Black;
            this.buttonsAddSpecification.Location = new System.Drawing.Point(149, 5);
            this.buttonsAddSpecification.Margin = new System.Windows.Forms.Padding(2);
            this.buttonsAddSpecification.Name = "buttonsAddSpecification";
            this.buttonsAddSpecification.Size = new System.Drawing.Size(30, 30);
            this.buttonsAddSpecification.TabIndex = 4;
            this.buttonsAddSpecification.Text = " +";
            this.buttonsAddSpecification.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonsAddSpecification.TextColor = System.Drawing.Color.Black;
            this.buttonsAddSpecification.UseVisualStyleBackColor = false;
            this.buttonsAddSpecification.Click += new System.EventHandler(this.buttonsAddSpecification_Click);
            // 
            // Specification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(330, 473);
            this.Controls.Add(this.SpecificationContentPanel);
            this.Controls.Add(this.SpecificationHeader);
            this.Controls.Add(this.SpecificationConfirm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Specification";
            this.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.Text = "Specification";
            this.Load += new System.EventHandler(this.Specification_Load);
            this.SpecificationConfirm.ResumeLayout(false);
            this.SpecificationHeader.ResumeLayout(false);
            this.SpecificationContentPanel.ResumeLayout(false);
            this.AddPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SpecificationConfirm;
        public POS_Controls.Buttons buttonStocksConfirm;
        private System.Windows.Forms.Panel SpecificationHeader;
        private System.Windows.Forms.Label labelSpecificationTitle;
        private System.Windows.Forms.FlowLayoutPanel SpecificationContentPanel;
        public POS_Controls.Buttons buttonsAddSpecification;
        private System.Windows.Forms.Panel AddPanel;
        private System.Windows.Forms.Panel TopBorderContainer;
        public POS_Controls.Buttons buttonsReset;
    }
}