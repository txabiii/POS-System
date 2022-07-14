using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace POS1.Exchange
{
    public partial class ExchangeDetailsContent2 : UserControl
    {

        private string contentTitle;
        private int contentCode;
        private string contentSize;
        private string contentColor;
        private float contentPrice;
        private string contentPhoto;
        private string contentPhotoExt;
        private int contentQuantity;

        public bool checkedBill;

        ExchangeDetails2 _parent;
        public ExchangeDetailsContent2(ExchangeDetails2 parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        public string ContentTitle
        {
            get { return contentTitle; }
            set { contentTitle = value; labelExchangeDetailsClothesTitle2.Text = value; }
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
            set { contentCode = value; labelExchangeDetailsClothesCode2.Text = "Item ID: " + value; }
        }

        public string ContentSize
        {
            get { return contentSize; }
            set { contentSize = value; labelExchangeDetailsClothesSize2.Text = "Size: " + value; }
        }

        public float ContentPrice
        {
            get { return contentPrice; }
            set
            {
                contentPrice = value; labelExchangeDetailsClothesPrice2.Text = "Subtotal: " + value.ToString("#,##0.00");
                //if (_parent.detailType == "supply") labelRefundDetailsClothesPrice.Visible = false;
            }
        }

        public string ContentColor
        {
            get { return contentColor; }
            set { contentColor = value; labelExchangeDetailsClothesColor2.Text = "Color: " + value; }
        }

        public bool CheckedBill
        {
            get { return checkedBill; }
            set { checkedBill = value;  }
        }

        public void SetImage()
        {
            if (contentCode <= 0 && contentPhotoExt != null)
            {
                pictureBoxExchangeDetailsClothesImage2.Image = Program.GetImage(contentCode.ToString(), contentPhotoExt);
            }
        }

        public int ContentQuantity
        {
            get { return contentQuantity; }
            set
            {
                contentQuantity = value;
                labelExchangeDetailsClothesQuantity2.Text = "Quantity: " + value;
            }
        }

        private void buttonsSelectExchangeDetails_Click(object sender, EventArgs e)
        {
            _parent.buttonsFullExchange.BackColor = Color.FromArgb(178, 178, 178);
            _parent.flowLayoutPanelExchangeDetailsRightMiddle.Controls.Clear();
            ExchangeDetailsContentSelect2 selectedContent = new ExchangeDetailsContentSelect2(_parent, this);
            selectedContent.ItemId = contentCode.ToString();
            selectedContent.ItemName = contentTitle.ToString();
            selectedContent.Subtotal = (contentPrice);
            selectedContent.ItemUnitPrice = (contentPrice / contentQuantity);
            selectedContent.ItemSize = contentSize.ToString();
            selectedContent.ItemColor = contentColor.ToString();
            selectedContent.ItemQty = contentQuantity;
            selectedContent.FileExt = contentPhotoExt;
            selectedContent.pictureBoxExchangeSelectClothesIcon2.Image = Program.GetImage(contentCode.ToString(), contentPhotoExt);           
            selectedContent.ShowDialog();
        }
    }
}
