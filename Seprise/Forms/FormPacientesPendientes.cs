using ClubDeportivo.service;
using Seprise.dao;
using Seprise.entity;
using System.ComponentModel;
using System.Data;

namespace Seprise
{
    public partial class FormPacientesPendientes : Form
    {
        public FormPacientesPendientes()
        {
            InitializeComponent();
            if (!IsDesignMode())
            {
                ConfigurarDataGridView();
                CargarMedicos();
            }
        }

        private bool IsDesignMode()
        {
            return LicenseManager.UsageMode == LicenseUsageMode.Designtime || (Site != null && Site.DesignMode);
        }

        private void CargarMedicos()
        {
            try
            {
                cmbMedico.Items.Clear();
                MedicoDao medicoDao = new MedicoDao();
                List<Medico> medicos = medicoDao.listarActivos();
                foreach (Medico m in medicos)
                    cmbMedico.Items.Add(m);
                if (cmbMedico.Items.Count > 0)
                    cmbMedico.SelectedIndex = 0;

                dtpFecha.Value = DateTime.Now;
                CargarCola();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar médicos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurarDataGridView()
        {
            dgvCola.AllowUserToAddRows = false;
            dgvCola.AllowUserToDeleteRows = false;
            dgvCola.ReadOnly = true;
            dgvCola.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCola.MultiSelect = false;
            dgvCola.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvCola.Columns.Clear();
            dgvCola.Columns.Add("Orden", "Orden");
            dgvCola.Columns.Add("HoraTurno", "Hora turno");
            dgvCola.Columns.Add("HoraRecepcion", "Hora recepción");
            dgvCola.Columns.Add("Paciente", "Paciente");
            dgvCola.Columns.Add("Estado", "Estado");
            dgvCola.Columns.Add("Consultorio", "Consultorio");
            dgvCola.Columns["Consultorio"].Visible = false;
            dgvCola.Columns.Add("TurnoId", "ID");
            dgvCola.Columns["TurnoId"].Visible = false;

            DataGridViewButtonColumn btnAtender = new DataGridViewButtonColumn();
            btnAtender.Name = "btnAtender";
            btnAtender.Text = "Atender";
            btnAtender.UseColumnTextForButtonValue = true;
            dgvCola.Columns.Add(btnAtender);
        }

        private void CargarCola()
        {
            try
            {
                dgvCola.Rows.Clear();

                if (cmbMedico.SelectedItem == null) return;

                Medico medico = (Medico)cmbMedico.SelectedItem;
                string fecha = dtpFecha.Value.ToString("yyyy-MM-dd");

                string sql = $"SELECT tc.id, tc.fecha_hora_turno, tc.fecha_recepcion, " +
                             $"CONCAT(p.nombre, ' ', p.apellido) as paciente, tc.estado, " +
                             $"c.nombre as consultorio " +
                             $"FROM turno_consulta tc " +
                             $"JOIN agenda_medica am ON tc.agenda_medica_id = am.id " +
                             $"JOIN paciente p ON tc.paciente_id = p.id " +
                             $"JOIN consultorio c ON am.consultorio_id = c.id " +
                             $"WHERE am.medico_id = {medico.Id} " +
                             $"AND DATE(tc.fecha_hora_turno) = '{fecha}' " +
                             $"AND tc.estado = 'RECEPCIONADO' " +
                             $"ORDER BY tc.fecha_hora_turno";

                ServicioConexion conexion = ServicioConexion.getInstancia();
                DataTable dt = conexion.ejecutarSQL(sql);

                int orden = 1;
                if (dt != null && dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        string horaTurno = Convert.ToDateTime(row["fecha_hora_turno"]).ToString("HH:mm");
                        string horaRecepcion = row["fecha_recepcion"] != DBNull.Value
                            ? Convert.ToDateTime(row["fecha_recepcion"]).ToString("HH:mm")
                            : "-";

                        dgvCola.Rows.Add(
                            orden++,
                            horaTurno,
                            horaRecepcion,
                            row["paciente"].ToString(),
                            row["estado"].ToString(),
                            row["consultorio"].ToString(),
                            row["id"].ToString()
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar cola: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarCola();
            MessageBox.Show("Lista de pacientes actualizada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvCola_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string columna = dgvCola.Columns[e.ColumnIndex].Name;

            if (columna == "btnAtender")
            {
                string paciente = dgvCola.Rows[e.RowIndex].Cells["Paciente"].Value?.ToString() ?? "-";
                string consultorio = dgvCola.Rows[e.RowIndex].Cells["Consultorio"].Value?.ToString() ?? "consultorio asignado";

                MessageBox.Show(
                    $"El paciente {paciente} será atendido en {consultorio}.",
                    "Llamar paciente",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
    }
}