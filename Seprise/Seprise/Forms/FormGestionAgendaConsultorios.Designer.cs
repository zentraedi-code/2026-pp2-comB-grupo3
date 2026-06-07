using System.Drawing;
using System.Windows.Forms;

namespace Seprise
{
    partial class FormGestionAgendaConsultorios
    {
        private System.ComponentModel.IContainer components = null;

        private Panel panelHeader;
        private Label lblTitulo;
        private Panel panelBotones;
        private Button btnCrearAgenda;
        private Button btnConfirmarAgenda;
        private Button btnCancelarAgenda;
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
            btnCrearAgenda = new Button();
            btnConfirmarAgenda = new Button();
            btnCancelarAgenda = new Button();
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
            lblIconoHeader.Text = "🏥";

            lblTitulo.AutoSize = true;
            lblTitulo.Font = fontTitulo;
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(80, 12);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(490, 32);
            lblTitulo.Text = "Gestión de Agenda - Consultorios Externos";

            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = fontSubtitulo;
            lblSubtitulo.ForeColor = colorTextoGrisClaro;
            lblSubtitulo.Location = new Point(80, 46);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(500, 15);
            lblSubtitulo.Text = "Administre la disponibilidad horaria, confirmaciones y cancelaciones de turnos para consultas médicas generales.";

            panelBotones.BackColor = Color.Transparent;
            panelBotones.Controls.Add(btnCrearAgenda);
            panelBotones.Controls.Add(btnConfirmarAgenda);
            panelBotones.Controls.Add(btnCancelarAgenda);
            panelBotones.Dock = DockStyle.Fill;
            panelBotones.Location = new Point(0, 75);
            panelBotones.Name = "panelBotones";
            panelBotones.Size = new Size(990, 205);
            panelBotones.TabIndex = 1;

            btnCrearAgenda.BackColor = Color.White;
            btnCrearAgenda.Cursor = Cursors.Hand;
            btnCrearAgenda.FlatAppearance.BorderColor = Color.FromArgb(220, 224, 227);
            btnCrearAgenda.FlatAppearance.BorderSize = 1;
            btnCrearAgenda.FlatStyle = FlatStyle.Flat;
            btnCrearAgenda.Location = new Point(35, 15);
            btnCrearAgenda.Name = "btnCrearAgenda";
            btnCrearAgenda.Size = new Size(285, 85);
            btnCrearAgenda.TabIndex = 0;
            btnCrearAgenda.UseVisualStyleBackColor = false;
            btnCrearAgenda.Click += btnCrearAgenda_Click;
            btnCrearAgenda.Paint += (s, e) => {
                Graphics g = e.Graphics;
                int centroX = btnCrearAgenda.Width / 2;
                using (Brush darkBrush = new SolidBrush(colorTextoOscuro))
                using (Brush grayBrush = new SolidBrush(Color.Gray)) {
                    g.DrawString("Crear Agenda", fontBotonesTitulo, darkBrush, centroX, 40, formatoCentrado);
                    g.DrawString("Defina nuevos bloques de atención\ny horarios para los consultorios.", fontBotonesDesc, grayBrush, centroX, 68, formatoCentrado);
                }
            };

            btnConfirmarAgenda.BackColor = Color.White;
            btnConfirmarAgenda.Cursor = Cursors.Hand;
            btnConfirmarAgenda.FlatAppearance.BorderColor = Color.FromArgb(220, 224, 227);
            btnConfirmarAgenda.FlatAppearance.BorderSize = 1;
            btnConfirmarAgenda.FlatStyle = FlatStyle.Flat;
            btnConfirmarAgenda.Location = new Point(352, 15);
            btnConfirmarAgenda.Name = "btnConfirmarAgenda";
            btnConfirmarAgenda.Size = new Size(285, 85);
            btnConfirmarAgenda.TabIndex = 1;
            btnConfirmarAgenda.UseVisualStyleBackColor = false;
            btnConfirmarAgenda.Click += btnConfirmarAgenda_Click;
            btnConfirmarAgenda.Paint += (s, e) => {
                Graphics g = e.Graphics;
                int centroX = btnConfirmarAgenda.Width / 2;
                using (Brush darkBrush = new SolidBrush(colorTextoOscuro))
                using (Brush grayBrush = new SolidBrush(Color.Gray)) {
                    g.DrawString("Confirmar Agenda", fontBotonesTitulo, darkBrush, centroX, 40, formatoCentrado);
                    g.DrawString("Establezca de manera firme las\nfechas de atención médica aprobadas.", fontBotonesDesc, grayBrush, centroX, 68, formatoCentrado);
                }
            };

            btnCancelarAgenda.BackColor = Color.White;
            btnCancelarAgenda.Cursor = Cursors.Hand;
            btnCancelarAgenda.FlatAppearance.BorderColor = Color.FromArgb(220, 224, 227);
            btnCancelarAgenda.FlatAppearance.BorderSize = 1;
            btnCancelarAgenda.FlatStyle = FlatStyle.Flat;
            btnCancelarAgenda.Location = new Point(670, 15);
            btnCancelarAgenda.Name = "btnCancelarAgenda";
            btnCancelarAgenda.Size = new Size(285, 85);
            btnCancelarAgenda.TabIndex = 2;
            btnCancelarAgenda.UseVisualStyleBackColor = false;
            btnCancelarAgenda.Click += btnCancelarAgenda_Click;
            btnCancelarAgenda.Paint += (s, e) => {
                Graphics g = e.Graphics;
                int centroX = btnCancelarAgenda.Width / 2;
                using (Brush darkBrush = new SolidBrush(colorTextoOscuro))
                using (Brush grayBrush = new SolidBrush(Color.Gray)) {
                    g.DrawString("Cancelar Agenda", fontBotonesTitulo, darkBrush, centroX, 40, formatoCentrado);
                    g.DrawString("Efectúe la baja de turnos o días\nde atención por licencia o imprevistos.", fontBotonesDesc, grayBrush, centroX, 68, formatoCentrado);
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
            lblNotaFooter.Text = "ℹ   Cualquier modificación estructural en las agendas de consultorios impactará directamente en la cartilla de turnos web y la asignación telefónica de los pacientes.";

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
            Name = "FormGestionAgendaConsultorios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SePrice - Panel de Gestión de Agenda de Consultorios";

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