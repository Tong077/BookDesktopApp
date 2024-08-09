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
    public partial class FormMain : Form
    {
        FormCustomer formCustomer;
        FormSaleRep formsalerep;
        FormSale formsale;
        FormItem formitem;
        FormAdjustment formAdjustment;
        FormPurchase formPurchase;
        FormUserManagement formUserManagement;

        FormMain formMain;
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            Formlogin formlogin = new Formlogin();
            if (formlogin.ShowDialog() != DialogResult.OK)
            {
                Application.Exit();
            }
            else
            {
                AppUser user = formlogin.UserLogon;
                this.UserLogon = formlogin.UserLogon;
                DataTable dtUserPermission = AppUserPermisstions.Get(user.AppUserId);

                if (user.IsAdmin)
                {
                    mUserManagement.Visible = true;
                }
                else
                {
                    mUserManagement.Visible = false;
                }
                foreach (DataRow row in dtUserPermission.Rows)
                {
                    if (row["AppUserPermission"].ToString() == "CustomerView")
                    {
                        smCustomerList.Visible = true;
                    }
                    if (row["AppUserPermission"].ToString() == "SaleRepView")
                    {
                        smSaleRepList.Visible = true;
                    }
                    if (row["AppUserPermission"].ToString() == "SaleView")
                    {
                        smCreateSale.Visible = true;
                    }
                   if (row["AppUserPermission"].ToString() == "ItemView")
                    {
                        smItemlist.Visible = true;
                    }
                   if (row["AppUserPermission"].ToString() == "AdjustmentsView")
                    {
                        smCerateAdjustments.Visible = true;
                    }
                    if (row["AppUserPermission"].ToString() == "PurchaseView")
                    {
                        smPurchase.Visible = true;
                    }
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mCustomerCenter_Click(object sender, EventArgs e)
        {
            mCustomerCenterSub.Visible = !mCustomerCenterSub.Visible;
        }

        private void mInventoryCenterSub_Click(object sender, EventArgs e)
        {
            
        }

        private void mInventoryCenter_Click(object sender, EventArgs e)
        {
            mInventoryCenterSub.Visible = !mInventoryCenterSub.Visible;
        }

        private void mCustomerCenter_MouseLeave(object sender, EventArgs e)
        {
            mCustomerCenter.BackColor = Color.FromArgb(238,238,238);
        }

        private void mCustomerCenter_MouseEnter(object sender, EventArgs e)
        {
            mCustomerCenter.BackColor = Color.Aqua;
        }

        private void mInventoryCenter_MouseEnter(object sender, EventArgs e)
        {
            mInventoryCenter.BackColor = Color.Aquamarine;
        }

        private void mInventoryCenter_MouseLeave(object sender, EventArgs e)
        {
            mInventoryCenter.BackColor = Color.FromArgb(238, 238, 238);
        }

        private void smCustomerList_MouseEnter(object sender, EventArgs e)
        {
            smCustomerList.BackColor = Color.Aquamarine;
        }

        private void smCustomerList_MouseLeave(object sender, EventArgs e)
        {
           smCustomerList.BackColor = Color.FromArgb(238, 238, 238);
        }

        private void smSaleRepList_MouseEnter(object sender, EventArgs e)
        {
            smSaleRepList.BackColor = Color.Aquamarine;
        }

        private void smSaleRepList_MouseLeave(object sender, EventArgs e)
        {
            smSaleRepList.BackColor = Color.FromArgb(238, 238, 238);
        }

        private void smCreateSale_MouseEnter(object sender, EventArgs e)
        {
            smCreateSale.BackColor = Color.Aquamarine;
        }

        private void smCreateSale_MouseLeave(object sender, EventArgs e)
        {
            smCreateSale.BackColor = Color.FromArgb(238, 238, 238);
        }

        private void panel14_MouseEnter(object sender, EventArgs e)
        {
            smItemlist.BackColor = Color.Aquamarine;
        }

        private void panel14_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void panel13_MouseEnter(object sender, EventArgs e)
        {
            smCerateAdjustments.BackColor = Color.Aquamarine;

        }

        private void panel13_MouseLeave(object sender, EventArgs e)
        {
            smCerateAdjustments.BackColor = Color.FromArgb(238, 238, 238);
        }

        private void mUserManagement_MouseEnter(object sender, EventArgs e)
        {
            mUserManagement.BackColor = Color.Aquamarine;
        }

        private void mUserManagement_MouseLeave(object sender, EventArgs e)
        {
            mUserManagement.BackColor = Color.FromArgb(238, 238, 238); 
        }

        private void mCustomerCenter_Paint(object sender, PaintEventArgs e)
        {

        }

        private void smCustomerList_Click(object sender, EventArgs e)
        {
            if(formCustomer == null)
            {
                formCustomer = new FormCustomer();
                formCustomer.TopLevel = false;
                formCustomer.FormBorderStyle = FormBorderStyle.None;
                formCustomer.WindowState = FormWindowState.Maximized;
                formCustomer.Dock = DockStyle.Fill;

                pnMain.Controls.Add(formCustomer);

                formCustomer.Show();
                formCustomer.BringToFront();
            }
            else
            {
                formCustomer.BringToFront();
            }
        }

        private void smCustomerList_Paint(object sender, PaintEventArgs e)
        {

        }

        private void smSaleRepList_Click(object sender, EventArgs e)
        {
            if(formsalerep == null)
            {
                formsalerep = new FormSaleRep();
                formsalerep.TopLevel = false;
                formsalerep.FormBorderStyle = FormBorderStyle.None;
                formsalerep.WindowState = FormWindowState.Maximized;
                formsalerep.Dock = DockStyle .Fill;

                pnMain.Controls.Add (formsalerep);

                formsalerep.Show();
                formsalerep.BringToFront();
            }
            else
            {
                formsalerep.BringToFront ();
            }
        }

        private void smCreateSale_Click(object sender, EventArgs e)
        {
            if(formsalerep == null)
            {
                formsale = new FormSale(this);
                formsale.TopLevel = false;
                formsale.FormBorderStyle = FormBorderStyle.None;
                formsale.WindowState = FormWindowState.Maximized;
                formsale.Dock = DockStyle .Fill;

                pnMain.Controls.Add (formsale);

                formsale.Show();
                formsale.BringToFront();
            }
            else
            {
                formsale.BringToFront();
            }

        }

        private void smItemlist_Click(object sender, EventArgs e)
        {
            if(formitem == null)
            {
                formitem = new FormItem();
                formitem.TopLevel = false;
                formitem.FormBorderStyle = FormBorderStyle.None;
                formitem.WindowState = FormWindowState.Maximized;
                formitem.Dock = DockStyle.Fill;

                pnMain.Controls.Add (formitem);

                formitem.Show();
                formitem.BringToFront() ;

            }
            else
            {
                formitem.BringToFront();
            }
        }

        private void mUserManagement_Click(object sender, EventArgs e)
        {
            if(formUserManagement == null)
            {
                formUserManagement = new FormUserManagement(this);
                formUserManagement.TopLevel = false;
                formUserManagement.FormBorderStyle = FormBorderStyle.None;
                formUserManagement.WindowState = FormWindowState.Maximized;
                formUserManagement.Dock = DockStyle.Fill;

                pnMain.Controls.Add(formUserManagement);

                formUserManagement.Show();
                formUserManagement.BringToFront();
            }
            else
            {
                formUserManagement.BringToFront();
            }
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            
        }

        public AppUser UserLogon { get; set; }

        private void smCerateAdjustments_Click(object sender, EventArgs e)
        {
            if(formAdjustment == null)
            {
                formAdjustment = new FormAdjustment(this);
                formAdjustment.TopLevel = false;
                formAdjustment.FormBorderStyle = FormBorderStyle.None;
                formAdjustment.WindowState = FormWindowState.Maximized;
                formAdjustment.Dock = DockStyle.Fill;
                
                pnMain.Controls.Add(formAdjustment);

                formAdjustment.Show();
                formAdjustment.BringToFront();
            }
            else
            {
                formAdjustment.BringToFront();
            }
        }

        private void smPurchase_Click(object sender, EventArgs e)
        {
            if(formPurchase == null)
            {
                formPurchase = new FormPurchase(this);
                formPurchase.TopLevel = false;
                formPurchase.FormBorderStyle = FormBorderStyle.None;
                formPurchase.WindowState = FormWindowState.Maximized;
                formPurchase.Dock = DockStyle.Fill;

                pnMain.Controls.Add(formPurchase);

                formPurchase.Show();
                formPurchase.BringToFront();
            }
            else
            {
                formPurchase.BringToFront();
            }
        }

        private void smPurchase_MouseEnter(object sender, EventArgs e)
        {
            smPurchase.BackColor = Color.Aquamarine;
        }

        private void smPurchase_MouseLeave(object sender, EventArgs e)
        {
            smPurchase  .BackColor = Color.FromArgb(238, 238, 238);
        }

        private void smItemlist_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void smItemlist_MouseLeave(object sender, EventArgs e)
        {
            smItemlist.BackColor = Color.FromArgb(238, 238, 238);
        }

        private void mInventoryCenterSub_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mCustomerCenterSub_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
