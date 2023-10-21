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
                // Create a new contract
                Contrato contrato = new Contrato();

                // Get the latest contract ID
                contrato.IdContrato = negocioContrato.obtenerUltimoIDContrato();

                // Set the contract start and end dates
                contrato.FechaInicio = metroFechaInicioContrato.Value;
                contrato.FechaTermino = metroFechaTerminoContrato.Value;

                // Convert the producer's Rut to an integer
                if (int.TryParse(metroTextRutProductorContrato.Text, out int rut))
                {
                    contrato.RutProductor = rut;

                    // Insert the contract into the business logic
                    negocioContrato.ingresarContrato(contrato);

                    // Display a success message
                    MessageBox.Show("Contrato Agregado");
                }
                else
                {
                    // Handle invalid producer Rut input
                    MessageBox.Show("Rut del productor no válido");
                }
            }
            catch (Exception ex)
            {
                // Log the exception for debugging purposes
                // You may want to use a logging framework like NLog or log4net
                Console.WriteLine("Error: " + ex.Message);

                // Display an error message
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
                contrato.IdContrato = Int32.Parse(this.txtbIdProductor.Text);
                contrato.FechaInicio = this.dateFechaInicioContrato.Value;
                contrato.FechaTermino = this.dateFechaTerminoContrato.Value;
                contrato.RutProductor = Int32.Parse(this.textbRutProductorContrato.Text);
                NegocioContrato negocioContrato = new NegocioContrato();
                negocioContrato.actualizarContrato(contrato);
                MessageBox.Show("El contrato se ha actualizado con éxito.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL INTENTAR ACTUALIZAR CONTRATO: "+ex);
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

        private void metroButtonModificarContrato_Click(object sender, EventArgs e)
        {
            int indiceFila = this.metroGridListaContratos.SelectedCells[0].RowIndex;
            DataGridViewRow filaSeleccionada = this.metroGridListaContratos.Rows[indiceFila];
            int idContrato = int.Parse(filaSeleccionada.Cells["ID_CONTRATO"].Value.ToString());
            metroTabControl1.SelectedIndex = 2;
            cargarDetalleContrato(idContrato);
        }

        private void cargarDetalleContrato(int id)
        {
            NegocioContrato ven = new NegocioContrato();
            Contrato contrato = ven.buscarContrato(id);

            this.txtbIdProductor.Text = contrato.IdContrato.ToString();
            this.dateFechaInicioContrato.Value = contrato.FechaInicio;
            this.dateFechaTerminoContrato.Value = contrato.FechaTermino;
            this.textbRutProductorContrato.Text = contrato.RutProductor.ToString();
        }
    }
}
