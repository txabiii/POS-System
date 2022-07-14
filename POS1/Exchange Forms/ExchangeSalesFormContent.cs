using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using POS1.Exchange;

namespace POS1.Exchange_Forms
{
    public partial class ExchangeSalesFormContent : UserControl
    {

        private string clothesTitle;
        private string clothesCode;
        private string clothesStocks;
        private string clothesPrice;
        private string clothesFileExt;
        public ExchangeDetails2 _parent;

        public ExchangeSalesFormContent(ExchangeDetails2 parentForm)
        {
            _parent = parentForm;
            //MessageBox.Show(_parent.ToString());
            InitializeComponent();
            pictureBoxClothes.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        [Category("Custom Props")]
        public string ClothesTitle
        {
            get { return clothesTitle; }
            set { clothesTitle = value; labelSalesItemsTitle.Text = value; }
        }

        [Category("Custom Props")]
        public string ClothesCode
        {
            get { return clothesCode; }
            set { clothesCode = value; labelSalesItemsCode.Text = "item no." + value; }
        }

        [Category("Custom Props")]
        public string ClothesStocks
        {
            get { return clothesStocks; }
            set { clothesStocks = value; labelSalesItemsStocks.Text = "x" + value; }
        }

        [Category("Custom Props")]
        public string ClothesPrice
        {
            get { return clothesPrice; }
            set { clothesPrice = value; labelSalesItemsPrice.Text = value; }
        }

        [Category("Custom Props")]
        public string ClothesFileExt
        {
            get { return clothesFileExt; }
            set { clothesFileExt = value; SetImage(); }
        }

        private void buttonsSalesItemsView_Click(object sender, EventArgs e)
        {
            if (!POS1.Forms.SalesForm.receiptPrinted)
            {
                MessageBox.Show("Print the receipt of the previous transaction first before proceeding");
                return;
            }
            //ViewSalesContent viewSales = new ViewSalesContent(this);
            //formViewClothes.ItemId = clothesCode;
            //formViewClothes.FileExt = clothesFileExt;
            //formViewClothes.labelViewClothesTitle.Text = clothesTitle;
            //formViewClothes.Subtotal = float.Parse(clothesPrice);

            //formViewClothes.pictureBoxViewClothesIcon.Image = Program.GetImage(clothesCode, clothesFileExt);

            //formViewClothes.ShowDialog();
        }

        private void SetImage()
        {
            pictureBoxClothes.Image = Program.GetImage(clothesCode, clothesFileExt);
        }

        private void buttonsSalesItemsView_Click_1(object sender, EventArgs e)
        {
            //_parent.Dispose();
            AddClothes viewAdd = new AddClothes(_parent);
            viewAdd.ItemId = clothesCode;
            viewAdd.FileExt = clothesFileExt;
            viewAdd.labelViewClothesTitle.Text = clothesTitle;
            viewAdd.Subtotal = float.Parse(clothesPrice);

            viewAdd.pictureBoxViewClothesIcon.Image = Program.GetImage(clothesCode, clothesFileExt);



            viewAdd.ShowDialog();

        }
    }
}
