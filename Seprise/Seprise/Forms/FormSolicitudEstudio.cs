using System;
using System.Windows.Forms;

namespace Seprise
{
    public partial class FormSolicitudEstudio : Form
    {
        public FormSolicitudEstudio()
        {
            InitializeComponent();
            CargarDatosIniciales();
        }

        private void CargarDatosIniciales()
        {
            cmbTipoEstudio.Items.AddRange(new string[] { "Radiografía", "Laboratorio", "Ecografía", "Tomografía", "Resonancia" });
            cmbOrigen.Items.AddRange(new string[] { "CONSULTORIO_EXTERNO", "EXTERNO", "GUARDIA", "INTERNACION", "LAB" });

            dtpFechaSolicitud.Value = DateTime.Now;

            if (cmbTipoEstudio.Items.Count > 0)
                cmbTipoEstudio.SelectedIndex = 0;
            if (cmbOrigen.Items.Count > 0)
                cmbOrigen.SelectedIndex = 0;
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

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            MessageBox.Show($"Solicitud de estudio creada con éxito.\n\nTipo: {cmbTipoEstudio.Text}\nOrigen: {cmbOrigen.Text}\nEstado: PENDIENTE", 
                "Solicitud creada", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimpiarFormulario();
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtDniPaciente.Text))
            {
                MessageBox.Show("Debe buscar un paciente primero.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cmbTipoEstudio.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un tipo de estudio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cmbOrigen.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un origen.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            txtDniPaciente.Clear();
            txtPaciente.Clear();
            txtObservaciones.Clear();
            dtpFechaSolicitud.Value = DateTime.Now;
            if (cmbTipoEstudio.Items.Count > 0)
                cmbTipoEstudio.SelectedIndex = 0;
            if (cmbOrigen.Items.Count > 0)
                cmbOrigen.SelectedIndex = 0;
            txtDniPaciente.Focus();
        }
    }
}
