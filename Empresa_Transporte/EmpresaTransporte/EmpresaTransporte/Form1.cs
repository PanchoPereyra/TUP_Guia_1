using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpresaTransporte
{
    public partial class Form1 : Form
    {
        Viaje viaje;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnIniciarViaje_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            if (form2.ShowDialog() == DialogResult.OK)
            {
                int hInicio = Convert.ToInt32(tbHoraFinalizacion.Text);
                int mInicio = Convert.ToInt32(tbMinutosFinalizacion.Text);
                int asientos = Convert.ToInt32(tbAsientos.Text);

                //Chequeo de la hora
                bool hCorrecta = hInicio >= 0 && hInicio <= 23;
                if (hCorrecta)
                {
                    MessageBox.Show("El valor de la hora incorrecta - el valor es de 0 a 23");
                }
                bool mCorrecto = mInicio >= 0 && mInicio <= 59;
                if (mCorrecto)
                {
                    MessageBox.Show("Valor de los minutos incorrecto - el valor correcto es de 0 a 59");
                }

                if (hCorrecta && mCorrecto)
                {
                    viaje = new Viaje(hInicio, mInicio, asientos);
                    #region limpiando controles
                    btnFinalizarViaje.Enabled = true;
                    tbHoraFinalizacion.Enabled = true;
                    tbMinutosFinalizacion.Enabled = true;
                    groupBox1.Enabled = true;
                    btnIngresaParada.Enabled = true;
                    btnIniciarViaje.Enabled = false;
                    tbHoraFinalizacion.Clear();
                    tbMinutosFinalizacion.Clear();
                    #endregion
                }
                else
                {
                    MessageBox.Show("Hubo un error en el ingreso de datos");
                }
            }

            else
            {
                MessageBox.Show("Ha cancelado el ingreso del viaje");
            }
        }

        private void btnFinalizarViaje_Click(object sender, EventArgs e)
        {
            int hLlegada = Convert.ToInt32(tbHoraFinalizacion.Text);
            int mLlegada = Convert.ToInt32(tbMinutosFinalizacion.Text);

            #region verificando
            bool correctoh = hLlegada >= 0 && hLlegada <= 23;
            if (correctoh == false)
            {
                MessageBox.Show("Valor de Hora incorrecta - el valor es de 0 a 23");
            }

            bool correctom = mLlegada >= 0 && mLlegada <= 59;
            if (correctom == false)
            {
                MessageBox.Show("Valor de Minutos incorrecto - el valor es de 0 a 59");
            }
            #endregion
            if(correctoh && correctom)
            {
                viaje.Finalizar(hLlegada, mLlegada);
                Form3 form3 = new Form3();
                form3.listBox1.Items.Clear();
                form3.listBox1.Items.Add($"Cantidad de pasajeros transportados: {viaje.Transportados}");
                form3.listBox1.Items.Add($"Tiempo total recorrido: {viaje.HDuracionViaje}:{viaje.MDuracionViaje}");
                form3.listBox1.Items.Add($"Tiempo total de demora en las paradas: {viaje.HDemora}:{viaje.MDemora}");
                form3.ShowDialog();
            }
        }

        private void btnIngresaParada_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            if (form2.ShowDialog() == DialogResult.OK)
            {
                int hLlegadaParada = Convert.ToInt32(form2.tbHoraLlegada.Text);
                int mLlegadaParada = Convert.ToInt32(form2.tbMinutosLlegada.Text);
                int hSalidaParada = Convert.ToInt32(form2.tbHoraSalida.Text);
                int mSalidaParada = Convert.ToInt32(form2.tbMinutosSalida.Text);
                int ascienden = Convert.ToInt32(form2.tbAscienden.Text);
                int descienden = Convert.ToInt32(form2.tbDescienden.Text);
            }
            else
            {
                MessageBox.Show("Ha cabcelado ingreso");
            }

        }
    }
}
