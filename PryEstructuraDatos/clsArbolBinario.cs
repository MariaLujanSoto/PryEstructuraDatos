using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryEstructuraDatos
{
    internal class clsArbolBinario
    {
        private clsNodo PrimerNodo;


        public clsNodo Raiz
        {
            get { return PrimerNodo; }
            set { PrimerNodo = value; }

        }

        public void Agregar(clsNodo Nvo)
        {
            Nvo.Izquierdo = null;
            Nvo.Derecho = null;

            if(Raiz == null)
            {
                Raiz = Nvo;
            }
            else
            {
                clsNodo Ant = Raiz; // NodoPadre
                clsNodo Aux = Raiz;

                while(Aux != null)
                {
                    Ant = Aux;
                    if(Nvo.Codigo < Aux.Codigo)
                    {
                        Aux = Aux.Izquierdo;
                    }
                    else
                    {
                        Aux = Aux.Derecho;
                    }
                }

                if(Nvo.Codigo < Ant.Codigo)
                {
                    Ant.Izquierdo = Nvo;
                }
                else
                {
                    Ant.Derecho = Nvo;
                }
            }

        }

        //---------Recorrer
        public void Recorrer(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            InOrdenAsc(Grilla, Raiz);
        }
        public void Recorrer(ListBox Lista)
        {
            Lista.Items.Clear();
            InOrdenAsc(Lista, Raiz);
        }

        public void Recorrer(TreeView tree)
        {
            tree.Nodes.Clear();
            TreeNode NodoPadre = new TreeNode("Arbol");
            tree.Nodes.Add(NodoPadre);
            PreOrden(Raiz, NodoPadre);
            tree.ExpandAll(); //
        }

        //----------ORDENAMIENTOS

        public void InOrdenAsc(DataGridView Dgv, clsNodo R)
        {
            if (R.Izquierdo != null) InOrdenAsc(Dgv, R.Izquierdo);
            Dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            if (R.Derecho != null) InOrdenAsc(Dgv, R.Derecho);

        }
        public void InOrdenAsc(ListBox Lst, clsNodo R)
        {
            if(R.Izquierdo != null)
            {
                InOrdenAsc(Lst, R.Izquierdo);
            }
            Lst.Items.Add(R.Codigo);
            if(R.Derecho != null)
            {
                InOrdenAsc(Lst, R.Derecho);
            }
        }
        
        private void PreOrden(clsNodo R, TreeNode nodoTreeView)
        {
            TreeNode NodoPadre = new TreeNode(R.Codigo.ToString());
            nodoTreeView.Nodes.Add(NodoPadre);

            if(R.Izquierdo != null)
            {
                PreOrden(R.Izquierdo, NodoPadre);
            }
            if(R.Derecho != null)
            {
                PreOrden(R.Derecho, NodoPadre);
            }
        }
    }
}
