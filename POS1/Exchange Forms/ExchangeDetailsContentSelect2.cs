using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace POS1.Exchange
{
    public partial class ExchangeDetailsContentSelect2 : Form
    {

        private int quantity = 0;
        private string itemId;
        private float subtotal;
        private float itemUnitPrice;
        private string itemSize;
        private string itemColor;
        private string itemName;
        private string fileExt;
        private int origQty;

        ExchangeDetails2 _parent;
        ExchangeDetailsContent2 _parent2;
        public ExchangeDetailsContentSelect2(ExchangeDetails2 parent, ExchangeDetailsContent2 parent2)
        {
            InitializeComponent();
            CheckOverLimit();
            origQty = quantity;
            _parent = parent;
            _parent2 = parent2;
        }

        public string ItemId
        {
            get { return itemId; }
            set { itemId = value; labelExchangeSelectClothesCode2.Text = "item no. " + value; }
        }

        public string ItemName
        {
            get { return itemName; }
            set { itemName = value; labelExchangeSelectClothesTitle2.Text = value; }
        }

        public string ItemSize
        {
            get { return itemSize; }
            set { itemSize = value; labelViewClothesSize.Text = "Size: " + value; }
        }

        public string ItemColor
        {
            get { return itemColor; }
            set { itemColor = value; ExchangeSelectColorLabel.Text = "Color: " + value; }
        }

        public int ItemQty
        {
            get { return quantity; }
            set { quantity = value; textBoxExchangeSelectClothesQuantity2.Text = value.ToString(); origQty = quantity; }
        }

        public float ItemUnitPrice
        {
            get { return itemUnitPrice; }
            set { itemUnitPrice = value; ExchangeSelectUnitPrice2.Text = value.ToString(); }
        }

        public string FileExt
        {
            get { return fileExt; }
            set { fileExt = value; }
        }

        public float Subtotal
        {
            get { return subtotal; }
            set { subtotal = value; labelExchangeSelectClothesPrice2.Text = subtotal.ToString(); }

        }

        private void ToggleAdd()
        {
            if (quantity != 0)
            {
                buttonsExchangeSelectClothesAdd2.Enabled = true;
                buttonsExchangeSelectClothesAdd2.BackgroundColor = Color.FromName("white");
            }
            else
            {
                buttonsExchangeSelectClothesAdd2.Enabled = false;
                buttonsExchangeSelectClothesAdd2.BackgroundColor = Color.FromName("Gainsboro");
            }
        }

        private void CheckNegative()
        {
            buttonsExchangeSelectClothesMinus2.Enabled = (quantity > 0);
            ToggleAdd();

            textBoxExchangeSelectClothesQuantity2.Text = quantity.ToString();
            labelExchangeSelectClothesPrice2.Text = subtotal.ToString("#,##0.00");
        }

        private void CheckOverLimit()
        {
            buttonsExchangeSelectClothesPlus2.Enabled = (quantity < origQty);
            ToggleAdd();

            textBoxExchangeSelectClothesQuantity2.Text = quantity.ToString();
            labelExchangeSelectClothesPrice2.Text = subtotal.ToString("#,##0.00");
        }

        private void buttonsExchangeSelectClothesPlus2_Click(object sender, EventArgs e)
        {
            quantity++;
            subtotal += itemUnitPrice;
            labelExchangeSelectClothesPrice2.Text = subtotal.ToString();
            ExchangeSelectUnitPrice2.Text = (subtotal * 0.05).ToString();
            CheckNegative();
            CheckOverLimit();
            //MessageBox.Show(quantity + " < " + origQty);
        }

        private void buttonsExchangeSelectClothesMinus2_Click(object sender, EventArgs e)
        {
            quantity--;
            subtotal -= itemUnitPrice;
            labelExchangeSelectClothesPrice2.Text = subtotal.ToString();
            ExchangeSelectUnitPrice2.Text = (subtotal * 0.05).ToString();
            CheckOverLimit();
            CheckNegative();

        }

        private void buttonsExchangeSelectClothesAdd2_Click(object sender, EventArgs e)
        {
            _parent.ExchangeDetailSubtotal = subtotal;
            _parent.ExchangeDetailSalesTax = float.Parse((subtotal * 0.05).ToString());
            _parent.ExchangeDetailTotal = float.Parse((subtotal + (subtotal * 0.05)).ToString());

            _parent2.ContentQuantity = int.Parse(textBoxExchangeSelectClothesQuantity2.Text);
        }
    }
}
