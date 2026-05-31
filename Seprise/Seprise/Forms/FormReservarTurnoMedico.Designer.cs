namespace Seprise
{
    partial class FormReservarTurnoMedico
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
            grpFiltros = new GroupBox();
            lblEspecialidad = new Label();
            cmbEspecialidad = new ComboBox();
            lblMedico = new Label();
            cmbMedico = new ComboBox();
            chkFecha = new CheckBox();
            dtpFecha = new DateTimePicker();
            btnBuscar = new Button();
            btnPrimeraDisponible = new Button();
            dgvTurnos = new DataGridView();
            lblNota = new Label();
            btnSalir = new Button();
            grpFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTurnos).BeginInit();
            SuspendLayout();

            // lblTitulo
            lblTitulo.BackColor = Color.FromArgb(30, 107, 160);
            lblTitulo.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(900, 48);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "   Reservar turno médico";
            lblTitulo.TextAlign = ContentAlignment.MiddleLeft;

            // grpFiltros
            grpFiltros.Location = new Point(15, 62);
            grpFiltros.Name = "grpFiltros";
            grpFiltros.Size = new Size(870, 100);
            grpFiltros.TabIndex = 1;
            grpFiltros.TabStop = false;
            grpFiltros.Text = "Filtros de búsqueda";

            // lblEspecialidad
            lblEspecialidad.AutoSize = true;
            lblEspecialidad.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEspecialidad.Location = new Point(12, 24);
            lblEspecialidad.Name = "lblEspecialidad";
            lblEspecialidad.TabIndex = 0;
            lblEspecialidad.Text = "Especialidad:";

            // cmbEspecialidad
            cmbEspecialidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEspecialidad.FormattingEnabled = true;
            cmbEspecialidad.Location = new Point(100, 21);
            cmbEspecialidad.Name = "cmbEspecialidad";
            cmbEspecialidad.Size = new Size(220, 23);
            cmbEspecialidad.TabIndex = 1;
            cmbEspecialidad.SelectedIndexChanged += cmbEspecialidad_SelectedIndexChanged;

            // lblMedico
            lblMedico.AutoSize = true;
            lblMedico.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblMedico.Location = new Point(335, 24);
            lblMedico.Name = "lblMedico";
            lblMedico.TabIndex = 2;
            lblMedico.Text = "Médico:";

            // cmbMedico
            cmbMedico.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMedico.FormattingEnabled = true;
            cmbMedico.Location = new Point(390, 21);
            cmbMedico.Name = "cmbMedico";
            cmbMedico.Size = new Size(280, 23);
            cmbMedico.TabIndex = 3;

            // chkFecha
            chkFecha.AutoSize = true;
            chkFecha.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            chkFecha.Location = new Point(12, 62);
            chkFecha.Name = "chkFecha";
            chkFecha.Size = new Size(56, 19);
            chkFecha.TabIndex = 4;
            chkFecha.Text = "Fecha:";
            chkFecha.CheckedChanged += chkFecha_CheckedChanged;

            // dtpFecha
            dtpFecha.CustomFormat = "dd/MM/yyyy";
            dtpFecha.Enabled = false;
            dtpFecha.Format = DateTimePickerFormat.Custom;
            dtpFecha.Location = new Point(75, 59);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(140, 23);
            dtpFecha.TabIndex = 5;

            // btnBuscar
            btnBuscar.BackColor = Color.FromArgb(30, 107, 160);
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(390, 57);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(130, 28);
            btnBuscar.TabIndex = 6;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;

            // btnPrimeraDisponible
            btnPrimeraDisponible.BackColor = Color.FromArgb(60, 140, 60);
            btnPrimeraDisponible.FlatAppearance.BorderSize = 0;
            btnPrimeraDisponible.FlatStyle = FlatStyle.Flat;
            btnPrimeraDisponible.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnPrimeraDisponible.ForeColor = Color.White;
            btnPrimeraDisponible.Location = new Point(530, 57);
            btnPrimeraDisponible.Name = "btnPrimeraDisponible";
            btnPrimeraDisponible.Size = new Size(160, 28);
            btnPrimeraDisponible.TabIndex = 7;
            btnPrimeraDisponible.Text = "Primera disponible";
            btnPrimeraDisponible.UseVisualStyleBackColor = false;
            btnPrimeraDisponible.Click += btnPrimeraDisponible_Click;

            grpFiltros.Controls.Add(lblEspecialidad);
            grpFiltros.Controls.Add(cmbEspecialidad);
            grpFiltros.Controls.Add(lblMedico);
            grpFiltros.Controls.Add(cmbMedico);
            grpFiltros.Controls.Add(chkFecha);
            grpFiltros.Controls.Add(dtpFecha);
            grpFiltros.Controls.Add(btnBuscar);
            grpFiltros.Controls.Add(btnPrimeraDisponible);

            // dgvTurnos
            dgvTurnos.AllowUserToAddRows = false;
            dgvTurnos.AllowUserToDeleteRows = false;
            dgvTurnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTurnos.Location = new Point(15, 174);
            dgvTurnos.Name = "dgvTurnos";
            dgvTurnos.ReadOnly = true;
            dgvTurnos.RowTemplate.Height = 25;
            dgvTurnos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTurnos.Size = new Size(870, 260);
            dgvTurnos.TabIndex = 2;
            dgvTurnos.CellClick += dgvTurnos_CellClick;

            // lblNota
            lblNota.BackColor = Color.FromArgb(232, 244, 248);
            lblNota.BorderStyle = BorderStyle.FixedSingle;
            lblNota.Location = new Point(15, 444);
            lblNota.Name = "lblNota";
            lblNota.Padding = new Padding(6, 4, 6, 4);
            lblNota.Size = new Size(760, 28);
            lblNota.TabIndex = 3;
            lblNota.Text = "Al reservar un turno se solicitará la búsqueda del paciente.";

            // btnSalir
            btnSalir.BackColor = Color.FromArgb(100, 149, 180);
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(785, 440);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(100, 32);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 487);
            ControlBox = false;
            Controls.Add(btnSalir);
            Controls.Add(lblNota);
            Controls.Add(dgvTurnos);
            Controls.Add(grpFiltros);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormReservarTurnoMedico";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reservar Turno Médico - Sistema SEPRISE";
            grpFiltros.ResumeLayout(false);
            grpFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTurnos).EndInit();
            ResumeLayout(false);
        }

        private Label lblTitulo;
        private GroupBox grpFiltros;
        private Label lblEspecialidad;
        private ComboBox cmbEspecialidad;
        private Label lblMedico;
        private ComboBox cmbMedico;
        private CheckBox chkFecha;
        private DateTimePicker dtpFecha;
        private Button btnBuscar;
        private Button btnPrimeraDisponible;
        private DataGridView dgvTurnos;
        private Label lblNota;
        private Button btnSalir;
    }
}
