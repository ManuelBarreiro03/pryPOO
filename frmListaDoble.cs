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
    public partial class frmListaDoble : Form
    {
        public frmListaDoble()
        {
            InitializeComponent();
        }

        clsListaDoble Lista = new clsListaDoble();

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            clsNodo objNodo = new clsNodo();
            objNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            objNodo.Nombre = txtNombre.Text;
            objNodo.Tramite = txtTramite.Text;
            Lista.Agregar(objNodo);
            Lista.RecorrerAsc(dgvGrilla);
            Lista.RecorrerAsc(lstLista);
            Lista.RecorrerAsc(cmbEliminar);
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            if (Lista.Primero != null)
            {
                Int32 x = Convert.ToInt32(cmbEliminar.Text);
                Lista.Eliminar(x);
                Lista.RecorrerAsc(dgvGrilla);
                Lista.RecorrerAsc(lstLista);
                Lista.RecorrerAsc(cmbEliminar);
            }
            else
            {
                MessageBox.Show("Lista Vacia");
            }
        }

        private void rbtAscendente_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtAscendente.Checked)
            {
                Lista.RecorrerAsc(dgvGrilla);
                Lista.RecorrerAsc(lstLista);
            }
            else
            {
                Lista.RecorrerDes(dgvGrilla);
                Lista.RecorrerDes(lstLista);
            }
        }
    }
}
