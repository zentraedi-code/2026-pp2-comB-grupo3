namespace Seprise
{
    partial class FormGenerarHistoriaClinica
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblPaciente;
        private System.Windows.Forms.TextBox txtPaciente;
        private System.Windows.Forms.Label lblMedico;
        private System.Windows.Forms.TextBox txtMedico;
        private System.Windows.Forms.Label lblFechaAtencion;
        private System.Windows.Forms.DateTimePicker dtpFechaAtencion;
        private System.Windows.Forms.Label lblEstadoTurno;
        private System.Windows.Forms.TextBox txtEstadoTurno;
        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.Label lblDiagnostico;
        private System.Windows.Forms.TextBox txtDiagnostico;
        private System.Windows.Forms.Label lblIndicaciones;
        private System.Windows.Forms.TextBox txtIndicaciones;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnSolicitarEstudio;
        private System.Windows.Forms.DataGridView dgvEstudios;

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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblPaciente = new System.Windows.Forms.Label();
            this.txtPaciente = new System.Windows.Forms.TextBox();
            this.lblMedico = new System.Windows.Forms.Label();
            this.txtMedico = new System.Windows.Forms.TextBox();
            this.lblFechaAtencion = new System.Windows.Forms.Label();
            this.dtpFechaAtencion = new System.Windows.Forms.DateTimePicker();
            this.lblEstadoTurno = new System.Windows.Forms.Label();
            this.txtEstadoTurno = new System.Windows.Forms.TextBox();
            this.lblMotivo = new System.Windows.Forms.Label();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.lblDiagnostico = new System.Windows.Forms.Label();
            this.txtDiagnostico = new System.Windows.Forms.TextBox();
            this.lblIndicaciones = new System.Windows.Forms.Label();
            this.txtIndicaciones = new System.Windows.Forms.TextBox();
            this.lblNota = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSolicitarEstudio = new System.Windows.Forms.Button();
            this.dgvEstudios = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudios)).BeginInit();
            this.SuspendLayout();

            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(20, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Generar historia clínica";

            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Location = new System.Drawing.Point(20, 50);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "El médico atiende al paciente, registra la historia clínica y finaliza la atención.";

            this.lblPaciente.AutoSize = true;
            this.lblPaciente.Location = new System.Drawing.Point(20, 90);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Size = new System.Drawing.Size(52, 15);
            this.lblPaciente.TabIndex = 2;
            this.lblPaciente.Text = "Paciente";

            this.txtPaciente.Enabled = false;
            this.txtPaciente.Location = new System.Drawing.Point(20, 110);
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.Size = new System.Drawing.Size(250, 23);
            this.txtPaciente.TabIndex = 3;

            this.lblMedico.AutoSize = true;
            this.lblMedico.Location = new System.Drawing.Point(290, 90);
            this.lblMedico.Name = "lblMedico";
            this.lblMedico.Size = new System.Drawing.Size(47, 15);
            this.lblMedico.TabIndex = 4;
            this.lblMedico.Text = "Médico";

            this.txtMedico.Enabled = false;
            this.txtMedico.Location = new System.Drawing.Point(290, 110);
            this.txtMedico.Name = "txtMedico";
            this.txtMedico.Size = new System.Drawing.Size(250, 23);
            this.txtMedico.TabIndex = 5;

            this.lblFechaAtencion.AutoSize = true;
            this.lblFechaAtencion.Location = new System.Drawing.Point(560, 90);
            this.lblFechaAtencion.Name = "lblFechaAtencion";
            this.lblFechaAtencion.Size = new System.Drawing.Size(87, 15);
            this.lblFechaAtencion.TabIndex = 6;
            this.lblFechaAtencion.Text = "Fecha atención";

            this.dtpFechaAtencion.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpFechaAtencion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaAtencion.Location = new System.Drawing.Point(560, 110);
            this.dtpFechaAtencion.Name = "dtpFechaAtencion";
            this.dtpFechaAtencion.Size = new System.Drawing.Size(200, 23);
            this.dtpFechaAtencion.TabIndex = 7;

            this.lblEstadoTurno.AutoSize = true;
            this.lblEstadoTurno.Location = new System.Drawing.Point(780, 90);
            this.lblEstadoTurno.Name = "lblEstadoTurno";
            this.lblEstadoTurno.Size = new System.Drawing.Size(73, 15);
            this.lblEstadoTurno.TabIndex = 8;
            this.lblEstadoTurno.Text = "Estado turno";

            this.txtEstadoTurno.Enabled = false;
            this.txtEstadoTurno.Location = new System.Drawing.Point(780, 110);
            this.txtEstadoTurno.Name = "txtEstadoTurno";
            this.txtEstadoTurno.Size = new System.Drawing.Size(150, 23);
            this.txtEstadoTurno.TabIndex = 9;

            this.lblMotivo.AutoSize = true;
            this.lblMotivo.Location = new System.Drawing.Point(20, 150);
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.Size = new System.Drawing.Size(113, 15);
            this.lblMotivo.TabIndex = 10;
            this.lblMotivo.Text = "Motivo de consulta";

            this.txtMotivo.Location = new System.Drawing.Point(20, 170);
            this.txtMotivo.Multiline = true;
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.PlaceholderText = "Describe el motivo de consulta...";
            this.txtMotivo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMotivo.Size = new System.Drawing.Size(910, 70);
            this.txtMotivo.TabIndex = 11;

            this.lblDiagnostico.AutoSize = true;
            this.lblDiagnostico.Location = new System.Drawing.Point(20, 250);
            this.lblDiagnostico.Name = "lblDiagnostico";
            this.lblDiagnostico.Size = new System.Drawing.Size(140, 15);
            this.lblDiagnostico.TabIndex = 12;
            this.lblDiagnostico.Text = "Diagnóstico / evolución";

            this.txtDiagnostico.Location = new System.Drawing.Point(20, 270);
            this.txtDiagnostico.Multiline = true;
            this.txtDiagnostico.Name = "txtDiagnostico";
            this.txtDiagnostico.PlaceholderText = "Carga de historia clínica...";
            this.txtDiagnostico.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDiagnostico.Size = new System.Drawing.Size(910, 70);
            this.txtDiagnostico.TabIndex = 13;

            this.lblIndicaciones.AutoSize = true;
            this.lblIndicaciones.Location = new System.Drawing.Point(20, 350);
            this.lblIndicaciones.Name = "lblIndicaciones";
            this.lblIndicaciones.Size = new System.Drawing.Size(76, 15);
            this.lblIndicaciones.TabIndex = 14;
            this.lblIndicaciones.Text = "Indicaciones";

            this.txtIndicaciones.Location = new System.Drawing.Point(20, 370);
            this.txtIndicaciones.Multiline = true;
            this.txtIndicaciones.Name = "txtIndicaciones";
            this.txtIndicaciones.PlaceholderText = "Tratamiento, recomendaciones o medicación...";
            this.txtIndicaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtIndicaciones.Size = new System.Drawing.Size(910, 70);
            this.txtIndicaciones.TabIndex = 15;

            this.lblNota.AutoSize = true;
            this.lblNota.Location = new System.Drawing.Point(20, 450);
            this.lblNota.MaximumSize = new System.Drawing.Size(910, 0);
            this.lblNota.Name = "lblNota";
            this.lblNota.TabIndex = 16;
            this.lblNota.Text = "Desde esta pantalla el médico puede finalizar la atención directamente o generar una solicitud de estudio si lo considera necesario.";

            this.btnGuardar.Location = new System.Drawing.Point(20, 480);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(250, 30);
            this.btnGuardar.TabIndex = 17;
            this.btnGuardar.Text = "Guardar historia y finalizar atención";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);

            this.btnSolicitarEstudio.Location = new System.Drawing.Point(280, 480);
            this.btnSolicitarEstudio.Name = "btnSolicitarEstudio";
            this.btnSolicitarEstudio.Size = new System.Drawing.Size(150, 30);
            this.btnSolicitarEstudio.TabIndex = 18;
            this.btnSolicitarEstudio.Text = "Solicitar estudio";
            this.btnSolicitarEstudio.UseVisualStyleBackColor = true;
            this.btnSolicitarEstudio.Click += new System.EventHandler(this.btnSolicitarEstudio_Click);

            this.dgvEstudios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstudios.Location = new System.Drawing.Point(20, 530);
            this.dgvEstudios.Name = "dgvEstudios";
            this.dgvEstudios.RowTemplate.Height = 25;
            this.dgvEstudios.Size = new System.Drawing.Size(910, 150);
            this.dgvEstudios.TabIndex = 19;

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 700);
            this.Controls.Add(this.dgvEstudios);
            this.Controls.Add(this.btnSolicitarEstudio);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblNota);
            this.Controls.Add(this.txtIndicaciones);
            this.Controls.Add(this.lblIndicaciones);
            this.Controls.Add(this.txtDiagnostico);
            this.Controls.Add(this.lblDiagnostico);
            this.Controls.Add(this.txtMotivo);
            this.Controls.Add(this.lblMotivo);
            this.Controls.Add(this.txtEstadoTurno);
            this.Controls.Add(this.lblEstadoTurno);
            this.Controls.Add(this.dtpFechaAtencion);
            this.Controls.Add(this.lblFechaAtencion);
            this.Controls.Add(this.txtMedico);
            this.Controls.Add(this.lblMedico);
            this.Controls.Add(this.txtPaciente);
            this.Controls.Add(this.lblPaciente);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormGenerarHistoriaClinica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Generar historia clínica";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
