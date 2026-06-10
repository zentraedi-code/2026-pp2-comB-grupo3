using System.Drawing;
using System.Windows.Forms;
using SePriseApp.Utils;

namespace SePriseApp.Forms
{
    public partial class FormABMPacientes : Form
    {
        private string _usuario;
        private string _rol;

        public FormABMPacientes(string usuario, string rol)
        {
            InitializeComponent();
            _usuario = usuario;
            _rol = rol;
            ConfigurarFormulario();
        }

        private void ConfigurarFormulario()
        {
            this.Text = "SePrise — ABM Pacientes";
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
            btnPacientes.Click += (s, e) => {
                new FormGestionPacientes(_usuario, _rol).Show();
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
                Text = "ABM Pacientes",
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                ForeColor = ColoresSePrise.TextoPrimario,
                Location = new Point(40, 30),
                Size = new Size(400, 35)
            };

            // ── BOTONERA ────────────────────────────────────────
            Button btnNuevo = new Button
            {
                Text = "+ Nuevo paciente",
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                BackColor = ColoresSePrise.VerdePrimario,
                ForeColor = ColoresSePrise.TextoBlanco,
                FlatStyle = FlatStyle.Flat,
                Location = new Point(40, 80),
                Size = new Size(160, 36),
                Cursor = Cursors.Hand
            };
            btnNuevo.FlatAppearance.BorderSize = 0;

            Button btnModificar = new Button
            {
                Text = "Modificar",
                Font = new Font("Segoe UI", 10),
                BackColor = ColoresSePrise.FondoControl,
                ForeColor = ColoresSePrise.TextoPrimario,
                FlatStyle = FlatStyle.Flat,
                Location = new Point(210, 80),
                Size = new Size(120, 36),
                Cursor = Cursors.Hand
            };
            btnModificar.FlatAppearance.BorderColor = ColoresSePrise.Borde;

            Button btnBaja = new Button
            {
                Text = "Dar de baja",
                Font = new Font("Segoe UI", 10),
                BackColor = ColoresSePrise.FondoControl,
                ForeColor = ColoresSePrise.TextoError,
                FlatStyle = FlatStyle.Flat,
                Location = new Point(340, 80),
                Size = new Size(120, 36),
                Cursor = Cursors.Hand
            };
            btnBaja.FlatAppearance.BorderColor = ColoresSePrise.Borde;

            // ── BUSCAR ──────────────────────────────────────────
            TextBox txtBuscar = new TextBox
            {
                Font = new Font("Segoe UI", 10),
                Location = new Point(800, 83),
                Size = new Size(280, 32),
                BorderStyle = BorderStyle.FixedSingle,
                PlaceholderText = "Buscar por nombre o DNI..."
            };

            // ── DATAGRIDVIEW ────────────────────────────────────
            DataGridView grilla = new DataGridView
            {
                Name = "grillaPacientes",
                Location = new Point(40, 135),
                Size = new Size(1060, 480),
                BackgroundColor = ColoresSePrise.FondoControl,
                BorderStyle = BorderStyle.FixedSingle,
                RowHeadersVisible = false,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                ReadOnly = true,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                Font = new Font("Segoe UI", 10),
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            };

            grilla.ColumnHeadersDefaultCellStyle.BackColor = ColoresSePrise.FondoVentana;
            grilla.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            grilla.EnableHeadersVisualStyles = false;

            grilla.Columns.AddRange(
                new DataGridViewTextBoxColumn { HeaderText = "DNI", Name = "DNI" },
                new DataGridViewTextBoxColumn { HeaderText = "Apellido", Name = "Apellido" },
                new DataGridViewTextBoxColumn { HeaderText = "Nombre", Name = "Nombre" },
                new DataGridViewTextBoxColumn { HeaderText = "Empadronamiento", Name = "Empadronamiento" },
                new DataGridViewTextBoxColumn { HeaderText = "Estado", Name = "Estado" }
            );

            // Datos de prueba
            grilla.Rows.Add("30111222", "Pérez", "Juan", "EP-0001", "Activo");
            grilla.Rows.Add("28445667", "Gómez", "María", "EP-0002", "Activo");
            grilla.Rows.Add("35778900", "López", "Carlos", "EP-0003", "Inactivo");

            Label lblInfo = new Label
            {
                Text = "3 registros · Doble clic para ver detalle",
                Font = new Font("Segoe UI", 9),
                ForeColor = ColoresSePrise.TextoSecundario,
                Location = new Point(40, 625),
                Size = new Size(400, 22)
            };

            panelMain.Controls.AddRange(new Control[]
            {
                lblTitulo, btnNuevo, btnModificar, btnBaja,
                txtBuscar, grilla, lblInfo
            });

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
    }
}