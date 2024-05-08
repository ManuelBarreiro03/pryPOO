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
    public partial class frmListaSimple : Form
    {
        public frmListaSimple()
        {
            InitializeComponent();
        }
        clsListaSimple Lista = new clsListaSimple();

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "")
            {
                if (txtNombre.Text != "")
                {
                    if (txtTramite.Text != "")
                    {
                        clsNodo objNodo = new clsNodo();
                        objNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
                        objNodo.Nombre = txtNombre.Text;
                        objNodo.Tramite = txtTramite.Text;
                        Lista.Agregar(objNodo);
                        Lista.Recorrer(dgvGrilla);
                        Lista.Recorrer(lstLista);
                        Lista.Recorrer(cmbEliminar);
                        txtCodigo.Text = "";
                        txtNombre.Text = "";
                        txtTramite.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Campo vacio");
                        txtTramite.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Campo vacio");
                    txtNombre.Focus();
                }
            }
            else
            {
                MessageBox.Show("Campo vacio");
                txtCodigo.Focus();
            }
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            if (Lista.Primero != null)
            {
                Int32 x = Convert.ToInt32(cmbEliminar.Text);
                Lista.Eliminar(x);
                Lista.Recorrer(dgvGrilla);
                Lista.Recorrer(lstLista);
                Lista.Recorrer(cmbEliminar);
            }
            else
            {
                MessageBox.Show("Lista Vacia");
            }
            cmdEliminar.Enabled = false;
        }

        private void cmbEliminar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEliminar.Text=="")
            {
                cmbEliminar.Enabled = false;
            }
            else
            {
                cmdEliminar.Enabled = true;
            }
        }

       
    }
}
