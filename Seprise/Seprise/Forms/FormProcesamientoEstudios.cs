using System;
using System.Drawing;
using System.Windows.Forms;

namespace Seprise
{
    public partial class FormProcesamientoEstudios : Form
    {
        public FormProcesamientoEstudios()
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

            btnFinalizarEstudio.MouseEnter += (s, e) => {
                btnFinalizarEstudio.BackColor = Color.FromArgb(128, 203, 196);
            };
            btnFinalizarEstudio.MouseLeave += (s, e) => {
                btnFinalizarEstudio.BackColor = Color.FromArgb(178, 235, 242);
            };

            btnGenerarInforme.MouseEnter += (s, e) => {
                btnGenerarInforme.BackColor = Color.FromArgb(128, 203, 196);
            };
            btnGenerarInforme.MouseLeave += (s, e) => {
                btnGenerarInforme.BackColor = Color.FromArgb(178, 235, 242);
            };

            btnEntregarEstudio.MouseEnter += (s, e) => {
                btnEntregarEstudio.BackColor = Color.FromArgb(128, 203, 196);
            };
            btnEntregarEstudio.MouseLeave += (s, e) => {
                btnEntregarEstudio.BackColor = Color.FromArgb(178, 235, 242);
            };
        }

        private void btnFinalizarEstudio_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidad de Finalizar Estudio pendiente de implementación",
                          "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGenerarInforme_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidad de Generar Informe pendiente de implementación",
                          "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEntregarEstudio_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidad de Entregar Estudio pendiente de implementación",
                          "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
