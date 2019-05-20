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
    public partial class OperacionesAvanzadas : Form
    {
        public OperacionesAvanzadas()
        {
            InitializeComponent();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool esIndiceValido(string texto)
        {
            int indice;
            bool esEntero = Int32.TryParse(texto, out indice);
            if (esEntero)
            {
                if(indice > 0)
                {
                    return true;
                }
            }
            return false;
        }
        private void buttonOperar_Click(object sender, EventArgs e)
        {
            if (textBoxComplejo.Text == "" || textBoxIndice.Text == "")
            {
                MessageBox.Show("Debe Ingresar los 2 campos para operar!");
            }
            else
            {
                OperacionesBasicas OB = new OperacionesBasicas();
                if (!OB.esComplejoValido(this.textBoxComplejo.Text) || !this.esIndiceValido(textBoxIndice.Text)) // || !OperacionesBasicas.esComplejoValido(textBoxIndice.Text)
                {
                    MessageBox.Show("Debe ingresar el número complejo de la siguiente manera: forma binómica (a;b) o forma polar [a;b] - El índice debe ser un entero");
                }
                else
                {
                    int n;
                    NumeroComplejo z1 = OB.parsearComplejo(textBoxComplejo.Text);
                    Int32.TryParse(textBoxIndice.Text, out n);

                    if (comboBoxOperaciones.SelectedIndex == -1)
                    {
                        MessageBox.Show("Debe seleccionar una operación!");
                    }
                    else
                    {
                        switch (comboBoxOperaciones.SelectedIndex)
                        {
                            case 0: //Potenciación
                                NumeroComplejo zres = new NumeroComplejo(0, 0, NumeroComplejo.Forma.Binomica);
                                zres = z1.potencia(n);
                                comboBox1.Items.Clear();
                                comboBox1.Items.Add("(" + Math.Round(zres.formaBinomica().a, 3) + " ; " + Math.Round(zres.formaBinomica().b, 3) + ")" + " - [" + Math.Round(zres.formaPolar().a, 3) + " ; " + Math.Round(zres.formaPolar().b, 3) + " rad]");
                                comboBox1.SelectedIndex = 0;
                                break;
                            case 1: //Radicación
                                List<NumeroComplejo> listaResultados = z1.raiz(n);
                                int k = 0;
                                comboBox1.Items.Clear();
                                
                                listaResultados.ForEach(delegate (NumeroComplejo Z)
                                {
                                    comboBox1.Items.Add("K=" + k + "-> (" + Math.Round(Z.formaBinomica().a, 3) + " ; " + Math.Round(Z.formaBinomica().b, 3) + ")" + " - [" + Math.Round(Z.formaPolar().a, 3) + " ; " + Math.Round(Z.formaPolar().b, 3) + " rad]");
                                    k++;
                                });
                                comboBox1.SelectedIndex = 0;
                                break;
                        }
                    }
                }
            }
        }

        private void labelResultado_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
