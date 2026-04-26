namespace Seprise
{
    public partial class FormPacientes : Form
    {
        public FormPacientes()
        {
            InitializeComponent();
            CargarDatosEjemplo();
        }

        private void CargarDatosEjemplo()
        {
            dgvPacientes.Rows.Add("30111222", "Pérez Juan", "11-5555-5555", "Activo");
            dgvPacientes.Rows.Add("30222333", "García María", "11-6666-6666", "Activo");
            dgvPacientes.Rows.Add("30333444", "López Carlos", "11-7777-7777", "Activo");
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            var formAbm = new FormPacienteABM("Crear");
            if (formAbm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Paciente creado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (dgvPacientes.SelectedRows.Count > 0)
            {
                var formAbm = new FormPacienteABM("Consultar");
                formAbm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccione un paciente de la lista", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvPacientes.SelectedRows.Count > 0)
            {
                var formAbm = new FormPacienteABM("Modificar");
                if (formAbm.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Paciente modificado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un paciente de la lista", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDesactivar_Click(object sender, EventArgs e)
        {
            if (dgvPacientes.SelectedRows.Count > 0)
            {
                var result = MessageBox.Show("¿Está seguro que desea desactivar este paciente?", 
                    "Confirmar", 
                    MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("Paciente desactivado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un paciente de la lista", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
