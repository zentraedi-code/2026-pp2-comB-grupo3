using System;
using System.Windows.Forms;

namespace Seprise
{
    public partial class FormReservarTurnoMedico : Form
    {
        public FormReservarTurnoMedico()
        {
            InitializeComponent();
            ConfigurarDataGridView();
            CargarDatosIniciales();
        }

        private void CargarDatosIniciales()
        {
            cmbEspecialidad.Items.AddRange(new string[] { "Clínica médica", "Fisio-kinesiología", "Salud mental", "Cardiología", "Pediatría" });
            cmbProfesional.Items.AddRange(new string[] { "Cualquiera", "Dra. Gómez Laura", "Dr. Rodríguez Carlos" });

            if (cmbEspecialidad.Items.Count > 0)
                cmbEspecialidad.SelectedIndex = 0;
            if (cmbProfesional.Items.Count > 0)
                cmbProfesional.SelectedIndex = 0;

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
            dgvTurnos.Columns.Add("Medico", "Médico");
            dgvTurnos.Columns.Add("Consultorio", "Consultorio");
            dgvTurnos.Columns.Add("Tipo", "Tipo");
            dgvTurnos.Columns.Add("Estado", "Estado");

            DataGridViewButtonColumn btnReservar = new DataGridViewButtonColumn();
            btnReservar.Name = "btnReservar";
            btnReservar.Text = "Reservar";
            btnReservar.UseColumnTextForButtonValue = true;
            dgvTurnos.Columns.Add(btnReservar);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvTurnos.Rows.Clear();
            dgvTurnos.Rows.Add("2026-05-10", "08:00", "Dra. Gómez", "1", "Normal", "DISPONIBLE");
            dgvTurnos.Rows.Add("2026-05-10", "08:45", "Dra. Gómez", "1", "Sobreturno", "DISPONIBLE");
            dgvTurnos.Rows.Add("2026-05-10", "09:00", "Dra. Gómez", "1", "Normal", "DISPONIBLE");
        }

        private void btnPrimeraDisponible_Click(object sender, EventArgs e)
        {
            dgvTurnos.Rows.Clear();
            dgvTurnos.Rows.Add("2026-05-10", "08:00", "Dra. Gómez", "1", "Normal", "DISPONIBLE");
            MessageBox.Show("Se muestra la primera fecha disponible.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvTurnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string columna = dgvTurnos.Columns[e.ColumnIndex].Name;

            if (columna == "btnReservar")
            {
                string dniPaciente = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el DNI del paciente:", "Reservar turno", "", -1, -1);

                if (!string.IsNullOrWhiteSpace(dniPaciente))
                {
                    dgvTurnos.Rows[e.RowIndex].Cells["Estado"].Value = "RESERVADO";
                    MessageBox.Show($"Turno reservado exitosamente para el paciente DNI {dniPaciente}.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
