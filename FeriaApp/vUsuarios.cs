﻿using Clases;
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
using MetroFramework;

namespace FeriaApp
{
    public partial class vUsuarios : UserControl
    {
        NegocioComuna negocioComuna = new NegocioComuna();
        NegocioTipoCliente negocioTipoCliente = new NegocioTipoCliente();
        NegocioPerfil negocioPerfil = new NegocioPerfil();
        NegocioUsuario negocioUsuarios = new NegocioUsuario();
        NegocioEmpresaTransporte negocioEmpresaTransporte = new NegocioEmpresaTransporte();

        // Lista para almacenar las instancias de Comuna
        List<Comuna> comunas = new List<Comuna>();

        // Lista para almacenar las instancias de TipoCliente
        List<TipoCliente> tiposClientes = new List<TipoCliente>();

        // Lista para almacenar las instancias de Perfil
        List<Perfil> perfiles = new List<Perfil>();

        // Lista para almacenar las instancias de Transporte
        List<EmpresaTransporte> transporte = new List<EmpresaTransporte>();

        int idUsuarioSeleccionado;


        public vUsuarios()
        {
            InitializeComponent();
        }

        private void vUsuarios_Load(object sender, EventArgs e)
        {
            //metroTabControl1.SelectedTab = null;
            metroTabControl1.SelectedIndex = 0;

            // Listado de usuarios
            DataSet listaUsuarios = negocioUsuarios.retornarUsuarios();
            metroGridListaUsuarios.AutoGenerateColumns = true;
            metroGridListaUsuarios.DataSource = listaUsuarios.Tables["USUARIO"]; // Listar usuarios

        }

        private void metroTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtén el índice de la pestaña actualmente seleccionada
            int tabIndex = metroTabControl1.SelectedIndex;

            // Ejecuta funciones basadas en la pestaña seleccionada
            switch (tabIndex)
            {
                case 0:
                    tabClientes();
                    break;

                case 1:
                    tabCrearCliente();
                    break;

                case 2:
                    // Pestaña Editar Clientes
                    break;

                //default:
                //    MessageBox.Show("Pestaña no reconocida");
                //    break;
            }
        }

        private void tabClientes()
        {
            // PESTAÑA USUARIOS

        }

        private void tabCrearCliente()
        {
            // PESTAÑA CREAR USUARIO
            obtenerComunasDesdeDataSet();
            obtenerTipoClienteDesdeDataSet();
            obtenerTipoPerfilDesdeDataSet();
            metroRadioButtonEstadoCuentaActiva.Checked = true;

            // llenar el combobox con las Comunas
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

            //metroComboBoxTipoCuenta.SelectedIndex = 1; // Seleciona automaticamente el tipo de cuenta a tipo Cliente
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

                // Empresa Transporte
                metroLabelEmpresaTransporte.Visible = false;
                metroTextBoxEmpresaTransporte.Visible = false;
                
            }
            else if (selectedIndex == 2) // Condicion para usuario transportista
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

                // Empresa Transporte
                metroLabelEmpresaTransporte.Visible = true;
                metroTextBoxEmpresaTransporte.Visible = true;

            }
            else if (selectedIndex == 3) // Condicion para usuario productor
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

                // Empresa Transporte
                metroLabelEmpresaTransporte.Visible = false;
                metroTextBoxEmpresaTransporte.Visible = false;

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

                // Empresa Transporte
                metroLabelEmpresaTransporte.Visible = false;
                metroTextBoxEmpresaTransporte.Visible = false;

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
            metroComboBoxTipoCuenta.SelectedIndex = 0;
            metroRadioButtonEstadoCuentaActiva.Checked = true;

            metroTextBoxRut.Text = "";
            metroTextBoxRutDV.Text = "";
            metroTextBoxRazonSocial.Text = "";
            metroTextBoxGiro.Text = "";
            metroComboBoxComuna.SelectedIndex = 0;
            metroTextBoxDireccion.Text = "";
            metroComboBoxTipoCliente.SelectedIndex = 0;

            // Devolver color original a los Labels
            metroLabelNombreUsuario.ForeColor = SystemColors.ControlText;
            metroLabelContrasena.ForeColor = SystemColors.ControlText;
            metroLabelRut.ForeColor = SystemColors.ControlText;
            metroLabelRutDV.ForeColor = SystemColors.ControlText;
            metroLabelRazonSocial.ForeColor = SystemColors.ControlText;
            metroLabelGiro.ForeColor = SystemColors.ControlText;
            metroLabelDireccion.ForeColor = SystemColors.ControlText;

        }

        private bool ValidarCampos()
        {
            // Recorre cada TextBox para ver si hay datos en blanco
            MetroTextBox[] textBoxes = { 
                metroTextBoxNombreUsuario,
                metroTextBoxContrasena,
                metroTextBoxRut,
                metroTextBoxRutDV,
                metroTextBoxRazonSocial,
                metroTextBoxGiro,
                metroTextBoxDireccion };

            MetroLabel[] labels = {
                metroLabelNombreUsuario,
                metroLabelContrasena,
                metroLabelRut,
                metroLabelRutDV,
                metroLabelRazonSocial,
                metroLabelGiro,
                metroLabelDireccion };

            bool allCorrect = true;
            for (int i = 0; i < textBoxes.Length; i++)
            {
                if (textBoxes[i].Visible && labels[i].Visible) // Verificar si el MetroLabel y el MetroTextBox estan visibles
                {
                    if (string.IsNullOrEmpty(textBoxes[i].Text))
                    {
                        labels[i].ForeColor = Color.Red;
                        allCorrect = false; // Cambia allCorrect a false solo si se encuentra un campo en blanco
                    }
                    else
                    {
                        labels[i].ForeColor = SystemColors.ControlText;
                    }
                }
            }
            return allCorrect;
        }

        private void metroButtonAgregarUsuario_Click(object sender, EventArgs e)
        {
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

            //MessageBox.Show($"Valor seleccionado: {valorSeleccionado1}");

            ingresarUsuario();
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

            // Selecciona estado cuenta segun opcion el RadioButton elegido
            int estadoCuenta = 1;
            if (metroRadioButtonEstadoCuentaActiva.Checked)
            {
                estadoCuenta = 1;
            }
            else if (metroRadioButtonEstadoCuentaInactiva.Checked)
            {
                estadoCuenta = 2;
            }
            else
            {
                MessageBox.Show("Ninguna opción seleccionada en Estado de Cuenta");
            }


            int valorTipoCuenta = retornarValorComboboxSeleccionado(metroComboBoxTipoCuenta);
            int valorComuna = retornarValorComboboxSeleccionado(metroComboBoxComuna);
            int valorTipoCliente = retornarValorComboboxSeleccionado(metroComboBoxTipoCliente);


            // Case Switch para Insertar cada Tipo de Usuario (PERFIL)
            int opcion = valorTipoCuenta; // Cambia el valor de 'opcion' según necesidades

            switch (opcion)
            {
                case 1:
                    // Realizar acción para la opción Administrador
                    try
                    {
                        bool camposLlenos = ValidarCampos();
                        if (!camposLlenos)
                        {
                            // Mensaje de error al detectar uno o mas de un TextBox en blanco
                            MessageBox.Show("Rellene todos los campos del formulario");
                            return;
                        }

                        NegocioUsuario negocioUsuario = new NegocioUsuario();

                        Usuario nuevoUsuario = new Usuario();                        
                        nuevoUsuario.UserName = this.metroTextBoxNombreUsuario.Text;
                        nuevoUsuario.Password = this.metroTextBoxContrasena.Text;
                        nuevoUsuario.IdPerfil = valorTipoCuenta;
                        nuevoUsuario.IdEstadoCuenta = estadoCuenta; // RadioButton Estado Cuenta
                        
                        negocioUsuario.ingresarUsuario(nuevoUsuario);

                        MessageBox.Show("Usuario Agregado");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERROR AL INTENTAR INGRESAR USUARIO" + ex);
                    }
                    break;

                case 2:
                    // Realizar acción para la opción Cliente
                    try
                    {
                        bool camposLlenos = ValidarCampos();
                        if (!camposLlenos)
                        {
                            // Mensaje de error al detectar uno o mas de un TextBox en blanco
                            MessageBox.Show("Rellene todos los campos del formulario");
                            return;
                        }

                        NegocioUsuario negocioUsuario = new NegocioUsuario();
                        NegocioCliente negocioCliente = new NegocioCliente();

                        Usuario nuevoUsuarioCliente = new Usuario();
                        nuevoUsuarioCliente.UserName = this.metroTextBoxNombreUsuario.Text;
                        nuevoUsuarioCliente.Password = this.metroTextBoxContrasena.Text;
                        nuevoUsuarioCliente.IdPerfil = valorTipoCuenta;
                        nuevoUsuarioCliente.IdEstadoCuenta = estadoCuenta;

                        negocioUsuario.ingresarUsuario(nuevoUsuarioCliente);

                        Cliente nuevoCliente = new Cliente();
                        nuevoCliente.DireccionCliente = this.metroTextBoxDireccion.Text;
                        nuevoCliente.RazonSocialCliente = this.metroTextBoxRazonSocial.Text;
                        nuevoCliente.GiroCliente = this.metroTextBoxGiro.Text;
                        nuevoCliente.RutCliente = Int32.Parse(this.metroTextBoxRut.Text);
                        nuevoCliente.DvRutCliente = this.metroTextBoxRutDV.Text;
                        nuevoCliente.IdComunaCliente = valorComuna;
                        nuevoCliente.IdUsuarioCliente = negocioUsuario.obtenerUltimoIdUsuario();
                        nuevoCliente.IdTipoCliente = valorTipoCliente;
                                                
                        negocioCliente.ingresarCliente(nuevoCliente);
                        
                        MessageBox.Show("Usuario Agregado");
                    }
                    catch (Exception ex) 
                    { 
                        MessageBox.Show("ERROR AL INTENTAR INGRESAR USUARIO" + ex); 
                    }
                    break;

                case 3:
                    // Realizar acción para la opción Transportista
                    try
                    {
                        bool camposLlenos = ValidarCampos();
                        if (!camposLlenos)
                        {
                            // Mensaje de error al detectar uno o mas de un TextBox en blanco
                            MessageBox.Show("Rellene todos los campos del formulario");
                            return;
                        }

                        NegocioUsuario negocioUsuario = new NegocioUsuario();
                        NegocioEmpresaTransporte negocioEmpresaTransporte = new NegocioEmpresaTransporte();

                        Usuario nuevoUsuario = new Usuario();
                        nuevoUsuario.UserName = this.metroTextBoxNombreUsuario.Text;
                        nuevoUsuario.Password = this.metroTextBoxContrasena.Text;
                        nuevoUsuario.IdPerfil = valorTipoCuenta;
                        nuevoUsuario.IdEstadoCuenta = estadoCuenta; // RadioButton Estado Cuenta
                        
                        negocioUsuario.ingresarUsuario(nuevoUsuario);

                        EmpresaTransporte nuevoTransporte = new EmpresaTransporte();
                        nuevoTransporte.NombreEmpresaTransporte = this.metroTextBoxEmpresaTransporte.Text;
                        nuevoTransporte.IdUsuarioEmpresaTransporte = negocioUsuario.obtenerUltimoIdUsuario();

                        negocioEmpresaTransporte.ingresarEmpresaTransporte(nuevoTransporte);

                        MessageBox.Show("Usuario Agregado");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERROR AL INTENTAR INGRESAR USUARIO" + ex);
                    }
                    break;

                case 4:
                    // Realizar acción para la opción Productor
                    try
                    {
                        bool camposLlenos = ValidarCampos();
                        if (!camposLlenos)
                        {
                            // Mensaje de error al detectar uno o mas de un TextBox en blanco
                            MessageBox.Show("Rellene todos los campos del formulario");
                            return;
                        }

                        NegocioUsuario negocioUsuario = new NegocioUsuario();
                        NegocioProductor negocioProductor = new NegocioProductor();

                        Usuario nuevoUsuarioProductor = new Usuario();
                        nuevoUsuarioProductor.UserName = this.metroTextBoxNombreUsuario.Text;
                        nuevoUsuarioProductor.Password = this.metroTextBoxContrasena.Text;
                        nuevoUsuarioProductor.IdPerfil = valorTipoCuenta;
                        nuevoUsuarioProductor.IdEstadoCuenta = estadoCuenta;

                        negocioUsuario.ingresarUsuario(nuevoUsuarioProductor);

                        Productor nuevoProductor = new Productor();
                        nuevoProductor.DireccionProductor = this.metroTextBoxDireccion.Text;
                        nuevoProductor.RazonSocialProductor = this.metroTextBoxRazonSocial.Text;
                        nuevoProductor.GiroProductor = this.metroTextBoxGiro.Text;
                        nuevoProductor.RutProductor = Int32.Parse(this.metroTextBoxRut.Text);
                        nuevoProductor.DvRutProductor = this.metroTextBoxRutDV.Text;
                        nuevoProductor.IdComunaProductor = valorComuna;
                        nuevoProductor.IdUsuarioProductor = negocioUsuario.obtenerUltimoIdUsuario();

                        negocioProductor.ingresarProductor(nuevoProductor);

                        MessageBox.Show("Usuario Agregado");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERROR AL INTENTAR INGRESAR USUARIO" + ex);
                    }
                    break;

                default:
                    // Realizar acción predeterminada si no coincide con ninguna opción
                    MessageBox.Show("Opción de Usuario no reconocida");
                    break;
            }
        }

        private void EliminarUsuario()
        {
            try
            {
                // Obtener el ID del usuario desde la variable de clase
                int idUsuario = idUsuarioSeleccionado;

                // Verificar si se ha seleccionado un usuario válido
                if (idUsuario > 0)
                {
                    NegocioUsuario negocioUsuario = new NegocioUsuario();
                    negocioUsuario.eliminarUsuario(idUsuario);
                    MessageBox.Show("Usuario eliminado");
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un usuario primero.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL ELIMINAR USUARIO: " + ex.Message);
            }
        }

        private void metroTextBoxRut_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada es un número o la tecla Backspace (para borrar)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Si no es un número ni la tecla Backspace, no permitir la entrada
                e.Handled = true;
            }
        }

        private void metroTextBoxRutDV_KeyPress(object sender, KeyPressEventArgs e)
        {
            char[] caracteresPermitidos = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'k' };

            // Verificar si la tecla presionada está en la lista de caracteres permitidos o es la tecla Backspace (para borrar)
            if (!char.IsControl(e.KeyChar) && !caracteresPermitidos.Contains(e.KeyChar))
            {
                // Si no es un carácter permitido ni la tecla Backspace, no permitir la entrada
                e.Handled = true;
            }

            // Convertir 'k' en minúscula a 'K' en mayúscula
            if (e.KeyChar == 'k')
            {
                e.KeyChar = 'K';
            }
        }

        private void metroButtonEliminarUsuario_Click(object sender, EventArgs e)
        {
            EliminarUsuario();
        }

        private void metroGridListaUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            // Verificar si hay al menos una fila seleccionada
            if (metroGridListaUsuarios.SelectedRows.Count > 0)
            {
                // Obtener el ID del usuario seleccionado
                int idUsuario = Convert.ToInt32(metroGridListaUsuarios.SelectedRows[0].Cells["ID_USUARIO"].Value);

                // Almacenar el ID en una variable de clase para usarlo al eliminar
                idUsuarioSeleccionado = idUsuario;

                //MessageBox.Show($"ID: {idUsuarioSeleccionado}");
            }
        }
    }

}
