using POS1.Sales_Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using POS1.POS_Controls;
using System.IO;
using System.Threading.Tasks;
using System.Diagnostics;

namespace POS1.Forms
{
    public partial class SalesForm : Form
    {
        // Fields
        private Button currentButton;
        private int currentCategory;
        public static List<SalesBills> billsList = new List<SalesBills>();
        private static int transactionItemId = 0;
        public static bool receiptPrinted = true;
        DirectoryInfo baseDir = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);

        // Constructor
        public SalesForm()
        {
            InitializeComponent();
        }

        public static int TrsansactionItemId
        {
            get { return transactionItemId; }
            set { transactionItemId = value; receiptPrinted = false; }
        }

        // Methods
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = Color.White;
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in FilterPanel.Controls)
            {
                if (previousBtn.GetType() != typeof(Label) && previousBtn.GetType() != typeof(PictureBox))
                {
                    previousBtn.BackColor = Color.FromArgb(255, 192, 192);
                }
            }
        }

        //method that loads the categories
        private void LoadCategories()
        {
            //clear category panel first
            CategoryPanel.Controls.Clear();

            //get categories
            DataTable categories = Program.DataTableQuery("select * from `category` order by `category_order`");

            //add "All" category
            var all = categories.NewRow();
            all["category_id"] = "0";
            all["category_name"] = "All";
            all["category_order"] = 0;
            categories.Rows.InsertAt(all, 0);

            //iterate through categories datatable, add category buttons, and add data
            foreach (DataRow category in categories.Rows)
            {
                //create new instance of category user control
                CategoryButton display = new CategoryButton();

                //insert the data from the datatable
                display.CategoryId = category["category_id"].ToString();
                display.CategoryName = category["category_name"].ToString();

                //create event handler when clicked
                display.buttonCategory.Click += new EventHandler(buttonCategory_Click);

                //add them to the panel
                CategoryPanel.Controls.Add(display.buttonCategory);
            }
        }

        //event that triggers when a category button is clicked
        private void buttonCategory_Click(object sender, EventArgs e)
        {
            //check first if the category is all
            if (((RadioButton)sender).Text == "All")
            {
                currentCategory = 0;
                PopulateSalesItems();
                return;
            }
            string categoryId = ((RadioButton)sender).AccessibleName;
            currentCategory = int.Parse(categoryId);
            PopulateSalesItems();
        }

        public void PopulateSalesItems()
        {
            //clear sales item panel first
            flowLayoutPanelSalesItems.Controls.Clear();

            //get datatable
            Program.GetItems();
            DataTable displayItems = Program.item;

            //store SalesItems to list 
            List<SalesItems> itemList = new List<SalesItems>();

            //filter the datatable
            //if category is set to something, filter the datatable
            try
            {
                if (currentCategory != 0) displayItems = displayItems.Select("category_id = " + currentCategory).CopyToDataTable();
            }
            catch (Exception)
            {
                Label noResult = new Label();
                noResult.Font = new Font("Roboto Mono Medium", 10, FontStyle.Regular);
                noResult.Text = "NoResult.";
                flowLayoutPanelSalesItems.Controls.Add(noResult);
                return;
            }
        
            if (!string.IsNullOrWhiteSpace(textBoxSales.Text))
            {
                try
                {
                    //if the textbox value is int, filter the datatable by item id
                    if (int.TryParse(textBoxSales.Text, out int result)) displayItems = displayItems.Select("item_id = " + result).CopyToDataTable();
                    //else, filter it by item name
                    else displayItems = displayItems.Select("item_name like '%" + textBoxSales.Text + "%'").CopyToDataTable();
                }
                //if the search yields no result, show no result
                catch (Exception)
                {
                    Label noResult = new Label();
                    noResult.Font = new Font("Roboto Mono Medium", 10, FontStyle.Regular);
                    noResult.Text = "NoResult.";
                    flowLayoutPanelSalesItems.Controls.Add(noResult);
                    return;
                }
            }

            foreach (DataRow item in displayItems.Rows)
            {
                //create new instance of sales item
                var display = new SalesItems(this);

                //insert data
                display.ClothesCode = item["item_id"].ToString();
                display.ClothesTitle = item["item_name"].ToString();
                display.ClothesPrice = item["selling_price"].ToString();
                display.ClothesStocks = item["stock"].ToString();
                display.ClothesFileExt = item["file_ext"].ToString();

                //set proper width, a little less than 1/4 of the flowlayoutpanel i guess
                display.Width = flowLayoutPanelSalesItems.Width / 4 - 20;
                display.SalesItemBack.Width = display.Width;

                //add sales item to the panel
                flowLayoutPanelSalesItems.Controls.Add(display);
                itemList.Add(display);
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            PopulateSalesItems();
        }

        private void buttonsSalesCash_Click(object sender, EventArgs e)
        {
            if (!receiptPrinted)
            {
                MessageBox.Show("Print the receipt of the previous transaction first before proceeding");
                return;
            }
            ButtonsCash formButtonsCash = new ButtonsCash(this);
            formButtonsCash.buttonsNumPadPay.Click += new EventHandler(ButtonsNumPadPay_Click);
            formButtonsCash.PaymentMethod = ((Button)sender).Text.ToString();
            formButtonsCash.ShowDialog();    
        }

        private void ButtonsNumPadPay_Click(object sender, EventArgs e)
        {
            PopulateSalesItems();
        }

        private void SalesForm_Load(object sender, EventArgs e)
        {
            receiptPrinted = true;
            clearAll();
            LoadCategories();
            //MessageBox.Show("e");
            //PopulateSalesItems();
        }

        private void textBoxSales_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                PopulateSalesItems();
            }
        }

        private void buttonsSalesClearAll_Click_1(object sender, EventArgs e)
        {
            clearAll();
        }

        private void clearAll()
        {
            foreach(SalesBills bill in panelBills.Controls)
            {
                //MessageBox.Show(bill.Quantity.ToString());
                bill.updateStock(bill.Quantity);
            }
            panelBills.Controls.Clear();
            labelSalesChangeValue.Text = String.Empty;
            labelSalesCashValue.Text = String.Empty;
            labelSalesTotalValue.Text = String.Empty;
            labelSalesTaxValue.Text = String.Empty;
            labelSalesSubtotalValue.Text = String.Empty;
        }

        private void buttonsSalesPrintBills_Click(object sender, EventArgs e)
        {
            buttonsSalesPrintBills.BackColor = Color.FromArgb(178, 178, 178);
            //make sure transaction is already done
            if (transactionItemId == 0)
            {
                MessageBox.Show("No Sale Transaction yet.");
                return;
            }
            //make sure the async method printrecipt is done
            if (PrintReceipt().IsCompleted)
            {
                //process object lets us open a file with a specified program
                Process p = new Process();
                p.StartInfo = new ProcessStartInfo()
                {
                    FileName = "notepad.exe",
                    Arguments = baseDir + @"Receipt.txt"
                };
                p.Start();

                //clear the salesform
                clearAll();
                //set receiptPrinted to false
                receiptPrinted = true;
            }
        }

        private async Task PrintReceipt()
        {
            //get current date time
            DateTime now = DateTime.Now;

            //display transaction item id and date and headings
            string receipt = "\n\n             Bench Official Receipt\n\n" +
                             "\nTransaction no. " + transactionItemId +
                             "\n" + now +
                             "\n----------------------------------------------" +
                             "\nQty\tDescription\t\t\tPrice" +
                             "\n----------------------------------------------";

            //loop through the salesbills add display their data to receipt
            foreach (SalesBills bill in panelBills.Controls)
            {
                //amount of tabs after clothes name depends on its string length
                string tabs = new string('\t', 4-((bill.BillsClothesTitle.Length - 1 ) / 8));

                //salesbill item data
                receipt += "\nx" + bill.textBoxBillsQuantity.Text + "\t" + bill.BillsClothesTitle + tabs + bill.labelBillsPrice.Text + "\n";
            }

            //other receipt details
            receipt += "\n\tSubtotal\t\t\t" + labelSalesSubtotalValue.Text +
                       "\n\tTax(5%)\t\t\t\t" + labelSalesTaxValue.Text +
                       "\n\tTotal\t\t\t\t" + labelSalesTotalValue.Text +
                       "\n----------------------------------------------" +
                       "\n\tPayment\t\t\t\t" + labelSalesCashValue.Text +
                       "\n\tChange\t\t\t\t" + labelSalesChangeValue.Text + "\n\n" +
                       "\n               🌺  Thank you  🌺\n\n" +
                       "\n         Returns are accepted within" +
                       "\n    thirty (30) days of this receipt only";

            await File.WriteAllTextAsync("Receipt.txt", receipt);            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
