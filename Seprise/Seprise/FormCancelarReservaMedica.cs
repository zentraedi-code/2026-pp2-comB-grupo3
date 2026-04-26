using System;
using System.Windows.Forms;

namespace Seprise
{
    public partial class FormCancelarReservaMedica : Form
    {
        public FormCancelarReservaMedica()
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

            dgvTurnos.Columns.Add("Fecha", "Fecha");
            dgvTurnos.Columns.Add("Hora", "Hora");
            dgvTurnos.Columns.Add("Paciente", "Paciente");
            dgvTurnos.Columns.Add("Medico", "Médico");
            dgvTurnos.Columns.Add("Estado", "Estado");

            DataGridViewButtonColumn btnCancelar = new DataGridViewButtonColumn();
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Text = "Cancelar reserva";
            btnCancelar.UseColumnTextForButtonValue = true;
            dgvTurnos.Columns.Add(btnCancelar);
        }

        private void btnBuscarPaciente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDniPaciente.Text))
            {
                MessageBox.Show("Ingrese un DNI para buscar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            txtPaciente.Text = $"(auto) Pérez Juan - DNI {txtDniPaciente.Text}";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDniPaciente.Text))
            {
                MessageBox.Show("Debe buscar un paciente primero.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dgvTurnos.Rows.Clear();
            dgvTurnos.Rows.Add("2026-05-10", "08:00", "Pérez Juan", "Dra. Gómez", "RESERVADO");
            dgvTurnos.Rows.Add("2026-05-12", "14:00", "Pérez Juan", "Dr. Rodríguez", "RESERVADO");
        }

        private void dgvTurnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string columna = dgvTurnos.Columns[e.ColumnIndex].Name;

            if (columna == "btnCancelar")
            {
                var result = MessageBox.Show("Al cancelar: se desasigna el paciente, se borra fecha de reserva y el turno vuelve a DISPONIBLE.\n\n¿Desea continuar?", 
                    "Confirmar cancelación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    dgvTurnos.Rows.RemoveAt(e.RowIndex);
                    MessageBox.Show("Reserva cancelada exitosamente. El turno volvió a estado DISPONIBLE.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
