using System.Windows.Forms;
using SePriseApp.Utils;

namespace SePriseApp.Forms
{
    // ══════════════════════════════════════════════════════════
    //  Panel de control del circuito Estudios Clínicos
    //  HU-15 al HU-23  —  9 funcionalidades
    // ══════════════════════════════════════════════════════════
    public partial class FormEstudiosClinicosPanel : Form
    {
        private string _usuario;
        private string _rol;

        public FormEstudiosClinicosPanel(string usuario, string rol)
        {
            InitializeComponent();
            _usuario = usuario;
            _rol = rol;
        }

        // ── EVENTOS DE NAVEGACIÓN — Panel lateral ────────────────────────────

        private void BtnPanel_Click(object sender, EventArgs e)
        {
            new FormPanelControl(_usuario, _rol).Show();
            this.Close();
        }

        private void BtnPacientes_Click(object sender, EventArgs e)
        {
            new FormGestionPacientes(_usuario, _rol).Show();
            this.Close();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            new FormLogin().Show();
            this.Close();
        }

        // ── EVENTOS DE NAVEGACIÓN — Cards ────────────────────────────────────

        private void C1_Click(object sender, EventArgs e)
        {
            new FormCrearAgendaEstudio(_usuario, _rol).Show();
            this.Hide();
        }

        private void C2_Click(object sender, EventArgs e)
        {
            new FormConfirmarAgendaEstudio(_usuario, _rol).Show();
            this.Hide();
        }

        private void C3_Click(object sender, EventArgs e)
        {
            new FormCancelarAgendaEstudio(_usuario, _rol).Show();
            this.Hide();
        }

        private void C4_Click(object sender, EventArgs e)
        {
            new FormReservarTurnoEstudio(_usuario, _rol).Show();
            this.Hide();
        }

        private void C5_Click(object sender, EventArgs e) =>
            MostrarEnDesarrollo("CU19 – Recepcionar Paciente");

        private void C6_Click(object sender, EventArgs e) =>
            MostrarEnDesarrollo("CU20 – Facturar Estudio");

        private void C7_Click(object sender, EventArgs e) =>
            MostrarEnDesarrollo("CU21 – Finalizar Estudio");

        private void C8_Click(object sender, EventArgs e) =>
            MostrarEnDesarrollo("CU22 – Generar Informe");

        private void C9_Click(object sender, EventArgs e) =>
            MostrarEnDesarrollo("CU23 – Entregar Estudio");

        // ── HELPERS DE LÓGICA ────────────────────────────────────────────────

        private void MostrarEnDesarrollo(string nombre) =>
            MessageBox.Show($"{nombre}\n\nEsta funcionalidad está en desarrollo.",
                "En desarrollo", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}