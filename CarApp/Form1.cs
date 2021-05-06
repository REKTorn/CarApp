using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;

namespace CarApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitListView();
            tbxRegNr.Focus();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbxRegNr.Text))
            {
                tbxRegNr.Text = tbxRegNr.Text.ToUpper();
                PrintData(tbxRegNr.Text);
            }
            else
            {
                MessageBox.Show("Du måste ange ett registreringsnummer", "Inmatning Saknas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxRegNr.Text) || string.IsNullOrEmpty(tbxMake.Text))
            {
                MessageBox.Show("You have to fill all the boxes", "Invalid input");
            }
            else
            {
                Car car = new Car(tbxRegNr.Text, tbxMake.Text, tbxModel.Text, Convert.ToInt32(tbxYear.Text), cbxForSale.Checked);
                AddCarToListView(car);

                int result = dbObject.AddCarRow(car);
                MessageBox.Show("You have added " + Convert.ToString(result) + " cars.");

                ClearTextboxes();
                btnClearAll.Enabled = true;
            }
        }

        private void AddCarToListView(Car car)
        {
            ListViewItem item = CreateListViewItem(car);
            lsvCars.Items.Add(item);
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
