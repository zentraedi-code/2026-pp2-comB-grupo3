using System.ComponentModel;

namespace Seprise
{
    public partial class FormGestionTurnosConsultorios : Form
    {
        public FormGestionTurnosConsultorios()
        {
            InitializeComponent();
            if (!IsDesignMode())
            {
                ConfigurarEventosHover();
            }
        }

        private bool IsDesignMode()
        {
            return LicenseManager.UsageMode == LicenseUsageMode.Designtime || (Site != null && Site.DesignMode);
        }

        private void ConfigurarEventosHover()
        {
            btnSalir.MouseEnter += (s, e) => {
                btnSalir.BackColor = Color.FromArgb(128, 203, 196);
            };
            btnSalir.MouseLeave += (s, e) => {
                btnSalir.BackColor = Color.White;
            };
        }

        private void btnReservarTurno_Click(object sender, EventArgs e)
        {
            var form = new FormReservarTurnoMedico();
            form.ShowDialog();
        }

        private void btnCancelarReserva_Click(object sender, EventArgs e)
        {
            var form = new FormCancelarReservaMedica();
            form.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
