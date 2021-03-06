﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MantenimientoEmpleados
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnListaEmpl_Click(object sender, EventArgs e)
        {
            frmListaEmpleados le = new frmListaEmpleados();
            le.Show(this);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show(this);
            f1.btnEliminar.Enabled = false;
            f1.btnActualiza.Enabled = false;
            f1.button2.Enabled = false;

        }

        private void btnSueldo_Click(object sender, EventArgs e)
        {
            frmCalcularSueldo cs = new frmCalcularSueldo();
            cs.Show(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmBuscarNomina bn = new frmBuscarNomina();
            bn.Show(this);
        }
    }
}
