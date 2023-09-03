namespace FeriaApp
{
    partial class vLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(vLogin));
            this.btnLogin = new MetroFramework.Controls.MetroButton();
            this.tbUser = new MetroFramework.Controls.MetroTextBox();
            this.tbPassword = new MetroFramework.Controls.MetroTextBox();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelContraseña = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.White;
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogin.Location = new System.Drawing.Point(253, 228);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(117, 33);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Entrar";
            this.btnLogin.UseSelectable = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tbUser
            // 
            // 
            // 
            // 
            this.tbUser.CustomButton.Image = null;
            this.tbUser.CustomButton.Location = new System.Drawing.Point(126, 2);
            this.tbUser.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.tbUser.CustomButton.Name = "";
            this.tbUser.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.tbUser.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbUser.CustomButton.TabIndex = 1;
            this.tbUser.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbUser.CustomButton.UseSelectable = true;
            this.tbUser.CustomButton.Visible = false;
            this.tbUser.Lines = new string[0];
            this.tbUser.Location = new System.Drawing.Point(253, 124);
            this.tbUser.Margin = new System.Windows.Forms.Padding(4);
            this.tbUser.MaxLength = 32767;
            this.tbUser.Name = "tbUser";
            this.tbUser.PasswordChar = '\0';
            this.tbUser.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbUser.SelectedText = "";
            this.tbUser.SelectionLength = 0;
            this.tbUser.SelectionStart = 0;
            this.tbUser.ShortcutsEnabled = true;
            this.tbUser.Size = new System.Drawing.Size(152, 28);
            this.tbUser.TabIndex = 4;
            this.tbUser.UseSelectable = true;
            this.tbUser.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbUser.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbPassword
            // 
            // 
            // 
            // 
            this.tbPassword.CustomButton.Image = null;
            this.tbPassword.CustomButton.Location = new System.Drawing.Point(126, 2);
            this.tbPassword.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.tbPassword.CustomButton.Name = "";
            this.tbPassword.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.tbPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbPassword.CustomButton.TabIndex = 1;
            this.tbPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbPassword.CustomButton.UseSelectable = true;
            this.tbPassword.CustomButton.Visible = false;
            this.tbPassword.Lines = new string[0];
            this.tbPassword.Location = new System.Drawing.Point(253, 180);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(4);
            this.tbPassword.MaxLength = 32767;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '\0';
            this.tbPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbPassword.SelectedText = "";
            this.tbPassword.SelectionLength = 0;
            this.tbPassword.SelectionStart = 0;
            this.tbPassword.ShortcutsEnabled = true;
            this.tbPassword.Size = new System.Drawing.Size(152, 28);
            this.tbPassword.TabIndex = 5;
            this.tbPassword.UseSelectable = true;
            this.tbPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // labelUsuario
            // 
            this.labelUsuario.Location = new System.Drawing.Point(171, 124);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(70, 28);
            this.labelUsuario.TabIndex = 7;
            this.labelUsuario.Text = "Usuario";
            this.labelUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelUsuario.Click += new System.EventHandler(this.labelUsuario_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Inter Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(151, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(317, 70);
            this.label3.TabIndex = 9;
            this.label3.Text = "Iniciar sesión";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(146, 285);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(306, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // labelContraseña
            // 
            this.labelContraseña.Location = new System.Drawing.Point(154, 180);
            this.labelContraseña.Name = "labelContraseña";
            this.labelContraseña.Size = new System.Drawing.Size(84, 28);
            this.labelContraseña.TabIndex = 11;
            this.labelContraseña.Text = "Contraseña";
            this.labelContraseña.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelContraseña.Click += new System.EventHandler(this.labelContraseña_Click);
            // 
            // vLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(599, 464);
            this.Controls.Add(this.labelContraseña);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.btnLogin);
            this.Font = new System.Drawing.Font("Inter Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "vLogin";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Resizable = false;
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.PictureBox pictureBox1;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label labelUsuario;

        #endregion

        private MetroFramework.Controls.MetroButton btnLogin;
        private MetroFramework.Controls.MetroTextBox tbUser;
        private MetroFramework.Controls.MetroTextBox tbPassword;
        private System.Windows.Forms.Label labelContraseña;
    }
}