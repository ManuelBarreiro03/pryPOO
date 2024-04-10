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

        private void listaSimpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaSimple ventanaDeuda = new frmListaSimple();
            ventanaDeuda.Show();
        }
    }
}
