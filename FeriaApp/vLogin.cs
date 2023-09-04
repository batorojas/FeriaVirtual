using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases;
using Negocios;

namespace FeriaApp
{
    public partial class vLogin : MetroForm
    {
        private vMain ventanaSecundaria;
        public vLogin()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnLogin;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this, "OK", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //MetroFramework.MetroMessageBox.Show(this, "Message", "Title", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear una instancia de Login y asignar los valores de los campos de entrada
                Sesion loginData = new Sesion();
                ServicioBaseDatos neg = new ServicioBaseDatos();
                loginData.Username = tbUser.Text;
                loginData.Password = tbPassword.Text;

                //if (loginData.Username == "admin" && loginData.Password == "123")
                if (neg.IngresarSistema(loginData))
                {

                    ventanaSecundaria = new vMain();
                    ventanaSecundaria.FormClosed += vMain_FormClosed;
                    ventanaSecundaria.Show(); // ventanaSecundaria.Show(); o nuevaVentana.ShowDialog();
                    this.Hide();

                }
                else
                {
                    // Autenticación fallida, mostrar un mensaje de error
                    MetroMessageBox.Show(this, "Credenciales incorrectas. \n\nInténtalo de nuevo.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }

        }
        private void vMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close(); // Cierra la ventana principal cuando la ventana secundaria se cierra
        }

        private void labelUsuario_Click(object sender, EventArgs e)
        {

        }

        private void labelContraseña_Click(object sender, EventArgs e)
        {

        }
    }
}
