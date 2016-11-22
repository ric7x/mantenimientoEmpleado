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
    public partial class frmListaEmpleados : Form
    {
        public frmListaEmpleados()
        {
            InitializeComponent();
        }

        private void frmListaEmpleados_Load(object sender, EventArgs e)
        {
            cargarEmpleados();
        }
        public void cargarEmpleados()
        {
            string con = ConfigurationManager.ConnectionStrings["cnx"].ToString();
            SqlConnection conexion = new SqlConnection(con);

            conexion.Open();
            SqlDataAdapter da = new SqlDataAdapter("select *from empleado", conexion);
            DataSet ds = new DataSet();
            da.Fill(ds, "empleado");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "empleado";
            conexion.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
