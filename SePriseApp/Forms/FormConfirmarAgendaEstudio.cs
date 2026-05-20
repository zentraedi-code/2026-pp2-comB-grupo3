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
    //  INTERFACE
    // ══════════════════════════════════════════════════════════
    public interface IConfirmarAgendaEstudioView
    {
        List<AgendaEstudio> Agendas { set; }
        List<TurnoEstudio> TurnosPreview { set; }
        AgendaEstudio? AgendaSeleccionada { get; }
        string InfoPreview { set; }

        event EventHandler Buscar;
        event EventHandler Confirmar;

        void MostrarError(string msg);
        void MostrarExito(string msg);
    }

    // ══════════════════════════════════════════════════════════
    //  PRESENTER
    // ══════════════════════════════════════════════════════════
    public class ConfirmarAgendaEstudioPresenter
    {
        private readonly IConfirmarAgendaEstudioView _view;
        private readonly IAgendaEstudioRepository _repo;

        public ConfirmarAgendaEstudioPresenter(IConfirmarAgendaEstudioView view,
                                               IAgendaEstudioRepository repo)
        {
            _view = view;
            _repo = repo;
            _view.Buscar += OnBuscar;
            _view.Confirmar += OnConfirmar;
        }

        private void OnBuscar(object? s, EventArgs e)
        {
            _view.Agendas = _repo.ObtenerPorEstado("BORRADOR");
            _view.TurnosPreview = new List<TurnoEstudio>();
            _view.InfoPreview = "Seleccione una agenda para ver la vista previa de turnos.";
        }

        // Llama el Form cuando cambia la selección en el grid
        public void MostrarPreview()
        {
            var agenda = _view.AgendaSeleccionada;
            if (agenda == null) return;

            // Genera los turnos en memoria solo para mostrar (aún no persiste)
            var preview = new List<TurnoEstudio>();
            var hora = agenda.HoraDesde;
            int numero = 1;

            while (hora < agenda.HoraHasta)
            {
                preview.Add(new TurnoEstudio
                {
                    Id = numero++,
                    Horario = hora,
                    Estado = "DISPONIBLE"
                });
                hora = hora.Add(TimeSpan.FromMinutes(agenda.DuracionMinutos));
            }

            _view.TurnosPreview = preview;
            _view.InfoPreview =
                $"Se generarán {preview.Count} turno(s) de {agenda.DuracionMinutos} min " +
                $"— todos en estado DISPONIBLE (sin sobreturno).";
        }

        private void OnConfirmar(object? s, EventArgs e)
        {
            var agenda = _view.AgendaSeleccionada;
            if (agenda == null)
            { _view.MostrarError("Seleccione una agenda para confirmar."); return; }

            if (agenda.Estado == "CONFIRMADA")
            { _view.MostrarError("Esta agenda ya fue confirmada anteriormente."); return; }

            // Confirmar y generar turnos reales
            agenda.Estado = "CONFIRMADA";
            _repo.Actualizar(agenda);
            var turnos = _repo.GenerarTurnos(agenda);

            _view.MostrarExito(
                $"Agenda confirmada exitosamente.\n" +
                $"Se generaron {turnos.Count} turno(s) en estado DISPONIBLE.");

            OnBuscar(s, e); // refresca el grid
        }
    }

    // ══════════════════════════════════════════════════════════
    //  FORM
    // ══════════════════════════════════════════════════════════
    public partial class FormConfirmarAgendaEstudio : Form, IConfirmarAgendaEstudioView
    {
        private readonly ConfirmarAgendaEstudioPresenter _presenter;
        private readonly string _usuario;
        private readonly string _rol;

        private DataGridView dgvAgendas = null!;
        private DataGridView dgvTurnos = null!;
        private Label lblInfo = null!;

        // ── Interface ──
        public List<AgendaEstudio> Agendas
        { set { dgvAgendas.DataSource = null; dgvAgendas.DataSource = value; } }

        public List<TurnoEstudio> TurnosPreview
        { set { dgvTurnos.DataSource = null; dgvTurnos.DataSource = value; } }

        public AgendaEstudio? AgendaSeleccionada =>
            dgvAgendas.CurrentRow?.DataBoundItem as AgendaEstudio;

        public string InfoPreview { set => lblInfo.Text = value; }

        public event EventHandler? Buscar;
        public event EventHandler? Confirmar;

        public void MostrarError(string msg) =>
            MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        public void MostrarExito(string msg) =>
            MessageBox.Show(msg, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

        public FormConfirmarAgendaEstudio(string usuario, string rol)
        {
            _usuario = usuario;
            _rol = rol;
            _presenter = new ConfirmarAgendaEstudioPresenter(this, new SePriseApp.Repositories.AgendaEstudioRepository());
            InitializeComponent();
            ConfigurarFormulario();
            Buscar?.Invoke(this, EventArgs.Empty); // carga al abrir
        }

        private void ConfigurarFormulario()
        {
            this.Text = "SePrise — CU17 Confirmar Agenda de Estudios";
            this.Size = new Size(1366, 768);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = ColoresSePrise.FondoVentana;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            Panel panelNav = CrearPanelNav();
            Panel panelMain = new Panel
            {
                Size = new Size(1146, 768),
                Location = new Point(220, 0),
                BackColor = ColoresSePrise.FondoVentana
            };

            panelMain.Controls.Add(new Label
            {
                Text = "Confirmar Agenda de Estudios — CU17",
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                ForeColor = ColoresSePrise.TextoPrimario,
                Location = new Point(40, 30),
                AutoSize = true
            });

            panelMain.Controls.Add(new Label
            {
                Text = "Agendas en estado BORRADOR. Al confirmar se generan los turnos DISPONIBLES.",
                Font = new Font("Segoe UI", 9),
                ForeColor = ColoresSePrise.TextoSecundario,
                Location = new Point(40, 68),
                AutoSize = true
            });

            // ── GroupBox agendas ─────────────────────────────
            GroupBox grp1 = new GroupBox
            {
                Text = "Agendas en BORRADOR",
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                Location = new Point(40, 100),
                Size = new Size(1060, 220),
                BackColor = ColoresSePrise.FondoControl
            };

            var btnBuscar = Btn("🔍  Buscar", 20, 25, false);
            btnBuscar.Width = 120;
            btnBuscar.Click += (s, e) => Buscar?.Invoke(s, e);
            grp1.Controls.Add(btnBuscar);

            dgvAgendas = new DataGridView
            {
                Location = new Point(20, 65),
                Size = new Size(1020, 140),
                ReadOnly = true,
                AllowUserToAddRows = false,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                BackgroundColor = ColoresSePrise.FondoControl,
                BorderStyle = BorderStyle.None,
                RowHeadersVisible = false
            };
            dgvAgendas.SelectionChanged += (s, e) => _presenter.MostrarPreview();
            grp1.Controls.Add(dgvAgendas);
            panelMain.Controls.Add(grp1);

            // ── GroupBox preview turnos ───────────────────────
            GroupBox grp2 = new GroupBox
            {
                Text = "Vista previa de turnos a generar",
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                Location = new Point(40, 335),
                Size = new Size(1060, 250),
                BackColor = ColoresSePrise.FondoControl
            };

            lblInfo = new Label
            {
                Text = "Seleccione una agenda para ver la vista previa.",
                Font = new Font("Segoe UI", 9, FontStyle.Italic),
                ForeColor = ColoresSePrise.TextoSecundario,
                Location = new Point(20, 28),
                AutoSize = true
            };
            grp2.Controls.Add(lblInfo);

            dgvTurnos = new DataGridView
            {
                Location = new Point(20, 55),
                Size = new Size(1020, 180),
                ReadOnly = true,
                AllowUserToAddRows = false,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                BackgroundColor = ColoresSePrise.FondoControl,
                BorderStyle = BorderStyle.None,
                RowHeadersVisible = false
            };
            grp2.Controls.Add(dgvTurnos);
            panelMain.Controls.Add(grp2);

            // ── Botones ──────────────────────────────────────
            var btnConfirmar = Btn("✔  Confirmar agenda", 40, 610, true);
            var btnVolver = Btn("← Volver", 220, 610, false);
            btnConfirmar.Click += (s, e) => Confirmar?.Invoke(s, e);
            btnVolver.Click += (s, e) => {
                new FormEstudiosClinicosPanel(_usuario, _rol).Show(); this.Close();
            };
            panelMain.Controls.AddRange(new Control[] { btnConfirmar, btnVolver });

            this.Controls.AddRange(new Control[] { panelNav, panelMain });
        }

        private Button Btn(string t, int x, int y, bool primario)
        {
            var b = new Button
            {
                Text = t,
                Location = new Point(x, y),
                Size = new Size(170, 38),
                Font = new Font("Segoe UI", 10),
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand,
                BackColor = primario ? ColoresSePrise.VerdePrimario : ColoresSePrise.FondoControl,
                ForeColor = primario ? ColoresSePrise.TextoBlanco : ColoresSePrise.TextoPrimario
            };
            b.FlatAppearance.BorderColor = primario ? ColoresSePrise.VerdeOscuro : ColoresSePrise.Borde;
            return b;
        }

        private Panel CrearPanelNav()
        {
            var p = new Panel
            {
                Size = new Size(220, 768),
                Location = new Point(0, 0),
                BackColor = ColoresSePrise.VerdePrimario
            };
            p.Controls.Add(new Label
            {
                Text = "MÓDULOS",
                Font = new Font("Segoe UI", 8, FontStyle.Bold),
                ForeColor = ColoresSePrise.VerdeClaro,
                Location = new Point(20, 30),
                Size = new Size(180, 20)
            });

            var b1 = BtnNav("Panel de control", 60, false);
            var b2 = BtnNav("Gestión de pacientes", 100, false);
            var b3 = BtnNav("Consultorios externos", 140, false);
            var b4 = BtnNav("Estudios clínicos", 180, true);
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
            var bC = BtnNav("Cerrar sesión", 665, false);
            bC.Click += (s, e) => { new FormLogin().Show(); this.Close(); };
            p.Controls.AddRange(new Control[] { b1, b2, b3, b4, bC });
            return p;
        }

        private Button BtnNav(string t, int y, bool activo)
        {
            var b = new Button
            {
                Text = t,
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
            b.FlatAppearance.BorderSize = 0;
            return b;
        }
    }
}
