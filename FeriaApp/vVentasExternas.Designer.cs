﻿namespace FeriaApp
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
            this.dgvListaVentas = new MetroFramework.Controls.MetroGrid();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabProcesosVenta = new MetroFramework.Controls.MetroTabPage();
            this.metroButtonDetallesPV = new MetroFramework.Controls.MetroButton();
            this.metroTabDetallePV = new MetroFramework.Controls.MetroTabPage();
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
            this.dgvListaVentas.Location = new System.Drawing.Point(3, 26);
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
            this.dgvListaVentas.Size = new System.Drawing.Size(849, 312);
            this.dgvListaVentas.TabIndex = 2;
            this.dgvListaVentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaVentas_CellContentClick);
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabProcesosVenta);
            this.metroTabControl1.Controls.Add(this.metroTabDetallePV);
            this.metroTabControl1.Location = new System.Drawing.Point(8, 26);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(863, 513);
            this.metroTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.metroTabControl1.TabIndex = 3;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabProcesosVenta
            // 
            this.metroTabProcesosVenta.Controls.Add(this.metroButtonDetallesPV);
            this.metroTabProcesosVenta.Controls.Add(this.dgvListaVentas);
            this.metroTabProcesosVenta.HorizontalScrollbarBarColor = true;
            this.metroTabProcesosVenta.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabProcesosVenta.HorizontalScrollbarSize = 10;
            this.metroTabProcesosVenta.Location = new System.Drawing.Point(4, 38);
            this.metroTabProcesosVenta.Name = "metroTabProcesosVenta";
            this.metroTabProcesosVenta.Size = new System.Drawing.Size(855, 471);
            this.metroTabProcesosVenta.TabIndex = 0;
            this.metroTabProcesosVenta.Text = "Procesos de Venta";
            this.metroTabProcesosVenta.VerticalScrollbarBarColor = true;
            this.metroTabProcesosVenta.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabProcesosVenta.VerticalScrollbarSize = 10;
            // 
            // metroButtonDetallesPV
            // 
            this.metroButtonDetallesPV.Location = new System.Drawing.Point(279, 378);
            this.metroButtonDetallesPV.Name = "metroButtonDetallesPV";
            this.metroButtonDetallesPV.Size = new System.Drawing.Size(259, 64);
            this.metroButtonDetallesPV.TabIndex = 3;
            this.metroButtonDetallesPV.Text = "Ver Detalles";
            this.metroButtonDetallesPV.UseSelectable = true;
            this.metroButtonDetallesPV.Click += new System.EventHandler(this.metroButtonDetallesPV_Click);
            // 
            // metroTabDetallePV
            // 
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
            this.metroTabDetallePV.HorizontalScrollbarSize = 10;
            this.metroTabDetallePV.Location = new System.Drawing.Point(4, 38);
            this.metroTabDetallePV.Name = "metroTabDetallePV";
            this.metroTabDetallePV.Size = new System.Drawing.Size(855, 471);
            this.metroTabDetallePV.TabIndex = 1;
            this.metroTabDetallePV.Text = "Detalle Venta";
            this.metroTabDetallePV.VerticalScrollbarBarColor = true;
            this.metroTabDetallePV.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabDetallePV.VerticalScrollbarSize = 10;
            // 
            // mdtFechaEmisionPV
            // 
            this.mdtFechaEmisionPV.Cursor = System.Windows.Forms.Cursors.No;
            this.mdtFechaEmisionPV.Enabled = false;
            this.mdtFechaEmisionPV.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.mdtFechaEmisionPV.Location = new System.Drawing.Point(501, 30);
            this.mdtFechaEmisionPV.MinimumSize = new System.Drawing.Size(0, 30);
            this.mdtFechaEmisionPV.Name = "mdtFechaEmisionPV";
            this.mdtFechaEmisionPV.Size = new System.Drawing.Size(303, 30);
            this.mdtFechaEmisionPV.TabIndex = 16;
            // 
            // txtbObservacionesPV
            // 
            // 
            // 
            // 
            this.txtbObservacionesPV.CustomButton.Image = null;
            this.txtbObservacionesPV.CustomButton.Location = new System.Drawing.Point(637, 1);
            this.txtbObservacionesPV.CustomButton.Name = "";
            this.txtbObservacionesPV.CustomButton.Size = new System.Drawing.Size(103, 103);
            this.txtbObservacionesPV.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtbObservacionesPV.CustomButton.TabIndex = 1;
            this.txtbObservacionesPV.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtbObservacionesPV.CustomButton.UseSelectable = true;
            this.txtbObservacionesPV.CustomButton.Visible = false;
            this.txtbObservacionesPV.Enabled = false;
            this.txtbObservacionesPV.Lines = new string[0];
            this.txtbObservacionesPV.Location = new System.Drawing.Point(20, 213);
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
            this.txtbObservacionesPV.Size = new System.Drawing.Size(741, 105);
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
            this.metroLabel7.Location = new System.Drawing.Point(20, 187);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(182, 23);
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
            this.txtbEstado.CustomButton.Location = new System.Drawing.Point(274, 2);
            this.txtbEstado.CustomButton.Name = "";
            this.txtbEstado.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtbEstado.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtbEstado.CustomButton.TabIndex = 1;
            this.txtbEstado.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtbEstado.CustomButton.UseSelectable = true;
            this.txtbEstado.CustomButton.Visible = false;
            this.txtbEstado.Enabled = false;
            this.txtbEstado.Lines = new string[0];
            this.txtbEstado.Location = new System.Drawing.Point(504, 137);
            this.txtbEstado.MaxLength = 32767;
            this.txtbEstado.Name = "txtbEstado";
            this.txtbEstado.PasswordChar = '\0';
            this.txtbEstado.ReadOnly = true;
            this.txtbEstado.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtbEstado.SelectedText = "";
            this.txtbEstado.SelectionLength = 0;
            this.txtbEstado.SelectionStart = 0;
            this.txtbEstado.ShortcutsEnabled = true;
            this.txtbEstado.Size = new System.Drawing.Size(300, 28);
            this.txtbEstado.TabIndex = 13;
            this.txtbEstado.UseSelectable = true;
            this.txtbEstado.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtbEstado.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.Location = new System.Drawing.Point(357, 136);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(139, 23);
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
            this.txtbEmpresaTransporte.CustomButton.Location = new System.Drawing.Point(166, 2);
            this.txtbEmpresaTransporte.CustomButton.Name = "";
            this.txtbEmpresaTransporte.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtbEmpresaTransporte.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtbEmpresaTransporte.CustomButton.TabIndex = 1;
            this.txtbEmpresaTransporte.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtbEmpresaTransporte.CustomButton.UseSelectable = true;
            this.txtbEmpresaTransporte.CustomButton.Visible = false;
            this.txtbEmpresaTransporte.Enabled = false;
            this.txtbEmpresaTransporte.Lines = new string[0];
            this.txtbEmpresaTransporte.Location = new System.Drawing.Point(159, 137);
            this.txtbEmpresaTransporte.MaxLength = 32767;
            this.txtbEmpresaTransporte.Name = "txtbEmpresaTransporte";
            this.txtbEmpresaTransporte.PasswordChar = '\0';
            this.txtbEmpresaTransporte.ReadOnly = true;
            this.txtbEmpresaTransporte.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtbEmpresaTransporte.SelectedText = "";
            this.txtbEmpresaTransporte.SelectionLength = 0;
            this.txtbEmpresaTransporte.SelectionStart = 0;
            this.txtbEmpresaTransporte.ShortcutsEnabled = true;
            this.txtbEmpresaTransporte.Size = new System.Drawing.Size(192, 28);
            this.txtbEmpresaTransporte.TabIndex = 11;
            this.txtbEmpresaTransporte.UseSelectable = true;
            this.txtbEmpresaTransporte.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtbEmpresaTransporte.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.Location = new System.Drawing.Point(3, 136);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(150, 23);
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
            this.txtbRazonSocial.CustomButton.Location = new System.Drawing.Point(274, 2);
            this.txtbRazonSocial.CustomButton.Name = "";
            this.txtbRazonSocial.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtbRazonSocial.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtbRazonSocial.CustomButton.TabIndex = 1;
            this.txtbRazonSocial.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtbRazonSocial.CustomButton.UseSelectable = true;
            this.txtbRazonSocial.CustomButton.Visible = false;
            this.txtbRazonSocial.Enabled = false;
            this.txtbRazonSocial.Lines = new string[0];
            this.txtbRazonSocial.Location = new System.Drawing.Point(504, 81);
            this.txtbRazonSocial.MaxLength = 32767;
            this.txtbRazonSocial.Name = "txtbRazonSocial";
            this.txtbRazonSocial.PasswordChar = '\0';
            this.txtbRazonSocial.ReadOnly = true;
            this.txtbRazonSocial.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtbRazonSocial.SelectedText = "";
            this.txtbRazonSocial.SelectionLength = 0;
            this.txtbRazonSocial.SelectionStart = 0;
            this.txtbRazonSocial.ShortcutsEnabled = true;
            this.txtbRazonSocial.Size = new System.Drawing.Size(300, 28);
            this.txtbRazonSocial.TabIndex = 9;
            this.txtbRazonSocial.UseSelectable = true;
            this.txtbRazonSocial.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtbRazonSocial.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.Location = new System.Drawing.Point(357, 81);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(139, 23);
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
            this.txtbRutCliente.CustomButton.Location = new System.Drawing.Point(166, 2);
            this.txtbRutCliente.CustomButton.Name = "";
            this.txtbRutCliente.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtbRutCliente.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtbRutCliente.CustomButton.TabIndex = 1;
            this.txtbRutCliente.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtbRutCliente.CustomButton.UseSelectable = true;
            this.txtbRutCliente.CustomButton.Visible = false;
            this.txtbRutCliente.Enabled = false;
            this.txtbRutCliente.Lines = new string[0];
            this.txtbRutCliente.Location = new System.Drawing.Point(159, 81);
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
            this.txtbRutCliente.Size = new System.Drawing.Size(192, 28);
            this.txtbRutCliente.TabIndex = 7;
            this.txtbRutCliente.UseSelectable = true;
            this.txtbRutCliente.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtbRutCliente.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.Location = new System.Drawing.Point(-4, 81);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(157, 23);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "RUT Cliente";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel2
            // 
            this.metroLabel2.Location = new System.Drawing.Point(304, 34);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(172, 24);
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
            this.txtbIDProcesoVenta.CustomButton.Location = new System.Drawing.Point(44, 2);
            this.txtbIDProcesoVenta.CustomButton.Name = "";
            this.txtbIDProcesoVenta.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtbIDProcesoVenta.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtbIDProcesoVenta.CustomButton.TabIndex = 1;
            this.txtbIDProcesoVenta.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtbIDProcesoVenta.CustomButton.UseSelectable = true;
            this.txtbIDProcesoVenta.CustomButton.Visible = false;
            this.txtbIDProcesoVenta.Enabled = false;
            this.txtbIDProcesoVenta.Lines = new string[0];
            this.txtbIDProcesoVenta.Location = new System.Drawing.Point(158, 30);
            this.txtbIDProcesoVenta.MaxLength = 32767;
            this.txtbIDProcesoVenta.Name = "txtbIDProcesoVenta";
            this.txtbIDProcesoVenta.PasswordChar = '\0';
            this.txtbIDProcesoVenta.ReadOnly = true;
            this.txtbIDProcesoVenta.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtbIDProcesoVenta.SelectedText = "";
            this.txtbIDProcesoVenta.SelectionLength = 0;
            this.txtbIDProcesoVenta.SelectionStart = 0;
            this.txtbIDProcesoVenta.ShortcutsEnabled = true;
            this.txtbIDProcesoVenta.Size = new System.Drawing.Size(70, 28);
            this.txtbIDProcesoVenta.TabIndex = 3;
            this.txtbIDProcesoVenta.UseSelectable = true;
            this.txtbIDProcesoVenta.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtbIDProcesoVenta.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.Location = new System.Drawing.Point(-4, 30);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(157, 23);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Cod. Identificador";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // vVentasExternas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroTabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "vVentasExternas";
            this.Size = new System.Drawing.Size(875, 543);
            this.Load += new System.EventHandler(this.vVentasExternas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaVentas)).EndInit();
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabProcesosVenta.ResumeLayout(false);
            this.metroTabDetallePV.ResumeLayout(false);
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
    }
}
