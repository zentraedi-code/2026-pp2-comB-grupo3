using System;
using System.Drawing;
using System.Windows.Forms;

namespace Seprise
{
    public partial class FormGestionMedicos : Form
    {
        public FormGestionMedicos()
        {
            InitializeComponent();
        }

        private void btnABMMedicos_Click(object sender, EventArgs e)
        {
            using (var form = new FormMedicos())
            {
                form.ShowDialog();
            }
        }

        private void btnLiquidarHonorarios_Click(object sender, EventArgs e)
        {
            using (var form = new FormLiquidarHonorarios())
            {
                form.ShowDialog();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
