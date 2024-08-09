using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transaction.Data;
using Transaction.Models;

namespace Transaction.Forms
{
    public partial class FormVendor : Form
    {
        DataTable dtVendor;
        public FormVendor()
        {
            InitializeComponent();
        }
        private void InitializeData()
        {
            dtVendor = Vendors.Getall();
            dgVendor.DataSource = dtVendor;

            dgVendor.Columns[0].Visible = false;
            dgVendor.Columns[1].HeaderText = "Vendro Name";
            dgVendor.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgVendor.Columns[2].Visible = false;
            dgVendor.Columns[3].Visible = false;
            dgVendor.Columns[4].Visible = false;
            dgVendor.Columns[5].Visible = false;
        }

        private void dgVendor_SelectionChanged(object sender, EventArgs e)
        {
            if (dgVendor.SelectedRows.Count <= 0)
                return;

            int vendorId = Convert.ToInt32(dgVendor.SelectedRows[0].Cells["VendorId"].Value.ToString());

            Vendor vendor = Vendors.Get(vendorId);
            if (vendor != null)
            {
                txtCompanyName.Text = vendor.CompanyName;
                txtPhone.Text = vendor.Phone;
                txtEmail.Text = vendor.Email;
                txtAddress.Text = vendor.Address;
            }
        }

        private void FormVendor_Load(object sender, EventArgs e)
        {
            InitializeData();   
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FormVendorAddEdit form = new FormVendorAddEdit(null);
            if (form.ShowDialog() == DialogResult.OK)
            {
                InitializeData();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgVendor.SelectedRows.Count <= 0)
                return;

            int vendorId = Convert.ToInt32(dgVendor.SelectedRows[0].Cells["VendorId"].Value.ToString());
            Vendor vendor = Vendors.Get(vendorId);

            FormVendorAddEdit form = new FormVendorAddEdit(vendor);
            if (form.ShowDialog() == DialogResult.OK)
            {
                InitializeData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgVendor.SelectedRows.Count <= 0)
                return;

            DialogResult confirm = MessageBox.Show("Are you sure to delete this Record?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes)
                return;

            int vendorId = Convert.ToInt32(dgVendor.SelectedRows[0].Cells["VendorId"].Value.ToString());

            Vendors.Delete(vendorId);

            MessageBox.Show("Customer has Deleted Successfully");

            InitializeData();
        }
    }
}
