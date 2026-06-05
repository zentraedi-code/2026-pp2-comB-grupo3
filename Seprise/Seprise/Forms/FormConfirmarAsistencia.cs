using System;
using System.ComponentModel;
using System.Windows.Forms;
using Seprise.dao;
using Seprise.entity;

namespace Seprise
{
    public partial class FormConfirmarAsistencia : Form
    {
        private Paciente? pacienteSeleccionado = null;

        public FormConfirmarAsistencia()
        {
            InitializeComponent();
            dtpFecha.Value = DateTime.Now;
            // Ensure the main Confirmar Asistencia button is wired
            try { this.btnConfirmarAsistencia.Click -= btnConfirmarAsistencia_Click; } catch { }
            this.btnConfirmarAsistencia.Click += btnConfirmarAsistencia_Click;
        }

        private void btnBuscarPaciente_Click(object sender, EventArgs e)
        {
            string dni = txtDniPaciente.Text?.Trim() ?? string.Empty;

            if (string.IsNullOrEmpty(dni))
            {
                MessageBox.Show("Ingrese el DNI del paciente.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                PacienteDao pacienteDao = new PacienteDao();
                var paciente = pacienteDao.buscar(dni);

                if (paciente == null)
                {
                    MessageBox.Show("No se encontró un paciente activo con ese DNI.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPaciente.Clear();
                    pacienteSeleccionado = null;
                    btnConfirmarAsistencia.Enabled = false;
                    return;
                }

                pacienteSeleccionado = paciente;
                TurnoConsultaDao turnoDao = new TurnoConsultaDao();
                var dt = turnoDao.buscarTurnosPorPacienteEnFecha(paciente.Id, dtpFecha.Value.Date);

                if (dt == null || dt.Rows.Count == 0)
                {
                    txtPaciente.Text = $"{paciente.Nombre} {paciente.Apellido}, no tiene turno para la fecha seleccionada.";
                    lblPacientePlaceholder.Visible = false;
                    btnConfirmarAsistencia.Enabled = false;
                    return;
                }

                System.Data.DataRow reservedRow = null;
                System.Data.DataRow recepcionadoRow = null;
                foreach (System.Data.DataRow rowEstado in dt.Rows)
                {
                    string estado = rowEstado["estado"]?.ToString() ?? string.Empty;
                    if (estado.Equals("RESERVADO", StringComparison.OrdinalIgnoreCase))
                    {
                        reservedRow = rowEstado;
                        break;
                    }
                    if (recepcionadoRow == null && estado.Equals("RECEPCIONADO", StringComparison.OrdinalIgnoreCase))
                    {
                        recepcionadoRow = rowEstado;
                    }
                }

                if (reservedRow != null)
                {
                    DateTime fechaHora = Convert.ToDateTime(reservedRow["fecha_hora_turno"]);
                    string medico = reservedRow["medico"]?.ToString() ?? string.Empty;
                    string especialidad = reservedRow.Table.Columns.Contains("especialidad") ? (reservedRow["especialidad"]?.ToString() ?? string.Empty) : string.Empty;
                    string consultorio = reservedRow["consultorio"]?.ToString() ?? string.Empty;
                    string estadoTurno = reservedRow["estado"]?.ToString() ?? string.Empty;

                    btnConfirmarAsistencia.Enabled = true;
                    txtPaciente.Text = $"Nombre: {paciente.Nombre} {paciente.Apellido}\r\n" +
                                       $"DNI: {paciente.Dni}\r\n" +
                                       $"Turno: {fechaHora:dd/MM/yyyy}\r\n" +
                                       $"Horario: {fechaHora:HH:mm}\r\n" +
                                       $"Médico: {medico}\r\n" +
                                       $"Especialidad: {especialidad}\r\n" +
                                       $"Consultorio: {consultorio}\r\n";
                }
                else if (recepcionadoRow != null)
                {
                    btnConfirmarAsistencia.Enabled = false;
                    txtPaciente.Text = $"{paciente.Nombre} {paciente.Apellido} ya confirmó su turno.";
                }
                else
                {
                    btnConfirmarAsistencia.Enabled = false;
                    txtPaciente.Text = $"{paciente.Nombre} {paciente.Apellido} no tiene un turno reservado para la fecha seleccionada.";
                }

                lblPacientePlaceholder.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar paciente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Panel CrearTarjetaTurno(int turnoId, DateTime fechaHora, Paciente? paciente, string medico, string consultorio, string especialidad, string dni, decimal importe, int yPos)
        {
            Panel tarjeta = new Panel
            {
                Location = new System.Drawing.Point(10, yPos),
                Size = new System.Drawing.Size(760, 100),
                BorderStyle = BorderStyle.None,
                Tag = turnoId
            };

            int x = 10;
            int ly = 8;

            var lblHora = new Label { Text = fechaHora.ToString("dd/MM/yyyy HH:mm"), Location = new System.Drawing.Point(x, ly), Size = new System.Drawing.Size(300, 20), Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold) };
            tarjeta.Controls.Add(lblHora);
            ly += 24;

            var lblPaciente = new Label { Text = paciente != null ? $"{paciente.Apellido}, {paciente.Nombre} (DNI: {dni})" : "Paciente", Location = new System.Drawing.Point(x, ly), Size = new System.Drawing.Size(400, 18), Font = new System.Drawing.Font("Segoe UI", 9F) };
            tarjeta.Controls.Add(lblPaciente);
            ly += 20;
            var lblMedico = new Label { Text = $"M�dico: {medico}", Location = new System.Drawing.Point(x, ly), Size = new System.Drawing.Size(300, 18), Font = new System.Drawing.Font("Segoe UI", 9F) };
            tarjeta.Controls.Add(lblMedico);

            var lblEspecialidad = new Label { Text = $"Especialidad: {especialidad}", Location = new System.Drawing.Point(320, ly), Size = new System.Drawing.Size(300, 18), Font = new System.Drawing.Font("Segoe UI", 9F) };
            tarjeta.Controls.Add(lblEspecialidad);

            var lblConsultorio = new Label { Text = $"Consultorio: {consultorio}", Location = new System.Drawing.Point(10, ly+18), Size = new System.Drawing.Size(300, 18), Font = new System.Drawing.Font("Segoe UI", 9F) };
            tarjeta.Controls.Add(lblConsultorio);

            var lblImporte = new Label { Text = $"Importe: ${importe:0.00}", Location = new System.Drawing.Point(320, ly+18), Size = new System.Drawing.Size(200, 18), Font = new System.Drawing.Font("Segoe UI", 9F) };
            tarjeta.Controls.Add(lblImporte);

            var btnConfirm = new Button { Text = "Confirmar", Location = new System.Drawing.Point(640, 30), Size = new System.Drawing.Size(100, 30), BackColor = System.Drawing.Color.FromArgb(46, 204, 113), ForeColor = System.Drawing.Color.White, FlatStyle = FlatStyle.Flat, Tag = turnoId };
            btnConfirm.Click += (s, e) => {
                int id = (int)(btnConfirm.Tag ?? 0);
                try
                {
                    TurnoConsultaDao turnoDao = new TurnoConsultaDao();
                    bool confirmado = turnoDao.confirmarAsistencia(id);
                    if (confirmado)
                    {
                        btnConfirm.Enabled = false;
                        btnConfirm.Text = "Confirmado (Listo para facturar)";
                        btnConfirm.BackColor = System.Drawing.Color.Gray;
                        lblMensajes.Text = "Asistencia confirmada y lista para facturar.";
                    }
                    else
                    {
                        lblMensajes.Text = "No se pudo confirmar la asistencia.";
                    }
                }
                catch (Exception ex)
                {
                    lblMensajes.Text = $"Error al confirmar: {ex.Message}";
                }
            };
            tarjeta.Controls.Add(btnConfirm);

            return tarjeta;
        }

        private void btnConfirmarAsistencia_Click(object sender, EventArgs e)
        {
            if (pacienteSeleccionado == null)
            {
                MessageBox.Show("Debe buscar un paciente primero.", "Validaci�n", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                TurnoConsultaDao turnoDao = new TurnoConsultaDao();
                // Search for RESERVADO turnos only (not RECEPCIONADO)
                var dt = turnoDao.buscarTurnosPorPacienteEnFecha(pacienteSeleccionado.Id, dtpFecha.Value.Date);

                if (dt == null || dt.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontr� un turno disponible para confirmar hoy.", "Informaci�n", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                bool anyConfirmed = false;
                string errorDetails = string.Empty;
                
                foreach (System.Data.DataRow row in dt.Rows)
                {
                    try
                    {
                        int id = Convert.ToInt32(row["id"]);
                        string estado = row["estado"]?.ToString() ?? "DESCONOCIDO";
                        
                        // Only confirm if state is RESERVADO
                        if (estado.Equals("RESERVADO", StringComparison.OrdinalIgnoreCase))
                        {
                            if (turnoDao.confirmarAsistencia(id))
                            {
                                anyConfirmed = true;
                            }
                        }
                        else
                        {
                            errorDetails += $"Turno {id} est� en estado {estado}. ";
                        }
                    }
                    catch (Exception ex)
                    {
                        errorDetails += $"Error procesando turno: {ex.Message}. ";
                    }
                }

                if (anyConfirmed)
                {
                    MessageBox.Show("Asistencia confirmada correctamente.", "�xito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Reset UI to allow new search
                    txtPaciente.Clear();
                    lblPacientePlaceholder.Visible = true;
                    pacienteSeleccionado = null;
                    btnConfirmarAsistencia.Enabled = false;
                    txtDniPaciente.Clear();
                    lblMensajes.Text = "Paciente confirmado. Ingrese un nuevo DNI.";
                }
                else
                {
                    string msg = "No se pudo confirmar la asistencia.";
                    if (!string.IsNullOrEmpty(errorDetails))
                        msg += " " + errorDetails;
                    MessageBox.Show(msg, "Informaci�n", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al confirmar asistencia: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


