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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroButtonLista = new MetroFramework.Controls.MetroButton();
            this.metroButtonProductores = new MetroFramework.Controls.MetroButton();
            this.metroButtonClientes = new MetroFramework.Controls.MetroButton();
            this.metroButtonTransportistas = new MetroFramework.Controls.MetroButton();
            this.metroButtonConsultor = new MetroFramework.Controls.MetroButton();
            this.metroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.metroButtonVentas = new MetroFramework.Controls.MetroButton();
            this.metroPanel1.SuspendLayout();
            this.metroContextMenu1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroButtonVentas);
            this.metroPanel1.Controls.Add(this.metroButtonConsultor);
            this.metroPanel1.Controls.Add(this.metroButtonTransportistas);
            this.metroPanel1.Controls.Add(this.metroButtonClientes);
            this.metroPanel1.Controls.Add(this.metroButtonProductores);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(170, 82);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(468, 286);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(373, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(47, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "MENU";
            // 
            // metroButtonLista
            // 
            this.metroButtonLista.Location = new System.Drawing.Point(644, 163);
            this.metroButtonLista.Name = "metroButtonLista";
            this.metroButtonLista.Size = new System.Drawing.Size(101, 57);
            this.metroButtonLista.TabIndex = 3;
            this.metroButtonLista.Text = "Listado";
            this.metroButtonLista.UseSelectable = true;
            this.metroButtonLista.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButtonProductores
            // 
            this.metroButtonProductores.Location = new System.Drawing.Point(149, 101);
            this.metroButtonProductores.Name = "metroButtonProductores";
            this.metroButtonProductores.Size = new System.Drawing.Size(101, 57);
            this.metroButtonProductores.TabIndex = 5;
            this.metroButtonProductores.Text = "Productores";
            this.metroButtonProductores.UseSelectable = true;
            this.metroButtonProductores.Click += new System.EventHandler(this.metroButtonProductores_Click);
            // 
            // metroButtonClientes
            // 
            this.metroButtonClientes.Location = new System.Drawing.Point(29, 101);
            this.metroButtonClientes.Name = "metroButtonClientes";
            this.metroButtonClientes.Size = new System.Drawing.Size(101, 57);
            this.metroButtonClientes.TabIndex = 6;
            this.metroButtonClientes.Text = "Clientes";
            this.metroButtonClientes.UseSelectable = true;
            // 
            // metroButtonTransportistas
            // 
            this.metroButtonTransportistas.Location = new System.Drawing.Point(149, 21);
            this.metroButtonTransportistas.Name = "metroButtonTransportistas";
            this.metroButtonTransportistas.Size = new System.Drawing.Size(101, 57);
            this.metroButtonTransportistas.TabIndex = 7;
            this.metroButtonTransportistas.Text = "Transportistas";
            this.metroButtonTransportistas.UseSelectable = true;
            // 
            // metroButtonConsultor
            // 
            this.metroButtonConsultor.Location = new System.Drawing.Point(29, 21);
            this.metroButtonConsultor.Name = "metroButtonConsultor";
            this.metroButtonConsultor.Size = new System.Drawing.Size(101, 57);
            this.metroButtonConsultor.TabIndex = 8;
            this.metroButtonConsultor.Text = "Consultor";
            this.metroButtonConsultor.UseSelectable = true;
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
            // metroButtonVentas
            // 
            this.metroButtonVentas.Location = new System.Drawing.Point(320, 30);
            this.metroButtonVentas.Name = "metroButtonVentas";
            this.metroButtonVentas.Size = new System.Drawing.Size(101, 57);
            this.metroButtonVentas.TabIndex = 9;
            this.metroButtonVentas.Text = "Ventas";
            this.metroButtonVentas.UseSelectable = true;
            this.metroButtonVentas.Click += new System.EventHandler(this.metroButtonVentas_Click);
            // 
            // vMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroButtonLista);
            this.Name = "vMain";
            this.Load += new System.EventHandler(this.Main_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroContextMenu1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton metroButtonLista;
        private MetroFramework.Controls.MetroButton metroButtonConsultor;
        private MetroFramework.Controls.MetroButton metroButtonTransportistas;
        private MetroFramework.Controls.MetroButton metroButtonClientes;
        private MetroFramework.Controls.MetroButton metroButtonProductores;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private MetroFramework.Controls.MetroButton metroButtonVentas;
    }
}

