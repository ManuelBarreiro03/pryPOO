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
    public partial class frmCola : Form
    {
        public frmCola()
        {
            InitializeComponent();
        }
        clsCola FilaDePersonas = new clsCola();
        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            clsNodo objNodo = new clsNodo();
            objNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            objNodo.Nombre = txtNombre.Text;
            objNodo.Tramite = txtTramite.Text;
            FilaDePersonas.Agregar(objNodo);
            FilaDePersonas.Recorrer(dgvGrilla);
            FilaDePersonas.Recorrer(lstLista);
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            if (FilaDePersonas.Primero !=null)
            {
                lblBorrarCodigo.Text = FilaDePersonas.Primero.Codigo.ToString();
                lblBorrarNombre.Text = FilaDePersonas.Primero.Nombre;
                lblBorrarTramite.Text = FilaDePersonas.Primero.Tramite;
                FilaDePersonas.eliminar();
                FilaDePersonas.Recorrer(dgvGrilla);
                FilaDePersonas.Recorrer(lstLista);
            }
        }
    }
}
