using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace POS1.Inventory_Forms
{
    public partial class InventoryCreateCategory : UserControl
    {
        private string categoryName;
        private int categoryId;
        public InventoryCreate _parent;

        public string CategoryName
        {
            get { return categoryName; }
            set { categoryName = value; labelInventoryCreateCategory.Text = value; }
        }

        public int CategoryId
        {
            get { return categoryId; }
            set { categoryId = value; }
        }

        public InventoryCreateCategory(InventoryCreate parentForm)
        {
            InitializeComponent();
            _parent = parentForm;
        }

        private void labelInventoryCreateCategory_Click(object sender, EventArgs e)
        {
            LoadCreatePerCategory();
        }

        private void buttonsInventoryCreateCategory_Click(object sender, EventArgs e)
        {
            LoadCreatePerCategory();
        }

        private void LoadCreatePerCategory()
        {
            _parent._parent.flowLayoutPanelInventoryContents.Controls.Clear();
            _parent._parent.CreateMode = false;

            InventoryCreatePerCategory create = new InventoryCreatePerCategory(this);
            create.ItemCategory = categoryName;
            create.ItemCategoryId = categoryId;

            create.Width = _parent._parent.flowLayoutPanelInventoryContents.Width - 30;
            create.Height = _parent._parent.flowLayoutPanelInventoryContents.Height - 106;

            _parent._parent.flowLayoutPanelInventoryContents.Controls.Add(create);
        }
    }
}
