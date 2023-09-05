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
            this.metroButtonVentas = new MetroFramework.Controls.MetroButton();
            this.tabControlMenu1 = new TabControls.DotNetBarTabControl();
            this.tabPageInicio = new System.Windows.Forms.TabPage();
            this.vInicio1 = new FeriaApp.vInicio();
            this.tabPageVentasLocales = new System.Windows.Forms.TabPage();
            this.tabPageVentasExternas = new System.Windows.Forms.TabPage();
            this.tabPageContratos = new System.Windows.Forms.TabPage();
            this.tabPageTransportes = new System.Windows.Forms.TabPage();
            this.tabPageUsuarios = new System.Windows.Forms.TabPage();
            this.vUsuarios1 = new FeriaApp.vUsuarios();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.vVentasLocales1 = new FeriaApp.vVentasLocales();
            this.vVentasExternas1 = new FeriaApp.vVentasExternas();
            this.vContratos1 = new FeriaApp.vContratos();
            this.vTransportes1 = new FeriaApp.vTransportes();
            this.tabControlMenu1.SuspendLayout();
            this.tabPageInicio.SuspendLayout();
            this.tabPageVentasLocales.SuspendLayout();
            this.tabPageVentasExternas.SuspendLayout();
            this.tabPageContratos.SuspendLayout();
            this.tabPageTransportes.SuspendLayout();
            this.tabPageUsuarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroButtonVentas
            // 
            this.metroButtonVentas.Location = new System.Drawing.Point(754, 171);
            this.metroButtonVentas.Name = "metroButtonVentas";
            this.metroButtonVentas.Size = new System.Drawing.Size(46, 45);
            this.metroButtonVentas.TabIndex = 9;
            this.metroButtonVentas.Text = "Ventas";
            this.metroButtonVentas.UseSelectable = true;
            this.metroButtonVentas.Click += new System.EventHandler(this.metroButtonVentas_Click);
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
            this.tabControlMenu1.Size = new System.Drawing.Size(748, 449);
            this.tabControlMenu1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlMenu1.TabIndex = 10;
            // 
            // tabPageInicio
            // 
            this.tabPageInicio.Controls.Add(this.vInicio1);
            this.tabPageInicio.Location = new System.Drawing.Point(140, 4);
            this.tabPageInicio.Name = "tabPageInicio";
            this.tabPageInicio.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInicio.Size = new System.Drawing.Size(604, 441);
            this.tabPageInicio.TabIndex = 0;
            this.tabPageInicio.Text = "Inicio";
            this.tabPageInicio.UseVisualStyleBackColor = true;
            // 
            // vInicio1
            // 
            this.vInicio1.Location = new System.Drawing.Point(0, 0);
            this.vInicio1.Name = "vInicio1";
            this.vInicio1.Size = new System.Drawing.Size(604, 441);
            this.vInicio1.TabIndex = 0;
            // 
            // tabPageVentasLocales
            // 
            this.tabPageVentasLocales.Controls.Add(this.vVentasLocales1);
            this.tabPageVentasLocales.Location = new System.Drawing.Point(140, 4);
            this.tabPageVentasLocales.Name = "tabPageVentasLocales";
            this.tabPageVentasLocales.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageVentasLocales.Size = new System.Drawing.Size(604, 441);
            this.tabPageVentasLocales.TabIndex = 1;
            this.tabPageVentasLocales.Text = "Ventas Locales";
            this.tabPageVentasLocales.UseVisualStyleBackColor = true;
            // 
            // tabPageVentasExternas
            // 
            this.tabPageVentasExternas.Controls.Add(this.vVentasExternas1);
            this.tabPageVentasExternas.Location = new System.Drawing.Point(140, 4);
            this.tabPageVentasExternas.Name = "tabPageVentasExternas";
            this.tabPageVentasExternas.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageVentasExternas.Size = new System.Drawing.Size(604, 441);
            this.tabPageVentasExternas.TabIndex = 2;
            this.tabPageVentasExternas.Text = "Ventas Externas";
            this.tabPageVentasExternas.UseVisualStyleBackColor = true;
            // 
            // tabPageContratos
            // 
            this.tabPageContratos.Controls.Add(this.vContratos1);
            this.tabPageContratos.Location = new System.Drawing.Point(140, 4);
            this.tabPageContratos.Name = "tabPageContratos";
            this.tabPageContratos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageContratos.Size = new System.Drawing.Size(604, 441);
            this.tabPageContratos.TabIndex = 3;
            this.tabPageContratos.Text = "Contratos";
            this.tabPageContratos.UseVisualStyleBackColor = true;
            // 
            // tabPageTransportes
            // 
            this.tabPageTransportes.Controls.Add(this.vTransportes1);
            this.tabPageTransportes.Location = new System.Drawing.Point(140, 4);
            this.tabPageTransportes.Name = "tabPageTransportes";
            this.tabPageTransportes.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTransportes.Size = new System.Drawing.Size(604, 441);
            this.tabPageTransportes.TabIndex = 4;
            this.tabPageTransportes.Text = "Transportes";
            this.tabPageTransportes.UseVisualStyleBackColor = true;
            // 
            // tabPageUsuarios
            // 
            this.tabPageUsuarios.Controls.Add(this.vUsuarios1);
            this.tabPageUsuarios.Location = new System.Drawing.Point(140, 4);
            this.tabPageUsuarios.Name = "tabPageUsuarios";
            this.tabPageUsuarios.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUsuarios.Size = new System.Drawing.Size(604, 441);
            this.tabPageUsuarios.TabIndex = 5;
            this.tabPageUsuarios.Text = "Usuarios";
            this.tabPageUsuarios.UseVisualStyleBackColor = true;
            // 
            // vUsuarios1
            // 
            this.vUsuarios1.Location = new System.Drawing.Point(0, 0);
            this.vUsuarios1.Name = "vUsuarios1";
            this.vUsuarios1.Size = new System.Drawing.Size(604, 441);
            this.vUsuarios1.TabIndex = 0;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(0, 0);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(200, 100);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // vVentasLocales1
            // 
            this.vVentasLocales1.Location = new System.Drawing.Point(0, 0);
            this.vVentasLocales1.Name = "vVentasLocales1";
            this.vVentasLocales1.Size = new System.Drawing.Size(604, 441);
            this.vVentasLocales1.TabIndex = 0;
            // 
            // vVentasExternas1
            // 
            this.vVentasExternas1.Location = new System.Drawing.Point(0, 0);
            this.vVentasExternas1.Name = "vVentasExternas1";
            this.vVentasExternas1.Size = new System.Drawing.Size(604, 441);
            this.vVentasExternas1.TabIndex = 0;
            // 
            // vContratos1
            // 
            this.vContratos1.Location = new System.Drawing.Point(0, 0);
            this.vContratos1.Name = "vContratos1";
            this.vContratos1.Size = new System.Drawing.Size(604, 441);
            this.vContratos1.TabIndex = 0;
            // 
            // vTransportes1
            // 
            this.vTransportes1.Location = new System.Drawing.Point(0, 0);
            this.vTransportes1.Name = "vTransportes1";
            this.vTransportes1.Size = new System.Drawing.Size(604, 441);
            this.vTransportes1.TabIndex = 0;
            // 
            // vMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlMenu1);
            this.Controls.Add(this.metroButtonVentas);
            this.MaximizeBox = false;
            this.Name = "vMain";
            this.Resizable = false;
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabControlMenu1.ResumeLayout(false);
            this.tabPageInicio.ResumeLayout(false);
            this.tabPageVentasLocales.ResumeLayout(false);
            this.tabPageVentasExternas.ResumeLayout(false);
            this.tabPageContratos.ResumeLayout(false);
            this.tabPageTransportes.ResumeLayout(false);
            this.tabPageUsuarios.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton metroButtonVentas;
        private TabControls.DotNetBarTabControl tabControlMenu1;
        private System.Windows.Forms.TabPage tabPageInicio;
        private System.Windows.Forms.TabPage tabPageVentasLocales;
        private System.Windows.Forms.TabPage tabPageVentasExternas;
        private System.Windows.Forms.TabPage tabPageContratos;
        private System.Windows.Forms.TabPage tabPageTransportes;
        private System.Windows.Forms.TabPage tabPageUsuarios;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private vInicio vInicio1;
        private vUsuarios vUsuarios1;
        private vVentasLocales vVentasLocales1;
        private vVentasExternas vVentasExternas1;
        private vContratos vContratos1;
        private vTransportes vTransportes1;
    }
}

