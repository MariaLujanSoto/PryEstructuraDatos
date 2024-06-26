namespace PryEstructuraDatos
{
    partial class frmRepasoOperacionesBaseDatos
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
            this.dgvGrillaSql = new System.Windows.Forms.DataGridView();
            this.btnListar = new System.Windows.Forms.Button();
            this.lblEnunciado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbConsulta = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrillaSql)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGrillaSql
            // 
            this.dgvGrillaSql.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrillaSql.Location = new System.Drawing.Point(52, 175);
            this.dgvGrillaSql.Name = "dgvGrillaSql";
            this.dgvGrillaSql.Size = new System.Drawing.Size(700, 238);
            this.dgvGrillaSql.TabIndex = 4;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(680, 29);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(106, 23);
            this.btnListar.TabIndex = 3;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // lblEnunciado
            // 
            this.lblEnunciado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEnunciado.Location = new System.Drawing.Point(52, 74);
            this.lblEnunciado.Name = "lblEnunciado";
            this.lblEnunciado.Size = new System.Drawing.Size(700, 85);
            this.lblEnunciado.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-3, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Operación a Realizar en la base de datos:";
            // 
            // cmbConsulta
            // 
            this.cmbConsulta.FormattingEnabled = true;
            this.cmbConsulta.Items.AddRange(new object[] {
            "Diferencia",
            "Intersección",
            "Unión ",
            "Selección Simple",
            "Selección por multiatributo por Intersección",
            "Selección por multiatributo por Convolución",
            "Orden",
            "Proyección por un atributo",
            "Proyección por multiatributo",
            "Juntar",
            "Diferencia",
            "Intersección",
            "Unión",
            "Selección Simple",
            "Selección por multiatributo por Intersección",
            "Selección por multiatributo por Convolución",
            "Orden",
            "Proyección por un atributo",
            "Proyección por multiatributo",
            "Juntar"});
            this.cmbConsulta.Location = new System.Drawing.Point(249, 31);
            this.cmbConsulta.Name = "cmbConsulta";
            this.cmbConsulta.Size = new System.Drawing.Size(425, 21);
            this.cmbConsulta.TabIndex = 9;
            // 
            // frmRepasoOperacionesBaseDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PryEstructuraDatos.Properties.Resources.ImgFondo;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbConsulta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEnunciado);
            this.Controls.Add(this.dgvGrillaSql);
            this.Controls.Add(this.btnListar);
            this.Name = "frmRepasoOperacionesBaseDatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Repaso de Operaciones de Baso de Datos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrillaSql)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvGrillaSql;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Label lblEnunciado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbConsulta;
    }
}