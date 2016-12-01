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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            habilitarYDeshabilitar hd = new habilitarYDeshabilitar();
            hd.deshabilitar(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAntiguedad_Click(object sender, EventArgs e)
        {

        }

        private void btnEdad_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime fechaN = dtFechaNacimiento.Value;
            DateTime fechaI = dtFechaIngreso.Value;

            string con = ConfigurationManager.ConnectionStrings["cnx"].ToString();
            SqlConnection conexion = new SqlConnection(con);
            try
            {
                conexion.Open();

                lblConexion.Text = "Conexion exitosa!";

            }
            catch (Exception x)
            {

                label1.Text = x.Message.ToString();
            }
            finally
            {
                conexion.Close();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
            
            string con = ConfigurationManager.ConnectionStrings["cnx"].ToString();
            SqlConnection conexion = new SqlConnection(con);
            string sql = " INSERT INTO empleado (nombre ,apellido ,sexo , cedula, fechaNacimiento ,fechaIngreso ,salario ,estatus) VALUES ('" + txtNombre.Text + "','" + txtApellido.Text + "','" + cmbSexo.Text + "','" + mtCedula.Text + "','" + dtFechaNacimiento.Value.Date + "','" + dtFechaIngreso.Value.Date + "','" + txtSalario.Text + "','" + txtEstatus.Text + "') ";
            

            try
            {
                conexion.Open();

                label1.Text = "Conexion exitosa!";
                SqlCommand cmd = new SqlCommand(sql, conexion);
                int res = cmd.ExecuteNonQuery();
                if (res >= 1)
                {
                    MessageBox.Show("Cliente Registrado!!!");
                }
            }
            catch (Exception x)
            {

                MessageBox.Show(x.Message.ToString());
            }
            finally
            {
                conexion.Close();
            }
        }

       

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
                    }

        private void dtFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            habilitarYDeshabilitar dh = new habilitarYDeshabilitar();
            dh.habilitar(this);
        }

        private void btnActualiza_Click(object sender, EventArgs e)
        {
            int ids;

            ids =Convert.ToInt32( txtId.Text);
            

            string con = ConfigurationManager.ConnectionStrings["cnx"].ToString();
            SqlConnection conexion = new SqlConnection(con);
            string sql = "UPDATE empleado SET nombre='" + txtNombre.Text + "',apellido='" + txtApellido.Text + "', sexo='" + cmbSexo.Text + "' , fechaNacimiento='" + dtFechaNacimiento.Value.Date + "' , fechaIngreso='" + dtFechaIngreso.Value.Date + "', cedula='" + mtCedula.Text + "' where id=" + ids + "";

            
            try
            {
                conexion.Open();            
                SqlCommand cmd = new SqlCommand(sql, conexion);
                int res = cmd.ExecuteNonQuery();
                if (res >= 1)
                {
                    MessageBox.Show("datos actualizados!!!");
                }
            }
            catch (Exception x)
            {

                MessageBox.Show(x.Message.ToString());
            }
            finally
            {

                conexion.Close();
            }
           
        }
    }
}
