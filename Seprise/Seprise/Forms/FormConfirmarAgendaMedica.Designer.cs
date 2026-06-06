namespace Seprise
{
    partial class FormConfirmarAgendaMedica
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
            grpFiltros = new Panel(); // Cambiado a Panel para el efecto Tarjeta Blanca
            lblSeccionFiltros = new Label();
            lblFechaEstatica = new Label();
            dtpFecha = new DateTimePicker();
            lblMedico = new Label();
            cmbMedico = new ComboBox();
            btnBuscar = new Button();
            pnlGridCard = new Panel(); // Tarjeta contenedora blanca para la grilla
            dgvAgendas = new DataGridView();
            lblNota = new Label();
            btnSalir = new Button();
            pnlHeader.SuspendLayout();
            grpFiltros.SuspendLayout();
            pnlGridCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAgendas).BeginInit();
            SuspendLayout();

            Color colorPrincipal = Color.FromArgb(0, 150, 136);

            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = colorPrincipal;
            pnlHeader.Controls.Add(lblTitulo);
            pnlHeader.Controls.Add(lblSubtitulo);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(760, 85);
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
            lblTitulo.Size = new Size(325, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "📅   Confirmar agenda médica";

            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.BackColor = Color.Transparent;
            lblSubtitulo.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            lblSubtitulo.ForeColor = Color.FromArgb(204, 242, 239);
            lblSubtitulo.Location = new Point(26, 48);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(230, 17);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Revise y confirme la agenda a crear.";

            // =======================================================================
            // TARJETA BLANCA: FILTROS DE BÚSQUEDA
            // =======================================================================
            grpFiltros.BackColor = Color.White;
            grpFiltros.Location = new Point(20, 105);
            grpFiltros.Name = "grpFiltros";
            grpFiltros.Size = new Size(720, 95);
            grpFiltros.TabIndex = 1;

            lblSeccionFiltros.AutoSize = true;
            lblSeccionFiltros.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblSeccionFiltros.ForeColor = colorPrincipal;
            lblSeccionFiltros.Location = new Point(15, 12);
            lblSeccionFiltros.Name = "lblSeccionFiltros";
            lblSeccionFiltros.Size = new Size(160, 17);
            lblSeccionFiltros.Text = "⏳ FILTROS DE BÚSQUEDA";

            // lblFechaEstatica (Alineación impecable)
            lblFechaEstatica.AutoSize = true;
            lblFechaEstatica.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFechaEstatica.ForeColor = Color.FromArgb(60, 60, 60);
            lblFechaEstatica.Location = new Point(17, 40);
            lblFechaEstatica.Size = new Size(38, 15);
            lblFechaEstatica.Text = "Fecha";

            // dtpFecha
            dtpFecha.CustomFormat = "dd/MM/yyyy";
            dtpFecha.Enabled = true;
            dtpFecha.Font = new Font("Segoe UI", 9.5F);
            dtpFecha.Format = DateTimePickerFormat.Custom;
            dtpFecha.Location = new Point(20, 57);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(135, 25);
            dtpFecha.TabIndex = 1;

            // lblMedico
            lblMedico.AutoSize = true;
            lblMedico.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblMedico.ForeColor = Color.FromArgb(60, 60, 60);
            lblMedico.Location = new Point(172, 40);
            lblMedico.Name = "lblMedico";
            lblMedico.Size = new Size(48, 15);
            lblMedico.TabIndex = 2;
            lblMedico.Text = "Médico";

            // cmbMedico
            cmbMedico.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMedico.Font = new Font("Segoe UI", 9.5F);
            cmbMedico.FormattingEnabled = true;
            cmbMedico.Location = new Point(175, 57);
            cmbMedico.Name = "cmbMedico";
            cmbMedico.Size = new Size(365, 25);
            cmbMedico.TabIndex = 3;

            // btnBuscar
            btnBuscar.BackColor = colorPrincipal;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(560, 55);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(140, 28);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "🔍 Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;

            grpFiltros.Controls.Add(lblSeccionFiltros);
            grpFiltros.Controls.Add(lblFechaEstatica);
            grpFiltros.Controls.Add(dtpFecha);
            grpFiltros.Controls.Add(lblMedico);
            grpFiltros.Controls.Add(cmbMedico);
            grpFiltros.Controls.Add(btnBuscar);

            // =======================================================================
            // TARJETA BLANCA: CONTENEDOR DE LA REJILLA
            // =======================================================================
            pnlGridCard.BackColor = Color.White;
            pnlGridCard.Location = new Point(20, 215);
            pnlGridCard.Name = "pnlGridCard";
            pnlGridCard.Padding = new Padding(15);
            pnlGridCard.Size = new Size(720, 110);
            pnlGridCard.TabIndex = 2;

            // dgvAgendas
            dgvAgendas.AllowUserToAddRows = false;
            dgvAgendas.AllowUserToDeleteRows = false;
            dgvAgendas.BackgroundColor = Color.White;
            dgvAgendas.BorderStyle = BorderStyle.None;
            dgvAgendas.EnableHeadersVisualStyles = false;
            
            DataGridViewCellStyle headerStyle = new DataGridViewCellStyle();
            headerStyle.BackColor = colorPrincipal;
            headerStyle.ForeColor = Color.White;
            headerStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            headerStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvAgendas.ColumnHeadersDefaultCellStyle = headerStyle;

            // Fila alterna en el verde menta ultra claro definido
            dgvAgendas.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(242, 249, 248);
            
            dgvAgendas.Dock = DockStyle.Fill;
            dgvAgendas.Location = new Point(15, 15);
            dgvAgendas.Name = "dgvAgendas";
            dgvAgendas.ReadOnly = true;
            dgvAgendas.RowHeadersVisible = false;
            dgvAgendas.RowTemplate.Height = 32;
            dgvAgendas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAgendas.Size = new Size(690, 90);
            dgvAgendas.TabIndex = 0;
            dgvAgendas.CellClick += dgvAgendas_CellClick;
            pnlGridCard.Controls.Add(dgvAgendas);

            // =======================================================================
            // FOOTER GENERAL
            // =======================================================================
            // lblNota (Fondo VERDE pastel corporativo real)
            lblNota.BackColor = Color.FromArgb(198, 234, 212);
            lblNota.BorderStyle = BorderStyle.None;
            lblNota.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            lblNota.ForeColor = Color.FromArgb(0, 75, 68); 
            lblNota.Location = new Point(20, 345);
            lblNota.Name = "lblNota";
            lblNota.Padding = new Padding(12, 10, 12, 10);
            lblNota.Size = new Size(520, 50);
            lblNota.TabIndex = 3;
            lblNota.Text = "ℹ   Al confirmar, el sistema crea turnos en estado DISPONIBLE y agrega 1 sobreturno por hora.";

            // btnSalir
            btnSalir.BackColor = Color.White;
            btnSalir.FlatAppearance.BorderColor = Color.FromArgb(210, 210, 210);
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnSalir.ForeColor = Color.FromArgb(100, 100, 100);
            btnSalir.Location = new Point(600, 350);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(140, 35);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "🚪 Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;

            // 
            // FormConfirmarAgendaMedica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(238, 242, 245); // Gris corporativo de fondo
            ClientSize = new Size(770, 450);
            ControlBox = false;
            Controls.Add(btnSalir);
            Controls.Add(lblNota);
            Controls.Add(pnlGridCard);
            Controls.Add(grpFiltros);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormConfirmarAgendaMedica";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Confirmar Agenda Médica - Sistema SEPRISE";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            grpFiltros.ResumeLayout(false);
            grpFiltros.PerformLayout();
            pnlGridCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAgendas).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Panel grpFiltros; // Mutado de GroupBox a Panel flat
        private System.Windows.Forms.Label lblSeccionFiltros;
        private System.Windows.Forms.Label lblFechaEstatica;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblMedico;
        private System.Windows.Forms.ComboBox cmbMedico;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Panel pnlGridCard;
        private System.Windows.Forms.DataGridView dgvAgendas;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.CheckBox chkFecha = null;
    }
}