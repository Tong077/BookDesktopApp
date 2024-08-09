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
    public partial class FormItemAddEdit : Form
    {
        Item item;

        bool isnew;
        public FormItemAddEdit(Item item)
        {
            InitializeComponent();

            if (item == null)
            {
                lblTiitle.Text = "New Item";
                btnSave.Text = "Save";
                isnew = true;
                this.item = new Item();
            }
            else
            {
                lblTiitle.Text = "Edit Item";
                btnSave.Text = "Update";
                isnew = false;

                txtItemName.Text = item.ItemName;
                txtDescription.Text = item.ItemDescription;
                txtQuantity.Text = item.Quantity.ToString();
                txtPrice.Text = item.Price.ToString();

                this.item = item;
            }
        }
        bool Dovalidation()
        {
            bool result = true;
            if (txtItemName.Text.Trim() == "")
            {
                epItemName.SetError(txtItemName, "ItemName is required ");
                result = false;
            }
            return result;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!Dovalidation())
                return;

            item.ItemName = txtItemName.Text;
            item.ItemDescription = txtDescription.Text;
            item.Quantity = int.Parse(txtQuantity.Text);
            item.Price = int.Parse(txtPrice.Text);


            if (isnew)
            {
                Items.Add(item);
            }
            else
            {
                Items.Update(item);
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
