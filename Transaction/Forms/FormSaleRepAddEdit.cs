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
    public partial class FormSaleRepAddEdit : Form
    {
        Salerep salerep;

        bool isnew;
        public FormSaleRepAddEdit(Salerep salerep)
        {
            InitializeComponent();
            if (salerep == null)
            {
                lblTiitle.Text = "New SaleRep";
                btnSave.Text = "Save";
                isnew = true;

                this.salerep = new Salerep();
            }
            else
            {
                lblTiitle.Text = "Edite SaleRel";
                btnSave.Text = "Update";
                isnew = false;

                txtSalerepname.Text = salerep.SaleRepName;
                txtSex.Text = salerep.Sex;
                dtpTxnDob.Text = dtpTxnDob.Value.ToString("yyyy-MM-dd");
                txtpob.Text = salerep.Pob;
                txtAddress.Text = salerep.Address;
                txtNationalcardnumber.Text = salerep.NATIONALCARDNUMBER;

                this.salerep = salerep;

            }
        }
        bool Dovalidation()
        {
            bool result = true;
            if (txtSalerepname.Text.Trim() == "")
            {
                epSaleRepName.SetError(txtSalerepname, "SaleRepName is required");
                result = false;
            }
            return result;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!Dovalidation())
                return;
            salerep.SaleRepName = txtSalerepname.Text;
            salerep.Sex = txtSex.Text;
            salerep.Dob = dtpTxnDob.Value;
            salerep.Pob = txtpob.Text;
            salerep.Address = txtAddress.Text;
            salerep.NATIONALCARDNUMBER = txtNationalcardnumber.Text;
            if (isnew)
            {
                Salereps.Add(salerep);
            }
            else
            {
                Salereps.Update(salerep);
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
