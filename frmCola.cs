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

        private void cmdAgregar_Click_1(object sender, EventArgs e)
        {
            try
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
                            FilaDePersonas.Agregar(objNodo);
                            FilaDePersonas.Recorrer(dgvGrilla);
                            FilaDePersonas.Recorrer(lstLista);
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
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }
    }
}
