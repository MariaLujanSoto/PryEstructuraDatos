namespace PryEstructuraDatos
{
    partial class frmListaSimple
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
            this.gpListado = new System.Windows.Forms.GroupBox();
            this.dgvListaS = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lstListaS = new System.Windows.Forms.ListBox();
            this.gpElementoEliminado = new System.Windows.Forms.GroupBox();
            this.cmbEliminar = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblCodigoElimiado = new System.Windows.Forms.Label();
            this.gpNuevoElemento = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtTramiteNuevo = new System.Windows.Forms.TextBox();
            this.txtNombreNuevo = new System.Windows.Forms.TextBox();
            this.txtCodigoNuevo = new System.Windows.Forms.TextBox();
            this.lblTramiteNuevo = new System.Windows.Forms.Label();
            this.lblNombreNuevo = new System.Windows.Forms.Label();
            this.lblCodigoNuevo = new System.Windows.Forms.Label();
            this.pctListaS = new System.Windows.Forms.PictureBox();
            this.gpListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaS)).BeginInit();
            this.gpElementoEliminado.SuspendLayout();
            this.gpNuevoElemento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctListaS)).BeginInit();
            this.SuspendLayout();
            // 
            // gpListado
            // 
            this.gpListado.Controls.Add(this.dgvListaS);
            this.gpListado.Controls.Add(this.lstListaS);
            this.gpListado.Location = new System.Drawing.Point(40, 242);
            this.gpListado.Name = "gpListado";
            this.gpListado.Size = new System.Drawing.Size(695, 230);
            this.gpListado.TabIndex = 7;
            this.gpListado.TabStop = false;
            this.gpListado.Text = "Listado en una Lista y una Grilla";
            // 
            // dgvListaS
            // 
            this.dgvListaS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvListaS.Location = new System.Drawing.Point(222, 38);
            this.dgvListaS.Name = "dgvListaS";
            this.dgvListaS.ReadOnly = true;
            this.dgvListaS.Size = new System.Drawing.Size(440, 169);
            this.dgvListaS.TabIndex = 1;
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
            // lstListaS
            // 
            this.lstListaS.FormattingEnabled = true;
            this.lstListaS.Location = new System.Drawing.Point(19, 34);
            this.lstListaS.Name = "lstListaS";
            this.lstListaS.Size = new System.Drawing.Size(186, 173);
            this.lstListaS.TabIndex = 0;
            // 
            // gpElementoEliminado
            // 
            this.gpElementoEliminado.Controls.Add(this.cmbEliminar);
            this.gpElementoEliminado.Controls.Add(this.btnEliminar);
            this.gpElementoEliminado.Controls.Add(this.lblCodigoElimiado);
            this.gpElementoEliminado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpElementoEliminado.Location = new System.Drawing.Point(530, 12);
            this.gpElementoEliminado.Name = "gpElementoEliminado";
            this.gpElementoEliminado.Size = new System.Drawing.Size(205, 135);
            this.gpElementoEliminado.TabIndex = 6;
            this.gpElementoEliminado.TabStop = false;
            this.gpElementoEliminado.Text = "Elemento Eliminado";
            // 
            // cmbEliminar
            // 
            this.cmbEliminar.FormattingEnabled = true;
            this.cmbEliminar.Location = new System.Drawing.Point(83, 41);
            this.cmbEliminar.Name = "cmbEliminar";
            this.cmbEliminar.Size = new System.Drawing.Size(103, 24);
            this.cmbEliminar.TabIndex = 11;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(26, 79);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(160, 32);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblCodigoElimiado
            // 
            this.lblCodigoElimiado.AutoSize = true;
            this.lblCodigoElimiado.Location = new System.Drawing.Point(23, 44);
            this.lblCodigoElimiado.Name = "lblCodigoElimiado";
            this.lblCodigoElimiado.Size = new System.Drawing.Size(54, 16);
            this.lblCodigoElimiado.TabIndex = 6;
            this.lblCodigoElimiado.Text = "Còdigo:";
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
            this.gpNuevoElemento.Location = new System.Drawing.Point(300, 12);
            this.gpNuevoElemento.Name = "gpNuevoElemento";
            this.gpNuevoElemento.Size = new System.Drawing.Size(192, 211);
            this.gpNuevoElemento.TabIndex = 5;
            this.gpNuevoElemento.TabStop = false;
            this.gpNuevoElemento.Text = "Nuevo Elemento";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(23, 164);
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
            // 
            // txtNombreNuevo
            // 
            this.txtNombreNuevo.Location = new System.Drawing.Point(86, 75);
            this.txtNombreNuevo.Name = "txtNombreNuevo";
            this.txtNombreNuevo.Size = new System.Drawing.Size(100, 22);
            this.txtNombreNuevo.TabIndex = 4;
            // 
            // txtCodigoNuevo
            // 
            this.txtCodigoNuevo.Location = new System.Drawing.Point(106, 41);
            this.txtCodigoNuevo.Name = "txtCodigoNuevo";
            this.txtCodigoNuevo.Size = new System.Drawing.Size(80, 22);
            this.txtCodigoNuevo.TabIndex = 3;
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
            // pctListaS
            // 
            this.pctListaS.Image = global::PryEstructuraDatos.Properties.Resources.ImgLista;
            this.pctListaS.Location = new System.Drawing.Point(40, 25);
            this.pctListaS.Name = "pctListaS";
            this.pctListaS.Size = new System.Drawing.Size(232, 198);
            this.pctListaS.TabIndex = 8;
            this.pctListaS.TabStop = false;
            // 
            // frmListaSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PryEstructuraDatos.Properties.Resources.ImgFondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(812, 500);
            this.Controls.Add(this.pctListaS);
            this.Controls.Add(this.gpListado);
            this.Controls.Add(this.gpElementoEliminado);
            this.Controls.Add(this.gpNuevoElemento);
            this.Name = "frmListaSimple";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estructuras Lineales: Lista Simple";
            this.Load += new System.EventHandler(this.frmListaSimple_Load);
            this.gpListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaS)).EndInit();
            this.gpElementoEliminado.ResumeLayout(false);
            this.gpElementoEliminado.PerformLayout();
            this.gpNuevoElemento.ResumeLayout(false);
            this.gpNuevoElemento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctListaS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpListado;
        private System.Windows.Forms.DataGridView dgvListaS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.ListBox lstListaS;
        private System.Windows.Forms.GroupBox gpElementoEliminado;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblCodigoElimiado;
        private System.Windows.Forms.GroupBox gpNuevoElemento;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtTramiteNuevo;
        private System.Windows.Forms.TextBox txtNombreNuevo;
        private System.Windows.Forms.TextBox txtCodigoNuevo;
        private System.Windows.Forms.Label lblTramiteNuevo;
        private System.Windows.Forms.Label lblNombreNuevo;
        private System.Windows.Forms.Label lblCodigoNuevo;
        private System.Windows.Forms.ComboBox cmbEliminar;
        private System.Windows.Forms.PictureBox pctListaS;
    }
}