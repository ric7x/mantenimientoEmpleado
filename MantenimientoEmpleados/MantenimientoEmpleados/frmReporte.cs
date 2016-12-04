using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace MantenimientoEmpleados
{
    public partial class frmReporte : Form
    {
        public frmReporte()
        {
            InitializeComponent();
        }

        private void frmReporte_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReportDocument crystalrpt = new ReportDocument();
            crystalrpt.Load(@"C:\Users\TheHangover\Source\Repos\NewRepo\MantenimientoEmpleados\MantenimientoEmpleados\CrystalReport1.rpt");
            crystalReportViewer1.ReportSource = crystalrpt;
            crystalReportViewer1.Refresh();

        }
    }
}
