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
            txtCodigoNuevo.Text = "";
            txtNombreNuevo.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(FilaDePersonas.Primero != null)
            {
                lblCodigoEliminado.Text = FilaDePersonas.Primero.ToString();
                lblNombreEliminado.Text = FilaDePersonas.Primero.Nombre;
                lblTramiteEliminado.Text = FilaDePersonas.Primero.Tramite;
                FilaDePersonas.Eliminar();
                FilaDePersonas.Recorrer(dgvCola);
                FilaDePersonas.Recorrer(lstCola);
                FilaDePersonas.Recorrer();

            }
            else
            {
                lblCodigoElimiado.Text = "";
                lblNombreEliminado.Text = "";
                lblTramiteEliminado.Text = "";
            }
        }
    }
}
