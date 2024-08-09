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
    public partial class FormUserManagement : Form
    {
        FormMain formMain;
        DataTable dtUser;
        DataTable dtUserPermission;
        public FormUserManagement(FormMain formMain)
        {
            this.formMain = formMain;
            InitializeComponent();
            InitializeData();
        }
        void InitializeData()
        {
            dtUser = AppUsers.GetAll();

            dgUsers.DataSource = dtUser;

            dgUsers.Columns[0].Visible = false;

            dgUsers.Columns[1].HeaderText = "User Name";
            dgUsers.Columns[1].Width = 200;
            dgUsers.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgUsers.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgUsers.Columns[1].Visible = true;

            dgUsers.Columns[2].Visible = false;
            dgUsers.Columns[3].Visible = false;
            

        }
        void LoadUserPermission()
        {
            if(dgUsers.SelectedRows.Count > 0)
            {
                int userid = Convert.ToInt32(dgUsers.SelectedRows[0].Cells["AppUserId"].Value.ToString());
                dtUserPermission = AppUserPermisstions.Get(userid);

                foreach(Control control in this.pnPermission.Controls)
                {
                    if(control is CheckBox)
                    {
                        ((CheckBox)control).Checked = false;
                    }
                }
                if (dtUserPermission.Rows.Count > 0)
                {
                    foreach(DataRow row in dtUserPermission.Rows)
                    {
                        CheckBox permission = (CheckBox)this.pnPermission.Controls[row["AppUserPermission"].ToString()];
                        if(permission != null)
                        {
                            permission.Checked = true;
                        }
                    }
                }
            }
        }
        private void btnPermission_Click(object sender, EventArgs e)
        {
            DialogResult confirmation;
            confirmation = MessageBox.Show("Do you really want to update user permission?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(confirmation == DialogResult.Yes)
            {
                if(dgUsers.SelectedRows.Count > 0)
                {
                    int userid = Convert.ToInt32(dgUsers.SelectedRows[0].Cells["AppUserId"].Value.ToString());
                    AppUserPermisstions.Delete(userid);
                    foreach(Control control in this.pnPermission.Controls)
                    {
                        if (control is CheckBox)
                        {
                            bool value = ((CheckBox)control).Checked;
                            if (value)
                            {
                                AppUserPermission permission = new AppUserPermission();
                                permission.AppUserId = userid;
                                permission.PermissionName = control.Name;
                                AppUserPermisstions.Add(permission);
                            }
                        }
                    }
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FormUserManagementAddEdit formUserManagementAddEdit = new FormUserManagementAddEdit(null);
            if(formUserManagementAddEdit.ShowDialog() == DialogResult.OK)
            {
                InitializeData();
                dgUsers.Rows[dgUsers.Rows.Count - 1].Selected = true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(dgUsers.SelectedRows.Count > 0)
            {
                int selectedrow = dgUsers.SelectedRows[0].Index;
                int userid = Convert.ToInt32 (dgUsers.SelectedRows[0].Cells["AppUserId"].Value.ToString());

                AppUser user =  AppUsers.Get(userid);
                if(user != null)
                {
                    FormUserManagementAddEdit formUserManagementAddEdit = new FormUserManagementAddEdit(user);
                    if(formUserManagementAddEdit.ShowDialog() == DialogResult.OK)
                    {
                        InitializeData();
                        dgUsers.Rows[selectedrow].Selected = true;
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult confirmation;
            confirmation = MessageBox.Show("Do you really want to delete this user?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmation == DialogResult.Yes)
            {
                if (dgUsers.SelectedRows.Count > 0)
                {
                    int userid = Convert.ToInt32(dgUsers.SelectedRows[0].Cells["AppUserId"].Value.ToString());
                    AppUsers.Delete(userid);
                }
            }
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            foreach(Control control in this.pnPermission.Controls)
            {
                if(control is CheckBox)
                {
                    ((CheckBox)control).Checked = true;
                }
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.pnPermission.Controls)
            {
                if (control is CheckBox)
                {
                    ((CheckBox)control).Checked = false;
                }
            }
        }

        private void dgUsers_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex > -1)
            {
                e.Handled = true;
                using (Brush b = new SolidBrush(dgUsers.DefaultCellStyle.BackColor))
                {
                    e.Graphics.FillRectangle(b, e.CellBounds);
                }

                using (Pen p = new Pen(Brushes.Black))
                {
                    p.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                    p.Color = Color.FromArgb(33, 37, 41);
                    e.Graphics.DrawLine(p, new Point(0, e.CellBounds.Bottom -1), new Point(e.CellBounds.Right, e.CellBounds.Bottom -1));
                    e.Graphics.DrawLine(p, new Point(0, 0), new Point(e.CellBounds.Right, 0));
                }
                e.PaintContent(e.ClipBounds);
            }
        }

        private void dgUsers_SelectionChanged(object sender, EventArgs e)
        {
            LoadUserPermission();
        }

        private void FormUserManagement_Load(object sender, EventArgs e)
        {

        }

        private void pnPermission_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CustomerView_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
