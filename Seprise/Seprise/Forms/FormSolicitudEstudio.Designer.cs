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
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlTarjetaContenedor;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Label lblIcono;
        private System.Windows.Forms.Label lblSeccionDatos;
        private System.Windows.Forms.Button btnCancelar; 

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

            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlTarjetaContenedor = new System.Windows.Forms.Panel();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.lblIcono = new System.Windows.Forms.Label();
            this.lblSeccionDatos = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();

            this.pnlHeader.SuspendLayout();
            this.pnlTarjetaContenedor.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();

            var colorTealSePrice = System.Drawing.Color.FromArgb(0, 150, 136);
            var colorTextoOscuro = System.Drawing.Color.FromArgb(33, 33, 33);
            var colorTextoGrisClaro = System.Drawing.Color.FromArgb(220, 240, 235);
            var colorFondoGrisForm = System.Drawing.Color.FromArgb(238, 242, 243);
            var colorNotaFondo = System.Drawing.Color.FromArgb(198, 234, 212);
            var colorNotaTexto = System.Drawing.Color.FromArgb(0, 75, 68);

            var fontTitulo = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            var fontSubtitulo = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            var fontSeccion = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            var fontLabels = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            var fontControles = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular);
            var fontBotones = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);

            this.pnlHeader.BackColor = colorTealSePrice;
            this.pnlHeader.Controls.Add(this.lblIcono);
            this.pnlHeader.Controls.Add(this.lblTitulo);
            this.pnlHeader.Controls.Add(this.lblSubtitulo);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(680, 75);
            this.pnlHeader.TabIndex = 0;

            this.lblIcono.AutoSize = true;
            this.lblIcono.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.lblIcono.ForeColor = System.Drawing.Color.White;
            this.lblIcono.Location = new System.Drawing.Point(18, 16);
            this.lblIcono.Size = new System.Drawing.Size(47, 37);
            this.lblIcono.Text = "📋";

            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = fontTitulo;
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(75, 14);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(320, 32);
            this.lblTitulo.Text = "Solicitud de Estudio";

            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = fontSubtitulo;
            this.lblSubtitulo.ForeColor = colorTextoGrisClaro;
            this.lblSubtitulo.Location = new System.Drawing.Point(77, 48);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(520, 15);
            this.lblSubtitulo.Text = "Solicitud común para consultorios externos, guardia, internación, laboratorio o externo.";

            this.pnlTarjetaContenedor.BackColor = System.Drawing.Color.White;
            this.pnlTarjetaContenedor.Controls.Add(this.lblSeccionDatos);
            this.pnlTarjetaContenedor.Controls.Add(this.lblDniPaciente);
            this.pnlTarjetaContenedor.Controls.Add(this.txtDniPaciente);
            this.pnlTarjetaContenedor.Controls.Add(this.btnBuscarPaciente);
            this.pnlTarjetaContenedor.Controls.Add(this.lblPaciente);
            this.pnlTarjetaContenedor.Controls.Add(this.txtPaciente);
            this.pnlTarjetaContenedor.Controls.Add(this.lblTipoEstudio);
            this.pnlTarjetaContenedor.Controls.Add(this.cmbTipoEstudio);
            this.pnlTarjetaContenedor.Controls.Add(this.lblOrigen);
            this.pnlTarjetaContenedor.Controls.Add(this.cmbOrigen);
            this.pnlTarjetaContenedor.Controls.Add(this.lblFechaSolicitud);
            this.pnlTarjetaContenedor.Controls.Add(this.dtpFechaSolicitud);
            this.pnlTarjetaContenedor.Controls.Add(this.lblObservaciones);
            this.pnlTarjetaContenedor.Controls.Add(this.txtObservaciones);
            this.pnlTarjetaContenedor.Controls.Add(this.btnCrear);
            this.pnlTarjetaContenedor.Location = new System.Drawing.Point(24, 95);
            this.pnlTarjetaContenedor.Name = "pnlTarjetaContenedor";
            this.pnlTarjetaContenedor.Size = new System.Drawing.Size(632, 435);
            this.pnlTarjetaContenedor.TabIndex = 1;

            this.lblSeccionDatos.AutoSize = true;
            this.lblSeccionDatos.Font = fontSeccion;
            this.lblSeccionDatos.ForeColor = colorTealSePrice;
            this.lblSeccionDatos.Location = new System.Drawing.Point(20, 15);
            this.lblSeccionDatos.Size = new System.Drawing.Size(220, 17);
            this.lblSeccionDatos.Text = "📄 NUEVA SOLICITUD MÉDICA";

            this.lblDniPaciente.AutoSize = true;
            this.lblDniPaciente.Font = fontLabels;
            this.lblDniPaciente.ForeColor = colorTextoOscuro;
            this.lblDniPaciente.Location = new System.Drawing.Point(20, 45);
            this.lblDniPaciente.Name = "lblDniPaciente";
            this.lblDniPaciente.Size = new System.Drawing.Size(109, 17);
            this.lblDniPaciente.Text = "DNI del paciente";

            this.txtDniPaciente.Font = fontControles;
            this.txtDniPaciente.Location = new System.Drawing.Point(20, 67);
            this.txtDniPaciente.Name = "txtDniPaciente";
            this.txtDniPaciente.Size = new System.Drawing.Size(160, 24);
            this.txtDniPaciente.TabIndex = 3;

            this.btnBuscarPaciente.BackColor = colorTealSePrice;
            this.btnBuscarPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarPaciente.FlatAppearance.BorderSize = 0;
            this.btnBuscarPaciente.Font = fontBotones;
            this.btnBuscarPaciente.ForeColor = System.Drawing.Color.White;
            this.btnBuscarPaciente.Location = new System.Drawing.Point(190, 66);
            this.btnBuscarPaciente.Name = "btnBuscarPaciente";
            this.btnBuscarPaciente.Size = new System.Drawing.Size(85, 26);
            this.btnBuscarPaciente.TabIndex = 4;
            this.btnBuscarPaciente.Text = "🔍 Buscar";
            this.btnBuscarPaciente.UseVisualStyleBackColor = false;
            this.btnBuscarPaciente.Click += new System.EventHandler(this.btnBuscarPaciente_Click);

            this.lblPaciente.AutoSize = true;
            this.lblPaciente.Font = fontLabels;
            this.lblPaciente.ForeColor = colorTextoOscuro;
            this.lblPaciente.Location = new System.Drawing.Point(295, 45);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Size = new System.Drawing.Size(59, 17);
            this.lblPaciente.Text = "Paciente";

            this.txtPaciente.Enabled = false;
            this.txtPaciente.Font = fontControles;
            this.txtPaciente.Location = new System.Drawing.Point(295, 67);
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.Size = new System.Drawing.Size(315, 24);
            this.txtPaciente.TabIndex = 6;

            this.lblTipoEstudio.AutoSize = true;
            this.lblTipoEstudio.Font = fontLabels;
            this.lblTipoEstudio.ForeColor = colorTextoOscuro;
            this.lblTipoEstudio.Location = new System.Drawing.Point(20, 110);
            this.lblTipoEstudio.Name = "lblTipoEstudio";
            this.lblTipoEstudio.Size = new System.Drawing.Size(102, 17);
            this.lblTipoEstudio.Text = "Tipo de estudio";

            this.cmbTipoEstudio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoEstudio.Font = fontControles;
            this.cmbTipoEstudio.FormattingEnabled = true;
            this.cmbTipoEstudio.Location = new System.Drawing.Point(20, 132);
            this.cmbTipoEstudio.Name = "cmbTipoEstudio";
            this.cmbTipoEstudio.Size = new System.Drawing.Size(255, 25);
            this.cmbTipoEstudio.TabIndex = 8;

            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Font = fontLabels;
            this.lblOrigen.ForeColor = colorTextoOscuro;
            this.lblOrigen.Location = new System.Drawing.Point(295, 110);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(49, 17);
            this.lblOrigen.Text = "Origen";

            this.cmbOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrigen.Font = fontControles;
            this.cmbOrigen.FormattingEnabled = true;
            this.cmbOrigen.Location = new System.Drawing.Point(295, 132);
            this.cmbOrigen.Name = "cmbOrigen";
            this.cmbOrigen.Size = new System.Drawing.Size(315, 25);
            this.cmbOrigen.TabIndex = 10;

            this.lblFechaSolicitud.AutoSize = true;
            this.lblFechaSolicitud.Font = fontLabels;
            this.lblFechaSolicitud.ForeColor = colorTextoOscuro;
            this.lblFechaSolicitud.Location = new System.Drawing.Point(20, 175);
            this.lblFechaSolicitud.Name = "lblFechaSolicitud";
            this.lblFechaSolicitud.Size = new System.Drawing.Size(116, 17);
            this.lblFechaSolicitud.Text = "Fecha de solicitud";

            this.dtpFechaSolicitud.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaSolicitud.Font = fontControles;
            this.dtpFechaSolicitud.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaSolicitud.Location = new System.Drawing.Point(20, 197);
            this.dtpFechaSolicitud.Name = "dtpFechaSolicitud";
            this.dtpFechaSolicitud.Size = new System.Drawing.Size(255, 24);
            this.dtpFechaSolicitud.TabIndex = 12;

            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Font = fontLabels;
            this.lblObservaciones.ForeColor = colorTextoOscuro;
            this.lblObservaciones.Location = new System.Drawing.Point(20, 240);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(95, 17);
            this.lblObservaciones.Text = "Observaciones";

            this.txtObservaciones.Font = fontControles;
            this.txtObservaciones.Location = new System.Drawing.Point(20, 262);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservaciones.Size = new System.Drawing.Size(590, 95);
            this.txtObservaciones.TabIndex = 14;

            this.btnCrear.BackColor = colorTealSePrice;
            this.btnCrear.FlatAppearance.BorderSize = 0;
            this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrear.Font = fontBotones;
            this.btnCrear.ForeColor = System.Drawing.Color.White;
            this.btnCrear.Location = new System.Drawing.Point(20, 380);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(590, 38);
            this.btnCrear.TabIndex = 15;
            this.btnCrear.Text = "🚀 Crear solicitud";
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);

            this.pnlFooter.BackColor = System.Drawing.Color.Transparent;
            this.pnlFooter.Controls.Add(this.btnLimpiar);
            this.pnlFooter.Controls.Add(this.btnCancelar);
            this.pnlFooter.Controls.Add(this.lblNota);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 550);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(680, 80);
            this.pnlFooter.TabIndex = 16;

            this.lblNota.BackColor = colorNotaFondo;
            this.lblNota.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular);
            this.lblNota.ForeColor = colorNotaTexto;
            this.lblNota.Location = new System.Drawing.Point(24, 12);
            this.lblNota.Name = "lblNota";
            this.lblNota.Padding = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this.lblNota.Size = new System.Drawing.Size(350, 55);
            this.lblNota.Text = "ℹ   Estado inicial sugerido: PENDIENTE. Asegúrese de validar la disponibilidad del tipo de estudio.";

            this.btnLimpiar.BackColor = System.Drawing.Color.White;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(200, 205, 210);
            this.btnLimpiar.Font = fontBotones;
            this.btnLimpiar.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.btnLimpiar.Location = new System.Drawing.Point(395, 22);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(110, 36);
            this.btnLimpiar.TabIndex = 16;
            this.btnLimpiar.Text = "✨ Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);

            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(200, 205, 210);
            this.btnCancelar.Font = fontBotones;
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.btnCancelar.Location = new System.Drawing.Point(515, 22);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(140, 36);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.Text = "🚪 Salir";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += (s, e) => { this.Close(); };

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = colorFondoGrisForm;
            this.ClientSize = new System.Drawing.Size(680, 610); 
            
            this.Controls.Add(this.pnlTarjetaContenedor);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlFooter);
            
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSolicitudEstudio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SePrice - Solicitar Estudio Médico";
            
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlTarjetaContenedor.ResumeLayout(false);
            this.pnlTarjetaContenedor.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}