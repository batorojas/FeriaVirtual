﻿namespace FeriaApp
{
    partial class vContratos
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
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabContratos = new MetroFramework.Controls.MetroTabPage();
            this.buttonEliminarContrato = new MetroFramework.Controls.MetroButton();
            this.metroGridListaContratos = new MetroFramework.Controls.MetroGrid();
            this.metroTabPageCrearContrato = new MetroFramework.Controls.MetroTabPage();
            this.buttonCrearContrato = new MetroFramework.Controls.MetroButton();
            this.metroTextRutProductorContrato = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroFechaInicioContrato = new MetroFramework.Controls.MetroDateTime();
            this.metroFechaTerminoContrato = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTabModificarContrato = new MetroFramework.Controls.MetroTabPage();
            this.buttonModificarContrato = new MetroFramework.Controls.MetroButton();
            this.textModificarRPContrato = new MetroFramework.Controls.MetroTextBox();
            this.dateModificarFechaTermino = new MetroFramework.Controls.MetroDateTime();
            this.dateModificarFechaInicio = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroTabControl1.SuspendLayout();
            this.metroTabContratos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridListaContratos)).BeginInit();
            this.metroTabPageCrearContrato.SuspendLayout();
            this.metroTabModificarContrato.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabContratos);
            this.metroTabControl1.Controls.Add(this.metroTabPageCrearContrato);
            this.metroTabControl1.Controls.Add(this.metroTabModificarContrato);
            this.metroTabControl1.Location = new System.Drawing.Point(3, 23);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 2;
            this.metroTabControl1.Size = new System.Drawing.Size(799, 520);
            this.metroTabControl1.TabIndex = 3;
            this.metroTabControl1.UseSelectable = true;
            this.metroTabControl1.SelectedIndexChanged += new System.EventHandler(this.metroTabControl1_SelectedIndexChanged);
            // 
            // metroTabContratos
            // 
            this.metroTabContratos.Controls.Add(this.buttonEliminarContrato);
            this.metroTabContratos.Controls.Add(this.metroGridListaContratos);
            this.metroTabContratos.HorizontalScrollbarBarColor = true;
            this.metroTabContratos.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabContratos.HorizontalScrollbarSize = 10;
            this.metroTabContratos.Location = new System.Drawing.Point(4, 38);
            this.metroTabContratos.Name = "metroTabContratos";
            this.metroTabContratos.Size = new System.Drawing.Size(791, 478);
            this.metroTabContratos.TabIndex = 0;
            this.metroTabContratos.Text = "Contratos";
            this.metroTabContratos.VerticalScrollbarBarColor = true;
            this.metroTabContratos.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabContratos.VerticalScrollbarSize = 10;
            // 
            // buttonEliminarContrato
            // 
            this.buttonEliminarContrato.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEliminarContrato.Location = new System.Drawing.Point(139, 237);
            this.buttonEliminarContrato.Name = "buttonEliminarContrato";
            this.buttonEliminarContrato.Size = new System.Drawing.Size(151, 56);
            this.buttonEliminarContrato.TabIndex = 3;
            this.buttonEliminarContrato.Text = "Eliminar";
            this.buttonEliminarContrato.UseSelectable = true;
            this.buttonEliminarContrato.Click += new System.EventHandler(this.buttonEliminarContrato_Click);
            // 
            // metroGridListaContratos
            // 
            this.metroGridListaContratos.AllowUserToResizeRows = false;
            this.metroGridListaContratos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridListaContratos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridListaContratos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGridListaContratos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridListaContratos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGridListaContratos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridListaContratos.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGridListaContratos.EnableHeadersVisualStyles = false;
            this.metroGridListaContratos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridListaContratos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridListaContratos.Location = new System.Drawing.Point(3, 20);
            this.metroGridListaContratos.Name = "metroGridListaContratos";
            this.metroGridListaContratos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridListaContratos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGridListaContratos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridListaContratos.RowTemplate.Height = 24;
            this.metroGridListaContratos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridListaContratos.Size = new System.Drawing.Size(682, 190);
            this.metroGridListaContratos.TabIndex = 2;
            this.metroGridListaContratos.SelectionChanged += new System.EventHandler(this.metroGridListaContratos_SelectionChanged);
            // 
            // metroTabPageCrearContrato
            // 
            this.metroTabPageCrearContrato.Controls.Add(this.buttonCrearContrato);
            this.metroTabPageCrearContrato.Controls.Add(this.metroTextRutProductorContrato);
            this.metroTabPageCrearContrato.Controls.Add(this.metroLabel3);
            this.metroTabPageCrearContrato.Controls.Add(this.metroFechaInicioContrato);
            this.metroTabPageCrearContrato.Controls.Add(this.metroFechaTerminoContrato);
            this.metroTabPageCrearContrato.Controls.Add(this.metroLabel2);
            this.metroTabPageCrearContrato.Controls.Add(this.metroLabel1);
            this.metroTabPageCrearContrato.HorizontalScrollbarBarColor = true;
            this.metroTabPageCrearContrato.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPageCrearContrato.HorizontalScrollbarSize = 10;
            this.metroTabPageCrearContrato.Location = new System.Drawing.Point(4, 38);
            this.metroTabPageCrearContrato.Name = "metroTabPageCrearContrato";
            this.metroTabPageCrearContrato.Size = new System.Drawing.Size(791, 478);
            this.metroTabPageCrearContrato.TabIndex = 1;
            this.metroTabPageCrearContrato.Text = "Añadir Contrato";
            this.metroTabPageCrearContrato.VerticalScrollbarBarColor = true;
            this.metroTabPageCrearContrato.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPageCrearContrato.VerticalScrollbarSize = 10;
            // 
            // buttonCrearContrato
            // 
            this.buttonCrearContrato.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCrearContrato.ForeColor = System.Drawing.Color.Coral;
            this.buttonCrearContrato.Location = new System.Drawing.Point(121, 221);
            this.buttonCrearContrato.Name = "buttonCrearContrato";
            this.buttonCrearContrato.Size = new System.Drawing.Size(150, 57);
            this.buttonCrearContrato.TabIndex = 9;
            this.buttonCrearContrato.Text = "Añadir";
            this.buttonCrearContrato.UseSelectable = true;
            this.buttonCrearContrato.Click += new System.EventHandler(this.buttonCrearContrato_Click);
            // 
            // metroTextRutProductorContrato
            // 
            // 
            // 
            // 
            this.metroTextRutProductorContrato.CustomButton.Image = null;
            this.metroTextRutProductorContrato.CustomButton.Location = new System.Drawing.Point(251, 2);
            this.metroTextRutProductorContrato.CustomButton.Name = "";
            this.metroTextRutProductorContrato.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.metroTextRutProductorContrato.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextRutProductorContrato.CustomButton.TabIndex = 1;
            this.metroTextRutProductorContrato.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextRutProductorContrato.CustomButton.UseSelectable = true;
            this.metroTextRutProductorContrato.CustomButton.Visible = false;
            this.metroTextRutProductorContrato.Lines = new string[0];
            this.metroTextRutProductorContrato.Location = new System.Drawing.Point(121, 156);
            this.metroTextRutProductorContrato.MaxLength = 32767;
            this.metroTextRutProductorContrato.Name = "metroTextRutProductorContrato";
            this.metroTextRutProductorContrato.PasswordChar = '\0';
            this.metroTextRutProductorContrato.PromptText = "Sin puntos ni dígito verificador";
            this.metroTextRutProductorContrato.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextRutProductorContrato.SelectedText = "";
            this.metroTextRutProductorContrato.SelectionLength = 0;
            this.metroTextRutProductorContrato.SelectionStart = 0;
            this.metroTextRutProductorContrato.ShortcutsEnabled = true;
            this.metroTextRutProductorContrato.ShowClearButton = true;
            this.metroTextRutProductorContrato.Size = new System.Drawing.Size(279, 30);
            this.metroTextRutProductorContrato.TabIndex = 8;
            this.metroTextRutProductorContrato.UseSelectable = true;
            this.metroTextRutProductorContrato.WaterMark = "Sin puntos ni dígito verificador";
            this.metroTextRutProductorContrato.WaterMarkColor = System.Drawing.Color.Gray;
            this.metroTextRutProductorContrato.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.Location = new System.Drawing.Point(8, 156);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(100, 23);
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "Rut Productor";
            // 
            // metroFechaInicioContrato
            // 
            this.metroFechaInicioContrato.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.metroFechaInicioContrato.ImeMode = System.Windows.Forms.ImeMode.On;
            this.metroFechaInicioContrato.Location = new System.Drawing.Point(121, 46);
            this.metroFechaInicioContrato.MinimumSize = new System.Drawing.Size(4, 30);
            this.metroFechaInicioContrato.Name = "metroFechaInicioContrato";
            this.metroFechaInicioContrato.Size = new System.Drawing.Size(279, 30);
            this.metroFechaInicioContrato.TabIndex = 6;
            this.metroFechaInicioContrato.ValueChanged += new System.EventHandler(this.metroDateTime2_ValueChanged);
            // 
            // metroFechaTerminoContrato
            // 
            this.metroFechaTerminoContrato.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.metroFechaTerminoContrato.ImeMode = System.Windows.Forms.ImeMode.On;
            this.metroFechaTerminoContrato.Location = new System.Drawing.Point(121, 98);
            this.metroFechaTerminoContrato.MinimumSize = new System.Drawing.Size(4, 30);
            this.metroFechaTerminoContrato.Name = "metroFechaTerminoContrato";
            this.metroFechaTerminoContrato.Size = new System.Drawing.Size(279, 30);
            this.metroFechaTerminoContrato.TabIndex = 5;
            // 
            // metroLabel2
            // 
            this.metroLabel2.Location = new System.Drawing.Point(8, 105);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(100, 23);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Fecha Termino";
            // 
            // metroLabel1
            // 
            this.metroLabel1.Location = new System.Drawing.Point(8, 53);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(95, 23);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Fecha Inicio";
            // 
            // metroTabModificarContrato
            // 
            this.metroTabModificarContrato.Controls.Add(this.buttonModificarContrato);
            this.metroTabModificarContrato.Controls.Add(this.textModificarRPContrato);
            this.metroTabModificarContrato.Controls.Add(this.dateModificarFechaTermino);
            this.metroTabModificarContrato.Controls.Add(this.dateModificarFechaInicio);
            this.metroTabModificarContrato.Controls.Add(this.metroLabel6);
            this.metroTabModificarContrato.Controls.Add(this.metroLabel5);
            this.metroTabModificarContrato.Controls.Add(this.metroLabel4);
            this.metroTabModificarContrato.HorizontalScrollbarBarColor = true;
            this.metroTabModificarContrato.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabModificarContrato.HorizontalScrollbarSize = 10;
            this.metroTabModificarContrato.Location = new System.Drawing.Point(4, 38);
            this.metroTabModificarContrato.Name = "metroTabModificarContrato";
            this.metroTabModificarContrato.Size = new System.Drawing.Size(791, 478);
            this.metroTabModificarContrato.TabIndex = 2;
            this.metroTabModificarContrato.Text = "Modificar Contrato";
            this.metroTabModificarContrato.VerticalScrollbarBarColor = true;
            this.metroTabModificarContrato.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabModificarContrato.VerticalScrollbarSize = 10;
            // 
            // buttonModificarContrato
            // 
            this.buttonModificarContrato.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonModificarContrato.ForeColor = System.Drawing.Color.Coral;
            this.buttonModificarContrato.Location = new System.Drawing.Point(119, 236);
            this.buttonModificarContrato.Name = "buttonModificarContrato";
            this.buttonModificarContrato.Size = new System.Drawing.Size(150, 57);
            this.buttonModificarContrato.TabIndex = 10;
            this.buttonModificarContrato.Text = "Actualizar";
            this.buttonModificarContrato.UseSelectable = true;
            this.buttonModificarContrato.Click += new System.EventHandler(this.buttonModificarContrato_Click);
            // 
            // textModificarRPContrato
            // 
            // 
            // 
            // 
            this.textModificarRPContrato.CustomButton.Image = null;
            this.textModificarRPContrato.CustomButton.Location = new System.Drawing.Point(251, 2);
            this.textModificarRPContrato.CustomButton.Name = "";
            this.textModificarRPContrato.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.textModificarRPContrato.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textModificarRPContrato.CustomButton.TabIndex = 1;
            this.textModificarRPContrato.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textModificarRPContrato.CustomButton.UseSelectable = true;
            this.textModificarRPContrato.CustomButton.Visible = false;
            this.textModificarRPContrato.Lines = new string[0];
            this.textModificarRPContrato.Location = new System.Drawing.Point(119, 174);
            this.textModificarRPContrato.MaxLength = 32767;
            this.textModificarRPContrato.Name = "textModificarRPContrato";
            this.textModificarRPContrato.PasswordChar = '\0';
            this.textModificarRPContrato.PromptText = "Sin puntos ni dígito verificador";
            this.textModificarRPContrato.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textModificarRPContrato.SelectedText = "";
            this.textModificarRPContrato.SelectionLength = 0;
            this.textModificarRPContrato.SelectionStart = 0;
            this.textModificarRPContrato.ShortcutsEnabled = true;
            this.textModificarRPContrato.ShowClearButton = true;
            this.textModificarRPContrato.Size = new System.Drawing.Size(279, 30);
            this.textModificarRPContrato.TabIndex = 9;
            this.textModificarRPContrato.UseSelectable = true;
            this.textModificarRPContrato.WaterMark = "Sin puntos ni dígito verificador";
            this.textModificarRPContrato.WaterMarkColor = System.Drawing.Color.Gray;
            this.textModificarRPContrato.WaterMarkFont = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // dateModificarFechaTermino
            // 
            this.dateModificarFechaTermino.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateModificarFechaTermino.Location = new System.Drawing.Point(119, 119);
            this.dateModificarFechaTermino.MinimumSize = new System.Drawing.Size(0, 30);
            this.dateModificarFechaTermino.Name = "dateModificarFechaTermino";
            this.dateModificarFechaTermino.Size = new System.Drawing.Size(278, 30);
            this.dateModificarFechaTermino.TabIndex = 6;
            // 
            // dateModificarFechaInicio
            // 
            this.dateModificarFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateModificarFechaInicio.Location = new System.Drawing.Point(120, 61);
            this.dateModificarFechaInicio.MinimumSize = new System.Drawing.Size(0, 30);
            this.dateModificarFechaInicio.Name = "dateModificarFechaInicio";
            this.dateModificarFechaInicio.Size = new System.Drawing.Size(278, 30);
            this.dateModificarFechaInicio.TabIndex = 5;
            // 
            // metroLabel6
            // 
            this.metroLabel6.Location = new System.Drawing.Point(6, 183);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(100, 21);
            this.metroLabel6.TabIndex = 4;
            this.metroLabel6.Text = "Rut Productor";
            // 
            // metroLabel5
            // 
            this.metroLabel5.Location = new System.Drawing.Point(6, 128);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(100, 21);
            this.metroLabel5.TabIndex = 3;
            this.metroLabel5.Text = "Fecha Término";
            // 
            // metroLabel4
            // 
            this.metroLabel4.Location = new System.Drawing.Point(13, 70);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(93, 21);
            this.metroLabel4.TabIndex = 2;
            this.metroLabel4.Text = "Fecha Inicio";
            // 
            // vContratos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroTabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "vContratos";
            this.Size = new System.Drawing.Size(805, 543);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabContratos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroGridListaContratos)).EndInit();
            this.metroTabPageCrearContrato.ResumeLayout(false);
            this.metroTabModificarContrato.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private MetroFramework.Controls.MetroButton buttonModificarContrato;

        private MetroFramework.Controls.MetroTextBox textModificarRPContrato;

        private MetroFramework.Controls.MetroDateTime dateModificarFechaTermino;

        private MetroFramework.Controls.MetroDateTime dateModificarFechaInicio;

        private MetroFramework.Controls.MetroLabel metroLabel6;

        private MetroFramework.Controls.MetroLabel metroLabel5;

        private MetroFramework.Controls.MetroLabel metroLabel4;

        private MetroFramework.Controls.MetroButton buttonEliminarContrato;

        private MetroFramework.Controls.MetroButton buttonCrearContrato;

        private MetroFramework.Controls.MetroTextBox metroTextRutProductorContrato;

        private MetroFramework.Controls.MetroDateTime metroFechaInicioContrato;
        private MetroFramework.Controls.MetroLabel metroLabel3;

        private MetroFramework.Controls.MetroLabel metroLabel2;

        private MetroFramework.Controls.MetroDateTime metroFechaTerminoContrato;

        private MetroFramework.Controls.MetroLabel metroLabel1;

        private MetroFramework.Controls.MetroGrid metroGridListaContratos;

        private MetroFramework.Controls.MetroTabPage metroTabModificarContrato;

        private MetroFramework.Controls.MetroTabPage metroTabPageCrearContrato;

        private MetroFramework.Controls.MetroTabPage metroTabContratos;

        private MetroFramework.Controls.MetroTabControl metroTabControl1;

        #endregion
    }
}
