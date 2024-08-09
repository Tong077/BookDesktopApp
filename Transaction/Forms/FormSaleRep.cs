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
    public partial class FormSaleRep : Form
    {
        DataTable dtsalerep;
        public FormSaleRep()
        {
            InitializeComponent();
        }
        private void InitializeData()
        {
            dtsalerep = Salereps.Getall();

            dgSalerep.DataSource = dtsalerep;

            dgSalerep.Columns[0].Visible = false;

            dgSalerep.Columns[1].HeaderText = "SaleRep Name";
            dgSalerep.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgSalerep.Columns[2].Visible = false;
            dgSalerep.Columns[3].Visible = false;
            dgSalerep.Columns[4].Visible = false;
            dgSalerep.Columns[5].Visible = false;
            dgSalerep.Columns[6].Visible = false;

        }

        private void dgSalerep_SelectionChanged(object sender, EventArgs e)
        {
            if (dgSalerep.SelectedRows.Count <= 0)
                return;

            int salerepId = Convert.ToInt32(dgSalerep.SelectedRows[0].Cells["SaleRepId"].Value.ToString());

            Salerep salerep = Salereps.Get(salerepId);
            if (salerep != null)
            {
                txtSalerepName.Text = salerep.SaleRepName;
                txtSex.Text = salerep.Sex;
                dtpTxnDob.Text = salerep.Dob.ToString();
                txtpob.Text = salerep.Pob;
                txtAddress.Text = salerep.Address;
                txtNationalcardnumber.Text = salerep.NATIONALCARDNUMBER;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FormSaleRepAddEdit form = new FormSaleRepAddEdit(null);
            if (form.ShowDialog() == DialogResult.OK)
            {
                InitializeData();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgSalerep.SelectedRows.Count <= 0)
                return;

            int salerepId = Convert.ToInt32(dgSalerep.SelectedRows[0].Cells["SaleRepId"].Value.ToString());
            Salerep salerep = Salereps.Get(salerepId);

            FormSaleRepAddEdit form = new FormSaleRepAddEdit(salerep);
            if (form.ShowDialog() == DialogResult.OK)
            {
                InitializeData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgSalerep.SelectedRows.Count <= 0)
                return;

            DialogResult confirm = MessageBox.Show("Are you sure to delete this Record?",
               "Confirm",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes)
                return;

            int salerepId = Convert.ToInt32(dgSalerep.SelectedRows[0].Cells["SaleRepId"].Value.ToString());

            Salereps.Delete(salerepId);
            MessageBox.Show("Customer has Deleted Successfully");

            InitializeData();
        }

        private void FormSaleRep_Load(object sender, EventArgs e)
        {
            InitializeData();
        }
    }
}
