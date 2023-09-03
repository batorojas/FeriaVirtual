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
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabVentasLocales = new MetroFramework.Controls.MetroTabPage();
            this.metroTabVentasExternas = new MetroFramework.Controls.MetroTabPage();
            this.metroTabContratos = new MetroFramework.Controls.MetroTabPage();
            this.metroTabTransportes = new MetroFramework.Controls.MetroTabPage();
            this.metroTabUsuarios = new MetroFramework.Controls.MetroTabPage();
            this.metroContextMenu1.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroButtonVentas
            // 
            this.metroButtonVentas.Location = new System.Drawing.Point(676, 195);
            this.metroButtonVentas.Name = "metroButtonVentas";
            this.metroButtonVentas.Size = new System.Drawing.Size(101, 57);
            this.metroButtonVentas.TabIndex = 9;
            this.metroButtonVentas.Text = "Ventas";
            this.metroButtonVentas.UseSelectable = true;
            this.metroButtonVentas.Click += new System.EventHandler(this.metroButtonVentas_Click);
            // 
            // metroButtonLista
            // 
            this.metroButtonLista.Location = new System.Drawing.Point(676, 275);
            this.metroButtonLista.Name = "metroButtonLista";
            this.metroButtonLista.Size = new System.Drawing.Size(101, 57);
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
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabVentasLocales);
            this.metroTabControl1.Controls.Add(this.metroTabVentasExternas);
            this.metroTabControl1.Controls.Add(this.metroTabContratos);
            this.metroTabControl1.Controls.Add(this.metroTabTransportes);
            this.metroTabControl1.Controls.Add(this.metroTabUsuarios);
            this.metroTabControl1.Location = new System.Drawing.Point(23, 21);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 4;
            this.metroTabControl1.Size = new System.Drawing.Size(629, 385);
            this.metroTabControl1.TabIndex = 4;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabVentasLocales
            // 
            this.metroTabVentasLocales.HorizontalScrollbarBarColor = true;
            this.metroTabVentasLocales.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabVentasLocales.HorizontalScrollbarSize = 10;
            this.metroTabVentasLocales.Location = new System.Drawing.Point(4, 38);
            this.metroTabVentasLocales.Name = "metroTabVentasLocales";
            this.metroTabVentasLocales.Size = new System.Drawing.Size(645, 122);
            this.metroTabVentasLocales.TabIndex = 0;
            this.metroTabVentasLocales.Text = "Ventas Locales";
            this.metroTabVentasLocales.VerticalScrollbarBarColor = true;
            this.metroTabVentasLocales.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabVentasLocales.VerticalScrollbarSize = 10;
            // 
            // metroTabVentasExternas
            // 
            this.metroTabVentasExternas.HorizontalScrollbarBarColor = true;
            this.metroTabVentasExternas.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabVentasExternas.HorizontalScrollbarSize = 10;
            this.metroTabVentasExternas.Location = new System.Drawing.Point(4, 38);
            this.metroTabVentasExternas.Name = "metroTabVentasExternas";
            this.metroTabVentasExternas.Size = new System.Drawing.Size(645, 122);
            this.metroTabVentasExternas.TabIndex = 1;
            this.metroTabVentasExternas.Text = "Ventas Externas";
            this.metroTabVentasExternas.VerticalScrollbarBarColor = true;
            this.metroTabVentasExternas.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabVentasExternas.VerticalScrollbarSize = 10;
            // 
            // metroTabContratos
            // 
            this.metroTabContratos.HorizontalScrollbarBarColor = true;
            this.metroTabContratos.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabContratos.HorizontalScrollbarSize = 10;
            this.metroTabContratos.Location = new System.Drawing.Point(4, 38);
            this.metroTabContratos.Name = "metroTabContratos";
            this.metroTabContratos.Size = new System.Drawing.Size(645, 122);
            this.metroTabContratos.TabIndex = 2;
            this.metroTabContratos.Text = "Contratos";
            this.metroTabContratos.VerticalScrollbarBarColor = true;
            this.metroTabContratos.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabContratos.VerticalScrollbarSize = 10;
            // 
            // metroTabTransportes
            // 
            this.metroTabTransportes.HorizontalScrollbarBarColor = true;
            this.metroTabTransportes.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabTransportes.HorizontalScrollbarSize = 10;
            this.metroTabTransportes.Location = new System.Drawing.Point(4, 38);
            this.metroTabTransportes.Name = "metroTabTransportes";
            this.metroTabTransportes.Size = new System.Drawing.Size(645, 122);
            this.metroTabTransportes.TabIndex = 3;
            this.metroTabTransportes.Text = "Transportes";
            this.metroTabTransportes.VerticalScrollbarBarColor = true;
            this.metroTabTransportes.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabTransportes.VerticalScrollbarSize = 10;
            this.metroTabTransportes.Click += new System.EventHandler(this.metroTabPage4_Click);
            // 
            // metroTabUsuarios
            // 
            this.metroTabUsuarios.HorizontalScrollbarBarColor = true;
            this.metroTabUsuarios.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabUsuarios.HorizontalScrollbarSize = 10;
            this.metroTabUsuarios.Location = new System.Drawing.Point(4, 38);
            this.metroTabUsuarios.Name = "metroTabUsuarios";
            this.metroTabUsuarios.Size = new System.Drawing.Size(621, 343);
            this.metroTabUsuarios.TabIndex = 4;
            this.metroTabUsuarios.Text = "Usuarios";
            this.metroTabUsuarios.VerticalScrollbarBarColor = true;
            this.metroTabUsuarios.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabUsuarios.VerticalScrollbarSize = 10;
            // 
            // vMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.metroButtonVentas);
            this.Controls.Add(this.metroButtonLista);
            this.Name = "vMain";
            this.Load += new System.EventHandler(this.Main_Load);
            this.metroContextMenu1.ResumeLayout(false);
            this.metroTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton metroButtonLista;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private MetroFramework.Controls.MetroButton metroButtonVentas;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabVentasLocales;
        private MetroFramework.Controls.MetroTabPage metroTabVentasExternas;
        private MetroFramework.Controls.MetroTabPage metroTabContratos;
        private MetroFramework.Controls.MetroTabPage metroTabTransportes;
        private MetroFramework.Controls.MetroTabPage metroTabUsuarios;
    }
}

