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
                    lblEnunciado.Text = cmbConsulta.Text + ":" + "Paises que no tienen libros";
                    VarSQL = " select * from pais where idpais not in (select idpais from libro)";
                    break;

                case 1:
                    // Operación: Proyección con subconsulta
                    lblEnunciado.Text = cmbConsulta.Text + ": Libros por idioma";
                    VarSQL = @"
                    SELECT idioma.nombre, 
                           (SELECT COUNT(*) 
                            FROM libro 
                            WHERE libro.ididioma = idioma.ididioma) AS cantidad_libros 
                    FROM idioma";
                    break;

                case 2:
                    // Operación: Proyección con subconsulta
                    lblEnunciado.Text = cmbConsulta.Text + ": Autores que tienen libros";
                    VarSQL = "SELECT nombre FROM autor WHERE idautor IN (SELECT DISTINCT idautor FROM libro)";
                    break;

                case 3:
                    // Operación: Selección
                    lblEnunciado.Text = cmbConsulta.Text + ": Libros publicados después del año 2000";
                    VarSQL = "SELECT * FROM libro WHERE año > 2000";
                    break;

                case 4:
                    // Operación: Proyección con subconsulta
                    lblEnunciado.Text = cmbConsulta.Text + ": Libros y sus autores";
                    VarSQL = "SELECT titulo, (SELECT nombre FROM autor WHERE autor.idautor = libro.idautor) AS autor FROM libro";
                    break;

                case 5:
                    // Operación: Proyección con subconsulta
                    lblEnunciado.Text = cmbConsulta.Text + ": Idiomas y el promedio de precios de sus libros";
                    VarSQL = @"
                       SELECT idioma.nombre, 
                               (SELECT AVG(libro.cantidadmprecio) 
                                FROM libro 
                                WHERE libro.ididioma = idioma.ididioma) AS promedio_precio 
                        FROM idioma";
                    break;

                case 6:
                    // Operación: Proyección con subconsulta
                    lblEnunciado.Text = cmbConsulta.Text + ": Libros por país";
                    VarSQL = @"
                        SELECT pais.nombre, 
                               (SELECT COUNT(*) 
                                FROM libro 
                                WHERE libro.idpais = pais.idpais) AS cantidad_libros 
                        FROM pais";
                    break;

                case 7:
                    // Operación: Proyección con subconsulta
                    lblEnunciado.Text = cmbConsulta.Text + ": Autores y cantidad de libros";
                    VarSQL = @"
                        SELECT autor.nombre, 
                               (SELECT COUNT(*) 
                                FROM libro 
                                WHERE libro.idautor = autor.idautor) AS cantidad_libros 
                        FROM autor";
                    break;

                case 8:
                    // Operación: Selección con subconsulta
                    lblEnunciado.Text = cmbConsulta.Text + ": Libros en inglés";
                    VarSQL = "SELECT titulo FROM libro WHERE ididioma = (SELECT ididioma FROM idioma WHERE nombre = 'Inglés')";
                    break;

                case 9:
                    // Operación: Proyección con subconsulta y cláusula HAVING
                    lblEnunciado.Text = cmbConsulta.Text + ": Países con más de 10 libros";
                    VarSQL = @"
                        SELECT nombre 
                        FROM pais 
                        WHERE (SELECT COUNT(*) 
                               FROM libro 
                               WHERE libro.idpais = pais.idpais) > 10";
                    break;

                case 10:
                    // Operación: Selección con subconsulta
                    lblEnunciado.Text = cmbConsulta.Text + ": Autores sin libros";
                    VarSQL = "SELECT nombre FROM autor WHERE idautor NOT IN (SELECT idautor FROM libro)";
                    break;

                case 11:
                    // Operación: Proyección con subconsulta
                    lblEnunciado.Text = cmbConsulta.Text + ": Libros por año";
                    VarSQL = @"
                        SELECT DISTINCT año, 
                               (SELECT COUNT(*) 
                                FROM libro AS L 
                                WHERE L.año = libro.año) AS cantidad_libros 
                        FROM libro";
                    break;

                case 12:
                    // Operación: Proyección
                    lblEnunciado.Text = cmbConsulta.Text + ": Libros y sus precios";
                    VarSQL = "SELECT titulo, cantidadmprecio FROM libro";
                    break;

                case 13:
                    // Operación: Proyección con subconsulta
                    lblEnunciado.Text = cmbConsulta.Text + ": Autores y sus idiomas de publicación";
                    VarSQL = @"
                        SELECT autor.nombre, 
                               (SELECT nombre FROM idioma WHERE idioma.ididioma = libro.ididioma) AS idioma 
                        FROM autor 
                        WHERE idautor IN (SELECT DISTINCT idautor FROM libro)";
                    break;

                case 14:
                    // Operación: Selección
                    lblEnunciado.Text = cmbConsulta.Text + ": Libros publicados en el siglo XXI";
                    VarSQL = "SELECT * FROM libro WHERE año >= 2001 AND año <= 2100";
                    break;

                case 15:
                    // Operación: Proyección con subconsulta
                    lblEnunciado.Text = cmbConsulta.Text + ": Países con autores que tienen libros";
                    VarSQL = "SELECT nombre FROM pais WHERE idpais IN (SELECT DISTINCT idpais FROM autor WHERE idautor IN (SELECT idautor FROM libro))";
                    break;

                case 16:
                    // Operación: Proyección con subconsultas
                    lblEnunciado.Text = cmbConsulta.Text + ": Libros y sus autores y países";
                    VarSQL = @"
                        SELECT titulo, 
                               (SELECT nombre FROM autor WHERE autor.idautor = libro.idautor) AS autor, 
                               (SELECT nombre FROM pais WHERE pais.idpais = libro.idpais) AS pais 
                        FROM libro";
                    break;

                case 17:
                    // Operación: Proyección con subconsulta
                    lblEnunciado.Text = cmbConsulta.Text + ": Libros y sus idiomas y precios";
                    VarSQL = @"
                        SELECT titulo, 
                               (SELECT nombre FROM idioma WHERE idioma.ididioma = libro.ididioma) AS idioma, 
                               cantidadmprecio 
                        FROM libro";
                    break;

                case 18:
                    // Operación: Proyección con subconsulta y selección
                    lblEnunciado.Text = cmbConsulta.Text + ": Países con libros en español";
                    VarSQL = "SELECT nombre FROM pais WHERE idpais IN (SELECT idpais FROM libro WHERE ididioma = (SELECT ididioma FROM idioma WHERE nombre = 'Español'))";
                    break;

                case 19:
                    // Operación: Proyección con subconsulta
                    lblEnunciado.Text = cmbConsulta.Text + ": Libros por autor y año";
                    VarSQL = @"
                    SELECT autor.nombre, libro.año, 
                           (SELECT COUNT(*) 
                            FROM libro AS L 
                            WHERE L.idautor = autor.idautor AND L.año = libro.año) AS cantidad_libros 
                    FROM autor JOIN libro ON autor.idautor = libro.idautor";
                    break;

                case 20:
                    // Operación: Proyección con subconsulta
                    lblEnunciado.Text = cmbConsulta.Text + ": Libros y sus países y años de publicación";
                    VarSQL = @"
                    SELECT titulo, 
                           (SELECT nombre FROM pais WHERE pais.idpais = libro.idpais) AS pais, 
                           año 
                    FROM libro";
                    break;

                default:
                    lblEnunciado.Text = "Selecciona una opcion en la lista desplegable";

                    break;
              

            }
            objBD.Listar(dgvGrillaSql, VarSQL);
        }
    }
}
