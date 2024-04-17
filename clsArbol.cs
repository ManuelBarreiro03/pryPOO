using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}
