using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace POS1.Refund_Forms
{
    public partial class RefundDetailsContent : UserControl
    {

        private string contentTitle;
        private int contentCode;
        private string contentSize;
        private string contentColor;
        private float contentPrice;
        private string contentPhoto;
        private string contentPhotoExt;
        private int contentQuantity;

        RefundDetails _parent;

        public RefundDetailsContent(RefundDetails parentRefund)
        {
            InitializeComponent();
            _parent = parentRefund;
        }
        public string ContentTitle
        {
            get { return contentTitle; }
            set { contentTitle = value; labelRefundDetailsClothesTitle.Text = value; }
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
            set { contentCode = value; labelRefundDetailsClothesCode.Text = "Item ID: " + value; }
        }

        public string ContentSize
        {
            get { return contentSize; }
            set { contentSize = value; labelRefundDetailsClothesSize.Text = "Size: " + value; }
        }

        public float ContentPrice
        {
            get { return contentPrice; }
            set
            {
                contentPrice = value; labelRefundDetailsClothesPrice.Text = "Subtotal: " + value.ToString("#,##0.00");
                //if (_parent.detailType == "supply") labelRefundDetailsClothesPrice.Visible = false;
            }
        }

        public string ContentColor
        {
            get { return contentColor; }
            set { contentColor = value; labelRefundDetailsClothesColor.Text = "Color: " + value; }
        }

        public void SetImage()
        {
            if (contentCode <= 0 && contentPhotoExt != null)
            {
                pictureBoxRefundDetailsClothesImage.Image = Program.GetImage(contentCode.ToString(), contentPhotoExt);
            }
        }

        public int ContentQuantity
        {
            get { return contentQuantity; }
            set
            {
                contentQuantity = value;
                labelRefundDetailsClothesQuantity.Text = "Quantity: " + value;
            }
        }

        private void buttonsSelectRefundDetails_Click(object sender, EventArgs e)
        {     
            if (_parent.isFullRefund)
            {
                MessageBox.Show("You must be in Partial Refund mode in order to use this button.");
            }
            else
            {
                RefundDetailsContentSelect selectedContent = new RefundDetailsContentSelect(_parent);
                selectedContent.ItemId = contentCode.ToString();
                selectedContent.ItemName = contentTitle.ToString();
                selectedContent.Subtotal = (contentPrice);
                selectedContent.ItemUnitPrice = (contentPrice / contentQuantity);
                selectedContent.ItemSize = contentSize.ToString();
                selectedContent.ItemColor = contentColor.ToString();
                selectedContent.ItemQty = contentQuantity;
                selectedContent.FileExt = contentPhotoExt;
                selectedContent.pictureBoxRefundSelectClothesIcon.Image = Program.GetImage(contentCode.ToString(), contentPhotoExt);
                selectedContent.ShowDialog();
            }

            //MessageBox.Show(contentPrice.ToString() + " * " + Int32.Parse(contentQuantity).ToString());
        }
    }
}
