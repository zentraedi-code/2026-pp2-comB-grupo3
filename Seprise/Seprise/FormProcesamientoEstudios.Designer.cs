using System.Drawing;
using System.Windows.Forms;

namespace Seprise
{
    partial class FormProcesamientoEstudios
    {
        private System.ComponentModel.IContainer components = null;
        private Panel panelHeader;
        private Label lblTitulo;
        private Panel panelBotones;
        private Button btnFinalizarEstudio;
        private Button btnGenerarInforme;
        private Button btnEntregarEstudio;
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
            btnFinalizarEstudio = new Button();
            btnGenerarInforme = new Button();
            btnEntregarEstudio = new Button();
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
            panelHeader.Size = new Size(520, 60);
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
            lblTitulo.Size = new Size(520, 60);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Procesamiento de Estudios";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;

            // 
            // panelBotones
            // 
            panelBotones.Controls.Add(btnFinalizarEstudio);
            panelBotones.Controls.Add(btnGenerarInforme);
            panelBotones.Controls.Add(btnEntregarEstudio);
            panelBotones.Controls.Add(btnSalir);
            panelBotones.Dock = DockStyle.Fill;
            panelBotones.Location = new Point(0, 60);
            panelBotones.Name = "panelBotones";
            panelBotones.Size = new Size(520, 240);
            panelBotones.TabIndex = 1;

            // 
            // btnFinalizarEstudio
            // 
            btnFinalizarEstudio.BackColor = Color.FromArgb(178, 235, 242);
            btnFinalizarEstudio.Cursor = Cursors.Hand;
            btnFinalizarEstudio.FlatAppearance.BorderColor = Color.FromArgb(0, 150, 136);
            btnFinalizarEstudio.FlatAppearance.BorderSize = 2;
            btnFinalizarEstudio.FlatStyle = FlatStyle.Flat;
            btnFinalizarEstudio.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnFinalizarEstudio.Location = new Point(20, 50);
            btnFinalizarEstudio.Name = "btnFinalizarEstudio";
            btnFinalizarEstudio.Size = new Size(140, 140);
            btnFinalizarEstudio.TabIndex = 0;
            btnFinalizarEstudio.Text = "✅\n\nFinalizar\nEstudio";
            btnFinalizarEstudio.TextAlign = ContentAlignment.MiddleCenter;
            btnFinalizarEstudio.UseVisualStyleBackColor = false;
            btnFinalizarEstudio.Click += btnFinalizarEstudio_Click;

            // 
            // btnGenerarInforme
            // 
            btnGenerarInforme.BackColor = Color.FromArgb(178, 235, 242);
            btnGenerarInforme.Cursor = Cursors.Hand;
            btnGenerarInforme.FlatAppearance.BorderColor = Color.FromArgb(0, 150, 136);
            btnGenerarInforme.FlatAppearance.BorderSize = 2;
            btnGenerarInforme.FlatStyle = FlatStyle.Flat;
            btnGenerarInforme.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGenerarInforme.Location = new Point(190, 50);
            btnGenerarInforme.Name = "btnGenerarInforme";
            btnGenerarInforme.Size = new Size(140, 140);
            btnGenerarInforme.TabIndex = 1;
            btnGenerarInforme.Text = "📄\n\nGenerar\nInforme";
            btnGenerarInforme.TextAlign = ContentAlignment.MiddleCenter;
            btnGenerarInforme.UseVisualStyleBackColor = false;
            btnGenerarInforme.Click += btnGenerarInforme_Click;

            // 
            // btnEntregarEstudio
            // 
            btnEntregarEstudio.BackColor = Color.FromArgb(178, 235, 242);
            btnEntregarEstudio.Cursor = Cursors.Hand;
            btnEntregarEstudio.FlatAppearance.BorderColor = Color.FromArgb(0, 150, 136);
            btnEntregarEstudio.FlatAppearance.BorderSize = 2;
            btnEntregarEstudio.FlatStyle = FlatStyle.Flat;
            btnEntregarEstudio.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEntregarEstudio.Location = new Point(360, 50);
            btnEntregarEstudio.Name = "btnEntregarEstudio";
            btnEntregarEstudio.Size = new Size(140, 140);
            btnEntregarEstudio.TabIndex = 2;
            btnEntregarEstudio.Text = "📦\n\nEntregar\nEstudio";
            btnEntregarEstudio.TextAlign = ContentAlignment.MiddleCenter;
            btnEntregarEstudio.UseVisualStyleBackColor = false;
            btnEntregarEstudio.Click += btnEntregarEstudio_Click;

            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(178, 235, 242);
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.FlatAppearance.BorderColor = Color.FromArgb(0, 150, 136);
            btnSalir.FlatAppearance.BorderSize = 2;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSalir.Location = new Point(460, 210);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(50, 25);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;

            // 
            // FormProcesamientoEstudios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 300);
            Controls.Add(panelBotones);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormProcesamientoEstudios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Procesamiento de Estudios";
            ControlBox = false;
            panelHeader.ResumeLayout(false);
            panelBotones.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
    }
}
