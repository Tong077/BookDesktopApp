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
    public partial class Formlogin : Form
    {
        public Formlogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //if (Dovalidation())
            //{
            //    AppUser user = AppUsers.Login(txtUserName.Text.Trim(), txtPassword.Text.Trim());
            //    if (user == null)
            //    {
            //        MessageBox.Show("Invalid Username and Password, Please enter again.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        return;
            //    }
            //    FormMain formMain = new FormMain();
            //    formMain.UserLogin = user;
            //    this.Hide();
            //    formMain.ShowDialog();
            //    this.Close();

            //}

            if (!Dovalidation())
                return;

            AppUser user = AppUsers.Login(txtUserName.Text.Trim(), txtPassword.Text.Trim());
            if (user != null)
            {
                MessageBox.Show("Login successfully ");
                UserLogon = user;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Username and Password, Please try again.");
            }
        }
        bool Dovalidation()
        {
            bool result = true;
            if(txtUserName.Text.Trim() == "")
            {
                epUserName.SetError(txtUserName, "Please enter username.");
                result = false;
            }
            if(txtPassword.Text.Trim() == "")
            {
                epPassword.SetError(txtPassword, "Password cannot blank, Please enter password");
                result = false;
            }
            return result;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close ();

        }
        public AppUser UserLogon { get; set; }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
