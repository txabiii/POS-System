using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using POS1;

namespace POS1.POS_Controls
{
    public partial class SizeOption : UserControl
    {
        private string sizeId;
        private string sizeName;

        public SizeOption()
        {
            InitializeComponent();
        }

        public string SizeId
        {
            get { return sizeId; }
            set { sizeId = value; buttonSize.AccessibleName = sizeId; } //store in the accessible name
        }

        [Category("Custom Props")]
        public string SizeName
        {
            get { return sizeName; }
            set { sizeName = value; buttonSize.Text = sizeName; }
        }
    }
}
