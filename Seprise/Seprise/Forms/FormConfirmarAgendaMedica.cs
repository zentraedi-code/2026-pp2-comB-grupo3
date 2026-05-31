using System.ComponentModel;
using System.Data;
using Seprise.dao;
using Seprise.entity;

namespace Seprise
{
    public partial class FormConfirmarAgendaMedica : Form
    {
        private List<Medico> medicos = new List<Medico>();

        public FormConfirmarAgendaMedica()
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
                MedicoDao medicoDao = new MedicoDao();
                medicos = medicoDao.listarActivos();

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
            dgvAgendas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAgendas.MultiSelect = false;
            dgvAgendas.RowHeadersVisible = false;
            dgvAgendas.Font = new Font("Segoe UI", 9f);
            dgvAgendas.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
            dgvAgendas.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 107, 160);
            dgvAgendas.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvAgendas.EnableHeadersVisualStyles = false;
            dgvAgendas.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 246, 255);

            dgvAgendas.Columns.Clear();
            dgvAgendas.Columns.Add(new DataGridViewTextBoxColumn { Name = "colId", HeaderText = "ID", FillWeight = 7, Visible = false });
            dgvAgendas.Columns.Add(new DataGridViewTextBoxColumn { Name = "colFecha", HeaderText = "Fecha", FillWeight = 15 });
            dgvAgendas.Columns.Add(new DataGridViewTextBoxColumn { Name = "colMedico", HeaderText = "Médico", FillWeight = 30 });
            dgvAgendas.Columns.Add(new DataGridViewTextBoxColumn { Name = "colDesde", HeaderText = "Desde", FillWeight = 12 });
            dgvAgendas.Columns.Add(new DataGridViewTextBoxColumn { Name = "colHasta", HeaderText = "Hasta", FillWeight = 12 });
            dgvAgendas.Columns.Add(new DataGridViewTextBoxColumn { Name = "colDuracion", HeaderText = "Duración (min)", FillWeight = 12 });
            dgvAgendas.Columns.Add(new DataGridViewTextBoxColumn { Name = "colSobreturno", HeaderText = "Sobreturno/h", FillWeight = 12 });

            DataGridViewButtonColumn btnConfirmar = new DataGridViewButtonColumn
            {
                Name = "colConfirmar",
                HeaderText = "",
                Text = "Confirmar",
                UseColumnTextForButtonValue = true,
                FillWeight = 15,
                FlatStyle = FlatStyle.Flat
            };
            dgvAgendas.Columns.Add(btnConfirmar);
        }

        private void chkFecha_CheckedChanged(object sender, EventArgs e)
        {
            dtpFecha.Enabled = chkFecha.Checked;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime? fecha = chkFecha.Checked ? dtpFecha.Value.Date : (DateTime?)null;
                int? medicoId = cmbMedico.SelectedItem is Medico m ? m.Id : (int?)null;

                AgendaMedicaDao dao = new AgendaMedicaDao();
                DataTable dt = dao.listarInactivasPorFiltro(fecha, medicoId);

                dgvAgendas.Rows.Clear();

                if (dt == null || dt.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron agendas en estado INACTIVA con los filtros indicados.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                foreach (DataRow row in dt.Rows)
                {
                    int idx = dgvAgendas.Rows.Add(
                        row["id"].ToString(),
                        Convert.ToDateTime(row["fecha"]).ToString("dd/MM/yyyy"),
                        row["medico"].ToString(),
                        row["hora_desde"].ToString(),
                        row["hora_hasta"].ToString(),
                        row["duracion_turno_minutos"].ToString(),
                        row["sobre_turnos_por_hora"].ToString()
                    );
                    dgvAgendas.Rows[idx].Tag = int.Parse(row["id"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar agendas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvAgendas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != dgvAgendas.Columns["colConfirmar"].Index)
                return;

            int agendaId = (int)dgvAgendas.Rows[e.RowIndex].Tag;

            var respuesta = MessageBox.Show(
                "¿Confirmar esta agenda y generar los turnos?",
                "Confirmar agenda",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta != DialogResult.Yes)
                return;

            try
            {
                AgendaMedicaDao dao = new AgendaMedicaDao();
                bool ok = dao.confirmarConTurnos(agendaId);

                if (ok)
                {
                    MessageBox.Show("Agenda confirmada y turnos generados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvAgendas.Rows.RemoveAt(e.RowIndex);
                }
                else
                {
                    MessageBox.Show("No se pudo confirmar la agenda.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al confirmar la agenda: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
