using System.Drawing;
using System.Windows.Forms;

namespace Seprise
{
    partial class FormRecepcionarPacienteConsultorios
    {
        private System.ComponentModel.IContainer components = null;

        private Panel panelHeader;
        private Label lblTitulo;
        private Panel panelBotones;
        private Button btnConfirmarAsistencia;
        private Button btnFacturarConsulta;
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
            btnConfirmarAsistencia = new Button();
            btnFacturarConsulta = new Button();
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
            panelHeader.Size = new Size(690, 75);
            panelHeader.TabIndex = 0;

            lblIconoHeader.AutoSize = true;
            lblIconoHeader.Font = new Font("Segoe UI", 22F);
            lblIconoHeader.ForeColor = Color.White;
            lblIconoHeader.Location = new Point(20, 16);
            lblIconoHeader.Text = "👤";

            lblTitulo.AutoSize = true;
            lblTitulo.Font = fontTitulo;
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(80, 12);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(505, 32);
            lblTitulo.Text = "Recepcionar Paciente - Consultorios Externos";

            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = fontSubtitulo;
            lblSubtitulo.ForeColor = colorTextoGrisClaro;
            lblSubtitulo.Location = new Point(80, 46);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(495, 15);
            lblSubtitulo.Text = "Registre la llegada del paciente a la institución y proceda con la facturación de la prestación médica.";

            panelBotones.BackColor = Color.Transparent;
            panelBotones.Controls.Add(btnConfirmarAsistencia);
            panelBotones.Controls.Add(btnFacturarConsulta);
            panelBotones.Dock = DockStyle.Fill;
            panelBotones.Location = new Point(0, 75);
            panelBotones.Name = "panelBotones";
            panelBotones.Size = new Size(690, 205);
            panelBotones.TabIndex = 1;

            btnConfirmarAsistencia.BackColor = Color.White;
            btnConfirmarAsistencia.Cursor = Cursors.Hand;
            btnConfirmarAsistencia.FlatAppearance.BorderColor = Color.FromArgb(220, 224, 227);
            btnConfirmarAsistencia.FlatAppearance.BorderSize = 1;
            btnConfirmarAsistencia.FlatStyle = FlatStyle.Flat;
            btnConfirmarAsistencia.Location = new Point(35, 15);
            btnConfirmarAsistencia.Name = "btnConfirmarAsistencia";
            btnConfirmarAsistencia.Size = new Size(285, 85);
            btnConfirmarAsistencia.TabIndex = 0;
            btnConfirmarAsistencia.UseVisualStyleBackColor = false;
            btnConfirmarAsistencia.Click += btnConfirmarAsistencia_Click;
            btnConfirmarAsistencia.Paint += (s, e) => {
                Graphics g = e.Graphics;
                int centroX = btnConfirmarAsistencia.Width / 2;
                using (Brush darkBrush = new SolidBrush(colorTextoOscuro))
                using (Brush grayBrush = new SolidBrush(Color.Gray)) {
                    g.DrawString("Confirmar Asistencia", fontBotonesTitulo, darkBrush, centroX, 40, formatoCentrado);
                    g.DrawString("Acredite la presencia del paciente en\nsala de espera para el llamado del médico.", fontBotonesDesc, grayBrush, centroX, 68, formatoCentrado);
                }
            };

            btnFacturarConsulta.BackColor = Color.White;
            btnFacturarConsulta.Cursor = Cursors.Hand;
            btnFacturarConsulta.FlatAppearance.BorderColor = Color.FromArgb(220, 224, 227);
            btnFacturarConsulta.FlatAppearance.BorderSize = 1;
            btnFacturarConsulta.FlatStyle = FlatStyle.Flat;
            btnFacturarConsulta.Location = new Point(370, 15);
            btnFacturarConsulta.Name = "btnFacturarConsulta";
            btnFacturarConsulta.Size = new Size(285, 85);
            btnFacturarConsulta.TabIndex = 1;
            btnFacturarConsulta.UseVisualStyleBackColor = false;
            btnFacturarConsulta.Click += btnFacturarConsulta_Click;
            btnFacturarConsulta.Paint += (s, e) => {
                Graphics g = e.Graphics;
                int centroX = btnFacturarConsulta.Width / 2;
                using (Brush darkBrush = new SolidBrush(colorTextoOscuro))
                using (Brush grayBrush = new SolidBrush(Color.Gray)) {
                    g.DrawString("Facturar Consulta", fontBotonesTitulo, darkBrush, centroX, 40, formatoCentrado);
                    g.DrawString("Gestione el cobro de coseguros o la\nvalidación del bono de la obra social.", fontBotonesDesc, grayBrush, centroX, 68, formatoCentrado);
                }
            };

            pnlFooter.BackColor = Color.Transparent;
            pnlFooter.Controls.Add(lblNotaFooter);
            pnlFooter.Controls.Add(btnSalir);
            pnlFooter.Dock = DockStyle.Bottom;
            pnlFooter.Location = new Point(0, 220);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new Size(690, 80);
            pnlFooter.TabIndex = 2;

            lblNotaFooter.BackColor = colorNotaFondo;
            lblNotaFooter.Font = fontNota;
            lblNotaFooter.ForeColor = colorNotaTexto;
            lblNotaFooter.Location = new Point(35, 12);
            lblNotaFooter.Name = "lblNotaFooter";
            lblNotaFooter.Padding = new Padding(10, 6, 10, 6);
            lblNotaFooter.Size = new Size(485, 55);
            lblNotaFooter.Text = "ℹ   Recuerde verificar la vigencia de la credencial física o digital del paciente y validar el estado de cobertura activo antes de confirmar el turno.";

            btnSalir.BackColor = Color.White;
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.FlatAppearance.BorderColor = Color.FromArgb(200, 205, 210);
            btnSalir.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnSalir.ForeColor = Color.FromArgb(100, 100, 100);
            btnSalir.Location = new Point(540, 21);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(115, 36);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "🚪 Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = colorFondoGrisForm;
            ClientSize = new Size(690, 300);
            ControlBox = false;
            Controls.Add(panelBotones);
            Controls.Add(panelHeader);
            Controls.Add(pnlFooter);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormRecepcionarPacienteConsultorios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SePrice - Control de Recepción de Pacientes";

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