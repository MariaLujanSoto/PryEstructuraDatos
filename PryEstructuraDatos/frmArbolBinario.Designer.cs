namespace PryEstructuraDatos
{
    partial class frmArbolBinario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gpNuevoElemento = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtTramiteNuevo = new System.Windows.Forms.TextBox();
            this.txtNombreNuevo = new System.Windows.Forms.TextBox();
            this.txtCodigoNuevo = new System.Windows.Forms.TextBox();
            this.lblTramiteNuevo = new System.Windows.Forms.Label();
            this.lblNombreNuevo = new System.Windows.Forms.Label();
            this.lblCodigoNuevo = new System.Windows.Forms.Label();
            this.gpElementoEliminado = new System.Windows.Forms.GroupBox();
            this.cmbAB = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblCodigoElimiado = new System.Windows.Forms.Label();
            this.gpListado = new System.Windows.Forms.GroupBox();
            this.btnPostOrden = new System.Windows.Forms.RadioButton();
            this.btnPreOrden = new System.Windows.Forms.RadioButton();
            this.lstArbolBinario = new System.Windows.Forms.ListBox();
            this.btnIODesc = new System.Windows.Forms.RadioButton();
            this.optIOAsc = new System.Windows.Forms.RadioButton();
            this.dgvArbolBinario = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEquilibrar = new System.Windows.Forms.Button();
            this.trvArbolBinario = new System.Windows.Forms.TreeView();
            this.gpNuevoElemento.SuspendLayout();
            this.gpElementoEliminado.SuspendLayout();
            this.gpListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArbolBinario)).BeginInit();
            this.SuspendLayout();
            // 
            // gpNuevoElemento
            // 
            this.gpNuevoElemento.Controls.Add(this.btnAgregar);
            this.gpNuevoElemento.Controls.Add(this.txtTramiteNuevo);
            this.gpNuevoElemento.Controls.Add(this.txtNombreNuevo);
            this.gpNuevoElemento.Controls.Add(this.txtCodigoNuevo);
            this.gpNuevoElemento.Controls.Add(this.lblTramiteNuevo);
            this.gpNuevoElemento.Controls.Add(this.lblNombreNuevo);
            this.gpNuevoElemento.Controls.Add(this.lblCodigoNuevo);
            this.gpNuevoElemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpNuevoElemento.Location = new System.Drawing.Point(338, 22);
            this.gpNuevoElemento.Name = "gpNuevoElemento";
            this.gpNuevoElemento.Size = new System.Drawing.Size(192, 196);
            this.gpNuevoElemento.TabIndex = 10;
            this.gpNuevoElemento.TabStop = false;
            this.gpNuevoElemento.Text = "Nuevo Elemento";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Enabled = false;
            this.btnAgregar.Location = new System.Drawing.Point(19, 153);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(154, 32);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtTramiteNuevo
            // 
            this.txtTramiteNuevo.Location = new System.Drawing.Point(86, 113);
            this.txtTramiteNuevo.Name = "txtTramiteNuevo";
            this.txtTramiteNuevo.Size = new System.Drawing.Size(100, 22);
            this.txtTramiteNuevo.TabIndex = 5;
            this.txtTramiteNuevo.TextChanged += new System.EventHandler(this.txtTramiteNuevo_TextChanged);
            // 
            // txtNombreNuevo
            // 
            this.txtNombreNuevo.Location = new System.Drawing.Point(86, 75);
            this.txtNombreNuevo.Name = "txtNombreNuevo";
            this.txtNombreNuevo.Size = new System.Drawing.Size(100, 22);
            this.txtNombreNuevo.TabIndex = 4;
            this.txtNombreNuevo.TextChanged += new System.EventHandler(this.txtNombreNuevo_TextChanged);
            // 
            // txtCodigoNuevo
            // 
            this.txtCodigoNuevo.Location = new System.Drawing.Point(106, 41);
            this.txtCodigoNuevo.Name = "txtCodigoNuevo";
            this.txtCodigoNuevo.Size = new System.Drawing.Size(80, 22);
            this.txtCodigoNuevo.TabIndex = 3;
            this.txtCodigoNuevo.TextChanged += new System.EventHandler(this.txtCodigoNuevo_TextChanged);
            // 
            // lblTramiteNuevo
            // 
            this.lblTramiteNuevo.AutoSize = true;
            this.lblTramiteNuevo.Location = new System.Drawing.Point(16, 119);
            this.lblTramiteNuevo.Name = "lblTramiteNuevo";
            this.lblTramiteNuevo.Size = new System.Drawing.Size(56, 16);
            this.lblTramiteNuevo.TabIndex = 2;
            this.lblTramiteNuevo.Text = "Tràmite:";
            // 
            // lblNombreNuevo
            // 
            this.lblNombreNuevo.AutoSize = true;
            this.lblNombreNuevo.Location = new System.Drawing.Point(13, 81);
            this.lblNombreNuevo.Name = "lblNombreNuevo";
            this.lblNombreNuevo.Size = new System.Drawing.Size(59, 16);
            this.lblNombreNuevo.TabIndex = 1;
            this.lblNombreNuevo.Text = "Nombre:";
            // 
            // lblCodigoNuevo
            // 
            this.lblCodigoNuevo.AutoSize = true;
            this.lblCodigoNuevo.Location = new System.Drawing.Point(13, 47);
            this.lblCodigoNuevo.Name = "lblCodigoNuevo";
            this.lblCodigoNuevo.Size = new System.Drawing.Size(54, 16);
            this.lblCodigoNuevo.TabIndex = 0;
            this.lblCodigoNuevo.Text = "Còdigo:";
            // 
            // gpElementoEliminado
            // 
            this.gpElementoEliminado.Controls.Add(this.cmbAB);
            this.gpElementoEliminado.Controls.Add(this.btnEliminar);
            this.gpElementoEliminado.Controls.Add(this.lblCodigoElimiado);
            this.gpElementoEliminado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpElementoEliminado.Location = new System.Drawing.Point(564, 22);
            this.gpElementoEliminado.Name = "gpElementoEliminado";
            this.gpElementoEliminado.Size = new System.Drawing.Size(205, 147);
            this.gpElementoEliminado.TabIndex = 11;
            this.gpElementoEliminado.TabStop = false;
            this.gpElementoEliminado.Text = "Elemento Eliminado";
            // 
            // cmbAB
            // 
            this.cmbAB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbAB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAB.FormattingEnabled = true;
            this.cmbAB.Location = new System.Drawing.Point(83, 41);
            this.cmbAB.Name = "cmbAB";
            this.cmbAB.Size = new System.Drawing.Size(103, 24);
            this.cmbAB.TabIndex = 11;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(16, 101);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(170, 34);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblCodigoElimiado
            // 
            this.lblCodigoElimiado.AutoSize = true;
            this.lblCodigoElimiado.Location = new System.Drawing.Point(23, 47);
            this.lblCodigoElimiado.Name = "lblCodigoElimiado";
            this.lblCodigoElimiado.Size = new System.Drawing.Size(54, 16);
            this.lblCodigoElimiado.TabIndex = 6;
            this.lblCodigoElimiado.Text = "Còdigo:";
            // 
            // gpListado
            // 
            this.gpListado.Controls.Add(this.btnPostOrden);
            this.gpListado.Controls.Add(this.btnPreOrden);
            this.gpListado.Controls.Add(this.lstArbolBinario);
            this.gpListado.Controls.Add(this.btnIODesc);
            this.gpListado.Controls.Add(this.optIOAsc);
            this.gpListado.Controls.Add(this.dgvArbolBinario);
            this.gpListado.Location = new System.Drawing.Point(44, 229);
            this.gpListado.Name = "gpListado";
            this.gpListado.Size = new System.Drawing.Size(791, 230);
            this.gpListado.TabIndex = 12;
            this.gpListado.TabStop = false;
            this.gpListado.Text = "Listado en una Lista y una Grilla";
            // 
            // btnPostOrden
            // 
            this.btnPostOrden.AutoSize = true;
            this.btnPostOrden.Location = new System.Drawing.Point(50, 159);
            this.btnPostOrden.Name = "btnPostOrden";
            this.btnPostOrden.Size = new System.Drawing.Size(78, 17);
            this.btnPostOrden.TabIndex = 5;
            this.btnPostOrden.TabStop = true;
            this.btnPostOrden.Text = "Post-Orden";
            this.btnPostOrden.UseVisualStyleBackColor = true;
            this.btnPostOrden.CheckedChanged += new System.EventHandler(this.btnPostOrden_CheckedChanged);
            // 
            // btnPreOrden
            // 
            this.btnPreOrden.AutoSize = true;
            this.btnPreOrden.Location = new System.Drawing.Point(50, 121);
            this.btnPreOrden.Name = "btnPreOrden";
            this.btnPreOrden.Size = new System.Drawing.Size(73, 17);
            this.btnPreOrden.TabIndex = 4;
            this.btnPreOrden.TabStop = true;
            this.btnPreOrden.Text = "Pre-Orden";
            this.btnPreOrden.UseVisualStyleBackColor = true;
            this.btnPreOrden.CheckedChanged += new System.EventHandler(this.btnPreOrden_CheckedChanged);
            // 
            // lstArbolBinario
            // 
            this.lstArbolBinario.FormattingEnabled = true;
            this.lstArbolBinario.Location = new System.Drawing.Point(730, 34);
            this.lstArbolBinario.Name = "lstArbolBinario";
            this.lstArbolBinario.Size = new System.Drawing.Size(46, 173);
            this.lstArbolBinario.TabIndex = 13;
            // 
            // btnIODesc
            // 
            this.btnIODesc.AutoSize = true;
            this.btnIODesc.Location = new System.Drawing.Point(50, 84);
            this.btnIODesc.Name = "btnIODesc";
            this.btnIODesc.Size = new System.Drawing.Size(127, 17);
            this.btnIODesc.TabIndex = 3;
            this.btnIODesc.TabStop = true;
            this.btnIODesc.Text = "In-Orden Descedente";
            this.btnIODesc.UseVisualStyleBackColor = true;
            this.btnIODesc.CheckedChanged += new System.EventHandler(this.btnIODesc_CheckedChanged);
            // 
            // optIOAsc
            // 
            this.optIOAsc.AutoSize = true;
            this.optIOAsc.Location = new System.Drawing.Point(50, 47);
            this.optIOAsc.Name = "optIOAsc";
            this.optIOAsc.Size = new System.Drawing.Size(126, 17);
            this.optIOAsc.TabIndex = 2;
            this.optIOAsc.TabStop = true;
            this.optIOAsc.Text = "In-Orden Ascendente";
            this.optIOAsc.UseVisualStyleBackColor = true;
            this.optIOAsc.CheckedChanged += new System.EventHandler(this.optIOAsc_CheckedChanged);
            // 
            // dgvArbolBinario
            // 
            this.dgvArbolBinario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArbolBinario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvArbolBinario.Location = new System.Drawing.Point(231, 34);
            this.dgvArbolBinario.Name = "dgvArbolBinario";
            this.dgvArbolBinario.ReadOnly = true;
            this.dgvArbolBinario.Size = new System.Drawing.Size(478, 169);
            this.dgvArbolBinario.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Còdigo";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tràmite";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // btnEquilibrar
            // 
            this.btnEquilibrar.Location = new System.Drawing.Point(564, 175);
            this.btnEquilibrar.Name = "btnEquilibrar";
            this.btnEquilibrar.Size = new System.Drawing.Size(205, 43);
            this.btnEquilibrar.TabIndex = 12;
            this.btnEquilibrar.Text = "EQUILIBRAR";
            this.btnEquilibrar.UseVisualStyleBackColor = true;
            this.btnEquilibrar.Click += new System.EventHandler(this.btnEquilibrar_Click);
            // 
            // trvArbolBinario
            // 
            this.trvArbolBinario.Location = new System.Drawing.Point(85, 22);
            this.trvArbolBinario.Name = "trvArbolBinario";
            this.trvArbolBinario.Size = new System.Drawing.Size(201, 196);
            this.trvArbolBinario.TabIndex = 14;
            // 
            // frmArbolBinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PryEstructuraDatos.Properties.Resources.ImgFondo;
            this.ClientSize = new System.Drawing.Size(873, 488);
            this.Controls.Add(this.trvArbolBinario);
            this.Controls.Add(this.btnEquilibrar);
            this.Controls.Add(this.gpListado);
            this.Controls.Add(this.gpElementoEliminado);
            this.Controls.Add(this.gpNuevoElemento);
            this.Name = "frmArbolBinario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arbol Binario";
            this.gpNuevoElemento.ResumeLayout(false);
            this.gpNuevoElemento.PerformLayout();
            this.gpElementoEliminado.ResumeLayout(false);
            this.gpElementoEliminado.PerformLayout();
            this.gpListado.ResumeLayout(false);
            this.gpListado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArbolBinario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpNuevoElemento;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtTramiteNuevo;
        private System.Windows.Forms.TextBox txtNombreNuevo;
        private System.Windows.Forms.TextBox txtCodigoNuevo;
        private System.Windows.Forms.Label lblTramiteNuevo;
        private System.Windows.Forms.Label lblNombreNuevo;
        private System.Windows.Forms.Label lblCodigoNuevo;
        private System.Windows.Forms.GroupBox gpElementoEliminado;
        private System.Windows.Forms.ComboBox cmbAB;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblCodigoElimiado;
        private System.Windows.Forms.GroupBox gpListado;
        private System.Windows.Forms.DataGridView dgvArbolBinario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button btnEquilibrar;
        private System.Windows.Forms.RadioButton btnPostOrden;
        private System.Windows.Forms.RadioButton btnPreOrden;
        private System.Windows.Forms.RadioButton btnIODesc;
        private System.Windows.Forms.RadioButton optIOAsc;
        private System.Windows.Forms.ListBox lstArbolBinario;
        private System.Windows.Forms.TreeView trvArbolBinario;
    }
}