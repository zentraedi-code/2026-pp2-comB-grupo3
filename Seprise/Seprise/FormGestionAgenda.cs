namespace Seprise
{
    public partial class FormGestionAgenda : Form
    {
        public FormGestionAgenda()
        {
            InitializeComponent();
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
