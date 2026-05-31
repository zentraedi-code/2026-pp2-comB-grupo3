namespace Seprise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ConfigurarEventosHover();
        }

        private void ConfigurarEventosHover()
        {
            var botones = new[] {
                btnPacientes,
                btnGestionMedicos, btnGestionAgenda, btnGestionTurnos,
                btnRecepcionarPaciente, btnAtencionPaciente,
                btnGestionAgendaEstudios, btnGestionTurnosEstudios,
                btnRecepcionarPacienteEstudio, btnSolicitudEstudios,
                btnConfirmacionEstudios, btnProcesamientoEstudios
            };

            foreach (var btn in botones)
            {
                btn.MouseEnter += (s, e) =>
                {
                    btn.BackColor = Color.FromArgb(128, 203, 196);
                };
                btn.MouseLeave += (s, e) =>
                {
                    btn.BackColor = Color.FromArgb(178, 235, 242);
                };
            }
        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            var form = new FormPacientes();
            form.ShowDialog();
        }

        private void btnGestionMedicos_Click(object sender, EventArgs e)
        {
            var form = new FormGestionMedicos();
            form.ShowDialog();
        }

        private void btnGestionAgenda_Click(object sender, EventArgs e)
        {
            var form = new FormGestionAgendaConsultorios();
            form.ShowDialog();
        }

        private void btnGestionTurnos_Click(object sender, EventArgs e)
        {
            var form = new FormGestionTurnosConsultorios();
            form.ShowDialog();
        }

        private void btnRecepcionarPaciente_Click(object sender, EventArgs e)
        {
            var form = new FormRecepcionarPacienteConsultorios();
            form.ShowDialog();
        }

        private void btnAtencionPaciente_Click(object sender, EventArgs e)
        {
            var form = new FormAtencionPaciente();
            form.ShowDialog();
        }

        private void btnGestionAgendaEstudios_Click(object sender, EventArgs e)
        {
            var form = new FormGestionAgendaEstudios();
            form.ShowDialog();
        }

        private void btnGestionTurnosEstudios_Click(object sender, EventArgs e)
        {
            var form = new FormGestionTurnosEstudios();
            form.ShowDialog();
        }

        private void btnRecepcionarEstudio_Click(object sender, EventArgs e)
        {
            var form = new FormRecepcionarPacienteEstudios();
            form.ShowDialog();
        }

        private void btnSolicitudEstudios_Click(object sender, EventArgs e)
        {
            var form = new FormSolicitudEstudio();
            form.ShowDialog();
        }

        private void btnConfirmacionEstudios_Click(object sender, EventArgs e)
        {
            var form = new FormConfirmacionEstudios();
            form.ShowDialog();
        }

        private void btnProcesamientoEstudios_Click(object sender, EventArgs e)
        {
            var form = new FormProcesamientoEstudios();
            form.ShowDialog();
        }

        private void panelContenido_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblSeccionComun_Click(object sender, EventArgs e)
        {

        }
    }
}
