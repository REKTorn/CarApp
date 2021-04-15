using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tbxRegNr.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxRegNr.Text) || string.IsNullOrEmpty(tbxMake.Text))
            {
                MessageBox.Show("You have to fill all the boxes", "Invalid input");
            }
            else
            {
                ListViewItem item = CreateListViewItem(tbxRegNr.Text, tbxMake.Text, tbxModel.Text, tbxYear.Text, cbxForSale.Checked);
                lsvCars.Items.Add(item);
                ClearTextboxes();
                btnClearAll.Enabled = true;
            }
        }

        private ListViewItem CreateListViewItem(string regNr, string make, string model, string year, bool forSale)
        {
            ListViewItem item = new ListViewItem(regNr);
            item.SubItems.Add(make);
            item.SubItems.Add(model);
            item.SubItems.Add(year);
            item.SubItems.Add(forSale ? "Yes" : "No");
            return item;
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            lsvCars.Items.Clear();
            tbxRegNr.Focus();
        }

        private void btnRemoveMarked_Click(object sender, EventArgs e)
        {
            if (lsvCars.SelectedItems.Count > 0)
            {
                var item = lsvCars.SelectedItems[0];
                lsvCars.Items.Remove(item);
                MessageBox.Show("The car with registration number '" + item.Text + "' is removed", "Removal of vehicle");
            }
            else
            {
                MessageBox.Show("No car was highlighted to be removed", "Removal of vehicle");
            }
            btnClearAll.Enabled = (lsvCars.Items.Count > 0);
        }

        private void lsvCars_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRemoveMarked.Enabled = (lsvCars.SelectedItems.Count > 0);
        }

        private void ClearTextboxes()
        {
            tbxRegNr.Clear();
            tbxMake.Clear();
            tbxModel.Clear();
            tbxYear.Clear();
            cbxForSale.Checked = false;
            tbxRegNr.Focus();
        }
    }
}
