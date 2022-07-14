using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace POS1.Inventory_Forms
{
    public partial class InventoryContent : UserControl
    {
        private string itemName;
        private int itemId;
        private string itemDescription;
        private float itemPrice;
        private string itemCategory;
        private DateTime itemDate;
        private int itemStock;
        private string itemFileExt;

        public InventoryForm _parent;

        public string ItemName
        {
            get { return itemName; }
            set { itemName = value; labelClothesDetailsTitle.Text = value; }
        }

        public int ItemId
        {
            get { return itemId; }
            set { itemId = value; labelClothesDetailsCode.Text = "item no. " + value.ToString(); }
        }

        public string ItemDescription
        {
            get { return itemDescription; }
            set { itemDescription = value; labelClothesDetailsDescription.Text = value; }
        }

        public float ItemPrice
        {
            get { return itemPrice; }
            set { itemPrice = value; labelClothesDetailsPrice.Text = value.ToString(); }
        }

        public string ItemCategory
        {
            get { return itemCategory; }
            set { itemCategory = value; labelInventoryContentCategory.Text = value; }
        }

        public DateTime ItemDate
        {
            get { return itemDate; }
            set { itemDate = value; labelInventoryContentDateAdded.Text = value.ToString("MMM. dd, yyyy"); }
        }

        public int ItemStock
        {
            get { return itemStock; }
            set { itemStock = value; labelInventoryContentStocks.Text = value.ToString(); }
        }

        public string ItemFileExt
        {
            get { return itemFileExt; }
            set { itemFileExt = value; pictureBoxInventoryContentImage.Image = Program.GetImage(itemId.ToString(), value); }
        }

        public InventoryContent(InventoryForm parentForm)
        {
            InitializeComponent();
            _parent = parentForm;
        }

        private void buttonsInventoryContentUpdate_Click(object sender, EventArgs e)
        {

        }

        private void labelInventoryContentStocks_Click(object sender, EventArgs e)
        {
            ManageStocks manageStocks = new ManageStocks(this);
            manageStocks.ItemId = itemId;
            manageStocks.ItemName = itemName;
            manageStocks.TotalStock = itemStock;
            manageStocks.ShowDialog();
        }

        public void resetInventoryForm()
        {
            _parent.populateInventoryContent();
        }

        private void buttonsInventoryContentDelete_Click(object sender, EventArgs e)
        {
            DirectoryInfo baseDir = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);

            if (Program.DeleteItem(itemId))
            {
                _parent.populateInventoryContent();
                if (File.Exists(baseDir + @"ItemImages\" + itemId + "." + itemFileExt))
                {
                    System.GC.Collect();
                    System.GC.WaitForPendingFinalizers();
                    File.Delete(baseDir + @"ItemImages\" + itemId + "." + itemFileExt);
                }
            }
        }

        private void buttonsInventoryContentUpdate_Click_1(object sender, EventArgs e)
        {
            DataTable contentData = Program.DataTableQuery("select `item`.`item_id`, `item_name`, `description`, " +
                    "`category`.`category_name`, `item_spec`.`stock`, `supplier_name`, `supplier_price`, " +
                    "`selling_price`, `item_spec`.`item_spec_id`, `item`.`file_ext` from `item`" +
                    "inner join `item_spec` on `item`.`item_id` = `item_spec`.`item_id`" +
                    "inner join `category` on `item`.`category_id` = `category`.`category_id`" +
                    "where `item`.`item_id` = " + ItemId);

            DataRow[] rows = contentData.Select("`item_id`=" + ItemId);

            ManageStocks manageStocks = new ManageStocks(this);
            manageStocks.ItemId = itemId;
            manageStocks.ItemName = itemName;
            manageStocks.TotalStock = itemStock;

            InventoryUpdate inventoryUpdate = new InventoryUpdate(this, manageStocks);
            inventoryUpdate.ItemName = (rows[0]["item_name"].ToString());
            inventoryUpdate.ItemId = ItemId.ToString();
            inventoryUpdate.ItemDescription = (rows[0]["description"].ToString());
            inventoryUpdate.ItemCategory = (rows[0]["category_name"].ToString());
            inventoryUpdate.ItemSellerName = (rows[0]["supplier_name"].ToString());
            inventoryUpdate.ItemSupplierPrice = double.Parse((rows[0]["supplier_price"].ToString()));
            inventoryUpdate.ItemSellingPrice = double.Parse((rows[0]["selling_price"].ToString()));
            inventoryUpdate.ItemFileExt = (rows[0]["file_ext"].ToString());

            _parent.showInventoryUpdate(inventoryUpdate);
        }
    }
}
