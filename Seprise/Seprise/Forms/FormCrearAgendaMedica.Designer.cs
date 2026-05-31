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
            lblTitulo = new Label();
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
            SuspendLayout();

            lblTitulo.BackColor = Color.FromArgb(30, 107, 160);
            lblTitulo.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(700, 48);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "   Crear agenda médica";
            lblTitulo.TextAlign = ContentAlignment.MiddleLeft;

            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFecha.Location = new Point(26, 68);
            lblFecha.Name = "lblFecha";
            lblFecha.TabIndex = 1;
            lblFecha.Text = "Fecha";

            dtpFecha.CustomFormat = "dd/MM/yyyy";
            dtpFecha.Format = DateTimePickerFormat.Custom;
            dtpFecha.Location = new Point(26, 86);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(307, 23);
            dtpFecha.TabIndex = 2;

            lblHoraDesde.AutoSize = true;
            lblHoraDesde.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblHoraDesde.Location = new Point(26, 120);
            lblHoraDesde.Name = "lblHoraDesde";
            lblHoraDesde.TabIndex = 3;
            lblHoraDesde.Text = "Hora desde";

            dtpHoraDesde.Format = DateTimePickerFormat.Custom;
            dtpHoraDesde.CustomFormat = "HH:mm";
            dtpHoraDesde.ShowUpDown = true;
            dtpHoraDesde.Location = new Point(26, 138);
            dtpHoraDesde.Name = "dtpHoraDesde";
            dtpHoraDesde.Size = new Size(307, 23);
            dtpHoraDesde.TabIndex = 4;

            lblHoraHasta.AutoSize = true;
            lblHoraHasta.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblHoraHasta.Location = new Point(368, 120);
            lblHoraHasta.Name = "lblHoraHasta";
            lblHoraHasta.TabIndex = 5;
            lblHoraHasta.Text = "Hora hasta";

            dtpHoraHasta.Format = DateTimePickerFormat.Custom;
            dtpHoraHasta.CustomFormat = "HH:mm";
            dtpHoraHasta.ShowUpDown = true;
            dtpHoraHasta.Location = new Point(368, 138);
            dtpHoraHasta.Name = "dtpHoraHasta";
            dtpHoraHasta.Size = new Size(307, 23);
            dtpHoraHasta.TabIndex = 6;

            lblProfesional.AutoSize = true;
            lblProfesional.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblProfesional.Location = new Point(26, 173);
            lblProfesional.Name = "lblProfesional";
            lblProfesional.TabIndex = 7;
            lblProfesional.Text = "Profesional";

            cboProfesional.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProfesional.FormattingEnabled = true;
            cboProfesional.Location = new Point(26, 191);
            cboProfesional.Name = "cboProfesional";
            cboProfesional.Size = new Size(307, 23);
            cboProfesional.TabIndex = 8;
            cboProfesional.SelectedIndexChanged += cboProfesional_SelectedIndexChanged;

            lblConsultorio.AutoSize = true;
            lblConsultorio.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblConsultorio.Location = new Point(368, 173);
            lblConsultorio.Name = "lblConsultorio";
            lblConsultorio.TabIndex = 9;
            lblConsultorio.Text = "Consultorio";

            cboConsultorio.DropDownStyle = ComboBoxStyle.DropDownList;
            cboConsultorio.FormattingEnabled = true;
            cboConsultorio.Location = new Point(368, 191);
            cboConsultorio.Name = "cboConsultorio";
            cboConsultorio.Size = new Size(307, 23);
            cboConsultorio.TabIndex = 10;

            lblDuracion.AutoSize = true;
            lblDuracion.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDuracion.Location = new Point(26, 226);
            lblDuracion.Name = "lblDuracion";
            lblDuracion.TabIndex = 11;
            lblDuracion.Text = "Duración consulta (min)";

            txtDuracion.BackColor = SystemColors.Control;
            txtDuracion.Location = new Point(26, 244);
            txtDuracion.Name = "txtDuracion";
            txtDuracion.PlaceholderText = "Automático según profesional";
            txtDuracion.ReadOnly = true;
            txtDuracion.Size = new Size(307, 23);
            txtDuracion.TabIndex = 12;
            txtDuracion.TabStop = false;

            lblNota.BackColor = Color.FromArgb(232, 244, 248);
            lblNota.BorderStyle = BorderStyle.FixedSingle;
            lblNota.Location = new Point(26, 282);
            lblNota.Name = "lblNota";
            lblNota.Padding = new Padding(8, 6, 8, 6);
            lblNota.Size = new Size(648, 38);
            lblNota.TabIndex = 13;
            lblNota.Text = "La duración se establece automáticamente según la especialidad del profesional seleccionado.";

            btnCrear.BackColor = Color.FromArgb(30, 107, 160);
            btnCrear.FlatAppearance.BorderSize = 0;
            btnCrear.FlatStyle = FlatStyle.Flat;
            btnCrear.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCrear.ForeColor = Color.White;
            btnCrear.Location = new Point(26, 334);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(131, 32);
            btnCrear.TabIndex = 14;
            btnCrear.Text = "Crear agenda";
            btnCrear.UseVisualStyleBackColor = false;
            btnCrear.Click += btnCrear_Click;

            btnLimpiar.BackColor = Color.FromArgb(100, 149, 180);
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(170, 334);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(105, 32);
            btnLimpiar.TabIndex = 15;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;

            btnSalir.BackColor = Color.FromArgb(100, 149, 180);
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(586, 334);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(88, 32);
            btnSalir.TabIndex = 16;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 385);
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
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCrearAgendaMedica";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Crear Agenda Médica - Sistema SEPRISE";
            Load += FormCrearAgendaMedica_Load;
            ResumeLayout(false);
            PerformLayout();
        }

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
