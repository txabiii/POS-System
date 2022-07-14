using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace POS1.Inventory_Forms
{
    public partial class InventoryCreate : UserControl
    {
        public InventoryForm _parent = new InventoryForm();
        private DataTable categories = Program.DataTableQuery("select * from `category` order by `category_order`");

        public InventoryCreate(InventoryForm parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        public void populateInventoryCreateCategory()
        {
            flowLayoutPanelInventoryCreateCategory.Controls.Clear();

            categories = Program.DataTableQuery("select * from `category` order by `category_order`");

            foreach (DataRow category in categories.Rows)
            {
                InventoryCreateCategory option = new InventoryCreateCategory(this);
                option.CategoryId = (int)category["category_id"];
                option.CategoryName = category["category_name"].ToString();

                flowLayoutPanelInventoryCreateCategory.Controls.Add(option);
            }
        }

        private void InventoryCreate_Load(object sender, EventArgs e)
        {
            populateInventoryCreateCategory();
        }

        private void buttonsInventoryCreateAddCategory_Click(object sender, EventArgs e)
        {
            categories = Program.DataTableQuery("select * from `category` order by `category_order`");

            Specification category = new Specification(this);
            category.SpecificationTitle = "Category";

            category.SpecificationTable = categories;

            category.ShowDialog();
        }

        private void buttonsTransactionClose_Click(object sender, EventArgs e)
        {
            _parent.CreateMode = false;
            _parent.populateInventoryContent();
        }

        private void buttonsAddSize_Click(object sender, EventArgs e)
        {
            Specification size = new Specification(this);
            size.SpecificationTitle = "Size";

            //get unique sizes
            DataTable itemSize = Program.DataTableQuery("select * from `size` order by `size_order`");
            
            size.SpecificationTable = itemSize;

            size.ShowDialog();
        }

        private void buttonsAddColor_Click(object sender, EventArgs e)
        {
            Specification color = new Specification(this);
            color.SpecificationTitle = "Color";

            //get unique colors
            DataTable itemColor = Program.DataTableQuery("select * from `color` order by `color_order`");

            color.SpecificationTable = itemColor;

            color.ShowDialog();
        }
    }
}
