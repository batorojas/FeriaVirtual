namespace FeriaApp
{
    partial class vMain
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
            this.components = new System.ComponentModel.Container();
            this.metroButtonVentas = new MetroFramework.Controls.MetroButton();
            this.metroButtonLista = new MetroFramework.Controls.MetroButton();
            this.metroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlMenu1 = new TabControls.DotNetBarTabControl();
            this.tabPageInicio = new System.Windows.Forms.TabPage();
            this.tabPageVentasLocales = new System.Windows.Forms.TabPage();
            this.tabPageVentasExternas = new System.Windows.Forms.TabPage();
            this.tabPageContratos = new System.Windows.Forms.TabPage();
            this.tabPageTransportes = new System.Windows.Forms.TabPage();
            this.tabPageUsuarios = new System.Windows.Forms.TabPage();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPageUsuarios = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPageCrearUsuario = new MetroFramework.Controls.MetroTabPage();
            this.metroContextMenu1.SuspendLayout();
            this.tabControlMenu1.SuspendLayout();
            this.tabPageUsuarios.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroButtonVentas
            // 
            this.metroButtonVentas.Location = new System.Drawing.Point(731, 195);
            this.metroButtonVentas.Name = "metroButtonVentas";
            this.metroButtonVentas.Size = new System.Drawing.Size(46, 45);
            this.metroButtonVentas.TabIndex = 9;
            this.metroButtonVentas.Text = "Ventas";
            this.metroButtonVentas.UseSelectable = true;
            this.metroButtonVentas.Click += new System.EventHandler(this.metroButtonVentas_Click);
            // 
            // metroButtonLista
            // 
            this.metroButtonLista.Location = new System.Drawing.Point(731, 246);
            this.metroButtonLista.Name = "metroButtonLista";
            this.metroButtonLista.Size = new System.Drawing.Size(46, 45);
            this.metroButtonLista.TabIndex = 3;
            this.metroButtonLista.Text = "Listado";
            this.metroButtonLista.UseSelectable = true;
            this.metroButtonLista.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroContextMenu1
            // 
            this.metroContextMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.metroContextMenu1.Name = "metroContextMenu1";
            this.metroContextMenu1.Size = new System.Drawing.Size(181, 48);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem2.Text = "toolStripMenuItem2";
            // 
            // tabControlMenu1
            // 
            this.tabControlMenu1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControlMenu1.Controls.Add(this.tabPageInicio);
            this.tabControlMenu1.Controls.Add(this.tabPageVentasLocales);
            this.tabControlMenu1.Controls.Add(this.tabPageVentasExternas);
            this.tabControlMenu1.Controls.Add(this.tabPageContratos);
            this.tabControlMenu1.Controls.Add(this.tabPageTransportes);
            this.tabControlMenu1.Controls.Add(this.tabPageUsuarios);
            this.tabControlMenu1.ItemSize = new System.Drawing.Size(44, 136);
            this.tabControlMenu1.Location = new System.Drawing.Point(0, 5);
            this.tabControlMenu1.Multiline = true;
            this.tabControlMenu1.Name = "tabControlMenu1";
            this.tabControlMenu1.SelectedIndex = 0;
            this.tabControlMenu1.Size = new System.Drawing.Size(725, 449);
            this.tabControlMenu1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlMenu1.TabIndex = 10;
            // 
            // tabPageInicio
            // 
            this.tabPageInicio.Location = new System.Drawing.Point(140, 4);
            this.tabPageInicio.Name = "tabPageInicio";
            this.tabPageInicio.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInicio.Size = new System.Drawing.Size(581, 441);
            this.tabPageInicio.TabIndex = 0;
            this.tabPageInicio.Text = "Inicio";
            this.tabPageInicio.UseVisualStyleBackColor = true;
            // 
            // tabPageVentasLocales
            // 
            this.tabPageVentasLocales.Location = new System.Drawing.Point(140, 4);
            this.tabPageVentasLocales.Name = "tabPageVentasLocales";
            this.tabPageVentasLocales.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageVentasLocales.Size = new System.Drawing.Size(581, 441);
            this.tabPageVentasLocales.TabIndex = 1;
            this.tabPageVentasLocales.Text = "Ventas Locales";
            this.tabPageVentasLocales.UseVisualStyleBackColor = true;
            // 
            // tabPageVentasExternas
            // 
            this.tabPageVentasExternas.Location = new System.Drawing.Point(140, 4);
            this.tabPageVentasExternas.Name = "tabPageVentasExternas";
            this.tabPageVentasExternas.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageVentasExternas.Size = new System.Drawing.Size(581, 441);
            this.tabPageVentasExternas.TabIndex = 2;
            this.tabPageVentasExternas.Text = "Ventas Externas";
            this.tabPageVentasExternas.UseVisualStyleBackColor = true;
            // 
            // tabPageContratos
            // 
            this.tabPageContratos.Location = new System.Drawing.Point(140, 4);
            this.tabPageContratos.Name = "tabPageContratos";
            this.tabPageContratos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageContratos.Size = new System.Drawing.Size(581, 441);
            this.tabPageContratos.TabIndex = 3;
            this.tabPageContratos.Text = "Contratos";
            this.tabPageContratos.UseVisualStyleBackColor = true;
            // 
            // tabPageTransportes
            // 
            this.tabPageTransportes.Location = new System.Drawing.Point(140, 4);
            this.tabPageTransportes.Name = "tabPageTransportes";
            this.tabPageTransportes.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTransportes.Size = new System.Drawing.Size(581, 441);
            this.tabPageTransportes.TabIndex = 4;
            this.tabPageTransportes.Text = "Transportes";
            this.tabPageTransportes.UseVisualStyleBackColor = true;
            // 
            // tabPageUsuarios
            // 
            this.tabPageUsuarios.Controls.Add(this.metroTabControl1);
            this.tabPageUsuarios.Location = new System.Drawing.Point(140, 4);
            this.tabPageUsuarios.Name = "tabPageUsuarios";
            this.tabPageUsuarios.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUsuarios.Size = new System.Drawing.Size(581, 441);
            this.tabPageUsuarios.TabIndex = 5;
            this.tabPageUsuarios.Text = "Usuarios";
            this.tabPageUsuarios.UseVisualStyleBackColor = true;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPageUsuarios);
            this.metroTabControl1.Controls.Add(this.metroTabPageCrearUsuario);
            this.metroTabControl1.Location = new System.Drawing.Point(6, 7);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(567, 399);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPageUsuarios
            // 
            this.metroTabPageUsuarios.HorizontalScrollbarBarColor = true;
            this.metroTabPageUsuarios.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPageUsuarios.HorizontalScrollbarSize = 10;
            this.metroTabPageUsuarios.Location = new System.Drawing.Point(4, 38);
            this.metroTabPageUsuarios.Name = "metroTabPageUsuarios";
            this.metroTabPageUsuarios.Size = new System.Drawing.Size(559, 357);
            this.metroTabPageUsuarios.TabIndex = 0;
            this.metroTabPageUsuarios.Text = "Usuarios";
            this.metroTabPageUsuarios.VerticalScrollbarBarColor = true;
            this.metroTabPageUsuarios.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPageUsuarios.VerticalScrollbarSize = 10;
            // 
            // metroTabPageCrearUsuario
            // 
            this.metroTabPageCrearUsuario.HorizontalScrollbarBarColor = true;
            this.metroTabPageCrearUsuario.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPageCrearUsuario.HorizontalScrollbarSize = 10;
            this.metroTabPageCrearUsuario.Location = new System.Drawing.Point(4, 38);
            this.metroTabPageCrearUsuario.Name = "metroTabPageCrearUsuario";
            this.metroTabPageCrearUsuario.Size = new System.Drawing.Size(559, 357);
            this.metroTabPageCrearUsuario.TabIndex = 1;
            this.metroTabPageCrearUsuario.Text = "Crear Usuario";
            this.metroTabPageCrearUsuario.VerticalScrollbarBarColor = true;
            this.metroTabPageCrearUsuario.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPageCrearUsuario.VerticalScrollbarSize = 10;
            // 
            // vMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlMenu1);
            this.Controls.Add(this.metroButtonVentas);
            this.Controls.Add(this.metroButtonLista);
            this.MaximizeBox = false;
            this.Name = "vMain";
            this.Resizable = false;
            this.Load += new System.EventHandler(this.Main_Load);
            this.metroContextMenu1.ResumeLayout(false);
            this.tabControlMenu1.ResumeLayout(false);
            this.tabPageUsuarios.ResumeLayout(false);
            this.metroTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton metroButtonLista;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private MetroFramework.Controls.MetroButton metroButtonVentas;
        private TabControls.DotNetBarTabControl tabControlMenu1;
        private System.Windows.Forms.TabPage tabPageInicio;
        private System.Windows.Forms.TabPage tabPageVentasLocales;
        private System.Windows.Forms.TabPage tabPageVentasExternas;
        private System.Windows.Forms.TabPage tabPageContratos;
        private System.Windows.Forms.TabPage tabPageTransportes;
        private System.Windows.Forms.TabPage tabPageUsuarios;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPageUsuarios;
        private MetroFramework.Controls.MetroTabPage metroTabPageCrearUsuario;
    }
}

