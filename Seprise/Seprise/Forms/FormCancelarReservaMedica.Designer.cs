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
            pnlHeader = new Panel();
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            grpPaciente = new Panel(); // Cambiado a Panel para estilo Tarjeta Blanca Flotante
            lblFiltrosIcono = new Label();
            lblDniPaciente = new Label();
            txtDniPaciente = new TextBox();
            btnBuscarPaciente = new Button();
            lblPaciente = new Label();
            txtPaciente = new TextBox();
            grpFiltros = new Panel(); // Cambiado a Panel para estilo Tarjeta Blanca Flotante
            lblSeccionFiltros = new Label();
            chkFecha = new Label(); // Se transforma a Label para sacar el CheckBox físico sin perder la funcionalidad
            dtpFecha = new DateTimePicker();
            btnBuscar = new Button();
            pnlGridCard = new Panel(); // Tarjeta contenedora para la grilla
            dgvTurnos = new DataGridView();
            lblNota = new Label();
            btnSalir = new Button();
            pnlHeader.SuspendLayout();
            grpPaciente.SuspendLayout();
            grpFiltros.SuspendLayout();
            pnlGridCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTurnos).BeginInit();
            SuspendLayout();

            Color colorPrincipal = Color.FromArgb(0, 150, 136); // Azul/Verde institucional unificado

            // 
            // pnlHeader (Cabecera moderna de la aplicación)
            // 
            pnlHeader.BackColor = colorPrincipal;
            pnlHeader.Controls.Add(lblTitulo);
            pnlHeader.Controls.Add(lblSubtitulo);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(920, 85);
            pnlHeader.TabIndex = 0;

            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(24, 15);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(350, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "❌  Cancelar reserva de turno";

            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.BackColor = Color.Transparent;
            lblSubtitulo.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            lblSubtitulo.ForeColor = Color.FromArgb(200, 240, 235);
            lblSubtitulo.Location = new Point(26, 48);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(320, 17);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Busque al paciente para liberar sus turnos agendados";

            // =======================================================================
            // TARJETA BLANCA 1: SECCIÓN PACIENTE
            // =======================================================================
            grpPaciente.BackColor = Color.White;
            grpPaciente.Location = new Point(20, 105);
            grpPaciente.Name = "grpPaciente";
            grpPaciente.Size = new Size(880, 90);
            grpPaciente.TabIndex = 1;

            lblFiltrosIcono.AutoSize = true;
            lblFiltrosIcono.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblFiltrosIcono.ForeColor = colorPrincipal;
            lblFiltrosIcono.Location = new Point(15, 12);
            lblFiltrosIcono.Name = "lblFiltrosIcono";
            lblFiltrosIcono.Size = new Size(150, 17);
            lblFiltrosIcono.Text = "👤 DATOS DEL PACIENTE";

            // lblDniPaciente (Regla de 3 píxeles: X = 17)
            lblDniPaciente.AutoSize = true;
            lblDniPaciente.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDniPaciente.ForeColor = Color.FromArgb(60, 60, 60);
            lblDniPaciente.Location = new Point(17, 39);
            lblDniPaciente.Name = "lblDniPaciente";
            lblDniPaciente.Size = new Size(29, 15);
            lblDniPaciente.Text = "DNI";

            txtDniPaciente.Font = new Font("Segoe UI", 9.5F);
            txtDniPaciente.Location = new Point(20, 56);
            txtDniPaciente.Name = "txtDniPaciente";
            txtDniPaciente.PlaceholderText = "Ej: 30111222";
            txtDniPaciente.Size = new Size(130, 25);
            txtDniPaciente.TabIndex = 1;

            btnBuscarPaciente.BackColor = colorPrincipal;
            btnBuscarPaciente.FlatAppearance.BorderSize = 0;
            btnBuscarPaciente.FlatStyle = FlatStyle.Flat;
            btnBuscarPaciente.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnBuscarPaciente.ForeColor = Color.White;
            btnBuscarPaciente.Location = new Point(160, 54);
            btnBuscarPaciente.Name = "btnBuscarPaciente";
            btnBuscarPaciente.Size = new Size(95, 28);
            btnBuscarPaciente.TabIndex = 2;
            btnBuscarPaciente.Text = "🔍 Buscar";
            btnBuscarPaciente.UseVisualStyleBackColor = false;
            btnBuscarPaciente.Click += btnBuscarPaciente_Click;

            // lblPaciente (Regla de 3 píxeles: X = 267)
            lblPaciente.AutoSize = true;
            lblPaciente.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPaciente.ForeColor = Color.FromArgb(60, 60, 60);
            lblPaciente.Location = new Point(267, 39);
            lblPaciente.Name = "lblPaciente";
            lblPaciente.Size = new Size(116, 15);
            lblPaciente.Text = "Nombre del Paciente";

            txtPaciente.BackColor = Color.FromArgb(245, 247, 248);
            txtPaciente.BorderStyle = BorderStyle.FixedSingle;
            txtPaciente.Font = new Font("Segoe UI", 9.5F);
            txtPaciente.Location = new Point(270, 56);
            txtPaciente.Name = "txtPaciente";
            txtPaciente.ReadOnly = true;
            txtPaciente.Size = new Size(590, 25);
            txtPaciente.TabIndex = 4;
            txtPaciente.TabStop = false;

            grpPaciente.Controls.Add(lblFiltrosIcono);
            grpPaciente.Controls.Add(lblDniPaciente);
            grpPaciente.Controls.Add(txtDniPaciente);
            grpPaciente.Controls.Add(btnBuscarPaciente);
            grpPaciente.Controls.Add(lblPaciente);
            grpPaciente.Controls.Add(txtPaciente);

            // =======================================================================
            // TARJETA BLANCA 2: FILTROS DE BÚSQUEDA
            // =======================================================================
            grpFiltros.BackColor = Color.White;
            grpFiltros.Location = new Point(20, 210);
            grpFiltros.Name = "grpFiltros";
            grpFiltros.Size = new Size(880, 95);
            grpFiltros.TabIndex = 2;

            lblSeccionFiltros.AutoSize = true;
            lblSeccionFiltros.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblSeccionFiltros.ForeColor = colorPrincipal;
            lblSeccionFiltros.Location = new Point(15, 12);
            lblSeccionFiltros.Name = "lblSeccionFiltros";
            lblSeccionFiltros.Size = new Size(160, 17);
            lblSeccionFiltros.Text = "⏳ FILTROS DE BÚSQUEDA";

            // chkFecha (Ahora actúa limpiamente como Label, X = 17)
            chkFecha.AutoSize = true;
            chkFecha.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            chkFecha.ForeColor = Color.FromArgb(60, 60, 60);
            chkFecha.Location = new Point(17, 42);
            chkFecha.Name = "chkFecha";
            chkFecha.Size = new Size(38, 15);
            chkFecha.TabIndex = 0;
            chkFecha.Text = "Fecha";

            dtpFecha.CustomFormat = "dd/MM/yyyy";
            dtpFecha.Enabled = true; // Habilitado directo ya que no requiere un check previo
            dtpFecha.Font = new Font("Segoe UI", 9.5F);
            dtpFecha.Format = DateTimePickerFormat.Custom;
            dtpFecha.Location = new Point(20, 59);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(140, 25);
            dtpFecha.TabIndex = 1;

            btnBuscar.BackColor = colorPrincipal;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(175, 56);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(150, 28);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "🔍 Buscar turnos";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;

            grpFiltros.Controls.Add(lblSeccionFiltros);
            grpFiltros.Controls.Add(chkFecha);
            grpFiltros.Controls.Add(dtpFecha);
            grpFiltros.Controls.Add(btnBuscar);

            // =======================================================================
            // TARJETA BLANCA 3: CONTENEDOR GRID
            // =======================================================================
            pnlGridCard.BackColor = Color.White;
            pnlGridCard.Location = new Point(20, 320);
            pnlGridCard.Name = "pnlGridCard";
            pnlGridCard.Padding = new Padding(15);
            pnlGridCard.Size = new Size(880, 190);
            pnlGridCard.TabIndex = 3;

            // dgvTurnos
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
            dgvTurnos.Size = new Size(850, 180);
            dgvTurnos.TabIndex = 0;
            dgvTurnos.CellClick += dgvTurnos_CellClick;
            pnlGridCard.Controls.Add(dgvTurnos);

            // =======================================================================
            // FOOTER GENERAL
            // =======================================================================
            // lblNota (Fondo VERDE pastel real con presencia)
            lblNota.BackColor = Color.FromArgb(198, 234, 212);
            lblNota.BorderStyle = BorderStyle.None;
            lblNota.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            lblNota.ForeColor = Color.FromArgb(20, 80, 120); // Letra azul original
            lblNota.Location = new Point(20, 527);
            lblNota.Name = "lblNota";
            lblNota.Padding = new Padding(12, 8, 10, 8);
            lblNota.Size = new Size(730, 35);
            lblNota.TabIndex = 4;
            lblNota.Text = "ℹ   Al cancelar, el turno vuelve a estado DISPONIBLE y se desasigna el paciente correspondiente.";

            // btnSalir
            btnSalir.BackColor = Color.White;
            btnSalir.FlatAppearance.BorderColor = Color.FromArgb(210, 210, 210);
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnSalir.ForeColor = Color.FromArgb(100, 100, 100);
            btnSalir.Location = new Point(770, 527);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(130, 35);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "🚪 Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;

            // 
            // FormCancelarReservaMedica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(238, 242, 245); // El fondo gris exacto de las pantallas
            ClientSize = new Size(930, 620);
            ControlBox = false;
            Controls.Add(btnSalir);
            Controls.Add(lblNota);
            Controls.Add(pnlGridCard);
            Controls.Add(grpFiltros);
            Controls.Add(grpPaciente);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCancelarReservaMedica";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cancelar Reserva de Turno - Sistema SEPRISE";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            grpPaciente.ResumeLayout(false);
            grpPaciente.PerformLayout();
            grpFiltros.ResumeLayout(false);
            grpFiltros.PerformLayout();
            pnlGridCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTurnos).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel grpPaciente;
        private System.Windows.Forms.Label lblFiltrosIcono;
        private System.Windows.Forms.Label lblDniPaciente;
        private System.Windows.Forms.TextBox txtDniPaciente;
        private System.Windows.Forms.Button btnBuscarPaciente;
        private System.Windows.Forms.Label lblPaciente;
        private System.Windows.Forms.TextBox txtPaciente;
        private System.Windows.Forms.Panel grpFiltros;
        private System.Windows.Forms.Label lblSeccionFiltros;
        private System.Windows.Forms.Label chkFecha; // Cambiado a Label manteniendo nombre original intacto
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Panel pnlGridCard;
        private System.Windows.Forms.DataGridView dgvTurnos;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.Button btnSalir;
    }
}