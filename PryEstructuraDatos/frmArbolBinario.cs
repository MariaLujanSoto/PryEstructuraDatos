using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryEstructuraDatos
{
    public partial class frmArbolBinario : Form
    {
        public frmArbolBinario()
        {
            InitializeComponent();
        }

        clsArbolBinario Arbol = new clsArbolBinario();

        private void optIOAsc_CheckedChanged(object sender, EventArgs e)
        {
            Arbol.Recorrer(dgvArbolBinario);
            Arbol.Recorrer(lstArbolBinario);
            Arbol.Recorrer(cmbAB);

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo ObjNodo = new clsNodo();
            ObjNodo.Codigo = Convert.ToInt32(txtCodigoNuevo.Text);
            ObjNodo.Nombre = txtNombreNuevo.Text;
            ObjNodo.Tramite = txtTramiteNuevo.Text;
            Arbol.Agregar(ObjNodo);
            Arbol.Recorrer(dgvArbolBinario);
            Arbol.Recorrer(lstArbolBinario);
            Arbol.Recorrer(trvArbolBinario);
            Arbol.Recorrer(cmbAB);


            txtCodigoNuevo.Text = "";
            txtTramiteNuevo.Text = "";
            txtNombreNuevo.Text = "";

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {


            if (Arbol.Raiz != null)
            {
                if (cmbAB.Text == "")
                {
                    MessageBox.Show("Debe seleccionar un valor");

                }
                else
                {
                    Int32 x = Convert.ToInt32(cmbAB.Text);
                    Arbol.Eliminar(x);
                    Arbol.Recorrer(dgvArbolBinario);
                    Arbol.Recorrer(lstArbolBinario);
                    Arbol.Recorrer(trvArbolBinario);
                    Arbol.Recorrer(cmbAB);
                    cmbAB.Text = "";
                }


            }
            else
            {
                MessageBox.Show("El Arbol esta vacio");
                cmbAB.Text = "";
            }
                

        }

        private void btnEquilibrar_Click(object sender, EventArgs e)
        {
            Arbol.Equilibrar();
            Arbol.Recorrer(trvArbolBinario);
        }

        private void btnIODesc_CheckedChanged(object sender, EventArgs e)
        {
            Arbol.RecorrerDesc(dgvArbolBinario);
            Arbol.RecorrerDesc(cmbAB);
            Arbol.RecorrerDesc(lstArbolBinario);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmVentanaPrincipal x = new frmVentanaPrincipal();
            x.Show();
            this.Hide();
        }

        private void btnPreOrden_CheckedChanged(object sender, EventArgs e)
        {
            Arbol.RecorrerPreOrden(dgvArbolBinario);
            Arbol.RecorrerPreOrden(lstArbolBinario);
            Arbol.RecorrerPreOrden(cmbAB);
        }

        private void btnPostOrden_CheckedChanged(object sender, EventArgs e)
        {
            Arbol.RecorrerPostOrden(dgvArbolBinario);
            Arbol.RecorrerPostOrden(lstArbolBinario);
            Arbol.RecorrerPostOrden(cmbAB);
        }

        private void txtCodigoNuevo_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigoNuevo.Text != "" && txtNombreNuevo.Text != "" && txtTramiteNuevo.Text != "")
            {
                btnAgregar.Enabled = true;
            }
            else
            {
                btnAgregar.Enabled = false;
            }
        }

        private void txtNombreNuevo_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigoNuevo.Text != "" && txtNombreNuevo.Text != "" && txtTramiteNuevo.Text != "")
            {
                btnAgregar.Enabled = true;
            }
            else
            {
                btnAgregar.Enabled = false;
            }
        }

        private void txtTramiteNuevo_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigoNuevo.Text != "" && txtNombreNuevo.Text != "" && txtTramiteNuevo.Text != "")
            {
                btnAgregar.Enabled = true;
            }
            else
            {
                btnAgregar.Enabled = false;
            }
        }
    }
}
