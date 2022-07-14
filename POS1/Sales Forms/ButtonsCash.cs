using POS1.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace POS1.Sales_Forms
{
    public partial class ButtonsCash : Form
    {
        private string paymentMethod;
        SalesForm _parent;
        List<SalesBills> billsList = new List<SalesBills>();

        public string PaymentMethod 
        {
            get { return paymentMethod; }
            set { paymentMethod = value; }
        }
        public ButtonsCash(SalesForm parentForm)
        {
            InitializeComponent();
            _parent = parentForm;
            labelButtonsCashSubtotalNumber.Text = _parent.labelSalesSubtotalValue.Text;
            labelButtonsCashSalesTaxNumber.Text = _parent.labelSalesTaxValue.Text;
            labelButtonsCashTotalNumber.Text = _parent.labelSalesTotalValue.Text;

            foreach (SalesBills bill in _parent.panelBills.Controls)
            {
                SalesBills finalBill = new SalesBills(_parent);
                //new settings
                finalBill.buttonsBillsMinus.Visible = false;
                finalBill.buttonsBillsPlus.Visible = false;
                finalBill.textBoxBillsQuantity.Location = new System.Drawing.Point(136,30);
                finalBill.labelBillsPrice.Dock = System.Windows.Forms.DockStyle.Right;
                //finalBill.textBoxBillsQuantity.Dock = System.Windows.Forms.DockStyle.Right;
                finalBill.textBoxBillsQuantity.Enabled = false;
                finalBill.panelSalesBillsDetails.Width = flowLayoutPanelButtonsCashBills.Width - 170;
                
                //get data
                finalBill.BillsClothesTitle = bill.BillsClothesTitle;
                finalBill.BillsClothesPrice = bill.BillsClothesPrice;
                finalBill.BillsClothesCode = bill.BillsClothesCode;
                finalBill.BillsClothesSizeName = bill.BillsClothesSizeName;
                finalBill.BillsClothesColorName = bill.BillsClothesColorName;
                finalBill.BillsClothesSizeId = bill.BillsClothesSizeId;
                finalBill.BillsClothesColorId = bill.BillsClothesColorId;
                finalBill.BillsClothesFileExt = bill.BillsClothesFileExt;
                finalBill.textBoxBillsQuantity.Text = "x" + bill.textBoxBillsQuantity.Text;
                
                //add to panel
                flowLayoutPanelButtonsCashBills.Controls.Add(finalBill);
                billsList.Add(bill);
            }

        }

        private void buttonNumPad_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender; 
            labelButtonsCashAmountNumber.Text = labelButtonsCashAmountNumber.Text + button.Text;
        }

        private void buttonsNumPadCancel_Click(object sender, EventArgs e)
        {
            labelButtonsCashAmountNumber.Text = "";
        }

        private void buttonsNumPadPay_Click(object sender, EventArgs e)
        {
            float cashAmount;
            try
            {
                cashAmount = float.Parse(labelButtonsCashAmountNumber.Text);
            }
            catch (Exception)
            {
                cashAmount = 0;
            }

            float salesTotal = float.Parse(labelButtonsCashTotalNumber.Text);

            if (cashAmount > salesTotal)
            {
                float changeAmount = System.Math.Abs(float.Parse(labelButtonsCashTotalNumber.Text) - float.Parse(labelButtonsCashAmountNumber.Text));
                labelButtonsCashChangeNumber.Text = changeAmount.ToString("#,##0.00");
                _parent.labelSalesCashValue.Text = cashAmount.ToString("#,##0.00");
                _parent.labelSalesChangeValue.Text = System.Math.Abs(cashAmount - salesTotal).ToString("#,##0.00");
            }
            else
            {
                string message = "Error: Total is greater than given cash!";
                string title = "Error!";
                MessageBox.Show(message, title);
                return;
            }

            //update database
            decimal total = Decimal.Round((decimal)salesTotal, 2); ;
            decimal amount = Decimal.Round((decimal)cashAmount, 2);
            Program.Pay(total, paymentMethod, cashAmount, billsList);

            //get updated items
            Program.GetItems();
            Close();
            _parent.buttonsSalesPrintBills.BackColor = Color.Tomato;
            _parent.PopulateSalesItems();
        }

        private void buttonsNumPadFullNum_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (String.IsNullOrWhiteSpace(labelButtonsCashAmountNumber.Text))
            {
                labelButtonsCashAmountNumber.Text = "0";
            }
            labelButtonsCashAmountNumber.Text = (int.Parse(labelButtonsCashAmountNumber.Text) + int.Parse(button.Text)).ToString();
        }
    }
}
