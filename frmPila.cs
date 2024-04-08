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
    public partial class frmPila : Form
    {
        public frmPila()
        {
            InitializeComponent();
        }
        clsPila PilaDeArchivos = new clsPila();
        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            clsNodo objNodo = new clsNodo();
            objNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            objNodo.Nombre = txtNombre.Text;
            objNodo.Tramite = txtTramite.Text;
            PilaDeArchivos.Agregar(objNodo);
            PilaDeArchivos.Recorrer(dgvGrilla);
            PilaDeArchivos.Recorrer(lstLista);
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            if (PilaDeArchivos.Primero != null)
            {
                lblBorrarCodigo.Text = PilaDeArchivos.Primero.Codigo.ToString();
                lblBorrarNombre.Text = PilaDeArchivos.Primero.Nombre;
                lblBorrarTramite.Text = PilaDeArchivos.Primero.Tramite;
                PilaDeArchivos.Eliminar();
                PilaDeArchivos.Recorrer(dgvGrilla);
                PilaDeArchivos.Recorrer(lstLista);
            }
        }
    }
}
