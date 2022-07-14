using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace POS1.Inventory_Forms
{
    public partial class InventoryFilter : Form
    {
        InventoryForm _parent;

        DataTable categories = Program.DataTableQuery("select * from `category` order by `category_order`");

        public InventoryFilter(InventoryForm parentForm)
        {
            InitializeComponent();
            _parent = parentForm;

            LoadCategories();

            comboBoxInventoryFilterAlphabeticalOrder.SelectedIndex = 0;
            comboBoxInventoryFilterCategory.SelectedIndex = 0;
            comboBoxInventoryFilterOrderByPrice.SelectedIndex = 0;
            comboBoxOrderByDate.SelectedIndex = 0;
        }

        private void LoadCategories()
        {
            comboBoxInventoryFilterCategory.Items.Clear();
            comboBoxInventoryFilterCategory.Items.Add("All");

            foreach (DataRow category in categories.Rows)
            {
                comboBoxInventoryFilterCategory.Items.Add(category["category_name"]);
            }
        }

        private void labelFilterClear_Click(object sender, EventArgs e)
        {
            comboBoxInventoryFilterAlphabeticalOrder.SelectedIndex = 0;
            comboBoxInventoryFilterCategory.SelectedIndex = 0;
            comboBoxInventoryFilterOrderByPrice.SelectedIndex = 0;
            comboBoxOrderByDate.SelectedIndex = 0;
        }

        private void filterConfirm_Click(object sender, EventArgs e)
        {
            if (comboBoxInventoryFilterAlphabeticalOrder.SelectedIndex == 1) _parent.OrderAlphabetical = true;
            else if (comboBoxInventoryFilterAlphabeticalOrder.SelectedIndex == 2) _parent.OrderAlphabetical = false;
            else _parent.OrderAlphabetical = null;

            if (comboBoxInventoryFilterOrderByPrice.SelectedIndex == 1) _parent.OrderPrice = true;
            else if (comboBoxInventoryFilterOrderByPrice.SelectedIndex == 2) _parent.OrderPrice = false;
            else _parent.OrderPrice = null;

            if (comboBoxOrderByDate.SelectedIndex == 1) _parent.OrderDate = true;
            else if (comboBoxOrderByDate.SelectedIndex == 2) _parent.OrderDate = false;
            else _parent.OrderDate = null;

            int categoryInput = 0;
            foreach (DataRow category in categories.Rows)
            {
                if (comboBoxInventoryFilterCategory.GetItemText(comboBoxInventoryFilterCategory.SelectedItem) == category["category_name"].ToString())
                {
                    categoryInput = (int)category["category_id"];
                }
            }
            _parent.FilterCategory = categoryInput;

            _parent.populateInventoryContent();
        }
    }
}
