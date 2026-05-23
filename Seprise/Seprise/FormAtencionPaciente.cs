using System;
using System.Drawing;
using System.Windows.Forms;

namespace Seprise
{
    public partial class FormAtencionPaciente : Form
    {
        public FormAtencionPaciente()
        {
            InitializeComponent();
        }

        private void btnRevisarPacientesPendientes_Click(object sender, EventArgs e)
        {
            using (var form = new FormRevisarPacientesPendientes())
            {
                form.ShowDialog();
            }
        }

        private void btnGenerarHistoriaClinica_Click(object sender, EventArgs e)
        {
            using (var form = new FormGenerarHistoriaClinica())
            {
                form.ShowDialog();
            }
        }

        private void btnSolicitarEstudios_Click(object sender, EventArgs e)
        {
            using (var form = new FormSolicitudEstudio())
            {
                form.ShowDialog();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
