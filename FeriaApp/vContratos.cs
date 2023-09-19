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
    public partial class vContratos : UserControl
    {
        NegocioContrato negocioContrato = new NegocioContrato();
        int idContratoSeleccionado;
        public vContratos()
        {
            InitializeComponent();
        }
        private void vContratos_Load(object sender, EventArgs e)
        {
            //metroTabControl1.SelectedTab = null;
            metroTabControl1.SelectedIndex = 0;
        }
        private void metroTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tabIndex = metroTabControl1.SelectedIndex;

            switch (tabIndex)
            {
                case 0:
                    tabContratos();
                    break;
                
                case 1:
                    //tabCrearContrato();
                    break;
            }
        }

        private void metroDateTime2_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void tabContratos()
        {
            // Pestaña Contratos
            
            // Listar Contratos
            
            DataSet listaContratos = negocioContrato.retornarContratos();
            metroGridListaContratos.AutoGenerateColumns = true;
            metroGridListaContratos.DataSource = listaContratos.Tables["CONTRATO"];
        }

        private void CrearContrato()
        {
            try
            {
                Contrato contrato = new Contrato();
                contrato.IdContrato = negocioContrato.obtenerUltimoIDContrato();
                contrato.FechaInicio = metroFechaInicioContrato.Value;
                contrato.FechaTermino = metroFechaTerminoContrato.Value;
                contrato.RutProductor = Convert.ToInt32(metroTextRutProductorContrato.Text);
                negocioContrato.ingresarContrato(contrato);
                MessageBox.Show("Contrato Agregado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL INTENTAR INGRESAR CONTRATO");
            }
        }
        private void buttonCrearContrato_Click(object sender, EventArgs e)
        {
            CrearContrato();
        }
        private void eliminarContrato()
        {
            try
            {
                // Obtener el ID del usuario desde la variable de clase
                int idContrato = idContratoSeleccionado;

                // Verificar si se ha seleccionado un usuario válido
                if (idContrato > 0)
                {
                    NegocioContrato negocioContrato = new NegocioContrato();
                    negocioContrato.eliminarContrato(idContrato);
                    MessageBox.Show("Contrato eliminado");
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un contrato para eliminar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL ELIMINAR CONTRATO: " + ex.Message);
            }
        }
        
        private void buttonEliminarContrato_Click(object sender, EventArgs e)
        {
            eliminarContrato();
        }
        
        public void actualizarContrato()
        {
            try
            {
                Contrato contrato = new Contrato();
                contrato.FechaInicio = dateModificarFechaInicio.Value;
                contrato.FechaTermino = dateModificarFechaTermino.Value;
                contrato.RutProductor = Convert.ToInt32(textModificarRPContrato.Text);
                negocioContrato.actualizarContrato(contrato);
                MessageBox.Show("Contrato Actualizado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL INTENTAR ACTUALIZAR CONTRATO");
            }
        }
        
        private void buttonModificarContrato_Click(object sender, EventArgs e)
        {
            actualizarContrato();
        }
        
        private void metroGridListaContratos_SelectionChanged(object sender, EventArgs e)
        {
            //Verificar si hay al menos una fila seleccionada
            if (metroGridListaContratos.SelectedRows.Count > 0)
            {
                object idContratoValue = metroGridListaContratos.SelectedRows[0].Cells["ID_CONTRATO"].Value;
                if (idContratoValue != DBNull.Value)
                {
                    int idContrato = Convert.ToInt32(metroGridListaContratos.SelectedRows[0].Cells["ID_CONTRATO"].Value);
                    DateTime fechaInicio = DateTime.Parse(metroGridListaContratos.SelectedRows[0].Cells["FECHA_INICIO"].Value.ToString());
                    DateTime fechaTermino = DateTime.Parse(metroGridListaContratos.SelectedRows[0].Cells["FECHA_TERMINO"].Value.ToString());
                    int RutProductor = Convert.ToInt32(metroGridListaContratos.SelectedRows[0].Cells["RUT_PRODUCTOR"].Value);
                    idContratoSeleccionado = idContrato;
                }
                else
                {
                    idContratoSeleccionado = 0;
                }
            }
        }
    }
}
