namespace PryEstructuraDatos
{
    partial class frmBaseDatosConsultaOperaciones
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
            this.btnListar = new System.Windows.Forms.Button();
            this.dtvGrillaSql = new System.Windows.Forms.DataGridView();
            this.txtSql = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtvGrillaSql)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(635, 146);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 0;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // dtvGrillaSql
            // 
            this.dtvGrillaSql.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvGrillaSql.Location = new System.Drawing.Point(21, 175);
            this.dtvGrillaSql.Name = "dtvGrillaSql";
            this.dtvGrillaSql.Size = new System.Drawing.Size(700, 251);
            this.dtvGrillaSql.TabIndex = 1;
            // 
            // txtSql
            // 
            this.txtSql.Location = new System.Drawing.Point(30, 21);
            this.txtSql.Multiline = true;
            this.txtSql.Name = "txtSql";
            this.txtSql.Size = new System.Drawing.Size(680, 119);
            this.txtSql.TabIndex = 2;
            // 
            // frmBaseDatosConsultaOperaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PryEstructuraDatos.Properties.Resources.ImgFondo;
            this.ClientSize = new System.Drawing.Size(746, 453);
            this.Controls.Add(this.txtSql);
            this.Controls.Add(this.dtvGrillaSql);
            this.Controls.Add(this.btnListar);
            this.Name = "frmBaseDatosConsultaOperaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Repaso de Operaciones de Base de Datos";
            ((System.ComponentModel.ISupportInitialize)(this.dtvGrillaSql)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.DataGridView dtvGrillaSql;
        private System.Windows.Forms.TextBox txtSql;
    }
}