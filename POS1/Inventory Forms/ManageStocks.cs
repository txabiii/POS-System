using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace POS1.Inventory_Forms
{
    public partial class ManageStocks : Form
    {
        private int itemId;
        private string itemName;
        private int totalStock;
        private Boolean isNewItem;

        DataTable sizeOptions = Program.DataTableQuery("select * from `size` order by `size_order`");
        DataTable colorOptions = Program.DataTableQuery("select * from `color` order by `color_order`");

        public InventoryContent _parentInventoryContent;
        public InventoryCreatePerCategory _parentInventoryCreatePerCategory;

        public string ItemName
        {
            get { return itemName; }
            set { itemName = value; labelItemName.Text = value; }
        }

        public int ItemId
        {
            get { return itemId; }
            set { itemId = value; }
        }

        public int TotalStock
        {
            get { return totalStock; }
            set { totalStock = value; }
        }

        public Boolean IsNewItem
        {
            get { return isNewItem; }
            set { isNewItem = value; }
        }

        public ManageStocks(InventoryContent parentContent = null, InventoryCreatePerCategory parentCreate = null)
        {
            InitializeComponent();
            CenterToScreen();
            ManageStocksHeader.Height = 49;
            _parentInventoryContent = parentContent;
            _parentInventoryCreatePerCategory = parentCreate;
        }

        private void ManageStocks_Load(object sender, EventArgs e)
        {
            PopulateStocksContent();
        }

        private void PopulateStocksContent()
        {

            if (itemId != 0)
            {
                foreach (DataRow itemSpec in Program.itemSpec.Rows)
                {
                    if (itemId == (int)itemSpec["item_id"])
                    {
                        ManageStockContent content = new ManageStockContent(this);
                        content.ReadOnly = true;
                        content.StockColorName = itemSpec["color_name"].ToString();
                        content.StockSizeName = itemSpec["size_name"].ToString();
                        content.StockSizeId = (int)itemSpec["size_id"];
                        content.StockColorId = (int)itemSpec["color_id"];
                        content.InitialStock = (int)itemSpec["stock"];
                        content.SizeOptions = sizeOptions;
                        content.ColorOptions = colorOptions;
                        ManageStocksContentPanel.Controls.Add(content);
                        ManageStocksContentPanel.Controls.SetChildIndex(content, 0);
                    }
                }
            }
        }

        private void buttons2_Click(object sender, EventArgs e)
        {
            int max = ManageStocksContentPanel.Controls.Count;
            ManageStockContent content = new ManageStockContent(this);
            content.SizeOptions = sizeOptions;
            content.ColorOptions = colorOptions;
            content.ReadOnly = false;
            content.InitialStock = 0;
            ManageStocksContentPanel.Controls.Add(content);
            ManageStocksContentPanel.Controls.SetChildIndex(content, max-1);
        }

        private void buttons1_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        public void ClearAll()
        {
            int max = ManageStocksContentPanel.Controls.Count - 2;
            for (int i = max; i > -1; i--)
            {
                ManageStockContent content = (ManageStockContent)ManageStocksContentPanel.Controls[i];
                if (content.readOnly)
                {
                    content.changeStock(-content.FinalStock);
                }
                else content.Dispose();
            }
        }

        private void buttonStocksConfirm_Click(object sender, EventArgs e)
        {
            if (isNewItem)
            {
                if (_parentInventoryCreatePerCategory != null) _parentInventoryCreatePerCategory.ItemStock = checkCurrentStock();
                Close();
                return;
            }
            Confirm();
        }

        public void Confirm()
        {
            //make sure item id exists
            if (itemId == 0) 
            {
                MessageBox.Show("No item id");
                return;
            }

            //setup datatables to store info for sql
            DataTable addStocksTable = new DataTable();
            addStocksTable.Columns.Add("color_id");
            addStocksTable.Columns["color_id"].DataType = typeof(int);
            addStocksTable.Columns.Add("size_id");
            addStocksTable.Columns["size_id"].DataType = typeof(int);
            addStocksTable.Columns.Add("quantity");
            addStocksTable.Columns["quantity"].DataType = typeof(int);
            addStocksTable.Columns.Add("new");
            addStocksTable.Columns["new"].DataType = typeof(Boolean);

            DataTable removeStocksTable = addStocksTable.Clone();

            addStocksTable.Rows.Clear();
            removeStocksTable.Rows.Clear();

            //iterate through the contents
            for (int i = 0; i < ManageStocksContentPanel.Controls.Count - 1; i++)
            {
                ManageStockContent content = (ManageStockContent)ManageStocksContentPanel.Controls[i];
                //if content is readonly just check the changes in stock
                if (content.readOnly)
                {
                    if (content.FinalStock < content.InitialStock)
                    {
                        //remove
                        removeStocksTable.Rows.Add(content.StockColorId, content.StockSizeId, content.InitialStock - content.FinalStock, false);
                    }
                    else if (content.FinalStock > content.InitialStock)
                    {
                        //add
                        addStocksTable.Rows.Add(content.StockColorId, content.StockSizeId, content.FinalStock - content.InitialStock, false);
                    }
                }
                //if content is not readonly and color and size had to be selected by user
                else
                {
                    //make sure all required fields are not empty
                    if (content.StockColorId != 0 && content.StockSizeId != 0 && content.FinalStock != 0)
                    {/*
                        //check if combination of colorid and size id already exists
                        int existingId = 0;
                        for (int j = 0; j < addStocksTable.Rows.Count; j++)
                        {
                            if ((int)addStocksTable.Rows[j]["color_id"] == content.StockColorId && (int)addStocksTable.Rows[j]["size_id"] == content.StockSizeId)
                            {
                                existingId = j;
                            }
                        }

                        if (existingId != 0)
                        {
                            //just add to quantity
                            addStocksTable.Rows[existingId]["quantity"] = (int)addStocksTable.Rows[existingId]["quantity"] + content.FinalStock;
                        }
                        else
                        {
                            //add new row
                            addStocksTable.Rows.Add(content.StockColorId, content.StockSizeId, content.FinalStock - content.InitialStock, true);
                        }*/
                        addStocksTable.Rows.Add(content.StockColorId, content.StockSizeId, content.FinalStock - content.InitialStock, true);
                    }
                }
            }

            //if there are stocks to be added
            if (addStocksTable.Rows.Count > 0)
            {
                Program.AddStocks(addStocksTable, itemId, true);
            }

            //if there are stocks to be removed
            if (removeStocksTable.Rows.Count > 0)
            {
                Program.AddStocks(removeStocksTable, itemId, false, textBoxRemarks.Text);
            }

            //reset inventory
            if(_parentInventoryContent != null) _parentInventoryContent._parent.populateInventoryContent();
            Close();
            Dispose();
        }

        public void checkStockChanges()
        {
            //iterate through the contents avoiding the first(conditional) and last
            int currentStock = 0;

            for (int i = 0; i < ManageStocksContentPanel.Controls.Count - 1; i++)
            {
                ManageStockContent content = (ManageStockContent)ManageStocksContentPanel.Controls[i];
                if (content.readOnly)
                {
                    currentStock += content.FinalStock;
                }
            }

            if (currentStock < totalStock)
            {
                panelRemarks.Visible = true;
                labelQuantity.Text = (currentStock - totalStock).ToString() + " stocks";
                ManageStocksHeader.Height = 146;
            } else
            {
                panelRemarks.Visible = false;
                ManageStocksHeader.Height = 49;
            }
            //MessageBox.Show(currentStock.ToString() + " & " + totalStock.ToString());
        }

        private int checkCurrentStock()
        {
            int result = 0;
            
            for (int i = 0; i < ManageStocksContentPanel.Controls.Count - 1; i++)
            {
                ManageStockContent content = (ManageStockContent)ManageStocksContentPanel.Controls[i];
                result += content.FinalStock;
            }
            return result;
        }
    }
}
