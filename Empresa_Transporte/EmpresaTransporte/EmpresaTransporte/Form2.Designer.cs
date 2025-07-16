namespace EmpresaTransporte
{
    partial class Form2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDescienden = new System.Windows.Forms.TextBox();
            this.tbAscienden = new System.Windows.Forms.TextBox();
            this.tbMinutosSalida = new System.Windows.Forms.TextBox();
            this.tbHoraSalida = new System.Windows.Forms.TextBox();
            this.tbMinutosLlegada = new System.Windows.Forms.TextBox();
            this.tbHoraLlegada = new System.Windows.Forms.TextBox();
            this.btnInicializar = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbDescienden);
            this.groupBox1.Controls.Add(this.tbAscienden);
            this.groupBox1.Controls.Add(this.tbMinutosSalida);
            this.groupBox1.Controls.Add(this.tbHoraSalida);
            this.groupBox1.Controls.Add(this.tbMinutosLlegada);
            this.groupBox1.Controls.Add(this.tbHoraLlegada);
            this.groupBox1.Location = new System.Drawing.Point(12, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 215);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Descienden";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ascienden";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Salida (HH : MM)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Llegada (HH : MM)";
            // 
            // tbDescienden
            // 
            this.tbDescienden.Location = new System.Drawing.Point(109, 150);
            this.tbDescienden.Name = "tbDescienden";
            this.tbDescienden.Size = new System.Drawing.Size(45, 20);
            this.tbDescienden.TabIndex = 5;
            // 
            // tbAscienden
            // 
            this.tbAscienden.Location = new System.Drawing.Point(109, 115);
            this.tbAscienden.Name = "tbAscienden";
            this.tbAscienden.Size = new System.Drawing.Size(45, 20);
            this.tbAscienden.TabIndex = 4;
            // 
            // tbMinutosSalida
            // 
            this.tbMinutosSalida.Location = new System.Drawing.Point(174, 71);
            this.tbMinutosSalida.Name = "tbMinutosSalida";
            this.tbMinutosSalida.Size = new System.Drawing.Size(45, 20);
            this.tbMinutosSalida.TabIndex = 3;
            // 
            // tbHoraSalida
            // 
            this.tbHoraSalida.Location = new System.Drawing.Point(109, 71);
            this.tbHoraSalida.Name = "tbHoraSalida";
            this.tbHoraSalida.Size = new System.Drawing.Size(45, 20);
            this.tbHoraSalida.TabIndex = 2;
            // 
            // tbMinutosLlegada
            // 
            this.tbMinutosLlegada.Location = new System.Drawing.Point(174, 30);
            this.tbMinutosLlegada.Name = "tbMinutosLlegada";
            this.tbMinutosLlegada.Size = new System.Drawing.Size(45, 20);
            this.tbMinutosLlegada.TabIndex = 1;
            this.tbMinutosLlegada.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tbHoraLlegada
            // 
            this.tbHoraLlegada.Location = new System.Drawing.Point(109, 30);
            this.tbHoraLlegada.Name = "tbHoraLlegada";
            this.tbHoraLlegada.Size = new System.Drawing.Size(45, 20);
            this.tbHoraLlegada.TabIndex = 0;
            // 
            // btnInicializar
            // 
            this.btnInicializar.Location = new System.Drawing.Point(289, 58);
            this.btnInicializar.Name = "btnInicializar";
            this.btnInicializar.Size = new System.Drawing.Size(75, 50);
            this.btnInicializar.TabIndex = 1;
            this.btnInicializar.Text = "Ingresar Parada";
            this.btnInicializar.UseVisualStyleBackColor = true;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(289, 145);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(75, 50);
            this.btnFinalizar.TabIndex = 2;
            this.btnFinalizar.Text = "Finalizar Parada";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 243);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.btnInicializar);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnInicializar;
        public System.Windows.Forms.Button btnFinalizar;
        public System.Windows.Forms.TextBox tbMinutosLlegada;
        public System.Windows.Forms.TextBox tbHoraLlegada;
        public System.Windows.Forms.TextBox tbHoraSalida;
        public System.Windows.Forms.TextBox tbAscienden;
        public System.Windows.Forms.TextBox tbMinutosSalida;
        public System.Windows.Forms.TextBox tbDescienden;
    }
}