using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transaction.Forms
{
    public partial class FormReportViewer : Form
    {
        ReportDocument report;
        public FormReportViewer(ReportDocument report)
        {
            //Provide the value of parameter report  to object report
            this.report = report;
            InitializeComponent();
        }

        private void FormReportViewer_Load(object sender, EventArgs e)
        {
            //show report
            if(this.report != null)
            {
                crvViewer.ReportSource = this.report;
                crvViewer.Refresh();
            }
        }
    }
}
