using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using SePriseApp.Models;
using SePriseApp.Repositories;
using SePriseApp.Utils;

namespace SePriseApp.Forms
{
    // ══════════════════════════════════════════════════════════
    //  INTERFACE  — contrato View / Presenter
    // ══════════════════════════════════════════════════════════
    public interface ICrearAgendaEstudioView
    {
        string TipoEstudio { get; }
        DateTime Fecha { get; }
        string HoraDesdeTexto { get; }
        string HoraHastaTexto { get; }
        int Duracion { get; }

        string DiaSemana { set; }
        string InfoTurnos { set; }

        event EventHandler Guardar;
        event EventHandler Limpiar;

        void MostrarError(string msg);
        void MostrarExito(string msg);
        void LimpiarCampos();
    }

    // ══════════════════════════════════════════════════════════
    //  PRESENTER  — toda la lógica, sin tocar UI
    // ══════════════════════════════════════════════════════════
    public class CrearAgendaEstudioPresenter
    {
        private readonly ICrearAgendaEstudioView _view;
        private readonly IAgendaEstudioRepository _repo;

        public CrearAgendaEstudioPresenter(ICrearAgendaEstudioView view,
                                           IAgendaEstudioRepository repo)
        {
            _view = view;
            _repo = repo;
            _view.Guardar += OnGuardar;
            _view.Limpiar += OnLimpiar;
        }

        public void RecalcularInfo()
        {
            _view.DiaSemana = _view.Fecha
                .ToString("dddd", new CultureInfo("es-AR")).ToUpperInvariant();

            if (TimeSpan.TryParse(_view.HoraDesdeTexto, out var desde) &&
                TimeSpan.TryParse(_view.HoraHastaTexto, out var hasta) &&
                hasta > desde && _view.Duracion > 0)
            {
                int cant = (int)((hasta - desde).TotalMinutes / _view.Duracion);
                _view.InfoTurnos =
                    $"→ Se generarán {cant} turnos de {_view.Duracion} min al confirmar";
            }
            else
            {
                _view.InfoTurnos = string.Empty;
            }
        }

        private void OnGuardar(object? s, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(_view.TipoEstudio))
            { _view.MostrarError("Seleccione un tipo de estudio."); return; }

            if (!TimeSpan.TryParse(_view.HoraDesdeTexto, out var desde))
            { _view.MostrarError("Formato de Hora desde inválido. Use HH:mm"); return; }

            if (!TimeSpan.TryParse(_view.HoraHastaTexto, out var hasta))
            { _view.MostrarError("Formato de Hora hasta inválido. Use HH:mm"); return; }

            if (hasta <= desde)
            { _view.MostrarError("La Hora hasta debe ser posterior a la Hora desde."); return; }

            if (_view.Duracion <= 0)
            { _view.MostrarError("La duración debe ser mayor a 0 minutos."); return; }

            var agenda = new AgendaEstudio
            {
                TipoEstudio = _view.TipoEstudio,
                Fecha = _view.Fecha,
                HoraDesde = desde,
                HoraHasta = hasta,
                DuracionMinutos = _view.Duracion,
                Estado = "BORRADOR"
            };

            _repo.Agregar(agenda);

            _view.MostrarExito(
                $"Agenda creada en estado BORRADOR.\n" +
                $"Se generarán {agenda.CantidadTurnos} turnos al confirmarla.");
            _view.LimpiarCampos();
        }

        private void OnLimpiar(object? s, EventArgs e) => _view.LimpiarCampos();
    }

    // ══════════════════════════════════════════════════════════
    //  FORM  — solo UI, sin lógica de negocio
    // ══════════════════════════════════════════════════════════
    public partial class FormCrearAgendaEstudio : Form, ICrearAgendaEstudioView
    {
        private readonly CrearAgendaEstudioPresenter _presenter;
        private readonly string _usuario;
        private readonly string _rol;

        // ── Implementación de la interface ──
        public string TipoEstudio => cmbTipo.Text;
        public DateTime Fecha => dtpFecha.Value.Date;
        public string HoraDesdeTexto => txtDesde.Text;
        public string HoraHastaTexto => txtHasta.Text;
        public int Duracion => (int)nudDuracion.Value;

        public string DiaSemana { set => txtDia.Text = value; }
        public string InfoTurnos { set => lblInfo.Text = value; }

        public event EventHandler? Guardar;
        public event EventHandler? Limpiar;

        public void MostrarError(string msg) =>
            MessageBox.Show(msg, "Error de validación",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);

        public void MostrarExito(string msg) =>
            MessageBox.Show(msg, "Operación exitosa",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

        public void LimpiarCampos()
        {
            cmbTipo.SelectedIndex = -1;
            dtpFecha.Value = DateTime.Today;
            txtDesde.Text = "08:00";
            txtHasta.Text = "12:00";
            nudDuracion.Value = 30;
            txtDia.Text = string.Empty;
            lblInfo.Text = string.Empty;
        }

        public FormCrearAgendaEstudio(string usuario, string rol)
        {
            _usuario = usuario;
            _rol = rol;

            InitializeComponent();   // ← Designer.cs

            _presenter = new CrearAgendaEstudioPresenter(
                this, new AgendaEstudioRepository());

            _presenter.RecalcularInfo();
        }

        // ── Helpers de controles (usados desde Designer.cs) ──
        internal Label Lbl(string t, int x, int y) => new Label
        {
            Text = t,
            Location = new Point(x, y + 3),
            AutoSize = true,
            Font = new Font("Segoe UI", 10),
            ForeColor = ColoresSePrise.TextoPrimario
        };

        internal Button Btn(string t, int x, int y, bool primario)
        {
            var b = new Button
            {
                Text = t,
                Location = new Point(x, y),
                Size = new Size(160, 38),
                Font = new Font("Segoe UI", 10),
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand,
                BackColor = primario ? ColoresSePrise.VerdePrimario : ColoresSePrise.FondoControl,
                ForeColor = primario ? ColoresSePrise.TextoBlanco : ColoresSePrise.TextoPrimario
            };
            b.FlatAppearance.BorderColor =
                primario ? ColoresSePrise.VerdeOscuro : ColoresSePrise.Borde;
            return b;
        }

        internal Button BtnNav(string t, int y, bool activo)
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