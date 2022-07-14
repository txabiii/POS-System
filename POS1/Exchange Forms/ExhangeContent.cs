using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace POS1.Exchange
{
    public partial class ExhangeContent : UserControl
    {

        private int exchangeId;
        private string exchangeFileExt;
        private string exchangeStatus;
        private int exchangeFirstItemId;
        private DateTime exchangeDateTime;

        private float exchangeSubtotal;
        private float exchangeDiscount;
        private float exchangeSalesTax;
        private float exchangeTotal;
        public ExhangeContent()
        {
            InitializeComponent();
        }

        public int ExchangeId
        {
            get { return exchangeId; }
            set { exchangeId = value; labelExchangeContentTransactionID.Text = value.ToString(); }
        }

        public string ExchangeFileExt
        {
            get { return exchangeFileExt; }
            set { exchangeFileExt = value; }
        }

        public string ExchangeStatus
        {
            get { return exchangeStatus; }
            set { exchangeStatus = value; labelExchangeContentStatus.Text = value; }
        }

        public DateTime ExchangeDateTime
        {
            get { return exchangeDateTime; }
            set { exchangeDateTime = value; labelExchangeContentDate.Text = value.ToShortDateString(); labelExchangeContentTime.Text = value.ToShortTimeString(); }
        }

        public string ExchangeFirstItemId
        {
            get { return exchangeFirstItemId.ToString(); }
            set { exchangeFirstItemId = Convert.ToInt32(value); SetImage(); }
        }


        public float ExchangeSubtotal
        {
            get { return exchangeSubtotal; }
            set { exchangeSubtotal = value; }
        }

        public float ExchangeDiscount
        {
            get { return exchangeDiscount; }
            set { exchangeDiscount = value; }
        }

        public float ExchangeSalesTax
        {
            get { return exchangeSalesTax; }
            set { exchangeSalesTax = value; }
        }

        public float ExchangeTotal
        {
            get { return exchangeTotal; }
            set
            {
                exchangeTotal = value; labelExchangeContentTotal.Text = value.ToString("#,##0.00");
            }

        }

        private void SetImage()
        {
            if (exchangeFileExt == null)
            {
                return;
            }
            //gets the base directory of the project
            DirectoryInfo baseDir = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);

            try
            {
                pictureBoxExchangeContentImage.Image = Image.FromFile(baseDir + @"ItemImages\" + exchangeFirstItemId + "." + exchangeFileExt);
            }
            catch (Exception)
            {
                pictureBoxExchangeContentImage.Image = Image.FromFile(baseDir + @"ItemImages\no_image.jpg");
            }
        }
    }
}
