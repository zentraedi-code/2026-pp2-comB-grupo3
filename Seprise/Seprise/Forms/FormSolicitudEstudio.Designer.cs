namespace Seprise
{
    partial class FormSolicitudEstudio
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblDniPaciente;
        private System.Windows.Forms.TextBox txtDniPaciente;
        private System.Windows.Forms.Button btnBuscarPaciente;
        private System.Windows.Forms.Label lblPaciente;
        private System.Windows.Forms.TextBox txtPaciente;
        private System.Windows.Forms.Label lblTipoEstudio;
        private System.Windows.Forms.ComboBox cmbTipoEstudio;
        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.ComboBox cmbOrigen;
        private System.Windows.Forms.Label lblFechaSolicitud;
        private System.Windows.Forms.DateTimePicker dtpFechaSolicitud;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblNota;

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
            this.lblDniPaciente = new System.Windows.Forms.Label();
            this.txtDniPaciente = new System.Windows.Forms.TextBox();
            this.btnBuscarPaciente = new System.Windows.Forms.Button();
            this.lblPaciente = new System.Windows.Forms.Label();
            this.txtPaciente = new System.Windows.Forms.TextBox();
            this.lblTipoEstudio = new System.Windows.Forms.Label();
            this.cmbTipoEstudio = new System.Windows.Forms.ComboBox();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.cmbOrigen = new System.Windows.Forms.ComboBox();
            this.lblFechaSolicitud = new System.Windows.Forms.Label();
            this.dtpFechaSolicitud = new System.Windows.Forms.DateTimePicker();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblNota = new System.Windows.Forms.Label();
            this.SuspendLayout();

            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(20, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "CU02 - Crear solicitud de estudio";

            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Location = new System.Drawing.Point(20, 50);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Solicitud común para consultorios externos, guardia, internación, laboratorio o externo.";

            this.lblDniPaciente.AutoSize = true;
            this.lblDniPaciente.Location = new System.Drawing.Point(20, 90);
            this.lblDniPaciente.Name = "lblDniPaciente";
            this.lblDniPaciente.Size = new System.Drawing.Size(95, 15);
            this.lblDniPaciente.TabIndex = 2;
            this.lblDniPaciente.Text = "DNI del paciente";

            this.txtDniPaciente.Location = new System.Drawing.Point(20, 110);
            this.txtDniPaciente.Name = "txtDniPaciente";
            this.txtDniPaciente.PlaceholderText = "Ej: 30111222";
            this.txtDniPaciente.Size = new System.Drawing.Size(200, 23);
            this.txtDniPaciente.TabIndex = 3;

            this.btnBuscarPaciente.Location = new System.Drawing.Point(230, 110);
            this.btnBuscarPaciente.Name = "btnBuscarPaciente";
            this.btnBuscarPaciente.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarPaciente.TabIndex = 4;
            this.btnBuscarPaciente.Text = "🔍 Buscar";
            this.btnBuscarPaciente.UseVisualStyleBackColor = true;
            this.btnBuscarPaciente.Click += new System.EventHandler(this.btnBuscarPaciente_Click);

            this.lblPaciente.AutoSize = true;
            this.lblPaciente.Location = new System.Drawing.Point(320, 90);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Size = new System.Drawing.Size(52, 15);
            this.lblPaciente.TabIndex = 5;
            this.lblPaciente.Text = "Paciente";

            this.txtPaciente.Enabled = false;
            this.txtPaciente.Location = new System.Drawing.Point(320, 110);
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.Size = new System.Drawing.Size(300, 23);
            this.txtPaciente.TabIndex = 6;

            this.lblTipoEstudio.AutoSize = true;
            this.lblTipoEstudio.Location = new System.Drawing.Point(20, 150);
            this.lblTipoEstudio.Name = "lblTipoEstudio";
            this.lblTipoEstudio.Size = new System.Drawing.Size(86, 15);
            this.lblTipoEstudio.TabIndex = 7;
            this.lblTipoEstudio.Text = "Tipo de estudio";

            this.cmbTipoEstudio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoEstudio.FormattingEnabled = true;
            this.cmbTipoEstudio.Location = new System.Drawing.Point(20, 170);
            this.cmbTipoEstudio.Name = "cmbTipoEstudio";
            this.cmbTipoEstudio.Size = new System.Drawing.Size(285, 23);
            this.cmbTipoEstudio.TabIndex = 8;

            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Location = new System.Drawing.Point(335, 150);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(43, 15);
            this.lblOrigen.TabIndex = 9;
            this.lblOrigen.Text = "Origen";

            this.cmbOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrigen.FormattingEnabled = true;
            this.cmbOrigen.Location = new System.Drawing.Point(335, 170);
            this.cmbOrigen.Name = "cmbOrigen";
            this.cmbOrigen.Size = new System.Drawing.Size(285, 23);
            this.cmbOrigen.TabIndex = 10;

            this.lblFechaSolicitud.AutoSize = true;
            this.lblFechaSolicitud.Location = new System.Drawing.Point(20, 210);
            this.lblFechaSolicitud.Name = "lblFechaSolicitud";
            this.lblFechaSolicitud.Size = new System.Drawing.Size(105, 15);
            this.lblFechaSolicitud.TabIndex = 11;
            this.lblFechaSolicitud.Text = "Fecha de solicitud";

            this.dtpFechaSolicitud.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaSolicitud.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaSolicitud.Location = new System.Drawing.Point(20, 230);
            this.dtpFechaSolicitud.Name = "dtpFechaSolicitud";
            this.dtpFechaSolicitud.Size = new System.Drawing.Size(285, 23);
            this.dtpFechaSolicitud.TabIndex = 12;

            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Location = new System.Drawing.Point(20, 270);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(87, 15);
            this.lblObservaciones.TabIndex = 13;
            this.lblObservaciones.Text = "Observaciones";

            this.txtObservaciones.Location = new System.Drawing.Point(20, 290);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservaciones.Size = new System.Drawing.Size(600, 80);
            this.txtObservaciones.TabIndex = 14;

            this.btnCrear.Location = new System.Drawing.Point(20, 390);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(120, 30);
            this.btnCrear.TabIndex = 15;
            this.btnCrear.Text = "Crear solicitud";
            this.btnCrear.BackColor = System.Drawing.Color.FromArgb(47, 143, 85);
            this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrear.FlatAppearance.BorderSize = 0;
            this.btnCrear.ForeColor = System.Drawing.Color.White;
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);

            this.btnLimpiar.Location = new System.Drawing.Point(150, 390);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 30);
            this.btnLimpiar.TabIndex = 16;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(47, 143, 85);
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);

            this.lblNota.AutoSize = true;
            this.lblNota.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblNota.Location = new System.Drawing.Point(20, 430);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(200, 15);
            this.lblNota.TabIndex = 17;
            this.lblNota.Text = "Estado inicial sugerido: PENDIENTE.";

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 470);
            this.Controls.Add(this.lblNota);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.lblObservaciones);
            this.Controls.Add(this.dtpFechaSolicitud);
            this.Controls.Add(this.lblFechaSolicitud);
            this.Controls.Add(this.cmbOrigen);
            this.Controls.Add(this.lblOrigen);
            this.Controls.Add(this.cmbTipoEstudio);
            this.Controls.Add(this.lblTipoEstudio);
            this.Controls.Add(this.txtPaciente);
            this.Controls.Add(this.lblPaciente);
            this.Controls.Add(this.btnBuscarPaciente);
            this.Controls.Add(this.txtDniPaciente);
            this.Controls.Add(this.lblDniPaciente);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSolicitudEstudio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Crear solicitud de estudio";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
