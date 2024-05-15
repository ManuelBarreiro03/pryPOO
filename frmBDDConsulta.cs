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
    public partial class frmBDDConsulta : Form
    {
        public frmBDDConsulta()
        {
            InitializeComponent();
        }

        private void cmdListar_Click(object sender, EventArgs e)
        {
            clsBaseDeDatos objBDD = new clsBaseDeDatos();
            objBDD.Listar(dgvGrilla, txtSQL.Text);
        }

    }
}
