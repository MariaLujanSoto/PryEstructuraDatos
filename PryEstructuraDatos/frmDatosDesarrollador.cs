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
    public partial class frmDatosDesarrollador : Form
    {
        public frmDatosDesarrollador()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmDatosDesarrollador_Load(object sender, EventArgs e)
        {
            lblMiDni.Text = "43530842";
            lblMiApellido.Text = "Soto";
            lblMiNombre.Text = "María Luján";
            lblMateria.Text = "Estructura De Datos";
            lblCarrera.Text = "Analista de Sistemas";
            lblFecha.Text = "10/05/2024";
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmVentanaPrincipal x = new frmVentanaPrincipal();
            x.Show();
            this.Hide();
        }
    }
}
