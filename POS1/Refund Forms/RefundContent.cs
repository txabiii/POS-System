using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace POS1.Refund_Forms
{
    public partial class RefundContent : UserControl
    {
        private string refundId;
        private string refundFileExt;
        private string refundStatus;
        private string refundFirstItemId;
        private DateTime refundDateTime;

        private float refundSubtotal;
        private float refundDiscount;
        private float refundSalesTax;
        private float refundTotal;
        public RefundContent()
        {
            InitializeComponent();
        }

        public string RefundId
        {
            get { return refundId; }
            set { refundId = value; labelRefundContentTransactionID.Text = value; }
        }

        public string RefundFileExt
        {
            get { return refundFileExt; }
            set { refundFileExt = value; }
        }

        public string RefundStatus
        {
            get { return refundStatus; }
            set { refundStatus = value; labelRefundContentStatus.Text = value; }
        }

        public DateTime RefundDateTime
        {
            get { return refundDateTime; }
            set { refundDateTime = value; labelRefundContentDate.Text = value.ToShortDateString(); labelRefundContentTime.Text = value.ToShortTimeString(); }
        }

        public string RefundFirstItemId
        {
            get { return refundFirstItemId; }
            set { refundFirstItemId = value; SetImage(); }
        }


        public float RefundSubtotal
        {
            get { return refundSubtotal; }
            set { refundSubtotal = value; }
        }

        public float RefundDiscount
        {
            get { return refundDiscount; }
            set { refundDiscount = value; }
        }

        public float RefundSalesTax
        {
            get { return refundSalesTax; }
            set { refundSalesTax = value; }
        }

        public float RefundTotal
        {
            get { return refundTotal; }
            set { refundTotal = value; labelRefundContentTotal.Text = value.ToString("#,##0.00"); }
        }

        private void SetImage()
        {
            if (refundId == null && refundFileExt == null)
            {
                return;
            }
            //gets the base directory of the project
            DirectoryInfo baseDir = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);

            try
            {
                pictureBoxRefundContentImage.Image = Image.FromFile(baseDir + @"ItemImages\" + refundFirstItemId + "." + refundFileExt);
            }
            catch (Exception)
            {
                pictureBoxRefundContentImage.Image = Image.FromFile(baseDir + @"ItemImages\no_image.jpg");
            }
        }

        private void viewRefundDetails_Click(object sender, EventArgs e)
        {

        }
    }
}
