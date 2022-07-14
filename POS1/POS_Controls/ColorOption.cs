using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace POS1.POS_Controls
{
    public partial class ColorOption : UserControl
    {
        private string colorId;
        private string colorName;

        public ColorOption()
        {
            InitializeComponent();
        }

        public string ColorId
        {
            get { return colorId; }
            set { colorId = value; ColorButton.AccessibleName = value; } // store the color id to accesible name
        }

        public string ColorName
        {
            get { return colorName; }
            set { colorName = value; ColorButton.BackColor = Color.FromName(colorName); }
        }
    }
}
