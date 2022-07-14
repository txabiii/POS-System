using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;
using POS1.Forms;

namespace POS1.Transaction_Forms
{
    public partial class Filter : Form
    {
        private bool filterByDate = true;

        public Filter()
        {
            InitializeComponent();
            clearFilter();
        }

        public bool FilterByDate
        {
            get { return filterByDate; }
            set { filterByDate = value; filterByDateCheckBox.Checked = filterByDate; }
        }

        private void buttons1_Click(object sender, EventArgs e)
        {
            //check date filter
            if (filterByDate)
            {
                POS1.Transaction.TransactionForm.dateFilterFirst = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                POS1.Transaction.TransactionForm.dateFilterSecond = dateTimePicker2.Value.ToString("yyyy-MM-dd");
            } else
            {
                POS1.Transaction.TransactionForm.dateFilterFirst = null;
                POS1.Transaction.TransactionForm.dateFilterSecond = null;
            }

            // check type filter
            if (comboBoxTransactionType.SelectedItem != null)
            {
                //string typeInput = "";
                //typeInput = comboBoxTransactionType.SelectedItem.ToString();
                if (comboBoxTransactionType.SelectedIndex >= 1 && comboBoxTransactionType.SelectedIndex <= 4)
                {
                    POS1.Transaction.TransactionForm.typeFilter = comboBoxTransactionType.Text;
                }
                else POS1.Transaction.TransactionForm.typeFilter = null;
            }
            else POS1.Transaction.TransactionForm.typeFilter = null;


            //check item id filter
            if (!String.IsNullOrEmpty(textBoxItemIdFilter.Text))
            {
                if (int.TryParse(textBoxItemIdFilter.Text, out int itemId))
                {
                    POS1.Transaction.TransactionForm.itemIdFilter = itemId;
                } else POS1.Transaction.TransactionForm.itemIdFilter = 0;
            } else POS1.Transaction.TransactionForm.itemIdFilter = 0;

            POS1.Transaction.TransactionForm.currentPage = 1;
            this.Close();
        }

        public Boolean checkFilter()
        {
            if (filterByDate || (comboBoxTransactionType.SelectedItem != null && comboBoxTransactionType.SelectedIndex != 0) || !String.IsNullOrEmpty(textBoxItemIdFilter.Text))
            {
                return true;
            }
            return false;
        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            toggleFilterByDate();
        }

        private void toggleFilterByDate()
        {
            if (filterByDate)
            {
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                dateTimePicker2.Format = DateTimePickerFormat.Custom;
                dateTimePicker1.CustomFormat = " ";
                dateTimePicker2.CustomFormat = " ";
                filterByDate = false;
                POS1.Transaction.TransactionForm.filterByDate = false;
            }
            else
            {
                dateTimePicker1.Enabled = true;
                dateTimePicker2.Enabled = true;
                dateTimePicker1.Format = DateTimePickerFormat.Short;
                dateTimePicker2.Format = DateTimePickerFormat.Short;
                filterByDate = true;
                POS1.Transaction.TransactionForm.filterByDate = true;
            }
        }

        private void labelFilterClear_Click(object sender, EventArgs e)
        {
            clearFilter();
        }

        private void clearFilter()
        {
            if (filterByDate)
            {
                filterByDateCheckBox.Checked = true;
            }
            comboBoxTransactionType.SelectedIndex = 0;
            textBoxItemIdFilter.Text = "";
        }

        private void textBoxItemIdFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
