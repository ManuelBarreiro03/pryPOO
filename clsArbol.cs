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
        public void RecorrerInAsc(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            InOrdenAsc(Grilla, Raiz);
        }
        public void InOrdenAsc(DataGridView Grilla, clsNodo Raiz)
        {
            if (Raiz.Izquierdo != null)
            {
                InOrdenAsc(Grilla, Raiz.Izquierdo);
            }
            Grilla.Rows.Add(Raiz.Codigo, Raiz.Nombre, Raiz.Tramite);
            if (Raiz.Derecho != null)
            {
                InOrdenAsc(Grilla, Raiz.Derecho);
            }
        }
        public void RecorrerInDes(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            InOrdenDes(Grilla, Raiz);
        }
        public void InOrdenDes(DataGridView Grilla, clsNodo Raiz)
        {
            if (Raiz.Derecho != null)
            {
                InOrdenDes(Grilla, Raiz.Izquierdo);
            }
            Grilla.Rows.Add(Raiz.Codigo, Raiz.Nombre, Raiz.Tramite);
            if (Raiz.Izquierdo != null)
            {
                InOrdenDes(Grilla, Raiz.Derecho);
            }
        }
        public void RecorrerInAsc(ListBox Lista)
        {
            Lista.Items.Clear();
            InOrdenAsc(Lista, Raiz);
        }
        public void InOrdenAsc(ListBox Lista, clsNodo Raiz)
        {
            if (Raiz.Izquierdo != null)
            {
                InOrdenAsc(Lista, Raiz.Izquierdo);
            }
            Lista.Items.Add(Raiz.Codigo);
            if (Raiz.Derecho != null)
            {
                InOrdenAsc(Lista, Raiz.Derecho);
            }
        }
        public void RecorrerInDes(ListBox Lista)
        {
            Lista.Items.Clear();
            InOrdenDes(Lista, Raiz);
        }
        public void InOrdenDes(ListBox Lista, clsNodo Raiz)
        {
            if (Raiz.Derecho != null)
            {
                InOrdenDes(Lista, Raiz.Izquierdo);
            }
            Lista.Items.Add(Raiz.Codigo);
            if (Raiz.Izquierdo != null)
            {
                InOrdenDes(Lista, Raiz.Derecho);
            }
        }
        public void RecorrerInAsc(ComboBox Lista)
        {
            Lista.Items.Clear();
            InOrdenAsc(Lista, Raiz);
        }
        public void InOrdenAsc(ComboBox Lista, clsNodo Raiz)
        {
            if (Raiz.Izquierdo != null)
            {
                InOrdenAsc(Lista, Raiz.Izquierdo);
            }
            Lista.Items.Add(Raiz.Codigo);
            if (Raiz.Derecho != null)
            {
                InOrdenAsc(Lista, Raiz.Derecho);
            }
        }
        public void RecorrerInDes(ComboBox Lista)
        {
            Lista.Items.Clear();
            InOrdenDes(Lista, Raiz);
        }
        public void InOrdenDes(ComboBox Lista, clsNodo Raiz)
        {
            if (Raiz.Derecho != null)
            {
                InOrdenDes(Lista, Raiz.Izquierdo);
            }
            Lista.Items.Add(Raiz.Codigo);
            if (Raiz.Izquierdo != null)
            {
                InOrdenDes(Lista, Raiz.Derecho);
            }
        }
        public void Recorrer(TreeView tree)
        {
            tree.Nodes.Clear();
            TreeNode Padre = new TreeNode("Arbol");
            tree.Nodes.Add(Padre);
            PreOrdenAsc(Raiz, Padre);
            tree.ExpandAll();
        }
        private void PreOrdenAsc(clsNodo Raiz, TreeNode nodoTree)
        {
            TreeNode Padre = new TreeNode(Raiz.Codigo.ToString());
            nodoTree.Nodes.Add(Padre);
            if (Raiz.Izquierdo != null)
            {
                PreOrdenAsc(Raiz.Izquierdo, Padre);
            }
            if (Raiz.Derecho != null)
            {
                PreOrdenAsc(Raiz.Derecho, Padre);
            }
        }
        public void RecorrerPre(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            PreOrden(Grilla, Raiz);
        }
        public void PreOrden(DataGridView Grilla, clsNodo Raiz)
        {
            Grilla.Rows.Add(Raiz.Codigo, Raiz.Nombre, Raiz.Tramite);
            if (Raiz.Izquierdo != null)
            {
                PreOrden(Grilla, Raiz.Izquierdo);
            }
            if (Raiz.Derecho != null)
            {
                PreOrden(Grilla, Raiz.Derecho);
            }
        }
        public void RecorrerPost(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            PostOrden(Grilla, Raiz);
        }
        public void PostOrden(DataGridView Grilla, clsNodo Raiz)
        {
            if (Raiz.Izquierdo != null)
            {
                PostOrden(Grilla, Raiz.Izquierdo);
            }
            if (Raiz.Derecho != null)
            {
                PostOrden(Grilla, Raiz.Derecho);
            }
            Grilla.Rows.Add(Raiz.Codigo, Raiz.Nombre, Raiz.Tramite);
        }

    }
}
