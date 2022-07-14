using System;
using System.Windows.Forms;

namespace POS1.Transaction_Forms
{
    public partial class BackButton : UserControl
    {
        public BackButton()
        {
            InitializeComponent();
        }

        public void pictureBoxBackButtonIcon_Click(object sender, EventArgs e)
        {
            new Transaction.TransactionForm();
            this.Dispose();
        }

        private void buttonsBack_Click(object sender, EventArgs e)
        {
            //new Transaction.TransactionForm();
            this.Dispose();
        }
    }
}
