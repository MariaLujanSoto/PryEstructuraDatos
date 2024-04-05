using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PryEstructuraDatos
{
    internal class clsNodo
    {
        private Int32 cod;
        private String nom;
        private String tra;
        private clsNodo sig;
        private clsNodo ant;

        private Int32 Codigo
        {
            get { return cod; }
            set { cod = value; }
        }
        private String Nombre

        {
            get { return nom; }
            set { nom = value; }
        }
        private String Tramite
        {
            get { return tra; }
            set { tra = value; }
        }
        private clsNodo Siguiente
        {
            get { return sig; }
            set { sig = value; }
        }

        private clsNodo Anterior
        {
            get { return ant; }
            set { ant = value; }
        }



    }
}
