using System;
using System.Collections.Generic;
using System.Text;

namespace Dado
{
    class Dado
    {
        private int numero;

        public int NumeroMayorDado { get; set; } = 6;

        public int Numero
        {
            get
            {
                return this.numero;
            }
        }

        public Dado()
        {
        }

        public Dado(int numeroTrampa)
        {
            this.numero = numeroTrampa;
        }

        public void Tirar()
        {
            Random random = new Random();
            this.numero = random.Next(1, this.NumeroMayorDado);
        }
    }
}