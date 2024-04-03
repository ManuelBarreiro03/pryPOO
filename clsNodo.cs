using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryPOO
{
    internal class clsNodo
    {
        private int cod;
        private string nom;
        private string tram;
        private clsNodo sig;
        private clsNodo ant;
        public int Codigo
        {
            get { return cod; }
            set { cod = value; }
        }
        public string Nombre
        {
            get { return nom; }
            set { nom = value; }
        }
        public string Tramite
        {
            get { return tram; }
            set { tram = value; }
        }
        public clsNodo Siguiente
        {
            get { return sig; }
            set { sig = value; }
        }
        public clsNodo Anterior
        {
            get { return ant; }
            set { ant = value; }
        }
    }
}
