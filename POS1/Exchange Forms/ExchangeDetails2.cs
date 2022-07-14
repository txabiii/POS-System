using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace POS1.Exchange
{
    public partial class ExchangeDetails2 : UserControl
    {

        private int exchangeDetailId;
        private string exchangeDetailFileExt;
        private string exchangeDetailType;
        private float exchangeDetailSubtotal;
        private float exchangeDetailDiscount;
        private float exchangeDetailSalesTax;
        private float exchangeDetailTotal;
        private DateTime exchangeDetailDateTime;
        private float exchangeDetailSubtotalRight;
        private float exchangeDetailSalesTaxRight;
        private float exchangeDetailTotalRight;

        public bool isFullRefund = true;

        List<ExchangeDetailsContentConfirm> billsList = new List<ExchangeDetailsContentConfirm>();
        List<ExchangeDetailsContent2> refundList = new List<ExchangeDetailsContent2>();

        public ExchangeDetails2()
        {
            InitializeComponent();

            //MessageBox.Show(flowLayoutPanelExchangeDetailsRightMiddle.Controls.Val);

        }

        public int ExchangeDetailId
        {
            get { return exchangeDetailId; }
            set { exchangeDetailId = value; labelExchangeDetailsID2.Text = "Transaction ID: " + value; }
        }

        public string ExchangeDetailFileExt
        {
            get { return exchangeDetailFileExt; }
            set { exchangeDetailFileExt = value; }
        }

        public string ExchangeDetailType
        {
            get { return exchangeDetailType; }
            set
            {
                exchangeDetailType = value;
                labelExchangeDetailsType2.Text = "Transaction Type: " + value;
                //if (value == "supply") panelRefundDetailsBottom.Visible = false;
            }
        }

        public float ExchangeDetailSubtotal
        {
            get { return exchangeDetailSubtotal; }
            set { exchangeDetailSubtotal = value; labelExchangeDetailsSubtotal2.Text = "Subtotal: " + value.ToString("#,##0.00"); }
        }


        public float ExchangeDetailDiscount
        {
            get { return exchangeDetailDiscount; }
            set { exchangeDetailDiscount = value; labelExchangeDetailsDiscounts2.Text = "Discounts: " + value.ToString("#,##0.00"); }
        }

        public float ExchangeDetailSalesTax
        {
            get { return exchangeDetailSalesTax; }
            set { exchangeDetailSalesTax = value; labelExchangeDetailsSalesTax2.Text = "Sales Tax (5%): " + value.ToString("#,##0.00"); }
        }

        public float ExchangeDetailTotal
        {
            get { return exchangeDetailTotal; }
            set { exchangeDetailTotal = value; labelExchangeDetailsTotal2.Text = "Total: " + value.ToString("#,##0.00"); }
        }

        public float ExchangeDetailSubtotalRight
        {
            get { return exchangeDetailSubtotalRight; }
            set { exchangeDetailSubtotalRight = value; labelExchangeDetailsSubtotalRight2.Text = "Subtotal: " + value.ToString("#,##0.00"); }
        }

        public float ExchangeDetailSalesTaxRight
        {
            get { return exchangeDetailSalesTaxRight; }
            set { exchangeDetailSalesTaxRight = value; labelExchangeDetailsSalesTaxRight2.Text = "Sales Tax (5%): " + value.ToString("#,##0.00"); }
        }

        public float ExchangeDetailTotalRight
        {
            get { return exchangeDetailTotalRight; }
            set { exchangeDetailTotalRight = value; labelExchangeDetailsTotalRight2.Text = "Total: " + value.ToString("#,##0.00"); }
        }

        public DateTime ExchangeDetailDateTime
        {
            get { return exchangeDetailDateTime; }
            set { exchangeDetailDateTime = value; labelExchangeDetailsDate2.Text = value.ToShortDateString(); labelExchangeDetailsTime2.Text = value.ToShortTimeString(); }
        }

        public DateTime ExchangeDetailDate
        {
            get { return exchangeDetailDateTime; }
            set { exchangeDetailDateTime = value; labelExchangeDetailsDate2.Text = "Date: " + value.ToShortDateString(); }
        }

        public DateTime ExchangeDetailTime
        {
            get { return exchangeDetailDateTime; }
            set { exchangeDetailDateTime = value; labelExchangeDetailsTime2.Text = "Time: " + value.ToShortTimeString(); }
        }

        public void populateExchangeDetailsContent()
        {
            DataTable exchange = Program.GetTransactionContent(ExchangeDetailId);
            //MessageBox.Show(transactionStockAdded.ToString());
            foreach (DataRow exchangecontent in exchange.Rows)
            {
                ExchangeDetailsContent2 content = new ExchangeDetailsContent2(this);
                content.Width = panelExchangeDetailsRight.Width - 2;

                content.ContentTitle = exchangecontent["item_name"].ToString();
                content.ContentCode = Convert.ToInt32(exchangecontent["item_id"]);
                content.ContentSize = exchangecontent["size_name"].ToString();
                content.ContentColor = exchangecontent["color_name"].ToString();
                content.ContentPrice = Convert.ToSingle(exchangecontent["sale_subtotal"]);
                content.ContentQuantity = Convert.ToInt32(exchangecontent["quantity"]);
                content.ContentPhotoExt = exchangecontent["file_ext"].ToString();
                content.pictureBoxExchangeDetailsClothesImage2.Image = Program.GetImage(exchangecontent["item_id"].ToString(), exchangecontent["file_ext"].ToString());


                comboBoxExchangeDetailsReason.Items.Clear();
                comboBoxExchangeDetailsReason.Items.Add("The item was damaged/defective.");
                comboBoxExchangeDetailsReason.Items.Add("The merchant shipped the wrong item.");
                comboBoxExchangeDetailsReason.Items.Add("The item does not live up to expectation.");
                comboBoxExchangeDetailsReason.Items.Add("The seller changed their mind.");
                comboBoxExchangeDetailsReason.Items.Add("The purchase was fraudulent.");

                flowLayoutPanelExchangeDetailsLeftMiddle2.Controls.Add(content);
            }
        }

        private void buttonsFullExchange_Click(object sender, EventArgs e)
        {
            buttonsFullExchange.BackColor = Color.PaleVioletRed;
        }

        private void buttonsExchangeSelectItemsPlusRight_Click(object sender, EventArgs e)
        {
            Exchange_Forms.ExchangeSalesForm newForm = new Exchange_Forms.ExchangeSalesForm(this);
            newForm.Show();
        }

        private void labelExchangeDetailsDiscounts2_Click(object sender, EventArgs e)
        {

        }

        private void buttonsExchange_Click(object sender, EventArgs e)
        {
            //ExchangeDetailsContentConfirm newBill = (ExchangeDetailsContentConfirm)flowLayoutPanelExchangeDetailsRightMiddle.Controls[0];

            //MessageBox.Show(flowLayoutPanelExchangeDetailsRightMiddle.Controls[1].Name);
            int i = 0;

            foreach (ExchangeDetailsContentConfirm bill in flowLayoutPanelExchangeDetailsRightMiddle.Controls)
            {
                ExchangeDetailsContentConfirm finalBill = new ExchangeDetailsContentConfirm(this);

                //get data
                finalBill.BillsClothesTitle = bill.BillsClothesTitle;
                finalBill.BillsClothesPrice = bill.BillsClothesPrice;
                finalBill.BillsClothesCode = bill.BillsClothesCode;
                finalBill.BillsClothesSizeName = bill.BillsClothesSizeName;
                finalBill.BillsClothesColorName = bill.BillsClothesColorName;
                finalBill.BillsClothesSizeId = bill.BillsClothesSizeId;
                finalBill.BillsClothesColorId = bill.BillsClothesColorId;
                finalBill.BillsClothesFileExt = bill.BillsClothesFileExt;
                finalBill.Quantity = bill.Quantity;

                //add to panel
                //flowLayoutPanelButtonsCashBills.Controls.Add(finalBill);
                billsList.Add(bill);
            }

            MessageBox.Show(flowLayoutPanelExchangeDetailsLeftMiddle2.Controls[0].Name);

            foreach (ExchangeDetailsContent2 bill in flowLayoutPanelExchangeDetailsLeftMiddle2.Controls)
            {
                ExchangeDetailsContent2 finalBill = new ExchangeDetailsContent2(this);

                //get data
                finalBill.ContentTitle = bill.ContentTitle;
                finalBill.ContentPrice = bill.ContentPrice;
                finalBill.ContentCode = bill.ContentCode;
                finalBill.ContentSize = bill.ContentSize;
                finalBill.ContentColor = bill.ContentColor;
                //finalBill.BillsClothesSizeId = bill.BillsClothesSizeId;
                //finalBill.BillsClothesColorId = bill.BillsClothesColorId;
                //finalBill.ContentFileExt = bill.BillsClothesFileExt;
                finalBill.ContentQuantity = bill.ContentQuantity;

                //add to panel
                //flowLayoutPanelButtonsCashBills.Controls.Add(finalBill);
                refundList.Add(bill);
            }



            decimal total = Convert.ToDecimal(ExchangeDetailTotalRight);
            string paymentMethod = "Cash";
            float cashAmount = ExchangeDetailTotal;

            Program.PayExchange(total, paymentMethod, cashAmount, billsList);
            Program.InsertTransactionItem(total, paymentMethod, exchangeDetailTotalRight, refundList);

            DataTable getSaleID = Program.GetSaleID(Convert.ToInt32(exchangeDetailId));

            foreach (DataRow refundcontent in getSaleID.Rows)
            {
                string refundtype;
                if (isFullRefund) refundtype = "Full"; else refundtype = "Partial";

                //Program.InsertRefundExchangeData(Convert.ToInt32(refundcontent["sale_id"]), exchangeDetailId, refundtype, exchangeDetailTotal);
            }
        }
    }

}
