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
        private clsNodo PrimerNodo;
        public clsNodo Raiz
        {
            get { return PrimerNodo; }
            set { PrimerNodo = value; }
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
                InOrdenDes(Grilla, Raiz.Derecho);
            }
            Grilla.Rows.Add(Raiz.Codigo, Raiz.Nombre, Raiz.Tramite);
            if (Raiz.Izquierdo != null)
            {
                InOrdenDes(Grilla, Raiz.Izquierdo);
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
                InOrdenDes(Lista, Raiz.Derecho);
            }
            Lista.Items.Add(Raiz.Codigo);
            if (Raiz.Izquierdo != null)
            {
                InOrdenDes(Lista, Raiz.Izquierdo);
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
        public clsNodo BuscarCodigo(Int32 cod)
        {
            clsNodo Aux = Raiz;
            while (Aux != null)
            {
                if (cod == Aux.Codigo) break;
                if (cod < Aux.Codigo) Aux = Aux.Izquierdo;
                else Aux = Aux.Derecho;
            }
            return Aux;
        }
        private clsNodo[] vector = new clsNodo[100];
        private Int32 i = 0;
        public void Equilibrar()
        {
            i = 0;
            GrabarVectorInOrden(Raiz);
            Raiz = null;
            EquilibrarArbol(0, i - 1);
        }
        private void GrabarVectorInOrden(clsNodo NodoPadre)
        {
            if (NodoPadre.Izquierdo != null)
            {
                GrabarVectorInOrden(NodoPadre.Izquierdo);
            }
            vector[i] = NodoPadre;
            i = i + 1;
            if (NodoPadre.Derecho != null)
            {
                GrabarVectorInOrden(NodoPadre.Derecho);
            }
        }
        private void EquilibrarArbol(Int32 ini, Int32 fin)
        {
            Int32 m = (ini + fin) / 2;
            if (ini <= fin)
            {
                Agregar(vector[m]);
                EquilibrarArbol(ini, m - 1);
                EquilibrarArbol(m + 1, fin);
            }
        }
        public void Eliminar(Int32 codigo)
        {
            i = 0;
            GrabarVectorInOrden(Raiz, codigo);
            Raiz = null;
            EquilibrarArbol(0, i - 1);
        }
        private void GrabarVectorInOrden(clsNodo NodoPadre,Int32 Codigo)
        {
            if (NodoPadre.Izquierdo != null)
            {
                GrabarVectorInOrden(NodoPadre.Izquierdo, Codigo);
            }
            if (NodoPadre.Codigo != Codigo)
            {
                vector[i] = NodoPadre;
                i = i + 1;
            }
            if (NodoPadre.Derecho != null)
            {
                GrabarVectorInOrden(NodoPadre.Derecho, Codigo);
            }
        }

    }
}
