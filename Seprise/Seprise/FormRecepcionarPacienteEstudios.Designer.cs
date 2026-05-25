using System.Drawing;
using System.Windows.Forms;

namespace Seprise
{
    partial class FormRecepcionarPacienteEstudios
    {
        private System.ComponentModel.IContainer components = null;
        private Panel panelHeader;
        private Label lblTitulo;
        private Panel panelBotones;
        private Button btnConfirmarAsistencia;
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
            btnSalir = new Button();
            panelHeader.SuspendLayout();
            panelBotones.SuspendLayout();
            SuspendLayout();

            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(0, 150, 136);
            panelHeader.Controls.Add(lblTitulo);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(450, 60);
            panelHeader.TabIndex = 0;

            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = false;
            lblTitulo.Dock = DockStyle.Fill;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(450, 60);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Recepcionar Paciente - Estudios Clínicos";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;

            // 
            // panelBotones
            // 
            panelBotones.Controls.Add(btnConfirmarAsistencia);
            panelBotones.Controls.Add(btnSalir);
            panelBotones.Dock = DockStyle.Fill;
            panelBotones.Location = new Point(0, 60);
            panelBotones.Name = "panelBotones";
            panelBotones.Size = new Size(450, 240);
            panelBotones.TabIndex = 1;

            // 
            // btnConfirmarAsistencia
            // 
            btnConfirmarAsistencia.BackColor = Color.FromArgb(178, 235, 242);
            btnConfirmarAsistencia.Cursor = Cursors.Hand;
            btnConfirmarAsistencia.FlatAppearance.BorderColor = Color.FromArgb(0, 150, 136);
            btnConfirmarAsistencia.FlatAppearance.BorderSize = 2;
            btnConfirmarAsistencia.FlatStyle = FlatStyle.Flat;
            btnConfirmarAsistencia.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnConfirmarAsistencia.Location = new Point(155, 50);
            btnConfirmarAsistencia.Name = "btnConfirmarAsistencia";
            btnConfirmarAsistencia.Size = new Size(140, 140);
            btnConfirmarAsistencia.TabIndex = 0;
            btnConfirmarAsistencia.Text = "📋✓\n\nConfirmar\nAsistencia";
            btnConfirmarAsistencia.TextAlign = ContentAlignment.MiddleCenter;
            btnConfirmarAsistencia.UseVisualStyleBackColor = false;
            btnConfirmarAsistencia.Click += btnConfirmarAsistencia_Click;

            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(178, 235, 242);
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.FlatAppearance.BorderColor = Color.FromArgb(0, 150, 136);
            btnSalir.FlatAppearance.BorderSize = 2;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSalir.Location = new Point(390, 210);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(50, 25);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;

            // 
            // FormRecepcionarPacienteEstudios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 300);
            Controls.Add(panelBotones);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormRecepcionarPacienteEstudios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Recepcionar Paciente - Estudios Clínicos";
            ControlBox = false;
            panelHeader.ResumeLayout(false);
            panelBotones.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
    }
}
