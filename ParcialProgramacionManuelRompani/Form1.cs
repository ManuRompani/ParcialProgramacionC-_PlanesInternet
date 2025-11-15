using ParcialProgramacionManuelRompani.Exceptions;
using ParcialProgramacionManuelRompani.Modelo;
using ParcialProgramacionManuelRompani.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcialProgramacionManuelRompani
{
    public partial class Form1 : Form
    {
        private ClienteContainer _clienteContainer;
        private PlanWifiContainer _planWifiContainer;

        public Form1(ClienteContainer clienteContainer, PlanWifiContainer planWifiContainer)
        {
            _clienteContainer = clienteContainer;
            _planWifiContainer = planWifiContainer;

            InitializeComponent();

            CargarClientesDGV();
            CargarTipoClientes();

        }

        private void CargarClientesDGV()
        {
            dgvClientes.DataSource = null;
            dgvClientes.DataSource = _clienteContainer.GetTodos();

            dgvClientesMas15Gb.DataSource = null;
            dgvClientesMas15Gb.DataSource = _clienteContainer.GetClientesConsumoMayor15GB();
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            int dni = 0;
            if(!int.TryParse(tboxDNI.Text, out dni))
            {
                MessageBox.Show("El DNI debe ser un valor numerico.");
                return;
            }

            string nombre = tboxNombre.Text;
            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("El nombre no puede quedar en blanco.");
                return;
            }

            int gbConsumidos = 0;
            if(!int.TryParse(tboxGbConsumidos.Text, out gbConsumidos))
            {
                MessageBox.Show("GB Consumidos debe ser un valor numerico.");
                return;
            }

            string tipoCliente = (string)cboxTipoCliente.SelectedValue;
            PlanWifi planWifi = (PlanWifi)cboxPlanWifi.SelectedValue;

            if(planWifi == null)
            {
                MessageBox.Show("El plan no puede quedar vacio.");
                return;
            }

            Cliente nuevoCliente = new Cliente(dni, nombre, tipoCliente, planWifi, gbConsumidos);

            try
            {
                _clienteContainer.Agregar(nuevoCliente);

                CargarClientesDGV();
                ClienteQueMasPaga();
                PromedioCostoMensualClientesNormales();

                tboxDNI.Text = "";
                tboxNombre.Text = "";
                tboxGbConsumidos.Text = "";

                MessageBox.Show("Se agrego al cliente correctamente.");
            }
            catch(ClienteExistException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(NegativeValueException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch
            {
                MessageBox.Show("Ocurrio un error inesperado.");
            }
        }

        private void CargarTipoClientes()
        {
            List<string> tipoClientes = new List<string>();
            tipoClientes.Add("Normal");
            tipoClientes.Add("Plus");
            tipoClientes.Add("Libre");

            cboxTipoCliente.DataSource = null;
            cboxTipoCliente.DataSource = tipoClientes;
        }

        private void btnAgregarPlanWifi_Click(object sender, EventArgs e)
        {
            string nombre = "";
            if (string.IsNullOrWhiteSpace(tboxNombrePlanWifi.Text))
            {
                MessageBox.Show("El nombre del plan no puede quedar vacío.");
                return;
            }
            nombre = tboxNombrePlanWifi.Text;

            double costoMensual = 0;
            if(!double.TryParse(tboxCostoMensual.Text, out costoMensual))
            {
                MessageBox.Show("El costo mensual debe ser un valor numerico.");
                return;
            }

            double costoGbExtra = 0;
            if (!double.TryParse(tboxCostoGbExtra.Text, out costoGbExtra))
            {
                MessageBox.Show("El costo GB extra debe ser un valor numerico.");
                return;
            }

            PlanWifi plan = new PlanWifi(nombre, costoMensual, costoGbExtra);

            try
            {
                _planWifiContainer.Agregar(plan);

                CargarPlanWifi();

                tboxNombrePlanWifi.Text = "";
                tboxCostoMensual.Text = "";
                tboxCostoGbExtra.Text = "";

                MessageBox.Show("Plan agregado correctamente");
            }
            catch(PlanWifiExistenteException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(NegativeValueException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch
            {
                MessageBox.Show("Ocurrio un error inesperado");
            }
        }

        private void CargarPlanWifi()
        {
            cboxPlanWifi.DataSource = null;
            cboxPlanWifi.DataSource = _planWifiContainer.GetTodo();
        }

        private void PromedioCostoMensualClientesNormales()
        {
            double promedio = _clienteContainer.PromedioCostoTotalMensualClientesNormales();
            lblPromedioNormales.Text = $"Promedio del costo total mensual entre clientes normales: {promedio}";
        }

        private void ClienteQueMasPaga()
        {
            Cliente clienteMasPaga = _clienteContainer.GetClienteMasPaga();

            if(clienteMasPaga != null)
            {
                lblClienteMasPaga.Text = $"El cliente que mas paga es DNI {clienteMasPaga.DNI} con un Total de {clienteMasPaga.Total}";
            }
        }
    }
}
