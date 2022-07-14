using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace POS1.Transaction_Forms
{
    public partial class HistoryContent : UserControl
    {
        private string historyId;
        private string historyFileExt;
        private string historyType;
        private string historyFirstItemId;
        private DateTime historyDateTime;

        //sale-related data
        private float historySubtotal;
        private float historyDiscount;
        private float historySalesTax;
        private float historyTotal;
        private float historyAmountPaid;
        private float historyChange;

        //supply-related data
        private int historySupplyTotal;
        private Boolean historyStockAdded;

        public HistoryContent()
        {
            InitializeComponent();
        }

        public string HistoryId
        {
            get { return historyId; }
            set { historyId = value; labelHistoryContentTransactionID.Text = value; }
        }

        public string HistoryFileExt
        {
            get { return historyFileExt; }
            set { historyFileExt = value; }
        }

        public string HistoryType
        {
            get { return historyType; }
            set { historyType = value; labelHistoryContentType.Text = value; }
        }

        public float HistorySubtotal
        {
            get { return historySubtotal; }
            set { historySubtotal = value; }
        }

        public float HistoryDiscount
        {
            get { return historyDiscount; }
            set { historyDiscount = value;}
        }

        public float HistorySalesTax
        {
            get { return historySalesTax; }
            set { historySalesTax = value;}
        }

        public float HistoryTotal
        {
            get { return historyTotal; }
            set { historyTotal = value; labelHistoryContentTotal.Text = value.ToString("#,##0.00"); }
        }

        public float HistoryAmountPaid
        {
            get { return historyAmountPaid; }
            set { historyAmountPaid = value; }
        }

        public float HistoryChange
        {
            get { return historyChange; }
            set { historyChange = value; }
        }

        public DateTime HistoryDateTime
        {
            get { return historyDateTime; }
            set { historyDateTime = value; labelHistoryContentDate.Text = value.ToShortDateString(); labelHistoryContentTime.Text = value.ToShortTimeString(); }
        }

        public string HistoryFirstItemId
        {
            get { return historyFirstItemId; }
            set { historyFirstItemId = value; SetImage(); }
        }

        public int HistorySupplyTotal
        {
            get { return historySupplyTotal; }
            set { historySupplyTotal = value; labelHistoryContentTotal.Text = value.ToString(); }
        }

        public Boolean HistoryStockAdded
        {
            get { return historyStockAdded; }
            set 
            { 
                historyStockAdded = value;
                if (historyStockAdded) labelHistoryContentTotal.Text = labelHistoryContentTotal.Text + " item/s added";
                else labelHistoryContentTotal.Text = labelHistoryContentTotal.Text + " item/s removed";
            }
        }

        private void SetImage()
        {
            if (historyId == null && historyFileExt == null)
            {
                return;
            }
            //gets the base directory of the project
            DirectoryInfo baseDir = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);

            try
            {
                pictureBoxHistoryContentImage.Image = Image.FromFile(baseDir + @"ItemImages\" + historyFirstItemId + "." + historyFileExt);
            }
            catch (Exception)
            {
                pictureBoxHistoryContentImage.Image = Image.FromFile(baseDir + @"ItemImages\no_image.jpg");
            }
        }

        private void viewTransactionDetails_Click(object sender, EventArgs e)
        {

        }
    }
}
