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
using Transaction.Modols;

namespace Transaction.Forms
{
    public partial class FormCustomerAddEdit : Form
    {

        //create fields customer for provid parameter to customer form  
        Customer customer;

        //isnew variable to control  insert new customer   or modify new data
        bool isnew;
        public FormCustomerAddEdit(Customer customer)
        {
            InitializeComponent();

            if (customer == null)
            {
                lblTiitle.Text = "New Customer";
                btnSave.Text = "Save";
                isnew = true;
                this.customer = new Customer();
            }
            else
            {
                lblTiitle.Text = "Edit Customer";
                btnSave.Text = "Update";
                isnew = false;

                txtCustomerName.Text = customer.CustomerName;
                txtCompanyName.Text = customer.CompanyName;
                txtPhone.Text = customer.Phone;
                txtEmail.Text = customer.Email;
                txtAddress.Text = customer.Address;

                //get parameters customer and return to customer object
                this.customer = customer;
            }
        }
        bool Dovalidation()
        {
            bool result = true;
            if (txtCustomerName.Text.Trim() == "")
            {
                epCustomerName.SetError(txtCustomerName, "CustomerName is required ");
                result = false;
            }
            return result;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!Dovalidation())
                return;

            // customer = new Customer();
            customer.CustomerName = txtCustomerName.Text;
            customer.CompanyName = txtCompanyName.Text;
            customer.Phone = txtPhone.Text;
            customer.Email = txtEmail.Text;
            customer.Address = txtAddress.Text;

            //use isnew variable to control new customer or modify customer
            //get class Customre add and update Customer
            if (isnew)
            {
                Customers.Add(customer);
            }
            else
            {
                Customers.Update(customer);
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
