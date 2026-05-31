using System;
using System.Drawing;
using System.Windows.Forms;

namespace Seprise
{
    public partial class FormConfirmacionEstudios : Form
    {
        public FormConfirmacionEstudios()
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

            btnConfirmarSolicitud.MouseEnter += (s, e) => {
                btnConfirmarSolicitud.BackColor = Color.FromArgb(128, 203, 196);
            };
            btnConfirmarSolicitud.MouseLeave += (s, e) => {
                btnConfirmarSolicitud.BackColor = Color.FromArgb(178, 235, 242);
            };

            btnFacturarEstudio.MouseEnter += (s, e) => {
                btnFacturarEstudio.BackColor = Color.FromArgb(128, 203, 196);
            };
            btnFacturarEstudio.MouseLeave += (s, e) => {
                btnFacturarEstudio.BackColor = Color.FromArgb(178, 235, 242);
            };
        }

        private void btnConfirmarSolicitud_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidad de Confirmar Solicitud pendiente de implementación",
                          "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnFacturarEstudio_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidad de Facturar Estudio pendiente de implementación",
                          "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
