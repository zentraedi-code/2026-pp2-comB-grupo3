namespace Seprise
{
    partial class FormConfirmarAsistencia
    {
        private System.ComponentModel.IContainer components = null;
        
        // Contenedores principales (Paneles y Tarjetas)
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlCardBuscar;
        private System.Windows.Forms.Panel pnlCardPaciente;
        private System.Windows.Forms.Panel pnlFooter;

        // Elementos de la Cabecera (Header)
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;

        // Elementos de Buscar Paciente
        private System.Windows.Forms.Label lblSeccionBuscar;
        private System.Windows.Forms.Label lblIndicacionBuscar;
        private System.Windows.Forms.Label lblDniPaciente;
        private System.Windows.Forms.TextBox txtDniPaciente;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btnBuscarPaciente;
        private System.Windows.Forms.Label lblEjemploDni;

        // Elementos del Detalle del Paciente
        private System.Windows.Forms.Label lblSeccionPaciente;
        private System.Windows.Forms.Panel pnlInfoPacienteBox;
        private System.Windows.Forms.Label lblPacientePlaceholder;
        private System.Windows.Forms.TextBox txtPaciente;

        // Resultados de búsqueda
        private System.Windows.Forms.Label lblMensajes;

        // Botón de Acción Principal
        private System.Windows.Forms.Button btnConfirmarAsistencia;

        // Barra Inferior (Footer)
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.Button btnSalir;

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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.pnlCardBuscar = new System.Windows.Forms.Panel();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblSeccionBuscar = new System.Windows.Forms.Label();
            this.lblIndicacionBuscar = new System.Windows.Forms.Label();
            this.lblDniPaciente = new System.Windows.Forms.Label();
            this.txtDniPaciente = new System.Windows.Forms.TextBox();
            this.btnBuscarPaciente = new System.Windows.Forms.Button();
            this.lblEjemploDni = new System.Windows.Forms.Label();
            this.pnlCardPaciente = new System.Windows.Forms.Panel();
            this.lblSeccionPaciente = new System.Windows.Forms.Label();
            this.pnlInfoPacienteBox = new System.Windows.Forms.Panel();
            this.txtPaciente = new System.Windows.Forms.TextBox();
            this.lblPacientePlaceholder = new System.Windows.Forms.Label();
            this.btnConfirmarAsistencia = new System.Windows.Forms.Button();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.lblNota = new System.Windows.Forms.Label();
            this.lblMensajes = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();

            this.pnlHeader.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            this.pnlCardBuscar.SuspendLayout();
            this.pnlCardPaciente.SuspendLayout();
            this.pnlInfoPacienteBox.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();

            // Colors setup (Paleta Azul institucional y fondos limpios)
            System.Drawing.Color azulPrincipal = System.Drawing.Color.FromArgb(0, 150, 136);
            System.Drawing.Color azulHover = System.Drawing.Color.FromArgb(21, 101, 192);
            System.Drawing.Color fondoGrisGris = System.Drawing.Color.FromArgb(248, 249, 250);
            System.Drawing.Color azulClaroBg = System.Drawing.Color.FromArgb(240, 244, 248);
            System.Drawing.Color bordeGris = System.Drawing.Color.FromArgb(230, 235, 240);
            System.Drawing.Color textoGris = System.Drawing.Color.FromArgb(100, 110, 120);

            // --- PNLHEADER (Cabecera Azul) ---
            this.pnlHeader.BackColor = azulPrincipal;
            this.pnlHeader.Controls.Add(this.lblSubtitulo);
            this.pnlHeader.Controls.Add(this.lblTitulo);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(700, 100);

            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(24, 20);
            this.lblTitulo.Text = "📅  CONFIRMAR ASISTENCIA DEL DÍA";

            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(220, 235, 252);
            this.lblSubtitulo.Location = new System.Drawing.Point(26, 58);
            this.lblSubtitulo.Text = "Registra la llegada del paciente al centro médico.";

            // --- PNLCARDBUSCAR (Módulo superior de búsqueda) ---
            this.pnlCardBuscar.BackColor = System.Drawing.Color.White;
            this.pnlCardBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pnlCardBuscar.Controls.Add(this.lblEjemploDni);
            this.pnlCardBuscar.Controls.Add(this.btnBuscarPaciente);
            this.pnlCardBuscar.Controls.Add(this.txtDniPaciente);
            this.pnlCardBuscar.Controls.Add(this.lblDniPaciente);
            this.pnlCardBuscar.Controls.Add(this.lblIndicacionBuscar);
            this.pnlCardBuscar.Controls.Add(this.lblSeccionBuscar);
            this.pnlCardBuscar.Location = new System.Drawing.Point(24, 120);
            this.pnlCardBuscar.Size = new System.Drawing.Size(650, 160);

            this.lblSeccionBuscar.AutoSize = true;
            this.lblSeccionBuscar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblSeccionBuscar.ForeColor = azulPrincipal;
            this.lblSeccionBuscar.Location = new System.Drawing.Point(16, 14);
            this.lblSeccionBuscar.Text = "👤 BUSCAR PACIENTE";

            this.lblIndicacionBuscar.Size = new System.Drawing.Size(430, 32);
            this.lblIndicacionBuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblIndicacionBuscar.ForeColor = System.Drawing.Color.FromArgb(50, 60, 70);
            this.lblIndicacionBuscar.Location = new System.Drawing.Point(16, 42);
            this.lblIndicacionBuscar.Text = "Ingresá el DNI del paciente para confirmar su asistencia.";

            this.lblDniPaciente.AutoSize = true;
            this.lblDniPaciente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDniPaciente.Location = new System.Drawing.Point(16, 75);
            this.lblDniPaciente.Text = "DNI del paciente";

            this.txtDniPaciente.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDniPaciente.Location = new System.Drawing.Point(18, 96);
            this.txtDniPaciente.Name = "txtDniPaciente";
            this.txtDniPaciente.PlaceholderText = "Ingresá el DNI del paciente";
            this.txtDniPaciente.Size = new System.Drawing.Size(430, 32);

            this.btnBuscarPaciente.BackColor = azulPrincipal;
            this.btnBuscarPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarPaciente.FlatAppearance.BorderSize = 0;
            this.btnBuscarPaciente.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnBuscarPaciente.ForeColor = System.Drawing.Color.White;
            this.btnBuscarPaciente.Location = new System.Drawing.Point(460, 93);
            this.btnBuscarPaciente.Size = new System.Drawing.Size(130, 32);
            this.btnBuscarPaciente.Text = "🔍 Buscar";
            this.btnBuscarPaciente.UseVisualStyleBackColor = true;
            this.btnBuscarPaciente.Click += new System.EventHandler(this.btnBuscarPaciente_Click);

            this.lblEjemploDni.AutoSize = true;
            this.lblEjemploDni.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblEjemploDni.ForeColor = textoGris;
            this.lblEjemploDni.Location = new System.Drawing.Point(16, 130);
            this.lblEjemploDni.Text = "Ejemplo: 12.345.678";

            // --- PNLCARDPACIENTE (Módulo inferior de resultados de paciente) ---
            this.pnlCardPaciente.BackColor = System.Drawing.Color.White;
            this.pnlCardPaciente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pnlCardPaciente.Controls.Add(this.pnlInfoPacienteBox);
            this.pnlCardPaciente.Controls.Add(this.lblSeccionPaciente);
            this.pnlCardPaciente.Location = new System.Drawing.Point(24, 295);
            this.pnlCardPaciente.Size = new System.Drawing.Size(650, 160);

            this.lblSeccionPaciente.AutoSize = true;
            this.lblSeccionPaciente.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblSeccionPaciente.ForeColor = azulPrincipal;
            this.lblSeccionPaciente.Location = new System.Drawing.Point(10, 14);
            this.lblSeccionPaciente.Text = "👥 PACIENTE";

            // Caja interior informativa blanca y de solo lectura
            this.pnlInfoPacienteBox.BackColor = System.Drawing.Color.White;
            this.pnlInfoPacienteBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pnlInfoPacienteBox.Controls.Add(this.txtPaciente);
            this.pnlInfoPacienteBox.Controls.Add(this.lblPacientePlaceholder);
            this.pnlInfoPacienteBox.Location = new System.Drawing.Point(14, 38);
            this.pnlInfoPacienteBox.Size = new System.Drawing.Size(650, 135);

            // txtPaciente (muestra nombre del paciente seleccionado)
            this.txtPaciente.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular);
            this.txtPaciente.ForeColor = azulPrincipal;
            this.txtPaciente.Location = new System.Drawing.Point(15, 0);
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.ReadOnly = true;
            this.txtPaciente.Enabled = false;
            this.txtPaciente.TabStop = false;
            this.txtPaciente.Multiline = true;
            this.txtPaciente.Size = new System.Drawing.Size(650, 135);
            this.txtPaciente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPaciente.Text = string.Empty;
            this.txtPaciente.BackColor = System.Drawing.Color.White;

            this.lblPacientePlaceholder.AutoSize = false;
            this.lblPacientePlaceholder.BringToFront();
            this.lblPacientePlaceholder.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular);
            this.lblPacientePlaceholder.ForeColor = textoGris;
            this.lblPacientePlaceholder.BackColor = System.Drawing.Color.Transparent;
            this.lblPacientePlaceholder.Location = new System.Drawing.Point(15, 6);
            this.lblPacientePlaceholder.Size = new System.Drawing.Size(770, 40);
            this.lblPacientePlaceholder.Text = "Los datos del paciente aparecerán aquí\nBuscá por DNI para ver la información del paciente.";
            this.lblPacientePlaceholder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // Botón Principal Confirmar Asistencia
            this.btnConfirmarAsistencia.BackColor = azulPrincipal;
            this.btnConfirmarAsistencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmarAsistencia.FlatAppearance.BorderSize = 0;
            this.btnConfirmarAsistencia.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnConfirmarAsistencia.ForeColor = System.Drawing.Color.White;
            this.btnConfirmarAsistencia.Location = new System.Drawing.Point(24, 465);
            this.btnConfirmarAsistencia.Size = new System.Drawing.Size(650, 45);
            this.btnConfirmarAsistencia.Text = "✔️  Confirmar asistencia del día";
            this.btnConfirmarAsistencia.UseVisualStyleBackColor = false;
            this.btnConfirmarAsistencia.Enabled = false;

            // --- PNLFOOTER (Barra inferior de acciones y notas) ---
            this.pnlFooter.BackColor = fondoGrisGris;
            this.pnlFooter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFooter.Controls.Add(this.btnSalir);
            this.pnlFooter.Controls.Add(this.lblNota);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 565);
            this.pnlFooter.Size = new System.Drawing.Size(700, 65);

            this.lblNota.AutoSize = true;
            this.lblNota.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNota.ForeColor = System.Drawing.Color.FromArgb(80, 90, 100);
            this.lblNota.Location = new System.Drawing.Point(24, 25);
            this.lblNota.Text = "🔒 Esta confirmación registrará la llegada del paciente en la fecha actual.";

            // lblMensajes (mensajes de estado en el footer)
            this.lblMensajes.AutoSize = false;
            this.lblMensajes.Location = new System.Drawing.Point(24, 45);
            this.lblMensajes.Name = "lblMensajes";
            this.lblMensajes.Size = new System.Drawing.Size(550, 15);
            this.lblMensajes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMensajes.ForeColor = azulPrincipal;
            this.lblMensajes.Text = string.Empty;
            this.pnlFooter.Controls.Add(this.lblMensajes);

            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(200, 210, 220);
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSalir.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.btnSalir.Location = new System.Drawing.Point(545, 15);
            this.btnSalir.Size = new System.Drawing.Size(125, 35);
            this.btnSalir.Text = "🚪 Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);

            // --- FORM CONFIGURATION ---
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(244, 246, 249);
            this.ClientSize = new System.Drawing.Size(700, 630);
            this.ControlBox = false;
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlCardPaciente);
            this.Controls.Add(this.pnlCardBuscar);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.btnConfirmarAsistencia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConfirmarAsistencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Confirmar Asistencia Médica del Día";
            
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            this.pnlCardBuscar.ResumeLayout(false);
            this.pnlCardBuscar.PerformLayout();
            this.pnlCardPaciente.ResumeLayout(false);
            this.pnlCardPaciente.PerformLayout();
            this.pnlInfoPacienteBox.ResumeLayout(false);
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}