﻿namespace PryEstructuraDatos
{
    partial class frmBaseDatosOperaciones
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnProyeccionS = new System.Windows.Forms.Button();
            this.btnProyeccionM = new System.Windows.Forms.Button();
            this.btnJuntar = new System.Windows.Forms.Button();
            this.btnSeleccionPC = new System.Windows.Forms.Button();
            this.btnSeleccionM = new System.Windows.Forms.Button();
            this.btnSeleccionS = new System.Windows.Forms.Button();
            this.btnDiferencia = new System.Windows.Forms.Button();
            this.btnInterseccion = new System.Windows.Forms.Button();
            this.btnUnion = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(882, 253);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnProyeccionS
            // 
            this.btnProyeccionS.Location = new System.Drawing.Point(38, 320);
            this.btnProyeccionS.Name = "btnProyeccionS";
            this.btnProyeccionS.Size = new System.Drawing.Size(263, 36);
            this.btnProyeccionS.TabIndex = 1;
            this.btnProyeccionS.Text = "Proyeccion Simple";
            this.btnProyeccionS.UseVisualStyleBackColor = true;
            // 
            // btnProyeccionM
            // 
            this.btnProyeccionM.Location = new System.Drawing.Point(38, 374);
            this.btnProyeccionM.Name = "btnProyeccionM";
            this.btnProyeccionM.Size = new System.Drawing.Size(263, 36);
            this.btnProyeccionM.TabIndex = 2;
            this.btnProyeccionM.Text = "Proyeccion multiatributo";
            this.btnProyeccionM.UseVisualStyleBackColor = true;
            // 
            // btnJuntar
            // 
            this.btnJuntar.Location = new System.Drawing.Point(38, 431);
            this.btnJuntar.Name = "btnJuntar";
            this.btnJuntar.Size = new System.Drawing.Size(263, 36);
            this.btnJuntar.TabIndex = 3;
            this.btnJuntar.Text = "Juntar";
            this.btnJuntar.UseVisualStyleBackColor = true;
            // 
            // btnSeleccionPC
            // 
            this.btnSeleccionPC.Location = new System.Drawing.Point(15, 131);
            this.btnSeleccionPC.Name = "btnSeleccionPC";
            this.btnSeleccionPC.Size = new System.Drawing.Size(263, 36);
            this.btnSeleccionPC.TabIndex = 6;
            this.btnSeleccionPC.Text = "Seleccion cor convolucion";
            this.btnSeleccionPC.UseVisualStyleBackColor = true;
            // 
            // btnSeleccionM
            // 
            this.btnSeleccionM.Location = new System.Drawing.Point(15, 74);
            this.btnSeleccionM.Name = "btnSeleccionM";
            this.btnSeleccionM.Size = new System.Drawing.Size(263, 36);
            this.btnSeleccionM.TabIndex = 5;
            this.btnSeleccionM.Text = "Seleccion multiatributo";
            this.btnSeleccionM.UseVisualStyleBackColor = true;
            // 
            // btnSeleccionS
            // 
            this.btnSeleccionS.Location = new System.Drawing.Point(15, 20);
            this.btnSeleccionS.Name = "btnSeleccionS";
            this.btnSeleccionS.Size = new System.Drawing.Size(263, 36);
            this.btnSeleccionS.TabIndex = 4;
            this.btnSeleccionS.Text = "Seleccion Simple";
            this.btnSeleccionS.UseVisualStyleBackColor = false;
            this.btnSeleccionS.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnDiferencia
            // 
            this.btnDiferencia.Location = new System.Drawing.Point(18, 131);
            this.btnDiferencia.Name = "btnDiferencia";
            this.btnDiferencia.Size = new System.Drawing.Size(263, 36);
            this.btnDiferencia.TabIndex = 9;
            this.btnDiferencia.Text = "Diferencia";
            this.btnDiferencia.UseVisualStyleBackColor = true;
            // 
            // btnInterseccion
            // 
            this.btnInterseccion.Location = new System.Drawing.Point(18, 74);
            this.btnInterseccion.Name = "btnInterseccion";
            this.btnInterseccion.Size = new System.Drawing.Size(263, 36);
            this.btnInterseccion.TabIndex = 8;
            this.btnInterseccion.Text = "Interseccion";
            this.btnInterseccion.UseVisualStyleBackColor = true;
            // 
            // btnUnion
            // 
            this.btnUnion.Location = new System.Drawing.Point(18, 20);
            this.btnUnion.Name = "btnUnion";
            this.btnUnion.Size = new System.Drawing.Size(263, 36);
            this.btnUnion.TabIndex = 7;
            this.btnUnion.Text = "Union";
            this.btnUnion.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSeleccionPC);
            this.groupBox1.Controls.Add(this.btnSeleccionM);
            this.groupBox1.Controls.Add(this.btnSeleccionS);
            this.groupBox1.Location = new System.Drawing.Point(330, 299);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 177);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operaciones de Seleccion - WHERE";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDiferencia);
            this.groupBox2.Controls.Add(this.btnInterseccion);
            this.groupBox2.Controls.Add(this.btnUnion);
            this.groupBox2.Location = new System.Drawing.Point(642, 300);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(287, 176);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operaciones Algebraicas";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(29, 300);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(281, 177);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Operaciones de Proyeccion - SELECT";
            // 
            // frmBaseDatosOperaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PryEstructuraDatos.Properties.Resources.ImgFondo;
            this.ClientSize = new System.Drawing.Size(941, 500);
            this.Controls.Add(this.btnJuntar);
            this.Controls.Add(this.btnProyeccionM);
            this.Controls.Add(this.btnProyeccionS);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmBaseDatosOperaciones";
            this.Text = "Base de Datos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnProyeccionS;
        private System.Windows.Forms.Button btnProyeccionM;
        private System.Windows.Forms.Button btnJuntar;
        private System.Windows.Forms.Button btnSeleccionPC;
        private System.Windows.Forms.Button btnSeleccionM;
        private System.Windows.Forms.Button btnSeleccionS;
        private System.Windows.Forms.Button btnDiferencia;
        private System.Windows.Forms.Button btnInterseccion;
        private System.Windows.Forms.Button btnUnion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}