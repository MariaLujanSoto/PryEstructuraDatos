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
    public partial class frmBaseDatosOperaciones : Form
    {
        public frmBaseDatosOperaciones()
        {
            InitializeComponent();
        }

        

        clsBaseDatos objBaseDatos = new clsBaseDatos();

        private void btnProyeccionS_Click(object sender, EventArgs e)
        {
            //FILTRO COLUMNA
            String varSQL = "SELECT TITULO " +
                "FROM LIBRO " +
                "ORDER BY 1 DESC ";
                objBaseDatos.Listar(dtvGrillaBD, varSQL);
        }

        private void btnProyeccionM_Click(object sender, EventArgs e)
        {
            //UNO DOS COLUMNAS
            String varSQL = "SELECT TITULO, AÑO " +
                "FROM LIBRO " +
                "ORDER BY TITULO DESC";
                objBaseDatos.Listar(dtvGrillaBD, varSQL);
        }

        private void btnJuntar_Click(object sender, EventArgs e)
        {
            //UNO DOS TABLAS
            String varSQL = "SELECT * " +
               "FROM LIBRO, IDIOMA " +
               "WHERE Libro.IdIdioma = Idioma.IdIdioma";
                objBaseDatos.Listar(dtvGrillaBD, varSQL);

        }


        private void btnSeleccionS_Click_1(object sender, EventArgs e)
        {
            //FILTRO POR UN ATRIBUTO
            String varSQL = "SELECT TITULO, CANTIDAD, AÑO " +
               "FROM LIBRO " +
               "WHERE CANTIDAD > 5 ";
                objBaseDatos.Listar(dtvGrillaBD, varSQL);
        }

        private void btnSeleccionM_Click(object sender, EventArgs e)
        {
            //FILTRO POR DOS ATRIBUTOS
            String varSQL = "SELECT TITULO, CANTIDAD, AÑO, PRECIO " +
              "FROM LIBRO " +
              "WHERE CANTIDAD>2 AND PRECIO>100";
                objBaseDatos.Listar(dtvGrillaBD, varSQL);
        }

        private void btnSeleccionPC_Click(object sender, EventArgs e)
        {
            String varSQL = "SELECT * " +
              "FROM (SELECT * FROM LIBRO as T1 WHERE T1.CANTIDAD < 10) as T2 " +
              "WHERE T2.IdPais = 1";
                objBaseDatos.Listar(dtvGrillaBD, varSQL);

            //SELECT * FROM (SELECT * FROM Libro as T1 WHERE T1.IdIdioma > 5) as T2 WHERE T2.IdAutor > 10

        }

        private void btnUnion_Click(object sender, EventArgs e)
        {
            //SELECT* FROM Libro WHERE IdAutor = 2
            //UNION
            //SELECT* FROM Libro WHERE IdAutor = 5
            //UNION
            //SELECT* FROM Libro WHERE IdAutor = 3
        }

        private void btnInterseccion_Click(object sender, EventArgs e)
        {
            String varSQL = "SELECT * " +
              "FROM AUTOR " +
              "WHERE IdAutor IN (SELECT IdAutor FROM LIBRO)";
                objBaseDatos.Listar(dtvGrillaBD, varSQL);

        }

        private void btnDiferencia_Click(object sender, EventArgs e)
        {
            String varSQL = "SELECT * " +
              "FROM IDIOMA " +
              "WHERE IdIdioma NOT (SELECT IdIdioma FROM LIBRO)";
                objBaseDatos.Listar(dtvGrillaBD, varSQL);
        }
    }
}
