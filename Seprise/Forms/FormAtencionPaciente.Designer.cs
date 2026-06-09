using System.Drawing;
using System.Windows.Forms;

namespace Seprise
{
    partial class FormAtencionPaciente
    {
        private System.ComponentModel.IContainer components = null;

        private Panel panelHeader;
        private Label lblTitulo;
        private Panel panelBotones;
        private Button btnRevisarPacientesPendientes;
        private Button btnGenerarHistoriaClinica;
        private Button btnSolicitarEstudios;
        private Button btnSalir;

        private Label lblSubtitulo;
        private Label lblIconoHeader;
        private Panel pnlFooter;
        private Label lblNotaFooter;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panelHeader = new Panel();
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            lblIconoHeader = new Label();
            panelBotones = new Panel();
            btnRevisarPacientesPendientes = new Button();
            btnGenerarHistoriaClinica = new Button();
            btnSolicitarEstudios = new Button();
            pnlFooter = new Panel();
            lblNotaFooter = new Label();
            btnSalir = new Button();

            panelHeader.SuspendLayout();
            panelBotones.SuspendLayout();
            pnlFooter.SuspendLayout();
            SuspendLayout();

            var colorTealSePrice = Color.FromArgb(0, 150, 136);
            var colorTextoOscuro = Color.FromArgb(33, 33, 33);
            var colorTextoGrisClaro = Color.FromArgb(220, 240, 235);
            var colorFondoGrisForm = Color.FromArgb(238, 242, 243);
            var colorNotaFondo = Color.FromArgb(198, 234, 212);
            var colorNotaTexto = Color.FromArgb(0, 75, 68);

            var fontTitulo = new Font("Segoe UI", 18F, FontStyle.Bold);
            var fontSubtitulo = new Font("Segoe UI", 9F, FontStyle.Regular);
            var fontBotonesTitulo = new Font("Segoe UI", 11F, FontStyle.Bold);
            var fontBotonesDesc = new Font("Segoe UI", 8.5F, FontStyle.Regular);
            var fontNota = new Font("Segoe UI", 8.5F, FontStyle.Regular);

            StringFormat formatoCentrado = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            panelHeader.BackColor = colorTealSePrice;
            panelHeader.Controls.Add(lblIconoHeader);
            panelHeader.Controls.Add(lblTitulo);
            panelHeader.Controls.Add(lblSubtitulo);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(990, 75);
            panelHeader.TabIndex = 0;

            lblIconoHeader.AutoSize = true;
            lblIconoHeader.Font = new Font("Segoe UI", 22F);
            lblIconoHeader.ForeColor = Color.White;
            lblIconoHeader.Location = new Point(20, 16);
            lblIconoHeader.Text = "🩺";

            lblTitulo.AutoSize = true;
            lblTitulo.Font = fontTitulo;
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(80, 12);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(410, 32);
            lblTitulo.Text = "Atención de Pacientes en Consultorio";

            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = fontSubtitulo;
            lblSubtitulo.ForeColor = colorTextoGrisClaro;
            lblSubtitulo.Location = new Point(80, 46);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(540, 15);
            lblSubtitulo.Text = "Gestione el flujo de pacientes en espera, el registro de evoluciones clínicas y la solicitud de exámenes complementarios.";

            panelBotones.BackColor = Color.Transparent;
            panelBotones.Controls.Add(btnRevisarPacientesPendientes);
            panelBotones.Controls.Add(btnGenerarHistoriaClinica);
            panelBotones.Controls.Add(btnSolicitarEstudios);
            panelBotones.Dock = DockStyle.Fill;
            panelBotones.Location = new Point(0, 75);
            panelBotones.Name = "panelBotones";
            panelBotones.Size = new Size(990, 205);
            panelBotones.TabIndex = 1;

            btnRevisarPacientesPendientes.BackColor = Color.White;
            btnRevisarPacientesPendientes.Cursor = Cursors.Hand;
            btnRevisarPacientesPendientes.FlatAppearance.BorderColor = Color.FromArgb(220, 224, 227);
            btnRevisarPacientesPendientes.FlatAppearance.BorderSize = 1;
            btnRevisarPacientesPendientes.FlatStyle = FlatStyle.Flat;
            btnRevisarPacientesPendientes.Location = new Point(35, 15);
            btnRevisarPacientesPendientes.Name = "btnRevisarPacientesPendientes";
            btnRevisarPacientesPendientes.Size = new Size(285, 85);
            btnRevisarPacientesPendientes.TabIndex = 0;
            btnRevisarPacientesPendientes.UseVisualStyleBackColor = false;
            btnRevisarPacientesPendientes.Click += btnRevisarPacientesPendientes_Click;
            btnRevisarPacientesPendientes.Paint += (s, e) => {
                Graphics g = e.Graphics;
                int centroX = btnRevisarPacientesPendientes.Width / 2;
                using (Brush darkBrush = new SolidBrush(colorTextoOscuro))
                using (Brush grayBrush = new SolidBrush(Color.Gray)) {
                    g.DrawString("Pacientes Pendientes", fontBotonesTitulo, darkBrush, centroX, 40, formatoCentrado);
                    g.DrawString("Visualice la sala de espera virtual\ny llame al siguiente paciente en fila.", fontBotonesDesc, grayBrush, centroX, 68, formatoCentrado);
                }
            };

            btnGenerarHistoriaClinica.BackColor = Color.White;
            btnGenerarHistoriaClinica.Cursor = Cursors.Hand;
            btnGenerarHistoriaClinica.FlatAppearance.BorderColor = Color.FromArgb(220, 224, 227);
            btnGenerarHistoriaClinica.FlatAppearance.BorderSize = 1;
            btnGenerarHistoriaClinica.FlatStyle = FlatStyle.Flat;
            btnGenerarHistoriaClinica.Location = new Point(352, 15);
            btnGenerarHistoriaClinica.Name = "btnGenerarHistoriaClinica";
            btnGenerarHistoriaClinica.Size = new Size(285, 85);
            btnGenerarHistoriaClinica.TabIndex = 1;
            btnGenerarHistoriaClinica.UseVisualStyleBackColor = false;
            btnGenerarHistoriaClinica.Click += btnGenerarHistoriaClinica_Click;
            btnGenerarHistoriaClinica.Paint += (s, e) => {
                Graphics g = e.Graphics;
                int centroX = btnGenerarHistoriaClinica.Width / 2;
                using (Brush darkBrush = new SolidBrush(colorTextoOscuro))
                using (Brush grayBrush = new SolidBrush(Color.Gray)) {
                    g.DrawString("Generar Historia", fontBotonesTitulo, darkBrush, centroX, 40, formatoCentrado);
                    g.DrawString("Registre la anamnesis, el examen físico\ny las indicaciones médicas del encuentro.", fontBotonesDesc, grayBrush, centroX, 68, formatoCentrado);
                }
            };

            btnSolicitarEstudios.BackColor = Color.White;
            btnSolicitarEstudios.Cursor = Cursors.Hand;
            btnSolicitarEstudios.FlatAppearance.BorderColor = Color.FromArgb(220, 224, 227);
            btnSolicitarEstudios.FlatAppearance.BorderSize = 1;
            btnSolicitarEstudios.FlatStyle = FlatStyle.Flat;
            btnSolicitarEstudios.Location = new Point(670, 15);
            btnSolicitarEstudios.Name = "btnSolicitarEstudios";
            btnSolicitarEstudios.Size = new Size(285, 85);
            btnSolicitarEstudios.TabIndex = 2;
            btnSolicitarEstudios.UseVisualStyleBackColor = false;
            btnSolicitarEstudios.Click += btnSolicitarEstudios_Click;
            btnSolicitarEstudios.Paint += (s, e) => {
                Graphics g = e.Graphics;
                int centroX = btnSolicitarEstudios.Width / 2;
                using (Brush darkBrush = new SolidBrush(colorTextoOscuro))
                using (Brush grayBrush = new SolidBrush(Color.Gray)) {
                    g.DrawString("Solicitar Estudios", fontBotonesTitulo, darkBrush, centroX, 40, formatoCentrado);
                    g.DrawString("Prescriba órdenes de laboratorio,\nimágenes o prácticas de alta complejidad.", fontBotonesDesc, grayBrush, centroX, 68, formatoCentrado);
                }
            };

            pnlFooter.BackColor = Color.Transparent;
            pnlFooter.Controls.Add(lblNotaFooter);
            pnlFooter.Controls.Add(btnSalir);
            pnlFooter.Dock = DockStyle.Bottom;
            pnlFooter.Location = new Point(0, 220);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new Size(990, 80);
            pnlFooter.TabIndex = 2;

            lblNotaFooter.BackColor = colorNotaFondo;
            lblNotaFooter.Font = fontNota;
            lblNotaFooter.ForeColor = colorNotaTexto;
            lblNotaFooter.Location = new Point(35, 12);
            lblNotaFooter.Name = "lblNotaFooter";
            lblNotaFooter.Padding = new Padding(10, 6, 10, 6);
            lblNotaFooter.Size = new Size(740, 55);
            lblNotaFooter.Text = "ℹ   Toda la información volcada en la consulta médica reviste carácter de declaración jurada y quedará vinculada de forma permanente al registro histórico del paciente.";

            btnSalir.BackColor = Color.White;
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.FlatAppearance.BorderColor = Color.FromArgb(200, 205, 210);
            btnSalir.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnSalir.ForeColor = Color.FromArgb(100, 100, 100);
            btnSalir.Location = new Point(825, 21);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(130, 36);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "🚪 Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = colorFondoGrisForm;
            ClientSize = new Size(990, 300);
            ControlBox = false;
            Controls.Add(panelBotones);
            Controls.Add(panelHeader);
            Controls.Add(pnlFooter);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAtencionPaciente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SePrice - Panel de Atención Médica de Pacientes";

            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelBotones.ResumeLayout(false);
            pnlFooter.ResumeLayout(false);
            pnlFooter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
    }
}