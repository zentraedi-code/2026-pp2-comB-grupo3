namespace Seprise
{
    public partial class FormGestionAgendaEstudios : Form
    {
        public FormGestionAgendaEstudios()
        {
            InitializeComponent();
            ConfigurarEventosHover();
        }

        private void ConfigurarEventosHover()
        {
            btnSalir.MouseEnter += (s, e) => {
                btnSalir.BackColor = Color.FromArgb(128, 203, 196);
            };
            btnSalir.MouseLeave += (s, e) => {
                btnSalir.BackColor = Color.FromArgb(178, 235, 242);
            };

            btnCrearAgenda.MouseEnter += (s, e) => {
                btnCrearAgenda.BackColor = Color.FromArgb(128, 203, 196);
            };
            btnCrearAgenda.MouseLeave += (s, e) => {
                btnCrearAgenda.BackColor = Color.FromArgb(178, 235, 242);
            };

            btnConfirmarAgenda.MouseEnter += (s, e) => {
                btnConfirmarAgenda.BackColor = Color.FromArgb(128, 203, 196);
            };
            btnConfirmarAgenda.MouseLeave += (s, e) => {
                btnConfirmarAgenda.BackColor = Color.FromArgb(178, 235, 242);
            };

            btnCancelarAgenda.MouseEnter += (s, e) => {
                btnCancelarAgenda.BackColor = Color.FromArgb(128, 203, 196);
            };
            btnCancelarAgenda.MouseLeave += (s, e) => {
                btnCancelarAgenda.BackColor = Color.FromArgb(178, 235, 242);
            };
        }

        private void btnCrearAgenda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidad: Crear Agenda de Estudios Clínicos\n\nEn desarrollo...", 
                "Crear Agenda Estudios", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
        }

        private void btnConfirmarAgenda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidad: Confirmar Agenda de Estudios Clínicos\n\nEn desarrollo...", 
                "Confirmar Agenda Estudios", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
        }

        private void btnCancelarAgenda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidad: Cancelar Agenda de Estudios Clínicos\n\nEn desarrollo...", 
                "Cancelar Agenda Estudios", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
