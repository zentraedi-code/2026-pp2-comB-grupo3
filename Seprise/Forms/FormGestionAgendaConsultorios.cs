using System.ComponentModel;

namespace Seprise
{
    public partial class FormGestionAgendaConsultorios : Form
    {
        public FormGestionAgendaConsultorios()
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

        private void btnCrearAgenda_Click(object sender, EventArgs e)
        {
            var form = new FormCrearAgendaMedica();
            form.ShowDialog();
        }

        private void btnConfirmarAgenda_Click(object sender, EventArgs e)
        {
            var form = new FormConfirmarAgendaMedica();
            form.ShowDialog();
        }

        private void btnCancelarAgenda_Click(object sender, EventArgs e)
        {
            var form = new FormCancelarAgendaMedica();
            form.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
