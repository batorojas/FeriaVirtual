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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabContratos = new MetroFramework.Controls.MetroTabPage();
            this.metroButtonModificarContrato = new MetroFramework.Controls.MetroButton();
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
            this.txtbIdProductor = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.buttonModificarContrato = new MetroFramework.Controls.MetroButton();
            this.textbRutProductorContrato = new MetroFramework.Controls.MetroTextBox();
            this.dateFechaTerminoContrato = new MetroFramework.Controls.MetroDateTime();
            this.dateFechaInicioContrato = new MetroFramework.Controls.MetroDateTime();
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
            this.metroTabControl1.Location = new System.Drawing.Point(2, 19);
            this.metroTabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(599, 422);
            this.metroTabControl1.TabIndex = 3;
            this.metroTabControl1.UseSelectable = true;
            this.metroTabControl1.SelectedIndexChanged += new System.EventHandler(this.metroTabControl1_SelectedIndexChanged);
            // 
            // metroTabContratos
            // 
            this.metroTabContratos.Controls.Add(this.metroButtonModificarContrato);
            this.metroTabContratos.Controls.Add(this.buttonEliminarContrato);
            this.metroTabContratos.Controls.Add(this.metroGridListaContratos);
            this.metroTabContratos.HorizontalScrollbarBarColor = true;
            this.metroTabContratos.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabContratos.HorizontalScrollbarSize = 8;
            this.metroTabContratos.Location = new System.Drawing.Point(4, 38);
            this.metroTabContratos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.metroTabContratos.Name = "metroTabContratos";
            this.metroTabContratos.Size = new System.Drawing.Size(591, 380);
            this.metroTabContratos.TabIndex = 0;
            this.metroTabContratos.Text = "Contratos";
            this.metroTabContratos.VerticalScrollbarBarColor = true;
            this.metroTabContratos.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabContratos.VerticalScrollbarSize = 8;
            // 
            // metroButtonModificarContrato
            // 
            this.metroButtonModificarContrato.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroButtonModificarContrato.Location = new System.Drawing.Point(304, 193);
            this.metroButtonModificarContrato.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.metroButtonModificarContrato.Name = "metroButtonModificarContrato";
            this.metroButtonModificarContrato.Size = new System.Drawing.Size(113, 46);
            this.metroButtonModificarContrato.TabIndex = 4;
            this.metroButtonModificarContrato.Text = "Actualizar";
            this.metroButtonModificarContrato.UseSelectable = true;
            this.metroButtonModificarContrato.Click += new System.EventHandler(this.metroButtonModificarContrato_Click);
            // 
            // buttonEliminarContrato
            // 
            this.buttonEliminarContrato.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEliminarContrato.Location = new System.Drawing.Point(104, 193);
            this.buttonEliminarContrato.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonEliminarContrato.Name = "buttonEliminarContrato";
            this.buttonEliminarContrato.Size = new System.Drawing.Size(113, 46);
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridListaContratos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.metroGridListaContratos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridListaContratos.DefaultCellStyle = dataGridViewCellStyle5;
            this.metroGridListaContratos.EnableHeadersVisualStyles = false;
            this.metroGridListaContratos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridListaContratos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridListaContratos.Location = new System.Drawing.Point(2, 16);
            this.metroGridListaContratos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.metroGridListaContratos.Name = "metroGridListaContratos";
            this.metroGridListaContratos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridListaContratos.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.metroGridListaContratos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridListaContratos.RowTemplate.Height = 24;
            this.metroGridListaContratos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridListaContratos.Size = new System.Drawing.Size(512, 154);
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
            this.metroTabPageCrearContrato.HorizontalScrollbarSize = 8;
            this.metroTabPageCrearContrato.Location = new System.Drawing.Point(4, 38);
            this.metroTabPageCrearContrato.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.metroTabPageCrearContrato.Name = "metroTabPageCrearContrato";
            this.metroTabPageCrearContrato.Size = new System.Drawing.Size(591, 380);
            this.metroTabPageCrearContrato.TabIndex = 1;
            this.metroTabPageCrearContrato.Text = "Añadir Contrato";
            this.metroTabPageCrearContrato.VerticalScrollbarBarColor = true;
            this.metroTabPageCrearContrato.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPageCrearContrato.VerticalScrollbarSize = 8;
            // 
            // buttonCrearContrato
            // 
            this.buttonCrearContrato.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCrearContrato.ForeColor = System.Drawing.Color.Coral;
            this.buttonCrearContrato.Location = new System.Drawing.Point(91, 180);
            this.buttonCrearContrato.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCrearContrato.Name = "buttonCrearContrato";
            this.buttonCrearContrato.Size = new System.Drawing.Size(112, 46);
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
            this.metroTextRutProductorContrato.CustomButton.Location = new System.Drawing.Point(140, 2);
            this.metroTextRutProductorContrato.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.metroTextRutProductorContrato.CustomButton.Name = "";
            this.metroTextRutProductorContrato.CustomButton.Size = new System.Drawing.Size(14, 15);
            this.metroTextRutProductorContrato.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextRutProductorContrato.CustomButton.TabIndex = 1;
            this.metroTextRutProductorContrato.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextRutProductorContrato.CustomButton.UseSelectable = true;
            this.metroTextRutProductorContrato.CustomButton.Visible = false;
            this.metroTextRutProductorContrato.Lines = new string[0];
            this.metroTextRutProductorContrato.Location = new System.Drawing.Point(91, 127);
            this.metroTextRutProductorContrato.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.metroTextRutProductorContrato.Size = new System.Drawing.Size(209, 24);
            this.metroTextRutProductorContrato.TabIndex = 8;
            this.metroTextRutProductorContrato.UseSelectable = true;
            this.metroTextRutProductorContrato.WaterMark = "Sin puntos ni dígito verificador";
            this.metroTextRutProductorContrato.WaterMarkColor = System.Drawing.Color.Gray;
            this.metroTextRutProductorContrato.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.Location = new System.Drawing.Point(6, 127);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(75, 19);
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "Rut Productor";
            // 
            // metroFechaInicioContrato
            // 
            this.metroFechaInicioContrato.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.metroFechaInicioContrato.ImeMode = System.Windows.Forms.ImeMode.On;
            this.metroFechaInicioContrato.Location = new System.Drawing.Point(91, 37);
            this.metroFechaInicioContrato.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.metroFechaInicioContrato.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroFechaInicioContrato.Name = "metroFechaInicioContrato";
            this.metroFechaInicioContrato.Size = new System.Drawing.Size(210, 30);
            this.metroFechaInicioContrato.TabIndex = 6;
            this.metroFechaInicioContrato.Value = new System.DateTime(2023, 10, 21, 0, 29, 10, 0);
            this.metroFechaInicioContrato.ValueChanged += new System.EventHandler(this.metroDateTime2_ValueChanged);
            // 
            // metroFechaTerminoContrato
            // 
            this.metroFechaTerminoContrato.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.metroFechaTerminoContrato.ImeMode = System.Windows.Forms.ImeMode.On;
            this.metroFechaTerminoContrato.Location = new System.Drawing.Point(91, 80);
            this.metroFechaTerminoContrato.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.metroFechaTerminoContrato.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroFechaTerminoContrato.Name = "metroFechaTerminoContrato";
            this.metroFechaTerminoContrato.Size = new System.Drawing.Size(210, 30);
            this.metroFechaTerminoContrato.TabIndex = 5;
            // 
            // metroLabel2
            // 
            this.metroLabel2.Location = new System.Drawing.Point(6, 85);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(75, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Fecha Termino";
            // 
            // metroLabel1
            // 
            this.metroLabel1.Location = new System.Drawing.Point(6, 43);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(71, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Fecha Inicio";
            // 
            // metroTabModificarContrato
            // 
            this.metroTabModificarContrato.Controls.Add(this.txtbIdProductor);
            this.metroTabModificarContrato.Controls.Add(this.metroLabel7);
            this.metroTabModificarContrato.Controls.Add(this.buttonModificarContrato);
            this.metroTabModificarContrato.Controls.Add(this.textbRutProductorContrato);
            this.metroTabModificarContrato.Controls.Add(this.dateFechaTerminoContrato);
            this.metroTabModificarContrato.Controls.Add(this.dateFechaInicioContrato);
            this.metroTabModificarContrato.Controls.Add(this.metroLabel6);
            this.metroTabModificarContrato.Controls.Add(this.metroLabel5);
            this.metroTabModificarContrato.Controls.Add(this.metroLabel4);
            this.metroTabModificarContrato.HorizontalScrollbarBarColor = true;
            this.metroTabModificarContrato.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabModificarContrato.HorizontalScrollbarSize = 8;
            this.metroTabModificarContrato.Location = new System.Drawing.Point(4, 38);
            this.metroTabModificarContrato.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.metroTabModificarContrato.Name = "metroTabModificarContrato";
            this.metroTabModificarContrato.Size = new System.Drawing.Size(591, 380);
            this.metroTabModificarContrato.TabIndex = 2;
            this.metroTabModificarContrato.Text = "Modificar Contrato";
            this.metroTabModificarContrato.VerticalScrollbarBarColor = true;
            this.metroTabModificarContrato.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabModificarContrato.VerticalScrollbarSize = 8;
            // 
            // txtbIdProductor
            // 
            // 
            // 
            // 
            this.txtbIdProductor.CustomButton.Image = null;
            this.txtbIdProductor.CustomButton.Location = new System.Drawing.Point(141, 1);
            this.txtbIdProductor.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbIdProductor.CustomButton.Name = "";
            this.txtbIdProductor.CustomButton.Size = new System.Drawing.Size(14, 15);
            this.txtbIdProductor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtbIdProductor.CustomButton.TabIndex = 1;
            this.txtbIdProductor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtbIdProductor.CustomButton.UseSelectable = true;
            this.txtbIdProductor.CustomButton.Visible = false;
            this.txtbIdProductor.Enabled = false;
            this.txtbIdProductor.Lines = new string[0];
            this.txtbIdProductor.Location = new System.Drawing.Point(88, 23);
            this.txtbIdProductor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbIdProductor.MaxLength = 32767;
            this.txtbIdProductor.Name = "txtbIdProductor";
            this.txtbIdProductor.PasswordChar = '\0';
            this.txtbIdProductor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtbIdProductor.SelectedText = "";
            this.txtbIdProductor.SelectionLength = 0;
            this.txtbIdProductor.SelectionStart = 0;
            this.txtbIdProductor.ShortcutsEnabled = true;
            this.txtbIdProductor.Size = new System.Drawing.Size(208, 21);
            this.txtbIdProductor.TabIndex = 12;
            this.txtbIdProductor.UseSelectable = true;
            this.txtbIdProductor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtbIdProductor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.Location = new System.Drawing.Point(9, 27);
            this.metroLabel7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(86, 17);
            this.metroLabel7.TabIndex = 11;
            this.metroLabel7.Text = "ID Productor";
            // 
            // buttonModificarContrato
            // 
            this.buttonModificarContrato.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonModificarContrato.ForeColor = System.Drawing.Color.Coral;
            this.buttonModificarContrato.Location = new System.Drawing.Point(89, 192);
            this.buttonModificarContrato.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonModificarContrato.Name = "buttonModificarContrato";
            this.buttonModificarContrato.Size = new System.Drawing.Size(112, 46);
            this.buttonModificarContrato.TabIndex = 10;
            this.buttonModificarContrato.Text = "Actualizar";
            this.buttonModificarContrato.UseSelectable = true;
            this.buttonModificarContrato.Click += new System.EventHandler(this.buttonModificarContrato_Click);
            // 
            // textbRutProductorContrato
            // 
            // 
            // 
            // 
            this.textbRutProductorContrato.CustomButton.Image = null;
            this.textbRutProductorContrato.CustomButton.Location = new System.Drawing.Point(140, 2);
            this.textbRutProductorContrato.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textbRutProductorContrato.CustomButton.Name = "";
            this.textbRutProductorContrato.CustomButton.Size = new System.Drawing.Size(14, 15);
            this.textbRutProductorContrato.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textbRutProductorContrato.CustomButton.TabIndex = 1;
            this.textbRutProductorContrato.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textbRutProductorContrato.CustomButton.UseSelectable = true;
            this.textbRutProductorContrato.CustomButton.Visible = false;
            this.textbRutProductorContrato.Enabled = false;
            this.textbRutProductorContrato.Lines = new string[0];
            this.textbRutProductorContrato.Location = new System.Drawing.Point(88, 151);
            this.textbRutProductorContrato.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textbRutProductorContrato.MaxLength = 32767;
            this.textbRutProductorContrato.Name = "textbRutProductorContrato";
            this.textbRutProductorContrato.PasswordChar = '\0';
            this.textbRutProductorContrato.PromptText = "Sin puntos ni dígito verificador";
            this.textbRutProductorContrato.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textbRutProductorContrato.SelectedText = "";
            this.textbRutProductorContrato.SelectionLength = 0;
            this.textbRutProductorContrato.SelectionStart = 0;
            this.textbRutProductorContrato.ShortcutsEnabled = true;
            this.textbRutProductorContrato.ShowClearButton = true;
            this.textbRutProductorContrato.Size = new System.Drawing.Size(209, 24);
            this.textbRutProductorContrato.TabIndex = 9;
            this.textbRutProductorContrato.UseSelectable = true;
            this.textbRutProductorContrato.WaterMark = "Sin puntos ni dígito verificador";
            this.textbRutProductorContrato.WaterMarkColor = System.Drawing.Color.Gray;
            this.textbRutProductorContrato.WaterMarkFont = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // dateFechaTerminoContrato
            // 
            this.dateFechaTerminoContrato.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFechaTerminoContrato.Location = new System.Drawing.Point(88, 106);
            this.dateFechaTerminoContrato.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateFechaTerminoContrato.MinimumSize = new System.Drawing.Size(4, 30);
            this.dateFechaTerminoContrato.Name = "dateFechaTerminoContrato";
            this.dateFechaTerminoContrato.Size = new System.Drawing.Size(210, 30);
            this.dateFechaTerminoContrato.TabIndex = 6;
            this.dateFechaTerminoContrato.Value = new System.DateTime(2023, 10, 21, 0, 28, 44, 0);
            // 
            // dateFechaInicioContrato
            // 
            this.dateFechaInicioContrato.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFechaInicioContrato.Location = new System.Drawing.Point(89, 59);
            this.dateFechaInicioContrato.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateFechaInicioContrato.MinimumSize = new System.Drawing.Size(4, 30);
            this.dateFechaInicioContrato.Name = "dateFechaInicioContrato";
            this.dateFechaInicioContrato.Size = new System.Drawing.Size(210, 30);
            this.dateFechaInicioContrato.TabIndex = 5;
            // 
            // metroLabel6
            // 
            this.metroLabel6.Location = new System.Drawing.Point(4, 158);
            this.metroLabel6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(75, 17);
            this.metroLabel6.TabIndex = 4;
            this.metroLabel6.Text = "Rut Productor";
            // 
            // metroLabel5
            // 
            this.metroLabel5.Location = new System.Drawing.Point(4, 114);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(75, 17);
            this.metroLabel5.TabIndex = 3;
            this.metroLabel5.Text = "Fecha Término";
            // 
            // metroLabel4
            // 
            this.metroLabel4.Location = new System.Drawing.Point(9, 67);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(70, 17);
            this.metroLabel4.TabIndex = 2;
            this.metroLabel4.Text = "Fecha Inicio";
            // 
            // vContratos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroTabControl1);
            this.Name = "vContratos";
            this.Size = new System.Drawing.Size(604, 441);
            this.Load += new System.EventHandler(this.vContratos_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabContratos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroGridListaContratos)).EndInit();
            this.metroTabPageCrearContrato.ResumeLayout(false);
            this.metroTabModificarContrato.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private MetroFramework.Controls.MetroButton metroButtonModificarContrato;

        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox txtbIdProductor;

        private MetroFramework.Controls.MetroButton buttonModificarContrato;

        private MetroFramework.Controls.MetroTextBox textbRutProductorContrato;

        private MetroFramework.Controls.MetroDateTime dateFechaTerminoContrato;

        private MetroFramework.Controls.MetroDateTime dateFechaInicioContrato;

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
