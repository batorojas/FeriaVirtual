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
    public partial class vDetallePostulacionProductor : UserControl
    {
        private int id;

        public vDetallePostulacionProductor()
        {
            InitializeComponent();
        }

        public int IdCabezera
        {
            get { return id; }
            set { id = value; }
        }

        private void vDetallePostulacionProductor_Load(object sender, EventArgs e)
        {
            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            metroLabel1.Text = id.ToString();
        }
    }
}
