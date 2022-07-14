using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace POS1.Inventory_Forms
{
    public partial class SpecificationContent : UserControl
    {
        Specification _parent;
        private int specificationId;
        private string specificationName;
        private int specificationOrder;
        private Boolean colorMode;
        private Boolean isNew;

        public Boolean ColorMode
        {
            get { return colorMode; }
            set { colorMode = value; toggleColorMode(value);  }
        }

        public string SpecificationName
        {
            get { return specificationName; }
            set 
            { 
                specificationName = value; 
                SpecificationTextBox.Text = specificationName;
            }
        }

        public int SpecificationId
        {
            get { return specificationId; }
            set { specificationId = value; }
        }

        public int SpecificationOrder
        {
            get { return specificationOrder; }
            set { specificationOrder = value; }
        }

        public Boolean IsNew
        {
            get { return isNew; }
            set { isNew = value; }
        }

        public SpecificationContent(Specification parent)
        {
            InitializeComponent();
            _parent = parent;
            toggleColorMode(false);
            //specificationOrder = parent.Controls.GetChildIndex(this);
        }

        public string GetNewSpecName()
        {
            string result = null;

            if (colorMode) result = comboBoxColor.SelectedItem.ToString();
            else result = SpecificationTextBox.Text;

            if (result != SpecificationName) return result;
            else return null;
        }

        public int? GetNewSpecOrder()
        {
            //MessageBox.Show("old: " + SpecificationOrder.ToString() + " new: " + Parent.Controls.GetChildIndex(this).ToString());
            if (IsNew) return Parent.Controls.GetChildIndex(this);
            else if (Parent.Controls.GetChildIndex(this) == SpecificationOrder) return null;
            else return Parent.Controls.GetChildIndex(this);
        }

        private void toggleColorMode(Boolean flag)
        {
            panelColor.Visible = flag;
            panelSpecificattionName.Visible = !flag;
            try
            {
                if (flag && specificationName != null)
                {
                    loadColors();
                    panelColorDisplay.BackColor = Color.FromName(specificationName);
                    comboBoxColor.SelectedIndex = comboBoxColor.FindString(specificationName);
                }
            }
            catch (Exception)
            {
                panelColor.BackColor = Color.White;
            }
        }

        private void ArrangementButton_MouseEnter(object sender, EventArgs e)
        {
            if (_parent.controlSelected)
            {
                Parent.Controls.SetChildIndex(_parent.selectedSpecification, Parent.Controls.GetChildIndex(this));
            }
        }

        private void ArrangementButton_Click(object sender, EventArgs e)
        {
            if (_parent.controlSelected)
            {
                _parent.selectedSpecification.BackColor = Color.White;
                _parent.selectedSpecification.SpecificationTextBox.BackColor = Color.White;
                _parent.controlSelected = false;
                _parent.selectedSpecification = null;
            }
            else
            {
                _parent.controlSelected = true;
                _parent.selectedSpecification = this;
                _parent.selectedSpecification.BackColor = Color.Gainsboro;
                _parent.selectedSpecification.SpecificationTextBox.BackColor = Color.Gainsboro;
            }
        }

        private void loadColors()
        {
            foreach (System.Reflection.PropertyInfo prop in typeof(Color).GetProperties())
            {
                if (prop.PropertyType.FullName == "System.Drawing.Color")
                    comboBoxColor.Items.Add(prop.Name);
            }
        }

        private void SpecificationContent_Load(object sender, EventArgs e)
        {
            
        }

        private void comboBoxColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelColorDisplay.BackColor = Color.FromName(comboBoxColor.SelectedItem.ToString());
        }

        private void comboBoxColor_DropDown(object sender, EventArgs e)
        {
            if (comboBoxColor.Items.Count == 0)
            {
                loadColors();
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (isNew)
            {
                Dispose();
            } else
            {
                if (Program.DeleteSpecification(specificationName, specificationId, _parent.SpecificationTitle)) 
                {
                    Dispose();
                }
            }
        }
    }
}
