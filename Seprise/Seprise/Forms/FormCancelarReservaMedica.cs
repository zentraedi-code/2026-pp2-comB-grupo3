using System.ComponentModel;
using Seprise.dao;
using Seprise.entity;

namespace Seprise
{
    public partial class FormCancelarReservaMedica : Form
    {
        private Paciente pacienteSeleccionado = null;

        public FormCancelarReservaMedica()
        {
            InitializeComponent();
            if (!IsDesignMode())
                ConfigurarGrilla();
        }

        private bool IsDesignMode()
        {
            return LicenseManager.UsageMode == LicenseUsageMode.Designtime || (Site != null && Site.DesignMode);
        }

        private void ConfigurarGrilla()
        {
            dgvTurnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTurnos.MultiSelect = false;
            dgvTurnos.RowHeadersVisible = false;
            dgvTurnos.Font = new Font("Segoe UI", 9f);
            dgvTurnos.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
            dgvTurnos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 150, 136);
            dgvTurnos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvTurnos.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 150, 136);
            dgvTurnos.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
            dgvTurnos.DefaultCellStyle.SelectionBackColor = Color.FromArgb(120, 200, 190);
            dgvTurnos.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvTurnos.EnableHeadersVisualStyles = false;
            dgvTurnos.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 246, 255);

            dgvTurnos.Columns.Clear();
            dgvTurnos.Columns.Add(new DataGridViewTextBoxColumn { Name = "colId", HeaderText = "ID", Visible = false });
            dgvTurnos.Columns.Add(new DataGridViewTextBoxColumn { Name = "colFechaHora", HeaderText = "Fecha y hora", FillWeight = 22 });
            dgvTurnos.Columns.Add(new DataGridViewTextBoxColumn { Name = "colMedico", HeaderText = "Médico", FillWeight = 30 });
            dgvTurnos.Columns.Add(new DataGridViewTextBoxColumn { Name = "colConsultorio", HeaderText = "Consultorio", FillWeight = 20 });
            dgvTurnos.Columns.Add(new DataGridViewTextBoxColumn { Name = "colSobreturno", HeaderText = "Sobreturno", FillWeight = 13 });

            DataGridViewButtonColumn btnCancelar = new DataGridViewButtonColumn
            {
                Name = "colCancelar",
                HeaderText = "",
                Text = "Cancelar",
                UseColumnTextForButtonValue = true,
                FillWeight = 15,
                FlatStyle = FlatStyle.Flat
            };
            dgvTurnos.Columns.Add(btnCancelar);
        }

        private void btnBuscarPaciente_Click(object sender, EventArgs e)
        {
            string dni = txtDniPaciente.Text.Trim();

            if (string.IsNullOrEmpty(dni))
            {
                MessageBox.Show("Ingrese el DNI del paciente.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                PacienteDao pacienteDao = new PacienteDao();
                Paciente p = pacienteDao.buscar(dni);

                if (p == null)
                {
                    MessageBox.Show("No se encontró un paciente activo con ese DNI.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPaciente.Clear();
                    pacienteSeleccionado = null;
                    return;
                }

                pacienteSeleccionado = p;
                txtPaciente.Text = $"{p.Apellido}, {p.Nombre}";
                dgvTurnos.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar paciente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (pacienteSeleccionado == null)
            {
                MessageBox.Show("Debe buscar un paciente primero.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DateTime? fecha =  dtpFecha.Value.Date ;

                TurnoConsultaDao turnoDao = new TurnoConsultaDao();
                System.Data.DataTable dt = turnoDao.buscarReservadosPorPaciente(pacienteSeleccionado.Id, fecha);

                dgvTurnos.Rows.Clear();

                if (dt == null || dt.Rows.Count == 0)
                {
                    MessageBox.Show("El paciente no tiene turnos reservados con los filtros indicados.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                foreach (System.Data.DataRow row in dt.Rows)
                {
                    DateTime fechaHora = Convert.ToDateTime(row["fecha_hora_turno"]);
                    int idx = dgvTurnos.Rows.Add(
                        row["id"].ToString(),
                        fechaHora.ToString("dd/MM/yyyy HH:mm"),
                        row["medico"].ToString(),
                        row["consultorio"].ToString(),
                        Convert.ToBoolean(row["es_sobreturno"]) ? "Sí" : "No"
                    );
                    dgvTurnos.Rows[idx].Tag = int.Parse(row["id"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar turnos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvTurnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != dgvTurnos.Columns["colCancelar"].Index)
                return;

            int turnoId = (int)dgvTurnos.Rows[e.RowIndex].Tag;

            var respuesta = MessageBox.Show(
                "¿Cancelar esta reserva? El turno volverá a estado DISPONIBLE.",
                "Confirmar cancelación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta != DialogResult.Yes)
                return;

            try
            {
                TurnoConsultaDao turnoDao = new TurnoConsultaDao();
                bool ok = turnoDao.cancelarReserva(turnoId);

                if (ok)
                {
                    MessageBox.Show("Reserva cancelada. El turno volvió a estado DISPONIBLE.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvTurnos.Rows.RemoveAt(e.RowIndex);
                }
                else
                {
                    MessageBox.Show("No se pudo cancelar la reserva.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cancelar la reserva: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
