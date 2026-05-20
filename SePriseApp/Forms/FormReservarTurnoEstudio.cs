using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using SePriseApp.Models;
using SePriseApp.Repositories;
using SePriseApp.Utils;

namespace SePriseApp.Forms
{
    // ══════════════════════════════════════════════════════════
    //  CU18 – RESERVAR TURNO DE ESTUDIO
    // ══════════════════════════════════════════════════════════

    public interface IReservarTurnoEstudioView
    {
        // Presenter lee
        string DniBusqueda { get; }
        string TipoEstudio { get; }
        DateTime FechaDeseada { get; }
        TurnoEstudio? TurnoSeleccionado { get; }

        // Presenter escribe
        string NombrePaciente { set; }
        string ObraSocial { set; }
        List<TurnoEstudio> Turnos { set; }
        string ResumenPaciente { set; }
        string ResumenEstudio { set; }
        string ResumenFecha { set; }

        event EventHandler BuscarPaciente;
        event EventHandler BuscarDisponibilidad;
        event EventHandler PrimeraDisponible;
        event EventHandler ConfirmarReserva;

        void MostrarError(string msg);
        void MostrarExito(string msg);
        void LimpiarResumen();
    }

    public class ReservarTurnoEstudioPresenter
    {
        private readonly IReservarTurnoEstudioView _view;
        private readonly IAgendaEstudioRepository _agendaRepo;
        private readonly IPacienteECRepository _pacienteRepo;
        private PacienteEC? _pacienteActual;

        public ReservarTurnoEstudioPresenter(IReservarTurnoEstudioView view,
                                             IAgendaEstudioRepository agendaRepo,
                                             IPacienteECRepository pacienteRepo)
        {
            _view = view; _agendaRepo = agendaRepo; _pacienteRepo = pacienteRepo;
            _view.BuscarPaciente += OnBuscarPaciente;
            _view.BuscarDisponibilidad += OnBuscarDisponibilidad;
            _view.PrimeraDisponible += OnPrimeraDisponible;
            _view.ConfirmarReserva += OnConfirmar;
        }

        private void OnBuscarPaciente(object? s, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(_view.DniBusqueda))
            { _view.MostrarError("Ingrese un DNI para buscar."); return; }

            var p = _pacienteRepo.BuscarPorDni(_view.DniBusqueda);
            if (p == null)
            { _view.MostrarError("No se encontró un paciente con ese DNI."); return; }

            _pacienteActual = p;
            _view.NombrePaciente = p.NombreCompleto;
            _view.ObraSocial = p.ObraSocial;
        }

        private void OnBuscarDisponibilidad(object? s, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(_view.TipoEstudio))
            { _view.MostrarError("Seleccione un tipo de estudio."); return; }

            var agendas = _agendaRepo.ObtenerPorEstado("CONFIRMADA")
                .FindAll(a => a.TipoEstudio == _view.TipoEstudio
                           && a.Fecha.Date == _view.FechaDeseada.Date);

            if (agendas.Count == 0)
            { _view.MostrarError("No hay agenda confirmada para ese tipo y fecha."); return; }

            var turnos = _agendaRepo.ObtenerTurnosPorAgenda(agendas[0].Id)
                .FindAll(t => t.Estado == "DISPONIBLE");

            if (turnos.Count == 0)
            { _view.MostrarError("No hay turnos disponibles para esa agenda."); return; }

            _view.Turnos = turnos;
        }

        private void OnPrimeraDisponible(object? s, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(_view.TipoEstudio))
            { _view.MostrarError("Seleccione un tipo de estudio."); return; }

            var agendas = _agendaRepo.ObtenerPorEstado("CONFIRMADA")
                .FindAll(a => a.TipoEstudio == _view.TipoEstudio
                           && a.Fecha.Date >= DateTime.Today);
            agendas.Sort((a, b) => a.Fecha.CompareTo(b.Fecha));

            foreach (var ag in agendas)
            {
                var turnos = _agendaRepo.ObtenerTurnosPorAgenda(ag.Id)
                    .FindAll(t => t.Estado == "DISPONIBLE");
                if (turnos.Count > 0) { _view.Turnos = turnos; return; }
            }
            _view.MostrarError("No hay turnos disponibles para ese tipo de estudio.");
        }

        private void OnConfirmar(object? s, EventArgs e)
        {
            if (_pacienteActual == null)
            { _view.MostrarError("Primero busque y seleccione un paciente."); return; }

            var turno = _view.TurnoSeleccionado;
            if (turno == null)
            { _view.MostrarError("Seleccione un turno de la lista."); return; }

            turno.Estado = "RESERVADO";
            turno.PacienteId = _pacienteActual.Id;
            _agendaRepo.ActualizarTurno(turno);

            _view.ResumenPaciente = _pacienteActual.NombreCompleto;
            _view.ResumenEstudio = _view.TipoEstudio;
            _view.ResumenFecha = $"{_view.FechaDeseada:dd/MM/yyyy}  —  {turno.HorarioDisplay} hs";

            _view.MostrarExito(
                $"Turno reservado exitosamente.\n\n" +
                $"Paciente: {_pacienteActual.NombreCompleto}\n" +
                $"Horario:  {turno.HorarioDisplay}");
        }
    }

    public partial class FormReservarTurnoEstudio : Form, IReservarTurnoEstudioView
    {
        private readonly ReservarTurnoEstudioPresenter _presenter;
        private readonly string _usuario, _rol;

        private TextBox txtDni = null!, txtNombre = null!, txtOS = null!;
        private ComboBox cmbTipo = null!;
        private DateTimePicker dtpFecha = null!;
        private DataGridView dgvTurnos = null!;
        private TextBox txtResPaciente = null!, txtResEstudio = null!, txtResFecha = null!;

        public string DniBusqueda => txtDni.Text;
        public string TipoEstudio => cmbTipo.Text;
        public DateTime FechaDeseada => dtpFecha.Value;
        public TurnoEstudio? TurnoSeleccionado =>
            dgvTurnos.CurrentRow?.DataBoundItem as TurnoEstudio;

        public string NombrePaciente { set => txtNombre.Text = value; }
        public string ObraSocial { set => txtOS.Text = value; }
        public List<TurnoEstudio> Turnos
        { set { dgvTurnos.DataSource = null; dgvTurnos.DataSource = value; } }
        public string ResumenPaciente { set => txtResPaciente.Text = value; }
        public string ResumenEstudio { set => txtResEstudio.Text = value; }
        public string ResumenFecha { set => txtResFecha.Text = value; }

        public event EventHandler? BuscarPaciente;
        public event EventHandler? BuscarDisponibilidad;
        public event EventHandler? PrimeraDisponible;
        public event EventHandler? ConfirmarReserva;

        public void MostrarError(string msg) =>
            MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        public void MostrarExito(string msg) =>
            MessageBox.Show(msg, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        public void LimpiarResumen()
        {
            txtResPaciente.Text = txtResEstudio.Text = txtResFecha.Text = string.Empty;
        }

        public FormReservarTurnoEstudio(string usuario, string rol)
        {
            _usuario = usuario; _rol = rol;
            _presenter = new ReservarTurnoEstudioPresenter(
    this, new Repositories.AgendaEstudioRepository(), new PacienteECRepository());
            InitializeComponent();
            ConfigurarFormulario();
        }

        private void ConfigurarFormulario()
        {
            this.Text = "SePrise — CU18 Reservar Turno de Estudio";
            this.Size = new Size(1366, 768); this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = ColoresSePrise.FondoVentana;
            this.FormBorderStyle = FormBorderStyle.FixedSingle; this.MaximizeBox = false;

            Panel panelNav = CrearPanelNav();
            Panel panelMain = new Panel
            {
                Size = new Size(1146, 768),
                Location = new Point(220, 0),
                BackColor = ColoresSePrise.FondoVentana
            };

            panelMain.Controls.Add(new Label
            {
                Text = "Reservar Turno de Estudio — CU18",
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                ForeColor = ColoresSePrise.TextoPrimario,
                Location = new Point(40, 30),
                AutoSize = true
            });

            // ── GroupBox Paciente ────────────────────────────
            var g1 = new GroupBox
            {
                Text = "Datos del Paciente",
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                Location = new Point(40, 90),
                Size = new Size(1060, 110),
                BackColor = ColoresSePrise.FondoControl
            };

            g1.Controls.Add(Lbl("DNI:", 20, 30));
            txtDni = new TextBox { Location = new Point(80, 28), Width = 130, Font = new Font("Segoe UI", 10) };
            g1.Controls.Add(txtDni);

            var bBuscarP = Btn("🔍  Buscar paciente", 220, 26, false); bBuscarP.Width = 160;
            bBuscarP.Click += (s, e) => BuscarPaciente?.Invoke(s, e);
            g1.Controls.Add(bBuscarP);

            g1.Controls.Add(Lbl("Nombre:", 400, 30));
            txtNombre = RO(470, 28, 250); g1.Controls.Add(txtNombre);

            g1.Controls.Add(Lbl("Obra Social:", 20, 68));
            txtOS = RO(120, 66, 200); g1.Controls.Add(txtOS);
            panelMain.Controls.Add(g1);

            // ── GroupBox Búsqueda de turno ───────────────────
            var g2 = new GroupBox
            {
                Text = "Búsqueda de Turno Disponible",
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                Location = new Point(40, 215),
                Size = new Size(1060, 250),
                BackColor = ColoresSePrise.FondoControl
            };

            g2.Controls.Add(Lbl("Tipo de estudio:", 20, 30));
            cmbTipo = new ComboBox
            {
                Location = new Point(160, 28),
                Width = 240,
                DropDownStyle = ComboBoxStyle.DropDownList,
                Font = new Font("Segoe UI", 10)
            };
            cmbTipo.Items.AddRange(new object[]{"Ecografía Abdominal","Radiografía de Tórax",
                "Laboratorio General","Tomografía Computada","Resonancia Magnética"});
            g2.Controls.Add(cmbTipo);

            g2.Controls.Add(Lbl("Fecha deseada:", 20, 68));
            dtpFecha = new DateTimePicker
            {
                Location = new Point(160, 66),
                Width = 160,
                Format = DateTimePickerFormat.Short,
                Value = DateTime.Today,
                Font = new Font("Segoe UI", 10)
            };
            g2.Controls.Add(dtpFecha);

            var bBuscarD = Btn("🔍  Buscar disponibilidad", 340, 64, false); bBuscarD.Width = 190;
            bBuscarD.Click += (s, e) => BuscarDisponibilidad?.Invoke(s, e);
            g2.Controls.Add(bBuscarD);

            var bPrimera = Btn("⚡  Primera disponible", 545, 64, false); bPrimera.Width = 180;
            bPrimera.Click += (s, e) => PrimeraDisponible?.Invoke(s, e);
            g2.Controls.Add(bPrimera);

            dgvTurnos = new DataGridView
            {
                Location = new Point(20, 105),
                Size = new Size(1020, 130),
                ReadOnly = true,
                AllowUserToAddRows = false,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                BackgroundColor = ColoresSePrise.FondoControl,
                BorderStyle = BorderStyle.None,
                RowHeadersVisible = false
            };
            g2.Controls.Add(dgvTurnos);
            panelMain.Controls.Add(g2);

            // ── GroupBox Resumen ──────────────────────────────
            var g3 = new GroupBox
            {
                Text = "Resumen de la Reserva",
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                Location = new Point(40, 480),
                Size = new Size(1060, 115),
                BackColor = ColoresSePrise.FondoControl
            };

            g3.Controls.Add(Lbl("Paciente:", 20, 30));
            txtResPaciente = RO(110, 28, 280); txtResPaciente.BackColor = Color.FromArgb(232, 240, 232);
            g3.Controls.Add(txtResPaciente);

            g3.Controls.Add(Lbl("Tipo de estudio:", 420, 30));
            txtResEstudio = RO(560, 28, 240); txtResEstudio.BackColor = Color.FromArgb(232, 240, 232);
            g3.Controls.Add(txtResEstudio);

            g3.Controls.Add(Lbl("Fecha y hora:", 20, 70));
            txtResFecha = RO(120, 68, 260); txtResFecha.BackColor = Color.FromArgb(232, 240, 232);
            txtResFecha.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            g3.Controls.Add(txtResFecha);
            panelMain.Controls.Add(g3);

            // ── Botones ──────────────────────────────────────
            var bConfirmar = Btn("📅  Confirmar reserva", 40, 620, true);
            bConfirmar.Click += (s, e) => ConfirmarReserva?.Invoke(s, e);

            var bLimpiar = Btn("🗑  Limpiar", 230, 620, false);
            bLimpiar.Click += (s, e) => {
                txtDni.Clear(); txtNombre.Clear(); txtOS.Clear();
                dgvTurnos.DataSource = null; LimpiarResumen();
            };

            var bVolver = Btn("← Volver", 400, 620, false);
            bVolver.Click += (s, e) => { new FormEstudiosClinicosPanel(_usuario, _rol).Show(); this.Close(); };

            panelMain.Controls.AddRange(new Control[] { bConfirmar, bLimpiar, bVolver });
            this.Controls.AddRange(new Control[] { panelNav, panelMain });
        }

        private Label Lbl(string t, int x, int y) => new Label
        {
            Text = t,
            Location = new Point(x, y + 3),
            AutoSize = true,
            Font = new Font("Segoe UI", 10),
            ForeColor = ColoresSePrise.TextoPrimario
        };
        private TextBox RO(int x, int y, int w) => new TextBox
        {
            Location = new Point(x, y),
            Width = w,
            ReadOnly = true,
            BackColor = ColoresSePrise.FondoVentana,
            Font = new Font("Segoe UI", 10)
        };
        private Button Btn(string t, int x, int y, bool pr)
        {
            var b = new Button
            {
                Text = t,
                Location = new Point(x, y),
                Size = new Size(180, 38),
                Font = new Font("Segoe UI", 10),
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand,
                BackColor = pr ? ColoresSePrise.VerdePrimario : ColoresSePrise.FondoControl,
                ForeColor = pr ? ColoresSePrise.TextoBlanco : ColoresSePrise.TextoPrimario
            };
            b.FlatAppearance.BorderColor = pr ? ColoresSePrise.VerdeOscuro : ColoresSePrise.Borde;
            return b;
        }

        private Panel CrearPanelNav()
        {
            var p = new Panel { Size = new Size(220, 768), Location = new Point(0, 0), BackColor = ColoresSePrise.VerdePrimario };
            p.Controls.Add(new Label
            {
                Text = "MÓDULOS",
                Font = new Font("Segoe UI", 8, FontStyle.Bold),
                ForeColor = ColoresSePrise.VerdeClaro,
                Location = new Point(20, 30),
                Size = new Size(180, 20)
            });
            var b1 = BN("Panel de control", 60, false); var b2 = BN("Gestión de pacientes", 100, false);
            var b3 = BN("Consultorios externos", 140, false); var b4 = BN("Estudios clínicos", 180, true);
            b1.Click += (s, e) => { new FormPanelControl(_usuario, _rol).Show(); this.Close(); };
            b2.Click += (s, e) => { new FormGestionPacientes(_usuario, _rol).Show(); this.Close(); };
            b4.Click += (s, e) => { new FormEstudiosClinicosPanel(_usuario, _rol).Show(); this.Close(); };
            p.Controls.Add(new Label
            {
                Text = "SESIÓN",
                Font = new Font("Segoe UI", 8, FontStyle.Bold),
                ForeColor = ColoresSePrise.VerdeClaro,
                Location = new Point(20, 640),
                Size = new Size(180, 20)
            });
            var bC = BN("Cerrar sesión", 665, false); bC.Click += (s, e) => { new FormLogin().Show(); this.Close(); };
            p.Controls.AddRange(new Control[] { b1, b2, b3, b4, bC }); return p;
        }

        private Button BN(string t, int y, bool a)
        {
            var b = new Button
            {
                Text = t,
                Font = new Font("Segoe UI", 10),
                ForeColor = ColoresSePrise.TextoBlanco,
                BackColor = a ? ColoresSePrise.VerdeOscuro : ColoresSePrise.VerdePrimario,
                FlatStyle = FlatStyle.Flat,
                Location = new Point(0, y),
                Size = new Size(220, 38),
                TextAlign = ContentAlignment.MiddleLeft,
                Padding = new Padding(20, 0, 0, 0),
                Cursor = Cursors.Hand
            };
            b.FlatAppearance.BorderSize = 0; return b;
        }
    }
}
