using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using POS1.POS_Controls;
using POS1.Forms;

namespace POS1.Refund_Forms
{
    public partial class RefundDetailsContentSelect : Form
    {

        private int quantity = 0;
        private string itemId;
        private float subtotal;
        private int itemQty;
        private float itemUnitPrice;
        private string itemSize;
        private string itemColor;
        private string itemName;
        private string selectedSizeId;
        private string selectedColorId;
        private string selectedSizeName;
        private string selectedColorName;
        private string fileExt;
        private int origQty;
        private float price;

        RefundDetails _parent = new RefundDetails();
        public RefundDetailsContentSelect(RefundDetails parentDetails)
        {
            InitializeComponent();
            CheckOverLimit();
            buttonsRefundSelectClothesAdd.Enabled = true;
            _parent = parentDetails;
        }

        public string ItemId
        {
            get { return itemId; }
            set { itemId = value; labelRefundSelectClothesCode.Text = "item no. " + value; }
        }

        public string ItemName
        {
            get { return itemName; }
            set { itemName = value; labelRefundSelectClothesTitle.Text = value; }
        }

        public string ItemSize
        {
            get { return itemSize; }
            set { itemSize = value; labelViewClothesSize.Text = "Size: " + value; }
        }

        public string ItemColor
        {
            get { return itemColor; }
            set { itemColor = value; RefundSelectColorLabel.Text = "Color: " + value; }
        }

        public int ItemQty
        {
            get { return quantity; }
            set { quantity = value; textBoxRefundSelectClothesQuantity.Text = value.ToString(); origQty = quantity; }
        }

        public float ItemUnitPrice
        {
            get { return itemUnitPrice; }
            set { itemUnitPrice = value; RefundSelectUnitPrice.Text = value.ToString(); }
        }

        public string FileExt
        {
            get { return fileExt; }
            set { fileExt = value; }
        }

        public float Subtotal
        {
            get { return subtotal; }
            set{ subtotal = value; labelRefundSelectClothesPrice.Text = subtotal.ToString(); }

        }

        //Methods


        private void ToggleAdd()
        {
            if (quantity != 0)
            {
                buttonsRefundSelectClothesAdd.Enabled = true;
                buttonsRefundSelectClothesAdd.BackgroundColor = Color.FromName("white");
            }
            else
            {
                buttonsRefundSelectClothesAdd.Enabled = false;
                buttonsRefundSelectClothesAdd.BackgroundColor = Color.FromName("Gainsboro");
            }
        }

        private void CheckNegative()
        {
            buttonsRefundSelectClothesMinus.Enabled = (quantity > 0);
            ToggleAdd();

            textBoxRefundSelectClothesQuantity.Text = quantity.ToString();
            labelRefundSelectClothesPrice.Text = subtotal.ToString("#,##0.00");
        }

        private void CheckOverLimit()
        {
            buttonsRefundSelectClothesPlus.Enabled = (quantity < origQty);
            ToggleAdd();

            textBoxRefundSelectClothesQuantity.Text = quantity.ToString();
            labelRefundSelectClothesPrice.Text = subtotal.ToString("#,##0.00");
        }
        private void buttonsRefundSelectClothesPlus_Click(object sender, EventArgs e)
        {
            quantity++;
            subtotal += itemUnitPrice;
            labelRefundSelectClothesPrice.Text = subtotal.ToString();
            CheckNegative();
            CheckOverLimit();
        }

        private void buttonsRefundSelectClothesMinus_Click(object sender, EventArgs e)
        {
            quantity--;
            subtotal -= itemUnitPrice;
            labelRefundSelectClothesPrice.Text = subtotal.ToString();
            CheckOverLimit();
            CheckNegative();
        }

        private void buttonsRefundSelectClothesAdd_Click(object sender, EventArgs e)
        {
            //set insert quantity
            int insertQuantity = quantity;

            //if quantity is 0, dont add bill
            if (insertQuantity == 0)
            {
                return;
            }

            RefundDetailsContentRight rightDetail = new RefundDetailsContentRight(_parent);
            rightDetail.ItemName = itemName;
            rightDetail.ItemId = itemId;
            rightDetail.ItemSize = itemSize;
            rightDetail.ItemColor = itemColor;
            rightDetail.ItemQty = quantity;
            rightDetail.ItemUnitPrice = itemUnitPrice * quantity;
            rightDetail.ItemFileExt = fileExt;
            rightDetail.pictureBoxRefundDetailsClothesImageRight.Image = Program.GetImage(ItemId.ToString(), fileExt);
            //MessageBox.Show(ItemId.ToString() + "." + fileExt);



            _parent.detailRightSubtotal += (itemUnitPrice * quantity);
            _parent.detailRightSalesTax += (float)((itemUnitPrice * quantity) * 0.05);
            _parent.detailRightTotal += (itemUnitPrice * quantity) + (float)((itemUnitPrice * quantity) * 0.05);
            MessageBox.Show(itemUnitPrice.ToString());

            _parent.flowLayoutPanelRefundDetailsRightMiddle.Controls.Add(rightDetail);
            Close();
        }

        private void textBoxRefundSelectClothesQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxRefundSelectClothesQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
