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
        NegocioTipoCliente negocioTipoCliente = new NegocioTipoCliente();
        NegocioPerfil negocioPerfil = new NegocioPerfil();

        Usuario usuario = new Usuario();
        Productor productor = new Productor();
        Cliente cliente = new Cliente();

        // Lista para almacenar las instancias de Comuna
        List<Comuna> comunas = new List<Comuna>();

        // Lista para almacenar las instancias de TipoCliente
        List<TipoCliente> tiposClientes = new List<TipoCliente>();

        // Lista para almacenar las instancias de Perfil
        List<Perfil> perfiles = new List<Perfil>();


        public vUsuarios()
        {
            InitializeComponent();
        }

        private void vUsuarios_Load(object sender, EventArgs e)
        {
            obtenerComunasDesdeDataSet();
            obtenerTipoClienteDesdeDataSet();
            obtenerTipoPerfilDesdeDataSet();
            metroTabControl1.SelectedTab = metroTabPageUsuarios;
            metroRadioButtonEstadoCuenta1.Checked = true;

            // llenar el combobox con las comunas
            metroComboBoxComuna.DataSource = comunas; 
            metroComboBoxComuna.DisplayMember = "NombreComuna"; // Muestra el nombre de la comuna
            metroComboBoxComuna.ValueMember = "IdComuna"; // Utiliza el ID de la comuna como valor seleccionado
            metroComboBoxComuna.DropDownHeight = 200; // Establece la altura máxima en píxeles

            // llenar combobox Tipo Cliente
            metroComboBoxTipoCliente.DataSource = tiposClientes;
            metroComboBoxTipoCliente.DisplayMember = "DescTipoCliente"; // Muestra el nombre de la comuna
            metroComboBoxTipoCliente.ValueMember = "IdTipoCliente"; // Utiliza el ID de la comuna como valor seleccionado

            // llenar combobox Tipo Cuenta
            metroComboBoxTipoCuenta.DataSource = perfiles;
            metroComboBoxTipoCuenta.DisplayMember = "DescPerfil"; // Muestra el nombre de la comuna
            metroComboBoxTipoCuenta.ValueMember = "IdPerfil"; // Utiliza el ID de la comuna como valor seleccionado

            metroComboBoxTipoCuenta.SelectedIndex = 1; // Seleciona automaticamente el tipo de cuenta a tipo Cliente
        }

        private void metroComboBoxTipoCuenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            ocultarDatos();
        }

        private void ocultarDatos()
        {
            int selectedIndex = metroComboBoxTipoCuenta.SelectedIndex;

            if (selectedIndex == 1) // Condicion para usuario cliente
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

                // Razon Social, Giro social y tipo cliente
                metroLabelRazonSocial.Visible = true;
                metroLabelGiro.Visible = true;
                metroTextBoxRazonSocial.Visible = true;
                metroTextBoxGiro.Visible = true;
                metroLabelTipoCliente.Visible = true;
                metroComboBoxTipoCliente.Visible = true;

            }else if (selectedIndex == 3) // Condicion para usuario productor
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

                // Razon Social, Giro social y tipo cliente
                metroLabelRazonSocial.Visible = true;
                metroLabelGiro.Visible = true;
                metroTextBoxRazonSocial.Visible = true;
                metroTextBoxGiro.Visible = true;
                metroLabelTipoCliente.Visible = false;
                metroComboBoxTipoCliente.Visible = false;

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

                // Razon Social, Giro social y tipo cliente
                metroLabelRazonSocial.Visible = false;
                metroLabelGiro.Visible = false;
                metroTextBoxRazonSocial.Visible = false;
                metroTextBoxGiro.Visible = false;
                metroLabelTipoCliente.Visible = false;
                metroComboBoxTipoCliente.Visible = false;

            }
        }

        public List<Comuna> obtenerComunasDesdeDataSet()
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

        public List<TipoCliente> obtenerTipoClienteDesdeDataSet()
        {
            // Llamar a la función para obtener el DataSet
            DataSet dataSet = negocioTipoCliente.retornarTipos();

            // Comprobar si el DataSet contiene datos
            if (dataSet != null && dataSet.Tables.Count > 0 && dataSet.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    TipoCliente tipoCliente = new TipoCliente();
                    tipoCliente.IdTipoCliente = Convert.ToInt32(row["ID_TIPO"]);
                    tipoCliente.DescTipoCliente = row["DESC_TIPO"].ToString();

                    tiposClientes.Add(tipoCliente);
                }
            }
            return tiposClientes;
        }

        public List<Perfil> obtenerTipoPerfilDesdeDataSet()
        {
            // Llamar a la función para obtener el DataSet
            DataSet dataSet = negocioPerfil.retornarPerfiles();

            // Comprobar si el DataSet contiene datos
            if (dataSet != null && dataSet.Tables.Count > 0 && dataSet.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    Perfil tipoPerfil = new Perfil();
                    tipoPerfil.IdPerfil = Convert.ToInt32(row["ID_PERFIL"]);
                    tipoPerfil.DescPerfil = row["DESC_PERFIL"].ToString();

                    perfiles.Add(tipoPerfil);
                }
            }
            return perfiles;
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
            metroComboBoxTipoCliente.SelectedIndex = 0;
        }

        private void metroButtonAgregarUsuario_Click(object sender, EventArgs e)
        {
            int valorSeleccionado1 = retornarValorComboboxSeleccionado(metroComboBoxTipoCuenta);
            int valorSeleccionado2 = retornarValorComboboxSeleccionado(metroComboBoxTipoCuenta);
            int valorSeleccionado3 = retornarValorComboboxSeleccionado(metroComboBoxTipoCuenta);

            //// Verifica si el valor seleccionado es válido (diferente de -1)
            //if (valorSeleccionado != -1)
            //{
            //    // Muestra el valor de metroComboBoxComuna.ValueMember en un MessageBox
            //    MessageBox.Show($"Valor seleccionado: {valorSeleccionado}");
            //}
            //else
            //{
            //    // Maneja la situación en la que no se pudo obtener un valor válido, si es necesario.
            //    MessageBox.Show("No se ha seleccionado un valor válido.");
            //}

            MessageBox.Show($"Valor seleccionado: {valorSeleccionado1}");
        }

        private int retornarValorComboboxSeleccionado(MetroComboBox comboBox)
        {
            // Obtén el valor seleccionado (usando el ValueMember)
            object valorSeleccionado = comboBox.SelectedValue;

            // Verifica si el valor seleccionado no es nulo y es convertible a int
            if (valorSeleccionado != null && int.TryParse(valorSeleccionado.ToString(), out int resultado))
            {
                return resultado;
            }
            else
            {
                // En caso de que no se pueda convertir, retorna un valor predeterminado (por ejemplo, -1)
                return -1;
            }
        }

        private void metroButtonLimpiarUsuario_Click(object sender, EventArgs e)
        {
            limpiarCrearUsuario();
        }

        void ingresarUsuario()
        {
            //try
            //{
            //    Usuario nuevoUsuario = new Usuario();
            //    nuevoUsuario.NombreUsuario = this.txtNombreUsuario.Text;
            //    nuevoUsuario.Password = this.txtContraseñaUsuario.Text;
            //    nuevoUsuario.IdPerfil = Int32.Parse(mcbPerfilUsuarioUsuario.SelectedValue.ToString());
            //    nuevoUsuario.IdEstadoCuenta = Int32.Parse(mcbEstadoUsuario.SelectedValue.ToString());


            //    NegocioUsuario negocioUsuario = new NegocioUsuario();
            //    negocioUsuario.IngresarUsuario(nuevoUsuario);
            //    MessageBox.Show("Usuario Agregado");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("ERROR AL INTENTAR INGRESAR USUARIO" + ex);
            //}

        }
    }

}
