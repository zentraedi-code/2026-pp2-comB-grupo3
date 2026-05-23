namespace Seprise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            // Ya estamos en inicio
        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            var form = new FormPacientes();
            form.ShowDialog();
        }

        private void btnSolicitudEstudio_Click(object sender, EventArgs e)
        {
            var form = new FormSolicitudEstudio();
            form.ShowDialog();
        }

        private void btnGestionMedicos_Click(object sender, EventArgs e)
        {
            var form = new FormGestionMedicos();
            form.ShowDialog();
        }

        private void btnGestionAgenda_Click(object sender, EventArgs e)
        {
            var form = new FormGestionAgenda();
            form.ShowDialog();
        }

        private void btnGestionTurnos_Click(object sender, EventArgs e)
        {
            var form = new FormGestionTurnos();
            form.ShowDialog();
        }

        private void btnRecepcionarPaciente_Click(object sender, EventArgs e)
        {
            var form = new FormRecepcionarPaciente();
            form.ShowDialog();
        }

        private void btnAtencionPaciente_Click(object sender, EventArgs e)
        {
            var form = new FormAtencionPaciente();
            form.ShowDialog();
        }

        private void btnCrearAgendaEstudios_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidad en desarrollo", "Crear Agenda Estudios", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancelarAgendaEstudios_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidad en desarrollo", "Cancelar Agenda Estudios", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnConfirmarAgendaEstudios_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidad en desarrollo", "Confirmar Agenda Estudios", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnReservarTurnoEstudio_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidad en desarrollo", "Reservar Turno Estudio", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancelarReservaEstudio_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidad en desarrollo", "Cancelar Reserva Estudio", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRecepcionarEstudio_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidad en desarrollo", "Recepcionar Paciente Estudio", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnFacturarEstudio_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidad en desarrollo", "Facturar Estudio", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnFinalizarEstudio_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidad en desarrollo", "Finalizar Atención Estudio", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGenerarInformeEstudio_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidad en desarrollo", "Generar Informe Estudio", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEntregarEstudio_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidad en desarrollo", "Entregar Estudio", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
