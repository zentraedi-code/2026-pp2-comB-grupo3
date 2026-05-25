using System.ComponentModel;

namespace Seprise
{
    public partial class FormGestionAgendaConsultorios : Form
    {
        public FormGestionAgendaConsultorios()
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

            // Efecto hover para btnCrearAgenda
            btnCrearAgenda.MouseEnter += (s, e) => {
                btnCrearAgenda.BackColor = Color.FromArgb(128, 203, 196);
            };
            btnCrearAgenda.MouseLeave += (s, e) => {
                btnCrearAgenda.BackColor = Color.FromArgb(178, 235, 242);
            };

            // Efecto hover para btnConfirmarAgenda
            btnConfirmarAgenda.MouseEnter += (s, e) => {
                btnConfirmarAgenda.BackColor = Color.FromArgb(128, 203, 196);
            };
            btnConfirmarAgenda.MouseLeave += (s, e) => {
                btnConfirmarAgenda.BackColor = Color.FromArgb(178, 235, 242);
            };

            // Efecto hover para btnCancelarAgenda
            btnCancelarAgenda.MouseEnter += (s, e) => {
                btnCancelarAgenda.BackColor = Color.FromArgb(128, 203, 196);
            };
            btnCancelarAgenda.MouseLeave += (s, e) => {
                btnCancelarAgenda.BackColor = Color.FromArgb(178, 235, 242);
            };
        }

        private void ConfigurarBotonConIcono(Button btn, string texto, string icono, int x, int y, int tamaño, EventHandler clickHandler)
        {
            btn.Location = new Point(x, y);
            btn.Name = "btn" + texto.Replace(" ", "");
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
