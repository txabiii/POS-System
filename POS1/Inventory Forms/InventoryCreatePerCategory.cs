using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace POS1.Inventory_Forms
{
    public partial class InventoryCreatePerCategory : UserControl
    {
        InventoryCreateCategory _parent;
        ManageStocks stocks;
        private string itemCategory;
        private int itemCategoryId;
        private string fileExt;
        private int itemStock;

        public string ItemCategory
        {
            get { return itemCategory; }
            set { itemCategory = value; textBoxCategory.Text = value; }
        }

        public int ItemCategoryId
        {
            get { return itemCategoryId; }
            set { itemCategoryId = value; }
        }

        public int ItemStock
        {
            get { return itemStock; }
            set { itemStock = value; labelAddStocks.Text = value.ToString(); }
        }

        public InventoryCreatePerCategory(InventoryCreateCategory parentForm)
        {
            InitializeComponent();
            _parent = parentForm;
            stocks = new ManageStocks(null, this);
            stocks.IsNewItem = true;
        }

        private void buttonsTransactionClose_Click(object sender, EventArgs e)
        {
            _parent._parent._parent.createItems();
        }

        private void buttonUploadPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            open.Filter = "Image Files(*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBoxInventoryCreatePerCategoryImage.Image = new Bitmap(open.FileName);
                fileExt = Path.GetExtension(open.FileName).Substring(1);
                buttonUploadPhoto.Visible = false;
                buttonRemove.Visible = true;
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            RemoveImage();
        }

        private void RemoveImage()
        {
            pictureBoxInventoryCreatePerCategoryImage.Image = null;
            fileExt = null;
            buttonUploadPhoto.Visible = true;
            buttonRemove.Visible = false;
        }

        private void labelClear_Click(object sender, EventArgs e)
        {
            RemoveImage();
            stocks.ClearAll();
            textBoxItemName.Text = "";
            textBoxDescription.Text = "";
            textBoxSellerName.Text = "";
            textBoxSellingPrice.Text = "";
            textBoxSupplierPrice.Text = "";
            labelAddStocks.Text = "Click here to add stocks";
        }

        private void buttonsCreate_Click(object sender, EventArgs e)
        {
            if (pictureBoxInventoryCreatePerCategoryImage.Image != null && textBoxItemName.Text != "" && textBoxDescription.Text != "" && textBoxItemName.Text != ""
                && textBoxSellerName.Text != "" && textBoxSellingPrice.Text != "" && textBoxSupplierPrice.Text != "" && fileExt != null)
            {
                if (float.TryParse(textBoxSellingPrice.Text, out float sellingPrice) && float.TryParse(textBoxSupplierPrice.Text, out float supplierPrice))
                {
                    int newItemId = Program.CreateItem(itemCategoryId, textBoxItemName.Text, sellingPrice, supplierPrice, textBoxSellerName.Text, textBoxDescription.Text, fileExt);

                    //save image with the new item id as filename
                    DirectoryInfo baseDir = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);

                    try
                    {
                        if (fileExt == "jpeg" || fileExt == "jpg")
                        {
                            pictureBoxInventoryCreatePerCategoryImage.Image.Save(baseDir + @"ItemImages\" + newItemId + "." + fileExt, ImageFormat.Jpeg);
                        }
                        else if (fileExt == "png")
                        {
                            pictureBoxInventoryCreatePerCategoryImage.Image.Save(baseDir + @"ItemImages\" + newItemId + "." + fileExt, ImageFormat.Png);
                        }
                        else if (fileExt == "gif")
                        {
                            pictureBoxInventoryCreatePerCategoryImage.Image.Save(baseDir + @"ItemImages\" + newItemId + "." + fileExt, ImageFormat.Gif);
                        }
                        else if (fileExt == "bmp")
                        {
                            pictureBoxInventoryCreatePerCategoryImage.Image.Save(baseDir + @"ItemImages\" + newItemId + "." + fileExt, ImageFormat.Bmp);
                        }
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Failed to save image\n" + "Error details: " + error.ToString());
                    }

                    stocks.ItemId = newItemId;
                    stocks.Confirm();

                    _parent._parent._parent.populateInventoryContent();
                }
                else
                {
                    MessageBox.Show("Invalid input for selling price and/or supplier price");
                    return;
                }
            } 
            else
            {
                MessageBox.Show("Incomplete details");
                return;
            }
        }

        private void labelAddStocks_Click(object sender, EventArgs e)
        {
            stocks.ItemName = textBoxItemName.Text;
            stocks.ShowDialog();
        }
    }
}
