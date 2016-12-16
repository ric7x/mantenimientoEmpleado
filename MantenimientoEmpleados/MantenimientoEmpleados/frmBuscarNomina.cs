using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace MantenimientoEmpleados
{
    public partial class frmBuscarNomina : Form
    {
        public frmBuscarNomina()
        {
            InitializeComponent();
        }

        private void btnImprime_Click(object sender, EventArgs e)
        {
            string con = ConfigurationManager.ConnectionStrings["cnx"].ToString();
            SqlConnection conexion = new SqlConnection(con);
           // DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            
            SqlDataAdapter da = new SqlDataAdapter("select dbo.empleado.nombre, dbo.empleado.Cargo,dbo.detallesNominas.salario,  dbo.detallesNominas.salario*0.12 as LSR,dbo.detallesNominas.salario*0.04 as SS,dbo.detallesNominas.salario*0.02 as OTROS,(dbo.detallesNominas.salario*0.12 + dbo.detallesNominas.salario*0.04 + dbo.detallesNominas.salario*0.02) as TotalDescuento,	dbo.detallesNominas.salario - (dbo.detallesNominas.salario*0.12 + dbo.detallesNominas.salario*0.04 + dbo.detallesNominas.salario*0.02) as SueltoNeto from dbo.detallesNominas INNER JOIN                         dbo.empleado ON dbo.detallesNominas.idEmpleado = dbo.empleado.id where fechaIni='" + dtp1.Value.Date + "' and fechaFin<= '" + dtp2.Value.Date + "' ", conexion);
           // SqlDataAdapter da = new SqlDataAdapter("select idEmpleado,salario, salario*0.12 as LSR,salario*0.04 as SS,salario*0.02 as OTROS,(salario*0.12 + salario*0.04 + salario*0.02) as TotalDescuento,	salario - (salario*0.12 + salario*0.04 + salario*0.02) as SueltoNeto from detallesNominas where fechaIni='" + dtp1.Value.Date + "' and fechaFin<= '" + dtp2.Value.Date + "' ", conexion);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            //dataGridView1.DataMember = "detallesNominas";
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmBuscarNomina_Load(object sender, EventArgs e)
        {

        }
    }
}
