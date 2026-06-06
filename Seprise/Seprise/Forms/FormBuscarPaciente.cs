using Seprise.dao;
using Seprise.entity;

namespace Seprise
{
    public partial class FormBuscarPaciente : Form
    {
        private PacienteDao pacienteDao;

        public Paciente PacienteSeleccionado { get; private set; }

        public FormBuscarPaciente()
        {
            InitializeComponent();
            pacienteDao = new PacienteDao();
            ConfigurarGrilla();
        }

        private void ConfigurarGrilla()
        {
            dgvPacientes.ReadOnly = true;
            dgvPacientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPacientes.MultiSelect = false;
            dgvPacientes.AllowUserToAddRows = false;
            dgvPacientes.RowHeadersVisible = false;
            dgvPacientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPacientes.Font = new Font("Segoe UI", 9f);
            dgvPacientes.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
            dgvPacientes.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 150, 136);
            dgvPacientes.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 150, 136);
            dgvPacientes.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
            dgvPacientes.DefaultCellStyle.SelectionBackColor = Color.FromArgb(200, 230, 225);
            dgvPacientes.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvPacientes.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvPacientes.EnableHeadersVisualStyles = false;
            dgvPacientes.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 246, 255);

            dgvPacientes.Columns.Clear();
            dgvPacientes.Columns.Add(new DataGridViewTextBoxColumn { Name = "colDni", HeaderText = "DNI", FillWeight = 20 });
            dgvPacientes.Columns.Add(new DataGridViewTextBoxColumn { Name = "colApellido", HeaderText = "Apellido", FillWeight = 30 });
            dgvPacientes.Columns.Add(new DataGridViewTextBoxColumn { Name = "colNombre", HeaderText = "Nombre", FillWeight = 30 });
            dgvPacientes.Columns.Add(new DataGridViewTextBoxColumn { Name = "colTelefono", HeaderText = "Teléfono", FillWeight = 20 });
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string dni = txtDni.Text.Trim();
            string nomApe = txtNombreApellido.Text.Trim();

            if (string.IsNullOrEmpty(dni) && string.IsNullOrEmpty(nomApe))
            {
                MessageBox.Show("Ingrese al menos un criterio de búsqueda: DNI o nombre y apellido.", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                List<Paciente> pacientes = pacienteDao.buscarFiltrado(dni, nomApe);
                dgvPacientes.Rows.Clear();

                if (pacientes.Count == 0)
                {
                    MessageBox.Show("No se encontraron pacientes activos con ese criterio.", "Sin resultados",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                foreach (Paciente p in pacientes)
                {
                    int idx = dgvPacientes.Rows.Add(p.Dni, p.Apellido, p.Nombre, p.Telefono ?? "-");
                    dgvPacientes.Rows[idx].Tag = p;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar pacientes: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCampo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnBuscar_Click(sender, e);
        }

        private void dgvPacientes_SelectionChanged(object sender, EventArgs e)
        {
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvPacientes.SelectedRows.Count == 0 || dgvPacientes.SelectedRows[0].Tag is not Paciente)
            {
                MessageBox.Show("Seleccione un paciente de la grilla.", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            PacienteSeleccionado = (Paciente)dgvPacientes.SelectedRows[0].Tag;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            PacienteSeleccionado = null;
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void dgvPacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
