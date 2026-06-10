using Seprise.dao;
using Seprise.entity;
using System.ComponentModel;
using System.Text.RegularExpressions;

namespace Seprise
{
    public partial class FormPaciente : Form
    {
        private string _modo;
        private Paciente _paciente;
        private PacienteDao _pacienteDao;

        public FormPaciente()
        {
            InitializeComponent();
        }

        public FormPaciente(string modo, Paciente paciente)
        {
            InitializeComponent();
            _modo = modo;
            _paciente = paciente;
            if (!IsDesignMode())
            {
                _pacienteDao = new PacienteDao();
                ConfigurarFormulario();
            }
        }

        private bool IsDesignMode()
        {
            return LicenseManager.UsageMode == LicenseUsageMode.Designtime || (Site != null && Site.DesignMode);
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

                if (_paciente != null)
                    CargarDatosPaciente();
            }
            else if (_modo == "Modificar")
            {
                txtDNI.ReadOnly = true;
                if (_paciente != null)
                    CargarDatosPaciente();
            }
        }

        private void CargarDatosPaciente()
        {
            if (_paciente != null)
            {
                txtDNI.Text = _paciente.Dni;
                txtNombre.Text = _paciente.Nombre;
                txtApellido.Text = _paciente.Apellido;
                txtTelefono.Text = _paciente.Telefono ?? "";
                txtEmail.Text = _paciente.Email ?? "";
                txtDireccion.Text = _paciente.Direccion ?? "";
                cboObraSocial.Text = _paciente.ObraSocial ?? "";
                dtpFechaNacimiento.Format = DateTimePickerFormat.Custom;
                dtpFechaNacimiento.CustomFormat = "dd/MM/yyyy";
                dtpFechaNacimiento.Value = _paciente.FechaNacimiento;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                try
                {
                    string obraSocial = cboObraSocial.SelectedIndex >= 0 ? cboObraSocial.Text : null;

                    if (_modo == "Crear")
                    {
                        Paciente nuevoPaciente = new Paciente(
                            0,
                            txtDNI.Text.Trim(),
                            txtNombre.Text.Trim(),
                            txtApellido.Text.Trim(),
                            dtpFechaNacimiento.Value,
                            string.IsNullOrWhiteSpace(txtTelefono.Text) ? null : txtTelefono.Text.Trim(),
                            string.IsNullOrWhiteSpace(txtEmail.Text) ? null : txtEmail.Text.Trim(),
                            string.IsNullOrWhiteSpace(txtDireccion.Text) ? null : txtDireccion.Text.Trim(),
                            obraSocial,
                            true
                        );

                        if (_pacienteDao.agregar(nuevoPaciente))
                        {
                            DialogResult = DialogResult.OK;
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo crear el paciente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (_modo == "Modificar")
                    {
                        _paciente.Dni = txtDNI.Text.Trim();
                        _paciente.Nombre = txtNombre.Text.Trim();
                        _paciente.Apellido = txtApellido.Text.Trim();
                        _paciente.FechaNacimiento = dtpFechaNacimiento.Value;
                        _paciente.Telefono = string.IsNullOrWhiteSpace(txtTelefono.Text) ? null : txtTelefono.Text.Trim();
                        _paciente.Email = string.IsNullOrWhiteSpace(txtEmail.Text) ? null : txtEmail.Text.Trim();
                        _paciente.Direccion = string.IsNullOrWhiteSpace(txtDireccion.Text) ? null : txtDireccion.Text.Trim();
                        _paciente.ObraSocial = obraSocial;

                        if (_pacienteDao.modificar(_paciente))
                        {
                            DialogResult = DialogResult.OK;
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo modificar el paciente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar paciente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool ValidarCampos()
        {
            string dni = txtDNI.Text.Replace(" ", "");
            string nombre = txtNombre.Text.Trim();
            string apellido = txtApellido.Text.Trim();
            string telefono = txtTelefono.Text.Replace(" ", "");
            string email = txtEmail.Text.Trim();
            string direccion = txtDireccion.Text.Trim();
            string obraSocial = cboObraSocial.Text.Trim();

            if (string.IsNullOrWhiteSpace(dni) || string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido) ||
                string.IsNullOrWhiteSpace(telefono) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(direccion) ||
                string.IsNullOrWhiteSpace(obraSocial))
            {
                MessageBox.Show("Todos los datos son obligatorios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (dni.Length < 6 || !dni.All(char.IsDigit))
            {
                MessageBox.Show("El DNI debe tener al menos 6 números.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDNI.Focus();
                return false;
            }

            if (!EsSoloLetras(nombre))
            {
                MessageBox.Show("El nombre debe contener solo letras.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return false;
            }

            if (!EsSoloLetras(apellido))
            {
                MessageBox.Show("El apellido debe contener solo letras.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtApellido.Focus();
                return false;
            }

            if (!telefono.All(char.IsDigit))
            {
                MessageBox.Show("El teléfono debe contener solo números.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTelefono.Focus();
                return false;
            }

            if (!EsEmailValido(email))
            {
                MessageBox.Show("El email no tiene un formato válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }

            if (dtpFechaNacimiento.Value.Date >= DateTime.Today)
            {
                MessageBox.Show("La fecha de nacimiento no puede ser hoy ni una fecha futura.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpFechaNacimiento.Focus();
                return false;
            }

            return true;
        }

        private bool EsSoloLetras(string valor)
        {
            return valor.All(c => char.IsLetter(c) || char.IsWhiteSpace(c) || "ÁÉÍÓÚáéíóúÑñ".Contains(c));
        }

        private bool EsEmailValido(string email)
        {
            return Regex.IsMatch(email, @"^[^\s@]+@[^\s@]+\.[^\s@]+$");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != 'Á' && e.KeyChar != 'É' && e.KeyChar != 'Í' && e.KeyChar != 'Ó' && e.KeyChar != 'Ú' && e.KeyChar != 'á' && e.KeyChar != 'é' && e.KeyChar != 'í' && e.KeyChar != 'ó' && e.KeyChar != 'ú' && e.KeyChar != 'Ñ' && e.KeyChar != 'ñ')
                e.Handled = true;
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != 'Á' && e.KeyChar != 'É' && e.KeyChar != 'Í' && e.KeyChar != 'Ó' && e.KeyChar != 'Ú' && e.KeyChar != 'á' && e.KeyChar != 'é' && e.KeyChar != 'í' && e.KeyChar != 'ó' && e.KeyChar != 'ú' && e.KeyChar != 'Ñ' && e.KeyChar != 'ñ')
                e.Handled = true;
        }

        private void FormPaciente_Load(object sender, EventArgs e)
        {

        }
    }
}
