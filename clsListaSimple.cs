using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryPOO
{
    internal class clsListaSimple
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
                if (Nuevo.Codigo <= Primero.Codigo)
                {
                    Nuevo.Siguiente = Primero;
                    Primero = Nuevo;
                }
                else
                {
                    clsNodo aux = Primero;
                    clsNodo ant = Primero;
                    while (Nuevo.Codigo > aux.Codigo)
                    {
                        ant = aux;
                        aux = aux.Siguiente;
                        if (aux==null)
                        {
                            break;
                        }
                    }
                    ant.Siguiente = Nuevo;
                    Nuevo.Siguiente = aux;
                }
            }
        }
        public void Eliminar(Int32 cod) 
        {
            if (cod == Primero.Codigo)
            {
                Primero = Primero.Siguiente;
            }
            else
            {
                clsNodo ant = Primero;
                clsNodo Aux = Primero;
                while(Aux.Codigo != cod)
                {
                    ant = Aux;
                    Aux = Aux.Siguiente;
                }
                ant.Siguiente = Aux.Siguiente;
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
        public void Recorrer(ComboBox Lista)
        {
            clsNodo Aux = Primero;
            Lista.Items.Clear();
            while (Aux != null)
            {
                Lista.Items.Add(Aux.Codigo);
                Aux = Aux.Siguiente;
            }
        }
    }
}
