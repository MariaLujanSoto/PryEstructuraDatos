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
                    // Operación: Diferencia
                    lblEnunciado.Text = cmbConsulta.Text + ": Paises que no tienen libros";
                    VarSQL = "SELECT * FROM pais WHERE idpais NOT IN (SELECT idpais FROM libro)";
                    break;

                case 1:
                    // Operación: Intersección
                    lblEnunciado.Text = cmbConsulta.Text + ": Libros cuyo idpais sea menor a 2 ";
                    VarSQL = " SELECT *  FROM libro WHERE idpais IN (SELECT DISTINCT  idpais FROM libro WHERE idpais < 2)";
                    break;

                case 2:
                    // Operación: Unión
                    lblEnunciado.Text = cmbConsulta.Text + ": Autores y Idiomas ";
                    VarSQL = "SELECT * FROM autor UNION SELECT * FROM idioma";
                    break;

                case 3:
                    // Operación: Selección Simple
                    lblEnunciado.Text = cmbConsulta.Text + ": Libros cuyo precio supera los 500 ";
                    VarSQL = "SELECT * FROM libro WHERE Precio > 500";
                    break;

                case 4:
                    // Operación: Selección por multiatributo por Intersección
                    lblEnunciado.Text = cmbConsulta.Text + ": Libros publicados con ID mayor a 5 y con cantidad mayor a 10 ";
                    VarSQL = "SELECT * FROM libro WHERE idlibro> 5 AND cantidad > 10 ";
                    break;

                case 5:
                    // Operación: Selección por multiatributo por Convolución
                    lblEnunciado.Text = cmbConsulta.Text + ": Libros publicados después del año 2000 o con precio mayor a 20 ";
                    VarSQL = "SELECT * FROM  (SELECT * FROM  libro WHERE precio > 20) WHERE año > '2000'";
                    break;

                case 6:
                    // Operación: Orden
                    lblEnunciado.Text = cmbConsulta.Text + ": Libros ordenados por año ";
                    VarSQL = "SELECT * FROM libro ORDER BY año DESC";
                    break;

                case 7:
                    // Operación: Proyección por un atributo
                    lblEnunciado.Text = cmbConsulta.Text + ": Títulos de los libros ";
                    VarSQL = "SELECT titulo FROM libro";
                    break;

                case 8:
                    // Operación: Proyección por multiatributo
                    lblEnunciado.Text = cmbConsulta.Text + ": Títulos y años de los libros";
                    VarSQL = "SELECT titulo, año FROM libro";
                    break;

                case 9:
                    // Operación: Juntar
                    lblEnunciado.Text = cmbConsulta.Text + ": Libros y sus autores";
                    VarSQL = "SELECT libro.titulo, autor.nombre AS autor  FROM libro, autor WHERE libro.idautor = autor.idautor";
                    break;

                case 10:
                    // Operación: Diferencia
                    lblEnunciado.Text = cmbConsulta.Text + ": Autores sin libros ";
                    VarSQL = "SELECT * FROM autor WHERE idautor NOT IN (SELECT idautor FROM libro)";
                    break;

                case 11:
                    // Operación: Intersección
                    lblEnunciado.Text = cmbConsulta.Text + ": Libros en español publicados antes del año 2000 ";
                    VarSQL =@"SELECT * FROM libro WHERE ididioma = (SELECT ididioma FROM idioma WHERE nombre = 'Español') AND año < '2000'"; 
                    break;

                case 12:
                    // Operación: Unión
                    lblEnunciado.Text = cmbConsulta.Text + ": Países y Idiomas";
                    VarSQL = " SELECT * FROM pais UNION SELECT * FROM idioma";
                    break;

                case 13:
                    // Operación: Selección Simple
                    lblEnunciado.Text = cmbConsulta.Text + ": Libros con precio mayor a 50";
                    VarSQL = "SELECT * FROM libro WHERE precio > 50";
                    break;

                case 14:
                    // Operación: Selección por multiatributo por Intersección
                    lblEnunciado.Text = cmbConsulta.Text + ": Libros publicados antes del año 2000 y con precio mayor a 30 ";
                    VarSQL = "SELECT * FROM libro WHERE año < '2000' AND precio > 30";
                    break;

                case 15:
                    // Operación: Selección por multiatributo por Convolución
                    lblEnunciado.Text = cmbConsulta.Text + ": Libros publicados antes del año 2000 o con precio mayor a 30";
                    VarSQL = "SELECT * FROM (SELECT * FROM libro WHERE año < '2000') WHERE precio > 30";
                    break;

                case 16:
                    // Operación: Orden
                    lblEnunciado.Text = cmbConsulta.Text + ": Libros ordenados por precio ascendente";
                    VarSQL = "SELECT * FROM libro ORDER BY precio ASC";
                    break;

                case 17:
                    // Operación: Proyección por un atributo
                    lblEnunciado.Text = cmbConsulta.Text + ": Nombres de los autores";
                    VarSQL = "SELECT nombre FROM autor";
                    break;

                case 18:
                    // Operación: Proyección por multiatributo
                    lblEnunciado.Text = cmbConsulta.Text + ": Nombres e IDs de los autores ";
                    VarSQL = "SELECT nombre, idautor FROM autor";
                    break;

                case 19:
                    // Operación: Juntar
                    lblEnunciado.Text = cmbConsulta.Text + ": Libros y sus idiomas";
                    VarSQL = "SELECT libro.titulo, idioma.nombre AS idioma FROM libro, idioma WHERE libro.ididioma = idioma.ididioma";
                    break;

                default:
                    lblEnunciado.Text = "Selecciona una opcion en la lista desplegable";
                    MessageBox.Show("Seleccione alguna de las opciones");

                    break;
              

            }
            objBD.Listar(dgvGrillaSql, VarSQL);
        }
    }
}
