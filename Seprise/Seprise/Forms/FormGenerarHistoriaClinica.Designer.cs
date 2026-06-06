namespace Seprise
{
    partial class FormGenerarHistoriaClinica
    {
        private System.ComponentModel.IContainer components = null;

        // Paneles contenedores y estructurales
        private System.Windows.Forms.Panel pnlHeader = null!;
        private System.Windows.Forms.Panel pnlDatosAtencion = null!;
        private System.Windows.Forms.Panel pnlMotivo = null!;
        private System.Windows.Forms.Panel pnlDiagnostico = null!;
        private System.Windows.Forms.Panel pnlIndicaciones = null!;
        private System.Windows.Forms.Panel pnlFooter;
        
        // Componentes de la interfaz
        private System.Windows.Forms.Label lblTitulo = null!;
        private System.Windows.Forms.Label lblSubtitulo = null!;
        
        private System.Windows.Forms.Label lblPaciente = null!;
        private System.Windows.Forms.TextBox txtDni = null!;
        private System.Windows.Forms.Button btnBuscarPaciente = null!;
        private System.Windows.Forms.Label lblMedico = null!;
        private System.Windows.Forms.ComboBox cmbMedicos = null!;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblMotivo = null!;
        private System.Windows.Forms.TextBox txtMotivo = null!;
        private System.Windows.Forms.Label lblDiagnostico = null!;
        private System.Windows.Forms.TextBox txtDiagnostico = null!;
        private System.Windows.Forms.Label lblIndicaciones = null!;
        private System.Windows.Forms.TextBox txtIndicaciones = null!;
        private System.Windows.Forms.Label lblDatosAtencion = null!;
        
        private System.Windows.Forms.Button btnGuardar = null!;

        // Nuevos componentes para mostrar los datos del paciente (Estilo Alerta Celeste)
        private System.Windows.Forms.Panel pnlInfoPacienteCard = null!;
        private System.Windows.Forms.Label lblDatosPacienteInfo = null!;
        
        // Componente de Nota institucional (Estilo Alerta Verde)
        private System.Windows.Forms.Label lblNota = null!;

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
            
            this.pnlDatosAtencion = new System.Windows.Forms.Panel();
            this.lblDatosAtencion = new System.Windows.Forms.Label();
            this.lblPaciente = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.btnBuscarPaciente = new System.Windows.Forms.Button();
            this.lblMedico = new System.Windows.Forms.Label();
            this.cmbMedicos = new System.Windows.Forms.ComboBox();
            this.pnlInfoPacienteCard = new System.Windows.Forms.Panel();
            this.lblDatosPacienteInfo = new System.Windows.Forms.Label();
            
            this.pnlMotivo = new System.Windows.Forms.Panel();
            this.lblMotivo = new System.Windows.Forms.Label();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            
            this.pnlDiagnostico = new System.Windows.Forms.Panel();
            this.lblDiagnostico = new System.Windows.Forms.Label();
            this.txtDiagnostico = new System.Windows.Forms.TextBox();
            
            this.pnlIndicaciones = new System.Windows.Forms.Panel();
            this.lblIndicaciones = new System.Windows.Forms.Label();
            this.txtIndicaciones = new System.Windows.Forms.TextBox();
            
            this.btnGuardar = new System.Windows.Forms.Button();
            
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.lblNota = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();

            this.pnlHeader.SuspendLayout();
            this.pnlDatosAtencion.SuspendLayout();
            this.pnlInfoPacienteCard.SuspendLayout();
            this.pnlMotivo.SuspendLayout();
            this.pnlDiagnostico.SuspendLayout();
            this.pnlIndicaciones.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();

            // =================================================================
            // pnlHeader (Franja Superior)
            // =================================================================
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(0, 150, 136);
            this.pnlHeader.Controls.Add(this.lblTitulo);
            this.pnlHeader.Controls.Add(this.lblSubtitulo);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(900, 100);
            this.pnlHeader.TabIndex = 0;

            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(24, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Text = "📋 GENERAR HISTORIA CLÍNICA";

            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(225, 245, 254);
            this.lblSubtitulo.Location = new System.Drawing.Point(26, 58);
            this.lblSubtitulo.Text = "El médico atiende al paciente, registra la historia clínica y finaliza la atención.";

            // =================================================================
            // pnlDatosAtencion (Agrupador: Datos de la Atención)
            // =================================================================
            this.pnlDatosAtencion.BackColor = System.Drawing.Color.White;
            this.pnlDatosAtencion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pnlDatosAtencion.Controls.Add(this.lblDatosAtencion);
            this.pnlDatosAtencion.Controls.Add(this.lblPaciente);
            this.pnlDatosAtencion.Controls.Add(this.txtDni);
            this.pnlDatosAtencion.Controls.Add(this.btnBuscarPaciente);
            this.pnlDatosAtencion.Controls.Add(this.lblMedico);
            this.pnlDatosAtencion.Controls.Add(this.cmbMedicos);
            this.pnlDatosAtencion.Controls.Add(this.pnlInfoPacienteCard);
            this.pnlDatosAtencion.Location = new System.Drawing.Point(24, 120);
            this.pnlDatosAtencion.Name = "pnlDatosAtencion";
            this.pnlDatosAtencion.Size = new System.Drawing.Size(857, 165);
            this.pnlDatosAtencion.TabIndex = 1;

            this.lblDatosAtencion.AutoSize = true;
            this.lblDatosAtencion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDatosAtencion.ForeColor = System.Drawing.Color.FromArgb(0, 150, 136);
            this.lblDatosAtencion.Location = new System.Drawing.Point(16, 12);
            this.lblDatosAtencion.Text = "👤 DATOS DE LA ATENCIÓN";

            this.lblPaciente.AutoSize = true;
            this.lblPaciente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPaciente.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
            this.lblPaciente.Location = new System.Drawing.Point(16, 34);
            this.lblPaciente.Text = "Paciente";

            this.txtDni.BackColor = System.Drawing.Color.White;
            this.txtDni.Location = new System.Drawing.Point(16, 53);
            this.txtDni.Name = "txtDni";
            this.txtDni.PlaceholderText = "Ingresá el DNI del paciente";
            this.txtDni.Size = new System.Drawing.Size(280, 23);

            this.btnBuscarPaciente.BackColor = System.Drawing.Color.FromArgb(0, 150, 136);
            this.btnBuscarPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarPaciente.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnBuscarPaciente.ForeColor = System.Drawing.Color.White;
            this.btnBuscarPaciente.Location = new System.Drawing.Point(310, 52);
            this.btnBuscarPaciente.Name = "btnBuscarPaciente";
            this.btnBuscarPaciente.Size = new System.Drawing.Size(80, 25);
            this.btnBuscarPaciente.Text = "🔍 Buscar";
            this.btnBuscarPaciente.UseVisualStyleBackColor = false;
            this.btnBuscarPaciente.Click += new System.EventHandler(this.btnBuscarPaciente_Click);

            this.lblMedico.AutoSize = true;
            this.lblMedico.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMedico.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
            this.lblMedico.Location = new System.Drawing.Point(447, 34);
            this.lblMedico.Text = "Médico";

            this.cmbMedicos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMedicos.Location = new System.Drawing.Point(450, 53);
            this.cmbMedicos.Name = "cmbMedicos";
            this.cmbMedicos.Size = new System.Drawing.Size(280, 23);
            this.cmbMedicos.SelectedIndexChanged += new System.EventHandler(this.cmbMedicos_SelectedIndexChanged);

            // Tarjeta Alerta Celeste de Información del Paciente
            this.pnlInfoPacienteCard.BackColor = System.Drawing.Color.FromArgb(235, 243, 255);
            this.pnlInfoPacienteCard.Controls.Add(this.lblDatosPacienteInfo);
            this.pnlInfoPacienteCard.Location = new System.Drawing.Point(16, 92);
            this.pnlInfoPacienteCard.Name = "pnlInfoPacienteCard";
            this.pnlInfoPacienteCard.Size = new System.Drawing.Size(814, 58);
            this.pnlInfoPacienteCard.TabIndex = 6;

            this.lblDatosPacienteInfo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblDatosPacienteInfo.ForeColor = System.Drawing.Color.FromArgb(0, 130, 115);
            this.lblDatosPacienteInfo.Location = new System.Drawing.Point(12, 8);
            this.lblDatosPacienteInfo.Name = "lblDatosPacienteInfo";
            this.lblDatosPacienteInfo.Size = new System.Drawing.Size(690, 42);
            this.lblDatosPacienteInfo.Text = "Los datos del paciente aparecerán aquí\r\nBuscá por DNI para ver la información del paciente.";

            // =================================================================
            // pnlMotivo (Agrupador: Motivo de consulta)
            // =================================================================
            this.pnlMotivo.BackColor = System.Drawing.Color.White;
            this.pnlMotivo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pnlMotivo.Controls.Add(this.lblMotivo);
            this.pnlMotivo.Controls.Add(this.txtMotivo);
            this.pnlMotivo.Location = new System.Drawing.Point(24, 300);
            this.pnlMotivo.Name = "pnlMotivo";
            this.pnlMotivo.Size = new System.Drawing.Size(857, 95);
            this.pnlMotivo.TabIndex = 2;

            this.lblMotivo.AutoSize = true;
            this.lblMotivo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMotivo.ForeColor = System.Drawing.Color.FromArgb(0, 150, 136);
            this.lblMotivo.Location = new System.Drawing.Point(16, 12);
            this.lblMotivo.Text = "💬 MOTIVO DE CONSULTA";

            this.txtMotivo.Location = new System.Drawing.Point(16, 35);
            this.txtMotivo.Multiline = true;
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.PlaceholderText = "Describe el motivo de consulta...";
            this.txtMotivo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMotivo.Size = new System.Drawing.Size(800, 50);

            // =================================================================
            // pnlDiagnostico (Agrupador: Diagnóstico / Evolución)
            // =================================================================
            this.pnlDiagnostico.BackColor = System.Drawing.Color.White;
            this.pnlDiagnostico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pnlDiagnostico.Controls.Add(this.lblDiagnostico);
            this.pnlDiagnostico.Controls.Add(this.txtDiagnostico);
            this.pnlDiagnostico.Location = new System.Drawing.Point(24, 410);
            this.pnlDiagnostico.Name = "pnlDiagnostico";
            this.pnlDiagnostico.Size = new System.Drawing.Size(857, 95);
            this.pnlDiagnostico.TabIndex = 3;

            this.lblDiagnostico.AutoSize = true;
            this.lblDiagnostico.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDiagnostico.ForeColor = System.Drawing.Color.FromArgb(0, 150, 136);
            this.lblDiagnostico.Location = new System.Drawing.Point(16, 12);
            this.lblDiagnostico.Text = "🩺 DIAGNÓSTICO / EVOLUCIÓN";

            this.txtDiagnostico.Location = new System.Drawing.Point(16, 35);
            this.txtDiagnostico.Multiline = true;
            this.txtDiagnostico.Name = "txtDiagnostico";
            this.txtDiagnostico.PlaceholderText = "Carga de historia clínica...";
            this.txtDiagnostico.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDiagnostico.Size = new System.Drawing.Size(800, 50);

            // =================================================================
            // pnlIndicaciones (Agrupador: Indicaciones)
            // =================================================================
            this.pnlIndicaciones.BackColor = System.Drawing.Color.White;
            this.pnlIndicaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pnlIndicaciones.Controls.Add(this.lblIndicaciones);
            this.pnlIndicaciones.Controls.Add(this.txtIndicaciones);
            this.pnlIndicaciones.Location = new System.Drawing.Point(24, 520);
            this.pnlIndicaciones.Name = "pnlIndicaciones";
            this.pnlIndicaciones.Size = new System.Drawing.Size(857, 99);
            this.pnlIndicaciones.TabIndex = 4;

            this.lblIndicaciones.AutoSize = true;
            this.lblIndicaciones.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblIndicaciones.ForeColor = System.Drawing.Color.FromArgb(0, 150, 136);
            this.lblIndicaciones.Location = new System.Drawing.Point(16, 12);
            this.lblIndicaciones.Text = "💊 INDICACIONES";

            this.txtIndicaciones.Location = new System.Drawing.Point(16, 35);
            this.txtIndicaciones.Multiline = true;
            this.txtIndicaciones.Name = "txtIndicaciones";
            this.txtIndicaciones.PlaceholderText = "Tratamiento, recomendaciones o medicación...";
            this.txtIndicaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtIndicaciones.Size = new System.Drawing.Size(800, 50);

            // =================================================================
            // Botones de Acción
            // =================================================================
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(0, 150, 136);
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(24, 628);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(857, 45);
            this.btnGuardar.Text = "💾 Guardar historia y finalizar atención";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);

            // =================================================================
            // pnlFooter (Estructura Unificada con Alerta Verde SEPRISE)
            // =================================================================
            this.pnlFooter.BackColor = System.Drawing.Color.FromArgb(238, 242, 245);
            this.pnlFooter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pnlFooter.Controls.Add(this.btnSalir);
            this.pnlFooter.Controls.Add(this.lblNota);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 645); // Ajustado para un calce perfecto
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(900, 80);
            this.pnlFooter.TabIndex = 5;

            // lblNota (Fondo VERDE pastel institucional con presencia real)
            this.lblNota.BackColor = System.Drawing.Color.FromArgb(198, 234, 212);
            this.lblNota.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblNota.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular);
            this.lblNota.ForeColor = System.Drawing.Color.FromArgb(0, 75, 68);
            this.lblNota.Location = new System.Drawing.Point(24, 15);
            this.lblNota.Name = "lblNota";
            this.lblNota.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.lblNota.Size = new System.Drawing.Size(700, 70);
            this.lblNota.Text = "ℹ   El sistema actualizará automáticamente el estado del turno del paciente de Recepcionado a Atendido, liberando la  disponibilidad del médico y registrando la fecha y hora de cierre de la consulta.";

            // btnSalir 
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(210, 210, 210);
            this.btnSalir.FlatAppearance.BorderSize = 1;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSalir.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.btnSalir.Location = new System.Drawing.Point(752, 22);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(125, 35);
            this.btnSalir.Text = "🚪 Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);

            // =================================================================
            // FormGenerarHistoriaClinica Estructura Base
            // =================================================================
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(240, 244, 248);
            this.ClientSize = new System.Drawing.Size(900, 745); // Incrementado levemente de 745 a 765 para que pnlFooter (80px) luzca perfecto
            
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.pnlIndicaciones);
            this.Controls.Add(this.pnlDiagnostico);
            this.Controls.Add(this.pnlMotivo);
            this.Controls.Add(this.pnlDatosAtencion);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlFooter);
            
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormGenerarHistoriaClinica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Generar Historia Clínica";

            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlDatosAtencion.ResumeLayout(false);
            this.pnlDatosAtencion.PerformLayout();
            this.pnlInfoPacienteCard.ResumeLayout(false);
            this.pnlMotivo.ResumeLayout(false);
            this.pnlMotivo.PerformLayout();
            this.pnlDiagnostico.ResumeLayout(false);
            this.pnlDiagnostico.PerformLayout();
            this.pnlIndicaciones.ResumeLayout(false);
            this.pnlIndicaciones.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}