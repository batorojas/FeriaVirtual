namespace FeriaApp
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
            this.metroGridListaContratos = new MetroFramework.Controls.MetroGrid();
            this.metroTabPageCrearContrato = new MetroFramework.Controls.MetroTabPage();
            this.metroTextRutProductorContrato = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroDateTime2 = new MetroFramework.Controls.MetroDateTime();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTabModificarContrato = new MetroFramework.Controls.MetroTabPage();
            this.metroTabControl1.SuspendLayout();
            this.metroTabContratos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridListaContratos)).BeginInit();
            this.metroTabPageCrearContrato.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabContratos);
            this.metroTabControl1.Controls.Add(this.metroTabPageCrearContrato);
            this.metroTabControl1.Controls.Add(this.metroTabModificarContrato);
            this.metroTabControl1.Location = new System.Drawing.Point(3, 23);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(799, 520);
            this.metroTabControl1.TabIndex = 3;
            this.metroTabControl1.UseSelectable = true;
            this.metroTabControl1.SelectedIndexChanged += new System.EventHandler(this.metroTabControl1_SelectedIndexChanged);
            // 
            // metroTabContratos
            // 
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
            // metroGridListaContratos
            // 
            this.metroGridListaContratos.AllowUserToResizeRows = false;
            this.metroGridListaContratos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridListaContratos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridListaContratos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGridListaContratos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
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
            this.metroGridListaContratos.Location = new System.Drawing.Point(3, 38);
            this.metroGridListaContratos.Name = "metroGridListaContratos";
            this.metroGridListaContratos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridListaContratos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGridListaContratos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridListaContratos.RowTemplate.Height = 24;
            this.metroGridListaContratos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridListaContratos.Size = new System.Drawing.Size(763, 348);
            this.metroGridListaContratos.TabIndex = 2;
            this.metroGridListaContratos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellContentClick);
            // 
            // metroTabPageCrearContrato
            // 
            this.metroTabPageCrearContrato.Controls.Add(this.metroTextRutProductorContrato);
            this.metroTabPageCrearContrato.Controls.Add(this.metroLabel3);
            this.metroTabPageCrearContrato.Controls.Add(this.metroDateTime2);
            this.metroTabPageCrearContrato.Controls.Add(this.metroDateTime1);
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
            this.metroTextRutProductorContrato.Location = new System.Drawing.Point(121, 160);
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
            this.metroTextRutProductorContrato.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.Location = new System.Drawing.Point(8, 160);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(100, 23);
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "Rut Productor";
            // 
            // metroDateTime2
            // 
            this.metroDateTime2.ImeMode = System.Windows.Forms.ImeMode.On;
            this.metroDateTime2.Location = new System.Drawing.Point(121, 50);
            this.metroDateTime2.MinimumSize = new System.Drawing.Size(4, 30);
            this.metroDateTime2.Name = "metroDateTime2";
            this.metroDateTime2.Size = new System.Drawing.Size(279, 30);
            this.metroDateTime2.TabIndex = 6;
            this.metroDateTime2.ValueChanged += new System.EventHandler(this.metroDateTime2_ValueChanged);
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.metroDateTime1.Location = new System.Drawing.Point(121, 102);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(4, 30);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(279, 30);
            this.metroDateTime1.TabIndex = 5;
            // 
            // metroLabel2
            // 
            this.metroLabel2.Location = new System.Drawing.Point(8, 109);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(100, 23);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Fecha Termino";
            // 
            // metroLabel1
            // 
            this.metroLabel1.Location = new System.Drawing.Point(8, 57);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(95, 23);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Fecha Inicio";
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // metroTabModificarContrato
            // 
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
            this.ResumeLayout(false);
        }

        private MetroFramework.Controls.MetroTextBox metroTextRutProductorContrato;

        private MetroFramework.Controls.MetroDateTime metroDateTime2;
        private MetroFramework.Controls.MetroLabel metroLabel3;

        private MetroFramework.Controls.MetroLabel metroLabel2;

        private MetroFramework.Controls.MetroDateTime metroDateTime1;

        private MetroFramework.Controls.MetroLabel metroLabel1;

        private MetroFramework.Controls.MetroGrid metroGridListaContratos;

        private MetroFramework.Controls.MetroTabPage metroTabModificarContrato;

        private MetroFramework.Controls.MetroTabPage metroTabPageCrearContrato;

        private MetroFramework.Controls.MetroTabPage metroTabContratos;

        private MetroFramework.Controls.MetroTabControl metroTabControl1;

        #endregion
    }
}
