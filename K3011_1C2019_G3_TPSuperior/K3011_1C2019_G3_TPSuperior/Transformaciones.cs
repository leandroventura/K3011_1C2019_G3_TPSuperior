using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace K3011_1C2019_G3_TPSuperior
{
    public partial class Transformaciones : Form
    {
        public Transformaciones()
        {
            InitializeComponent();
        }

        private void buttonTransformar_Click(object sender, EventArgs e)
        {
            OperacionesBasicas OB = new OperacionesBasicas();
            if (!OB.esComplejoValido(this.textBoxComplejo.Text))
            {
                MessageBox.Show("Debe ingresar el número complejo de la siguiente manera: forma binómica (a;b) o forma polar [a;b]");
            }
            else
            {
                NumeroComplejo z1 = OB.parsearComplejo(textBoxComplejo.Text);

                if(z1.forma == NumeroComplejo.Forma.Binomica)
                {
                    NumeroComplejo zRes = z1.formaPolar();
                    labelResultado.Text = "["+ Math.Round(zRes.a, 3) + ";"+ Math.Round(zRes.b, 3) + "]";
                }
                else
                {
                    NumeroComplejo zRes = z1.formaBinomica();
                    labelResultado.Text = "(" + Math.Round(zRes.a,3) + ";" + Math.Round(zRes.b,3) + ")";

                }
            }
        }
    }
}
