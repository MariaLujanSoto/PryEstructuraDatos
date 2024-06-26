﻿using System;
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
    public partial class frmListaSimple : Form
    {
        public frmListaSimple()
        {
            InitializeComponent();
        }

        clsListaSimple Lista = new clsListaSimple();

        private void frmListaSimple_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
                clsNodo ObjNodo = new clsNodo();
                ObjNodo.Codigo = Convert.ToInt32(txtCodigoNuevo.Text);
                ObjNodo.Nombre = txtNombreNuevo.Text;
                ObjNodo.Tramite = txtTramiteNuevo.Text;
                Lista.Agregar(ObjNodo);
                Lista.Recorrer(dgvListaS);
                Lista.Recorrer(lstListaS);
                Lista.Recorrer(cmbEliminar);
                Lista.Recorrer();

                txtCodigoNuevo.Text = "";
                txtTramiteNuevo.Text = "";
                txtNombreNuevo.Text = "";
         
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Lista.Primero != null && cmbEliminar.Text != "")
            {
                Int32 x = Convert.ToInt32(cmbEliminar.Text);
                Lista.Eliminar(x);
                Lista.Recorrer(dgvListaS);
                Lista.Recorrer(lstListaS);
                Lista.Recorrer(cmbEliminar);
                Lista.Recorrer();
                cmbEliminar.Text = "";


            }
            else
            {
                
                if(Lista.Primero == null)
                {
                    MessageBox.Show("La Lista esta vacia");
                    cmbEliminar.Text = "";

                }
                else{
                    if (cmbEliminar.Text == "")
                    {
                        MessageBox.Show("Debe seleccionar un valor");

                    }
                }
            }
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
