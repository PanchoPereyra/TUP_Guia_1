using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Concesionario_Moto
{
    public partial class Form1 : Form
    {
        Moto unaMoto;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string marca = tbMarca.Text;
            int modelo = Convert.ToInt32(nUDAño.Text);
            int anio = Convert.ToInt32(nUDAño.Text);
            double valorFabricacion = Convert.ToDouble(tbValor.Text);
            double tasaDep = Convert.ToDouble(tbTasa.Text);
            int vidaUt = Convert.ToInt16(tbVidaU.Text);
            unaMoto = new Moto(marca, valorFabricacion);
            Form2 formularioVer = new Form2();
            formularioVer.lbResultado.Items.Add(unaMoto.VerDescripcion());


            double valorLineal = unaMoto.CalcularDepreciacionLineal(anio, vidaUt);
            formularioVer.lbResultado.Items.Add($"Depreciación lineal: {valorFabricacion}");

            double valorAnual = unaMoto.CalcularDepreciacionAnual(anio, tasaDep);
            formularioVer.lbResultado.Items.Add($"Depeciación anual: ${valorAnual}");

            formularioVer.ShowDialog();

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
