using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace MantenimientoEmpleados
{
    public partial class frmCalcularSueldo : Form
    {
        public frmCalcularSueldo()
        {
            InitializeComponent();
        }

        private void btnImprime_Click(object sender, EventArgs e)
        {
            string con = ConfigurationManager.ConnectionStrings["cnx"].ToString();
            SqlConnection conexion = new SqlConnection(con);

            conexion.Open();
            SqlDataAdapter da = new SqlDataAdapter("select id,nombre, cedula,cargo, salario, salario*0.12 as LSR,salario*0.04 as SS,salario*0.02 as OTROS,(salario*0.12 + salario*0.04 + salario*0.02) as TotalDescuento,	salario - (salario*0.12 + salario*0.04 + salario*0.02) as SueltoNeto from empleado order by nombre asc", conexion);
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
            SueldoEmpleados se = new SueldoEmpleados();
            se.Show(this);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string con = ConfigurationManager.ConnectionStrings["cnx"].ToString();
            SqlConnection conexion = new SqlConnection(con);


            DateTime dt1 = new DateTime();
            DateTime dt2 = new DateTime();
            dt1 = dtp1.Value.Date;
            dt2 = dtp2.Value.Date;
           // MessageBox.Show(dtp2.ToString());
            
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                string sql = "insert into detallesNominas (idEmpleado,salario,fechaIni,fechaFin) values (" + dataGridView1.Rows[i].Cells["id"].Value + "," + dataGridView1.Rows[i].Cells["salario"].Value + ",'" + dt1.ToString() + "','" + dt2.ToString() + "')";
               // MessageBox.Show(dataGridView1.Rows[i].Cells["id"].Value.ToString());
                SqlCommand cmd = new SqlCommand(sql, conexion);
                try
                {
                    conexion.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception error)
                {
                    MessageBox.Show("sd" + error);
                    throw;
                }
                finally
                {
                conexion.Close();
                }


            //string sql = "insert into detallesNominas (salario) values ('11')";
            //SqlCommand cmd = new SqlCommand(sql, conexion);
            //conexion.Open();
            //cmd.ExecuteNonQuery();
            //conexion.Close();
           
        }
    }
}
}
