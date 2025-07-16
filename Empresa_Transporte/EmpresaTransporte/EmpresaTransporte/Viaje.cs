using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTransporte
{
    internal class Viaje
    {
        private int transportados;
        private int asientos;
        private int hDemora;
        private int mDemora;
        private int cantParadas;
        private int hDuracionViaje;
        private int mDuracionViaje;
        private int hInicio;
        private int mInicio;
        public int demoraEnM;
        public int horaInicio;
        public int minInicio;
        public int hLlegada;
        public int mLlegada;
        int ocupados;
        int pasajerosTransportados;

        public int Transportados
        {
            get { return transportados; }
            set { transportados = value; }
        }

        public int Asientos
        {
            get { return asientos; }
            set {  asientos = value; }
        }

        public int HDemora
        {
            get { return demoraEnM / 60; }
        }

        public int MDemora
        {
            get { return demoraEnM % 60; }
        }

        public int CantParadas
        {
            get { return cantParadas; }
            set { cantParadas = value; }
        }

        public int HDuracionViajes
        {
            get { return hDuracionViaje; }
            set { hDuracionViaje = value; }
        }

        public int MDuracionViajes
        {
            get { return mDuracionViaje; }
            set { mDuracionViaje = value; }
        }

        private int DuracionViajeEnM
        {
            get
            {
                return hLlegada * 60 + mLlegada - (horaInicio * 60 + minInicio);
            }
        }

        public int HDuracionViaje
        {
            get
            {
                return DuracionViajeEnM / 60;
            }
        }

        public int MDuracionViaje
        {
            get
            {
                return DuracionViajeEnM % 60;
            }
        }

        //CONSTRUCTOR
        public Viaje(int hInicio, int mInicio, int asientos)
        {
            hInicio = horaInicio;
            mInicio = minInicio;
            this.asientos = asientos;
        }



        public void RealizarParada(int hLlegadaParada, int mLlegadaParada, int hSalidaParada, int mSalidaParada, int ascienden, int descienden)
        {
            int llegadaEnM = 30 * hLlegadaParada + mLlegadaParada;
            int salidaEnM = 30 * hSalidaParada + mSalidaParada;
            demoraEnM += salidaEnM - llegadaEnM;
            cantParadas++;
            ocupados += ascienden - descienden;
            pasajerosTransportados += ascienden;
        }

        public void Finalizar (int hLlegada, int mLlegada)
        {
            this.hLlegada = hLlegada;
            this.mLlegada = mLlegada;

        }
    }
}
