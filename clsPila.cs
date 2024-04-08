using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryPOO
{
    internal class clsPila
    {
        private clsNodo pri;
        public clsNodo Primero
        {
            get { return pri; }
            set { pri = value; }
        }
        public void Agregar(clsNodo Nuevo) 
        {
            if (Primero == null)
            {
                Primero = Nuevo;
            }
            else
            {
                Nuevo.Siguiente = Primero;
                Primero = Nuevo;
            }
        }
        public void Eliminar() 
        {
            if (Primero!=null)
            {
                Primero = Primero.Siguiente;
            }
        }
        public void Recorrer(DataGridView Grilla) 
        {
            clsNodo aux = Primero;
            Grilla.Rows.Clear();
            while (aux != null)
            {
                Grilla.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                aux = aux.Siguiente;
            }
        }
        public void Recorrer(ListBox Lista)
        {
            clsNodo Aux = Primero;
            Lista.Items.Clear();
            while (Aux != null)
            {
                Lista.Items.Add(Aux.Codigo);
                Aux = Aux.Siguiente;
            }
        }
        public void Recorrer(ComboBox Combo)
        {
            clsNodo Aux = Primero;
            Combo.Items.Clear();
            while (Aux != null)
            {
                Combo.Items.Add(Aux.Codigo);
                Aux = Aux.Siguiente;
            }
        }
    }
}
