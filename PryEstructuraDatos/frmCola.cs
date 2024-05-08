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
    public partial class frmCola : Form
    {
        public frmCola()
        {
            InitializeComponent();
        }

        private void frmEstructuraNoLineal_Load(object sender, EventArgs e)
        {

        }

        clsCola FilaDePersonas = new clsCola();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo ObjNodo = new clsNodo();
            ObjNodo.Codigo = Convert.ToInt32(txtCodigoNuevo.Text);
            ObjNodo.Nombre = txtNombreNuevo.Text;
            ObjNodo.Tramite = txtTramiteNuevo.Text;
            FilaDePersonas.Agregar(ObjNodo);
            FilaDePersonas.Recorrer(dgvCola);
            FilaDePersonas.Recorrer(lstCola);
            FilaDePersonas.Recorrer();

            txtCodigoNuevo.Text = "";
            txtTramiteNuevo.Text = "";
            txtNombreNuevo.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(FilaDePersonas.Primero != null)
            {
                lblCodigoEliminado.Text = FilaDePersonas.Primero.Codigo.ToString();
                lblNombreEliminado.Text = FilaDePersonas.Primero.Nombre;
                lblTramiteEliminado.Text = FilaDePersonas.Primero.Tramite;
                FilaDePersonas.Eliminar();
                FilaDePersonas.Recorrer(dgvCola);
                FilaDePersonas.Recorrer(lstCola);
                FilaDePersonas.Recorrer();
                

            }
            else
            {
                MessageBox.Show("La Cola esta vacia");
                lblCodigoEliminado.Text = "";
                lblNombreEliminado.Text = "";
                lblTramiteEliminado.Text = "";
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmVentanaPrincipal x = new frmVentanaPrincipal();
            x.Show();
            this.Hide();
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
    }
}
