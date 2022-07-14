using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using POS1.Exchange;

namespace POS1.Exchange_Forms
{
    public partial class ExchangeSalesForm : Form
    {

        public ExchangeDetails2 _parent;
        public ExchangeSalesForm(ExchangeDetails2 parent)
        {
            _parent = parent;
            InitializeComponent();
            PopulateExchangeSalesItems();
        }

        public void PopulateExchangeSalesItems()
        {
            Program.GetItems();
            DataTable displayItems = Program.item;
            

            foreach (DataRow item in displayItems.Rows)
            {
                //create new instance of sales item
                ExchangeSalesFormContent display = new ExchangeSalesFormContent(_parent);
                //this.ExchangeSalesFormPanel.SetFlowBreak(this.ExchangeSalesFormPanel, true);
                //MessageBox.Show("test");

                //insert data
                display.ClothesCode = item["item_id"].ToString();
                display.ClothesTitle = item["item_name"].ToString();
                display.ClothesPrice = item["selling_price"].ToString();
                display.ClothesStocks = item["stock"].ToString();
                display.ClothesFileExt = item["file_ext"].ToString();

                //set proper width, a little less than 1/4 of the flowlayoutpanel i guess
                //display.Width = ExchangeSalesFormPanel.Width - 700;
                //display.Height = ExchangeSalesFormPanel.Height - 350;
                display.SalesItemBack.Width = display.Width;

                //add sales item to the panel
                ExchangeSalesFormPanel.Controls.Add(display);
                //itemList.Add(display);
            }
        }
    }
}
