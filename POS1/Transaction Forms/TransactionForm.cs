using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using POS1.Transaction_Forms;

namespace POS1.Transaction
{
    public partial class TransactionForm : Form
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

        private static Filter filterForm = new Filter();

        public TransactionForm()
        {
            InitializeComponent();
            filterForm.filterConfirm.Click += new EventHandler(filterForm_Click);
        }

        // Methods
        public void populateHistoryContent()
        {
            initializePagination("history");

            // Clear the flowLayoutPanel and panel of labels
            flowLayoutPanelTransactionContents.Controls.Clear();
            panelTransactionHistoryLabel.Controls.Clear();

            // User control of History Label
            HistoryLabel historyLabel = new HistoryLabel();

            //set width here to fit
            historyLabel.Width = panelTransactionHistoryLabel.Width - 40;
            panelTransactionHistoryLabel.Controls.Add(historyLabel);

            //only display items if the total records are above zero
            if (totalRecords > 0)
            {
                //get transaction list
                DataTable transactions = Program.GetTransactionsHistory(currentPage, resultsPerPage, dateFilterFirst, dateFilterSecond, typeFilter, search);

                foreach (DataRow transaction in transactions.Rows)
                {
                    HistoryContent display = new HistoryContent();
                    display.HistoryId = transaction["transaction_id"].ToString();
                    display.HistoryFileExt = transaction["file_ext"].ToString();
                    display.HistoryFirstItemId = transaction["item_id"].ToString();
                    display.HistoryDateTime = DateTime.Parse(transaction["date_time"].ToString());
                    display.HistoryType = transaction["type"].ToString();

                    if (transaction["type"].ToString() == "sale" || transaction["type"].ToString() == "refund" || transaction["type"].ToString() == "sale(ex)" || transaction["type"].ToString() == "ref (ex)")
                    {
                        float total = (float)(decimal)transaction["total"];
                        display.HistorySubtotal = Convert.ToSingle(total - (total / (1 + 0.05) * 0.05));
                        display.HistoryDiscount = 0;
                        display.HistorySalesTax = Convert.ToSingle((float)(decimal)transaction["total"] * 0.05);
                        display.HistoryTotal = Convert.ToSingle(transaction["total"]);
                        display.HistoryAmountPaid = Convert.ToSingle(transaction["payment_amount"]);
                        display.HistoryChange = Convert.ToSingle(transaction["payment_amount"]) - Convert.ToSingle(transaction["total"]);
                    }
                    else if (transaction["type"].ToString() == "supply")
                    {
                        display.HistorySupplyTotal = Convert.ToInt32(transaction["quantity"]);
                        display.HistoryStockAdded = Convert.ToBoolean(transaction["stock_added"]);
                        
                    }
                    
                    display.Width = flowLayoutPanelTransactionContents.Width - 40;
                    display.viewTransactionDetails.Click += new EventHandler((sender, e) => ViewTransactionDetails_Click(sender, e, display.HistoryId,
                                                                                            display.HistoryFileExt, display.HistoryTotal, display.HistoryType,
                                                                                            display.HistoryDateTime, display.HistoryFirstItemId, display.HistorySubtotal,
                                                                                            display.HistoryDiscount, display.HistorySalesTax, display.HistoryAmountPaid,
                                                                                            display.HistoryChange, display.HistoryStockAdded));

                    flowLayoutPanelTransactionContents.Controls.Add(display);
                }
            }
        }

        //some parameters are optional because they only apply to sales
        private void ViewTransactionDetails_Click(object sender, EventArgs e, string HistoryId, string HistoryFileExt, float HistoryTotal,
                                                    string HistoryType, DateTime HistoryDateTime, string HistoryFirstItemId, float HistorySubtotal = 0,
                                                    float HistoryDiscount = 0, float HistorySalesTax = 0, float HistoryAmountPaid = 0, float HistoryChange = 0, bool HistoryStockAdded = true)
        {
            // Clear the flowLayoutPanel and panel of labels
            flowLayoutPanelTransactionContents.Controls.Clear();
            panelTransactionHistoryLabel.Controls.Clear();

            //hide page navigation
            panelPageNavigation.Visible = false;

            // User control of Item Movement Label
            TransactionDetails transactionDetails = new TransactionDetails();
            transactionDetails.detailId = HistoryId;
            transactionDetails.detailType = HistoryType;
            transactionDetails.detailDate = Convert.ToDateTime(HistoryDateTime.ToShortDateString());
            transactionDetails.detailTime = Convert.ToDateTime(HistoryDateTime.ToShortTimeString());
            transactionDetails.detailDiscount = HistoryDiscount;
            transactionDetails.detailSalesTax = HistorySalesTax;
            transactionDetails.detailTotal = HistoryTotal;
            transactionDetails.detailSubtotal = HistorySubtotal;
            transactionDetails.detailAmountPaid = HistoryAmountPaid;
            transactionDetails.detailChange = HistoryChange;
            transactionDetails.Width = flowLayoutPanelTransactionContents.Width - 5;
            transactionDetails.Height = flowLayoutPanelTransactionContents.Height - 5;
            transactionDetails.buttonsTransactionClose.Click += new EventHandler(buttonsTransactionFilter_Click);
            transactionDetails.TransactionStockAdded = HistoryStockAdded;
            transactionDetails.populateTransactionDetailsContent();
            flowLayoutPanelTransactionContents.Controls.Add(transactionDetails);
        }

        private void initializePagination(string type)
        {
            //display page navigation
            panelPageNavigation.Visible = true;

            //try parsing search input
            if (!String.IsNullOrWhiteSpace(textBoxTransactionSearch.Text))
            {
                if (int.TryParse(textBoxTransactionSearch.Text, out int result))
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

        private void populateItemMovementContent()
        {
            initializePagination("itemMovement");

            // Clear the flowLayoutPanel and panel of labels
            flowLayoutPanelTransactionContents.Controls.Clear();
            panelTransactionHistoryLabel.Controls.Clear();

            //User control of Item Movement Content
            ItemMovementContent movementContent = new ItemMovementContent();

            // User control of Item Movement Label
            ItemMovementLabel itemMovementLabel = new ItemMovementLabel();
            itemMovementLabel.Dock = DockStyle.Top;
            itemMovementLabel.Width = flowLayoutPanelTransactionContents.Width - 40;
            panelTransactionHistoryLabel.Controls.Add(itemMovementLabel);

            //only display items if the total records are above zero
            if (totalRecords > 0)
            {
                DataTable movementContents = Program.GetItemMovementContent(currentPage, resultsPerPage, dateFilterFirst, dateFilterSecond, typeFilter, search, itemIdFilter);

                foreach (DataRow movementContentData in movementContents.Rows)
                {
                    movementContent = new ItemMovementContent();
                    movementContent.Dock = DockStyle.Top;
                    movementContent.ContentDate = DateTime.Parse(movementContentData["date_time"].ToString());
                    movementContent.ContentItemId = movementContentData["item_id"].ToString();
                    movementContent.ContentName = movementContentData["item_name"].ToString() + "\n" + movementContentData["color_name"].ToString() + " - " + movementContentData["size_name"].ToString();
                    movementContent.ContentQuantity = Convert.ToInt32(movementContentData["quantity"]);
                    movementContent.ContentFileExt = movementContentData["file_ext"].ToString();
                    movementContent.labelMovementItemActionId.Text = movementContentData["transaction_id"].ToString();


                    string type = movementContentData["type"].ToString();
                    movementContent.ContentTransactionID = "New " + char.ToUpper(type[0]) + type.Substring(1) + " Transaction:";
                    movementContent.ContentStatus = char.ToUpper(type[0]) + type.Substring(1) + " Succesful";

                    if (String.Equals(type, "sale"))
                    {
                        movementContent.ContentQuantity = 0 - movementContent.ContentQuantity;
                        movementContent.ContentSupplier = "POS Sale";
                    }
                    else if (String.Equals(type, "refund"))
                    {
                        movementContent.ContentSupplier = "Customer Refund";
                    }
                    else if (String.Equals(type, "exchange"))
                    {
                        movementContent.ContentSupplier = "Customer Return";
                    }
                    else if (String.Equals(type, "supply"))
                    {
                        movementContent.ContentSupplier = movementContentData["supplier_name"].ToString(); ;
                    }

                    movementContent.labelMovementItemActionId.Click += new EventHandler((sender, e) => labelMovementItemActionId_Click(sender, e, movementContentData["transaction_id"].ToString()));

                    movementContent.Width = flowLayoutPanelTransactionContents.Width - 40;
                    flowLayoutPanelTransactionContents.Controls.Add(movementContent);
                }
            }            
        }

        private void labelMovementItemActionId_Click(object sender, EventArgs e, string id)
        {
            textBoxTransactionSearch.Text = id;
            toggleHistoryButton();
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            if (historyActive)
            {
                filterForm.panelItemIdFilter.Visible = false;
                filterForm.Height = filterForm.Height - filterForm.panelItemIdFilter.Height;
            }
            else
            {
                filterForm.Height = filterForm.panelFilterLeft.Height + filterForm.panelConfirm.Height + filterForm.panelItemIdFilter.Height;
                filterForm.panelItemIdFilter.Visible = true;
            }
            filterForm.ShowDialog();
        }

        private void filterForm_Click(object sender, EventArgs e)
        {
            if (filterForm.checkFilter())
            {
                filterDot.Visible = true;
            }
            else filterDot.Visible = false;

            togglePopulate();
        }

        private void TransactionForm_Load(object sender, EventArgs e)
        {
            populateHistoryContent();
        }

        private void historyButton_Click(object sender, EventArgs e)
        {
            toggleHistoryButton();
        }

        private void toggleHistoryButton()
        {
            currentPage = 1;
            populateHistoryContent();
            historyActive = true;
            historyBottomBorder.BackColor = Color.Red;
            historyBottomBorder.Height = 8;
            itemMovementBottomBorder.BackColor = Color.Silver;
            itemMovementBottomBorder.Height = 2;
        }

        private void itemMovementButton_Click(object sender, EventArgs e)
        {
            toggleItemMovementButton();   
        }

        private void toggleItemMovementButton()
        {
            currentPage = 1;
            populateItemMovementContent();
            historyActive = false;
            historyBottomBorder.BackColor = Color.Silver;
            historyBottomBorder.Height = 2;
            itemMovementBottomBorder.BackColor = Color.Red;
            itemMovementBottomBorder.Height = 8;
        }

        private void pageInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                itemMovementBottomBorder.Focus();
                pageInput.Clear();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                //input has to be an int and not whitespace
                if (!String.IsNullOrWhiteSpace(pageInput.Text) && int.TryParse(pageInput.Text, out int result))
                {
                    //input has to be in range
                    if (result > 0 && result <= totalPages)
                    {
                        currentPage = result;
                    }
                    else return;
                }
                else return;

                togglePopulate();
            }
        }

        private void pageDisplay_Paint(object sender, PaintEventArgs e)
        {
            pageInput.Left = pageDisplay.Left + 2;
            pageInput.Width = pageDisplay.Width - 2;
        }

        private void pageInput_MouseLeave(object sender, EventArgs e)
        {
            itemMovementBottomBorder.Focus();
            pageInput.Clear();
        }

        private void pageInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void firstButton_Click(object sender, EventArgs e)
        {
            if (currentPage == 1)
            {
                return;
            }
            else currentPage = 1;

            togglePopulate();
        }

        private void lastButton_Click(object sender, EventArgs e)
        {
            if (currentPage == totalPages)
            {
                return;
            }
            else currentPage = totalPages;

            togglePopulate();
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            if (currentPage == 1)
            {
                return;
            }
            else currentPage--;

            togglePopulate();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (currentPage == totalPages)
            {
                return;
            }
            else currentPage++;

            togglePopulate();
        }

        //method that calls the appropriate populate method based if history is the active tab
        public void togglePopulate()
        {
            if (historyActive)
            {
                populateHistoryContent();
            }
            else
            {
                populateItemMovementContent();
            }
        }

        private void textBoxTransactionSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //input has to be an int and not whitespace
                if (!String.IsNullOrWhiteSpace(textBoxTransactionSearch.Text) && int.TryParse(textBoxTransactionSearch.Text, out int result))
                {
                    //set searchfilter to result
                    search = result.ToString();
                }
                else
                {
                    search = null;
                }
                togglePopulate();
            }
        }

        private void buttonsTransactionFilter_Click(object sender, EventArgs e)
        {
            togglePopulate();
        }
    }
}
