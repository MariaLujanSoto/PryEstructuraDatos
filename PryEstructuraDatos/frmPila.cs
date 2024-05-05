using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PryEstructuraDatos
{
    public partial class frmPila : Form
    {
        public frmPila()
        {
            InitializeComponent();
        }
        clsPila Pila = new clsPila();

        private void frmPila_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo ObjNodo = new clsNodo();
            ObjNodo.Codigo = Convert.ToInt32(txtCodigoNuevo.Text);
            ObjNodo.Nombre = txtNombreNuevo.Text;
            ObjNodo.Tramite = txtTramiteNuevo.Text;
            Pila.Agregar(ObjNodo);
            Pila.Recorrer(dgvPila);
            Pila.Recorrer(lstPila);
            Pila.Recorrer();

            txtTramiteNuevo.Text = "";
            txtCodigoNuevo.Text = "";
            txtNombreNuevo.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Pila.Primero != null)
            {
                lblCodigoEliminado.Text = Pila.Primero.Codigo.ToString();
                lblNombreEliminado.Text = Pila.Primero.Nombre;
                lblTramiteEliminado.Text = Pila.Primero.Tramite;
                Pila.Eliminar();
                Pila.Recorrer(dgvPila);
                Pila.Recorrer(lstPila);
                Pila.Recorrer();

            }
            else
            {
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
    }
}
