using System;
using System.Collections.Generic;
using System.Windows.Forms;
 

namespace K3011_1C2019_G3_TPSuperior
{
    public partial class OperacionesFasores : Form
    {
        public OperacionesFasores()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;

        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void buttonOperar_Click(object sender, EventArgs e)
        {
            if (Amplitud.Text == "" || inputAmplitud2.Text == "" || inputFase1.Text == "" || inputFase2.Text == "" || inputFrecuencia1.Text == "" || inputFrecuencia2.Text == "")
            {
                MessageBox.Show("Debe Ingresar todos campos para operar!");
            }
            else 
            {
                //------Declaro variables para armar las dos funciones------
                Funcion.TipoFuncion tipoFuncion1;
                
                Double amplitud1;
                Double fase1;
                Double frecuencia1;

                Funcion.TipoFuncion tipoFuncion2;
                Double amplitud2;
                Double fase2;
                Double frecuencia2;
                //--------------------------------------
                if (comboBox1.SelectedIndex == 0)
                {
                    tipoFuncion1 = Funcion.TipoFuncion.Sen;
                }
                else
                {
                    tipoFuncion1 = Funcion.TipoFuncion.Cos;
                }
                if (comboBox1.SelectedIndex == 0)
                {
                    tipoFuncion2 = Funcion.TipoFuncion.Sen;
                }
                else
                {
                    tipoFuncion2 = Funcion.TipoFuncion.Cos;
                }

                //inicio flag en true, si alguno falla lo pone en false
                bool flagTipo = true;
                flagTipo = double.TryParse(inputAmplitud1.Text, out amplitud1);
                //MessageBox.Show("el valor es" + amplitud1.ToString());
                flagTipo = Double.TryParse(inputFase1.Text, out fase1);
                flagTipo = Double.TryParse(inputFrecuencia1.Text, out frecuencia1);

                flagTipo = double.TryParse(inputAmplitud2.Text, out amplitud2);
                flagTipo = Double.TryParse(inputFase2.Text, out fase2);
                flagTipo = Double.TryParse(inputFrecuencia2.Text, out frecuencia2);

                if (flagTipo == false)
                {
                    MessageBox.Show("Asegúrese de ingresar este formato: 20.5");
                }
                else
                {
                    //Verifico que la frecuencia sea la misma
                    if (Math.Abs(frecuencia1 - frecuencia2) != 0)
                    {
                        //throw new Exception("Error: las frecuencias son distintas");
                        MessageBox.Show("Error: las frecuencias son distintas");
                    }
                    else
                    {
                        Funcion funcion1 = new Funcion(amplitud1, tipoFuncion1, frecuencia1, fase1);
                        Funcion funcion2 = new Funcion(amplitud2, tipoFuncion2, frecuencia2, fase2);

                        Funcion funcionResultado = funcion1.sumarFunciones(funcion1, funcion2);

                        String faseRes = funcionResultado.fase.ToString();
                        String amplitudRes = funcionResultado.amplitud.ToString();
                        String frecuenciaRes = funcionResultado.frecuencia.ToString();
                        String tipoRes = funcionResultado.tipoFuncion.ToString();

                        labelResultado.Text = amplitudRes + "*" + tipoRes + "(" + frecuenciaRes + "t+" + faseRes + ")";
                    }
                }


                
            }
        }

        private void comboBoxOperaciones_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void OperacionesFasores_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void amplitud1_TextChanged(object sender, EventArgs e)
        {

        }

        private void fase1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
