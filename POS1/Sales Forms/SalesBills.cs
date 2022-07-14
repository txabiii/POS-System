using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using POS1.Forms;

namespace POS1.Sales_Forms
{
    public partial class SalesBills : UserControl
    {
        // Fields
        private string billsClothesTitle;
        private string billsClothesCode;
        private string billsClothesColorName;
        private string billsClothesSizeName;
        private int billsClothesColorId;
        private int billsClothesSizeId;
        private string billsClothesSubtotal;
        private string billsClothesPrice;
        private string billsOriginalClothesPrice;
        private string billsClothesFileExt;
        private Image billsClothesIcon;
        private int quantity;
        private bool checkedBill; // stores whether the bill has been added to database or not

        SalesForm _parent;

        public SalesBills(SalesForm parentForm)
        {
            InitializeComponent();
            _parent = parentForm;
        }

        [Category("Custom Props")]
        public string BillsClothesTitle
        {
            get { return billsClothesTitle; }
            set { billsClothesTitle = value; labelBillsClothesTitle.Text = value; }
        }

        [Category("Custom Props")]
        public string BillsClothesCode
        {
            get { return billsClothesCode; }
            set { billsClothesCode = value; labelBillsClothesCode.Text = "item no. " + value; }
        }

        [Category("Custom Props")]
        public string BillsClothesColorName
        {
            get { return billsClothesColorName; }
            set { billsClothesColorName = value; labelBillsClothesColor.Text = "color: " + value; }
        }

        [Category("Custom Props")]
        public string BillsClothesSizeName
        {
            get { return billsClothesSizeName; }
            set { billsClothesSizeName = value; labelBillsClothesSize.Text = "size: " + value; }
        }

        [Category("Custom Props")]
        public string BillsClothesSubtotal
        {
            get { return billsClothesSubtotal; }
            set { billsClothesSubtotal = value;  }
        }

        [Category("Custom Props")]
        public string BillsClothesPrice
        {
            get { return billsClothesPrice; }
            set { billsClothesPrice = "0"; billsOriginalClothesPrice = value; labelBillsPrice.Text = value; }
        }

        [Category("Custom Props")]
        public Image BillsClothesIcon
        {
            get { return billsClothesIcon; }
            set { billsClothesIcon = value; pictureBoxBillsIcon.Image = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = 0; textBoxBillsQuantity.Text = value.ToString(); changeQuantity(value); }
        }

        public string BillsClothesFileExt
        {
            get { return billsClothesFileExt; }
            set { billsClothesFileExt = value; setImage(); }
        }

        public int BillsClothesColorId
        {
            get { return billsClothesColorId; }
            set { billsClothesColorId = value; }
        }

        public int BillsClothesSizeId
        {
            get { return billsClothesSizeId; }
            set { billsClothesSizeId = value; }
        }

        public bool CheckedBill
        {
            get { return checkedBill; }
            set { checkedBill = value; }
        }

        private void buttonsBillsPlus_Click(object sender, EventArgs e)
        {
            changeQuantity(1);
            updateStock(-1);
        }

        private void buttonsBillsMinus_Click(object sender, EventArgs e)
        {
            changeQuantity(-1);
            updateStock(1);
        }

        //change stock runs
        //stock is attempted to be updated
        //if stock goes below 0, show error, just empty the stocks
        //if stock does not go below zero, continue

        public void updateStock(int amount)
        {            
            foreach (DataRow row in Program.itemSpec.Rows)
            {
                if (row["item_id"].ToString() == billsClothesCode && (int)row["color_id"] == billsClothesColorId && (int)row["size_id"] == billsClothesSizeId)
                {
                    //MessageBox.Show((int.Parse(row["stock"].ToString()) + amount).ToString());
                    if (int.Parse(row["stock"].ToString()) + amount < 0)
                    {
                        changeQuantity(amount);
                        MessageBox.Show("Maximum stocks for this item and specifications reached");
                    }
                    else 
                    {
                        row["stock"] = int.Parse(row["stock"].ToString()) + amount;
                    }

                }
            }
        }

        public void changeQuantity(int insertQuantity)
        {
            //add the insert quantity
            quantity += insertQuantity;

            //update ui
            textBoxBillsQuantity.Text = quantity.ToString();
            billsClothesPrice = (float.Parse(billsClothesPrice) + insertQuantity * float.Parse(billsOriginalClothesPrice)).ToString("#,##0.00");
            labelBillsPrice.Text = billsClothesPrice;

            //get the subtotal of sales
            float salesSubtotal;
            if (float.TryParse(_parent.labelSalesSubtotalValue.Text, out float result))
            {
                salesSubtotal = result;
            }
            else salesSubtotal = 0;

            //add to the subtotal the original price multiplied by the insert quantity
            _parent.labelSalesSubtotalValue.Text = (salesSubtotal + insertQuantity * float.Parse(billsOriginalClothesPrice)).ToString();

            //get new subtotal
            salesSubtotal = float.Parse(_parent.labelSalesSubtotalValue.Text);

            //add tax
            double taxValue = ((salesSubtotal) * 0.05);
            _parent.labelSalesTaxValue.Text = taxValue.ToString("#,##0.00");

            //display final bill
            _parent.labelSalesTotalValue.Text = (salesSubtotal + taxValue).ToString("#,##0.00");
            
            checkNegative();
        }

        private void checkNegative()
        {
            if (int.TryParse(textBoxBillsQuantity.Text, out int quantity))
            {
                //if quantity is 1 make minus red
                //if quantity is greater than 1 make minus gray
                //if quantity becomes 0 or less dispose this object
                if (quantity == 1)
                {
                    buttonsBillsMinus.BackgroundColor = Color.LightCoral;
                } else if (quantity > 1)
                {
                    buttonsBillsMinus.BackgroundColor = Color.FromArgb(255,178,178,178);
                } else
                {
                    this.Dispose();
                }
            }
            else textBoxBillsQuantity.Text = "0";
        }
        
        private void setImage()
        {
            pictureBoxBillsIcon.Image = Program.GetImage(BillsClothesCode, BillsClothesFileExt);
        }

        private void textBoxBillsQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxBillsQuantity_KeyUp(object sender, KeyEventArgs e)
        {
            if (int.TryParse(textBoxBillsQuantity.Text, out int input))
            {
                int change = input - quantity;
                int update = quantity - input;
                changeQuantity(change);
                updateStock(update);
            }
        }
    }
}
