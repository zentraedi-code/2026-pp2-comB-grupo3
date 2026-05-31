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
            btnABMMedicos = new Button();
            btnLiquidarHonorarios = new Button();
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
            lblTitulo.Text = "Gestión Médicos";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;

            panelBotones.Controls.Add(btnABMMedicos);
            panelBotones.Controls.Add(btnLiquidarHonorarios);
            panelBotones.Controls.Add(btnSalir);
            panelBotones.Dock = DockStyle.Fill;
            panelBotones.Location = new Point(0, 60);
            panelBotones.Name = "panelBotones";
            panelBotones.Size = new Size(450, 240);
            panelBotones.TabIndex = 1;

            btnABMMedicos.BackColor = Color.FromArgb(178, 235, 242);
            btnABMMedicos.Cursor = Cursors.Hand;
            btnABMMedicos.FlatAppearance.BorderColor = Color.FromArgb(0, 150, 136);
            btnABMMedicos.FlatAppearance.BorderSize = 2;
            btnABMMedicos.FlatStyle = FlatStyle.Flat;
            btnABMMedicos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnABMMedicos.Location = new Point(77, 50);
            btnABMMedicos.Name = "btnABMMedicos";
            btnABMMedicos.Size = new Size(140, 140);
            btnABMMedicos.TabIndex = 0;
            btnABMMedicos.Text = "👨‍⚕️📋\n\nABM\nMédicos";
            btnABMMedicos.TextAlign = ContentAlignment.MiddleCenter;
            btnABMMedicos.UseVisualStyleBackColor = false;
            btnABMMedicos.Click += btnABMMedicos_Click;

            btnLiquidarHonorarios.BackColor = Color.FromArgb(178, 235, 242);
            btnLiquidarHonorarios.Cursor = Cursors.Hand;
            btnLiquidarHonorarios.FlatAppearance.BorderColor = Color.FromArgb(0, 150, 136);
            btnLiquidarHonorarios.FlatAppearance.BorderSize = 2;
            btnLiquidarHonorarios.FlatStyle = FlatStyle.Flat;
            btnLiquidarHonorarios.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLiquidarHonorarios.Location = new Point(232, 50);
            btnLiquidarHonorarios.Name = "btnLiquidarHonorarios";
            btnLiquidarHonorarios.Size = new Size(140, 140);
            btnLiquidarHonorarios.TabIndex = 1;
            btnLiquidarHonorarios.Text = "💰📊\n\nLiquidar\nHonorarios";
            btnLiquidarHonorarios.TextAlign = ContentAlignment.MiddleCenter;
            btnLiquidarHonorarios.UseVisualStyleBackColor = false;
            btnLiquidarHonorarios.Click += btnLiquidarHonorarios_Click;

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
            Name = "FormGestionMedicos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión Médicos";
            panelHeader.ResumeLayout(false);
            panelBotones.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
    }
}
