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
            panelBotones = new Panel();
            btnConfirmarAsistencia = new Button();
            btnFacturarConsulta = new Button();
            btnSalir = new Button();
            panelHeader.SuspendLayout();
            panelBotones.SuspendLayout();
            SuspendLayout();

            panelHeader.BackColor = Color.FromArgb(0, 150, 136);
            panelHeader.Controls.Add(lblTitulo);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(450, 60);
            panelHeader.TabIndex = 0;

            lblTitulo.AutoSize = false;
            lblTitulo.Dock = DockStyle.Fill;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(450, 60);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Recepcionar Paciente - Consultorios Externos";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;

            panelBotones.Controls.Add(btnConfirmarAsistencia);
            panelBotones.Controls.Add(btnFacturarConsulta);
            panelBotones.Controls.Add(btnSalir);
            panelBotones.Dock = DockStyle.Fill;
            panelBotones.Location = new Point(0, 60);
            panelBotones.Name = "panelBotones";
            panelBotones.Size = new Size(450, 240);
            panelBotones.TabIndex = 1;

            btnConfirmarAsistencia.BackColor = Color.FromArgb(178, 235, 242);
            btnConfirmarAsistencia.Cursor = Cursors.Hand;
            btnConfirmarAsistencia.FlatAppearance.BorderColor = Color.FromArgb(0, 150, 136);
            btnConfirmarAsistencia.FlatAppearance.BorderSize = 2;
            btnConfirmarAsistencia.FlatStyle = FlatStyle.Flat;
            btnConfirmarAsistencia.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnConfirmarAsistencia.Location = new Point(77, 50);
            btnConfirmarAsistencia.Name = "btnConfirmarAsistencia";
            btnConfirmarAsistencia.Size = new Size(140, 140);
            btnConfirmarAsistencia.TabIndex = 0;
            btnConfirmarAsistencia.Text = "📋✓\n\nConfirmar\nAsistencia";
            btnConfirmarAsistencia.TextAlign = ContentAlignment.MiddleCenter;
            btnConfirmarAsistencia.UseVisualStyleBackColor = false;
            btnConfirmarAsistencia.Click += btnConfirmarAsistencia_Click;

            btnFacturarConsulta.BackColor = Color.FromArgb(178, 235, 242);
            btnFacturarConsulta.Cursor = Cursors.Hand;
            btnFacturarConsulta.FlatAppearance.BorderColor = Color.FromArgb(0, 150, 136);
            btnFacturarConsulta.FlatAppearance.BorderSize = 2;
            btnFacturarConsulta.FlatStyle = FlatStyle.Flat;
            btnFacturarConsulta.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnFacturarConsulta.Location = new Point(232, 50);
            btnFacturarConsulta.Name = "btnFacturarConsulta";
            btnFacturarConsulta.Size = new Size(140, 140);
            btnFacturarConsulta.TabIndex = 1;
            btnFacturarConsulta.Text = "💰\n\nFacturar\nConsulta";
            btnFacturarConsulta.TextAlign = ContentAlignment.MiddleCenter;
            btnFacturarConsulta.UseVisualStyleBackColor = false;
            btnFacturarConsulta.Click += btnFacturarConsulta_Click;

            btnSalir.BackColor = Color.FromArgb(178, 235, 242);
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.FlatAppearance.BorderColor = Color.FromArgb(0, 150, 136);
            btnSalir.FlatAppearance.BorderSize = 2;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSalir.Location = new Point(330, 205);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(100, 30);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(450, 300);
            ControlBox = false;
            Controls.Add(panelBotones);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormRecepcionarPaciente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Recepcionar paciente";
            panelHeader.ResumeLayout(false);
            panelBotones.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
    }
}
