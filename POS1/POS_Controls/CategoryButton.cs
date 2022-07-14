using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace POS1.POS_Controls
{
    public partial class CategoryButton : UserControl
    {
        //Fields
        private string categoryId;
        private string categoryName;

        private int borderSize = 2;
        private int borderRadius = 20;
        private Color borderColor = Color.Transparent;

        public CategoryButton()
        {
            InitializeComponent();
        }

        public string CategoryId
        {
            get { return categoryId; }
            set { categoryId = value; buttonCategory.AccessibleName = value; }
        }

        public string CategoryName
        {
            get { return CategoryName; }
            set { categoryName = value; buttonCategory.Text = value; }
        }

        GraphicsPath GetRoundPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }

        private void buttonCategory_Paint(object sender, PaintEventArgs e)
        {
            Rectangle rectSurface = buttonCategory.ClientRectangle;
            Rectangle rectBorder = Rectangle.Inflate(rectSurface, -borderSize, -borderSize);
            int smoothSize = 2;
            if (borderSize > 0)
                smoothSize = borderSize;

            if (borderRadius > 2) //Rounded button
            {
                using (GraphicsPath pathSurface = GetRoundPath(rectSurface, borderRadius))
                using (GraphicsPath pathBorder = GetRoundPath(rectBorder, borderRadius - borderSize))
                using (Pen penSurface = new Pen(buttonCategory.Parent.BackColor, smoothSize))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    //Button surface
                    buttonCategory.Region = new Region(pathSurface);
                    //Draw surface border for HD result
                    e.Graphics.DrawPath(penSurface, pathSurface);

                    //Button border 
                    if (borderSize >= 1)
                        //Draw control border
                        e.Graphics.DrawPath(penBorder, pathBorder);
                }
            }
            else //Normal button
            {
                e.Graphics.SmoothingMode = SmoothingMode.None;
                //Button surface
                buttonCategory.Region = new Region(rectSurface);
                //Button border
                if (borderSize >= 1)
                {
                    using (Pen penBorder = new Pen(borderColor, borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        e.Graphics.DrawRectangle(penBorder, 0, 0, buttonCategory.Width - 1, buttonCategory.Height - 1);
                    }
                }
            }
        }

        private void buttonCategory_CheckedChanged(object sender, EventArgs e)
        {
            if (buttonCategory.Checked == true)
            {
                buttonCategory.BackColor = Color.White;
                borderColor = Color.Red;
            }
            else
            {
                buttonCategory.BackColor = Color.FromArgb(255, 255, 192, 192);
                borderColor = Color.Transparent;
            }

            buttonCategory.Invalidate();
        }
    }
}
