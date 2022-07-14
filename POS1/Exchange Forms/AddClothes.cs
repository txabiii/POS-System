using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using POS1.POS_Controls;
using POS1.Forms;
using POS1.Exchange;

namespace POS1.Exchange_Forms
{
    public partial class AddClothes : Form
    {

        // Fields
        private int quantity = 0;
        private string itemId;
        private float subtotal;
        private string selectedSizeId;
        private string selectedColorId;
        private string selectedSizeName;
        private string selectedColorName;
        private string fileExt;
        private int stock;
        private float price;
        ExchangeDetails2 _parent;


        List<ExchangeDetailsContentConfirm> billsList = new List<ExchangeDetailsContentConfirm>();

        //ExchangeSalesFormContent _parent;

        public AddClothes(ExchangeDetails2 parentForm)
        {
            _parent = parentForm;
            InitializeComponent();
            CheckNegative();
            CheckBelowStock();
            
        }

        public string ItemId
        {
            get { return itemId; }
            set { itemId = value; LoadSizeOptions(); labelViewClothesCode.Text = "item no. " + value; }
        }

        public string FileExt
        {
            get { return fileExt; }
            set { fileExt = value; }
        }

        public float Subtotal
        {
            get { return subtotal; }
            set
            {
                subtotal = 0;
                price = value;
                labelViewClothesPrice.Text = subtotal.ToString();
                unitPrice.Text = "(" + value.ToString() + ")";
            }
        }

        //Methods

        // method that gets the avaiable size options for this particular item by searching for it in the item spec datatable
        // creates new instances of size option user control, inserts the data, and add them to the UI
        private void LoadSizeOptions()
        {
            //select the rows with the proper item id
            DataTable itemSize = Program.itemSpec.Select("item_id = " + itemId, " size_order ASC").CopyToDataTable();

            //get unique sizes
            itemSize = itemSize.DefaultView.ToTable(true, "size_id", "size_name");

            //loop through the resulting datatable
            foreach (DataRow spec in itemSize.Rows)
            {
                //create new instance of the size button
                var insert = new SizeOption();

                //insert data
                insert.SizeId = spec["size_id"].ToString();
                insert.SizeName = spec["size_name"].ToString();

                //add event handler
                insert.buttonSize.Click += new EventHandler(buttonSize_Click);

                //add the button to the panel
                SizePanel.Controls.Add(insert.buttonSize);
            }
        }

        //event called when a size option is clicked
        private void buttonSize_Click(object sender, EventArgs e)
        {
            //get the size id of the selected radio button
            selectedSizeId = ((RadioButton)sender).AccessibleName;
            selectedSizeName = ((RadioButton)sender).Text;

            //get colors from the item spec table with the size id of selected size id
            //select the rows with the proper item id
            DataTable itemColor = Program.itemSpec.Select("item_id = " + itemId + " and size_id = " + selectedSizeId, " color_order ASC").CopyToDataTable();

            //get unique colors
            itemColor = itemColor.DefaultView.ToTable(true, "color_id", "color_name");

            //clear panel, colorlabel and selectedColorId, stockdata, and stock first
            ColorPanel.Controls.Clear();
            selectedColorId = null;
            ColorLabel.Text = "Color:";
            stock = 0;
            StockData.Text = "";
            quantity = 0;
            textBoxViewClothesQuantity.Text = "0";

            //get first color as default
            SetColor(itemColor.Rows[0]["color_id"].ToString(), itemColor.Rows[0]["color_name"].ToString());

            //display the colors
            foreach (DataRow color in itemColor.Rows)
            {
                //new instance of color button
                var insert = new ColorOption();

                //insert data
                insert.ColorId = color["color_id"].ToString();
                insert.ColorName = color["color_name"].ToString();

                //add event handler
                insert.ColorButton.MouseClick += ColorButton_MouseClick;

                //add to the color panel
                ColorPanel.Controls.Add(insert);
            }
        }

        private void ColorButton_MouseClick(object sender, MouseEventArgs e)
        {
            SetColor(((Button)sender).AccessibleName, ((Button)sender).BackColor.Name.ToString());
        }

        private void SetColor(string id, string name)
        {
            //get the color id that was stored in the accessible name
            selectedColorId = id;
            selectedColorName = name;

            //display in the UI
            ColorLabel.Text = "Color: " + selectedColorName;

            CheckAvailableStock();
            CheckNegative();
            CheckBelowStock();

            //enable add button
            ToggleAdd();
        }

        private void CheckAvailableStock()
        {
            //check stock is aviable
            DataTable itemStock = Program.itemSpec.Select("size_id = " + selectedSizeId + " and color_id = " + selectedColorId + " and item_id = " + itemId).CopyToDataTable();

            stock = (int)itemStock.Rows[0]["stock"];

            if (itemStock.Rows.Count > 0) StockData.Text = selectedSizeName + " | " + selectedColorName + "\nx" + itemStock.Rows[0]["stock"].ToString() + " in stock";
            else StockData.Text = selectedSizeName + " | " + selectedColorName + "\nNo Stock Avaiable";

            //display stock in the ui
            StockData.Visible = true;
        }

        private void ToggleAdd()
        {
            if (quantity != 0)
            {
                buttonsViewClothesAdd1.Enabled = true;
                buttonsViewClothesAdd1.BackgroundColor = Color.FromName("white");
            }
            else
            {
                buttonsViewClothesAdd1.Enabled = false;
                buttonsViewClothesAdd1.BackgroundColor = Color.FromName("Gainsboro");
            }
        }

        private void CheckNegative()
        {
            buttonsViewClothesMinus.Enabled = (quantity > 0);
            ToggleAdd();

            textBoxViewClothesQuantity.Text = quantity.ToString();
            labelViewClothesPrice.Text = subtotal.ToString("#,##0.00");
        }

        private void CheckBelowStock()
        {
            if (quantity >= stock)
            {
                quantity = stock;
                subtotal = quantity * price;
                labelViewClothesPrice.Text = subtotal.ToString();
                textBoxViewClothesQuantity.Text = stock.ToString();
                buttonsViewClothesPlus.Enabled = false;
            }
            else
            {
                buttonsViewClothesPlus.Enabled = true;
            }
        }

        private void buttonsViewClothesAdd_Click(object sender, EventArgs e)
        {

        }

        private void textBoxViewClothesQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void buttons1_Click(object sender, EventArgs e)
        {
            //set insert quantity
            int insertQuantity = quantity;

            //if quantity is 0, dont add bill
            if (insertQuantity == 0)
            {
                return;
            }

            //update stock amount in item datatable to prevent adding more items than there is in stock
            foreach (DataRow row in Program.itemSpec.Rows)
            {
                if (row["item_id"].ToString() == itemId && row["color_id"].ToString() == selectedColorId && row["size_id"].ToString() == selectedSizeId)
                {
                    row["stock"] = int.Parse(row["stock"].ToString()) - quantity;
                }
            }
            //update stock data and check if the quantity falls below the stock
            CheckAvailableStock();
            CheckBelowStock();

            //check if the item already exists in the salesbill panel

                //foreach (POS1.Exchange.ExchangeDetailsContentConfirm bills in _parent.flowLayoutPanelExchangeDetailsRightMiddle.Controls)
                //{
                    //if (bills.BillsClothesCode == itemId && bills.BillsClothesColorId == int.Parse(selectedColorId) && bills.BillsClothesSizeId == int.Parse(selectedSizeId))
                    //{
                        //bills.changeQuantity(insertQuantity);
                        //return;
                   // }
              // }



            POS1.Exchange.ExchangeDetailsContentConfirm newBill = new POS1.Exchange.ExchangeDetailsContentConfirm(_parent);
            newBill.BillsClothesTitle = labelViewClothesTitle.Text;
            newBill.BillsClothesPrice = price.ToString();
            newBill.BillsClothesCode = itemId;
            newBill.BillsClothesSizeName = selectedSizeName;
            newBill.BillsClothesColorName = selectedColorName;
            newBill.BillsClothesSizeId = int.Parse(selectedSizeId);
            newBill.BillsClothesColorId = int.Parse(selectedColorId);
            newBill.BillsClothesFileExt = fileExt;
            newBill.Quantity = insertQuantity;

            _parent.ExchangeDetailSubtotalRight += float.Parse((price * insertQuantity).ToString());
            _parent.ExchangeDetailSalesTaxRight += float.Parse((price * insertQuantity * 0.05).ToString());
            _parent.ExchangeDetailTotalRight += float.Parse((price * insertQuantity).ToString()) + float.Parse((price * insertQuantity * 0.05).ToString());

            //billsList.Add(newBill);
            _parent.flowLayoutPanelExchangeDetailsRightMiddle.Controls.Add(newBill);

        }

        private void buttonsViewClothesPlus_Click_1(object sender, EventArgs e)
        {
            quantity++;
            subtotal += price;
            CheckNegative();
            CheckBelowStock();
        }

        private void buttonsViewClothesMinus_Click_1(object sender, EventArgs e)
        {
            quantity--;
            subtotal -= price;
            CheckNegative();
            CheckBelowStock();
        }
    }
}
