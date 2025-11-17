using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arboles_Grafos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void jerarquiaOrganizativaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormArbol ventanaArbol = new FormArbol();
            ventanaArbol.Show();
        }

        private void grafoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGrafos ventanaGrafo = new FormGrafos();
            ventanaGrafo.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nnovatecToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
