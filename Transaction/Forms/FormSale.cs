using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transaction.Data;
using Transaction.Modoels;

namespace Transaction.Forms
{
    public partial class FormSale : Form
    {
        DataTable dtSale;
        DataTable dtSalDetial;
        BindingSource bsSale;
        FormMain formMain;
        //----------------------------------------------------------------
        public FormSale(FormMain formMain)
        {
            InitializeComponent();
            InitializeData();
            this.formMain = formMain;
        }
        //----------------------------------------------------------------
        void InitializeData()
        {
            LoadCutomser();
            LoadSaleRep();
            LoadSale();

        }
        //----------------------------------------------------------------
        void LoadSale()
        {
            dtSale = Sales.GetAll();
            bsSale = new BindingSource();
            bsSale.DataSource = dtSale;

            txtSaleId.DataBindings.Clear();
            txtSaleId.DataBindings.Add(new Binding("Text", bsSale, "SaleId"));
            dtpTxndate.DataBindings.Clear();
            dtpTxndate.DataBindings.Add(new Binding("Text", bsSale, "SaleDate", true));
            txtRefNumber.DataBindings.Clear();
            txtRefNumber.DataBindings.Add(new Binding("Text", bsSale, "RefNumber"));

            cboCustomer.DataBindings.Clear();
            cboCustomer.DataBindings.Add(new Binding("SelectedValue", bsSale, "CustomerId"));

            cboSaleRep.DataBindings.Clear();
            cboSaleRep.DataBindings.Add(new Binding("SelectedValue", bsSale, "SaleRepId"));

            txtNote.DataBindings.Clear();
            txtNote.DataBindings.Add(new Binding("Text", bsSale, "Note"));

            LoadSaleDetail();

        }
        //----------------------------------------------------------------
        void LoadSaleDetail()
        {
            if (bsSale.Count <= 0)
            {
                dtSalDetial = SaleDetails.Get(0);
            }
            else
            {
                DataRowView current = (DataRowView)bsSale.Current;
                int saleid = Convert.ToInt32(current["SaleId"].ToString());
                dtSalDetial = SaleDetails.Get(saleid);
            }

            dgSaledetail.Columns[0].Visible = false;
            dgSaledetail.Columns[0].DataPropertyName = "SaleDetailId";

            dgSaledetail.Columns[1].Visible = false;
            dgSaledetail.Columns[1].DataPropertyName = "SaleId";

            dgSaledetail.Columns[2].Visible = true;
            dgSaledetail.Columns[2].HeaderText = "Item";
            dgSaledetail.Columns[2].Width = 300;
            dgSaledetail.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgSaledetail.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgSaledetail.Columns[2].DataPropertyName = "ItemId";
            DataGridViewComboBoxColumn column = (DataGridViewComboBoxColumn)dgSaledetail.Columns[2];
            column.DisplayMember = "ItemName";
            column.ValueMember = "ItemId";
            column.DataSource = Items.GetAll();

            dgSaledetail.Columns[3].Visible = true;
            dgSaledetail.Columns[3].HeaderText = "Description";
            dgSaledetail.Columns[3].Width = 300;
            dgSaledetail.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgSaledetail.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgSaledetail.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgSaledetail.Columns[3].DataPropertyName = "ItemDescription";

            dgSaledetail.Columns[4].Visible = true;
            dgSaledetail.Columns[4].HeaderText = "Quantity";
            dgSaledetail.Columns[4].Width = 200;
            dgSaledetail.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgSaledetail.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgSaledetail.Columns[4].DataPropertyName = "Quantity";

            dgSaledetail.Columns[5].Visible = true;
            dgSaledetail.Columns[5].HeaderText = "Price";
            dgSaledetail.Columns[5].Width = 200;
            dgSaledetail.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgSaledetail.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgSaledetail.Columns[5].DefaultCellStyle.Format = "$,##0.00";
            dgSaledetail.Columns[5].DataPropertyName = "Price";

            dgSaledetail.Columns[6].Visible = true;
            dgSaledetail.Columns[6].HeaderText = "Amount";
            dgSaledetail.Columns[6].Width = 200;
            dgSaledetail.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgSaledetail.Columns[6].DefaultCellStyle.Format = "$,##0.00";
            dgSaledetail.Columns[6].DataPropertyName = "Amount";

            dgSaledetail.DataSource = dtSalDetial;

        }
        //----------------------------------------------------------------
        void LoadCutomser()
        {
            DataTable dtCustomer = Customers.GetAll();
            cboCustomer.DataSource = dtCustomer;
            cboCustomer.DisplayMember = "CustomerName";
            cboCustomer.ValueMember = "CustomerId";
        }
        //----------------------------------------------------------------
        void LoadSaleRep()
        {
            DataTable dtSalesRep = SalesReps.Getall();
            cboSaleRep.DataSource = dtSalesRep;
            cboSaleRep.DisplayMember = "SaleRepName";
            cboSaleRep.ValueMember = "SaleRepId";


        }
        //----------------------------------------------------------------
        void AllowEditSale(bool value)
        {
            cboCustomer.Enabled = value;
            txtRefNumber.Enabled = value;
            dtpTxndate.Enabled = value;
            cboSaleRep.Enabled = value;
            txtNote.Enabled = value;
            dgSaledetail.Enabled = value;
        }
        //----------------------------------------------------------------
        private void btnNew_Click(object sender, EventArgs e)
        {
                bsSale.AddNew();
                dtSalDetial.Rows.Clear();
        }
        //-----------------------------------------------------------------
        private void dgSaledetail_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
                if (e.RowIndex == 1 && e.ColumnIndex > -1)
                {
                    e.Handled = true;
                    using (Brush b = new SolidBrush(dgSaledetail.DefaultCellStyle.BackColor))
                    {
                        e.Graphics.FillRectangle(b, e.CellBounds);
                    }
                    using (Pen p = new Pen(Brushes.Black))
                    {
                        p.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                        p.Color = Color.FromArgb(33, 37, 41);
                        e.Graphics.DrawLine(p, new Point(0, e.CellBounds.Bottom - 1), new Point(e.CellBounds.Right, e.CellBounds.Bottom - 1));
                        e.Graphics.DrawLine(p, new Point(0, 0), new Point(e.CellBounds.Right, 0));
                    }
                    e.PaintContent(e.ClipBounds);
                }
        }

        //----------------------------------------------------------------
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            bsSale.CancelEdit();
            bsSale.MovePrevious();
            LoadSaleDetail();
        }

        //-----------------------------------------------------------------
        private void btnNext_Click(object sender, EventArgs e)
        {
            bsSale.CancelEdit();
            bsSale.MoveNext();
            LoadSaleDetail();
        }

        //-----------------------------------------------------------------
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (bsSale.Count <= 0)
                return;

            DataRowView datarow = (DataRowView)bsSale.Current;
            if (datarow.IsNew)
                return;

            DialogResult confirmation = MessageBox.Show("Are you sure to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmation != DialogResult.Yes)
                return;

            SaleDetails.Delete(Convert.ToInt32(txtSaleId.Text));
            Sales.Delete(Convert.ToInt32(txtSaleId.Text));
            MessageBox.Show("Sale has deleted successfully");

            InitializeData();
        }

        //----------------------------------------------------------------
        private void btnSave_Click(object sender, EventArgs e)
        {
                dgSaledetail.EndEdit();
            if (!Dovalidation())
                return;

            DataRowView datarow = (DataRowView)bsSale.Current;
            if (datarow.IsNew)
            {
                if (Dovalidation())
                {
                    Sale sale = new Sale();
                    sale.SaleDate = dtpTxndate.Value;
                    sale.RefNumber = txtRefNumber.Text.Trim();
                    sale.CustomerId = Convert.ToInt32(cboCustomer.SelectedValue);   
                    sale.SaleRepId = Convert.ToInt32(cboSaleRep.SelectedValue);
                    sale.Note = txtNote.Text;
                    sale.AppUserId = formMain.UserLogon.AppUserId;      
                    int saleId = Sales.Add(sale);
                    if (saleId > 0)
                    {
                        dtSalDetial.Columns["SaleId"].DefaultValue = saleId;
                        dgSaledetail.Refresh();
                        dtSalDetial.AcceptChanges();
                        foreach (DataRow row in dtSalDetial.Rows)
                        {
                            SaleDetail saleDetail = new SaleDetail();
                            saleDetail.SaleId = saleId;
                            saleDetail.ItemId = Convert.ToInt32(row["ItemId"].ToString());
                            saleDetail.ItemDesciption = row["ItemDescription"].ToString();
                            saleDetail.Quantity = Convert.ToDouble(row["Quantity"].ToString());
                            saleDetail.Price = Convert.ToDouble(row["Price"].ToString());

                            SaleDetails.Add(saleDetail);
                        }
                    }
                    MessageBox.Show("Invoice has added successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadSale();
                }
            }
            else
            {
                if (Dovalidation())
                {
                    Sale sale = new Sale();
                    sale.SaleId = Convert.ToInt32(txtSaleId.Text);
                    sale.SaleDate = dtpTxndate.Value;
                    sale.RefNumber = txtRefNumber.Text.Trim();
                    sale.CustomerId = Convert.ToInt32(cboCustomer.SelectedValue);
                    sale.SaleRepId = Convert.ToInt32(cboSaleRep.SelectedValue);
                    sale.Note = txtNote.Text;
                    sale.AppUserId = formMain.UserLogon.AppUserId;
                    Sales.Update(sale);

                    SaleDetails.Delete(sale.SaleId);
                    dgSaledetail.Refresh();
                    dtSalDetial.AcceptChanges();

                    foreach (DataRow row in dtSalDetial.Rows)
                    {
                        SaleDetail saleDetail = new SaleDetail();

                        saleDetail.SaleId = sale.SaleId;
                        saleDetail.ItemId = Convert.ToInt32(row["ItemId"].ToString());
                        saleDetail.ItemDesciption = row["ItemDescription"].ToString();
                        saleDetail.Quantity = Convert.ToDouble(row["Quantity"].ToString());
                        saleDetail.Price = Convert.ToDouble(row["Price"].ToString());

                        SaleDetails.Add(saleDetail);
                    }
                    MessageBox.Show("Invoice has update successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        //----------------------------------------------------------------
        bool Dovalidation()
        {
            bool result = true;
            if (cboCustomer.SelectedIndex < 0)
            {
                epCustomerName.SetError(cboCustomer, "Please enter customer name");
                result = false;
            }
            return result;
        }

        //--------------------------------------------------------------------------
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormSale_Load(object sender, EventArgs e)
        {

        }

        private void cboSaleRep_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSaleId_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
