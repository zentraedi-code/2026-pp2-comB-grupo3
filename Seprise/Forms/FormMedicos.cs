using Seprise.dao;
using Seprise.entity;
using System.ComponentModel;

namespace Seprise
{
    public partial class FormMedicos : Form
    {
        private MedicoDao medicoDao;

        public FormMedicos()
        {
            InitializeComponent();
            if (!IsDesignMode())
            {
                medicoDao = new MedicoDao();
                Shown += FormMedicos_Shown;
            }
        }

        private void FormMedicos_Shown(object sender, EventArgs e)
        {
            CargarMedicos();
        }

        private bool IsDesignMode()
        {
            return LicenseManager.UsageMode == LicenseUsageMode.Designtime || (Site != null && Site.DesignMode);
        }

        private void CargarMedicos()
        {
            try
            {
                dgvMedicos.Rows.Clear();
                List<Medico> medicos = medicoDao.listarTodos();
                foreach (Medico medico in medicos)
                {
                    dgvMedicos.Rows.Add(
                        medico.Matricula,
                        medico.ObtenerNombreCompleto(),
                        medico.EspecialidadNombre,
                        medico.ImporteConsulta.ToString("C"),
                        medico.Activo ? "Activo" : "Inactivo"
                    );
                    dgvMedicos.Rows[dgvMedicos.Rows.Count - 1].Tag = medico;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar médicos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            var form = new FormMedicoABM("Crear", null);
            if (form.ShowDialog() == DialogResult.OK)
            {
                medicoDao.agregar(form.MedicoResultado);
                CargarMedicos();
                MessageBox.Show("Médico creado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvMedicos.SelectedRows.Count > 0)
            {
                Medico medico = (Medico)dgvMedicos.SelectedRows[0].Tag;
                var form = new FormMedicoABM("Modificar", medico);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    medicoDao.modificar(form.MedicoResultado);
                    CargarMedicos();
                    MessageBox.Show("Médico modificado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un médico de la lista", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDesactivar_Click(object sender, EventArgs e)
        {
            if (dgvMedicos.SelectedRows.Count > 0)
            {
                Medico medico = (Medico)dgvMedicos.SelectedRows[0].Tag;
                var result = MessageBox.Show($"¿Desactivar a {medico.ObtenerNombreCompleto()}?",
                    "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    medicoDao.desactivar(medico.Id);
                    CargarMedicos();
                    MessageBox.Show("Médico desactivado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un médico de la lista", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}