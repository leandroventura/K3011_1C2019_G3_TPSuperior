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

        public double a;
        public double b;
        public Forma forma;

        public NumeroComplejo(double p_a, double p_b, Forma unaForma)
        {
            a = p_a;
            b = p_b;
            forma = unaForma;
        }
        public NumeroComplejo formaBinomica()
        {
            if (this.forma == Forma.Binomica)
            {
                return this;
            }
            else
            {
                //si no está en forma binómica, calcular su Re(z) e Im(z)
                NumeroComplejo z = new NumeroComplejo(0, 0, Forma.Polar);
                
                z.forma = Forma.Polar;
                z.a = this.a* Math.Cos(this.b);
                z.b = this.a* Math.Sin(this.b);
                return z;
            }
        }
        public double calcularModulo()
        {
            return 0;
        }

    }
}
