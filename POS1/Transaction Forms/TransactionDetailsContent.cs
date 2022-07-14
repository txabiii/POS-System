using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace POS1.Transaction_Forms
{

    public partial class TransactionDetailsContent : UserControl
    {

        private string contentTitle;
        private int contentCode;
        private string contentSize;
        private string contentColor;
        private float contentPrice;
        private string contentPhoto;
        private string contentPhotoExt;
        private string contentQuantity;

        TransactionDetails _parent;

        public TransactionDetailsContent(TransactionDetails parentTransaction)
        {
            InitializeComponent();
            _parent = parentTransaction;
        }

        public string ContentTitle
        {
            get { return contentTitle; }
            set { contentTitle = value; labelTransactionDetailsClothesTitle.Text = value; }
        }

        public string ContentPhoto
        {
            get { return contentPhoto; }
            set { contentPhoto = value; }
        }

        public string ContentPhotoExt
        {
            get { return contentPhotoExt; }
            set { contentPhotoExt = value; SetImage(); }
        }

        public int ContentCode
        {
            get { return contentCode; }
            set { contentCode = value; labelTransactionDetailsClothesCode.Text = "Item ID: " + value; }
        }

        public string ContentSize
        {
            get { return contentSize; }
            set { contentSize = value; labelTransactionDetailsClothesSize.Text = "Size: " + value; }
        }

        public float ContentPrice
        {
            get { return contentPrice; }
            set { contentPrice = value; labelTransactionDetailsClothesPrice.Text = "Subtotal: " + value.ToString("#,##0.00");
                if (_parent.detailType == "supply") labelTransactionDetailsClothesPrice.Visible = false;
            }
        }

        public string ContentColor
        {
            get { return contentColor; }
            set { contentColor = value; labelTransactionDetailsClothesColor.Text = "Color: " + value; }
        }

        public void SetImage()
        {
            if (contentCode <= 0 && contentPhotoExt != null)
            {
                pictureBoxTransactionDetailsClothesImage.Image = Program.GetImage(contentCode.ToString(), contentPhotoExt);
            }
        }

        public string ContentQuantity
        {
            get { return contentQuantity; }
            set { contentQuantity = value;
                if (_parent.detailType == "supply" && !_parent.TransactionStockAdded) value = "-" + value;
                labelTransactionDetailsClothesQuantity.Text = "Quantity: " + value;
            }
        }
    }
}
