using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace POS1.Exchange
{
    public partial class ExchangeForm : Form
    {

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

        public ExchangeForm()
        {
            InitializeComponent();
        }

        public void populateExchangeContent()
        {
            initializePagination("history");

            flowLayoutPanelExchangeContents.Controls.Clear();

            // User control of Refund Label
            ExchangeLabel refundLabel = new ExchangeLabel();

            //set width here to fit
            refundLabel.Width = panelExchangeLabel.Width - 40;
            panelExchangeLabel.Controls.Add(refundLabel);

            // User control of Refund Content
            if (totalRecords > 0)
            {
                //get transaction list
                DataTable refunds = Program.GetRefundHistory(currentPage, resultsPerPage, dateFilterFirst, dateFilterSecond, typeFilter, search);

                foreach (DataRow transaction in refunds.Rows)
                {
                    ExhangeContent display = new ExhangeContent();

                    if (String.Equals(transaction["type"].ToString(), "sale"))
                    {
                        display.ExchangeId = Convert.ToInt32(transaction["transaction_id"]);
                        display.ExchangeFileExt = transaction["file_ext"].ToString();
                        display.ExchangeFirstItemId = transaction["item_id"].ToString();
                        display.ExchangeDateTime = DateTime.Parse(transaction["date_time"].ToString());
                        display.ExchangeStatus = transaction["type"].ToString();
                        float total = (float)(decimal)transaction["total"];
                        display.ExchangeSubtotal = Convert.ToSingle(total - (total / (1 + 0.05) * 0.05));
                        display.ExchangeDiscount = 0;
                        //display.RefundSalesTax = Convert.ToSingle((float)(decimal)transaction["total"] * 0.05);
                        display.ExchangeSalesTax = Convert.ToSingle((total - (total / (1 + 0.05) * 0.05)) * 0.05);
                        display.ExchangeTotal = Convert.ToSingle(transaction["total"]);


                        display.Width = flowLayoutPanelExchangeContents.Width - 40;

                        display.viewExchangeDetails.Click += new EventHandler((sender, e) => ViewRefundDetails_Click(sender, e, Convert.ToInt32(display.ExchangeId),
                                                                                                display.ExchangeFileExt, display.ExchangeStatus,
                                                                                                display.ExchangeDateTime, display.ExchangeFirstItemId, display.ExchangeDiscount,
                                                                                                display.ExchangeSalesTax, display.ExchangeSubtotal, display.ExchangeTotal));
                        flowLayoutPanelExchangeContents.Controls.Add(display);
                    }
                }
            }
        }

        private void ExchangeForm_Load(object sender, EventArgs e)
        {
            populateExchangeContent();
        }

        private void ViewRefundDetails_Click(object sender, EventArgs e, int HistoryId, string HistoryFileExt,
                                    string HistoryType, DateTime HistoryDateTime, string HistoryFirstItemId, float HistoryDiscount = 0,
                                    float HistorySalesTax = 0, float HistorySubtotal = 0, float HistoryTotal = 0)

        {
            // Clear the flowLayoutPanel and panel of labels
            flowLayoutPanelExchangeContents.Controls.Clear();
            panelExchangeLabel.Controls.Clear();

            //hide page navigation
            panelPageNavigation.Visible = false;

            // User control of Item Movement Label
            ExchangeDetails2 exchangeDetail = new ExchangeDetails2();
            exchangeDetail.ExchangeDetailId = HistoryId;
            exchangeDetail.ExchangeDetailType = HistoryType;
            exchangeDetail.ExchangeDetailDate = Convert.ToDateTime(HistoryDateTime.ToShortDateString());
            exchangeDetail.ExchangeDetailTime = Convert.ToDateTime(HistoryDateTime.ToShortTimeString());
            exchangeDetail.ExchangeDetailDiscount = HistoryDiscount;
            exchangeDetail.ExchangeDetailSalesTax = HistorySalesTax;
            exchangeDetail.ExchangeDetailTotal = HistoryTotal;
            exchangeDetail.ExchangeDetailSubtotal = HistorySubtotal;
            exchangeDetail.populateExchangeDetailsContent();
            flowLayoutPanelExchangeContents.Controls.Add(exchangeDetail);

        }

        private void initializePagination(string type)
        {
            //display page navigation
            panelPageNavigation.Visible = true;

            //try parsing search input
            if (!String.IsNullOrWhiteSpace(textBoxExchangeSearch.Text))
            {
                if (int.TryParse(textBoxExchangeSearch.Text, out int result))
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
