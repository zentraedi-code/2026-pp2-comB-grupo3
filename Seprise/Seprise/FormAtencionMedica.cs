using System;
using System.Windows.Forms;

namespace Seprise
{
    public partial class FormAtencionMedica : Form
    {
        public FormAtencionMedica()
        {
            InitializeComponent();
            ConfigurarDataGridView();
            CargarDatosIniciales();
        }

        private void CargarDatosIniciales()
        {
            txtPaciente.Text = "Pérez Juan";
            txtMedico.Text = "Dra. Gómez Laura";
            txtEstadoTurno.Text = "RECEPCIONADO";
            dtpFechaAtencion.Value = DateTime.Now;

            dgvEstudios.Rows.Add("#105", "Radiografía", "CONSULTORIO_EXTERNO", "PENDIENTE");
        }

        private void ConfigurarDataGridView()
        {
            dgvEstudios.AllowUserToAddRows = false;
            dgvEstudios.AllowUserToDeleteRows = false;
            dgvEstudios.ReadOnly = true;
            dgvEstudios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEstudios.MultiSelect = false;
            dgvEstudios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvEstudios.Columns.Add("ID", "Estudios solicitados en esta atención");
            dgvEstudios.Columns.Add("Tipo", "Tipo");
            dgvEstudios.Columns.Add("Origen", "Origen");
            dgvEstudios.Columns.Add("Estado", "Estado");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            txtEstadoTurno.Text = "FINALIZADO";
            MessageBox.Show("Historia clínica guardada y atención finalizada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtMotivo.Text))
            {
                MessageBox.Show("Debe ingresar el motivo de consulta.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDiagnostico.Text))
            {
                MessageBox.Show("Debe ingresar el diagnóstico o evolución.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnSolicitarEstudio_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Abriendo formulario de solicitud de estudio...", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
