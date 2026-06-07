using System.Drawing;
using System.Windows.Forms;

namespace Seprise
{
    partial class FormGestionMedicos
    {
        private System.ComponentModel.IContainer components = null;
        
        private Panel panelHeader;
        private Label lblTitulo;
        private Panel panelBotones;
        private Button btnABMMedicos;
        private Button btnLiquidarHonorarios;
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
            btnABMMedicos = new Button();
            btnLiquidarHonorarios = new Button();
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
            panelHeader.Size = new Size(680, 75);
            panelHeader.TabIndex = 0;

            lblIconoHeader.AutoSize = true;
            lblIconoHeader.Font = new Font("Segoe UI", 22F);
            lblIconoHeader.ForeColor = Color.White;
            lblIconoHeader.Location = new Point(20, 16);
            lblIconoHeader.Text = "👨‍⚕️";

            lblTitulo.AutoSize = true;
            lblTitulo.Font = fontTitulo;
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(80, 12);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(240, 32);
            lblTitulo.Text = "Gestión de Médicos";

            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = fontSubtitulo;
            lblSubtitulo.ForeColor = colorTextoGrisClaro;
            lblSubtitulo.Location = new Point(80, 46);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(450, 15);
            lblSubtitulo.Text = "Seleccione la acción administrativa o de liquidación que desea realizar sobre el plantel profesional.";

            panelBotones.BackColor = Color.Transparent;
            panelBotones.Controls.Add(btnABMMedicos);
            panelBotones.Controls.Add(btnLiquidarHonorarios);
            panelBotones.Dock = DockStyle.Fill;
            panelBotones.Location = new Point(0, 75);
            panelBotones.Name = "panelBotones";
            panelBotones.Size = new Size(680, 205);
            panelBotones.TabIndex = 1;

            btnABMMedicos.BackColor = Color.White;
            btnABMMedicos.Cursor = Cursors.Hand;
            btnABMMedicos.FlatAppearance.BorderColor = Color.FromArgb(220, 224, 227);
            btnABMMedicos.FlatAppearance.BorderSize = 1;
            btnABMMedicos.FlatStyle = FlatStyle.Flat;
            btnABMMedicos.Location = new Point(35, 15);
            btnABMMedicos.Name = "btnABMMedicos";
            btnABMMedicos.Size = new Size(285, 85);
            btnABMMedicos.TabIndex = 0;
            btnABMMedicos.UseVisualStyleBackColor = false;
            btnABMMedicos.Click += btnABMMedicos_Click;
            btnABMMedicos.Paint += (s, e) => {
                Graphics g = e.Graphics;
                int centroX = btnABMMedicos.Width / 2;
                using (Brush darkBrush = new SolidBrush(colorTextoOscuro))
                using (Brush grayBrush = new SolidBrush(Color.Gray)) {
                    g.DrawString("Gestión de Médicos", fontBotonesTitulo, darkBrush, centroX, 40, formatoCentrado);
                    g.DrawString("Administre los datos básicos\ny especialidades del personal.", fontBotonesDesc, grayBrush, centroX, 68, formatoCentrado);
                }
            };

            btnLiquidarHonorarios.BackColor = Color.White;
            btnLiquidarHonorarios.Cursor = Cursors.Hand;
            btnLiquidarHonorarios.FlatAppearance.BorderColor = Color.FromArgb(220, 224, 227);
            btnLiquidarHonorarios.FlatAppearance.BorderSize = 1;
            btnLiquidarHonorarios.FlatStyle = FlatStyle.Flat;
            btnLiquidarHonorarios.Location = new Point(360, 15);
            btnLiquidarHonorarios.Name = "btnLiquidarHonorarios";
            btnLiquidarHonorarios.Size = new Size(285, 85);
            btnLiquidarHonorarios.TabIndex = 1;
            btnLiquidarHonorarios.UseVisualStyleBackColor = false;
            btnLiquidarHonorarios.Click += btnLiquidarHonorarios_Click;
            btnLiquidarHonorarios.Paint += (s, e) => {
                Graphics g = e.Graphics;
                int centroX = btnLiquidarHonorarios.Width / 2;
                using (Brush darkBrush = new SolidBrush(colorTextoOscuro))
                using (Brush grayBrush = new SolidBrush(Color.Gray)) {
                    g.DrawString("Liquidar Honorarios", fontBotonesTitulo, darkBrush, centroX, 40, formatoCentrado);
                    g.DrawString("Calcule y procese las liquidaciones\nde los profesionales médicos.", fontBotonesDesc, grayBrush, centroX, 68, formatoCentrado);
                }
            };

            pnlFooter.BackColor = Color.Transparent;
            pnlFooter.Controls.Add(lblNotaFooter);
            pnlFooter.Controls.Add(btnSalir);
            pnlFooter.Dock = DockStyle.Bottom;
            pnlFooter.Location = new Point(0, 220); 
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new Size(680, 80);
            pnlFooter.TabIndex = 2;

            lblNotaFooter.BackColor = colorNotaFondo;
            lblNotaFooter.Font = fontNota;
            lblNotaFooter.ForeColor = colorNotaTexto;
            lblNotaFooter.Location = new Point(35, 12);
            lblNotaFooter.Name = "lblNotaFooter";
            lblNotaFooter.Padding = new Padding(10, 6, 10, 6);
            lblNotaFooter.Size = new Size(450, 55);
            lblNotaFooter.Text = "ℹ   Recuerde que los cambios en las especialidades o el registro de nuevos profesionales alterarán directamente los coeficientes de liquidación del mes corriente.";

            btnSalir.BackColor = Color.White;
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.FlatAppearance.BorderColor = Color.FromArgb(200, 205, 210);
            btnSalir.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnSalir.ForeColor = Color.FromArgb(100, 100, 100);
            btnSalir.Location = new Point(515, 21);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(130, 36);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "🚪 Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = colorFondoGrisForm;
            ClientSize = new Size(680, 300); 
            ControlBox = false;
            Controls.Add(panelBotones);
            Controls.Add(panelHeader);
            Controls.Add(pnlFooter);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormGestionMedicos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SePrice - Panel de Gestión Médica";
            
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