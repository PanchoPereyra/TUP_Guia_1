namespace EmpresaTransporte
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnIniciarViaje = new System.Windows.Forms.Button();
            this.btnIngresaParada = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbHoraFinalizacion = new System.Windows.Forms.TextBox();
            this.tbMinutosFinalizacion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFinalizarViaje = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAsientos = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIniciarViaje
            // 
            this.btnIniciarViaje.Location = new System.Drawing.Point(30, 13);
            this.btnIniciarViaje.Name = "btnIniciarViaje";
            this.btnIniciarViaje.Size = new System.Drawing.Size(278, 23);
            this.btnIniciarViaje.TabIndex = 0;
            this.btnIniciarViaje.Text = "Iniciar Viaje";
            this.btnIniciarViaje.UseVisualStyleBackColor = true;
            this.btnIniciarViaje.Click += new System.EventHandler(this.btnIniciarViaje_Click);
            // 
            // btnIngresaParada
            // 
            this.btnIngresaParada.Location = new System.Drawing.Point(30, 43);
            this.btnIngresaParada.Name = "btnIngresaParada";
            this.btnIngresaParada.Size = new System.Drawing.Size(278, 23);
            this.btnIngresaParada.TabIndex = 1;
            this.btnIngresaParada.Text = "Ingresar Parada";
            this.btnIngresaParada.UseVisualStyleBackColor = true;
            this.btnIngresaParada.Click += new System.EventHandler(this.btnIngresaParada_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hora de finalización";
            // 
            // tbHoraFinalizacion
            // 
            this.tbHoraFinalizacion.Location = new System.Drawing.Point(116, 21);
            this.tbHoraFinalizacion.Name = "tbHoraFinalizacion";
            this.tbHoraFinalizacion.Size = new System.Drawing.Size(60, 20);
            this.tbHoraFinalizacion.TabIndex = 3;
            // 
            // tbMinutosFinalizacion
            // 
            this.tbMinutosFinalizacion.Location = new System.Drawing.Point(198, 21);
            this.tbMinutosFinalizacion.Name = "tbMinutosFinalizacion";
            this.tbMinutosFinalizacion.Size = new System.Drawing.Size(60, 20);
            this.tbMinutosFinalizacion.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = ":";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnFinalizarViaje
            // 
            this.btnFinalizarViaje.Location = new System.Drawing.Point(116, 99);
            this.btnFinalizarViaje.Name = "btnFinalizarViaje";
            this.btnFinalizarViaje.Size = new System.Drawing.Size(142, 23);
            this.btnFinalizarViaje.TabIndex = 6;
            this.btnFinalizarViaje.Text = "Finalizar Viaje";
            this.btnFinalizarViaje.UseVisualStyleBackColor = true;
            this.btnFinalizarViaje.Click += new System.EventHandler(this.btnFinalizarViaje_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbAsientos);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnFinalizarViaje);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbHoraFinalizacion);
            this.groupBox1.Controls.Add(this.tbMinutosFinalizacion);
            this.groupBox1.Location = new System.Drawing.Point(24, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 143);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Finalizar Parada";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Asientos";
            // 
            // tbAsientos
            // 
            this.tbAsientos.Location = new System.Drawing.Point(116, 58);
            this.tbAsientos.Name = "tbAsientos";
            this.tbAsientos.Size = new System.Drawing.Size(60, 20);
            this.tbAsientos.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 236);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnIngresaParada);
            this.Controls.Add(this.btnIniciarViaje);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIniciarViaje;
        private System.Windows.Forms.Button btnIngresaParada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbHoraFinalizacion;
        private System.Windows.Forms.TextBox tbMinutosFinalizacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFinalizarViaje;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbAsientos;
        private System.Windows.Forms.Label label3;
    }
}

