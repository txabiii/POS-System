using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace POS1.Sales_Forms
{
    public partial class ButtonsCategories : UserControl
    {
        // Fields
        private Button currentButton;

        public ButtonsCategories()
        {
            InitializeComponent();
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
            foreach (Control previousBtn in panelButtonsCategories.Controls)
            {
                if (previousBtn.GetType() != typeof(Label) && previousBtn.GetType() != typeof(PictureBox))
                {
                    previousBtn.BackColor = Color.FromArgb(255, 192, 192);
                }
            }
        }

        private void buttonsAll_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void buttonsMen_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void buttonsWomen_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void buttonsActive_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void buttonsBodyBath_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }
    }
}
