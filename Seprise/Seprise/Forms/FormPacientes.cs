using Seprise.dao;
using Seprise.entity;
using System.ComponentModel;

namespace Seprise
{
    public partial class FormPacientes : Form
    {
        private PacienteDao pacienteDao;

        public FormPacientes()
        {
            InitializeComponent();
            if (!IsDesignMode())
            {
                pacienteDao = new PacienteDao();
                Shown += FormPacientes_Shown;
            }
        }

        private void FormPacientes_Shown(object sender, EventArgs e)
        {
            CargarPacientes();
        }

        private void dgvPacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == btnConsultar.Index)
                btnConsultar_Click(sender, e);
            else if (e.ColumnIndex == btnModificar.Index)
                btnModificar_Click(sender, e);
            else if (e.ColumnIndex == btnDesactivar.Index)
                btnDesactivar_Click(sender, e);
        }

        private bool IsDesignMode()
        {
            return LicenseManager.UsageMode == LicenseUsageMode.Designtime || (Site != null && Site.DesignMode);
        }

        private void CargarPacientes()
        {
            try
            {
                dgvPacientes.Rows.Clear();
                List<Paciente> pacientes = pacienteDao.listarTodos();

                foreach (Paciente paciente in pacientes)
                {
                    dgvPacientes.Rows.Add(
                        paciente.Dni,
                        paciente.ObtenerNombreCompleto(),
                        paciente.Telefono ?? "N/A",
                        paciente.Activo ? "Activo" : "Inactivo"
                    );
                    dgvPacientes.Rows[dgvPacientes.Rows.Count - 1].Tag = paciente;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar pacientes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
                var formAbm = new FormPaciente("Crear", null);
            if (formAbm.ShowDialog() == DialogResult.OK)
            {
                CargarPacientes();
                MessageBox.Show("Paciente creado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (dgvPacientes.SelectedRows.Count > 0)
            {
                Paciente paciente = (Paciente)dgvPacientes.SelectedRows[0].Tag;
                var formAbm = new FormPaciente("Consultar", paciente);
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
                Paciente paciente = (Paciente)dgvPacientes.SelectedRows[0].Tag;
                var formAbm = new FormPaciente("Modificar", paciente);
                if (formAbm.ShowDialog() == DialogResult.OK)
                {
                    CargarPacientes();
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
                Paciente paciente = (Paciente)dgvPacientes.SelectedRows[0].Tag;

                var result = MessageBox.Show($"¿Está seguro que desea desactivar a {paciente.ObtenerNombreCompleto()}?", 
                    "Confirmar", 
                    MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        if (pacienteDao.desactivar(paciente.Id))
                        {
                            CargarPacientes();
                            MessageBox.Show("Paciente desactivado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se pudo desactivar el paciente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al desactivar paciente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un paciente de la lista", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
