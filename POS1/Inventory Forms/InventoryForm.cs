using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace POS1.Inventory_Forms
{
    public partial class InventoryForm : Form
    {
        private int currentPage = 1;
        private int resultsPerPage = 5;
        private int totalPages = 0;
        private bool createMode;

        private int filterSearch;
        private int filterCategory;
        private bool? orderAlphabetical = null;
        private bool? orderPrice = null;
        private bool? orderDate = null;

        InventoryFilter inventoryFilter;

        public InventoryForm()
        {
            InitializeComponent();
            inventoryFilter = new InventoryFilter(this);
        }

        public bool CreateMode
        {
            get { return createMode; }
            set { createMode = value; }
        }

        public bool? OrderAlphabetical
        {
            get { return orderAlphabetical; }
            set { orderAlphabetical = value; }
        }

        public bool? OrderPrice
        {
            get { return orderPrice; }
            set { orderPrice = value; }
        }

        public bool? OrderDate
        {
            get { return orderDate; }
            set { orderDate = value; }
        }

        public int FilterCategory
        {
            get { return filterCategory; }
            set { filterCategory = value; }
        }

        public int FilterSearch
        {
            get { return filterSearch; }
            set { filterSearch = value; }
        }

        public void showInventoryUpdate(InventoryUpdate inventoryUpdate)
        {
            inventoryContentTable.Visible = false;
            panelInventoryBottom.Visible = false;
            flowLayoutPanelInventoryContents.Controls.Clear();
            inventoryUpdate.Width = flowLayoutPanelInventoryContents.Width - 100;
            inventoryUpdate.Height = flowLayoutPanelInventoryContents.Height - 400;
            flowLayoutPanelInventoryContents.Controls.Add(inventoryUpdate);
        }

        public void populateInventoryContent()
        {
            inventoryContentTable.Visible = true;
            panelInventoryBottom.Visible = true;

            //clear panel
            flowLayoutPanelInventoryContents.Controls.Clear();

            //get search id
            if (!string.IsNullOrEmpty(textBoxInventorySearch.Text))
            {
                if (int.TryParse(textBoxInventorySearch.Text, out int input))
                {
                    filterSearch = input;
                }
                else 
                {
                    filterSearch = 0;
                    MessageBox.Show("Invalid search input");
                }
            }
            else filterSearch = 0;

            //get items
            Program.GetItems(currentPage, resultsPerPage, orderAlphabetical, orderPrice, orderDate, filterCategory, filterSearch);

            int totalItems = int.Parse(Program.DataTableQuery("select count(*) from `item`").Rows[0][0].ToString());
            totalPages = totalItems / resultsPerPage + Convert.ToInt32((totalItems % resultsPerPage) != 0);

            if (currentPage > totalPages) currentPage = totalPages;

            pageInputInventoryForm.PlaceholderText = currentPage + " of " + totalPages;

            if (totalItems > 0)
            {
                DataTable displayItems = Program.item;

                foreach (DataRow item in displayItems.Rows)
                {
                    InventoryContent content = new InventoryContent(this);
                    content.ItemName = item["item_name"].ToString();
                    content.ItemId = (int)item["item_id"];
                    content.ItemDescription = item["description"].ToString();
                    content.ItemPrice = float.Parse(item["selling_price"].ToString());
                    content.ItemCategory = item["category_name"].ToString();
                    content.ItemDate = DateTime.Parse(item["date_added"].ToString());

                    if (int.TryParse(item["stock"].ToString(), out int result)) content.ItemStock = result;
                    else content.ItemStock = 0;

                    content.ItemFileExt = item["file_ext"].ToString();

                    content.Width = flowLayoutPanelInventoryContents.Width - 40;
                    flowLayoutPanelInventoryContents.Controls.Add(content);
                }
            }
        }

        private void InventoryForm_Load(object sender, EventArgs e)
        {
            populateInventoryContent();
        }

        private void buttonsInventoryFilter_Click(object sender, EventArgs e)
        {
            //InventoryFilter inventoryFilter = new InventoryFilter(this);
            inventoryFilter.ShowDialog();
        }

        private void pageInputInventoryForm_MouseLeave(object sender, EventArgs e)
        {
            panelInventoryBottom.Focus();
            pageInputInventoryForm.Clear();
        }

        private void pageInputInventoryForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                panelInventoryBottom.Focus();
                pageInputInventoryForm.Clear();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                //input has to be an int and not whitespace
                if (!String.IsNullOrWhiteSpace(pageInputInventoryForm.Text) && int.TryParse(pageInputInventoryForm.Text, out int result))
                {
                    //input has to be in range
                    if (result > 0 && result <= totalPages)
                    {
                        currentPage = result;
                    }
                    else return;
                }
                else return;

                populateInventoryContent();
            }
        }

        private void pageInputInventoryForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void pageDisplayInventoryForm_Paint(object sender, PaintEventArgs e)
        {
            pageInputInventoryForm.Left = pageDisplayInventoryForm.Left + 2;
            pageInputInventoryForm.Width = pageDisplayInventoryForm.Width - 2;
        }

        private void previousButtonInventoryForm_Click(object sender, EventArgs e)
        {
            if (currentPage == 1)
            {
                return;
            }
            else currentPage--;

            populateInventoryContent();
        }

        private void firstButtonInventoryForm_Click(object sender, EventArgs e)
        {
            if (currentPage == 1)
            {
                return;
            }
            else currentPage = 1;

            populateInventoryContent();
        }

        private void nextButtonInventoryForm_Click(object sender, EventArgs e)
        {
            if (currentPage == totalPages)
            {
                return;
            }
            else currentPage++;

            populateInventoryContent();
        }

        private void lastButtonInventoryForm_Click(object sender, EventArgs e)
        {
            if (currentPage == totalPages)
            {
                return;
            }
            else currentPage = totalPages;

            populateInventoryContent();
        }

        private void buttonsInventoryCreate_Click_1(object sender, EventArgs e)
        {
            createItems();
        }

        private void pictureBoxInventoryCreateIcon_Click(object sender, EventArgs e)
        {
            createItems();
        }

        public void createItems()
        {
            if (!createMode)
            {
                InventoryCreate create = new InventoryCreate(this);
                panelInventoryBottom.Visible = false;
                create.Width = flowLayoutPanelInventoryContents.Width - 30;
                create.Height = flowLayoutPanelInventoryContents.Height - 106;
                inventoryContentTable.Visible = false;
                flowLayoutPanelInventoryContents.Controls.Clear();
                flowLayoutPanelInventoryContents.Controls.Add(create);
                createMode = true;
            }
        }

        private void textBoxInventorySearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxInventorySearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                populateInventoryContent();
            }
        }
    }
}
