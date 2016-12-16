namespace MantenimientoEmpleados
{
    partial class frmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSueldo = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnListaEmpl = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSueldo
            // 
            this.btnSueldo.Image = global::MantenimientoEmpleados.Properties.Resources.task;
            this.btnSueldo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSueldo.Location = new System.Drawing.Point(401, 12);
            this.btnSueldo.Name = "btnSueldo";
            this.btnSueldo.Size = new System.Drawing.Size(143, 72);
            this.btnSueldo.TabIndex = 3;
            this.btnSueldo.Text = "Generar Nomina";
            this.btnSueldo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSueldo.UseVisualStyleBackColor = true;
            this.btnSueldo.Click += new System.EventHandler(this.btnSueldo_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::MantenimientoEmpleados.Properties.Resources.Close_Window_48;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(758, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(160, 72);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = global::MantenimientoEmpleados.Properties.Resources.Manager_48;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(195, 12);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(186, 72);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar ";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnListaEmpl
            // 
            this.btnListaEmpl.Image = global::MantenimientoEmpleados.Properties.Resources.Add_User_Group_Man_Man_48;
            this.btnListaEmpl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListaEmpl.Location = new System.Drawing.Point(3, 12);
            this.btnListaEmpl.Name = "btnListaEmpl";
            this.btnListaEmpl.Size = new System.Drawing.Size(186, 72);
            this.btnListaEmpl.TabIndex = 0;
            this.btnListaEmpl.Text = "  Listado Empleado";
            this.btnListaEmpl.UseVisualStyleBackColor = true;
            this.btnListaEmpl.Click += new System.EventHandler(this.btnListaEmpl_Click);
            // 
            // button1
            // 
            this.button1.Image = global::MantenimientoEmpleados.Properties.Resources.task;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(560, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 72);
            this.button1.TabIndex = 4;
            this.button1.Text = "Buscar Nomina";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 524);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSueldo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnListaEmpl);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListaEmpl;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnSueldo;
        private System.Windows.Forms.Button button1;

    }
}