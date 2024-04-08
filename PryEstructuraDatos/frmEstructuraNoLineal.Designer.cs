namespace PryEstructuraDatos
{
    partial class frmCola
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
            this.pctCola = new System.Windows.Forms.PictureBox();
            this.gpNuevoElemento = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtTramiteNuevo = new System.Windows.Forms.TextBox();
            this.txtNombreNuevo = new System.Windows.Forms.TextBox();
            this.txtCodigoNuevo = new System.Windows.Forms.TextBox();
            this.lblTramiteNuevo = new System.Windows.Forms.Label();
            this.lblNombreNuevo = new System.Windows.Forms.Label();
            this.lblCodigoNuevo = new System.Windows.Forms.Label();
            this.gpElementoEliminado = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblTramiteEliminado = new System.Windows.Forms.Label();
            this.lblNombreEliminado = new System.Windows.Forms.Label();
            this.lblCodigoEliminado = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCodigoElimiado = new System.Windows.Forms.Label();
            this.gpListado = new System.Windows.Forms.GroupBox();
            this.dgvCola = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lstCola = new System.Windows.Forms.ListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pctCola)).BeginInit();
            this.gpNuevoElemento.SuspendLayout();
            this.gpElementoEliminado.SuspendLayout();
            this.gpListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCola)).BeginInit();
            this.SuspendLayout();
            // 
            // pctCola
            // 
            this.pctCola.Image = global::PryEstructuraDatos.Properties.Resources.cola;
            this.pctCola.Location = new System.Drawing.Point(27, 12);
            this.pctCola.Name = "pctCola";
            this.pctCola.Size = new System.Drawing.Size(190, 211);
            this.pctCola.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctCola.TabIndex = 0;
            this.pctCola.TabStop = false;
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
            this.gpNuevoElemento.Location = new System.Drawing.Point(258, 12);
            this.gpNuevoElemento.Name = "gpNuevoElemento";
            this.gpNuevoElemento.Size = new System.Drawing.Size(192, 211);
            this.gpNuevoElemento.TabIndex = 1;
            this.gpNuevoElemento.TabStop = false;
            this.gpNuevoElemento.Text = "Nuevo Elemento";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(23, 164);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(147, 32);
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
            this.lblTramiteNuevo.Size = new System.Drawing.Size(57, 16);
            this.lblTramiteNuevo.TabIndex = 2;
            this.lblTramiteNuevo.Text = "Tràmite:";
            // 
            // lblNombreNuevo
            // 
            this.lblNombreNuevo.AutoSize = true;
            this.lblNombreNuevo.Location = new System.Drawing.Point(13, 81);
            this.lblNombreNuevo.Name = "lblNombreNuevo";
            this.lblNombreNuevo.Size = new System.Drawing.Size(60, 16);
            this.lblNombreNuevo.TabIndex = 1;
            this.lblNombreNuevo.Text = "Nombre:";
            // 
            // lblCodigoNuevo
            // 
            this.lblCodigoNuevo.AutoSize = true;
            this.lblCodigoNuevo.Location = new System.Drawing.Point(13, 47);
            this.lblCodigoNuevo.Name = "lblCodigoNuevo";
            this.lblCodigoNuevo.Size = new System.Drawing.Size(55, 16);
            this.lblCodigoNuevo.TabIndex = 0;
            this.lblCodigoNuevo.Text = "Còdigo:";
            // 
            // gpElementoEliminado
            // 
            this.gpElementoEliminado.Controls.Add(this.btnEliminar);
            this.gpElementoEliminado.Controls.Add(this.lblTramiteEliminado);
            this.gpElementoEliminado.Controls.Add(this.lblNombreEliminado);
            this.gpElementoEliminado.Controls.Add(this.lblCodigoEliminado);
            this.gpElementoEliminado.Controls.Add(this.label6);
            this.gpElementoEliminado.Controls.Add(this.label5);
            this.gpElementoEliminado.Controls.Add(this.lblCodigoElimiado);
            this.gpElementoEliminado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpElementoEliminado.Location = new System.Drawing.Point(488, 12);
            this.gpElementoEliminado.Name = "gpElementoEliminado";
            this.gpElementoEliminado.Size = new System.Drawing.Size(205, 211);
            this.gpElementoEliminado.TabIndex = 2;
            this.gpElementoEliminado.TabStop = false;
            this.gpElementoEliminado.Text = "Elemento Eliminado";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(26, 164);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(146, 32);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblTramiteEliminado
            // 
            this.lblTramiteEliminado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTramiteEliminado.Location = new System.Drawing.Point(104, 118);
            this.lblTramiteEliminado.Name = "lblTramiteEliminado";
            this.lblTramiteEliminado.Size = new System.Drawing.Size(95, 22);
            this.lblTramiteEliminado.TabIndex = 9;
            // 
            // lblNombreEliminado
            // 
            this.lblNombreEliminado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNombreEliminado.Location = new System.Drawing.Point(104, 80);
            this.lblNombreEliminado.Name = "lblNombreEliminado";
            this.lblNombreEliminado.Size = new System.Drawing.Size(95, 22);
            this.lblNombreEliminado.TabIndex = 8;
            // 
            // lblCodigoEliminado
            // 
            this.lblCodigoEliminado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCodigoEliminado.Location = new System.Drawing.Point(121, 41);
            this.lblCodigoEliminado.Name = "lblCodigoEliminado";
            this.lblCodigoEliminado.Size = new System.Drawing.Size(78, 22);
            this.lblCodigoEliminado.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tràmite:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Nombre:";
            // 
            // lblCodigoElimiado
            // 
            this.lblCodigoElimiado.AutoSize = true;
            this.lblCodigoElimiado.Location = new System.Drawing.Point(23, 47);
            this.lblCodigoElimiado.Name = "lblCodigoElimiado";
            this.lblCodigoElimiado.Size = new System.Drawing.Size(55, 16);
            this.lblCodigoElimiado.TabIndex = 6;
            this.lblCodigoElimiado.Text = "Còdigo:";
            // 
            // gpListado
            // 
            this.gpListado.Controls.Add(this.dgvCola);
            this.gpListado.Controls.Add(this.lstCola);
            this.gpListado.Location = new System.Drawing.Point(27, 242);
            this.gpListado.Name = "gpListado";
            this.gpListado.Size = new System.Drawing.Size(666, 230);
            this.gpListado.TabIndex = 3;
            this.gpListado.TabStop = false;
            this.gpListado.Text = "Listado en una Lista y una Grilla";
            // 
            // dgvCola
            // 
            this.dgvCola.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCola.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvCola.Location = new System.Drawing.Point(222, 38);
            this.dgvCola.Name = "dgvCola";
            this.dgvCola.ReadOnly = true;
            this.dgvCola.Size = new System.Drawing.Size(425, 169);
            this.dgvCola.TabIndex = 1;
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
            // lstCola
            // 
            this.lstCola.FormattingEnabled = true;
            this.lstCola.Location = new System.Drawing.Point(19, 34);
            this.lstCola.Name = "lstCola";
            this.lstCola.Size = new System.Drawing.Size(186, 173);
            this.lstCola.TabIndex = 0;
            // 
            // frmCola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 484);
            this.Controls.Add(this.gpListado);
            this.Controls.Add(this.gpElementoEliminado);
            this.Controls.Add(this.gpNuevoElemento);
            this.Controls.Add(this.pctCola);
            this.Name = "frmCola";
            this.Text = "Estructura Dinàmica no Lineal - Cola";
            this.Load += new System.EventHandler(this.frmEstructuraNoLineal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctCola)).EndInit();
            this.gpNuevoElemento.ResumeLayout(false);
            this.gpNuevoElemento.PerformLayout();
            this.gpElementoEliminado.ResumeLayout(false);
            this.gpElementoEliminado.PerformLayout();
            this.gpListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCola)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pctCola;
        private System.Windows.Forms.GroupBox gpNuevoElemento;
        private System.Windows.Forms.TextBox txtTramiteNuevo;
        private System.Windows.Forms.TextBox txtNombreNuevo;
        private System.Windows.Forms.TextBox txtCodigoNuevo;
        private System.Windows.Forms.Label lblTramiteNuevo;
        private System.Windows.Forms.Label lblNombreNuevo;
        private System.Windows.Forms.Label lblCodigoNuevo;
        private System.Windows.Forms.GroupBox gpElementoEliminado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCodigoElimiado;
        private System.Windows.Forms.GroupBox gpListado;
        private System.Windows.Forms.DataGridView dgvCola;
        private System.Windows.Forms.ListBox lstCola;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblTramiteEliminado;
        private System.Windows.Forms.Label lblNombreEliminado;
        private System.Windows.Forms.Label lblCodigoEliminado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}