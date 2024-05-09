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

        //--------------AGREGAR

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

        //-----------RECORRER

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
            tree.ExpandAll(); 
        }

        public void Recorrer(ComboBox Cmb)
        {
            Cmb.Items.Clear();
            InOrdenAsc(Cmb, Raiz);
        }
        public void RecorrerDesc(ListBox Lst)
        {
            Lst.Items.Clear();
            InOrdenDesc(Lst, Raiz);
        }

        public void RecorrerDesc(DataGridView dgv)
        {
            dgv.Rows.Clear();
            InOrdenDesc(dgv, Raiz);
        }

        public void RecorrerDesc(ComboBox Cmb)
        {
            Cmb.Items.Clear();
            InOrdenDesc(Cmb, Raiz);
        }

        public void RecorrerPreOrden(DataGridView dgv)
        {
            dgv.Rows.Clear();
            PreOrden(dgv, Raiz);
        }

        public void RecorrerPreOrden(ListBox Lst)
        {
            Lst.Items.Clear();
            PreOrden(Lst, Raiz);
        }

        public void RecorrerPreOrden(ComboBox Cmb)
        {
            Cmb.Items.Clear();
            PreOrden(Cmb, Raiz);
        }

        public void RecorrerPostOrden(ComboBox Cmb)
        {
            Cmb.Items.Clear();
            PostOrden(Cmb, Raiz);
        }
        public void RecorrerPostOrden(ListBox lst)
        {
            lst.Items.Clear();
            PostOrden(lst, Raiz);
        }
        public void RecorrerPostOrden(DataGridView dgv)
        {
            dgv.Rows.Clear();
            PostOrden(dgv, Raiz);
        }

        //----------ORDENAMIENTOS

        //POSTORDEN

        public void PostOrden(ComboBox Cmb, clsNodo R)
        {
            if (R == null)
            {
                return;
            }
            if (R.Izquierdo != null)
            {
                PostOrden(Cmb, R.Izquierdo);
            }

            if (R.Derecho != null)
            {
                PostOrden(Cmb, R.Derecho);
            }

            Cmb.Items.Add(R.Codigo);
        }

        public void PostOrden(ListBox lst, clsNodo R)
        {
            if (R == null)
            {
                return;
            }
            if (R.Izquierdo != null)
            {
                PostOrden(lst, R.Izquierdo);
            }

            if (R.Derecho != null)
            {
                PostOrden(lst, R.Derecho);
            }

            lst.Items.Add(R.Codigo);
        }

        public void PostOrden(DataGridView dgv, clsNodo R)
        {
            if (R == null)
            {
                return;
            }
            if (R.Izquierdo != null)
            {
                PostOrden(dgv, R.Izquierdo);
            }

            if (R.Derecho != null)
            {
                PostOrden(dgv, R.Derecho);
            }

            dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
        }


        //PREORDEN
        private void PreOrden(clsNodo R, TreeNode nodoTreeView)
        {
            if (R == null)
            {
                return;
            }
            TreeNode NodoPadre = new TreeNode(R.Codigo.ToString());

            nodoTreeView.Nodes.Add(NodoPadre);

            if (R.Izquierdo != null)
            {
                PreOrden(R.Izquierdo, NodoPadre);
            }

            if (R.Derecho != null)
            {
                PreOrden(R.Derecho, NodoPadre);
            }
        }

        public void PreOrden(DataGridView dgv, clsNodo R) 
        {
            if (R == null)
            {
                return;
            }
            dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);

            if (R.Izquierdo != null)
            {
                PreOrden(dgv, R.Izquierdo);
            }

            if (R.Derecho != null)
            {
                PreOrden(dgv, R.Derecho);
            }
        }
        public void PreOrden(ComboBox Cmb, clsNodo R) 
        {
            if (R == null)
            {
                return;
            }
            Cmb.Items.Add(R.Codigo);

            if (R.Izquierdo != null)
            {
                PreOrden(Cmb, R.Izquierdo);
            }

            if (R.Derecho != null)
            {
                PreOrden(Cmb, R.Derecho);
            }
        }

        public void PreOrden(ListBox lst, clsNodo R) 
        {
            if (R == null)
            {
                return;
            }
            lst.Items.Add(R.Codigo);

            if (R.Izquierdo != null)
            {
                PreOrden(lst, R.Izquierdo);
            }

            if (R.Derecho != null)
            {
                PreOrden(lst, R.Derecho);
            }
        }

        //ASCENDENTE

        public void InOrdenAsc(DataGridView Dgv, clsNodo R)
        {
            if (R == null)
            {
                return;
            }
            if (R.Izquierdo != null)
            {
                InOrdenAsc(Dgv, R.Izquierdo);
            }
            Dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            if (R.Derecho != null)
            {
                InOrdenAsc(Dgv, R.Derecho);
            }

        }
        public void InOrdenAsc(ListBox Lst, clsNodo R)
        {
            if (R == null)
            {
                return;
            }
            if (R.Izquierdo != null)
            {
                InOrdenAsc(Lst, R.Izquierdo);
            }
            Lst.Items.Add(R.Codigo);
            if(R.Derecho != null)
            {
                InOrdenAsc(Lst, R.Derecho);
            }
        }
        

        public void InOrdenAsc(ComboBox Cmb, clsNodo R)
        {
            if (R == null)
            {
                return;
            }
            if (R.Izquierdo != null)
            {
                InOrdenAsc(Cmb, R.Izquierdo);
            }
            Cmb.Items.Add(R.Codigo);
            if (R.Derecho != null)
            {
                InOrdenAsc(Cmb, R.Derecho);
            }
        }
        //DESCENDENTE

        public void InOrdenDesc(DataGridView Dgv, clsNodo R)
        {
            if (R == null)
            {
                return;
            }
            if (R.Derecho != null)
            {
                InOrdenDesc(Dgv, R.Derecho);
            }
            Dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            if (R.Izquierdo != null)
            {
                InOrdenDesc(Dgv, R.Izquierdo);
            }

        }
        

        public void InOrdenDesc(ComboBox Cmb, clsNodo R)
        {
            if (R == null)
            {
                return;
            }
            if (R.Derecho != null)
            {
                InOrdenDesc(Cmb, R.Derecho);
            }
            Cmb.Items.Add(R.Codigo);
            if (R.Izquierdo != null)
            {
                InOrdenDesc(Cmb, R.Izquierdo);
            }
        }

        public void InOrdenDesc(ListBox Lst, clsNodo R)
        {
            if (R == null)
            {
                return;
            }
            if (R.Derecho != null)
            {
                InOrdenDesc(Lst, R.Derecho);
            }

            Lst.Items.Add(R.Codigo);

            if (R.Izquierdo != null)
            {
                InOrdenDesc(Lst, R.Izquierdo);
            }
        }

        //---------EQUILIBRAR Y GRABAR

        private clsNodo[] Vector = new clsNodo[100];
        private Int32 i = 0;

        public void Equilibrar()
        {
            i = 0;
            GrabarVectorInOrden(Raiz);
            Raiz = null;
            EquilibrarArbol(0, i-1);
        }

        private void EquilibrarArbol(Int32 ini, Int32 fin)
        {
            Int32 m = (ini + fin) / 2;
            if (ini <= fin)
            {
                Agregar(Vector[m]);
                EquilibrarArbol(ini, m - 1);
                EquilibrarArbol(m + 1, fin);
            }
        }

        private void GrabarVectorInOrden(clsNodo NodoPadre)
        {
            if(NodoPadre.Izquierdo != null)
            {
                GrabarVectorInOrden(NodoPadre.Izquierdo);
            }
            Vector[i] = NodoPadre;
            i = i + 1;
            if(NodoPadre.Derecho != null)
            {
                GrabarVectorInOrden(NodoPadre.Derecho);                               
            }
        }

          

        public void GrabarVectorInOrden(clsNodo NodoPadre, Int32 Codigo)
        {
            
            if (NodoPadre.Izquierdo != null)
            {
                GrabarVectorInOrden(NodoPadre.Izquierdo, Codigo);
            }

            if(NodoPadre.Codigo != Codigo)
            {
                Vector[i] = NodoPadre;
                i = i + 1;
            }
            if(NodoPadre.Derecho != null)
            {
                GrabarVectorInOrden(NodoPadre.Derecho, Codigo);
            }
        }

        //-----ELIMINAR
        public void Eliminar(Int32 codigo)
        {
            i = 0;
            GrabarVectorInOrden(Raiz, codigo);
            Raiz = null;
            EquilibrarArbol(0, i - 1);
        }
    }
}
