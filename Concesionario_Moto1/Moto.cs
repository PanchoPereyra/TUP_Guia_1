using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concesionario_Moto
{
    internal class Moto
    {
        private string marca;
        private int modeloAnio;
        private double valorFabricacion;

        //PROPIEDADES
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public int ModeloAnio
        {
            get { return modeloAnio; }
            set { modeloAnio = value; }
        }

        public double ValorFabricacion
        {
            get { return valorFabricacion; }
            set { valorFabricacion = value; }
        }

        //CONSTRUCTOR
        public Moto (string marca, double valorFabricacion)
        {
            this.marca = marca;
            this.valorFabricacion = valorFabricacion;
        }

        //METODOS
        public double CalcularDepreciacionLineal(int anioCalcular, int vidaU)
        {
            int anioDeUso=0;
            double depeciacionLineal = valorFabricacion-(valorFabricacion*(anioDeUso/vidaU));
            return depeciacionLineal;
        }

        public double CalcularDepreciacionAnual(int anioCalcular, double depreciacionLineal)
        {
            double valorActualizado = valorFabricacion * (1 - depreciacionLineal);
            return valorActualizado;
        }

        public string VerDescripcion()
        {
            return $"Marca: {Marca}, Modelo:{ModeloAnio}, Valor Fabricación: ${ValorFabricacion}"; 
        }
    }
}
