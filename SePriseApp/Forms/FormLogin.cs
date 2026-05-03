using System.Drawing;
using System.Windows.Forms;
using SePriseApp.Utils;

namespace SePriseApp.Forms
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            ConfigurarFormulario();
        }

        private void ConfigurarFormulario()
        {
            this.Text = "Sistema SePrise — Gestión Clínica";
            this.Size = new Size(1366, 768);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = ColoresSePrise.FondoVentana;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // ── PANEL IZQUIERDO ─────────────────────────────────
            Panel panelIzq = new Panel
            {
                Size = new Size(400, 768),
                Location = new Point(0, 0),
                BackColor = ColoresSePrise.VerdePrimario
            };

            Label lblLogo = new Label
            {
                Text = "+",
                Font = new Font("Segoe UI", 48, FontStyle.Bold),
                ForeColor = ColoresSePrise.TextoBlanco,
                TextAlign = ContentAlignment.MiddleCenter,
                Size = new Size(100, 100),
                Location = new Point(150, 220)
            };

            Label lblNombre = new Label
            {
                Text = "Clínica SePrise",
                Font = new Font("Segoe UI", 18, FontStyle.Bold),
                ForeColor = ColoresSePrise.TextoBlanco,
                TextAlign = ContentAlignment.MiddleCenter,
                Size = new Size(360, 40),
                Location = new Point(20, 340)
            };

            Label lblSistema = new Label
            {
                Text = "Sistema de Gestión",
                Font = new Font("Segoe UI", 11),
                ForeColor = ColoresSePrise.TextoBlanco,
                TextAlign = ContentAlignment.MiddleCenter,
                Size = new Size(360, 30),
                Location = new Point(20, 385)
            };

            Label lblModulos = new Label
            {
                Text = "Consultorios Externos · Estudios Clínicos",
                Font = new Font("Segoe UI", 9),
                ForeColor = ColoresSePrise.VerdeClaro,
                TextAlign = ContentAlignment.MiddleCenter,
                Size = new Size(360, 25),
                Location = new Point(20, 450)
            };

            panelIzq.Controls.AddRange(new Control[]
            { lblLogo, lblNombre, lblSistema, lblModulos });

            // ── PANEL DERECHO ────────────────────────────────────
            Panel panelDer = new Panel
            {
                Size = new Size(966, 768),
                Location = new Point(400, 0),
                BackColor = ColoresSePrise.FondoVentana
            };

            Label lblTitulo = new Label
            {
                Text = "Inicio de Sesión",
                Font = new Font("Segoe UI", 20, FontStyle.Bold),
                ForeColor = ColoresSePrise.TextoPrimario,
                Location = new Point(100, 180),
                Size = new Size(400, 40)
            };

            Label lblUsuario = new Label
            {
                Text = "Usuario",
                Font = new Font("Segoe UI", 11),
                ForeColor = ColoresSePrise.TextoSecundario,
                Location = new Point(100, 260),
                Size = new Size(200, 25)
            };

            TextBox txtUsuario = new TextBox
            {
                Name = "txtUsuario",
                Font = new Font("Segoe UI", 11),
                Location = new Point(100, 288),
                Size = new Size(380, 35),
                BorderStyle = BorderStyle.FixedSingle
            };

            Label lblPassword = new Label
            {
                Text = "Contraseña",
                Font = new Font("Segoe UI", 11),
                ForeColor = ColoresSePrise.TextoSecundario,
                Location = new Point(100, 340),
                Size = new Size(200, 25)
            };

            TextBox txtPassword = new TextBox
            {
                Name = "txtPassword",
                Font = new Font("Segoe UI", 11),
                Location = new Point(100, 368),
                Size = new Size(380, 35),
                BorderStyle = BorderStyle.FixedSingle,
                PasswordChar = '●'
            };

            Label lblRol = new Label
            {
                Text = "Rol",
                Font = new Font("Segoe UI", 11),
                ForeColor = ColoresSePrise.TextoSecundario,
                Location = new Point(100, 420),
                Size = new Size(200, 25)
            };

            ComboBox cmbRol = new ComboBox
            {
                Name = "cmbRol",
                Font = new Font("Segoe UI", 11),
                Location = new Point(100, 448),
                Size = new Size(380, 35),
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            cmbRol.Items.AddRange(new string[]
            {
                "Admisión", "Recepción", "Administración",
                "Médico", "Técnico", "Supervisor"
            });
            cmbRol.SelectedIndex = 0;

            Button btnIngresar = new Button
            {
                Text = "Ingresar",
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                BackColor = ColoresSePrise.VerdePrimario,
                ForeColor = ColoresSePrise.TextoBlanco,
                FlatStyle = FlatStyle.Flat,
                Location = new Point(100, 510),
                Size = new Size(180, 42),
                Cursor = Cursors.Hand
            };
            btnIngresar.FlatAppearance.BorderSize = 0;
            btnIngresar.Click += BtnIngresar_Click;

            Label lblError = new Label
            {
                Name = "lblError",
                Text = "",
                Font = new Font("Segoe UI", 10),
                ForeColor = ColoresSePrise.TextoError,
                Location = new Point(100, 562),
                Size = new Size(380, 25)
            };

            LinkLabel lnkRegistro = new LinkLabel
            {
                Text = "¿No tenés cuenta? Registrate aquí",
                Font = new Font("Segoe UI", 9),
                Location = new Point(100, 600),
                Size = new Size(300, 20),
                LinkColor = ColoresSePrise.VerdePrimario
            };
            lnkRegistro.LinkClicked += LnkRegistro_LinkClicked;

            panelDer.Controls.AddRange(new Control[]
            {
                lblTitulo, lblUsuario, txtUsuario,
                lblPassword, txtPassword,
                lblRol, cmbRol,
                btnIngresar, lblError, lnkRegistro
            });

            this.Controls.AddRange(new Control[] { panelIzq, panelDer });
        }

        private void BtnIngresar_Click(object? sender, EventArgs e)
        {
            var txtUsuario = this.Controls.Find("txtUsuario", true).FirstOrDefault() as TextBox;
            var txtPassword = this.Controls.Find("txtPassword", true).FirstOrDefault() as TextBox;
            var lblError = this.Controls.Find("lblError", true).FirstOrDefault() as Label;
            var cmbRol = this.Controls.Find("cmbRol", true).FirstOrDefault() as ComboBox;

            if (string.IsNullOrWhiteSpace(txtUsuario?.Text) ||
                string.IsNullOrWhiteSpace(txtPassword?.Text))
            {
                lblError!.Text = "⚠ Completá usuario y contraseña.";
                return;
            }

            FormPanelControl panel = new FormPanelControl(
                txtUsuario.Text, cmbRol?.Text ?? "Admisión");
            panel.Show();
            this.Hide();
        }

        private void LnkRegistro_LinkClicked(object? sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegistro registro = new FormRegistro();
            registro.ShowDialog();
        }
    }
}
