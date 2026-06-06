namespace Seprise
{
    partial class FormCrearAgendaMedica
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
            lblFecha = new Label();
            dtpFecha = new DateTimePicker();
            lblHoraDesde = new Label();
            dtpHoraDesde = new DateTimePicker();
            lblHoraHasta = new Label();
            dtpHoraHasta = new DateTimePicker();
            lblProfesional = new Label();
            cboProfesional = new ComboBox();
            lblConsultorio = new Label();
            cboConsultorio = new ComboBox();
            lblDuracion = new Label();
            txtDuracion = new TextBox();
            lblNota = new Label();
            btnCrear = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            pnlHeader.SuspendLayout();
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
            pnlHeader.Size = new Size(710, 85);
            pnlHeader.TabIndex = 0;

            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(24, 15);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(280, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "📅  Crear agenda médica";

            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.BackColor = Color.Transparent;
            lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular);
            lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(204, 242, 239);
            lblSubtitulo.Location = new Point(26, 48);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(280, 17);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Complete los datos para crear una nueva agenda.";

            // ==========================================
            // FILA 1: FECHA (Ocupa la columna izquierda)
            // ==========================================
            // lblFecha (X = 23, 3 puntos menos que el dtpFecha que está en 26)
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblFecha.ForeColor = Color.FromArgb(40, 40, 40);
            lblFecha.Location = new Point(23, 102);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(43, 17);
            lblFecha.Text = "Fecha";

            dtpFecha.CustomFormat = "dd/MM/yyyy";
            dtpFecha.Font = new Font("Segoe UI", 10F);
            dtpFecha.Format = DateTimePickerFormat.Custom;
            dtpFecha.Location = new Point(26, 122);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(320, 25);
            dtpFecha.TabIndex = 2;

            // ==========================================
            // FILA 2: HORAS (Desde y Hasta)
            // ==========================================
            // lblHoraDesde (X = 23, 3 puntos menos que dtpHoraDesde en 26)
            lblHoraDesde.AutoSize = true;
            lblHoraDesde.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblHoraDesde.ForeColor = Color.FromArgb(40, 40, 40);
            lblHoraDesde.Location = new Point(23, 160);
            lblHoraDesde.Name = "lblHoraDesde";
            lblHoraDesde.Size = new Size(77, 17);
            lblHoraDesde.Text = "Hora desde";

            dtpHoraDesde.CustomFormat = "HH:mm";
            dtpHoraDesde.Font = new Font("Segoe UI", 10F);
            dtpHoraDesde.Format = DateTimePickerFormat.Custom;
            dtpHoraDesde.Location = new Point(26, 180);
            dtpHoraDesde.Name = "dtpHoraDesde";
            dtpHoraDesde.ShowUpDown = true;
            dtpHoraDesde.Size = new Size(320, 25);
            dtpHoraDesde.TabIndex = 4;

            // lblHoraHasta (X = 361, 3 puntos menos que dtpHoraHasta en 364)
            lblHoraHasta.AutoSize = true;
            lblHoraHasta.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblHoraHasta.ForeColor = Color.FromArgb(40, 40, 40);
            lblHoraHasta.Location = new Point(361, 160);
            lblHoraHasta.Name = "lblHoraHasta";
            lblHoraHasta.Size = new Size(73, 17);
            lblHoraHasta.Text = "Hora hasta";

            dtpHoraHasta.CustomFormat = "HH:mm";
            dtpHoraHasta.Font = new Font("Segoe UI", 10F);
            dtpHoraHasta.Format = DateTimePickerFormat.Custom;
            dtpHoraHasta.Location = new Point(364, 180);
            dtpHoraHasta.Name = "dtpHoraHasta";
            dtpHoraHasta.ShowUpDown = true;
            dtpHoraHasta.Size = new Size(320, 25);
            dtpHoraHasta.TabIndex = 6;

            // ==========================================
            // FILA 3: PROFESIONAL Y CONSULTORIO
            // ==========================================
            // lblProfesional (X = 23, 3 puntos menos que cboProfesional en 26)
            lblProfesional.AutoSize = true;
            lblProfesional.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblProfesional.ForeColor = Color.FromArgb(40, 40, 40);
            lblProfesional.Location = new Point(23, 218);
            lblProfesional.Name = "lblProfesional";
            lblProfesional.Size = new Size(77, 17);
            lblProfesional.Text = "Profesional";

            cboProfesional.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProfesional.Font = new Font("Segoe UI", 10F);
            cboProfesional.FormattingEnabled = true;
            cboProfesional.Location = new Point(26, 238);
            cboProfesional.Name = "cboProfesional";
            cboProfesional.Size = new Size(320, 25);
            cboProfesional.TabIndex = 8;
            cboProfesional.SelectedIndexChanged += cboProfesional_SelectedIndexChanged;

            // lblConsultorio (X = 361, 3 puntos menos que cboConsultorio en 364)
            lblConsultorio.AutoSize = true;
            lblConsultorio.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblConsultorio.ForeColor = Color.FromArgb(40, 40, 40);
            lblConsultorio.Location = new Point(361, 218);
            lblConsultorio.Name = "lblConsultorio";
            lblConsultorio.Size = new Size(79, 17);
            lblConsultorio.Text = "Consultorio";

            cboConsultorio.DropDownStyle = ComboBoxStyle.DropDownList;
            cboConsultorio.Font = new Font("Segoe UI", 10F);
            cboConsultorio.FormattingEnabled = true;
            cboConsultorio.Location = new Point(364, 238);
            cboConsultorio.Name = "cboConsultorio";
            cboConsultorio.Size = new Size(320, 25);
            cboConsultorio.TabIndex = 10;

            // ==========================================
            // FILA 4: DURACIÓN Y BOTÓN CREAR
            // ==========================================
            // lblDuracion (X = 23, 3 puntos menos que txtDuracion en 26)
            lblDuracion.AutoSize = true;
            lblDuracion.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblDuracion.ForeColor = Color.FromArgb(40, 40, 40);
            lblDuracion.Location = new Point(23, 276);
            lblDuracion.Name = "lblDuracion";
            lblDuracion.Size = new Size(155, 17);
            lblDuracion.Text = "Duración consulta (min)";

            txtDuracion.BackColor = Color.FromArgb(240, 242, 245);
            txtDuracion.BorderStyle = BorderStyle.FixedSingle;
            txtDuracion.Font = new Font("Segoe UI", 10F);
            txtDuracion.Location = new Point(26, 296);
            txtDuracion.Name = "txtDuracion";
            txtDuracion.PlaceholderText = "Automático según profesional";
            txtDuracion.ReadOnly = true;
            txtDuracion.Size = new Size(320, 25);
            txtDuracion.TabIndex = 12;
            txtDuracion.TabStop = false;

            // btnCrear (Alineado simétricamente en la columna derecha de la duración)
            btnCrear.BackColor = colorPrincipal;
            btnCrear.FlatAppearance.BorderSize = 0;
            btnCrear.FlatStyle = FlatStyle.Flat;
            btnCrear.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCrear.ForeColor = Color.White;
            btnCrear.Location = new Point(364, 278);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(320, 42);
            btnCrear.TabIndex = 14;
            btnCrear.Text = "📅 Crear agenda";
            btnCrear.UseVisualStyleBackColor = false;
            btnCrear.Click += btnCrear_Click;

            // ==========================================
            // FOOTER: NOTA INFORMATIVA Y BOTÓN SALIR
            // ==========================================
            // lblNota (Recuadro achicado, texto estructurado abajo para dar espacio)
            lblNota.BackColor = Color.FromArgb(230, 247, 245);
            lblNota.BorderStyle = BorderStyle.None;
            lblNota.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            lblNota.ForeColor = Color.FromArgb(0, 100, 90);
            lblNota.Location = new Point(26, 345);
            lblNota.Name = "lblNota";
            lblNota.Padding = new Padding(10, 6, 10, 6);
            lblNota.Size = new Size(500, 42); // Más angosto para que el texto salte de línea de forma natural
            lblNota.TabIndex = 13;
            lblNota.Text = "ℹ  La duración se establece automáticamente según la\n    especialidad del profesional seleccionado.";

            // btnSalir (Botón "Cancelar/Salir" ubicado al costado derecho de la nota)
            btnSalir.BackColor = Color.White;
            btnSalir.FlatAppearance.BorderColor = Color.FromArgb(210, 210, 210);
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnSalir.ForeColor = Color.FromArgb(100, 100, 100);
            btnSalir.Location = new Point(544, 348);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(140, 35);
            btnSalir.TabIndex = 16;
            btnSalir.Text = "🚪 Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;

            // btnLimpiar (Preservado oculto por compatibilidad con tus eventos internos)
            btnLimpiar.Location = new Point(0, 0);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(0, 0);
            btnLimpiar.TabIndex = 15;
            btnLimpiar.Visible = false;

            // 
            // FormCrearAgendaMedica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(710, 445); // Formulario mucho más compacto y elegante
            ControlBox = false;
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCrear);
            Controls.Add(lblNota);
            Controls.Add(txtDuracion);
            Controls.Add(lblDuracion);
            Controls.Add(cboConsultorio);
            Controls.Add(lblConsultorio);
            Controls.Add(cboProfesional);
            Controls.Add(lblProfesional);
            Controls.Add(dtpHoraHasta);
            Controls.Add(lblHoraHasta);
            Controls.Add(dtpHoraDesde);
            Controls.Add(lblHoraDesde);
            Controls.Add(dtpFecha);
            Controls.Add(lblFecha);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCrearAgendaMedica";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Crear Agenda Médica - Sistema SEPRISE";
            Load += FormCrearAgendaMedica_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Panel pnlHeader;
        private Label lblSubtitulo;
        private Label lblTitulo;
        private Label lblFecha;
        private DateTimePicker dtpFecha;
        private Label lblHoraDesde;
        private DateTimePicker dtpHoraDesde;
        private Label lblHoraHasta;
        private DateTimePicker dtpHoraHasta;
        private Label lblProfesional;
        private ComboBox cboProfesional;
        private Label lblConsultorio;
        private ComboBox cboConsultorio;
        private Label lblDuracion;
        private TextBox txtDuracion;
        private Label lblNota;
        private Button btnCrear;
        private Button btnLimpiar;
        private Button btnSalir;
    }
}