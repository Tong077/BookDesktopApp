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
    public partial class FormVendorAddEdit : Form
    {
        Vendor vendor;
        bool isnew;
        public FormVendorAddEdit(Vendor vendor)
        {
            InitializeComponent();
            if (vendor == null)
            {
                lblTiitle.Text = "New Vendor";
                btnSave.Text = "Save";
                isnew = true;
                this.vendor = new Vendor();
            }
            else
            {
                lblTiitle.Text = "Edit Vendor";
                btnSave.Text = "Update";
                isnew = false;

                txtVendorName.Text = vendor.VendorName;
                txtCompanyName.Text = vendor.CompanyName;
                txtPhone.Text = vendor.Phone;
                txtEmail.Text = vendor.Email;
                txtAddress.Text = vendor.Address;

                this.vendor = vendor;
            }
        }
        bool Dovalidation()
        {
            bool result = true;
            if (txtVendorName.Text.Trim() == "")
            {
                epVendorName.SetError(txtVendorName, "Vendor Name  is required");
                result = false;
            }
            return result;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!Dovalidation())
                return;


            vendor.VendorName = txtVendorName.Text;
            vendor.CompanyName = txtCompanyName.Text;
            vendor.Phone = txtPhone.Text;
            vendor.Email = txtEmail.Text;
            vendor.Address = txtAddress.Text;

            if (isnew)
            {
                Vendors.Add(vendor);
            }
            else
            {
                Vendors.Update(vendor);
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
