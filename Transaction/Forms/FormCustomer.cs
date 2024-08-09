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
using Transaction.Modols;

namespace Transaction.Forms
{
    public partial class FormCustomer : Form
    {
        DataTable dtCustomer;
        public FormCustomer()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FormCustomerAddEdit form = new FormCustomerAddEdit(null);
            if (form.ShowDialog() == DialogResult.OK)
            {
                InitializeData();
            }
        }
        private void InitializeData()
        {
            dtCustomer = Customers.GetAll();

            dgCustomer.DataSource = dtCustomer;

            dgCustomer.Columns[0].Visible = false;

            //dgCustomer.Columns[1].Visible = true;
            dgCustomer.Columns[1].HeaderText = "Customer Name";
            dgCustomer.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //dgCustomer.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dgCustomer.Columns[2].Visible = false;
            dgCustomer.Columns[3].Visible = false;
            dgCustomer.Columns[4].Visible = false;
            dgCustomer.Columns[5].Visible = false;

        }

        private void FormCustomer_Load(object sender, EventArgs e)
        {
            InitializeData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgCustomer.SelectedRows.Count <= 0)
                return;

            int customerId = Convert.ToInt32(dgCustomer.SelectedRows[0].Cells["CustomerId"].Value.ToString());
            Customer customer = Customers.Get(customerId);


            FormCustomerAddEdit form = new FormCustomerAddEdit(customer);
            if (form.ShowDialog() == DialogResult.OK)
            {
                InitializeData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgCustomer.SelectedRows.Count <= 0)
                return;


            DialogResult confirm = MessageBox.Show("Are you sure to delete this Record?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes)
                return;
            int CustomerId = Convert.ToInt32(dgCustomer.SelectedRows[0].Cells["CustomerId"].Value.ToString());

            Customers.Delete(CustomerId);

            MessageBox.Show("Customer has Deleted Successfully");

            InitializeData();
        }

        private void dgCustomer_SelectionChanged(object sender, EventArgs e)
        {
            if (dgCustomer.SelectedRows.Count <= 0)
                return;

            int customerId = Convert.ToInt32(dgCustomer.SelectedRows[0].Cells["CustomerId"].Value.ToString());

            Customer customer = Customers.Get(customerId);
            if (customer != null)
            {
                txtCompanyName.Text = customer.CompanyName;
                txtPhone.Text = customer.Phone;
                txtEmail.Text = customer.Email;
                txtAddress.Text = customer.Address;
            }
        }

        private void btnCustomerList_Click(object sender, EventArgs e)
        {
            //generat data srouce for report to show
            //and provide data source to xml file
            DataTable dtCustomer = Customers.GetAll();
            //exsport to xml
            dtCustomer.TableName = "CustomerList";
            //writexmlSchema get all row all columns
            dtCustomer.WriteXmlSchema(Path.Combine(Application.StartupPath, "Reports","CustomerList.xml"),true);

            ReportDocument rptCustomerList = new ReportDocument();
            rptCustomerList.Load(Path.Combine(Application.StartupPath, "Reports", "ReportCustomerList.rpt"));

            rptCustomerList.Database.Tables[0].SetDataSource(dtCustomer);

            FormReportViewer formReportViewer = new FormReportViewer(rptCustomerList);
            formReportViewer.ShowDialog();
        }
    }
    
}
