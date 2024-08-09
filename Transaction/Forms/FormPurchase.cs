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
using Transaction.Modoels;

namespace Transaction.Forms
{
    public partial class FormPurchase : Form
    {
        DataTable dtPurchase;
        DataTable dtPurchaseDetail;
        BindingSource bsPurchase;
        FormMain formMain;
        public FormPurchase(FormMain formMain)
        {
            InitializeComponent();
            InitializeData();
            this.formMain = formMain;
        }

        private void FormPurchase_Load(object sender, EventArgs e)
        {

        }
        void LoadPurchase()
        {
            dtPurchase = Purchases.GetAll();
            bsPurchase = new BindingSource();
            bsPurchase.DataSource = dtPurchase;

            txtPurchaseId.DataBindings.Clear();
            txtPurchaseId.DataBindings.Add(new Binding("Text", bsPurchase, "PurchaseId"));

            dtpTxndate.DataBindings.Clear();
            dtpTxndate.DataBindings.Add(new Binding("Text", bsPurchase, "PurchaseDate"));

            cboVendor.DataBindings.Clear();
            cboVendor.DataBindings.Add(new Binding("SelectedValue", bsPurchase, "VendorId"));

            txtNote.DataBindings.Clear();
            txtNote.DataBindings.Add(new Binding("Text", bsPurchase, "Note"));
            
            LoadPurchaseDetail();

        }
        void LoadPurchaseDetail()
        {
            if (bsPurchase.Count <= 0)
            {
                dtPurchaseDetail = PurchaseDetails.Get(0);
            }
            else
            {
                DataRowView current = (DataRowView)bsPurchase.Current;
                int purchaseid = Convert.ToInt32(current["PurchaseId"].ToString());
                dtPurchaseDetail = PurchaseDetails.Get(purchaseid);
            }

            dgPurchaseDetail.Columns[0].Visible = false;
            dgPurchaseDetail.Columns[0].DataPropertyName = "PurchaseDetailId";

            dgPurchaseDetail.Columns[1].Visible = false;
            dgPurchaseDetail.Columns[1].DataPropertyName = "PurchaseId";

            dgPurchaseDetail.Columns[2].Visible = true;
            dgPurchaseDetail.Columns[2].HeaderText = "Item";
            dgPurchaseDetail.Columns[2].Width = 300;
            dgPurchaseDetail.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgPurchaseDetail.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgPurchaseDetail.Columns[2].DataPropertyName = "ItemId";
            DataGridViewComboBoxColumn column = (DataGridViewComboBoxColumn)dgPurchaseDetail.Columns[2];
            column.DisplayMember = "ItemName";
            column.ValueMember = "ItemId";
            column.DataSource = Items.GetAll();

            dgPurchaseDetail.Columns[3].Visible = true;
            dgPurchaseDetail.Columns[3].HeaderText = "Description";
            dgPurchaseDetail.Columns[3].Width = 300;
            dgPurchaseDetail.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgPurchaseDetail.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgPurchaseDetail.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgPurchaseDetail.Columns[3].DataPropertyName = "ItemDescription";

            dgPurchaseDetail.Columns[4].Visible = true;
            dgPurchaseDetail.Columns[4].HeaderText = "Quantity";
            dgPurchaseDetail.Columns[4].Width = 200;
            dgPurchaseDetail.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgPurchaseDetail.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgPurchaseDetail.Columns[4].DataPropertyName = "Quantity";

            dgPurchaseDetail.Columns[5].Visible = true;
            dgPurchaseDetail.Columns[5].HeaderText = "Price";
            dgPurchaseDetail.Columns[5].Width = 200;
            dgPurchaseDetail.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgPurchaseDetail.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgPurchaseDetail.Columns[5].DefaultCellStyle.Format = "$,##0.00";
            dgPurchaseDetail.Columns[5].DataPropertyName = "Price";

            dgPurchaseDetail.Columns[6].Visible = true;
            dgPurchaseDetail.Columns[6].HeaderText = "Amount";
            dgPurchaseDetail.Columns[6].Width = 200;
            dgPurchaseDetail.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgPurchaseDetail.Columns[6].DefaultCellStyle.Format = "$,##0.00";
            dgPurchaseDetail.Columns[6].DataPropertyName = "Amount";

            dgPurchaseDetail.DataSource = dtPurchaseDetail;

        }
        void InitializeData()
        {
            LoadVendor();
            LoadPurchase();
        }
        void LoadVendor()
        {
            DataTable dtVendor = Vendors.Getall();
            cboVendor.DataSource = dtVendor;
            cboVendor.DisplayMember = "VendorName";
            cboVendor.ValueMember = "VendorId";
        }
        void AllowEditePurchase(bool value)
        {
            
            dtpTxndate.Enabled = value;
            cboVendor.Enabled = value;
            txtNote.Enabled = value;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            bsPurchase.CancelEdit();
            bsPurchase.MovePrevious();
            LoadPurchaseDetail();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            bsPurchase.CancelEdit();
            bsPurchase.MoveNext();
            LoadPurchaseDetail();
           
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            bsPurchase.AddNew();
            dtPurchaseDetail.Rows.Clear();
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (bsPurchase.Count <= 0)
                return;

            DataRowView datarow = (DataRowView)bsPurchase.Current;
            if (datarow.IsNew)
                return;

            DialogResult confirmation = MessageBox.Show("Are you sure to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmation != DialogResult.Yes)
                return;

            PurchaseDetails.Delete(Convert.ToInt32(txtPurchaseId.Text));
            Purchases.Delete(Convert.ToInt32(txtPurchaseId.Text));
            MessageBox.Show("Sale has deleted successfully");

            InitializeData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            dgPurchaseDetail.EndEdit();
            if (!Dovalidation())
                return;

            DataRowView datarow = (DataRowView)bsPurchase.Current;

            if (datarow.IsNew)
            {
                Purchase purchase = new Purchase();
                purchase.PurchaseDate = dtpTxndate.Value;
                purchase.VendorId = Convert.ToInt32( cboVendor.SelectedValue);
                purchase.Note = txtNote.Text;
                purchase.AppuserId = formMain.UserLogon.AppUserId;
                

                int purchaseid = Purchases.Add(purchase);
                if(purchaseid > 0)
                {
                    dtPurchaseDetail.Columns["PurchaseId"].DefaultValue = purchaseid;
                    dgPurchaseDetail.Refresh();
                    dtPurchaseDetail.AcceptChanges();
                    foreach (DataRow row in dtPurchaseDetail.Rows)
                    {
                        PurchaseDetail purchaseDetail = new PurchaseDetail();
                        purchaseDetail.PurchaseId = purchaseid;
                        purchaseDetail.ItemId = Convert.ToInt32 (row["ItemId"].ToString());
                        purchaseDetail.ItemDescription = row["ItemDescription"].ToString();
                        purchaseDetail.Quantity = Convert.ToDouble (row["Quantity"].ToString());
                        purchaseDetail.Price = Convert.ToDouble(row["Price"].ToString());

                        PurchaseDetails.Add(purchaseDetail);

                    }
                    MessageBox.Show("Invoice has added successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadPurchase();
                }
            }
            else
            {
                if (Dovalidation())
                {
                    Purchase purchase = new Purchase();
                    purchase.PurchaseID = Convert.ToInt32 (txtPurchaseId.Text);
                    purchase.PurchaseDate = dtpTxndate.Value;
                    purchase.VendorId = Convert.ToInt32(cboVendor.SelectedValue);
                    purchase.Note = txtNote.Text;
                    purchase.AppuserId = formMain.UserLogon.AppUserId;
                    Purchases.Update(purchase);

                    PurchaseDetails.Delete(purchase.PurchaseID);
                    dgPurchaseDetail.Refresh();
                    dtPurchaseDetail.AcceptChanges();

                    foreach( DataRow row in dtPurchaseDetail.Rows)
                    {
                        PurchaseDetail purchaseDetail = new PurchaseDetail();

                        purchaseDetail.PurchaseId = purchase.PurchaseID;
                        purchaseDetail.ItemId = Convert.ToInt32( row["ItemId"].ToString());
                        purchaseDetail.ItemDescription = row["ItemDescription"].ToString();
                        purchaseDetail.Quantity = Convert.ToDouble( row["Quantity"].ToString());
                        purchaseDetail.Price = Convert.ToDouble(row["Price"].ToString());

                        PurchaseDetails.Add(purchaseDetail);
                    }
                    MessageBox.Show("Invoice has update successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        bool Dovalidation()
        {
            bool result = true;
            if(cboVendor.SelectedIndex < 0)
            {
                epVendorName.SetError(cboVendor, "Please enter VendorName");
                result = false;
            }
            return result;
        }

        private void dgPurchaseDetail_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == 1 && e.ColumnIndex > -1)
            {
                e.Handled = true;
                using (Brush b = new SolidBrush(dgPurchaseDetail.DefaultCellStyle.BackColor))
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
    }
}
