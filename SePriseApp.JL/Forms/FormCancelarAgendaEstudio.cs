using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using SePriseApp.Models;
using SePriseApp.Repositories;
using SePriseApp.Utils;

// ══════════════════════════════════════════════════════════════
//  CU16 – CANCELAR AGENDA DE ESTUDIOS
// ══════════════════════════════════════════════════════════════
namespace SePriseApp.Forms
{
    public interface ICancelarAgendaEstudioView
    {
        List<AgendaEstudio> Agendas { set; }
        AgendaEstudio? AgendaSeleccionada { get; }

        string DetalleTipo { set; }
        string DetalleFecha { set; }
        string DetalleHorario { set; }
        string DetalleTurnos { set; }
        string DetalleEstado { set; }
        bool AdvertenciaVisible { set; }

        event EventHandler Buscar;
        event EventHandler Cancelar;

        void MostrarError(string msg);
        void MostrarExito(string msg);
        bool ConfirmarAccion(string msg);
    }

    public class CancelarAgendaEstudioPresenter
    {
        private readonly ICancelarAgendaEstudioView _view;
        private readonly IAgendaEstudioRepository _repo;

        public CancelarAgendaEstudioPresenter(ICancelarAgendaEstudioView view,
                                              IAgendaEstudioRepository repo)
        {
            _view = view; _repo = repo;
            _view.Buscar += OnBuscar;
            _view.Cancelar += OnCancelar;
        }

        private void OnBuscar(object? s, EventArgs e) =>
            _view.Agendas = _repo.ObtenerTodas()
                .FindAll(a => a.Estado != "CANCELADA");

        public void ActualizarDetalle()
        {
            var a = _view.AgendaSeleccionada;
            if (a == null) return;
            _view.DetalleTipo = a.TipoEstudio;
            _view.DetalleFecha = a.Fecha.ToString("dd/MM/yyyy");
            _view.DetalleHorario = a.HorarioDisplay;
            _view.DetalleTurnos = $"{a.CantidadTurnos} turno(s)";
            _view.DetalleEstado = a.Estado;
            _view.AdvertenciaVisible = true;
        }

        private void OnCancelar(object? s, EventArgs e)
        {
            var agenda = _view.AgendaSeleccionada;
            if (agenda == null)
            { _view.MostrarError("Seleccione una agenda para cancelar."); return; }

            bool ok = _view.ConfirmarAccion(
                $"¿Confirma la cancelación?\n\n" +
                $"  Tipo:   {agenda.TipoEstudio}\n" +
                $"  Fecha:  {agenda.Fecha:dd/MM/yyyy}\n" +
                $"  Turnos: {agenda.CantidadTurnos}\n\n" +
                "Todos los turnos pasarán a CANCELADO.\n" +
                "Esta acción NO puede revertirse.");
            if (!ok) return;

            agenda.Estado = "CANCELADA";
            _repo.Actualizar(agenda);

            var turnos = _repo.ObtenerTurnosPorAgenda(agenda.Id);
            foreach (var t in turnos) { t.Estado = "CANCELADO"; _repo.ActualizarTurno(t); }

            _view.MostrarExito($"Agenda cancelada. {turnos.Count} turno(s) cancelado(s).");
            _view.AdvertenciaVisible = false;
            OnBuscar(s, e);
        }
    }

    public partial class FormCancelarAgendaEstudio : Form, ICancelarAgendaEstudioView
    {
        private readonly CancelarAgendaEstudioPresenter _presenter;
        private readonly string _usuario, _rol;

        private DataGridView dgv = null!;
        private TextBox txtTipo = null!, txtFecha = null!,
                        txtHora = null!, txtTurnos = null!, txtEstado = null!;
        private Label lblAdv = null!;

        public List<AgendaEstudio> Agendas
        { set { dgv.DataSource = null; dgv.DataSource = value; } }
        public AgendaEstudio? AgendaSeleccionada =>
            dgv.CurrentRow?.DataBoundItem as AgendaEstudio;

        public string DetalleTipo { set => txtTipo.Text = value; }
        public string DetalleFecha { set => txtFecha.Text = value; }
        public string DetalleHorario { set => txtHora.Text = value; }
        public string DetalleTurnos { set => txtTurnos.Text = value; }
        public string DetalleEstado { set => txtEstado.Text = value; }
        public bool AdvertenciaVisible { set => lblAdv.Visible = value; }

        public event EventHandler? Buscar;
        public event EventHandler? Cancelar;

        public void MostrarError(string msg) =>
            MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        public void MostrarExito(string msg) =>
            MessageBox.Show(msg, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        public bool ConfirmarAccion(string msg) =>
            MessageBox.Show(msg, "Confirmar cancelación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes;

        public FormCancelarAgendaEstudio(string usuario, string rol)
        {
            _usuario = usuario; _rol = rol;
            _presenter = new CancelarAgendaEstudioPresenter(this, new SePriseApp.Repositories.AgendaEstudioRepository());
            InitializeComponent();
            ConfigurarFormulario();
            Buscar?.Invoke(this, EventArgs.Empty);
        }

        private void ConfigurarFormulario()
        {
            this.Text = "SePrise — CU16 Cancelar Agenda de Estudios";
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
                Text = "Cancelar Agenda de Estudios — CU16",
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                ForeColor = ColoresSePrise.TextoPrimario,
                Location = new Point(40, 30),
                AutoSize = true
            });

            // GroupBox lista
            var g1 = new GroupBox
            {
                Text = "Agendas disponibles (BORRADOR / CONFIRMADA)",
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                Location = new Point(40, 90),
                Size = new Size(1060, 240),
                BackColor = ColoresSePrise.FondoControl
            };

            var bBuscar = Btn("🔍  Buscar", 20, 25, false); bBuscar.Width = 120;
            bBuscar.Click += (s, e) => Buscar?.Invoke(s, e);
            g1.Controls.Add(bBuscar);

            dgv = new DataGridView
            {
                Location = new Point(20, 65),
                Size = new Size(1020, 160),
                ReadOnly = true,
                AllowUserToAddRows = false,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                BackgroundColor = ColoresSePrise.FondoControl,
                BorderStyle = BorderStyle.None,
                RowHeadersVisible = false
            };
            dgv.SelectionChanged += (s, e) => _presenter.ActualizarDetalle();
            g1.Controls.Add(dgv);
            panelMain.Controls.Add(g1);

            // GroupBox detalle
            var g2 = new GroupBox
            {
                Text = "Detalle de la Agenda Seleccionada",
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                Location = new Point(40, 345),
                Size = new Size(1060, 180),
                BackColor = ColoresSePrise.FondoControl
            };

            g2.Controls.Add(Lbl("Tipo de estudio:", 20, 30));
            txtTipo = RO(160, 28, 240); g2.Controls.Add(txtTipo);
            g2.Controls.Add(Lbl("Estado:", 430, 30));
            txtEstado = RO(500, 28, 120); txtEstado.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            txtEstado.ForeColor = Color.FromArgb(192, 57, 43); g2.Controls.Add(txtEstado);

            g2.Controls.Add(Lbl("Fecha:", 20, 78));
            txtFecha = RO(160, 76, 120); g2.Controls.Add(txtFecha);
            g2.Controls.Add(Lbl("Horario:", 310, 78));
            txtHora = RO(390, 76, 130); g2.Controls.Add(txtHora);
            g2.Controls.Add(Lbl("Turnos:", 550, 78));
            txtTurnos = RO(620, 76, 100); g2.Controls.Add(txtTurnos);

            lblAdv = new Label
            {
                Text = "⚠   Al cancelar esta agenda TODOS los turnos asociados pasarán a CANCELADO. Esta acción no puede revertirse.",
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                ForeColor = Color.FromArgb(192, 57, 43),
                Location = new Point(20, 125),
                Size = new Size(1020, 22),
                Visible = false
            };
            g2.Controls.Add(lblAdv);
            panelMain.Controls.Add(g2);

            // Botones
            var bCancelar = Btn("✕  Cancelar agenda", 40, 550, false);
            bCancelar.BackColor = Color.FromArgb(192, 57, 43);
            bCancelar.ForeColor = ColoresSePrise.TextoBlanco;
            bCancelar.FlatAppearance.BorderColor = Color.FromArgb(150, 40, 30);
            bCancelar.Click += (s, e) => Cancelar?.Invoke(s, e);

            var bVolver = Btn("← Volver", 230, 550, false);
            bVolver.Click += (s, e) => { new FormEstudiosClinicosPanel(_usuario, _rol).Show(); this.Close(); };
            panelMain.Controls.AddRange(new Control[] { bCancelar, bVolver });
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