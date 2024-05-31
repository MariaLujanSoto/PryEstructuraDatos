namespace PryEstructuraDatos
{
    partial class frmVentanaPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menu = new System.Windows.Forms.MenuStrip();
            this.sistemmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosDelDesarrolladorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.sALIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frmVenatanaPrincipal = new System.Windows.Forms.ToolStripMenuItem();
            this.colaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pilaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.listaSimpleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDobleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estructurasNoLinealesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arbolBinarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baseDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operacionesConTablasDeBasesDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasEnLaBaseDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.repasoDeOperacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemmaToolStripMenuItem,
            this.frmVenatanaPrincipal,
            this.estructurasNoLinealesToolStripMenuItem,
            this.baseDeDatosToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(679, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menu";
            // 
            // sistemmaToolStripMenuItem
            // 
            this.sistemmaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datosDelDesarrolladorToolStripMenuItem,
            this.toolStripMenuItem1,
            this.sALIRToolStripMenuItem});
            this.sistemmaToolStripMenuItem.Name = "sistemmaToolStripMenuItem";
            this.sistemmaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.sistemmaToolStripMenuItem.Text = "Sistema";
            // 
            // datosDelDesarrolladorToolStripMenuItem
            // 
            this.datosDelDesarrolladorToolStripMenuItem.Name = "datosDelDesarrolladorToolStripMenuItem";
            this.datosDelDesarrolladorToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.datosDelDesarrolladorToolStripMenuItem.Text = "Datos del Desarrollador ...";
            this.datosDelDesarrolladorToolStripMenuItem.Click += new System.EventHandler(this.datosDelDesarrolladorToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(205, 6);
            // 
            // sALIRToolStripMenuItem
            // 
            this.sALIRToolStripMenuItem.Name = "sALIRToolStripMenuItem";
            this.sALIRToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.sALIRToolStripMenuItem.Text = "Salir";
            this.sALIRToolStripMenuItem.Click += new System.EventHandler(this.sALIRToolStripMenuItem_Click);
            // 
            // frmVenatanaPrincipal
            // 
            this.frmVenatanaPrincipal.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colaToolStripMenuItem,
            this.pilaToolStripMenuItem,
            this.toolStripMenuItem2,
            this.listaSimpleToolStripMenuItem,
            this.listaDobleToolStripMenuItem});
            this.frmVenatanaPrincipal.Name = "frmVenatanaPrincipal";
            this.frmVenatanaPrincipal.Size = new System.Drawing.Size(122, 20);
            this.frmVenatanaPrincipal.Text = "Estructuras Lineales";
            // 
            // colaToolStripMenuItem
            // 
            this.colaToolStripMenuItem.Name = "colaToolStripMenuItem";
            this.colaToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.colaToolStripMenuItem.Text = "Cola...";
            this.colaToolStripMenuItem.Click += new System.EventHandler(this.colaToolStripMenuItem_Click);
            // 
            // pilaToolStripMenuItem
            // 
            this.pilaToolStripMenuItem.Name = "pilaToolStripMenuItem";
            this.pilaToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.pilaToolStripMenuItem.Text = "Pila...";
            this.pilaToolStripMenuItem.Click += new System.EventHandler(this.pilaToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(143, 6);
            // 
            // listaSimpleToolStripMenuItem
            // 
            this.listaSimpleToolStripMenuItem.Name = "listaSimpleToolStripMenuItem";
            this.listaSimpleToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.listaSimpleToolStripMenuItem.Text = "Lista Simple...";
            this.listaSimpleToolStripMenuItem.Click += new System.EventHandler(this.listaSimpleToolStripMenuItem_Click);
            // 
            // listaDobleToolStripMenuItem
            // 
            this.listaDobleToolStripMenuItem.Name = "listaDobleToolStripMenuItem";
            this.listaDobleToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.listaDobleToolStripMenuItem.Text = "Lista Doble...";
            this.listaDobleToolStripMenuItem.Click += new System.EventHandler(this.listaDobleToolStripMenuItem_Click);
            // 
            // estructurasNoLinealesToolStripMenuItem
            // 
            this.estructurasNoLinealesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arbolBinarioToolStripMenuItem});
            this.estructurasNoLinealesToolStripMenuItem.Name = "estructurasNoLinealesToolStripMenuItem";
            this.estructurasNoLinealesToolStripMenuItem.Size = new System.Drawing.Size(141, 20);
            this.estructurasNoLinealesToolStripMenuItem.Text = "Estructuras No Lineales";
            // 
            // arbolBinarioToolStripMenuItem
            // 
            this.arbolBinarioToolStripMenuItem.Name = "arbolBinarioToolStripMenuItem";
            this.arbolBinarioToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.arbolBinarioToolStripMenuItem.Text = "Arbol Binario...";
            this.arbolBinarioToolStripMenuItem.Click += new System.EventHandler(this.arbolBinarioToolStripMenuItem_Click);
            // 
            // baseDeDatosToolStripMenuItem
            // 
            this.baseDeDatosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operacionesConTablasDeBasesDeDatosToolStripMenuItem,
            this.consultasEnLaBaseDeDatosToolStripMenuItem,
            this.toolStripMenuItem3,
            this.repasoDeOperacionesToolStripMenuItem});
            this.baseDeDatosToolStripMenuItem.Name = "baseDeDatosToolStripMenuItem";
            this.baseDeDatosToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.baseDeDatosToolStripMenuItem.Text = "Base De Datos";
            // 
            // operacionesConTablasDeBasesDeDatosToolStripMenuItem
            // 
            this.operacionesConTablasDeBasesDeDatosToolStripMenuItem.Name = "operacionesConTablasDeBasesDeDatosToolStripMenuItem";
            this.operacionesConTablasDeBasesDeDatosToolStripMenuItem.Size = new System.Drawing.Size(302, 22);
            this.operacionesConTablasDeBasesDeDatosToolStripMenuItem.Text = "Operaciones con tablas de bases de datos...";
            this.operacionesConTablasDeBasesDeDatosToolStripMenuItem.Click += new System.EventHandler(this.operacionesConTablasDeBasesDeDatosToolStripMenuItem_Click);
            // 
            // consultasEnLaBaseDeDatosToolStripMenuItem
            // 
            this.consultasEnLaBaseDeDatosToolStripMenuItem.Name = "consultasEnLaBaseDeDatosToolStripMenuItem";
            this.consultasEnLaBaseDeDatosToolStripMenuItem.Size = new System.Drawing.Size(302, 22);
            this.consultasEnLaBaseDeDatosToolStripMenuItem.Text = "Consultas en la base de datos...";
            this.consultasEnLaBaseDeDatosToolStripMenuItem.Click += new System.EventHandler(this.consultasEnLaBaseDeDatosToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(299, 6);
            // 
            // repasoDeOperacionesToolStripMenuItem
            // 
            this.repasoDeOperacionesToolStripMenuItem.Name = "repasoDeOperacionesToolStripMenuItem";
            this.repasoDeOperacionesToolStripMenuItem.Size = new System.Drawing.Size(302, 22);
            this.repasoDeOperacionesToolStripMenuItem.Text = "Repaso de Operaciones...";
            this.repasoDeOperacionesToolStripMenuItem.Click += new System.EventHandler(this.repasoDeOperacionesToolStripMenuItem_Click);
            // 
            // frmVentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PryEstructuraDatos.Properties.Resources.ImgFondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(679, 422);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "frmVentanaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal EDD";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem sistemmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datosDelDesarrolladorToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sALIRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frmVenatanaPrincipal;
        private System.Windows.Forms.ToolStripMenuItem colaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pilaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem listaSimpleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDobleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estructurasNoLinealesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arbolBinarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baseDeDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operacionesConTablasDeBasesDeDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasEnLaBaseDeDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem repasoDeOperacionesToolStripMenuItem;
    }
}

