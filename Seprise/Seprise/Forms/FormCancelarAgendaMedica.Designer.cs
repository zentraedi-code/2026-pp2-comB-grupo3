namespace Seprise
{
    partial class FormCancelarAgendaMedica
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
            pnlHeader = new Panel(); // Inicializamos el panel contenedor
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            grpFiltros = new GroupBox();
            dtpFecha = new DateTimePicker();
            lblMedico = new Label();
            cmbMedico = new ComboBox();
            btnBuscar = new Button();
            dgvAgendas = new DataGridView();
            lblNota = new Label();
            btnSalir = new Button();
            pnlHeader.SuspendLayout(); // Suspendemos layout del panel
            grpFiltros.SuspendLayout();
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
            pnlHeader.Size = new Size(750, 85); // Altura ideal para albergar ambos textos cómodamente
            pnlHeader.TabIndex = 0;

            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true; // Cambiado a True para que use posicionamiento web limpio
            lblTitulo.BackColor = Color.Transparent; // Transparente para usar el fondo del panel
            lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(24, 15); // Ubicación ajustada dentro del Panel
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(320, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "📅  Cancelar agenda médica";

            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.BackColor = Color.Transparent;
            lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(204, 242, 239); 
            lblSubtitulo.Location = new Point(26, 48); // Ubicación ajustada debajo del título
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(262, 17);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Seleccione la agenda médica que desea cancelar.";

            // grpFiltros (Bajado a la posición 100 para que no lo tape el panel de cabecera)
            grpFiltros.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpFiltros.ForeColor = colorPrincipal;
            grpFiltros.Location = new Point(20, 100);
            grpFiltros.Name = "grpFiltros";
            grpFiltros.Size = new Size(700, 85);
            grpFiltros.TabIndex = 1;
            grpFiltros.TabStop = false;
            grpFiltros.Text = " 🔍  FILTROS DE BÚSQUEDA";

            // lblFecha
            Label lblFechaEstatica = new Label();
            lblFechaEstatica.AutoSize = true;
            lblFechaEstatica.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFechaEstatica.ForeColor = Color.FromArgb(30, 30, 30);
            lblFechaEstatica.Location = new Point(15, 25);
            lblFechaEstatica.Size = new Size(40, 15);
            lblFechaEstatica.Text = "Fecha";

            // dtpFecha
            dtpFecha.CustomFormat = "dd/MM/yyyy";
            dtpFecha.Enabled = true;
            dtpFecha.Font = new Font("Segoe UI", 9.5F);
            dtpFecha.Format = DateTimePickerFormat.Custom;
            dtpFecha.Location = new Point(15, 45);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(140, 23);
            dtpFecha.TabIndex = 1;

            // lblMedico
            lblMedico.AutoSize = true;
            lblMedico.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblMedico.ForeColor = Color.FromArgb(30, 30, 30);
            lblMedico.Location = new Point(175, 25);
            lblMedico.Name = "lblMedico";
            lblMedico.Size = new Size(52, 15);
            lblMedico.TabIndex = 2;
            lblMedico.Text = "Médico";

            // cmbMedico
            cmbMedico.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMedico.Font = new Font("Segoe UI", 9.5F);
            cmbMedico.FormattingEnabled = true;
            cmbMedico.Location = new Point(175, 45);
            cmbMedico.Name = "cmbMedico";
            cmbMedico.Size = new Size(360, 23);
            cmbMedico.TabIndex = 3;

            // btnBuscar
            btnBuscar.BackColor = colorPrincipal;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(550, 40);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(140, 30);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "🔍 Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;

            // Agregar componentes a grpFiltros
            grpFiltros.Controls.Add(lblFechaEstatica);
            grpFiltros.Controls.Add(dtpFecha);
            grpFiltros.Controls.Add(lblMedico);
            grpFiltros.Controls.Add(cmbMedico);
            grpFiltros.Controls.Add(btnBuscar);

            // dgvAgendas (Bajado a la posición 200)
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
            
            dgvAgendas.Location = new Point(20, 200);
            dgvAgendas.Name = "dgvAgendas";
            dgvAgendas.ReadOnly = true;
            dgvAgendas.RowTemplate.Height = 32;
            dgvAgendas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAgendas.Size = new Size(700, 240);
            dgvAgendas.TabIndex = 2;
            dgvAgendas.CellClick += dgvAgendas_CellClick;

            // lblNota (Bajado proporcionalmente)
            lblNota.BackColor = Color.FromArgb(230, 247, 245);
            lblNota.BorderStyle = BorderStyle.None;
            lblNota.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            lblNota.ForeColor = Color.FromArgb(0, 100, 90);
            lblNota.Location = new Point(20, 460);
            lblNota.Name = "lblNota";
            lblNota.Padding = new Padding(10, 8, 10, 8);
            lblNota.Size = new Size(500, 45);
            lblNota.TabIndex = 3;
            lblNota.Text = "ℹ  Seleccione una agenda y confirme para proceder con la cancelación.\r\n    Al cancelar una agenda ACTIVA se eliminarán todos sus turnos asociados.";

            // btnSalir (Bajado proporcionalmente)
            btnSalir.BackColor = Color.White;
            btnSalir.FlatAppearance.BorderColor = Color.FromArgb(210, 210, 210);
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnSalir.ForeColor = Color.FromArgb(100, 100, 100);
            btnSalir.Location = new Point(570, 465);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(150, 35);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "🚪 Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;

            // FormCancelarAgendaMedica
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(750, 560); 
            ControlBox = false;
            Controls.Add(btnSalir);
            Controls.Add(lblNota);
            Controls.Add(dgvAgendas);
            Controls.Add(grpFiltros);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCancelarAgendaMedica";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cancelar Agenda Médica - Sistema SEPRISE";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            grpFiltros.ResumeLayout(false);
            grpFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAgendas).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlHeader; // Agregada la definición del Panel
        private Label lblTitulo;
        private Label lblSubtitulo;
        private GroupBox grpFiltros;
        private CheckBox chkFecha = null;
        private DateTimePicker dtpFecha;
        private Label lblMedico;
        private ComboBox cmbMedico;
        private Button btnBuscar;
        private DataGridView dgvAgendas;
        private Label lblNota;
        private Button btnSalir;
    }
}