namespace MantenimientoEmpleados
{
    partial class frmBuscarNomina
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
            this.label2 = new System.Windows.Forms.Label();
            this.Desde = new System.Windows.Forms.Label();
            this.dtp2 = new System.Windows.Forms.DateTimePicker();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.btnbuscarReportes = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Hasta:";
            // 
            // Desde
            // 
            this.Desde.AutoSize = true;
            this.Desde.Location = new System.Drawing.Point(2, 61);
            this.Desde.Name = "Desde";
            this.Desde.Size = new System.Drawing.Size(41, 13);
            this.Desde.TabIndex = 26;
            this.Desde.Text = "Desde:";
            // 
            // dtp2
            // 
            this.dtp2.Location = new System.Drawing.Point(308, 57);
            this.dtp2.Name = "dtp2";
            this.dtp2.Size = new System.Drawing.Size(200, 20);
            this.dtp2.TabIndex = 25;
            // 
            // dtp1
            // 
            this.dtp1.Location = new System.Drawing.Point(49, 57);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(200, 20);
            this.dtp1.TabIndex = 24;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1222, 445);
            this.dataGridView1.TabIndex = 19;
            // 
            // button2
            // 
            this.button2.Image = global::MantenimientoEmpleados.Properties.Resources.printer12;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(842, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 62);
            this.button2.TabIndex = 22;
            this.button2.Text = "Imprimir";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnbuscarReportes
            // 
            this.btnbuscarReportes.Image = global::MantenimientoEmpleados.Properties.Resources.task;
            this.btnbuscarReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnbuscarReportes.Location = new System.Drawing.Point(951, 15);
            this.btnbuscarReportes.Name = "btnbuscarReportes";
            this.btnbuscarReportes.Size = new System.Drawing.Size(152, 62);
            this.btnbuscarReportes.TabIndex = 21;
            this.btnbuscarReportes.Text = "Buscar Reportes";
            this.btnbuscarReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnbuscarReportes.UseVisualStyleBackColor = true;
            this.btnbuscarReportes.Click += new System.EventHandler(this.btnImprime_Click);
            // 
            // button1
            // 
            this.button1.Image = global::MantenimientoEmpleados.Properties.Resources.Close_Window_48;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(1112, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 62);
            this.button1.TabIndex = 20;
            this.button1.Text = "Cerrar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmBuscarNomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 587);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Desde);
            this.Controls.Add(this.dtp2);
            this.Controls.Add(this.dtp1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnbuscarReportes);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmBuscarNomina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Nomina";
            this.Load += new System.EventHandler(this.frmBuscarNomina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Desde;
        private System.Windows.Forms.DateTimePicker dtp2;
        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnbuscarReportes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}