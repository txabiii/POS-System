using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS1
{
    public partial class Dashboard : Form
    {
        // Fields
        private Button currentButton;
        private Form activeForm;

        // Constructor
        public Dashboard()
        {
            InitializeComponent();
        }

        // Date and Time
        private void Dashboard_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTimeDate.Text = DateTime.Now.ToString("MM-dd-yyyy\nhh:mm:ss");
        }

        // Methods
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = Color.FromArgb(255, 192, 192);
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() != typeof(Label) && previousBtn.GetType() != typeof(PictureBox))
                {
                    previousBtn.BackColor = Color.FromArgb(178, 178, 178);
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelRightSide.Controls.Add(childForm);
            this.panelRightSide.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void buttonsSales_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.SalesForm(), sender);
        }

        private void buttonsTransactions_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Transaction.TransactionForm(), sender);
        }

        private void buttonsInventory_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Inventory_Forms.InventoryForm(), sender);
        }

        private void buttonsRefund_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Refund_Forms.RefundForm(), sender);
        }

        private void buttonsExchange_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Exchange.ExchangeForm(), sender);
        }
    }
}
