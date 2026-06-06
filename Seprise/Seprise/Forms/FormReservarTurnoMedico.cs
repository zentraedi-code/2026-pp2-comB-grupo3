using System.ComponentModel;
using Seprise.dao;
using Seprise.entity;

namespace Seprise
{
    public partial class FormReservarTurnoMedico : Form
    {
        private List<Medico> medicos = new List<Medico>();
        private List<Especialidad> especialidades = new List<Especialidad>();

        public FormReservarTurnoMedico()
        {
            InitializeComponent();
            if (!IsDesignMode())
            {
                CargarDatos();
                ConfigurarGrilla();
            }
        }

        private bool IsDesignMode()
        {
            return LicenseManager.UsageMode == LicenseUsageMode.Designtime || (Site != null && Site.DesignMode);
        }

        private void CargarDatos()
        {
            try
            {
                EspecialidadDao espDao = new EspecialidadDao();
                especialidades = espDao.listarActivas();

                cmbEspecialidad.Items.Clear();
                cmbEspecialidad.Items.Add("-- Todas --");
                foreach (Especialidad esp in especialidades)
                    cmbEspecialidad.Items.Add(esp);
                cmbEspecialidad.SelectedIndex = 0;

                CargarMedicosPorEspecialidad(null);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarMedicosPorEspecialidad(int? especialidadId)
        {
            try
            {
                MedicoDao medicoDao = new MedicoDao();
                List<Medico> todos = medicoDao.listarActivos();

                medicos = especialidadId.HasValue
                    ? todos.Where(m => m.IdEspecialidad == especialidadId.Value).ToList()
                    : todos;

                cmbMedico.Items.Clear();
                cmbMedico.Items.Add("-- Todos --");
                foreach (Medico m in medicos)
                    cmbMedico.Items.Add(m);
                cmbMedico.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar médicos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurarGrilla()
        {
            dgvTurnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTurnos.MultiSelect = false;
            dgvTurnos.RowHeadersVisible = false;
            dgvTurnos.Font = new Font("Segoe UI", 9f);
            dgvTurnos.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
            dgvTurnos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 150, 136);
            dgvTurnos.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 150, 136);
            dgvTurnos.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
            dgvTurnos.DefaultCellStyle.SelectionBackColor = Color.FromArgb(120, 200, 190);
            dgvTurnos.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvTurnos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvTurnos.EnableHeadersVisualStyles = false;

            dgvTurnos.Columns.Clear();
            dgvTurnos.Columns.Add(new DataGridViewTextBoxColumn { Name = "colId", HeaderText = "ID", Visible = false });
            dgvTurnos.Columns.Add(new DataGridViewTextBoxColumn { Name = "colFecha", HeaderText = "Fecha", FillWeight = 14 });
            dgvTurnos.Columns.Add(new DataGridViewTextBoxColumn { Name = "colHora", HeaderText = "Hora", FillWeight = 10 });
            dgvTurnos.Columns.Add(new DataGridViewTextBoxColumn { Name = "colMedico", HeaderText = "Médico", FillWeight = 30 });
            dgvTurnos.Columns.Add(new DataGridViewTextBoxColumn { Name = "colConsultorio", HeaderText = "Consultorio", FillWeight = 18 });
            dgvTurnos.Columns.Add(new DataGridViewTextBoxColumn { Name = "colTipo", HeaderText = "Tipo", FillWeight = 13 });

            DataGridViewButtonColumn btnReservar = new DataGridViewButtonColumn
            {
                Name = "colReservar",
                HeaderText = "",
                Text = "Reservar",
                UseColumnTextForButtonValue = true,
                FillWeight = 15,
                FlatStyle = FlatStyle.Flat
            };
            dgvTurnos.Columns.Add(btnReservar);
        }

        private void cmbEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            int? espId = cmbEspecialidad.SelectedItem is Especialidad esp ? esp.Id : (int?)null;
            CargarMedicosPorEspecialidad(espId);
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cmbMedico.SelectedItem is not Medico medico)
            {
                MessageBox.Show("Seleccione un médico para buscar disponibilidad.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                TurnoConsultaDao dao = new TurnoConsultaDao();
                List<TurnoConsulta> turnos = dao.buscarDisponiblesPorProfesionalYFecha(medico.Id, dtpFecha.Value.Date);
                CargarGrilla(turnos);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar turnos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrimeraDisponible_Click(object sender, EventArgs e)
        {
            if (cmbMedico.SelectedItem is not Medico medico)
            {
                MessageBox.Show("Seleccione un médico para ver la primera fecha disponible.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                TurnoConsultaDao dao = new TurnoConsultaDao();
                List<TurnoConsulta> turnos = dao.buscarPrimeraDisponiblePorProfesional(medico.Id);
                CargarGrilla(turnos);

                if (turnos.Count > 0)
                {
                    dtpFecha.Value = turnos[0].FechaHoraTurno.Date;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar primera disponible: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarGrilla(List<TurnoConsulta> turnos)
        {
            dgvTurnos.Rows.Clear();

            if (turnos == null || turnos.Count == 0)
            {
                MessageBox.Show("No se encontraron turnos DISPONIBLES con los filtros indicados.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (TurnoConsulta t in turnos)
            {
                int idx = dgvTurnos.Rows.Add(
                    t.Id.ToString(),
                    t.FechaHoraTurno.ToString("dd/MM/yyyy"),
                    t.FechaHoraTurno.ToString("HH:mm"),
                    t.MedicoNombreCompleto ?? "-",
                    t.ConsultorioNombre ?? "-",
                    t.EsSobreturno ? "Sobreturno" : "Normal"
                );
                dgvTurnos.Rows[idx].Tag = t;
            }
        }

        private void dgvTurnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != dgvTurnos.Columns["colReservar"].Index)
                return;

            TurnoConsulta turno = dgvTurnos.Rows[e.RowIndex].Tag as TurnoConsulta;
            if (turno == null) return;

            using FormBuscarPaciente formPaciente = new FormBuscarPaciente();
            if (formPaciente.ShowDialog() != DialogResult.OK)
                return;

            Paciente paciente = formPaciente.PacienteSeleccionado;
            if (paciente == null) return;

            var respuesta = MessageBox.Show(
                $"¿Reservar turno el {turno.FechaHoraTurno:dd/MM/yyyy} a las {turno.FechaHoraTurno:HH:mm} para {paciente.Apellido}, {paciente.Nombre}?",
                "Confirmar reserva",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta != DialogResult.Yes)
                return;

            try
            {
                TurnoConsultaDao dao = new TurnoConsultaDao();
                bool ok = dao.reservar(turno.Id, paciente.Id);

                if (ok)
                {
                    MessageBox.Show("Turno reservado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvTurnos.Rows.RemoveAt(e.RowIndex);
                }
                else
                {
                    MessageBox.Show("No se pudo reservar el turno. Es posible que ya no esté disponible.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al reservar turno: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

