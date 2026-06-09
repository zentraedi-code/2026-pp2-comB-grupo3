namespace Seprise
{
    partial class FormReservarTurnoMedico
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            pnlFiltrosCard = new Panel();
            lblFiltrosIcono = new Label();
            lblEspecialidad = new Label();
            cmbEspecialidad = new ComboBox();
            lblMedico = new Label();
            cmbMedico = new ComboBox();
            chkFecha = new Label(); 
            dtpFecha = new DateTimePicker();
            btnBuscar = new Button();
            btnPrimeraDisponible = new Button();
            pnlGridCard = new Panel();
            dgvTurnos = new DataGridView();
            lblNota = new Label();
            btnSalir = new Button();
            pnlHeader.SuspendLayout();
            pnlFiltrosCard.SuspendLayout();
            pnlGridCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTurnos).BeginInit();
            SuspendLayout();

            Color colorPrincipal = Color.FromArgb(0, 150, 136); 

            pnlHeader.BackColor = colorPrincipal;
            pnlHeader.Controls.Add(lblTitulo);
            pnlHeader.Controls.Add(lblSubtitulo);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(930, 85);
            pnlHeader.TabIndex = 0;

            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(24, 15);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(270, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "📅  Reservar turno médico";

            lblSubtitulo.AutoSize = true;
            lblSubtitulo.BackColor = Color.Transparent;
            lblSubtitulo.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            lblSubtitulo.ForeColor = Color.FromArgb(200, 220, 255);
            lblSubtitulo.Location = new Point(26, 48);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(262, 17);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Busque y seleccione un turno disponible";

            pnlFiltrosCard.BackColor = Color.White;
            pnlFiltrosCard.BorderStyle = BorderStyle.None;
            pnlFiltrosCard.Controls.Add(lblFiltrosIcono);
            pnlFiltrosCard.Controls.Add(lblEspecialidad);
            pnlFiltrosCard.Controls.Add(cmbEspecialidad);
            pnlFiltrosCard.Controls.Add(lblMedico);
            pnlFiltrosCard.Controls.Add(cmbMedico);
            pnlFiltrosCard.Controls.Add(chkFecha);
            pnlFiltrosCard.Controls.Add(dtpFecha);
            pnlFiltrosCard.Controls.Add(btnBuscar);
            pnlFiltrosCard.Controls.Add(btnPrimeraDisponible);
            pnlFiltrosCard.Location = new Point(20, 105);
            pnlFiltrosCard.Name = "pnlFiltrosCard";
            pnlFiltrosCard.Size = new Size(890, 105);
            pnlFiltrosCard.TabIndex = 1;

            lblFiltrosIcono.AutoSize = true;
            lblFiltrosIcono.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblFiltrosIcono.ForeColor = colorPrincipal;
            lblFiltrosIcono.Location = new Point(15, 12);
            lblFiltrosIcono.Name = "lblFiltrosIcono";
            lblFiltrosIcono.Size = new Size(160, 17);
            lblFiltrosIcono.Text = "⏳ FILTROS DE BÚSQUEDA";

            lblEspecialidad.AutoSize = true;
            lblEspecialidad.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEspecialidad.ForeColor = Color.FromArgb(60, 60, 60);
            lblEspecialidad.Location = new Point(17, 42);
            lblEspecialidad.Name = "lblEspecialidad";
            lblEspecialidad.Size = new Size(76, 15);
            lblEspecialidad.Text = "Especialidad";

            cmbEspecialidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEspecialidad.Font = new Font("Segoe UI", 9.5F);
            cmbEspecialidad.FormattingEnabled = true;
            cmbEspecialidad.Location = new Point(20, 60);
            cmbEspecialidad.Name = "cmbEspecialidad";
            cmbEspecialidad.Size = new Size(190, 25);
            cmbEspecialidad.TabIndex = 1;
            cmbEspecialidad.SelectedIndexChanged += cmbEspecialidad_SelectedIndexChanged;

            lblMedico.AutoSize = true;
            lblMedico.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblMedico.ForeColor = Color.FromArgb(60, 60, 60);
            lblMedico.Location = new Point(222, 42);
            lblMedico.Name = "lblMedico";
            lblMedico.Size = new Size(49, 15);
            lblMedico.Text = "Médico";

            cmbMedico.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMedico.Font = new Font("Segoe UI", 9.5F);
            cmbMedico.FormattingEnabled = true;
            cmbMedico.Location = new Point(225, 60);
            cmbMedico.Name = "cmbMedico";
            cmbMedico.Size = new Size(220, 25);
            cmbMedico.TabIndex = 3;

            chkFecha.AutoSize = true;
            chkFecha.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            chkFecha.ForeColor = Color.FromArgb(60, 60, 60);
            chkFecha.Location = new Point(462, 42);
            chkFecha.Name = "chkFecha";
            chkFecha.Size = new Size(38, 15);
            chkFecha.TabIndex = 4;
            chkFecha.Text = "Fecha";

            dtpFecha.CustomFormat = "dd/MM/yyyy";
            dtpFecha.Enabled = true; 
            dtpFecha.Font = new Font("Segoe UI", 9.5F);
            dtpFecha.Format = DateTimePickerFormat.Custom;
            dtpFecha.Location = new Point(465, 60);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(130, 25);
            dtpFecha.TabIndex = 5;

            btnBuscar.BackColor = colorPrincipal;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(610, 57);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(115, 30);
            btnBuscar.TabIndex = 6;
            btnBuscar.Text = "🔍 Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;

            btnPrimeraDisponible.BackColor = Color.FromArgb(16, 157, 89);
            btnPrimeraDisponible.FlatAppearance.BorderSize = 0;
            btnPrimeraDisponible.FlatStyle = FlatStyle.Flat;
            btnPrimeraDisponible.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnPrimeraDisponible.ForeColor = Color.White;
            btnPrimeraDisponible.Location = new Point(735, 57);
            btnPrimeraDisponible.Name = "btnPrimeraDisponible";
            btnPrimeraDisponible.Size = new Size(140, 30);
            btnPrimeraDisponible.TabIndex = 7;
            btnPrimeraDisponible.Text = "⚡ Primera disp.";
            btnPrimeraDisponible.UseVisualStyleBackColor = false;
            btnPrimeraDisponible.Click += btnPrimeraDisponible_Click;

            pnlGridCard.BackColor = Color.White;
            pnlGridCard.BorderStyle = BorderStyle.None;
            pnlGridCard.Controls.Add(dgvTurnos);
            pnlGridCard.Location = new Point(20, 225);
            pnlGridCard.Name = "pnlGridCard";
            pnlGridCard.Padding = new Padding(15);
            pnlGridCard.Size = new Size(890, 250);
            pnlGridCard.TabIndex = 2;

            dgvTurnos.AllowUserToAddRows = false;
            dgvTurnos.AllowUserToDeleteRows = false;
            dgvTurnos.BackgroundColor = Color.White;
            dgvTurnos.BorderStyle = BorderStyle.None;
            dgvTurnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTurnos.Dock = DockStyle.Fill;
            dgvTurnos.Location = new Point(15, 15);
            dgvTurnos.Name = "dgvTurnos";
            dgvTurnos.ReadOnly = true;
            dgvTurnos.RowHeadersVisible = false;
            dgvTurnos.RowTemplate.Height = 30;
            dgvTurnos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTurnos.Size = new Size(860, 220);
            dgvTurnos.TabIndex = 0;
            dgvTurnos.CellClick += dgvTurnos_CellClick;

            lblNota.BackColor = Color.FromArgb(198, 234, 212);
            lblNota.BorderStyle = BorderStyle.None;
            lblNota.Font = new Font("Segoe UI", 9F, FontStyle.Regular); 
            lblNota.ForeColor = Color.FromArgb(20, 80, 120); 
            lblNota.Location = new Point(20, 492);
            lblNota.Name = "lblNota";
            lblNota.Padding = new Padding(12, 8, 10, 8);
            lblNota.Size = new Size(740, 35);
            lblNota.TabIndex = 3;
            lblNota.Text = "ℹ   Al reservar un turno se solicitará la búsqueda del paciente correspondiente.";

            btnSalir.BackColor = Color.White;
            btnSalir.FlatAppearance.BorderColor = Color.FromArgb(210, 210, 210);
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnSalir.ForeColor = Color.FromArgb(100, 100, 100);
            btnSalir.Location = new Point(780, 492);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(130, 35);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "🚪 Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(238, 242, 245); 
            ClientSize = new Size(940, 578); 
            ControlBox = false;
            Controls.Add(btnSalir);
            Controls.Add(lblNota);
            Controls.Add(pnlGridCard);
            Controls.Add(pnlFiltrosCard);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormReservarTurnoMedico";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reservar Turno Médico - Sistema SEPRISE";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlFiltrosCard.ResumeLayout(false);
            pnlFiltrosCard.PerformLayout();
            pnlGridCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTurnos).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Panel pnlFiltrosCard;
        private System.Windows.Forms.Label lblFiltrosIcono;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.ComboBox cmbEspecialidad;
        private System.Windows.Forms.Label lblMedico;
        private System.Windows.Forms.ComboBox cmbMedico;
        private System.Windows.Forms.Label chkFecha; 
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnPrimeraDisponible;
        private System.Windows.Forms.Panel pnlGridCard;
        private System.Windows.Forms.DataGridView dgvTurnos;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.Button btnSalir;
    }
}