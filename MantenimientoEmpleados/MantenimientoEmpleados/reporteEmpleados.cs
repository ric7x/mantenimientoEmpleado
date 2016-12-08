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
    public partial class SueldoEmpleados : Form
    {
        public SueldoEmpleados()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReportDocument crysta2rpt = new ReportDocument();
            crysta2rpt.Load(@"C:\Users\TheHangover\Source\Repos\NewRepo\MantenimientoEmpleados\MantenimientoEmpleados\CrystalReport2.rpt");
            crystalReportViewer1.ReportSource = crysta2rpt;
            crystalReportViewer1.Refresh();
        }

        private void SueldoEmpleados_Load(object sender, EventArgs e)
        {

        }
    }
}
