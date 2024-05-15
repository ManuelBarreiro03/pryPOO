using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryPOO
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void tsmDeuda_Click(object sender, EventArgs e)
        {
            frmDeuda ventanaDeuda = new frmDeuda();
            ventanaDeuda.Show();
        }

        private void tsmCola_Click(object sender, EventArgs e)
        {
            frmCola ventanaDeuda = new frmCola();
            ventanaDeuda.Show();
        }

        private void tsmPila_Click(object sender, EventArgs e)
        {
            frmPila ventanaDeuda = new frmPila();
            ventanaDeuda.Show();
        }

        private void opcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArbol frmArbol = new frmArbol();
            frmArbol.Show();
        }

        private void listaSimpleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmListaSimple frmListaSimple = new frmListaSimple();
            frmListaSimple.Show();
        }

        private void listaDobleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaDoble frmListaSimple = new frmListaDoble();
            frmListaSimple.Show();
        }

        private void consultasEnLaBaseDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBDDConsulta frmListaSimple = new frmBDDConsulta();
            frmListaSimple.Show();
        }
    }
}
