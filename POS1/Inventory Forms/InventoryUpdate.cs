using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace POS1.Inventory_Forms
{
    public partial class InventoryUpdate : UserControl
    {

        public InventoryContent _parent;

        private string itemName;
        private string itemId;
        private string itemDescription;
        private string itemCategory;
        private string itemSellerName;
        private double itemSupplierPrice;
        private double itemSellingPrice;
        private string itemFileExt;

        ManageStocks manageStocksMain;

        public InventoryUpdate(InventoryContent inventoryContent, ManageStocks manageStocks)
        {
            InitializeComponent();
            _parent = inventoryContent;
            manageStocksMain = manageStocks;
            pictureBoxInventoryUpdateImage.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        public string ItemName
        {
            get { return itemName; }
            set { itemName = value; textBoxItemName.Text = value; }
        }

        public string ItemId
        {
            get { return itemId; }
            set { itemId = value; textBoxItemId.Text = value; }
        }

        public string ItemDescription
        {
            get { return itemDescription; }
            set { itemDescription = value; textBoxDescription.Text = value; }
        }

        public string ItemCategory
        {
            get { return itemCategory; }
            set { itemCategory = value; textBoxCategory.Text = value; }
        }

        public string ItemSellerName
        {
            get { return itemSellerName; }
            set { itemSellerName = value; textBoxSeller.Text = value; }
        }

        public double ItemSupplierPrice
        {
            get { return itemSupplierPrice; }
            set { itemSupplierPrice = value; textBoxSupplierPrice.Text = value.ToString(); }
        }

        public double ItemSellingPrice
        {
            get { return itemSellingPrice; }
            set { itemSellingPrice = value; textBoxSellingPrice.Text = value.ToString(); }
        }

        public string ItemFileExt
        {
            get { return itemFileExt; }
            set { itemFileExt = value; pictureBoxInventoryUpdateImage.Image = Program.GetImage(itemId.ToString(), value); }
        }


        private void textBoxInventoryUpdateCategory_TextChanged(object sender, EventArgs e)
        {

        }
        private void buttonsTransactionClose_Click(object sender, EventArgs e)
        {
            _parent.resetInventoryForm();
        }

        private void buttonChangePhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            open.Filter = "Image Files(*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBoxInventoryUpdateImage.Image = new Bitmap(open.FileName);
                itemFileExt = Path.GetExtension(open.FileName).Substring(1);
            }
        }

        private int determineCategory(String itemCategoryString)
        {
            if (itemCategoryString.ToLower().Equals("men"))
            {
                return 1;
            }
            else if (itemCategoryString.ToLower().Equals("women"))
            {
                return 2;
            }
            else if (itemCategoryString.ToLower().Equals("kids"))
            {
                return 3;
            }
            else
            {
                return 0;
            }
        }

        private void buttonsInventoryUpdateSave_Click(object sender, EventArgs e)
        {
            Program.UpdateItem(int.Parse(textBoxItemId.Text), determineCategory(textBoxCategory.Text), textBoxItemName.Text, float.Parse(textBoxSellingPrice.Text), float.Parse(textBoxSupplierPrice.Text), textBoxSeller.Text, textBoxDescription.Text, itemFileExt);

            DirectoryInfo baseDir = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);

            try
            {
                if (itemFileExt == "jpeg" || itemFileExt == "jpg")
                {
                    pictureBoxInventoryUpdateImage.Image.Save(baseDir + @"ItemImages\" + int.Parse(textBoxItemId.Text) + "." + itemFileExt, ImageFormat.Jpeg);
                }
                else if (itemFileExt == "png")
                {
                    pictureBoxInventoryUpdateImage.Image.Save(baseDir + @"ItemImages\" + int.Parse(textBoxItemId.Text) + "." + itemFileExt, ImageFormat.Png);
                }
                else if (itemFileExt == "gif")
                {
                    pictureBoxInventoryUpdateImage.Image.Save(baseDir + @"ItemImages\" + int.Parse(textBoxItemId.Text) + "." + itemFileExt, ImageFormat.Gif);
                }
                else if (itemFileExt == "bmp")
                {
                    pictureBoxInventoryUpdateImage.Image.Save(baseDir + @"ItemImages\" + int.Parse(textBoxItemId.Text) + "." + itemFileExt, ImageFormat.Bmp);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Failed to save image\n" + "Error details: " + error.ToString());
            }
        }

        private void labelAddStocks_Click(object sender, EventArgs e)
        {
            manageStocksMain.ShowDialog();
        }
    }
}
