using System.ComponentModel;
using Seprise.dao;
using Seprise.entity;

namespace Seprise
{
    public partial class FormCrearAgendaMedica : Form
    {
        private List<Medico> medicos = new List<Medico>();
        private List<Consultorio> consultorios = new List<Consultorio>();

        public FormCrearAgendaMedica()
        {
            InitializeComponent();
            if (!IsDesignMode())
            {
                CargarDatos();
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

                cboProfesional.Items.Clear();
                cboProfesional.Items.Add("-- Seleccione un profesional --");
                foreach (Medico m in medicos)
                {
                    cboProfesional.Items.Add(m);
                }
                cboProfesional.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar médicos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                ConsultorioDao consultorioDao = new ConsultorioDao();
                consultorios = consultorioDao.listarActivos();

                cboConsultorio.Items.Clear();
                cboConsultorio.Items.Add("-- Seleccione un consultorio --");
                foreach (Consultorio c in consultorios)
                {
                    cboConsultorio.Items.Add(c);
                }
                cboConsultorio.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar consultorios: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dtpFecha.Value = DateTime.Today.AddDays(7);
            dtpHoraDesde.Value = DateTime.Today.Date.AddHours(8);
            dtpHoraHasta.Value = DateTime.Today.Date.AddHours(17);
        }

        private void cboProfesional_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboProfesional.SelectedItem is Medico medicoSeleccionado)
            {
                txtDuracion.Text = medicoSeleccionado.DuracionMinimaTurno.ToString();
            }
            else
            {
                txtDuracion.Clear();
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                try
                {
                    Medico medico = (Medico)cboProfesional.SelectedItem;
                    Consultorio consultorio = (Consultorio)cboConsultorio.SelectedItem;

                    AgendaMedica agenda = new AgendaMedica(
                        medico.Id,
                        consultorio.Id,
                        dtpFecha.Value.Date,
                        dtpHoraDesde.Value.TimeOfDay,
                        dtpHoraHasta.Value.TimeOfDay,
                        int.Parse(txtDuracion.Text),
                        1,
                        EstadoAgendaMedica.INACTIVA
                    );

                    AgendaMedicaDao agendaDao = new AgendaMedicaDao();
                    agendaDao.agregar(agenda);

                    MessageBox.Show("Agenda médica creada exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar la agenda: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool ValidarCampos()
        {
            if (dtpFecha.Value.Date < DateTime.Today)
            {
                MessageBox.Show("La fecha no puede ser anterior a hoy", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cboProfesional.SelectedItem is not Medico)
            {
                MessageBox.Show("Debe seleccionar un profesional", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cboConsultorio.SelectedItem is not Consultorio)
            {
                MessageBox.Show("Debe seleccionar un consultorio", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (dtpHoraHasta.Value.TimeOfDay <= dtpHoraDesde.Value.TimeOfDay)
            {
                MessageBox.Show("La hora hasta debe ser mayor a la hora desde", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDuracion.Text) || !int.TryParse(txtDuracion.Text, out int duracion) || duracion < 15)
            {
                MessageBox.Show("La duración debe ser de al menos 15 minutos", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            dtpFecha.Value = DateTime.Today.AddDays(7);
            dtpHoraDesde.Value = DateTime.Today.Date.AddHours(8);
            dtpHoraHasta.Value = DateTime.Today.Date.AddHours(17);
            cboProfesional.SelectedIndex = 0;
            cboConsultorio.SelectedIndex = 0;
            txtDuracion.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCrearAgendaMedica_Load(object sender, EventArgs e)
        {

        }

        private void lblSubtitulo_Click(object sender, EventArgs e)
        {

        }
    }
}
