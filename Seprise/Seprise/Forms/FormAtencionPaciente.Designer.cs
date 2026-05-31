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
            btnRevisarPacientesPendientes = new Button();
            btnGenerarHistoriaClinica = new Button();
            btnSolicitarEstudios = new Button();
            btnSalir = new Button();
            panelHeader.SuspendLayout();
            panelBotones.SuspendLayout();
            SuspendLayout();

            panelHeader.BackColor = Color.FromArgb(0, 150, 136);
            panelHeader.Controls.Add(lblTitulo);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(520, 60);
            panelHeader.TabIndex = 0;

            lblTitulo.AutoSize = false;
            lblTitulo.Dock = DockStyle.Fill;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(520, 60);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Atención paciente";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;

            panelBotones.Controls.Add(btnRevisarPacientesPendientes);
            panelBotones.Controls.Add(btnGenerarHistoriaClinica);
            panelBotones.Controls.Add(btnSolicitarEstudios);
            panelBotones.Controls.Add(btnSalir);
            panelBotones.Dock = DockStyle.Fill;
            panelBotones.Location = new Point(0, 60);
            panelBotones.Name = "panelBotones";
            panelBotones.Size = new Size(520, 240);
            panelBotones.TabIndex = 1;

            btnRevisarPacientesPendientes.BackColor = Color.FromArgb(178, 235, 242);
            btnRevisarPacientesPendientes.Cursor = Cursors.Hand;
            btnRevisarPacientesPendientes.FlatAppearance.BorderColor = Color.FromArgb(0, 150, 136);
            btnRevisarPacientesPendientes.FlatAppearance.BorderSize = 2;
            btnRevisarPacientesPendientes.FlatStyle = FlatStyle.Flat;
            btnRevisarPacientesPendientes.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRevisarPacientesPendientes.Location = new Point(35, 50);
            btnRevisarPacientesPendientes.Name = "btnRevisarPacientesPendientes";
            btnRevisarPacientesPendientes.Size = new Size(140, 140);
            btnRevisarPacientesPendientes.TabIndex = 0;
            btnRevisarPacientesPendientes.Text = "📋👥\n\nPacientes\nPendientes";
            btnRevisarPacientesPendientes.TextAlign = ContentAlignment.MiddleCenter;
            btnRevisarPacientesPendientes.UseVisualStyleBackColor = false;
            btnRevisarPacientesPendientes.Click += btnRevisarPacientesPendientes_Click;

            btnGenerarHistoriaClinica.BackColor = Color.FromArgb(178, 235, 242);
            btnGenerarHistoriaClinica.Cursor = Cursors.Hand;
            btnGenerarHistoriaClinica.FlatAppearance.BorderColor = Color.FromArgb(0, 150, 136);
            btnGenerarHistoriaClinica.FlatAppearance.BorderSize = 2;
            btnGenerarHistoriaClinica.FlatStyle = FlatStyle.Flat;
            btnGenerarHistoriaClinica.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGenerarHistoriaClinica.Location = new Point(190, 50);
            btnGenerarHistoriaClinica.Name = "btnGenerarHistoriaClinica";
            btnGenerarHistoriaClinica.Size = new Size(140, 140);
            btnGenerarHistoriaClinica.TabIndex = 1;
            btnGenerarHistoriaClinica.Text = "📝🏥\n\nGenerar\nHistoria";
            btnGenerarHistoriaClinica.TextAlign = ContentAlignment.MiddleCenter;
            btnGenerarHistoriaClinica.UseVisualStyleBackColor = false;
            btnGenerarHistoriaClinica.Click += btnGenerarHistoriaClinica_Click;

            btnSolicitarEstudios.BackColor = Color.FromArgb(178, 235, 242);
            btnSolicitarEstudios.Cursor = Cursors.Hand;
            btnSolicitarEstudios.FlatAppearance.BorderColor = Color.FromArgb(0, 150, 136);
            btnSolicitarEstudios.FlatAppearance.BorderSize = 2;
            btnSolicitarEstudios.FlatStyle = FlatStyle.Flat;
            btnSolicitarEstudios.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSolicitarEstudios.Location = new Point(345, 50);
            btnSolicitarEstudios.Name = "btnSolicitarEstudios";
            btnSolicitarEstudios.Size = new Size(140, 140);
            btnSolicitarEstudios.TabIndex = 2;
            btnSolicitarEstudios.Text = "🔬📋\n\nSolicitar\nEstudios";
            btnSolicitarEstudios.TextAlign = ContentAlignment.MiddleCenter;
            btnSolicitarEstudios.UseVisualStyleBackColor = false;
            btnSolicitarEstudios.Click += btnSolicitarEstudios_Click;

            btnSalir.BackColor = Color.FromArgb(178, 235, 242);
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.FlatAppearance.BorderColor = Color.FromArgb(0, 150, 136);
            btnSalir.FlatAppearance.BorderSize = 2;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSalir.Location = new Point(400, 205);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(100, 30);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 250, 250);
            ClientSize = new Size(520, 300);
            ControlBox = false;
            Controls.Add(panelBotones);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAtencionPaciente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Atención paciente";
            panelHeader.ResumeLayout(false);
            panelBotones.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
    }
}
