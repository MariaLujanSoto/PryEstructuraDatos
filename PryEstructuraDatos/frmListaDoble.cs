using System;
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
    public partial class frmListaDoble : Form
    {
        public frmListaDoble()
        {
            InitializeComponent();
        }
        clsListaDoble Lista = new clsListaDoble();

        private void frmListaDoble_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
               clsNodo ObjNodo = new clsNodo();
                ObjNodo.Codigo = Convert.ToInt32(txtCodigoNuevo.Text);
                ObjNodo.Nombre = txtNombreNuevo.Text;
                ObjNodo.Tramite = txtTramiteNuevo.Text;
                Lista.Agregar(ObjNodo);
                Lista.Recorrer(dgvListaDoble);
                Lista.Recorrer(lstListaDoble);
                Lista.Recorrer(cmbListaDoble);
                Lista.Recorrer();

                txtCodigoNuevo.Text = "";
                txtTramiteNuevo.Text = "";
                txtNombreNuevo.Text = "";
           
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Lista.Primero != null && cmbListaDoble.Text != "")
            {
                Int32 x = Convert.ToInt32(cmbListaDoble.Text);
                Lista.Eliminar(x);
                Lista.Recorrer(dgvListaDoble);
                Lista.Recorrer(lstListaDoble);
                Lista.Recorrer(cmbListaDoble);
                Lista.Recorrer();
                cmbListaDoble.Text = "";
            }
            else
            {

                if (Lista.Primero == null)
                {
                    MessageBox.Show("La Lista esta vacia");
                    cmbListaDoble.Text = "";

                }
                else
                {
                    if (cmbListaDoble.Text == "")
                    {
                        MessageBox.Show("Debe seleccionar un valor");

                    }
                }
            }
        }

        private void optAscendente_CheckedChanged(object sender, EventArgs e)
        {
            Lista.RecorrerAsc(dgvListaDoble);
            Lista.RecorrerAsc(cmbListaDoble);
            Lista.RecorrerAsc(lstListaDoble);

            Lista.Recorrer();
        }

        private void optDescendente_CheckedChanged(object sender, EventArgs e)
        {
            Lista.RecorrerDes(dgvListaDoble);
            Lista.RecorrerDes(cmbListaDoble);
            Lista.RecorrerDes(lstListaDoble);

            Lista.Recorrer();
        }

        private void cmbListaDoble_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmVentanaPrincipal x = new frmVentanaPrincipal();
            x.Show();
            this.Hide();
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
