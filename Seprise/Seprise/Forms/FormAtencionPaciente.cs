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

            btnRevisarPacientesPendientes.MouseEnter += (s, e) => {
                btnRevisarPacientesPendientes.BackColor = Color.FromArgb(128, 203, 196);
            };
            btnRevisarPacientesPendientes.MouseLeave += (s, e) => {
                btnRevisarPacientesPendientes.BackColor = Color.FromArgb(178, 235, 242);
            };

            btnGenerarHistoriaClinica.MouseEnter += (s, e) => {
                btnGenerarHistoriaClinica.BackColor = Color.FromArgb(128, 203, 196);
            };
            btnGenerarHistoriaClinica.MouseLeave += (s, e) => {
                btnGenerarHistoriaClinica.BackColor = Color.FromArgb(178, 235, 242);
            };

            btnSolicitarEstudios.MouseEnter += (s, e) => {
                btnSolicitarEstudios.BackColor = Color.FromArgb(128, 203, 196);
            };
            btnSolicitarEstudios.MouseLeave += (s, e) => {
                btnSolicitarEstudios.BackColor = Color.FromArgb(178, 235, 242);
            };
        }

        private void ConfigurarBotonConIcono(Button btn, string texto, string icono, int x, int y, int tamaño, EventHandler clickHandler)
        {
            btn.Location = new Point(x, y);
            btn.Name = "btn" + texto.Replace(" ", "").Replace("\n", "");
            btn.Size = new Size(tamaño, tamaño);
            btn.TabIndex = 0;
            btn.BackColor = Color.FromArgb(178, 235, 242);
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderColor = Color.FromArgb(0, 150, 136);
            btn.FlatAppearance.BorderSize = 2;
            btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn.Cursor = Cursors.Hand;

            btn.Text = $"{icono}\n\n{texto}";
            btn.TextAlign = ContentAlignment.MiddleCenter;

            btn.Click += clickHandler;
        }

        private void btnRevisarPacientesPendientes_Click(object sender, EventArgs e)
        {
            using (var form = new FormPacientesPendientes())
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
