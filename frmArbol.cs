using System;
using System.Collections;
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
    public partial class frmArbol : Form
    {
        public frmArbol()
        {
            InitializeComponent();
        }
        clsArbol Arbol = new clsArbol();
        private void cmdEliminar_Click(object sender, EventArgs e)
        {

        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            clsNodo objNodo = new clsNodo();
            objNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            objNodo.Nombre = txtNombre.Text;
            objNodo.Tramite = txtTramite.Text;
            Arbol.Agregar(objNodo);
            Arbol.Recorrer(dgvGrilla);
            Arbol.Recorrer(treeView);
            Arbol.Recorrer(cmbEliminar);
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }

        private void cmdEquilibrar_Click(object sender, EventArgs e)
        {

        }
    }
}
