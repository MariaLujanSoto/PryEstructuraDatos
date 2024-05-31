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
    public partial class frmRepasoOperacionesBaseDatos : Form
    {
        public frmRepasoOperacionesBaseDatos()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            clsBaseDatos objBD = new clsBaseDatos();
            String VarSQL = "SELECT * FROM LIBRO";

            switch(cmbConsulta.SelectedIndex)
            {

                case 0:
                    lblEnunciado.Text = cmbConsulta.Text + ":" +
                        "Paises que no tienen libros";
                    VarSQL = " select * from pais where" +
                        "idpais not in" + 
                        "(select idpais from libro)";
                    break;

                case 1:

                    break;

                default:
                    lblEnunciado.Text = "Selecciona una opcion en la lista desplegable";

                    break;
              

            }
            objBD.Listar(dgvGrillaSql, VarSQL);
        }
    }
}
