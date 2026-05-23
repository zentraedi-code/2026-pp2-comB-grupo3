using System;
using System.Windows.Forms;

namespace Seprise
{
    public partial class FormConfirmarAsistencia : Form
    {
        public FormConfirmarAsistencia()
        {
            InitializeComponent();
            ConfigurarDataGridView();
            dtpFecha.Value = DateTime.Now;
        }

        private void ConfigurarDataGridView()
        {
            dgvTurnos.AllowUserToAddRows = false;
            dgvTurnos.AllowUserToDeleteRows = false;
            dgvTurnos.ReadOnly = true;
            dgvTurnos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTurnos.MultiSelect = false;
            dgvTurnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvTurnos.Columns.Add("Hora", "Hora");
            dgvTurnos.Columns.Add("Paciente", "Paciente");
            dgvTurnos.Columns.Add("Medico", "Médico");
            dgvTurnos.Columns.Add("Consultorio", "Consultorio");
            dgvTurnos.Columns.Add("Estado", "Estado");

            DataGridViewButtonColumn btnConfirmar = new DataGridViewButtonColumn();
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseColumnTextForButtonValue = true;
            dgvTurnos.Columns.Add(btnConfirmar);
        }

        private void btnBuscarPaciente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDniPaciente.Text))
            {
                MessageBox.Show("Ingrese un DNI para buscar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            txtPaciente.Text = $"(auto) Apellido Nombre - DNI {txtDniPaciente.Text}";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDniPaciente.Text))
            {
                MessageBox.Show("Debe buscar un paciente primero.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dgvTurnos.Rows.Clear();
            dgvTurnos.Rows.Add("08:00", "Pérez Juan", "Dra. Gómez", "1", "RESERVADO");
        }

        private void dgvTurnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string columna = dgvTurnos.Columns[e.ColumnIndex].Name;

            if (columna == "btnConfirmar")
            {
                dgvTurnos.Rows[e.RowIndex].Cells["Estado"].Value = "RECEPCIONADO";
                MessageBox.Show("Asistencia confirmada exitosamente. El turno está disponible para facturación y cola del médico.", 
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
