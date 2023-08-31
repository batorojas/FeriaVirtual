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

namespace FeriaApp
{
    public partial class vMain : MetroForm
    {
        private vAdministrador ventanaAdministrador;
        private vProductores ventanaProductores;
        private vVentas ventanaVentas;

        public vMain()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            ventanaAdministrador = new vAdministrador();
            ventanaAdministrador.ShowDialog();
        }

        private void metroButtonProductores_Click(object sender, EventArgs e)
        {
            ventanaProductores = new vProductores();
            ventanaProductores.ShowDialog();
        }

        private void metroButtonVentas_Click(object sender, EventArgs e)
        {
            ventanaVentas = new vVentas();
            ventanaVentas.ShowDialog();
        }
    }
}
