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
    public partial class frmTablasBDD : Form
    {
        public frmTablasBDD()
        {
            InitializeComponent();
        }
        clsBaseDeDatos BDD = new clsBaseDeDatos();
        string Consulta;

        private void cmdSelectSimple_Click(object sender, EventArgs e)
        {
            Consulta = "select titulo " +
                "from libro";
            BDD.Listar(dgvGrilla, Consulta);
        }

        private void cmdSelectMulti_Click(object sender, EventArgs e)
        {
            Consulta = "select titulo,idlibro " +
                "from libro";
            BDD.Listar(dgvGrilla, Consulta);
        }

        private void cmdJuntar_Click(object sender, EventArgs e)
        {
            Consulta = "";
            BDD.Listar(dgvGrilla, Consulta);
        }

        private void cmdWhereSimple_Click(object sender, EventArgs e)
        {
            Consulta = "";
            BDD.Listar(dgvGrilla, Consulta);
        }

        private void cmdWhereMulti_Click(object sender, EventArgs e)
        {
            Consulta = "SELECT * FROM Libro" +
                " WHERE IdIdioma " +
                "IN (SELECT DISTINCT IdIdioma FROM Libro WHERE IdIdioma < 5)";
            BDD.Listar(dgvGrilla, Consulta);
        }

        private void cmsWhereConvo_Click(object sender, EventArgs e)
        {
            Consulta = "SELECT * " +
                "FROM (SELECT * FROM Libro as T1 WHERE T1.IdIdioma > 5) " +
                "as T2 WHERE T2.IdAutor > 10";
            BDD.Listar(dgvGrilla, Consulta);
        }

        private void cmdUnion_Click(object sender, EventArgs e)
        {
            Consulta = "";
            BDD.Listar(dgvGrilla, Consulta);
        }

        private void cmdInterseccion_Click(object sender, EventArgs e)
        {
            Consulta = "";
            BDD.Listar(dgvGrilla, Consulta);
        }

        private void cmdDiferencia_Click(object sender, EventArgs e)
        {
            Consulta = "";
            BDD.Listar(dgvGrilla, Consulta);
        }
    }
}
