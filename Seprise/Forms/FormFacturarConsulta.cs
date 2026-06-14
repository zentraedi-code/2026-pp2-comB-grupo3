using System;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using Seprise.dao;
using Seprise.entity;

namespace Seprise
{
    public partial class FormFacturarConsulta : Form
    {
        private string? ultimoPacienteEmitido = null;
        private string? ultimoDniEmitido = null;
        private string? ultimoConceptoEmitido = null;
        private string? ultimoMedicoEmitido = null;
        private string? ultimoImporteEmitido = null;
        private string? ultimoMedioPagoEmitido = null;
        private int? pacienteIdSeleccionado = null;
        private int? turnoIdSeleccionado = null;
        private DataTable? dtConsultasActuales = null;
        private decimal importeBase = 0m;
        private Label lblImporteValor;

        public FormFacturarConsulta()
        {
            InitializeComponent();

            lblImporteValor = new Label
            {
                AutoSize = false,
                Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold),
                ForeColor = System.Drawing.Color.FromArgb(0, 150, 136),
                Location = new System.Drawing.Point(520, 188),
                Size = new System.Drawing.Size(220, 30),
                TextAlign = System.Drawing.ContentAlignment.MiddleRight,
                Text = "$0.00"
            };
            pnlFacturacion.Controls.Add(lblImporteValor);
            txtImporte.Visible = false;
            cmbMedioPago.SelectedIndexChanged += cmbMedioPago_SelectedIndexChanged;

            if (!IsDesignMode())
            {
                CargarDatosIniciales();
            }
        }

        private bool IsDesignMode()
        {
            return LicenseManager.UsageMode == LicenseUsageMode.Designtime || (Site != null && Site.DesignMode);
        }

        private void CargarDatosIniciales()
        {
            cmbMedioPago.Items.Clear();
            cmbMedioPago.Items.AddRange(new string[] { "Efectivo", "Débito", "Crédito", "Obra social" });
            if (cmbMedioPago.Items.Count > 0)
                cmbMedioPago.SelectedIndex = 0;

            txtConcepto.Text = "Consulta médica";
            ActualizarObraSocialCampos();
            ActualizarImporte();
        }

        private void cmbMedioPago_SelectedIndexChanged(object? sender, EventArgs e)
        {
            ActualizarObraSocialCampos();
        }

        private void ActualizarObraSocialCampos()
        {
            bool esObraSocial = cmbMedioPago.SelectedItem?.ToString()?.Equals("Obra social", StringComparison.OrdinalIgnoreCase) == true;

            if (esObraSocial)
            {
                if (!pacienteIdSeleccionado.HasValue)
                {
                    MessageBox.Show("Debe buscar y seleccionar un paciente antes de elegir Obra Social como medio de pago.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbMedioPago.SelectedIndex = 0; 
                    return;
                }

                try
                {
                    PacienteDao pacienteDao = new PacienteDao();
                    var paciente = pacienteDao.buscar(txtDniPaciente.Text.Trim());

                    if (paciente == null)
                    {
                        MessageBox.Show("Error al revalidar los datos del paciente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cmbMedioPago.SelectedIndex = 0;
                        return;
                    }

                    if (!paciente.Activo || string.IsNullOrWhiteSpace(paciente.ObraSocial) || 
                        paciente.ObraSocial.Equals("PARTICULAR", StringComparison.OrdinalIgnoreCase))
                    {
                        MessageBox.Show("El paciente no cuenta con una cobertura de Obra Social activa en el sistema o figura como Particular.\nNo puede utilizar este medio de pago.", 
                                        "Paciente No Activo / Sin Cobertura", 
                                        MessageBoxButtons.OK, 
                                        MessageBoxIcon.Stop);
                        
                        cmbMedioPago.SelectedIndex = 0; 
                        return;
                    }

                    txtObraSocialNombre.Text = paciente.ObraSocial;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al validar obra social del paciente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbMedioPago.SelectedIndex = 0;
                    return;
                }
            }

            lblObraSocialNombre.Visible = esObraSocial;
            txtObraSocialNombre.Visible = esObraSocial;
            lblNumeroSocio.Visible = esObraSocial;
            txtNumeroSocio.Visible = esObraSocial;
            lblNumeroCobertura.Visible = esObraSocial;
            txtNumeroCobertura.Visible = esObraSocial;

            if (!esObraSocial)
            {
                txtObraSocialNombre.Clear();
                txtNumeroSocio.Clear();
                txtNumeroCobertura.Clear();
            }

            ActualizarImporte();
        }

        private void ActualizarImporte()
        {
            bool esObraSocial = cmbMedioPago.SelectedItem?.ToString()?.Equals("Obra social", StringComparison.OrdinalIgnoreCase) == true;

            decimal importeFinal = importeBase;
            if (cmbMedioPago.SelectedItem?.ToString()?.Equals("Crédito", StringComparison.OrdinalIgnoreCase) == true)
            {
                importeFinal = Math.Round(importeBase * 1.10m, 2);
            }
            else if (esObraSocial)
            {
                importeFinal = 0; 
            }

            lblImporteValor.Text = importeFinal > 0 ? $"${importeFinal:0.00}" : "$0.00";
            txtImporte.Text = importeFinal.ToString("0.00");
        }

        private void btnBuscarPaciente_Click(object sender, EventArgs e)
        {
            lblMensajes.Text = string.Empty;
            string dni = txtDniPaciente.Text?.Trim() ?? string.Empty;

            if (string.IsNullOrEmpty(dni))
            {
                lblMensajes.Text = "Ingrese un DNI para buscar.";
                return;
            }

            try
            {
                PacienteDao pacienteDao = new PacienteDao();
                var paciente = pacienteDao.buscar(dni);

                if (paciente == null)
                {
                    lblMensajes.Text = "No se encontró un paciente a facturar con ese DNI.";
                    lblDatosPacienteInfo.Text = "Los datos del paciente aparecerán aquí";
                    txtMedico.Clear();
                    txtImporte.Clear();
                    turnoIdSeleccionado = null;
                    pacienteIdSeleccionado = null;
                    return;
                }

                pacienteIdSeleccionado = paciente.Id;
                lblDatosPacienteInfo.Text = $"Paciente: {paciente.Apellido}, {paciente.Nombre}\nDNI: {paciente.Dni}";
                txtMedico.Clear();
                txtImporte.Clear();
                turnoIdSeleccionado = null;

                TurnoConsultaDao turnoDao = new TurnoConsultaDao();
                dtConsultasActuales = turnoDao.buscarRecepcionadosPorPaciente(paciente.Id, null);

                if (dtConsultasActuales == null || dtConsultasActuales.Rows.Count == 0)
                {
                    lblMensajes.Text = "No hay turnos recepcionados para facturar para este paciente.";
                    return;
                }

                var primeraConsulta = dtConsultasActuales.Rows[0];
                turnoIdSeleccionado = Convert.ToInt32(primeraConsulta["id"]);
                txtMedico.Text = primeraConsulta["medico"]?.ToString() ?? string.Empty;
                string especialidad = primeraConsulta["especialidad"]?.ToString() ?? "Consulta médica";
                txtConcepto.Text = $"Consulta - {especialidad}";
                ultimoConceptoEmitido = txtConcepto.Text;
                importeBase = Convert.ToDecimal(primeraConsulta["importe_consulta"]);
                
              
                cmbMedioPago.SelectedIndex = 0; 
                ActualizarImporte();

                lblMensajes.Text = dtConsultasActuales.Rows.Count == 1
                    ? "Consulta cargada para facturar." 
                    : $"Se cargó la primera de {dtConsultasActuales.Rows.Count} consulta(s) recepcionada(s).";
            }
            catch (Exception ex)
            {
                lblMensajes.Text = $"Error al buscar paciente: {ex.Message}";
                txtMedico.Clear();
                txtImporte.Clear();
                turnoIdSeleccionado = null;
                pacienteIdSeleccionado = null;
            }
        }

        private void btnEmitir_Click(object sender, EventArgs e)
        {
            if (!pacienteIdSeleccionado.HasValue || !turnoIdSeleccionado.HasValue)
            {
                MessageBox.Show("Debe seleccionar una consulta para facturar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (importeBase <= 0 && cmbMedioPago.SelectedItem?.ToString() != "Obra social")
            {
                MessageBox.Show("El importe debe ser un número mayor a cero.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal importe = importeBase;
            bool esCredito = cmbMedioPago.SelectedItem?.ToString()?.Equals("Crédito", StringComparison.OrdinalIgnoreCase) == true;
            if (esCredito)
            {
                importe = Math.Round(importeBase * 1.10m, 2);
            }

            string tipoCobertura = "PARTICULAR";
            bool esObraSocial = cmbMedioPago.SelectedItem?.ToString() == "Obra social";
            
            if (esObraSocial)
            {
                tipoCobertura = "OBRA_SOCIAL";

                if (string.IsNullOrWhiteSpace(txtObraSocialNombre.Text))
                {
                    MessageBox.Show("Debe ingresar la obra social.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtNumeroSocio.Text))
                {
                    MessageBox.Show("Debe ingresar el número de socio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtNumeroCobertura.Text))
                {
                    MessageBox.Show("Debe ingresar el número de cobertura.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                
                importe = 0; 
            }

            try
            {
                Factura factura = new Factura(
                    0,
                    pacienteIdSeleccionado.Value,
                    turnoIdSeleccionado.Value,
                    null,
                    importe,
                    tipoCobertura,
                    "EMITIDA",
                    DateTime.Now
                );

                FacturaDao facturaDao = new FacturaDao();
                bool insertado = facturaDao.agregar(factura);

                if (!insertado)
                {
                    MessageBox.Show("No se pudo emitir la factura.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string[] lineasPaciente = lblDatosPacienteInfo.Text.Split('\n');
                ultimoPacienteEmitido = lineasPaciente[0].Replace("Paciente: ", "").Trim();
                ultimoDniEmitido = lineasPaciente.Length > 1 ? lineasPaciente[1].Replace("DNI: ", "").Trim() : txtDniPaciente.Text;
                ultimoMedicoEmitido = txtMedico.Text;
                ultimoImporteEmitido = lblImporteValor.Text;
                ultimoMedioPagoEmitido = cmbMedioPago.SelectedItem?.ToString() ?? "Efectivo";
                
                MessageBox.Show("Factura emitida exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al emitir factura: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarFormulario()
        {
            pacienteIdSeleccionado = null;
            turnoIdSeleccionado = null;
            dtConsultasActuales = null;
            importeBase = 0m;
            txtDniPaciente.Clear();

            lblDatosPacienteInfo.Text =
                "Los datos del paciente aparecerán aquí\n" +
                "Buscá por DNI para ver la información del paciente.";

            lblMensajes.Text = "";
            txtMedico.Clear();
            cmbMedioPago.SelectedIndex = 0;

            txtObraSocialNombre.Clear();
            txtNumeroSocio.Clear();
            txtNumeroCobertura.Clear();

            lblImporteValor.Text = "$0.00";
            txtImporte.Text = "0.00";

            ActualizarObraSocialCampos();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ultimoPacienteEmitido))
            {
                MessageBox.Show("Debe emitir una factura antes de poder imprimir el comprobante.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                string contenido = $"FACTURA DE CONSULTA MÉDICA\r\n" +
                                $"========================================\r\n" +
                                $"Paciente: {ultimoPacienteEmitido}\r\n" +
                                $"DNI: {ultimoDniEmitido}\r\n" + 
                                $"Médico: {ultimoMedicoEmitido}\r\n" +
                                $"Concepto: {ultimoConceptoEmitido}\r\n" +
                                $"Importe: {ultimoImporteEmitido}\r\n" +
                                $"Medio de pago: {ultimoMedioPagoEmitido}\r\n" +
                                $"Estado: EMITIDA\r\n" +
                                $"Fecha emisión: {DateTime.Now:dd/MM/yyyy HH:mm:ss}\r\n" +
                                $"========================================";

                using (var preview = new FormExportPreview(contenido))
                {
                    preview.ShowDialog(this);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al imprimir: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}