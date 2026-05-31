namespace Seprise
{
    public partial class FormGestionTurnosEstudios : Form
    {
        public FormGestionTurnosEstudios()
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

            btnReservarTurno.MouseEnter += (s, e) => {
                btnReservarTurno.BackColor = Color.FromArgb(128, 203, 196);
            };
            btnReservarTurno.MouseLeave += (s, e) => {
                btnReservarTurno.BackColor = Color.FromArgb(178, 235, 242);
            };

            btnCancelarReserva.MouseEnter += (s, e) => {
                btnCancelarReserva.BackColor = Color.FromArgb(128, 203, 196);
            };
            btnCancelarReserva.MouseLeave += (s, e) => {
                btnCancelarReserva.BackColor = Color.FromArgb(178, 235, 242);
            };
        }

        private void btnReservarTurno_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidad: Reservar Turno de Estudio Clínico\n\nEn desarrollo...", 
                "Reservar Turno Estudio", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
        }

        private void btnCancelarReserva_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidad: Cancelar Reserva de Turno de Estudio Clínico\n\nEn desarrollo...", 
                "Cancelar Reserva Estudio", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
