using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Seprise
{
    public partial class FormMedicos : Form
    {
        public FormMedicos()
        {
            InitializeComponent();
            if (!IsDesignMode())
            {
                ConfigurarDataGridView();
                CargarDatosEjemplo();
            }
        }

        private bool IsDesignMode()
        {
            return LicenseManager.UsageMode == LicenseUsageMode.Designtime || (Site != null && Site.DesignMode);
        }

        private void ConfigurarDataGridView()
        {
            dgvMedicos.AllowUserToAddRows = false;
            dgvMedicos.AllowUserToDeleteRows = false;
            dgvMedicos.ReadOnly = true;
            dgvMedicos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMedicos.MultiSelect = false;
            dgvMedicos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvMedicos.Columns.Add("Matricula", "Matrícula");
            dgvMedicos.Columns.Add("Medico", "Médico");
            dgvMedicos.Columns.Add("Especialidad", "Especialidad");
            dgvMedicos.Columns.Add("Honorario", "Honorario");
            dgvMedicos.Columns.Add("Estado", "Estado");

            DataGridViewButtonColumn btnConsultar = new DataGridViewButtonColumn();
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Text = "Consultar";
            btnConsultar.UseColumnTextForButtonValue = true;
            dgvMedicos.Columns.Add(btnConsultar);

            DataGridViewButtonColumn btnModificar = new DataGridViewButtonColumn();
            btnModificar.Name = "btnModificar";
            btnModificar.Text = "Modificar";
            btnModificar.UseColumnTextForButtonValue = true;
            dgvMedicos.Columns.Add(btnModificar);

            DataGridViewButtonColumn btnDesactivar = new DataGridViewButtonColumn();
            btnDesactivar.Name = "btnDesactivar";
            btnDesactivar.Text = "Desactivar";
            btnDesactivar.UseColumnTextForButtonValue = true;
            dgvMedicos.Columns.Add(btnDesactivar);
        }

        private void CargarDatosEjemplo()
        {
            dgvMedicos.Rows.Add("MN12345", "Gómez Laura", "Clínica médica", "$15.000", "Activo");
            dgvMedicos.Rows.Add("MN12346", "Rodríguez Carlos", "Fisio-kinesiología", "$18.000", "Activo");
            dgvMedicos.Rows.Add("MN12347", "Martínez Ana", "Salud mental", "$20.000", "Activo");
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            FormMedicoABM form = new FormMedicoABM("Crear");
            if (form.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Médico creado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvMedicos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string columna = dgvMedicos.Columns[e.ColumnIndex].Name;

            if (columna == "btnConsultar")
            {
                FormMedicoABM form = new FormMedicoABM("Consultar");
                form.ShowDialog();
            }
            else if (columna == "btnModificar")
            {
                FormMedicoABM form = new FormMedicoABM("Modificar");
                if (form.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Médico modificado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (columna == "btnDesactivar")
            {
                var result = MessageBox.Show("¿Está seguro de desactivar este médico?", 
                    "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    dgvMedicos.Rows[e.RowIndex].Cells["Estado"].Value = "Inactivo";
                    MessageBox.Show("Médico desactivado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
