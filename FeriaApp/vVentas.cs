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
    public partial class vVentas : MetroForm
    {
        public vVentas()
        {
            InitializeComponent();
            //tabControl1.DrawItem += new DrawItemEventHandler(tabControl1_DrawItem);
            //this.tabControl1 = new TabControls.DotNetBarTabControl();

        }

        private void vVentas_Load(object sender, EventArgs e)
        {
            NegocioVenta negocioVenta = new NegocioVenta();
            DataSet listaVenta = negocioVenta.ListarVenta();

            this.dgvListaVentas.AutoGenerateColumns = true;
            this.dgvListaVentas.DataSource = listaVenta.Tables["CABECERA_PV"];
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvListaVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //private void tabControl1_DrawItem(Object sender, System.Windows.Forms.DrawItemEventArgs e)
        //{
        //    string tabName = tabControl1.TabPages[e.Index].Text;
        //    StringFormat stringFormat = new StringFormat();
        //    stringFormat.Alignment = StringAlignment.Center;
        //    stringFormat.LineAlignment = StringAlignment.Center;
        //    //Find if it is selected, this one will be hightlighted...
        //    if (e.Index == tabControl1.SelectedIndex)
        //        e.Graphics.FillRectangle(Brushes.LightBlue, e.Bounds);
        //    e.Graphics.DrawString(tabName, this.Font, Brushes.Black, tabControl1.GetTabRect(e.Index), stringFormat);
        //}
    }
}
