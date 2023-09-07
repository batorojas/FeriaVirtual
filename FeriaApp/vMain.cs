using MetroFramework.Controls;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;
using System.Windows.Forms;
using System.Windows.Media;

namespace FeriaApp
{
    public partial class vMain : MetroForm
    {
        public string ValorRecibidoSesionUsername { get; set; }

        public vMain()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // Selecciona la pestaña deseada al iniciar la aplicacion
            //tabControlMenu1.SelectedTab = null;
            tabControlMenu1.SelectedTab = tabPageInicio;
            vInicio1.NombreSesionStartPage = char.ToUpper(ValorRecibidoSesionUsername[0]) + ValorRecibidoSesionUsername.Substring(1).ToLower(); // Transforma a mayusculas la primera letra de la String
        }

        private void tabControlMenu1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (tabControlMenu1.SelectedTab == tabPageInicio) // Cambia tabPage1 al nombre de la pestaña donde deseas cargar el UserControl
            //{
            //    // Crea una instancia del UserControl y agrégalo al TabPage
            //    vInicio userControl = new vInicio(); // Reemplaza YourUserControl con el nombre de tu UserControl
            //    //tabPageInicio.Controls.Clear();
            //    tabPageInicio.Controls.Add(userControl);
            //    userControl.Dock = DockStyle.Fill; // Ajusta el tamaño del UserControl al tamaño del TabPage
            //}
        }
    }
}
