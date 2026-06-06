using Seprise.dao;
using Seprise.entity;
using System.ComponentModel;

namespace Seprise
{
    public partial class FormSolicitudEstudio : Form
    {
        private PacienteDao pacienteDao;
        private Paciente pacienteSeleccionado;

        public FormSolicitudEstudio()
        {
            InitializeComponent();
            if (!IsDesignMode())
            {
                pacienteDao = new PacienteDao();
                CargarDatosIniciales();
            }
        }

        private bool IsDesignMode()
        {
            return LicenseManager.UsageMode == LicenseUsageMode.Designtime || (Site != null && Site.DesignMode);
        }

        private void CargarDatosIniciales()
        {
            cmbTipoEstudio.Items.Clear();
            cmbOrigen.Items.Clear();

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

            try
            {
                pacienteSeleccionado = pacienteDao.buscar(txtDniPaciente.Text.Trim());
                if (pacienteSeleccionado != null)
                {
                    txtPaciente.Text = $"{pacienteSeleccionado.ObtenerNombreCompleto()} - DNI {pacienteSeleccionado.Dni}";
                }
                else
                {
                    MessageBox.Show("No se encontró ningún paciente con ese DNI.", "Paciente no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPaciente.Clear();
                    pacienteSeleccionado = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar paciente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            try
            {
                string sql = $"INSERT INTO solicitud_estudio " +
                             $"(paciente_id, estudio_id, es_externo, origen_atencion_id, fecha_solicitud, estado) " +
                             $"VALUES ({pacienteSeleccionado.Id}, 1, 0, 1, NOW(), 'PENDIENTE')";

                var conexion = ClubDeportivo.service.ServicioConexion.getInstancia();
                conexion.ejecutarComandoSQL(sql);

                MessageBox.Show($"Solicitud de estudio creada con éxito.\n\nPaciente: {pacienteSeleccionado.ObtenerNombreCompleto()}\nTipo: {cmbTipoEstudio.Text}\nOrigen: {cmbOrigen.Text}\nEstado: PENDIENTE",
                    "Solicitud creada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear solicitud: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarCampos()
        {
            if (pacienteSeleccionado == null)
            {
                MessageBox.Show("Debe buscar y seleccionar un paciente primero.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            pacienteSeleccionado = null;
            if (cmbTipoEstudio.Items.Count > 0)
                cmbTipoEstudio.SelectedIndex = 0;
            if (cmbOrigen.Items.Count > 0)
                cmbOrigen.SelectedIndex = 0;
            txtDniPaciente.Focus();
        }
    }
}