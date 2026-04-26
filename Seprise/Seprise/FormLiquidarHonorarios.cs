using System;
using System.Windows.Forms;

namespace Seprise
{
    public partial class FormLiquidarHonorarios : Form
    {
        public FormLiquidarHonorarios()
        {
            InitializeComponent();
            ConfigurarDataGridView();
            CargarDatosIniciales();
        }

        private void CargarDatosIniciales()
        {
            cmbMedico.Items.Add("Todos");
            cmbMedico.Items.Add("Dra. Gómez Laura");
            cmbMedico.Items.Add("Dr. Rodríguez Carlos");
            cmbMedico.Items.Add("Dra. Martínez Ana");

            if (cmbMedico.Items.Count > 0)
                cmbMedico.SelectedIndex = 0;

            dtpDesde.Value = DateTime.Now.AddMonths(-1);
            dtpHasta.Value = DateTime.Now;
        }

        private void ConfigurarDataGridView()
        {
            dgvHonorarios.AllowUserToAddRows = false;
            dgvHonorarios.AllowUserToDeleteRows = false;
            dgvHonorarios.ReadOnly = true;
            dgvHonorarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHonorarios.MultiSelect = false;
            dgvHonorarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvHonorarios.Columns.Add("Medico", "Médico");
            dgvHonorarios.Columns.Add("Consultas", "Consultas atendidas");
            dgvHonorarios.Columns.Add("Honorario", "Honorario unitario");
            dgvHonorarios.Columns.Add("Total", "Total");
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            dgvHonorarios.Rows.Clear();

            if (cmbMedico.SelectedItem.ToString() == "Todos")
            {
                dgvHonorarios.Rows.Add("Dra. Gómez Laura", "18", "$15.000", "$270.000");
                dgvHonorarios.Rows.Add("Dr. Rodríguez Carlos", "12", "$18.000", "$216.000");
                dgvHonorarios.Rows.Add("Dra. Martínez Ana", "15", "$20.000", "$300.000");
            }
            else
            {
                dgvHonorarios.Rows.Add(cmbMedico.SelectedItem.ToString(), "18", "$15.000", "$270.000");
            }

            MessageBox.Show("Reporte generado exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Exportando reporte...", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
