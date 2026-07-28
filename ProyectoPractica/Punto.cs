using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPractica
{
    class Punto
    {
        private double x;

        private double y;

        public Punto()
        {
            this.x = 0;

            this.y = 0;       
        }

        public Punto(double x, double y)
        {
            this.x = x;

            this.y = y;
        }


        public double distanciaHasta(Punto otroPunto)
        {
            double xDif = this.x - otroPunto.x;

            double yDif = this.y - otroPunto.y;

            double distanciaPunto = Math.Sqrt(Math.Pow(xDif,2)+Math.Pow(yDif,2));

            return distanciaPunto;
        }
        public void Mariano() {
    }
}
