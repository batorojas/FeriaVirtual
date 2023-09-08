namespace FeriaApp
{
    partial class vUsuarios
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
            this.dgvListaUsuarios = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPageCrearUsuario = new MetroFramework.Controls.MetroTabPage();
            this.metroComboBoxTipoCliente = new MetroFramework.Controls.MetroComboBox();
            this.metroLabelTipoCliente = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxGiro = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxRazonSocial = new MetroFramework.Controls.MetroTextBox();
            this.metroComboBoxComuna = new MetroFramework.Controls.MetroComboBox();
            this.metroLabelRutDV = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxRutDV = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxRut = new MetroFramework.Controls.MetroTextBox();
            this.metroLabelComuna = new MetroFramework.Controls.MetroLabel();
            this.metroLabelGiro = new MetroFramework.Controls.MetroLabel();
            this.metroLabelRazonSocial = new MetroFramework.Controls.MetroLabel();
            this.metroLabelRut = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxDireccion = new MetroFramework.Controls.MetroTextBox();
            this.metroLabelDireccion = new MetroFramework.Controls.MetroLabel();
            this.metroButtonLimpiarUsuario = new MetroFramework.Controls.MetroButton();
            this.metroButtonAgregarUsuario = new MetroFramework.Controls.MetroButton();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.metroRadioButtonEstadoCuentaInactiva = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButtonEstadoCuentaActiva = new MetroFramework.Controls.MetroRadioButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroComboBoxTipoCuenta = new MetroFramework.Controls.MetroComboBox();
            this.metroTextBoxContrasena = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxNombreUsuario = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPageCrearUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.dgvListaUsuarios);
            this.metroTabControl1.Controls.Add(this.metroTabPageCrearUsuario);
            this.metroTabControl1.Location = new System.Drawing.Point(8, 26);
            this.metroTabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(863, 513);
            this.metroTabControl1.TabIndex = 1;
            this.metroTabControl1.UseSelectable = true;
            // 
            // dgvListaUsuarios
            // 
            this.dgvListaUsuarios.HorizontalScrollbarBarColor = true;
            this.dgvListaUsuarios.HorizontalScrollbarHighlightOnWheel = false;
            this.dgvListaUsuarios.HorizontalScrollbarSize = 12;
            this.dgvListaUsuarios.Location = new System.Drawing.Point(4, 38);
            this.dgvListaUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.dgvListaUsuarios.Name = "dgvListaUsuarios";
            this.dgvListaUsuarios.Size = new System.Drawing.Size(855, 471);
            this.dgvListaUsuarios.TabIndex = 0;
            this.dgvListaUsuarios.Text = "Usuarios";
            this.dgvListaUsuarios.VerticalScrollbarBarColor = true;
            this.dgvListaUsuarios.VerticalScrollbarHighlightOnWheel = false;
            this.dgvListaUsuarios.VerticalScrollbarSize = 13;
            this.dgvListaUsuarios.Click += new System.EventHandler(this.metroTabPageUsuarios_Click);
            this.dgvListaUsuarios.Layout += new System.Windows.Forms.LayoutEventHandler(this.metroTabPageUsuarios_Layout);
            // 
            // metroTabPageCrearUsuario
            // 
            this.metroTabPageCrearUsuario.Controls.Add(this.metroComboBoxTipoCliente);
            this.metroTabPageCrearUsuario.Controls.Add(this.metroLabelTipoCliente);
            this.metroTabPageCrearUsuario.Controls.Add(this.metroTextBoxGiro);
            this.metroTabPageCrearUsuario.Controls.Add(this.metroTextBoxRazonSocial);
            this.metroTabPageCrearUsuario.Controls.Add(this.metroComboBoxComuna);
            this.metroTabPageCrearUsuario.Controls.Add(this.metroLabelRutDV);
            this.metroTabPageCrearUsuario.Controls.Add(this.metroTextBoxRutDV);
            this.metroTabPageCrearUsuario.Controls.Add(this.metroTextBoxRut);
            this.metroTabPageCrearUsuario.Controls.Add(this.metroLabelComuna);
            this.metroTabPageCrearUsuario.Controls.Add(this.metroLabelGiro);
            this.metroTabPageCrearUsuario.Controls.Add(this.metroLabelRazonSocial);
            this.metroTabPageCrearUsuario.Controls.Add(this.metroLabelRut);
            this.metroTabPageCrearUsuario.Controls.Add(this.metroTextBoxDireccion);
            this.metroTabPageCrearUsuario.Controls.Add(this.metroLabelDireccion);
            this.metroTabPageCrearUsuario.Controls.Add(this.metroButtonLimpiarUsuario);
            this.metroTabPageCrearUsuario.Controls.Add(this.metroButtonAgregarUsuario);
            this.metroTabPageCrearUsuario.Controls.Add(this.metroGrid1);
            this.metroTabPageCrearUsuario.Controls.Add(this.metroRadioButtonEstadoCuentaInactiva);
            this.metroTabPageCrearUsuario.Controls.Add(this.metroRadioButtonEstadoCuentaActiva);
            this.metroTabPageCrearUsuario.Controls.Add(this.metroLabel4);
            this.metroTabPageCrearUsuario.Controls.Add(this.metroLabel3);
            this.metroTabPageCrearUsuario.Controls.Add(this.metroComboBoxTipoCuenta);
            this.metroTabPageCrearUsuario.Controls.Add(this.metroTextBoxContrasena);
            this.metroTabPageCrearUsuario.Controls.Add(this.metroTextBoxNombreUsuario);
            this.metroTabPageCrearUsuario.Controls.Add(this.metroLabel2);
            this.metroTabPageCrearUsuario.Controls.Add(this.metroLabel1);
            this.metroTabPageCrearUsuario.HorizontalScrollbarBarColor = true;
            this.metroTabPageCrearUsuario.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPageCrearUsuario.HorizontalScrollbarSize = 12;
            this.metroTabPageCrearUsuario.Location = new System.Drawing.Point(4, 38);
            this.metroTabPageCrearUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.metroTabPageCrearUsuario.Name = "metroTabPageCrearUsuario";
            this.metroTabPageCrearUsuario.Size = new System.Drawing.Size(855, 471);
            this.metroTabPageCrearUsuario.TabIndex = 1;
            this.metroTabPageCrearUsuario.Text = "Crear Usuario";
            this.metroTabPageCrearUsuario.VerticalScrollbarBarColor = true;
            this.metroTabPageCrearUsuario.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPageCrearUsuario.VerticalScrollbarSize = 13;
            // 
            // metroComboBoxTipoCliente
            // 
            this.metroComboBoxTipoCliente.FormattingEnabled = true;
            this.metroComboBoxTipoCliente.ItemHeight = 24;
            this.metroComboBoxTipoCliente.Location = new System.Drawing.Point(692, 160);
            this.metroComboBoxTipoCliente.Margin = new System.Windows.Forms.Padding(4);
            this.metroComboBoxTipoCliente.Name = "metroComboBoxTipoCliente";
            this.metroComboBoxTipoCliente.Size = new System.Drawing.Size(159, 30);
            this.metroComboBoxTipoCliente.TabIndex = 39;
            this.metroComboBoxTipoCliente.UseSelectable = true;
            // 
            // metroLabelTipoCliente
            // 
            this.metroLabelTipoCliente.AutoSize = true;
            this.metroLabelTipoCliente.Location = new System.Drawing.Point(580, 165);
            this.metroLabelTipoCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabelTipoCliente.Name = "metroLabelTipoCliente";
            this.metroLabelTipoCliente.Size = new System.Drawing.Size(83, 20);
            this.metroLabelTipoCliente.TabIndex = 38;
            this.metroLabelTipoCliente.Text = "Tipo Cliente";
            // 
            // metroTextBoxGiro
            // 
            // 
            // 
            // 
            this.metroTextBoxGiro.CustomButton.Image = null;
            this.metroTextBoxGiro.CustomButton.Location = new System.Drawing.Point(142, 2);
            this.metroTextBoxGiro.CustomButton.Margin = new System.Windows.Forms.Padding(5);
            this.metroTextBoxGiro.CustomButton.Name = "";
            this.metroTextBoxGiro.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.metroTextBoxGiro.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxGiro.CustomButton.TabIndex = 1;
            this.metroTextBoxGiro.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxGiro.CustomButton.UseSelectable = true;
            this.metroTextBoxGiro.CustomButton.Visible = false;
            this.metroTextBoxGiro.Lines = new string[0];
            this.metroTextBoxGiro.Location = new System.Drawing.Point(395, 165);
            this.metroTextBoxGiro.Margin = new System.Windows.Forms.Padding(4);
            this.metroTextBoxGiro.MaxLength = 32767;
            this.metroTextBoxGiro.Name = "metroTextBoxGiro";
            this.metroTextBoxGiro.PasswordChar = '\0';
            this.metroTextBoxGiro.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxGiro.SelectedText = "";
            this.metroTextBoxGiro.SelectionLength = 0;
            this.metroTextBoxGiro.SelectionStart = 0;
            this.metroTextBoxGiro.ShortcutsEnabled = true;
            this.metroTextBoxGiro.Size = new System.Drawing.Size(168, 28);
            this.metroTextBoxGiro.TabIndex = 36;
            this.metroTextBoxGiro.UseSelectable = true;
            this.metroTextBoxGiro.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxGiro.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBoxRazonSocial
            // 
            // 
            // 
            // 
            this.metroTextBoxRazonSocial.CustomButton.Image = null;
            this.metroTextBoxRazonSocial.CustomButton.Location = new System.Drawing.Point(174, 2);
            this.metroTextBoxRazonSocial.CustomButton.Margin = new System.Windows.Forms.Padding(5);
            this.metroTextBoxRazonSocial.CustomButton.Name = "";
            this.metroTextBoxRazonSocial.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.metroTextBoxRazonSocial.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxRazonSocial.CustomButton.TabIndex = 1;
            this.metroTextBoxRazonSocial.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxRazonSocial.CustomButton.UseSelectable = true;
            this.metroTextBoxRazonSocial.CustomButton.Visible = false;
            this.metroTextBoxRazonSocial.Lines = new string[0];
            this.metroTextBoxRazonSocial.Location = new System.Drawing.Point(520, 119);
            this.metroTextBoxRazonSocial.Margin = new System.Windows.Forms.Padding(4);
            this.metroTextBoxRazonSocial.MaxLength = 32767;
            this.metroTextBoxRazonSocial.Name = "metroTextBoxRazonSocial";
            this.metroTextBoxRazonSocial.PasswordChar = '\0';
            this.metroTextBoxRazonSocial.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxRazonSocial.SelectedText = "";
            this.metroTextBoxRazonSocial.SelectionLength = 0;
            this.metroTextBoxRazonSocial.SelectionStart = 0;
            this.metroTextBoxRazonSocial.ShortcutsEnabled = true;
            this.metroTextBoxRazonSocial.Size = new System.Drawing.Size(200, 28);
            this.metroTextBoxRazonSocial.TabIndex = 35;
            this.metroTextBoxRazonSocial.UseSelectable = true;
            this.metroTextBoxRazonSocial.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxRazonSocial.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroComboBoxComuna
            // 
            this.metroComboBoxComuna.FormattingEnabled = true;
            this.metroComboBoxComuna.ItemHeight = 24;
            this.metroComboBoxComuna.Location = new System.Drawing.Point(155, 160);
            this.metroComboBoxComuna.Margin = new System.Windows.Forms.Padding(4);
            this.metroComboBoxComuna.Name = "metroComboBoxComuna";
            this.metroComboBoxComuna.Size = new System.Drawing.Size(160, 30);
            this.metroComboBoxComuna.TabIndex = 34;
            this.metroComboBoxComuna.UseSelectable = true;
            // 
            // metroLabelRutDV
            // 
            this.metroLabelRutDV.AutoSize = true;
            this.metroLabelRutDV.Location = new System.Drawing.Point(273, 114);
            this.metroLabelRutDV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabelRutDV.Name = "metroLabelRutDV";
            this.metroLabelRutDV.Size = new System.Drawing.Size(15, 20);
            this.metroLabelRutDV.TabIndex = 33;
            this.metroLabelRutDV.Text = "-";
            // 
            // metroTextBoxRutDV
            // 
            // 
            // 
            // 
            this.metroTextBoxRutDV.CustomButton.Image = null;
            this.metroTextBoxRutDV.CustomButton.Location = new System.Drawing.Point(5, 2);
            this.metroTextBoxRutDV.CustomButton.Margin = new System.Windows.Forms.Padding(5);
            this.metroTextBoxRutDV.CustomButton.Name = "";
            this.metroTextBoxRutDV.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.metroTextBoxRutDV.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxRutDV.CustomButton.TabIndex = 1;
            this.metroTextBoxRutDV.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxRutDV.CustomButton.UseSelectable = true;
            this.metroTextBoxRutDV.CustomButton.Visible = false;
            this.metroTextBoxRutDV.Lines = new string[0];
            this.metroTextBoxRutDV.Location = new System.Drawing.Point(293, 114);
            this.metroTextBoxRutDV.Margin = new System.Windows.Forms.Padding(4);
            this.metroTextBoxRutDV.MaxLength = 1;
            this.metroTextBoxRutDV.Name = "metroTextBoxRutDV";
            this.metroTextBoxRutDV.PasswordChar = '\0';
            this.metroTextBoxRutDV.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxRutDV.SelectedText = "";
            this.metroTextBoxRutDV.SelectionLength = 0;
            this.metroTextBoxRutDV.SelectionStart = 0;
            this.metroTextBoxRutDV.ShortcutsEnabled = true;
            this.metroTextBoxRutDV.Size = new System.Drawing.Size(31, 28);
            this.metroTextBoxRutDV.TabIndex = 32;
            this.metroTextBoxRutDV.UseSelectable = true;
            this.metroTextBoxRutDV.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxRutDV.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBoxRutDV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextBoxRutDV_KeyPress);
            // 
            // metroTextBoxRut
            // 
            // 
            // 
            // 
            this.metroTextBoxRut.CustomButton.Image = null;
            this.metroTextBoxRut.CustomButton.Location = new System.Drawing.Point(94, 2);
            this.metroTextBoxRut.CustomButton.Margin = new System.Windows.Forms.Padding(5);
            this.metroTextBoxRut.CustomButton.Name = "";
            this.metroTextBoxRut.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.metroTextBoxRut.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxRut.CustomButton.TabIndex = 1;
            this.metroTextBoxRut.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxRut.CustomButton.UseSelectable = true;
            this.metroTextBoxRut.CustomButton.Visible = false;
            this.metroTextBoxRut.Lines = new string[0];
            this.metroTextBoxRut.Location = new System.Drawing.Point(155, 114);
            this.metroTextBoxRut.Margin = new System.Windows.Forms.Padding(4);
            this.metroTextBoxRut.MaxLength = 8;
            this.metroTextBoxRut.Name = "metroTextBoxRut";
            this.metroTextBoxRut.PasswordChar = '\0';
            this.metroTextBoxRut.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxRut.SelectedText = "";
            this.metroTextBoxRut.SelectionLength = 0;
            this.metroTextBoxRut.SelectionStart = 0;
            this.metroTextBoxRut.ShortcutsEnabled = true;
            this.metroTextBoxRut.Size = new System.Drawing.Size(120, 28);
            this.metroTextBoxRut.TabIndex = 31;
            this.metroTextBoxRut.UseSelectable = true;
            this.metroTextBoxRut.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxRut.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBoxRut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextBoxRut_KeyPress);
            // 
            // metroLabelComuna
            // 
            this.metroLabelComuna.AutoSize = true;
            this.metroLabelComuna.Location = new System.Drawing.Point(68, 162);
            this.metroLabelComuna.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabelComuna.Name = "metroLabelComuna";
            this.metroLabelComuna.Size = new System.Drawing.Size(61, 20);
            this.metroLabelComuna.TabIndex = 30;
            this.metroLabelComuna.Text = "Comuna";
            // 
            // metroLabelGiro
            // 
            this.metroLabelGiro.AutoSize = true;
            this.metroLabelGiro.Location = new System.Drawing.Point(341, 165);
            this.metroLabelGiro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabelGiro.Name = "metroLabelGiro";
            this.metroLabelGiro.Size = new System.Drawing.Size(35, 20);
            this.metroLabelGiro.TabIndex = 29;
            this.metroLabelGiro.Text = "Giro";
            // 
            // metroLabelRazonSocial
            // 
            this.metroLabelRazonSocial.AutoSize = true;
            this.metroLabelRazonSocial.Location = new System.Drawing.Point(401, 119);
            this.metroLabelRazonSocial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabelRazonSocial.Name = "metroLabelRazonSocial";
            this.metroLabelRazonSocial.Size = new System.Drawing.Size(86, 20);
            this.metroLabelRazonSocial.TabIndex = 28;
            this.metroLabelRazonSocial.Text = "Razon Social";
            // 
            // metroLabelRut
            // 
            this.metroLabelRut.AutoSize = true;
            this.metroLabelRut.Location = new System.Drawing.Point(109, 114);
            this.metroLabelRut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabelRut.Name = "metroLabelRut";
            this.metroLabelRut.Size = new System.Drawing.Size(29, 20);
            this.metroLabelRut.TabIndex = 27;
            this.metroLabelRut.Text = "Rut";
            // 
            // metroTextBoxDireccion
            // 
            // 
            // 
            // 
            this.metroTextBoxDireccion.CustomButton.Image = null;
            this.metroTextBoxDireccion.CustomButton.Location = new System.Drawing.Point(259, 2);
            this.metroTextBoxDireccion.CustomButton.Margin = new System.Windows.Forms.Padding(5);
            this.metroTextBoxDireccion.CustomButton.Name = "";
            this.metroTextBoxDireccion.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.metroTextBoxDireccion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxDireccion.CustomButton.TabIndex = 1;
            this.metroTextBoxDireccion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxDireccion.CustomButton.UseSelectable = true;
            this.metroTextBoxDireccion.CustomButton.Visible = false;
            this.metroTextBoxDireccion.Lines = new string[0];
            this.metroTextBoxDireccion.Location = new System.Drawing.Point(155, 215);
            this.metroTextBoxDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.metroTextBoxDireccion.MaxLength = 32767;
            this.metroTextBoxDireccion.Name = "metroTextBoxDireccion";
            this.metroTextBoxDireccion.PasswordChar = '\0';
            this.metroTextBoxDireccion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxDireccion.SelectedText = "";
            this.metroTextBoxDireccion.SelectionLength = 0;
            this.metroTextBoxDireccion.SelectionStart = 0;
            this.metroTextBoxDireccion.ShortcutsEnabled = true;
            this.metroTextBoxDireccion.Size = new System.Drawing.Size(285, 28);
            this.metroTextBoxDireccion.TabIndex = 23;
            this.metroTextBoxDireccion.UseSelectable = true;
            this.metroTextBoxDireccion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxDireccion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabelDireccion
            // 
            this.metroLabelDireccion.AutoSize = true;
            this.metroLabelDireccion.Location = new System.Drawing.Point(63, 215);
            this.metroLabelDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabelDireccion.Name = "metroLabelDireccion";
            this.metroLabelDireccion.Size = new System.Drawing.Size(68, 20);
            this.metroLabelDireccion.TabIndex = 17;
            this.metroLabelDireccion.Text = "Direccion";
            // 
            // metroButtonLimpiarUsuario
            // 
            this.metroButtonLimpiarUsuario.Location = new System.Drawing.Point(469, 215);
            this.metroButtonLimpiarUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.metroButtonLimpiarUsuario.Name = "metroButtonLimpiarUsuario";
            this.metroButtonLimpiarUsuario.Size = new System.Drawing.Size(100, 28);
            this.metroButtonLimpiarUsuario.TabIndex = 14;
            this.metroButtonLimpiarUsuario.Text = "Limpiar";
            this.metroButtonLimpiarUsuario.UseSelectable = true;
            this.metroButtonLimpiarUsuario.Click += new System.EventHandler(this.metroButtonLimpiarUsuario_Click);
            // 
            // metroButtonAgregarUsuario
            // 
            this.metroButtonAgregarUsuario.Location = new System.Drawing.Point(609, 215);
            this.metroButtonAgregarUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.metroButtonAgregarUsuario.Name = "metroButtonAgregarUsuario";
            this.metroButtonAgregarUsuario.Size = new System.Drawing.Size(100, 28);
            this.metroButtonAgregarUsuario.TabIndex = 13;
            this.metroButtonAgregarUsuario.Text = "Agregar";
            this.metroButtonAgregarUsuario.UseSelectable = true;
            this.metroButtonAgregarUsuario.Click += new System.EventHandler(this.metroButtonAgregarUsuario_Click);
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToAddRows = false;
            this.metroGrid1.AllowUserToDeleteRows = false;
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(4, 254);
            this.metroGrid1.Margin = new System.Windows.Forms.Padding(4);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.ReadOnly = true;
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(771, 191);
            this.metroGrid1.TabIndex = 12;
            // 
            // metroRadioButtonEstadoCuentaInactiva
            // 
            this.metroRadioButtonEstadoCuentaInactiva.AutoSize = true;
            this.metroRadioButtonEstadoCuentaInactiva.Location = new System.Drawing.Point(609, 71);
            this.metroRadioButtonEstadoCuentaInactiva.Margin = new System.Windows.Forms.Padding(4);
            this.metroRadioButtonEstadoCuentaInactiva.Name = "metroRadioButtonEstadoCuentaInactiva";
            this.metroRadioButtonEstadoCuentaInactiva.Size = new System.Drawing.Size(67, 17);
            this.metroRadioButtonEstadoCuentaInactiva.TabIndex = 11;
            this.metroRadioButtonEstadoCuentaInactiva.Text = "Inactiva";
            this.metroRadioButtonEstadoCuentaInactiva.UseSelectable = true;
            // 
            // metroRadioButtonEstadoCuentaActiva
            // 
            this.metroRadioButtonEstadoCuentaActiva.AutoSize = true;
            this.metroRadioButtonEstadoCuentaActiva.Location = new System.Drawing.Point(527, 71);
            this.metroRadioButtonEstadoCuentaActiva.Margin = new System.Windows.Forms.Padding(4);
            this.metroRadioButtonEstadoCuentaActiva.Name = "metroRadioButtonEstadoCuentaActiva";
            this.metroRadioButtonEstadoCuentaActiva.Size = new System.Drawing.Size(58, 17);
            this.metroRadioButtonEstadoCuentaActiva.TabIndex = 10;
            this.metroRadioButtonEstadoCuentaActiva.Text = "Activa";
            this.metroRadioButtonEstadoCuentaActiva.UseSelectable = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(347, 66);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(130, 20);
            this.metroLabel4.TabIndex = 8;
            this.metroLabel4.Text = "Estado de la cuenta";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(347, 23);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(102, 20);
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "Tipo de cuenta";
            // 
            // metroComboBoxTipoCuenta
            // 
            this.metroComboBoxTipoCuenta.FormattingEnabled = true;
            this.metroComboBoxTipoCuenta.ItemHeight = 24;
            this.metroComboBoxTipoCuenta.Location = new System.Drawing.Point(508, 18);
            this.metroComboBoxTipoCuenta.Margin = new System.Windows.Forms.Padding(4);
            this.metroComboBoxTipoCuenta.Name = "metroComboBoxTipoCuenta";
            this.metroComboBoxTipoCuenta.Size = new System.Drawing.Size(160, 30);
            this.metroComboBoxTipoCuenta.TabIndex = 6;
            this.metroComboBoxTipoCuenta.UseSelectable = true;
            this.metroComboBoxTipoCuenta.SelectedIndexChanged += new System.EventHandler(this.metroComboBoxTipoCuenta_SelectedIndexChanged);
            // 
            // metroTextBoxContrasena
            // 
            // 
            // 
            // 
            this.metroTextBoxContrasena.CustomButton.Image = null;
            this.metroTextBoxContrasena.CustomButton.Location = new System.Drawing.Point(95, 2);
            this.metroTextBoxContrasena.CustomButton.Margin = new System.Windows.Forms.Padding(5);
            this.metroTextBoxContrasena.CustomButton.Name = "";
            this.metroTextBoxContrasena.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.metroTextBoxContrasena.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxContrasena.CustomButton.TabIndex = 1;
            this.metroTextBoxContrasena.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxContrasena.CustomButton.UseSelectable = true;
            this.metroTextBoxContrasena.CustomButton.Visible = false;
            this.metroTextBoxContrasena.Lines = new string[0];
            this.metroTextBoxContrasena.Location = new System.Drawing.Point(155, 66);
            this.metroTextBoxContrasena.Margin = new System.Windows.Forms.Padding(4);
            this.metroTextBoxContrasena.MaxLength = 32767;
            this.metroTextBoxContrasena.Name = "metroTextBoxContrasena";
            this.metroTextBoxContrasena.PasswordChar = '\0';
            this.metroTextBoxContrasena.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxContrasena.SelectedText = "";
            this.metroTextBoxContrasena.SelectionLength = 0;
            this.metroTextBoxContrasena.SelectionStart = 0;
            this.metroTextBoxContrasena.ShortcutsEnabled = true;
            this.metroTextBoxContrasena.Size = new System.Drawing.Size(121, 28);
            this.metroTextBoxContrasena.TabIndex = 5;
            this.metroTextBoxContrasena.UseSelectable = true;
            this.metroTextBoxContrasena.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxContrasena.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBoxNombreUsuario
            // 
            // 
            // 
            // 
            this.metroTextBoxNombreUsuario.CustomButton.Image = null;
            this.metroTextBoxNombreUsuario.CustomButton.Location = new System.Drawing.Point(95, 2);
            this.metroTextBoxNombreUsuario.CustomButton.Margin = new System.Windows.Forms.Padding(5);
            this.metroTextBoxNombreUsuario.CustomButton.Name = "";
            this.metroTextBoxNombreUsuario.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.metroTextBoxNombreUsuario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxNombreUsuario.CustomButton.TabIndex = 1;
            this.metroTextBoxNombreUsuario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxNombreUsuario.CustomButton.UseSelectable = true;
            this.metroTextBoxNombreUsuario.CustomButton.Visible = false;
            this.metroTextBoxNombreUsuario.Lines = new string[0];
            this.metroTextBoxNombreUsuario.Location = new System.Drawing.Point(155, 18);
            this.metroTextBoxNombreUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.metroTextBoxNombreUsuario.MaxLength = 32767;
            this.metroTextBoxNombreUsuario.Name = "metroTextBoxNombreUsuario";
            this.metroTextBoxNombreUsuario.PasswordChar = '\0';
            this.metroTextBoxNombreUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxNombreUsuario.SelectedText = "";
            this.metroTextBoxNombreUsuario.SelectionLength = 0;
            this.metroTextBoxNombreUsuario.SelectionStart = 0;
            this.metroTextBoxNombreUsuario.ShortcutsEnabled = true;
            this.metroTextBoxNombreUsuario.Size = new System.Drawing.Size(121, 28);
            this.metroTextBoxNombreUsuario.TabIndex = 4;
            this.metroTextBoxNombreUsuario.UseSelectable = true;
            this.metroTextBoxNombreUsuario.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxNombreUsuario.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(47, 66);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(79, 20);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Contraseña";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(4, 18);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(112, 20);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Nombre Usuario";
            // 
            // vUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroTabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "vUsuarios";
            this.Size = new System.Drawing.Size(875, 543);
            this.Load += new System.EventHandler(this.vUsuarios_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPageCrearUsuario.ResumeLayout(false);
            this.metroTabPageCrearUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage dgvListaUsuarios;
        private MetroFramework.Controls.MetroTabPage metroTabPageCrearUsuario;
        private MetroFramework.Controls.MetroButton metroButtonLimpiarUsuario;
        private MetroFramework.Controls.MetroButton metroButtonAgregarUsuario;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroRadioButton metroRadioButtonEstadoCuentaInactiva;
        private MetroFramework.Controls.MetroRadioButton metroRadioButtonEstadoCuentaActiva;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox metroComboBoxTipoCuenta;
        private MetroFramework.Controls.MetroTextBox metroTextBoxContrasena;
        private MetroFramework.Controls.MetroTextBox metroTextBoxNombreUsuario;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabelDireccion;
        private MetroFramework.Controls.MetroTextBox metroTextBoxDireccion;
        private MetroFramework.Controls.MetroTextBox metroTextBoxGiro;
        private MetroFramework.Controls.MetroTextBox metroTextBoxRazonSocial;
        private MetroFramework.Controls.MetroComboBox metroComboBoxComuna;
        private MetroFramework.Controls.MetroLabel metroLabelRutDV;
        private MetroFramework.Controls.MetroTextBox metroTextBoxRutDV;
        private MetroFramework.Controls.MetroTextBox metroTextBoxRut;
        private MetroFramework.Controls.MetroLabel metroLabelComuna;
        private MetroFramework.Controls.MetroLabel metroLabelGiro;
        private MetroFramework.Controls.MetroLabel metroLabelRazonSocial;
        private MetroFramework.Controls.MetroLabel metroLabelRut;
        private MetroFramework.Controls.MetroLabel metroLabelTipoCliente;
        private MetroFramework.Controls.MetroComboBox metroComboBoxTipoCliente;
    }
}
