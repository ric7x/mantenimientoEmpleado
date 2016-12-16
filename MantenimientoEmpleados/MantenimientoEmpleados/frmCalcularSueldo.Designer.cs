namespace MantenimientoEmpleados
{
    partial class frmCalcularSueldo
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
            this.btnImprime = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.dtp2 = new System.Windows.Forms.DateTimePicker();
            this.Desde = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImprime
            // 
            this.btnImprime.Image = global::MantenimientoEmpleados.Properties.Resources.task;
            this.btnImprime.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprime.Location = new System.Drawing.Point(964, 28);
            this.btnImprime.Name = "btnImprime";
            this.btnImprime.Size = new System.Drawing.Size(152, 62);
            this.btnImprime.TabIndex = 12;
            this.btnImprime.Text = "Generar Reporte";
            this.btnImprime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprime.UseVisualStyleBackColor = true;
            this.btnImprime.Click += new System.EventHandler(this.btnImprime_Click);
            // 
            // button1
            // 
            this.button1.Image = global::MantenimientoEmpleados.Properties.Resources.Close_Window_48;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(1125, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 62);
            this.button1.TabIndex = 11;
            this.button1.Text = "Cerrar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1222, 509);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button2
            // 
            this.button2.Image = global::MantenimientoEmpleados.Properties.Resources.printer12;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(855, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 62);
            this.button2.TabIndex = 13;
            this.button2.Text = "Imprimir";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Image = global::MantenimientoEmpleados.Properties.Resources.save;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.Location = new System.Drawing.Point(732, 28);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 62);
            this.button3.TabIndex = 14;
            this.button3.Text = "Guardar";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dtp1
            // 
            this.dtp1.Location = new System.Drawing.Point(62, 70);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(200, 20);
            this.dtp1.TabIndex = 15;
            // 
            // dtp2
            // 
            this.dtp2.Location = new System.Drawing.Point(321, 70);
            this.dtp2.Name = "dtp2";
            this.dtp2.Size = new System.Drawing.Size(200, 20);
            this.dtp2.TabIndex = 16;
            // 
            // Desde
            // 
            this.Desde.AutoSize = true;
            this.Desde.Location = new System.Drawing.Point(15, 74);
            this.Desde.Name = "Desde";
            this.Desde.Size = new System.Drawing.Size(41, 13);
            this.Desde.TabIndex = 17;
            this.Desde.Text = "Desde:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Hasta:";
            // 
            // frmCalcularSueldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 655);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Desde);
            this.Controls.Add(this.dtp2);
            this.Controls.Add(this.dtp1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnImprime);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmCalcularSueldo";
            this.Text = "frmCalcularSueldo";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImprime;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.DateTimePicker dtp2;
        private System.Windows.Forms.Label Desde;
        private System.Windows.Forms.Label label2;
    }
}