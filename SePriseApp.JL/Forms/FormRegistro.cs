using System.Drawing;
using System.Windows.Forms;
using SePriseApp.Utils;

namespace SePriseApp.Forms
{
    public partial class FormRegistro : Form
    {
        public FormRegistro()
        {
            InitializeComponent();
            ConfigurarFormulario();
        }

        private void ConfigurarFormulario()
        {
            this.Text = "SePrise — Registro de Empleado";
            this.Size = new Size(520, 620);
            this.StartPosition = FormStartPosition.CenterParent;
            this.BackColor = ColoresSePrise.FondoVentana;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // ── HEADER ──────────────────────────────────────────
            Panel panelHeader = new Panel
            {
                Size = new Size(520, 70),
                Location = new Point(0, 0),
                BackColor = ColoresSePrise.VerdePrimario
            };

            Label lblTitulo = new Label
            {
                Text = "Registro de Empleado",
                Font = new Font("Segoe UI", 16, FontStyle.Bold),
                ForeColor = ColoresSePrise.TextoBlanco,
                TextAlign = ContentAlignment.MiddleCenter,
                Size = new Size(520, 70),
                Location = new Point(0, 0)
            };

            panelHeader.Controls.Add(lblTitulo);

            // ── CAMPOS ──────────────────────────────────────────
            // Nombre
            Label lblNombre = new Label
            {
                Text = "Nombre",
                Font = new Font("Segoe UI", 10),
                ForeColor = ColoresSePrise.TextoSecundario,
                Location = new Point(60, 100),
                Size = new Size(200, 22)
            };
            TextBox txtNombre = new TextBox
            {
                Name = "txtNombre",
                Font = new Font("Segoe UI", 11),
                Location = new Point(60, 124),
                Size = new Size(390, 32),
                BorderStyle = BorderStyle.FixedSingle
            };

            // Apellido
            Label lblApellido = new Label
            {
                Text = "Apellido",
                Font = new Font("Segoe UI", 10),
                ForeColor = ColoresSePrise.TextoSecundario,
                Location = new Point(60, 170),
                Size = new Size(200, 22)
            };
            TextBox txtApellido = new TextBox
            {
                Name = "txtApellido",
                Font = new Font("Segoe UI", 11),
                Location = new Point(60, 194),
                Size = new Size(390, 32),
                BorderStyle = BorderStyle.FixedSingle
            };

            // Usuario
            Label lblUsuario = new Label
            {
                Text = "Usuario",
                Font = new Font("Segoe UI", 10),
                ForeColor = ColoresSePrise.TextoSecundario,
                Location = new Point(60, 240),
                Size = new Size(200, 22)
            };
            TextBox txtUsuario = new TextBox
            {
                Name = "txtUsuario",
                Font = new Font("Segoe UI", 11),
                Location = new Point(60, 264),
                Size = new Size(390, 32),
                BorderStyle = BorderStyle.FixedSingle
            };

            // Contraseña
            Label lblPassword = new Label
            {
                Text = "Contraseña",
                Font = new Font("Segoe UI", 10),
                ForeColor = ColoresSePrise.TextoSecundario,
                Location = new Point(60, 310),
                Size = new Size(200, 22)
            };
            TextBox txtPassword = new TextBox
            {
                Name = "txtPassword",
                Font = new Font("Segoe UI", 11),
                Location = new Point(60, 334),
                Size = new Size(390, 32),
                BorderStyle = BorderStyle.FixedSingle,
                PasswordChar = '●'
            };

            // Rol
            Label lblRol = new Label
            {
                Text = "Rol",
                Font = new Font("Segoe UI", 10),
                ForeColor = ColoresSePrise.TextoSecundario,
                Location = new Point(60, 380),
                Size = new Size(200, 22)
            };
            ComboBox cmbRol = new ComboBox
            {
                Name = "cmbRol",
                Font = new Font("Segoe UI", 11),
                Location = new Point(60, 404),
                Size = new Size(390, 32),
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            cmbRol.Items.AddRange(new string[]
            {
                "Admisión", "Recepción", "Administración",
                "Médico", "Técnico", "Supervisor"
            });
            cmbRol.SelectedIndex = 0;

            // Mensaje error
            Label lblError = new Label
            {
                Name = "lblError",
                Text = "",
                Font = new Font("Segoe UI", 9),
                ForeColor = ColoresSePrise.TextoError,
                Location = new Point(60, 448),
                Size = new Size(390, 22)
            };

            // ── BOTONES ─────────────────────────────────────────
            Button btnRegistrar = new Button
            {
                Text = "Registrar",
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                BackColor = ColoresSePrise.VerdePrimario,
                ForeColor = ColoresSePrise.TextoBlanco,
                FlatStyle = FlatStyle.Flat,
                Location = new Point(60, 480),
                Size = new Size(180, 42),
                Cursor = Cursors.Hand
            };
            btnRegistrar.FlatAppearance.BorderSize = 0;
            btnRegistrar.Click += BtnRegistrar_Click;

            Button btnCancelar = new Button
            {
                Text = "Cancelar",
                Font = new Font("Segoe UI", 11),
                BackColor = ColoresSePrise.FondoControl,
                ForeColor = ColoresSePrise.TextoPrimario,
                FlatStyle = FlatStyle.Flat,
                Location = new Point(270, 480),
                Size = new Size(180, 42),
                Cursor = Cursors.Hand
            };
            btnCancelar.FlatAppearance.BorderColor = ColoresSePrise.Borde;
            btnCancelar.Click += (s, e) => this.Close();

            this.Controls.AddRange(new Control[]
            {
                panelHeader,
                lblNombre, txtNombre,
                lblApellido, txtApellido,
                lblUsuario, txtUsuario,
                lblPassword, txtPassword,
                lblRol, cmbRol,
                lblError,
                btnRegistrar, btnCancelar
            });
        }

        private void BtnRegistrar_Click(object? sender, EventArgs e)
        {
            var txtNombre = this.Controls.Find("txtNombre", true).FirstOrDefault() as TextBox;
            var txtApellido = this.Controls.Find("txtApellido", true).FirstOrDefault() as TextBox;
            var txtUsuario = this.Controls.Find("txtUsuario", true).FirstOrDefault() as TextBox;
            var txtPassword = this.Controls.Find("txtPassword", true).FirstOrDefault() as TextBox;
            var lblError = this.Controls.Find("lblError", true).FirstOrDefault() as Label;

            if (string.IsNullOrWhiteSpace(txtNombre?.Text) ||
                string.IsNullOrWhiteSpace(txtApellido?.Text) ||
                string.IsNullOrWhiteSpace(txtUsuario?.Text) ||
                string.IsNullOrWhiteSpace(txtPassword?.Text))
            {
                lblError!.Text = "⚠ Completá todos los campos.";
                return;
            }

            MessageBox.Show(
                "Empleado registrado correctamente.",
                "SePrise",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            this.Close();
        }
    }
}
