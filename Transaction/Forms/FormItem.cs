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
    public partial class FormItem : Form
    {
        DataTable dtItem;
        public FormItem()
        {
            InitializeComponent();
        }
        void Initializedata()
        {
            dtItem = Items.GetAll();

            dgItem.DataSource = dtItem;

            dgItem.Columns[0].Visible = false;

            //dgCustomer.Columns[1].Visible = true;
            dgItem.Columns[1].HeaderText = "Item Name";
            dgItem.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //dgCustomer.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dgItem.Columns[2].Visible = false;
            dgItem.Columns[3].Visible = false;
            dgItem.Columns[4].Visible = false;

        }

        private void FormItem_Load(object sender, EventArgs e)
        {
            Initializedata();
        }

        private void dgItem_SelectionChanged(object sender, EventArgs e)
        {
            if (dgItem.SelectedRows.Count <= 0)
                return;

            int itemid = Convert.ToInt32(dgItem.SelectedRows[0].Cells["ItemId"].Value.ToString());


            Item item = Items.Get(itemid);
            if (item != null)
            {
                txtItemName.Text = item.ItemName;
                txtDescription.Text = item.ItemDescription;
                txtQuantity.Text = item.Quantity.ToString();
                txtPrice.Text = item.Price.ToString();
            }

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FormItemAddEdit form = new FormItemAddEdit(null);
            if (form.ShowDialog() == DialogResult.OK)
            {
                Initializedata();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgItem.SelectedRows.Count <= 0)
                return;

            int itemid = Convert.ToInt32(dgItem.SelectedRows[0].Cells["ItemId"].Value.ToString());

            Item item = Items.Get(itemid);

            FormItemAddEdit form = new FormItemAddEdit(item);
            if (form.ShowDialog() == DialogResult.OK)
            {
                Initializedata();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgItem.SelectedRows.Count <= 0)
                return;

            DialogResult confirm = MessageBox.Show("Are you sure to delete this Record?",
               "Confirm",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes)
                return;

            int itemid = Convert.ToInt32(dgItem.SelectedRows[0].Cells["ItemId"].Value.ToString());
            Items.Delete(itemid);

            MessageBox.Show("Customer has Deleted Successfully");
            Initializedata();
        }
    }
}
