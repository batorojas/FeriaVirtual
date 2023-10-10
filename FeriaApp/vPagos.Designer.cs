using System.ComponentModel;

namespace FeriaApp
{
    partial class vPagos
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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

        #region Component Designer generated code

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
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroButtonActualizarPago = new MetroFramework.Controls.MetroButton();
            this.metroScrollBar1 = new MetroFramework.Controls.MetroScrollBar();
            this.dgvListaPagosPendientes = new MetroFramework.Controls.MetroGrid();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.dgvListaPagosRealizados = new MetroFramework.Controls.MetroGrid();
            this.btnExportar = new MetroFramework.Controls.MetroButton();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPagosPendientes)).BeginInit();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPagosRealizados)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Location = new System.Drawing.Point(10, 28);
            this.metroTabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(647, 417);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            this.metroTabControl1.SelectedIndexChanged += new System.EventHandler(this.metroTabControl1_SelectedIndexChanged);
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.btnExportar);
            this.metroTabPage1.Controls.Add(this.metroButtonActualizarPago);
            this.metroTabPage1.Controls.Add(this.metroScrollBar1);
            this.metroTabPage1.Controls.Add(this.dgvListaPagosPendientes);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 8;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(639, 375);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Pagos Pendientes";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 8;
            // 
            // metroButtonActualizarPago
            // 
            this.metroButtonActualizarPago.Location = new System.Drawing.Point(235, 309);
            this.metroButtonActualizarPago.Margin = new System.Windows.Forms.Padding(2);
            this.metroButtonActualizarPago.Name = "metroButtonActualizarPago";
            this.metroButtonActualizarPago.Size = new System.Drawing.Size(171, 49);
            this.metroButtonActualizarPago.TabIndex = 4;
            this.metroButtonActualizarPago.Text = "Actualizar Pago";
            this.metroButtonActualizarPago.UseSelectable = true;
            this.metroButtonActualizarPago.Click += new System.EventHandler(this.metroButtonActualizarPago_Click);
            // 
            // metroScrollBar1
            // 
            this.metroScrollBar1.LargeChange = 10;
            this.metroScrollBar1.Location = new System.Drawing.Point(235, 177);
            this.metroScrollBar1.Margin = new System.Windows.Forms.Padding(2);
            this.metroScrollBar1.Maximum = 100;
            this.metroScrollBar1.Minimum = 0;
            this.metroScrollBar1.MouseWheelBarPartitions = 10;
            this.metroScrollBar1.Name = "metroScrollBar1";
            this.metroScrollBar1.Orientation = MetroFramework.Controls.MetroScrollOrientation.Vertical;
            this.metroScrollBar1.ScrollbarSize = 6;
            this.metroScrollBar1.Size = new System.Drawing.Size(6, 6);
            this.metroScrollBar1.TabIndex = 3;
            this.metroScrollBar1.UseSelectable = true;
            // 
            // dgvListaPagosPendientes
            // 
            this.dgvListaPagosPendientes.AllowUserToResizeRows = false;
            this.dgvListaPagosPendientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvListaPagosPendientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListaPagosPendientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvListaPagosPendientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaPagosPendientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListaPagosPendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaPagosPendientes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListaPagosPendientes.EnableHeadersVisualStyles = false;
            this.dgvListaPagosPendientes.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvListaPagosPendientes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvListaPagosPendientes.Location = new System.Drawing.Point(2, 19);
            this.dgvListaPagosPendientes.Margin = new System.Windows.Forms.Padding(2);
            this.dgvListaPagosPendientes.Name = "dgvListaPagosPendientes";
            this.dgvListaPagosPendientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaPagosPendientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListaPagosPendientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvListaPagosPendientes.RowTemplate.Height = 24;
            this.dgvListaPagosPendientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaPagosPendientes.Size = new System.Drawing.Size(614, 220);
            this.dgvListaPagosPendientes.TabIndex = 2;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.dgvListaPagosRealizados);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 8;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(639, 375);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Historial de Pagos";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 8;
            // 
            // dgvListaPagosRealizados
            // 
            this.dgvListaPagosRealizados.AllowUserToResizeRows = false;
            this.dgvListaPagosRealizados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvListaPagosRealizados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListaPagosRealizados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvListaPagosRealizados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaPagosRealizados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvListaPagosRealizados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaPagosRealizados.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvListaPagosRealizados.EnableHeadersVisualStyles = false;
            this.dgvListaPagosRealizados.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvListaPagosRealizados.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvListaPagosRealizados.Location = new System.Drawing.Point(13, 29);
            this.dgvListaPagosRealizados.Margin = new System.Windows.Forms.Padding(2);
            this.dgvListaPagosRealizados.Name = "dgvListaPagosRealizados";
            this.dgvListaPagosRealizados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaPagosRealizados.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvListaPagosRealizados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvListaPagosRealizados.RowTemplate.Height = 24;
            this.dgvListaPagosRealizados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaPagosRealizados.Size = new System.Drawing.Size(622, 250);
            this.dgvListaPagosRealizados.TabIndex = 2;
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(33, 294);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(75, 23);
            this.btnExportar.TabIndex = 5;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseSelectable = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // vPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroTabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "vPagos";
            this.Size = new System.Drawing.Size(647, 417);
            this.Load += new System.EventHandler(this.vPagos_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPagosPendientes)).EndInit();
            this.metroTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPagosRealizados)).EndInit();
            this.ResumeLayout(false);

        }

        private MetroFramework.Controls.MetroGrid dgvListaPagosRealizados;

        private MetroFramework.Controls.MetroButton metroButtonActualizarPago;

        private MetroFramework.Controls.MetroScrollBar metroScrollBar1;

        private MetroFramework.Controls.MetroGrid dgvListaPagosPendientes;

        private MetroFramework.Controls.MetroTabPage metroTabPage2;

        private MetroFramework.Controls.MetroTabPage metroTabPage1;

        private MetroFramework.Controls.MetroTabControl metroTabControl1;

        #endregion

        private MetroFramework.Controls.MetroButton btnExportar;
    }
}