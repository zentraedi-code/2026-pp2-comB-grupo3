using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Seprise
{
    public partial class FormCancelarAgendaMedica : Form
    {
        public FormCancelarAgendaMedica()
        {
            InitializeComponent();
            if (!IsDesignMode())
            {
                ConfigurarDataGridView();
                CargarDatosEjemplo();
                CargarEstados();
            }
        }

        private bool IsDesignMode()
        {
            return LicenseManager.UsageMode == LicenseUsageMode.Designtime || (Site != null && Site.DesignMode);
        }

        private void CargarEstados()
        {
            cmbEstado.Items.AddRange(new string[] { "BORRADOR", "CONFIRMADA", "CANCELADA" });
            cmbEstado.SelectedIndex = 0;
        }

        private void ConfigurarDataGridView()
        {
            dgvAgendas.AllowUserToAddRows = false;
            dgvAgendas.AllowUserToDeleteRows = false;
            dgvAgendas.ReadOnly = true;
            dgvAgendas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAgendas.MultiSelect = false;
            dgvAgendas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvAgendas.Columns.Add("Fecha", "Fecha");
            dgvAgendas.Columns.Add("Profesional", "Profesional");
            dgvAgendas.Columns.Add("Horario", "Horario");
            dgvAgendas.Columns.Add("Duracion", "Duración");
            dgvAgendas.Columns.Add("Estado", "Estado");

            DataGridViewButtonColumn btnCancelar = new DataGridViewButtonColumn();
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseColumnTextForButtonValue = true;
            dgvAgendas.Columns.Add(btnCancelar);
        }

        private void CargarDatosEjemplo()
        {
            dgvAgendas.Rows.Add("2026-05-10", "Dra. Gómez", "08:00 - 12:00", "15 min", "BORRADOR");
            dgvAgendas.Rows.Add("2026-05-11", "Dr. Rodríguez", "14:00 - 18:00", "20 min", "CONFIRMADA");
        }

        private void dgvAgendas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string columna = dgvAgendas.Columns[e.ColumnIndex].Name;

            if (columna == "btnCancelar")
            {
                var result = MessageBox.Show("Al cancelar, el sistema eliminará todos los turnos asociados a esta agenda.\n\n¿Desea continuar?", 
                    "Cancelar agenda", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    dgvAgendas.Rows[e.RowIndex].Cells["Estado"].Value = "CANCELADA";
                    MessageBox.Show("Agenda cancelada exitosamente. Turnos eliminados.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
