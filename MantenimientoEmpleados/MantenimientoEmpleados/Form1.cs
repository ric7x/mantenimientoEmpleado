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
using System.Data;

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
            mtCedula.Enabled = false;
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
            DateTime fa = DateTime.Now;
            DateTime fn = new DateTime();
            fn = dtFechaIngreso.Value;
            txtAntiguedad.Text = (fa.Year - fn.Year).ToString();
        }

        private void btnEdad_Click(object sender, EventArgs e)
        {
            DateTime fa = DateTime.Now;
            DateTime fn = new DateTime();
            fn=dtFechaNacimiento.Value;
            txtEdad.Text = (fa.Year - fn.Year).ToString();
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

        private void limpiar()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtSalario.Clear();
            txtId.Clear();
            txtEstatus.Clear();
            txtEdad.Clear();
            txtAntiguedad.Clear();
            cmbSexo.Text = "";
            mtCedula.Text = "";
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
          

            if (txtNombre.TextLength<=0)
            {
                MessageBox.Show("hay campos que no contienen datos");
            }
            
            else{
            string con = ConfigurationManager.ConnectionStrings["cnx"].ToString();
            SqlConnection conexion = new SqlConnection(con);
            string sql = " INSERT INTO empleado (nombre ,apellido ,sexo , cedula, fechaNacimiento ,fechaIngreso ,salario ,estatus,cargo) VALUES ('" + txtNombre.Text + "','" + txtApellido.Text + "','" + cmbSexo.Text + "','" + mtCedula.Text + "','" + dtFechaNacimiento.Value.Date + "','" + dtFechaIngreso.Value.Date + "','" + txtSalario.Text + "','" + txtEstatus.Text + "','" + txtCargo.Text + "') ";
            
                // Stream usado como buffer
           // System.IO.MemoryStream ms = new System.IO.MemoryStream();
            // Se guarda la imagen en el buffer
            //pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            // Se extraen los bytes del buffer para asignarlos como valor para el 
            // parámetro.

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
            limpiar();
            habilitarYDeshabilitar hd = new habilitarYDeshabilitar();
            hd.deshabilitar(this);
            mtCedula.Enabled = false;
            button2.Enabled = false;
            btnCrear.Enabled = true;
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
            txtId.Enabled = false;
            mtCedula.Enabled = true;
            btnActualiza.Enabled = false;
            btnEliminar.Enabled = false;
            button2.Enabled = true;
            txtNombre.Focus();
            btnCrear.Enabled = false;
        }

        private void btnActualiza_Click(object sender, EventArgs e)
        {

            if (txtNombre.TextLength <= 0)
            {
                MessageBox.Show("tiene que seleccionar un empleado de la lista de empleados");
            }
            else { 
            int ids;
            ids =Convert.ToInt32( txtId.Text);
            

            string con = ConfigurationManager.ConnectionStrings["cnx"].ToString();
            SqlConnection conexion = new SqlConnection(con);
            string sql = "UPDATE empleado SET nombre='" + txtNombre.Text + "',apellido='" + txtApellido.Text + "',cargo='" + txtCargo.Text + "',salario='" + txtSalario.Text + "', sexo='" + cmbSexo.Text + "' , fechaNacimiento='" + dtFechaNacimiento.Value.Date + "' , fechaIngreso='" + dtFechaIngreso.Value.Date + "', cedula='" + mtCedula.Text + "' where id=" + ids + "";

            
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtNombre.TextLength <= 0)
            {
                MessageBox.Show("tiene que seleccionar un empleado de la lista de empleados");
            }
            else
            {
                int ids;
                ids = Convert.ToInt32(txtId.Text);


                string con = ConfigurationManager.ConnectionStrings["cnx"].ToString();
                SqlConnection conexion = new SqlConnection(con);
                string sql = "DELETE FROM empleado WHERE id =" + ids;


                try
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand(sql, conexion);
                    int res = cmd.ExecuteNonQuery();
                    if (res >= 1)
                    {
                        MessageBox.Show("empleado eliminado con exito!!!");
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
                habilitarYDeshabilitar hd = new habilitarYDeshabilitar();
                limpiar();
                hd.deshabilitar(this);
                btnCrear.Enabled = true;
                btnEliminar.Enabled = false;
                btnActualiza.Enabled = false;
                
            }
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            
            
        }

        private void button3_Click_3(object sender, EventArgs e)
        {
            try
            {
                this.openFileDialog1.ShowDialog();
                if(this.openFileDialog1.FileName.Equals("")==false)
                {
                    pictureBox1.Load(this.openFileDialog1.FileName);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("no se pudo cargar la imagen");
                throw;
            }
        }
    }
}
