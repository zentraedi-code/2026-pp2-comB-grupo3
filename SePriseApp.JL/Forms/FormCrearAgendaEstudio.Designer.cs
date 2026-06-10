using System;
using System.Drawing;
using System.Windows.Forms;
using SePriseApp.Utils;

namespace SePriseApp.Forms
{
    partial class FormCrearAgendaEstudio
    {
        // ── Declaración de controles ──────────────────────────
        private System.ComponentModel.IContainer components = null;

        private ComboBox cmbTipo;
        private DateTimePicker dtpFecha;
        private TextBox txtDesde;
        private TextBox txtHasta;
        private NumericUpDown nudDuracion;
        private TextBox txtDia;
        private Label lblInfo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        // ══════════════════════════════════════════════════════
        //  InitializeComponent  — generado / mantenido a mano
        // ══════════════════════════════════════════════════════
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            // ── Form ──────────────────────────────────────────
            this.Text = "SePrise — CU15 Crear Agenda de Estudios";
            this.Size = new Size(1366, 768);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = ColoresSePrise.FondoVentana;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // ── Panel navegación lateral ───────────────────────
            Panel panelNav = CrearPanelNav();

            // ── Panel principal ───────────────────────────────
            Panel panelMain = new Panel
            {
                Size = new Size(1146, 768),
                Location = new Point(220, 0),
                BackColor = ColoresSePrise.FondoVentana
            };

            panelMain.Controls.Add(new Label
            {
                Text = "Crear Agenda de Estudios — CU15",
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                ForeColor = ColoresSePrise.TextoPrimario,
                Location = new Point(40, 30),
                AutoSize = true
            });

            panelMain.Controls.Add(new Label
            {
                Text = "Complete los datos. La agenda se guardará en estado BORRADOR.",
                Font = new Font("Segoe UI", 9),
                ForeColor = ColoresSePrise.TextoSecundario,
                Location = new Point(40, 68),
                AutoSize = true
            });

            // ── GroupBox formulario ───────────────────────────
            GroupBox grp = new GroupBox
            {
                Text = "Datos de la Agenda",
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                Location = new Point(40, 110),
                Size = new Size(680, 320),
                BackColor = ColoresSePrise.FondoControl
            };

            int lx = 20, cx = 200, gap = 52;

            // Tipo de estudio
            grp.Controls.Add(Lbl("Tipo de estudio:", lx, 30));
            cmbTipo = new ComboBox
            {
                Location = new Point(cx, 28),
                Width = 300,
                DropDownStyle = ComboBoxStyle.DropDownList,
                Font = new Font("Segoe UI", 10)
            };
            cmbTipo.Items.AddRange(new object[]{
                "Ecografía Abdominal", "Radiografía de Tórax",
                "Laboratorio General", "Tomografía Computada",
                "Resonancia Magnética", "Mamografía" });
            grp.Controls.Add(cmbTipo);

            // Fecha
            grp.Controls.Add(Lbl("Fecha:", lx, 30 + gap));
            dtpFecha = new DateTimePicker
            {
                Location = new Point(cx, 28 + gap),
                Width = 160,
                Format = DateTimePickerFormat.Short,
                Value = DateTime.Today,
                Font = new Font("Segoe UI", 10)
            };
            dtpFecha.ValueChanged += (s, e) => _presenter.RecalcularInfo();
            grp.Controls.Add(dtpFecha);

            // Día (readonly)
            grp.Controls.Add(Lbl("Día:", cx + 175, 30 + gap));
            txtDia = new TextBox
            {
                Location = new Point(cx + 215, 28 + gap),
                Width = 120,
                ReadOnly = true,
                BackColor = ColoresSePrise.FondoVentana,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                ForeColor = ColoresSePrise.VerdePrimario
            };
            grp.Controls.Add(txtDia);

            // Hora desde
            grp.Controls.Add(Lbl("Hora desde:", lx, 30 + gap * 2));
            txtDesde = new TextBox
            {
                Location = new Point(cx, 28 + gap * 2),
                Width = 80,
                Text = "08:00",
                Font = new Font("Segoe UI", 10)
            };
            txtDesde.Leave += (s, e) => _presenter.RecalcularInfo();
            grp.Controls.Add(txtDesde);

            // Hora hasta
            grp.Controls.Add(Lbl("Hora hasta:", cx + 100, 30 + gap * 2));
            txtHasta = new TextBox
            {
                Location = new Point(cx + 210, 28 + gap * 2),
                Width = 80,
                Text = "12:00",
                Font = new Font("Segoe UI", 10)
            };
            txtHasta.Leave += (s, e) => _presenter.RecalcularInfo();
            grp.Controls.Add(txtHasta);

            // Duración
            grp.Controls.Add(Lbl("Duración (min):", lx, 30 + gap * 3));
            nudDuracion = new NumericUpDown
            {
                Location = new Point(cx, 28 + gap * 3),
                Width = 80,
                Minimum = 5,
                Maximum = 120,
                Value = 30,
                Increment = 5,
                Font = new Font("Segoe UI", 10)
            };
            nudDuracion.ValueChanged += (s, e) => _presenter.RecalcularInfo();
            grp.Controls.Add(nudDuracion);

            lblInfo = new Label
            {
                Location = new Point(cx + 100, 32 + gap * 3),
                AutoSize = true,
                Font = new Font("Segoe UI", 9, FontStyle.Italic),
                ForeColor = ColoresSePrise.VerdePrimario
            };
            grp.Controls.Add(lblInfo);

            // Estado (siempre BORRADOR)
            grp.Controls.Add(Lbl("Estado:", lx, 30 + gap * 4));
            grp.Controls.Add(new TextBox
            {
                Location = new Point(cx, 28 + gap * 4),
                Width = 120,
                ReadOnly = true,
                Text = "BORRADOR",
                BackColor = ColoresSePrise.FondoVentana,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                ForeColor = Color.FromArgb(138, 109, 59)
            });

            panelMain.Controls.Add(grp);

            // ── Botones ───────────────────────────────────────
            var btnGuardar = Btn("💾  Guardar agenda", 40, 460, true);
            var btnLimpiar = Btn("🗑  Limpiar", 210, 460, false);
            var btnVolver = Btn("← Volver", 320, 460, false);

            btnGuardar.Click += (s, e) => Guardar?.Invoke(s, e);
            btnLimpiar.Click += (s, e) => Limpiar?.Invoke(s, e);
            btnVolver.Click += (s, e) =>
            {
                new FormEstudiosClinicosPanel(_usuario, _rol).Show();
                this.Close();
            };

            panelMain.Controls.AddRange(
                new Control[] { btnGuardar, btnLimpiar, btnVolver });

            this.Controls.AddRange(new Control[] { panelNav, panelMain });
        }

        // ── Panel de navegación lateral ───────────────────────
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
    }
}