using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace POS1.Transaction_Forms
{
    public partial class TransactionDetails : UserControl
    {

        private string transactionDetailId;
        private string transactionDetailFileExt;
        private string transactionDetailType;
        private float transactionDetailSubtotal;
        private float transactionDetailDiscount;
        private float transactionDetailSalesTax;
        private float transactionDetailTotal;
        private float transactionDetailAmountPaid;
        private float transactionDetailChange;
        private DateTime transactionDetailDateTime;
        private bool transactionStockAdded;

        public TransactionDetails()
        {
            InitializeComponent();
        }

        public string detailId
        {
            get { return transactionDetailId; }
            set { transactionDetailId = value; labelTransactionDetailsID.Text = "Transaction ID: " + value;  }
        }

        public string detailFileExt
        {
            get { return transactionDetailFileExt; }
            set { transactionDetailFileExt = value; }
        }

        public string detailType
        {
            get { return transactionDetailType; }
            set { 
                transactionDetailType = value; 
                labelTransactionDetailsType.Text = "Transaction Type: " + value;
                if (value != "sale" && value != "sale(exp)") panelTransactionDetailsBottom.Visible = false;
            }
        }

        public float detailSubtotal
        {
            get { return transactionDetailSubtotal; }
            set { transactionDetailSubtotal = value; labelTransactionDetailsSubtotal.Text = "Subtotal: " + value.ToString("#,##0.00"); }
        }

        public float detailDiscount
        {
            get { return transactionDetailDiscount; }
            set { transactionDetailDiscount = value; labelTransactionDetailsDiscounts.Text = "Discounts: " + value.ToString("#,##0.00"); }
        }

        public float detailSalesTax
        {
            get { return transactionDetailSalesTax; }
            set { transactionDetailSalesTax = value; labelTransactionDetailsSalesTax.Text = "Sales Tax (5%): " + value.ToString("#,##0.00"); }
        }


        public float detailTotal
        {
            get { return transactionDetailTotal; }
            set { transactionDetailTotal = value; labelTransactionDetailsTotal.Text = "Total: " + value.ToString("#,##0.00"); }
        }

        public float detailAmountPaid
        {
            get { return transactionDetailAmountPaid; }
            set { transactionDetailAmountPaid = value; labelTransactionDetailsAmountPaid.Text = "Amount Paid: " + value.ToString("#,##0.00"); }
        }

        public float detailChange
        {
            get { return transactionDetailChange; }
            set { transactionDetailChange = value; labelTransactionDetailsChange.Text = "Change: " + value.ToString("#,##0.00"); }
        }

        public DateTime detailDateTime
        {
            get { return transactionDetailDateTime; }
            set { transactionDetailDateTime = value; labelTransactionDetailsDate.Text = value.ToShortDateString(); labelTransactionDetailsTime.Text = value.ToShortTimeString(); }
        }

        public DateTime detailDate
        {
            get { return transactionDetailDateTime; }
            set { transactionDetailDateTime = value; labelTransactionDetailsDate.Text = "Date: " + value.ToShortDateString(); }
        }

        public DateTime detailTime
        {
            get { return transactionDetailDateTime; }
            set { transactionDetailDateTime = value; labelTransactionDetailsTime.Text = "Time: " + value.ToShortTimeString(); }
        }

        public bool TransactionStockAdded
        {
            get { return transactionStockAdded; }
            set { transactionStockAdded = value;}
        }

        public void populateTransactionDetailsContent()
        {
            DataTable transactionscontent = Program.GetTransactionContent(Convert.ToInt32(transactionDetailId));
            //MessageBox.Show(transactionStockAdded.ToString());
            foreach (DataRow transactioncontent in transactionscontent.Rows)
            {
                TransactionDetailsContent content = new TransactionDetailsContent(this);
                content.Width = flowLayoutPanelTransactionDetailsContent.Width/3 - 5;

                if (!int.TryParse(transactioncontent["item_id"].ToString(), out int id))
                {
                    content.panel1.Controls.Clear();
                    Label itemDeleted = new Label();
                    itemDeleted.Dock = DockStyle.Fill;
                    itemDeleted.Text = "Item is deleted";
                    itemDeleted.TextAlign = ContentAlignment.MiddleCenter;
                    content.panel1.Controls.Add(itemDeleted);
                    flowLayoutPanelTransactionDetailsContent.Controls.Add(content);
                    return;
                }

                content.ContentTitle = transactioncontent["item_name"].ToString();
                content.ContentCode = Convert.ToInt32(transactioncontent["item_id"]);
                content.ContentSize = transactioncontent["size_name"].ToString();
                content.ContentColor = transactioncontent["color_name"].ToString();
                content.ContentPrice = Convert.ToSingle(transactioncontent["sale_subtotal"]);
                content.ContentQuantity = transactioncontent["quantity"].ToString();
                content.ContentPhotoExt = transactioncontent["file_ext"].ToString();
                content.pictureBoxTransactionDetailsClothesImage.Image = Program.GetImage(transactioncontent["item_id"].ToString(), transactioncontent["file_ext"].ToString());

                flowLayoutPanelTransactionDetailsContent.Controls.Add(content);
            }
        }
    }

}
