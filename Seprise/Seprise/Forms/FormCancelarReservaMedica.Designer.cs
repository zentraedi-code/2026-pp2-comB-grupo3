namespace Seprise
{
    partial class FormCancelarReservaMedica
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitulo = new Label();
            grpPaciente = new GroupBox();
            lblDniPaciente = new Label();
            txtDniPaciente = new TextBox();
            btnBuscarPaciente = new Button();
            lblPaciente = new Label();
            txtPaciente = new TextBox();
            grpFiltros = new GroupBox();
            chkFecha = new CheckBox();
            dtpFecha = new DateTimePicker();
            btnBuscar = new Button();
            dgvTurnos = new DataGridView();
            lblNota = new Label();
            btnSalir = new Button();
            grpPaciente.SuspendLayout();
            grpFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTurnos).BeginInit();
            SuspendLayout();

            lblTitulo.BackColor = Color.FromArgb(30, 107, 160);
            lblTitulo.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(900, 48);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "   Cancelar reserva de turno médico";
            lblTitulo.TextAlign = ContentAlignment.MiddleLeft;

            grpPaciente.Location = new Point(15, 62);
            grpPaciente.Name = "grpPaciente";
            grpPaciente.Size = new Size(870, 70);
            grpPaciente.TabIndex = 1;
            grpPaciente.TabStop = false;
            grpPaciente.Text = "Paciente";

            lblDniPaciente.AutoSize = true;
            lblDniPaciente.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDniPaciente.Location = new Point(12, 26);
            lblDniPaciente.Name = "lblDniPaciente";
            lblDniPaciente.TabIndex = 0;
            lblDniPaciente.Text = "DNI:";

            txtDniPaciente.Location = new Point(45, 24);
            txtDniPaciente.Name = "txtDniPaciente";
            txtDniPaciente.PlaceholderText = "Ej: 30111222";
            txtDniPaciente.Size = new Size(140, 23);
            txtDniPaciente.TabIndex = 1;

            btnBuscarPaciente.BackColor = Color.FromArgb(30, 107, 160);
            btnBuscarPaciente.FlatAppearance.BorderSize = 0;
            btnBuscarPaciente.FlatStyle = FlatStyle.Flat;
            btnBuscarPaciente.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBuscarPaciente.ForeColor = Color.White;
            btnBuscarPaciente.Location = new Point(195, 22);
            btnBuscarPaciente.Name = "btnBuscarPaciente";
            btnBuscarPaciente.Size = new Size(90, 27);
            btnBuscarPaciente.TabIndex = 2;
            btnBuscarPaciente.Text = "Buscar";
            btnBuscarPaciente.UseVisualStyleBackColor = false;
            btnBuscarPaciente.Click += btnBuscarPaciente_Click;

            lblPaciente.AutoSize = true;
            lblPaciente.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPaciente.Location = new Point(300, 27);
            lblPaciente.Name = "lblPaciente";
            lblPaciente.TabIndex = 3;
            lblPaciente.Text = "Nombre:";

            txtPaciente.BackColor = SystemColors.Control;
            txtPaciente.Location = new Point(358, 24);
            txtPaciente.Name = "txtPaciente";
            txtPaciente.ReadOnly = true;
            txtPaciente.Size = new Size(490, 23);
            txtPaciente.TabIndex = 4;
            txtPaciente.TabStop = false;

            grpPaciente.Controls.Add(lblDniPaciente);
            grpPaciente.Controls.Add(txtDniPaciente);
            grpPaciente.Controls.Add(btnBuscarPaciente);
            grpPaciente.Controls.Add(lblPaciente);
            grpPaciente.Controls.Add(txtPaciente);

            grpFiltros.Location = new Point(15, 144);
            grpFiltros.Name = "grpFiltros";
            grpFiltros.Size = new Size(870, 60);
            grpFiltros.TabIndex = 2;
            grpFiltros.TabStop = false;
            grpFiltros.Text = "Filtros";

            chkFecha.AutoSize = true;
            chkFecha.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            chkFecha.Location = new Point(12, 22);
            chkFecha.Name = "chkFecha";
            chkFecha.TabIndex = 0;
            chkFecha.Text = "Fecha:";
            chkFecha.CheckedChanged += chkFecha_CheckedChanged;

            dtpFecha.CustomFormat = "dd/MM/yyyy";
            dtpFecha.Enabled = false;
            dtpFecha.Format = DateTimePickerFormat.Custom;
            dtpFecha.Location = new Point(75, 20);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(140, 23);
            dtpFecha.TabIndex = 1;

            btnBuscar.BackColor = Color.FromArgb(30, 107, 160);
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(230, 17);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(150, 28);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar turnos";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;

            grpFiltros.Controls.Add(chkFecha);
            grpFiltros.Controls.Add(dtpFecha);
            grpFiltros.Controls.Add(btnBuscar);

            dgvTurnos.AllowUserToAddRows = false;
            dgvTurnos.AllowUserToDeleteRows = false;
            dgvTurnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTurnos.Location = new Point(15, 216);
            dgvTurnos.Name = "dgvTurnos";
            dgvTurnos.ReadOnly = true;
            dgvTurnos.RowTemplate.Height = 25;
            dgvTurnos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTurnos.Size = new Size(870, 270);
            dgvTurnos.TabIndex = 3;
            dgvTurnos.CellClick += dgvTurnos_CellClick;

            lblNota.BackColor = Color.FromArgb(232, 244, 248);
            lblNota.BorderStyle = BorderStyle.FixedSingle;
            lblNota.Location = new Point(15, 495);
            lblNota.Name = "lblNota";
            lblNota.Padding = new Padding(6, 4, 6, 4);
            lblNota.Size = new Size(760, 28);
            lblNota.TabIndex = 4;
            lblNota.Text = "Al cancelar, el turno vuelve a estado DISPONIBLE y se desasigna el paciente.";

            btnSalir.BackColor = Color.FromArgb(100, 149, 180);
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(785, 491);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(100, 32);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 535);
            ControlBox = false;
            Controls.Add(btnSalir);
            Controls.Add(lblNota);
            Controls.Add(dgvTurnos);
            Controls.Add(grpFiltros);
            Controls.Add(grpPaciente);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCancelarReservaMedica";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cancelar Reserva de Turno - Sistema SEPRISE";
            grpPaciente.ResumeLayout(false);
            grpPaciente.PerformLayout();
            grpFiltros.ResumeLayout(false);
            grpFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTurnos).EndInit();
            ResumeLayout(false);
        }

        private Label lblTitulo;
        private GroupBox grpPaciente;
        private Label lblDniPaciente;
        private TextBox txtDniPaciente;
        private Button btnBuscarPaciente;
        private Label lblPaciente;
        private TextBox txtPaciente;
        private GroupBox grpFiltros;
        private CheckBox chkFecha;
        private DateTimePicker dtpFecha;
        private Button btnBuscar;
        private DataGridView dgvTurnos;
        private Label lblNota;
        private Button btnSalir;
    }
}
