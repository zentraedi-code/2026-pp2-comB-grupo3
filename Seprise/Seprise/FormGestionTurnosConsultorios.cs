namespace Seprise
{
    public partial class FormGestionTurnosConsultorios : Form
    {
        public FormGestionTurnosConsultorios()
        {
            InitializeComponent();
            ConfigurarEventosHover();
        }

        private void ConfigurarEventosHover()
        {
            // Efecto hover para btnSalir
            btnSalir.MouseEnter += (s, e) => {
                btnSalir.BackColor = Color.FromArgb(128, 203, 196);
            };
            btnSalir.MouseLeave += (s, e) => {
                btnSalir.BackColor = Color.FromArgb(178, 235, 242);
            };

            // Efecto hover para btnReservarTurno
            btnReservarTurno.MouseEnter += (s, e) => {
                btnReservarTurno.BackColor = Color.FromArgb(128, 203, 196);
            };
            btnReservarTurno.MouseLeave += (s, e) => {
                btnReservarTurno.BackColor = Color.FromArgb(178, 235, 242);
            };

            // Efecto hover para btnCancelarReserva
            btnCancelarReserva.MouseEnter += (s, e) => {
                btnCancelarReserva.BackColor = Color.FromArgb(128, 203, 196);
            };
            btnCancelarReserva.MouseLeave += (s, e) => {
                btnCancelarReserva.BackColor = Color.FromArgb(178, 235, 242);
            };
        }

        private void ConfigurarBotonConIcono(Button btn, string texto, string icono, int x, int y, int tamaño, EventHandler clickHandler)
        {
            btn.Location = new Point(x, y);
            btn.Name = "btn" + texto.Replace(" ", "");
            btn.Size = new Size(tamaño, tamaño);
            btn.TabIndex = 0;
            btn.BackColor = Color.FromArgb(178, 235, 242);
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderColor = Color.FromArgb(0, 150, 136);
            btn.FlatAppearance.BorderSize = 2;
            btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn.Cursor = Cursors.Hand;

            // Configurar texto con icono arriba y texto abajo
            btn.Text = $"{icono}\n\n{texto}";
            btn.TextAlign = ContentAlignment.MiddleCenter;

            btn.Click += clickHandler;
        }

        private void btnReservarTurno_Click(object sender, EventArgs e)
        {
            var form = new FormReservarTurnoMedico();
            form.ShowDialog();
        }

        private void btnCancelarReserva_Click(object sender, EventArgs e)
        {
            var form = new FormCancelarReservaMedica();
            form.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
