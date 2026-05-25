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
            lblDia = new Label();
            cboDia = new ComboBox();
            lblHoraDesde = new Label();
            txtHoraDesde = new TextBox();
            lblHoraHasta = new Label();
            txtHoraHasta = new TextBox();
            lblProfesional = new Label();
            cboProfesional = new ComboBox();
            lblConsultorio = new Label();
            cboConsultorio = new ComboBox();
            lblDuracion = new Label();
            txtDuracion = new TextBox();
            lblEstado = new Label();
            txtEstado = new TextBox();
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
            lblTitulo.Location = new Point(30, 30);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "CU04 - Crear agenda médica";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.Location = new Point(30, 75);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(900, 50);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Asignación de fecha, rango horario, día, profesional, consultorio y duración de consulta.";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(30, 140);
            lblFecha.Name = "lblFecha";
            lblFecha.TabIndex = 2;
            lblFecha.Text = "Fecha";
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(30, 163);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(350, 27);
            dtpFecha.TabIndex = 3;
            // 
            // lblDia
            // 
            lblDia.AutoSize = true;
            lblDia.Location = new Point(420, 140);
            lblDia.Name = "lblDia";
            lblDia.TabIndex = 4;
            lblDia.Text = "Día";
            // 
            // cboDia
            // 
            cboDia.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDia.FormattingEnabled = true;
            cboDia.Items.AddRange(new object[] { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" });
            cboDia.Location = new Point(420, 163);
            cboDia.Name = "cboDia";
            cboDia.Size = new Size(350, 28);
            cboDia.TabIndex = 5;
            // 
            // lblHoraDesde
            // 
            lblHoraDesde.AutoSize = true;
            lblHoraDesde.Location = new Point(30, 210);
            lblHoraDesde.Name = "lblHoraDesde";
            lblHoraDesde.TabIndex = 6;
            lblHoraDesde.Text = "Hora desde";
            // 
            // txtHoraDesde
            // 
            txtHoraDesde.Location = new Point(30, 233);
            txtHoraDesde.Name = "txtHoraDesde";
            txtHoraDesde.PlaceholderText = "08:00";
            txtHoraDesde.Size = new Size(350, 27);
            txtHoraDesde.TabIndex = 7;
            // 
            // lblHoraHasta
            // 
            lblHoraHasta.AutoSize = true;
            lblHoraHasta.Location = new Point(420, 210);
            lblHoraHasta.Name = "lblHoraHasta";
            lblHoraHasta.TabIndex = 8;
            lblHoraHasta.Text = "Hora hasta";
            // 
            // txtHoraHasta
            // 
            txtHoraHasta.Location = new Point(420, 233);
            txtHoraHasta.Name = "txtHoraHasta";
            txtHoraHasta.PlaceholderText = "17:00";
            txtHoraHasta.Size = new Size(350, 27);
            txtHoraHasta.TabIndex = 9;
            // 
            // lblProfesional
            // 
            lblProfesional.AutoSize = true;
            lblProfesional.Location = new Point(30, 280);
            lblProfesional.Name = "lblProfesional";
            lblProfesional.TabIndex = 10;
            lblProfesional.Text = "Profesional";
            // 
            // cboProfesional
            // 
            cboProfesional.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProfesional.FormattingEnabled = true;
            cboProfesional.Items.AddRange(new object[] { "Dra. Gómez Laura - Clínica médica", "Dr. Martínez Carlos - Cardiología", "Dra. Fernández Ana - Pediatría" });
            cboProfesional.Location = new Point(30, 303);
            cboProfesional.Name = "cboProfesional";
            cboProfesional.Size = new Size(350, 28);
            cboProfesional.TabIndex = 11;
            // 
            // lblConsultorio
            // 
            lblConsultorio.AutoSize = true;
            lblConsultorio.Location = new Point(420, 280);
            lblConsultorio.Name = "lblConsultorio";
            lblConsultorio.TabIndex = 12;
            lblConsultorio.Text = "Consultorio";
            // 
            // cboConsultorio
            // 
            cboConsultorio.DropDownStyle = ComboBoxStyle.DropDownList;
            cboConsultorio.FormattingEnabled = true;
            cboConsultorio.Items.AddRange(new object[] { "Consultorio 1", "Consultorio 2", "Consultorio 3", "Consultorio 4" });
            cboConsultorio.Location = new Point(420, 303);
            cboConsultorio.Name = "cboConsultorio";
            cboConsultorio.Size = new Size(350, 28);
            cboConsultorio.TabIndex = 13;
            // 
            // lblDuracion
            // 
            lblDuracion.AutoSize = true;
            lblDuracion.Location = new Point(30, 350);
            lblDuracion.Name = "lblDuracion";
            lblDuracion.TabIndex = 14;
            lblDuracion.Text = "Duración consulta";
            // 
            // txtDuracion
            // 
            txtDuracion.Location = new Point(30, 373);
            txtDuracion.Name = "txtDuracion";
            txtDuracion.PlaceholderText = "Mínimo según especialidad";
            txtDuracion.Size = new Size(350, 27);
            txtDuracion.TabIndex = 15;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(420, 350);
            lblEstado.Name = "lblEstado";
            lblEstado.TabIndex = 16;
            lblEstado.Text = "Estado";
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(420, 373);
            txtEstado.Name = "txtEstado";
            txtEstado.ReadOnly = true;
            txtEstado.Size = new Size(350, 27);
            txtEstado.TabIndex = 17;
            // 
            // pnlNota
            // 
            pnlNota.BorderStyle = BorderStyle.FixedSingle;
            pnlNota.Controls.Add(lblNota);
            pnlNota.Location = new Point(30, 420);
            pnlNota.Name = "pnlNota";
            pnlNota.Size = new Size(740, 60);
            pnlNota.TabIndex = 18;
            // 
            // lblNota
            // 
            lblNota.Location = new Point(10, 10);
            lblNota.Name = "lblNota";
            lblNota.Size = new Size(720, 40);
            lblNota.TabIndex = 0;
            lblNota.Text = "Validación: la duración no debe ser menor a la duración mínima configurada para la especialidad.";
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(30, 500);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(150, 35);
            btnCrear.TabIndex = 19;
            btnCrear.Text = "Crear agenda";
            btnCrear.BackColor = Color.FromArgb(47, 143, 85);
            btnCrear.FlatStyle = FlatStyle.Flat;
            btnCrear.FlatAppearance.BorderSize = 0;
            btnCrear.ForeColor = Color.White;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(200, 500);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(120, 35);
            btnLimpiar.TabIndex = 20;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.BackColor = Color.FromArgb(47, 143, 85);
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(670, 500);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(100, 35);
            btnSalir.TabIndex = 21;
            btnSalir.Text = "Salir";
            btnSalir.BackColor = Color.FromArgb(47, 143, 85);
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.ForeColor = Color.White;
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // FormCrearAgendaMedica
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 560);
            ControlBox = false;
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCrear);
            Controls.Add(pnlNota);
            Controls.Add(txtEstado);
            Controls.Add(lblEstado);
            Controls.Add(txtDuracion);
            Controls.Add(lblDuracion);
            Controls.Add(cboConsultorio);
            Controls.Add(lblConsultorio);
            Controls.Add(cboProfesional);
            Controls.Add(lblProfesional);
            Controls.Add(txtHoraHasta);
            Controls.Add(lblHoraHasta);
            Controls.Add(txtHoraDesde);
            Controls.Add(lblHoraDesde);
            Controls.Add(cboDia);
            Controls.Add(lblDia);
            Controls.Add(dtpFecha);
            Controls.Add(lblFecha);
            Controls.Add(lblSubtitulo);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCrearAgendaMedica";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Crear Agenda Médica - Sistema SEPRISE";
            pnlNota.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblTitulo;
        private Label lblSubtitulo;
        private Label lblFecha;
        private DateTimePicker dtpFecha;
        private Label lblDia;
        private ComboBox cboDia;
        private Label lblHoraDesde;
        private TextBox txtHoraDesde;
        private Label lblHoraHasta;
        private TextBox txtHoraHasta;
        private Label lblProfesional;
        private ComboBox cboProfesional;
        private Label lblConsultorio;
        private ComboBox cboConsultorio;
        private Label lblDuracion;
        private TextBox txtDuracion;
        private Label lblEstado;
        private TextBox txtEstado;
        private Panel pnlNota;
        private Label lblNota;
        private Button btnCrear;
        private Button btnLimpiar;
        private Button btnSalir;
    }
}
