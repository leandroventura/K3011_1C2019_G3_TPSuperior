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
    public partial class PantallaPrincipal : Form
    {
        public PantallaPrincipal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PantallaPrincipal_Load(object sender, EventArgs e)
        {

        }
        private void básicasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OperacionesBasicas form = new OperacionesBasicas();

            form.Show();

        }
        
        private void avanzadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OperacionesAvanzadas form = new OperacionesAvanzadas();

            form.Show();

        }
        private void fasoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OperacionesFasores form = new OperacionesFasores();

            form.Show();

        }
        
        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
