using System;
using System.Windows.Forms;

namespace Seprise
{
    public partial class FormPacientesPendientes : Form
    {
        public FormPacientesPendientes()
        {
            InitializeComponent();
            ConfigurarDataGridView();
            CargarDatosIniciales();
        }

        private void CargarDatosIniciales()
        {
            cmbMedico.Items.AddRange(new string[] { "Dra. Gómez Laura", "Dr. Rodríguez Carlos", "Dra. Martínez Ana" });
            if (cmbMedico.Items.Count > 0)
                cmbMedico.SelectedIndex = 0;

            dtpFecha.Value = DateTime.Now;
            CargarDatosEjemplo();
        }

        private void ConfigurarDataGridView()
        {
            dgvCola.AllowUserToAddRows = false;
            dgvCola.AllowUserToDeleteRows = false;
            dgvCola.ReadOnly = true;
            dgvCola.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCola.MultiSelect = false;
            dgvCola.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvCola.Columns.Add("Orden", "Orden");
            dgvCola.Columns.Add("HoraTurno", "Hora turno");
            dgvCola.Columns.Add("HoraRecepcion", "Hora recepción");
            dgvCola.Columns.Add("Paciente", "Paciente");
            dgvCola.Columns.Add("Estado", "Estado");

            DataGridViewButtonColumn btnAtender = new DataGridViewButtonColumn();
            btnAtender.Name = "btnAtender";
            btnAtender.Text = "Atender";
            btnAtender.UseColumnTextForButtonValue = true;
            dgvCola.Columns.Add(btnAtender);
        }

        private void CargarDatosEjemplo()
        {
            dgvCola.Rows.Clear();
            dgvCola.Rows.Add("1", "08:00", "07:55", "Pérez Juan", "RECEPCIONADO");
            dgvCola.Rows.Add("2", "08:15", "08:05", "García Ana", "RECEPCIONADO");
            dgvCola.Rows.Add("3", "08:30", "08:20", "Rodríguez Pedro", "RECEPCIONADO");
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarDatosEjemplo();
            MessageBox.Show("Lista de pacientes actualizada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvCola_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string columna = dgvCola.Columns[e.ColumnIndex].Name;

            if (columna == "btnAtender")
            {
                MessageBox.Show("Abriendo formulario de Atención médica...", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
