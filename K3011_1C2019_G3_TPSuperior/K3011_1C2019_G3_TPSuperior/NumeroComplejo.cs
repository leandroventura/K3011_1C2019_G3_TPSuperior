using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K3011_1C2019_G3_TPSuperior
{
    class NumeroComplejo
    {
        public enum Forma
        {
            Binomica,
            Polar
        }

        public double parteReal;
        public double parteImaginaria;
        public Forma forma;

        public NumeroComplejo(double a, double b, Forma unaForma)
        {
            parteReal = a;
            parteImaginaria = b;
            forma = unaForma;
        }

        public double calcularModulo()
        {
            return 0;
        }

    }
}
