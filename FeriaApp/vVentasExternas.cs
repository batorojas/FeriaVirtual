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
using Negocios;

namespace FeriaApp
{
    public partial class vVentasExternas : UserControl
    {
        public vVentasExternas()
        {
            InitializeComponent();
        }

        private void vVentasExternas_Load(object sender, EventArgs e)
        {
            NegocioVenta negocioVenta = new NegocioVenta();
            DataSet listaVenta = negocioVenta.listarVenta();
            this.dgvListaVentas.AutoGenerateColumns = true;
            this.dgvListaVentas.DataSource = listaVenta.Tables["CABECERA_PV"];
        }

        private void dgvListaVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}
