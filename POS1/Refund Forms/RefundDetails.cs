using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace POS1.Refund_Forms
{
    public partial class RefundDetails : UserControl
    {

        private int refundDetailId;
        private string refundDetailFileExt;
        private string refundDetailType;
        private float refundDetailSubtotal;
        private float refundDetailRightSubtotal;
        private float refundDetailDiscount;
        private float refundDetailSalesTax;
        private float refundDetailRightSalesTax;
        private float refundDetailTotal;
        private float refundDetailRightTotal;
        private DateTime refundDetailDateTime;

        public bool isFullRefund = true;
        public bool checkedBill = true;

        List<RefundDetailsContentRight> billsList = new List<RefundDetailsContentRight>();

        public RefundDetails()
        {
            InitializeComponent();
        }

        public int detailId
        {
            get { return refundDetailId; }
            set { refundDetailId = value; labelRefundDetailsID.Text = "Transaction ID: " + value; }
        }

        public string detailFileExt
        {
            get { return refundDetailFileExt; }
            set { refundDetailFileExt = value; }
        }

        public string detailType
        {
            get { return refundDetailType; }
            set
            {
                refundDetailType = value;
                labelRefundDetailsType.Text = "Transaction Type: " + value;
                //if (value == "supply") panelRefundDetailsBottom.Visible = false;
            }
        }

        public float detailSubtotal
        {
            get { return refundDetailSubtotal; }
            set { refundDetailSubtotal = value; labelRefundDetailsSubtotal.Text = "Subtotal: " + value.ToString("#,##0.00"); }
        }

        public float detailRightSubtotal
        {
            get { return refundDetailRightSubtotal; }
            set { refundDetailRightSubtotal = value; labelRefundDetailsSubtotalRight.Text = "Subtotal: " + value.ToString("#,##0.00"); }
        }

        public float detailDiscount
        {
            get { return refundDetailDiscount; }
            set { refundDetailDiscount = value; labelRefundDetailsDiscounts.Text = "Discounts: " + value.ToString("#,##0.00"); }
        }

        public float detailRightSalesTax
        {
            get { return refundDetailRightSalesTax; }
            set { refundDetailRightSalesTax = value; labelRefundDetailsSalesTaxRight.Text = "Sales Tax (5%): " + value.ToString("#,##0.00"); }
        }

        public float detailSalesTax
        {
            get { return refundDetailSalesTax; }
            set { refundDetailSalesTax = value; labelRefundDetailsSalesTax.Text = "Sales Tax (5%): " + value.ToString("#,##0.00"); }
        }

        public float detailRightTotal
        {
            get { return refundDetailRightTotal; }
            set { refundDetailRightTotal = value; labelRefundDetailsTotalRight.Text = "Total: " + value.ToString("#,##0.00"); }
        }

        public float detailTotal
        {
            get { return refundDetailTotal; }
            set { refundDetailTotal = value; labelRefundDetailsTotal.Text = "Total: " + value.ToString("#,##0.00"); }
        }

        public DateTime detailDateTime
        {
            get { return refundDetailDateTime; }
            set { refundDetailDateTime = value; labelRefundDetailsDate.Text = value.ToShortDateString(); labelRefundDetailsTime.Text = value.ToShortTimeString(); }
        }

        public DateTime detailDate
        {
            get { return refundDetailDateTime; }
            set { refundDetailDateTime = value; labelRefundDetailsDate.Text = "Date: " + value.ToShortDateString(); }
        }

        public DateTime detailTime
        {
            get { return refundDetailDateTime; }
            set { refundDetailDateTime = value; labelRefundDetailsTime.Text = "Time: " + value.ToShortTimeString(); }
        }

        public void populateRefundDetailsContent()
        {
            DataTable refunds = Program.GetTransactionContent(Convert.ToInt32(refundDetailId));
            //MessageBox.Show(transactionStockAdded.ToString());
            foreach (DataRow refundcontent in refunds.Rows)
            {
                RefundDetailsContent content = new RefundDetailsContent(this);
                content.Width = flowLayoutPanelRefundDetailsLeftMiddle.Width - 2;

                content.ContentTitle = refundcontent["item_name"].ToString();
                content.ContentCode = Convert.ToInt32(refundcontent["item_id"]);
                content.ContentSize = refundcontent["size_name"].ToString();
                content.ContentColor = refundcontent["color_name"].ToString();
                content.ContentPrice = Convert.ToSingle(refundcontent["sale_subtotal"]);
                content.ContentQuantity = Convert.ToInt32(refundcontent["quantity"]);
                content.ContentPhotoExt = refundcontent["file_ext"].ToString();
                content.pictureBoxRefundDetailsClothesImage.Image = Program.GetImage(refundcontent["item_id"].ToString(), refundcontent["file_ext"].ToString());

                comboBoxRefundDetailsReason.Items.Clear();
                comboBoxRefundDetailsReason.Items.Add("The item was damaged/defective.");
                comboBoxRefundDetailsReason.Items.Add("The merchant shipped the wrong item.");
                comboBoxRefundDetailsReason.Items.Add("The item does not live up to expectation.");
                comboBoxRefundDetailsReason.Items.Add("The seller changed their mind.");
                comboBoxRefundDetailsReason.Items.Add("The purchase was fraudulent.");

                flowLayoutPanelRefundDetailsLeftMiddle.Controls.Add(content);
            }
        }

        private void buttonsFullRefund_Click(object sender, EventArgs e)
        {
            isFullRefund = true;
            buttonsFullRefund.BackColor = Color.PaleVioletRed;
            buttonsPartialRefund.BackColor = Color.FromArgb(178, 178, 178);
            detailRightSubtotal = refundDetailSubtotal;
            detailRightSalesTax = (float)(refundDetailSubtotal * 0.05);
            detailRightTotal = refundDetailTotal;
            flowLayoutPanelRefundDetailsRightMiddle.Controls.Clear();

            DataTable refunds = Program.GetTransactionContent(Convert.ToInt32(refundDetailId));
            foreach (DataRow refundcontent in refunds.Rows)
            {
                RefundDetailsContentRight rightDetail = new RefundDetailsContentRight(this);

                rightDetail.ItemName = refundcontent["item_name"].ToString();
                rightDetail.ItemId = Convert.ToInt32(refundcontent["item_id"]).ToString();
                rightDetail.ItemSize = refundcontent["size_name"].ToString();
                rightDetail.ItemColor = refundcontent["color_name"].ToString();
                rightDetail.ItemUnitPrice = Convert.ToSingle(refundcontent["sale_subtotal"]);
                rightDetail.ItemQty = Convert.ToInt32(refundcontent["quantity"]);
                rightDetail.ItemFileExt = refundcontent["file_ext"].ToString();
                rightDetail.pictureBoxRefundDetailsClothesImageRight.Image = Program.GetImage(refundcontent["item_id"].ToString(), refundcontent["file_ext"].ToString());

                flowLayoutPanelRefundDetailsRightMiddle.Controls.Add(rightDetail);
            }
        }

        private void buttonsPartialRefund_Click(object sender, EventArgs e)
        {
            isFullRefund = false;
            buttonsPartialRefund.BackColor = Color.PaleVioletRed;
            buttonsFullRefund.BackColor = Color.FromArgb(178, 178, 178);
            labelRefundDetailsSubtotalRight.Text = "Subtotal: ";
            labelRefundDetailsSalesTaxRight.Text = "Sales Tax (5%): ";
            labelRefundDetailsTotalRight.Text = "Total: ";
            flowLayoutPanelRefundDetailsRightMiddle.Controls.Clear();

            detailRightSubtotal = 0;
            detailRightSalesTax = 0;
            detailRightTotal = 0;
        }

        private void buttonsRefund_Click(object sender, EventArgs e)
        {
            DataTable getSaleID = Program.GetSaleID(Convert.ToInt32(refundDetailId));

            foreach (DataRow refundcontent in getSaleID.Rows)
            {
                string refundtype;
                if (isFullRefund) refundtype = "Full"; else refundtype = "Partial";

                Program.InsertRefundData(Convert.ToInt32(refundcontent["sale_id"]), refundDetailId, refundtype);
                //Program.InsertRefundExchangeData(Convert.ToInt32(refundcontent["sale_id"]), refundDetailId, refundtype, refundDetailRightTotal);
            }

            foreach (RefundDetailsContentRight bill in flowLayoutPanelRefundDetailsRightMiddle.Controls)
            {
                RefundDetailsContentRight finalBill = new RefundDetailsContentRight(this);

                //get data
                finalBill.ItemName = bill.ItemName;
                finalBill.ItemUnitPrice = bill.ItemUnitPrice;
                finalBill.ItemId = bill.ItemId;
                finalBill.ItemSize = bill.ItemSize;
                finalBill.ItemColor = bill.ItemColor;
                //finalBill.BillsClothesSizeId = bill.BillsClothesSizeId;
                //finalBill.BillsClothesColorId = bill.BillsClothesColorId;
                finalBill.ItemFileExt = bill.ItemFileExt;
                finalBill.ItemQty = bill.ItemQty;

                //add to panel
                //flowLayoutPanelButtonsCashBills.Controls.Add(finalBill);
                billsList.Add(bill);
            }

            decimal total = Convert.ToDecimal(refundDetailRightTotal);
            string paymentMethod = "Cash";
            float cashAmount = refundDetailTotal;

            Program.InsertRefundItem(total, paymentMethod, refundDetailRightTotal, billsList);


        }
    }
}
