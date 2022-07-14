using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace POS1.Inventory_Forms
{
    public partial class Specification : Form
    {
        public Boolean controlSelected;
        public SpecificationContent selectedSpecification;

        private string specificationTitle;
        private DataTable specificationTable;

        InventoryCreate _parent;

        public string SpecificationTitle
        {
            get { return specificationTitle; }
            set { specificationTitle = value; labelSpecificationTitle.Text = specificationTitle; }
        }

        public DataTable SpecificationTable
        {
            get { return specificationTable; }
            set 
            { 
                specificationTable = value.Copy();
                specificationTable.Columns[0].ColumnName = "id";
                specificationTable.Columns[1].ColumnName = "name";
                specificationTable.Columns[2].ColumnName = "order";
                PopulateSpecifications(); 
            }
        }

        public Specification(InventoryCreate parentForm)
        {
            InitializeComponent();
            SpecificationContentPanel.HorizontalScroll.Maximum = 0;
            SpecificationContentPanel.AutoScroll = false;
            SpecificationContentPanel.VerticalScroll.Visible = false;
            SpecificationContentPanel.AutoScroll = true;
            _parent = parentForm;
        }

        private void Specification_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        private void PopulateSpecifications()
        {
            int numControls = SpecificationContentPanel.Controls.Count - 1;
            for (int i = 0; i < numControls; i++)
            {
                SpecificationContentPanel.Controls.RemoveAt(0);
            }

            foreach (DataRow category in SpecificationTable.Rows)
            {
                SpecificationContent content = new SpecificationContent(this);

                content.SpecificationName = category["name"].ToString();
                content.SpecificationId = (int)category["id"];
                content.SpecificationOrder = (int)category["order"];

                if (specificationTitle == "Color") content.ColorMode = true;

                SpecificationContentPanel.Controls.Add(content);
                SpecificationContentPanel.Controls.SetChildIndex(content, SpecificationContentPanel.Controls.Count - 2);
            }
        }

        private void AddPanel_Click(object sender, EventArgs e)
        {
            if (controlSelected)
            {
                controlSelected = false;
                selectedSpecification.BackColor = Color.White;
                selectedSpecification.SpecificationTextBox.BackColor = Color.White;
                SpecificationContentPanel.Controls.SetChildIndex(selectedSpecification, SpecificationContentPanel.Controls.Count - 2);
            }
        }

        private void buttonsReset_Click(object sender, EventArgs e)
        {
            PopulateSpecifications();
        }

        private void buttonsAddSpecification_Click(object sender, EventArgs e)
        {
            SpecificationContent content = new SpecificationContent(this);
            content.IsNew = true;
            SpecificationContentPanel.Controls.Add(content);
            SpecificationContentPanel.Controls.SetChildIndex(content, SpecificationContentPanel.Controls.Count - 2);
            if(specificationTitle == "Color") content.ColorMode = true;
        }

        private void buttonStocksConfirm_Click(object sender, EventArgs e)
        {
            //iterate through the contents
            for(int i = 0; i < SpecificationContentPanel.Controls.Count - 1; i++)
            {
                SpecificationContent content = (SpecificationContent)SpecificationContentPanel.Controls[i];

                //check if it is a new specification
                if (content.IsNew && !String.IsNullOrEmpty(content.GetNewSpecName()))
                {
                    Program.AddSpecification(SpecificationTitle, content.GetNewSpecName(), content.GetNewSpecOrder());
                }
                else
                {
                    Program.UpdateSpecification(SpecificationTitle, content.GetNewSpecName(), content.GetNewSpecOrder(), content.SpecificationId);
                }
            }
            if(specificationTitle == "Category")
            {
                _parent.populateInventoryCreateCategory();
            }
            Close();
        }
    }
}
