using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Seprise
{
    public partial class FormFacturarConsulta : Form
    {
        public FormFacturarConsulta()
        {
            InitializeComponent();
            if (!IsDesignMode())
            {
                CargarDatosIniciales();
            }
        }

        private bool IsDesignMode()
        {
            return LicenseManager.UsageMode == LicenseUsageMode.Designtime || (Site != null && Site.DesignMode);
        }

        private void CargarDatosIniciales()
        {
            cmbPaciente.Items.Add("Pérez Juan - Turno recepcionado 08:00");
            cmbPaciente.Items.Add("García Ana - Turno recepcionado 08:15");

            cmbMedioPago.Items.AddRange(new string[] { "Efectivo", "Débito", "Crédito", "Obra social" });

            if (cmbPaciente.Items.Count > 0)
                cmbPaciente.SelectedIndex = 0;
            if (cmbMedioPago.Items.Count > 0)
                cmbMedioPago.SelectedIndex = 0;

            txtMedico.Text = "Dra. Gómez Laura";
            txtConcepto.Text = "Consulta médica";
            txtImporte.Text = "15000";
            txtEstadoFactura.Text = "PENDIENTE";
        }

        private void btnEmitir_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            txtEstadoFactura.Text = "EMITIDA";
            MessageBox.Show("Factura emitida exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool ValidarCampos()
        {
            if (cmbPaciente.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un paciente.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtImporte.Text) || !decimal.TryParse(txtImporte.Text, out decimal importe) || importe <= 0)
            {
                MessageBox.Show("El importe debe ser un número mayor a cero.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cmbMedioPago.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un medio de pago.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Imprimiendo comprobante...", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
