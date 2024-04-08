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
    public partial class frmDeuda : Form
    {
        clsCliente clsCliente = new clsCliente();
        public frmDeuda()
        {
            InitializeComponent();
        }
        private void frmDeuda_Load(object sender, EventArgs e)
        {
            
            clsCliente.Codigo = 15;
            clsCliente.Nombre = "ramiro";
            clsCliente.Deuda = 0;
            lblCodigo.Text = clsCliente.Codigo.ToString();
            lblNombre.Text = clsCliente.Nombre;
            lblDeuda.Text = clsCliente.Deuda.ToString();
        }

        private void cmdComprar_Click(object sender, EventArgs e)
        {
            clsCliente.Comprar(Convert.ToInt32(txtImporte.Text));
            lblDeuda.Text = clsCliente.Deuda.ToString();
        }

        private void cmdPagar_Click(object sender, EventArgs e)
        {
            clsCliente.Pagar(Convert.ToInt32(txtImporte.Text));
            lblDeuda.Text = clsCliente.Deuda.ToString();
        }
    }
}
