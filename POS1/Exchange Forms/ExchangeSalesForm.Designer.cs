
namespace POS1.Exchange_Forms
{
    partial class ExchangeSalesForm
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
            this.ExchangeSalesFormPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // ExchangeSalesFormPanel
            // 
            this.ExchangeSalesFormPanel.AutoScroll = true;
            this.ExchangeSalesFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExchangeSalesFormPanel.Location = new System.Drawing.Point(0, 0);
            this.ExchangeSalesFormPanel.Name = "ExchangeSalesFormPanel";
            this.ExchangeSalesFormPanel.Size = new System.Drawing.Size(800, 450);
            this.ExchangeSalesFormPanel.TabIndex = 0;
            // 
            // ExchangeSalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ExchangeSalesFormPanel);
            this.Name = "ExchangeSalesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.FlowLayoutPanel ExchangeSalesFormPanel;
    }
}