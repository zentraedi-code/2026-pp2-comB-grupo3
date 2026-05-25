using System.ComponentModel;

namespace Seprise
{
    public partial class FormCrearAgendaMedica : Form
    {
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
            cboDia.SelectedIndex = 0;
            cboProfesional.SelectedIndex = 0;
            cboConsultorio.SelectedIndex = 0;
            dtpFecha.Value = DateTime.Today.AddDays(7);
            txtEstado.Text = "BORRADOR";
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                MessageBox.Show("Agenda médica creada exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }
        }

        private bool ValidarCampos()
        {
            if (dtpFecha.Value < DateTime.Today)
            {
                MessageBox.Show("La fecha no puede ser anterior a hoy", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtHoraDesde.Text) || string.IsNullOrWhiteSpace(txtHoraHasta.Text))
            {
                MessageBox.Show("Debe especificar el rango horario", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            cboDia.SelectedIndex = 0;
            txtHoraDesde.Clear();
            txtHoraHasta.Clear();
            cboProfesional.SelectedIndex = 0;
            cboConsultorio.SelectedIndex = 0;
            txtDuracion.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
