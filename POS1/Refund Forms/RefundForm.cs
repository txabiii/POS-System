using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using POS1.Transaction_Forms;


namespace POS1.Refund_Forms
{
    public partial class RefundForm : Form
    {

        private bool historyActive = true;

        public static int currentPage = 1;
        public static int resultsPerPage = 7;
        public static int totalPages = 0;
        private static int totalRecords = 0;
        public static string dateFilterFirst;
        public static string dateFilterSecond;
        public static string typeFilter;
        public static int itemIdFilter;
        public static bool filterByDate = true;
        public string search;
        public RefundForm()
        {
            InitializeComponent();
        }

        public void populateRefundContent()
        {
            initializePagination("history");

            flowLayoutPanelRefundContents.Controls.Clear();

            // User control of Refund Label
            RefundLabel refundLabel = new RefundLabel();

            //set width here to fit
            refundLabel.Width = panelRefundLabel.Width - 40;
            panelRefundLabel.Controls.Add(refundLabel);

            // User control of Refund Content
            if (totalRecords > 0)
            {
                //get transaction list
                DataTable refunds = Program.GetRefundHistory(currentPage, resultsPerPage, dateFilterFirst, dateFilterSecond, typeFilter, search);

                foreach (DataRow transaction in refunds.Rows)
                {
                    RefundContent display = new RefundContent();

                    if (String.Equals(transaction["type"].ToString(), "sale"))
                    {
                        display.RefundId = transaction["transaction_id"].ToString();
                        display.RefundFileExt = transaction["file_ext"].ToString();
                        display.RefundFirstItemId = transaction["item_id"].ToString();
                        display.RefundDateTime = DateTime.Parse(transaction["date_time"].ToString());
                        display.RefundStatus = transaction["type"].ToString();
                        float total = (float)(decimal)transaction["total"];
                        display.RefundSubtotal = Convert.ToSingle(total - (total / (1 + 0.05) * 0.05));
                        display.RefundDiscount = 0;
                        //display.RefundSalesTax = Convert.ToSingle((float)(decimal)transaction["total"] * 0.05);
                        display.RefundSalesTax = Convert.ToSingle((total - (total / (1 + 0.05) * 0.05)) * 0.05);
                        display.RefundTotal = Convert.ToSingle(transaction["total"]);


                        display.Width = flowLayoutPanelRefundContents.Width - 40;

                        display.viewRefundDetails.Click += new EventHandler((sender, e) => ViewRefundDetails_Click(sender, e, Convert.ToInt32(display.RefundId),
                                                                                                display.RefundFileExt, display.RefundStatus,
                                                                                                display.RefundDateTime, display.RefundFirstItemId, display.RefundDiscount,
                                                                                                display.RefundSalesTax, display.RefundSubtotal, display.RefundTotal));
                        flowLayoutPanelRefundContents.Controls.Add(display);
                    }
                }
            }
        }

        private void ViewRefundDetails_Click(object sender, EventArgs e, int HistoryId, string HistoryFileExt,
                                            string HistoryType, DateTime HistoryDateTime, string HistoryFirstItemId, float HistoryDiscount = 0, 
                                            float HistorySalesTax = 0, float HistorySubtotal = 0, float HistoryTotal = 0)

        {
            // Clear the flowLayoutPanel and panel of labels
            flowLayoutPanelRefundContents.Controls.Clear();
            panelRefundLabel.Controls.Clear();

            //hide page navigation
            panelPageNavigation.Visible = false;

            // User control of Item Movement Label
            RefundDetails refundDetails = new RefundDetails();
            refundDetails.detailId = HistoryId;
            refundDetails.detailType = HistoryType;
            refundDetails.detailDate = Convert.ToDateTime(HistoryDateTime.ToShortDateString());
            refundDetails.detailTime = Convert.ToDateTime(HistoryDateTime.ToShortTimeString());
            refundDetails.detailDiscount = HistoryDiscount;
            refundDetails.detailSalesTax = HistorySalesTax;
            refundDetails.detailTotal = HistoryTotal;
            refundDetails.detailSubtotal = HistorySubtotal;
            refundDetails.populateRefundDetailsContent();
            flowLayoutPanelRefundContents.Controls.Add(refundDetails);

        }

        private void RefundForm_Load(object sender, EventArgs e)
        {
            populateRefundContent();
        }

        private void initializePagination(string type)
        {
            //display page navigation
            panelPageNavigation.Visible = true;

            //try parsing search input
            if (!String.IsNullOrWhiteSpace(textBoxRefundSearch.Text))
            {
                if (int.TryParse(textBoxRefundSearch.Text, out int result))
                {
                    search = result.ToString();
                }
            }

            else search = null;

            //get the total number of transaction records and compute total pages
            totalRecords = Program.TotalRecords(dateFilterFirst, dateFilterSecond, typeFilter, search, type);

            totalPages = totalRecords / resultsPerPage + Convert.ToInt32((totalRecords % resultsPerPage) != 0);

            //if currentpage is above totalpages set to totalpage
            if (currentPage > totalPages && currentPage != 1) currentPage = totalPages;

            //set placeholder text of page input
            pageInput.PlaceholderText = currentPage + " of " + totalPages;
        }

    }
}
