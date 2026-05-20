using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using SePriseApp.Utils;

namespace SePriseApp.Forms
{
    partial class FormEstudiosClinicosPanel
    {
        // ── DECLARACIÓN DE CONTROLES ─────────────────────────────────────────
        private Panel panelNav;
        private Panel panelMain;
        private Label lblModulos;
        private Label lblSesion;
        private Button btnPanel;
        private Button btnPacientes;
        private Button btnConsultorios;
        private Button btnEstudios;
        private Button btnCerrar;
        private Label lblTitulo;
        private Label lblSub;
        private Panel c1, c2, c3, c4, c5, c6, c7, c8, c9;

        private void InitializeComponent()
        {
            // ── FORM ────────────────────────────────────────────────────────
            this.Text = "SePrise — Estudios Clínicos";
            this.Size = new Size(1366, 768);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = ColoresSePrise.FondoVentana;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // ── PANEL LATERAL ────────────────────────────────────────────────
            panelNav = new Panel
            {
                Size = new Size(220, 768),
                Location = new Point(0, 0),
                BackColor = ColoresSePrise.VerdePrimario
            };

            lblModulos = new Label
            {
                Text = "MÓDULOS",
                Font = new Font("Segoe UI", 8, FontStyle.Bold),
                ForeColor = ColoresSePrise.VerdeClaro,
                Location = new Point(20, 30),
                Size = new Size(180, 20)
            };

            btnPanel = CrearBotonNav("Panel de control", 60, false);
            btnPacientes = CrearBotonNav("Gestión de pacientes", 100, false);
            btnConsultorios = CrearBotonNav("Consultorios externos", 140, false);
            btnEstudios = CrearBotonNav("Estudios clínicos", 180, true);

            lblSesion = new Label
            {
                Text = "SESIÓN",
                Font = new Font("Segoe UI", 8, FontStyle.Bold),
                ForeColor = ColoresSePrise.VerdeClaro,
                Location = new Point(20, 640),
                Size = new Size(180, 20)
            };

            btnCerrar = CrearBotonNav("Cerrar sesión", 665, false);

            btnPanel.Click += BtnPanel_Click;
            btnPacientes.Click += BtnPacientes_Click;
            btnCerrar.Click += BtnCerrar_Click;

            panelNav.Controls.AddRange(new Control[]
            {
                lblModulos, btnPanel, btnPacientes, btnConsultorios,
                btnEstudios, lblSesion, btnCerrar
            });

            // ── PANEL PRINCIPAL ──────────────────────────────────────────────
            panelMain = new Panel
            {
                Size = new Size(1146, 768),
                Location = new Point(220, 0),
                BackColor = ColoresSePrise.FondoVentana
            };

            lblTitulo = new Label
            {
                Text = "Estudios Clínicos",
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                ForeColor = ColoresSePrise.TextoPrimario,
                Location = new Point(40, 30),
                AutoSize = true
            };

            lblSub = new Label
            {
                Text = "Seleccioná una funcionalidad del circuito",
                Font = new Font("Segoe UI", 10),
                ForeColor = ColoresSePrise.TextoSecundario,
                Location = new Point(40, 68),
                AutoSize = true
            };

            // ── 9 CARDS ──────────────────────────────────────────────────────
            // Fila 1
            c1 = CrearCard("📅", "Crear agenda", "CU15 · BORRADOR", 40, 120);
            c2 = CrearCard("✔", "Confirmar agenda", "CU17 · Genera turnos", 290, 120);
            c3 = CrearCard("✕", "Cancelar agenda", "CU16 · Cancela turnos", 540, 120);
            c4 = CrearCard("🕐", "Reservar turno", "CU18 · Asigna paciente", 790, 120);

            // Fila 2
            c5 = CrearCard("📋", "Recepcionar", "CU19 · Marca recibido", 40, 350);
            c6 = CrearCard("💲", "Facturar estudio", "CU20 · Obra social/part.", 290, 350);
            c7 = CrearCard("✔", "Finalizar estudio", "CU21 · Marca realizado", 540, 350);
            c8 = CrearCard("📄", "Generar informe", "CU22 · Carga resultado", 790, 350);

            // Fila 3
            c9 = CrearCard("📦", "Entregar estudio", "CU23 · Estado ENTREGADO", 40, 580);

            // Eventos de las cards
            c1.Click += C1_Click;
            c2.Click += C2_Click;
            c3.Click += C3_Click;
            c4.Click += C4_Click;
            c5.Click += C5_Click;
            c6.Click += C6_Click;
            c7.Click += C7_Click;
            c8.Click += C8_Click;
            c9.Click += C9_Click;

            panelMain.Controls.AddRange(new Control[]
            {
                lblTitulo, lblSub,
                c1, c2, c3, c4,
                c5, c6, c7, c8,
                c9
            });

            this.Controls.AddRange(new Control[] { panelNav, panelMain });
        }

        // ── HELPERS VISUALES ─────────────────────────────────────────────────

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
                Size = new Size(230, 200),
                Location = new Point(x, y),
                BackColor = ColoresSePrise.FondoControl,
                Cursor = Cursors.Hand
            };

            card.Paint += (s, e) =>
            {
                e.Graphics.DrawRectangle(
                    new Pen(ColoresSePrise.Borde, 1),
                    0, 0, card.Width - 1, card.Height - 1);
            };

            Label lblIcono = new Label
            {
                Text = icono,
                Font = new Font("Segoe UI", 28),
                TextAlign = ContentAlignment.MiddleCenter,
                Size = new Size(230, 70),
                Location = new Point(0, 18)
            };

            Label lblTituloCard = new Label
            {
                Text = titulo,
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                ForeColor = ColoresSePrise.TextoPrimario,
                TextAlign = ContentAlignment.MiddleCenter,
                Size = new Size(230, 28),
                Location = new Point(0, 100)
            };

            Label lblSubCard = new Label
            {
                Text = subtitulo,
                Font = new Font("Segoe UI", 8),
                ForeColor = ColoresSePrise.TextoSecundario,
                TextAlign = ContentAlignment.MiddleCenter,
                Size = new Size(230, 22),
                Location = new Point(0, 134)
            };

            // Propagar click de los labels al panel
            lblIcono.Click += (s, e) => typeof(Control).GetMethod("OnClick",
                BindingFlags.NonPublic | BindingFlags.Instance)?.Invoke(card, new[] { e });
            lblTituloCard.Click += (s, e) => typeof(Control).GetMethod("OnClick",
                BindingFlags.NonPublic | BindingFlags.Instance)?.Invoke(card, new[] { e });
            lblSubCard.Click += (s, e) => typeof(Control).GetMethod("OnClick",
                BindingFlags.NonPublic | BindingFlags.Instance)?.Invoke(card, new[] { e });

            card.Controls.AddRange(new Control[] { lblIcono, lblTituloCard, lblSubCard });
            return card;
        }
    }
}