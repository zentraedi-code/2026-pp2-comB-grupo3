using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Seprise
{
    public partial class FormRecepcionarPacienteConsultorios : Form
    {
        public FormRecepcionarPacienteConsultorios()
        {
            InitializeComponent();
            if (!IsDesignMode())
            {
                ConfigurarEventosHover();
            }
        }

        private bool IsDesignMode()
        {
            return LicenseManager.UsageMode == LicenseUsageMode.Designtime || (Site != null && Site.DesignMode);
        }

        private void ConfigurarEventosHover()
        {
            // Efecto hover para btnSalir
            btnSalir.MouseEnter += (s, e) => {
                btnSalir.BackColor = Color.FromArgb(128, 203, 196);
            };
            btnSalir.MouseLeave += (s, e) => {
                btnSalir.BackColor = Color.FromArgb(178, 235, 242);
            };

            // Efecto hover para btnConfirmarAsistencia
            btnConfirmarAsistencia.MouseEnter += (s, e) => {
                btnConfirmarAsistencia.BackColor = Color.FromArgb(128, 203, 196);
            };
            btnConfirmarAsistencia.MouseLeave += (s, e) => {
                btnConfirmarAsistencia.BackColor = Color.FromArgb(178, 235, 242);
            };

            // Efecto hover para btnFacturarConsulta
            btnFacturarConsulta.MouseEnter += (s, e) => {
                btnFacturarConsulta.BackColor = Color.FromArgb(128, 203, 196);
            };
            btnFacturarConsulta.MouseLeave += (s, e) => {
                btnFacturarConsulta.BackColor = Color.FromArgb(178, 235, 242);
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

            // Configurar texto con icono arriba y texto abajo
            btn.Text = $"{icono}\n\n{texto}";
            btn.TextAlign = ContentAlignment.MiddleCenter;

            btn.Click += clickHandler;
        }

        private void btnConfirmarAsistencia_Click(object sender, EventArgs e)
        {
            using (var form = new FormConfirmarAsistencia())
            {
                form.ShowDialog();
            }
        }

        private void btnFacturarConsulta_Click(object sender, EventArgs e)
        {
            using (var form = new FormFacturarConsulta())
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
