using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace POS1.Inventory_Forms
{
    public partial class ManageStockContent : UserControl
    {
        public Boolean readOnly;
        private string stockColorName;
        private string stockSizeName;
        private int stockColorId;
        private int stockSizeId;
        private int initialStock;
        private int finalStock;
        private static DataTable sizeOptions;
        private static DataTable colorOptions;
        private Boolean sizeFlag;
        private Boolean colorFlag;

        ManageStocks _parent;

        public string StockColorName
        {
            get { return stockColorName; }
            set { stockColorName = value; labelColor.Text = value.Substring(0,1).ToUpper() + value.Substring(1); }
        }

        public string StockSizeName
        {
            get { return stockSizeName; }
            set { stockSizeName = value; labelSize.Text = value; }
        }

        public int StockColorId
        {
            get { return stockColorId; }
            set { stockColorId = value; }
        }

        public int StockSizeId
        {
            get { return stockSizeId; }
            set { stockSizeId = value; }
        }

        public int InitialStock
        {
            get { return initialStock; }
            set { initialStock = value; textBoxStock.Text = value.ToString(); finalStock = value; }
        }

        public int FinalStock
        {
            get { return finalStock; }
            set { finalStock = value; }
        }

        public Boolean ReadOnly
        {
            get { return readOnly; }
            set { readOnly = value; toggleReadOnly(); }
        }

        public DataTable SizeOptions
        {
            get { return sizeOptions; }
            set { sizeOptions = value; }
        }

        public DataTable ColorOptions
        {
            get { return colorOptions; }
            set { colorOptions = value; }
        }

        public ManageStockContent(ManageStocks parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        private void toggleReadOnly()
        {
            labelColor.Visible = readOnly;
            labelSize.Visible = readOnly;
            comboBoxColor.Visible = !readOnly;
            comboBoxSize.Visible = !readOnly;

            if (!readOnly)
            {
                MinusButton.BackColor = Color.Tomato;
            }
        }

            private void setSizes()
        {
            if (sizeOptions != null && !readOnly)
            {
                foreach (DataRow size in sizeOptions.Rows)
                {
                    comboBoxSize.Items.Add(size["size_name"].ToString());
                }
                if (comboBoxSize.Items.Count > 0)
                {
                    comboBoxSize.SelectedIndex = 0;
                }
            }
        }

        private void setColors()
        {
            if (colorOptions != null && !readOnly)
            {
                foreach (DataRow color in colorOptions.Rows)
                {
                    string colorName = color["color_name"].ToString();
                    comboBoxColor.Items.Add(colorName.Substring(0, 1).ToUpper() + colorName.Substring(1));
                }
                if (comboBoxColor.Items.Count > 0)
                {
                    comboBoxColor.SelectedIndex = 0;
                }
            }
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            if (finalStock > 0) changeStock(-1);
            else if (!readOnly)
            {
                Dispose();
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            changeStock(1);
        }

        private void checkReduced()
        {
            if (finalStock < initialStock)
            {
                textBoxStock.ForeColor = Color.Red;
            }
            else if (finalStock > initialStock)
            {
                textBoxStock.ForeColor = Color.Green;
            }
            else
            {
                textBoxStock.ForeColor = Color.Black;
            }
        }

        public void changeStock(int change)
        {
            if ((finalStock + change) < 0)
            {
                finalStock = 0;
                textBoxStock.Text = "0";
            } 
            else
            {
                finalStock += change;
                textBoxStock.Text = finalStock.ToString();

                if (finalStock == 0 && !readOnly) MinusButton.BackColor = Color.Tomato;
                else MinusButton.BackColor = Color.White;

                checkReduced();
            }
            _parent.checkStockChanges();
        }

        private void comboBoxColor_DropDown(object sender, EventArgs e)
        {
            if (!colorFlag)
            {
                setColors();
                colorFlag = true;
            }
        }

        private void comboBoxSize_DropDown(object sender, EventArgs e)
        {
            if (!sizeFlag)
            {
                setSizes();
                sizeFlag = true;
            }
        }

        private void textBoxStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxStock_KeyUp(object sender, KeyEventArgs e)
        {
            if (int.TryParse(textBoxStock.Text, out int newStock))
            {
                newStock -= finalStock;
                changeStock(newStock);
            }
        }

        private void comboBoxColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            StockColorId = (int)colorOptions.Rows[comboBoxColor.SelectedIndex]["color_id"];
        }

        private void comboBoxSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            stockSizeId = (int)sizeOptions.Rows[comboBoxSize.SelectedIndex]["size_id"];
        }
    }
}
