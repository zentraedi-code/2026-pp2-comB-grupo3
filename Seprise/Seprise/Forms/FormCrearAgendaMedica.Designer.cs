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
            pnlFormCard = new Panel(); 
            lblSeccionDatos = new Label();
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
            btnCrear = new Button();
            lblNota = new Label();
            btnSalir = new Button();
            btnLimpiar = new Button();
            pnlHeader.SuspendLayout();
            pnlFormCard.SuspendLayout();
            SuspendLayout();

            Color colorPrincipal = Color.FromArgb(0, 150, 136);

            pnlHeader.BackColor = colorPrincipal;
            pnlHeader.Controls.Add(lblTitulo);
            pnlHeader.Controls.Add(lblSubtitulo);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(740, 85);
            pnlHeader.TabIndex = 0;

            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(24, 15);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(280, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "📅   Crear agenda médica";

            lblSubtitulo.AutoSize = true;
            lblSubtitulo.BackColor = Color.Transparent;
            lblSubtitulo.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            lblSubtitulo.ForeColor = Color.FromArgb(204, 242, 239);
            lblSubtitulo.Location = new Point(26, 48);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(280, 17);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Complete los datos para crear una nueva agenda.";

            pnlFormCard.BackColor = Color.White;
            pnlFormCard.Location = new Point(20, 105);
            pnlFormCard.Name = "pnlFormCard";
            pnlFormCard.Size = new Size(700, 275);
            pnlFormCard.TabIndex = 1;

            lblSeccionDatos.AutoSize = true;
            lblSeccionDatos.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblSeccionDatos.ForeColor = colorPrincipal;
            lblSeccionDatos.Location = new Point(17, 12);
            lblSeccionDatos.Name = "lblSeccionDatos";
            lblSeccionDatos.Size = new Size(150, 17);
            lblSeccionDatos.Text = "📝 DATOS DE LA AGENDA";

            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblFecha.ForeColor = Color.FromArgb(60, 60, 60);
            lblFecha.Location = new Point(17, 42); 
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(43, 17);
            lblFecha.Text = "Fecha";

            dtpFecha.CustomFormat = "dd/MM/yyyy";
            dtpFecha.Font = new Font("Segoe UI", 10F);
            dtpFecha.Format = DateTimePickerFormat.Custom;
            dtpFecha.Location = new Point(20, 62);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(315, 25);
            dtpFecha.TabIndex = 2;

            lblHoraDesde.AutoSize = true;
            lblHoraDesde.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblHoraDesde.ForeColor = Color.FromArgb(60, 60, 60);
            lblHoraDesde.Location = new Point(17, 100);
            lblHoraDesde.Name = "lblHoraDesde";
            lblHoraDesde.Size = new Size(77, 17);
            lblHoraDesde.Text = "Hora desde";

            dtpHoraDesde.CustomFormat = "HH:mm";
            dtpHoraDesde.Font = new Font("Segoe UI", 10F);
            dtpHoraDesde.Format = DateTimePickerFormat.Custom;
            dtpHoraDesde.Location = new Point(20, 120);
            dtpHoraDesde.Name = "dtpHoraDesde";
            dtpHoraDesde.ShowUpDown = true;
            dtpHoraDesde.Size = new Size(315, 25);
            dtpHoraDesde.TabIndex = 4;

            lblHoraHasta.AutoSize = true;
            lblHoraHasta.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblHoraHasta.ForeColor = Color.FromArgb(60, 60, 60);
            lblHoraHasta.Location = new Point(357, 100); 
            lblHoraHasta.Name = "lblHoraHasta";
            lblHoraHasta.Size = new Size(73, 17);
            lblHoraHasta.Text = "Hora hasta";

            dtpHoraHasta.CustomFormat = "HH:mm";
            dtpHoraHasta.Font = new Font("Segoe UI", 10F);
            dtpHoraHasta.Format = DateTimePickerFormat.Custom;
            dtpHoraHasta.Location = new Point(360, 120);
            dtpHoraHasta.Name = "dtpHoraHasta";
            dtpHoraHasta.ShowUpDown = true;
            dtpHoraHasta.Size = new Size(315, 25);
            dtpHoraHasta.TabIndex = 6;

            lblProfesional.AutoSize = true;
            lblProfesional.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblProfesional.ForeColor = Color.FromArgb(60, 60, 60);
            lblProfesional.Location = new Point(17, 158);
            lblProfesional.Name = "lblProfesional";
            lblProfesional.Size = new Size(77, 17);
            lblProfesional.Text = "Profesional";

            cboProfesional.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProfesional.Font = new Font("Segoe UI", 10F);
            cboProfesional.FormattingEnabled = true;
            cboProfesional.Location = new Point(20, 178);
            cboProfesional.Name = "cboProfesional";
            cboProfesional.Size = new Size(315, 25);
            cboProfesional.TabIndex = 8;
            cboProfesional.SelectedIndexChanged += cboProfesional_SelectedIndexChanged;

            lblConsultorio.AutoSize = true;
            lblConsultorio.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblConsultorio.ForeColor = Color.FromArgb(60, 60, 60);
            lblConsultorio.Location = new Point(357, 158);
            lblConsultorio.Name = "lblConsultorio";
            lblConsultorio.Size = new Size(79, 17);
            lblConsultorio.Text = "Consultorio";

            cboConsultorio.DropDownStyle = ComboBoxStyle.DropDownList;
            cboConsultorio.Font = new Font("Segoe UI", 10F);
            cboConsultorio.FormattingEnabled = true;
            cboConsultorio.Location = new Point(360, 178);
            cboConsultorio.Name = "cboConsultorio";
            cboConsultorio.Size = new Size(315, 25);
            cboConsultorio.TabIndex = 10;

            lblDuracion.AutoSize = true;
            lblDuracion.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblDuracion.ForeColor = Color.FromArgb(60, 60, 60);
            lblDuracion.Location = new Point(17, 216);
            lblDuracion.Name = "lblDuracion";
            lblDuracion.Size = new Size(155, 17);
            lblDuracion.Text = "Duración consulta (min)";

            txtDuracion.BackColor = Color.FromArgb(240, 242, 245);
            txtDuracion.BorderStyle = BorderStyle.FixedSingle;
            txtDuracion.Font = new Font("Segoe UI", 10F);
            txtDuracion.Location = new Point(20, 236);
            txtDuracion.Name = "txtDuracion";
            txtDuracion.PlaceholderText = "Automático según profesional";
            txtDuracion.ReadOnly = true;
            txtDuracion.Size = new Size(315, 25);
            txtDuracion.TabIndex = 12;
            txtDuracion.TabStop = false;

            btnCrear.BackColor = colorPrincipal;
            btnCrear.FlatAppearance.BorderSize = 0;
            btnCrear.FlatStyle = FlatStyle.Flat;
            btnCrear.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCrear.ForeColor = Color.White;
            btnCrear.Location = new Point(360, 225);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(315, 36);
            btnCrear.TabIndex = 14;
            btnCrear.Text = "📅 Crear agenda";
            btnCrear.UseVisualStyleBackColor = false;
            btnCrear.Click += btnCrear_Click;

            pnlFormCard.Controls.Add(lblSeccionDatos);
            pnlFormCard.Controls.Add(lblFecha);
            pnlFormCard.Controls.Add(dtpFecha);
            pnlFormCard.Controls.Add(lblHoraDesde);
            pnlFormCard.Controls.Add(dtpHoraDesde);
            pnlFormCard.Controls.Add(lblHoraHasta);
            pnlFormCard.Controls.Add(dtpHoraHasta);
            pnlFormCard.Controls.Add(lblProfesional);
            pnlFormCard.Controls.Add(cboProfesional);
            pnlFormCard.Controls.Add(lblConsultorio);
            pnlFormCard.Controls.Add(cboConsultorio);
            pnlFormCard.Controls.Add(lblDuracion);
            pnlFormCard.Controls.Add(txtDuracion);
            pnlFormCard.Controls.Add(btnCrear);

            lblNota.BackColor = Color.FromArgb(198, 234, 212);
            lblNota.BorderStyle = BorderStyle.None;
            lblNota.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            lblNota.ForeColor = Color.FromArgb(0, 75, 68); 
            lblNota.Location = new Point(20, 395);
            lblNota.Name = "lblNota";
            lblNota.Padding = new Padding(12, 8, 12, 8);
            lblNota.Size = new Size(500, 45);
            lblNota.TabIndex = 13;
            lblNota.Text = "ℹ   La duración se establece automáticamente según la\r\n    especialidad del profesional seleccionado.";

            btnSalir.BackColor = Color.White;
            btnSalir.FlatAppearance.BorderColor = Color.FromArgb(210, 210, 210);
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnSalir.ForeColor = Color.FromArgb(100, 100, 100);
            btnSalir.Location = new Point(540, 400);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(180, 35);
            btnSalir.TabIndex = 16;
            btnSalir.Text = "🚪 Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;

            btnLimpiar.Location = new Point(0, 0);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(0, 0);
            btnLimpiar.TabIndex = 15;
            btnLimpiar.Visible = false;

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(238, 242, 245); 
            ClientSize = new Size(750, 495);
            ControlBox = false;
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(lblNota);
            Controls.Add(pnlFormCard);
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
            pnlFormCard.ResumeLayout(false);
            pnlFormCard.PerformLayout();
            ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlFormCard; 
        private System.Windows.Forms.Label lblSeccionDatos;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblHoraDesde;
        private System.Windows.Forms.DateTimePicker dtpHoraDesde;
        private System.Windows.Forms.Label lblHoraHasta;
        private System.Windows.Forms.DateTimePicker dtpHoraHasta;
        private System.Windows.Forms.Label lblProfesional;
        private System.Windows.Forms.ComboBox cboProfesional;
        private System.Windows.Forms.Label lblConsultorio;
        private System.Windows.Forms.ComboBox cboConsultorio;
        private System.Windows.Forms.Label lblDuracion;
        private System.Windows.Forms.TextBox txtDuracion;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
    }
}