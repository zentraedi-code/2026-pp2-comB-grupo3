namespace Seprise
{
    public partial class FormPacienteABM : Form
    {
        private string _modo;

        public FormPacienteABM(string modo)
        {
            InitializeComponent();
            _modo = modo;
            ConfigurarFormulario();
        }

        private void ConfigurarFormulario()
        {
            lblTitulo.Text = $"{_modo} Paciente";

            if (_modo == "Consultar")
            {
                txtDNI.ReadOnly = true;
                txtNombre.ReadOnly = true;
                txtApellido.ReadOnly = true;
                txtTelefono.ReadOnly = true;
                txtEmail.ReadOnly = true;
                txtDireccion.ReadOnly = true;
                dtpFechaNacimiento.Enabled = false;
                cboObraSocial.Enabled = false;
                btnGuardar.Visible = false;
                btnCancelar.Text = "Cerrar";

                CargarDatosEjemplo();
            }
            else if (_modo == "Modificar")
            {
                txtDNI.ReadOnly = true;
                CargarDatosEjemplo();
            }
        }

        private void CargarDatosEjemplo()
        {
            txtDNI.Text = "30111222";
            txtNombre.Text = "Juan";
            txtApellido.Text = "Pérez";
            txtTelefono.Text = "11-5555-5555";
            txtEmail.Text = "juan.perez@email.com";
            txtDireccion.Text = "Av. Corrientes 1234";
            dtpFechaNacimiento.Value = new DateTime(1985, 5, 15);
            cboObraSocial.SelectedIndex = 0;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtDNI.Text))
            {
                MessageBox.Show("El DNI es obligatorio", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDNI.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre es obligatorio", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("El apellido es obligatorio", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtApellido.Focus();
                return false;
            }

            return true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
