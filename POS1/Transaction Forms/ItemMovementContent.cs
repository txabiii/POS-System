using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using POS1;

namespace POS1.Transaction_Forms
{
    public partial class ItemMovementContent : UserControl
    {

        private DateTime contentDate;
        private String contentItemId;
        private String contentName;
        private String contentSupplier;
        private int contentQuantity;
        private String contentTransactionId;
        private String contentStatus;
        private string contentFileExt;

        public ItemMovementContent()
        {
            InitializeComponent();
        }

        public DateTime ContentDate
        {
            get { return contentDate; }
            set { contentDate = value; labelItemMovementDate.Text = value.ToString(); }
        }

        public String ContentItemId
        {
            get { return contentItemId; }
            set { contentItemId = value; labelItemMovementProductID.Text = value; }
        }

        public String ContentName
        {
            get { return contentName; }
            set { contentName = value; labelItemMovementProductName.Text = value; }
        }

        public String ContentSupplier
        {
            get { return contentSupplier; }
            set { contentSupplier = value; labelItemMovementSource.Text = value; }
        }

        public int ContentQuantity
        {
            get { return contentQuantity; }
            set { contentQuantity = value; labelItemMovementChangeQuantity.Text = value.ToString(); }
        }

        public String ContentTransactionID
        {
            get { return contentTransactionId; }
            set { contentTransactionId = value; labelItemMovementActionDetail.Text = value; }
        }

        public String ContentStatus
        {
            get { return contentStatus; }
            set { contentStatus = value; label1.Text = value; }
        }

        public String ContentFileExt
        {
            get { return contentFileExt; }
            set { contentFileExt = value; label1.Text = value; SetImage(); }
        }

        private void SetImage()
        {
            if (!String.IsNullOrEmpty(contentItemId) && !String.IsNullOrEmpty(contentFileExt))
            {
                itemMovementContentPictureBox.Image = Program.GetImage(contentItemId, ContentFileExt);
            }
        }
    }
}
