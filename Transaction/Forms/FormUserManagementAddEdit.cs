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
    public partial class FormUserManagementAddEdit : Form
    {
        AppUser _user;
        bool newuser;
        public FormUserManagementAddEdit(AppUser user)
        {
            InitializeComponent();
            if(user == null)
            {
                this._user = new AppUser();
                lblTitle.Text = "New User";
                this.newuser = true;
                txtUserName.Focus();
            }
            else
            {
                this._user = user;
                this.newuser = false;
                lblTitle.Text = "Edit User";
                InitializeData();
                txtUserName.Focus ();
            }
        }
        void InitializeData()
        {
            txtUserName.Text = _user.UserName;
            txtPassword.Text = _user.UserPassword;
            txtConfirm_Password.Text = _user.UserPassword;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        private bool DoValidation()
        {
            bool result = true;

            if(txtUserName.Text.Trim() == "")
            {
                epUserName.SetError(txtUserName, "Please enter User Name");
            }
            return result;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (DoValidation())
            {
                _user.UserName = txtUserName.Text.Trim();
                _user.UserPassword = txtPassword.Text.Trim();
                if (newuser)
                    AppUsers.Add(_user);
                else
                    AppUsers.Update(_user);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void FormUserManagementAddEdit_Load(object sender, EventArgs e)
        {

        }
    }
}
