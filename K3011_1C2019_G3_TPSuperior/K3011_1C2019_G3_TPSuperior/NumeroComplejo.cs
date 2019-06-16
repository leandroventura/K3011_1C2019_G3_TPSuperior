using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K3011_1C2019_G3_TPSuperior
{
    public class NumeroComplejo
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
                NumeroComplejo z = new NumeroComplejo(0, 0, Forma.Binomica);

                //z.forma = Forma.Binomica;
                z.a = this.a * Math.Cos(this.b);
                z.b = this.a * Math.Sin(this.b);
                return z;
            }
        }
        public NumeroComplejo formaPolar()
        {
            if (this.forma == Forma.Polar)
            {
                return this;
            }
            else
            {
                //si no está en forma polar, calcular su módulo y argumento
                //a : modulo, b:argumento
                NumeroComplejo z = new NumeroComplejo(0, 0, Forma.Polar);
                double parteReal = this.a;
                double parteIm = this.b;
                int cuadrante = this.cuadrante();
                z.a = Math.Sqrt((parteReal * parteReal) + (parteIm * parteIm));
                //si no es imaginario puro
                if (parteReal != 0)
                {
                    
                    if(parteIm != 0)
                    {
                        z.b = Math.Atan(parteIm / parteReal);
                        z = z.corregirArgumento(cuadrante);
                    }
                    else //está sobre el eje real
                    {
                        if (parteReal > 0)
                        {
                            z.b = 0;
                        }
                        else
                        {
                            z.b = Math.PI;
                        }
                    }
                    
                    
                }
                //si es imaginario puro
                else
                {
                    if (parteIm > 0)
                    {
                        z.b = Math.PI / 2;
                    }
                    else if (parteIm < 0)
                    {
                        z.b = Math.PI * 3 / 4;
                    }
                }
                return z;
            }
        }

        public NumeroComplejo corregirArgumento(int cuadrante)
        {
            switch (cuadrante)
            {
                case 2:
                case 3:
                    this.b = this.b + Math.PI;
                    break;
                case 4:
                    this.b = this.b + (2 * Math.PI);
                    break;
            }
            return this;
        }

        //esta solo sirve si el complejo esta en binomica
        public int cuadrante()
        {
            int cuadrante = 0;
            if (this.forma == Forma.Binomica)
            {
                double parteReal = this.a;
                double parteIm = this.b;

                if (parteReal > 0 && parteIm > 0)
                {
                    cuadrante = 1;
                }
                if (parteReal < 0 && parteIm > 0)
                {
                    cuadrante = 2;
                }
                if (parteReal < 0 && parteIm < 0)
                {
                    cuadrante = 3;
                }
                if (parteReal > 0 && parteIm < 0)
                {
                    cuadrante = 4;
                }
            }
            return cuadrante;
        }

        public NumeroComplejo sumarComplejos(NumeroComplejo z2)
        {
            NumeroComplejo z3 = new NumeroComplejo(0, 0, Forma.Binomica);
            if (this.forma == Forma.Binomica)
            {
                if (z2.forma == Forma.Binomica)
                {
                    z3.a = this.a + z2.a;
                    z3.b = this.b + z2.b;
                    return z3;
                }
                else
                {
                    z2 = z2.formaBinomica();
                    z3.a = this.a + z2.a;
                    z3.b = this.b + z2.b;
                    return z3;
                }
            }
            else //this en forma polar
            {
                NumeroComplejo z = new NumeroComplejo(0, 0, Forma.Binomica);
                z = this.formaBinomica(); //lo que tngo en this, lo paso a binomica y lo asigno a z
                if (z2.forma == Forma.Binomica)
                {
                    z3.a = z.a + z2.a;
                    z3.b = z.b + z2.b;
                    return z3.formaPolar();
                }
                else
                {
                    z2 = z2.formaBinomica();
                    z3.a = z.a + z2.a;
                    z3.b = z.b + z2.b;
                    return z3.formaPolar();
                }
            }
        }

        public NumeroComplejo restarComplejos(NumeroComplejo z2)
        {
            NumeroComplejo z3 = new NumeroComplejo(0, 0, Forma.Binomica);
            if (this.forma == Forma.Binomica)
            {
                if (z2.forma == Forma.Binomica)
                {
                    z3.a = this.a - z2.a;
                    z3.b = this.b - z2.b;
                    return z3;
                }
                else
                {
                    z2 = z2.formaBinomica();
                    z3.a = this.a - z2.a;
                    z3.b = this.b - z2.b;
                    return z3;
                }
            }
            else //this en forma polar
            {
                NumeroComplejo z = new NumeroComplejo(0, 0, Forma.Binomica);
                z = this.formaBinomica(); //lo que tngo en this, lo paso a binomica y lo asigno a z
                if (z2.forma == Forma.Binomica)
                {
                    z3.a = z.a - z2.a;
                    z3.b = z.b - z2.b;
                    return z3.formaPolar();
                }
                else
                {
                    z2 = z2.formaBinomica();
                    z3.a = z.a - z2.a;
                    z3.b = z.b - z2.b;
                    return z3.formaPolar();
                }
            }
        }

        public NumeroComplejo multiplicarComplejos(NumeroComplejo z2)
        {
            NumeroComplejo z3 = new NumeroComplejo(0, 0, Forma.Binomica);
            NumeroComplejo z = new NumeroComplejo(0, 0, Forma.Binomica);
            z = this.formaBinomica();
            z2 = z2.formaBinomica();
            z3.a = (z.a * z2.a) - (z.b * z2.b);
            z3.b = (z.a * z2.b) + (z2.a * z.b);
            return z3;
        }

        public NumeroComplejo DividirComplejos(NumeroComplejo z2)
        {
            NumeroComplejo z3 = new NumeroComplejo(0, 0, Forma.Binomica);
            NumeroComplejo z = new NumeroComplejo(0, 0, Forma.Binomica);

            z = this.formaBinomica();
            z2 = z2.formaBinomica();
            z3.a = ((z.a * z2.a) + (z.b * z2.b)) / (Math.Pow(z2.a,2) + Math.Pow(z2.b, 2));
            z3.b = ((z.b * z2.a) - (z.a * z2.b)) / (Math.Pow(z2.a, 2) + Math.Pow(z2.b, 2));
            return z3;
        }

        public NumeroComplejo potencia(int exponente)
        {
            NumeroComplejo zres = new NumeroComplejo(0, 0, Forma.Polar);
            double modulo;
            double argumento;

            modulo = Math.Pow(this.formaPolar().a,exponente); //el modulo es el modulo^n
            argumento = exponente * this.formaPolar().b;

            zres.a = modulo;
            zres.b = argumento;

            return zres;
        }

        public List<NumeroComplejo> raiz(int indice)
        {
            //NumeroComplejo zres = new NumeroComplejo(0, 0, Forma.Polar);
            double modulo;
            double argumento;
            List<NumeroComplejo> listaResultados = new List<NumeroComplejo>();

            modulo = Math.Pow(this.formaPolar().a, (1 / (double)indice));

            //zres.a = modulo;
            for(int i = 0; i< indice; i++)
            {
                argumento = (double)(this.formaPolar().b + 2*i*Math.PI)/ indice;
                //zres.b = argumento;
                //listaResultados.Add(zres);
                listaResultados.Add(new NumeroComplejo(modulo, argumento, Forma.Polar));

            }

            return listaResultados;
        }
    }

    public class Funcion
    {

        public enum TipoFuncion
        {
            Cos,
            Sen
        }

        public double amplitud;
        public TipoFuncion tipoFuncion;
        public double frecuencia;
        public double fase;

        public Funcion(double unaAmplitud, TipoFuncion tipoFuncion, double unaFrecuencia, double unaFase)
        {
            //Verifico la frecuencia:
            if (amplitud < 0)
            {
                throw new Exception("La amplitud no puede ser negativa");
            }

            this.amplitud = unaAmplitud;
            this.frecuencia = unaFrecuencia;
            this.fase = unaFase;
            this.tipoFuncion = tipoFuncion;

            
        }

        public Funcion sumarFunciones (Funcion unaFuncion, Funcion otraFuncion)
        {
            var faseUnaFuncion = unaFuncion.fase;
            var faseOtraFuncion = otraFuncion.fase;

           
            //Voy a trabajar todo a senos o pasarlo según necesite
            if (unaFuncion.tipoFuncion == TipoFuncion.Cos)
            {
                faseUnaFuncion = faseUnaFuncion + Math.PI / 2;
            }

            if (otraFuncion.tipoFuncion == TipoFuncion.Cos)
            {
                faseOtraFuncion = faseOtraFuncion + Math.PI / 2;
            }

            //Los convierto a complejos
            var fasorDeUnaFuncion = new NumeroComplejo(unaFuncion.amplitud, faseUnaFuncion, NumeroComplejo.Forma.Polar);
            var fasorDeOtraFuncion = new NumeroComplejo(otraFuncion.amplitud, faseOtraFuncion, NumeroComplejo.Forma.Polar);

            var resultadoSuma = fasorDeOtraFuncion.sumarComplejos(fasorDeOtraFuncion);

            var resultadoFase = resultadoSuma.b;

            return new Funcion(resultadoSuma.a, TipoFuncion.Sen, otraFuncion.frecuencia, resultadoFase);

        }


    }

}
