using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace K3011_1C2019_G3_TPSuperior
{
    public partial class OperacionesBasicas : Form
    {
        public OperacionesBasicas()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOperar_Click(object sender, EventArgs e)
        {
            if(textBoxComplejo1.Text == "" || textBoxComplejo2.Text == "")
            {
                MessageBox.Show("Debe Ingresar los 2 números complejos para operar!");
            }
            else
            {
                if (!this.esComplejoValido(textBoxComplejo1.Text) || !this.esComplejoValido(textBoxComplejo2.Text))
                {
                    MessageBox.Show("Debe Ingresar los números complejos de la siguiente manera: forma binómica (a;b) o forma polar [a;b]");
                    //MessageBox.Show(textBoxComplejo1.Text, textBoxComplejo2.Text);
                }
                else
                {
                    //aca se sacarian los numeros de cada textbox, de su expresion regular, se crean los complejos y se ejecuta la operacion correspondiente
                    
                    //luego opero

                    //por ahora los hardcodeo...
                    //NumeroComplejo z1 = new NumeroComplejo(2, 3, NumeroComplejo.Forma.Binomica);
                    //algo asi
                    NumeroComplejo z1 = this.parsearComplejo(textBoxComplejo1.Text);
                    NumeroComplejo z2 = this.parsearComplejo(textBoxComplejo2.Text);

                    NumeroComplejo zres = new NumeroComplejo(0, 0, NumeroComplejo.Forma.Binomica);
                    
                    if (comboBoxOperaciones.SelectedIndex == -1)
                    {
                        MessageBox.Show("Debe seleccionar una operación!");
                    } else
                    {
                        switch (comboBoxOperaciones.SelectedIndex)
                        {
                            case 0: //sumar
                                zres = z1.sumarComplejos(z2);

                            break;
                            case 1: //restar
                                zres = z1.restarComplejos(z2);

                            break;
                            case 2: //mult
                                zres = z1.multiplicarComplejos(z2);

                            break;
                            case 3: //dividir
                                zres = z1.DividirComplejos(z2);

                                break;
                        }
                        //Despues distinguir si imprimir [a,b] o (a,b)
                        labelResultado.Text = "(" + Math.Round(zres.formaBinomica().a,3) + " ; " + Math.Round(zres.formaBinomica().b, 3) + ")" + " - ["+ Math.Round(zres.formaPolar().a, 3) + " ; "+ Math.Round(zres.formaPolar().b, 3) + " rad]";

                        //armo un case con todas las posibles operaciones seleccionadas
                        //por cada operacion, opero con los complejos
                    }
                }
            }
        }

        private bool esComplejoValido(string complejo)
        {
            //aca se validaria la expresion regular y se devolveria el resultado de la validacion
            //expresion para forma polar: ^[[][-]?[0-9]+([,][0-9]+)?[;][-]?[0-9]+([,][0-9]+)?[]]$
            //expresion para forma binomica: ^[(][-]?[0-9]+([,][0-9]+)?[;][-]?[0-9]+([,][0-9]+)?[)]$
            //explicacion en https://www.youtube.com/watch?v=Er8xgxdK8MY
            //(recordar expresiones regulares de sintaxis... jaja)

            Regex ERPolar = new Regex("^[[](?<a>[-]?[0-9]+([,][0-9]+)?)[;](?<b>[-]?[0-9]+([,][0-9]+)?)[]]$");
            Regex ERBinomica = new Regex("^[(](?<a>[-]?[0-9]+([,][0-9]+)?)[;](?<b>[-]?[0-9]+([,][0-9]+)?)[)]$");

            if (ERPolar.IsMatch(complejo) || ERBinomica.IsMatch(complejo))
            {
                return true;

            }
            else
            {
                return false;
            }
        }
        private NumeroComplejo parsearComplejo(string complejo)
        {

            Regex ERPolar = new Regex("^[[](?<a>[-]?[0-9]+([,][0-9]+)?)[;](?<b>[-]?[0-9]+([,][0-9]+)?)[]]$");
            Regex ERBinomica = new Regex("^[(](?<a>[-]?[0-9]+([,][0-9]+)?)[;](?<b>[-]?[0-9]+([,][0-9]+)?)[)]$");
            if (ERPolar.IsMatch(complejo))
            {
                NumeroComplejo z = new NumeroComplejo(0, 0, NumeroComplejo.Forma.Polar);

                foreach(Match mt in ERPolar.Matches(complejo))
                {
                    z.a = Double.Parse(mt.Groups["a"].Value);
                    z.b = Double.Parse(mt.Groups["b"].Value);
                }
                return z;

            }
            else //if(ERBinomica.IsMatch(complejo))
            {
                NumeroComplejo z = new NumeroComplejo(0, 0, NumeroComplejo.Forma.Binomica);

                foreach (Match mt in ERBinomica.Matches(complejo))
                {
                    z.a = Double.Parse(mt.Groups["a"].Value);
                    z.b = Double.Parse(mt.Groups["b"].Value);

                }
                return z;

            }
        }

        private void textBoxComplejo1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
