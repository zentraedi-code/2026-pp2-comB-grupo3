using System.Drawing;
using System.Windows.Forms;
using SePriseApp.Utils;

namespace SePriseApp.Forms
{
    public partial class FormPanelControl : Form
    {
        private string _usuario;
        private string _rol;

        public FormPanelControl(string usuario, string rol)
        {
            InitializeComponent();
            _usuario = usuario;
            _rol = rol;
            ConfigurarFormulario();
        }

        private void ConfigurarFormulario()
        {
            this.Text = "SePrise — Panel de Control";
            this.Size = new Size(1366, 768);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = ColoresSePrise.FondoVentana;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // ── PANEL LATERAL IZQUIERDO ─────────────────────────
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

            Button btnPanel = CrearBotonNav("Panel de control", 60, true);
            Button btnPacientes = CrearBotonNav("Gestión de pacientes", 100, false);
            Button btnConsultorios = CrearBotonNav("Consultorios externos", 140, false);
            Button btnEstudios = CrearBotonNav("Estudios clínicos", 180, false);

            Label lblSesion = new Label
            {
                Text = "SESIÓN",
                Font = new Font("Segoe UI", 8, FontStyle.Bold),
                ForeColor = ColoresSePrise.VerdeClaro,
                Location = new Point(20, 640),
                Size = new Size(180, 20)
            };

            Button btnCerrar = CrearBotonNav("Cerrar sesión", 665, false);
            btnCerrar.Click += (s, e) => {
                new FormLogin().Show();
                this.Close();
            };

            btnPacientes.Click += (s, e) => {
                new FormGestionPacientes(_usuario, _rol).Show();
                this.Hide();
            };

            panelNav.Controls.AddRange(new Control[]
            { lblModulos, btnPanel, btnPacientes, btnConsultorios, btnEstudios, lblSesion, btnCerrar });

            // ── ÁREA PRINCIPAL ──────────────────────────────────
            Panel panelMain = new Panel
            {
                Size = new Size(1146, 768),
                Location = new Point(220, 0),
                BackColor = ColoresSePrise.FondoVentana
            };

            Label lblBienvenido = new Label
            {
                Text = $"Bienvenido — seleccioná un módulo",
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                ForeColor = ColoresSePrise.TextoPrimario,
                Location = new Point(40, 40),
                Size = new Size(700, 35)
            };

            Label lblEmpleado = new Label
            {
                Text = $"Empleado: {_usuario}  |  Rol: {_rol}",
                Font = new Font("Segoe UI", 10),
                ForeColor = ColoresSePrise.TextoSecundario,
                Location = new Point(40, 80),
                Size = new Size(500, 25)
            };

            // Cards
            Panel card1 = CrearCard("👤", "Gestión de pacientes", "ABM · Solicitudes", 40, 140);
            Panel card2 = CrearCard("🩺", "Consultorios externos", "Médicos · Agenda · Turnos", 400, 140);
            Panel card3 = CrearCard("🔬", "Estudios clínicos", "Agenda · Turnos · Informes", 760, 140);

            card1.Click += (s, e) => {
                new FormGestionPacientes(_usuario, _rol).Show();
                this.Hide();
            };

            panelMain.Controls.AddRange(new Control[]
            { lblBienvenido, lblEmpleado, card1, card2, card3 });

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
