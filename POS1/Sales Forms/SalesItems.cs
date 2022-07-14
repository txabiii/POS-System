using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using POS1.Forms;

namespace POS1.Sales_Forms
{
    public partial class SalesItems : UserControl
    {
        // Fields
        private string clothesTitle;
        private string clothesCode;
        private string clothesStocks;
        private string clothesPrice;
        private string clothesFileExt;
        public SalesForm _parent;

        public SalesItems(SalesForm parentForm)
        {
            InitializeComponent();
            _parent = parentForm;
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
            ViewClothes formViewClothes = new ViewClothes(this);
            formViewClothes.ItemId = clothesCode;
            formViewClothes.FileExt = clothesFileExt;
            formViewClothes.labelViewClothesTitle.Text = clothesTitle;
            formViewClothes.Subtotal = float.Parse(clothesPrice);

            formViewClothes.pictureBoxViewClothesIcon.Image = Program.GetImage(clothesCode, clothesFileExt);

            formViewClothes.ShowDialog();
        }

        private void SetImage()
        {
            pictureBoxClothes.Image = Program.GetImage(clothesCode, clothesFileExt);
        }

        private void SalesItems_Load(object sender, EventArgs e)
        {

        }

        private void pictureBoxClothes_Click(object sender, EventArgs e)
        {

        }
    }
}
