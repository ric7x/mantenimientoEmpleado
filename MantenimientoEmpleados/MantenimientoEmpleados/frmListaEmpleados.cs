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

        public string nombre;
        public string apellido;
        public string sexo;
        public string fechaNacimiento;
        public string estatus;
        public string salario;
        public string fechaIngreso;

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

        private void button2_Click(object sender, EventArgs e)
        {
            string con = ConfigurationManager.ConnectionStrings["cnx"].ToString();
            SqlConnection conexion = new SqlConnection(con);

            conexion.Open();
            SqlDataAdapter da = new SqlDataAdapter("select *from empleado where nombre='"+textBox1.Text+"'", conexion);
            DataSet ds = new DataSet();
            da.Fill(ds, "empleado");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "empleado";
            conexion.Close();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        public void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            nombre = dataGridView1.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
            apellido = dataGridView1.Rows[e.RowIndex].Cells["apellido"].Value.ToString();
            sexo = dataGridView1.Rows[e.RowIndex].Cells["sexo"].Value.ToString();
            fechaNacimiento = dataGridView1.Rows[e.RowIndex].Cells["fechaNacimiento"].Value.ToString();
            fechaIngreso = dataGridView1.Rows[e.RowIndex].Cells["fechaIngreso"].Value.ToString();
            salario = dataGridView1.Rows[e.RowIndex].Cells["salario"].Value.ToString();
            estatus = dataGridView1.Rows[e.RowIndex].Cells["estatus"].Value.ToString();

            Form1 f1 = new Form1();
            f1.txtNombre.Text = nombre;
            f1.txtApellido.Text = apellido;
            f1.txtEstatus.Text = estatus;
            f1.dtFechaNacimiento.Text = fechaNacimiento;
            f1.cmbSexo.Text = sexo;
            f1.txtSalario.Text = salario;

            f1.Show();
            
            
        }
    }
}
