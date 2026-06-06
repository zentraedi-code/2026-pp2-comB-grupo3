using Seprise.entity;
using System.ComponentModel;

namespace Seprise
{
    public partial class FormMedicoABM : Form
    {
        private string _modo;
        private Medico _medico;
        public Medico MedicoResultado { get; private set; }

        private Dictionary<string, int> _especialidades = new Dictionary<string, int>
        {
            { "Clínica médica", 1 },
            { "Pediatría", 2 },
            { "Cardiología", 3 },
            { "Traumatología", 4 },
            { "Ginecología", 5 },
            { "Fisio-kinesiología", 6 },
            { "Salud mental", 7 }
        };

        public FormMedicoABM(string modo, Medico medico)
        {
            InitializeComponent();
            _modo = modo;
            _medico = medico;
            if (!IsDesignMode())
                ConfigurarFormulario();
        }

        private bool IsDesignMode()
        {
            return LicenseManager.UsageMode == LicenseUsageMode.Designtime || (Site != null && Site.DesignMode);
        }

        private void ConfigurarFormulario()
        {
            this.Text = $"{_modo} médico";
            lblTitulo.Text = $"{_modo} médico";

            cmbEspecialidad.Items.Clear();
            foreach (var esp in _especialidades.Keys)
                cmbEspecialidad.Items.Add(esp);

            if (_medico != null)
            {
                txtMatricula.Text = _medico.Matricula;
                txtNombre.Text = _medico.Nombre;
                txtApellido.Text = _medico.Apellido;
                cmbEspecialidad.SelectedItem = _medico.EspecialidadNombre;
                txtHonorario.Text = _medico.ImporteConsulta.ToString();
            }
            else
            {
                if (cmbEspecialidad.Items.Count > 0)
                    cmbEspecialidad.SelectedIndex = 0;
            }

            if (_modo == "Consultar")
            {
                txtMatricula.ReadOnly = true;
                txtNombre.ReadOnly = true;
                txtApellido.ReadOnly = true;
                cmbEspecialidad.Enabled = false;
                txtHonorario.ReadOnly = true;
                btnGuardar.Visible = false;
            }
            else if (_modo == "Modificar")
            {
                txtMatricula.ReadOnly = true;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            string espNombre = cmbEspecialidad.SelectedItem.ToString();
            int espId = _especialidades[espNombre];

            MedicoResultado = new Medico(
                _medico?.Id ?? 0,
                txtMatricula.Text.Trim(),
                txtNombre.Text.Trim(),
                txtApellido.Text.Trim(),
                espId,
                espNombre,
                decimal.Parse(txtHonorario.Text.Trim()),
                true
            );

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtMatricula.Text))
            {
                MessageBox.Show("La matrícula es obligatoria.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("El apellido es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cmbEspecialidad.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una especialidad.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtHonorario.Text) || !decimal.TryParse(txtHonorario.Text, out decimal importe) || importe <= 0)
            {
                MessageBox.Show("El importe debe ser un número mayor a cero.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}