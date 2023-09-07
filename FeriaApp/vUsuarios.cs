using Clases;
using MetroFramework.Controls;
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
    public partial class vUsuarios : UserControl
    {
        NegocioComuna negocioComuna = new NegocioComuna();
        // Lista para almacenar las instancias de Comuna
        List<Comuna> comunas = new List<Comuna>();

        public vUsuarios()
        {
            InitializeComponent();
        }

        private void vUsuarios_Load(object sender, EventArgs e)
        {
            ObtenerComunasDesdeDataSet();
            metroTabControl1.SelectedTab = metroTabPageUsuarios;
            metroComboBoxTipoCuenta.SelectedIndex = 1;
            metroRadioButtonEstadoCuenta1.Checked = true;
            ocultarDatos();

            // llenar el combobox con las comunas
            metroComboBoxComuna.DataSource = comunas; 
            metroComboBoxComuna.DisplayMember = "NombreComuna"; // Muestra el nombre de la comuna
            metroComboBoxComuna.ValueMember = "IdComuna"; // Utiliza el ID de la comuna como valor seleccionado
            metroComboBoxComuna.DropDownHeight = 200; // Establece la altura máxima en píxeles
        }

        private void metroComboBoxTipoCuenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            ocultarDatos();
        }

        private void ocultarDatos()
        {
            int selectedIndex = metroComboBoxTipoCuenta.SelectedIndex;

            if (selectedIndex == 3) // Condicion para usuario productor
            {
                // Rut
                metroLabelRut.Visible = true;
                metroLabelRutDV.Visible = true;
                metroTextBoxRut.Visible = true;
                metroTextBoxRutDV.Visible = true;

                // Direccion 
                metroLabelDireccion.Visible = true;
                metroLabelComuna.Visible = true;
                metroTextBoxDireccion.Visible = true;
                metroComboBoxComuna.Visible = true;

                // Razon Social y Giro social
                metroLabelRazonSocial.Visible = true;
                metroLabelGiro.Visible = true;
                metroTextBoxRazonSocial.Visible = true;
                metroTextBoxGiro.Visible = true;

            }
            else
            {
                // Rut
                metroLabelRut.Visible = false;
                metroLabelRutDV.Visible = false;
                metroTextBoxRut.Visible = false;
                metroTextBoxRutDV.Visible = false;

                // Direccion 
                metroLabelDireccion.Visible = false;
                metroLabelComuna.Visible = false;
                metroTextBoxDireccion.Visible = false;
                metroComboBoxComuna.Visible = false;

                // Razon Social y Giro social
                metroLabelRazonSocial.Visible = false;
                metroLabelGiro.Visible = false;
                metroTextBoxRazonSocial.Visible = false;
                metroTextBoxGiro.Visible = false;
            }
        }

        public List<Comuna> ObtenerComunasDesdeDataSet()
        {
            // Llamar a la función para obtener el DataSet
            DataSet dataSet = negocioComuna.listarComunas();

            // Comprobar si el DataSet contiene datos
            if (dataSet != null && dataSet.Tables.Count > 0 && dataSet.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    Comuna comuna = new Comuna();
                    comuna.IdComuna = Convert.ToInt32(row["ID"]);
                    comuna.NombreComuna = row["NOMBRE_COMUNA"].ToString();
                    comuna.IdProvincia = Convert.ToInt32(row["ID_PROVINCIA"]);

                    comunas.Add(comuna);
                }
            }

            return comunas;
        }

        void limpiarCrearUsuario()
        {
            metroTextBoxNombreUsuario.Text = "";
            metroTextBoxContrasena.Text = "";
            metroComboBoxTipoCuenta.SelectedIndex = 1;
            metroRadioButtonEstadoCuenta1.Checked = true;

            metroTextBoxRut.Text = "";
            metroTextBoxRutDV.Text = "";
            metroTextBoxRazonSocial.Text = "";
            metroTextBoxGiro.Text = "";
            metroComboBoxComuna.SelectedIndex = 0;
            metroTextBoxDireccion.Text = "";
        }

        private void metroButtonLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCrearUsuario();
        }

        private void metroButtonAgregarUsuario_Click(object sender, EventArgs e)
        {

        }
    }

}
