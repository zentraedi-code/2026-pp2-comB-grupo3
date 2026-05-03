using System.Drawing;
using System.Windows.Forms;
using SePriseApp.Utils;

namespace SePriseApp.Forms
{
    public partial class FormGestionPacientes : Form
    {
        private string _usuario;
        private string _rol;

        public FormGestionPacientes(string usuario, string rol)
        {
            InitializeComponent();
            _usuario = usuario;
            _rol = rol;
            ConfigurarFormulario();
        }

        private void ConfigurarFormulario()
        {
            this.Text = "SePrise — Gestión de Pacientes";
            this.Size = new Size(1366, 768);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = ColoresSePrise.FondoVentana;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // ── PANEL LATERAL ───────────────────────────────────
            Panel panelNav = new Panel
            {
                Size = new Size(220, 768),
                Location = new Point(0, 0),
                BackColor = ColoresSePrise.VerdePrimario
            };

            Label lblModulos = new Label
            {
                Text = "MÓDULOS",
                Font = new Font("Segoe UI", 8, FontStyle.Bold),
                ForeColor = ColoresSePrise.VerdeClaro,
                Location = new Point(20, 30),
                Size = new Size(180, 20)
            };

            Button btnPanel = CrearBotonNav("Panel de control", 60, false);
            Button btnPacientes = CrearBotonNav("Gestión de pacientes", 100, true);
            Button btnConsultorios = CrearBotonNav("Consultorios externos", 140, false);
            Button btnEstudios = CrearBotonNav("Estudios clínicos", 180, false);

            btnPanel.Click += (s, e) => {
                new FormPanelControl(_usuario, _rol).Show();
                this.Close();
            };

            panelNav.Controls.AddRange(new Control[]
            { lblModulos, btnPanel, btnPacientes, btnConsultorios, btnEstudios });

            // ── ÁREA PRINCIPAL ──────────────────────────────────
            Panel panelMain = new Panel
            {
                Size = new Size(1146, 768),
                Location = new Point(220, 0),
                BackColor = ColoresSePrise.FondoVentana
            };

            Label lblTitulo = new Label
            {
                Text = "Gestión de pacientes",
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                ForeColor = ColoresSePrise.TextoPrimario,
                Location = new Point(40, 40),
                Size = new Size(400, 35)
            };

            // Card ABM Pacientes
            Panel card = CrearCard("👤", "ABM Pacientes", "Alta · Baja · Modificación", 40, 120);
            card.Click += (s, e) => {
                new FormABMPacientes(_usuario, _rol).Show();
                this.Hide();
            };

            panelMain.Controls.AddRange(new Control[] { lblTitulo, card });
            this.Controls.AddRange(new Control[] { panelNav, panelMain });
        }

        private Button CrearBotonNav(string texto, int y, bool activo)
        {
            Button btn = new Button
            {
                Text = texto,
                Font = new Font("Segoe UI", 10),
                ForeColor = ColoresSePrise.TextoBlanco,
                BackColor = activo ? ColoresSePrise.VerdeOscuro : ColoresSePrise.VerdePrimario,
                FlatStyle = FlatStyle.Flat,
                Location = new Point(0, y),
                Size = new Size(220, 38),
                TextAlign = ContentAlignment.MiddleLeft,
                Padding = new Padding(20, 0, 0, 0),
                Cursor = Cursors.Hand
            };
            btn.FlatAppearance.BorderSize = 0;
            return btn;
        }

        private Panel CrearCard(string icono, string titulo, string subtitulo, int x, int y)
        {
            Panel card = new Panel
            {
                Size = new Size(300, 200),
                Location = new Point(x, y),
                BackColor = ColoresSePrise.FondoControl,
                Cursor = Cursors.Hand
            };
            card.Paint += (s, e) => {
                e.Graphics.DrawRectangle(
                    new Pen(ColoresSePrise.Borde, 1),
                    0, 0, card.Width - 1, card.Height - 1);
            };

            Label lblIcono = new Label
            {
                Text = icono,
                Font = new Font("Segoe UI", 32),
                TextAlign = ContentAlignment.MiddleCenter,
                Size = new Size(300, 80),
                Location = new Point(0, 20)
            };

            Label lblTitulo = new Label
            {
                Text = titulo,
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = ColoresSePrise.TextoPrimario,
                TextAlign = ContentAlignment.MiddleCenter,
                Size = new Size(300, 30),
                Location = new Point(0, 110)
            };

            Label lblSub = new Label
            {
                Text = subtitulo,
                Font = new Font("Segoe UI", 9),
                ForeColor = ColoresSePrise.TextoSecundario,
                TextAlign = ContentAlignment.MiddleCenter,
                Size = new Size(300, 25),
                Location = new Point(0, 145)
            };

            card.Controls.AddRange(new Control[] { lblIcono, lblTitulo, lblSub });
            return card;
        }
    }
}
