namespace Seprise
{
    public partial class FormGestionTurnos : Form
    {
        public FormGestionTurnos()
        {
            InitializeComponent();
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
