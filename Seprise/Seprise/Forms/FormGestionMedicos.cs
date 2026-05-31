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
            ConfigurarEventosHover();
        }

        private void ConfigurarEventosHover()
        {
            btnSalir.MouseEnter += (s, e) => {
                btnSalir.BackColor = Color.FromArgb(128, 203, 196);
            };
            btnSalir.MouseLeave += (s, e) => {
                btnSalir.BackColor = Color.FromArgb(178, 235, 242);
            };

            btnABMMedicos.MouseEnter += (s, e) => {
                btnABMMedicos.BackColor = Color.FromArgb(128, 203, 196);
            };
            btnABMMedicos.MouseLeave += (s, e) => {
                btnABMMedicos.BackColor = Color.FromArgb(178, 235, 242);
            };

            btnLiquidarHonorarios.MouseEnter += (s, e) => {
                btnLiquidarHonorarios.BackColor = Color.FromArgb(128, 203, 196);
            };
            btnLiquidarHonorarios.MouseLeave += (s, e) => {
                btnLiquidarHonorarios.BackColor = Color.FromArgb(178, 235, 242);
            };
        }

        private void ConfigurarBotonConIcono(Button btn, string texto, string icono, int x, int y, int tamaño, EventHandler clickHandler)
        {
            btn.Location = new Point(x, y);
            btn.Name = "btn" + texto.Replace(" ", "").Replace("\n", "");
            btn.Size = new Size(tamaño, tamaño);
            btn.TabIndex = 0;
            btn.BackColor = Color.FromArgb(178, 235, 242);
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderColor = Color.FromArgb(0, 150, 136);
            btn.FlatAppearance.BorderSize = 2;
            btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn.Cursor = Cursors.Hand;

            btn.Text = $"{icono}\n\n{texto}";
            btn.TextAlign = ContentAlignment.MiddleCenter;

            btn.Click += clickHandler;
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
