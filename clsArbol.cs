using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryPOO
{
    internal class clsArbol
    {
        private clsNodo PrimarNodo;
        public clsNodo Raiz
        {
            get { return PrimarNodo; }
            set { PrimarNodo = value; }
        }
        public void Agregar(clsNodo nvo)
        {
            if (Raiz == null)
            {
                Raiz = nvo;
            }
            else
            {
                clsNodo Aux = Raiz;
                clsNodo Padre = Raiz;
                while (Aux != null)
                {
                    Padre = Aux;
                    if (nvo.Codigo < Aux.Codigo)
                    {
                        Aux = Aux.Izquierdo;
                    }
                    else
                    {
                        Aux = Aux.Derecho;
                    }
                }
                if (nvo.Codigo < Padre.Codigo)
                {
                    Padre.Izquierdo = nvo;
                }
                else
                {
                    Padre.Derecho = nvo;
                }
            }
        }
        public void Recorrer(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            InOrden(Grilla, Raiz);
        }
        public void InOrden(DataGridView Grilla, clsNodo Raiz)
        {
            if (Raiz.Izquierdo != null)
            {
                InOrden(Grilla, Raiz.Izquierdo);
            }
            Grilla.Rows.Add(Raiz.Codigo, Raiz.Nombre, Raiz.Tramite);
            if (Raiz.Derecho != null)
            {
                InOrden(Grilla, Raiz.Derecho);
            }
        }
        public void Recorrer(ListBox Lista)
        {
            Lista.Items.Clear();
            InOrden(Lista, Raiz);
        }
        public void InOrden(ListBox Lista, clsNodo Raiz)
        {
            if (Raiz.Izquierdo != null)
            {
                InOrden(Lista, Raiz.Izquierdo);
            }
            Lista.Items.Add(Raiz.Codigo);
            if (Raiz.Derecho != null)
            {
                InOrden(Lista, Raiz.Derecho);
            }
        }
        public void Recorrer(ComboBox Lista)
        {
            Lista.Items.Clear();
            InOrden(Lista, Raiz);
        }
        public void InOrden(ComboBox Lista, clsNodo Raiz)
        {
            if (Raiz.Izquierdo != null)
            {
                InOrden(Lista, Raiz.Izquierdo);
            }
            Lista.Items.Add(Raiz.Codigo);
            if (Raiz.Derecho != null)
            {
                InOrden(Lista, Raiz.Derecho);
            }
        }
        public void Recorrer(TreeView tree)
        {
            tree.Nodes.Clear();
            TreeNode Padre = new TreeNode("Arbol");
            tree.Nodes.Add(Padre);
            PreOrden(Raiz, Padre);
            tree.ExpandAll();
        }
        private void PreOrden(clsNodo Raiz, TreeNode nodoTree)
        {
            TreeNode Padre = new TreeNode(Raiz.Codigo.ToString());
            nodoTree.Nodes.Add(Padre);
            if (Raiz.Izquierdo != null)
            {
                PreOrden(Raiz.Izquierdo, Padre);
            }
            if (Raiz.Derecho != null)
            {
                PreOrden(Raiz.Derecho, Padre);
            }
        }
    }
}
