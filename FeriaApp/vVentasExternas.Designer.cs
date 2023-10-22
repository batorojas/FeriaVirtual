namespace FeriaApp
{
    partial class vVentasExternas
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

        #region Código generado por el Diseñador de componentes

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvListaVentas = new MetroFramework.Controls.MetroGrid();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabProcesosVenta = new MetroFramework.Controls.MetroTabPage();
            this.btnActualizar = new MetroFramework.Controls.MetroButton();
            this.btnExportar = new MetroFramework.Controls.MetroButton();
            this.metroButtonDetallesPV = new MetroFramework.Controls.MetroButton();
            this.metroTabDetallePV = new MetroFramework.Controls.MetroTabPage();
            this.btnTransporte = new MetroFramework.Controls.MetroButton();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.dgvDetalleProcesoVenta = new MetroFramework.Controls.MetroGrid();
            this.mdtFechaEmisionPV = new MetroFramework.Controls.MetroDateTime();
            this.txtbObservacionesPV = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txtbEstado = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtbEmpresaTransporte = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtbRazonSocial = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtbRutCliente = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtbIDProcesoVenta = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaVentas)).BeginInit();
            this.metroTabControl1.SuspendLayout();
            this.metroTabProcesosVenta.SuspendLayout();
            this.metroTabDetallePV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleProcesoVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaVentas
            // 
            this.dgvListaVentas.AllowUserToResizeRows = false;
            this.dgvListaVentas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvListaVentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListaVentas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvListaVentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListaVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaVentas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListaVentas.EnableHeadersVisualStyles = false;
            this.dgvListaVentas.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvListaVentas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvListaVentas.Location = new System.Drawing.Point(2, 21);
            this.dgvListaVentas.Margin = new System.Windows.Forms.Padding(2);
            this.dgvListaVentas.Name = "dgvListaVentas";
            this.dgvListaVentas.ReadOnly = true;
            this.dgvListaVentas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaVentas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListaVentas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvListaVentas.RowTemplate.Height = 24;
            this.dgvListaVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaVentas.Size = new System.Drawing.Size(637, 254);
            this.dgvListaVentas.TabIndex = 2;
            this.dgvListaVentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaVentas_CellContentClick);
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabProcesosVenta);
            this.metroTabControl1.Controls.Add(this.metroTabDetallePV);
            this.metroTabControl1.Location = new System.Drawing.Point(6, 21);
            this.metroTabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(647, 417);
            this.metroTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.metroTabControl1.TabIndex = 3;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabProcesosVenta
            // 
            this.metroTabProcesosVenta.Controls.Add(this.btnActualizar);
            this.metroTabProcesosVenta.Controls.Add(this.btnExportar);
            this.metroTabProcesosVenta.Controls.Add(this.metroButtonDetallesPV);
            this.metroTabProcesosVenta.Controls.Add(this.dgvListaVentas);
            this.metroTabProcesosVenta.HorizontalScrollbarBarColor = true;
            this.metroTabProcesosVenta.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabProcesosVenta.HorizontalScrollbarSize = 8;
            this.metroTabProcesosVenta.Location = new System.Drawing.Point(4, 38);
            this.metroTabProcesosVenta.Margin = new System.Windows.Forms.Padding(2);
            this.metroTabProcesosVenta.Name = "metroTabProcesosVenta";
            this.metroTabProcesosVenta.Size = new System.Drawing.Size(639, 375);
            this.metroTabProcesosVenta.TabIndex = 0;
            this.metroTabProcesosVenta.Text = "Procesos de Venta";
            this.metroTabProcesosVenta.VerticalScrollbarBarColor = true;
            this.metroTabProcesosVenta.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabProcesosVenta.VerticalScrollbarSize = 8;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(29, 307);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(63, 52);
            this.btnActualizar.TabIndex = 8;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseSelectable = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(532, 307);
            this.btnExportar.Margin = new System.Windows.Forms.Padding(2);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(63, 52);
            this.btnExportar.TabIndex = 7;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseSelectable = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // metroButtonDetallesPV
            // 
            this.metroButtonDetallesPV.Location = new System.Drawing.Point(209, 307);
            this.metroButtonDetallesPV.Margin = new System.Windows.Forms.Padding(2);
            this.metroButtonDetallesPV.Name = "metroButtonDetallesPV";
            this.metroButtonDetallesPV.Size = new System.Drawing.Size(194, 52);
            this.metroButtonDetallesPV.TabIndex = 3;
            this.metroButtonDetallesPV.Text = "Ver Detalles";
            this.metroButtonDetallesPV.UseSelectable = true;
            this.metroButtonDetallesPV.Click += new System.EventHandler(this.metroButtonDetallesPV_Click);
            // 
            // metroTabDetallePV
            // 
            this.metroTabDetallePV.Controls.Add(this.btnTransporte);
            this.metroTabDetallePV.Controls.Add(this.metroLabel8);
            this.metroTabDetallePV.Controls.Add(this.dgvDetalleProcesoVenta);
            this.metroTabDetallePV.Controls.Add(this.mdtFechaEmisionPV);
            this.metroTabDetallePV.Controls.Add(this.txtbObservacionesPV);
            this.metroTabDetallePV.Controls.Add(this.metroLabel7);
            this.metroTabDetallePV.Controls.Add(this.txtbEstado);
            this.metroTabDetallePV.Controls.Add(this.metroLabel6);
            this.metroTabDetallePV.Controls.Add(this.txtbEmpresaTransporte);
            this.metroTabDetallePV.Controls.Add(this.metroLabel5);
            this.metroTabDetallePV.Controls.Add(this.txtbRazonSocial);
            this.metroTabDetallePV.Controls.Add(this.metroLabel4);
            this.metroTabDetallePV.Controls.Add(this.txtbRutCliente);
            this.metroTabDetallePV.Controls.Add(this.metroLabel3);
            this.metroTabDetallePV.Controls.Add(this.metroLabel2);
            this.metroTabDetallePV.Controls.Add(this.txtbIDProcesoVenta);
            this.metroTabDetallePV.Controls.Add(this.metroLabel1);
            this.metroTabDetallePV.HorizontalScrollbarBarColor = true;
            this.metroTabDetallePV.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabDetallePV.HorizontalScrollbarSize = 8;
            this.metroTabDetallePV.Location = new System.Drawing.Point(4, 38);
            this.metroTabDetallePV.Margin = new System.Windows.Forms.Padding(2);
            this.metroTabDetallePV.Name = "metroTabDetallePV";
            this.metroTabDetallePV.Size = new System.Drawing.Size(639, 375);
            this.metroTabDetallePV.TabIndex = 1;
            this.metroTabDetallePV.Text = "Detalle Venta";
            this.metroTabDetallePV.VerticalScrollbarBarColor = true;
            this.metroTabDetallePV.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabDetallePV.VerticalScrollbarSize = 8;
            // 
            // btnTransporte
            // 
            this.btnTransporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.btnTransporte.ForeColor = System.Drawing.Color.White;
            this.btnTransporte.Location = new System.Drawing.Point(519, 226);
            this.btnTransporte.Name = "btnTransporte";
            this.btnTransporte.Size = new System.Drawing.Size(100, 37);
            this.btnTransporte.TabIndex = 19;
            this.btnTransporte.Text = "Ver Transporte";
            this.btnTransporte.UseCustomBackColor = true;
            this.btnTransporte.UseCustomForeColor = true;
            this.btnTransporte.UseSelectable = true;
            this.btnTransporte.Click += new System.EventHandler(this.btnTransporte_Click_1);
            // 
            // metroLabel8
            // 
            this.metroLabel8.BackColor = System.Drawing.SystemColors.Info;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel8.Location = new System.Drawing.Point(20, 194);
            this.metroLabel8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(136, 19);
            this.metroLabel8.TabIndex = 18;
            this.metroLabel8.Text = "Productos:";
            this.metroLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvDetalleProcesoVenta
            // 
            this.dgvDetalleProcesoVenta.AllowUserToAddRows = false;
            this.dgvDetalleProcesoVenta.AllowUserToDeleteRows = false;
            this.dgvDetalleProcesoVenta.AllowUserToResizeRows = false;
            this.dgvDetalleProcesoVenta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvDetalleProcesoVenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDetalleProcesoVenta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvDetalleProcesoVenta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalleProcesoVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDetalleProcesoVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetalleProcesoVenta.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDetalleProcesoVenta.EnableHeadersVisualStyles = false;
            this.dgvDetalleProcesoVenta.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvDetalleProcesoVenta.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvDetalleProcesoVenta.Location = new System.Drawing.Point(32, 216);
            this.dgvDetalleProcesoVenta.Name = "dgvDetalleProcesoVenta";
            this.dgvDetalleProcesoVenta.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalleProcesoVenta.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDetalleProcesoVenta.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDetalleProcesoVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalleProcesoVenta.Size = new System.Drawing.Size(481, 125);
            this.dgvDetalleProcesoVenta.TabIndex = 17;
            // 
            // mdtFechaEmisionPV
            // 
            this.mdtFechaEmisionPV.Cursor = System.Windows.Forms.Cursors.No;
            this.mdtFechaEmisionPV.Enabled = false;
            this.mdtFechaEmisionPV.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.mdtFechaEmisionPV.Location = new System.Drawing.Point(391, 5);
            this.mdtFechaEmisionPV.Margin = new System.Windows.Forms.Padding(2);
            this.mdtFechaEmisionPV.MinimumSize = new System.Drawing.Size(0, 29);
            this.mdtFechaEmisionPV.Name = "mdtFechaEmisionPV";
            this.mdtFechaEmisionPV.Size = new System.Drawing.Size(228, 29);
            this.mdtFechaEmisionPV.TabIndex = 16;
            // 
            // txtbObservacionesPV
            // 
            // 
            // 
            // 
            this.txtbObservacionesPV.CustomButton.Image = null;
            this.txtbObservacionesPV.CustomButton.Location = new System.Drawing.Point(492, 1);
            this.txtbObservacionesPV.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtbObservacionesPV.CustomButton.Name = "";
            this.txtbObservacionesPV.CustomButton.Size = new System.Drawing.Size(63, 63);
            this.txtbObservacionesPV.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtbObservacionesPV.CustomButton.TabIndex = 1;
            this.txtbObservacionesPV.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtbObservacionesPV.CustomButton.UseSelectable = true;
            this.txtbObservacionesPV.CustomButton.Visible = false;
            this.txtbObservacionesPV.Enabled = false;
            this.txtbObservacionesPV.Lines = new string[0];
            this.txtbObservacionesPV.Location = new System.Drawing.Point(48, 118);
            this.txtbObservacionesPV.Margin = new System.Windows.Forms.Padding(2);
            this.txtbObservacionesPV.MaxLength = 32767;
            this.txtbObservacionesPV.Name = "txtbObservacionesPV";
            this.txtbObservacionesPV.PasswordChar = '\0';
            this.txtbObservacionesPV.PromptText = "No posee observaciones";
            this.txtbObservacionesPV.ReadOnly = true;
            this.txtbObservacionesPV.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtbObservacionesPV.SelectedText = "";
            this.txtbObservacionesPV.SelectionLength = 0;
            this.txtbObservacionesPV.SelectionStart = 0;
            this.txtbObservacionesPV.ShortcutsEnabled = true;
            this.txtbObservacionesPV.Size = new System.Drawing.Size(556, 65);
            this.txtbObservacionesPV.TabIndex = 15;
            this.txtbObservacionesPV.UseSelectable = true;
            this.txtbObservacionesPV.WaterMark = "No posee observaciones";
            this.txtbObservacionesPV.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtbObservacionesPV.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.BackColor = System.Drawing.SystemColors.Info;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel7.Location = new System.Drawing.Point(20, 97);
            this.metroLabel7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(136, 19);
            this.metroLabel7.TabIndex = 14;
            this.metroLabel7.Text = "Observaciones:";
            this.metroLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtbEstado
            // 
            // 
            // 
            // 
            this.txtbEstado.CustomButton.Image = null;
            this.txtbEstado.CustomButton.Location = new System.Drawing.Point(203, 1);
            this.txtbEstado.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtbEstado.CustomButton.Name = "";
            this.txtbEstado.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtbEstado.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtbEstado.CustomButton.TabIndex = 1;
            this.txtbEstado.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtbEstado.CustomButton.UseSelectable = true;
            this.txtbEstado.CustomButton.Visible = false;
            this.txtbEstado.Enabled = false;
            this.txtbEstado.Lines = new string[0];
            this.txtbEstado.Location = new System.Drawing.Point(391, 65);
            this.txtbEstado.Margin = new System.Windows.Forms.Padding(2);
            this.txtbEstado.MaxLength = 32767;
            this.txtbEstado.Name = "txtbEstado";
            this.txtbEstado.PasswordChar = '\0';
            this.txtbEstado.ReadOnly = true;
            this.txtbEstado.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtbEstado.SelectedText = "";
            this.txtbEstado.SelectionLength = 0;
            this.txtbEstado.SelectionStart = 0;
            this.txtbEstado.ShortcutsEnabled = true;
            this.txtbEstado.Size = new System.Drawing.Size(225, 23);
            this.txtbEstado.TabIndex = 13;
            this.txtbEstado.UseSelectable = true;
            this.txtbEstado.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtbEstado.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.Location = new System.Drawing.Point(283, 69);
            this.metroLabel6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(104, 19);
            this.metroLabel6.TabIndex = 12;
            this.metroLabel6.Text = "Estado";
            this.metroLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtbEmpresaTransporte
            // 
            // 
            // 
            // 
            this.txtbEmpresaTransporte.CustomButton.Image = null;
            this.txtbEmpresaTransporte.CustomButton.Location = new System.Drawing.Point(122, 1);
            this.txtbEmpresaTransporte.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtbEmpresaTransporte.CustomButton.Name = "";
            this.txtbEmpresaTransporte.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtbEmpresaTransporte.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtbEmpresaTransporte.CustomButton.TabIndex = 1;
            this.txtbEmpresaTransporte.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtbEmpresaTransporte.CustomButton.UseSelectable = true;
            this.txtbEmpresaTransporte.CustomButton.Visible = false;
            this.txtbEmpresaTransporte.Enabled = false;
            this.txtbEmpresaTransporte.Lines = new string[0];
            this.txtbEmpresaTransporte.Location = new System.Drawing.Point(119, 63);
            this.txtbEmpresaTransporte.Margin = new System.Windows.Forms.Padding(2);
            this.txtbEmpresaTransporte.MaxLength = 32767;
            this.txtbEmpresaTransporte.Name = "txtbEmpresaTransporte";
            this.txtbEmpresaTransporte.PasswordChar = '\0';
            this.txtbEmpresaTransporte.ReadOnly = true;
            this.txtbEmpresaTransporte.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtbEmpresaTransporte.SelectedText = "";
            this.txtbEmpresaTransporte.SelectionLength = 0;
            this.txtbEmpresaTransporte.SelectionStart = 0;
            this.txtbEmpresaTransporte.ShortcutsEnabled = true;
            this.txtbEmpresaTransporte.Size = new System.Drawing.Size(144, 23);
            this.txtbEmpresaTransporte.TabIndex = 11;
            this.txtbEmpresaTransporte.UseSelectable = true;
            this.txtbEmpresaTransporte.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtbEmpresaTransporte.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.Location = new System.Drawing.Point(3, 65);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(112, 19);
            this.metroLabel5.TabIndex = 10;
            this.metroLabel5.Text = "Emp. Transporte";
            this.metroLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtbRazonSocial
            // 
            // 
            // 
            // 
            this.txtbRazonSocial.CustomButton.Image = null;
            this.txtbRazonSocial.CustomButton.Location = new System.Drawing.Point(203, 1);
            this.txtbRazonSocial.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtbRazonSocial.CustomButton.Name = "";
            this.txtbRazonSocial.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtbRazonSocial.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtbRazonSocial.CustomButton.TabIndex = 1;
            this.txtbRazonSocial.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtbRazonSocial.CustomButton.UseSelectable = true;
            this.txtbRazonSocial.CustomButton.Visible = false;
            this.txtbRazonSocial.Enabled = false;
            this.txtbRazonSocial.Lines = new string[0];
            this.txtbRazonSocial.Location = new System.Drawing.Point(391, 38);
            this.txtbRazonSocial.Margin = new System.Windows.Forms.Padding(2);
            this.txtbRazonSocial.MaxLength = 32767;
            this.txtbRazonSocial.Name = "txtbRazonSocial";
            this.txtbRazonSocial.PasswordChar = '\0';
            this.txtbRazonSocial.ReadOnly = true;
            this.txtbRazonSocial.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtbRazonSocial.SelectedText = "";
            this.txtbRazonSocial.SelectionLength = 0;
            this.txtbRazonSocial.SelectionStart = 0;
            this.txtbRazonSocial.ShortcutsEnabled = true;
            this.txtbRazonSocial.Size = new System.Drawing.Size(225, 23);
            this.txtbRazonSocial.TabIndex = 9;
            this.txtbRazonSocial.UseSelectable = true;
            this.txtbRazonSocial.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtbRazonSocial.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.Location = new System.Drawing.Point(283, 40);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(104, 19);
            this.metroLabel4.TabIndex = 8;
            this.metroLabel4.Text = "Razón Social";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtbRutCliente
            // 
            // 
            // 
            // 
            this.txtbRutCliente.CustomButton.Image = null;
            this.txtbRutCliente.CustomButton.Location = new System.Drawing.Point(122, 1);
            this.txtbRutCliente.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtbRutCliente.CustomButton.Name = "";
            this.txtbRutCliente.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtbRutCliente.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtbRutCliente.CustomButton.TabIndex = 1;
            this.txtbRutCliente.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtbRutCliente.CustomButton.UseSelectable = true;
            this.txtbRutCliente.CustomButton.Visible = false;
            this.txtbRutCliente.Enabled = false;
            this.txtbRutCliente.Lines = new string[0];
            this.txtbRutCliente.Location = new System.Drawing.Point(119, 36);
            this.txtbRutCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtbRutCliente.MaxLength = 32767;
            this.txtbRutCliente.Name = "txtbRutCliente";
            this.txtbRutCliente.PasswordChar = '\0';
            this.txtbRutCliente.ReadOnly = true;
            this.txtbRutCliente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtbRutCliente.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtbRutCliente.SelectedText = "";
            this.txtbRutCliente.SelectionLength = 0;
            this.txtbRutCliente.SelectionStart = 0;
            this.txtbRutCliente.ShortcutsEnabled = true;
            this.txtbRutCliente.Size = new System.Drawing.Size(144, 23);
            this.txtbRutCliente.TabIndex = 7;
            this.txtbRutCliente.UseSelectable = true;
            this.txtbRutCliente.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtbRutCliente.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.Location = new System.Drawing.Point(-3, 38);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(118, 19);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "RUT Cliente";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel2
            // 
            this.metroLabel2.Location = new System.Drawing.Point(258, 10);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(129, 20);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Fecha";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtbIDProcesoVenta
            // 
            // 
            // 
            // 
            this.txtbIDProcesoVenta.CustomButton.Image = null;
            this.txtbIDProcesoVenta.CustomButton.Location = new System.Drawing.Point(30, 1);
            this.txtbIDProcesoVenta.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtbIDProcesoVenta.CustomButton.Name = "";
            this.txtbIDProcesoVenta.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtbIDProcesoVenta.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtbIDProcesoVenta.CustomButton.TabIndex = 1;
            this.txtbIDProcesoVenta.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtbIDProcesoVenta.CustomButton.UseSelectable = true;
            this.txtbIDProcesoVenta.CustomButton.Visible = false;
            this.txtbIDProcesoVenta.Enabled = false;
            this.txtbIDProcesoVenta.Lines = new string[0];
            this.txtbIDProcesoVenta.Location = new System.Drawing.Point(119, 9);
            this.txtbIDProcesoVenta.Margin = new System.Windows.Forms.Padding(2);
            this.txtbIDProcesoVenta.MaxLength = 32767;
            this.txtbIDProcesoVenta.Name = "txtbIDProcesoVenta";
            this.txtbIDProcesoVenta.PasswordChar = '\0';
            this.txtbIDProcesoVenta.ReadOnly = true;
            this.txtbIDProcesoVenta.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtbIDProcesoVenta.SelectedText = "";
            this.txtbIDProcesoVenta.SelectionLength = 0;
            this.txtbIDProcesoVenta.SelectionStart = 0;
            this.txtbIDProcesoVenta.ShortcutsEnabled = true;
            this.txtbIDProcesoVenta.Size = new System.Drawing.Size(52, 23);
            this.txtbIDProcesoVenta.TabIndex = 3;
            this.txtbIDProcesoVenta.UseSelectable = true;
            this.txtbIDProcesoVenta.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtbIDProcesoVenta.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.Location = new System.Drawing.Point(-3, 11);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(118, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Cod. Identificador";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // vVentasExternas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroTabControl1);
            this.Name = "vVentasExternas";
            this.Size = new System.Drawing.Size(656, 441);
            this.Load += new System.EventHandler(this.vVentasExternas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaVentas)).EndInit();
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabProcesosVenta.ResumeLayout(false);
            this.metroTabDetallePV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleProcesoVenta)).EndInit();
            this.ResumeLayout(false);

        }

        private MetroFramework.Controls.MetroDateTime mdtFechaEmisionPV;

        private MetroFramework.Controls.MetroTextBox txtbObservacionesPV;

        private MetroFramework.Controls.MetroLabel metroLabel7;

        private MetroFramework.Controls.MetroTextBox txtbEstado;

        private MetroFramework.Controls.MetroLabel metroLabel6;

        private MetroFramework.Controls.MetroTextBox txtbEmpresaTransporte;

        private MetroFramework.Controls.MetroLabel metroLabel5;

        private MetroFramework.Controls.MetroTextBox txtbRazonSocial;

        private MetroFramework.Controls.MetroLabel metroLabel4;

        private MetroFramework.Controls.MetroTextBox txtbRutCliente;

        private MetroFramework.Controls.MetroLabel metroLabel3;

        private MetroFramework.Controls.MetroLabel metroLabel2;

        private MetroFramework.Controls.MetroTextBox txtbIDProcesoVenta;

        private MetroFramework.Controls.MetroLabel metroLabel1;

        private MetroFramework.Controls.MetroTabPage metroTabDetallePV;

        private MetroFramework.Controls.MetroButton metroButtonDetallesPV;

        private MetroFramework.Controls.MetroTabPage metroTabProcesosVenta;

        private MetroFramework.Controls.MetroTabControl metroTabControl1;

        private MetroFramework.Controls.MetroGrid dgvListaVentas;

        #endregion

        private MetroFramework.Controls.MetroButton btnActualizar;
        private MetroFramework.Controls.MetroButton btnExportar;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroGrid dgvDetalleProcesoVenta;
        private MetroFramework.Controls.MetroButton btnTransporte;
    }
}
