using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using POS1;

namespace POS1.Exchange
{
    public partial class ExchangeDetailsContentConfirm : UserControl
    {

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
        private float billsRefundMoney;

        private bool checkedBill;

        public ExchangeDetails2 _parent;

        List<ExchangeDetailsContentConfirm> billsList = new List<ExchangeDetailsContentConfirm>();
        public ExchangeDetailsContentConfirm(ExchangeDetails2 parent)
        {
            _parent = parent;
            InitializeComponent();
        }

        [Category("Custom Props")]
        public string BillsClothesTitle
        {
            get { return billsClothesTitle; }
            set { billsClothesTitle = value; labelExchangeDetailsClothesTitleConfirm.Text = value; }
        }

        [Category("Custom Props")]
        public string BillsClothesCode
        {
            get { return billsClothesCode; }
            set { billsClothesCode = value; labelExchangeDetailsClothesCodeConfirm.Text = "item no. " + value; }
        }

        [Category("Custom Props")]
        public string BillsClothesColorName
        {
            get { return billsClothesColorName; }
            set { billsClothesColorName = value; labelExchangeDetailsClothesColorConfirm.Text = "color: " + value; }
        }

        [Category("Custom Props")]
        public string BillsClothesSizeName
        {
            get { return billsClothesSizeName; }
            set { billsClothesSizeName = value; labelExchangeDetailsClothesSizeConfirm.Text = "size: " + value; }
        }

        [Category("Custom Props")]
        public string BillsClothesSubtotal
        {
            get { return billsClothesSubtotal; }
            set { billsClothesSubtotal = value; }
        }

        [Category("Custom Props")]
        public string BillsClothesPrice
        {
            get { return billsClothesPrice; }
            set { billsClothesPrice = value; billsOriginalClothesPrice = value; labelExchangeDetailsClothesPriceConfirm.Text = value; }
        }

        [Category("Custom Props")]
        public Image BillsClothesIcon
        {
            get { return billsClothesIcon; }
            set { billsClothesIcon = value; pictureBoxExchangeDetailsClothesImageConfirm.Image = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; textBoxExchangeClothesQuantityConfirm.Text = value.ToString(); labelExchangeDetailsClothesQuantityConfirm.Text = value.ToString(); }
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

        public float BillsRefundMoney
        {
            get { return billsRefundMoney; }
            set { billsRefundMoney = value; }
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
            MessageBox.Show(quantity.ToString());

            textBoxExchangeClothesQuantityConfirm.Text = quantity.ToString();
            billsClothesPrice = (float.Parse(billsClothesPrice) + insertQuantity * float.Parse(billsOriginalClothesPrice)).ToString("#,##0.00");
            labelExchangeDetailsClothesPriceConfirm.Text = billsClothesPrice;

            checkNegative();
        }

        private void checkNegative()
        {
            if (int.TryParse(textBoxExchangeClothesQuantityConfirm.Text, out int quantity))
            {
                //if quantity is 1 make minus red
                //if quantity is greater than 1 make minus gray
                //if quantity becomes 0 or less dispose this object
                if (quantity == 1)
                {
                    buttonsExchangeClothesMinuslabelExchangeDetailsClothesConfirm.BackgroundColor = Color.LightCoral;
                }
                else if (quantity > 1)
                {
                    buttonsExchangeClothesMinuslabelExchangeDetailsClothesConfirm.BackgroundColor = Color.FromArgb(255, 178, 178, 178);
                }
                else
                {
                    this.Dispose();
                }
            }
            else textBoxExchangeClothesQuantityConfirm.Text = "0";
        }

        private void setImage()
        {
            pictureBoxExchangeDetailsClothesImageConfirm.Image = Program.GetImage(BillsClothesCode, BillsClothesFileExt);
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
            if (int.TryParse(textBoxExchangeClothesQuantityConfirm.Text, out int input))
            {
                int change = input - quantity;
                int update = quantity - input;
                changeQuantity(change);
                updateStock(update);
            }
        }

        private void buttonsExchangeClothesMinuslabelExchangeDetailsClothesConfirm_Click(object sender, EventArgs e)
        {
            Quantity--;
            _parent.ExchangeDetailSubtotalRight = float.Parse((float.Parse(BillsClothesPrice) * Quantity).ToString());
            _parent.ExchangeDetailSalesTaxRight = float.Parse((float.Parse(BillsClothesPrice) * Quantity * 0.05).ToString());
            _parent.ExchangeDetailTotalRight = float.Parse((float.Parse(BillsClothesPrice) * Quantity).ToString()) + float.Parse((float.Parse(BillsClothesPrice) * Quantity * 0.05).ToString());
        }

        private void buttonsExchangeClothesPlusConfirm_Click(object sender, EventArgs e)
        {
            Quantity++;
            _parent.ExchangeDetailSubtotalRight = float.Parse((float.Parse(BillsClothesPrice) * Quantity).ToString());
            _parent.ExchangeDetailSalesTaxRight = float.Parse((float.Parse(BillsClothesPrice) * Quantity * 0.05).ToString());
            _parent.ExchangeDetailTotalRight = float.Parse((float.Parse(BillsClothesPrice) * Quantity).ToString()) + float.Parse((float.Parse(BillsClothesPrice) * Quantity * 0.05).ToString());
        }
    }
}
