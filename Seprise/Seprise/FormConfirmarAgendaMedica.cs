using System;
using System.Windows.Forms;

namespace Seprise
{
    public partial class FormConfirmarAgendaMedica : Form
    {
        public FormConfirmarAgendaMedica()
        {
            InitializeComponent();
            ConfigurarDataGridView();
            CargarDatosEjemplo();
            CargarEstados();
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

            DataGridViewButtonColumn btnConfirmar = new DataGridViewButtonColumn();
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseColumnTextForButtonValue = true;
            dgvAgendas.Columns.Add(btnConfirmar);
        }

        private void CargarDatosEjemplo()
        {
            dgvAgendas.Rows.Add("2026-05-10", "Dra. Gómez", "08:00 - 12:00", "15 min", "BORRADOR");
            dgvAgendas.Rows.Add("2026-05-11", "Dr. Rodríguez", "14:00 - 18:00", "20 min", "BORRADOR");
        }

        private void dgvAgendas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string columna = dgvAgendas.Columns[e.ColumnIndex].Name;

            if (columna == "btnConfirmar")
            {
                var result = MessageBox.Show("Al confirmar, el sistema creará turnos en estado DISPONIBLE y agregará 1 sobreturno por hora.\n\n¿Desea continuar?", 
                    "Confirmar agenda", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    dgvAgendas.Rows[e.RowIndex].Cells["Estado"].Value = "CONFIRMADA";
                    MessageBox.Show("Agenda confirmada exitosamente. Turnos creados.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
