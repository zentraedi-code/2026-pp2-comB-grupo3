using System;
using System.ComponentModel;
using System.Windows.Forms;
using Seprise.dao;
using Seprise.entity;

namespace Seprise
{
    public partial class FormGenerarHistoriaClinica : Form
    {
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int PacienteId { get; set; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int MedicoId { get; set; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int TurnoConsultaId { get; set; }

        public FormGenerarHistoriaClinica()
        {
            InitializeComponent();
            try
            {
                CargarDatosIniciales();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al inicializar el formulario de historia clínica: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public FormGenerarHistoriaClinica(int pacienteId, int medicoId, int turnoConsultaId, string pacienteNombre, string medicoNombre, string estadoTurno)
            : this()
        {
            SetAtencion(pacienteId, medicoId, turnoConsultaId, pacienteNombre, medicoNombre, estadoTurno);
        }

        public void SetAtencion(int pacienteId, int medicoId, int turnoConsultaId, string pacienteNombre, string medicoNombre, string estadoTurno)
        {
            PacienteId = pacienteId;
            MedicoId = medicoId;
            TurnoConsultaId = turnoConsultaId;
            try
            {
                // seleccionar medico en el combo si está cargado
                for (int i = 0; i < cmbMedicos.Items.Count; i++)
                {
                    if (cmbMedicos.Items[i] is ComboBoxItem it && it.Id == medicoId)
                    {
                        cmbMedicos.SelectedIndex = i;
                        break;
                    }
                }
            }
            catch { }
        }

        private void CargarDatosIniciales()
        {
            try
            {
                var medicos = new MedicoDao().listarActivos();
                cmbMedicos.Items.Clear();
                foreach (var m in medicos)
                {
                    cmbMedicos.Items.Add(new ComboBoxItem(m.Id, $"{m.Apellido}, {m.Nombre}"));
                }
                if (cmbMedicos.Items.Count > 0)
                    cmbMedicos.SelectedIndex = 0;
            }
            catch (Exception)
            {
                // ignore load errors, keep form usable
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            if (PacienteId <= 0 || MedicoId <= 0 || TurnoConsultaId <= 0)
            {
                MessageBox.Show("No se han cargado los datos completos de la atención. Revise paciente, médico y turno.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            HistoriaClinica historia = new HistoriaClinica
            {
                PacienteId = PacienteId,
                MedicoId = MedicoId,
                TurnoConsultaId = TurnoConsultaId,
                MotivoConsulta = txtMotivo.Text.Trim(),
                Diagnostico = txtDiagnostico.Text.Trim(),
                Indicaciones = txtIndicaciones.Text.Trim()
            };

            bool guardado = new HistoriaClinicaDao().guardar(historia);
            if (!guardado)
            {
                MessageBox.Show("No se pudo guardar la historia clínica. Intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Historia clínica guardada y atención finalizada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
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

        private void btnBuscarPaciente_Click(object sender, EventArgs e)
        {
            try
            {
                string dni = txtDni.Text.Trim();
                if (string.IsNullOrEmpty(dni))
                {
                    MessageBox.Show("Ingrese un DNI para buscar el paciente.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var paciente = new PacienteDao().buscar(dni);
                if (paciente == null)
                {
                    MessageBox.Show($"No se encontró paciente con DNI {dni}.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PacienteId = 0;
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar paciente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbMedicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbMedicos.SelectedItem is ComboBoxItem item)
                {
                    MedicoId = item.Id;
                }
            }
            catch (Exception)
            {
                // ignore
            }
        }

        // Helper class para almacenar Id y texto en el ComboBox
        private class ComboBoxItem
        {
            public int Id { get; }
            public string Text { get; }
            public ComboBoxItem(int id, string text) { Id = id; Text = text; }
            public override string ToString() => Text;
        }
         private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
