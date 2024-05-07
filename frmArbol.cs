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
            Arbol.Eliminar(Convert.ToInt32(cmbEliminar.Text)); 
            Arbol.Recorrer(treeView);
        }

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
                        Arbol.Agregar(objNodo);
                        Arbol.RecorrerInAsc(dgvGrilla);
                        Arbol.RecorrerInAsc(cmbEliminar);
                        Arbol.Recorrer(treeView);
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

        private void cmdEquilibrar_Click(object sender, EventArgs e)
        {
            Arbol.Equilibrar();
            Arbol.Recorrer(treeView);
        }

        private void rbnInOrdenAsc_CheckedChanged(object sender, EventArgs e)
        {
            if (Arbol.Raiz != null)
            {
                Arbol.RecorrerInAsc(dgvGrilla);
                Arbol.RecorrerInAsc(cmbEliminar);
            }
            else
            {
                MessageBox.Show("no existe la raiz");
            }
            
        }

        private void rbnInOrdenDes_CheckedChanged(object sender, EventArgs e)
        {
            if (Arbol.Raiz != null)
            {
                Arbol.RecorrerInDes(dgvGrilla);
                Arbol.RecorrerInDes(cmbEliminar);
            }
            else
            {
                MessageBox.Show("no existe la raiz");
            }
        }

        private void rbnPreOrden_CheckedChanged(object sender, EventArgs e)
        {
            if (Arbol.Raiz != null)
            {
                Arbol.RecorrerPre(dgvGrilla);
            }
            else
            {
                MessageBox.Show("no existe la raiz");
            }
        }

        private void rbnPostOrden_CheckedChanged(object sender, EventArgs e)
        {
            if (Arbol.Raiz != null)
            {
                Arbol.RecorrerPost(dgvGrilla);
            }
            else
            {
                MessageBox.Show("no existe la raiz");
            }
        }
    }
}
