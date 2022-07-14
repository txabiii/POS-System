using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace POS1.Refund_Forms
{
    public partial class RefundDetailsContentRight : UserControl
    {
        private string itemId;
        private string itemName;
        private string itemSize;
        private string itemColor;
        private float itemUnitPrice;
        private int itemQty;
        private string fileExt;

        private RefundDetails _parent;

        public bool checkedBill;
        public string ItemId
        {
            get { return itemId; }
            set { itemId = value; labelRefundDetailsClothesCodeRight.Text = value; }
        }

        public string ItemName
        {
            get { return itemName; }
            set { itemName = value; labelRefundDetailsClothesTitleRight.Text = value; }
        }

        public string ItemSize
        {
            get { return itemSize; }
            set { itemSize = value; labelRefundDetailsClothesSizeRight.Text = "Size: " + value; }
        }

        public string ItemColor
        {
            get { return itemColor; }
            set { itemColor = value; labelRefundDetailsClothesColorRight.Text = "Color: " + value; }
        }

        public int ItemQty
        {
            get { return itemQty; }
            set { itemQty = value; labelRefundDetailsClothesQuantityRight.Text = value.ToString(); }
        }

        public float ItemUnitPrice
        {
            get { return itemUnitPrice; }
            set { itemUnitPrice = value; labelRefundDetailsClothesPriceRight.Text = value.ToString(); }
        }

        public string ItemFileExt
        {
            get { return fileExt; }
            set { fileExt = value; }
        }
        public RefundDetailsContentRight(RefundDetails parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        public bool CheckedBill
        {
            get { return checkedBill; }
            set { checkedBill = value; }
        }


        private void buttonsRefundDelete_Click(object sender, EventArgs e)
        {
            _parent.detailRightSubtotal -= itemUnitPrice;
            _parent.detailRightSalesTax -= (float)(itemUnitPrice * 0.05);
            _parent.detailRightTotal = _parent.detailRightSubtotal + _parent.detailRightSalesTax;
            this.Dispose();
        }
    }
}
