using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryPOO
{
    internal class clsCliente
    {
        private int cod;
        private string nom;
        private decimal deu;

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
        public decimal Deuda 
        {
            get { return deu; }
            set { deu = value; }
        }
        public void Comprar(decimal Importe) 
        {
            deu = deu + Importe;
        }
        public void Pagar(decimal Importe)
        {
            deu = deu - Importe;
        }
    }
}
