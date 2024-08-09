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
    public partial class FormAdjustment : Form
    {
        DataTable dtAdjustment;
        DataTable dtAdjustmentDetial;
        BindingSource bsAdjustment;
        FormMain formMain;
        public FormAdjustment(FormMain formMain)
        {
            InitializeComponent();
            LoadAdjustment();
            this.formMain = formMain;
        }

        private void FormAdjustment_Load(object sender, EventArgs e)
        {

        }
        void LoadAdjustment()
        {

            dtAdjustment = Adjustments.GetAll();
            bsAdjustment = new BindingSource();
            bsAdjustment.DataSource = dtAdjustment;

            txtAdjustmentId.DataBindings.Clear();
            txtAdjustmentId.DataBindings.Add(new Binding("Text", bsAdjustment, "AdjustmentId"));

            dtpTxndate.DataBindings.Clear();
            dtpTxndate.DataBindings.Add(new Binding("Text", bsAdjustment, "AdjustmentDate", true));

            txtRefNumber.DataBindings.Clear();
            txtRefNumber.DataBindings.Add(new Binding("Text", bsAdjustment, "RefNumber"));

            txtRefNumber.DataBindings.Clear();
            txtRefNumber.DataBindings.Add(new Binding("Text", bsAdjustment, "Note"));

            LoadeAdjustmentDetail();
        }

        void LoadeAdjustmentDetail()
        {
            if (bsAdjustment.Count <= 0)
            {
                dtAdjustmentDetial = AdjustmentDetails.Get(0);
            }
            else
            {
                DataRowView current = (DataRowView)bsAdjustment.Current;
                int adjustmentId = Convert.ToInt32(current["AdjustmentId"].ToString());
                dtAdjustmentDetial = AdjustmentDetails.Get(adjustmentId);
            }

            dgAdjustmentDetail.Columns[0].Visible = false;
            dgAdjustmentDetail.Columns[0].DataPropertyName = "ADJUSTMENTDETAILID";

            dgAdjustmentDetail.Columns[1].Visible = false;
            dgAdjustmentDetail.Columns[1].DataPropertyName = "ADJUSTMENTID";

            dgAdjustmentDetail.Columns[2].Visible = true;
            dgAdjustmentDetail.Columns[2].HeaderText = "Item";
            dgAdjustmentDetail.Columns[2].Width = 300;
            dgAdjustmentDetail.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgAdjustmentDetail.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgAdjustmentDetail.Columns[2].DataPropertyName = "ItemId";
            DataGridViewComboBoxColumn column = (DataGridViewComboBoxColumn)dgAdjustmentDetail.Columns[2];
            column.DisplayMember = "ItemName";
            column.ValueMember = "ItemId";
            column.DataSource = Items.GetAll();

            dgAdjustmentDetail.Columns[3].Visible = true;
            dgAdjustmentDetail.Columns[3].HeaderText = "Description";
            dgAdjustmentDetail.Columns[3].Width = 300;
            dgAdjustmentDetail.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgAdjustmentDetail.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgAdjustmentDetail.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgAdjustmentDetail.Columns[3].DataPropertyName = "ItemDescription";

            dgAdjustmentDetail.Columns[4].Visible = true;
            dgAdjustmentDetail.Columns[4].HeaderText = "Quantity";
            dgAdjustmentDetail.Columns[4].Width = 200;
            dgAdjustmentDetail.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgAdjustmentDetail.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgAdjustmentDetail.Columns[4].DataPropertyName = "Quantity";

            dgAdjustmentDetail.Columns[5].Visible = true;
            dgAdjustmentDetail.Columns[5].HeaderText = "Price";
            dgAdjustmentDetail.Columns[5].Width = 200;
            dgAdjustmentDetail.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgAdjustmentDetail.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgAdjustmentDetail.Columns[5].DefaultCellStyle.Format = "$,##0.00";
            dgAdjustmentDetail.Columns[5].DataPropertyName = "Price";

            dgAdjustmentDetail.Columns[6].Visible = true;
            dgAdjustmentDetail.Columns[6].HeaderText = "Amount";
            dgAdjustmentDetail.Columns[6].Width = 200;
            dgAdjustmentDetail.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgAdjustmentDetail.Columns[6].DefaultCellStyle.Format = "$,##0.00";
            dgAdjustmentDetail.Columns[6].DataPropertyName = "Amount";

            dgAdjustmentDetail.DataSource = dtAdjustmentDetial;

        }
        void AllowEditAdjustment(bool value)
        {

            txtRefNumber.Enabled = value;
            txtNote.Enabled = value;
            dgAdjustmentDetail.Enabled = value;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            bsAdjustment.CancelEdit();
            bsAdjustment.MovePrevious();
            LoadeAdjustmentDetail();    

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (bsAdjustment.Count <= 0)
                return;

            DataRowView datarow = (DataRowView)bsAdjustment.Current;
            if (datarow.IsNew)
                return;

            DialogResult confirmation = MessageBox.Show("Are you sure to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmation != DialogResult.Yes)
                return;

            AdjustmentDetails.Delete(Convert.ToInt32(txtAdjustmentId.Text));
            Adjustments.Delete(Convert.ToInt32(txtAdjustmentId.Text));
            LoadAdjustment();

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            bsAdjustment.AddNew();
            dtAdjustmentDetial.Rows.Clear();
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            dgAdjustmentDetail.EndEdit();
            if (!Dovalidation())
                return;

            DataRowView datarow = (DataRowView)bsAdjustment.Current;

            if (datarow.IsNew)
            {
                if (Dovalidation())
                {
                    Adjustment adjustment = new Adjustment();
                    adjustment.AdjustmentDate = dtpTxndate.Value;
                    adjustment.RefNumber = txtRefNumber.Text.Trim();
                    adjustment.AppuserId = formMain.UserLogon.AppUserId;
                    
                    adjustment.Note = txtNote.Text;
                    int adjustmenid = Adjustments.Add(adjustment);
                    if (adjustmenid > 0)
                    {
                        dtAdjustmentDetial.Columns["AdjustmentId"].DefaultValue = adjustmenid;
                        dgAdjustmentDetail.Refresh();
                        dtAdjustmentDetial.AcceptChanges();
                        foreach (DataRow row in dtAdjustmentDetial.Rows)
                        {
                            AdjustmentDetail adjustmentDetail = new AdjustmentDetail();
                            adjustmentDetail.AdjustmentId = adjustmenid;
                            adjustmentDetail.ItemId = Convert.ToInt32(row["ItemId"].ToString());
                            adjustmentDetail.ItemDescription = row["ItemDescription"].ToString();
                            adjustmentDetail.Quantity = Convert.ToInt32(row["Quantity"].ToString());
                            adjustmentDetail.Price = Convert.ToInt32(row["Price"].ToString());
                            AdjustmentDetails.Add(adjustmentDetail);

                        }
                    }
                    MessageBox.Show("Adjustment has add successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAdjustment();
                }

            }
            else
            {
                if (Dovalidation())
                {
                    Adjustment adjustment = new Adjustment();
                    adjustment.AdjustmentId = Convert.ToInt32(txtAdjustmentId.Text);
                    adjustment.AdjustmentDate = dtpTxndate.Value;
                    adjustment.RefNumber = txtRefNumber.Text.Trim();
                    adjustment.AppuserId = formMain.UserLogon.AppUserId;
                    
                    adjustment.Note = txtNote.Text.Trim();
                    Adjustments.Update(adjustment);

                    AdjustmentDetails.Delete(adjustment.AdjustmentId);
                    dgAdjustmentDetail.Refresh();
                    dtAdjustmentDetial.AcceptChanges();

                    foreach (DataRow row in dtAdjustmentDetial.Rows)
                    {
                        AdjustmentDetail adjustmentDetail = new AdjustmentDetail();
                        adjustmentDetail.AdjustmentId = adjustment.AdjustmentId;
                        adjustmentDetail.ItemId = Convert.ToInt32(row["ItemId"].ToString());
                        adjustmentDetail.ItemDescription = row["ItemDescription"].ToString();
                        adjustmentDetail.Quantity = Convert.ToDouble(row["Quantity"].ToString());
                        adjustmentDetail.Price = Convert.ToDouble(row["Price"].ToString());

                        AdjustmentDetails.Add(adjustmentDetail);
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
            if (txtRefNumber.Text.Trim() == "")
            {
                epRefNumber.SetError(txtRefNumber, "RefNumber Is required !");
                result = false;
            }
            return result;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            bsAdjustment.CancelEdit();
            bsAdjustment.MoveNext();
            LoadeAdjustmentDetail();
        }
    }
}
