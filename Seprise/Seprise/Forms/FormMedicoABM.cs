using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Seprise
{
    public partial class FormMedicoABM : Form
    {
        private string _modo;

        public FormMedicoABM()
        {
            InitializeComponent();
        }

        public FormMedicoABM(string modo)
        {
            InitializeComponent();
            _modo = modo;
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

            cmbEspecialidad.Items.AddRange(new string[] { 
                "Clínica médica", 
                "Fisio-kinesiología", 
                "Salud mental", 
                "Cardiología", 
                "Pediatría" 
            });

            if (_modo == "Consultar")
            {
                txtMatricula.ReadOnly = true;
                txtNombre.ReadOnly = true;
                txtApellido.ReadOnly = true;
                cmbEspecialidad.Enabled = false;
                txtHonorario.ReadOnly = true;
                btnGuardar.Visible = false;

                txtMatricula.Text = "MN12345";
                txtNombre.Text = "Laura";
                txtApellido.Text = "Gómez";
                cmbEspecialidad.SelectedIndex = 0;
                txtHonorario.Text = "15000";
            }
            else if (_modo == "Modificar")
            {
                txtMatricula.ReadOnly = true;
                txtMatricula.Text = "MN12345";
                txtNombre.Text = "Laura";
                txtApellido.Text = "Gómez";
                cmbEspecialidad.SelectedIndex = 0;
                txtHonorario.Text = "15000";
            }
            else
            {
                if (cmbEspecialidad.Items.Count > 0)
                    cmbEspecialidad.SelectedIndex = 0;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

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

            if (string.IsNullOrWhiteSpace(txtHonorario.Text) || !decimal.TryParse(txtHonorario.Text, out decimal honorario) || honorario <= 0)
            {
                MessageBox.Show("El honorario debe ser un número mayor a cero.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
