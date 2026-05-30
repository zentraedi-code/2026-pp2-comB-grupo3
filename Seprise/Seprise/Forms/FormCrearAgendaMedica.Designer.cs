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
            pnlNota = new Panel();
            lblNota = new Label();
            btnCrear = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            pnlNota.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(26, 22);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(158, 15);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "CU04 - Crear agenda médica";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.Location = new Point(26, 56);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(788, 38);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Asignación de fecha, rango horario, profesional, consultorio y duración de consulta.";
            lblSubtitulo.Click += lblSubtitulo_Click;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(26, 105);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(38, 15);
            lblFecha.TabIndex = 2;
            lblFecha.Text = "Fecha";
            // 
            // dtpFecha
            // 
            dtpFecha.CustomFormat = "dd/MM/yyyy";
            dtpFecha.Format = DateTimePickerFormat.Custom;
            dtpFecha.Location = new Point(26, 122);
            dtpFecha.Margin = new Padding(3, 2, 3, 2);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(307, 23);
            dtpFecha.TabIndex = 3;
            // 
            // lblHoraDesde
            // 
            lblHoraDesde.AutoSize = true;
            lblHoraDesde.Location = new Point(26, 158);
            lblHoraDesde.Name = "lblHoraDesde";
            lblHoraDesde.Size = new Size(67, 15);
            lblHoraDesde.TabIndex = 6;
            lblHoraDesde.Text = "Hora desde";
            // 
            // dtpHoraDesde
            // 
            dtpHoraDesde.Format = DateTimePickerFormat.Custom;
            dtpHoraDesde.CustomFormat = "HH:mm";
            dtpHoraDesde.ShowUpDown = true;
            dtpHoraDesde.Location = new Point(26, 175);
            dtpHoraDesde.Margin = new Padding(3, 2, 3, 2);
            dtpHoraDesde.Name = "dtpHoraDesde";
            dtpHoraDesde.Size = new Size(307, 23);
            dtpHoraDesde.TabIndex = 7;
            // 
            // lblHoraHasta
            // 
            lblHoraHasta.AutoSize = true;
            lblHoraHasta.Location = new Point(368, 158);
            lblHoraHasta.Name = "lblHoraHasta";
            lblHoraHasta.Size = new Size(64, 15);
            lblHoraHasta.TabIndex = 8;
            lblHoraHasta.Text = "Hora hasta";
            // 
            // dtpHoraHasta
            // 
            dtpHoraHasta.Format = DateTimePickerFormat.Custom;
            dtpHoraHasta.CustomFormat = "HH:mm";
            dtpHoraHasta.ShowUpDown = true;
            dtpHoraHasta.Location = new Point(368, 175);
            dtpHoraHasta.Margin = new Padding(3, 2, 3, 2);
            dtpHoraHasta.Name = "dtpHoraHasta";
            dtpHoraHasta.Size = new Size(307, 23);
            dtpHoraHasta.TabIndex = 9;
            // 
            // lblProfesional
            // 
            lblProfesional.AutoSize = true;
            lblProfesional.Location = new Point(26, 210);
            lblProfesional.Name = "lblProfesional";
            lblProfesional.Size = new Size(66, 15);
            lblProfesional.TabIndex = 10;
            lblProfesional.Text = "Profesional";
            // 
            // cboProfesional
            // 
            cboProfesional.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProfesional.FormattingEnabled = true;

            cboProfesional.Location = new Point(26, 227);
            cboProfesional.Margin = new Padding(3, 2, 3, 2);
            cboProfesional.Name = "cboProfesional";
            cboProfesional.Size = new Size(307, 23);
            cboProfesional.TabIndex = 11;
            cboProfesional.SelectedIndexChanged += cboProfesional_SelectedIndexChanged;
            // 
            // lblConsultorio
            // 
            lblConsultorio.AutoSize = true;
            lblConsultorio.Location = new Point(368, 210);
            lblConsultorio.Name = "lblConsultorio";
            lblConsultorio.Size = new Size(69, 15);
            lblConsultorio.TabIndex = 12;
            lblConsultorio.Text = "Consultorio";
            // 
            // cboConsultorio
            // 
            cboConsultorio.DropDownStyle = ComboBoxStyle.DropDownList;
            cboConsultorio.FormattingEnabled = true;
            cboConsultorio.Items.AddRange(new object[] { "Consultorio 1", "Consultorio 2", "Consultorio 3", "Consultorio 4" });
            cboConsultorio.Location = new Point(368, 227);
            cboConsultorio.Margin = new Padding(3, 2, 3, 2);
            cboConsultorio.Name = "cboConsultorio";
            cboConsultorio.Size = new Size(307, 23);
            cboConsultorio.TabIndex = 13;
            // 
            // lblDuracion
            // 
            lblDuracion.AutoSize = true;
            lblDuracion.Location = new Point(26, 262);
            lblDuracion.Name = "lblDuracion";
            lblDuracion.Size = new Size(103, 15);
            lblDuracion.TabIndex = 14;
            lblDuracion.Text = "Duración consulta";
            // 
            // txtDuracion
            // 
            txtDuracion.Location = new Point(26, 280);
            txtDuracion.Margin = new Padding(3, 2, 3, 2);
            txtDuracion.Name = "txtDuracion";
            txtDuracion.PlaceholderText = "Mínimo según especialidad";
            txtDuracion.Size = new Size(307, 23);
            txtDuracion.TabIndex = 15;
            // 
            // pnlNota
            // 
            pnlNota.BorderStyle = BorderStyle.FixedSingle;
            pnlNota.Controls.Add(lblNota);
            pnlNota.Location = new Point(26, 315);
            pnlNota.Margin = new Padding(3, 2, 3, 2);
            pnlNota.Name = "pnlNota";
            pnlNota.Size = new Size(648, 46);
            pnlNota.TabIndex = 18;
            // 
            // lblNota
            // 
            lblNota.Location = new Point(9, 8);
            lblNota.Name = "lblNota";
            lblNota.Size = new Size(630, 30);
            lblNota.TabIndex = 0;
            lblNota.Text = "Validación: la duración no debe ser menor a la duración mínima configurada para la especialidad.";
            // 
            // btnCrear
            // 
            btnCrear.BackColor = Color.FromArgb(47, 143, 85);
            btnCrear.FlatAppearance.BorderSize = 0;
            btnCrear.FlatStyle = FlatStyle.Flat;
            btnCrear.ForeColor = Color.White;
            btnCrear.Location = new Point(26, 375);
            btnCrear.Margin = new Padding(3, 2, 3, 2);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(131, 26);
            btnCrear.TabIndex = 19;
            btnCrear.Text = "Crear agenda";
            btnCrear.UseVisualStyleBackColor = false;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(47, 143, 85);
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(175, 375);
            btnLimpiar.Margin = new Padding(3, 2, 3, 2);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(105, 26);
            btnLimpiar.TabIndex = 20;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(47, 143, 85);
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(586, 375);
            btnSalir.Margin = new Padding(3, 2, 3, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(88, 26);
            btnSalir.TabIndex = 21;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // FormCrearAgendaMedica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 420);
            ControlBox = false;
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCrear);
            Controls.Add(pnlNota);
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
            Controls.Add(lblSubtitulo);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCrearAgendaMedica";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Crear Agenda Médica - Sistema SEPRISE";
            Load += FormCrearAgendaMedica_Load;
            pnlNota.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblTitulo;
        private Label lblSubtitulo;
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
        private Panel pnlNota;
        private Label lblNota;
        private Button btnCrear;
        private Button btnLimpiar;
        private Button btnSalir;
    }
}
