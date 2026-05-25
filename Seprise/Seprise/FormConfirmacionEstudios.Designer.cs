using System.Drawing;
using System.Windows.Forms;

namespace Seprise
{
    partial class FormConfirmacionEstudios
    {
        private System.ComponentModel.IContainer components = null;
        private Panel panelHeader;
        private Label lblTitulo;
        private Panel panelBotones;
        private Button btnConfirmarSolicitud;
        private Button btnFacturarEstudio;
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
            btnConfirmarSolicitud = new Button();
            btnFacturarEstudio = new Button();
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
            lblTitulo.Text = "Confirmación de Estudios";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;

            // 
            // panelBotones
            // 
            panelBotones.Controls.Add(btnConfirmarSolicitud);
            panelBotones.Controls.Add(btnFacturarEstudio);
            panelBotones.Controls.Add(btnSalir);
            panelBotones.Dock = DockStyle.Fill;
            panelBotones.Location = new Point(0, 60);
            panelBotones.Name = "panelBotones";
            panelBotones.Size = new Size(450, 240);
            panelBotones.TabIndex = 1;

            // 
            // btnConfirmarSolicitud
            // 
            btnConfirmarSolicitud.BackColor = Color.FromArgb(178, 235, 242);
            btnConfirmarSolicitud.Cursor = Cursors.Hand;
            btnConfirmarSolicitud.FlatAppearance.BorderColor = Color.FromArgb(0, 150, 136);
            btnConfirmarSolicitud.FlatAppearance.BorderSize = 2;
            btnConfirmarSolicitud.FlatStyle = FlatStyle.Flat;
            btnConfirmarSolicitud.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnConfirmarSolicitud.Location = new Point(77, 50);
            btnConfirmarSolicitud.Name = "btnConfirmarSolicitud";
            btnConfirmarSolicitud.Size = new Size(140, 140);
            btnConfirmarSolicitud.TabIndex = 0;
            btnConfirmarSolicitud.Text = "✅\n\nConfirmar\nSolicitud";
            btnConfirmarSolicitud.TextAlign = ContentAlignment.MiddleCenter;
            btnConfirmarSolicitud.UseVisualStyleBackColor = false;
            btnConfirmarSolicitud.Click += btnConfirmarSolicitud_Click;

            // 
            // btnFacturarEstudio
            // 
            btnFacturarEstudio.BackColor = Color.FromArgb(178, 235, 242);
            btnFacturarEstudio.Cursor = Cursors.Hand;
            btnFacturarEstudio.FlatAppearance.BorderColor = Color.FromArgb(0, 150, 136);
            btnFacturarEstudio.FlatAppearance.BorderSize = 2;
            btnFacturarEstudio.FlatStyle = FlatStyle.Flat;
            btnFacturarEstudio.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnFacturarEstudio.Location = new Point(233, 50);
            btnFacturarEstudio.Name = "btnFacturarEstudio";
            btnFacturarEstudio.Size = new Size(140, 140);
            btnFacturarEstudio.TabIndex = 1;
            btnFacturarEstudio.Text = "💵\n\nFacturar\nEstudio";
            btnFacturarEstudio.TextAlign = ContentAlignment.MiddleCenter;
            btnFacturarEstudio.UseVisualStyleBackColor = false;
            btnFacturarEstudio.Click += btnFacturarEstudio_Click;

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
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;

            // 
            // FormConfirmacionEstudios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 300);
            Controls.Add(panelBotones);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormConfirmacionEstudios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Confirmación de Estudios";
            ControlBox = false;
            panelHeader.ResumeLayout(false);
            panelBotones.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
    }
}
