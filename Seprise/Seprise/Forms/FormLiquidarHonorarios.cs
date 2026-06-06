using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Drawing;
using Seprise.dao;

namespace Seprise
{
    public partial class FormLiquidarHonorarios : Form
    {
        private List<string> pagosRegistrados = new List<string>();

        // Clase auxiliar interna para poblar el ComboBox
        private class MedicoItem
        {
            public int Id { get; set; }
            public string? Nombre { get; set; }

            public override string ToString() => Nombre ?? string.Empty;
        }

        // Estructura de datos para evitar leer texto directamente de las Labels de la UI
        private class HonorarioDTO
        {
            public int MedicoId { get; set; }
            public string MedicoNombre { get; set; } = string.Empty;
            public string Especialidad { get; set; } = string.Empty;
            public string Consultas { get; set; } = "0";
            public decimal Honorario { get; set; }
            public decimal Total { get; set; }
        }

        public FormLiquidarHonorarios()
        {
            InitializeComponent();
            InicializarGrillaConsultas();
            CargarDatosIniciales();
            // Ensure button event is wired (Designer may not wire it)
            try
            {
                this.btnPagar.Click -= BtnPagar_Click;
            }
            catch { }
            this.btnPagar.Click += BtnPagar_Click;
        }

        private void InicializarGrillaConsultas()
        {
            dgvConsultas.Columns.Clear();

            dgvConsultas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "FechaHora",
                HeaderText = "Fecha y hora",
                FillWeight = 22F,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleLeft }
            });
            dgvConsultas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Paciente",
                HeaderText = "Paciente",
                FillWeight = 26F,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleLeft }
            });
            dgvConsultas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "DNI",
                HeaderText = "DNI",
                FillWeight = 18F,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
            });
            dgvConsultas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Concepto",
                HeaderText = "Concepto",
                FillWeight = 22F,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleLeft }
            });
            dgvConsultas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Honorarios",
                HeaderText = "Honorarios",
                FillWeight = 12F,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleRight, Format = "C2" }
            });

            dgvConsultas.AllowUserToAddRows = false;
            dgvConsultas.ReadOnly = true;
            dgvConsultas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvConsultas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvConsultas.RowHeadersVisible = false;
            dgvConsultas.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 150, 136);
            dgvConsultas.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
            dgvConsultas.DefaultCellStyle.SelectionBackColor = Color.FromArgb(120, 200, 190);
            dgvConsultas.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvConsultas.Rows.Clear();
        }

        private void CargarDatosIniciales()
        {
            cmbMedico.Items.Clear();
            cmbMedico.Items.Add(new MedicoItem { Id = 0, Nombre = "Todos" });

            try
            {
                MedicoDao medicoDao = new MedicoDao();
                var medicos = medicoDao.listarActivos();

                foreach (var medico in medicos)
                {
                    cmbMedico.Items.Add(new MedicoItem { Id = medico.Id, Nombre = $"{medico.Apellido}, {medico.Nombre}" });
                }
            }
            catch (Exception ex)
            {
                MostrarMensaje($"Error al cargar médicos: {ex.Message}", true);
            }

            if (cmbMedico.Items.Count > 0)
                cmbMedico.SelectedIndex = 0;

            dtpDesde.Value = DateTime.Now.AddMonths(-1);
            dtpHasta.Value = DateTime.Now;
            ResetResumen();
            dgvConsultas.Rows.Clear();
            lblMensajes.Text = string.Empty;
        }

        private void ResetResumen()
        {
            lblResumenMedico.Text = "Nombre médico";
            lblResumenEspecialidad.Text = "Especialidad";
            lblResumenConsultasValor.Text = "0";
            lblResumenHonorariosValor.Text = "$0,00";
            lblResumenTotalValor.Text = "$0,00";
            btnPagar.Enabled = false;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            lblMensajes.Text = string.Empty;

            if (dtpDesde.Value.Date > dtpHasta.Value.Date)
            {
                MostrarMensaje("El rango de fechas no es válido.", true);
                return;
            }

            try
            {
                int? medicoId = null;
                MedicoItem? seleccionado = cmbMedico.SelectedItem as MedicoItem;
                if (seleccionado != null && seleccionado.Id > 0)
                {
                    medicoId = seleccionado.Id;
                }

                FacturaDao facturaDao = new FacturaDao();
                var resumen = facturaDao.obtenerHonorariosPorMedico(dtpDesde.Value.Date, dtpHasta.Value.Date, medicoId);
                var detalle = facturaDao.obtenerDetalleHonorariosPorMedico(dtpDesde.Value.Date, dtpHasta.Value.Date, medicoId);

                if (resumen == null || resumen.Rows.Count == 0)
                {
                    ResetResumen();
                    dgvConsultas.Rows.Clear();
                    MostrarMensaje("No se encontraron consultas para el periodo seleccionado.", true);
                    return;
                }

                string nombreMedico = "Todos los médicos";
                string especialidad = "Varias especialidades";
                int totalConsultas = 0;
                decimal honorarioUnitario = 0M;
                decimal totalHonorarios = 0M;
                decimal totalGeneral = 0M;

                if (seleccionado != null && seleccionado.Id > 0)
                {
                    DataRow row = resumen.Rows[0];
                    nombreMedico = row["medico"]?.ToString() ?? "Nombre médico";
                    especialidad = row["especialidad"]?.ToString() ?? "Especialidad";
                    totalConsultas = Convert.ToInt32(row["consultas"]);
                    honorarioUnitario = Convert.ToDecimal(row["honorario"]);
                    totalHonorarios = honorarioUnitario;
                    totalGeneral = Convert.ToDecimal(row["total"]);
                }
                else
                {
                    foreach (DataRow row in resumen.Rows)
                    {
                        totalConsultas += Convert.ToInt32(row["consultas"]);
                        totalHonorarios += Convert.ToDecimal(row["total"]);
                    }
                }

                lblResumenMedico.Text = nombreMedico;
                lblResumenEspecialidad.Text = especialidad;
                lblResumenConsultasValor.Text = totalConsultas.ToString();
                lblResumenHonorariosValor.Text = $"${totalHonorarios:0.00}";
                lblResumenTotalValor.Text = $"${totalGeneral:0.00}";

                dgvConsultas.Rows.Clear();
                if (detalle != null)
                {
                    foreach (DataRow row in detalle.Rows)
                    {
                        DateTime fecha = Convert.ToDateTime(row["fecha_hora_turno"]);
                        string paciente = row["paciente"]?.ToString() ?? string.Empty;
                        string dni = row["dni"]?.ToString() ?? string.Empty;
                        string concepto = row["concepto"]?.ToString() ?? string.Empty;
                        decimal honorario = Convert.ToDecimal(row["honorario"]);

                        dgvConsultas.Rows.Add(fecha.ToString("dd/MM/yyyy HH:mm"), paciente, dni, concepto, honorario.ToString("C2"));
                    }
                }

                if (dgvConsultas.Rows.Count == 0)
                {
                    MostrarMensaje("No se encontraron consultas para mostrar en la tabla.", true);
                    btnPagar.Enabled = false;
                }
                else
                {
                    MostrarMensaje($"Se encontraron {dgvConsultas.Rows.Count} consultas.", false);
                    btnPagar.Enabled = seleccionado != null && seleccionado.Id > 0;
                }
            }
            catch (Exception ex)
            {
                MostrarMensaje($"Error al generar reporte: {ex.Message}", true);
            }
        }

        private void BtnPagar_Click(object? sender, EventArgs e)
        {
            if (!(cmbMedico.SelectedItem is MedicoItem item) || item.Id <= 0)
            {
                MostrarMensaje("Seleccione un médico para pagar sus honorarios.", true);
                return;
            }

            if (dgvConsultas.Rows.Count == 0)
            {
                MostrarMensaje("No hay consultas en la tabla para pagar.", true);
                return;
            }

            if (MessageBox.Show($"¿Confirmás que se abonó a {lblResumenMedico.Text}?",
                "Confirmar pago", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                FacturaDao facturaDao = new FacturaDao();
                bool eliminado = facturaDao.eliminarFacturasEmitidasPorMedico(dtpDesde.Value.Date, dtpHasta.Value.Date, item.Id);

                if (eliminado)
                {
                    string registro = $"Medico: {lblResumenMedico.Text}{Environment.NewLine}" +
                                     $"Especialidad: {lblResumenEspecialidad.Text}{Environment.NewLine}" +
                                     $"Consultas: {lblResumenConsultasValor.Text}{Environment.NewLine}" +
                                     $"Honorario: {lblResumenHonorariosValor.Text.Replace("$", string.Empty)}{Environment.NewLine}" +
                                     $"Total: {lblResumenTotalValor.Text.Replace("$", string.Empty)}{Environment.NewLine}" +
                                     $"Periodo: {dtpDesde.Value:dd/MM/yyyy} - {dtpHasta.Value:dd/MM/yyyy}{Environment.NewLine}" +
                                     "------------------------";

                    pagosRegistrados.Add(registro);
                    ResetResumen();
                    dgvConsultas.Rows.Clear();
                    MostrarMensaje($"Pago registrado para {lblResumenMedico.Text}.", false);
                }
                else
                {
                    MostrarMensaje($"No se encontraron facturas para {lblResumenMedico.Text}.", true);
                }
            }
            catch (Exception ex)
            {
                MostrarMensaje($"Error al procesar pago: {ex.Message}", true);
            }
        }

        private void MostrarMensaje(string mensaje, bool esError)
        {
            lblMensajes.Text = mensaje;
            lblMensajes.ForeColor = esError 
                ? Color.FromArgb(231, 76, 60) 
                : Color.FromArgb(52, 152, 219);
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (pagosRegistrados == null || pagosRegistrados.Count == 0)
            {
                MostrarMensaje("No hay pagos registrados para exportar.", true);
                return;
            }

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("--- Resumen de Pagos Registrados ---");
            sb.AppendLine($"Generado: {DateTime.Now:dd/MM/yyyy HH:mm}");
            sb.AppendLine("Periodo solicitado: " + dtpDesde.Value.ToString("dd/MM/yyyy") + " - " + dtpHasta.Value.ToString("dd/MM/yyyy"));
            sb.AppendLine();
            
            decimal acumulado = 0M;
            foreach (var r in pagosRegistrados)
            {
                sb.AppendLine(r);
                
                var lines = r.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var line in lines)
                {
                    if (line.Trim().StartsWith("Total:"))
                    {
                        var val = line.Replace("Total:", string.Empty).Replace("$", string.Empty).Trim();
                        // Se fuerza la invariante cultural para evitar fallos si el sistema usa comas o puntos decimales
                        if (decimal.TryParse(val, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out decimal dec)) 
                            acumulado += dec;
                    }
                }
            }
            sb.AppendLine();
            sb.AppendLine($"Total general: ${acumulado:0.00}");

            using (var preview = new FormExportPreview(sb.ToString()))
            {
                preview.ShowDialog(this);
            }
        }
         private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}